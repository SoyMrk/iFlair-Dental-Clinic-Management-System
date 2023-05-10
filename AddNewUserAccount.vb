Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class AddNewUserAccount
    Private Sub AddNewUserAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            ConnectDatabase()
            Dim EmpTable As New DataTable
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "checkEmpUserAcc"

                myAdapter.SelectCommand = sqlcmd
                myAdapter.Fill(EmpTable)
            End With
            cmbboxEmployeeNumber.DataSource = EmpTable
            cmbboxEmployeeNumber.ValueMember = "EmployeeID"
            cmbboxEmployeeNumber.DisplayMember = "EmployeeID"

            cmbboxEmployeeName.DataSource = EmpTable
            cmbboxEmployeeName.ValueMember = "EmployeeId"
            cmbboxEmployeeName.DisplayMember = "FullName"
            DatabaseDisconnect()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()
        End Try






    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'MsgBox(cmbboxEmployeeNumber.Text)
        If txtboxUsername.Text = "" Or txtboxUserPassword.Text = "" Then
            MsgBox("Username or Password cannot be Empty", MsgBoxStyle.Exclamation, "Information")
            Exit Sub
        End If


        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "InsertNewUserAccount"
                .Parameters.AddWithValue("@UName", txtboxUsername.Text)
                .Parameters.AddWithValue("@UPassword", txtboxUserPassword.Text)
                .Parameters.AddWithValue("@EmpId", cmbboxEmployeeNumber.Text)
                .Parameters.AddWithValue("@UType", cmbboxAccountType.Text)

                .ExecuteNonQuery()
                'MsgBox("User Account Registered", MsgBoxStyle.Information, "Information")

                DatabaseDisconnect()
            Catch ex As Exception
                If ex.Message.Contains("Duplicate") Then
                    MessageBox.Show("Username already exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End If
                Exit Sub
                DatabaseDisconnect()
            End Try


        End With

        If cmbboxAccountType.Text = "Administrator" Then
            SecurityQuestions.UName = txtboxUsername.Text
            SecurityQuestions.Show()
        End If

        Me.Close()



        HomeScreen.Enabled = True

        UserInformation.refreshDataGridUserInfo()


    End Sub



    Private Sub AddNewUserAccount_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        HomeScreen.Enabled = True

    End Sub

    Private Sub Input_Validating(sender As Object, e As CancelEventArgs) Handles txtboxUserPassword.Validating, txtboxUsername.Validating

        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        If (txtbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtbox, String.Empty)
        Else
            ErrorProvider1.SetError(txtbox, "This field is required!")
            txtbox.Select()
        End If


    End Sub
End Class