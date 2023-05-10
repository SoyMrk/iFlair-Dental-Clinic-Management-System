Imports System.ComponentModel

Public Class ViewAppointmentvb
    Private Sub ViewAppointmentvb_Load(sender As Object, e As EventArgs) Handles Me.Load

        If LoginAccount.userType = "Administrator" And Appointment.AppointmentStatus <> "Completed" Then
            btnEditAppointment.Visible = True
        End If


        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "PatAppointments"
                .Parameters.AddWithValue("@QType", "Get")
                .Parameters.AddWithValue("@AppFilterStatus", "No Filter")
                .Parameters.AddWithValue("@PatID", Appointment.AppPatientID)
                .Parameters.AddWithValue("@AppID", Appointment.MyAppointmentID)

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()

                    txtboxPatientName.Text = myreader("PatientName")
                    txtboxAppointmentDate.Text = myreader.Item("AppDate")
                    ListboxProcedure.Items.Add(myreader("ProcedureName"))
                    txtboxAppointmentStatus.Text = myreader.Item("AppStatus")
                    txtboxStartTime.Text = myreader("StartTime")
                    txtboxEndTime.Text = myreader("EndTime")
                    txtboxDuration.Text = myreader("Duration")
                    txtboxDentist.Text = myreader("DentistName")

                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try

        End With

        DatabaseDisconnect()

    End Sub

    Private Sub ViewAppointmentvb_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        HomeScreen.Enabled = True

    End Sub

    Private Sub btnToPatientProfile_Click(sender As Object, e As EventArgs) Handles btnToPatientProfile.Click

        Me.Close()

        PatientAppointmentHistory.AppointmentID = Appointment.MyAppointmentID
        PatientRecordScreen.MyPatientID = Appointment.AppPatientID

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

        PatientRecordScreen.pnlClicked.Width = PatientRecordScreen.btnAppointments.Width
        PatientRecordScreen.pnlClicked.Left = PatientRecordScreen.btnAppointments.Left

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

        HomeScreen.Enabled = True

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnEditAppointment_Click(sender As Object, e As EventArgs) Handles btnEditAppointment.Click

        Me.Close()
        HomeScreen.Enabled = False
        EditAppointment.Show()

    End Sub

End Class