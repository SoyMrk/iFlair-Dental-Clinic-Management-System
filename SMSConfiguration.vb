Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class SMSConfiguration

    Public Shared AccountSID As String = My.Settings.AccountSID
    Public Shared AuthToken As String = My.Settings.AuthToken
    Public Shared TwillioNumber As String = My.Settings.TwillioNumber

    Public Sub loadConfigurations()
        AccountSID = My.Settings.AccountSID
        AuthToken = My.Settings.AuthToken
        TwillioNumber = My.Settings.TwillioNumber
    End Sub

    Private Sub SMSConfiguration_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            ConnectDatabase()
            Dim smsConfigTable As New DataTable
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SMSConfiguration"
                .Parameters.AddWithValue("@QType", "View")
                .Parameters.AddWithValue("@AccSID", "")
                .Parameters.AddWithValue("@AutToken", "")
                .Parameters.AddWithValue("@TwillioNumber", "")
            End With

            myAdapter.SelectCommand = sqlcmd
            myAdapter.Fill(smsConfigTable)

            If smsConfigTable.Rows.Count <> 0 Then

                cmbboxSMSConfig.DataSource = smsConfigTable
                cmbboxSMSConfig.ValueMember = "AccountSID"
                cmbboxSMSConfig.DisplayMember = "AccountSID"

            End If

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try


        If My.Settings.AccountSID = "" Then
            MessageBox.Show("No Active Configuration, Select One and Set Active Configuration")
        Else
            btnSetConfiguration.Visible = False
            btnDelete.Visible = True

            txtboxAccountSID.Text = AccountSID
            txtboxAuthToken.Text = AuthToken
            txtboxPhoneNumber.Text = TwillioNumber

            cmbboxSMSConfig.Text = AccountSID
        End If

        txtboxAccountSID.SelectionStart = 0
        txtboxAccountSID.SelectionLength = 0
    End Sub

    Private Sub cmbboxSMSConfig_Click(sender As Object, e As EventArgs) Handles cmbboxSMSConfig.Click

        If cmbboxSMSConfig.Text = "" Then
            MessageBox.Show("Configuration is Empty, Please Add One")
        End If

    End Sub



    Private Sub cmbboxSMSConfig_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxSMSConfig.SelectionChangeCommitted


    End Sub

    Private Sub btnSetConfiguration_Click(sender As Object, e As EventArgs) Handles btnSetConfiguration.Click

        If txtboxAccountSID.Text = "" Then

            MessageBox.Show("Please Enter an AccountSID", "Informtaion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            My.Settings.AccountSID = txtboxAccountSID.Text
            My.Settings.AuthToken = txtboxAuthToken.Text
            My.Settings.TwillioNumber = txtboxPhoneNumber.Text

            loadConfigurations()

            'MessageBox.Show("Configuration Set Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        End If
    End Sub

    Private Sub cmbboxSMSConfig_DropDownClosed(sender As Object, e As EventArgs) Handles cmbboxSMSConfig.DropDownClosed
        btnDelete.Visible = True
        Try
            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SMSConfiguration"
                .Parameters.AddWithValue("@QType", "Get")
                .Parameters.AddWithValue("@AccSID", cmbboxSMSConfig.SelectedValue.ToString)
                .Parameters.AddWithValue("@AutToken", "")
                .Parameters.AddWithValue("@TwillioNumber", "")

                myreader = .ExecuteReader

                If myreader.Read() Then
                    txtboxAccountSID.Text = myreader("AccountSID")
                    txtboxAuthToken.Text = myreader("AuthToken")
                    txtboxPhoneNumber.Text = myreader("TwillioNumber")
                End If

            End With

            DatabaseDisconnect()

        Catch ex As Exception
            DatabaseDisconnect()
            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If AccountSID <> txtboxAccountSID.Text Then
            btnSetConfiguration.Visible = True
        Else
            btnSetConfiguration.Visible = False
        End If

    End Sub

    Private Sub SMSConfiguration_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
    End Sub

    Private Sub btnAddSMSConfig_Click(sender As Object, e As EventArgs) Handles btnAddSMSConfig.Click

        Me.Close()
        AddSMSConfig.Show()
        HomeScreen.Enabled = False

    End Sub

    Private Sub btnConfigureSMS_Click(sender As Object, e As EventArgs) Handles btnConfigureSMS.Click
        EditSMSConfiguration.txtboxEAccountSID.Text = txtboxAccountSID.Text
        EditSMSConfiguration.txtboxEAuthToken.Text = txtboxAuthToken.Text
        EditSMSConfiguration.txtboxEPhoneNumber.Text = txtboxPhoneNumber.Text

        Me.Close()
        EditSMSConfiguration.Show()
        HomeScreen.Enabled = False
    End Sub



    Private Sub btnShowAuthToken_Click(sender As Object, e As EventArgs) Handles btnShowAuthToken.Click

        If txtboxAuthToken.UseSystemPasswordChar = True Then
            txtboxAuthToken.UseSystemPasswordChar = False
        Else
            txtboxAuthToken.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If txtboxAccountSID.Text = "" Then
            MessageBox.Show("Please pick a Configuration First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'sqlstr = "DELETE FROM sms_config WHERE AccountSID = '" & cmbboxSMSConfig.SelectedValue.ToString & "'"

        Try
            ConnectDatabase()

            With sqlcmd

                If MessageBox.Show("Are you sure you want to delete this SMS Condfiguration with AccountSID '" & cmbboxSMSConfig.SelectedValue.ToString & "'", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SMSConfiguration"
                    .Parameters.AddWithValue("@QType", "Delete")
                    .Parameters.AddWithValue("@AccSID", cmbboxSMSConfig.SelectedValue.ToString)
                    .Parameters.AddWithValue("@AutToken", "")
                    .Parameters.AddWithValue("@TwillioNumber", "")
                    .ExecuteNonQuery()

                    If cmbboxSMSConfig.SelectedValue.ToString = SMSConfiguration.AccountSID Then
                        SMSConfiguration.AccountSID = ""
                        SMSConfiguration.AuthToken = ""
                        SMSConfiguration.TwillioNumber = ""
                    End If
                    Me.Close()

                    'MsgBox("Configuration Successfully Deleted", MsgBoxStyle.Information, "Information")
                Else

                    Exit Sub

                End If

            End With

            DatabaseDisconnect()
        Catch ex As Exception
            DatabaseDisconnect()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class