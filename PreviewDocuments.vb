Imports System.ComponentModel
Imports System.IO

Public Class PreviewDocuments
    Private Sub btnAddDocument_Click(sender As Object, e As EventArgs) Handles btnAddDocument.Click
        If txtboxDocumentName.Text = "" Then
            MessageBox.Show("Document Naming is required", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtboxDocumentName.Select()
            Exit Sub
        End If

        Dim arrImage() As Byte
        Dim msstream As New System.IO.MemoryStream()
        picboxPreview.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()

        Try

            ConnectDatabase()

            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Documents"
                .Parameters.AddWithValue("@Qtype", "Add")
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@DocuName", txtboxDocumentName.Text)
                .Parameters.AddWithValue("@DocuImage", arrImage)

                .ExecuteNonQuery()


                If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName) Then
                    System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)
                End If

                Dim PatFiles As String = desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName + "\"

                System.IO.Path.GetFileName(Document.imgpath)

                System.IO.File.Copy(Document.imgpath, PatFiles + "\" + txtboxDocumentName.Text + System.IO.Path.GetExtension(Document.imgpath))

                'Dim newfilename As String = txtboxDocumentName.Text + System.IO.Path.GetExtension(Document.imgpath)

                'If newfilename = PatFiles + "\" + System.IO.Path.GetFileName(Document.imgpath) Then
                '    My.Computer.FileSystem.RenameFile(PatFiles + "\" + System.IO.Path.GetFileName(Document.imgpath), txtboxDocumentName.Text + System.IO.Path.GetExtension(Document.imgpath))
                'End If

                'MessageBox.Show("Document Added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            End With

            DatabaseDisconnect()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Close()
            DatabaseDisconnect()
        End Try

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

    End Sub

    Private Sub PreviewDocuments_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        HomeScreen.Enabled = True

    End Sub


End Class