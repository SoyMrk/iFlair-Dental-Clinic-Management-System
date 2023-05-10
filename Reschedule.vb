Imports System.ComponentModel

Public Class Reschedule
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        HomeScreen.Enabled = True
        Me.Close()


    End Sub

    Private Sub Reschedule_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
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
                .Parameters.AddWithValue("@AppID", PatientAppointmentHistory.AppointmentID)
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




        '''''

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "reschedAppointment"
                .Parameters.AddWithValue("@AppID", PatientAppointmentHistory.AppointmentID)
                .Parameters.AddWithValue("@NewAppDate", dtpickerAppDate.Text)
                .Parameters.AddWithValue("@STime", dtpickerStartTime.Value.ToString("hh:mm tt"))
                .Parameters.AddWithValue("@ETime", dtpickerEndTime.Value.ToString("hh:mm tt"))
                .Parameters.AddWithValue("@AppDuration", txtboxDuration.Text)
                .ExecuteNonQuery()
                'MsgBox("Appointment Rescheduled", MsgBoxStyle.Information, "Information")

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

            DatabaseDisconnect()

        End With

        Me.Close()

        HomeScreen.Enabled = True

        ClearPatientPanel()

        With PatientAppointmentHistory
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            PatientRecordScreen.PatientProfilePanel.Controls.Add(PatientAppointmentHistory)
            .BringToFront()
            .Show()
        End With

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

    Private Sub Reschedule_Load(sender As Object, e As EventArgs) Handles Me.Load

        dtpickerAppDate.Value = Convert.ToDateTime(PatientAppointmentHistory.txtboxAppDate.Text)

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