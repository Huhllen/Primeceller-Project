Imports System.Data.SqlClient

Namespace Dahboard

    Partial Public Class Product_List
        Inherits System.Windows.Forms.UserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim connStr As String = "Server=RAY26\\SQLEXPRESS;Database=SalesDashboardDB;Trusted_Connection=True;"
            Using conn As New SqlConnection(connStr)
                Try
                    conn.Open()
                    MessageBox.Show("Connected!")
                Catch ex As Exception
                    MessageBox.Show("Failed: " & ex.Message)
                End Try
            End Using


            Dim dialog As New ProductDialog()
            If dialog.ShowDialog() = DialogResult.OK Then
                Dim id As String = dialog.TextBoxID.Text
                Dim name As String = dialog.TextBoxName.Text
                Dim price As String = dialog.TextBoxPrice.Text
                Dim qty As String = dialog.TextBoxQTY.Text
                Dim fullImg As Image = dialog.PictureBoxImage.Image
                Dim thumb As Image = CreateThumbnail(fullImg, 48, 48)
                Dim rowIdx As Integer = DataGridView1.Rows.Add(id, thumb, name, price, qty)
                DataGridView1.Rows(rowIdx).Tag = fullImg
                Dim row = DataGridView1.CurrentRow
                Dim largeImg As Image = TryCast(row.Tag, Image)
            End If
        End Sub

        Private Function WordToNumber(word As String) As Integer?
            Select Case word.ToLower().Trim()
                Case "one" : Return 1
                Case "two" : Return 2
                Case "three" : Return 3
                Case "four" : Return 4
                Case "five" : Return 5
                Case "six" : Return 6
                Case "seven" : Return 7
                Case "eight" : Return 8
                Case "nine" : Return 9
                Case "ten" : Return 10
                Case Else : Return Nothing
            End Select
        End Function

        Private imagePreviewForm As New ImagePreviewForm()


        Private Sub DataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating
            Dim colName = DataGridView1.Columns(e.ColumnIndex).Name
            If colName = "Price" OrElse colName = "QTY" Then
                Dim value = e.FormattedValue.ToString()
                Dim numericValue As Integer

                If Not Integer.TryParse(value, numericValue) Then
                    Dim wordNumber = WordToNumber(value)
                    If wordNumber Is Nothing Then
                        MessageBox.Show($"{colName} must be a number or numeric word ('one', 'two', etc).")
                        e.Cancel = True
                    Else
                        DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = wordNumber
                    End If
                End If
            End If
        End Sub

        Private Sub ButtonViewImage_Click(sender As Object, e As EventArgs) Handles ButtonViewImage.Click
            Dim selectedRow = DataGridView1.CurrentRow
            If selectedRow IsNot Nothing Then
                Dim fullImage As Image = TryCast(selectedRow.Tag, Image)
                If fullImage IsNot Nothing Then
                    Dim preview As New ImagePreviewForm()
                    preview.ShowImage(fullImage)
                Else
                    MessageBox.Show("No image available for the selected product.")
                End If
            Else
                MessageBox.Show("Please select a row first.")
            End If
        End Sub



        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            If DataGridView1.CurrentRow IsNot Nothing Then
                MessageBox.Show("Row updated!")
            End If
        End Sub

        Private Function CreateThumbnail(img As Image, width As Integer, height As Integer) As Image
            Dim thumb As New Bitmap(width, height)
            Using g As Graphics = Graphics.FromImage(thumb)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(img, 0, 0, width, height)
            End Using
            Return thumb
        End Function
        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            If DataGridView1.CurrentRow IsNot Nothing Then
                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            End If
        End Sub



    End Class

End Namespace
