Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class EditEmployeeDetails

    Public newContactNumber As String
    Private Sub EditEmployeeDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sqlstr = "SELECT * FROM `employee` WHERE EmployeeID = '" & Employee.EmpID & "'"

        'MsgBox(sqlstr)

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getEmployee"
                .Parameters.AddWithValue("@EmpID", Employee.EmpID)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() Then

                    txtboxEmployeeNumber.Text = myreader("EmployeeID")
                    cmbboxJobPosition.Text = myreader("JobPosition")
                    txtboxLastName.Text = myreader("EmpLastName")
                    txtboxFirstName.Text = myreader("EmpFirstName")
                    txtboxMiddleName.Text = myreader("EmpMiddleName")
                    dtpickerDateOfBirth.Value = myreader("DateofBirth")
                    txtboxAge.Text = myreader("EmpAge")
                    cmbboxSex.Text = myreader("EmpGender")
                    txtboxContactNumber.Text = myreader("EmpContactNo")
                    txtboxEmailAddress.Text = myreader("EmpEmail")
                    cmbboxGovernmentID.Text = myreader("GovernmentID")
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

                        btnUploadPhoto.Visible = True

                    End If

                End If



            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With

        DatabaseDisconnect()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        HomeScreen.Enabled = True
        Me.Close()


    End Sub

    Private Sub EditEmployeeDetails_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click



        If dtpickerDateOfBirth.Value.Date = Date.Today Or dtpickerDateOfBirth.Value.Date > Date.Today Then
            MsgBox("Please Enter a valid BirthDate", MsgBoxStyle.Exclamation, "Information")
            Exit Sub
        End If

        Dim allTxt As New List(Of Control)
        For Each txt As TextBox In FindControlRecursive(allTxt, Me, GetType(TextBox))
            If Not (txt.Name = txtboxIDNumber.Name Or txt.Name = txtboxMiddleName.Name Or txt.Name = txtboxHouseNo.Name) Then
                If txt.Text = "" Then
                    MsgBox(txt.Name & " field cannot be emppty.", MsgBoxStyle.Exclamation, "Information")
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

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "editEmployee"
                .Parameters.AddWithValue("@QType", "Info")
                .Parameters.AddWithValue("@EmpID", Employee.EmpID)
                .Parameters.AddWithValue("@LastName", txtboxLastName.Text)
                .Parameters.AddWithValue("@MiddleName", txtboxMiddleName.Text)
                .Parameters.AddWithValue("@FirstName", txtboxFirstName.Text)
                .Parameters.AddWithValue("@dateofbirth", dtpickerDateOfBirth.Text)
                .Parameters.AddWithValue("@Age", txtboxAge.Text)
                .Parameters.AddWithValue("@Gender", cmbboxSex.Text)
                .Parameters.AddWithValue("@Contact", newContactNumber)
                .Parameters.AddWithValue("@Email", txtboxEmailAddress.Text)
                .Parameters.AddWithValue("@GovernmentID", cmbboxGovernmentID.Text)
                .Parameters.AddWithValue("@GovIDNum", txtboxIDNumber.Text)
                .Parameters.AddWithValue("@HouseNumber", txtboxHouseNo.Text)
                .Parameters.AddWithValue("@Street", txtboxStreet.Text)
                .Parameters.AddWithValue("@Barangay", txtboxBrgy.Text)
                .Parameters.AddWithValue("@Municipality", txtboxMunicipality.Text)
                .Parameters.AddWithValue("@Province", txtboxProvince.Text)
                .Parameters.AddWithValue("@ZipCode", txtboxZipCode.Text)

                .ExecuteNonQuery()
                'MsgBox("Employee Updated", MsgBoxStyle.Information, "Information")

            Catch ex As Exception
                If ex.Message.Contains("duplicate") Or ex.Message.Contains("Duplicate") Then
                    MessageBox.Show("Email Already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End If

                DatabaseDisconnect()
            End Try

            DatabaseDisconnect()

        End With

        Me.Close()

        HomeScreen.Enabled = True

        Employee.refreshDataGridEmp()

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

                'MsgBox("Photo Updated", MsgBoxStyle.Information, "Information")
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
                .Parameters.AddWithValue("@EmpID", Employee.EmpID)
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

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()

        End Try


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

    Private Sub txtboxContactNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxContactNumber.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            'MsgBox("Numeric Input Only", MsgBoxStyle.Exclamation, "Information")
        End If

    End Sub

    Private Sub Input_Validating(sender As Object, e As CancelEventArgs) Handles txtboxZipCode.Validating, txtboxStreet.Validating, txtboxProvince.Validating, txtboxMunicipality.Validating, txtboxLastName.Validating, txtboxIDNumber.Validating, txtboxFirstName.Validating, txtboxEmailAddress.Validating, txtboxContactNumber.Validating, txtboxBrgy.Validating, txtboxAge.Validating, cmbboxGovernmentID.Validating
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
End Class