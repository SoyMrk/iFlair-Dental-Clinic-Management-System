Public Class ButtonAddAppointment
    Private Sub btnAddPatAppointment_Click(sender As Object, e As EventArgs) Handles btnAddPatAppointment.Click
        HomeScreen.Enabled = False

        AddPatientAppointment.Show()
    End Sub
End Class