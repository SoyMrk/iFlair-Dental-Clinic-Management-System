Public Class PatientAppointmentHistory

    Public Shared AppointmentID As String
    Public Shared nameDentist As String
    Public Shared EmpDentistID As String
    Public Sub refreshdtgridPatAppointment()
        datagridPatAppointment.Rows.Clear()

        ConnectDatabase()
        Try
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "PatAppointments"
                .Parameters.AddWithValue("@QType", "View")
                .Parameters.AddWithValue("@AppFilterStatus", cmbboxAppointmentStatus.Text)
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@AppID", "")

                myreader = sqlcmd.ExecuteReader

                If myreader.HasRows Then

                    While myreader.Read()

                        Dim AppDate As DateTime = myreader("AppDate").ToString

                        'AppDate.ToString("h:mm tt")

                        Me.datagridPatAppointment.Rows.Add(New Object() {AppDate.ToString("MMMM dd, yyyy"), myreader.Item("AppStatus"), myreader.Item("Description"), myreader.Item("DentistName"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("Duration")})

                    End While
                    'myreader.Dispose()

                Else

                    clearAppointmentAppointmentHistoryPanel()

                    With ButtonAppoointmentHistory

                        .WindowState = FormWindowState.Maximized
                        .Dock = DockStyle.Fill And DockStyle.Bottom
                        .AutoSize = True
                        .TopLevel = False
                        pnlAppointmentHistory.Controls.Add(ButtonAppoointmentHistory)
                        .BringToFront()
                        .Show()

                    End With

                End If


            End With
            DatabaseDisconnect()

        Catch ex As Exception
            DatabaseDisconnect()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        txtboxAppsFound.Text = datagridPatAppointment.Rows.Count.ToString + " appointment/s found"
    End Sub
    Private Sub PatientAppointmentHistory_Load(sender As Object, e As EventArgs) Handles Me.Load

        cmbboxAppointmentStatus.Text = "No Filter"

        datagridPatAppointment.RowTemplate.Height = 40


        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "PatAppointments"
                .Parameters.AddWithValue("@QType", "Check")
                .Parameters.AddWithValue("@AppFilterStatus", "No Filter")
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@AppID", "")

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() And Not IsDBNull(myreader("AppointmentID")) Then


                    Dim AppDate As DateTime = myreader("AppDate").ToString

                    AppointmentID = myreader("AppointmentID")
                    nameDentist = myreader("DentistName")
                    EmpDentistID = myreader("DentistID")
                    txtboxAppDate.Text = AppDate.ToString("MMMM dd, yyyy")
                    txtboxStartTime.Text = myreader("StartTime")
                    txtboxEndTime.Text = myreader("EndTime")
                    txtboxDescription.Text = myreader("Description")
                    txtboxProcedure.Text = myreader("Procedures")

                Else

                    clearAppointmentTodayPanel()

                    With ButtonAddAppointment

                        .WindowState = FormWindowState.Maximized
                        .Dock = DockStyle.Fill And DockStyle.Bottom
                        .AutoSize = True
                        .TopLevel = False
                        pnlAppointmentToday.Controls.Add(ButtonAddAppointment)
                        .BringToFront()
                        .Show()

                    End With

                End If

            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        End With
        DatabaseDisconnect()


        refreshdtgridPatAppointment()

        'MsgBox(AppointmentID)
    End Sub

    Private Sub btnECompleteAppointment_Click(sender As Object, e As EventArgs) Handles btnECompleteAppointment.Click

        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "checkPatBilling"
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader
                If myreader.Read() Then

                    If MessageBox.Show("Update Payment from Existing Installment?", "Notification", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                        HomeScreen.Enabled = False

                        EditBilling.Show()

                        'MsgBox("Yes")

                    Else
                        'MsgBox("No")

                        HomeScreen.Enabled = False

                        AddBilling.Show()

                    End If

                Else

                    HomeScreen.Enabled = False

                    AddBilling.Show()

                End If
            End With
            DatabaseDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()
        End Try


    End Sub

    Private Sub btnCancelApp_Click(sender As Object, e As EventArgs) Handles btnCancelApp.Click

        HomeScreen.Enabled = False
        ReasonForCancel.Show()

        'If MessageBox.Show("Cancel this Appointment?", "Appointment Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
        'End If

    End Sub

    Private Sub btnReschedule_Click(sender As Object, e As EventArgs) Handles btnReschedule.Click

        HomeScreen.Enabled = False
        Reschedule.Show()

    End Sub

    'Private Sub btnAddPatientAppointment_Click(sender As Object, e As EventArgs) Handles btnAddPatientAppointment.Click

    '    HomeScreen.Enabled = False

    '    AddPatientAppointment.Show()

    'End Sub

    Private Sub btnAddPrescription_Click(sender As Object, e As EventArgs) Handles btnAddPrescription.Click
        HomeScreen.Enabled = False

        Prescription.Show()
    End Sub

    Private Sub btnNoShow_Click(sender As Object, e As EventArgs) Handles btnNoShow.Click

        If MessageBox.Show("The Patient did not come?", "Appointment No Show", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

            ConnectDatabase()

            With sqlcmd

                Try
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "noShowAppointment"
                    .Parameters.AddWithValue("@AppID", PatientAppointmentHistory.AppointmentID)
                    .ExecuteNonQuery()
                    MsgBox("Patient Appointment Updated", MsgBoxStyle.Information, "Information")

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try

                DatabaseDisconnect()

            End With

            clearAppointmentTodayPanel()

            With ButtonAddAppointment

                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill And DockStyle.Bottom
                .AutoSize = True
                .TopLevel = False
                pnlAppointmentToday.Controls.Add(ButtonAddAppointment)
                .BringToFront()
                .Show()

            End With
            refreshdtgridPatAppointment()


        End If

    End Sub

    Private Sub cmbboxAppointmentStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxAppointmentStatus.SelectionChangeCommitted

        refreshdtgridPatAppointment()

    End Sub

    Private Sub datagridPatAppointment_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridPatAppointment.CellMouseMove
        datagridPatAppointment.ClearSelection()
        If e.RowIndex > -1 Then
            datagridPatAppointment.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub btnInventoryUsed_Click(sender As Object, e As EventArgs) Handles btnInventoryUsed.Click
        HomeScreen.Enabled = False
        AppointmentInventory.Show()
    End Sub

End Class