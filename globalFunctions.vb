
Imports System.Text.RegularExpressions
Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types

Module globalFunctions

    Public desktopPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop

    Public Sub SendMessage(ByVal AccSid As String, ByVal AuThoken As String, ByVal FromNum As String, ByVal ToNum As String, ByVal messageBody As String)

        ' Find your Account Sid and Auth Token at twilio.com/console
        ' Const accountSid = "ACd27a70ed7fa486818bc6d1dad6b13df0"
        ' Const authToken = "8da93e5e525ca76a373ad268a1a2b85b"
        TwilioClient.Init(AccSid, AuThoken)

        Dim toNumber = New PhoneNumber(ToNum)
        Dim message = MessageResource.Create(
            toNumber, from:=New PhoneNumber(FromNum),
            body:=messageBody)

        Console.WriteLine(message.Sid)

        'MsgBox("Message Successfully Sent")

    End Sub

    Public Function TakeScreenshotPanel(ByVal control As Control) As Bitmap

        Dim tmpImg As New Bitmap(control.Width, control.Height)
        Using g As Graphics = Graphics.FromImage(tmpImg)
            g.CopyFromScreen(control.PointToScreen(New Point(0, 0)), New Point(0, 0), New Size(control.Width, control.Height))
        End Using
        Return tmpImg

    End Function
    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Function HaveInternetConnection() As Boolean

        Try
            Return My.Computer.Network.Ping("www.google.com")
        Catch
            Return False
        End Try

    End Function
    Public Function validatePhoneNumber(ByVal phoneNumber As String) As Boolean
        Return phoneNumber(0) = "0" And phoneNumber(1) = "9" And phoneNumber.Length = "11" And Regex.IsMatch(phoneNumber, "^[0-9 ]+$")
    End Function

    Public Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

        Return emailExpression.IsMatch(email)
    End Function

    Public Function isBloodPressure(ByVal bloodPressure As String) As Boolean
        Static bloodPressureExpression As New Regex("^\d{1,3}\/\d{1,3}$")

        Return bloodPressureExpression.IsMatch(bloodPressure)
    End Function

    Public Function FindControlRecursive(ByVal list As List(Of Control), ByVal parent As Control, ByVal ctrlType As System.Type) As List(Of Control)
        If parent Is Nothing Then Return list
        If parent.GetType Is ctrlType Then
            list.Add(parent)
        End If
        For Each child As Control In parent.Controls
            FindControlRecursive(list, child, ctrlType)
        Next
        Return list
    End Function

    'Homescreen Panel
    Public Sub ClearHomeMainPanel()
        While HomeScreen.pnlHomeScreen.Controls.Count > 0
            HomeScreen.pnlHomeScreen.Controls(0).Dispose()
        End While
    End Sub
    'Patient Panel
    Public Sub ClearPatientPanel()
        While PatientRecordScreen.PatientProfilePanel.Controls.Count > 0
            PatientRecordScreen.PatientProfilePanel.Controls(0).Dispose()
        End While
    End Sub
    'Employee Profile Panel
    Public Sub ClearUserEmpProfPanel()
        While AccountProfile.pnlProfile.Controls.Count > 0
            AccountProfile.pnlProfile.Controls(0).Dispose()
        End While
    End Sub

    Public Sub clearAppointmentTodayPanel()
        While PatientAppointmentHistory.pnlAppointmentToday.Controls.Count > 0
            PatientAppointmentHistory.pnlAppointmentToday.Controls(0).Dispose()
        End While
    End Sub

    Public Sub clearAppointmentAppointmentHistoryPanel()
        While PatientAppointmentHistory.pnlAppointmentHistory.Controls.Count > 0
            PatientAppointmentHistory.pnlAppointmentHistory.Controls(0).Dispose()
        End While
    End Sub

    Public Sub clearInvoicePanel()
        While AddBilling.pnlInvoice.Controls.Count > 0
            AddBilling.pnlInvoice.Controls(0).Dispose()
        End While
    End Sub

    Public Sub clearReportsPanel()
        While SalesReport.pnlSalesReport.Controls.Count > 0
            SalesReport.pnlSalesReport.Controls(0).Dispose()
        End While
    End Sub

End Module
