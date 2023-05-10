Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class PatientRecordScreen

    Public Shared MyPatientID As String
    Public Shared PatientName As String
    Public Shared PatientAge As String
    Public Shared PatientSex As String
    Public Shared PatientAddress As String

    Private Sub btnPatientProfle_Click(sender As Object, e As EventArgs) Handles btnPatientProfle.Click

        ClearPatientPanel()

        pnlClicked.Width = btnPatientProfle.Width
        pnlClicked.Left = btnPatientProfle.Left

        With PatientProfile
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            PatientProfilePanel.Controls.Add(PatientProfile)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnMedicalHistory_Click(sender As Object, e As EventArgs) Handles btnMedicalHistory.Click

        pnlClicked.Width = btnMedicalHistory.Width
        pnlClicked.Left = btnMedicalHistory.Left

        'MsgBox(MyPatientID)
        If txtboxMedHistory.BackColor = Color.Red Then

            'MsgBox("Has Data")
            ClearPatientPanel()

            With ButtonAddMedicalHistory
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill And DockStyle.Bottom
                .AutoSize = True
                .TopLevel = False
                PatientProfilePanel.Controls.Add(ButtonAddMedicalHistory)
                .BringToFront()
                .Show()
            End With

        Else

            'MsgBox("No Data")
            ClearPatientPanel()

            With MedicalInformation
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill And DockStyle.Bottom
                .AutoSize = True
                .TopLevel = False
                PatientProfilePanel.Controls.Add(MedicalInformation)
                .BringToFront()
                .Show()
            End With

        End If



    End Sub

    Public Sub btnDentalRecord_Click(sender As Object, e As EventArgs) Handles btnDentalRecord.Click

        pnlClicked.Width = btnDentalRecord.Width
        pnlClicked.Left = btnDentalRecord.Left

        'DentalChart.Show()

        If txtboxDentalRecord.BackColor = Color.Red Then

            ClearPatientPanel()

            With ButtonAddDentalChart
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill And DockStyle.Bottom
                .AutoSize = True
                .TopLevel = False
                PatientProfilePanel.Controls.Add(ButtonAddDentalChart)
                .BringToFront()
                .Show()
            End With

        Else

            ClearPatientPanel()

            With DentalChart
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill And DockStyle.Bottom
                .AutoSize = True
                .TopLevel = False
                PatientProfilePanel.Controls.Add(DentalChart)
                .BringToFront()
                .Show()
            End With

        End If



    End Sub

    Private Sub btnTreatment_Click(sender As Object, e As EventArgs) Handles btnTreatment.Click
        ''CODE DELETED/COMMENTED 

        'pnlClicked.Width = btnTreatment.Width
        'pnlClicked.Left = btnTreatment.Left

        ''ClearPatientPanel()

        ''With TreatmentForm
        ''    .WindowState = FormWindowState.Maximized
        ''    .Dock = DockStyle.Fill And DockStyle.Bottom
        ''    .AutoSize = True
        ''    .TopLevel = False
        ''    PatientProfilePanel.Controls.Add(TreatmentForm)
        ''    .BringToFront()
        ''    .Show()
        ''End With

        'Try
        '    ConnectDatabase()
        '    With sqlcmd
        '        .Connection = DBConnection
        '        .CommandType = CommandType.StoredProcedure
        '        .CommandText = "viewPatProdHist"
        '        .Parameters.AddWithValue("@AppDateFilter", "All")
        '        .Parameters.AddWithValue("@PatientID", PatientRecordScreen.MyPatientID)
        '        .Parameters.AddWithValue("@SearchTxt", "")
        '        'MsgBox("Successful", MsgBoxStyle.Information, "Information")

        '        myreader = sqlcmd.ExecuteReader

        '        If myreader.HasRows Then

        '            ClearPatientPanel()

        '            With TreatmentForm
        '                .WindowState = FormWindowState.Maximized
        '                .Dock = DockStyle.Fill And DockStyle.Bottom
        '                .AutoSize = True
        '                .TopLevel = False
        '                PatientProfilePanel.Controls.Add(TreatmentForm)
        '                .BringToFront()
        '                .Show()
        '            End With

        '        Else

        '            ClearPatientPanel()

        '            With ButtonProcedure
        '                .WindowState = FormWindowState.Maximized
        '                .Dock = DockStyle.Fill And DockStyle.Bottom
        '                .AutoSize = True
        '                .TopLevel = False
        '                PatientProfilePanel.Controls.Add(ButtonProcedure)
        '                .BringToFront()
        '                .Show()
        '            End With

        '        End If

        '    End With
        '    DatabaseDisconnect()

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical)
        '    DatabaseDisconnect()
        'End Try


    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click

        pnlClicked.Width = btnBilling.Width
        pnlClicked.Left = btnBilling.Left

        Try

            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewPatBills"
                .Parameters.AddWithValue("@BillStatus", "Incomplete")
                .Parameters.AddWithValue("@AppDateFilter", "")
                .Parameters.AddWithValue("@txtSearch", "")
                .Parameters.AddWithValue("@PatientID", PatientRecordScreen.MyPatientID)

                myreader = sqlcmd.ExecuteReader

                If myreader.HasRows Then

                    ClearPatientPanel()

                    With Billing
                        .WindowState = FormWindowState.Maximized
                        .Dock = DockStyle.Fill And DockStyle.Bottom
                        .AutoSize = True
                        .TopLevel = False
                        PatientProfilePanel.Controls.Add(Billing)
                        .BringToFront()
                        .Show()
                    End With

                Else

                    ClearPatientPanel()

                    With ButtonTransaction
                        .WindowState = FormWindowState.Maximized
                        .Dock = DockStyle.Fill And DockStyle.Bottom
                        .AutoSize = True
                        .TopLevel = False
                        PatientProfilePanel.Controls.Add(ButtonTransaction)
                        .BringToFront()
                        .Show()
                    End With

                End If

                DatabaseDisconnect()

            End With
        Catch ex As Exception
            DatabaseDisconnect()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try




    End Sub

    Private Sub btnAppointments_Click(sender As Object, e As EventArgs) Handles btnAppointments.Click

        pnlClicked.Width = btnAppointments.Width
        pnlClicked.Left = btnAppointments.Left

        ClearPatientPanel()

        With PatientAppointmentHistory
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            PatientProfilePanel.Controls.Add(PatientAppointmentHistory)
            .BringToFront()
            .Show()
        End With


    End Sub
    Private Sub btnDocument_Click(sender As Object, e As EventArgs) Handles btnDocument.Click


        pnlClicked.Width = btnDocument.Width
        pnlClicked.Left = btnDocument.Left

        Try
            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Documents"
                .Parameters.AddWithValue("@Qtype", "Check")
                .Parameters.AddWithValue("@PatId", MyPatientID)
                .Parameters.AddWithValue("@DocuName", DBNull.Value)
                .Parameters.AddWithValue("@DocuImage", DBNull.Value)

                myreader = .ExecuteReader

                If myreader.Read Or txtboxXray.BackColor = Color.LimeGreen Then

                    ClearPatientPanel()

                    With Document
                        .WindowState = FormWindowState.Maximized
                        .Dock = DockStyle.Fill And DockStyle.Bottom
                        .AutoSize = True
                        .TopLevel = False
                        PatientProfilePanel.Controls.Add(Document)
                        .BringToFront()
                        .Show()
                    End With

                Else

                    ClearPatientPanel()

                    With ButtonUploadDocu
                        .WindowState = FormWindowState.Maximized
                        .Dock = DockStyle.Fill And DockStyle.Bottom
                        .AutoSize = True
                        .TopLevel = False
                        PatientProfilePanel.Controls.Add(ButtonUploadDocu)
                        .BringToFront()
                        .Show()
                    End With

                End If

            End With
            DatabaseDisconnect()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try




    End Sub


    Private Sub PatientRecordScreen_Load(sender As Object, e As EventArgs) Handles Me.Load


        'PATIENT DETAILS LOAD

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getPatient"
                .Parameters.AddWithValue("@PatID", MyPatientID)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()
                    txtboxPatientName.Text = myreader("LastName").ToString & ", " & myreader("FirstName").ToString
                    txtboxContactNo.Text = myreader("PatContactNo").ToString

                    Dim dateofBirth As DateTime = myreader("DateofBirth")
                    txtboxDateofBirth.Text = myreader.GetDateTime("DateofBirth").ToString("MM/dd/yyyy")

                    txtboxMuniProv.Text = myreader("Municipality") + ", " + myreader("Province")

                    PatientName = myreader("FirstName") + " " + myreader("LastName")
                    PatientAge = myreader("Age")
                    PatientSex = myreader("Gender")
                    PatientAddress = myreader("Street") + ", " + myreader("Barangay") + ", " + myreader("Municipality") + ", " + myreader("Province")

                    If Not IsDBNull(myreader("PatientPhoto")) Then

                        Dim arrimage() As Byte
                        arrimage = myreader("PatientPhoto")

                        Dim msstream As New System.IO.MemoryStream(arrimage)
                        picboxPatient.SizeMode = PictureBoxSizeMode.StretchImage
                        picboxPatient.Image = Image.FromStream(msstream)

                        btnUploadPhoto.Visible = False

                    End If


                End While
                DatabaseDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try
        End With



        'FINANCE INDICATOR
        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getPatBalance"
                .Parameters.AddWithValue("@PatID", MyPatientID)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() Then

                    If myreader("Balance").ToString > "0" Then
                        txtboxBalance.Text = myreader("Balance")
                    Else
                        txtboxBalance.Text = "0.00"
                    End If

                End If

                DatabaseDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try
        End With



        'LAST AND NEXT APPOINTMENT INDICATOR
        Try
            ConnectDatabase()

            Dim newSqlCmd As New MySqlCommand
            Dim newDA As New MySqlDataAdapter

            Dim appTable As New DataTable

            With newSqlCmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getPatLNAppointment"
                .Parameters.AddWithValue("@PatID", MyPatientID)
            End With

            newDA.SelectCommand = newSqlCmd
            newDA.Fill(appTable)

            If appTable.Rows.Count = 1 Then

                If appTable.Rows.Item(0).Item("AppStatus") = "Completed" Or appTable.Rows.Item(0).Item("AppStatus") = "Cancelled" Then

                    Dim AppDateInRow1 As DateTime = appTable.Rows.Item(0).Item("AppDate")
                    txtboxLastApp.Text = AppDateInRow1.ToString("MMMM dd, yyyy")
                    txtboxNextApp.Text = "No Schedule"

                Else

                    Dim AppDateInRow1 As DateTime = appTable.Rows.Item(0).Item("AppDate")
                    txtboxNextApp.Text = AppDateInRow1.ToString("MMMM dd, yyyy")
                    txtboxLastApp.Text = "No Schedule"

                End If



            ElseIf appTable.Rows.Count = 2 Then

                If appTable.Rows.Item(0).Item("AppStatus") = "Completed" Or appTable.Rows.Item(0).Item("AppStatus") = "Cancelled" Then

                    Dim AppDateInRow1 As DateTime = appTable.Rows.Item(0).Item("AppDate")
                    txtboxNextApp.Text = "No Schedule"
                    txtboxLastApp.Text = AppDateInRow1.ToString("MMMM dd, yyyy")

                Else

                    If Not appTable.Rows.Item(1).Item("AppNextSchedule").ToString = "" Then

                        Dim AppDateRow1 As DateTime = appTable.Rows.Item(0).Item("AppDate")
                        Dim NextAppDateRow2 As DateTime = appTable.Rows.Item(1).Item("AppNextSchedule")
                        Dim LastAppDateInRow2 As DateTime = appTable.Rows.Item(1).Item("AppDate")

                        'MsgBox(AppDateRow1.ToString("MMMM dd, yyyy"))
                        'MsgBox(NextAppDateRow2.ToString("MMMM dd, yyyy"))

                        If NextAppDateRow2.ToString("MMMM dd, yyyy") = AppDateRow1.ToString("MMMM dd, yyyy") Then
                            txtboxNextApp.Text = NextAppDateRow2.ToString("MMMM dd, yyyy")
                            txtboxLastApp.Text = LastAppDateInRow2.ToString("MMMM dd, yyyy")
                            'MsgBox("Date Matched")
                        End If

                    Else

                        Dim NextAppDateInRow1 As DateTime = appTable.Rows.Item(0).Item("AppDate")
                        Dim LastAppDateInRow2 As DateTime = appTable.Rows.Item(1).Item("AppDate")
                        txtboxNextApp.Text = NextAppDateInRow1.ToString("MMMM dd, yyyy")
                        txtboxLastApp.Text = LastAppDateInRow2.ToString("MMMM dd, yyyy")

                    End If

                End If

            Else

                txtboxLastApp.Text = "No Schedule"
                txtboxNextApp.Text = "No Schedule"

            End If

            DatabaseDisconnect()


        Catch ex As Exception

            DatabaseDisconnect()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try



        'MEDICAL HISTORY INDICATOR
        'sqlstr = "SELECT * FROM medical_history WHERE PatientID = '" & MyPatientID & "'"

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getMedicalInfo"
                .Parameters.AddWithValue("@PatID", MyPatientID)

                myreader = sqlcmd.ExecuteReader

                If myreader.Read Then

                    'MsgBox("Has Data")
                    txtboxMedHistory.BackColor = Color.LimeGreen
                    ToolTip1.SetToolTip(txtboxMedHistory, "Present medical history")

                Else

                    'MsgBox("No Data")
                    txtboxMedHistory.BackColor = Color.Red
                    ToolTip1.SetToolTip(txtboxMedHistory, "Missing medical history")

                End If

                DatabaseDisconnect()


            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With



        'DENTAL RECORD INDICATOR

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewDentalRecords"
                .Parameters.AddWithValue("@PatID", MyPatientID)

                myreader = sqlcmd.ExecuteReader

                If myreader.Read Then

                    'MsgBox("Has Data")
                    txtboxDentalRecord.BackColor = Color.LimeGreen
                    ToolTip1.SetToolTip(txtboxDentalRecord, "Present dental record")

                Else

                    'MsgBox("No Data")
                    txtboxDentalRecord.BackColor = Color.Red
                    ToolTip1.SetToolTip(txtboxDentalRecord, "Missing dental record")

                End If

                DatabaseDisconnect()


            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With

        'CONSENT INDICATOR

        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "checkConsentDocument"
                .Parameters.AddWithValue("@PatID", MyPatientID)
                .Parameters.AddWithValue("@DocuChechString", "Consent")
            End With
            myreader = sqlcmd.ExecuteReader

            If myreader.Read Then
                txtboxInformedConsent.BackColor = Color.LimeGreen
                ToolTip1.SetToolTip(txtboxInformedConsent, "Present patient informed consent")
            Else
                txtboxInformedConsent.BackColor = Color.Red
                ToolTip1.SetToolTip(txtboxInformedConsent, "Missing patient informed consent")
            End If

            DatabaseDisconnect()
        Catch ex As Exception
            DatabaseDisconnect()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        'XRAY INDICATOR

        Try
            ConnectDatabase()
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
            myreader = sqlcmd.ExecuteReader

            If myreader.Read Then
                txtboxXray.BackColor = Color.LimeGreen
                ToolTip1.SetToolTip(txtboxXray, "Present patient x-ray")

            Else
                txtboxXray.BackColor = Color.Red
                ToolTip1.SetToolTip(txtboxXray, "Missing patient x-ray")

            End If

            DatabaseDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()
        End Try

        'NAVIGATION MENU CLICK

        If HomeScreen.PatientRecordScreenPanel = PatientProfile.Name Then

            btnPatientProfle_Click(sender, e)

        ElseIf HomeScreen.PatientRecordScreenPanel = EditPatientRecord.Name Then

            pnlClicked.Width = btnPatientProfle.Width
            pnlClicked.Left = btnPatientProfle.Left

            ClearPatientPanel()

            With EditPatientRecord
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill And DockStyle.Bottom
                .AutoSize = True
                .TopLevel = False
                Me.PatientProfilePanel.Controls.Add(EditPatientRecord)
                .BringToFront()
                .Show()
            End With

        ElseIf HomeScreen.PatientRecordScreenPanel = MedicalInformation.Name Or HomeScreen.PatientRecordScreenPanel = ButtonAddMedicalHistory.Name Then

            btnMedicalHistory_Click(sender, e)

        ElseIf HomeScreen.PatientRecordScreenPanel = EditMedicalHistory.Name Then

            pnlClicked.Width = btnMedicalHistory.Width
            pnlClicked.Left = btnMedicalHistory.Left

            ClearPatientPanel()

            With EditMedicalHistory
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill And DockStyle.Bottom
                .AutoSize = True
                .TopLevel = False
                Me.PatientProfilePanel.Controls.Add(EditMedicalHistory)
                .BringToFront()
                .Show()
            End With

        ElseIf HomeScreen.PatientRecordScreenPanel = DentalChart.Name Or HomeScreen.PatientRecordScreenPanel = ButtonAddDentalChart.Name Then

            btnDentalRecord_Click(sender, e)

        ElseIf HomeScreen.PatientRecordScreenPanel = TreatmentForm.Name Then

            btnTreatment_Click(sender, e)

        ElseIf HomeScreen.PatientRecordScreenPanel = Billing.Name Then

            btnBilling_Click(sender, e)

        ElseIf HomeScreen.PatientRecordScreenPanel = PatientAppointmentHistory.Name Or HomeScreen.PatientRecordScreenPanel = ButtonAddAppointment.Name Then

            btnAppointments_Click(sender, e)

        ElseIf HomeScreen.PatientRecordScreenPanel = Document.Name Or HomeScreen.PatientRecordScreenPanel = ButtonUploadDocu.Name Then

            btnDocument_Click(sender, e)

        ElseIf HomeScreen.PatientRecordScreenPanel = PrescriptionRecords.Name Or HomeScreen.PatientRecordScreenPanel = ButtonPrescription.Name Then

            btnPrescription_Click(sender, e)

        Else

            btnPatientProfle_Click(sender, e)

        End If

    End Sub

    Private Sub btnUploadPhoto_Click(sender As Object, e As EventArgs) Handles btnUploadPhoto.Click

        Dim imgpath As String

        Try
            Dim ofd As FileDialog = New OpenFileDialog

            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"

            If ofd.ShowDialog() = DialogResult.OK Then

                imgpath = ofd.FileName
                picboxPatient.SizeMode = PictureBoxSizeMode.StretchImage

                picboxPatient.ImageLocation = imgpath

                'MessageBox.Show("Photo Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            ofd = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Information")

        End Try

        Dim arrImage() As Byte
        Dim msstream As New System.IO.MemoryStream()
        picboxPatient.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()

        Try

            ConnectDatabase()

            'sqlstr = "UPDATE patient SET PatientPhoto=@patientphoto WHERE PatientID = '" & MyPatientID & "'"

            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "editPatientPhoto"
                .Parameters.AddWithValue("@PatID", MyPatientID)
                .Parameters.AddWithValue("@PatPhoto", arrImage)

                Dim x As Integer

                x = .ExecuteNonQuery()


                'If x > 0 Then
                '    MessageBox.Show("Photo Updated")
                'Else
                '    MessageBox.Show("Photo Not Updated")
                'End If

            End With

            DatabaseDisconnect()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Information")
            DatabaseDisconnect()
        End Try

        btnUploadPhoto.Visible = False

    End Sub






    Private Sub PatientRecordScreen_Leave(sender As Object, e As EventArgs) Handles Me.Leave

        For Each recordFormName As Form In PatientProfilePanel.Controls

            'MsgBox(recordFormName.Name + "leave state")

            HomeScreen.PatientRecordScreenPanel = recordFormName.Name

        Next

        'HomeScreen.PatientRecordScreenPanel = Nothing

    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click

        pnlClicked.Width = btnTransaction.Width
        pnlClicked.Left = btnTransaction.Left

        'ClearPatientPanel()

        'With PatientTransaction
        '    .WindowState = FormWindowState.Maximized
        '    .Dock = DockStyle.Fill And DockStyle.Bottom
        '    .AutoSize = True
        '    .TopLevel = False
        '    PatientProfilePanel.Controls.Add(PatientTransaction)
        '    .BringToFront()
        '    .Show()
        'End With

        Try

            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewPatBills"
                .Parameters.AddWithValue("@BillStatus", "Complete")
                .Parameters.AddWithValue("@AppDateFilter", "")
                .Parameters.AddWithValue("@txtSearch", "")
                .Parameters.AddWithValue("@PatientID", PatientRecordScreen.MyPatientID)

                myreader = sqlcmd.ExecuteReader

                If myreader.HasRows Then

                    ClearPatientPanel()

                    With PatientTransaction
                        .WindowState = FormWindowState.Maximized
                        .Dock = DockStyle.Fill And DockStyle.Bottom
                        .AutoSize = True
                        .TopLevel = False
                        PatientProfilePanel.Controls.Add(PatientTransaction)
                        .BringToFront()
                        .Show()
                    End With

                Else

                    ClearPatientPanel()

                    With ButtonTransactionHistory
                        .WindowState = FormWindowState.Maximized
                        .Dock = DockStyle.Fill And DockStyle.Bottom
                        .AutoSize = True
                        .TopLevel = False
                        PatientProfilePanel.Controls.Add(ButtonTransactionHistory)
                        .BringToFront()
                        .Show()
                    End With

                End If

                DatabaseDisconnect()

            End With
        Catch ex As Exception
            DatabaseDisconnect()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnPrescription_Click(sender As Object, e As EventArgs) Handles btnPrescription.Click

        pnlClicked.Width = btnPrescription.Width
        pnlClicked.Left = btnPrescription.Left

        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewPatPrescriptions"
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                If myreader.HasRows Then

                    ClearPatientPanel()

                    With PrescriptionRecords
                        .WindowState = FormWindowState.Maximized
                        .Dock = DockStyle.Fill And DockStyle.Bottom
                        .AutoSize = True
                        .TopLevel = False
                        PatientProfilePanel.Controls.Add(PrescriptionRecords)
                        .BringToFront()
                        .Show()
                    End With

                Else

                    ClearPatientPanel()

                    With ButtonPrescription
                        .WindowState = FormWindowState.Maximized
                        .Dock = DockStyle.Fill And DockStyle.Bottom
                        .AutoSize = True
                        .TopLevel = False
                        PatientProfilePanel.Controls.Add(ButtonPrescription)
                        .BringToFront()
                        .Show()
                    End With

                End If

            End With
            DatabaseDisconnect()
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()

        End Try



    End Sub

End Class