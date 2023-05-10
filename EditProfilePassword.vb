Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class EditProfilePassword
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        ClearUserEmpProfPanel()

        With ProfileAccountInfo
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            AccountProfile.pnlProfile.Controls.Add(ProfileAccountInfo)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnSave_Click(sender As Object, newPass As EventArgs) Handles btnSave.Click


        If txtboxCurrentPass.Text = "" Then
            MsgBox("Current Password Cannot Be Empty", MsgBoxStyle.Exclamation, "Information")
            txtboxCurrentPass.Select()
            Exit Sub
        ElseIf txtboxNewPass.Text = "" And txtboxNewPass.Text = "" Then
            MsgBox("New Password Cannot Be Empty", MsgBoxStyle.Exclamation, "Information")
            txtboxNewPass.Select()
            Exit Sub
        End If

        Dim currentPass As String = txtboxCurrentPass.Text
        Dim newPassword As String = txtboxNewPass.Text
        Dim confirmPass As String = txtboxConfirmPass.Text
        Dim userName As String = LoginAccount.userName

        'sqlstr = "SELECT * FROM user_account WHERE UserPassword ='" & txtboxCurrentPass.Text & "' AND UserName ='" & userName & "'"
        'MsgBox(sqlstr)

        ConnectDatabase()

        With sqlcmd
            .Connection = DBConnection
            .CommandType = CommandType.StoredProcedure
            .CommandText = "EmpAccountInfo"
            .Parameters.AddWithValue("@QType", "verifyPassword")
            .Parameters.AddWithValue("@EmpID", LoginAccount.empID)
            .Parameters.AddWithValue("@UserPass", txtboxCurrentPass.Text)
            .Parameters.AddWithValue("@oldUName", userName)
            .Parameters.AddWithValue("@newUName", "")
        End With
        myreader = sqlcmd.ExecuteReader

        If myreader.HasRows Then

            If newPassword = confirmPass Then

                'sqlstr = "UPDATE `user_account` SET UserPassword = '" & txtboxConfirmPass.Text & "' WHERE UserName = '" & userName & "'"

                'MsgBox(sqlstr)

                ConnectDatabase()

                With sqlcmd

                    Try
                        .Connection = DBConnection
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "EmpAccountInfo"
                        .Parameters.AddWithValue("@QType", "changePassword")
                        .Parameters.AddWithValue("@EmpID", LoginAccount.empID)
                        .Parameters.AddWithValue("@UserPass", txtboxConfirmPass.Text)
                        .Parameters.AddWithValue("@oldUName", userName)
                        .Parameters.AddWithValue("@newUName", "")

                        .ExecuteNonQuery()
                        'MsgBox("Password Updated", MsgBoxStyle.Information, "Information")

                    Catch ex As Exception
                        DatabaseDisconnect()
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                    End Try

                    DatabaseDisconnect()

                End With

                ClearUserEmpProfPanel()

                With ProfileAccountInfo
                    .WindowState = FormWindowState.Maximized
                    .Dock = DockStyle.Fill And DockStyle.Bottom
                    .AutoSize = True
                    .TopLevel = False
                    AccountProfile.pnlProfile.Controls.Add(ProfileAccountInfo)
                    .BringToFront()
                    .Show()
                End With

            Else
                MsgBox("New Password Do Not Match", MsgBoxStyle.Exclamation, "Information")
            End If





        Else
            MessageBox.Show("Incorrect Current Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DatabaseDisconnect()
        End If
        DatabaseDisconnect()

    End Sub

    Private Sub txtboxCurrentPass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtboxNewPass.Validating, txtboxCurrentPass.Validating, txtboxConfirmPass.Validating

        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        If (txtbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtbox, String.Empty)
        Else
            ErrorProvider1.SetError(txtbox, "This field is required!")
            txtbox.Select()
        End If

    End Sub
End Class