Imports System.ComponentModel

Public Class AddNewEmployee

    Public newContactNumber As String

    Private Sub btnAddNewEmployee_Click(sender As Object, e As EventArgs) Handles btnAddNewEmployee.Click

        If dtpickerDateOfBirth.Value.Date = Date.Today Or dtpickerDateOfBirth.Value.Date > Date.Today Then
            MsgBox("Please Enter a valid BirthDate", MsgBoxStyle.Exclamation, "Information")
            Exit Sub
        End If

        Dim allTxt As New List(Of Control)
        For Each txt As TextBox In FindControlRecursive(allTxt, Me, GetType(TextBox))
            If Not (txt.Name = txtboxIDNumber.Name Or txt.Name = txtboxMiddleName.Name Or txt.Name = txtboxHouseNumber.Name) Then
                If txt.Text = "" Then
                    MsgBox(txt.AccessibleName & " field cannot be emppty.", MsgBoxStyle.Exclamation, "Information")
                    txt.Select()
                    Exit Sub
                End If
            End If
            'MsgBox(txt.Name)
        Next

        If cmbboxJobPosition.Text = "" Then
            MsgBox("Job Position cannot be empty", MsgBoxStyle.Exclamation, "Information")
            Exit Sub
        ElseIf cmbboxSex.Text = "" Then
            MsgBox("Gender cannot be empty", MsgBoxStyle.Exclamation, "Information")
            Exit Sub
        ElseIf cmbboxGovernmentID.Text = "" Then
            MsgBox("Government ID cannot be empty", MsgBoxStyle.Exclamation, "Information")
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

        If picboxEmployeePhoto.Image Is Nothing Then

            Try

                'sqlstr = "INSERT INTO employee(EmployeeID, EmpFirstName, EmpMiddleName, EmpLastName, JobPosition, DateofBirth, EmpAge, EmpGender, EmpHouseNumber, EmpStreet, EmpBarangay, EmpMunicipality, EmpProvince, EmpZipCode, EmpEmail, EmpContactNo, GovernmentID, IDNumber) " _
                '        & "VALUES(@employeeid,@firstname,@middlename,@lastname,@jobposition,@dateofbirth,@age,@gender,@housenumber,@street,@barangay,@municipality,@provivnce,@zipcode,@email,@contact,@governmentid,@idnumber)"

                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewEmployee"

                    .Parameters.AddWithValue("@EmpId", txtboxEmployeeNumber.Text)
                    .Parameters.AddWithValue("@FName", txtboxFirstName.Text)
                    .Parameters.AddWithValue("@MName", txtboxMiddleName.Text)
                    .Parameters.AddWithValue("@LName", txtboxLastName.Text)
                    .Parameters.AddWithValue("@JobPstn", cmbboxJobPosition.Text)
                    .Parameters.AddWithValue("@Birthdate", dtpickerDateOfBirth.Text)
                    .Parameters.AddWithValue("@Age", txtboxAge.Text)
                    .Parameters.AddWithValue("@Gender", cmbboxSex.Text)
                    .Parameters.AddWithValue("@HouseNumber", txtboxHouseNumber.Text)
                    .Parameters.AddWithValue("@Street", txtboxStreet.Text)
                    .Parameters.AddWithValue("@Barangay", txtboxBrgy.Text)
                    .Parameters.AddWithValue("@Municipality", txtboxMunicipality.Text)
                    .Parameters.AddWithValue("@Province", txtboxProvince.Text)
                    .Parameters.AddWithValue("@ZipCode", txtboxZipCode.Text)
                    .Parameters.AddWithValue("@Email", txtboxEmailAddress.Text)
                    .Parameters.AddWithValue("@ContactNo", newContactNumber)
                    .Parameters.AddWithValue("@GovID", cmbboxGovernmentID.Text)
                    .Parameters.AddWithValue("@GovIDNumber", txtboxIDNumber.Text)
                    .Parameters.AddWithValue("@EmployeePhoto", DBNull.Value)

                    Dim x As Integer

                    x = .ExecuteNonQuery()

                    If x > 0 Then
                        'MessageBox.Show("Employee has been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Employee has not been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End With

                DatabaseDisconnect()

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()

            End Try


        Else

            Dim arrImage() As Byte

            Try

                Dim msstream As New System.IO.MemoryStream
                picboxEmployeePhoto.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = msstream.GetBuffer()
                Dim filesize As UInt32
                filesize = msstream.Length
                msstream.Close()

                'sqlstr = "INSERT INTO employee(EmployeeID, EmpFirstName, EmpMiddleName, EmpLastName, JobPosition, DateofBirth, EmpAge, EmpGender, EmpHouseNumber, EmpStreet, EmpBarangay, EmpMunicipality, EmpProvince, EmpZipCode, EmpEmail, ContactNo, GovernmentID, IDNumber, EmpPhoto) " _
                '       & "VALUES(@employeeid,@firstname,@middlename,@lastname,@jobposition,@dateofbirth,@age,@gender,@housenumber,@street,@barangay,@municipality,@provivnce,@zipcode,@email,@contact,@governmentid,@idnumber,@empphoto)"

                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewEmployee"

                    .Parameters.AddWithValue("@EmpId", txtboxEmployeeNumber.Text)
                    .Parameters.AddWithValue("@FName", txtboxFirstName.Text)
                    .Parameters.AddWithValue("@MName", txtboxMiddleName.Text)
                    .Parameters.AddWithValue("@LName", txtboxLastName.Text)
                    .Parameters.AddWithValue("@JobPstn", cmbboxJobPosition.Text)
                    .Parameters.AddWithValue("@Birthdate", dtpickerDateOfBirth.Text)
                    .Parameters.AddWithValue("@Age", txtboxAge.Text)
                    .Parameters.AddWithValue("@Gender", cmbboxSex.Text)
                    .Parameters.AddWithValue("@HouseNumber", txtboxHouseNumber.Text)
                    .Parameters.AddWithValue("@Street", txtboxStreet.Text)
                    .Parameters.AddWithValue("@Barangay", txtboxBrgy.Text)
                    .Parameters.AddWithValue("@Municipality", txtboxMunicipality.Text)
                    .Parameters.AddWithValue("@Province", txtboxProvince.Text)
                    .Parameters.AddWithValue("@ZipCode", txtboxZipCode.Text)
                    .Parameters.AddWithValue("@Email", txtboxEmailAddress.Text)
                    .Parameters.AddWithValue("@ContactNo", newContactNumber)
                    .Parameters.AddWithValue("@GovID", cmbboxGovernmentID.Text)
                    .Parameters.AddWithValue("@GovIDNumber", txtboxIDNumber.Text)
                    .Parameters.AddWithValue("@EmployeePhoto", arrImage)

                    Dim x As Integer

                    x = .ExecuteNonQuery()

                    If x > 0 Then
                        'MessageBox.Show("Employee has been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Employee has not been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End With

                DatabaseDisconnect()

            Catch ex As Exception

                If ex.Message.Contains("duplicate") Or ex.Message.Contains("Duplicate") Then
                    MessageBox.Show("Email Already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End If

                DatabaseDisconnect()


            End Try

        End If


        Employee.refreshDataGridEmp()

        If cmbboxJobPosition.Text = "Dentist" Then
            DentistDetails.EmpID = txtboxEmployeeNumber.Text
            DentistDetails.FName = txtboxFirstName.Text
            DentistDetails.MName = txtboxMiddleName.Text
            DentistDetails.LName = txtboxLastName.Text
            DentistDetails.Show()
            Me.Close()
            HomeScreen.Enabled = False
        Else
            AddNewUserAccount.Show()
            Me.Close()
            HomeScreen.Enabled = False
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

        HomeScreen.Enabled = True
    End Sub


    Private Sub AddNewEmployee_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
    End Sub

    Private Sub btnUploadPhotoEmployee_Click(sender As Object, e As EventArgs) Handles btnUploadPhotoEmployee.Click

        Dim imgpath As String

        Try

            Dim ofd As New OpenFileDialog

            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"

            If ofd.ShowDialog() = DialogResult.OK Then

                imgpath = ofd.FileName
                picboxEmployeePhoto.SizeMode = PictureBoxSizeMode.StretchImage
                picboxEmployeePhoto.ImageLocation = imgpath

            End If

            ofd = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub AddNewEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim timenow As String = Now().ToString("yyyyMMddHHmmssff")
        Dim newEmpId As String = "EMP" + timenow

        txtboxEmployeeNumber.Text = newEmpId

    End Sub

    Private Sub txtboxLastName_Validating(sender As Object, e As CancelEventArgs) Handles txtboxZipCode.Validating, txtboxStreet.Validating, txtboxProvince.Validating, txtboxMunicipality.Validating, txtboxLastName.Validating, txtboxIDNumber.Validating, txtboxFirstName.Validating, txtboxEmailAddress.Validating, txtboxContactNumber.Validating, txtboxBrgy.Validating
        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        If (txtbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtbox, String.Empty)
        Else
            ErrorProvider1.SetError(txtbox, "This field is required!")
            txtbox.Select()
        End If

        If txtbox.Name = "txtboxEmailAddress" Then
            If IsEmail(txtboxEmailAddress.Text) Then
                ErrorProvider1.SetError(txtbox, String.Empty)
            Else
                ErrorProvider1.SetError(txtbox, "Invalid Email")
                txtbox.Select()
            End If
        End If
    End Sub

    Private Sub txtboxContactNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxContactNumber.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            'MsgBox("Numeric Input Only", MsgBoxStyle.Exclamation, "Information")
        End If

    End Sub

    Private Sub cmbboxJobPosition_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxJobPosition.SelectionChangeCommitted

    End Sub

    Private Sub txtboxAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxAge.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dtpickerDateOfBirth_ValueChanged(sender As Object, e As EventArgs) Handles dtpickerDateOfBirth.ValueChanged

        If dtpickerDateOfBirth.Value.Date = Date.Today Or dtpickerDateOfBirth.Value.Date > Date.Today Then
            MsgBox("Enter a valid Birthdate", MsgBoxStyle.Exclamation, "Information")
            Exit Sub
        End If

        Dim age As Integer
        Dim dateOfBirth As DateTime = dtpickerDateOfBirth.Value
        age = Today.Year - dateOfBirth.Year

        If (dateOfBirth > Today.AddYears(-age)) Then
            age -= 1
        End If

        txtboxAge.Text = age

    End Sub

    Private Sub AddNewEmployee_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
            e.SuppressKeyPress = True
        End If

    End Sub
End Class