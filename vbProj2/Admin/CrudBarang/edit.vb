Imports MySql.Data.MySqlClient

Public Class edit
    Dim CS As String = "server=localhost;user=root;password=;database=db_vb_proj;allow user variables=true"
    Dim c As New MySqlConnection(CS)
    Private Sub edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadbarang()
    End Sub
    Private Sub loadbarang()
        Dim query As String = "SELECT * FROM barang"
        Dim data As New MySqlDataAdapter(query, c)
        Dim table As New DataTable()
        data.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim slctd As Integer = CInt(DataGridView1.SelectedRows(0).Cells(0).Value)
                Dim query As String = "UPDATE barang SET nama_barang=@NB,harga_barang=@HG,stok=@ST WHERE id_barang=@id"
                Dim cmd As New MySqlCommand(query, c)
                cmd.Parameters.AddWithValue("@NB", tbEditNamaBarang.Text)
                cmd.Parameters.AddWithValue("@HG", tbEditharga.Text)
                cmd.Parameters.AddWithValue("@ST", tbEditstok.Text)
                cmd.Parameters.AddWithValue("@id", slctd)

                c.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Update Success")
                loadbarang()

            Else
                MsgBox("Tolong Pilih Data Untuk Di Edit")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            c.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim slctd As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            Dim query As String = "SELECT * FROM barang WHERE Id_barang = @id"

            Using cmd As New MySqlCommand(query, c)
                cmd.Parameters.AddWithValue("@id", slctd)

                Try
                    c.Open()
                    Dim rd As MySqlDataReader = cmd.ExecuteReader()

                    If rd.Read() Then
                        tbEditNamaBarang.Text = rd("nama_barang").ToString()
                        tbEditharga.Text = rd("harga_barang").ToString()
                        tbEditstok.Text = rd("stok").ToString()

                    End If

                Catch ex As Exception
                    MsgBox("error: " & ex.Message)
                Finally
                    c.Close()
                End Try
            End Using
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        CrudBarang.Show()
    End Sub
End Class