Public Class frmStart
    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = Nothing
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmLogin.Show()
        Me.Hide()
    End Sub
End Class
