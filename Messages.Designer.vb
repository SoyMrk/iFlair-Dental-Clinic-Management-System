<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Messages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Messages))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TopGrayPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSMSTemplates = New System.Windows.Forms.Button()
        Me.btnSMSConfig = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEditMessage = New System.Windows.Forms.Button()
        Me.chcboxNotify = New System.Windows.Forms.CheckBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.rchtxtboxMessage = New System.Windows.Forms.RichTextBox()
        Me.txtboxtoNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbboxTemplate = New System.Windows.Forms.ComboBox()
        Me.btnSendMessage = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.dataviewMessagesAppointment = New System.Windows.Forms.DataGridView()
        Me.AppID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SMS_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentistContact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentistName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbboxMsgAppFilterStatus = New System.Windows.Forms.ComboBox()
        Me.cmbboxMsgAppFilterDate = New System.Windows.Forms.ComboBox()
        Me.txtboxSearchApp = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopGrayPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.dataviewMessagesAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopGrayPanel
        '
        Me.TopGrayPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TopGrayPanel.Controls.Add(Me.Label1)
        Me.TopGrayPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopGrayPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopGrayPanel.Name = "TopGrayPanel"
        Me.TopGrayPanel.Size = New System.Drawing.Size(1924, 63)
        Me.TopGrayPanel.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 28)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Messages"
        '
        'btnSMSTemplates
        '
        Me.btnSMSTemplates.BackColor = System.Drawing.Color.Transparent
        Me.btnSMSTemplates.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSMSTemplates.FlatAppearance.BorderSize = 0
        Me.btnSMSTemplates.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSMSTemplates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSMSTemplates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSMSTemplates.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSMSTemplates.ForeColor = System.Drawing.Color.White
        Me.btnSMSTemplates.Image = CType(resources.GetObject("btnSMSTemplates.Image"), System.Drawing.Image)
        Me.btnSMSTemplates.Location = New System.Drawing.Point(374, 9)
        Me.btnSMSTemplates.Name = "btnSMSTemplates"
        Me.btnSMSTemplates.Size = New System.Drawing.Size(35, 29)
        Me.btnSMSTemplates.TabIndex = 2
        Me.btnSMSTemplates.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnSMSTemplates, "View SMS template")
        Me.btnSMSTemplates.UseVisualStyleBackColor = False
        '
        'btnSMSConfig
        '
        Me.btnSMSConfig.BackColor = System.Drawing.Color.Gray
        Me.btnSMSConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSMSConfig.FlatAppearance.BorderSize = 0
        Me.btnSMSConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSMSConfig.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSMSConfig.ForeColor = System.Drawing.Color.White
        Me.btnSMSConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSMSConfig.Location = New System.Drawing.Point(202, 10)
        Me.btnSMSConfig.Name = "btnSMSConfig"
        Me.btnSMSConfig.Size = New System.Drawing.Size(159, 27)
        Me.btnSMSConfig.TabIndex = 1
        Me.btnSMSConfig.TabStop = False
        Me.btnSMSConfig.Text = "SMS Configuration"
        Me.ToolTip1.SetToolTip(Me.btnSMSConfig, "Set active SMS configuration.")
        Me.btnSMSConfig.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(13, 1064)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1898, 13)
        Me.Panel4.TabIndex = 48
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1911, 76)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 1001)
        Me.Panel3.TabIndex = 47
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 1001)
        Me.Panel2.TabIndex = 46
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1924, 13)
        Me.Panel1.TabIndex = 45
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(13, 76)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(430, 988)
        Me.Panel5.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEditMessage)
        Me.GroupBox1.Controls.Add(Me.chcboxNotify)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.rchtxtboxMessage)
        Me.GroupBox1.Controls.Add(Me.txtboxtoNumber)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbboxTemplate)
        Me.GroupBox1.Controls.Add(Me.btnSendMessage)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(19, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 910)
        Me.GroupBox1.TabIndex = 211
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "."
        '
        'btnEditMessage
        '
        Me.btnEditMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btnEditMessage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditMessage.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnEditMessage.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEditMessage.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnEditMessage.Image = CType(resources.GetObject("btnEditMessage.Image"), System.Drawing.Image)
        Me.btnEditMessage.Location = New System.Drawing.Point(80, 738)
        Me.btnEditMessage.Name = "btnEditMessage"
        Me.btnEditMessage.Size = New System.Drawing.Size(38, 32)
        Me.btnEditMessage.TabIndex = 8
        Me.btnEditMessage.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnEditMessage, "Edit message")
        Me.btnEditMessage.UseVisualStyleBackColor = False
        '
        'chcboxNotify
        '
        Me.chcboxNotify.BackColor = System.Drawing.Color.ForestGreen
        Me.chcboxNotify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chcboxNotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chcboxNotify.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chcboxNotify.ForeColor = System.Drawing.Color.White
        Me.chcboxNotify.Location = New System.Drawing.Point(234, 738)
        Me.chcboxNotify.Name = "chcboxNotify"
        Me.chcboxNotify.Padding = New System.Windows.Forms.Padding(8, 3, 5, 5)
        Me.chcboxNotify.Size = New System.Drawing.Size(138, 32)
        Me.chcboxNotify.TabIndex = 7
        Me.chcboxNotify.TabStop = False
        Me.chcboxNotify.Text = "Notify dentist"
        Me.chcboxNotify.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.chcboxNotify, "Check if you want to notify the dentist.")
        Me.chcboxNotify.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.Location = New System.Drawing.Point(19, 738)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(57, 32)
        Me.btnReset.TabIndex = 5
        Me.btnReset.TabStop = False
        Me.btnReset.Text = "Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Reset message")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'rchtxtboxMessage
        '
        Me.rchtxtboxMessage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rchtxtboxMessage.Location = New System.Drawing.Point(19, 214)
        Me.rchtxtboxMessage.Name = "rchtxtboxMessage"
        Me.rchtxtboxMessage.ReadOnly = True
        Me.rchtxtboxMessage.Size = New System.Drawing.Size(353, 518)
        Me.rchtxtboxMessage.TabIndex = 6
        Me.rchtxtboxMessage.TabStop = False
        Me.rchtxtboxMessage.Text = ""
        '
        'txtboxtoNumber
        '
        Me.txtboxtoNumber.BackColor = System.Drawing.Color.White
        Me.txtboxtoNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxtoNumber.Enabled = False
        Me.txtboxtoNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxtoNumber.ForeColor = System.Drawing.Color.Black
        Me.txtboxtoNumber.Location = New System.Drawing.Point(19, 67)
        Me.txtboxtoNumber.Name = "txtboxtoNumber"
        Me.txtboxtoNumber.ReadOnly = True
        Me.txtboxtoNumber.Size = New System.Drawing.Size(353, 27)
        Me.txtboxtoNumber.TabIndex = 3
        Me.txtboxtoNumber.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 470
        Me.Label5.Text = "Contact Number"
        '
        'cmbboxTemplate
        '
        Me.cmbboxTemplate.AccessibleName = "Template Type"
        Me.cmbboxTemplate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxTemplate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxTemplate.FormattingEnabled = True
        Me.cmbboxTemplate.Items.AddRange(New Object() {"Template 1", "Template 2", "Template 3"})
        Me.cmbboxTemplate.Location = New System.Drawing.Point(19, 129)
        Me.cmbboxTemplate.Name = "cmbboxTemplate"
        Me.cmbboxTemplate.Size = New System.Drawing.Size(353, 28)
        Me.cmbboxTemplate.TabIndex = 4
        Me.cmbboxTemplate.TabStop = False
        '
        'btnSendMessage
        '
        Me.btnSendMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSendMessage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSendMessage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendMessage.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSendMessage.ForeColor = System.Drawing.Color.White
        Me.btnSendMessage.Location = New System.Drawing.Point(23, 833)
        Me.btnSendMessage.Name = "btnSendMessage"
        Me.btnSendMessage.Size = New System.Drawing.Size(349, 41)
        Me.btnSendMessage.TabIndex = 9
        Me.btnSendMessage.TabStop = False
        Me.btnSendMessage.Text = "Send Message"
        Me.btnSendMessage.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 220
        Me.Label3.Text = "Template"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 198
        Me.Label4.Text = "Message"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.btnSMSTemplates)
        Me.Panel6.Controls.Add(Me.btnSMSConfig)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(428, 50)
        Me.Panel6.TabIndex = 43
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(443, 76)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(12, 988)
        Me.Panel10.TabIndex = 51
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.dataviewMessagesAppointment)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(455, 76)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1456, 988)
        Me.Panel7.TabIndex = 52
        '
        'dataviewMessagesAppointment
        '
        Me.dataviewMessagesAppointment.AllowUserToAddRows = False
        Me.dataviewMessagesAppointment.AllowUserToDeleteRows = False
        Me.dataviewMessagesAppointment.AllowUserToResizeColumns = False
        Me.dataviewMessagesAppointment.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dataviewMessagesAppointment.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dataviewMessagesAppointment.BackgroundColor = System.Drawing.Color.White
        Me.dataviewMessagesAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataviewMessagesAppointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dataviewMessagesAppointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataviewMessagesAppointment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dataviewMessagesAppointment.ColumnHeadersHeight = 50
        Me.dataviewMessagesAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataviewMessagesAppointment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppID, Me.PatientName, Me.ContactNumber, Me.AppointmentDate, Me.StartTime, Me.EndTime, Me.AppStatus, Me.SMS_Status, Me.DentistContact, Me.DentistName})
        Me.dataviewMessagesAppointment.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataviewMessagesAppointment.DefaultCellStyle = DataGridViewCellStyle8
        Me.dataviewMessagesAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataviewMessagesAppointment.EnableHeadersVisualStyles = False
        Me.dataviewMessagesAppointment.Location = New System.Drawing.Point(0, 50)
        Me.dataviewMessagesAppointment.Name = "dataviewMessagesAppointment"
        Me.dataviewMessagesAppointment.ReadOnly = True
        Me.dataviewMessagesAppointment.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dataviewMessagesAppointment.RowHeadersVisible = False
        Me.dataviewMessagesAppointment.RowHeadersWidth = 20
        Me.dataviewMessagesAppointment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataviewMessagesAppointment.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dataviewMessagesAppointment.RowTemplate.Height = 10
        Me.dataviewMessagesAppointment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataviewMessagesAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataviewMessagesAppointment.ShowCellToolTips = False
        Me.dataviewMessagesAppointment.Size = New System.Drawing.Size(1454, 936)
        Me.dataviewMessagesAppointment.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.dataviewMessagesAppointment, "Click to select patient contact")
        '
        'AppID
        '
        Me.AppID.HeaderText = "AppID"
        Me.AppID.MinimumWidth = 6
        Me.AppID.Name = "AppID"
        Me.AppID.ReadOnly = True
        Me.AppID.Visible = False
        Me.AppID.Width = 125
        '
        'PatientName
        '
        Me.PatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PatientName.HeaderText = "Patient Name"
        Me.PatientName.MinimumWidth = 6
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
        '
        'ContactNumber
        '
        Me.ContactNumber.HeaderText = "Contact"
        Me.ContactNumber.MinimumWidth = 6
        Me.ContactNumber.Name = "ContactNumber"
        Me.ContactNumber.ReadOnly = True
        Me.ContactNumber.Width = 130
        '
        'AppointmentDate
        '
        Me.AppointmentDate.HeaderText = "Appointment Date"
        Me.AppointmentDate.MinimumWidth = 6
        Me.AppointmentDate.Name = "AppointmentDate"
        Me.AppointmentDate.ReadOnly = True
        Me.AppointmentDate.Width = 150
        '
        'StartTime
        '
        Me.StartTime.HeaderText = "Start Time"
        Me.StartTime.MinimumWidth = 6
        Me.StartTime.Name = "StartTime"
        Me.StartTime.ReadOnly = True
        Me.StartTime.Width = 90
        '
        'EndTime
        '
        Me.EndTime.HeaderText = "End Time"
        Me.EndTime.MinimumWidth = 6
        Me.EndTime.Name = "EndTime"
        Me.EndTime.ReadOnly = True
        Me.EndTime.Width = 90
        '
        'AppStatus
        '
        Me.AppStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AppStatus.HeaderText = "Appoinment Status"
        Me.AppStatus.MinimumWidth = 6
        Me.AppStatus.Name = "AppStatus"
        Me.AppStatus.ReadOnly = True
        '
        'SMS_Status
        '
        Me.SMS_Status.HeaderText = "SMS Status"
        Me.SMS_Status.MinimumWidth = 6
        Me.SMS_Status.Name = "SMS_Status"
        Me.SMS_Status.ReadOnly = True
        Me.SMS_Status.Width = 120
        '
        'DentistContact
        '
        Me.DentistContact.HeaderText = "DentistContact"
        Me.DentistContact.MinimumWidth = 6
        Me.DentistContact.Name = "DentistContact"
        Me.DentistContact.ReadOnly = True
        Me.DentistContact.Visible = False
        Me.DentistContact.Width = 125
        '
        'DentistName
        '
        Me.DentistName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DentistName.HeaderText = "Dentist Name"
        Me.DentistName.MinimumWidth = 6
        Me.DentistName.Name = "DentistName"
        Me.DentistName.ReadOnly = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.ComboBox2)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1454, 50)
        Me.Panel8.TabIndex = 46
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Controls.Add(Me.cmbboxMsgAppFilterStatus)
        Me.Panel9.Controls.Add(Me.cmbboxMsgAppFilterDate)
        Me.Panel9.Controls.Add(Me.txtboxSearchApp)
        Me.Panel9.Controls.Add(Me.PictureBox3)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1452, 50)
        Me.Panel9.TabIndex = 201
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1073, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 213
        Me.Label2.Text = "Filter by:"
        '
        'cmbboxMsgAppFilterStatus
        '
        Me.cmbboxMsgAppFilterStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbboxMsgAppFilterStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cmbboxMsgAppFilterStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxMsgAppFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxMsgAppFilterStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbboxMsgAppFilterStatus.ForeColor = System.Drawing.Color.White
        Me.cmbboxMsgAppFilterStatus.FormattingEnabled = True
        Me.cmbboxMsgAppFilterStatus.Items.AddRange(New Object() {"No Filter", "Scheduled/Rescheduled", "Completed", "Cancelled", "No Show"})
        Me.cmbboxMsgAppFilterStatus.Location = New System.Drawing.Point(1258, 9)
        Me.cmbboxMsgAppFilterStatus.Name = "cmbboxMsgAppFilterStatus"
        Me.cmbboxMsgAppFilterStatus.Size = New System.Drawing.Size(178, 28)
        Me.cmbboxMsgAppFilterStatus.TabIndex = 12
        Me.cmbboxMsgAppFilterStatus.TabStop = False
        Me.ToolTip1.SetToolTip(Me.cmbboxMsgAppFilterStatus, "Filter by appointment status")
        '
        'cmbboxMsgAppFilterDate
        '
        Me.cmbboxMsgAppFilterDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbboxMsgAppFilterDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cmbboxMsgAppFilterDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxMsgAppFilterDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxMsgAppFilterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbboxMsgAppFilterDate.ForeColor = System.Drawing.Color.White
        Me.cmbboxMsgAppFilterDate.FormattingEnabled = True
        Me.cmbboxMsgAppFilterDate.Items.AddRange(New Object() {"All", "Today", "Tomorrow", "This Week", "This Month"})
        Me.cmbboxMsgAppFilterDate.Location = New System.Drawing.Point(1141, 9)
        Me.cmbboxMsgAppFilterDate.Name = "cmbboxMsgAppFilterDate"
        Me.cmbboxMsgAppFilterDate.Size = New System.Drawing.Size(111, 28)
        Me.cmbboxMsgAppFilterDate.TabIndex = 11
        Me.cmbboxMsgAppFilterDate.TabStop = False
        '
        'txtboxSearchApp
        '
        Me.txtboxSearchApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtboxSearchApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxSearchApp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxSearchApp.ForeColor = System.Drawing.Color.White
        Me.txtboxSearchApp.Location = New System.Drawing.Point(41, 11)
        Me.txtboxSearchApp.Name = "txtboxSearchApp"
        Me.txtboxSearchApp.Size = New System.Drawing.Size(305, 27)
        Me.txtboxSearchApp.TabIndex = 10
        Me.txtboxSearchApp.TabStop = False
        Me.txtboxSearchApp.Text = "  Search here"
        Me.ToolTip1.SetToolTip(Me.txtboxSearchApp, "Search by patient name")
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.PictureBox3.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Tomorrow", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.ComboBox2.Location = New System.Drawing.Point(1268, 19)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(237, 28)
        Me.ComboBox2.TabIndex = 200
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
        'Messages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1077)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TopGrayPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Messages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Messages"
        Me.TopGrayPanel.ResumeLayout(False)
        Me.TopGrayPanel.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.dataviewMessagesAppointment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopGrayPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnSMSTemplates As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbboxTemplate As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSendMessage As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEditUsername As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents dataviewMessagesAppointment As DataGridView
    Friend WithEvents DateCreated As DataGridViewTextBoxColumn
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSMSConfig As Button
    Friend WithEvents txtboxtoNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rchtxtboxMessage As RichTextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEditMessage As Button
    Friend WithEvents chckboxToday As CheckBox
    Friend WithEvents chckboxWeek As CheckBox
    Friend WithEvents chckboxMonth As CheckBox
    Friend WithEvents Edit As DataGridViewImageColumn
    Friend WithEvents Delete As DataGridViewImageColumn
    Friend WithEvents chcboxNotify As CheckBox
    Friend WithEvents cmbboxMsgAppFilterStatus As ComboBox
    Friend WithEvents cmbboxMsgAppFilterDate As ComboBox
    Friend WithEvents txtboxSearch As TextBox
    Friend WithEvents txtboxSearchApp As TextBox
    Friend WithEvents AppID As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumber As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentDate As DataGridViewTextBoxColumn
    Friend WithEvents StartTime As DataGridViewTextBoxColumn
    Friend WithEvents EndTime As DataGridViewTextBoxColumn
    Friend WithEvents AppStatus As DataGridViewTextBoxColumn
    Friend WithEvents SMS_Status As DataGridViewTextBoxColumn
    Friend WithEvents DentistContact As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DentistName As DataGridViewTextBoxColumn
End Class
