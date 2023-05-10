Imports Microsoft.Office.Interop
Imports System.IO

Public Class Appointment

    Public Shared MyAppointmentID As String
    Public Shared AppPatientID As String
    Public Shared AppointmentStatus As String

    Public Sub refreshAppointmentDataGrid()

        cmbboxFilterStatus.Text = "No Filter"
        cmbboxFilterDate.Text = "Today"
        Me.dtGridAppointment.Rows.Clear()
        Try
            ConnectDatabase()

            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Appointments"
                .Parameters.AddWithValue("@AppFilterDate", cmbboxFilterDate.Text)
                .Parameters.AddWithValue("@AppFilterStatus", cmbboxFilterStatus.Text)
                .Parameters.AddWithValue("@SearchTxt", "")

                myreader = .ExecuteReader

                While myreader.Read()

                    'Dim startTime As DateTime = myreader("StartTime").ToString
                    'Dim endTime As DateTime = myreader("EndTime").ToString
                    'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                    Dim AppDate As DateTime = myreader("AppDate").ToString


                    Me.dtGridAppointment.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("AppointmentID"), myreader.Item("PatientName"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Description"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("Duration"), myreader.Item("DentistName"), myreader.Item("AppStatus")})

                End While

            End With

            DatabaseDisconnect()
        Catch ex As Exception
            DatabaseDisconnect()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        txtboxAppsFound.Text = dtGridAppointment.Rows.Count.ToString + " appointment/s found"

    End Sub

    Private Sub btnAddNewAppointment_Click(sender As Object, e As EventArgs) Handles btnAddNewAppointment.Click
        HomeScreen.Enabled = False
        AddAppointment.Show()
    End Sub

    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtGridAppointment.RowTemplate.Height = 40

        refreshAppointmentDataGrid()
        cmbboxFilterStatus.Text = "No Filter"
        cmbboxFilterDate.Text = "Today"

    End Sub

    Private Sub dtGridAppointment_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dtGridAppointment.RowsAdded

        txtboxAppsFound.Text = dtGridAppointment.Rows.Count.ToString + " appointment/s found"

    End Sub

    Private Sub txtboxSearchApp_Click(sender As Object, e As EventArgs) Handles txtboxSearchApp.Click

        txtboxSearchApp.Text = ""

    End Sub

    Private Sub dtGridAppointment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridAppointment.CellContentClick

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        AppPatientID = dtGridAppointment.CurrentRow.Cells(0).Value.ToString
        MyAppointmentID = dtGridAppointment.CurrentRow.Cells(1).Value.ToString
        AppointmentStatus = dtGridAppointment.CurrentRow.Cells(9).Value.ToString

        'MsgBox("Patient ID: " + AppPatientID)
        'MsgBox("Appointment ID: " + MyAppointmentID)
        'MsgBox(MyAppointmentID)

        'Dim senderGrid = DirectCast(sender, DataGridView)
        'If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
        '    If e.ColumnIndex = 8 Then
        '        MsgBox("edit")


        '    ElseIf e.ColumnIndex = 10 Then
        '        MsgBox("delete")



        '    End If
        '    Exit Sub
        'End If

        HomeScreen.Enabled = False
        ViewAppointmentvb.Show()


    End Sub

    Private Sub dtGridAppointment_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtGridAppointment.CellMouseMove

        dtGridAppointment.ClearSelection()
        If e.RowIndex > -1 Then
            dtGridAppointment.Rows(e.RowIndex).Selected = True
        End If

    End Sub


    Private Sub txtboxSearchApp_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearchApp.TextChanged

        If cmbboxFilterDate.Text = "Today" Or cmbboxFilterDate.Text = "All" Or cmbboxFilterDate.Text = "Tommorow" Or cmbboxFilterDate.Text = "Week" Or cmbboxFilterDate.Text = "Month" Then

            If txtboxSearchApp.Text = "Search appointment" Or txtboxSearchApp.Text = "" Then

                Me.dtGridAppointment.Rows.Clear()

                Try
                    ConnectDatabase()
                    With sqlcmd
                        .Connection = DBConnection
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "Appointments"
                        .Parameters.AddWithValue("@AppFilterDate", cmbboxFilterDate.Text)
                        .Parameters.AddWithValue("@AppFilterStatus", cmbboxFilterStatus.Text)
                        .Parameters.AddWithValue("@SearchTxt", txtboxSearchApp.Text)

                        myreader = .ExecuteReader

                        While myreader.Read()

                            'Dim startTime As DateTime = myreader("StartTime").ToString
                            'Dim endTime As DateTime = myreader("EndTime").ToString
                            'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                            Dim AppDate As DateTime = myreader("AppDate").ToString

                            Me.dtGridAppointment.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("AppointmentID"), myreader.Item("PatientName"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Description"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("Duration"), myreader.Item("DentistName"), myreader.Item("AppStatus")})

                        End While

                    End With

                    DatabaseDisconnect()

                Catch ex As Exception

                    DatabaseDisconnect()
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

                End Try

            End If

            Me.dtGridAppointment.Rows.Clear()

            Try
                ConnectDatabase()
                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", txtboxSearchApp.Text)

                    myreader = .ExecuteReader

                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString

                        Me.dtGridAppointment.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("AppointmentID"), myreader.Item("PatientName"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Description"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("Duration"), myreader.Item("DentistName"), myreader.Item("AppStatus")})

                    End While

                End With

                DatabaseDisconnect()

            Catch ex As Exception

                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

            End Try

        End If


    End Sub

    Private Sub cmbboxFilterDate_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxFilterDate.SelectionChangeCommitted

        Me.dtGridAppointment.Rows.Clear()

        If cmbboxFilterDate.Text = "All" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString


                        Me.dtGridAppointment.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("AppointmentID"), myreader.Item("PatientName"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Description"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("Duration"), myreader.Item("DentistName"), myreader.Item("AppStatus")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf cmbboxFilterDate.Text = "Today" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString


                        Me.dtGridAppointment.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("AppointmentID"), myreader.Item("PatientName"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Description"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("Duration"), myreader.Item("DentistName"), myreader.Item("AppStatus")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf cmbboxFilterDate.Text = "Tomorrow" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString


                        Me.dtGridAppointment.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("AppointmentID"), myreader.Item("PatientName"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Description"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("Duration"), myreader.Item("DentistName"), myreader.Item("AppStatus")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf cmbboxFilterDate.Text = "Week" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString


                        Me.dtGridAppointment.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("AppointmentID"), myreader.Item("PatientName"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Description"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("Duration"), myreader.Item("DentistName"), myreader.Item("AppStatus")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf cmbboxFilterDate.Text = "Month" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString


                        Me.dtGridAppointment.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("AppointmentID"), myreader.Item("PatientName"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Description"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("Duration"), myreader.Item("DentistName"), myreader.Item("AppStatus")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        End If

    End Sub

    Private Sub cmbboxFilterStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxFilterStatus.SelectionChangeCommitted

        Me.dtGridAppointment.Rows.Clear()

        If cmbboxFilterDate.Text = "All" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString


                        Me.dtGridAppointment.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("AppointmentID"), myreader.Item("PatientName"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Description"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("Duration"), myreader.Item("DentistName"), myreader.Item("AppStatus")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf cmbboxFilterDate.Text = "Today" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString


                        Me.dtGridAppointment.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("AppointmentID"), myreader.Item("PatientName"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Description"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("Duration"), myreader.Item("DentistName"), myreader.Item("AppStatus")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf cmbboxFilterDate.Text = "Tomorrow" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString


                        Me.dtGridAppointment.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("AppointmentID"), myreader.Item("PatientName"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Description"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("Duration"), myreader.Item("DentistName"), myreader.Item("AppStatus")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf cmbboxFilterDate.Text = "Week" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString


                        Me.dtGridAppointment.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("AppointmentID"), myreader.Item("PatientName"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Description"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("Duration"), myreader.Item("DentistName"), myreader.Item("AppStatus")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        ElseIf cmbboxFilterDate.Text = "Month" Then

            Try
                ConnectDatabase()

                With sqlcmd

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Appointments"
                    .Parameters.AddWithValue("@AppFilterDate", cmbboxFilterDate.Text)
                    .Parameters.AddWithValue("@AppFilterStatus", cmbboxFilterStatus.Text)
                    .Parameters.AddWithValue("@SearchTxt", "")

                    myreader = .ExecuteReader


                    While myreader.Read()

                        'Dim startTime As DateTime = myreader("StartTime").ToString
                        'Dim endTime As DateTime = myreader("EndTime").ToString
                        'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                        Dim AppDate As DateTime = myreader("AppDate").ToString


                        Me.dtGridAppointment.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("AppointmentID"), myreader.Item("PatientName"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Description"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("Duration"), myreader.Item("DentistName"), myreader.Item("AppStatus")})

                    End While

                End With

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        End If

        txtboxAppsFound.Text = dtGridAppointment.Rows.Count.ToString + " appointment/s found"
    End Sub

    Private Sub txtboxSearchApp_Leave(sender As Object, e As EventArgs) Handles txtboxSearchApp.Leave
        txtboxSearchApp.Text = "Search Appointment"

        Me.dtGridAppointment.Rows.Clear()

        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Appointments"
                .Parameters.AddWithValue("@AppFilterDate", cmbboxFilterDate.Text)
                .Parameters.AddWithValue("@AppFilterStatus", cmbboxFilterStatus.Text)
                .Parameters.AddWithValue("@SearchTxt", "")

                myreader = .ExecuteReader

                While myreader.Read()

                    'Dim startTime As DateTime = myreader("StartTime").ToString
                    'Dim endTime As DateTime = myreader("EndTime").ToString
                    'startTime.ToString("h:mm tt"), endTime.ToString("h:mm tt")

                    Dim AppDate As DateTime = myreader("AppDate").ToString

                    Me.dtGridAppointment.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("AppointmentID"), myreader.Item("PatientName"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Description"), myreader.Item("StartTime"), myreader.Item("EndTime"), myreader.Item("Duration"), myreader.Item("DentistName"), myreader.Item("AppStatus")})

                End While

            End With

            DatabaseDisconnect()

        Catch ex As Exception

            DatabaseDisconnect()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

        txtboxAppsFound.Text = dtGridAppointment.Rows.Count.ToString + " appointment/s found"
    End Sub

    Private Sub btnPrintapp_Click(sender As Object, e As EventArgs) Handles btnPrintapp.Click

        Dim StartUpPath As String = Application.StartupPath


        Dim xlsFiles As String = desktopPath + "\Dental Clinic Management System\Reports\Appointments\"
        Dim xlsTemplates As String

        If StartUpPath.Contains("bin") Then
            xlsTemplates = StartUpPath.Replace("\bin\Debug\net6.0-windows\", "\Templates\")
        Else
            xlsTemplates = StartUpPath + "\Templates\"
        End If

        'MsgBox(xlsTemplates)
        'MsgBox(xlsFiles)

        Dim xlsApp As Excel.Application
        Dim xlsWB As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet

        xlsApp = New Excel.Application

        xlsApp.Visible = False
        xlsWB = xlsApp.Workbooks.Open(xlsTemplates & "Appointment.xlsx")

        xlsSheet = xlsWB.Worksheets(1)
        xlsSheet.Unprotect("flair")

        Dim x As Integer
        Dim currentRow As Integer = 9
        For x = 0 To dtGridAppointment.RowCount - 1

            xlsSheet.Cells(currentRow, 1) = dtGridAppointment.Rows(x).Cells("colPatName").Value
            xlsSheet.Cells(currentRow, 2) = dtGridAppointment.Rows(x).Cells("colAppDate").Value.ToString
            xlsSheet.Cells(currentRow, 3) = dtGridAppointment.Rows(x).Cells("colDescription").Value
            xlsSheet.Cells(currentRow, 4) = dtGridAppointment.Rows(x).Cells("colStartTime").Value
            xlsSheet.Cells(currentRow, 5) = dtGridAppointment.Rows(x).Cells("colEndTime").Value
            xlsSheet.Cells(currentRow, 6) = dtGridAppointment.Rows(x).Cells("colDuration").Value
            xlsSheet.Cells(currentRow, 7) = dtGridAppointment.Rows(x).Cells("colDentistName").Value
            xlsSheet.Cells(currentRow, 8) = dtGridAppointment.Rows(x).Cells("colAppStatus").Value

            currentRow += 1

        Next

        xlsSheet.Cells(5, 8) = dtGridAppointment.Rows.Count.ToString
        xlsSheet.Cells(6, 2) = cmbboxFilterDate.Text
        xlsSheet.Cells(6, 3) = cmbboxFilterStatus.Text

        With xlsSheet.Range("A9", "H" & currentRow - 1)
            .Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlInsideHorizontal).Weight = Excel.XlBorderWeight.xlHairline
        End With

        xlsSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape
        xlsApp.ActiveWindow.View = Excel.XlWindowView.xlPageLayoutView
        xlsApp.ActiveWindow.DisplayGridlines = False

        xlsSheet.PageSetup.LeftFooter = "Date Created: " & DateTime.Now & Chr(10) & "Generated by: " & LoginAccount.empName

        Dim myfilename As String = "AppointmentReport-" & DateTime.Now.ToString("MMddyy-HHmmss") & ".xlsx"
        xlsSheet.Protect("flair")

        xlsWB.SaveAs(xlsFiles & myfilename)
        xlsApp.Quit()

        releaseObject(xlsApp)
        releaseObject(xlsWB)
        releaseObject(xlsSheet)

        If File.Exists("C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE") Then

            Process.Start("C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE", """" & xlsFiles & myfilename & """")

        ElseIf File.Exists("C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE") Then

            Process.Start("C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE", """" & xlsFiles & myfilename & """")

        Else

            MessageBox.Show("Excel is not installed in this device", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub

End Class