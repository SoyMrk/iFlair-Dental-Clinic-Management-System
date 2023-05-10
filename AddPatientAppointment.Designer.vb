<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddPatientAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPatientAppointment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TopGrayPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblGridDate = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtgridAppDateViewer = New System.Windows.Forms.DataGridView()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAddProcedure6 = New System.Windows.Forms.Button()
        Me.btnAddProcedure5 = New System.Windows.Forms.Button()
        Me.btnAddProcedure4 = New System.Windows.Forms.Button()
        Me.txtboxDescription = New System.Windows.Forms.TextBox()
        Me.lblProcedure6 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.cmbboxProcedure6 = New System.Windows.Forms.ComboBox()
        Me.cmbboxProcedure = New System.Windows.Forms.ComboBox()
        Me.lblProcedure = New System.Windows.Forms.Label()
        Me.btnAddProcedure2 = New System.Windows.Forms.Button()
        Me.lblProcedure5 = New System.Windows.Forms.Label()
        Me.cmbboxProcedure5 = New System.Windows.Forms.ComboBox()
        Me.cmbboxProcedure2 = New System.Windows.Forms.ComboBox()
        Me.btnAddProcedure3 = New System.Windows.Forms.Button()
        Me.lblProcedure2 = New System.Windows.Forms.Label()
        Me.lblProcedure4 = New System.Windows.Forms.Label()
        Me.cmbboxProcedure3 = New System.Windows.Forms.ComboBox()
        Me.cmbboxProcedure4 = New System.Windows.Forms.ComboBox()
        Me.lblProcedure3 = New System.Windows.Forms.Label()
        Me.btnDelete1 = New System.Windows.Forms.Button()
        Me.btnDelete2 = New System.Windows.Forms.Button()
        Me.btnDelete3 = New System.Windows.Forms.Button()
        Me.btnDelete4 = New System.Windows.Forms.Button()
        Me.btnDelete5 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtboxPatientName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxPatientNo = New System.Windows.Forms.TextBox()
        Me.cmbboxDentist = New System.Windows.Forms.ComboBox()
        Me.dtpickerAppDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.txtboxDuration = New System.Windows.Forms.TextBox()
        Me.dtpickerEndTime = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.dtpickerStartTime = New System.Windows.Forms.DateTimePicker()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopGrayPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgridAppDateViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopGrayPanel
        '
        Me.TopGrayPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TopGrayPanel.Controls.Add(Me.PictureBox1)
        Me.TopGrayPanel.Controls.Add(Me.Label1)
        Me.TopGrayPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopGrayPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopGrayPanel.Name = "TopGrayPanel"
        Me.TopGrayPanel.Size = New System.Drawing.Size(1310, 68)
        Me.TopGrayPanel.TabIndex = 209
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 25)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(40, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 28)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Add Appointment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1310, 835)
        Me.Panel1.TabIndex = 210
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(1153, 781)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 41)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(1040, 781)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 41)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblGridDate)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dtgridAppDateViewer)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1286, 698)
        Me.GroupBox1.TabIndex = 306
        Me.GroupBox1.TabStop = False
        '
        'lblGridDate
        '
        Me.lblGridDate.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblGridDate.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblGridDate.Location = New System.Drawing.Point(28, 69)
        Me.lblGridDate.Name = "lblGridDate"
        Me.lblGridDate.Size = New System.Drawing.Size(507, 25)
        Me.lblGridDate.TabIndex = 334
        Me.lblGridDate.Text = "Date"
        Me.lblGridDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(30, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 25)
        Me.Label10.TabIndex = 335
        Me.Label10.Text = "Appointment List"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtgridAppDateViewer
        '
        Me.dtgridAppDateViewer.AccessibleName = "List of Appointment"
        Me.dtgridAppDateViewer.AllowUserToAddRows = False
        Me.dtgridAppDateViewer.AllowUserToDeleteRows = False
        Me.dtgridAppDateViewer.AllowUserToResizeColumns = False
        Me.dtgridAppDateViewer.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgridAppDateViewer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgridAppDateViewer.BackgroundColor = System.Drawing.Color.White
        Me.dtgridAppDateViewer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dtgridAppDateViewer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgridAppDateViewer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgridAppDateViewer.ColumnHeadersHeight = 50
        Me.dtgridAppDateViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgridAppDateViewer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientName, Me.StartTime, Me.EndTime})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgridAppDateViewer.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgridAppDateViewer.EnableHeadersVisualStyles = False
        Me.dtgridAppDateViewer.Location = New System.Drawing.Point(34, 107)
        Me.dtgridAppDateViewer.Name = "dtgridAppDateViewer"
        Me.dtgridAppDateViewer.ReadOnly = True
        Me.dtgridAppDateViewer.RowHeadersVisible = False
        Me.dtgridAppDateViewer.RowHeadersWidth = 20
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgridAppDateViewer.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgridAppDateViewer.RowTemplate.Height = 29
        Me.dtgridAppDateViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtgridAppDateViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgridAppDateViewer.Size = New System.Drawing.Size(501, 556)
        Me.dtgridAppDateViewer.TabIndex = 333
        '
        'PatientName
        '
        Me.PatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PatientName.HeaderText = "Last Name"
        Me.PatientName.MinimumWidth = 6
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(34, 98)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(501, 10)
        Me.Panel3.TabIndex = 350
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.btnAddProcedure6)
        Me.Panel2.Controls.Add(Me.btnAddProcedure5)
        Me.Panel2.Controls.Add(Me.btnAddProcedure4)
        Me.Panel2.Controls.Add(Me.txtboxDescription)
        Me.Panel2.Controls.Add(Me.lblProcedure6)
        Me.Panel2.Controls.Add(Me.lblDescription)
        Me.Panel2.Controls.Add(Me.cmbboxProcedure6)
        Me.Panel2.Controls.Add(Me.cmbboxProcedure)
        Me.Panel2.Controls.Add(Me.lblProcedure)
        Me.Panel2.Controls.Add(Me.btnAddProcedure2)
        Me.Panel2.Controls.Add(Me.lblProcedure5)
        Me.Panel2.Controls.Add(Me.cmbboxProcedure5)
        Me.Panel2.Controls.Add(Me.cmbboxProcedure2)
        Me.Panel2.Controls.Add(Me.btnAddProcedure3)
        Me.Panel2.Controls.Add(Me.lblProcedure2)
        Me.Panel2.Controls.Add(Me.lblProcedure4)
        Me.Panel2.Controls.Add(Me.cmbboxProcedure3)
        Me.Panel2.Controls.Add(Me.cmbboxProcedure4)
        Me.Panel2.Controls.Add(Me.lblProcedure3)
        Me.Panel2.Controls.Add(Me.btnDelete1)
        Me.Panel2.Controls.Add(Me.btnDelete2)
        Me.Panel2.Controls.Add(Me.btnDelete3)
        Me.Panel2.Controls.Add(Me.btnDelete4)
        Me.Panel2.Controls.Add(Me.btnDelete5)
        Me.Panel2.Location = New System.Drawing.Point(574, 275)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(675, 388)
        Me.Panel2.TabIndex = 348
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(450, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 17)
        Me.Label9.TabIndex = 351
        Me.Label9.Text = "*"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddProcedure6
        '
        Me.btnAddProcedure6.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAddProcedure6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProcedure6.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddProcedure6.FlatAppearance.BorderSize = 0
        Me.btnAddProcedure6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProcedure6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddProcedure6.ForeColor = System.Drawing.Color.Red
        Me.btnAddProcedure6.Image = CType(resources.GetObject("btnAddProcedure6.Image"), System.Drawing.Image)
        Me.btnAddProcedure6.Location = New System.Drawing.Point(21, 314)
        Me.btnAddProcedure6.Name = "btnAddProcedure6"
        Me.btnAddProcedure6.Size = New System.Drawing.Size(31, 28)
        Me.btnAddProcedure6.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.btnAddProcedure6, "Add new procedure")
        Me.btnAddProcedure6.UseVisualStyleBackColor = False
        Me.btnAddProcedure6.Visible = False
        '
        'btnAddProcedure5
        '
        Me.btnAddProcedure5.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAddProcedure5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProcedure5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddProcedure5.FlatAppearance.BorderSize = 0
        Me.btnAddProcedure5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProcedure5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddProcedure5.ForeColor = System.Drawing.Color.Red
        Me.btnAddProcedure5.Image = CType(resources.GetObject("btnAddProcedure5.Image"), System.Drawing.Image)
        Me.btnAddProcedure5.Location = New System.Drawing.Point(21, 255)
        Me.btnAddProcedure5.Name = "btnAddProcedure5"
        Me.btnAddProcedure5.Size = New System.Drawing.Size(31, 28)
        Me.btnAddProcedure5.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.btnAddProcedure5, "Add new procedure")
        Me.btnAddProcedure5.UseVisualStyleBackColor = False
        Me.btnAddProcedure5.Visible = False
        '
        'btnAddProcedure4
        '
        Me.btnAddProcedure4.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAddProcedure4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProcedure4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddProcedure4.FlatAppearance.BorderSize = 0
        Me.btnAddProcedure4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProcedure4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddProcedure4.ForeColor = System.Drawing.Color.Red
        Me.btnAddProcedure4.Image = CType(resources.GetObject("btnAddProcedure4.Image"), System.Drawing.Image)
        Me.btnAddProcedure4.Location = New System.Drawing.Point(20, 197)
        Me.btnAddProcedure4.Name = "btnAddProcedure4"
        Me.btnAddProcedure4.Size = New System.Drawing.Size(32, 28)
        Me.btnAddProcedure4.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.btnAddProcedure4, "Add new procedure")
        Me.btnAddProcedure4.UseVisualStyleBackColor = False
        Me.btnAddProcedure4.Visible = False
        '
        'txtboxDescription
        '
        Me.txtboxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxDescription.Location = New System.Drawing.Point(373, 45)
        Me.txtboxDescription.Multiline = True
        Me.txtboxDescription.Name = "txtboxDescription"
        Me.txtboxDescription.Size = New System.Drawing.Size(283, 321)
        Me.txtboxDescription.TabIndex = 21
        '
        'lblProcedure6
        '
        Me.lblProcedure6.AutoSize = True
        Me.lblProcedure6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProcedure6.ForeColor = System.Drawing.Color.Black
        Me.lblProcedure6.Location = New System.Drawing.Point(16, 316)
        Me.lblProcedure6.Name = "lblProcedure6"
        Me.lblProcedure6.Size = New System.Drawing.Size(88, 20)
        Me.lblProcedure6.TabIndex = 346
        Me.lblProcedure6.Text = "Procedure 6"
        Me.lblProcedure6.Visible = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Location = New System.Drawing.Point(368, 22)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(85, 20)
        Me.lblDescription.TabIndex = 304
        Me.lblDescription.Text = "Description"
        '
        'cmbboxProcedure6
        '
        Me.cmbboxProcedure6.BackColor = System.Drawing.Color.White
        Me.cmbboxProcedure6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxProcedure6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxProcedure6.FormattingEnabled = True
        Me.cmbboxProcedure6.Items.AddRange(New Object() {"Dental Check up", "Procedure 1", "Procedure 2", "Procedure 3"})
        Me.cmbboxProcedure6.Location = New System.Drawing.Point(20, 338)
        Me.cmbboxProcedure6.Name = "cmbboxProcedure6"
        Me.cmbboxProcedure6.Size = New System.Drawing.Size(291, 28)
        Me.cmbboxProcedure6.TabIndex = 19
        Me.cmbboxProcedure6.Visible = False
        '
        'cmbboxProcedure
        '
        Me.cmbboxProcedure.BackColor = System.Drawing.Color.White
        Me.cmbboxProcedure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxProcedure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxProcedure.FormattingEnabled = True
        Me.cmbboxProcedure.Items.AddRange(New Object() {"Dental Check up", "Procedure 1", "Procedure 2", "Procedure 3"})
        Me.cmbboxProcedure.Location = New System.Drawing.Point(20, 45)
        Me.cmbboxProcedure.Name = "cmbboxProcedure"
        Me.cmbboxProcedure.Size = New System.Drawing.Size(291, 28)
        Me.cmbboxProcedure.TabIndex = 5
        '
        'lblProcedure
        '
        Me.lblProcedure.AutoSize = True
        Me.lblProcedure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProcedure.ForeColor = System.Drawing.Color.Black
        Me.lblProcedure.Location = New System.Drawing.Point(16, 23)
        Me.lblProcedure.Name = "lblProcedure"
        Me.lblProcedure.Size = New System.Drawing.Size(76, 20)
        Me.lblProcedure.TabIndex = 301
        Me.lblProcedure.Text = "Procedure"
        '
        'btnAddProcedure2
        '
        Me.btnAddProcedure2.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAddProcedure2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProcedure2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddProcedure2.FlatAppearance.BorderSize = 0
        Me.btnAddProcedure2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProcedure2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddProcedure2.ForeColor = System.Drawing.Color.Red
        Me.btnAddProcedure2.Image = CType(resources.GetObject("btnAddProcedure2.Image"), System.Drawing.Image)
        Me.btnAddProcedure2.Location = New System.Drawing.Point(20, 80)
        Me.btnAddProcedure2.Name = "btnAddProcedure2"
        Me.btnAddProcedure2.Size = New System.Drawing.Size(32, 28)
        Me.btnAddProcedure2.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnAddProcedure2, "Add new procedure")
        Me.btnAddProcedure2.UseVisualStyleBackColor = False
        '
        'lblProcedure5
        '
        Me.lblProcedure5.AutoSize = True
        Me.lblProcedure5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProcedure5.ForeColor = System.Drawing.Color.Black
        Me.lblProcedure5.Location = New System.Drawing.Point(16, 257)
        Me.lblProcedure5.Name = "lblProcedure5"
        Me.lblProcedure5.Size = New System.Drawing.Size(88, 20)
        Me.lblProcedure5.TabIndex = 343
        Me.lblProcedure5.Text = "Procedure 5"
        Me.lblProcedure5.Visible = False
        '
        'cmbboxProcedure5
        '
        Me.cmbboxProcedure5.BackColor = System.Drawing.Color.White
        Me.cmbboxProcedure5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxProcedure5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxProcedure5.FormattingEnabled = True
        Me.cmbboxProcedure5.Items.AddRange(New Object() {"Dental Check up", "Procedure 1", "Procedure 2", "Procedure 3"})
        Me.cmbboxProcedure5.Location = New System.Drawing.Point(20, 279)
        Me.cmbboxProcedure5.Name = "cmbboxProcedure5"
        Me.cmbboxProcedure5.Size = New System.Drawing.Size(291, 28)
        Me.cmbboxProcedure5.TabIndex = 16
        Me.cmbboxProcedure5.Visible = False
        '
        'cmbboxProcedure2
        '
        Me.cmbboxProcedure2.BackColor = System.Drawing.Color.White
        Me.cmbboxProcedure2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxProcedure2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxProcedure2.FormattingEnabled = True
        Me.cmbboxProcedure2.Items.AddRange(New Object() {"Dental Check up", "Procedure 1", "Procedure 2", "Procedure 3"})
        Me.cmbboxProcedure2.Location = New System.Drawing.Point(20, 105)
        Me.cmbboxProcedure2.Name = "cmbboxProcedure2"
        Me.cmbboxProcedure2.Size = New System.Drawing.Size(291, 28)
        Me.cmbboxProcedure2.TabIndex = 7
        Me.cmbboxProcedure2.Visible = False
        '
        'btnAddProcedure3
        '
        Me.btnAddProcedure3.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAddProcedure3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProcedure3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddProcedure3.FlatAppearance.BorderSize = 0
        Me.btnAddProcedure3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProcedure3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddProcedure3.ForeColor = System.Drawing.Color.Red
        Me.btnAddProcedure3.Image = CType(resources.GetObject("btnAddProcedure3.Image"), System.Drawing.Image)
        Me.btnAddProcedure3.Location = New System.Drawing.Point(20, 140)
        Me.btnAddProcedure3.Name = "btnAddProcedure3"
        Me.btnAddProcedure3.Size = New System.Drawing.Size(32, 28)
        Me.btnAddProcedure3.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btnAddProcedure3, "Add new procedure")
        Me.btnAddProcedure3.UseVisualStyleBackColor = False
        Me.btnAddProcedure3.Visible = False
        '
        'lblProcedure2
        '
        Me.lblProcedure2.AutoSize = True
        Me.lblProcedure2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProcedure2.ForeColor = System.Drawing.Color.Black
        Me.lblProcedure2.Location = New System.Drawing.Point(16, 83)
        Me.lblProcedure2.Name = "lblProcedure2"
        Me.lblProcedure2.Size = New System.Drawing.Size(88, 20)
        Me.lblProcedure2.TabIndex = 307
        Me.lblProcedure2.Text = "Procedure 2"
        Me.lblProcedure2.Visible = False
        '
        'lblProcedure4
        '
        Me.lblProcedure4.AutoSize = True
        Me.lblProcedure4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProcedure4.ForeColor = System.Drawing.Color.Black
        Me.lblProcedure4.Location = New System.Drawing.Point(16, 198)
        Me.lblProcedure4.Name = "lblProcedure4"
        Me.lblProcedure4.Size = New System.Drawing.Size(88, 20)
        Me.lblProcedure4.TabIndex = 317
        Me.lblProcedure4.Text = "Procedure 4"
        Me.lblProcedure4.Visible = False
        '
        'cmbboxProcedure3
        '
        Me.cmbboxProcedure3.BackColor = System.Drawing.Color.White
        Me.cmbboxProcedure3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxProcedure3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxProcedure3.FormattingEnabled = True
        Me.cmbboxProcedure3.Items.AddRange(New Object() {"Dental Check up", "Procedure 1", "Procedure 2", "Procedure 3"})
        Me.cmbboxProcedure3.Location = New System.Drawing.Point(20, 162)
        Me.cmbboxProcedure3.Name = "cmbboxProcedure3"
        Me.cmbboxProcedure3.Size = New System.Drawing.Size(291, 28)
        Me.cmbboxProcedure3.TabIndex = 10
        Me.cmbboxProcedure3.Visible = False
        '
        'cmbboxProcedure4
        '
        Me.cmbboxProcedure4.BackColor = System.Drawing.Color.White
        Me.cmbboxProcedure4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxProcedure4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxProcedure4.FormattingEnabled = True
        Me.cmbboxProcedure4.Items.AddRange(New Object() {"Dental Check up", "Procedure 1", "Procedure 2", "Procedure 3"})
        Me.cmbboxProcedure4.Location = New System.Drawing.Point(20, 220)
        Me.cmbboxProcedure4.Name = "cmbboxProcedure4"
        Me.cmbboxProcedure4.Size = New System.Drawing.Size(291, 28)
        Me.cmbboxProcedure4.TabIndex = 13
        Me.cmbboxProcedure4.Visible = False
        '
        'lblProcedure3
        '
        Me.lblProcedure3.AutoSize = True
        Me.lblProcedure3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProcedure3.ForeColor = System.Drawing.Color.Black
        Me.lblProcedure3.Location = New System.Drawing.Point(16, 140)
        Me.lblProcedure3.Name = "lblProcedure3"
        Me.lblProcedure3.Size = New System.Drawing.Size(88, 20)
        Me.lblProcedure3.TabIndex = 312
        Me.lblProcedure3.Text = "Procedure 3"
        Me.lblProcedure3.Visible = False
        '
        'btnDelete1
        '
        Me.btnDelete1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnDelete1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDelete1.FlatAppearance.BorderSize = 0
        Me.btnDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete1.ForeColor = System.Drawing.Color.Red
        Me.btnDelete1.Image = CType(resources.GetObject("btnDelete1.Image"), System.Drawing.Image)
        Me.btnDelete1.Location = New System.Drawing.Point(317, 105)
        Me.btnDelete1.Name = "btnDelete1"
        Me.btnDelete1.Size = New System.Drawing.Size(32, 28)
        Me.btnDelete1.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.btnDelete1, "Delete procedure")
        Me.btnDelete1.UseVisualStyleBackColor = False
        Me.btnDelete1.Visible = False
        '
        'btnDelete2
        '
        Me.btnDelete2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnDelete2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDelete2.FlatAppearance.BorderSize = 0
        Me.btnDelete2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete2.ForeColor = System.Drawing.Color.Red
        Me.btnDelete2.Image = CType(resources.GetObject("btnDelete2.Image"), System.Drawing.Image)
        Me.btnDelete2.Location = New System.Drawing.Point(317, 162)
        Me.btnDelete2.Name = "btnDelete2"
        Me.btnDelete2.Size = New System.Drawing.Size(32, 28)
        Me.btnDelete2.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.btnDelete2, "Delete procedure")
        Me.btnDelete2.UseVisualStyleBackColor = False
        Me.btnDelete2.Visible = False
        '
        'btnDelete3
        '
        Me.btnDelete3.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnDelete3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDelete3.FlatAppearance.BorderSize = 0
        Me.btnDelete3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete3.ForeColor = System.Drawing.Color.Red
        Me.btnDelete3.Image = CType(resources.GetObject("btnDelete3.Image"), System.Drawing.Image)
        Me.btnDelete3.Location = New System.Drawing.Point(317, 220)
        Me.btnDelete3.Name = "btnDelete3"
        Me.btnDelete3.Size = New System.Drawing.Size(32, 28)
        Me.btnDelete3.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.btnDelete3, "Delete procedure")
        Me.btnDelete3.UseVisualStyleBackColor = False
        Me.btnDelete3.Visible = False
        '
        'btnDelete4
        '
        Me.btnDelete4.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnDelete4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDelete4.FlatAppearance.BorderSize = 0
        Me.btnDelete4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete4.ForeColor = System.Drawing.Color.Red
        Me.btnDelete4.Image = CType(resources.GetObject("btnDelete4.Image"), System.Drawing.Image)
        Me.btnDelete4.Location = New System.Drawing.Point(317, 279)
        Me.btnDelete4.Name = "btnDelete4"
        Me.btnDelete4.Size = New System.Drawing.Size(32, 28)
        Me.btnDelete4.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.btnDelete4, "Delete procedure")
        Me.btnDelete4.UseVisualStyleBackColor = False
        Me.btnDelete4.Visible = False
        '
        'btnDelete5
        '
        Me.btnDelete5.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnDelete5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDelete5.FlatAppearance.BorderSize = 0
        Me.btnDelete5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete5.ForeColor = System.Drawing.Color.Red
        Me.btnDelete5.Image = CType(resources.GetObject("btnDelete5.Image"), System.Drawing.Image)
        Me.btnDelete5.Location = New System.Drawing.Point(317, 337)
        Me.btnDelete5.Name = "btnDelete5"
        Me.btnDelete5.Size = New System.Drawing.Size(32, 28)
        Me.btnDelete5.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.btnDelete5, "Delete procedure")
        Me.btnDelete5.UseVisualStyleBackColor = False
        Me.btnDelete5.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtboxPatientName)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtboxPatientNo)
        Me.GroupBox2.Controls.Add(Me.cmbboxDentist)
        Me.GroupBox2.Controls.Add(Me.dtpickerAppDate)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblDuration)
        Me.GroupBox2.Controls.Add(Me.txtboxDuration)
        Me.GroupBox2.Controls.Add(Me.dtpickerEndTime)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblEndTime)
        Me.GroupBox2.Controls.Add(Me.dtpickerStartTime)
        Me.GroupBox2.Controls.Add(Me.lblStartTime)
        Me.GroupBox2.Location = New System.Drawing.Point(574, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(675, 221)
        Me.GroupBox2.TabIndex = 349
        Me.GroupBox2.TabStop = False
        '
        'txtboxPatientName
        '
        Me.txtboxPatientName.AccessibleName = "Patient Name"
        Me.txtboxPatientName.BackColor = System.Drawing.Color.White
        Me.txtboxPatientName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxPatientName.Enabled = False
        Me.txtboxPatientName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxPatientName.ForeColor = System.Drawing.Color.Black
        Me.txtboxPatientName.Location = New System.Drawing.Point(20, 50)
        Me.txtboxPatientName.Name = "txtboxPatientName"
        Me.txtboxPatientName.ReadOnly = True
        Me.txtboxPatientName.Size = New System.Drawing.Size(329, 25)
        Me.txtboxPatientName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(501, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 309
        Me.Label3.Text = "Input (yyyy/mm/dd)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(373, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 308
        Me.Label2.Text = "Appointment Date"
        '
        'txtboxPatientNo
        '
        Me.txtboxPatientNo.AccessibleName = "Patient Number"
        Me.txtboxPatientNo.BackColor = System.Drawing.Color.White
        Me.txtboxPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxPatientNo.Location = New System.Drawing.Point(20, 175)
        Me.txtboxPatientNo.Name = "txtboxPatientNo"
        Me.txtboxPatientNo.ReadOnly = True
        Me.txtboxPatientNo.Size = New System.Drawing.Size(329, 27)
        Me.txtboxPatientNo.TabIndex = 321
        Me.txtboxPatientNo.Visible = False
        '
        'cmbboxDentist
        '
        Me.cmbboxDentist.AccessibleName = "Dentist Name"
        Me.cmbboxDentist.BackColor = System.Drawing.Color.White
        Me.cmbboxDentist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxDentist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxDentist.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxDentist.ForeColor = System.Drawing.Color.Black
        Me.cmbboxDentist.FormattingEnabled = True
        Me.cmbboxDentist.Items.AddRange(New Object() {"Scheduled", "Cancelled", "Rescheduled", "Completed", "No Show"})
        Me.cmbboxDentist.Location = New System.Drawing.Point(20, 111)
        Me.cmbboxDentist.Name = "cmbboxDentist"
        Me.cmbboxDentist.Size = New System.Drawing.Size(329, 28)
        Me.cmbboxDentist.TabIndex = 2
        '
        'dtpickerAppDate
        '
        Me.dtpickerAppDate.AccessibleName = "Appointment Date"
        Me.dtpickerAppDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpickerAppDate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtpickerAppDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpickerAppDate.Location = New System.Drawing.Point(377, 50)
        Me.dtpickerAppDate.Name = "dtpickerAppDate"
        Me.dtpickerAppDate.Size = New System.Drawing.Size(279, 27)
        Me.dtpickerAppDate.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 325
        Me.Label5.Text = "Dentist Name"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDuration.ForeColor = System.Drawing.Color.Black
        Me.lblDuration.Location = New System.Drawing.Point(373, 153)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(67, 20)
        Me.lblDuration.TabIndex = 319
        Me.lblDuration.Text = "Duration"
        '
        'txtboxDuration
        '
        Me.txtboxDuration.AccessibleName = "Duration"
        Me.txtboxDuration.BackColor = System.Drawing.Color.White
        Me.txtboxDuration.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxDuration.Enabled = False
        Me.txtboxDuration.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxDuration.ForeColor = System.Drawing.Color.Black
        Me.txtboxDuration.Location = New System.Drawing.Point(377, 175)
        Me.txtboxDuration.Name = "txtboxDuration"
        Me.txtboxDuration.ReadOnly = True
        Me.txtboxDuration.Size = New System.Drawing.Size(279, 23)
        Me.txtboxDuration.TabIndex = 6
        '
        'dtpickerEndTime
        '
        Me.dtpickerEndTime.AccessibleName = "End Time"
        Me.dtpickerEndTime.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtpickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpickerEndTime.Location = New System.Drawing.Point(536, 112)
        Me.dtpickerEndTime.Name = "dtpickerEndTime"
        Me.dtpickerEndTime.ShowUpDown = True
        Me.dtpickerEndTime.Size = New System.Drawing.Size(120, 27)
        Me.dtpickerEndTime.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(16, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 323
        Me.Label6.Text = "Patient Name"
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEndTime.ForeColor = System.Drawing.Color.Black
        Me.lblEndTime.Location = New System.Drawing.Point(532, 90)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(71, 20)
        Me.lblEndTime.TabIndex = 316
        Me.lblEndTime.Text = "End Time"
        '
        'dtpickerStartTime
        '
        Me.dtpickerStartTime.AccessibleName = "Start Time"
        Me.dtpickerStartTime.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtpickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpickerStartTime.Location = New System.Drawing.Point(377, 112)
        Me.dtpickerStartTime.Name = "dtpickerStartTime"
        Me.dtpickerStartTime.ShowUpDown = True
        Me.dtpickerStartTime.Size = New System.Drawing.Size(140, 27)
        Me.dtpickerStartTime.TabIndex = 3
        Me.dtpickerStartTime.Value = New Date(2022, 10, 3, 1, 14, 0, 0)
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStartTime.ForeColor = System.Drawing.Color.Black
        Me.lblStartTime.Location = New System.Drawing.Point(373, 90)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(77, 20)
        Me.lblStartTime.TabIndex = 315
        Me.lblStartTime.Text = "Start Time"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.BackColor = System.Drawing.Color.White
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 50
        '
        'AddPatientAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1310, 903)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TopGrayPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddPatientAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopGrayPanel.ResumeLayout(False)
        Me.TopGrayPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtgridAppDateViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopGrayPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblProcedure4 As Label
    Friend WithEvents cmbboxProcedure4 As ComboBox
    Friend WithEvents btnAddProcedure2 As Button
    Friend WithEvents cmbboxProcedure3 As ComboBox
    Friend WithEvents lblProcedure3 As Label
    Friend WithEvents lblProcedure2 As Label
    Friend WithEvents cmbboxProcedure2 As ComboBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtboxDescription As TextBox
    Friend WithEvents cmbboxProcedure As ComboBox
    Friend WithEvents lblProcedure As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtboxPatientName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtboxPatientNo As TextBox
    Friend WithEvents dtpickerStartTime As DateTimePicker
    Friend WithEvents lblStartTime As Label
    Friend WithEvents lblEndTime As Label
    Friend WithEvents dtpickerEndTime As DateTimePicker
    Friend WithEvents txtboxDuration As TextBox
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblAppointmentStatus As Label
    Friend WithEvents cmbboxAppStatus As ComboBox
    Friend WithEvents dtpickerAppDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbboxDentist As ComboBox
    Friend WithEvents dtgridAppDateViewer As DataGridView
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents StartTime As DataGridViewTextBoxColumn
    Friend WithEvents EndTime As DataGridViewTextBoxColumn
    Friend WithEvents lblGridDate As Label
    Friend WithEvents btnAddProcedure4 As Button
    Friend WithEvents btnAddProcedure3 As Button
    Friend WithEvents btnAddProcedure6 As Button
    Friend WithEvents lblProcedure6 As Label
    Friend WithEvents cmbboxProcedure6 As ComboBox
    Friend WithEvents btnAddProcedure5 As Button
    Friend WithEvents lblProcedure5 As Label
    Friend WithEvents cmbboxProcedure5 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnDelete1 As Button
    Friend WithEvents btnDelete5 As Button
    Friend WithEvents btnDelete4 As Button
    Friend WithEvents btnDelete3 As Button
    Friend WithEvents btnDelete2 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
