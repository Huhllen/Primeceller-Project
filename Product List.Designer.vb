Namespace Dahboard


    Partial Class Product_List
        Inherits System.Windows.Forms.UserControl
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

        Private components As System.ComponentModel.IContainer

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product_List))
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.PictureBox8 = New System.Windows.Forms.PictureBox()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.ButtonViewImage = New System.Windows.Forms.Button()
            Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Image = New System.Windows.Forms.DataGridViewImageColumn()
            Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TextBox1
            '
            Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
            Me.TextBox1.Location = New System.Drawing.Point(33, 47)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(350, 30)
            Me.TextBox1.TabIndex = 0
            Me.TextBox1.Text = "          Search"
            '
            'Button1
            '
            Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
            Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.Button1.Location = New System.Drawing.Point(966, 34)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(125, 54)
            Me.Button1.TabIndex = 5
            Me.Button1.Text = "Insert"
            Me.Button1.UseVisualStyleBackColor = False
            '
            'Button2
            '
            Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button2.BackColor = System.Drawing.Color.LimeGreen
            Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
            Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.Button2.Location = New System.Drawing.Point(1126, 34)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(125, 54)
            Me.Button2.TabIndex = 6
            Me.Button2.Text = "Update"
            Me.Button2.UseVisualStyleBackColor = False
            '
            'Button3
            '
            Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button3.BackColor = System.Drawing.Color.Purple
            Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
            Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.Button3.Location = New System.Drawing.Point(1267, 34)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(125, 54)
            Me.Button3.TabIndex = 7
            Me.Button3.Text = "Delete"
            Me.Button3.UseVisualStyleBackColor = False
            '
            'PictureBox8
            '
            Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
            Me.PictureBox8.Location = New System.Drawing.Point(45, 47)
            Me.PictureBox8.Name = "PictureBox8"
            Me.PictureBox8.Size = New System.Drawing.Size(40, 30)
            Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox8.TabIndex = 8
            Me.PictureBox8.TabStop = False
            '
            'DataGridView1
            '
            Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
            Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Image, Me.ProductName, Me.Price, Me.QTY})
            Me.DataGridView1.Location = New System.Drawing.Point(3, 112)
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.RowHeadersWidth = 50
            Me.DataGridView1.RowTemplate.Height = 50
            Me.DataGridView1.Size = New System.Drawing.Size(1429, 546)
            Me.DataGridView1.TabIndex = 9
            '
            'ButtonViewImage
            '
            Me.ButtonViewImage.Location = New System.Drawing.Point(420, 83)
            Me.ButtonViewImage.Name = "ButtonViewImage"
            Me.ButtonViewImage.Size = New System.Drawing.Size(75, 23)
            Me.ButtonViewImage.TabIndex = 0
            Me.ButtonViewImage.Text = "View"
            Me.ButtonViewImage.UseVisualStyleBackColor = True
            '
            'ID
            '
            Me.ID.FillWeight = 91.57755!
            Me.ID.HeaderText = "ID"
            Me.ID.MinimumWidth = 6
            Me.ID.Name = "ID"
            Me.ID.ReadOnly = True
            '
            'Image
            '
            Me.Image.FillWeight = 133.6898!
            Me.Image.HeaderText = "Image"
            Me.Image.MinimumWidth = 6
            Me.Image.Name = "Image"
            Me.Image.ReadOnly = True
            '
            'ProductName
            '
            Me.ProductName.FillWeight = 91.57755!
            Me.ProductName.HeaderText = "ProductName"
            Me.ProductName.MinimumWidth = 6
            Me.ProductName.Name = "ProductName"
            '
            'Price
            '
            Me.Price.FillWeight = 91.57755!
            Me.Price.HeaderText = "Price"
            Me.Price.MinimumWidth = 6
            Me.Price.Name = "Price"
            '
            'QTY
            '
            Me.QTY.FillWeight = 91.57755!
            Me.QTY.HeaderText = "QTY"
            Me.QTY.MinimumWidth = 6
            Me.QTY.Name = "QTY"
            '
            'Product_List
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ButtonViewImage)
            Me.Controls.Add(Me.DataGridView1)
            Me.Controls.Add(Me.PictureBox8)
            Me.Controls.Add(Me.Button3)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.TextBox1)
            Me.Name = "Product_List"
            Me.Size = New System.Drawing.Size(1432, 749)
            CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TextBox1 As TextBox
        Friend WithEvents Button1 As Button
        Friend WithEvents Button2 As Button
        Friend WithEvents Button3 As Button
        Friend WithEvents PictureBox8 As PictureBox
        Friend WithEvents DataGridView1 As DataGridView
        Friend WithEvents ButtonViewImage As Button
        Friend WithEvents ID As DataGridViewTextBoxColumn
        Friend WithEvents Image As DataGridViewImageColumn
        Friend Shadows WithEvents ProductName As DataGridViewTextBoxColumn
        Friend WithEvents Price As DataGridViewTextBoxColumn
        Friend WithEvents QTY As DataGridViewTextBoxColumn
    End Class
End Namespace

