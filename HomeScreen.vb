Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class HomeScreen


    Public Shared PatientRecordScreenPanel As String
    Public Shared AccountProfilePanel As String

    'slide Tab ---------- 
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If MainPanel.Width > 70 Then
            Timer1.Enabled = True
        ElseIf MainPanel.Width < 250 Then
            Timer2.Enabled = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If MainPanel.Width > 70 Then
            MainPanel.Width -= 30
        Else

            Timer1.Enabled = False

            For Each formname As Form In pnlHomeScreen.Controls

                'MsgBox(formname.name)

                If formname.Name = PatientMainScreen.Name Then

                    btnPatient_Click(sender, e)

                ElseIf formname.Name = PatientRecordScreen.Name Then


                    ClearHomeMainPanel()

                    With PatientRecordScreen
                        .WindowState = FormWindowState.Maximized
                        .Dock = DockStyle.Fill And DockStyle.Bottom
                        .AutoSize = True
                        .TopLevel = False
                        pnlHomeScreen.Controls.Add(PatientRecordScreen)
                        .BringToFront()
                        .Show()
                    End With


                ElseIf formname.Name = Appointment.Name Then

                    btnAppointmentDetails_Click(sender, e)

                ElseIf formname.Name = Procedure.Name Then

                    btnProcedure_Click(sender, e)

                ElseIf formname.Name = Treatment.Name Then

                    btnTreatment_Click(sender, e)

                ElseIf formname.Name = Messages.Name Then

                    btnMessages_Click(sender, e)

                ElseIf formname.Name = Inventory.Name Then

                    btnSupplyList_Click(sender, e)

                ElseIf formname.Name = InventoryList.Name Then

                    btnInventory_Click(sender, e)

                ElseIf formname.Name = Employee.Name Then

                    btnEmployeeList_Click(sender, e)

                ElseIf formname.Name = UserInformation.Name Then

                    btnUsers_Click(sender, e)

                ElseIf formname.Name = UserLogs.Name Then

                    btnUserLogs_Click(sender, e)

                ElseIf formname.Name = AccountProfile.Name Then

                    btnSeeProfile_Click(sender, e)

                ElseIf formname.Name = SalesReport.Name Then

                    btnSalesReport_Click(sender, e)

                ElseIf formname.Name = Dashboard.Name Then

                    btnDashboard_Click(sender, e)

                End If


            Next


        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If MainPanel.Width < 250 Then
            MainPanel.Width += 30
        Else
            Timer2.Enabled = False

            For Each formname As Form In pnlHomeScreen.Controls

                'MsgBox(formname.name)

                If formname.Name = PatientMainScreen.Name Then

                    btnPatient_Click(sender, e)

                ElseIf formname.Name = PatientRecordScreen.Name Then


                    ClearHomeMainPanel()

                    With PatientRecordScreen
                        .WindowState = FormWindowState.Maximized
                        .Dock = DockStyle.Fill And DockStyle.Bottom
                        .AutoSize = True
                        .TopLevel = False
                        pnlHomeScreen.Controls.Add(PatientRecordScreen)
                        .BringToFront()
                        .Show()
                    End With


                ElseIf formname.Name = Appointment.Name Then

                    btnAppointmentDetails_Click(sender, e)

                ElseIf formname.Name = Procedure.Name Then

                    btnProcedure_Click(sender, e)

                ElseIf formname.Name = Treatment.Name Then

                    btnTreatment_Click(sender, e)

                ElseIf formname.Name = Messages.Name Then

                    btnMessages_Click(sender, e)

                ElseIf formname.Name = Inventory.Name Then

                    btnSupplyList_Click(sender, e)

                ElseIf formname.Name = InventoryList.Name Then

                    btnInventory_Click(sender, e)

                ElseIf formname.Name = Employee.Name Then

                    btnEmployeeList_Click(sender, e)

                ElseIf formname.Name = UserInformation.Name Then

                    btnUsers_Click(sender, e)

                ElseIf formname.Name = UserLogs.Name Then

                    btnUserLogs_Click(sender, e)

                ElseIf formname.Name = AccountProfile.Name Then

                    btnSeeProfile_Click(sender, e)

                ElseIf formname.Name = SalesReport.Name Then

                    btnSalesReport_Click(sender, e)

                ElseIf formname.Name = Dashboard.Name Then

                    btnDashboard_Click(sender, e)

                ElseIf formname.Name = Calendar.Name Then

                    btnCalendar_Click(sender, e)


                End If


            Next

        End If
    End Sub
    'slide Tab ---------- 

    'dropdown bar ----------   
    Private Sub HomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'sqlstr = "SELECT EmpPhoto from employee WHERE EmployeeID = '" & LoginAccount.empID & "'"

        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getEmployee"
                .Parameters.AddWithValue("@EmpID", LoginAccount.empID)

                myreader = .ExecuteReader

                If myreader.Read Then
                    Dim arrimage() As Byte
                    arrimage = myreader("EmpPhoto")

                    Dim msstream As New System.IO.MemoryStream(arrimage)
                    picboxAccountPhoto.SizeMode = PictureBoxSizeMode.StretchImage
                    picboxAccountPhoto.Image = Image.FromStream(msstream)
                End If
            End With

            DatabaseDisconnect()
        Catch ex As Exception
            DatabaseDisconnect()

        End Try
        panelAppointment.Visible = False
        panelMaterials.Visible = False
        panelAccounts.Visible = False

        txtboxAccountName.Text = LoginAccount.empName

        If LoginAccount.userType = "Administrator" Then
            txtboxAccountType.Text = "Administrator"
        Else
            txtboxAccountType.Text = "Staff"
            btnProcedure.Visible = False
            btnTreatment.Visible = False
            btnAccounts.Visible = False
            btnSalesReport.Visible = False
            picboxDropDown2.Visible = False
        End If

        'MsgBox("Welcome, " + LoginAccount.empName)

        '"Change Appointments missed to cancelled because of unforeseen circumstances like natural disasters
        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "checkToCancelAppointments"

                myreader = .ExecuteReader
            End With
            If myreader.Read Then
                If myreader("toCancelAppointmentsCount") > 0 Then
                    MessageBox.Show("There are " & myreader("toCancelAppointmentsCount") & " Cancelled Appointments", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnDashboard_Click(sender, e)
                End If
            End If

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try

        '"Change patients to Inactive with 10 years old Record
        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "checkToInactivePatients"

                myreader = .ExecuteReader
            End With
            If myreader.Read Then
                If myreader("toInactivePatientCount") > 0 Then
                    MessageBox.Show("There are " & myreader("toInactivePatientCount") & " Inactivated Patients", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnDashboard_Click(sender, e)
                End If
            End If

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try

        btnDashboard_Click(sender, e)

    End Sub

    'NAV DROPDOWN MENU
    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click

        If panelAppointment.Visible = False Then
            panelAppointment.Visible = True
        Else
            panelAppointment.Visible = False
        End If

    End Sub

    'NAV DROPDOWN MENU
    Private Sub btnMaterials_Click(sender As Object, e As EventArgs) Handles btnMaterials.Click

        If panelMaterials.Visible = False Then
            panelMaterials.Visible = True
        Else
            panelMaterials.Visible = False
        End If

    End Sub


    'NAV DROPDOWN MENU
    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click

        If panelAccounts.Visible = False Then
            panelAccounts.Visible = True
        Else
            panelAccounts.Visible = False
        End If

    End Sub
    'dropdown bar ---------- 

    Private Sub btnCalendar_Click(sender As Object, e As EventArgs)
        ClearHomeMainPanel()

        With Calendar
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlHomeScreen.Controls.Add(Calendar)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ClearHomeMainPanel()

        With Dashboard
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlHomeScreen.Controls.Add(Dashboard)
            .BringToFront()
            .Show()
        End With
    End Sub

    'PATIENTS
    Public Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click

        ClearHomeMainPanel()

        With PatientMainScreen

            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlHomeScreen.Controls.Add(PatientMainScreen)
            .BringToFront()
            .Show()

        End With

        PatientRecordScreenPanel = Nothing

    End Sub

    'APPOINTMENTS
    Private Sub btnAppointmentDetails_Click(sender As Object, e As EventArgs) Handles btnAppointmentDetails.Click


        ClearHomeMainPanel()

        With Appointment
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlHomeScreen.Controls.Add(Appointment)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnProcedure_Click(sender As Object, e As EventArgs) Handles btnProcedure.Click

        ClearHomeMainPanel()

        With Procedure
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlHomeScreen.Controls.Add(Procedure)
            .BringToFront()
            .Show()
        End With

    End Sub

    'TRANSACTIONS
    Private Sub btnTreatment_Click(sender As Object, e As EventArgs) Handles btnTreatment.Click

        ClearHomeMainPanel()

        With Treatment
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlHomeScreen.Controls.Add(Treatment)
            .BringToFront()
            .Show()
        End With

    End Sub



    'MESSAGES
    Private Sub btnMessages_Click(sender As Object, e As EventArgs) Handles btnMessages.Click

        ClearHomeMainPanel()

        With Messages
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlHomeScreen.Controls.Add(Messages)
            .BringToFront()
            .Show()
        End With

    End Sub


    'MATERIALS
    Private Sub btnSupplyList_Click(sender As Object, e As EventArgs) Handles btnSupplyList.Click

        ClearHomeMainPanel()

        With Inventory
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlHomeScreen.Controls.Add(Inventory)
            .BringToFront()
            .Show()

        End With


    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        ClearHomeMainPanel()

        With InventoryList
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlHomeScreen.Controls.Add(InventoryList)
            .BringToFront()
            .Show()
        End With

    End Sub


    'ACCOUNTS

    Private Sub btnEmployeeList_Click(sender As Object, e As EventArgs) Handles btnEmployeeList.Click

        ClearHomeMainPanel()

        With Employee
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlHomeScreen.Controls.Add(Employee)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click

        ClearHomeMainPanel()

        With UserInformation
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlHomeScreen.Controls.Add(UserInformation)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnUserLogs_Click(sender As Object, e As EventArgs) Handles btnUserLogs.Click

        ClearHomeMainPanel()

        With UserLogs
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlHomeScreen.Controls.Add(UserLogs)
            .BringToFront()
            .Show()
        End With

    End Sub


    'PROFILE

    Private Sub btnSeeProfile_Click(sender As Object, e As EventArgs) Handles btnSeeProfile.Click

        ClearHomeMainPanel()

        With AccountProfile
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlHomeScreen.Controls.Add(AccountProfile)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click

        ClearHomeMainPanel()

        With SalesReport
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            pnlHomeScreen.Controls.Add(SalesReport)
            .BringToFront()
            .Show()
        End With

    End Sub




    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub


    Private Sub HomeScreen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If MessageBox.Show(" Are you sure you want to quit?", "Are you sure?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'MsgBox("Yes")

            LoginAccount.txtboxUsername.Text = ""
            LoginAccount.txtboxPassword.Text = ""


            ConnectDatabase()
            With sqlcmd
                Try
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "NewUserLog"
                    .Parameters.AddWithValue("@QType", "Out")
                    .Parameters.AddWithValue("@ULogID", LoginAccount.iduserlog)
                    .Parameters.AddWithValue("@UName", "")
                    .Parameters.AddWithValue("@UType", "")
                    .ExecuteNonQuery()

                Catch ex As Exception
                    DatabaseDisconnect()
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
                DatabaseDisconnect()
            End With

            Dim StartUpPath As String = Application.StartupPath
            Dim Backups As String = StartUpPath.Replace("\bin\Debug\net6.0-windows\", "\.dbbackups\")


            If StartUpPath.Contains("bin") Then
                Backups = StartUpPath.Replace("\bin\Debug\net6.0-windows\", "\.dbbackups\")
            Else
                Backups = StartUpPath + "\.dbbackups\"
            End If

            Dim backupName As String = Now().ToString("yyyyMMddHHmmssff") + "dbdentalbackup" + ".sql"

            'BACKUP
            Try
                Dim backupConString = "server=" & My.Settings.serverIp & ";user id=" & My.Settings.userId & ";password=" & My.Settings.password & ";database=" & My.Settings.dbName & ""
                Dim connection As MySqlConnection = New MySqlConnection(backupConString)
                Dim backSqlCmd As MySqlCommand = New MySqlCommand

                backSqlCmd.Connection = connection

                connection.Open()

                Dim mb As MySqlBackup = New MySqlBackup(backSqlCmd)
                mb.ExportToFile(Backups + backupName)
                'MsgBox("Backup Succesfully")

                connection.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'RESTORE
            'With sqlcmd

            '    .Connection = DBConnection
            '    Dim backup As MySqlBackup = New MySqlBackup(sqlcmd)
            '    backup.ImportFromFile("C:\Users\Mac\Desktop\dbdentalclinics.sql")

            'End With

            LoginAccount.Show()
        Else
            'MsgBox("No")
            e.Cancel = True
        End If



    End Sub

    Private Sub btnDiscount_Click(sender As Object, e As EventArgs) Handles btnDiscount.Click
        Me.Enabled = False
        Discount.Show()
    End Sub
End Class