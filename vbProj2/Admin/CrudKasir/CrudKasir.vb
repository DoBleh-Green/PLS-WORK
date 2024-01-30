Imports MySql.Data.MySqlClient

Public Class CrudKasir
    Dim CS As String = "server=localhost;user=root;password=;database=db_vb_proj;allow user variables=true"
    Dim c As New MySqlConnection(CS)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        AdminPage.Show()
    End Sub

    Private Sub loadakun()
        Dim query As String = "SELECT * FROM users WHERE role = 'kasir' "
        Dim akun As New MySqlDataAdapter(query, c)
        Dim table As New DataTable()
        akun.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Private Sub CrudKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadakun()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        EditKasir.Showw()

    End Sub



    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        loadakun()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim slctd As Integer = CInt(DataGridView1.SelectedRows(0).Cells(0).Value)
            Dim rs As DialogResult = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If System.Windows.Forms.DialogResult.Yes Then
                Try
                    Dim query As String = "DELETE FROM users WHERE Id_user=@id"
                    Dim cmd As New MySqlCommand(query, c)
                    cmd.Parameters.AddWithValue("@id", slctd)

                    c.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("BErhasil mengahpus data")
                    loadakun()
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
        Me.Close()
        create.Show()
    End Sub
End Class