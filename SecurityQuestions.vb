Imports System.ComponentModel

Public Class SecurityQuestions

    Dim RecoveryQuestions(2) As String
    Dim RecoveryAnswers(2) As String
    Public UName As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtboxQuestion1Answer.Text = "" Or txtboxQuestion2Answer.Text = "" Or txtboxQuestion3Answer.Text = "" Then
            MessageBox.Show("All Fields Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        RecoveryQuestions(0) = cmbboxQuestion1.Text
        RecoveryQuestions(1) = cmbboxQuestion2.Text
        RecoveryQuestions(2) = cmbboxQuestion3.Text

        RecoveryAnswers(0) = txtboxQuestion1Answer.Text
        RecoveryAnswers(1) = txtboxQuestion2Answer.Text
        RecoveryAnswers(2) = txtboxQuestion3Answer.Text

        ConnectDatabase()

        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "PasswordRecovery"
                .Parameters.AddWithValue("@QType", "Add")
                .Parameters.AddWithValue("@UName", UName)
                .Parameters.AddWithValue("@RecoveryQuestion", "")
                .Parameters.AddWithValue("@RecoveryQuestionAnswer", "")
                .Parameters.AddWithValue("@NewPassword", "")
                For index = 0 To RecoveryQuestions.Count - 1
                    .Parameters("@UName").Value = UName
                    .Parameters("@RecoveryQuestion").Value = RecoveryQuestions(index)
                    .Parameters("@RecoveryQuestionAnswer").Value = RecoveryAnswers(index)
                    .ExecuteNonQuery()
                Next


                MsgBox("Recovery Registered", MsgBoxStyle.Information, "Information")

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try


        End With
        Me.Close()

    End Sub

    Private Sub SecurityQuestions_Load(sender As Object, e As EventArgs) Handles Me.Load
        HomeScreen.Enabled = False
    End Sub

    Private Sub SecurityQuestions_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
    End Sub

End Class