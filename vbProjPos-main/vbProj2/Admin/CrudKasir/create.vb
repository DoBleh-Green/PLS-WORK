Imports MySql.Data.MySqlClient

Public Class CreateBarang
    Dim CS As String = "server=localhost;user=root;password=;database=db_vb_proj;allow user variables=true"
    Dim c As New MySqlConnection(CS)
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            c.Open()
            Dim query As String = "INSERT INTO users (username,name,password,role) VALUES(@UM,@NM,@PW,@RL)"
            Dim cmd As New MySqlCommand(query, c)

            cmd.Parameters.AddWithValue("@UM", tbEditUsername.Text)
            cmd.Parameters.AddWithValue("@PW", tbEditPassword.Text)
            cmd.Parameters.AddWithValue("@NM", tbEditName.Text)
            cmd.Parameters.AddWithValue("@RL", cbEditRole.Text)
            cmd.ExecuteNonQuery()
            MsgBox("berhasil insert")
        Catch ex As Exception
            MsgBox("error:" & ex.Message)
        Finally
            c.Close()
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        CrudKasir.Show()
    End Sub
End Class