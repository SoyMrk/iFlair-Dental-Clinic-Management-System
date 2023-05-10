Imports MySql.Data.MySqlClient

Public Class AddDentalChart

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Generate Record ID's base on patient ID and DateTime when its made
        Dim DentalRecordID As String = "DR" + PatientRecordScreen.MyPatientID + Now().ToString("yyyyMMddHHmm")
        Dim IntraOralID As String = "IO" + PatientRecordScreen.MyPatientID + Now().ToString("yyyyMMddHHmm")
        Dim ExtraOralID As String = "EO" + PatientRecordScreen.MyPatientID + Now().ToString("yyyyMMddHHmm")
        Dim OcclusionID As String = "O" + PatientRecordScreen.MyPatientID + Now().ToString("yyyyMMddHHmm")
        Dim PSID As String = "PS" + PatientRecordScreen.MyPatientID + Now().ToString("yyyyMMddHHmm")

        Dim FaceSymmetry As String
        Dim ClickingSounds As String
        Dim Swellings As String
        Dim LipExamination As String
        Dim LymphNodes As String

        Dim oralHygiene As String
        Dim GingivaColor As String
        Dim GingivaConsistency As String
        Dim PathologicalCondition As String
        Dim TonguePosition As String

        Dim ClassMolar As String
        Dim Mmoverjet As String
        Dim OverbitePercent As String
        Dim MiddlineDeviation As String
        Dim crossbite As String

        Dim Gingivits As String
        Dim EarlyPeriodontitis As String
        Dim ModeratePeriodontitis As String
        Dim AdvancePeriodontitis As String


        'VALIDATIONS'

        If Not (rdSymmetrical.Checked = True Or rdAsymmetrical.Checked = True) Then
            MessageBox.Show("You have not choosed an option in Item I.A", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Not (rdTempPresent.Checked = True Or rdTempAbsent.Checked = True) Then
            MessageBox.Show("You have not choosed an option in Item I.B", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Not (rdSwellPresent.Checked = True Or rdSwellAbsent.Checked = True) Then
            MessageBox.Show("You have not choosed an option in Item I.C", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Not (rdCrack.Checked = True Or rdUlcers.Checked = True) Then
            MessageBox.Show("You have not choosed an option in Item I.D", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Not (rdPalpable.Checked = True Or rdNotPalpable.Checked = True) Then
            MessageBox.Show("You have not choosed an option in Item I.E", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Not (rdGood.Checked = True Or rdFair.Checked = True Or rdPoor.Checked = True) Then
            MessageBox.Show("You have not choosed an option in Item II.A", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Not (rdPink.Checked = True Or rdPale.Checked = True Or rdBrightRed.Checked = True) Then
            MessageBox.Show("You have not choosed an option in Item II.B", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Not (rdFirm.Checked = True Or rdSmooth.Checked = True Or rdEnlarged.Checked = True) Then
            MessageBox.Show("You have not choosed an option in Item II.C", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Not (rdElevations.Checked = True Or rdDepressions.Checked = True Or rdColorChanges.Checked = True) Then
            MessageBox.Show("You have not choosed an option in Item II.D", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Not (rdNormal.Checked = True Or rdRetracted.Checked = True) Then
            MessageBox.Show("You have not choosed an option in Item II.E", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtboxClassMolar.Text = "" Then
            MessageBox.Show("Missing Value in Occlusion Class Molar", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtboxOverjet.Text = "" Then
            MessageBox.Show("Missing Value in Occlusion Overjet", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtboxOverbite.Text = "" Then
            MessageBox.Show("Missing Value in Occlusion Overbite", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtboxMidline.Text = "" Then
            MessageBox.Show("Missing Value in Occlusion Midline deviation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtboxCrossbite.Text = "" Then
            MessageBox.Show("Missing Value in Occlusion Crossbite", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Not (cbxGingivitis.Checked = True Or cbxEarlyPeriod.Checked = True Or cbxModeratePeriod.Checked = True Or cbxAdvancePeriod.Checked = True) Then
            MessageBox.Show("You have not choosed an option in Item IV", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        'END VALIDATIONS


        'Extraoral Examination Start

        If rdSymmetrical.Checked Then
            FaceSymmetry = rdSymmetrical.Text
        Else
            FaceSymmetry = rdAsymmetrical.Text
        End If

        If rdTempPresent.Checked Then
            ClickingSounds = rdTempPresent.Text
        Else
            ClickingSounds = rdTempAbsent.Text
        End If

        If rdSwellPresent.Checked Then
            Swellings = rdSwellPresent.Text
        Else
            Swellings = rdSwellAbsent.Text
        End If

        If rdCrack.Checked Then
            LipExamination = rdCrack.Text
        Else
            LipExamination = rdUlcers.Text
        End If

        If rdPalpable.Checked Then
            LymphNodes = rdPalpable.Text
        Else
            LymphNodes = rdNotPalpable.Text
        End If

        'Extraoral Examination End

        'Intraoral Examination Start

        If rdGood.Checked Then
            oralHygiene = rdGood.Text
        ElseIf rdFair.Checked Then
            oralHygiene = rdFair.Text
        Else
            oralHygiene = rdPoor.Text
        End If

        If rdPink.Checked Then
            GingivaColor = rdPink.Text
        ElseIf rdPale.Checked Then
            GingivaColor = rdPale.Text
        Else
            GingivaColor = rdBrightRed.Text
        End If

        If rdFirm.Checked Then
            GingivaConsistency = rdFirm.Text
        ElseIf rdSmooth.Checked Then
            GingivaConsistency = rdSmooth.Text
        Else
            GingivaConsistency = rdEnlarged.Text
        End If

        If rdElevations.Checked Then
            PathologicalCondition = rdElevations.Text
        ElseIf rdDepressions.Checked Then
            PathologicalCondition = rdDepressions.Text
        Else
            PathologicalCondition = rdColorChanges.Text
        End If

        If rdNormal.Checked Then
            TonguePosition = rdNormal.Text
        Else
            TonguePosition = rdRetracted.Text
        End If

        'Intraoral Examination End

        'Occlusion Start

        ClassMolar = txtboxClassMolar.Text
        Mmoverjet = txtboxOverjet.Text
        OverbitePercent = txtboxOverbite.Text
        MiddlineDeviation = txtboxMidline.Text
        crossbite = txtboxCrossbite.Text

        'Occlusion End

        'Periodental Screening Start

        If cbxGingivitis.Checked = True Then
            Gingivits = "Yes"
        Else
            Gingivits = "No"
        End If

        If cbxEarlyPeriod.Checked = True Then
            EarlyPeriodontitis = "Yes"
        Else
            EarlyPeriodontitis = "No"
        End If

        If cbxModeratePeriod.Checked = True Then
            ModeratePeriodontitis = "Yes"
        Else
            ModeratePeriodontitis = "No"
        End If

        If cbxAdvancePeriod.Checked = True Then
            AdvancePeriodontitis = "True"
        Else
            AdvancePeriodontitis = "No"
        End If

        'Periodental Screening End

        'TAKING THE SCREENSHOT OF DENTAL CHART
        Dim arrImage() As Byte
        Dim msstream As New System.IO.MemoryStream()

        TakeScreenshotPanel(pnlDentalChart).Save(msstream, System.Drawing.Imaging.ImageFormat.Png)

        arrImage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()

        'END OF TAKING SCREENSHOT


        Try
            ConnectDatabase()

            With sqlcmd

                Try
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "InsertDentalExams"

                    .Parameters.AddWithValue("@IntOralID", IntraOralID)
                    .Parameters.AddWithValue("@OralHyg", oralHygiene)
                    .Parameters.AddWithValue("@GingivaClr", GingivaColor)
                    .Parameters.AddWithValue("@GingivaCnsstncy", GingivaConsistency)
                    .Parameters.AddWithValue("@PathologicalCndtn", PathologicalCondition)
                    .Parameters.AddWithValue("@TonguePstn", TonguePosition)

                    .Parameters.AddWithValue("@ExtOralID", ExtraOralID)
                    .Parameters.AddWithValue("@FaceSymmtry", FaceSymmetry)
                    .Parameters.AddWithValue("@ClickingSnds", ClickingSounds)
                    .Parameters.AddWithValue("@Swllngs", Swellings)
                    .Parameters.AddWithValue("@LipExmntn", LipExamination)
                    .Parameters.AddWithValue("@LymphNds", LymphNodes)

                    .Parameters.AddWithValue("@OcclsnID", OcclusionID)
                    .Parameters.AddWithValue("@ClassMjr", ClassMolar)
                    .Parameters.AddWithValue("@MMoverjt", Mmoverjet)
                    .Parameters.AddWithValue("@OverbitePrcnt", OverbitePercent)
                    .Parameters.AddWithValue("@MiddlineDvtn", MiddlineDeviation)
                    .Parameters.AddWithValue("@Crssbt", crossbite)

                    .Parameters.AddWithValue("@PerDntlScrngID", PSID)
                    .Parameters.AddWithValue("@Gnvts", Gingivits)
                    .Parameters.AddWithValue("@EarlyPrdntts", EarlyPeriodontitis)
                    .Parameters.AddWithValue("@ModeratePrdntts", ModeratePeriodontitis)
                    .Parameters.AddWithValue("@AdvancePrdntts", AdvancePeriodontitis)

                    .ExecuteNonQuery()
                    'MessageBox.Show("Exams Registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    'sqlcmd.Parameters.Clear()
                    DatabaseDisconnect()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'sqlcmd.Parameters.Clear()
                    DatabaseDisconnect()
                End Try


            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try

        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "InsertDentalRecord"
                .Parameters.AddWithValue("@DentalRcrdID", DentalRecordID)
                .Parameters.AddWithValue("@DentstID", cmbboxDentist.SelectedValue.ToString)
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@IntOralID", IntraOralID)
                .Parameters.AddWithValue("@ExtOralID", ExtraOralID)
                .Parameters.AddWithValue("@OcclsnID", OcclusionID)
                .Parameters.AddWithValue("@PerDntlScrngID", PSID)
                .Parameters.AddWithValue("@DntlChrt", arrImage)
            End With

            Dim x As Integer

            x = sqlcmd.ExecuteNonQuery()

            If x > 0 Then
                'MessageBox.Show("Dental Record Registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            'sqlcmd.Parameters.Clear()
            DatabaseDisconnect()

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

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Dental Record Not Registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try




    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub AddDentalChart_Load(sender As Object, e As EventArgs) Handles Me.Load

        'ADD CLICK EVENT HANDLER TO ALL PICTUREBOX(TOOTH) IN FORM
        AddToothEventHandler(pnlDentalChart)


        lblDentalChartOwnerName.Text = PatientRecordScreen.txtboxPatientName.Text
        lblDentalChartDate.Text = Now().ToString("MMMM dd, yyyy")

        Try
            ConnectDatabase()
            Dim DenTable As New DataTable
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getDentists"
            End With
            myAdapter.SelectCommand = sqlcmd
            myAdapter.Fill(DenTable)

            cmbboxDentist.DataSource = DenTable
            cmbboxDentist.ValueMember = "EmployeeID"
            cmbboxDentist.DisplayMember = "EmployeeName"

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try

    End Sub

    Private Sub ptTT55U_Click(sender As Object, e As EventArgs) Handles ptTT55U.Click
        If ptTT55U.BackColor = Color.White Then
            ptTT55U.BackColor = Color.Red
        ElseIf ptTT55U.BackColor = Color.Red Then
            ptTT55U.BackColor = Color.Blue
        Else
            ptTT55U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT55R_Click(sender As Object, e As EventArgs) Handles ptTT55R.Click
        If ptTT55R.BackColor = Color.White Then
            ptTT55R.BackColor = Color.Red
        ElseIf ptTT55R.BackColor = Color.Red Then
            ptTT55R.BackColor = Color.Blue
        Else
            ptTT55R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT55D_Click(sender As Object, e As EventArgs) Handles ptTT55D.Click
        If ptTT55D.BackColor = Color.White Then
            ptTT55D.BackColor = Color.Red
        ElseIf ptTT55D.BackColor = Color.Red Then
            ptTT55D.BackColor = Color.Blue
        Else
            ptTT55D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT55L_Click(sender As Object, e As EventArgs) Handles ptTT55L.Click
        If ptTT55L.BackColor = Color.White Then
            ptTT55L.BackColor = Color.Red
        ElseIf ptTT55L.BackColor = Color.Red Then
            ptTT55L.BackColor = Color.Blue
        Else
            ptTT55L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT55M_Click(sender As Object, e As EventArgs) Handles ptTT55M.Click
        If ptTT55M.BackColor = Color.White Then
            ptTT55M.BackColor = Color.Red
        ElseIf ptTT55M.BackColor = Color.Red Then
            ptTT55M.BackColor = Color.Blue
        Else
            ptTT55M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT54U_Click(sender As Object, e As EventArgs) Handles ptTT54U.Click
        If ptTT54U.BackColor = Color.White Then
            ptTT54U.BackColor = Color.Red
        ElseIf ptTT54U.BackColor = Color.Red Then
            ptTT54U.BackColor = Color.Blue
        Else
            ptTT54U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT54L_Click(sender As Object, e As EventArgs) Handles ptTT54L.Click
        If ptTT54L.BackColor = Color.White Then
            ptTT54L.BackColor = Color.Red
        ElseIf ptTT54L.BackColor = Color.Red Then
            ptTT54L.BackColor = Color.Blue
        Else
            ptTT54L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT54D_Click(sender As Object, e As EventArgs) Handles ptTT54D.Click
        If ptTT54D.BackColor = Color.White Then
            ptTT54D.BackColor = Color.Red
        ElseIf ptTT54D.BackColor = Color.Red Then
            ptTT54D.BackColor = Color.Blue
        Else
            ptTT54D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT54R_Click(sender As Object, e As EventArgs) Handles ptTT54R.Click
        If ptTT54R.BackColor = Color.White Then
            ptTT54R.BackColor = Color.Red
        ElseIf ptTT54R.BackColor = Color.Red Then
            ptTT54R.BackColor = Color.Blue
        Else
            ptTT54R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT54M_Click(sender As Object, e As EventArgs) Handles ptTT54M.Click
        If ptTT54M.BackColor = Color.White Then
            ptTT54M.BackColor = Color.Red
        ElseIf ptTT54M.BackColor = Color.Red Then
            ptTT54M.BackColor = Color.Blue
        Else
            ptTT54M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT53U_Click(sender As Object, e As EventArgs) Handles ptTT53U.Click
        If ptTT53U.BackColor = Color.White Then
            ptTT53U.BackColor = Color.Red
        ElseIf ptTT53U.BackColor = Color.Red Then
            ptTT53U.BackColor = Color.Blue
        Else
            ptTT53U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT53L_Click(sender As Object, e As EventArgs) Handles ptTT53L.Click
        If ptTT53L.BackColor = Color.White Then
            ptTT53L.BackColor = Color.Red
        ElseIf ptTT53L.BackColor = Color.Red Then
            ptTT53L.BackColor = Color.Blue
        Else
            ptTT53L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT53D_Click(sender As Object, e As EventArgs) Handles ptTT53D.Click
        If ptTT53D.BackColor = Color.White Then
            ptTT53D.BackColor = Color.Red
        ElseIf ptTT53D.BackColor = Color.Red Then
            ptTT53D.BackColor = Color.Blue
        Else
            ptTT53D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT53UR_Click(sender As Object, e As EventArgs) Handles ptTT53UR.Click
        If ptTT53UR.BackColor = Color.White Then
            ptTT53UR.BackColor = Color.Red
        ElseIf ptTT53UR.BackColor = Color.Red Then
            ptTT53UR.BackColor = Color.Blue
        Else
            ptTT53UR.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT53M_Click(sender As Object, e As EventArgs) Handles ptTT53M.Click
        If ptTT53M.BackColor = Color.White Then
            ptTT53M.BackColor = Color.Red
        ElseIf ptTT53M.BackColor = Color.Red Then
            ptTT53M.BackColor = Color.Blue
        Else
            ptTT53M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT52R_Click(sender As Object, e As EventArgs) Handles ptTT52R.Click
        If ptTT52R.BackColor = Color.White Then
            ptTT52R.BackColor = Color.Red
        ElseIf ptTT52R.BackColor = Color.Red Then
            ptTT52R.BackColor = Color.Blue
        Else
            ptTT52R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT52U_Click(sender As Object, e As EventArgs) Handles ptTT52U.Click
        If ptTT52U.BackColor = Color.White Then
            ptTT52U.BackColor = Color.Red
        ElseIf ptTT52U.BackColor = Color.Red Then
            ptTT52U.BackColor = Color.Blue
        Else
            ptTT52U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT52L_Click(sender As Object, e As EventArgs) Handles ptTT52L.Click
        If ptTT52L.BackColor = Color.White Then
            ptTT52L.BackColor = Color.Red
        ElseIf ptTT52L.BackColor = Color.Red Then
            ptTT52L.BackColor = Color.Blue
        Else
            ptTT52L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT52D_Click(sender As Object, e As EventArgs) Handles ptTT52D.Click
        If ptTT52D.BackColor = Color.White Then
            ptTT52D.BackColor = Color.Red
        ElseIf ptTT52D.BackColor = Color.Red Then
            ptTT52D.BackColor = Color.Blue
        Else
            ptTT52D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT52M_Click(sender As Object, e As EventArgs) Handles ptTT52M.Click
        If ptTT52M.BackColor = Color.White Then
            ptTT52M.BackColor = Color.Red
        ElseIf ptTT52M.BackColor = Color.Red Then
            ptTT52M.BackColor = Color.Blue
        Else
            ptTT52M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT51U_Click(sender As Object, e As EventArgs) Handles ptTT51U.Click
        If ptTT51U.BackColor = Color.White Then
            ptTT51U.BackColor = Color.Red
        ElseIf ptTT51U.BackColor = Color.Red Then
            ptTT51U.BackColor = Color.Blue
        Else
            ptTT51U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT51L_Click(sender As Object, e As EventArgs) Handles ptTT51L.Click
        If ptTT51L.BackColor = Color.White Then
            ptTT51L.BackColor = Color.Red
        ElseIf ptTT51L.BackColor = Color.Red Then
            ptTT51L.BackColor = Color.Blue
        Else
            ptTT51L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT51D_Click(sender As Object, e As EventArgs) Handles ptTT51D.Click
        If ptTT51D.BackColor = Color.White Then
            ptTT51D.BackColor = Color.Red
        ElseIf ptTT51D.BackColor = Color.Red Then
            ptTT51D.BackColor = Color.Blue
        Else
            ptTT51D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT51R_Click(sender As Object, e As EventArgs) Handles ptTT51R.Click
        If ptTT51R.BackColor = Color.White Then
            ptTT51R.BackColor = Color.Red
        ElseIf ptTT51R.BackColor = Color.Red Then
            ptTT51R.BackColor = Color.Blue
        Else
            ptTT51R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT51M_Click(sender As Object, e As EventArgs) Handles ptTT51M.Click
        If ptTT51M.BackColor = Color.White Then
            ptTT51M.BackColor = Color.Red
        ElseIf ptTT51M.BackColor = Color.Red Then
            ptTT51M.BackColor = Color.Blue
        Else
            ptTT51M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT61U_Click(sender As Object, e As EventArgs) Handles ptTT61U.Click
        If ptTT61U.BackColor = Color.White Then
            ptTT61U.BackColor = Color.Red
        ElseIf ptTT61U.BackColor = Color.Red Then
            ptTT61U.BackColor = Color.Blue
        Else
            ptTT61U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT61L_Click(sender As Object, e As EventArgs) Handles ptTT61L.Click
        If ptTT61L.BackColor = Color.White Then
            ptTT61L.BackColor = Color.Red
        ElseIf ptTT61L.BackColor = Color.Red Then
            ptTT61L.BackColor = Color.Blue
        Else
            ptTT61L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT61D_Click(sender As Object, e As EventArgs) Handles ptTT61D.Click
        If ptTT61D.BackColor = Color.White Then
            ptTT61D.BackColor = Color.Red
        ElseIf ptTT61D.BackColor = Color.Red Then
            ptTT61D.BackColor = Color.Blue
        Else
            ptTT61D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT61R_Click(sender As Object, e As EventArgs) Handles ptTT61R.Click
        If ptTT61R.BackColor = Color.White Then
            ptTT61R.BackColor = Color.Red
        ElseIf ptTT61R.BackColor = Color.Red Then
            ptTT61R.BackColor = Color.Blue
        Else
            ptTT61R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT61UM_Click(sender As Object, e As EventArgs) Handles ptTT61UM.Click
        If ptTT61UM.BackColor = Color.White Then
            ptTT61UM.BackColor = Color.Red
        ElseIf ptTT61UM.BackColor = Color.Red Then
            ptTT61UM.BackColor = Color.Blue
        Else
            ptTT61UM.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT62U_Click(sender As Object, e As EventArgs) Handles ptTT62U.Click
        If ptTT62U.BackColor = Color.White Then
            ptTT62U.BackColor = Color.Red
        ElseIf ptTT62U.BackColor = Color.Red Then
            ptTT62U.BackColor = Color.Blue
        Else
            ptTT62U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT62L_Click(sender As Object, e As EventArgs) Handles ptTT62L.Click
        If ptTT62L.BackColor = Color.White Then
            ptTT62L.BackColor = Color.Red
        ElseIf ptTT62L.BackColor = Color.Red Then
            ptTT62L.BackColor = Color.Blue
        Else
            ptTT62L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT62D_Click(sender As Object, e As EventArgs) Handles ptTT62D.Click
        If ptTT62D.BackColor = Color.White Then
            ptTT62D.BackColor = Color.Red
        ElseIf ptTT62D.BackColor = Color.Red Then
            ptTT62D.BackColor = Color.Blue
        Else
            ptTT62D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT62R_Click(sender As Object, e As EventArgs) Handles ptTT62R.Click
        If ptTT62R.BackColor = Color.White Then
            ptTT62R.BackColor = Color.Red
        ElseIf ptTT62R.BackColor = Color.Red Then
            ptTT62R.BackColor = Color.Blue
        Else
            ptTT62R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT62M_Click(sender As Object, e As EventArgs) Handles ptTT62M.Click
        If ptTT62M.BackColor = Color.White Then
            ptTT62M.BackColor = Color.Red
        ElseIf ptTT62M.BackColor = Color.Red Then
            ptTT62M.BackColor = Color.Blue
        Else
            ptTT62M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT63U_Click(sender As Object, e As EventArgs) Handles ptTT63U.Click
        If ptTT63U.BackColor = Color.White Then
            ptTT63U.BackColor = Color.Red
        ElseIf ptTT63U.BackColor = Color.Red Then
            ptTT63U.BackColor = Color.Blue
        Else
            ptTT63U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT63L_Click(sender As Object, e As EventArgs) Handles ptTT63L.Click
        If ptTT63L.BackColor = Color.White Then
            ptTT63L.BackColor = Color.Red
        ElseIf ptTT63L.BackColor = Color.Red Then
            ptTT63L.BackColor = Color.Blue
        Else
            ptTT63L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT63D_Click(sender As Object, e As EventArgs) Handles ptTT63D.Click
        If ptTT63D.BackColor = Color.White Then
            ptTT63D.BackColor = Color.Red
        ElseIf ptTT63D.BackColor = Color.Red Then
            ptTT63D.BackColor = Color.Blue
        Else
            ptTT63D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT63R_Click(sender As Object, e As EventArgs) Handles ptTT63R.Click
        If ptTT63R.BackColor = Color.White Then
            ptTT63R.BackColor = Color.Red
        ElseIf ptTT63R.BackColor = Color.Red Then
            ptTT63R.BackColor = Color.Blue
        Else
            ptTT63R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT63M_Click(sender As Object, e As EventArgs) Handles ptTT63M.Click
        If ptTT63M.BackColor = Color.White Then
            ptTT63M.BackColor = Color.Red
        ElseIf ptTT63M.BackColor = Color.Red Then
            ptTT63M.BackColor = Color.Blue
        Else
            ptTT63M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT64U_Click(sender As Object, e As EventArgs) Handles ptTT64U.Click
        If ptTT64U.BackColor = Color.White Then
            ptTT64U.BackColor = Color.Red
        ElseIf ptTT64U.BackColor = Color.Red Then
            ptTT64U.BackColor = Color.Blue
        Else
            ptTT64U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT64L_Click(sender As Object, e As EventArgs) Handles ptTT64L.Click
        If ptTT64L.BackColor = Color.White Then
            ptTT64L.BackColor = Color.Red
        ElseIf ptTT64L.BackColor = Color.Red Then
            ptTT64L.BackColor = Color.Blue
        Else
            ptTT64L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT64D_Click(sender As Object, e As EventArgs) Handles ptTT64D.Click
        If ptTT64D.BackColor = Color.White Then
            ptTT64D.BackColor = Color.Red
        ElseIf ptTT64D.BackColor = Color.Red Then
            ptTT64D.BackColor = Color.Blue
        Else
            ptTT64D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT64R_Click(sender As Object, e As EventArgs) Handles ptTT64R.Click
        If ptTT64R.BackColor = Color.White Then
            ptTT64R.BackColor = Color.Red
        ElseIf ptTT64R.BackColor = Color.Red Then
            ptTT64R.BackColor = Color.Blue
        Else
            ptTT64R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT64M_Click(sender As Object, e As EventArgs) Handles ptTT64M.Click
        If ptTT64M.BackColor = Color.White Then
            ptTT64M.BackColor = Color.Red
        ElseIf ptTT64M.BackColor = Color.Red Then
            ptTT64M.BackColor = Color.Blue
        Else
            ptTT64M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT65U_Click(sender As Object, e As EventArgs) Handles ptTT65U.Click
        If ptTT65U.BackColor = Color.White Then
            ptTT65U.BackColor = Color.Red
        ElseIf ptTT65U.BackColor = Color.Red Then
            ptTT65U.BackColor = Color.Blue
        Else
            ptTT65U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT65L_Click(sender As Object, e As EventArgs) Handles ptTT65L.Click
        If ptTT65L.BackColor = Color.White Then
            ptTT65L.BackColor = Color.Red
        ElseIf ptTT65L.BackColor = Color.Red Then
            ptTT65L.BackColor = Color.Blue
        Else
            ptTT65L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT65D_Click(sender As Object, e As EventArgs) Handles ptTT65D.Click
        If ptTT65D.BackColor = Color.White Then
            ptTT65D.BackColor = Color.Red
        ElseIf ptTT65D.BackColor = Color.Red Then
            ptTT65D.BackColor = Color.Blue
        Else
            ptTT65D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT65R_Click(sender As Object, e As EventArgs) Handles ptTT65R.Click
        If ptTT65R.BackColor = Color.White Then
            ptTT65R.BackColor = Color.Red
        ElseIf ptTT65R.BackColor = Color.Red Then
            ptTT65R.BackColor = Color.Blue
        Else
            ptTT65R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT65M_Click(sender As Object, e As EventArgs) Handles ptTT65M.Click
        If ptTT65M.BackColor = Color.White Then
            ptTT65M.BackColor = Color.Red
        ElseIf ptTT65M.BackColor = Color.Red Then
            ptTT65M.BackColor = Color.Blue
        Else
            ptTT65M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT18U_Click(sender As Object, e As EventArgs) Handles ptPT18U.Click
        If ptPT18U.BackColor = Color.White Then
            ptPT18U.BackColor = Color.Red
        ElseIf ptPT18U.BackColor = Color.Red Then
            ptPT18U.BackColor = Color.Blue
        Else
            ptPT18U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT18L_Click(sender As Object, e As EventArgs) Handles ptPT18L.Click
        If ptPT18L.BackColor = Color.White Then
            ptPT18L.BackColor = Color.Red
        ElseIf ptPT18L.BackColor = Color.Red Then
            ptPT18L.BackColor = Color.Blue
        Else
            ptPT18L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT18D_Click(sender As Object, e As EventArgs) Handles ptPT18D.Click
        If ptPT18D.BackColor = Color.White Then
            ptPT18D.BackColor = Color.Red
        ElseIf ptPT18D.BackColor = Color.Red Then
            ptPT18D.BackColor = Color.Blue
        Else
            ptPT18D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT18R_Click(sender As Object, e As EventArgs) Handles ptPT18R.Click
        If ptPT18R.BackColor = Color.White Then
            ptPT18R.BackColor = Color.Red
        ElseIf ptPT18R.BackColor = Color.Red Then
            ptPT18R.BackColor = Color.Blue
        Else
            ptPT18R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT18M_Click(sender As Object, e As EventArgs) Handles ptPT18M.Click
        If ptPT18M.BackColor = Color.White Then
            ptPT18M.BackColor = Color.Red
        ElseIf ptPT18M.BackColor = Color.Red Then
            ptPT18M.BackColor = Color.Blue
        Else
            ptPT18M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT17U_Click(sender As Object, e As EventArgs) Handles ptPT17U.Click
        If ptPT17U.BackColor = Color.White Then
            ptPT17U.BackColor = Color.Red
        ElseIf ptPT17U.BackColor = Color.Red Then
            ptPT17U.BackColor = Color.Blue
        Else
            ptPT17U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT17L_Click(sender As Object, e As EventArgs) Handles ptPT17L.Click
        If ptPT17L.BackColor = Color.White Then
            ptPT17L.BackColor = Color.Red
        ElseIf ptPT17L.BackColor = Color.Red Then
            ptPT17L.BackColor = Color.Blue
        Else
            ptPT17L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT17D_Click(sender As Object, e As EventArgs) Handles ptPT17D.Click
        If ptPT17D.BackColor = Color.White Then
            ptPT17D.BackColor = Color.Red
        ElseIf ptPT17D.BackColor = Color.Red Then
            ptPT17D.BackColor = Color.Blue
        Else
            ptPT17D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT17R_Click(sender As Object, e As EventArgs) Handles ptPT17R.Click
        If ptPT17R.BackColor = Color.White Then
            ptPT17R.BackColor = Color.Red
        ElseIf ptPT17R.BackColor = Color.Red Then
            ptPT17R.BackColor = Color.Blue
        Else
            ptPT17R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT17M_Click(sender As Object, e As EventArgs) Handles ptPT17M.Click
        If ptPT17M.BackColor = Color.White Then
            ptPT17M.BackColor = Color.Red
        ElseIf ptPT17M.BackColor = Color.Red Then
            ptPT17M.BackColor = Color.Blue
        Else
            ptPT17M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT16U_Click(sender As Object, e As EventArgs) Handles ptPT16U.Click
        If ptPT16U.BackColor = Color.White Then
            ptPT16U.BackColor = Color.Red
        ElseIf ptPT16U.BackColor = Color.Red Then
            ptPT16U.BackColor = Color.Blue
        Else
            ptPT16U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT16L_Click(sender As Object, e As EventArgs) Handles ptPT16L.Click
        If ptPT16L.BackColor = Color.White Then
            ptPT16L.BackColor = Color.Red
        ElseIf ptPT16L.BackColor = Color.Red Then
            ptPT16L.BackColor = Color.Blue
        Else
            ptPT16L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT16D_Click(sender As Object, e As EventArgs) Handles ptPT16D.Click
        If ptPT16D.BackColor = Color.White Then
            ptPT16D.BackColor = Color.Red
        ElseIf ptPT16D.BackColor = Color.Red Then
            ptPT16D.BackColor = Color.Blue
        Else
            ptPT16D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT16R_Click(sender As Object, e As EventArgs) Handles ptPT16R.Click
        If ptPT16R.BackColor = Color.White Then
            ptPT16R.BackColor = Color.Red
        ElseIf ptPT16R.BackColor = Color.Red Then
            ptPT16R.BackColor = Color.Blue
        Else
            ptPT16R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT16M_Click(sender As Object, e As EventArgs) Handles ptPT16M.Click
        If ptPT16M.BackColor = Color.White Then
            ptPT16M.BackColor = Color.Red
        ElseIf ptPT16M.BackColor = Color.Red Then
            ptPT16M.BackColor = Color.Blue
        Else
            ptPT16M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT15U_Click(sender As Object, e As EventArgs) Handles ptPT15U.Click
        If ptPT15U.BackColor = Color.White Then
            ptPT15U.BackColor = Color.Red
        ElseIf ptPT15U.BackColor = Color.Red Then
            ptPT15U.BackColor = Color.Blue
        Else
            ptPT15U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT15L_Click(sender As Object, e As EventArgs) Handles ptPT15L.Click
        If ptPT15L.BackColor = Color.White Then
            ptPT15L.BackColor = Color.Red
        ElseIf ptPT15L.BackColor = Color.Red Then
            ptPT15L.BackColor = Color.Blue
        Else
            ptPT15L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT15D_Click(sender As Object, e As EventArgs) Handles ptPT15D.Click
        If ptPT15D.BackColor = Color.White Then
            ptPT15D.BackColor = Color.Red
        ElseIf ptPT15D.BackColor = Color.Red Then
            ptPT15D.BackColor = Color.Blue
        Else
            ptPT15D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT15R_Click(sender As Object, e As EventArgs) Handles ptPT15R.Click
        If ptPT15R.BackColor = Color.White Then
            ptPT15R.BackColor = Color.Red
        ElseIf ptPT15R.BackColor = Color.Red Then
            ptPT15R.BackColor = Color.Blue
        Else
            ptPT15R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT15M_Click(sender As Object, e As EventArgs) Handles ptPT15M.Click
        If ptPT15M.BackColor = Color.White Then
            ptPT15M.BackColor = Color.Red
        ElseIf ptPT15M.BackColor = Color.Red Then
            ptPT15M.BackColor = Color.Blue
        Else
            ptPT15M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT14U_Click(sender As Object, e As EventArgs) Handles ptPT14U.Click
        If ptPT14U.BackColor = Color.White Then
            ptPT14U.BackColor = Color.Red
        ElseIf ptPT14U.BackColor = Color.Red Then
            ptPT14U.BackColor = Color.Blue
        Else
            ptPT14U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT14L_Click(sender As Object, e As EventArgs) Handles ptPT14L.Click
        If ptPT14L.BackColor = Color.White Then
            ptPT14L.BackColor = Color.Red
        ElseIf ptPT14L.BackColor = Color.Red Then
            ptPT14L.BackColor = Color.Blue
        Else
            ptPT14L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT14D_Click(sender As Object, e As EventArgs) Handles ptPT14D.Click
        If ptPT14D.BackColor = Color.White Then
            ptPT14D.BackColor = Color.Red
        ElseIf ptPT14D.BackColor = Color.Red Then
            ptPT14D.BackColor = Color.Blue
        Else
            ptPT14D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT14R_Click(sender As Object, e As EventArgs) Handles ptPT14R.Click
        If ptPT14R.BackColor = Color.White Then
            ptPT14R.BackColor = Color.Red
        ElseIf ptPT14R.BackColor = Color.Red Then
            ptPT14R.BackColor = Color.Blue
        Else
            ptPT14R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT14M_Click(sender As Object, e As EventArgs) Handles ptPT14M.Click
        If ptPT14M.BackColor = Color.White Then
            ptPT14M.BackColor = Color.Red
        ElseIf ptPT14M.BackColor = Color.Red Then
            ptPT14M.BackColor = Color.Blue
        Else
            ptPT14M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT13U_Click(sender As Object, e As EventArgs) Handles ptPT13U.Click
        If ptPT13U.BackColor = Color.White Then
            ptPT13U.BackColor = Color.Red
        ElseIf ptPT13U.BackColor = Color.Red Then
            ptPT13U.BackColor = Color.Blue
        Else
            ptPT13U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT13L_Click(sender As Object, e As EventArgs) Handles ptPT13L.Click
        If ptPT13L.BackColor = Color.White Then
            ptPT13L.BackColor = Color.Red
        ElseIf ptPT13L.BackColor = Color.Red Then
            ptPT13L.BackColor = Color.Blue
        Else
            ptPT13L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT13D_Click(sender As Object, e As EventArgs) Handles ptPT13D.Click
        If ptPT13D.BackColor = Color.White Then
            ptPT13D.BackColor = Color.Red
        ElseIf ptPT13D.BackColor = Color.Red Then
            ptPT13D.BackColor = Color.Blue
        Else
            ptPT13D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT13R_Click(sender As Object, e As EventArgs) Handles ptPT13R.Click
        If ptPT13R.BackColor = Color.White Then
            ptPT13R.BackColor = Color.Red
        ElseIf ptPT13R.BackColor = Color.Red Then
            ptPT13R.BackColor = Color.Blue
        Else
            ptPT13R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT13M_Click(sender As Object, e As EventArgs) Handles ptPT13M.Click
        If ptPT13M.BackColor = Color.White Then
            ptPT13M.BackColor = Color.Red
        ElseIf ptPT13M.BackColor = Color.Red Then
            ptPT13M.BackColor = Color.Blue
        Else
            ptPT13M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT12U_Click(sender As Object, e As EventArgs) Handles ptPT12U.Click
        If ptPT12U.BackColor = Color.White Then
            ptPT12U.BackColor = Color.Red
        ElseIf ptPT12U.BackColor = Color.Red Then
            ptPT12U.BackColor = Color.Blue
        Else
            ptPT12U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT12L_Click(sender As Object, e As EventArgs) Handles ptPT12L.Click
        If ptPT12L.BackColor = Color.White Then
            ptPT12L.BackColor = Color.Red
        ElseIf ptPT12L.BackColor = Color.Red Then
            ptPT12L.BackColor = Color.Blue
        Else
            ptPT12L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT12D_Click(sender As Object, e As EventArgs) Handles ptPT12D.Click
        If ptPT12D.BackColor = Color.White Then
            ptPT12D.BackColor = Color.Red
        ElseIf ptPT12D.BackColor = Color.Red Then
            ptPT12D.BackColor = Color.Blue
        Else
            ptPT12D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT12R_Click(sender As Object, e As EventArgs) Handles ptPT12R.Click
        If ptPT12R.BackColor = Color.White Then
            ptPT12R.BackColor = Color.Red
        ElseIf ptPT12R.BackColor = Color.Red Then
            ptPT12R.BackColor = Color.Blue
        Else
            ptPT12R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT12M_Click(sender As Object, e As EventArgs) Handles ptPT12M.Click
        If ptPT12M.BackColor = Color.White Then
            ptPT12M.BackColor = Color.Red
        ElseIf ptPT12M.BackColor = Color.Red Then
            ptPT12M.BackColor = Color.Blue
        Else
            ptPT12M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT11U_Click(sender As Object, e As EventArgs) Handles ptPT11U.Click
        If ptPT11U.BackColor = Color.White Then
            ptPT11U.BackColor = Color.Red
        ElseIf ptPT11U.BackColor = Color.Red Then
            ptPT11U.BackColor = Color.Blue
        Else
            ptPT11U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT11L_Click(sender As Object, e As EventArgs) Handles ptPT11L.Click
        If ptPT11L.BackColor = Color.White Then
            ptPT11L.BackColor = Color.Red
        ElseIf ptPT11L.BackColor = Color.Red Then
            ptPT11L.BackColor = Color.Blue
        Else
            ptPT11L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT11D_Click(sender As Object, e As EventArgs) Handles ptPT11D.Click
        If ptPT11D.BackColor = Color.White Then
            ptPT11D.BackColor = Color.Red
        ElseIf ptPT11D.BackColor = Color.Red Then
            ptPT11D.BackColor = Color.Blue
        Else
            ptPT11D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT11R_Click(sender As Object, e As EventArgs) Handles ptPT11R.Click
        If ptPT11R.BackColor = Color.White Then
            ptPT11R.BackColor = Color.Red
        ElseIf ptPT11R.BackColor = Color.Red Then
            ptPT11R.BackColor = Color.Blue
        Else
            ptPT11R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT11M_Click(sender As Object, e As EventArgs) Handles ptPT11M.Click
        If ptPT11M.BackColor = Color.White Then
            ptPT11M.BackColor = Color.Red
        ElseIf ptPT11M.BackColor = Color.Red Then
            ptPT11M.BackColor = Color.Blue
        Else
            ptPT11M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT21U_Click(sender As Object, e As EventArgs) Handles ptPT21U.Click
        If ptPT21U.BackColor = Color.White Then
            ptPT21U.BackColor = Color.Red
        ElseIf ptPT21U.BackColor = Color.Red Then
            ptPT21U.BackColor = Color.Blue
        Else
            ptPT21U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT21L_Click(sender As Object, e As EventArgs) Handles ptPT21L.Click
        If ptPT21L.BackColor = Color.White Then
            ptPT21L.BackColor = Color.Red
        ElseIf ptPT21L.BackColor = Color.Red Then
            ptPT21L.BackColor = Color.Blue
        Else
            ptPT21L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT21D_Click(sender As Object, e As EventArgs) Handles ptPT21D.Click
        If ptPT21D.BackColor = Color.White Then
            ptPT21D.BackColor = Color.Red
        ElseIf ptPT21D.BackColor = Color.Red Then
            ptPT21D.BackColor = Color.Blue
        Else
            ptPT21D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT21R_Click(sender As Object, e As EventArgs) Handles ptPT21R.Click
        If ptPT21R.BackColor = Color.White Then
            ptPT21R.BackColor = Color.Red
        ElseIf ptPT21R.BackColor = Color.Red Then
            ptPT21R.BackColor = Color.Blue
        Else
            ptPT21R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT21M_Click(sender As Object, e As EventArgs) Handles ptPT21M.Click
        If ptPT21M.BackColor = Color.White Then
            ptPT21M.BackColor = Color.Red
        ElseIf ptPT21M.BackColor = Color.Red Then
            ptPT21M.BackColor = Color.Blue
        Else
            ptPT21M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT22U_Click(sender As Object, e As EventArgs) Handles ptPT22U.Click
        If ptPT22U.BackColor = Color.White Then
            ptPT22U.BackColor = Color.Red
        ElseIf ptPT22U.BackColor = Color.Red Then
            ptPT22U.BackColor = Color.Blue
        Else
            ptPT22U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT22L_Click(sender As Object, e As EventArgs) Handles ptPT22L.Click
        If ptPT22L.BackColor = Color.White Then
            ptPT22L.BackColor = Color.Red
        ElseIf ptPT22L.BackColor = Color.Red Then
            ptPT22L.BackColor = Color.Blue
        Else
            ptPT22L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT22D_Click(sender As Object, e As EventArgs) Handles ptPT22D.Click
        If ptPT22D.BackColor = Color.White Then
            ptPT22D.BackColor = Color.Red
        ElseIf ptPT22D.BackColor = Color.Red Then
            ptPT22D.BackColor = Color.Blue
        Else
            ptPT22D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT22R_Click(sender As Object, e As EventArgs) Handles ptPT22R.Click
        If ptPT22R.BackColor = Color.White Then
            ptPT22R.BackColor = Color.Red
        ElseIf ptPT22R.BackColor = Color.Red Then
            ptPT22R.BackColor = Color.Blue
        Else
            ptPT22R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT22M_Click(sender As Object, e As EventArgs) Handles ptPT22M.Click
        If ptPT22M.BackColor = Color.White Then
            ptPT22M.BackColor = Color.Red
        ElseIf ptPT22M.BackColor = Color.Red Then
            ptPT22M.BackColor = Color.Blue
        Else
            ptPT22M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT23U_Click(sender As Object, e As EventArgs) Handles ptPT23U.Click
        If ptPT23U.BackColor = Color.White Then
            ptPT23U.BackColor = Color.Red
        ElseIf ptPT23U.BackColor = Color.Red Then
            ptPT23U.BackColor = Color.Blue
        Else
            ptPT23U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT23L_Click(sender As Object, e As EventArgs) Handles ptPT23L.Click
        If ptPT23L.BackColor = Color.White Then
            ptPT23L.BackColor = Color.Red
        ElseIf ptPT23L.BackColor = Color.Red Then
            ptPT23L.BackColor = Color.Blue
        Else
            ptPT23L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT23D_Click(sender As Object, e As EventArgs) Handles ptPT23D.Click
        If ptPT23D.BackColor = Color.White Then
            ptPT23D.BackColor = Color.Red
        ElseIf ptPT23D.BackColor = Color.Red Then
            ptPT23D.BackColor = Color.Blue
        Else
            ptPT23D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT23R_Click(sender As Object, e As EventArgs) Handles ptPT23R.Click
        If ptPT23R.BackColor = Color.White Then
            ptPT23R.BackColor = Color.Red
        ElseIf ptPT23R.BackColor = Color.Red Then
            ptPT23R.BackColor = Color.Blue
        Else
            ptPT23R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT23M_Click(sender As Object, e As EventArgs) Handles ptPT23M.Click
        If ptPT23M.BackColor = Color.White Then
            ptPT23M.BackColor = Color.Red
        ElseIf ptPT23M.BackColor = Color.Red Then
            ptPT23M.BackColor = Color.Blue
        Else
            ptPT23M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT24U_Click(sender As Object, e As EventArgs) Handles ptPT24U.Click
        If ptPT24U.BackColor = Color.White Then
            ptPT24U.BackColor = Color.Red
        ElseIf ptPT24U.BackColor = Color.Red Then
            ptPT24U.BackColor = Color.Blue
        Else
            ptPT24U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT24L_Click(sender As Object, e As EventArgs) Handles ptPT24L.Click
        If ptPT24L.BackColor = Color.White Then
            ptPT24L.BackColor = Color.Red
        ElseIf ptPT24L.BackColor = Color.Red Then
            ptPT24L.BackColor = Color.Blue
        Else
            ptPT24L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT24D_Click(sender As Object, e As EventArgs) Handles ptPT24D.Click
        If ptPT24D.BackColor = Color.White Then
            ptPT24D.BackColor = Color.Red
        ElseIf ptPT24D.BackColor = Color.Red Then
            ptPT24D.BackColor = Color.Blue
        Else
            ptPT24D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT24R_Click(sender As Object, e As EventArgs) Handles ptPT24R.Click
        If ptPT24R.BackColor = Color.White Then
            ptPT24R.BackColor = Color.Red
        ElseIf ptPT24R.BackColor = Color.Red Then
            ptPT24R.BackColor = Color.Blue
        Else
            ptPT24R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT24M_Click(sender As Object, e As EventArgs) Handles ptPT24M.Click
        If ptPT24M.BackColor = Color.White Then
            ptPT24M.BackColor = Color.Red
        ElseIf ptPT24M.BackColor = Color.Red Then
            ptPT24M.BackColor = Color.Blue
        Else
            ptPT24M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT25U_Click(sender As Object, e As EventArgs) Handles ptPT25U.Click
        If ptPT25U.BackColor = Color.White Then
            ptPT25U.BackColor = Color.Red
        ElseIf ptPT25U.BackColor = Color.Red Then
            ptPT25U.BackColor = Color.Blue
        Else
            ptPT25U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT25L_Click(sender As Object, e As EventArgs) Handles ptPT25L.Click
        If ptPT25L.BackColor = Color.White Then
            ptPT25L.BackColor = Color.Red
        ElseIf ptPT25L.BackColor = Color.Red Then
            ptPT25L.BackColor = Color.Blue
        Else
            ptPT25L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT25D_Click(sender As Object, e As EventArgs) Handles ptPT25D.Click
        If ptPT25D.BackColor = Color.White Then
            ptPT25D.BackColor = Color.Red
        ElseIf ptPT25D.BackColor = Color.Red Then
            ptPT25D.BackColor = Color.Blue
        Else
            ptPT25D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT25R_Click(sender As Object, e As EventArgs) Handles ptPT25R.Click
        If ptPT25R.BackColor = Color.White Then
            ptPT25R.BackColor = Color.Red
        ElseIf ptPT25R.BackColor = Color.Red Then
            ptPT25R.BackColor = Color.Blue
        Else
            ptPT25R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT25M_Click(sender As Object, e As EventArgs) Handles ptPT25M.Click
        If ptPT25M.BackColor = Color.White Then
            ptPT25M.BackColor = Color.Red
        ElseIf ptPT25M.BackColor = Color.Red Then
            ptPT25M.BackColor = Color.Blue
        Else
            ptPT25M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT26U_Click(sender As Object, e As EventArgs) Handles ptPT26U.Click
        If ptPT26U.BackColor = Color.White Then
            ptPT26U.BackColor = Color.Red
        ElseIf ptPT26U.BackColor = Color.Red Then
            ptPT26U.BackColor = Color.Blue
        Else
            ptPT26U.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox112_Click(sender As Object, e As EventArgs) Handles PictureBox112.Click
        If PictureBox112.BackColor = Color.White Then
            PictureBox112.BackColor = Color.Red
        ElseIf PictureBox112.BackColor = Color.Red Then
            PictureBox112.BackColor = Color.Blue
        Else
            PictureBox112.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT26D_Click(sender As Object, e As EventArgs) Handles ptPT26D.Click
        If ptPT26D.BackColor = Color.White Then
            ptPT26D.BackColor = Color.Red
        ElseIf ptPT26D.BackColor = Color.Red Then
            ptPT26D.BackColor = Color.Blue
        Else
            ptPT26D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT26L_Click(sender As Object, e As EventArgs) Handles ptPT26L.Click
        If ptPT26L.BackColor = Color.White Then
            ptPT26L.BackColor = Color.Red
        ElseIf ptPT26L.BackColor = Color.Red Then
            ptPT26L.BackColor = Color.Blue
        Else
            ptPT26L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT26M_Click(sender As Object, e As EventArgs) Handles ptPT26M.Click
        If ptPT26M.BackColor = Color.White Then
            ptPT26M.BackColor = Color.Red
        ElseIf ptPT26M.BackColor = Color.Red Then
            ptPT26M.BackColor = Color.Blue
        Else
            ptPT26M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT27U_Click(sender As Object, e As EventArgs) Handles ptPT27U.Click
        If ptPT27U.BackColor = Color.White Then
            ptPT27U.BackColor = Color.Red
        ElseIf ptPT27U.BackColor = Color.Red Then
            ptPT27U.BackColor = Color.Blue
        Else
            ptPT27U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT27L_Click(sender As Object, e As EventArgs) Handles ptPT27L.Click
        If ptPT27L.BackColor = Color.White Then
            ptPT27L.BackColor = Color.Red
        ElseIf ptPT27L.BackColor = Color.Red Then
            ptPT27L.BackColor = Color.Blue
        Else
            ptPT27L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT27D_Click(sender As Object, e As EventArgs) Handles ptPT27D.Click
        If ptPT27D.BackColor = Color.White Then
            ptPT27D.BackColor = Color.Red
        ElseIf ptPT27D.BackColor = Color.Red Then
            ptPT27D.BackColor = Color.Blue
        Else
            ptPT27D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT27R_Click(sender As Object, e As EventArgs) Handles ptPT27R.Click
        If ptPT27R.BackColor = Color.White Then
            ptPT27R.BackColor = Color.Red
        ElseIf ptPT27R.BackColor = Color.Red Then
            ptPT27R.BackColor = Color.Blue
        Else
            ptPT27R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT27M_Click(sender As Object, e As EventArgs) Handles ptPT27M.Click
        If ptPT27M.BackColor = Color.White Then
            ptPT27M.BackColor = Color.Red
        ElseIf ptPT27M.BackColor = Color.Red Then
            ptPT27M.BackColor = Color.Blue
        Else
            ptPT27M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT28U_Click(sender As Object, e As EventArgs) Handles ptPT28U.Click
        If ptPT28U.BackColor = Color.White Then
            ptPT28U.BackColor = Color.Red
        ElseIf ptPT28U.BackColor = Color.Red Then
            ptPT28U.BackColor = Color.Blue
        Else
            ptPT28U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT28L_Click(sender As Object, e As EventArgs) Handles ptPT28L.Click
        If ptPT28L.BackColor = Color.White Then
            ptPT28L.BackColor = Color.Red
        ElseIf ptPT28L.BackColor = Color.Red Then
            ptPT28L.BackColor = Color.Blue
        Else
            ptPT28L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT28D_Click(sender As Object, e As EventArgs) Handles ptPT28D.Click
        If ptPT28D.BackColor = Color.White Then
            ptPT28D.BackColor = Color.Red
        ElseIf ptPT28D.BackColor = Color.Red Then
            ptPT28D.BackColor = Color.Blue
        Else
            ptPT28D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT28R_Click(sender As Object, e As EventArgs) Handles ptPT28R.Click
        If ptPT28R.BackColor = Color.White Then
            ptPT28R.BackColor = Color.Red
        ElseIf ptPT28R.BackColor = Color.Red Then
            ptPT28R.BackColor = Color.Blue
        Else
            ptPT28R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT28M_Click(sender As Object, e As EventArgs) Handles ptPT28M.Click
        If ptPT28M.BackColor = Color.White Then
            ptPT28M.BackColor = Color.Red
        ElseIf ptPT28M.BackColor = Color.Red Then
            ptPT28M.BackColor = Color.Blue
        Else
            ptPT28M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT48U_Click(sender As Object, e As EventArgs) Handles ptPT48U.Click
        If ptPT48U.BackColor = Color.White Then
            ptPT48U.BackColor = Color.Red
        ElseIf ptPT48U.BackColor = Color.Red Then
            ptPT48U.BackColor = Color.Blue
        Else
            ptPT48U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT48L_Click(sender As Object, e As EventArgs) Handles ptPT48L.Click
        If ptPT48L.BackColor = Color.White Then
            ptPT48L.BackColor = Color.Red
        ElseIf ptPT48L.BackColor = Color.Red Then
            ptPT48L.BackColor = Color.Blue
        Else
            ptPT48L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT48D_Click(sender As Object, e As EventArgs) Handles ptPT48D.Click
        If ptPT48D.BackColor = Color.White Then
            ptPT48D.BackColor = Color.Red
        ElseIf ptPT48D.BackColor = Color.Red Then
            ptPT48D.BackColor = Color.Blue
        Else
            ptPT48D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT48R_Click(sender As Object, e As EventArgs) Handles ptPT48R.Click
        If ptPT48R.BackColor = Color.White Then
            ptPT48R.BackColor = Color.Red
        ElseIf ptPT48R.BackColor = Color.Red Then
            ptPT48R.BackColor = Color.Blue
        Else
            ptPT48R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT48M_Click(sender As Object, e As EventArgs) Handles ptPT48M.Click
        If ptPT48M.BackColor = Color.White Then
            ptPT48M.BackColor = Color.Red
        ElseIf ptPT48M.BackColor = Color.Red Then
            ptPT48M.BackColor = Color.Blue
        Else
            ptPT48M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT47U_Click(sender As Object, e As EventArgs) Handles ptPT47U.Click
        If ptPT47U.BackColor = Color.White Then
            ptPT47U.BackColor = Color.Red
        ElseIf ptPT47U.BackColor = Color.Red Then
            ptPT47U.BackColor = Color.Blue
        Else
            ptPT47U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT47L_Click(sender As Object, e As EventArgs) Handles ptPT47L.Click
        If ptPT47L.BackColor = Color.White Then
            ptPT47L.BackColor = Color.Red
        ElseIf ptPT47L.BackColor = Color.Red Then
            ptPT47L.BackColor = Color.Blue
        Else
            ptPT47L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT47D_Click(sender As Object, e As EventArgs) Handles ptPT47D.Click
        If ptPT47D.BackColor = Color.White Then
            ptPT47D.BackColor = Color.Red
        ElseIf ptPT47D.BackColor = Color.Red Then
            ptPT47D.BackColor = Color.Blue
        Else
            ptPT47D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT47R_Click(sender As Object, e As EventArgs) Handles ptPT47R.Click
        If ptPT47R.BackColor = Color.White Then
            ptPT47R.BackColor = Color.Red
        ElseIf ptPT47R.BackColor = Color.Red Then
            ptPT47R.BackColor = Color.Blue
        Else
            ptPT47R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT47M_Click(sender As Object, e As EventArgs) Handles ptPT47M.Click
        If ptPT47M.BackColor = Color.White Then
            ptPT47M.BackColor = Color.Red
        ElseIf ptPT47M.BackColor = Color.Red Then
            ptPT47M.BackColor = Color.Blue
        Else
            ptPT47M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT46U_Click(sender As Object, e As EventArgs) Handles ptPT46U.Click
        If ptPT46U.BackColor = Color.White Then
            ptPT46U.BackColor = Color.Red
        ElseIf ptPT46U.BackColor = Color.Red Then
            ptPT46U.BackColor = Color.Blue
        Else
            ptPT46U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT46L_Click(sender As Object, e As EventArgs) Handles ptPT46L.Click
        If ptPT46L.BackColor = Color.White Then
            ptPT46L.BackColor = Color.Red
        ElseIf ptPT46L.BackColor = Color.Red Then
            ptPT46L.BackColor = Color.Blue
        Else
            ptPT46L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT46D_Click(sender As Object, e As EventArgs) Handles ptPT46D.Click
        If ptPT46D.BackColor = Color.White Then
            ptPT46D.BackColor = Color.Red
        ElseIf ptPT46D.BackColor = Color.Red Then
            ptPT46D.BackColor = Color.Blue
        Else
            ptPT46D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT46R_Click(sender As Object, e As EventArgs) Handles ptPT46R.Click
        If ptPT46R.BackColor = Color.White Then
            ptPT46R.BackColor = Color.Red
        ElseIf ptPT46R.BackColor = Color.Red Then
            ptPT46R.BackColor = Color.Blue
        Else
            ptPT46R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT46M_Click(sender As Object, e As EventArgs) Handles ptPT46M.Click
        If ptPT46M.BackColor = Color.White Then
            ptPT46M.BackColor = Color.Red
        ElseIf ptPT46M.BackColor = Color.Red Then
            ptPT46M.BackColor = Color.Blue
        Else
            ptPT46M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT45U_Click(sender As Object, e As EventArgs) Handles ptPT45U.Click
        If ptPT45U.BackColor = Color.White Then
            ptPT45U.BackColor = Color.Red
        ElseIf ptPT45U.BackColor = Color.Red Then
            ptPT45U.BackColor = Color.Blue
        Else
            ptPT45U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT45L_Click(sender As Object, e As EventArgs) Handles ptPT45L.Click
        If ptPT45L.BackColor = Color.White Then
            ptPT45L.BackColor = Color.Red
        ElseIf ptPT45L.BackColor = Color.Red Then
            ptPT45L.BackColor = Color.Blue
        Else
            ptPT45L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT45D_Click(sender As Object, e As EventArgs) Handles ptPT45D.Click
        If ptPT45D.BackColor = Color.White Then
            ptPT45D.BackColor = Color.Red
        ElseIf ptPT45D.BackColor = Color.Red Then
            ptPT45D.BackColor = Color.Blue
        Else
            ptPT45D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT45R_Click(sender As Object, e As EventArgs) Handles ptPT45R.Click
        If ptPT45R.BackColor = Color.White Then
            ptPT45R.BackColor = Color.Red
        ElseIf ptPT45R.BackColor = Color.Red Then
            ptPT45R.BackColor = Color.Blue
        Else
            ptPT45R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT45M_Click(sender As Object, e As EventArgs) Handles ptPT45M.Click
        If ptPT45M.BackColor = Color.White Then
            ptPT45M.BackColor = Color.Red
        ElseIf ptPT45M.BackColor = Color.Red Then
            ptPT45M.BackColor = Color.Blue
        Else
            ptPT45M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT44U_Click(sender As Object, e As EventArgs) Handles ptPT44U.Click
        If ptPT44U.BackColor = Color.White Then
            ptPT44U.BackColor = Color.Red
        ElseIf ptPT44U.BackColor = Color.Red Then
            ptPT44U.BackColor = Color.Blue
        Else
            ptPT44U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT44L_Click(sender As Object, e As EventArgs) Handles ptPT44L.Click
        If ptPT44L.BackColor = Color.White Then
            ptPT44L.BackColor = Color.Red
        ElseIf ptPT44L.BackColor = Color.Red Then
            ptPT44L.BackColor = Color.Blue
        Else
            ptPT44L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT44D_Click(sender As Object, e As EventArgs) Handles ptPT44D.Click
        If ptPT44D.BackColor = Color.White Then
            ptPT44D.BackColor = Color.Red
        ElseIf ptPT44D.BackColor = Color.Red Then
            ptPT44D.BackColor = Color.Blue
        Else
            ptPT44D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT44R_Click(sender As Object, e As EventArgs) Handles ptPT44R.Click
        If ptPT44R.BackColor = Color.White Then
            ptPT44R.BackColor = Color.Red
        ElseIf ptPT44R.BackColor = Color.Red Then
            ptPT44R.BackColor = Color.Blue
        Else
            ptPT44R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT44M_Click(sender As Object, e As EventArgs) Handles ptPT44M.Click
        If ptPT44M.BackColor = Color.White Then
            ptPT44M.BackColor = Color.Red
        ElseIf ptPT44M.BackColor = Color.Red Then
            ptPT44M.BackColor = Color.Blue
        Else
            ptPT44M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT43U_Click(sender As Object, e As EventArgs) Handles ptPT43U.Click
        If ptPT43U.BackColor = Color.White Then
            ptPT43U.BackColor = Color.Red
        ElseIf ptPT43U.BackColor = Color.Red Then
            ptPT43U.BackColor = Color.Blue
        Else
            ptPT43U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT43L_Click(sender As Object, e As EventArgs) Handles ptPT43L.Click
        If ptPT43L.BackColor = Color.White Then
            ptPT43L.BackColor = Color.Red
        ElseIf ptPT43L.BackColor = Color.Red Then
            ptPT43L.BackColor = Color.Blue
        Else
            ptPT43L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT43D_Click(sender As Object, e As EventArgs) Handles ptPT43D.Click
        If ptPT43D.BackColor = Color.White Then
            ptPT43D.BackColor = Color.Red
        ElseIf ptPT43D.BackColor = Color.Red Then
            ptPT43D.BackColor = Color.Blue
        Else
            ptPT43D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT43R_Click(sender As Object, e As EventArgs) Handles ptPT43R.Click
        If ptPT43R.BackColor = Color.White Then
            ptPT43R.BackColor = Color.Red
        ElseIf ptPT43R.BackColor = Color.Red Then
            ptPT43R.BackColor = Color.Blue
        Else
            ptPT43R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT43M_Click(sender As Object, e As EventArgs) Handles ptPT43M.Click
        If ptPT43M.BackColor = Color.White Then
            ptPT43M.BackColor = Color.Red
        ElseIf ptPT43M.BackColor = Color.Red Then
            ptPT43M.BackColor = Color.Blue
        Else
            ptPT43M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT42U_Click(sender As Object, e As EventArgs) Handles ptPT42U.Click
        If ptPT42U.BackColor = Color.White Then
            ptPT42U.BackColor = Color.Red
        ElseIf ptPT42U.BackColor = Color.Red Then
            ptPT42U.BackColor = Color.Blue
        Else
            ptPT42U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT42L_Click(sender As Object, e As EventArgs) Handles ptPT42L.Click
        If ptPT42L.BackColor = Color.White Then
            ptPT42L.BackColor = Color.Red
        ElseIf ptPT42L.BackColor = Color.Red Then
            ptPT42L.BackColor = Color.Blue
        Else
            ptPT42L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT42D_Click(sender As Object, e As EventArgs) Handles ptPT42D.Click
        If ptPT42D.BackColor = Color.White Then
            ptPT42D.BackColor = Color.Red
        ElseIf ptPT42D.BackColor = Color.Red Then
            ptPT42D.BackColor = Color.Blue
        Else
            ptPT42D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT42R_Click(sender As Object, e As EventArgs) Handles ptPT42R.Click
        If ptPT42R.BackColor = Color.White Then
            ptPT42R.BackColor = Color.Red
        ElseIf ptPT42R.BackColor = Color.Red Then
            ptPT42R.BackColor = Color.Blue
        Else
            ptPT42R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT42M_Click(sender As Object, e As EventArgs) Handles ptPT42M.Click
        If ptPT42M.BackColor = Color.White Then
            ptPT42M.BackColor = Color.Red
        ElseIf ptPT42M.BackColor = Color.Red Then
            ptPT42M.BackColor = Color.Blue
        Else
            ptPT42M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT41U_Click(sender As Object, e As EventArgs) Handles ptPT41U.Click
        If ptPT41U.BackColor = Color.White Then
            ptPT41U.BackColor = Color.Red
        ElseIf ptPT41U.BackColor = Color.Red Then
            ptPT41U.BackColor = Color.Blue
        Else
            ptPT41U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT41L_Click(sender As Object, e As EventArgs) Handles ptPT41L.Click
        If ptPT41L.BackColor = Color.White Then
            ptPT41L.BackColor = Color.Red
        ElseIf ptPT41L.BackColor = Color.Red Then
            ptPT41L.BackColor = Color.Blue
        Else
            ptPT41L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT41D_Click(sender As Object, e As EventArgs) Handles ptPT41D.Click
        If ptPT41D.BackColor = Color.White Then
            ptPT41D.BackColor = Color.Red
        ElseIf ptPT41D.BackColor = Color.Red Then
            ptPT41D.BackColor = Color.Blue
        Else
            ptPT41D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT41R_Click(sender As Object, e As EventArgs) Handles ptPT41R.Click
        If ptPT41R.BackColor = Color.White Then
            ptPT41R.BackColor = Color.Red
        ElseIf ptPT41R.BackColor = Color.Red Then
            ptPT41R.BackColor = Color.Blue
        Else
            ptPT41R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT41M_Click(sender As Object, e As EventArgs) Handles ptPT41M.Click
        If ptPT41M.BackColor = Color.White Then
            ptPT41M.BackColor = Color.Red
        ElseIf ptPT41M.BackColor = Color.Red Then
            ptPT41M.BackColor = Color.Blue
        Else
            ptPT41M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT31U_Click(sender As Object, e As EventArgs) Handles ptPT31U.Click
        If ptPT31U.BackColor = Color.White Then
            ptPT31U.BackColor = Color.Red
        ElseIf ptPT31U.BackColor = Color.Red Then
            ptPT31U.BackColor = Color.Blue
        Else
            ptPT31U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT31L_Click(sender As Object, e As EventArgs) Handles ptPT31L.Click
        If ptPT31L.BackColor = Color.White Then
            ptPT31L.BackColor = Color.Red
        ElseIf ptPT31L.BackColor = Color.Red Then
            ptPT31L.BackColor = Color.Blue
        Else
            ptPT31L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT31D_Click(sender As Object, e As EventArgs) Handles ptPT31D.Click
        If ptPT31D.BackColor = Color.White Then
            ptPT31D.BackColor = Color.Red
        ElseIf ptPT31D.BackColor = Color.Red Then
            ptPT31D.BackColor = Color.Blue
        Else
            ptPT31D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT31R_Click(sender As Object, e As EventArgs) Handles ptPT31R.Click
        If ptPT31R.BackColor = Color.White Then
            ptPT31R.BackColor = Color.Red
        ElseIf ptPT31R.BackColor = Color.Red Then
            ptPT31R.BackColor = Color.Blue
        Else
            ptPT31R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT31M_Click(sender As Object, e As EventArgs) Handles ptPT31M.Click
        If ptPT31M.BackColor = Color.White Then
            ptPT31M.BackColor = Color.Red
        ElseIf ptPT31M.BackColor = Color.Red Then
            ptPT31M.BackColor = Color.Blue
        Else
            ptPT31M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT32U_Click(sender As Object, e As EventArgs) Handles ptPT32U.Click
        If ptPT32U.BackColor = Color.White Then
            ptPT32U.BackColor = Color.Red
        ElseIf ptPT32U.BackColor = Color.Red Then
            ptPT32U.BackColor = Color.Blue
        Else
            ptPT32U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT32L_Click(sender As Object, e As EventArgs) Handles ptPT32L.Click
        If ptPT32L.BackColor = Color.White Then
            ptPT32L.BackColor = Color.Red
        ElseIf ptPT32L.BackColor = Color.Red Then
            ptPT32L.BackColor = Color.Blue
        Else
            ptPT32L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT32D_Click(sender As Object, e As EventArgs) Handles ptPT32D.Click
        If ptPT32D.BackColor = Color.White Then
            ptPT32D.BackColor = Color.Red
        ElseIf ptPT32D.BackColor = Color.Red Then
            ptPT32D.BackColor = Color.Blue
        Else
            ptPT32D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT32R_Click(sender As Object, e As EventArgs) Handles ptPT32R.Click
        If ptPT32R.BackColor = Color.White Then
            ptPT32R.BackColor = Color.Red
        ElseIf ptPT32R.BackColor = Color.Red Then
            ptPT32R.BackColor = Color.Blue
        Else
            ptPT32R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT32M_Click(sender As Object, e As EventArgs) Handles ptPT32M.Click
        If ptPT32M.BackColor = Color.White Then
            ptPT32M.BackColor = Color.Red
        ElseIf ptPT32M.BackColor = Color.Red Then
            ptPT32M.BackColor = Color.Blue
        Else
            ptPT32M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT33U_Click(sender As Object, e As EventArgs) Handles ptPT33U.Click
        If ptPT33U.BackColor = Color.White Then
            ptPT33U.BackColor = Color.Red
        ElseIf ptPT33U.BackColor = Color.Red Then
            ptPT33U.BackColor = Color.Blue
        Else
            ptPT33U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT33L_Click(sender As Object, e As EventArgs) Handles ptPT33L.Click
        If ptPT33L.BackColor = Color.White Then
            ptPT33L.BackColor = Color.Red
        ElseIf ptPT33L.BackColor = Color.Red Then
            ptPT33L.BackColor = Color.Blue
        Else
            ptPT33L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT33D_Click(sender As Object, e As EventArgs) Handles ptPT33D.Click
        If ptPT33D.BackColor = Color.White Then
            ptPT33D.BackColor = Color.Red
        ElseIf ptPT33D.BackColor = Color.Red Then
            ptPT33D.BackColor = Color.Blue
        Else
            ptPT33D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT33R_Click(sender As Object, e As EventArgs) Handles ptPT33R.Click
        If ptPT33R.BackColor = Color.White Then
            ptPT33R.BackColor = Color.Red
        ElseIf ptPT33R.BackColor = Color.Red Then
            ptPT33R.BackColor = Color.Blue
        Else
            ptPT33R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT33M_Click(sender As Object, e As EventArgs) Handles ptPT33M.Click
        If ptPT33M.BackColor = Color.White Then
            ptPT33M.BackColor = Color.Red
        ElseIf ptPT33M.BackColor = Color.Red Then
            ptPT33M.BackColor = Color.Blue
        Else
            ptPT33M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT34U_Click(sender As Object, e As EventArgs) Handles ptPT34U.Click
        If ptPT34U.BackColor = Color.White Then
            ptPT34U.BackColor = Color.Red
        ElseIf ptPT34U.BackColor = Color.Red Then
            ptPT34U.BackColor = Color.Blue
        Else
            ptPT34U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT34L_Click(sender As Object, e As EventArgs) Handles ptPT34L.Click
        If ptPT34L.BackColor = Color.White Then
            ptPT34L.BackColor = Color.Red
        ElseIf ptPT34L.BackColor = Color.Red Then
            ptPT34L.BackColor = Color.Blue
        Else
            ptPT34L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT34D_Click(sender As Object, e As EventArgs) Handles ptPT34D.Click
        If ptPT34D.BackColor = Color.White Then
            ptPT34D.BackColor = Color.Red
        ElseIf ptPT34D.BackColor = Color.Red Then
            ptPT34D.BackColor = Color.Blue
        Else
            ptPT34D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT34R_Click(sender As Object, e As EventArgs) Handles ptPT34R.Click
        If ptPT34R.BackColor = Color.White Then
            ptPT34R.BackColor = Color.Red
        ElseIf ptPT34R.BackColor = Color.Red Then
            ptPT34R.BackColor = Color.Blue
        Else
            ptPT34R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT34M_Click(sender As Object, e As EventArgs) Handles ptPT34M.Click
        If ptPT34M.BackColor = Color.White Then
            ptPT34M.BackColor = Color.Red
        ElseIf ptPT34M.BackColor = Color.Red Then
            ptPT34M.BackColor = Color.Blue
        Else
            ptPT34M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT35U_Click(sender As Object, e As EventArgs) Handles ptPT35U.Click
        If ptPT35U.BackColor = Color.White Then
            ptPT35U.BackColor = Color.Red
        ElseIf ptPT35U.BackColor = Color.Red Then
            ptPT35U.BackColor = Color.Blue
        Else
            ptPT35U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT35L_Click(sender As Object, e As EventArgs) Handles ptPT35L.Click
        If ptPT35L.BackColor = Color.White Then
            ptPT35L.BackColor = Color.Red
        ElseIf ptPT35L.BackColor = Color.Red Then
            ptPT35L.BackColor = Color.Blue
        Else
            ptPT35L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT35D_Click(sender As Object, e As EventArgs) Handles ptPT35D.Click
        If ptPT35D.BackColor = Color.White Then
            ptPT35D.BackColor = Color.Red
        ElseIf ptPT35D.BackColor = Color.Red Then
            ptPT35D.BackColor = Color.Blue
        Else
            ptPT35D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT35R_Click(sender As Object, e As EventArgs) Handles ptPT35R.Click
        If ptPT35R.BackColor = Color.White Then
            ptPT35R.BackColor = Color.Red
        ElseIf ptPT35R.BackColor = Color.Red Then
            ptPT35R.BackColor = Color.Blue
        Else
            ptPT35R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT35M_Click(sender As Object, e As EventArgs) Handles ptPT35M.Click
        If ptPT35M.BackColor = Color.White Then
            ptPT35M.BackColor = Color.Red
        ElseIf ptPT35M.BackColor = Color.Red Then
            ptPT35M.BackColor = Color.Blue
        Else
            ptPT35M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT36U_Click(sender As Object, e As EventArgs) Handles ptPT36U.Click
        If ptPT36U.BackColor = Color.White Then
            ptPT36U.BackColor = Color.Red
        ElseIf ptPT36U.BackColor = Color.Red Then
            ptPT36U.BackColor = Color.Blue
        Else
            ptPT36U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT36L_Click(sender As Object, e As EventArgs) Handles ptPT36L.Click
        If ptPT36L.BackColor = Color.White Then
            ptPT36L.BackColor = Color.Red
        ElseIf ptPT36L.BackColor = Color.Red Then
            ptPT36L.BackColor = Color.Blue
        Else
            ptPT36L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT36D_Click(sender As Object, e As EventArgs) Handles ptPT36D.Click
        If ptPT36D.BackColor = Color.White Then
            ptPT36D.BackColor = Color.Red
        ElseIf ptPT36D.BackColor = Color.Red Then
            ptPT36D.BackColor = Color.Blue
        Else
            ptPT36D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT36R_Click(sender As Object, e As EventArgs) Handles ptPT36R.Click
        If ptPT36R.BackColor = Color.White Then
            ptPT36R.BackColor = Color.Red
        ElseIf ptPT36R.BackColor = Color.Red Then
            ptPT36R.BackColor = Color.Blue
        Else
            ptPT36R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT36M_Click(sender As Object, e As EventArgs) Handles ptPT36M.Click
        If ptPT36M.BackColor = Color.White Then
            ptPT36M.BackColor = Color.Red
        ElseIf ptPT36M.BackColor = Color.Red Then
            ptPT36M.BackColor = Color.Blue
        Else
            ptPT36M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT37U_Click(sender As Object, e As EventArgs) Handles ptPT37U.Click
        If ptPT37U.BackColor = Color.White Then
            ptPT37U.BackColor = Color.Red
        ElseIf ptPT37U.BackColor = Color.Red Then
            ptPT37U.BackColor = Color.Blue
        Else
            ptPT37U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT37L_Click(sender As Object, e As EventArgs) Handles ptPT37L.Click
        If ptPT37L.BackColor = Color.White Then
            ptPT37L.BackColor = Color.Red
        ElseIf ptPT37L.BackColor = Color.Red Then
            ptPT37L.BackColor = Color.Blue
        Else
            ptPT37L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT37D_Click(sender As Object, e As EventArgs) Handles ptPT37D.Click
        If ptPT37D.BackColor = Color.White Then
            ptPT37D.BackColor = Color.Red
        ElseIf ptPT37D.BackColor = Color.Red Then
            ptPT37D.BackColor = Color.Blue
        Else
            ptPT37D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT37R_Click(sender As Object, e As EventArgs) Handles ptPT37R.Click
        If ptPT37R.BackColor = Color.White Then
            ptPT37R.BackColor = Color.Red
        ElseIf ptPT37R.BackColor = Color.Red Then
            ptPT37R.BackColor = Color.Blue
        Else
            ptPT37R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT37M_Click(sender As Object, e As EventArgs) Handles ptPT37M.Click
        If ptPT37M.BackColor = Color.White Then
            ptPT37M.BackColor = Color.Red
        ElseIf ptPT37M.BackColor = Color.Red Then
            ptPT37M.BackColor = Color.Blue
        Else
            ptPT37M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT38U_Click(sender As Object, e As EventArgs) Handles ptPT38U.Click
        If ptPT38U.BackColor = Color.White Then
            ptPT38U.BackColor = Color.Red
        ElseIf ptPT38U.BackColor = Color.Red Then
            ptPT38U.BackColor = Color.Blue
        Else
            ptPT38U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT38L_Click(sender As Object, e As EventArgs) Handles ptPT38L.Click
        If ptPT38L.BackColor = Color.White Then
            ptPT38L.BackColor = Color.Red
        ElseIf ptPT38L.BackColor = Color.Red Then
            ptPT38L.BackColor = Color.Blue
        Else
            ptPT38L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT38D_Click(sender As Object, e As EventArgs) Handles ptPT38D.Click
        If ptPT38D.BackColor = Color.White Then
            ptPT38D.BackColor = Color.Red
        ElseIf ptPT38D.BackColor = Color.Red Then
            ptPT38D.BackColor = Color.Blue
        Else
            ptPT38D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT38R_Click(sender As Object, e As EventArgs) Handles ptPT38R.Click
        If ptPT38R.BackColor = Color.White Then
            ptPT38R.BackColor = Color.Red
        ElseIf ptPT38R.BackColor = Color.Red Then
            ptPT38R.BackColor = Color.Blue
        Else
            ptPT38R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptPT38M_Click(sender As Object, e As EventArgs) Handles ptPT38M.Click
        If ptPT38M.BackColor = Color.White Then
            ptPT38M.BackColor = Color.Red
        ElseIf ptPT38M.BackColor = Color.Red Then
            ptPT38M.BackColor = Color.Blue
        Else
            ptPT38M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT85U_Click(sender As Object, e As EventArgs) Handles ptTT85U.Click
        If ptTT85U.BackColor = Color.White Then
            ptTT85U.BackColor = Color.Red
        ElseIf ptTT85U.BackColor = Color.Red Then
            ptTT85U.BackColor = Color.Blue
        Else
            ptTT85U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT85L_Click(sender As Object, e As EventArgs) Handles ptTT85L.Click
        If ptTT85L.BackColor = Color.White Then
            ptTT85L.BackColor = Color.Red
        ElseIf ptTT85L.BackColor = Color.Red Then
            ptTT85L.BackColor = Color.Blue
        Else
            ptTT85L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT85D_Click(sender As Object, e As EventArgs) Handles ptTT85D.Click
        If ptTT85D.BackColor = Color.White Then
            ptTT85D.BackColor = Color.Red
        ElseIf ptTT85D.BackColor = Color.Red Then
            ptTT85D.BackColor = Color.Blue
        Else
            ptTT85D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT85R_Click(sender As Object, e As EventArgs) Handles ptTT85R.Click
        If ptTT85R.BackColor = Color.White Then
            ptTT85R.BackColor = Color.Red
        ElseIf ptTT85R.BackColor = Color.Red Then
            ptTT85R.BackColor = Color.Blue
        Else
            ptTT85R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT85M_Click(sender As Object, e As EventArgs) Handles ptTT85M.Click
        If ptTT85M.BackColor = Color.White Then
            ptTT85M.BackColor = Color.Red
        ElseIf ptTT85M.BackColor = Color.Red Then
            ptTT85M.BackColor = Color.Blue
        Else
            ptTT85M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT84U_Click(sender As Object, e As EventArgs) Handles ptTT84U.Click
        If ptTT84U.BackColor = Color.White Then
            ptTT84U.BackColor = Color.Red
        ElseIf ptTT84U.BackColor = Color.Red Then
            ptTT84U.BackColor = Color.Blue
        Else
            ptTT84U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT84L_Click(sender As Object, e As EventArgs) Handles ptTT84L.Click
        If ptTT84L.BackColor = Color.White Then
            ptTT84L.BackColor = Color.Red
        ElseIf ptTT84L.BackColor = Color.Red Then
            ptTT84L.BackColor = Color.Blue
        Else
            ptTT84L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT84D_Click(sender As Object, e As EventArgs) Handles ptTT84D.Click
        If ptTT84D.BackColor = Color.White Then
            ptTT84D.BackColor = Color.Red
        ElseIf ptTT84D.BackColor = Color.Red Then
            ptTT84D.BackColor = Color.Blue
        Else
            ptTT84D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT84R_Click(sender As Object, e As EventArgs) Handles ptTT84R.Click
        If ptTT84R.BackColor = Color.White Then
            ptTT84R.BackColor = Color.Red
        ElseIf ptTT84R.BackColor = Color.Red Then
            ptTT84R.BackColor = Color.Blue
        Else
            ptTT84R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT84M_Click(sender As Object, e As EventArgs) Handles ptTT84M.Click
        If ptTT84M.BackColor = Color.White Then
            ptTT84M.BackColor = Color.Red
        ElseIf ptTT84M.BackColor = Color.Red Then
            ptTT84M.BackColor = Color.Blue
        Else
            ptTT84M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT83U_Click(sender As Object, e As EventArgs) Handles ptTT83U.Click
        If ptTT83U.BackColor = Color.White Then
            ptTT83U.BackColor = Color.Red
        ElseIf ptTT83U.BackColor = Color.Red Then
            ptTT83U.BackColor = Color.Blue
        Else
            ptTT83U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT83L_Click(sender As Object, e As EventArgs) Handles ptTT83L.Click
        If ptTT83L.BackColor = Color.White Then
            ptTT83L.BackColor = Color.Red
        ElseIf ptTT83L.BackColor = Color.Red Then
            ptTT83L.BackColor = Color.Blue
        Else
            ptTT83L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT83D_Click(sender As Object, e As EventArgs) Handles ptTT83D.Click
        If ptTT83D.BackColor = Color.White Then
            ptTT83D.BackColor = Color.Red
        ElseIf ptTT83D.BackColor = Color.Red Then
            ptTT83D.BackColor = Color.Blue
        Else
            ptTT83D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT83R_Click(sender As Object, e As EventArgs) Handles ptTT83R.Click
        If ptTT83R.BackColor = Color.White Then
            ptTT83R.BackColor = Color.Red
        ElseIf ptTT83R.BackColor = Color.Red Then
            ptTT83R.BackColor = Color.Blue
        Else
            ptTT83R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT83M_Click(sender As Object, e As EventArgs) Handles ptTT83M.Click
        If ptTT83M.BackColor = Color.White Then
            ptTT83M.BackColor = Color.Red
        ElseIf ptTT83M.BackColor = Color.Red Then
            ptTT83M.BackColor = Color.Blue
        Else
            ptTT83M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT82U_Click(sender As Object, e As EventArgs) Handles ptTT82U.Click
        If ptTT82U.BackColor = Color.White Then
            ptTT82U.BackColor = Color.Red
        ElseIf ptTT82U.BackColor = Color.Red Then
            ptTT82U.BackColor = Color.Blue
        Else
            ptTT82U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT82L_Click(sender As Object, e As EventArgs) Handles ptTT82L.Click
        If ptTT82L.BackColor = Color.White Then
            ptTT82L.BackColor = Color.Red
        ElseIf ptTT82L.BackColor = Color.Red Then
            ptTT82L.BackColor = Color.Blue
        Else
            ptTT82L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT82D_Click(sender As Object, e As EventArgs) Handles ptTT82D.Click
        If ptTT82D.BackColor = Color.White Then
            ptTT82D.BackColor = Color.Red
        ElseIf ptTT82D.BackColor = Color.Red Then
            ptTT82D.BackColor = Color.Blue
        Else
            ptTT82D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT82R_Click(sender As Object, e As EventArgs) Handles ptTT82R.Click
        If ptTT82R.BackColor = Color.White Then
            ptTT82R.BackColor = Color.Red
        ElseIf ptTT82R.BackColor = Color.Red Then
            ptTT82R.BackColor = Color.Blue
        Else
            ptTT82R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT82M_Click(sender As Object, e As EventArgs) Handles ptTT82M.Click
        If ptTT82M.BackColor = Color.White Then
            ptTT82M.BackColor = Color.Red
        ElseIf ptTT82M.BackColor = Color.Red Then
            ptTT82M.BackColor = Color.Blue
        Else
            ptTT82M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT81U_Click(sender As Object, e As EventArgs) Handles ptTT81U.Click
        If ptTT81U.BackColor = Color.White Then
            ptTT81U.BackColor = Color.Red
        ElseIf ptTT81U.BackColor = Color.Red Then
            ptTT81U.BackColor = Color.Blue
        Else
            ptTT81U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT81L_Click(sender As Object, e As EventArgs) Handles ptTT81L.Click
        If ptTT81L.BackColor = Color.White Then
            ptTT81L.BackColor = Color.Red
        ElseIf ptTT81L.BackColor = Color.Red Then
            ptTT81L.BackColor = Color.Blue
        Else
            ptTT81L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT81D_Click(sender As Object, e As EventArgs) Handles ptTT81D.Click
        If ptTT81D.BackColor = Color.White Then
            ptTT81D.BackColor = Color.Red
        ElseIf ptTT81D.BackColor = Color.Red Then
            ptTT81D.BackColor = Color.Blue
        Else
            ptTT81D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT81R_Click(sender As Object, e As EventArgs) Handles ptTT81R.Click
        If ptTT81R.BackColor = Color.White Then
            ptTT81R.BackColor = Color.Red
        ElseIf ptTT81R.BackColor = Color.Red Then
            ptTT81R.BackColor = Color.Blue
        Else
            ptTT81R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT81M_Click(sender As Object, e As EventArgs) Handles ptTT81M.Click
        If ptTT81M.BackColor = Color.White Then
            ptTT81M.BackColor = Color.Red
        ElseIf ptTT81M.BackColor = Color.Red Then
            ptTT81M.BackColor = Color.Blue
        Else
            ptTT81M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT71U_Click(sender As Object, e As EventArgs) Handles ptTT71U.Click
        If ptTT71U.BackColor = Color.White Then
            ptTT71U.BackColor = Color.Red
        ElseIf ptTT71U.BackColor = Color.Red Then
            ptTT71U.BackColor = Color.Blue
        Else
            ptTT71U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT71L_Click(sender As Object, e As EventArgs) Handles ptTT71L.Click
        If ptTT71L.BackColor = Color.White Then
            ptTT71L.BackColor = Color.Red
        ElseIf ptTT71L.BackColor = Color.Red Then
            ptTT71L.BackColor = Color.Blue
        Else
            ptTT71L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT71D_Click(sender As Object, e As EventArgs) Handles ptTT71D.Click
        If ptTT71D.BackColor = Color.White Then
            ptTT71D.BackColor = Color.Red
        ElseIf ptTT71D.BackColor = Color.Red Then
            ptTT71D.BackColor = Color.Blue
        Else
            ptTT71D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT71R_Click(sender As Object, e As EventArgs) Handles ptTT71R.Click
        If ptTT71R.BackColor = Color.White Then
            ptTT71R.BackColor = Color.Red
        ElseIf ptTT71R.BackColor = Color.Red Then
            ptTT71R.BackColor = Color.Blue
        Else
            ptTT71R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT71M_Click(sender As Object, e As EventArgs) Handles ptTT71M.Click
        If ptTT71M.BackColor = Color.White Then
            ptTT71M.BackColor = Color.Red
        ElseIf ptTT71M.BackColor = Color.Red Then
            ptTT71M.BackColor = Color.Blue
        Else
            ptTT71M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT72U_Click(sender As Object, e As EventArgs) Handles ptTT72U.Click
        If ptTT72U.BackColor = Color.White Then
            ptTT72U.BackColor = Color.Red
        ElseIf ptTT72U.BackColor = Color.Red Then
            ptTT72U.BackColor = Color.Blue
        Else
            ptTT72U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT72L_Click(sender As Object, e As EventArgs) Handles ptTT72L.Click
        If ptTT72L.BackColor = Color.White Then
            ptTT72L.BackColor = Color.Red
        ElseIf ptTT72L.BackColor = Color.Red Then
            ptTT72L.BackColor = Color.Blue
        Else
            ptTT72L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT72D_Click(sender As Object, e As EventArgs) Handles ptTT72D.Click
        If ptTT72D.BackColor = Color.White Then
            ptTT72D.BackColor = Color.Red
        ElseIf ptTT72D.BackColor = Color.Red Then
            ptTT72D.BackColor = Color.Blue
        Else
            ptTT72D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT72R_Click(sender As Object, e As EventArgs) Handles ptTT72R.Click
        If ptTT72R.BackColor = Color.White Then
            ptTT72R.BackColor = Color.Red
        ElseIf ptTT72R.BackColor = Color.Red Then
            ptTT72R.BackColor = Color.Blue
        Else
            ptTT72R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT72M_Click(sender As Object, e As EventArgs) Handles ptTT72M.Click
        If ptTT72M.BackColor = Color.White Then
            ptTT72M.BackColor = Color.Red
        ElseIf ptTT72M.BackColor = Color.Red Then
            ptTT72M.BackColor = Color.Blue
        Else
            ptTT72M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT73U_Click(sender As Object, e As EventArgs) Handles ptTT73U.Click
        If ptTT73U.BackColor = Color.White Then
            ptTT73U.BackColor = Color.Red
        ElseIf ptTT73U.BackColor = Color.Red Then
            ptTT73U.BackColor = Color.Blue
        Else
            ptTT73U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT73L_Click(sender As Object, e As EventArgs) Handles ptTT73L.Click
        If ptTT73L.BackColor = Color.White Then
            ptTT73L.BackColor = Color.Red
        ElseIf ptTT73L.BackColor = Color.Red Then
            ptTT73L.BackColor = Color.Blue
        Else
            ptTT73L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT73D_Click(sender As Object, e As EventArgs) Handles ptTT73D.Click
        If ptTT73D.BackColor = Color.White Then
            ptTT73D.BackColor = Color.Red
        ElseIf ptTT73D.BackColor = Color.Red Then
            ptTT73D.BackColor = Color.Blue
        Else
            ptTT73D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT73R_Click(sender As Object, e As EventArgs) Handles ptTT73R.Click
        If ptTT73R.BackColor = Color.White Then
            ptTT73R.BackColor = Color.Red
        ElseIf ptTT73R.BackColor = Color.Red Then
            ptTT73R.BackColor = Color.Blue
        Else
            ptTT73R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT73M_Click(sender As Object, e As EventArgs) Handles ptTT73M.Click
        If ptTT73M.BackColor = Color.White Then
            ptTT73M.BackColor = Color.Red
        ElseIf ptTT73M.BackColor = Color.Red Then
            ptTT73M.BackColor = Color.Blue
        Else
            ptTT73M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT74U_Click(sender As Object, e As EventArgs) Handles ptTT74U.Click
        If ptTT74U.BackColor = Color.White Then
            ptTT74U.BackColor = Color.Red
        ElseIf ptTT74U.BackColor = Color.Red Then
            ptTT74U.BackColor = Color.Blue
        Else
            ptTT74U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT74L_Click(sender As Object, e As EventArgs) Handles ptTT74L.Click
        If ptTT74L.BackColor = Color.White Then
            ptTT74L.BackColor = Color.Red
        ElseIf ptTT74L.BackColor = Color.Red Then
            ptTT74L.BackColor = Color.Blue
        Else
            ptTT74L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT74D_Click(sender As Object, e As EventArgs) Handles ptTT74D.Click
        If ptTT74D.BackColor = Color.White Then
            ptTT74D.BackColor = Color.Red
        ElseIf ptTT74D.BackColor = Color.Red Then
            ptTT74D.BackColor = Color.Blue
        Else
            ptTT74D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT74R_Click(sender As Object, e As EventArgs) Handles ptTT74R.Click
        If ptTT74R.BackColor = Color.White Then
            ptTT74R.BackColor = Color.Red
        ElseIf ptTT74R.BackColor = Color.Red Then
            ptTT74R.BackColor = Color.Blue
        Else
            ptTT74R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT74M_Click(sender As Object, e As EventArgs) Handles ptTT74M.Click
        If ptTT74M.BackColor = Color.White Then
            ptTT74M.BackColor = Color.Red
        ElseIf ptTT74M.BackColor = Color.Red Then
            ptTT74M.BackColor = Color.Blue
        Else
            ptTT74M.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT75U_Click(sender As Object, e As EventArgs) Handles ptTT75U.Click
        If ptTT75U.BackColor = Color.White Then
            ptTT75U.BackColor = Color.Red
        ElseIf ptTT75U.BackColor = Color.Red Then
            ptTT75U.BackColor = Color.Blue
        Else
            ptTT75U.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT75L_Click(sender As Object, e As EventArgs) Handles ptTT75L.Click
        If ptTT75L.BackColor = Color.White Then
            ptTT75L.BackColor = Color.Red
        ElseIf ptTT75L.BackColor = Color.Red Then
            ptTT75L.BackColor = Color.Blue
        Else
            ptTT75L.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT75D_Click(sender As Object, e As EventArgs) Handles ptTT75D.Click
        If ptTT75D.BackColor = Color.White Then
            ptTT75D.BackColor = Color.Red
        ElseIf ptTT75D.BackColor = Color.Red Then
            ptTT75D.BackColor = Color.Blue
        Else
            ptTT75D.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT75R_Click(sender As Object, e As EventArgs) Handles ptTT75R.Click
        If ptTT75R.BackColor = Color.White Then
            ptTT75R.BackColor = Color.Red
        ElseIf ptTT75R.BackColor = Color.Red Then
            ptTT75R.BackColor = Color.Blue
        Else
            ptTT75R.BackColor = Color.White
        End If
    End Sub

    Private Sub ptTT75M_Click(sender As Object, e As EventArgs) Handles ptTT75M.Click
        If ptTT75M.BackColor = Color.White Then
            ptTT75M.BackColor = Color.Red
        ElseIf ptTT75M.BackColor = Color.Red Then
            ptTT75M.BackColor = Color.Blue
        Else
            ptTT75M.BackColor = Color.White
        End If
    End Sub

    Private Sub txtboxCrossbite_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtboxOverjet.Validating, txtboxOverbite.Validating, txtboxMidline.Validating, txtboxCrossbite.Validating, txtboxClassMolar.Validating
        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        If (txtbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtbox, String.Empty)
        Else
            ErrorProvider1.SetError(txtbox, "This field is required!")
            txtbox.Select()
        End If
    End Sub

End Class