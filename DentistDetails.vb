Imports System.ComponentModel

Public Class DentistDetails

    Public FName As String
    Public MName As String
    Public LName As String
    Public EmpID As String
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        If txtboxDentistName.Text = "" Or txtboxLicenseNo.Text = "" Or txtboxPTRNo.Text = "" Then
            MessageBox.Show("Please fill all required fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "InsertDentistDetails"
                .Parameters.AddWithValue("@DentID", EmpID)
                .Parameters.AddWithValue("@License", txtboxLicenseNo.Text)
                .Parameters.AddWithValue("@PTR", txtboxPTRNo.Text)
                .Parameters.AddWithValue("@FName", FName)
                .Parameters.AddWithValue("@MName", MName)
                .Parameters.AddWithValue("@LName", LName)
                .ExecuteNonQuery()
            End With

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try
        Me.Close()
        AddNewUserAccount.Show()
        HomeScreen.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "editDentistDetails"
                .Parameters.AddWithValue("@DentID", LoginAccount.empID)
                .Parameters.AddWithValue("@License", txtboxLicenseNo.Text)
                .Parameters.AddWithValue("@PTR", txtboxPTRNo.Text)
                .ExecuteNonQuery()
            End With
            'MessageBox.Show("Details Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try
        Me.Close()
        ClearUserEmpProfPanel()

        With ProfileBasicInfo
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            AccountProfile.pnlProfile.Controls.Add(ProfileBasicInfo)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub DentistDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtboxDentistName.Text = FName + " " + MName + " " + LName
        txtboxLicenseNo.Select()
    End Sub

    Private Sub DentistDetails_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Input_Validating(sender As Object, e As CancelEventArgs) Handles txtboxPTRNo.Validating, txtboxLicenseNo.Validating, txtboxDentistName.Validating

        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        If (txtbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtbox, String.Empty)
        Else
            ErrorProvider1.SetError(txtbox, "This field is required!")
            txtbox.Select()
        End If

    End Sub
End Class