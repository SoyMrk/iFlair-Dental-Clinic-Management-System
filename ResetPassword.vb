Imports System.ComponentModel

Public Class ResetPassword
    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        If Not txtboxEnterNewPassword.Text = txtboxConfirmNewPassword.Text Then
            MessageBox.Show("Password did not match", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Try
                ConnectDatabase()
                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "PasswordRecovery"
                    .Parameters.AddWithValue("@QType", "ChangePassword")
                    .Parameters.AddWithValue("@UName", ForgotPasswordSecurityQuestion.UserName)
                    .Parameters.AddWithValue("@RecoveryQuestion", "")
                    .Parameters.AddWithValue("@RecoveryQuestionAnswer", "")
                    .Parameters.AddWithValue("@NewPassword", txtboxConfirmNewPassword.Text)

                    .ExecuteNonQuery()

                    MessageBox.Show("Password changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                End With

                DatabaseDisconnect()
            Catch ex As Exception

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DatabaseDisconnect()
            End Try

        End If
    End Sub

    Private Sub ResetPassword_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LoginAccount.Enabled = True
    End Sub
End Class