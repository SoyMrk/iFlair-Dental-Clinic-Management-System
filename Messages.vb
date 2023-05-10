Imports MySql.Data.MySqlClient
Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types

Public Class Messages

    Public MsgAppID As String
    Public AppDate As String
    Public STime As String
    Public ETime As String

    Public PatName As String
    Public DentName As String




    Public Sub RefreshMessageDataGrid()

        Me.dataviewMessagesAppointment.Rows.Clear()
        dataviewMessagesAppointment.RowTemplate.Height = 40

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Appointments"
                .Parameters.AddWithValue("@AppFilterDate", cmbboxMsgAppFilterDate.Text)
                .Parameters.AddWithValue("@AppFilterStatus", cmbboxMsgAppFilterStatus.Text)
                .Parameters.AddWithValue("@SearchTxt", "")
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()

                    Dim appDate As DateTime = myreader("AppDate").ToString

                    Me.dataviewMessagesAppointment.Rows.Add(New Object() {myreader.Item("AppointmentID"), myreader.Item("PatientName"), myreader.Item("PatContactNo"), appDate.ToString("MMMM dd, yyyy"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("AppStatus"), myreader.Item("SMSStatus"), myreader.Item("EmpContactNo"), myreader.Item("DentistName")})

                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()

            End Try

        End With

        DatabaseDisconnect()

    End Sub

    Private Sub btnSendMessage_Click(sender As Object, e As EventArgs) Handles btnSendMessage.Click

        'Check Internet Connection
        If HaveInternetConnection() Then

            Dim strQuote As String = Chr(34)

            If txtboxtoNumber.Text = "" Then
                MessageBox.Show("Please Select a Contact First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            ElseIf rchtxtboxMessage.Text = "" Then
                MessageBox.Show("Please Choose a Template", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            ElseIf SMSConfiguration.AccountSID = "" Then
                MessageBox.Show("SMS Not Configured", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim DentistContactNo As String = dataviewMessagesAppointment.CurrentRow.Cells(8).Value.ToString
            Dim notifyDentistMessage As String = "Hi, This is Flair Dental Clinic!" & System.Environment.NewLine & "date: '" & AppDate & "'" & System.Environment.NewLine & "time: '" & STime & "' to '" & ETime & "' " & System.Environment.NewLine & "Good Day Doc!, You have an appointment with your patient '" & PatName & "' on the Date and Time mentioned above."

            Try
                If chcboxNotify.Checked Then
                    SendMessage(SMSConfiguration.AccountSID, SMSConfiguration.AuthToken, SMSConfiguration.TwillioNumber, txtboxtoNumber.Text, rchtxtboxMessage.Text)
                    SendMessage(SMSConfiguration.AccountSID, SMSConfiguration.AuthToken, SMSConfiguration.TwillioNumber, DentistContactNo, notifyDentistMessage)
                Else
                    SendMessage(SMSConfiguration.AccountSID, SMSConfiguration.AuthToken, SMSConfiguration.TwillioNumber, txtboxtoNumber.Text, rchtxtboxMessage.Text)
                End If

                ConnectDatabase()
                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "insertNewSMSLog"
                    .Parameters.AddWithValue("@QType", "Sent")
                    .Parameters.AddWithValue("@MsgAppID", MsgAppID)
                    .Parameters.AddWithValue("@AccSID", SMSConfiguration.AccountSID)
                    .Parameters.AddWithValue("@TempName", cmbboxTemplate.SelectedValue.ToString)
                    .Parameters.AddWithValue("@smsMessage", strQuote & rchtxtboxMessage.Text & strQuote)
                    .Parameters.AddWithValue("@toNumber", txtboxtoNumber.Text)

                    .ExecuteNonQuery()
                End With
                DatabaseDisconnect()

                RefreshMessageDataGrid()

            Catch ex As Exception

                'MsgBox(sqlstr)
                ConnectDatabase()
                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "insertNewSMSLog"
                    .Parameters.AddWithValue("@QType", "NotSent")
                    .Parameters.AddWithValue("@MsgAppID", MsgAppID)
                    .Parameters.AddWithValue("@AccSID", SMSConfiguration.AccountSID)
                    .Parameters.AddWithValue("@TempName", cmbboxTemplate.SelectedValue.ToString)
                    .Parameters.AddWithValue("@smsMessage", strQuote & rchtxtboxMessage.Text & strQuote)
                    .Parameters.AddWithValue("@toNumber", txtboxtoNumber.Text)

                    .ExecuteNonQuery()
                End With
                DatabaseDisconnect()

                MessageBox.Show("Message Not Sent" + vbCrLf + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                RefreshMessageDataGrid()
            End Try

        Else
            MessageBox.Show("You are not Connected to the Internet", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnSMSConfig_Click(sender As Object, e As EventArgs) Handles btnSMSConfig.Click

        HomeScreen.Enabled = False
        SMSConfiguration.Show()

    End Sub

    Private Sub btnSMSTemplates_Click(sender As Object, e As EventArgs) Handles btnSMSTemplates.Click

        ViewTemplate.Show()
        HomeScreen.Enabled = False


    End Sub

    Private Sub Messages_Load(sender As Object, e As EventArgs) Handles Me.Load

        cmbboxMsgAppFilterDate.Text = "Tomorrow"
        cmbboxMsgAppFilterStatus.Text = "Scheduled/Rescheduled"

        RefreshMessageDataGrid()

        Try
            ConnectDatabase()
            Dim smsTemplateTemplate As New DataTable
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SMSTemplate"
                .Parameters.AddWithValue("@QType", "View")
                .Parameters.AddWithValue("@TempName", "")
                .Parameters.AddWithValue("@TempText", "")
                myAdapter.SelectCommand = sqlcmd
                myAdapter.Fill(smsTemplateTemplate)
            End With
            If smsTemplateTemplate.Rows.Count <> 0 Then

                cmbboxTemplate.DataSource = smsTemplateTemplate
                cmbboxTemplate.ValueMember = "TemplateName"
                cmbboxTemplate.DisplayMember = "TemplateName"

            End If
            DatabaseDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()
        End Try

    End Sub

    Private Sub cmbboxTemplate_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxTemplate.SelectionChangeCommitted

        Try
            ConnectDatabase()
            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SMSTemplate"
                .Parameters.AddWithValue("@QType", "Get")
                .Parameters.AddWithValue("@TempName", cmbboxTemplate.SelectedValue.ToString)
                .Parameters.AddWithValue("@TempText", "")

                myreader = .ExecuteReader

                If myreader.Read() Then

                    If myreader("TemplateName") = "Appointment Notification" Then
                        rchtxtboxMessage.Text = "Good Day, " + PatName + "!" & System.Environment.NewLine & "This is Flair Dental Clinic " & System.Environment.NewLine & System.Environment.NewLine & "We wanted to remind you of your scheduled appointment on '" & AppDate & "' at '" & STime & "' to '" & ETime & "' with Dr. " & DentName & " " & System.Environment.NewLine & System.Environment.NewLine & myreader("TemplateText")
                        'MsgBox("APPNOF")
                    ElseIf myreader("TemplateName") = "Appointment Cancellation" Then
                        rchtxtboxMessage.Text = "Good Day, " + PatName + "!" & System.Environment.NewLine & "This is Flair Dental Clinic " & System.Environment.NewLine & System.Environment.NewLine & "Looks like you missed or cancelled your appointment with Dr. " & DentName & " on '" & AppDate & "' at '" & STime & "' to '" & ETime & "'." & vbCrLf & vbCrLf & myreader("TemplateText")
                        'MsgBox("CANCEL")
                    ElseIf myreader("TemplateName") = "Appointment Rescheduled" Then
                        rchtxtboxMessage.Text = "Good Day, " + PatName + "!" & System.Environment.NewLine & "This is Flair Dental Clinic " & System.Environment.NewLine & System.Environment.NewLine & "We have successfully rescheduled your appointment to '" & AppDate & "' at '" & STime & "' to '" & ETime & "' with Dr. " & DentName & " " & vbCrLf & vbCrLf & myreader("TemplateText")
                        'MsgBox("RESCHED")
                    Else
                        rchtxtboxMessage.Text = myreader("TemplateText")
                        rchtxtboxMessage.ReadOnly = False
                    End If


                End If
            End With

            DatabaseDisconnect()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try
        MsgBox(cmbboxTemplate.SelectedValue.ToString)

    End Sub

    Private Sub cmbboxTemplate_Click(sender As Object, e As EventArgs) Handles cmbboxTemplate.Click
        If txtboxtoNumber.Text = "" Then
            MessageBox.Show("Please Select a Contact First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub dataviewMessagesAppointment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataviewMessagesAppointment.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        MsgAppID = dataviewMessagesAppointment.CurrentRow.Cells(0).Value.ToString
        AppDate = dataviewMessagesAppointment.CurrentRow.Cells(3).Value.ToString
        STime = dataviewMessagesAppointment.CurrentRow.Cells(4).Value.ToString
        ETime = dataviewMessagesAppointment.CurrentRow.Cells(5).Value.ToString

        PatName = dataviewMessagesAppointment.CurrentRow.Cells(1).Value.ToString
        DentName = dataviewMessagesAppointment.CurrentRow.Cells(9).Value.ToString

        txtboxtoNumber.Text = dataviewMessagesAppointment.CurrentRow.Cells(2).Value.ToString
        Dim empcontactno As String = dataviewMessagesAppointment.CurrentRow.Cells(8).Value.ToString
        'MsgBox(empcontactno)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtboxtoNumber.Text = String.Empty
        rchtxtboxMessage.Text = String.Empty
    End Sub

    Private Sub btnEditMessage_Click(sender As Object, e As EventArgs) Handles btnEditMessage.Click

        If txtboxtoNumber.Text = "" Then
            MessageBox.Show("Please Select a Contact First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf rchtxtboxMessage.Text = "" And cmbboxTemplate.Text <> "Blank Template" Then
            MessageBox.Show("Please Choose a Template", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        rchtxtboxMessage.ReadOnly = False
        rchtxtboxMessage.Focus()
        rchtxtboxMessage.SelectionStart = rchtxtboxMessage.Text.Length

    End Sub

    Private Sub rchtxtboxMessage_Leave(sender As Object, e As EventArgs) Handles rchtxtboxMessage.Leave
        rchtxtboxMessage.ReadOnly = True
    End Sub

    Private Sub cmbboxMsgAppFilterDate_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxMsgAppFilterDate.SelectionChangeCommitted

        Me.dataviewMessagesAppointment.Rows.Clear()

        If cmbboxMsgAppFilterDate.Text = "All" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxMsgAppFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxMsgAppFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString
                        Me.dataviewMessagesAppointment.Rows.Add(New Object() {myreader.Item("AppointmentID"), myreader.Item("PatientName"), myreader.Item("PatContactNo"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("AppStatus"), myreader.Item("SMSStatus"), myreader("EmpContactNo"), myreader("DentistName")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf cmbboxMsgAppFilterDate.Text = "Today" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxMsgAppFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxMsgAppFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString
                        Me.dataviewMessagesAppointment.Rows.Add(New Object() {myreader.Item("AppointmentID"), myreader.Item("PatientName"), myreader.Item("PatContactNo"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("AppStatus"), myreader.Item("SMSStatus"), myreader("EmpContactNo"), myreader("DentistName")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf cmbboxMsgAppFilterDate.Text = "Tomorrow" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxMsgAppFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxMsgAppFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString
                        Me.dataviewMessagesAppointment.Rows.Add(New Object() {myreader.Item("AppointmentID"), myreader.Item("PatientName"), myreader.Item("PatContactNo"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("AppStatus"), myreader.Item("SMSStatus"), myreader("EmpContactNo"), myreader("DentistName")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf cmbboxMsgAppFilterDate.Text = "Week" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxMsgAppFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxMsgAppFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString
                        Me.dataviewMessagesAppointment.Rows.Add(New Object() {myreader.Item("AppointmentID"), myreader.Item("PatientName"), myreader.Item("PatContactNo"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("AppStatus"), myreader.Item("SMSStatus"), myreader("EmpContactNo"), myreader("DentistName")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf cmbboxMsgAppFilterDate.Text = "Month" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxMsgAppFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxMsgAppFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString
                        Me.dataviewMessagesAppointment.Rows.Add(New Object() {myreader.Item("AppointmentID"), myreader.Item("PatientName"), myreader.Item("PatContactNo"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("AppStatus"), myreader.Item("SMSStatus"), myreader("EmpContactNo"), myreader("DentistName")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        End If

    End Sub

    Private Sub cmbboxMsgAppFilterStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxMsgAppFilterStatus.SelectionChangeCommitted

        Me.dataviewMessagesAppointment.Rows.Clear()

        If cmbboxMsgAppFilterDate.Text = "All" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxMsgAppFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxMsgAppFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString
                        Me.dataviewMessagesAppointment.Rows.Add(New Object() {myreader.Item("AppointmentID"), myreader.Item("PatientName"), myreader.Item("PatContactNo"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("AppStatus"), myreader.Item("SMSStatus"), myreader("EmpContactNo"), myreader("DentistName")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf cmbboxMsgAppFilterDate.Text = "Today" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxMsgAppFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxMsgAppFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString
                        Me.dataviewMessagesAppointment.Rows.Add(New Object() {myreader.Item("AppointmentID"), myreader.Item("PatientName"), myreader.Item("PatContactNo"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("AppStatus"), myreader.Item("SMSStatus"), myreader("EmpContactNo"), myreader("DentistName")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf cmbboxMsgAppFilterDate.Text = "Tomorrow" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxMsgAppFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxMsgAppFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString
                        Me.dataviewMessagesAppointment.Rows.Add(New Object() {myreader.Item("AppointmentID"), myreader.Item("PatientName"), myreader.Item("PatContactNo"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("AppStatus"), myreader.Item("SMSStatus"), myreader("EmpContactNo"), myreader("DentistName")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf cmbboxMsgAppFilterDate.Text = "Week" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxMsgAppFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxMsgAppFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString
                        Me.dataviewMessagesAppointment.Rows.Add(New Object() {myreader.Item("AppointmentID"), myreader.Item("PatientName"), myreader.Item("PatContactNo"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("AppStatus"), myreader.Item("SMSStatus"), myreader("EmpContactNo"), myreader("DentistName")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf cmbboxMsgAppFilterDate.Text = "Month" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxMsgAppFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxMsgAppFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString
                        Me.dataviewMessagesAppointment.Rows.Add(New Object() {myreader.Item("AppointmentID"), myreader.Item("PatientName"), myreader.Item("PatContactNo"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("AppStatus"), myreader.Item("SMSStatus"), myreader("EmpContactNo"), myreader("DentistName")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        End If

    End Sub

    Private Sub txtboxSearchApp_Click(sender As Object, e As EventArgs) Handles txtboxSearchApp.Click
        txtboxSearchApp.Text = ""
    End Sub

    Private Sub txtboxSearchApp_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearchApp.TextChanged

        If cmbboxMsgAppFilterDate.Text = "Today" Or cmbboxMsgAppFilterDate.Text = "All" Or cmbboxMsgAppFilterDate.Text = "Tommorow" Or cmbboxMsgAppFilterDate.Text = "Week" Or cmbboxMsgAppFilterDate.Text = "Month" Then

            If txtboxSearchApp.Text = "Search appointment" Or txtboxSearchApp.Text = "" Then

                Me.dataviewMessagesAppointment.Rows.Clear()

                Try
                    ConnectDatabase()
                    With sqlcmd
                        .Connection = DBConnection
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "Appointments"
                        .Parameters.AddWithValue("@AppFilterDate", cmbboxMsgAppFilterDate.Text)
                        .Parameters.AddWithValue("@AppFilterStatus", cmbboxMsgAppFilterStatus.Text)
                        .Parameters.AddWithValue("@SearchTxt", txtboxSearchApp.Text)

                        myreader = .ExecuteReader

                        While myreader.Read()

                            'Dim startTime As DateTime = myreader("StartTime").ToString
                            'Dim endTime As DateTime = myreader("EndTime").ToString
                            'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                            Dim AppDate As DateTime = myreader("AppDate").ToString
                            Me.dataviewMessagesAppointment.Rows.Add(New Object() {myreader.Item("AppointmentID"), myreader.Item("PatientName"), myreader.Item("PatContactNo"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("AppStatus"), myreader.Item("SMSStatus"), myreader("EmpContactNo"), myreader("DentistName")})


                        End While

                    End With

                    DatabaseDisconnect()

                Catch ex As Exception

                    DatabaseDisconnect()
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

                End Try

            End If

            Me.dataviewMessagesAppointment.Rows.Clear()

            Try
                ConnectDatabase()
                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxMsgAppFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxMsgAppFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", txtboxSearchApp.Text)

                    myreader = .ExecuteReader

                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString
                        Me.dataviewMessagesAppointment.Rows.Add(New Object() {myreader.Item("AppointmentID"), myreader.Item("PatientName"), myreader.Item("PatContactNo"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("AppStatus"), myreader.Item("SMSStatus"), myreader("EmpContactNo"), myreader("DentistName")})


                    End While

                End With

                DatabaseDisconnect()

            Catch ex As Exception

                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

            End Try

        End If

    End Sub

    Private Sub txtboxSearchApp_Leave(sender As Object, e As EventArgs) Handles txtboxSearchApp.Leave

        txtboxSearchApp.Text = "Search Appointment"

        Me.dataviewMessagesAppointment.Rows.Clear()

        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Appointments"
                .Parameters.AddWithValue("@AppFilterDate", cmbboxMsgAppFilterDate.Text)
                .Parameters.AddWithValue("@AppFilterStatus", cmbboxMsgAppFilterStatus.Text)
                .Parameters.AddWithValue("@SearchTxt", "")

                myreader = .ExecuteReader

                While myreader.Read()

                    'Dim startTime As DateTime = myreader("StartTime").ToString
                    'Dim endTime As DateTime = myreader("EndTime").ToString
                    'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                    Dim AppDate As DateTime = myreader("AppDate").ToString
                    Me.dataviewMessagesAppointment.Rows.Add(New Object() {myreader.Item("AppointmentID"), myreader.Item("PatientName"), myreader.Item("PatContactNo"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("AppStatus"), myreader.Item("SMSStatus"), myreader("EmpContactNo")})


                End While

            End With

            DatabaseDisconnect()

        Catch ex As Exception

            DatabaseDisconnect()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

End Class