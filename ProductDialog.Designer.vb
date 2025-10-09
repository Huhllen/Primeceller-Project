Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductDialog))
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxQTY = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBoxImage = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(387, 169)
        Me.TextBoxID.Multiline = True
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(140, 30)
        Me.TextBoxID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(114, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(114, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product Name"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(114, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Image"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(387, 205)
        Me.TextBoxName.Multiline = True
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(140, 30)
        Me.TextBoxName.TabIndex = 6
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(387, 241)
        Me.TextBoxPrice.Multiline = True
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(140, 30)
        Me.TextBoxPrice.TabIndex = 7
        '
        'TextBoxQTY
        '
        Me.TextBoxQTY.Location = New System.Drawing.Point(387, 277)
        Me.TextBoxQTY.Multiline = True
        Me.TextBoxQTY.Name = "TextBoxQTY"
        Me.TextBoxQTY.Size = New System.Drawing.Size(140, 30)
        Me.TextBoxQTY.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(387, 428)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Select Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(117, 412)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 30)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Ok"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(219, 412)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 30)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBoxImage
        '
        Me.PictureBoxImage.Location = New System.Drawing.Point(387, 322)
        Me.PictureBoxImage.Name = "PictureBoxImage"
        Me.PictureBoxImage.Size = New System.Drawing.Size(120, 100)
        Me.PictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxImage.TabIndex = 12
        Me.PictureBoxImage.TabStop = False
        '
        'ProductDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(622, 568)
        Me.Controls.Add(Me.PictureBoxImage)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxQTY)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxID)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ProductDialog"
        CType(Me.PictureBoxImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents TextBoxQTY As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBoxImage As PictureBox

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select Product Image"
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        If ofd.ShowDialog() = DialogResult.OK Then
            PictureBoxImage.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Check for empty textboxes
        If String.IsNullOrWhiteSpace(TextBoxID.Text) OrElse
       String.IsNullOrWhiteSpace(TextBoxName.Text) OrElse
       String.IsNullOrWhiteSpace(TextBoxPrice.Text) OrElse
       String.IsNullOrWhiteSpace(TextBoxQTY.Text) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error")
            Return
        End If

        If Not IsNumeric(TextBoxID.Text) Then
            MessageBox.Show("ID must be numbers only!", "Input Warning")
            Return
        End If
        If TextBoxName.Text.Any(AddressOf Char.IsDigit) Then
            MessageBox.Show("Product Name must not contain numbers!", "Input Warning")
            Return
        End If
        If Not IsNumeric(TextBoxPrice.Text) Then
            MessageBox.Show("Price must be numeric!", "Input Warning")
            Return
        End If

        If Not IsNumeric(TextBoxQTY.Text) Then
            MessageBox.Show("QTY must be numeric!", "Input Warning")
            Return
        End If
        Try
        Catch ex As Exception
            MessageBox.Show("The selected file is not a valid image file.", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
            PictureBoxImage.Image = Nothing
        End Try

        ' Check if image is selected
        If PictureBoxImage.Image Is Nothing Then
            MessageBox.Show("Please select an image.", "Validation Error")
            Return
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
