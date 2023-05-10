Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ProfileBasicInfo
    Private Sub btnEditBasic_Click(sender As Object, e As EventArgs) Handles btnEditBasic.Click

        ClearUserEmpProfPanel()

        With EditProfileBasic
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            AccountProfile.pnlProfile.Controls.Add(EditProfileBasic)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub ProfileBasicInfo_Load(sender As Object, e As EventArgs) Handles Me.Load

        With sqlcmd
            ConnectDatabase()
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getEmployee"
                .Parameters.AddWithValue("@EmpID", LoginAccount.empID)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() Then

                    txtboxEmployeeNumber.Text = myreader("EmployeeID").ToString
                    txtboxLastName.Text = myreader("EmpLastName").ToString
                    txtboxFirstName.Text = myreader("EmpFirstName").ToString
                    txtboxMiddleName.Text = myreader("EmpMiddleName").ToString
                    txtboxJobPosition.Text = myreader("JobPosition").ToString
                    txtboxDateofBirth.Text = myreader.GetDateTime("DateofBirth").ToString("MM/dd/yyyy")
                    txtboxAge.Text = myreader("EmpAge").ToString
                    txtboxSex.Text = myreader("EmpGender").ToString
                    txtboxContactNo.Text = myreader("EmpContactNo").ToString
                    txtboxEmailAddress.Text = myreader("EmpEmail").ToString
                    txtboxGovID.Text = myreader("GovernmentID").ToString
                    txtboxIDNumber.Text = myreader("IDNumber").ToString

                End If

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With


        If txtboxJobPosition.Text = "Dentist" Then
            lblDentistDetails.Visible = True
            btnUpdateDentistDetails.Visible = True
            txtboxDentistLicense.Visible = True
            txtboxPTRNo.Visible = True
            GroupBoxLicense.Visible = True
            GroupBoxLicense2.Visible = True
            GroupBoxPTR.Visible = True
            GroupBoxPTR2.Visible = True
            Try
                ConnectDatabase()
                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "getDentistDetails"
                    .Parameters.AddWithValue("@DentID", LoginAccount.empID)
                    'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                    myreader = sqlcmd.ExecuteReader

                    If myreader.Read() Then
                        txtboxDentistLicense.Text = myreader("LicenseNo")
                        txtboxPTRNo.Text = myreader("PTRNo")
                    End If
                End With
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If

    End Sub

    Private Sub btnUpdateDentistDetails_Click(sender As Object, e As EventArgs) Handles btnUpdateDentistDetails.Click
        HomeScreen.Enabled = False
        DentistDetails.EmpID = LoginAccount.empID
        DentistDetails.FName = txtboxFirstName.Text
        DentistDetails.MName = txtboxMiddleName.Text
        DentistDetails.LName = txtboxLastName.Text

        DentistDetails.Show()

        DentistDetails.txtboxLicenseNo.Text = txtboxDentistLicense.Text
        DentistDetails.txtboxPTRNo.Text = txtboxPTRNo.Text

        DentistDetails.btnUpdate.Visible = True
        DentistDetails.btnCancel.Visible = True
        DentistDetails.btnContinue.Visible = False
    End Sub

End Class