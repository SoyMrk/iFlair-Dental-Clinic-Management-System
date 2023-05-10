Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class LoginAccount

    Public Shared userName As String
    Public Shared empID As String
    Public Shared empName As String
    Public Shared userType As String
    Public Shared iduserlog As String

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

        Me.Enabled = False
        ConnectionTest.Show()

    End Sub



    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click

        If txtboxPassword.UseSystemPasswordChar = True Then
            txtboxPassword.UseSystemPasswordChar = False
        Else
            txtboxPassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub labelRegisterAccount_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Verification.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtboxUsername.Text = String.Empty Or txtboxUsername.Text = String.Empty Then
            MessageBox.Show("Username or Password is Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'sqlstr = "SELECT UserName, UserPassword, u.EmployeeID, concat(EmpFirstName,"" "", EmpLastName) AS EmpName, UserType FROM user_account u INNER JOIN employee e ON u.EmployeeID = e.EmployeeID  WHERE UserName ='" & txtboxUsername.Text & "' AND UserPassword ='" & txtboxPassword.Text & "'"

        'MsgBox(sqlstr)

        ConnectDatabase()

        If DBConnection.State = ConnectionState.Closed Then
            txtboxUsername.Text = String.Empty
            txtboxPassword.Text = String.Empty
            Exit Sub
        End If

        With sqlcmd
            .Connection = DBConnection
            .CommandType = CommandType.StoredProcedure
            .CommandText = "LoginAccount"
            .Parameters.AddWithValue("@UName", txtboxUsername.Text)
            .Parameters.AddWithValue("@PWord", txtboxPassword.Text)
        End With

        myreader = sqlcmd.ExecuteReader

        If myreader.Read Then

            userName = myreader("UserName").ToString
            empID = myreader("EmployeeID").ToString
            userType = myreader("UserType").ToString
            empName = myreader("EmpName").ToString

            myreader.Close()
            DatabaseDisconnect()

            'USERLOGS
            ConnectDatabase()
            iduserlog = Now().ToString("yyyyMMddHHmmss")
            With sqlcmd
                Try
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "NewUserLog"
                    .Parameters.AddWithValue("@QType", "In")
                    .Parameters.AddWithValue("@ULogID", iduserlog)
                    .Parameters.AddWithValue("@UName", userName)
                    .Parameters.AddWithValue("@UType", userType)
                    .ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End With
            DatabaseDisconnect()

            Me.Hide()
            HomeScreen.Show()

        Else
            MessageBox.Show("Incorrect username or password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DatabaseDisconnect()
        End If

    End Sub

    Private Sub LoginAccount_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then btnLogin_Click(sender, e)
    End Sub

    Private Sub LoginAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Flair Dental Clinic"

        txtboxUsername.Select()

        'FORMS
        If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\Forms") Then
            System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\Forms")
        End If

        'REPORTS
        If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\Reports\SalesReports") Then
            System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\Reports\SalesReports")
        End If

        If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\Reports\Appointments") Then
            System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\Reports\Appointments")
        End If

        If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\Reports\InventoryRecords") Then
            System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\Reports\InventoryRecords")
        End If

        'PATIENT RECORDS

        If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\PatientRecords") Then
            System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\PatientRecords")
        End If


    End Sub

    Private Sub LoginAccount_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        txtboxUsername.Select()
    End Sub

    Private Sub labelForgotPassword_Click(sender As Object, e As EventArgs) Handles labelForgotPassword.Click
        Me.Enabled = False
        ForgotPassword.Show()
    End Sub

    Private Sub labelRegisterAccount_Click_1(sender As Object, e As EventArgs) Handles labelRegisterAccount.Click

        Try
            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "checkAdmins"
                myreader = .ExecuteReader
            End With

            If myreader.HasRows Then
                Me.Enabled = False
                Verification.Show()
            Else
                AddNewEmployee.Show()
            End If

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try


    End Sub

    Private Sub LoginAccount_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        'Dim StartUpPath As String = Application.StartupPath
        'Dim Backups As String = StartUpPath.Replace("\bin\Debug\net6.0-windows\", "\.dbbackups\")


        'If StartUpPath.Contains("bin") Then
        '    Backups = StartUpPath.Replace("\bin\Debug\net6.0-windows\", "\.dbbackups\")
        'Else
        '    Backups = StartUpPath + "\.dbbackups\"
        'End If

        'Dim backupName As String = Now().ToString("yyyyMMddHHmmssff") + "dbdentalbackup" + ".sql"

        ''BACKUP
        'Try
        '    Dim backupConString = "server=" & My.Settings.serverIp & ";user id=" & My.Settings.userId & ";password=" & My.Settings.password & ";database=" & My.Settings.dbName & ""
        '    Dim connection As MySqlConnection = New MySqlConnection(backupConString)
        '    Dim backSqlCmd As MySqlCommand = New MySqlCommand

        '    backSqlCmd.Connection = connection

        '    connection.Open()

        '    Dim mb As MySqlBackup = New MySqlBackup(backSqlCmd)
        '    mb.ExportToFile(Backups + backupName)
        '    'MsgBox("Backup Succesfully")

        '    connection.Close()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        ''RESTORE
        ''With sqlcmd

        ''    .Connection = DBConnection
        ''    Dim backup As MySqlBackup = New MySqlBackup(sqlcmd)
        ''    backup.ImportFromFile("C:\Users\Mac\Desktop\dbdentalclinics.sql")

        ''End With

    End Sub


End Class
