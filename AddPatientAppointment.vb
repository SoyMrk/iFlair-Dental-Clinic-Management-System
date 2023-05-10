Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class AddPatientAppointment

    Dim timenow As String = Now().ToString("yyyyMMddHH")
    ' Dim newAppProcID As String
    Dim newAppointmentID As String



    Private Sub AddPatientAppointment_Load(sender As Object, e As EventArgs) Handles Me.Load


        txtboxPatientNo.Text = PatientRecordScreen.MyPatientID
        txtboxPatientName.Text = PatientRecordScreen.PatientName

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

                DatabaseDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try
        End With

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

    Private Sub dtpickerEndTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpickerEndTime.ValueChanged

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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        HomeScreen.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'VALIDATIONS
        If dtpickerAppDate.Value < Date.Today Then
            MsgBox("Enter a date later than today", MsgBoxStyle.Exclamation, "Information")
            Exit Sub
        End If

        If cmbboxDentist.Text = "" Then
            MsgBox("Dentist Name Cannot be Empty", MsgBoxStyle.Exclamation, "Information")
            cmbboxDentist.Select()
            Exit Sub
        End If

        If txtboxPatientNo.Text = "" Then
            MsgBox("Please Select a Patient in the table above", MsgBoxStyle.Exclamation, "Information")
            Exit Sub
        End If

        If txtboxDescription.Text = "" Then
            MessageBox.Show("Description cannot be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtboxDescription.Select()
            Exit Sub
        End If


        'VALIDATE TIME CONFLICTS
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

        If btnAddProcedure2.Visible = True Then

            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewAppointment"
                    .Parameters.AddWithValue("@PrdCount", "1")

                    .Parameters.AddWithValue("@AppID", newAppointmentID)
                    .Parameters.AddWithValue("@PatId", txtboxPatientNo.Text)
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


        ElseIf btnAddProcedure3.Visible = True Then

            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewAppointment"
                    .Parameters.AddWithValue("@PrdCount", "2")

                    .Parameters.AddWithValue("@AppID", newAppointmentID)
                    .Parameters.AddWithValue("@PatId", txtboxPatientNo.Text)
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


        ElseIf btnAddProcedure4.Visible = True Then

            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewAppointment"
                    .Parameters.AddWithValue("@PrdCount", "3")

                    .Parameters.AddWithValue("@AppID", newAppointmentID)
                    .Parameters.AddWithValue("@PatId", txtboxPatientNo.Text)
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

        ElseIf btnAddProcedure5.Visible = True Then

            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewAppointment"
                    .Parameters.AddWithValue("@PrdCount", "4")

                    .Parameters.AddWithValue("@AppID", newAppointmentID)
                    .Parameters.AddWithValue("@PatId", txtboxPatientNo.Text)
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


        ElseIf btnAddProcedure6.Visible = True Then

            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewAppointment"
                    .Parameters.AddWithValue("@PrdCount", "5")

                    .Parameters.AddWithValue("@AppID", newAppointmentID)
                    .Parameters.AddWithValue("@PatId", txtboxPatientNo.Text)
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

        Else

            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertNewAppointment"
                    .Parameters.AddWithValue("@PrdCount", "6")

                    .Parameters.AddWithValue("@AppID", newAppointmentID)
                    .Parameters.AddWithValue("@PatId", txtboxPatientNo.Text)
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

        End If

        Me.Close()

        HomeScreen.Enabled = True

        ClearHomeMainPanel()

        With PatientRecordScreen
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            HomeScreen.pnlHomeScreen.Controls.Add(PatientRecordScreen)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub AddPatientAppointment_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
    End Sub

    Private Sub cmbboxDentist_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxDentist.SelectionChangeCommitted
        'MsgBox(cmbboxDentist.SelectedValue.ToString)
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


End Class