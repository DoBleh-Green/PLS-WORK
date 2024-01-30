Imports MySql.Data.MySqlClient

Public Class create
    Dim CS As String = "server=localhost;user=root;password=;database=db_vb_proj;allow user variables=true"
    Dim c As New MySqlConnection(CS)
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub tbEditName_TextChanged(sender As Object, e As EventArgs) Handles stokC.TextChanged

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            c.Open()
            Dim query As String = "INSERT INTO barang(nama_barang,stok,harga_barang) VALUES(@NB,@ST,@HG)"
            Dim cmd As New MySqlCommand(query, c)

            cmd.Parameters.AddWithValue("@NB", usernameC.Text)
            cmd.Parameters.AddWithValue("@ST", stokC.Text)
            cmd.Parameters.AddWithValue("@HG", hargaC.Text)

            cmd.ExecuteNonQuery()
            MsgBox("berhasil insert")
        Catch ex As Exception
            MsgBox("gagal insert:" & ex.Message)
        Finally
            c.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        CrudBarang.Show()
    End Sub
End Class