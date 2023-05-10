Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class AppointmentNewPatient

    Dim timenow As String = Now().ToString("yyyyMMddHH")
    ' Dim newAppProcID As String
    Dim newAppointmentID As String
    Public newContactNumber As String

    Private Sub AppointmentNewPatient_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            ConnectDatabase()
            Dim ProcTable As New DataTable
            Dim ProcTable2 As New DataTable
            Dim ProcTable3 As New DataTable
            Dim ProcTable4 As New DataTable
            Dim ProcTable5 As New DataTable
            Dim ProcTable6 As New DataTable
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "AppProcedures"
                .Parameters.AddWithValue("@QType", "View")
                .Parameters.AddWithValue("@ProdID", "")
                .Parameters.AddWithValue("@ProdName", "")
                .Parameters.AddWithValue("@ProdDescription", "")
                .Parameters.AddWithValue("@ProdPrice", DBNull.Value)
                .Parameters.AddWithValue("@ProdCategory", "")
            End With
            myAdapter.SelectCommand = sqlcmd
            myAdapter.Fill(ProcTable)
            myAdapter.Fill(ProcTable2)
            myAdapter.Fill(ProcTable3)
            myAdapter.Fill(ProcTable4)
            myAdapter.Fill(ProcTable5)
            myAdapter.Fill(ProcTable6)


            cmbboxProcedure.DataSource = ProcTable
            cmbboxProcedure2.DataSource = ProcTable2
            cmbboxProcedure3.DataSource = ProcTable3
            cmbboxProcedure4.DataSource = ProcTable4
            cmbboxProcedure5.DataSource = ProcTable5
            cmbboxProcedure6.DataSource = ProcTable6

            cmbboxProcedure.ValueMember = "ProcedureID"
            cmbboxProcedure2.ValueMember = "ProcedureID"
            cmbboxProcedure3.ValueMember = "ProcedureID"
            cmbboxProcedure4.ValueMember = "ProcedureID"
            cmbboxProcedure5.ValueMember = "ProcedureID"
            cmbboxProcedure6.ValueMember = "ProcedureID"

            cmbboxProcedure.DisplayMember = "ProcedureName"
            cmbboxProcedure2.DisplayMember = "ProcedureName"
            cmbboxProcedure3.DisplayMember = "ProcedureName"
            cmbboxProcedure4.DisplayMember = "ProcedureName"
            cmbboxProcedure5.DisplayMember = "ProcedureName"
            cmbboxProcedure6.DisplayMember = "ProcedureName"

            DatabaseDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()
        End Try



        Try
            ConnectDatabase()
            Dim DenTable As New DataTable
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getDentists"
            End With
            myAdapter.SelectCommand = sqlcmd
            myAdapter.Fill(DenTable)

            cmbboxDentist.DataSource = DenTable
            cmbboxDentist.ValueMember = "EmployeeID"
            cmbboxDentist.DisplayMember = "EmployeeName"

            DatabaseDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()
        End Try

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getTotalAppointments"
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() Then

                    newAppointmentID = "APT" + timenow + myreader("TotalAppointment").ToString

                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With
        DatabaseDisconnect()

        'dataGridAppDateViewer
        lblGridDate.Text = dtpickerAppDate.Value.ToString("MMMM dd, yyyy")
        Try
            ConnectDatabase()
            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Appointments"
                .Parameters.AddWithValue("@AppFilterDate", "Check")
                .Parameters.AddWithValue("@AppFilterStatus", "Scheduled/Rescheduled")
                .Parameters.AddWithValue("@SearchTxt", dtpickerAppDate.Text)

                myreader = .ExecuteReader

                While myreader.Read()
                    Me.dtgridAppDateViewer.Rows.Add(New Object() {myreader.Item("LastName"), myreader.Item("StartTime"), myreader.Item("EndTime")})
                End While

            End With
            DatabaseDisconnect()

        Catch ex As Exception
            DatabaseDisconnect()
            MessageBox.Show(ex.Message, "Errsssor", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'VALIDATION START
        Dim allTxt As New List(Of Control)
        For Each txt As TextBox In FindControlRecursive(allTxt, Me, GetType(TextBox))
            If Not (txt.Name = txtboxMiddleName.Name Or txt.Name = txtboxHouseNo.Name) Then
                If txt.Text = "" Then
                    MsgBox(txt.Name & " field is required", MsgBoxStyle.Exclamation, "Information")
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

        If cmbboxSex.Text = "" Or cmbboxDentist.Text = "" Then
            MsgBox("Dentist Name Cannot be Empty", MsgBoxStyle.Exclamation, "Information")
            cmbboxDentist.Select()
            Exit Sub
        End If

        If dtpickerAppDate.Value < Date.Today Then
            MsgBox("Enter a date later than today", MsgBoxStyle.Exclamation, "Information")
            Exit Sub
        End If
        'dtpickerAppDate.Value.Date = Date.Today Or

        If txtboxDescription.Text = "" Then
            MessageBox.Show("Description cannot be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtboxDescription.Select()
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


        'VALIDATE TIME
        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "checkAppointmentTime"
                .Parameters.AddWithValue("@NewAppDate", dtpickerAppDate.Text)
                .Parameters.AddWithValue("@AppStartTime", dtpickerStartTime.Value.ToString("hh:mm tt"))
                .Parameters.AddWithValue("@AppEndTime", dtpickerEndTime.Value.ToString("hh:mm tt"))
                .Parameters.AddWithValue("@AppID", "")
            End With

            myreader = sqlcmd.ExecuteReader

            If myreader.HasRows Then
                MessageBox.Show("There is a conflicting schedule on the time that you picked." & Environment.NewLine & "Please Check.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            DatabaseDisconnect()
            Exit Sub
        End Try


        'VALIDATION END

        Dim timenow As String = Now().ToString("yyyyMMddHHmmssff")
        Dim newPatientID As String = "PAT" + timenow

        'sqlstr = "INSERT INTO patient(PatientID, FirstName, MiddleName, LastName, Gender, ContactNo, DateofBirth, Age, HouseNumber, Street, Province, Municipality, Barangay, ZipCode)" _
        '        & "VALUES('" & newPatientID & "','" & txtboxFirstName.Text & "', '" & txtboxMiddleName.Text & "','" & txtboxLastName.Text & "','" & cmbboxSex.Text & "','" & newContactNumber & "'," _
        '        & "'" & dtpickerDateofBirth.Text & "','" & txtboxAge.Text & "','" & txtboxHouseNo.Text & "','" & txtboxStreet.Text & "','" & txtboxProvince.Text & "'," _
        '        & "'" & txtboxMunicipality.Text & "','" & txtboxBrgy.Text & "','" & txtboxZipCode.Text & "');"

        If btnAddProcedure2.Visible = True Then

            Try

                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewPatient"

                    .Parameters.AddWithValue("@PatID", newPatientID)
                    .Parameters.AddWithValue("@FName", txtboxFirstName.Text)
                    .Parameters.AddWithValue("@MName", txtboxMiddleName.Text)
                    .Parameters.AddWithValue("@LName", txtboxLastName.Text)
                    .Parameters.AddWithValue("@NName", "")
                    .Parameters.AddWithValue("@Gndr", cmbboxSex.Text)
                    .Parameters.AddWithValue("@Contact", newContactNumber)
                    .Parameters.AddWithValue("@Birthday", dtpickerDateofBirth.Text)
                    .Parameters.AddWithValue("@PatAge", txtboxAge.Text)
                    .Parameters.AddWithValue("@Rlgn", "")
                    .Parameters.AddWithValue("@Ntnlty", "")
                    .Parameters.AddWithValue("@PatOccupation", "")
                    .Parameters.AddWithValue("@GrdnName", "")
                    .Parameters.AddWithValue("@GrdnOccupation", "")
                    .Parameters.AddWithValue("@HNumber", txtboxHouseNo.Text)
                    .Parameters.AddWithValue("@Strt", txtboxStreet.Text)
                    .Parameters.AddWithValue("@Prvnce", txtboxProvince.Text)
                    .Parameters.AddWithValue("@Mncply", txtboxMunicipality.Text)
                    .Parameters.AddWithValue("@Brngy", txtboxBrgy.Text)
                    .Parameters.AddWithValue("@zpcd", txtboxZipCode.Text)
                    .Parameters.AddWithValue("@rfrrdBy", "")
                    .Parameters.AddWithValue("@CReason", "")
                    .Parameters.AddWithValue("@Comments", "")
                    .Parameters.AddWithValue("@prvsDentist", "")
                    .Parameters.AddWithValue("@lstDentalVst", "")
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



            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewAppointment"
                    .Parameters.AddWithValue("@PrdCount", "1")

                    .Parameters.AddWithValue("@AppID", newAppointmentID)
                    .Parameters.AddWithValue("@PatId", newPatientID)
                    .Parameters.AddWithValue("@DentID", cmbboxDentist.SelectedValue.ToString)
                    .Parameters.AddWithValue("@AppointmentDate", dtpickerAppDate.Text)
                    .Parameters.AddWithValue("@STime", dtpickerStartTime.Value.ToString("hh:mm tt"))
                    .Parameters.AddWithValue("@ETime", dtpickerEndTime.Value.ToString("hh:mm tt"))
                    .Parameters.AddWithValue("@Dscrptn", txtboxDescription.Text)
                    .Parameters.AddWithValue("@Drntn", txtboxDuration.Text)
                    .Parameters.AddWithValue("@AppointmentStatus", "Scheduled")

                    .Parameters.AddWithValue("@Prd1", cmbboxProcedure.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd2", "")
                    .Parameters.AddWithValue("@Prd3", "")
                    .Parameters.AddWithValue("@Prd4", "")
                    .Parameters.AddWithValue("@Prd5", "")
                    .Parameters.AddWithValue("@Prd6", "")

                    .ExecuteNonQuery()
                End With

                'MsgBox("Appointment Registered", MsgBoxStyle.Information, "Information")

                DatabaseDisconnect()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                DatabaseDisconnect()
            End Try

            MsgBox("Patient and Appointment Registered", MsgBoxStyle.Information, "Information")


        ElseIf btnAddProcedure3.Visible = True Then

            Try

                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewPatient"

                    .Parameters.AddWithValue("@PatID", newPatientID)
                    .Parameters.AddWithValue("@FName", txtboxFirstName.Text)
                    .Parameters.AddWithValue("@MName", txtboxMiddleName.Text)
                    .Parameters.AddWithValue("@LName", txtboxLastName.Text)
                    .Parameters.AddWithValue("@NName", "")
                    .Parameters.AddWithValue("@Gndr", cmbboxSex.Text)
                    .Parameters.AddWithValue("@Contact", newContactNumber)
                    .Parameters.AddWithValue("@Birthday", dtpickerDateofBirth.Text)
                    .Parameters.AddWithValue("@PatAge", txtboxAge.Text)
                    .Parameters.AddWithValue("@Rlgn", "")
                    .Parameters.AddWithValue("@Ntnlty", "")
                    .Parameters.AddWithValue("@PatOccupation", "")
                    .Parameters.AddWithValue("@GrdnName", "")
                    .Parameters.AddWithValue("@GrdnOccupation", "")
                    .Parameters.AddWithValue("@HNumber", txtboxHouseNo.Text)
                    .Parameters.AddWithValue("@Strt", txtboxStreet.Text)
                    .Parameters.AddWithValue("@Prvnce", txtboxProvince.Text)
                    .Parameters.AddWithValue("@Mncply", txtboxMunicipality.Text)
                    .Parameters.AddWithValue("@Brngy", txtboxBrgy.Text)
                    .Parameters.AddWithValue("@zpcd", txtboxZipCode.Text)
                    .Parameters.AddWithValue("@rfrrdBy", "")
                    .Parameters.AddWithValue("@CReason", "")
                    .Parameters.AddWithValue("@Comments", "")
                    .Parameters.AddWithValue("@prvsDentist", "")
                    .Parameters.AddWithValue("@lstDentalVst", "")
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

                MsgBox(ex.Message)
                DatabaseDisconnect()

            End Try



            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewAppointment"
                    .Parameters.AddWithValue("@PrdCount", "2")

                    .Parameters.AddWithValue("@AppID", newAppointmentID)
                    .Parameters.AddWithValue("@PatId", newPatientID)
                    .Parameters.AddWithValue("@DentID", cmbboxDentist.SelectedValue.ToString)
                    .Parameters.AddWithValue("@AppointmentDate", dtpickerAppDate.Text)
                    .Parameters.AddWithValue("@STime", dtpickerStartTime.Value.ToString("hh:mm tt"))
                    .Parameters.AddWithValue("@ETime", dtpickerEndTime.Value.ToString("hh:mm tt"))
                    .Parameters.AddWithValue("@Dscrptn", txtboxDescription.Text)
                    .Parameters.AddWithValue("@Drntn", txtboxDuration.Text)
                    .Parameters.AddWithValue("@AppointmentStatus", "Scheduled")

                    .Parameters.AddWithValue("@Prd1", cmbboxProcedure.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd2", cmbboxProcedure2.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd3", "")
                    .Parameters.AddWithValue("@Prd4", "")
                    .Parameters.AddWithValue("@Prd5", "")
                    .Parameters.AddWithValue("@Prd6", "")

                    .ExecuteNonQuery()
                End With

                'MsgBox("Appointment Registered", MsgBoxStyle.Information, "Information")

                DatabaseDisconnect()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                DatabaseDisconnect()
            End Try


            MsgBox("Patient and Appointment Registered", MsgBoxStyle.Information, "Information")


        ElseIf btnAddProcedure4.Visible = True Then

            Try

                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewPatient"

                    .Parameters.AddWithValue("@PatID", newPatientID)
                    .Parameters.AddWithValue("@FName", txtboxFirstName.Text)
                    .Parameters.AddWithValue("@MName", txtboxMiddleName.Text)
                    .Parameters.AddWithValue("@LName", txtboxLastName.Text)
                    .Parameters.AddWithValue("@NName", "")
                    .Parameters.AddWithValue("@Gndr", cmbboxSex.Text)
                    .Parameters.AddWithValue("@Contact", newContactNumber)
                    .Parameters.AddWithValue("@Birthday", dtpickerDateofBirth.Text)
                    .Parameters.AddWithValue("@PatAge", txtboxAge.Text)
                    .Parameters.AddWithValue("@Rlgn", "")
                    .Parameters.AddWithValue("@Ntnlty", "")
                    .Parameters.AddWithValue("@PatOccupation", "")
                    .Parameters.AddWithValue("@GrdnName", "")
                    .Parameters.AddWithValue("@GrdnOccupation", "")
                    .Parameters.AddWithValue("@HNumber", txtboxHouseNo.Text)
                    .Parameters.AddWithValue("@Strt", txtboxStreet.Text)
                    .Parameters.AddWithValue("@Prvnce", txtboxProvince.Text)
                    .Parameters.AddWithValue("@Mncply", txtboxMunicipality.Text)
                    .Parameters.AddWithValue("@Brngy", txtboxBrgy.Text)
                    .Parameters.AddWithValue("@zpcd", txtboxZipCode.Text)
                    .Parameters.AddWithValue("@rfrrdBy", "")
                    .Parameters.AddWithValue("@CReason", "")
                    .Parameters.AddWithValue("@Comments", "")
                    .Parameters.AddWithValue("@prvsDentist", "")
                    .Parameters.AddWithValue("@lstDentalVst", "")
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

                MsgBox(ex.Message)
                DatabaseDisconnect()

            End Try




            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewAppointment"
                    .Parameters.AddWithValue("@PrdCount", "3")

                    .Parameters.AddWithValue("@AppID", newAppointmentID)
                    .Parameters.AddWithValue("@PatId", newPatientID)
                    .Parameters.AddWithValue("@DentID", cmbboxDentist.SelectedValue.ToString)
                    .Parameters.AddWithValue("@AppointmentDate", dtpickerAppDate.Text)
                    .Parameters.AddWithValue("@STime", dtpickerStartTime.Value.ToString("hh:mm tt"))
                    .Parameters.AddWithValue("@ETime", dtpickerEndTime.Value.ToString("hh:mm tt"))
                    .Parameters.AddWithValue("@Dscrptn", txtboxDescription.Text)
                    .Parameters.AddWithValue("@Drntn", txtboxDuration.Text)
                    .Parameters.AddWithValue("@AppointmentStatus", "Scheduled")

                    .Parameters.AddWithValue("@Prd1", cmbboxProcedure.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd2", cmbboxProcedure2.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd3", cmbboxProcedure3.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd4", "")
                    .Parameters.AddWithValue("@Prd5", "")
                    .Parameters.AddWithValue("@Prd6", "")

                    .ExecuteNonQuery()
                End With

                'MsgBox("Appointment Registered", MsgBoxStyle.Information, "Information")

                DatabaseDisconnect()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                DatabaseDisconnect()
            End Try

            MsgBox("Patient and Appointment Registered", MsgBoxStyle.Information, "Information")

        ElseIf btnAddProcedure5.Visible = True Then

            Try

                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewPatient"

                    .Parameters.AddWithValue("@PatID", newPatientID)
                    .Parameters.AddWithValue("@FName", txtboxFirstName.Text)
                    .Parameters.AddWithValue("@MName", txtboxMiddleName.Text)
                    .Parameters.AddWithValue("@LName", txtboxLastName.Text)
                    .Parameters.AddWithValue("@NName", "")
                    .Parameters.AddWithValue("@Gndr", cmbboxSex.Text)
                    .Parameters.AddWithValue("@Contact", newContactNumber)
                    .Parameters.AddWithValue("@Birthday", dtpickerDateofBirth.Text)
                    .Parameters.AddWithValue("@PatAge", txtboxAge.Text)
                    .Parameters.AddWithValue("@Rlgn", "")
                    .Parameters.AddWithValue("@Ntnlty", "")
                    .Parameters.AddWithValue("@PatOccupation", "")
                    .Parameters.AddWithValue("@GrdnName", "")
                    .Parameters.AddWithValue("@GrdnOccupation", "")
                    .Parameters.AddWithValue("@HNumber", txtboxHouseNo.Text)
                    .Parameters.AddWithValue("@Strt", txtboxStreet.Text)
                    .Parameters.AddWithValue("@Prvnce", txtboxProvince.Text)
                    .Parameters.AddWithValue("@Mncply", txtboxMunicipality.Text)
                    .Parameters.AddWithValue("@Brngy", txtboxBrgy.Text)
                    .Parameters.AddWithValue("@zpcd", txtboxZipCode.Text)
                    .Parameters.AddWithValue("@rfrrdBy", "")
                    .Parameters.AddWithValue("@CReason", "")
                    .Parameters.AddWithValue("@Comments", "")
                    .Parameters.AddWithValue("@prvsDentist", "")
                    .Parameters.AddWithValue("@lstDentalVst", "")
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

                MsgBox(ex.Message)
                DatabaseDisconnect()

            End Try



            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewAppointment"
                    .Parameters.AddWithValue("@PrdCount", "4")

                    .Parameters.AddWithValue("@AppID", newAppointmentID)
                    .Parameters.AddWithValue("@PatId", newPatientID)
                    .Parameters.AddWithValue("@DentID", cmbboxDentist.SelectedValue.ToString)
                    .Parameters.AddWithValue("@AppointmentDate", dtpickerAppDate.Text)
                    .Parameters.AddWithValue("@STime", dtpickerStartTime.Value.ToString("hh:mm tt"))
                    .Parameters.AddWithValue("@ETime", dtpickerEndTime.Value.ToString("hh:mm tt"))
                    .Parameters.AddWithValue("@Dscrptn", txtboxDescription.Text)
                    .Parameters.AddWithValue("@Drntn", txtboxDuration.Text)
                    .Parameters.AddWithValue("@AppointmentStatus", "Scheduled")

                    .Parameters.AddWithValue("@Prd1", cmbboxProcedure.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd2", cmbboxProcedure2.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd3", cmbboxProcedure3.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd4", cmbboxProcedure4.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd5", "")
                    .Parameters.AddWithValue("@Prd6", "")

                    .ExecuteNonQuery()
                End With

                'MsgBox("Appointment Registered", MsgBoxStyle.Information, "Information")

                DatabaseDisconnect()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                DatabaseDisconnect()
            End Try

            MsgBox("Patient and Appointment Registered", MsgBoxStyle.Information, "Information")

        ElseIf btnAddProcedure6.Visible = True Then


            Try

                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewPatient"

                    .Parameters.AddWithValue("@PatID", newPatientID)
                    .Parameters.AddWithValue("@FName", txtboxFirstName.Text)
                    .Parameters.AddWithValue("@MName", txtboxMiddleName.Text)
                    .Parameters.AddWithValue("@LName", txtboxLastName.Text)
                    .Parameters.AddWithValue("@NName", "")
                    .Parameters.AddWithValue("@Gndr", cmbboxSex.Text)
                    .Parameters.AddWithValue("@Contact", newContactNumber)
                    .Parameters.AddWithValue("@Birthday", dtpickerDateofBirth.Text)
                    .Parameters.AddWithValue("@PatAge", txtboxAge.Text)
                    .Parameters.AddWithValue("@Rlgn", "")
                    .Parameters.AddWithValue("@Ntnlty", "")
                    .Parameters.AddWithValue("@PatOccupation", "")
                    .Parameters.AddWithValue("@GrdnName", "")
                    .Parameters.AddWithValue("@GrdnOccupation", "")
                    .Parameters.AddWithValue("@HNumber", txtboxHouseNo.Text)
                    .Parameters.AddWithValue("@Strt", txtboxStreet.Text)
                    .Parameters.AddWithValue("@Prvnce", txtboxProvince.Text)
                    .Parameters.AddWithValue("@Mncply", txtboxMunicipality.Text)
                    .Parameters.AddWithValue("@Brngy", txtboxBrgy.Text)
                    .Parameters.AddWithValue("@zpcd", txtboxZipCode.Text)
                    .Parameters.AddWithValue("@rfrrdBy", "")
                    .Parameters.AddWithValue("@CReason", "")
                    .Parameters.AddWithValue("@Comments", "")
                    .Parameters.AddWithValue("@prvsDentist", "")
                    .Parameters.AddWithValue("@lstDentalVst", "")
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

                MsgBox(ex.Message)
                DatabaseDisconnect()

            End Try




            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewAppointment"
                    .Parameters.AddWithValue("@PrdCount", "5")

                    .Parameters.AddWithValue("@AppID", newAppointmentID)
                    .Parameters.AddWithValue("@PatId", newPatientID)
                    .Parameters.AddWithValue("@DentID", cmbboxDentist.SelectedValue.ToString)
                    .Parameters.AddWithValue("@AppointmentDate", dtpickerAppDate.Text)
                    .Parameters.AddWithValue("@STime", dtpickerStartTime.Value.ToString("hh:mm tt"))
                    .Parameters.AddWithValue("@ETime", dtpickerEndTime.Value.ToString("hh:mm tt"))
                    .Parameters.AddWithValue("@Dscrptn", txtboxDescription.Text)
                    .Parameters.AddWithValue("@Drntn", txtboxDuration.Text)
                    .Parameters.AddWithValue("@AppointmentStatus", "Scheduled")

                    .Parameters.AddWithValue("@Prd1", cmbboxProcedure.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd2", cmbboxProcedure2.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd3", cmbboxProcedure3.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd4", cmbboxProcedure4.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd5", cmbboxProcedure5.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd6", "")

                    .ExecuteNonQuery()
                End With

                'MsgBox("Appointment Registered", MsgBoxStyle.Information, "Information")

                DatabaseDisconnect()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                DatabaseDisconnect()
            End Try

            MsgBox("Patient and Appointment Registered", MsgBoxStyle.Information, "Information")

        Else

            Try

                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewPatient"

                    .Parameters.AddWithValue("@PatID", newPatientID)
                    .Parameters.AddWithValue("@FName", txtboxFirstName.Text)
                    .Parameters.AddWithValue("@MName", txtboxMiddleName.Text)
                    .Parameters.AddWithValue("@LName", txtboxLastName.Text)
                    .Parameters.AddWithValue("@NName", "")
                    .Parameters.AddWithValue("@Gndr", cmbboxSex.Text)
                    .Parameters.AddWithValue("@Contact", newContactNumber)
                    .Parameters.AddWithValue("@Birthday", dtpickerDateofBirth.Text)
                    .Parameters.AddWithValue("@PatAge", txtboxAge.Text)
                    .Parameters.AddWithValue("@Rlgn", "")
                    .Parameters.AddWithValue("@Ntnlty", "")
                    .Parameters.AddWithValue("@PatOccupation", "")
                    .Parameters.AddWithValue("@GrdnName", "")
                    .Parameters.AddWithValue("@GrdnOccupation", "")
                    .Parameters.AddWithValue("@HNumber", txtboxHouseNo.Text)
                    .Parameters.AddWithValue("@Strt", txtboxStreet.Text)
                    .Parameters.AddWithValue("@Prvnce", txtboxProvince.Text)
                    .Parameters.AddWithValue("@Mncply", txtboxMunicipality.Text)
                    .Parameters.AddWithValue("@Brngy", txtboxBrgy.Text)
                    .Parameters.AddWithValue("@zpcd", txtboxZipCode.Text)
                    .Parameters.AddWithValue("@rfrrdBy", "")
                    .Parameters.AddWithValue("@CReason", "")
                    .Parameters.AddWithValue("@Comments", "")
                    .Parameters.AddWithValue("@prvsDentist", "")
                    .Parameters.AddWithValue("@lstDentalVst", "")
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

                MsgBox(ex.Message)
                DatabaseDisconnect()

            End Try



            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewAppointment"
                    .Parameters.AddWithValue("@PrdCount", "6")

                    .Parameters.AddWithValue("@AppID", newAppointmentID)
                    .Parameters.AddWithValue("@PatId", newPatientID)
                    .Parameters.AddWithValue("@DentID", cmbboxDentist.SelectedValue.ToString)
                    .Parameters.AddWithValue("@AppointmentDate", dtpickerAppDate.Text)
                    .Parameters.AddWithValue("@STime", dtpickerStartTime.Value.ToString("hh:mm tt"))
                    .Parameters.AddWithValue("@ETime", dtpickerEndTime.Value.ToString("hh:mm tt"))
                    .Parameters.AddWithValue("@Dscrptn", txtboxDescription.Text)
                    .Parameters.AddWithValue("@Drntn", txtboxDuration.Text)
                    .Parameters.AddWithValue("@AppointmentStatus", "Scheduled")

                    .Parameters.AddWithValue("@Prd1", cmbboxProcedure.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd2", cmbboxProcedure2.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd3", cmbboxProcedure3.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd4", cmbboxProcedure4.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd5", cmbboxProcedure5.SelectedValue.ToString)
                    .Parameters.AddWithValue("@Prd6", cmbboxProcedure6.SelectedValue.ToString)

                    .ExecuteNonQuery()
                End With

                'MsgBox("Appointment Registered", MsgBoxStyle.Information, "Information")

                DatabaseDisconnect()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                DatabaseDisconnect()
            End Try

            MsgBox("Patient and Appointment Registered", MsgBoxStyle.Information, "Information")

        End If


        AddAppointment.Close()

        HomeScreen.Enabled = True

    End Sub

    Private Sub dtpickerEndTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpickerEndTime.ValueChanged

        Dim startTime As TimeSpan = New TimeSpan(dtpickerStartTime.Value.Hour, dtpickerStartTime.Value.Minute, dtpickerStartTime.Value.Second)
        Dim endTime As TimeSpan = New TimeSpan(dtpickerEndTime.Value.Hour, dtpickerEndTime.Value.Minute, dtpickerEndTime.Value.Second)
        Dim duration As TimeSpan

        duration = endTime - startTime

        If duration.Hours <= 0 Then
            duration = (duration + New TimeSpan(0, 24, 0, 0, 0))
        End If

        If duration.Hours <> 0 Then
            txtboxDuration.Text = duration.Hours
            lblDuration.Text = "Duration (in Hours)"
        Else
            lblDuration.Text = "Duration (in Minutes)"
            txtboxDuration.Text = duration.Minutes
        End If

    End Sub

    Private Sub dtpickerStartTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpickerStartTime.ValueChanged

        Dim startTime As TimeSpan = New TimeSpan(dtpickerStartTime.Value.Hour, dtpickerStartTime.Value.Minute, dtpickerStartTime.Value.Second)
        Dim endTime As TimeSpan = New TimeSpan(dtpickerEndTime.Value.Hour, dtpickerEndTime.Value.Minute, dtpickerEndTime.Value.Second)
        Dim duration As TimeSpan

        duration = endTime - startTime

        If duration.Hours <= 0 Then
            duration = (duration + New TimeSpan(0, 24, 0, 0, 0))
        End If

        If duration.Hours <> 0 Then
            lblDuration.Text = "Duration (in Hours)"
            txtboxDuration.Text = duration.Hours
        Else
            lblDuration.Text = "Duration (in Minutes)"
            txtboxDuration.Text = duration.Minutes
        End If

    End Sub


    '    Private Sub cmbboxProcedure_TextChanged(sender As Object, e As EventArgs) Handles cmbboxProcedure.TextChanged
    '        sqlstr = "SELECT * FROM dbdentalclinic.procedure WHERE ProcedureId = '" & cmbboxProcedure.SelectedValue.ToString & "'"

    '        ConnectDatabase()

    '        With sqlcmd

    '            Try
    '                .Connection = DBConnection
    '                .CommandType = CommandType.Text
    '                .CommandText = sqlstr
    '                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

    '                myreader = sqlcmd.ExecuteReader

    '                If myreader.Read() Then

    '                    txtboxDescription.Text = myreader("Description")

    '                End If

    '            Catch ex As Exception
    '                MsgBox(ex.Message, MsgBoxStyle.Critical)
    '            End Try

    '        End With

    '        DatabaseDisconnect()

    '    End Sub

    '    Private Sub cmbboxProcedure2_TextChanged(sender As Object, e As EventArgs) Handles cmbboxProcedure2.TextChanged

    '        sqlstr = "SELECT * FROM dbdentalclinic.procedure WHERE ProcedureId = '" & cmbboxProcedure2.SelectedValue.ToString & "'"
    '        ConnectDatabase()

    '        With sqlcmd

    '            Try
    '                .Connection = DBConnection
    '                .CommandType = CommandType.Text
    '                .CommandText = sqlstr
    '                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

    '                myreader = sqlcmd.ExecuteReader

    '                If myreader.Read() Then

    '                    txtboxDescription2.Text = myreader("Description")

    '                End If

    '            Catch ex As Exception
    '                MsgBox(ex.Message, MsgBoxStyle.Critical)
    '            End Try

    '        End With

    '    End Sub

    '    Private Sub cmbboxProcedure3_TextChanged(sender As Object, e As EventArgs) Handles cmbboxProcedure3.TextChanged

    '        sqlstr = "SELECT * FROM dbdentalclinic.procedure WHERE ProcedureId = '" & cmbboxProcedure3.SelectedValue.ToString & "'"
    '        ConnectDatabase()

    '        With sqlcmd

    '            Try
    '                .Connection = DBConnection
    '                .CommandType = CommandType.Text
    '                .CommandText = sqlstr
    '                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

    '                myreader = sqlcmd.ExecuteReader

    '                If myreader.Read() Then

    '                    txtboxDescription3.Text = myreader("Description")

    '                End If

    '            Catch ex As Exception
    '                MsgBox(ex.Message, MsgBoxStyle.Critical)
    '            End Try

    '        End With

    '    End Sub

    '    Private Sub cmbboxProcedure4_TextChanged(sender As Object, e As EventArgs) Handles cmbboxProcedure4.TextChanged

    '        sqlstr = "SELECT * FROM dbdentalclinic.procedure WHERE ProcedureId = '" & cmbboxProcedure4.SelectedValue.ToString & "'"
    '        ConnectDatabase()

    '        With sqlcmd

    '            Try
    '                .Connection = DBConnection
    '                .CommandType = CommandType.Text
    '                .CommandText = sqlstr
    '                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

    '                myreader = sqlcmd.ExecuteReader

    '                If myreader.Read() Then

    '                    txtboxDescription4.Text = myreader("Description")

    '                End If

    '            Catch ex As Exception
    '                MsgBox(ex.Message, MsgBoxStyle.Critical)
    '            End Try

    '        End With

    '    End Sub


    Private Sub btnDelete1_Click(sender As Object, e As EventArgs) Handles btnDelete1.Click
        btnDelete1.Visible = False

        btnAddProcedure2.Visible = True
        lblProcedure2.Visible = False
        cmbboxProcedure2.Visible = False
        btnAddProcedure3.Visible = False
    End Sub

    Private Sub btnDelete2_Click(sender As Object, e As EventArgs) Handles btnDelete2.Click
        btnDelete2.Visible = False
        btnDelete1.Visible = True

        btnAddProcedure3.Visible = True
        lblProcedure3.Visible = False
        cmbboxProcedure3.Visible = False
        btnAddProcedure4.Visible = False
    End Sub

    Private Sub btnDelete3_Click(sender As Object, e As EventArgs) Handles btnDelete3.Click
        btnDelete3.Visible = False
        btnDelete2.Visible = True

        btnAddProcedure4.Visible = True
        lblProcedure4.Visible = False
        cmbboxProcedure4.Visible = False
        btnAddProcedure5.Visible = False
    End Sub

    Private Sub btnDelete4_Click(sender As Object, e As EventArgs) Handles btnDelete4.Click
        btnDelete4.Visible = False
        btnDelete3.Visible = True

        btnAddProcedure5.Visible = True
        lblProcedure5.Visible = False
        cmbboxProcedure5.Visible = False
        btnAddProcedure6.Visible = False
    End Sub

    Private Sub btnDelete5_Click(sender As Object, e As EventArgs) Handles btnDelete5.Click
        btnDelete5.Visible = False
        btnDelete4.Visible = True

        btnAddProcedure6.Visible = True
        lblProcedure6.Visible = False
        cmbboxProcedure6.Visible = False
    End Sub

    Private Sub btnAddProcedure2_Click(sender As Object, e As EventArgs) Handles btnAddProcedure2.Click
        btnDelete1.Visible = True

        btnAddProcedure2.Visible = False
        lblProcedure2.Visible = True
        cmbboxProcedure2.Visible = True
        btnAddProcedure3.Visible = True


    End Sub

    Private Sub btnAddProcedure3_Click(sender As Object, e As EventArgs) Handles btnAddProcedure3.Click
        btnDelete1.Visible = False
        btnDelete2.Visible = True

        btnAddProcedure3.Visible = False
        lblProcedure3.Visible = True
        cmbboxProcedure3.Visible = True
        btnAddProcedure4.Visible = True

    End Sub

    Private Sub btnAddProcedure4_Click(sender As Object, e As EventArgs) Handles btnAddProcedure4.Click
        btnDelete2.Visible = False
        btnDelete3.Visible = True

        btnAddProcedure4.Visible = False
        lblProcedure4.Visible = True
        cmbboxProcedure4.Visible = True
        btnAddProcedure5.Visible = True

    End Sub

    Private Sub btnAddProcedure5_Click(sender As Object, e As EventArgs) Handles btnAddProcedure5.Click
        btnDelete3.Visible = False
        btnDelete4.Visible = True

        btnAddProcedure5.Visible = False
        lblProcedure5.Visible = True
        cmbboxProcedure5.Visible = True
        btnAddProcedure6.Visible = True

    End Sub

    Private Sub btnAddProcedure6_Click(sender As Object, e As EventArgs) Handles btnAddProcedure6.Click
        btnDelete4.Visible = False
        btnDelete5.Visible = True

        btnAddProcedure6.Visible = False
        lblProcedure6.Visible = True
        cmbboxProcedure6.Visible = True

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        AddAppointment.Close()
    End Sub

    Private Sub txtboxFirstName_Validating(sender As Object, e As CancelEventArgs) Handles txtboxZipCode.Validating, txtboxStreet.Validating, txtboxProvince.Validating, txtboxMunicipality.Validating, txtboxLastName.Validating, txtboxFirstName.Validating, txtboxContactNumber.Validating, txtboxBrgy.Validating, txtboxAge.Validating

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
            'MsgBox("Numeric Input Only")
        End If

    End Sub

    Private Sub dtpickerDateofBirth_ValueChanged(sender As Object, e As EventArgs) Handles dtpickerDateofBirth.ValueChanged
        If dtpickerDateofBirth.Value.Date = Date.Today Or dtpickerDateofBirth.Value.Date > Date.Today Then
            MsgBox("Enter a valid Birthdate")
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

    Private Sub dtpickerAppDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpickerAppDate.ValueChanged

        Me.dtgridAppDateViewer.Rows.Clear()
        lblGridDate.Text = dtpickerAppDate.Value.ToString("MMMM dd, yyyy")

        Try
            ConnectDatabase()
            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Appointments"
                .Parameters.AddWithValue("@AppFilterDate", "Check")
                .Parameters.AddWithValue("@AppFilterStatus", "Scheduled/Rescheduled")
                .Parameters.AddWithValue("@SearchTxt", dtpickerAppDate.Text)

                myreader = .ExecuteReader

                While myreader.Read()
                    Me.dtgridAppDateViewer.Rows.Add(New Object() {myreader.Item("LastName"), myreader.Item("StartTime"), myreader.Item("EndTime")})
                End While

            End With
            DatabaseDisconnect()

        Catch ex As Exception
            DatabaseDisconnect()
            MessageBox.Show(ex.Message, "Errsssor", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtboxAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxAge.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AppointmentNewPatient_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub dtgridAppDateViewer_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgridAppDateViewer.CellMouseMove
        dtgridAppDateViewer.ClearSelection()
        If e.RowIndex > -1 Then
            dtgridAppDateViewer.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub txtboxZipCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxZipCode.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            'MsgBox("Numeric Input Only")
        End If
    End Sub

End Class