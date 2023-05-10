Public Class EditProfileAddress
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        ClearUserEmpProfPanel()

        With ProfileAddressInfo
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            AccountProfile.pnlProfile.Controls.Add(ProfileAddressInfo)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub EditProfileAddress_Load(sender As Object, e As EventArgs) Handles Me.Load


        ConnectDatabase()

        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getEmployee"
                .Parameters.AddWithValue("@EmpID", LoginAccount.empID)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() Then

                    txtboxHouseNo.Text = myreader("EmpHouseNumber").ToString
                    txtboxStreet.Text = myreader("EmpStreet").ToString
                    txtboxBrgy.Text = myreader("EmpBarangay").ToString
                    txtboxProvince.Text = myreader("EmpProvince").ToString
                    txtboxMunicipality.Text = myreader("EmpMunicipality").ToString
                    txtboxZipCode.Text = myreader("EmpZipCode").ToString

                End If



            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With

        DatabaseDisconnect()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim allTxt As New List(Of Control)
        For Each txt As TextBox In FindControlRecursive(allTxt, Me, GetType(TextBox))
            If Not txt.Name = txtboxHouseNo.Name Then
                If txt.Text = "" Then
                    MsgBox(txt.Name & " field cannot be emppty.", MsgBoxStyle.Exclamation, "Information")
                    txt.Select()
                    Exit Sub
                End If
            End If
            'MsgBox(txt.Name)
        Next

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "EditEmployee"
                .Parameters.AddWithValue("@QType", "Address")
                .Parameters.AddWithValue("@EmpID", LoginAccount.empID)
                .Parameters.AddWithValue("@LastName", "")
                .Parameters.AddWithValue("@MiddleName", "")
                .Parameters.AddWithValue("@FirstName", "")
                .Parameters.AddWithValue("@dateofbirth", DBNull.Value)
                .Parameters.AddWithValue("@Age", DBNull.Value)
                .Parameters.AddWithValue("@Gender", "")
                .Parameters.AddWithValue("@Contact", "")
                .Parameters.AddWithValue("@Email", "")
                .Parameters.AddWithValue("@GovernmentID", "")
                .Parameters.AddWithValue("@GovIDNum", "")
                .Parameters.AddWithValue("@HouseNumber", txtboxHouseNo.Text)
                .Parameters.AddWithValue("@Street", txtboxStreet.Text)
                .Parameters.AddWithValue("@Barangay", txtboxBrgy.Text)
                .Parameters.AddWithValue("@Municipality", txtboxMunicipality.Text)
                .Parameters.AddWithValue("@Province", txtboxProvince.Text)
                .Parameters.AddWithValue("@ZipCode", txtboxZipCode.Text)

                .ExecuteNonQuery()
                'MsgBox("Employee Addrress Updated", MsgBoxStyle.Information, "Information")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

            DatabaseDisconnect()

        End With

        ClearUserEmpProfPanel()

        With ProfileAddressInfo
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            AccountProfile.pnlProfile.Controls.Add(ProfileAddressInfo)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub Input_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtboxZipCode.Validating, txtboxStreet.Validating, txtboxProvince.Validating, txtboxMunicipality.Validating, txtboxBrgy.Validating

        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        If (txtbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtbox, String.Empty)
        Else
            ErrorProvider1.SetError(txtbox, "This field is required!")
            txtbox.Select()
        End If

    End Sub
End Class