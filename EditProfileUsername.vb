Public Class EditProfileUsername
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtboxCurrentname.Text = "" Or txtboxNewName.Text = "" Then
            MessageBox.Show("Please fill all required fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "EmpAccountInfo"
                .Parameters.AddWithValue("@QType", "changeUName")
                .Parameters.AddWithValue("@EmpID", LoginAccount.empID)
                .Parameters.AddWithValue("@UserPass", "")
                .Parameters.AddWithValue("@oldUName", txtboxCurrentname.Text)
                .Parameters.AddWithValue("@newUName", txtboxNewName.Text)

                .ExecuteNonQuery()
                'MsgBox("UserName Updated", MsgBoxStyle.Information, "Information")

            Catch ex As Exception
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

    End Sub

    Private Sub EditProfileUsername_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub

    Private Sub txtboxCurrentname_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtboxNewName.Validating, txtboxCurrentname.Validating

        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        If (txtbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtbox, String.Empty)
        Else
            ErrorProvider1.SetError(txtbox, "This field is required!")
            txtbox.Select()
        End If

    End Sub
End Class