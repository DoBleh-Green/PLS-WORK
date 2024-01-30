Public Class AdminPage
    Private Sub btnKasir_Click(sender As Object, e As EventArgs) Handles btnKasir.Click
        Me.Hide()
        CrudKasir.Show()
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        Me.Hide()
        CrudBarang.Show()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Me.Hide()
        HistoryPembelian.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class