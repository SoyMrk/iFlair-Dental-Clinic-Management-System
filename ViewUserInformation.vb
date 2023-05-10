Imports System.ComponentModel

Public Class ViewUserInformation

    Public UName As String
    Private Sub ViewUserInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewUserInfo"
                .Parameters.AddWithValue("@UName", UName)
            End With

            myreader = sqlcmd.ExecuteReader

            If myreader.Read Then
                lblEmployeeName.Text = myreader("EmployeeName")
                lblUserName.Text = myreader("Username")
                lblAccountType.Text = myreader("UserType")
            End If

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try

        If lblAccountType.Text = "Administrator" Then
            btnResetPassword.Visible = False
        End If

    End Sub

    Private Sub ViewUserInformation_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        ForgotPasswordSecurityQuestion.UserName = lblUserName.Text
        ResetPassword.Show()
    End Sub

End Class