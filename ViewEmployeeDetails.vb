Imports System.ComponentModel

Public Class ViewEmployeeDetails
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ViewEmployeeDetails_Load(sender As Object, e As EventArgs) Handles Me.Load



        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getEmployee"
                .Parameters.AddWithValue("@EmpID", Employee.EmpID)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = .ExecuteReader

                If myreader.Read() Then

                    txtboxEmployeeNumber.Text = myreader("EmployeeID")
                    txtboxJobPosition.Text = myreader("JobPosition")
                    txtboxLastName.Text = myreader("EmpLastName")
                    txtboxFirstName.Text = myreader("EmpFirstName")
                    txtboxMiddleName.Text = myreader("EmpMiddleName")
                    dtpickerDateOfBirth.Value = myreader("DateofBirth")
                    txtboxAge.Text = myreader("EmpAge")
                    txtboxGender.Text = myreader("EmpGender")
                    txtboxContactNumber.Text = myreader("EmpContactNo")
                    txtboxEmailAddress.Text = myreader("EmpEmail")
                    txtboxGovID.Text = myreader("GovernmentID")
                    txtboxIDNumber.Text = myreader("IDNumber")
                    txtboxHouseNo.Text = myreader("EmpHouseNumber")
                    txtboxStreet.Text = myreader("EmpStreet")
                    txtboxBrgy.Text = myreader("EmpBarangay")
                    txtboxProvince.Text = myreader("EmpProvince")
                    txtboxMunicipality.Text = myreader("EmpMunicipality")
                    txtboxZipCode.Text = myreader("EmpZipCode")

                    If Not IsDBNull(myreader("EmpPhoto")) Then

                        Dim arrimage() As Byte
                        arrimage = myreader("EmpPhoto")

                        Dim msstream As New System.IO.MemoryStream(arrimage)
                        picboxEmployeePhoto.SizeMode = PictureBoxSizeMode.StretchImage
                        picboxEmployeePhoto.Image = Image.FromStream(msstream)

                        'btnUploadPhoto.Visible = False

                    End If

                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try
        End With

        DatabaseDisconnect()

    End Sub

    Private Sub ViewEmployeeDetails_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
    End Sub


End Class