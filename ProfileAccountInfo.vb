Public Class ProfileAccountInfo
    Private Sub btnEditUsername_Click(sender As Object, e As EventArgs) Handles btnEditUsername.Click

        EditProfileUsername.txtboxCurrentname.Text = txtboxUsername.Text

        ClearUserEmpProfPanel()

        With EditProfileUsername
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            AccountProfile.pnlProfile.Controls.Add(EditProfileUsername)
            .BringToFront()
            .Show()
        End With



    End Sub

    Private Sub btnEditPass_Click(sender As Object, e As EventArgs) Handles btnEditPass.Click

        ClearUserEmpProfPanel()

        With EditProfilePassword
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            AccountProfile.pnlProfile.Controls.Add(EditProfilePassword)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub ProfileAccountInfo_Load(sender As Object, e As EventArgs) Handles Me.Load

        ConnectDatabase()

        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "EmpAccountInfo"
                .Parameters.AddWithValue("@QType", "Get")
                .Parameters.AddWithValue("@EmpID", LoginAccount.empID)
                .Parameters.AddWithValue("@UserPass", "")
                .Parameters.AddWithValue("@oldUName", "")
                .Parameters.AddWithValue("@newUName", "")
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() Then

                    txtboxAccountType.Text = myreader("UserType").ToString
                    txtboxUsername.Text = myreader("UserName").ToString
                    txtboxDateCreated.Text = myreader("DateCreated").ToString

                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With

        DatabaseDisconnect()

    End Sub

End Class