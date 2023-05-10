Imports System.ComponentModel

Public Class AddNewPatient

    Public newContactNumber As String

    Private Sub AddNewPatient_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim timenow As String = Now().ToString("yyyyMMddHHmmssff")
        Dim newPatientID As String = "PAT" + timenow

        txtboxPatientNumber.Text = newPatientID

        txtboxFirstName.Select()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim allTxt As New List(Of Control)
        For Each txt As TextBox In FindControlRecursive(allTxt, Me, GetType(TextBox))
            If Not (txt.Name = txtboxMiddleName.Name Or txt.Name = txtboxHouseNumber.Name Or txt.Name = txtboxNickname.Name Or txt.Name = txtboxParentName.Name Or txt.Name = txtboxParentOccupation.Name Or txt.Name = txtboxComments.Name Or txt.Name = txtboxReferredBy.Name Or txt.Name = txtboxReason.Name Or txt.Name = txtboxPreviiousDentist.Name Or txt.Name = txtboxLastDentalVisit.Name) Then
                If txt.Text = "" Then
                    MsgBox(txt.AccessibleName & " field is required", MsgBoxStyle.Exclamation, "Information")
                    txt.Select()
                    Exit Sub
                End If
            End If
            'MsgBox(txt.Name)
        Next

        If dtpickerDateofBirth.Value.Date = Date.Today Or dtpickerDateofBirth.Value.Date > Date.Today Then
            MsgBox("Enter a Valid Birthday", MsgBoxStyle.Exclamation, "Information")
            Exit Sub
        End If

        If cmbboxSex.Text = "" Then
            MsgBox("Please pick a Gender", MsgBoxStyle.Exclamation, "Information")
            Exit Sub
        End If


        If validatePhoneNumber(txtboxContactNumber.Text) Then
            newContactNumber = txtboxContactNumber.Text.Remove(0, 1)
            newContactNumber = "+63" + newContactNumber
        Else
            MsgBox("Invalid Phone Number", MsgBoxStyle.Exclamation, "Information")
            txtboxContactNumber.Select()
            Exit Sub
        End If


        If picboxPatient.Image Is Nothing Then
            'MsgBox("Wala")

            Try

                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewPatient"

                    .Parameters.AddWithValue("@PatID", txtboxPatientNumber.Text)
                    .Parameters.AddWithValue("@FName", txtboxFirstName.Text)
                    .Parameters.AddWithValue("@MName", txtboxMiddleName.Text)
                    .Parameters.AddWithValue("@LName", txtboxLastName.Text)
                    .Parameters.AddWithValue("@NName", txtboxNickname.Text)
                    .Parameters.AddWithValue("@Gndr", cmbboxSex.Text)
                    .Parameters.AddWithValue("@Contact", newContactNumber)
                    .Parameters.AddWithValue("@Birthday", dtpickerDateofBirth.Text)
                    .Parameters.AddWithValue("@PatAge", txtboxAge.Text)
                    .Parameters.AddWithValue("@Rlgn", txtboxReligion.Text)
                    .Parameters.AddWithValue("@Ntnlty", txtboxNationality.Text)
                    .Parameters.AddWithValue("@PatOccupation", txtboxOccupation.Text)
                    .Parameters.AddWithValue("@GrdnName", txtboxParentName.Text)
                    .Parameters.AddWithValue("@GrdnOccupation", txtboxParentOccupation.Text)
                    .Parameters.AddWithValue("@HNumber", txtboxHouseNumber.Text)
                    .Parameters.AddWithValue("@Strt", txtboxStreet.Text)
                    .Parameters.AddWithValue("@Prvnce", txtboxProvince.Text)
                    .Parameters.AddWithValue("@Mncply", txtboxMunicipality.Text)
                    .Parameters.AddWithValue("@Brngy", txtboxBarangay.Text)
                    .Parameters.AddWithValue("@zpcd", txtboxZipCode.Text)
                    .Parameters.AddWithValue("@rfrrdBy", txtboxReferredBy.Text)
                    .Parameters.AddWithValue("@CReason", txtboxReason.Text)
                    .Parameters.AddWithValue("@Comments", txtboxComments.Text)
                    .Parameters.AddWithValue("@prvsDentist", txtboxPreviiousDentist.Text)
                    .Parameters.AddWithValue("@lstDentalVst", txtboxLastDentalVisit.Text)
                    .Parameters.AddWithValue("@patPhoto", DBNull.Value)

                    Dim x As Integer

                    x = .ExecuteNonQuery()

                    If x > 0 Then
                        'MessageBox.Show("Patient has been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Patiient has not been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End With

                DatabaseDisconnect()

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()

            End Try

            Me.Close()

            HomeScreen.Enabled = True

        Else

            'MsgBox("May Picture")

            Dim arrImage() As Byte

            Try

                Dim msstream As New System.IO.MemoryStream
                picboxPatient.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = msstream.GetBuffer()
                Dim filesize As UInt32
                filesize = msstream.Length
                msstream.Close()

                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewPatient"

                    .Parameters.AddWithValue("@PatID", txtboxPatientNumber.Text)
                    .Parameters.AddWithValue("@FName", txtboxFirstName.Text)
                    .Parameters.AddWithValue("@MName", txtboxMiddleName.Text)
                    .Parameters.AddWithValue("@LName", txtboxLastName.Text)
                    .Parameters.AddWithValue("@NName", txtboxNickname.Text)
                    .Parameters.AddWithValue("@Gndr", cmbboxSex.Text)
                    .Parameters.AddWithValue("@Contact", newContactNumber)
                    .Parameters.AddWithValue("@Birthday", dtpickerDateofBirth.Text)
                    .Parameters.AddWithValue("@PatAge", txtboxAge.Text)
                    .Parameters.AddWithValue("@Rlgn", txtboxReligion.Text)
                    .Parameters.AddWithValue("@Ntnlty", txtboxNationality.Text)
                    .Parameters.AddWithValue("@PatOccupation", txtboxOccupation.Text)
                    .Parameters.AddWithValue("@GrdnName", txtboxParentName.Text)
                    .Parameters.AddWithValue("@GrdnOccupation", txtboxParentOccupation.Text)
                    .Parameters.AddWithValue("@HNumber", txtboxHouseNumber.Text)
                    .Parameters.AddWithValue("@Strt", txtboxStreet.Text)
                    .Parameters.AddWithValue("@Prvnce", txtboxProvince.Text)
                    .Parameters.AddWithValue("@Mncply", txtboxMunicipality.Text)
                    .Parameters.AddWithValue("@Brngy", txtboxBarangay.Text)
                    .Parameters.AddWithValue("@zpcd", txtboxZipCode.Text)
                    .Parameters.AddWithValue("@rfrrdBy", txtboxReferredBy.Text)
                    .Parameters.AddWithValue("@CReason", txtboxReason.Text)
                    .Parameters.AddWithValue("@Comments", txtboxComments.Text)
                    .Parameters.AddWithValue("@prvsDentist", txtboxPreviiousDentist.Text)
                    .Parameters.AddWithValue("@lstDentalVst", txtboxLastDentalVisit.Text)
                    .Parameters.AddWithValue("@patPhoto", arrImage)

                    Dim x As Integer

                    x = .ExecuteNonQuery()

                    If x > 0 Then
                        'MessageBox.Show("Patient has been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Patiient has not been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End With

                DatabaseDisconnect()

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()

            End Try

            Me.Close()

            HomeScreen.Enabled = True

        End If

        PatientMainScreen.RefreshPatientdataGrid()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        HomeScreen.Enabled = True

        Me.Close()
    End Sub

    Private Sub AddNewPatient_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True

    End Sub

    Private Sub btnUploadPhoto_Click(sender As Object, e As EventArgs) Handles btnUploadPhoto.Click

        Dim imgpath As String

        Try
            Dim ofd As FileDialog = New OpenFileDialog

            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"

            If ofd.ShowDialog() = DialogResult.OK Then

                imgpath = ofd.FileName
                picboxPatient.SizeMode = PictureBoxSizeMode.StretchImage
                picboxPatient.ImageLocation = imgpath


            End If

            ofd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try


    End Sub

    'VALIDATIONS
    Private Sub txtbox_Validating(sender As Object, e As CancelEventArgs) Handles txtboxContactNumber.Validating, txtboxZipCode.Validating, txtboxStreet.Validating, txtboxReligion.Validating, txtboxProvince.Validating, txtboxPatientNumber.Validating, txtboxOccupation.Validating, txtboxNationality.Validating, txtboxMunicipality.Validating, txtboxLastName.Validating, txtboxFirstName.Validating, txtboxBarangay.Validating

        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        If (txtbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtbox, String.Empty)
        Else
            ErrorProvider1.SetError(txtbox, "This field is required!")
            txtbox.Select()
        End If

    End Sub

    Private Sub txtboxContactNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxContactNumber.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            'MsgBox("Numeric Input Only", MsgBoxStyle.Exclamation, "Information")
        End If

    End Sub

    Private Sub cmbboxSex_Validating(sender As Object, e As CancelEventArgs) Handles cmbboxSex.Validating

        Dim cmbbox As ComboBox = DirectCast(sender, ComboBox)

        If (cmbbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(cmbbox, String.Empty)
        Else
            ErrorProvider1.SetError(cmbbox, "This field is required!")
            cmbbox.Select()
        End If

    End Sub

    Private Sub txtboxAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxAge.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
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

    Private Sub AddNewPatient_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub txtboxZipCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxZipCode.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            'MsgBox("Numeric Input Only")
        End If

    End Sub

End Class