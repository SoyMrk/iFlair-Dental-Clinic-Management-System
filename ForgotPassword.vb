Imports System.ComponentModel

Public Class ForgotPassword
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub



    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If txtboxUsername.Text = "" Then
            MessageBox.Show("Username Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtboxUsername.Select()
            Exit Sub
        End If
        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "PasswordRecovery"
                .Parameters.AddWithValue("@QType", "Check")
                .Parameters.AddWithValue("@UName", txtboxUsername.Text)
                .Parameters.AddWithValue("@RecoveryQuestion", "")
                .Parameters.AddWithValue("@RecoveryQuestionAnswer", "")
                .Parameters.AddWithValue("@NewPassword", "")

                myreader = .ExecuteReader

                If myreader.HasRows Then
                    If myreader.Read() Then
                        If myreader("UserType") <> "Administrator" Then
                            MessageBox.Show("This feature is for adminstrator only" & vbCrLf & "If you lost your password. Contact Administrator.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                            Me.Close()
                        End If
                    End If
                    ForgotPasswordSecurityQuestion.UserName = txtboxUsername.Text
                    Me.Close()
                    LoginAccount.Enabled = False
                    ForgotPasswordSecurityQuestion.Show()
                Else
                    MessageBox.Show("Account Username doesn't Exist" & vbCrLf & "This feature is for Adminstrators only" & vbCrLf & "If you lost your password. Contact Administrator.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Close()
                End If

            End With

            DatabaseDisconnect()
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try
    End Sub

    Private Sub ForgotPassword_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LoginAccount.Enabled = True
    End Sub

    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub ForgotPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then btnContinue_Click(sender, e)
    End Sub
End Class