Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor
Public Class EditKasir
    Dim CS As String = "server=localhost;user=root;password=;database=db_vb_proj;allow user variables=true"
    Dim c As New MySqlConnection(CS)

    Private Sub EditKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadakun()
    End Sub

    Private Sub loadakun()
        Dim query As String = "SELECT * FROM users WHERE role = 'kasir' "
        Dim akun As New MySqlDataAdapter(query, c)
        Dim table As New DataTable()
        akun.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim slctd As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            Dim query As String = "SELECT * FROM users WHERE Id_user = @id"

            Using cmd As New MySqlCommand(query, c)
                cmd.Parameters.AddWithValue("@id", slctd)

                Try
                    c.Open()
                    Dim rd As MySqlDataReader = cmd.ExecuteReader()

                    If rd.Read() Then
                        tbEditUsername.Text = rd("username").ToString()
                        tbEditName.Text = rd("name").ToString()
                        tbEditPassword.Text = rd("password").ToString()
                        cbEditRole.Text = rd("role").ToString()
                    End If

                Catch ex As Exception
                    MsgBox("error: " & ex.Message)
                Finally
                    c.Close()
                End Try
            End Using
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim slctd As Integer = CInt(DataGridView1.SelectedRows(0).Cells(0).Value)
                Dim query As String = "UPDATE users SET username=@username, password=@password, name=@name, role=@role WHERE Id_user=@id"
                Dim cmd As New MySqlCommand(query, c)

                cmd.Parameters.AddWithValue("@username", tbEditUsername.Text)
                cmd.Parameters.AddWithValue("@password", tbEditPassword.Text)
                cmd.Parameters.AddWithValue("@name", tbEditName.Text)
                cmd.Parameters.AddWithValue("@role", cbEditRole.Text)

                cmd.Parameters.AddWithValue("@id", slctd)

                c.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Update Success")
                loadakun()

            Else
                MsgBox("Tolong Pilih Data Untuk Di Edit")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            c.Close()
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadakun()
        Me.Close()
        CrudKasir.Show()

    End Sub
End Class