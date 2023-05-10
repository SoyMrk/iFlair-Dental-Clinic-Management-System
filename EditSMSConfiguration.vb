Imports System.ComponentModel

Public Class EditSMSConfiguration
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        'SMSConfiguration.Show()
    End Sub

    Private Sub EditSMSConfiguration_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SMSConfiguration.Show()
    End Sub

    Private Sub EditSMSConfiguration_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SMSConfiguration"
                .Parameters.AddWithValue("@QType", "Edit")
                .Parameters.AddWithValue("@AccSID", txtboxEAuthToken.Text)
                .Parameters.AddWithValue("@AutToken", txtboxEAuthToken.Text)
                .Parameters.AddWithValue("@TwillioNumber", txtboxEPhoneNumber.Text)
                .ExecuteNonQuery()

                'MessageBox.Show("SMS Configuration Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("Current Configuration Activated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                SMSConfiguration.txtboxAccountSID.Text = txtboxEAccountSID.Text
                SMSConfiguration.txtboxAuthToken.Text = txtboxEAuthToken.Text
                SMSConfiguration.txtboxPhoneNumber.Text = txtboxEPhoneNumber.Text
                SMSConfiguration.AccountSID = txtboxEAccountSID.Text
                SMSConfiguration.AuthToken = txtboxEAuthToken.Text
                SMSConfiguration.TwillioNumber = txtboxEPhoneNumber.Text
                DatabaseDisconnect()
            End With
        Catch ex As Exception
            DatabaseDisconnect()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()
        SMSConfiguration.Show()


    End Sub

    Private Sub btnShowAuthToken_Click(sender As Object, e As EventArgs) Handles btnShowAuthToken.Click

        If txtboxEAuthToken.UseSystemPasswordChar = True Then
            txtboxEAuthToken.UseSystemPasswordChar = False
        Else
            txtboxEAuthToken.UseSystemPasswordChar = True
        End If

    End Sub
End Class