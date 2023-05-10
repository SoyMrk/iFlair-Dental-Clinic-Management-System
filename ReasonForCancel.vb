Imports System.ComponentModel

Public Class ReasonForCancel
    Private Sub ReasonForCancel_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "cancelAppointment"
                .Parameters.AddWithValue("@AppID", PatientAppointmentHistory.AppointmentID)
                .Parameters.AddWithValue("@txtReason", rchtxtboxReason.Text)
                .ExecuteNonQuery()
                'MsgBox("Appointment Cancelled", MsgBoxStyle.Information, "Information")

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

            DatabaseDisconnect()

        End With

        clearAppointmentTodayPanel()

        With ButtonAddAppointment

            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            PatientAppointmentHistory.pnlAppointmentToday.Controls.Add(ButtonAddAppointment)
            .BringToFront()
            .Show()

        End With
        PatientAppointmentHistory.refreshdtgridPatAppointment()

        Me.Close()

    End Sub
End Class