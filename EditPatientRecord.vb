Public Class EditPatientRecord

    Public newContactNumber As String
    Public oldContactNumber As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        ClearPatientPanel()

        With PatientProfile
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            PatientRecordScreen.PatientProfilePanel.Controls.Add(PatientProfile)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub EditPatientRecord_Load(sender As Object, e As EventArgs) Handles Me.Load

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getPatient"
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()

                    txtboxPatientNumber.Text = myreader("Patientid").ToString
                    txtboxLastName.Text = myreader("LastName").ToString
                    txtboxFirstName.Text = myreader("FirstName").ToString
                    txtboxMiddleName.Text = myreader("MiddleName").ToString
                    txtboxNickname.Text = myreader("Nickname").ToString
                    dtpickerDateofBirth.Value = myreader("DateofBirth")

                    cmbboxSex.Text = myreader("Gender").ToString
                    txtboxAge.Text = myreader("Age").ToString
                    txtboxContactNo.Text = myreader("PatContactNo").ToString
                    txtboxReligion.Text = myreader("Religion").ToString
                    txtboxNationality.Text = myreader("Nationality").ToString
                    txtboxOccupation.Text = myreader("PatientOccupation").ToString

                    txtboxParentsName.Text = myreader("GuardianName").ToString
                    txtboxParentOccupation.Text = myreader("GuardianOccupation").ToString

                    txtboxReferredBy.Text = myreader("ReferredBy").ToString
                    txtboxReason.Text = myreader("ConsultReason").ToString
                    txtboxComments.Text = myreader("Comment").ToString


                    txtboxPreviousDentist.Text = myreader("PreviousDentist").ToString
                    txtboxLastDentalVisit.Text = myreader("LastDentalVisit").ToString

                    If Not IsDBNull(myreader("PatientPhoto")) Then

                        Dim arrimage() As Byte
                        arrimage = myreader("PatientPhoto")

                        Dim msstream As New System.IO.MemoryStream(arrimage)
                        picboxPatientPhoto.SizeMode = PictureBoxSizeMode.StretchImage
                        picboxPatientPhoto.Image = Image.FromStream(msstream)


                    End If

                End While



            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With

        DatabaseDisconnect()
        oldContactNumber = txtboxContactNo.Text
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        newContactNumber = txtboxContactNo.Text
        If newContactNumber <> oldContactNumber Then
            If validatePhoneNumber(txtboxContactNo.Text) Then
                newContactNumber = txtboxContactNo.Text.Remove(0, 1)
                newContactNumber = "+63" + newContactNumber
            Else
                MsgBox("Invalid Phone Number" & Environment.NewLine & "Ex. 09xxxxxxxxx", MsgBoxStyle.Exclamation, "Information")
                txtboxContactNo.Select()
                Exit Sub
            End If
        End If


        Dim allTxt As New List(Of Control)
        For Each txt As TextBox In FindControlRecursive(allTxt, Me, GetType(TextBox))
            If Not (txt.Name = txtboxMiddleName.Name Or txt.Name = txtboxNickname.Name Or txt.Name = txtboxParentsName.Name Or txt.Name = txtboxParentOccupation.Name Or txt.Name = txtboxComments.Name Or txt.Name = txtboxReferredBy.Name Or txt.Name = txtboxReason.Name Or txt.Name = txtboxPreviousDentist.Name Or txt.Name = txtboxLastDentalVisit.Name) Then
                If txt.Text = "" Then
                    MsgBox(txt.AccessibleName & " field is required", MsgBoxStyle.Exclamation, "Information")
                    txt.Select()
                    Exit Sub
                End If
                'MsgBox(txt.Name)
            End If
        Next


        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "editPatient"
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@QType", "Info")
                .Parameters.AddWithValue("@FName", txtboxFirstName.Text)
                .Parameters.AddWithValue("@MName", txtboxMiddleName.Text)
                .Parameters.AddWithValue("@LName", txtboxLastName.Text)
                .Parameters.AddWithValue("@NName", txtboxNickname.Text)
                .Parameters.AddWithValue("@PatGender", cmbboxSex.Text)
                .Parameters.AddWithValue("@ContactNo", newContactNumber)
                .Parameters.AddWithValue("@Birthdate", dtpickerDateofBirth.Text)
                .Parameters.AddWithValue("@PatAge", txtboxAge.Text)
                .Parameters.AddWithValue("@PatReligion", txtboxReligion.Text)
                .Parameters.AddWithValue("@PatNationality", txtboxNationality.Text)
                .Parameters.AddWithValue("@PatOccupation", txtboxOccupation.Text)
                .Parameters.AddWithValue("@PatGuardianName", txtboxParentsName.Text)
                .Parameters.AddWithValue("@GuardianOccupation", txtboxParentOccupation.Text)
                .Parameters.AddWithValue("@PatRefferor", txtboxReferredBy.Text)
                .Parameters.AddWithValue("@PatConsultReason", txtboxReason.Text)
                .Parameters.AddWithValue("@PatComment", txtboxComments.Text)
                .Parameters.AddWithValue("@PatPreviousDentist", txtboxPreviousDentist.Text)
                .Parameters.AddWithValue("@PatLastDentalVisit", txtboxLastDentalVisit.Text)
                .Parameters.AddWithValue("@PatHouseNumber", "")
                .Parameters.AddWithValue("@PatStreet", "")
                .Parameters.AddWithValue("@PatProvince", "")
                .Parameters.AddWithValue("@PatMunicipality", "")
                .Parameters.AddWithValue("@PatBarangay", "")
                .Parameters.AddWithValue("@PatZipCode", DBNull.Value)

                .ExecuteNonQuery()
                'MsgBox("Patient Information Updated", MsgBoxStyle.Information, "Information")
                DatabaseDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try
        End With

        ClearPatientPanel()

        With PatientProfile
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            PatientRecordScreen.PatientProfilePanel.Controls.Add(PatientProfile)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnChangePhoto_Click(sender As Object, e As EventArgs) Handles btnChangePhoto.Click

        Dim imgpath As String

        Try
            Dim ofd As FileDialog = New OpenFileDialog

            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"

            If ofd.ShowDialog() = DialogResult.OK Then

                imgpath = ofd.FileName
                picboxPatientPhoto.SizeMode = PictureBoxSizeMode.StretchImage

                picboxPatientPhoto.ImageLocation = imgpath
                PatientRecordScreen.picboxPatient.ImageLocation = imgpath

                MessageBox.Show("Photo Changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Exit Sub
            End If

            ofd = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()

        End Try

        Dim arrImage() As Byte
        Dim msstream As New System.IO.MemoryStream()
        picboxPatientPhoto.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()

        Try

            ConnectDatabase()

            'sqlstr = "UPDATE patient SET PatientPhoto=@patientphoto WHERE PatientID = '" & PatientRecordScreen.MyPatientID & "'"

            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "editPatientPhoto"
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@PatPhoto", arrImage)

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

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()

        End Try



    End Sub

    Private Sub txtboxLastName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtboxReligion.Validating, txtboxParentsName.Validating, txtboxParentOccupation.Validating, txtboxOccupation.Validating, txtboxNickname.Validating, txtboxNationality.Validating, txtboxLastName.Validating, txtboxFirstName.Validating, txtboxContactNo.Validating

        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        If (txtbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtbox, String.Empty)
        Else
            ErrorProvider1.SetError(txtbox, "This field is required!")
            txtbox.Select()
        End If

    End Sub

    Private Sub cmbboxSex_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbboxSex.Validating

        Dim cmbbox As ComboBox = DirectCast(sender, ComboBox)

        If (cmbbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(cmbbox, String.Empty)
        Else
            ErrorProvider1.SetError(cmbbox, "This field is required!")
            cmbbox.Select()
        End If

    End Sub

    Private Sub txtboxContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxContactNo.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            'MsgBox("Numeric Input Only")
        End If

    End Sub

    Private Sub txtboxAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxAge.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            'MsgBox("Numeric Input Only")
        End If
    End Sub

    Private Sub dtpickerDateofBirth_ValueChanged(sender As Object, e As EventArgs) Handles dtpickerDateofBirth.ValueChanged
        If dtpickerDateofBirth.Value.Date = Date.Today Or dtpickerDateofBirth.Value.Date > Date.Today Then
            MsgBox("Enter a valid Birthdate", MsgBoxStyle.Exclamation, "Information")
            Exit Sub
        End If

        Dim age As Integer
        Dim dateOfBirth As DateTime = dtpickerDateofBirth.Value
        age = Today.Year - dateOfBirth.Year

        If (dateOfBirth > Today.AddYears(-age)) Then
            age -= 1
        End If

        txtboxAge.Text = age

    End Sub

    Private Sub EditPatientRecord_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
            e.SuppressKeyPress = True
        End If
    End Sub
End Class