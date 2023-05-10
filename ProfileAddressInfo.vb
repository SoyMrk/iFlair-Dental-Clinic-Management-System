Public Class ProfileAddressInfo
    Private Sub btnEditAddress_Click(sender As Object, e As EventArgs) Handles btnEditAddress.Click

        ClearUserEmpProfPanel()

        With EditProfileAddress
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            AccountProfile.pnlProfile.Controls.Add(EditProfileAddress)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub ProfileAddressInfo_Load(sender As Object, e As EventArgs) Handles Me.Load

        'sqlstr = "SELECT * FROM employee WHERE EmployeeID = '" & LoginAccount.empID & "'"

        ConnectDatabase()

        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getEmployee"
                .Parameters.AddWithValue("@EmpID", LoginAccount.empID)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() Then

                    txtboxHouseNo.Text = myreader("EmpHouseNumber").ToString
                    txtboxStreet.Text = myreader("EmpStreet").ToString
                    txtboxBrgy.Text = myreader("EmpBarangay").ToString
                    txtboxProvince.Text = myreader("EmpProvince").ToString
                    txtboxMunicipality.Text = myreader("EmpMunicipality").ToString
                    txtboxZipCode.Text = myreader("EmpZipCode").ToString


                End If



            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With

        DatabaseDisconnect()


    End Sub


End Class