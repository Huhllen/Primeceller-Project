Public Class ImagePreviewForm

    Public Sub ShowImage(img As Image)
        PictureBox1.Image = img
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Show()
        Me.BringToFront()
    End Sub

    Public Sub New()
        InitializeComponent()  ' THIS IS REQUIRED!
    End Sub

    Private Sub ButtonMinimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub



End Class
