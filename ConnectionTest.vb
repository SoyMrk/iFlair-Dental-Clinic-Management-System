Imports System.ComponentModel

Public Class ConnectionTest
    Private Sub ConnectionTest_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtboxServerName.Text = My.Settings.serverIp
        txtboxUserID.Text = My.Settings.userId
        txtboxPassword.Text = My.Settings.password
        txtboxDatabaseName.Text = My.Settings.dbName

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

        Try

            ConnectDatabase()

            With DBConnection
                If .State = ConnectionState.Open Then
                    MessageBox.Show("Database is connected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Database is out of reach", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ConnectionTest_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LoginAccount.Enabled = True
    End Sub



    Private Sub txtboxDatabaseName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtboxUserID.KeyUp, txtboxServerName.KeyUp, txtboxPassword.KeyUp, txtboxDatabaseName.KeyUp
        My.Settings.serverIp = txtboxServerName.Text
        My.Settings.userId = txtboxUserID.Text
        My.Settings.password = txtboxPassword.Text
        My.Settings.dbName = txtboxDatabaseName.Text
    End Sub
End Class