Public Class ButtonAppoointmentHistory
    Private Sub cmbboxAppointmentStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxAppointmentStatus.SelectionChangeCommitted

        ClearPatientPanel()

        With PatientAppointmentHistory
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            PatientRecordScreen.PatientProfilePanel.Controls.Add(PatientAppointmentHistory)
            .BringToFront()
            .Show()
        End With

        PatientAppointmentHistory.refreshdtgridPatAppointment()
    End Sub


End Class