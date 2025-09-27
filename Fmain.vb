Public Class Fmain
    Private Sub Qcalbttn_Click(sender As Object, e As EventArgs) Handles Qcalbttn.Click
        Dim Foption As New Fchoices
        Foption.TopLevel = False
        M_pnl.Controls.Add(Foption)
        Foption.BringToFront()
        Foption.Show()

    End Sub


    Private Sub T_pnl_Paint(sender As Object, e As PaintEventArgs) Handles T_pnl.Paint

    End Sub

    Private Sub Fmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub S_pnl_Paint(sender As Object, e As PaintEventArgs) Handles S_pnl.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
