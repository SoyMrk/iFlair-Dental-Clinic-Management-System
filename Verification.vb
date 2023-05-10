Imports System.ComponentModel

Public Class Verification




    Private Sub Verification_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LoginAccount.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        If txtboxUsername.Text = String.Empty Or txtboxPassword.Text = String.Empty Then
            MessageBox.Show("Username or Password is Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'dbConnect.sqlstr = "SELECT * FROM user_account WHERE UserType ='admin' AND UserName ='" & txtboxUsername.Text & "' AND UserPassword ='" & txtboxPassword.Text & "'"
        'MsgBox(sqlstr)
        dbConnect.ConnectDatabase()

        Try
            With dbConnect.sqlcmd
                .Connection = dbConnect.DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "verifyAdmin"
                .Parameters.AddWithValue("@UName", txtboxUsername.Text)
                .Parameters.AddWithValue("@UPass", txtboxPassword.Text)
            End With

            myreader = dbConnect.sqlcmd.ExecuteReader
            If myreader.HasRows Then
                Me.Close()
                AddNewEmployee.Show()
            Else
                MessageBox.Show("Registration is facilitated by admins", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                LoginAccount.Show()
            End If
            dbConnect.DatabaseDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error")
            dbConnect.DatabaseDisconnect()
        End Try

    End Sub

    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        If txtboxPassword.UseSystemPasswordChar = True Then
            txtboxPassword.UseSystemPasswordChar = False
        Else
            txtboxPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Verification_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtboxUsername.Select()

    End Sub





    'Private Sub checkboxShowPassword_CheckedChanged(sender As Object, e As EventArgs)
    '    txtboxPassword.UseSystemPasswordChar = Not checkboxShowPassword.Checked
    'End Sub


End Class