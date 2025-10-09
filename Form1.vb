Namespace Dahboard

    Partial Public Class Form1
        Inherits System.Windows.Forms.Form

        Public Sub New()
            InitializeComponent()
            ShowHomePage() ' Show the Home page on startup
        End Sub

        Public Sub ShowHomePage()
            PanelContent.Controls.Clear()
            Dim homePage As New HomeControl() With {
                .Dock = DockStyle.Fill
            }
            PanelContent.Controls.Add(homePage)
            Label2.Text = "Home"
        End Sub

        Public Sub ShowProductList()
            PanelContent.Controls.Clear()
            Dim productListControl As New Product_List With {
                .Dock = DockStyle.Fill
            }
            PanelContent.Controls.Clear()
            PanelContent.Controls.Add(productListControl)
            Label2.Text = "Product List"
        End Sub

        Public Sub ShowPMSNotifier()
            PanelContent.Controls.Clear()
            Dim pmsNotifierControl As New PMS_Notifier() With {
        .Dock = DockStyle.Fill
    }
            PanelContent.Controls.Add(pmsNotifierControl)
            Label2.Text = "PMS Notifier"
        End Sub
        Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
            ShowProductList()
        End Sub

        Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
            ShowHomePage()
        End Sub

        Private Sub PanelContent_Paint(sender As Object, e As PaintEventArgs) Handles PanelContent.Paint

        End Sub

        Private Sub TimerDateTime_Tick(sender As Object, e As EventArgs) Handles TimerDateTime.Tick
            Label3.Text = DateTime.Now.ToString("MMMM dd yyyy hh:mm:ss tt")
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Label3.Text = DateTime.Now.ToString("MMMM dd yyyy hh:mm:ss tt")
        End Sub

        Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        End Sub

        Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        End Sub

        Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
            ShowPMSNotifier()
        End Sub
    End Class

End Namespace
