Public Class EditPatientAddress

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearPatientPanel()

        With PatientProfile
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            PatientRecordScreen.PatientProfilePanel.Controls.Add(PatientProfile)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub EditPatientAddress_Load(sender As Object, e As EventArgs) Handles Me.Load

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getPatient"
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()

                    txtboxHouseNumber.Text = myreader("HouseNumber").ToString
                    txtboxBrgy.Text = myreader("Barangay").ToString
                    txtboxStreet.Text = myreader("Street").ToString
                    txtboxMunicipality.Text = myreader("Municipality").ToString
                    txtboxProvince.Text = myreader("Province").ToString
                    txtboxZipCode.Text = myreader("ZipCode").ToString

                End While
                DatabaseDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try
        End With




    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim allTxt As New List(Of Control)
        For Each txt As TextBox In FindControlRecursive(allTxt, Me, GetType(TextBox))
            If Not txt.Name = txtboxHouseNumber.Name Then
                If txt.Text = "" Then
                    MsgBox(txt.Name & " field cannot be empty.", MsgBoxStyle.Exclamation, "Information")
                    txt.Select()
                    Exit Sub
                End If
                'MsgBox(txt.Name)
            End If

        Next

        ConnectDatabase()

        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "editPatient"
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@QType", "Address")
                .Parameters.AddWithValue("@FName", "")
                .Parameters.AddWithValue("@MName", "")
                .Parameters.AddWithValue("@LName", "")
                .Parameters.AddWithValue("@NName", "")
                .Parameters.AddWithValue("@PatGender", "")
                .Parameters.AddWithValue("@ContactNo", "")
                .Parameters.AddWithValue("@Birthdate", "")
                .Parameters.AddWithValue("@PatAge", DBNull.Value)
                .Parameters.AddWithValue("@PatReligion", "")
                .Parameters.AddWithValue("@PatNationality", "")
                .Parameters.AddWithValue("@PatOccupation", "")
                .Parameters.AddWithValue("@PatGuardianName", "")
                .Parameters.AddWithValue("@GuardianOccupation", "")
                .Parameters.AddWithValue("@PatRefferor", "")
                .Parameters.AddWithValue("@PatConsultReason", "")
                .Parameters.AddWithValue("@PatComment", "")
                .Parameters.AddWithValue("@PatPreviousDentist", "")
                .Parameters.AddWithValue("@PatLastDentalVisit", "")
                .Parameters.AddWithValue("@PatHouseNumber", txtboxHouseNumber.Text)
                .Parameters.AddWithValue("@PatStreet", txtboxStreet.Text)
                .Parameters.AddWithValue("@PatProvince", txtboxProvince.Text)
                .Parameters.AddWithValue("@PatMunicipality", txtboxMunicipality.Text)
                .Parameters.AddWithValue("@PatBarangay", txtboxBrgy.Text)
                .Parameters.AddWithValue("@PatZipCode", txtboxZipCode.Text)

                .ExecuteNonQuery()
                'MsgBox("Patient Address Updated", MsgBoxStyle.Information, "Information")
                DatabaseDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try
        End With

        ClearPatientPanel()

        With PatientProfile
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            PatientRecordScreen.PatientProfilePanel.Controls.Add(PatientProfile)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub txtboxZipCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxZipCode.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            'MsgBox("Numeric Input Only")
        End If
    End Sub
End Class