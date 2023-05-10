Imports System.ComponentModel

Public Class AddNewTemplate
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        richtxtMessage.Text = ""
        richtxtMessage.Select()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            ConnectDatabase()

            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SMSTemplate"
                .Parameters.AddWithValue("@QType", "Insert")
                .Parameters.AddWithValue("@TempName", txtboxTemplateName.Text)
                .Parameters.AddWithValue("@TempText", richtxtMessage.Text)
                .ExecuteNonQuery()
                'MessageBox.Show("SMS Template Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End With

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DatabaseDisconnect()
        End Try

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub AddNewTemplate_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ViewTemplate.Show()

    End Sub

    Private Sub Input_Validating(sender As Object, e As CancelEventArgs) Handles txtboxTemplateName.Validating, richtxtMessage.Validating

        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        If (txtbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtbox, String.Empty)
        Else
            ErrorProvider1.SetError(txtbox, "This field is required!")
            txtbox.Select()
        End If

    End Sub
End Class