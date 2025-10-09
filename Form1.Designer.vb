Namespace Dahboard

    Partial Class Form1
        Inherits System.Windows.Forms.Form

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.PictureBox7 = New System.Windows.Forms.PictureBox()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.PictureBox6 = New System.Windows.Forms.PictureBox()
            Me.PictureBox2 = New System.Windows.Forms.PictureBox()
            Me.PictureBox5 = New System.Windows.Forms.PictureBox()
            Me.PictureBox3 = New System.Windows.Forms.PictureBox()
            Me.PictureBox4 = New System.Windows.Forms.PictureBox()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.PanelContent = New System.Windows.Forms.Panel()
            Me.TimerDateTime = New System.Windows.Forms.Timer(Me.components)
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1401, 130)
            Me.Panel1.TabIndex = 0
            '
            'Label2
            '
            Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.Label2.Location = New System.Drawing.Point(545, 40)
            Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(289, 50)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Home"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.Label3.Location = New System.Drawing.Point(816, 40)
            Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(581, 50)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Date and Time"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.Label1.Location = New System.Drawing.Point(51, 47)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(283, 38)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Sales Dashboard"
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.Panel2.Controls.Add(Me.PictureBox7)
            Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel2.Location = New System.Drawing.Point(0, 130)
            Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(107, 481)
            Me.Panel2.TabIndex = 1
            '
            'PictureBox7
            '
            Me.PictureBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
            Me.PictureBox7.Location = New System.Drawing.Point(16, 376)
            Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4)
            Me.PictureBox7.Name = "PictureBox7"
            Me.PictureBox7.Size = New System.Drawing.Size(64, 54)
            Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox7.TabIndex = 7
            Me.PictureBox7.TabStop = False
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.PictureBox6, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.PictureBox2, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.PictureBox5, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.PictureBox3, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.PictureBox4, 0, 3)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 10
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(107, 481)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(21, 4)
            Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(64, 40)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 2
            Me.PictureBox1.TabStop = False
            '
            'PictureBox6
            '
            Me.PictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
            Me.PictureBox6.Location = New System.Drawing.Point(21, 244)
            Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4)
            Me.PictureBox6.Name = "PictureBox6"
            Me.PictureBox6.Size = New System.Drawing.Size(64, 40)
            Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox6.TabIndex = 6
            Me.PictureBox6.TabStop = False
            '
            'PictureBox2
            '
            Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Default
            Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
            Me.PictureBox2.Location = New System.Drawing.Point(21, 52)
            Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(64, 40)
            Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox2.TabIndex = 1
            Me.PictureBox2.TabStop = False
            '
            'PictureBox5
            '
            Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
            Me.PictureBox5.Location = New System.Drawing.Point(21, 196)
            Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
            Me.PictureBox5.Name = "PictureBox5"
            Me.PictureBox5.Size = New System.Drawing.Size(64, 40)
            Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox5.TabIndex = 5
            Me.PictureBox5.TabStop = False
            '
            'PictureBox3
            '
            Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
            Me.PictureBox3.Location = New System.Drawing.Point(21, 100)
            Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(64, 40)
            Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox3.TabIndex = 3
            Me.PictureBox3.TabStop = False
            '
            'PictureBox4
            '
            Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
            Me.PictureBox4.Location = New System.Drawing.Point(21, 148)
            Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
            Me.PictureBox4.Name = "PictureBox4"
            Me.PictureBox4.Size = New System.Drawing.Size(64, 40)
            Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox4.TabIndex = 4
            Me.PictureBox4.TabStop = False
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.PanelContent)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(107, 130)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(1294, 481)
            Me.Panel3.TabIndex = 2
            '
            'PanelContent
            '
            Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelContent.Location = New System.Drawing.Point(0, 0)
            Me.PanelContent.Name = "PanelContent"
            Me.PanelContent.Size = New System.Drawing.Size(1294, 481)
            Me.PanelContent.TabIndex = 0
            '
            'TimerDateTime
            '
            Me.TimerDateTime.Enabled = True
            Me.TimerDateTime.Interval = 1000
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1401, 611)
            Me.Controls.Add(Me.Panel3)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.Panel1)
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel1.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Panel2 As Panel
        Friend WithEvents PictureBox2 As PictureBox
        Friend WithEvents PictureBox6 As PictureBox
        Friend WithEvents PictureBox5 As PictureBox
        Friend WithEvents PictureBox4 As PictureBox
        Friend WithEvents PictureBox3 As PictureBox
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents PictureBox7 As PictureBox
        Friend WithEvents Panel3 As Panel
        Friend WithEvents PanelContent As Panel
        Friend WithEvents TimerDateTime As Timer
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    End Class

End Namespace
