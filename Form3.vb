Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class sched
    Private WithEvents lblSelectedDate As New Label()

    Private Sub sched_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MonthCalendar1.MaxSelectionCount = 1
        MonthCalendar1.Font = New Font("Embrima", 11, FontStyle.Regular)
        MonthCalendar1.Anchor = AnchorStyles.Top
        Panel1.Controls.Add(MonthCalendar1)

        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
    End Sub

    Private selectedTime As String = ""
    Private Sub MonthCalendar1_DateChanged_1(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim selectedDate As Date = e.Start

        Panel1.Controls.Add(Label4)

        If selectedTime <> "" Then
            Label4.Text = "Selected Date and Time: " & vbCrLf & selectedDate.ToLongDateString() & ", " & selectedTime
        Else
            Label4.Text = "Selected Date and Time: " & vbCrLf & selectedDate.ToLongDateString()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            ComboBox1.ForeColor = Color.Gray
        Else
            ComboBox1.ForeColor = Color.Black
            selectedTime = ComboBox1.SelectedItem.ToString

            If MonthCalendar1.SelectionStart <> Date.MinValue Then
                Label4.Text = "Selected Date and Time: " & vbCrLf & MonthCalendar1.SelectionStart.ToLongDateString & ", " & selectedTime
            End If
        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex = 0 Then
            ComboBox2.ForeColor = Color.Gray
        Else
            ComboBox2.ForeColor = Color.Black
            selectedTime = ComboBox2.SelectedItem.ToString
            UpdateServiceDuration()
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedIndex = 0 Then
            ComboBox3.ForeColor = Color.Gray
        Else
            ComboBox3.ForeColor = Color.Black
            selectedTime = ComboBox2.SelectedItem.ToString
            UpdateServiceDuration()
        End If
    End Sub

    Private Function GetServiceDuration(airconType As String, serviceType As String) As String


        Select Case serviceType
            Case "Installation"
                Select Case airconType
                    Case "Window-Type"
                        Return "1–2 hours"
                    Case "Split-Type"
                        Return "3–6 hours"
                    Case "Multi-Split"
                        Return "1–2 days"
                End Select

            Case "Repair"
                Return "2–4 hours (Varies by issue)"

            Case "Maintenance"
                Return "1–4 hours (Varies by cleaning)"
        End Select

        Return ""
    End Function

    Private Sub UpdateServiceDuration()
        Dim airconType As String = ComboBox2.SelectedItem?.ToString()
        Dim serviceType As String = ComboBox3.SelectedItem?.ToString()

        If String.IsNullOrEmpty(airconType) OrElse String.IsNullOrEmpty(serviceType) Then
            Label5.Text = "This service would take:"
            Label5.ForeColor = Color.Black
            Return
        End If

        Dim duration As String = GetServiceDuration(airconType, serviceType)
        If duration <> "" Then
            Label5.Text = "This service would take: " & duration
        Else
            Label5.Text = "This service would take: (unknown)"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Using pen As New Pen(Color.DodgerBlue, 1.5F)
            Dim r As Integer = 12
            Dim rect As New Rectangle(0, 0, Panel1.Width - 1, Panel1.Height - 1)
            Using path As New GraphicsPath()
                path.AddArc(rect.X, rect.Y, r, r, 180, 90)
                path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90)
                path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90)
                path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90)
                path.CloseAllFigures()
                e.Graphics.DrawPath(pen, path)
            End Using
        End Using
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        DrawRoundedBorder(Panel2, e, Color.DodgerBlue, 1.5F, 12)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        DrawRoundedBorder(Panel3, e, Color.DodgerBlue, 1.5F, 12)
    End Sub

    Private Sub DrawRoundedBorder(pnl As Panel, e As PaintEventArgs, borderColor As Color, borderWidth As Single, radius As Integer)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As New Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1)
        Using path As New GraphicsPath()
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
            path.CloseAllFigures()

            Using pen As New Pen(borderColor, borderWidth)
                e.Graphics.DrawPath(pen, path)
            End Using
        End Using
    End Sub

End Class
