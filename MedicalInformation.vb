Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.Office.Interop
Imports System.IO

Public Class MedicalInformation
    Private Sub MedicalInformation_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getMedicalInfo"
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
            End With

            myreader = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection)

            If myreader.Read Then

                txtboxPhysician.Text = myreader("PhysicianName").ToString
                txtboxSpecialty.Text = myreader("Specialty").ToString
                txtboxOfficeAddress.Text = myreader("OfficeAddress").ToString
                txtboxOfficeNumber.Text = myreader("OfficeNumber").ToString
                txtboxComments.Text = myreader("Comment").ToString

                If myreader("inGoodHealth") = "Yes" Then
                    chckbox1Yes.Checked = True
                Else
                    chckbox1No.Checked = True
                End If

                If myreader("InTreatment") = "No" Then
                    chckbox2No.Checked = True
                Else
                    chckbox1Yes.Checked = True
                    txtbox2Exp.Text = myreader("InTreatment").ToString
                End If

                If myreader("HadIllnessOrSurgery") = "No" Then
                    chckbox3No.Checked = True
                Else
                    chckbox3Yes.Checked = True
                    txtbox3Exp.Text = myreader("HadIllnessOrSurgery").ToString
                End If

                If myreader("Hospitalized") = "No" Then
                    chckbox4No.Checked = True
                Else
                    chckbox4Yes.Checked = True
                    txtbox4Exp.Text = myreader("Hospitalized").ToString
                End If

                If myreader("takingMedication") = "No" Then
                    chckbox5No.Checked = True
                Else
                    chckbox5Yes.Checked = True
                    txtbox5Exp.Text = myreader("takingMedication").ToString
                End If

                If myreader("TobaccoProducts") = "Yes" Then
                    chckbox6Yes.Checked = True
                Else
                    chckbox6No.Checked = True
                End If

                If myreader("DangerousDrugs") = "Yes" Then
                    chckbox7Yes.Checked = True
                Else
                    chckbox7No.Checked = True
                End If

                If myreader("hadAllergies") = "None" Then
                    chckbox8None.Checked = True
                Else

                    If myreader("sulfaDrugs") = "Yes" Then
                        chckbox8Drugs.Checked = True
                    End If
                    If myreader("Aspirin") = "Yes" Then
                        chckbox8Aspirin.Checked = True
                    End If
                    If myreader("Latex") = "Yes" Then
                        chckbox8Latex.Checked = True
                    End If
                    If myreader("localAnesthethic") = "Yes" Then
                        chckbox8Local.Checked = True
                    End If
                    If myreader("OtherAllergies") = "Yes" Then
                        chckbox8Others.Checked = True
                    End If

                End If

                txtbox9Exp.Text = myreader("BleedingTime").ToString

                If PatientRecordScreen.PatientSex <> "Male" Then

                    If myreader("Pregnant") = "Yes" Then
                        chckbox10PregnantYes.Checked = True
                    Else
                        chckbox10PregnantNo.Checked = True
                    End If

                    If myreader("Nursing") = "Yes" Then
                        chckbox10NursingYes.Checked = True
                    Else
                        chckbox10NursingNo.Checked = True
                    End If

                    If myreader("TakingBirthControlPills") = "Yes" Then
                        chckbox10PillsYes.Checked = True
                    Else
                        chckbox10PillsNo.Checked = True
                    End If

                End If

                txtboxBloodType.Text = myreader("BloodType").ToString
                txtbox12Pressure1.Text = myreader("BloodPressure").ToString

                If myreader("PastIllness") = "None" Then
                    chckbox13None.Checked = True
                Else

                    If myreader("HighBloodPressure") = "Yes" Then
                        chckbox13HighBlood.Checked = True
                    Else
                        chckbox13HighBlood.Checked = False
                    End If

                    If myreader("LowBloodPressure") = "Yes" Then
                        chckbox13LowBlood.Checked = True
                    Else
                        chckbox13LowBlood.Checked = False
                    End If

                    If myreader("Epilepsy") = "Yes" Then
                        chckbox13Epilepsy.Checked = True
                    Else
                        chckbox13Epilepsy.Checked = False
                    End If

                    If myreader("AIDSorHIV") = "Yes" Then
                        chckbox13AIDS.Checked = True
                    Else
                        chckbox13AIDS.Checked = False
                    End If

                    If myreader("STD") = "Yes" Then
                        chckbox13Sexually.Checked = True
                    Else
                        chckbox13Sexually.Checked = False
                    End If

                    If myreader("StomachTroublesOrUlcers") = "Yes" Then
                        chckbox13Ulcers.Checked = True
                    Else
                        chckbox13Ulcers.Checked = False
                    End If

                    If myreader("FaintingSeizures") = "Yes" Then
                        chckbox13Fainting.Checked = True
                    Else
                        chckbox13Fainting.Checked = False
                    End If

                    If myreader("RapidWeightLoss") = "Yes" Then
                        chckbox13WeightLoss.Checked = True
                    Else
                        chckbox13WeightLoss.Checked = False
                    End If

                    If myreader("RadiationTherapy") = "Yes" Then
                        chckbox13Radiation.Checked = True
                    Else
                        chckbox13Radiation.Checked = False
                    End If

                    If myreader("JointReplacmentOrImplant") = "Yes" Then
                        chckbox13Implant.Checked = True
                    Else
                        chckbox13Implant.Checked = False
                    End If

                    If myreader("HeartSurgery") = "Yes" Then
                        chckbox13HeartSurgery.Checked = True
                    Else
                        chckbox13HeartSurgery.Checked = False
                    End If

                    If myreader("CancerOrTumors") = "Yes" Then
                        chckbox13Cancer.Checked = True
                    Else
                        chckbox13Cancer.Checked = False
                    End If

                    If myreader("Angina") = "Yes" Then
                        chckbox13Angina.Checked = True
                    Else
                        chckbox13Angina.Checked = False
                    End If

                    If myreader("Emphysema") = "Yes" Then
                        chckbox13Emphysema.Checked = True
                    Else
                        chckbox13Emphysema.Checked = False
                    End If

                    If myreader("BloodDiseases") = "Yes" Then
                        chckbox13BloodDiseases.Checked = True
                    Else
                        chckbox13BloodDiseases.Checked = False
                    End If

                    If myreader("AthritisOrRheumatism") = "Yes" Then
                        chckbox13Arthrisis.Checked = True
                    Else
                        chckbox13Arthrisis.Checked = False
                    End If

                    If myreader("HeartAttack") = "Yes" Then
                        chckbox13HeartAttack.Checked = True
                    Else
                        chckbox13HeartAttack.Checked = False
                    End If

                    If myreader("ThyroidProblem") = "Yes" Then
                        chckbox13Thyroid.Checked = True
                    Else
                        chckbox13Thyroid.Checked = False
                    End If

                    If myreader("HeartDisease") = "Yes" Then
                        chckbox13HeartDisease.Checked = True
                    Else
                        chckbox13HeartDisease.Checked = False
                    End If

                    If myreader("HeartMurmur") = "Yes" Then
                        chckbox13HeartMurmur.Checked = True
                    Else
                        chckbox13HeartMurmur.Checked = False
                    End If

                    If myreader("HepatitisOrLiverDisease") = "Yes" Then
                        chckbox13Liver.Checked = True
                    Else
                        chckbox13Liver.Checked = False
                    End If

                    If myreader("RheumaticFever") = "Yes" Then
                        chckbox13Rheumatic.Checked = True
                    Else
                        chckbox13Rheumatic.Checked = False
                    End If

                    If myreader("HepatitisOrJaundice") = "Yes" Then
                        chckbox13Jaundice.Checked = True
                    Else
                        chckbox13Jaundice.Checked = False
                    End If

                    If myreader("Tuberculosis") = "Yes" Then
                        chckbox13Tuberculosis.Checked = True
                    Else
                        chckbox13Tuberculosis.Checked = False
                    End If

                    If myreader("SwollenAnkles") = "Yes" Then
                        chckbox13Swollen.Checked = True
                    Else
                        chckbox13Swollen.Checked = False
                    End If

                    If myreader("KidneyDisease") = "Yes" Then
                        chckbox13Kidney.Checked = True
                    Else
                        chckbox13Kidney.Checked = False
                    End If

                    If myreader("Diabetes") = "Yes" Then
                        chckbox13Diabetes.Checked = True
                    Else
                        chckbox13Diabetes.Checked = False
                    End If

                    If myreader("Anemia") = "Yes" Then
                        chckbox13Anemia.Checked = True
                    Else
                        chckbox13Anemia.Checked = False
                    End If

                    If myreader("Asthma") = "Yes" Then
                        chckbox13Asthma.Checked = True
                    Else
                        chckbox13Asthma.Checked = False
                    End If

                    If myreader("BleedingProblems") = "Yes" Then
                        chckbox13Bleeding.Checked = True
                    Else
                        chckbox13Bleeding.Checked = False
                    End If

                    If myreader("HeadInjuries") = "Yes" Then
                        chckbox13HeadInjuries.Checked = True
                    Else
                        chckbox13HeadInjuries.Checked = False
                    End If

                    If myreader("Others") = "None" Then
                        chckbox13None.Checked = False
                    Else
                        chckbox13None.Checked = True
                        txtbox13OthersExp.Text = myreader("Others")
                    End If

                End If

            End If



            'DatabaseDisconnect()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        ClearPatientPanel()

        With EditMedicalHistory
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            PatientRecordScreen.PatientProfilePanel.Controls.Add(EditMedicalHistory)
            .BringToFront()
            .Show()
        End With

    End Sub



    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click


        If Not System.IO.Directory.Exists(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName) Then
            System.IO.Directory.CreateDirectory(desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)
        End If

        Dim PatFiles As String = desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName + "\"
        Dim xlsTemplates As String

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
        xlsWB = xlsApp.Workbooks.Open(xlsTemplates & "MedicalHistory.xlsx")

        xlsSheet = xlsWB.Worksheets(1)
        xlsSheet.Unprotect("flair")


        xlsSheet.Cells(5, 2) = PatientRecordScreen.PatientName
        xlsSheet.Cells(6, 2) = PatientRecordScreen.txtboxDateofBirth.Text
        xlsSheet.Cells(5, 5) = PatientRecordScreen.PatientSex
        xlsSheet.Cells(6, 5) = PatientRecordScreen.PatientAge

        xlsSheet.Cells(10, 2) = txtboxPhysician.Text
        xlsSheet.Cells(11, 2) = txtboxSpecialty.Text
        xlsSheet.Cells(10, 5) = txtboxOfficeAddress.Text
        xlsSheet.Cells(11, 5) = txtboxOfficeNumber.Text


        xlsSheet.Cells(1, 4) = txtboxComments.Text

        If chckbox1Yes.Checked Then
            xlsSheet.Cells(15, 4) = chckbox1Yes.Text
        Else
            xlsSheet.Cells(15, 4) = chckbox1No.Text
        End If

        If chckbox2Yes.Checked Then
            xlsSheet.Cells(16, 4) = chckbox2Yes.Text & ", " & txtbox2Exp.Text
        Else
            xlsSheet.Cells(16, 4) = chckbox2No.Text
        End If

        If chckbox3Yes.Checked Then
            xlsSheet.Cells(18, 4) = chckbox3Yes.Text & ", " & txtbox3Exp.Text
        Else
            xlsSheet.Cells(18, 4) = chckbox3No.Text
        End If

        If chckbox4Yes.Checked Then
            xlsSheet.Cells(20, 4) = chckbox4Yes.Text & ", " & txtbox4Exp.Text
        Else
            xlsSheet.Cells(20, 4) = chckbox4No.Text
        End If

        If chckbox5Yes.Checked Then
            xlsSheet.Cells(22, 4) = chckbox5Yes.Text & ", " & txtbox5Exp.Text
        Else
            xlsSheet.Cells(22, 4) = chckbox5No.Text
        End If

        If chckbox6Yes.Checked Then
            xlsSheet.Cells(24, 4) = chckbox6Yes.Text
        Else
            xlsSheet.Cells(24, 4) = chckbox6No.Text
        End If

        If chckbox7Yes.Checked Then
            xlsSheet.Cells(25, 4) = chckbox7Yes.Text
        Else
            xlsSheet.Cells(25, 4) = chckbox7No.Text
        End If

        If chckbox8None.Checked Then
            xlsSheet.Cells(26, 4) = "None"
        Else
            Dim allergy As String = ""

            If chckbox8Local.Checked Then
                allergy = allergy + chckbox8Local.Text & ", "
            End If

            If chckbox8Drugs.Checked Then
                allergy = allergy + chckbox8Drugs.Text & ", "
            End If

            If chckbox8Aspirin.Checked Then
                allergy = allergy + chckbox8Aspirin.Text & ", "
            End If

            If chckbox8Latex.Checked Then
                allergy = allergy + chckbox8Latex.Text & ", "
            End If

            If chckbox8Others.Checked Then
                allergy = allergy + txtbox8Others.Text & ", "
            End If

            xlsSheet.Cells(26, 4) = allergy

        End If

        xlsSheet.Cells(27, 4) = txtbox9Exp.Text

        If PatientRecordScreen.PatientSex <> "Male" Then

            If chckbox10PregnantYes.Checked Then
                xlsSheet.Cells(28, 4) = "YES"
            Else
                xlsSheet.Cells(28, 4) = "NO"
            End If

            If chckbox10NursingYes.Checked Then
                xlsSheet.Cells(29, 4) = "YES"
            Else
                xlsSheet.Cells(29, 4) = "NO"
            End If

            If chckbox10PillsYes.Checked Then
                xlsSheet.Cells(30, 4) = "YES"
            Else
                xlsSheet.Cells(30, 4) = "NO"
            End If

        End If


        xlsSheet.Cells(31, 4) = txtboxBloodType.Text
        xlsSheet.Cells(32, 4) = txtbox12Pressure1.Text

        If chckbox13None.Checked Then
            xlsSheet.Cells(34, 4) = "NONE"
        Else
            Dim PatPastIllness As String = ""

            If chckbox13HighBlood.Checked Then
                PatPastIllness = PatPastIllness + chckbox13HighBlood.Text & ", "
            End If

            If chckbox13LowBlood.Checked Then
                PatPastIllness = PatPastIllness + chckbox13LowBlood.Text & ", "
            End If

            If chckbox13Epilepsy.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Epilepsy.Text & ", "
            End If

            If chckbox13AIDS.Checked Then
                PatPastIllness = PatPastIllness + chckbox13AIDS.Text & ", "
            End If

            If chckbox13Sexually.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Sexually.Text & ", "
            End If

            If chckbox13Ulcers.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Ulcers.Text & ", "
            End If

            If chckbox13Fainting.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Fainting.Text & ", "
            End If

            If chckbox13WeightLoss.Checked Then
                PatPastIllness = PatPastIllness + chckbox13WeightLoss.Text & ", "
            End If

            If chckbox13Radiation.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Radiation.Text & ", "
            End If

            If chckbox13Implant.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Implant.Text & ", "
            End If

            If chckbox13HeartSurgery.Checked Then
                PatPastIllness = PatPastIllness + chckbox13HeartSurgery.Text & ", "
            End If

            If chckbox13Cancer.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Cancer.Text & ", "
            End If

            If chckbox13Angina.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Angina.Text & ", "
            End If

            If chckbox13Emphysema.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Emphysema.Text & ", "
            End If

            If chckbox13BloodDiseases.Checked Then
                PatPastIllness = PatPastIllness + chckbox13BloodDiseases.Text & ", "
            End If

            If chckbox13Arthrisis.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Arthrisis.Text & ", "
            End If

            If chckbox13HeartAttack.Checked Then
                PatPastIllness = PatPastIllness + chckbox13HeartAttack.Text & ", "
            End If

            If chckbox13Thyroid.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Thyroid.Text & ", "
            End If

            If chckbox13HeartDisease.Checked Then
                PatPastIllness = PatPastIllness + chckbox13HeartDisease.Text & ", "
            End If

            If chckbox13HeartMurmur.Checked Then
                PatPastIllness = PatPastIllness + chckbox13HeartMurmur.Text & ", "
            End If

            If chckbox13Liver.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Liver.Text & ", "
            End If

            If chckbox13Rheumatic.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Rheumatic.Text & ", "
            End If

            If chckbox13Jaundice.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Jaundice.Text & ", "
            End If

            If chckbox13Tuberculosis.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Tuberculosis.Text & ", "
            End If

            If chckbox13Swollen.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Swollen.Text & ", "
            End If

            If chckbox13Kidney.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Kidney.Text & ", "
            End If

            If chckbox13Diabetes.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Diabetes.Text & ", "
            End If

            If chckbox13Anemia.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Anemia.Text & ", "
            End If

            If chckbox13Asthma.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Asthma.Text & ", "
            End If

            If chckbox13Bleeding.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Bleeding.Text & ", "
            End If

            If chckbox13HeadInjuries.Checked Then
                PatPastIllness = PatPastIllness + chckbox13HeadInjuries.Text & ", "
            End If

            If chckbox13Others.Checked Then
                PatPastIllness = PatPastIllness + chckbox13Others.Text & ", "
            End If

            xlsSheet.Cells(34, 4) = PatPastIllness

        End If

        xlsApp.ActiveWindow.View = Excel.XlWindowView.xlPageLayoutView
        xlsApp.ActiveWindow.DisplayGridlines = False

        xlsSheet.PageSetup.LeftFooter = "Date Created: " & DateTime.Now & Chr(10) & "Generated by: " & LoginAccount.empName

        Dim myfilename As String = "Medical Record - " & PatientRecordScreen.PatientName & " - " & DateTime.Now.ToString("MM-dd-yy") & ".xlsx"
        Dim myFilenameAsPdf As String = "Medical Record - " & PatientRecordScreen.PatientName & " - " & DateTime.Now.ToString("MM-dd-yy") & ".pdf"

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

        If File.Exists("C:\Program Files\Google\Chrome\Application\chrome.exe") Then
            Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", """" & PatFiles & myFilenameAsPdf & """")
        ElseIf File.Exists("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe") Then
            Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", """" & PatFiles & myFilenameAsPdf & """")
        Else
            Process.Start("explorer.exe", desktopPath + "\Dental Clinic Management System\PatientRecords\" + PatientRecordScreen.PatientName)
        End If

        'If File.Exists("C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE") Then

        '    Process.Start("C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE", """" & PatFiles & myfilename & """")

        'ElseIf File.Exists("C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE") Then

        '    Process.Start("C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE", """" & PatFiles & myfilename & """")

        'Else

        '    MessageBox.Show("Excel is not installed in this device", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        'End If

    End Sub

End Class