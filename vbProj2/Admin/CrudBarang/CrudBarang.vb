Imports MySql.Data.MySqlClient

Public Class CrudBarang
    Dim CS As String = "server=localhost;user=root;password=;database=db_vb_proj;allow user variables=true"
    Dim c As New MySqlConnection(CS)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        AdminPage.Show()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub loadbarang()
        Dim query As String = "SELECT * FROM barang"
        Dim barang As New MySqlDataAdapter(query, c)
        Dim table As New DataTable()
        barang.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Private Sub CrudBarang_load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadbarang()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim slctd As Integer = CInt(DataGridView1.SelectedRows(0).Cells(0).Value)
            Dim rs As DialogResult = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If System.Windows.Forms.DialogResult.Yes Then
                Try
                    Dim query As String = "DELETE FROM barang WHERE Id_barang=@id"
                    Dim cmd As New MySqlCommand(query, c)
                    cmd.Parameters.AddWithValue("@id", slctd)

                    c.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("BErhasil mengahpus data")
                    loadbarang()
                Catch ex As Exception
                    MsgBox("Error deleting data: " & ex.Message, MsgBoxStyle.Critical)
                Finally
                    c.Close()
                End Try
            End If
        Else
            MsgBox("Pilih Rows yang ingin dihapus")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        create.Show()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        loadbarang()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        edit.Show()
        Me.Hide()
    End Sub
End Class