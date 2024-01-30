Imports MySql.Data.MySqlClient

Public Enum role
    admin
    kasir
End Enum
Public Class Login
    Dim CS As String = "server=localhost;user=root;password=;database=db_vb_proj;allow user variables=true"
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = tbUsername.Text()
        Dim password As String = tbPassword.Text()

        If Auth(username, password, role.admin) Then
            MsgBox("admin Login Sukses")
            admin()
        ElseIf Auth(username, password, role.kasir) Then
            MsgBox("kasir Login Sukses")
            kasir()

        Else
            MsgBox("Invalid Login")
        End If



    End Sub

    Private Sub admin()
        Dim admin As New AdminPage()
        Me.Hide()
        admin.Show()
    End Sub
    Private Sub kasir()
        Dim kasir As New KasirPage()
        Me.Hide()
        kasir.Show()
    End Sub

    Private Function Auth(username As String, password As String, role As role) As Boolean
        Using c As New MySqlConnection(CS)
            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM users WHERE username=@username AND password=@password AND role=@role", c)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@role", role.ToString())

                Try
                    c.Open()
                    Dim rs As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return rs > 0

                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                    Return False ' Return false in case of an exception
                Finally
                    c.Close()
                End Try
            End Using
        End Using
    End Function
End Class

