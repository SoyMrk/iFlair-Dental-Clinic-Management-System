Public Class ButtonAddMedicalHistory
    Private Sub btnAddMedicalHistory_Click(sender As Object, e As EventArgs) Handles btnAddMedicalHistory.Click

        ClearPatientPanel()

        With AddMedicalHistory
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            PatientRecordScreen.PatientProfilePanel.Controls.Add(AddMedicalHistory)
            .BringToFront()
            .Show()
        End With

    End Sub

End Class