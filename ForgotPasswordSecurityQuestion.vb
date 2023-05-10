Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class ForgotPasswordSecurityQuestion
    Public Shared UserName As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub ForgotPasswordSecurityQuestion_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            ConnectDatabase()
            Dim Questions As New DataTable
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getRecoveryQuestions"
                .Parameters.AddWithValue("@UName", UserName)
            End With
            myAdapter.SelectCommand = sqlcmd
            myAdapter.Fill(Questions)

            cmbboxQuestion.DataSource = Questions
            cmbboxQuestion.ValueMember = "fgtPassAnswer"
            cmbboxQuestion.DisplayMember = "fgtPassQuestion"

            DatabaseDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()
        End Try


    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If txtboxAnswer.Text = cmbboxQuestion.SelectedValue.ToString Then
            Me.Close()
            LoginAccount.Enabled = False
            ResetPassword.Show()
        Else
            MessageBox.Show("Wrong Answer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ForgotPasswordSecurityQuestion_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LoginAccount.Enabled = True
    End Sub


End Class