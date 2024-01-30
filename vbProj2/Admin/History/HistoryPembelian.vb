Public Class HistoryPembelian
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        AdminPage.Show()
    End Sub
    Private Sub dataload()
        Dim query As String = "SELECT * FROM transaksi"
    End Sub
    Private Sub HistoryPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class