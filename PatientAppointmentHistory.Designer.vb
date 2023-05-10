<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientAppointmentHistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientAppointmentHistory))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlAppointmentToday = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnInventoryUsed = New System.Windows.Forms.Button()
        Me.btnNoShow = New System.Windows.Forms.Button()
        Me.btnCancelApp = New System.Windows.Forms.Button()
        Me.btnECompleteAppointment = New System.Windows.Forms.Button()
        Me.btnAddPrescription = New System.Windows.Forms.Button()
        Me.btnReschedule = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtboxDescription = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtboxProcedure = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxAppDate = New System.Windows.Forms.TextBox()
        Me.txtboxStartTime = New System.Windows.Forms.TextBox()
        Me.txtboxEndTime = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlAppointmentHistory = New System.Windows.Forms.Panel()
        Me.datagridPatAppointment = New System.Windows.Forms.DataGridView()
        Me.AppDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentistName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbboxAppointmentStatus = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtboxAppsFound = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlAppointmentToday.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAppointmentHistory.SuspendLayout()
        CType(Me.datagridPatAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAppointmentToday
        '
        Me.pnlAppointmentToday.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlAppointmentToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAppointmentToday.Controls.Add(Me.Panel1)
        Me.pnlAppointmentToday.Controls.Add(Me.Panel9)
        Me.pnlAppointmentToday.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAppointmentToday.Location = New System.Drawing.Point(0, 0)
        Me.pnlAppointmentToday.Name = "pnlAppointmentToday"
        Me.pnlAppointmentToday.Size = New System.Drawing.Size(1924, 223)
        Me.pnlAppointmentToday.TabIndex = 229
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnInventoryUsed)
        Me.Panel1.Controls.Add(Me.btnNoShow)
        Me.Panel1.Controls.Add(Me.btnCancelApp)
        Me.Panel1.Controls.Add(Me.btnECompleteAppointment)
        Me.Panel1.Controls.Add(Me.btnAddPrescription)
        Me.Panel1.Controls.Add(Me.btnReschedule)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtboxDescription)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.txtboxProcedure)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtboxAppDate)
        Me.Panel1.Controls.Add(Me.txtboxStartTime)
        Me.Panel1.Controls.Add(Me.txtboxEndTime)
        Me.Panel1.Location = New System.Drawing.Point(11, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1900, 134)
        Me.Panel1.TabIndex = 479
        '
        'btnInventoryUsed
        '
        Me.btnInventoryUsed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInventoryUsed.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnInventoryUsed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventoryUsed.FlatAppearance.BorderSize = 0
        Me.btnInventoryUsed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventoryUsed.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnInventoryUsed.ForeColor = System.Drawing.Color.White
        Me.btnInventoryUsed.Image = CType(resources.GetObject("btnInventoryUsed.Image"), System.Drawing.Image)
        Me.btnInventoryUsed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventoryUsed.Location = New System.Drawing.Point(1346, 48)
        Me.btnInventoryUsed.Name = "btnInventoryUsed"
        Me.btnInventoryUsed.Size = New System.Drawing.Size(119, 37)
        Me.btnInventoryUsed.TabIndex = 477
        Me.btnInventoryUsed.Text = "Inventory"
        Me.btnInventoryUsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnInventoryUsed, "Update inventory used in appointment")
        Me.btnInventoryUsed.UseVisualStyleBackColor = False
        '
        'btnNoShow
        '
        Me.btnNoShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNoShow.BackColor = System.Drawing.Color.White
        Me.btnNoShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNoShow.FlatAppearance.BorderColor = System.Drawing.Color.Orange
        Me.btnNoShow.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNoShow.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnNoShow.ForeColor = System.Drawing.Color.Orange
        Me.btnNoShow.Location = New System.Drawing.Point(1670, 47)
        Me.btnNoShow.Name = "btnNoShow"
        Me.btnNoShow.Size = New System.Drawing.Size(90, 39)
        Me.btnNoShow.TabIndex = 472
        Me.btnNoShow.Text = "No Show"
        Me.ToolTip1.SetToolTip(Me.btnNoShow, "No show apppointment")
        Me.btnNoShow.UseVisualStyleBackColor = False
        '
        'btnCancelApp
        '
        Me.btnCancelApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelApp.BackColor = System.Drawing.Color.White
        Me.btnCancelApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelApp.FlatAppearance.BorderColor = System.Drawing.Color.Orange
        Me.btnCancelApp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelApp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancelApp.ForeColor = System.Drawing.Color.Orange
        Me.btnCancelApp.Location = New System.Drawing.Point(1764, 47)
        Me.btnCancelApp.Name = "btnCancelApp"
        Me.btnCancelApp.Size = New System.Drawing.Size(90, 39)
        Me.btnCancelApp.TabIndex = 471
        Me.btnCancelApp.Text = "Cancel"
        Me.ToolTip1.SetToolTip(Me.btnCancelApp, "Cancel appointment")
        Me.btnCancelApp.UseVisualStyleBackColor = False
        '
        'btnECompleteAppointment
        '
        Me.btnECompleteAppointment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnECompleteAppointment.BackColor = System.Drawing.Color.White
        Me.btnECompleteAppointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnECompleteAppointment.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnECompleteAppointment.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnECompleteAppointment.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnECompleteAppointment.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnECompleteAppointment.Location = New System.Drawing.Point(1482, 47)
        Me.btnECompleteAppointment.Name = "btnECompleteAppointment"
        Me.btnECompleteAppointment.Size = New System.Drawing.Size(90, 39)
        Me.btnECompleteAppointment.TabIndex = 469
        Me.btnECompleteAppointment.Text = "Complete"
        Me.ToolTip1.SetToolTip(Me.btnECompleteAppointment, "Complete appointment")
        Me.btnECompleteAppointment.UseVisualStyleBackColor = False
        '
        'btnAddPrescription
        '
        Me.btnAddPrescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddPrescription.BackColor = System.Drawing.Color.Goldenrod
        Me.btnAddPrescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddPrescription.FlatAppearance.BorderSize = 0
        Me.btnAddPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPrescription.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddPrescription.ForeColor = System.Drawing.Color.White
        Me.btnAddPrescription.Image = CType(resources.GetObject("btnAddPrescription.Image"), System.Drawing.Image)
        Me.btnAddPrescription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddPrescription.Location = New System.Drawing.Point(1215, 48)
        Me.btnAddPrescription.Name = "btnAddPrescription"
        Me.btnAddPrescription.Size = New System.Drawing.Size(125, 37)
        Me.btnAddPrescription.TabIndex = 473
        Me.btnAddPrescription.Text = "Prescription"
        Me.btnAddPrescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnAddPrescription, "Add prescription")
        Me.btnAddPrescription.UseVisualStyleBackColor = False
        '
        'btnReschedule
        '
        Me.btnReschedule.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReschedule.BackColor = System.Drawing.Color.White
        Me.btnReschedule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReschedule.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnReschedule.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnReschedule.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReschedule.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnReschedule.Location = New System.Drawing.Point(1576, 47)
        Me.btnReschedule.Name = "btnReschedule"
        Me.btnReschedule.Size = New System.Drawing.Size(90, 39)
        Me.btnReschedule.TabIndex = 470
        Me.btnReschedule.Text = "Reschedule"
        Me.ToolTip1.SetToolTip(Me.btnReschedule, "Reschedule appointment")
        Me.btnReschedule.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(4927, 18)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(358, 27)
        Me.TextBox3.TabIndex = 19
        Me.TextBox3.Text = "  Search"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(441, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 31)
        Me.Label8.TabIndex = 382
        Me.Label8.Text = "Description:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtboxDescription
        '
        Me.txtboxDescription.BackColor = System.Drawing.Color.White
        Me.txtboxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxDescription.Enabled = False
        Me.txtboxDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxDescription.Location = New System.Drawing.Point(565, 57)
        Me.txtboxDescription.Multiline = True
        Me.txtboxDescription.Name = "txtboxDescription"
        Me.txtboxDescription.Size = New System.Drawing.Size(263, 62)
        Me.txtboxDescription.TabIndex = 476
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(21, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 31)
        Me.Label6.TabIndex = 382
        Me.Label6.Text = "End Time:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(441, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 31)
        Me.Label4.TabIndex = 382
        Me.Label4.Text = "Procedure:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(4898, 18)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.PictureBox3.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'txtboxProcedure
        '
        Me.txtboxProcedure.BackColor = System.Drawing.Color.White
        Me.txtboxProcedure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxProcedure.Enabled = False
        Me.txtboxProcedure.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxProcedure.Location = New System.Drawing.Point(565, 21)
        Me.txtboxProcedure.Multiline = True
        Me.txtboxProcedure.Name = "txtboxProcedure"
        Me.txtboxProcedure.Size = New System.Drawing.Size(263, 30)
        Me.txtboxProcedure.TabIndex = 474
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 31)
        Me.Label2.TabIndex = 382
        Me.Label2.Text = "Start Time:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 31)
        Me.Label3.TabIndex = 382
        Me.Label3.Text = "Appointment Date:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtboxAppDate
        '
        Me.txtboxAppDate.BackColor = System.Drawing.Color.White
        Me.txtboxAppDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxAppDate.Enabled = False
        Me.txtboxAppDate.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxAppDate.Location = New System.Drawing.Point(167, 20)
        Me.txtboxAppDate.Name = "txtboxAppDate"
        Me.txtboxAppDate.ReadOnly = True
        Me.txtboxAppDate.Size = New System.Drawing.Size(228, 31)
        Me.txtboxAppDate.TabIndex = 385
        Me.txtboxAppDate.Text = "2022-28-01"
        Me.txtboxAppDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxStartTime
        '
        Me.txtboxStartTime.BackColor = System.Drawing.Color.White
        Me.txtboxStartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxStartTime.Enabled = False
        Me.txtboxStartTime.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxStartTime.Location = New System.Drawing.Point(167, 54)
        Me.txtboxStartTime.Name = "txtboxStartTime"
        Me.txtboxStartTime.ReadOnly = True
        Me.txtboxStartTime.Size = New System.Drawing.Size(228, 31)
        Me.txtboxStartTime.TabIndex = 385
        Me.txtboxStartTime.Text = "12:00 pm"
        Me.txtboxStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxEndTime
        '
        Me.txtboxEndTime.BackColor = System.Drawing.Color.White
        Me.txtboxEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxEndTime.Enabled = False
        Me.txtboxEndTime.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxEndTime.Location = New System.Drawing.Point(167, 88)
        Me.txtboxEndTime.Name = "txtboxEndTime"
        Me.txtboxEndTime.ReadOnly = True
        Me.txtboxEndTime.Size = New System.Drawing.Size(228, 31)
        Me.txtboxEndTime.TabIndex = 385
        Me.txtboxEndTime.Text = "01:00 pm"
        Me.txtboxEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel9.Controls.Add(Me.TextBox2)
        Me.Panel9.Controls.Add(Me.PictureBox2)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1922, 48)
        Me.Panel9.TabIndex = 478
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(4949, 18)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(358, 27)
        Me.TextBox2.TabIndex = 19
        Me.TextBox2.Text = "  Search"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(4920, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.PictureBox2.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 28)
        Me.Label5.TabIndex = 376
        Me.Label5.Text = "Appointment Today"
        '
        'pnlAppointmentHistory
        '
        Me.pnlAppointmentHistory.AutoScroll = True
        Me.pnlAppointmentHistory.Controls.Add(Me.datagridPatAppointment)
        Me.pnlAppointmentHistory.Controls.Add(Me.Panel3)
        Me.pnlAppointmentHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAppointmentHistory.Location = New System.Drawing.Point(0, 223)
        Me.pnlAppointmentHistory.Name = "pnlAppointmentHistory"
        Me.pnlAppointmentHistory.Size = New System.Drawing.Size(1924, 854)
        Me.pnlAppointmentHistory.TabIndex = 230
        '
        'datagridPatAppointment
        '
        Me.datagridPatAppointment.AllowUserToAddRows = False
        Me.datagridPatAppointment.AllowUserToDeleteRows = False
        Me.datagridPatAppointment.AllowUserToResizeColumns = False
        Me.datagridPatAppointment.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.datagridPatAppointment.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datagridPatAppointment.BackgroundColor = System.Drawing.Color.White
        Me.datagridPatAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridPatAppointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.datagridPatAppointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridPatAppointment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.datagridPatAppointment.ColumnHeadersHeight = 50
        Me.datagridPatAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagridPatAppointment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppDate, Me.AppStatus, Me.Description, Me.DentistName, Me.StartTime, Me.EndTime, Me.Duration})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridPatAppointment.DefaultCellStyle = DataGridViewCellStyle7
        Me.datagridPatAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridPatAppointment.EnableHeadersVisualStyles = False
        Me.datagridPatAppointment.Location = New System.Drawing.Point(0, 63)
        Me.datagridPatAppointment.Name = "datagridPatAppointment"
        Me.datagridPatAppointment.ReadOnly = True
        Me.datagridPatAppointment.RowHeadersVisible = False
        Me.datagridPatAppointment.RowHeadersWidth = 51
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.datagridPatAppointment.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.datagridPatAppointment.RowTemplate.Height = 29
        Me.datagridPatAppointment.RowTemplate.ReadOnly = True
        Me.datagridPatAppointment.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridPatAppointment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datagridPatAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridPatAppointment.Size = New System.Drawing.Size(1924, 791)
        Me.datagridPatAppointment.TabIndex = 242
        Me.datagridPatAppointment.TabStop = False
        '
        'AppDate
        '
        Me.AppDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AppDate.HeaderText = "Appointment Date"
        Me.AppDate.MinimumWidth = 6
        Me.AppDate.Name = "AppDate"
        Me.AppDate.ReadOnly = True
        Me.AppDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'AppStatus
        '
        Me.AppStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AppStatus.HeaderText = "Appointment Status"
        Me.AppStatus.MinimumWidth = 6
        Me.AppStatus.Name = "AppStatus"
        Me.AppStatus.ReadOnly = True
        '
        'Description
        '
        Me.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Description.HeaderText = "Description"
        Me.Description.MinimumWidth = 6
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'DentistName
        '
        Me.DentistName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DentistName.HeaderText = "Dentist Name"
        Me.DentistName.MinimumWidth = 6
        Me.DentistName.Name = "DentistName"
        Me.DentistName.ReadOnly = True
        '
        'StartTime
        '
        Me.StartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StartTime.HeaderText = "Start Time"
        Me.StartTime.MinimumWidth = 6
        Me.StartTime.Name = "StartTime"
        Me.StartTime.ReadOnly = True
        '
        'EndTime
        '
        Me.EndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EndTime.HeaderText = "End Time"
        Me.EndTime.MinimumWidth = 6
        Me.EndTime.Name = "EndTime"
        Me.EndTime.ReadOnly = True
        '
        'Duration
        '
        Me.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Duration.HeaderText = "Duration"
        Me.Duration.MinimumWidth = 6
        Me.Duration.Name = "Duration"
        Me.Duration.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cmbboxAppointmentStatus)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1924, 63)
        Me.Panel3.TabIndex = 241
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1472, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 215
        Me.Label7.Text = "Filter by:"
        '
        'cmbboxAppointmentStatus
        '
        Me.cmbboxAppointmentStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbboxAppointmentStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cmbboxAppointmentStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxAppointmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxAppointmentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbboxAppointmentStatus.ForeColor = System.Drawing.Color.White
        Me.cmbboxAppointmentStatus.FormattingEnabled = True
        Me.cmbboxAppointmentStatus.Items.AddRange(New Object() {"No Filter", "Scheduled/Rescheduled", "Completed", "Cancelled", "No Show"})
        Me.cmbboxAppointmentStatus.Location = New System.Drawing.Point(1540, 18)
        Me.cmbboxAppointmentStatus.Name = "cmbboxAppointmentStatus"
        Me.cmbboxAppointmentStatus.Size = New System.Drawing.Size(177, 28)
        Me.cmbboxAppointmentStatus.TabIndex = 214
        Me.cmbboxAppointmentStatus.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtboxAppsFound)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(1723, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(201, 63)
        Me.Panel5.TabIndex = 203
        '
        'txtboxAppsFound
        '
        Me.txtboxAppsFound.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxAppsFound.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtboxAppsFound.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxAppsFound.ForeColor = System.Drawing.Color.White
        Me.txtboxAppsFound.Location = New System.Drawing.Point(3, 21)
        Me.txtboxAppsFound.Name = "txtboxAppsFound"
        Me.txtboxAppsFound.ReadOnly = True
        Me.txtboxAppsFound.Size = New System.Drawing.Size(183, 20)
        Me.txtboxAppsFound.TabIndex = 1
        Me.txtboxAppsFound.TabStop = False
        Me.txtboxAppsFound.Text = "4 appointments found"
        Me.txtboxAppsFound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 25)
        Me.Label1.TabIndex = 202
        Me.Label1.Text = "Appointment"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.BackColor = System.Drawing.Color.White
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        '
        'PatientAppointmentHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1077)
        Me.Controls.Add(Me.pnlAppointmentHistory)
        Me.Controls.Add(Me.pnlAppointmentToday)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PatientAppointmentHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PatientAppointmentHistory"
        Me.pnlAppointmentToday.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAppointmentHistory.ResumeLayout(False)
        CType(Me.datagridPatAppointment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAppointmentHistory As Panel
    Friend WithEvents datagridPatAppointment As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAddPrescription As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtboxStartTime As TextBox
    Friend WithEvents txtboxEndTime As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEditUsername As Button
    Friend WithEvents btnECompleteAppointment As Button
    Friend WithEvents pnlAppointmentToday As Panel
    Friend WithEvents AppointmentDate As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentStatus As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewImageColumn
    Friend WithEvents btnCancelApp As Button
    Friend WithEvents btnReschedule As Button
    Friend WithEvents btnNoShow As Button
    Friend WithEvents AppDate As DataGridViewTextBoxColumn
    Friend WithEvents AppStatus As DataGridViewTextBoxColumn
    Friend WithEvents StartTime As DataGridViewTextBoxColumn
    Friend WithEvents EndTime As DataGridViewTextBoxColumn
    Friend WithEvents Duration As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents DentistName As DataGridViewTextBoxColumn
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents txtboxDescription As TextBox
    Friend WithEvents txtboxProcedure As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtboxAppDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtboxAppsFound As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbboxAppointmentStatus As ComboBox
    Friend WithEvents btnInventoryUsed As Button
End Class
