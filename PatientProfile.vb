Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Office.Interop
Imports System.IO
Imports Org.BouncyCastle.Crypto.Agreement

Public Class PatientProfile
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEditBasic.Click

        ClearPatientPanel()

        With EditPatientRecord
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            PatientRecordScreen.PatientProfilePanel.Controls.Add(EditPatientRecord)
            .BringToFront()
            .Show()
        End With

    End Sub


    Private Sub btnEditAddress_Click(sender As Object, e As EventArgs) Handles btnEditAddress.Click

        ClearPatientPanel()

        With EditPatientAddress
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            PatientRecordScreen.PatientProfilePanel.Controls.Add(EditPatientAddress)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub PatientProfile_Load(sender As Object, e As EventArgs) Handles Me.Load

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

                    txtboxPatientNumber.Text = myreader("Patientid").ToString
                    txtboxLastName.Text = myreader("LastName").ToString
                    txtboxFirstName.Text = myreader("FirstName").ToString
                    txtboxMiddleName.Text = myreader("MiddleName").ToString
                    txtboxNickName.Text = myreader("Nickname").ToString
                    txtboxSex.Text = myreader("Gender").ToString
                    txtboxContactNo.Text = myreader("PatContactNo").ToString
                    txtboxAge.Text = myreader("Age").ToString

                    txtboxDateofBirth.Text = myreader.GetDateTime("DateofBirth").ToString("MM/dd/yyyy")

                    txtboxReligion.Text = myreader("Religion").ToString
                    txtboxNationality.Text = myreader("Nationality").ToString
                    txtboxOccupation.Text = myreader("PatientOccupation").ToString

                    txtboxHouseNumber.Text = myreader("HouseNumber").ToString
                    txtboxStreet.Text = myreader("Street").ToString
                    txtboxProvince.Text = myreader("Province").ToString
                    txtboxMunicipality.Text = myreader("Municipality").ToString
                    txtboxBrgy.Text = myreader("Barangay").ToString
                    txtboxZipCode.Text = myreader("ZipCode").ToString

                    txtboxRefferedBy.Text = myreader("ReferredBy").ToString
                    txtboxPreviousDentist.Text = myreader("PreviousDentist").ToString
                    txtboxLastDentalVisit.Text = myreader("LastDentalVisit").ToString

                    txtboxReason.Text = myreader("ConsultReason").ToString
                    txtboxComments.Text = myreader("Comment").ToString
                    txtboxParentsName.Text = myreader("GuardianName").ToString
                    txtboxParentOccupation.Text = myreader("GuardianOccupation").ToString

                End While

                DatabaseDisconnect()


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With



    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click


        Dim StartUpPath As String = Application.StartupPath

        If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName) Then
            System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)
        End If

        Dim PatFiles As String = desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName + "\"
        Dim xlsTemplates As String

        If StartUpPath.Contains("bin") Then
            xlsTemplates = StartUpPath.Replace("\bin\Debug\net6.0-windows\", "\Templates\")
        Else
            xlsTemplates = StartUpPath + "\Templates\"
        End If

        'MsgBox(xlsTemplates)
        'MsgBox(xlsFiles)

        Dim xlsApp As Excel.Application
        Dim xlsWB As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet

        xlsApp = New Excel.Application

        xlsApp.Visible = False
        xlsWB = xlsApp.Workbooks.Open(xlsTemplates & "PatientRecord.xlsx")

        xlsSheet = xlsWB.Worksheets(1)
        xlsSheet.Unprotect("flair")


        xlsSheet.Cells(1, 4) = txtboxComments.Text
        xlsSheet.Cells(5, 2) = txtboxFirstName.Text + " " + txtboxMiddleName.Text + " " + txtboxLastName.Text
        xlsSheet.Cells(6, 2) = txtboxDateofBirth.Text
        xlsSheet.Cells(6, 5) = txtboxNickName.Text
        xlsSheet.Cells(7, 5) = txtboxAge.Text
        xlsSheet.Cells(7, 2) = txtboxReligion.Text
        xlsSheet.Cells(8, 2) = txtboxNationality.Text
        xlsSheet.Cells(8, 5) = txtboxSex.Text
        xlsSheet.Cells(9, 2) = txtboxOccupation.Text
        xlsSheet.Cells(9, 5) = txtboxContactNo.Text
        xlsSheet.Cells(10, 2) = txtboxHouseNumber.Text + " " + txtboxStreet.Text + " " + txtboxBrgy.Text + " " + txtboxMunicipality.Text + " " + txtboxProvince.Text + " " + txtboxZipCode.Text

        xlsSheet.Cells(14, 2) = txtboxParentsName.Text
        xlsSheet.Cells(15, 2) = txtboxParentOccupation.Text
        xlsSheet.Cells(17, 3) = txtboxRefferedBy.Text
        xlsSheet.Cells(18, 3) = txtboxReason.Text

        xlsSheet.Cells(22, 2) = txtboxPreviousDentist.Text
        xlsSheet.Cells(23, 2) = txtboxLastDentalVisit.Text

        xlsApp.ActiveWindow.View = Excel.XlWindowView.xlPageLayoutView
        xlsApp.ActiveWindow.DisplayGridlines = False

        xlsSheet.PageSetup.LeftFooter = "Date Created: " & DateTime.Now & Chr(10) & "Generated by: " & LoginAccount.empName

        Dim myfilename As String = "Patient Record - " & PatientRecordScreen.PatientName & " - " & DateTime.Now.ToString("MM-dd-yy") & ".xlsx"
        Dim myFilenameAsPdf As String = "Patient Record - " & PatientRecordScreen.PatientName & " - " & DateTime.Now.ToString("MM-dd-yy") & ".pdf"

        xlsSheet.Protect("flair")

        'SAVING TO EXCEL
        xlsWB.SaveAs(PatFiles & myfilename)
        'SAVING TO PDF
        xlsSheet.PrintOutEx(Copies:=1, Preview:=False, ActivePrinter:="Microsoft Print to PDF", PrintToFile:=True, Collate:=True, PrToFileName:=PatFiles & myFilenameAsPdf, IgnorePrintAreas:=False)

        xlsApp.Quit()

        releaseObject(xlsApp)
        releaseObject(xlsWB)
        releaseObject(xlsSheet)

        My.Computer.FileSystem.DeleteFile(PatFiles & myfilename)

        MessageBox.Show("Successfully exported to PDF", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'OPENING IN CHROME ELSE FOLDER
        If File.Exists("C:\Program Files\Google\Chrome\Application\chrome.exe") Then
            Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", """" & PatFiles & myFilenameAsPdf & """")
        ElseIf File.Exists("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe") Then
            Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", """" & PatFiles & myFilenameAsPdf & """")
        Else
            Process.Start("explorer.exe", desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)
        End If

        'OPENING IN EXCEL
        'If File.Exists("C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE") Then

        '    Process.Start("C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE", """" & PatFiles & myfilename & """")

        'ElseIf File.Exists("C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE") Then

        '    Process.Start("C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE", """" & PatFiles & myfilename & """")

        'Else

        '    MessageBox.Show("Excel is not installed in this device", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        'End If


    End Sub

End Class