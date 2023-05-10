Public Class ButtonUploadDocu

    Private Sub btnUploadDocument_Click(sender As Object, e As EventArgs) Handles btnUploadDocument.Click

        HomeScreen.Enabled = False

        Try
            Dim ofd As FileDialog = New OpenFileDialog

            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"

            If ofd.ShowDialog() = DialogResult.OK Then

                Document.imgpath = ofd.FileName
                PreviewDocuments.picboxPreview.SizeMode = PictureBoxSizeMode.StretchImage

                PreviewDocuments.picboxPreview.ImageLocation = Document.imgpath

                PreviewDocuments.Show()
            End If

            ofd = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

        HomeScreen.Enabled = True

    End Sub

    Private Sub btnViewFiles_Click(sender As Object, e As EventArgs) Handles btnViewFiles.Click
        If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName) Then

            System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)
        End If

        Process.Start("explorer.exe", desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)

    End Sub

    Private Sub btnUploadXray_Click(sender As Object, e As EventArgs) Handles btnUploadXray.Click

        HomeScreen.Enabled = False


        Try
            Dim ofd As FileDialog = New OpenFileDialog

            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"

            If ofd.ShowDialog() = DialogResult.OK Then

                Document.imgpath = ofd.FileName
                PreviewXray.picBoxPreviewXray.SizeMode = PictureBoxSizeMode.StretchImage

                PreviewXray.picBoxPreviewXray.ImageLocation = Document.imgpath

                PreviewXray.Show()
            End If

            ofd = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

        HomeScreen.Enabled = True

    End Sub
End Class