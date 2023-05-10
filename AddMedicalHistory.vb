Imports System.ComponentModel
Imports Twilio.Rest

Public Class AddMedicalHistory

    Private newMedHistID As String

    Private Sub AddMedicalHistory_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim timenow As String = Now().ToString("yyyyMMddHHmmssff")
        newMedHistID = "MED" + timenow
        'MsgBox(newMedHistID)

        If PatientRecordScreen.PatientSex = "Male" Then

            lblForWomen.Enabled = False
            lblPregnant.Enabled = False
            lblNursing.Enabled = False
            lblControlPills.Enabled = False

            rdbox10NursingNo.Enabled = False
            rdbox10NursingYes.Enabled = False
            rdbox10PillsNo.Enabled = False
            rdbox10pillsYes.Enabled = False
            rdbox10pregnantNo.Enabled = False
            rdbox10pregnantYes.Enabled = False

        End If

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        ClearPatientPanel()

        With ButtonAddMedicalHistory
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            PatientRecordScreen.PatientProfilePanel.Controls.Add(ButtonAddMedicalHistory)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim PhysicianName As String = lbldoctor.Text + " " + txtboxPhysician.Text
        Dim Specialty As String = txtboxSpecialty.Text
        Dim officeAddress As String = txtboxOfficeAddress.Text
        Dim officeNumber As String = txtboxOfficeNumber.Text
        Dim Comments As String = txtboxComments.Text

        If txtboxPhysician.Text = "" Then
            PhysicianName = "N/A"
        End If

        If txtboxSpecialty.Text = "" Then
            Specialty = "N/A"
        End If

        If txtboxOfficeAddress.Text = "" Then
            officeAddress = "N/A"
        End If

        If txtboxOfficeNumber.Text = "" Then
            officeNumber = "N/A"
        End If

        If txtboxComments.Text = "" Then
            Comments = "No Comments"
        End If

        Dim inGoodHealth As String
        Dim inMedicalTreatment As String
        Dim hadSurgertyOrOperation As String
        Dim hadHospitalized As String
        Dim takingMedication As String
        Dim usingTobacco As String
        Dim usingDangerousDrugsOrAlcohol As String

        Dim hadAllergies As String
        Dim LocalAnesthetic As String
        Dim sulfaDrugs As String
        Dim aspirin As String
        Dim latex As String
        Dim otherDrugs As String

        Dim bleedingTime As String

        Dim pregnant As String = ""
        Dim nursing As String = ""
        Dim takingBirthControlPills As String = ""



        Dim BloodType As String
        Dim BloodPressure As String

        Dim hadPastIllness As String
        Dim highBloodPressure As String
        Dim lowBloodPressure As String
        Dim epilepsy As String
        Dim AIDSorHIV As String
        Dim STD As String
        Dim StomachTroublesOrUlcers As String
        Dim faintingSeizures As String
        Dim rapidWeightLoss As String
        Dim radiationTherapy As String
        Dim jointReplacement As String
        Dim heartSurgery As String
        Dim cancerOrTumors As String
        Dim Angina As String
        Dim Emphysema As String
        Dim bloodDiseases As String
        Dim arthritisOrRheumatism As String
        Dim heartAttack As String
        Dim thyroidProblem As String
        Dim heartDisease As String
        Dim heartMurmur As String
        Dim hepatitisOrLiverDisease As String
        Dim rheumaticFever As String
        Dim hepatitisOrJaundice As String
        Dim tuberculosis As String
        Dim swollenAnkles As String
        Dim kidneyDisease As String
        Dim diabetes As String
        Dim anemia As String
        Dim asthma As String
        Dim bleedingProblems As String
        Dim headInjuries As String
        Dim OtherIllnessses As String


        'VALIDATIONS

        If Not (rdbox1Yes.Checked = True Or rdbox1No.Checked = True) Then
            MsgBox("You have not checked an option in Item 1", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        If Not (rdbox2Yes.Checked = True Or rdbox2No.Checked = True) Then
            MsgBox("You have not checked an option in Item 2", MsgBoxStyle.Information, "Information")
            Exit Sub
        ElseIf rdbox2Yes.Checked = True And txtbox2Exp.Text = "" Then
            MsgBox("Missing Description in Item 2", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        If Not (rdbox3Yes.Checked = True Or rdbox3No.Checked = True) Then
            MsgBox("You have not checked an option in Item 3", MsgBoxStyle.Information, "Information")
            Exit Sub
        ElseIf rdbox3Yes.Checked = True And txtbox3Exp.Text = "" Then
            MsgBox("Missing Description in Item 3", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        If Not (rdbox4Yes.Checked = True Or rdbox4No.Checked = True) Then
            MsgBox("You have not checked an option in Item 4", MsgBoxStyle.Information, "Information")
            Exit Sub
        ElseIf rdbox4Yes.Checked = True And txtbox4Exp.Text = "" Then
            MsgBox("Missing Description in Item 4", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        If Not (rdbox5Yes.Checked = True Or rdbox5No.Checked = True) Then
            MsgBox("You have not checked an option in Item 5", MsgBoxStyle.Information, "Information")
            Exit Sub
        ElseIf rdbox5Yes.Checked = True And txtbox5Exp.Text = "" Then
            MsgBox("Missing Description in Item 5", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        If Not (rdbox6Yes.Checked = True Or rdbox6No.Checked = True) Then
            MsgBox("You have not checked an option in Item 6", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        If Not (rdbox7Yes.Checked = True Or rdbox7No.Checked = True) Then
            MsgBox("You have not checked an option in Item 7", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        If Not (chckbox8None.Checked = True Or chckbox8Local.Checked = True Or chckbox8Latex.Checked = True Or chckbox8Drugs.Checked = True Or chckbox8Aspirin.Checked = True Or chckbox8Others.Checked = True) Then
            MsgBox("You have not checked an option in Item 8", MsgBoxStyle.Information, "Information")
            Exit Sub
        ElseIf chckbox8Others.Checked = True And txtbox8Others.Text = "" Then
            MsgBox("Missing Description in Item 8", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        If txtbox9Exp.Text = "" Then
            MsgBox("Missing Description in Item 9", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        If PatientRecordScreen.PatientSex <> "Male" Then

            If Not (rdbox10pregnantYes.Checked = True Or rdbox10pregnantNo.Checked = True) Then
                MsgBox("You have not checked an option in Item 10", MsgBoxStyle.Information, "Information")
                Exit Sub
            End If

            If Not (rdbox10pillsYes.Checked = True Or rdbox10PillsNo.Checked = True) Then
                MsgBox("You have not checked an option in Item 10", MsgBoxStyle.Information, "Information")
                Exit Sub
            End If

            If Not (rdbox10NursingYes.Checked = True Or rdbox10NursingNo.Checked = True) Then
                MsgBox("You have not checked an option in Item 10", MsgBoxStyle.Information, "Information")
                Exit Sub
            End If

        End If


        If cmbbox11BloodType.Text = "" Then
            MsgBox("Please choose a blood type in Item 11", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        If txtbox12Pressure.Text = "" Then
            MsgBox("Missing Blood Pressure in Item 12", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        If Not (chckbox13None.Checked = True Or chckbox13HighBlood.Checked = True Or chckbox13LowBlood.Checked = True Or chckbox13Epilepsy.Checked = True Or chckbox13AIDS.Checked = True Or chckbox13Sexually.Checked = True Or chckbox13Ulcers.Checked = True Or chckbox13Fainting.Checked = True Or chckbox13WeightLoss.Checked = True Or chckbox13Radiation.Checked = True Or chckbox13Implant.Checked = True Or chckbox13HeartSurgery.Checked = True Or chckbox13Cancer.Checked = True Or chckbox13Angina.Checked = True Or chckbox13Emphysema.Checked = True Or chckbox13BloodDiseases.Checked = True Or chckbox13Rheumatic.Checked = True Or chckbox13HeartAttack.Checked Or chckbox13Thyroid.Checked = True Or chckbox13HeartDisease.Checked = True Or chckbox13HeartMurmur.Checked = True Or chckbox13Liver.Checked = True Or chckbox13Arthrisis.Checked = True Or chckbox13Jaundice.Checked = True Or chckbox13Tuberculosis.Checked = True Or chckbox13Swollen.Checked = True Or chckbox13Kidney.Checked = True Or chckbox13Diabetes.Checked = True Or chckbox13Anemia.Checked = True Or chckbox13Asthma.Checked = True Or chckbox13Bleeding.Checked = True Or chckbox13HeadInjuries.Checked = True Or chckbox13Others.Checked = True) Then
            MsgBox("You have not checked an option in Item 13", MsgBoxStyle.Information, "Information")
            Exit Sub
        ElseIf chckbox13Others.Checked = True And txtbox13OthersExp.Text = "" Then
            MsgBox("Missing ""Others"" Description in Item 13", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        'END VALIDATIONS


        If rdbox1Yes.Checked Then
            inGoodHealth = rdbox1Yes.Text
        Else
            inGoodHealth = rdbox1No.Text
        End If

        If rdbox2Yes.Checked Then
            inMedicalTreatment = txtbox2Exp.Text
        Else
            inMedicalTreatment = rdbox2No.Text
        End If

        If rdbox3Yes.Checked Then
            hadSurgertyOrOperation = txtbox3Exp.Text
        Else
            hadSurgertyOrOperation = rdbox3No.Text
        End If

        If rdbox4Yes.Checked Then
            hadHospitalized = txtbox4Exp.Text
        Else
            hadHospitalized = rdbox4No.Text
        End If

        If rdbox5Yes.Checked Then
            takingMedication = txtbox5Exp.Text
        Else
            takingMedication = rdbox5No.Text
        End If

        If rdbox6Yes.Checked Then
            usingTobacco = rdbox6Yes.Text
        Else
            usingTobacco = rdbox6No.Text
        End If

        If rdbox7Yes.Checked Then
            usingDangerousDrugsOrAlcohol = rdbox7Yes.Text
        Else
            usingDangerousDrugsOrAlcohol = rdbox7No.Text
        End If

        If chckbox8Aspirin.Checked Or chckbox8Drugs.Checked Or chckbox8Local.Checked Or chckbox8Latex.Checked Or chckbox8Others.Checked Then
            hadAllergies = "Yes"
        ElseIf chckbox8None.Checked Then
            hadAllergies = "None"
        Else
            hadAllergies = "None"
        End If

        If chckbox8Aspirin.Checked Then
            aspirin = "Yes"
        Else
            aspirin = "No"
        End If

        If chckbox8Local.Checked Then
            LocalAnesthetic = "Yes"
        Else
            LocalAnesthetic = "No"
        End If

        If chckbox8Drugs.Checked Then
            sulfaDrugs = "Yes"
        Else
            sulfaDrugs = "No"
        End If

        If chckbox8Latex.Checked Then
            latex = "Yes"
        Else
            latex = "No"
        End If

        If chckbox8Others.Checked Then
            otherDrugs = txtbox8Others.Text
        Else
            otherDrugs = "None"
        End If

        bleedingTime = txtbox9Exp.Text

        If PatientRecordScreen.PatientSex <> "Male" Then

            If rdbox10NursingYes.Checked Then
                pregnant = rdbox10pregnantYes.Text
            Else
                pregnant = "No"
            End If

            If rdbox10NursingYes.Checked Then
                nursing = rdbox10NursingYes.Text
            Else
                nursing = "No"
            End If

            If rdbox10pillsYes.Checked Then
                takingBirthControlPills = rdbox10pillsYes.Text
            Else
                takingBirthControlPills = "No"
            End If

        Else

            pregnant = "N/A"
            nursing = "N/A"
            takingBirthControlPills = "N/A"

        End If

        BloodType = cmbbox11BloodType.Text

        BloodPressure = txtbox12Pressure.Text

        If chckbox13None.Checked Then
            hadPastIllness = "None"
        Else
            hadPastIllness = "Yes"
        End If

        If chckbox13HighBlood.Checked Then
            highBloodPressure = "Yes"
        Else
            highBloodPressure = "No"
        End If

        If chckbox13LowBlood.Checked Then
            lowBloodPressure = "Yes"
        Else
            lowBloodPressure = "No"
        End If

        If chckbox13LowBlood.Checked Then
            lowBloodPressure = "Yes"
        Else
            lowBloodPressure = "No"
        End If

        If chckbox13Epilepsy.Checked Then
            epilepsy = "Yes"
        Else
            epilepsy = "No"
        End If

        If chckbox13AIDS.Checked Then
            AIDSorHIV = "Yes"
        Else
            AIDSorHIV = "No"
        End If

        If chckbox13Sexually.Checked Then
            STD = "Yes"
        Else
            STD = "No"
        End If

        If chckbox13Ulcers.Checked Then
            StomachTroublesOrUlcers = "Yes"
        Else
            StomachTroublesOrUlcers = "No"
        End If

        If chckbox13Fainting.Checked Then
            faintingSeizures = "Yes"
        Else
            faintingSeizures = "No"
        End If

        If chckbox13WeightLoss.Checked Then
            rapidWeightLoss = "Yes"
        Else
            rapidWeightLoss = "No"
        End If

        If chckbox13Radiation.Checked Then
            radiationTherapy = "Yes"
        Else
            radiationTherapy = "No"
        End If

        If chckbox13Implant.Checked Then
            jointReplacement = "Yes"
        Else
            jointReplacement = "No"
        End If

        If chckbox13HeartSurgery.Checked Then
            heartSurgery = "Yes"
        Else
            heartSurgery = "No"
        End If

        If chckbox13Cancer.Checked Then
            cancerOrTumors = "Yes"
        Else
            cancerOrTumors = "No"
        End If

        If chckbox13Angina.Checked Then
            Angina = "Yes"
        Else
            Angina = "No"
        End If

        If chckbox13Emphysema.Checked Then
            Emphysema = "Yes"
        Else
            Emphysema = "No"
        End If

        If chckbox13BloodDiseases.Checked Then
            bloodDiseases = "Yes"
        Else
            bloodDiseases = "No"
        End If

        If chckbox13Arthrisis.Checked Then
            arthritisOrRheumatism = "Yes"
        Else
            arthritisOrRheumatism = "No"
        End If

        If chckbox13HeartAttack.Checked Then
            heartAttack = "Yes"
        Else
            heartAttack = "No"
        End If

        If chckbox13Thyroid.Checked Then
            thyroidProblem = "Yes"
        Else
            thyroidProblem = "No"
        End If

        If chckbox13HeartDisease.Checked Then
            heartDisease = "Yes"
        Else
            heartDisease = "No"
        End If

        If chckbox13HeartMurmur.Checked Then
            heartMurmur = "Yes"
        Else
            heartMurmur = "No"
        End If

        If chckbox13Liver.Checked Then
            hepatitisOrLiverDisease = "Yes"
        Else
            hepatitisOrLiverDisease = "No"
        End If

        If chckbox13Rheumatic.Checked Then
            rheumaticFever = "Yes"
        Else
            rheumaticFever = "No"
        End If

        If chckbox13Jaundice.Checked Then
            hepatitisOrJaundice = "Yes"
        Else
            hepatitisOrJaundice = "No"
        End If

        If chckbox13Tuberculosis.Checked Then
            tuberculosis = "Yes"
        Else
            tuberculosis = "No"
        End If

        If chckbox13Swollen.Checked Then
            swollenAnkles = "Yes"
        Else
            swollenAnkles = "No"
        End If

        If chckbox13Kidney.Checked Then
            kidneyDisease = "Yes"
        Else
            kidneyDisease = "No"
        End If

        If chckbox13Diabetes.Checked Then
            diabetes = "Yes"
        Else
            diabetes = "No"
        End If

        If chckbox13Anemia.Checked Then
            anemia = "Yes"
        Else
            anemia = "No"
        End If

        If chckbox13Asthma.Checked Then
            asthma = "Yes"
        Else
            asthma = "No"
        End If

        If chckbox13Bleeding.Checked Then
            bleedingProblems = "Yes"
        Else
            bleedingProblems = "No"
        End If

        If chckbox13HeadInjuries.Checked Then
            headInjuries = "Yes"
        Else
            headInjuries = "No"
        End If

        If chckbox13Others.Checked Then
            OtherIllnessses = txtbox13OthersExp.Text
        Else
            OtherIllnessses = "None"
        End If

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "InsertNewMedicalHist"
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@MedID", newMedHistID)
                .Parameters.AddWithValue("@PhyscnName", PhysicianName)
                .Parameters.AddWithValue("@Spclty", Specialty)
                .Parameters.AddWithValue("@OfficeAdd", officeAddress)
                .Parameters.AddWithValue("@OfficeNum", officeNumber)
                .Parameters.AddWithValue("@Goodhealth", inGoodHealth)
                .Parameters.AddWithValue("@nTreatment", inMedicalTreatment)
                .Parameters.AddWithValue("@hdIlnessOrSurgery", hadSurgertyOrOperation)
                .Parameters.AddWithValue("@hdHospitalized", hadHospitalized)
                .Parameters.AddWithValue("@takingMeds", takingMedication)
                .Parameters.AddWithValue("@usingTobacco", usingTobacco)
                .Parameters.AddWithValue("@dngrousDrugs", usingDangerousDrugsOrAlcohol)
                .Parameters.AddWithValue("@hdAllergies", hadAllergies)
                .Parameters.AddWithValue("@sulfa", sulfaDrugs)
                .Parameters.AddWithValue("@asprn", aspirin)
                .Parameters.AddWithValue("@latx", latex)
                .Parameters.AddWithValue("@loclAnesthetic", LocalAnesthetic)
                .Parameters.AddWithValue("@othrAllegies", otherDrugs)
                .Parameters.AddWithValue("@bleedngTime", bleedingTime)
                .Parameters.AddWithValue("@Prgnant", pregnant)
                .Parameters.AddWithValue("@nrsing", nursing)
                .Parameters.AddWithValue("@birthcontrolpills", takingBirthControlPills)
                .Parameters.AddWithValue("@bldtype", BloodType)
                .Parameters.AddWithValue("@BldPressure", BloodPressure)
                .Parameters.AddWithValue("@pstIllness", hadPastIllness)
                .Parameters.AddWithValue("@highbldpressure", highBloodPressure)
                .Parameters.AddWithValue("@LowBldPressure", lowBloodPressure)
                .Parameters.AddWithValue("@Eplepsy", epilepsy)
                .Parameters.AddWithValue("@AIDSHIV", AIDSorHIV)
                .Parameters.AddWithValue("@Stds", STD)
                .Parameters.AddWithValue("@StomachAcheUlcers", StomachTroublesOrUlcers)
                .Parameters.AddWithValue("@FaintingSezrs", faintingSeizures)
                .Parameters.AddWithValue("@RapidWghtLoss", rapidWeightLoss)
                .Parameters.AddWithValue("@RdtnTherapy", radiationTherapy)
                .Parameters.AddWithValue("@JntReplacementImplant", jointReplacement)
                .Parameters.AddWithValue("@HrtSrgry", heartSurgery)
                .Parameters.AddWithValue("@CancerTumors", cancerOrTumors)
                .Parameters.AddWithValue("@Angna", Angina)
                .Parameters.AddWithValue("@Emphsema", Emphysema)
                .Parameters.AddWithValue("@BldDiseases", bloodDiseases)
                .Parameters.AddWithValue("@ArthritisRheuma", arthritisOrRheumatism)
                .Parameters.AddWithValue("@HrtAttck", heartAttack)
                .Parameters.AddWithValue("@ThyroidPrblem", thyroidProblem)
                .Parameters.AddWithValue("@HrtDisease", heartDisease)
                .Parameters.AddWithValue("@HrtMurmur", heartMurmur)
                .Parameters.AddWithValue("@HepatitisLiverDisease", hepatitisOrLiverDisease)
                .Parameters.AddWithValue("@RheumaticFver", rheumaticFever)
                .Parameters.AddWithValue("@HepatitsJaundice", hepatitisOrJaundice)
                .Parameters.AddWithValue("@Tbrculosis", tuberculosis)
                .Parameters.AddWithValue("@SwllenAnkles", swollenAnkles)
                .Parameters.AddWithValue("@KdneyDisease", kidneyDisease)
                .Parameters.AddWithValue("@diabtes", diabetes)
                .Parameters.AddWithValue("@Anmia", anemia)
                .Parameters.AddWithValue("@Asthm", asthma)
                .Parameters.AddWithValue("@BledngProblems", bleedingProblems)
                .Parameters.AddWithValue("@HeadInjries", headInjuries)
                .Parameters.AddWithValue("@Othrs", OtherIllnessses)
                .Parameters.AddWithValue("@Cmmnt", Comments)


                .ExecuteNonQuery()
                'MsgBox("Medical History Registered", MsgBoxStyle.Information, "Information")

                DatabaseDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try


            ClearPatientPanel()

            With MedicalInformation
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill And DockStyle.Bottom
                .AutoSize = True
                .TopLevel = False
                PatientRecordScreen.PatientProfilePanel.Controls.Add(MedicalInformation)
                .BringToFront()
                .Show()
            End With

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



        ''''''''''''''''''''''''''''

        'sqlstr = "UPDATE patient SET MedHistory ='" & 1 & "' WHERE PatientID ='" & PatientRecordScreen.MyPatientID & "'"

        'ConnectDatabase()

        'With sqlcmd

        '    Try
        '        .Connection = DBConnection
        '        .CommandText = sqlstr
        '        .ExecuteNonQuery()
        '        MsgBox("Status Updated", MsgBoxStyle.Information, "Information")
        '    Catch ex As Exception
        '        MsgBox(ex.Message, MsgBoxStyle.Critical)
        '    End Try

        '    DatabaseDisconnect()

        'End With

    End Sub

    Private Sub AddMedicalHistory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtbox9Exp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox9Exp.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            'MsgBox("Numeric Input Only")
        End If

    End Sub

    Private Sub txtbox12Pressure_Validating(sender As Object, e As CancelEventArgs) Handles txtbox12Pressure.Validating

        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        If (txtbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtbox, String.Empty)
        Else
            ErrorProvider1.SetError(txtbox, "This field is required!")
            txtbox.Select()
        End If

        If txtbox.Name = "txtbox12Pressure" Then
            If isBloodPressure(txtbox12Pressure.Text) Then
                ErrorProvider1.SetError(txtbox, String.Empty)
            Else
                ErrorProvider1.SetError(txtbox, "Invalid Blood Pressure")
                txtbox.Select()
            End If
        End If

    End Sub

End Class