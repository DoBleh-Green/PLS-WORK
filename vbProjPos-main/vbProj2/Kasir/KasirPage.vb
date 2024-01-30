Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient

Public Class KasirPage
    Dim CS As String = "server=localhost;user=root;password=;database=db_vb_proj;allow user variables=true"
    Dim c As New MySqlConnection(CS)

    Private Sub dataloadbarang()
        Dim query As String = "SELECT id_barang,nama_barang FROM barang"
        Dim cmd As New MySqlCommand(query, c)

        Try
            c.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader()

            While rd.Read()
                ComboBox1.Items.Add(rd("nama_barang").ToString())
            End While
            rd.Close()
        Catch ex As Exception
            MsgBox("error render barang:" & ex.Message)

        Finally
            c.Close()
        End Try
    End Sub
    Private Sub dataloaduser()
        Dim query As String = "SELECT id_user,name FROM users"
        Dim cmd As New MySqlCommand(query, c)

        Try
            c.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader()

            While rd.Read()
                ComboBox3.Items.Add(rd("name").ToString())
            End While
            rd.Close()
        Catch ex As Exception
            MsgBox("error render barang:" & ex.Message)

        Finally
            c.Close()
        End Try
    End Sub
    Private Sub dataTBbarang(namaBarang As String)
        Dim query As String = "SELECT * FROM barang WHERE nama_barang = @namaBarang"
        Dim cmd As New MySqlCommand(query, c)
        cmd.Parameters.AddWithValue("@namaBarang", namaBarang)

        Try
            c.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader()

            While rd.Read()
                TBidbarang.Text = rd("id_barang").ToString()
                TBstok.Text = rd("stok").ToString()
                TBharga.Text = rd("harga_barang").ToString()

            End While
            rd.Close()
        Catch ex As Exception
            MsgBox("error:" & ex.Message)
        Finally
            c.Close()
        End Try
    End Sub
    Private Sub dataTBuser(user As String)
        Dim query As String = "SELECT * FROM users WHERE name = @user"
        Dim cmd As New MySqlCommand(query, c)
        cmd.Parameters.AddWithValue("@user", user)

        Try
            c.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader()

            While rd.Read()
                TBnama.Text = rd("id_user").ToString()
            End While
            rd.Close()
        Catch ex As Exception
            MsgBox("error:" & ex.Message)
        Finally
            c.Close()
        End Try
    End Sub
    Private Sub KasirPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataloadbarang()
        dataloaduser()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TBstok.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim slctd As String = ComboBox1.SelectedItem.ToString()
        dataTBbarang(slctd)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles jumlah.ValueChanged
        Dim harga As Decimal = TBharga.Text
        Dim total_harga As Decimal = jumlah.Value * harga

        TBtotalharga.Text = total_harga.ToString
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim IDB As Integer = TBidbarang.Text
        Dim NB As String = ComboBox1.Text
        Dim JH As Integer = jumlah.Value
        Dim TH As Integer = TBtotalharga.Text

        DataGridView1.Rows.Add(IDB, NB, JH, TH)
        totalharga()
    End Sub
    Private Sub totalharga()
        Dim totalsub As Integer = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim RT As Integer
                If Integer.TryParse(row.Cells(3).Value.ToString(), RT) Then
                    totalsub += RT
                Else
                    MessageBox.Show("invalid total row" & row.Index + 1)
                End If
            End If
        Next
        TBsubtotal.Text = totalsub.ToString()
    End Sub

    Private Sub TBtunai_TextChanged(sender As Object, e As EventArgs) Handles TBtunai.TextChanged
        Dim tunai As Decimal = TBtunai.Text
        Dim hasil As Decimal = tunai - TBtotal.Text
        TBkembalian.Text = hasil
    End Sub

    Private Sub TBsubtotal_TextChanged(sender As Object, e As EventArgs) Handles TBsubtotal.TextChanged
        TBtotal.Text = TBsubtotal.Text

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim diskon = ComboBox2.Text
        Dim hasil As Decimal = TBsubtotal.Text * (diskon / 100)
        TBtotal.Text = hasil
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim slctd As String = ComboBox3.SelectedItem.ToString()
        dataTBuser(slctd)
    End Sub
End Class