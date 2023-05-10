Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView
Imports Mysqlx.Crud

Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")
        ClockTimer.Enabled = True

        loadCounts()
        refreshDtGridPtToday()
        refreshDtGridPtTommorow()
        refreshDtGridInvWarn()
        refreshDtGridPendingBilling()

        'pnlInventWarning.BringToFront()
        'pnlPendingBilling.BringToFront()
        'pnlSchedToday.BringToFront()
        'pnlSchedTomorrow.BringToFront()



        ''AUTOMATIC SMS BEFORE THE APPOINTMENT DAY
        'Dim MsgAppIds(50) As String
        'Dim AppDates(50) As String
        'Dim STimes(50) As String
        'Dim ETimes(50) As String

        'Dim PatNames(50) As String
        'Dim PatContactNo(50) As String

        'Dim DentNames(50) As String
        'Dim DentContactNo(50) As String

        'Dim x As Integer = 0

        ''CHECK APPOINTMENT SMS
        'Try
        '    ConnectDatabase()

        '    With sqlcmd

        '        .Connection = DBConnection
        '        .CommandType = CommandType.StoredProcedure
        '        .CommandText = "checkAppointmentSMS"

        '        myreader = .ExecuteReader

        '        If myreader.HasRows Then
        '            While myreader.Read

        '                MsgAppIds(x) = myreader("AppointmentID")
        '                AppDates(x) = myreader("AppDate")
        '                STimes(x) = myreader("StartTime")
        '                ETimes(x) = myreader("EndTime")

        '                PatNames(x) = myreader("PatientName")
        '                PatContactNo(x) = myreader("PatContactNo")

        '                DentNames(x) = myreader("DentistName")
        '                DentContactNo(x) = myreader("EmpContactNo")

        '                x = x + 1

        '            End While
        '        Else
        '            Exit Sub
        '        End If

        '    End With

        '    DatabaseDisconnect()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    DatabaseDisconnect()
        'End Try

        'Dim businessdetails As String = "Flair Dental Clinic | Legazpi City"
        'Dim fblink As String = "In case of any queries, please feel free to call us at https://www.facebook.com/people/Flair-Dental-Clinic/100057619892884/"
        'Dim smsgeneratednotif As String = "This Is a system generated SMS message. Do Not reply."

        'Dim AppointmentNotificationTemplate As String = "Please arrive 5 minutes before your appointment. If you are running late Or unable To make your appointment, kindly Let us know As soon As possible." & System.Environment.NewLine & System.Environment.NewLine & fblink & System.Environment.NewLine & System.Environment.NewLine & businessdetails & System.Environment.NewLine & System.Environment.NewLine & smsgeneratednotif

        'Try

        '    For i = 0 To x - 1

        '        Dim AppointmentMessageTemplate As String = "Good Day, " + PatNames(i) + "!" & System.Environment.NewLine & "This is Flair Dental Clinic " & System.Environment.NewLine & System.Environment.NewLine & "We wanted to remind you of your scheduled appointment on '" & AppDates(i) & "' at '" & STimes(i) & "' to '" & ETimes(i) & "' with Dr. " & DentNames(i) & " " & System.Environment.NewLine & System.Environment.NewLine & AppointmentNotificationTemplate


        '        If HaveInternetConnection() Then

        '            Dim strQuote As String = Chr(34)

        '            Try
        '                SendMessage(SMSConfiguration.AccountSID, SMSConfiguration.AuthToken, SMSConfiguration.TwillioNumber, PatContactNo(i), AppointmentMessageTemplate)

        '                ConnectDatabase()
        '                With sqlcmd
        '                    .Connection = DBConnection
        '                    .CommandType = CommandType.StoredProcedure
        '                    .CommandText = "insertNewSMSLog"
        '                    .Parameters.AddWithValue("@QType", "Sent")
        '                    .Parameters.AddWithValue("@MsgAppID", MsgAppIds(i))
        '                    .Parameters.AddWithValue("@AccSID", SMSConfiguration.AccountSID)
        '                    .Parameters.AddWithValue("@TempName", "Appointment Notification")
        '                    .Parameters.AddWithValue("@smsMessage", strQuote & AppointmentMessageTemplate & strQuote)
        '                    .Parameters.AddWithValue("@toNumber", PatContactNo(i))

        '                    .ExecuteNonQuery()
        '                End With
        '                DatabaseDisconnect()

        '                'MessageBox.Show("Message Succesfully Sent", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '            Catch ex As Exception

        '                ConnectDatabase()
        '                With sqlcmd
        '                    .Connection = DBConnection
        '                    .CommandType = CommandType.StoredProcedure
        '                    .CommandText = "insertNewSMSLog"
        '                    .Parameters.AddWithValue("@QType", "NotSent")
        '                    .Parameters.AddWithValue("@MsgAppID", MsgAppIds(i))
        '                    .Parameters.AddWithValue("@AccSID", SMSConfiguration.AccountSID)
        '                    .Parameters.AddWithValue("@TempName", "Appointment Notification")
        '                    .Parameters.AddWithValue("@smsMessage", strQuote & AppointmentMessageTemplate & strQuote)
        '                    .Parameters.AddWithValue("@toNumber", PatContactNo(i))

        '                    .ExecuteNonQuery()
        '                End With
        '                DatabaseDisconnect()

        '                'MessageBox.Show("Message Not Sent" + vbCrLf + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        '                x -= 1
        '            End Try

        '        Else
        '            MessageBox.Show("You are not Connected to the Internet" & Environment.NewLine & "Automatic SMS Notifications did not start.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        End If

        '        'NOT USED - DENTIST NOTIF
        '        'MsgBox(DentContactNo(i))

        '    Next

        '    MessageBox.Show(x & " Automatic Notifications Sent", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)


        'Catch ex As Exception

        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'End Try



    End Sub

    Public Sub loadCounts()

        'TOTAL PATIENTS
        Try
            ConnectDatabase()

            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getTotalPatient"

                myreader = .ExecuteReader

                If myreader.Read Then
                    lblTotalPatient.Text = myreader("PatientCount")
                End If

            End With

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try

        'TOTAL APPOINTMENTS
        Try
            ConnectDatabase()

            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getTotalAppointments"

                myreader = .ExecuteReader

                If myreader.Read Then
                    lblTotalAppointment.Text = myreader("TotalAppointment")
                    lblCompleted.Text = myreader("CompletedAppointments")
                    lblCancel.Text = myreader("CancelledAppointments")
                    lblNoShow.Text = myreader("NoShowAppointments")
                    lblScheduled.Text = myreader("ScheduledAppointments")
                End If

            End With

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try

        '    'REVENUE
        '    Try
        '        ConnectDatabase()

        '        With sqlcmd

        '            .Connection = DBConnection
        '            .CommandType = CommandType.StoredProcedure
        '            .CommandText = "getRevenue"
        '            .Parameters.AddWithValue("@filterRange", "Today")
        '            .Parameters.AddWithValue("@filterDate", "")

        '            myreader = .ExecuteReader

        '            If myreader.Read Then
        '                lblRevenueToday.Text = "₱" & myreader("Revenue")
        '            Else
        '                lblRevenueToday.Text = "₱0.00"
        '            End If

        '        End With

        '        DatabaseDisconnect()
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        DatabaseDisconnect()
        '    End Try
    End Sub

    Public Sub refreshDtGridPtToday()
        dtgridPatientToday.RowTemplate.Height = 40
        Me.dtgridPatientToday.Rows.Clear()

        Try
            ConnectDatabase()

            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Appointments"
                .Parameters.AddWithValue("@AppFilterDate", "Today")
                .Parameters.AddWithValue("@AppFilterStatus", "Scheduled/Rescheduled")
                .Parameters.AddWithValue("@SearchTxt", "")

                myreader = .ExecuteReader

                While myreader.Read()
                    Me.dtgridPatientToday.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("AppointmentID"), myreader.Item("PatientName"), myreader.Item("PatientAddress"), myreader.Item("StartTime"), myreader.Item("EndTime")})
                End While

            End With

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try
        lblPatientToday.Text = dtgridPatientToday.Rows.Count


        If dtgridPatientToday.Rows.Count > 0 Then
            pnlSchedToday.SendToBack()
        End If
    End Sub

    Public Sub refreshDtGridPtTommorow()
        dtgridPatientTomorrow.RowTemplate.Height = 40
        Me.dtgridPatientTomorrow.Rows.Clear()

        Try
            ConnectDatabase()

            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Appointments"
                .Parameters.AddWithValue("@AppFilterDate", "Tomorrow")
                .Parameters.AddWithValue("@AppFilterStatus", "Scheduled/Rescheduled")
                .Parameters.AddWithValue("@SearchTxt", "")

                myreader = .ExecuteReader

                While myreader.Read()
                    Me.dtgridPatientTomorrow.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("AppointmentID"), myreader.Item("PatientName"), myreader.Item("PatientAddress"), myreader.Item("StartTime"), myreader.Item("EndTime")})
                End While

            End With

            DatabaseDisconnect()
        Catch ex As Exception
            DatabaseDisconnect()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        lblPatientTomorrow.Text = dtgridPatientTomorrow.Rows.Count


        If dtgridPatientTomorrow.Rows.Count > 0 Then
            pnlSchedTomorrow.SendToBack()
        End If

    End Sub

    Public Sub refreshDtGridInvWarn()
        dtgridInventoryWarning.RowTemplate.Height = 40
        Me.dtgridInventoryWarning.Rows.Clear()

        Try
            ConnectDatabase()

            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getCriticalInv"

                myreader = .ExecuteReader

                While myreader.Read()
                    Me.dtgridInventoryWarning.Rows.Add(New Object() {myreader.Item("SupplyID"), myreader.Item("SupplyName"), myreader.Item("RemainingStock"), myreader.Item("Status")})
                End While

            End With

            DatabaseDisconnect()
        Catch ex As Exception
            DatabaseDisconnect()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        If dtgridInventoryWarning.Rows.Count > 0 Then
            pnlInventWarning.SendToBack()
        End If
    End Sub

    Public Sub refreshDtGridPendingBilling()
        dtGridPendingBilling.RowTemplate.Height = 40
        Me.dtGridPendingBilling.Rows.Clear()

        Try
            ConnectDatabase()

            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getPatPendingBills"

                myreader = .ExecuteReader

                While myreader.Read()
                    Me.dtGridPendingBilling.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("PatientName"), myreader.Item("Balance")})

                End While

            End With

            DatabaseDisconnect()
        Catch ex As Exception
            DatabaseDisconnect()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If dtGridPendingBilling.Rows.Count > 0 Then
            pnlPendingBilling.SendToBack()
        End If
    End Sub



    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick

        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")

        'If lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt") Then
        '    MsgBox("True") 
        'End If

        'NAMOOOOOOOOOOOO

    End Sub

    Private Sub dtgridPatientToday_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridPatientToday.CellContentClick

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        Appointment.AppPatientID = dtgridPatientToday.CurrentRow.Cells(0).Value.ToString
        Appointment.MyAppointmentID = dtgridPatientToday.CurrentRow.Cells(1).Value.ToString
        HomeScreen.Enabled = False
        ViewAppointmentvb.Show()

    End Sub

    'Patient today cell mouse hover
    Private Sub dtgridPatientToday_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgridPatientToday.CellMouseMove
        dtgridPatientToday.ClearSelection()
        If e.RowIndex > -1 Then
            dtgridPatientToday.Rows(e.RowIndex).Selected = True
        End If
    End Sub


    Private Sub dtgridPatientTomorrow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridPatientTomorrow.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        Appointment.AppPatientID = dtgridPatientTomorrow.CurrentRow.Cells(0).Value.ToString
        Appointment.MyAppointmentID = dtgridPatientTomorrow.CurrentRow.Cells(1).Value.ToString
        HomeScreen.Enabled = False
        ViewAppointmentvb.Show()

    End Sub

    'Patient tomorrow cell mouse hover
    Private Sub dtgridPatientTomorrow_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgridPatientTomorrow.CellMouseMove
        dtgridPatientTomorrow.ClearSelection()
        If e.RowIndex > -1 Then
            dtgridPatientTomorrow.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub dtgridInventoryWarning_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridInventoryWarning.CellContentClick

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        InventoryList.InventorySupplyID = dtgridInventoryWarning.CurrentRow.Cells(0).Value.ToString

        HomeScreen.Enabled = False

        EditInventory.Show()

    End Sub

    'Inventory warning cell mouse hover
    Private Sub dtgridInventoryWarning_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgridInventoryWarning.CellMouseMove
        dtgridInventoryWarning.ClearSelection()
        If e.RowIndex > -1 Then
            dtgridInventoryWarning.Rows(e.RowIndex).Selected = True
        End If
    End Sub


    Private Sub dtGridPendingBilling_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridPendingBilling.CellContentClick

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        PatientRecordScreen.MyPatientID = dtGridPendingBilling.CurrentRow.Cells(0).Value.ToString

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

        PatientRecordScreen.pnlClicked.Width = PatientRecordScreen.btnBilling.Width
        PatientRecordScreen.pnlClicked.Left = PatientRecordScreen.btnBilling.Left

        ClearPatientPanel()

        With Billing
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            PatientRecordScreen.PatientProfilePanel.Controls.Add(Billing)
            .BringToFront()
            .Show()
        End With

    End Sub

    'Pending billing cell mouse hover
    Private Sub dtGridPendingBilling_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtGridPendingBilling.CellMouseMove
        dtGridPendingBilling.ClearSelection()
        If e.RowIndex > -1 Then
            dtGridPendingBilling.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub btnViewReports_Click(sender As Object, e As EventArgs) Handles btnViewReports.Click

        Process.Start("explorer.exe", desktopPath + "\Dental Clinic Management System\Reports")

    End Sub

    Private Sub btnViewForms_Click(sender As Object, e As EventArgs) Handles btnViewForms.Click

        'MsgBox(desktopPath + "\Dental Clinic Management System\Forms")
        Process.Start("explorer.exe", desktopPath + "\Dental Clinic Management System\Forms")

    End Sub
End Class