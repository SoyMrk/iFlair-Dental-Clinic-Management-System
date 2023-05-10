Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports Mysqlx.XDevAPI.Relational
Imports System.Drawing.Printing
Imports System.IO

Public Class Document

    Public Shared imgpath As String
    Dim imgDocuments(6) As Image
    Dim DocumentNames(6) As String
    Dim count = 0

    Private Sub Document_Load(sender As Object, e As EventArgs) Handles Me.Load



        Try
            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Documents"
                .Parameters.AddWithValue("@Qtype", "Check")
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@DocuName", DBNull.Value)
                .Parameters.AddWithValue("@DocuImage", DBNull.Value)

                myreader = .ExecuteReader

                While myreader.Read
                    Dim arrImage() As Byte
                    arrImage = myreader("DocumentImage")
                    Dim msstream As New System.IO.MemoryStream(arrImage)
                    imgDocuments(count) = Image.FromStream(msstream)
                    DocumentNames(count) = myreader("DocumentName")
                    count += 1
                End While
            End With

            DatabaseDisconnect()
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try


        If count > 0 Then
            picboxPhoto1.Visible = True
            lblPhotoName1.Visible = True
            btnDelete1.Visible = True
            lblPhotoName1.Text = DocumentNames(0)
            picboxPhoto1.SizeMode = PictureBoxSizeMode.StretchImage
            picboxPhoto1.Image = imgDocuments(0)
            btnPrint.Visible = True
        End If
        If count > 1 Then
            picboxPhoto2.Visible = True
            lblPhotoName2.Visible = True
            btnDelete2.Visible = True
            lblPhotoName2.Text = DocumentNames(1)
            picboxPhoto2.SizeMode = PictureBoxSizeMode.StretchImage
            picboxPhoto2.Image = imgDocuments(1)
            btnPrint2.Visible = True
        End If
        If count > 2 Then
            picboxPhoto3.Visible = True
            lblPhotoName3.Visible = True
            btnDelete3.Visible = True
            lblPhotoName3.Text = DocumentNames(2)
            picboxPhoto3.SizeMode = PictureBoxSizeMode.StretchImage
            picboxPhoto3.Image = imgDocuments(2)
            btnPrint3.Visible = True
        End If
        If count > 3 Then
            picboxPhoto4.Visible = True
            lblPhotoName4.Visible = True
            btnDelete4.Visible = True
            lblPhotoName4.Text = DocumentNames(3)
            picboxPhoto4.SizeMode = PictureBoxSizeMode.StretchImage
            picboxPhoto4.Image = imgDocuments(3)
            btnPrint4.Visible = True
        End If

        If count > 4 Then
            picboxPhoto5.Visible = True
            lblPhotoName5.Visible = True
            btnDelete5.Visible = True
            lblPhotoName5.Text = DocumentNames(4)
            picboxPhoto5.SizeMode = PictureBoxSizeMode.StretchImage
            picboxPhoto5.Image = imgDocuments(4)
        End If

        If PatientRecordScreen.txtboxXray.BackColor = Color.LimeGreen Then

            Try
                ConnectDatabase()
                Dim arrimage() As Byte
                Dim xRayList As New DataTable
                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Xray"
                    .Parameters.AddWithValue("@Qtype", "View")
                    .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                    .Parameters.AddWithValue("@Xray_Name", "")
                    .Parameters.AddWithValue("@XRay_Image", DBNull.Value)
                End With
                myAdapter.SelectCommand = sqlcmd
                myAdapter.Fill(xRayList)

                cmbboxXrayList.DataSource = xRayList
                cmbboxXrayList.ValueMember = "XrayID"
                cmbboxXrayList.DisplayMember = "XrayName"

                arrimage = xRayList.Rows(0).Item(3)
                Dim msstream As New System.IO.MemoryStream(arrimage)
                picboxXray.SizeMode = PictureBoxSizeMode.StretchImage
                picboxXray.Image = Image.FromStream(msstream)

                DatabaseDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try

        End If

        If PatientRecordScreen.txtboxXray.BackColor = Color.Red Then
            btnDeleteXray.Visible = False
            btnPrintXray.Visible = False
        End If

        If picboxPhoto1.Visible = False And PatientRecordScreen.txtboxXray.BackColor = Color.Red Then

            ClearPatientPanel()

            With ButtonUploadDocu
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill And DockStyle.Bottom
                .AutoSize = True
                .TopLevel = False
                PatientRecordScreen.PatientProfilePanel.Controls.Add(ButtonUploadDocu)
                .BringToFront()
                .Show()
            End With

            Exit Sub
        End If

    End Sub

    Private Sub btnUploadDoc_Click(sender As Object, e As EventArgs) Handles btnUploadDoc.Click

        HomeScreen.Enabled = False


        Try
            Dim ofd As FileDialog = New OpenFileDialog

            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"

            If ofd.ShowDialog() = DialogResult.OK Then

                imgpath = ofd.FileName

                PreviewDocuments.picboxPreview.SizeMode = PictureBoxSizeMode.StretchImage

                PreviewDocuments.picboxPreview.ImageLocation = imgpath

                PreviewDocuments.Show()
            End If

            ofd = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

        HomeScreen.Enabled = True



    End Sub

    Private Sub btnDelete1_Click(sender As Object, e As EventArgs) Handles btnDelete1.Click

        If MessageBox.Show(" Are you sure you want to delete " & DocumentNames(0) & "?", "Are you sure?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'MsgBox("Yes")

            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Documents"
                    .Parameters.AddWithValue("@Qtype", "Delete")
                    .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                    .Parameters.AddWithValue("@DocuName", DocumentNames(0))
                    .Parameters.AddWithValue("@DocuImage", DBNull.Value)

                    .ExecuteNonQuery()

                    If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName) Then
                        System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)
                    End If


                    Dim PatFiles As String = desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName + "\"

                    Dim thePath As String = PatFiles
                    Dim theFolder As String() = Directory.GetFiles(thePath)
                    Dim theSearch As String = DocumentNames(0) ' or else

                    For Each theFile As String In theFolder
                        If theFile.IndexOf(theSearch) > 0 Then
                            File.Delete(theFile)
                        End If
                    Next

                    'MessageBox.Show("Document Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'My.Computer.FileSystem.DeleteFile(PatFiles & myfilename)

                End With

                ClearHomeMainPanel()

                With PatientRecordScreen
                    .WindowState = FormWindowState.Maximized
                    .Dock = DockStyle.Fill And DockStyle.Bottom
                    .AutoSize = True
                    .TopLevel = False
                    HomeScreen.pnlHomeScreen.Controls.Add(PatientRecordScreen)
                    .BringToFront()
                    .Show()
                End With

                DatabaseDisconnect()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DatabaseDisconnect()
            End Try

        Else
            'MsgBox("No")
        End If



    End Sub

    Private Sub btnDelete2_Click(sender As Object, e As EventArgs) Handles btnDelete2.Click

        If MessageBox.Show(" Are you sure you want to delete " & DocumentNames(1) & "?", "Are you sure?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'MsgBox("Yes")

            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Documents"
                    .Parameters.AddWithValue("@Qtype", "Delete")
                    .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                    .Parameters.AddWithValue("@DocuName", DocumentNames(1))
                    .Parameters.AddWithValue("@DocuImage", DBNull.Value)

                    .ExecuteNonQuery()

                    If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName) Then
                        System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)
                    End If

                    Dim PatFiles As String = desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName + "\"

                    Dim thePath As String = PatFiles
                    Dim theFolder As String() = Directory.GetFiles(thePath)
                    Dim theSearch As String = DocumentNames(1) ' or else

                    For Each theFile As String In theFolder
                        If theFile.IndexOf(theSearch) > 0 Then
                            File.Delete(theFile)
                        End If
                    Next

                    'MessageBox.Show("Document Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End With

                ClearHomeMainPanel()

                With PatientRecordScreen
                    .WindowState = FormWindowState.Maximized
                    .Dock = DockStyle.Fill And DockStyle.Bottom
                    .AutoSize = True
                    .TopLevel = False
                    HomeScreen.pnlHomeScreen.Controls.Add(PatientRecordScreen)
                    .BringToFront()
                    .Show()
                End With

                DatabaseDisconnect()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DatabaseDisconnect()
            End Try

        Else
            'MsgBox("No")
        End If

    End Sub

    Private Sub btnDelete3_Click(sender As Object, e As EventArgs) Handles btnDelete3.Click

        If MessageBox.Show(" Are you sure you want to delete " & DocumentNames(2) & "?", "Are you sure?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'MsgBox("Yes")

            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Documents"
                    .Parameters.AddWithValue("@Qtype", "Delete")
                    .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                    .Parameters.AddWithValue("@DocuName", DocumentNames(2))
                    .Parameters.AddWithValue("@DocuImage", DBNull.Value)

                    .ExecuteNonQuery()

                    If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName) Then
                        System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)
                    End If

                    Dim PatFiles As String = desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName + "\"

                    Dim thePath As String = PatFiles
                    Dim theFolder As String() = Directory.GetFiles(thePath)
                    Dim theSearch As String = DocumentNames(2) ' or else

                    For Each theFile As String In theFolder
                        If theFile.IndexOf(theSearch) > 0 Then
                            File.Delete(theFile)
                        End If
                    Next

                    'MessageBox.Show("Document Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With

                ClearHomeMainPanel()

                With PatientRecordScreen
                    .WindowState = FormWindowState.Maximized
                    .Dock = DockStyle.Fill And DockStyle.Bottom
                    .AutoSize = True
                    .TopLevel = False
                    HomeScreen.pnlHomeScreen.Controls.Add(PatientRecordScreen)
                    .BringToFront()
                    .Show()
                End With

                DatabaseDisconnect()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DatabaseDisconnect()
            End Try

        Else
            'MsgBox("No")
        End If

    End Sub

    Private Sub btnDelete4_Click(sender As Object, e As EventArgs) Handles btnDelete4.Click

        If MessageBox.Show(" Are you sure you want to delete " & DocumentNames(3) & "?", "Are you sure?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'MsgBox("Yes")

            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Documents"
                    .Parameters.AddWithValue("@Qtype", "Delete")
                    .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                    .Parameters.AddWithValue("@DocuName", DocumentNames(3))
                    .Parameters.AddWithValue("@DocuImage", DBNull.Value)

                    .ExecuteNonQuery()

                    If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName) Then
                        System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)
                    End If

                    Dim PatFiles As String = desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName + "\"

                    Dim thePath As String = PatFiles
                    Dim theFolder As String() = Directory.GetFiles(thePath)
                    Dim theSearch As String = DocumentNames(3) ' or else

                    For Each theFile As String In theFolder
                        If theFile.IndexOf(theSearch) > 0 Then
                            File.Delete(theFile)
                        End If
                    Next

                    'MessageBox.Show("Document Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End With

                ClearHomeMainPanel()

                With PatientRecordScreen
                    .WindowState = FormWindowState.Maximized
                    .Dock = DockStyle.Fill And DockStyle.Bottom
                    .AutoSize = True
                    .TopLevel = False
                    HomeScreen.pnlHomeScreen.Controls.Add(PatientRecordScreen)
                    .BringToFront()
                    .Show()
                End With

                DatabaseDisconnect()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DatabaseDisconnect()
            End Try

        Else
            'MsgBox("No")
        End If

    End Sub

    Private Sub btnDelete5_Click(sender As Object, e As EventArgs) Handles btnDelete5.Click

        If MessageBox.Show(" Are you sure you want to delete " & DocumentNames(4) & "?", "Are you sure?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'MsgBox("Yes")

            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Documents"
                    .Parameters.AddWithValue("@Qtype", "Delete")
                    .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                    .Parameters.AddWithValue("@DocuName", DocumentNames(4))
                    .Parameters.AddWithValue("@DocuImage", DBNull.Value)

                    .ExecuteNonQuery()

                    If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName) Then
                        System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)
                    End If

                    Dim PatFiles As String = desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName + "\"

                    Dim thePath As String = PatFiles
                    Dim theFolder As String() = Directory.GetFiles(thePath)
                    Dim theSearch As String = DocumentNames(4) ' or else

                    For Each theFile As String In theFolder
                        If theFile.IndexOf(theSearch) > 0 Then
                            File.Delete(theFile)
                        End If
                    Next

                    'MessageBox.Show("Document Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End With

                ClearHomeMainPanel()

                With PatientRecordScreen
                    .WindowState = FormWindowState.Maximized
                    .Dock = DockStyle.Fill And DockStyle.Bottom
                    .AutoSize = True
                    .TopLevel = False
                    HomeScreen.pnlHomeScreen.Controls.Add(PatientRecordScreen)
                    .BringToFront()
                    .Show()
                End With

                DatabaseDisconnect()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DatabaseDisconnect()
            End Try

        Else
            'MsgBox("No")
        End If

    End Sub

    Private Sub btnAddXray_Click(sender As Object, e As EventArgs) Handles btnAddXray.Click

        HomeScreen.Enabled = False


        Try
            Dim ofd As FileDialog = New OpenFileDialog

            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"

            If ofd.ShowDialog() = DialogResult.OK Then

                imgpath = ofd.FileName
                PreviewXray.picBoxPreviewXray.SizeMode = PictureBoxSizeMode.StretchImage

                PreviewXray.picBoxPreviewXray.ImageLocation = imgpath

                PreviewXray.Show()
            End If

            ofd = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

        HomeScreen.Enabled = True

    End Sub

    Private Sub cmbboxXrayList_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxXrayList.SelectionChangeCommitted
        Try
            ConnectDatabase()
            Dim arrimage() As Byte
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "XRay"
                .Parameters.AddWithValue("@Qtype", "Get")
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@Xray_Name", cmbboxXrayList.Text)
                .Parameters.AddWithValue("@XRay_Image", DBNull.Value)
            End With
            myreader = sqlcmd.ExecuteReader

            If myreader.Read Then
                arrimage = myreader("XRayImage")
                Dim msstream As New System.IO.MemoryStream(arrimage)
                picboxXray.SizeMode = PictureBoxSizeMode.StretchImage
                picboxXray.Image = Image.FromStream(msstream)
            End If

            DatabaseDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()
        End Try
    End Sub

    Private Sub btnDeleteXray_Click(sender As Object, e As EventArgs) Handles btnDeleteXray.Click
        If MessageBox.Show(" Are you sure you want to delete " & cmbboxXrayList.Text & " X-ray?", "Are you sure?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'MsgBox("Yes")

            Try
                ConnectDatabase()

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "XRay"
                    .Parameters.AddWithValue("@Qtype", "Delete")
                    .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                    .Parameters.AddWithValue("@Xray_Name", cmbboxXrayList.Text)
                    .Parameters.AddWithValue("@XRay_Image", DBNull.Value)

                    .ExecuteNonQuery()

                    If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName) Then
                        System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)
                    End If

                    Dim PatFiles As String = desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName + "\"

                    Dim thePath As String = PatFiles
                    Dim theFolder As String() = Directory.GetFiles(thePath)
                    Dim theSearch As String = cmbboxXrayList.Text ' or else

                    For Each theFile As String In theFolder
                        If theFile.IndexOf(theSearch) > 0 Then
                            File.Delete(theFile)
                        End If
                    Next

                    'MessageBox.Show("Xray Photo Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End With

                ClearHomeMainPanel()

                With PatientRecordScreen
                    .WindowState = FormWindowState.Maximized
                    .Dock = DockStyle.Fill And DockStyle.Bottom
                    .AutoSize = True
                    .TopLevel = False
                    HomeScreen.pnlHomeScreen.Controls.Add(PatientRecordScreen)
                    .BringToFront()
                    .Show()
                End With

                DatabaseDisconnect()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DatabaseDisconnect()
            End Try

        Else
            'MsgBox("No")
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDoc.PrinterSettings = PrintDialog1.PrinterSettings

            'Dim PageSetup As New PageSettings
            'With PageSetup
            '    .Margins.Left = 50
            '    .Margins.Right = 50
            '    .Margins.Top = 50
            '    .Margins.Bottom = 50
            '    .Landscape = False
            'End With
            'PrintDoc.DefaultPageSettings = PageSetup
        End If

        PrintPreviewDialog1.Document = PrintDoc
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen

        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub btnPrint2_Click(sender As Object, e As EventArgs) Handles btnPrint2.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            PrintDoc.PrinterSettings = PrintDialog1.PrinterSettings

        End If


        PrintPreviewDialog1.Document = PrintDoc2
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnPrint3_Click(sender As Object, e As EventArgs) Handles btnPrint3.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            PrintDoc.PrinterSettings = PrintDialog1.PrinterSettings

        End If

        PrintPreviewDialog1.Document = PrintDoc3
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnPrint4_Click(sender As Object, e As EventArgs) Handles btnPrint4.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            PrintDoc.PrinterSettings = PrintDialog1.PrinterSettings

        End If

        PrintPreviewDialog1.Document = PrintDoc4
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnPrint5_Click(sender As Object, e As EventArgs) Handles btnPrint5.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            PrintDoc.PrinterSettings = PrintDialog1.PrinterSettings

        End If

        PrintPreviewDialog1.Document = PrintDoc5
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnPrintXray_Click(sender As Object, e As EventArgs) Handles btnPrintXray.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            PrintDoc.PrinterSettings = PrintDialog1.PrinterSettings

        End If

        PrintXray.DefaultPageSettings.Landscape = True

        PrintPreviewDialog1.Document = PrintXray
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        e.Graphics.DrawImage(picboxPhoto1.Image, 25, 25, e.PageBounds.Width - 50, e.PageBounds.Height - 50)
    End Sub

    Private Sub PrintDoc2_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc2.PrintPage
        e.Graphics.DrawImage(picboxPhoto2.Image, 25, 25, e.PageBounds.Width - 50, e.PageBounds.Height - 50)
    End Sub

    Private Sub PrintDoc3_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc3.PrintPage
        e.Graphics.DrawImage(picboxPhoto3.Image, 25, 25, e.PageBounds.Width - 50, e.PageBounds.Height - 50)
    End Sub

    Private Sub PrintDoc4_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc4.PrintPage
        e.Graphics.DrawImage(picboxPhoto4.Image, 25, 25, e.PageBounds.Width - 50, e.PageBounds.Height - 50)
    End Sub

    Private Sub PrintDoc5_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc5.PrintPage
        e.Graphics.DrawImage(picboxPhoto5.Image, 25, 25, e.PageBounds.Width - 50, e.PageBounds.Height - 50)
    End Sub

    Private Sub PrintXray_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintXray.PrintPage
        e.Graphics.DrawImage(picboxXray.Image, 25, 25, e.PageBounds.Width - 50, e.PageBounds.Height - 50)
    End Sub







    Private Sub picboxPhoto1_Click(sender As Object, e As EventArgs) Handles picboxPhoto1.Click
        DocumentFullScreen.Show()
        DocumentFullScreen.picboxDocument.Image = picboxPhoto1.Image
    End Sub

    'Private Sub picboxPhoto1_MouseEnter(sender As Object, e As EventArgs) Handles picboxPhoto1.MouseEnter
    '    DocumentFullScreen.Show()
    '    DocumentFullScreen.picboxDocument.Image = picboxPhoto1.Image
    'End Sub
    Private Sub picboxPhoto2_Click(sender As Object, e As EventArgs) Handles picboxPhoto2.Click
        DocumentFullScreen.Show()
        DocumentFullScreen.picboxDocument.Image = picboxPhoto2.Image
    End Sub

    'Private Sub picboxPhoto2_MouseEnter(sender As Object, e As EventArgs) Handles picboxPhoto2.MouseEnter
    '    DocumentFullScreen.Show()
    '    DocumentFullScreen.picboxDocument.Image = picboxPhoto2.Image
    'End Sub
    Private Sub picboxPhoto3_Click(sender As Object, e As EventArgs) Handles picboxPhoto3.Click
        DocumentFullScreen.Show()
        DocumentFullScreen.picboxDocument.Image = picboxPhoto3.Image
    End Sub

    'Private Sub picboxPhoto3_MouseEnter(sender As Object, e As EventArgs) Handles picboxPhoto3.MouseEnter
    '    DocumentFullScreen.Show()
    '    DocumentFullScreen.picboxDocument.Image = picboxPhoto3.Image
    'End Sub
    Private Sub picboxPhoto4_Click(sender As Object, e As EventArgs) Handles picboxPhoto4.Click
        DocumentFullScreen.Show()
        DocumentFullScreen.picboxDocument.Image = picboxPhoto4.Image
    End Sub

    'Private Sub picboxPhoto4_MouseEnter(sender As Object, e As EventArgs) Handles picboxPhoto4.MouseEnter
    '    DocumentFullScreen.Show()
    '    DocumentFullScreen.picboxDocument.Image = picboxPhoto4.Image
    'End Sub
    Private Sub picboxPhoto5_Click(sender As Object, e As EventArgs) Handles picboxPhoto5.Click
        DocumentFullScreen.Show()
        DocumentFullScreen.picboxDocument.Image = picboxPhoto5.Image
    End Sub

    'Private Sub picboxPhoto5_MouseEnter(sender As Object, e As EventArgs) Handles picboxPhoto5.MouseEnter
    '    DocumentFullScreen.Show()
    '    DocumentFullScreen.picboxDocument.Image = picboxPhoto5.Image
    'End Sub

    Private Sub btnViewFiles_Click(sender As Object, e As EventArgs) Handles btnViewFiles.Click

        If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName) Then
            System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)
        End If

        Process.Start("explorer.exe", desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)

    End Sub

End Class