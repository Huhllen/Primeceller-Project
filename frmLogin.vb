Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmLogin
    Private connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=PrimeCellerDB;Integrated Security=True;Encrypt=False;"

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = lblDummy

        Select Case CurrentRole
            Case "Admin"
                lblRole.Text = "Logging in as Admin"
                lblRole.ForeColor = Color.Blue
            Case "Finance"
                lblRole.Text = "Logging in as Finance"
                lblRole.ForeColor = Color.Blue
            Case "Sales"
                lblRole.Text = "Logging in as Sales"
                lblRole.ForeColor = Color.Blue
            Case Else
                lblRole.Text = ""
        End Select
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CurrentRole = ""
        frmStart.Show()
        Me.Close()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If AuthenticateUser(username, password) Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Select Case CurrentRole
                Case "Admin"
                    frmAdminDashBoard.Show()
                Case "Finance"
                    frmFinanceDashBoard.Show()
                Case "Sales"
                    frmSalesDashBoard.Show()
            End Select

            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Dim isValid As Boolean = False
        Dim tableName As String = ""

        ' Choose table based on role
        Select Case CurrentRole
            Case "Admin"
                tableName = "AdminAccounts"
            Case "Finance"
                tableName = "FinanceAccounts"
            Case "Sales"
                tableName = "SalesAccounts"
            Case Else
                MessageBox.Show("Invalid role selected.")
                Return False
        End Select

        Using con As New SqlConnection(connectionString)
            Dim query As String = $"SELECT COUNT(*) FROM {tableName} WHERE Account_Username=@Username AND Account_Password=@Password"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", password)
                Try
                    con.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        isValid = True
                    End If
                Catch ex As Exception
                    MessageBox.Show("Database error: " & ex.Message)
                End Try
            End Using
        End Using
        Return isValid
    End Function

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnlogin.PerformClick()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnlogin.PerformClick()
        End If
    End Sub
End Class
