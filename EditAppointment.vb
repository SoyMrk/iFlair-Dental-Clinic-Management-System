Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class EditAppointment
    Private Sub EditAppointment_Load(sender As Object, e As EventArgs) Handles Me.Load


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

        Try
            ConnectDatabase()
            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "PatAppointments"
                .Parameters.AddWithValue("@QType", "Get")
                .Parameters.AddWithValue("@AppFilterStatus", "No Filter")
                .Parameters.AddWithValue("@PatID", Appointment.AppPatientID)
                .Parameters.AddWithValue("@AppID", Appointment.MyAppointmentID)

                myreader = sqlcmd.ExecuteReader


                While myreader.Read()

                    dtpickerStartTime.Text = myreader("StartTime").ToString
                    dtpickerEndTime.Text = myreader("EndTime").ToString
                    txtboxPatientName.Text = myreader("PatientName")
                    cmbboxDentist.Text = myreader("DentistName")
                    listboxProcedure.Items.Add(myreader("ProcedureName"))
                    txtboxDescription.Text = myreader("Description")
                    txtboxDuration.Text = myreader("Duration")

                End While
                dtpickerAppDate.Text = myreader("AppDate").ToString


            End With
            DatabaseDisconnect()
        Catch ex As Exception
            DatabaseDisconnect()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try



    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub EditAppointment_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

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
                .Parameters.AddWithValue("@AppID", Appointment.MyAppointmentID)
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


        '

        Try
            ConnectDatabase()

            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "editAppointment"
                .Parameters.AddWithValue("@AppID", Appointment.MyAppointmentID)
                .Parameters.AddWithValue("@DentistID", cmbboxDentist.SelectedValue.ToString)
                .Parameters.AddWithValue("@AppDate", dtpickerAppDate.Text)
                .Parameters.AddWithValue("@StartTime", dtpickerStartTime.Value.ToString("hh:mm tt"))
                .Parameters.AddWithValue("@EndTime", dtpickerEndTime.Value.ToString("hh:mm tt"))
                .Parameters.AddWithValue("@Duration", txtboxDuration.Text)
                .Parameters.AddWithValue("@DescriptionTxt", txtboxDescription.Text)

                .ExecuteNonQuery()
                'MessageBox.Show("Appointment Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Appointment.refreshAppointmentDataGrid()

            End With

            DatabaseDisconnect()

        Catch ex As Exception
            DatabaseDisconnect()
            MessageBox.Show(ex.Message, "Errsssor", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class