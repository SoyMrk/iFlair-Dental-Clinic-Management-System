Imports System.ComponentModel

Public Class AddSMSConfig

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()
        SMSConfiguration.Show()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SMSConfiguration"
                .Parameters.AddWithValue("@QType", "Insert")
                .Parameters.AddWithValue("@AccSID", txtboxAccountSID.Text)
                .Parameters.AddWithValue("@AutToken", txtboxAuthToken.Text)
                .Parameters.AddWithValue("@TwillioNumber", txtboxPhoneNumber.Text)
                .ExecuteNonQuery()
                'MessageBox.Show("SMS Configuration Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End With

            DatabaseDisconnect()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DatabaseDisconnect()
        End Try

        Me.Close()


    End Sub

    Private Sub btnShowAuthToken_Click(sender As Object, e As EventArgs) Handles btnShowAuthToken.Click

        If txtboxAuthToken.UseSystemPasswordChar = True Then
            txtboxAuthToken.UseSystemPasswordChar = False
        Else
            txtboxAuthToken.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub AddSMSConfig_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SMSConfiguration.Show()
    End Sub

    Private Sub Input_Validating(sender As Object, e As CancelEventArgs) Handles txtboxPhoneNumber.Validating, txtboxAuthToken.Validating, txtboxAccountSID.Validating

        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        If (txtbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtbox, String.Empty)
        Else
            ErrorProvider1.SetError(txtbox, "This field is required!")
            txtbox.Select()
        End If



    End Sub
End Class