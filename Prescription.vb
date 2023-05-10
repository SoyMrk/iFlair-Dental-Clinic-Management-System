Imports System.ComponentModel

Public Class Prescription
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub Prescription_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtboxName.Text = PatientRecordScreen.PatientName
        txtboxAge.Text = PatientRecordScreen.PatientAge
        txtboxAddress.Text = PatientRecordScreen.PatientAddress
        lblDentistName.Text = PatientAppointmentHistory.nameDentist
        lblPrescDate.Text = DateTime.Today.ToString("MM/dd/yyyy")

        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getDentistDetails"
                .Parameters.AddWithValue("@DentID", PatientAppointmentHistory.EmpDentistID)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() Then
                    lblDentistName.Text = myreader("EmpFirstName") + " " + myreader("EmpMiddleName") + " " + myreader("EmpLastName")
                    txtboxLicNo.Text = myreader("LicenseNo")
                    txtboxPTRno.Text = myreader("PTRNo")
                End If
            End With
        Catch ex As Exception

            DatabaseDisconnect()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim timenow As String = Now().ToString("yyyyMMddHHmmss  ")
        Dim newPrescID As String = "PRESC" + timenow

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "InsertNewPrescription"
                .Parameters.AddWithValue("@PrescID", newPrescID)
                .Parameters.AddWithValue("@AppId", PatientAppointmentHistory.AppointmentID)
                .Parameters.AddWithValue("@EmpDentistID", PatientAppointmentHistory.EmpDentistID)
                .Parameters.AddWithValue("@PrescName", richtxtPrescription.Text)


                .ExecuteNonQuery()
                'MsgBox("Prescription Registered", MsgBoxStyle.Information, "Information")

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

            DatabaseDisconnect()

        End With

        Me.Close()

    End Sub

    Private Sub Prescription_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintPrescription.PrinterSettings = PrintDialog1.PrinterSettings
        End If

        PrintPreviewDialog1.Document = PrintPrescription
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen

        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintPrescription_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintPrescription.PrintPage

        Dim prescription As New Bitmap(Me.pnlPrescription.Width, Me.pnlPrescription.Height)
        Me.pnlPrescription.DrawToBitmap(prescription, New Rectangle(0, 0, Me.pnlPrescription.Width, Me.pnlPrescription.Height))
        e.Graphics.DrawImage(prescription, 0, 0)

        Dim psD As New PageSetupDialog
        psD.Document = PrintPrescription

    End Sub

    Private Sub richtxtPrescription_Click(sender As Object, e As EventArgs) Handles richtxtPrescription.Click
        richtxtPrescription.Text = ""
    End Sub

End Class