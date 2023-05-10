Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class DentalChartFullScreen

    Private Sub DentalChartFullScreen_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            ConnectDatabase()
            Dim DRTable As New DataTable
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewDentalRecords"
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                myAdapter.SelectCommand = sqlcmd
                myAdapter.Fill(DRTable)
            End With
            If DRTable.Rows.Count > 0 Then
                cmbboxDentalChart.DataSource = DRTable
                cmbboxDentalChart.ValueMember = "DentalRecordID"
                cmbboxDentalChart.DisplayMember = "DateTimeCreated"
            Else
                cmbboxDentalChart.Text = "No Data"
                cmbboxDentalChart.Enabled = False
            End If
            DatabaseDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()
        End Try

        If PatientRecordScreen.txtboxDentalRecord.BackColor = Color.LimeGreen Then

            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewDentalCharts"
                .Parameters.AddWithValue("@PatientID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@DrID", "")
            End With

            Dim arrimage() As Byte
            Dim table As New DataTable

            Try
                myAdapter.SelectCommand = sqlcmd
                myAdapter.Fill(table)

                arrimage = table.Rows(0).Item(0)
                Dim msstream As New System.IO.MemoryStream(arrimage)
                picboxDentalChart.SizeMode = PictureBoxSizeMode.StretchImage
                picboxDentalChart.Image = Image.FromStream(msstream)
                DatabaseDisconnect()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            Finally
                myAdapter.Dispose()
                DatabaseDisconnect()
            End Try

        End If

    End Sub

    Private Sub btnExitFullScreen_Click(sender As Object, e As EventArgs) Handles btnExitFullScreen.Click

        Me.Close()
        PatientRecordScreen.btnDentalRecord_Click(sender, e)

    End Sub

    Private Sub cmbboxDentalChart_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxDentalChart.SelectionChangeCommitted

        ConnectDatabase()
        With sqlcmd
            .Connection = DBConnection
            .CommandType = CommandType.StoredProcedure
            .CommandText = "viewDentalCharts"
            .Parameters.AddWithValue("@PatientID", PatientRecordScreen.MyPatientID)
            .Parameters.AddWithValue("@DrID", cmbboxDentalChart.SelectedValue.ToString)
        End With

        Dim arrimage() As Byte
        Dim table As New DataTable

        Try
            myAdapter.SelectCommand = sqlcmd
            myAdapter.Fill(table)

            arrimage = table.Rows(0).Item(0)
            Dim msstream As New System.IO.MemoryStream(arrimage)
            picboxDentalChart.SizeMode = PictureBoxSizeMode.StretchImage
            picboxDentalChart.Image = Image.FromStream(msstream)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            myAdapter.Dispose()
            DatabaseDisconnect()
        End Try

    End Sub



    Private Sub btnAddNewChart_Click(sender As Object, e As EventArgs) Handles btnAddNewChart.Click

        AddDentalChart.Show()

    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click


        If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName) Then
            System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)
        End If

        Dim PatFiles As String = desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName + "\"
        Dim xlsTemplates As String

        Dim dentalCharts As String = desktopPath + "\Dental Clinic Management System\"

        Dim StartUpPath As String = Application.StartupPath
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
        xlsWB = xlsApp.Workbooks.Open(xlsTemplates & "DentalChartRecord.xlsx")

        xlsSheet = xlsWB.Worksheets(1)

        xlsSheet.Unprotect("flair")

        TakeScreenshotPanel(pnlDentalChart).Save(dentalCharts + "DentalChart.png", System.Drawing.Imaging.ImageFormat.Png)

        Dim r As Excel.Range
        Dim s As Microsoft.Office.Interop.Excel.Shape
        Dim dentalChartPath As String = dentalCharts + "DentalChart.png"

        Dim pictureWidth As Integer = picboxDentalChart.Width
        Dim pictureHeight As Integer = picboxDentalChart.Height

        r = xlsSheet.Cells(2, 1)
        s = xlsSheet.Shapes.AddPicture(dentalChartPath, True, True, r.Left, r.Top, pictureWidth * 2 / 4 + 60, pictureHeight * 2 / 4 + 70)
        'xlsSheet.Cells(8, 1) = "data"

        My.Computer.FileSystem.DeleteFile(dentalCharts + "DentalChart.png")

        Dim myfilename As String = PatientRecordScreen.txtboxPatientName.Text & " - DentalChart - " & DateTime.Now.ToString("MM-dd-yy") & ".xlsx"
        Dim myFilenameAsPdf As String = "DentalChart - " & PatientRecordScreen.txtboxPatientName.Text & " - " & DateTime.Now.ToString("MM-dd-yy") & ".pdf"

        xlsSheet.Protect("flair")

        xlsSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape
        xlsApp.ActiveWindow.View = Excel.XlWindowView.xlPageLayoutView
        xlsApp.ActiveWindow.DisplayGridlines = False

        xlsSheet.PageSetup.LeftFooter = "Date Created: " & DateTime.Now & Chr(10) & "Generated by: " & LoginAccount.empName

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

        If File.Exists("C:\Program Files\Google\Chrome\Application\chrome.exe") Then
            Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", """" & PatFiles & myFilenameAsPdf & """")
        ElseIf File.Exists("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe") Then
            Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", """" & PatFiles & myFilenameAsPdf & """")
        Else
            Process.Start("explorer.exe", desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)
        End If


        'OPENING IN EXCEL
        'If File.Exists("C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE") Then

        '    Process.Start("C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE", """" & xlsFiles & myfilename & """")

        'ElseIf File.Exists("C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE") Then

        '    Process.Start("C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE", """" & xlsFiles & myfilename & """")

        'Else

        '    MessageBox.Show("Excel is not installed in this device", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        'End If


    End Sub
End Class