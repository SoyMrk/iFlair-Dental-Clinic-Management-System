Public Class AccountProfile

    Private Sub btnProfileBasicInfo_Click(sender As Object, e As EventArgs) Handles btnProfileBasicInfo.Click

        ClearUserEmpProfPanel()

        pnlClicked.Width = btnProfileBasicInfo.Width
        pnlClicked.Left = btnProfileBasicInfo.Left

        With ProfileBasicInfo
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlProfile.Controls.Add(ProfileBasicInfo)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnProfileAddressInfo_Click(sender As Object, e As EventArgs) Handles btnProfileAddressInfo.Click

        ClearUserEmpProfPanel()

        pnlClicked.Width = btnProfileAddressInfo.Width
        pnlClicked.Left = btnProfileAddressInfo.Left

        With ProfileAddressInfo
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlProfile.Controls.Add(ProfileAddressInfo)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnProfileAccountInfo_Click(sender As Object, e As EventArgs) Handles btnProfileAccountInfo.Click

        ClearUserEmpProfPanel()

        pnlClicked.Width = btnProfileAccountInfo.Width
        pnlClicked.Left = btnProfileAccountInfo.Left

        With ProfileAccountInfo
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlProfile.Controls.Add(ProfileAccountInfo)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub AccountProfile_Load(sender As Object, e As EventArgs) Handles Me.Load

        btnProfileBasicInfo_Click(sender, e)

        If LoginAccount.userType = "Administrator" Then
            txtboxRole.Text = "Administrator"
        Else
            txtboxRole.Text = "Staff"
        End If


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

                    txtboxName.Text = myreader("EmpLastName").ToString & ", " & myreader("EmpFirstName").ToString
                    txtboxContactNo.Text = myreader("EmpContactNo").ToString
                    txtboxMunPov.Text = myreader("EmpMunicipality").ToString + ", " + myreader("EmpProvince").ToString
                    txtboxDateofBirth.Text = myreader.GetDateTime("DateofBirth").ToString("MM/dd/yyyy")

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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With

        DatabaseDisconnect()


        If HomeScreen.AccountProfilePanel = ProfileBasicInfo.Name Then

            btnProfileBasicInfo_Click(sender, e)

        ElseIf HomeScreen.AccountProfilePanel = EditProfileBasic.Name Then

            pnlClicked.Width = btnProfileBasicInfo.Width
            pnlClicked.Left = btnProfileBasicInfo.Left

            ClearUserEmpProfPanel()

            With EditProfileBasic
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill And DockStyle.Bottom
                .AutoSize = True
                .TopLevel = False
                Me.pnlProfile.Controls.Add(EditProfileBasic)
                .BringToFront()
                .Show()
            End With

        ElseIf HomeScreen.AccountProfilePanel = ProfileAddressInfo.Name Then

            btnProfileAddressInfo_Click(sender, e)

        ElseIf HomeScreen.AccountProfilePanel = EditProfileAddress.Name Then

            pnlClicked.Width = btnProfileAddressInfo.Width
            pnlClicked.Left = btnProfileAddressInfo.Left

            ClearUserEmpProfPanel()

            With EditProfileAddress
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill And DockStyle.Bottom
                .AutoSize = True
                .TopLevel = False
                Me.pnlProfile.Controls.Add(EditProfileAddress)
                .BringToFront()
                .Show()
            End With

        ElseIf HomeScreen.AccountProfilePanel = ProfileAccountInfo.Name Then

            btnProfileAccountInfo_Click(sender, e)

        ElseIf HomeScreen.AccountProfilePanel = EditProfilePassword.Name Then

            pnlClicked.Width = btnProfileAccountInfo.Width
            pnlClicked.Left = btnProfileAccountInfo.Left

            ClearUserEmpProfPanel()

            With EditProfilePassword
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill And DockStyle.Bottom
                .AutoSize = True
                .TopLevel = False
                Me.pnlProfile.Controls.Add(EditProfilePassword)
                .BringToFront()
                .Show()
            End With

        ElseIf HomeScreen.AccountProfilePanel = EditProfileUsername.Name Then

            pnlClicked.Width = btnProfileAccountInfo.Width
            pnlClicked.Left = btnProfileAccountInfo.Left

            ClearUserEmpProfPanel()

            With EditProfileUsername
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill And DockStyle.Bottom
                .AutoSize = True
                .TopLevel = False
                Me.pnlProfile.Controls.Add(EditProfileUsername)
                .BringToFront()
                .Show()
            End With

        End If


    End Sub

    Private Sub btnUploadPhoto_Click(sender As Object, e As EventArgs) Handles btnUploadPhoto.Click

        Dim imgpath As String

        Try

            Dim ofd As New OpenFileDialog

            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"

            If ofd.ShowDialog() = DialogResult.OK Then

                imgpath = ofd.FileName
                picboxEmployeePhoto.SizeMode = PictureBoxSizeMode.StretchImage
                picboxEmployeePhoto.ImageLocation = imgpath

                'MessageBox.Show("Photo Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Exit Sub
            End If

            ofd = Nothing

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()

        End Try

        Dim arrImage() As Byte
        Dim msstream As New System.IO.MemoryStream()
        picboxEmployeePhoto.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()

        Try

            ConnectDatabase()

            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "editEmployeePhoto"
                .Parameters.AddWithValue("@EmpID", LoginAccount.empID)
                .Parameters.AddWithValue("@EmployeePhoto", arrImage)

                Dim x As Integer

                x = .ExecuteNonQuery()

                'If x > 0 Then
                '    MessageBox.Show("Photo Updated")
                'Else
                '    MessageBox.Show("Photo Not Updated")
                'End If

            End With

            DatabaseDisconnect()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()

        End Try

    End Sub

    Private Sub AccountProfile_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        For Each AccounProfileFormName As Form In pnlProfile.Controls

            'MsgBox(recordFormName.Name + "leave state")

            HomeScreen.AccountProfilePanel = AccounProfileFormName.Name

        Next

        'HomeScreen.PatientRecordScreenPanel = Nothing

    End Sub
End Class