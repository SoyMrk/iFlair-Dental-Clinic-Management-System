Public Class EditProfileBasic
    Dim newContactNumber As String
    Dim oldContactNumber As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

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

    Private Sub EditProfileBasic_Load(sender As Object, e As EventArgs) Handles Me.Load


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

                    txtboxEmployeeNumber.Text = myreader("EmployeeID").ToString
                    txtboxLastName.Text = myreader("EmpLastName").ToString
                    txtboxFirstName.Text = myreader("EmpFirstName").ToString
                    txtboxMiddleName.Text = myreader("EmpMiddleName").ToString
                    cmbboxJobPosition.Text = myreader("JobPosition").ToString
                    dtpickerDateOfBirth.Value = myreader("DateofBirth")
                    txtboxAge.Text = myreader("EmpAge").ToString
                    cmbboxSex.Text = myreader("EmpGender").ToString
                    txtboxContactNumber.Text = myreader("EmpContactNo").ToString
                    txtboxEmailAddress.Text = myreader("EmpEmail").ToString
                    cmbboxGovID.Text = myreader("GovernmentID").ToString
                    txtboxIdNumber.Text = myreader("IDNumber").ToString


                End If



            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With

        DatabaseDisconnect()

        oldContactNumber = txtboxContactNumber.Text

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        If dtpickerDateOfBirth.Value.Date = Date.Today Or dtpickerDateOfBirth.Value.Date > Date.Today Then
            MsgBox("Please Enter a valid BirthDate", MsgBoxStyle.Exclamation, "Information")
            Exit Sub
        End If

        Dim allTxt As New List(Of Control)
        For Each txt As TextBox In FindControlRecursive(allTxt, Me, GetType(TextBox))
            If Not txt.Name = txtboxMiddleName.Name Then
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
        ElseIf cmbboxGovID.Text = "" Then
            MsgBox("Government ID cannot be empty", MsgBoxStyle.Exclamation, "Information")
            Exit Sub
        End If

        newContactNumber = txtboxContactNumber.Text
        If newContactNumber <> oldContactNumber Then
            If validatePhoneNumber(txtboxContactNumber.Text) Then
                newContactNumber = txtboxContactNumber.Text.Remove(0, 1)
                newContactNumber = "+63" + newContactNumber
            Else
                MsgBox("Invalid Phone Number", MsgBoxStyle.Exclamation, "Information")
                txtboxContactNumber.Select()
                Exit Sub
            End If
        End If



        'sqlstr = "UPDATE employee SET  EmpLastName ='" & txtboxLastName.Text & "', EmpFirstName='" & txtboxFirstName.Text & "', EmpMiddleName='" & txtboxMiddleName.Text & "', JobPosition='" & cmbboxJobPosition.Text & "', DateofBirth='" & dtpickerDateOfBirth.Text & "', EmpAge='" & txtboxAge.Text & "', EmpGender='" & cmbboxSex.Text & "', ContactNo='" & newContactNumber & "', EmpEmail='" & txtboxEmailAddress.Text & "', GovernmentID='" & cmbboxGovID.Text & "', IDNumber='" & txtboxIdNumber.Text & "' WHERE EmployeeID ='" & LoginAccount.empID & "'"
        'MsgBox(sqlstr)
        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "EditEmployee"
                .Parameters.AddWithValue("@QType", "Basic")
                .Parameters.AddWithValue("@EmpID", LoginAccount.empID)
                .Parameters.AddWithValue("@LastName", txtboxLastName.Text)
                .Parameters.AddWithValue("@MiddleName", txtboxMiddleName.Text)
                .Parameters.AddWithValue("@FirstName", txtboxFirstName.Text)
                .Parameters.AddWithValue("@dateofbirth", dtpickerDateOfBirth.Text)
                .Parameters.AddWithValue("@Age", txtboxAge.Text)
                .Parameters.AddWithValue("@Gender", cmbboxSex.Text)
                .Parameters.AddWithValue("@Contact", newContactNumber)
                .Parameters.AddWithValue("@Email", txtboxEmailAddress.Text)
                .Parameters.AddWithValue("@GovernmentID", cmbboxGovID.Text)
                .Parameters.AddWithValue("@GovIDNum", txtboxIdNumber.Text)
                .Parameters.AddWithValue("@HouseNumber", "")
                .Parameters.AddWithValue("@Street", "")
                .Parameters.AddWithValue("@Barangay", "")
                .Parameters.AddWithValue("@Municipality", "")
                .Parameters.AddWithValue("@Province", "")
                .Parameters.AddWithValue("@ZipCode", "")

                .ExecuteNonQuery()
                'MsgBox("Employee Updated", MsgBoxStyle.Information, "Information")

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

            DatabaseDisconnect()

        End With

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

    Private Sub txtboxContactNumber_Click(sender As Object, e As EventArgs) Handles txtboxContactNumber.Click
        txtboxContactNumber.Text = ""
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

        Dim now As DateTime = Date.Now
        Dim dateOfBirth As DateTime = dtpickerDateOfBirth.Value
        Dim Age As Integer = now.Year - dateOfBirth.Year
        If now.Month Or (now.Month = dateOfBirth.Month And now.Day < dateOfBirth.Day) Then
            Age -= 1
        End If

        If Age >= 0 Then
            txtboxAge.Text = Age
        End If
    End Sub

    Private Sub txtboxFirstName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtboxLastName.Validating, txtboxIdNumber.Validating, txtboxFirstName.Validating, txtboxEmailAddress.Validating, txtboxContactNumber.Validating, txtboxAge.Validating, cmbboxSex.Validating, cmbboxJobPosition.Validating, cmbboxGovID.Validating

        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        If (txtbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtbox, String.Empty)
        Else
            ErrorProvider1.SetError(txtbox, "This field is required!")
            txtbox.Select()
        End If

    End Sub
End Class