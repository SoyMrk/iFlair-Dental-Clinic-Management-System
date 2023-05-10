Imports System.ComponentModel

Public Class AddAppointment

    Private currentForm As Form = Nothing

    Public Sub openChildForm(Childform As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = Childform
        currentForm.TopLevel = False
        currentForm.FormBorderStyle = FormBorderStyle.None
        currentForm.Dock = DockStyle.Fill
        pnlAddAppointment.Controls.Add(Childform)
        pnlAddAppointment.Tag = Childform
        Childform.BringToFront()
        Childform.Show()

    End Sub

    Private Sub btnNewPatient_Click(sender As Object, e As EventArgs) Handles btnNewPatient.Click

        pnlClicked.Width = btnNewPatient.Width
        pnlClicked.Left = btnNewPatient.Left

        openChildForm(New AppointmentNewPatient())
    End Sub

    Private Sub btnOldPatient_Click(sender As Object, e As EventArgs) Handles btnProfileAddressInfo.Click, btnOldPatient.Click

        pnlClicked.Width = btnOldPatient.Width
        pnlClicked.Left = btnOldPatient.Left

        openChildForm(New AppointmentOldPatient())
    End Sub

    Private Sub AddAppointment_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnNewPatient_Click(sender, e)
    End Sub

    Private Sub AddAppointment_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ClearHomeMainPanel()

        With Appointment
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            HomeScreen.pnlHomeScreen.Controls.Add(Appointment)
            .BringToFront()
            .Show()
        End With

        HomeScreen.Enabled = True
    End Sub
End Class