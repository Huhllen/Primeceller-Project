Namespace Dahboard

    Public Class HomeControl
        Inherits UserControl

        Public Sub New()
            Me.BackColor = Color.White
            Dim lbl As New Label With {
                .Text = "HOME PAGE",
                .Dock = DockStyle.Top,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Font = New Font("Segoe UI", 32, FontStyle.Bold)
            }
            Me.Controls.Add(lbl)
        End Sub

        Private Sub InitializeComponent()
            Me.SuspendLayout()
            '
            'HomeControl
            '
            Me.Name = "HomeControl"
            Me.Size = New System.Drawing.Size(530, 490)
            Me.ResumeLayout(False)

        End Sub
    End Class

End Namespace
