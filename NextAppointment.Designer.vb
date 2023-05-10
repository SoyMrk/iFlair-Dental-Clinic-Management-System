<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NextAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NextAppointment))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblGridDate = New System.Windows.Forms.Label()
        Me.dtgridAppDateViewer = New System.Windows.Forms.DataGridView()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnAddProcedure6 = New System.Windows.Forms.Button()
        Me.btnAddProcedure3 = New System.Windows.Forms.Button()
        Me.btnAddProcedure5 = New System.Windows.Forms.Button()
        Me.btnAddProcedure4 = New System.Windows.Forms.Button()
        Me.btnAddProcedure2 = New System.Windows.Forms.Button()
        Me.btnDelete5 = New System.Windows.Forms.Button()
        Me.btnDelete4 = New System.Windows.Forms.Button()
        Me.btnDelete3 = New System.Windows.Forms.Button()
        Me.btnDelete2 = New System.Windows.Forms.Button()
        Me.btnDelete1 = New System.Windows.Forms.Button()
        Me.cmbboxProcedure = New System.Windows.Forms.ComboBox()
        Me.lblProcedure6 = New System.Windows.Forms.Label()
        Me.lblProcedure = New System.Windows.Forms.Label()
        Me.cmbboxProcedure2 = New System.Windows.Forms.ComboBox()
        Me.cmbboxProcedure6 = New System.Windows.Forms.ComboBox()
        Me.lblProcedure2 = New System.Windows.Forms.Label()
        Me.txtboxDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblProcedure3 = New System.Windows.Forms.Label()
        Me.cmbboxProcedure3 = New System.Windows.Forms.ComboBox()
        Me.lblProcedure5 = New System.Windows.Forms.Label()
        Me.cmbboxProcedure4 = New System.Windows.Forms.ComboBox()
        Me.lblProcedure4 = New System.Windows.Forms.Label()
        Me.cmbboxProcedure5 = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtboxDentistName = New System.Windows.Forms.TextBox()
        Me.cmbboxDentist = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtboxPatientName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxPatientNo = New System.Windows.Forms.TextBox()
        Me.dtpickerStartTime = New System.Windows.Forms.DateTimePicker()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.dtpickerEndTime = New System.Windows.Forms.DateTimePicker()
        Me.txtboxDuration = New System.Windows.Forms.TextBox()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.dtpickerAppDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgridAppDateViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(42, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 28)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Next Appointment"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 25)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1268, 68)
        Me.Panel1.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblGridDate)
        Me.Panel2.Controls.Add(Me.dtgridAppDateViewer)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1268, 778)
        Me.Panel2.TabIndex = 68
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(13, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 25)
        Me.Label10.TabIndex = 355
        Me.Label10.Text = "Appointment List"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGridDate
        '
        Me.lblGridDate.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblGridDate.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblGridDate.Location = New System.Drawing.Point(11, 53)
        Me.lblGridDate.Name = "lblGridDate"
        Me.lblGridDate.Size = New System.Drawing.Size(390, 25)
        Me.lblGridDate.TabIndex = 338
        Me.lblGridDate.Text = "Date:"
        '
        'dtgridAppDateViewer
        '
        Me.dtgridAppDateViewer.AccessibleName = "List of Appointment"
        Me.dtgridAppDateViewer.AllowUserToAddRows = False
        Me.dtgridAppDateViewer.AllowUserToDeleteRows = False
        Me.dtgridAppDateViewer.AllowUserToResizeColumns = False
        Me.dtgridAppDateViewer.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgridAppDateViewer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgridAppDateViewer.BackgroundColor = System.Drawing.Color.White
        Me.dtgridAppDateViewer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dtgridAppDateViewer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgridAppDateViewer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dtgridAppDateViewer.ColumnHeadersHeight = 50
        Me.dtgridAppDateViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgridAppDateViewer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LastName, Me.StartTime, Me.EndTime})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgridAppDateViewer.DefaultCellStyle = DataGridViewCellStyle7
        Me.dtgridAppDateViewer.EnableHeadersVisualStyles = False
        Me.dtgridAppDateViewer.Location = New System.Drawing.Point(16, 92)
        Me.dtgridAppDateViewer.Name = "dtgridAppDateViewer"
        Me.dtgridAppDateViewer.ReadOnly = True
        Me.dtgridAppDateViewer.RowHeadersVisible = False
        Me.dtgridAppDateViewer.RowHeadersWidth = 20
        Me.dtgridAppDateViewer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgridAppDateViewer.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dtgridAppDateViewer.RowTemplate.Height = 29
        Me.dtgridAppDateViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtgridAppDateViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgridAppDateViewer.ShowCellToolTips = False
        Me.dtgridAppDateViewer.Size = New System.Drawing.Size(385, 587)
        Me.dtgridAppDateViewer.TabIndex = 337
        '
        'LastName
        '
        Me.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.MinimumWidth = 6
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.btnAddProcedure6)
        Me.Panel4.Controls.Add(Me.btnAddProcedure3)
        Me.Panel4.Controls.Add(Me.btnAddProcedure5)
        Me.Panel4.Controls.Add(Me.btnAddProcedure4)
        Me.Panel4.Controls.Add(Me.btnAddProcedure2)
        Me.Panel4.Controls.Add(Me.btnDelete5)
        Me.Panel4.Controls.Add(Me.btnDelete4)
        Me.Panel4.Controls.Add(Me.btnDelete3)
        Me.Panel4.Controls.Add(Me.btnDelete2)
        Me.Panel4.Controls.Add(Me.btnDelete1)
        Me.Panel4.Controls.Add(Me.cmbboxProcedure)
        Me.Panel4.Controls.Add(Me.lblProcedure6)
        Me.Panel4.Controls.Add(Me.lblProcedure)
        Me.Panel4.Controls.Add(Me.cmbboxProcedure2)
        Me.Panel4.Controls.Add(Me.cmbboxProcedure6)
        Me.Panel4.Controls.Add(Me.lblProcedure2)
        Me.Panel4.Controls.Add(Me.txtboxDescription)
        Me.Panel4.Controls.Add(Me.lblDescription)
        Me.Panel4.Controls.Add(Me.lblProcedure3)
        Me.Panel4.Controls.Add(Me.cmbboxProcedure3)
        Me.Panel4.Controls.Add(Me.lblProcedure5)
        Me.Panel4.Controls.Add(Me.cmbboxProcedure4)
        Me.Panel4.Controls.Add(Me.lblProcedure4)
        Me.Panel4.Controls.Add(Me.cmbboxProcedure5)
        Me.Panel4.Location = New System.Drawing.Point(420, 280)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(827, 399)
        Me.Panel4.TabIndex = 354
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
        Me.btnAddProcedure6.Location = New System.Drawing.Point(25, 326)
        Me.btnAddProcedure6.Name = "btnAddProcedure6"
        Me.btnAddProcedure6.Size = New System.Drawing.Size(31, 28)
        Me.btnAddProcedure6.TabIndex = 16
        Me.btnAddProcedure6.UseVisualStyleBackColor = False
        Me.btnAddProcedure6.Visible = False
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
        Me.btnAddProcedure3.Location = New System.Drawing.Point(25, 134)
        Me.btnAddProcedure3.Name = "btnAddProcedure3"
        Me.btnAddProcedure3.Size = New System.Drawing.Size(31, 28)
        Me.btnAddProcedure3.TabIndex = 10
        Me.btnAddProcedure3.UseVisualStyleBackColor = False
        Me.btnAddProcedure3.Visible = False
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
        Me.btnAddProcedure5.Location = New System.Drawing.Point(25, 262)
        Me.btnAddProcedure5.Name = "btnAddProcedure5"
        Me.btnAddProcedure5.Size = New System.Drawing.Size(31, 28)
        Me.btnAddProcedure5.TabIndex = 14
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
        Me.btnAddProcedure4.Location = New System.Drawing.Point(25, 197)
        Me.btnAddProcedure4.Name = "btnAddProcedure4"
        Me.btnAddProcedure4.Size = New System.Drawing.Size(31, 28)
        Me.btnAddProcedure4.TabIndex = 12
        Me.btnAddProcedure4.UseVisualStyleBackColor = False
        Me.btnAddProcedure4.Visible = False
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
        Me.btnAddProcedure2.Location = New System.Drawing.Point(25, 71)
        Me.btnAddProcedure2.Name = "btnAddProcedure2"
        Me.btnAddProcedure2.Size = New System.Drawing.Size(31, 28)
        Me.btnAddProcedure2.TabIndex = 8
        Me.btnAddProcedure2.UseVisualStyleBackColor = False
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
        Me.btnDelete5.Location = New System.Drawing.Point(375, 351)
        Me.btnDelete5.Name = "btnDelete5"
        Me.btnDelete5.Size = New System.Drawing.Size(32, 28)
        Me.btnDelete5.TabIndex = 357
        Me.btnDelete5.UseVisualStyleBackColor = False
        Me.btnDelete5.Visible = False
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
        Me.btnDelete4.Location = New System.Drawing.Point(375, 290)
        Me.btnDelete4.Name = "btnDelete4"
        Me.btnDelete4.Size = New System.Drawing.Size(32, 28)
        Me.btnDelete4.TabIndex = 356
        Me.btnDelete4.UseVisualStyleBackColor = False
        Me.btnDelete4.Visible = False
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
        Me.btnDelete3.Location = New System.Drawing.Point(375, 226)
        Me.btnDelete3.Name = "btnDelete3"
        Me.btnDelete3.Size = New System.Drawing.Size(32, 28)
        Me.btnDelete3.TabIndex = 355
        Me.btnDelete3.UseVisualStyleBackColor = False
        Me.btnDelete3.Visible = False
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
        Me.btnDelete2.Location = New System.Drawing.Point(375, 161)
        Me.btnDelete2.Name = "btnDelete2"
        Me.btnDelete2.Size = New System.Drawing.Size(32, 28)
        Me.btnDelete2.TabIndex = 354
        Me.btnDelete2.UseVisualStyleBackColor = False
        Me.btnDelete2.Visible = False
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
        Me.btnDelete1.Location = New System.Drawing.Point(375, 98)
        Me.btnDelete1.Name = "btnDelete1"
        Me.btnDelete1.Size = New System.Drawing.Size(32, 28)
        Me.btnDelete1.TabIndex = 353
        Me.btnDelete1.UseVisualStyleBackColor = False
        Me.btnDelete1.Visible = False
        '
        'cmbboxProcedure
        '
        Me.cmbboxProcedure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxProcedure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxProcedure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxProcedure.FormattingEnabled = True
        Me.cmbboxProcedure.Items.AddRange(New Object() {"Dental Check up", "Procedure 1", "Procedure 2", "Procedure 3"})
        Me.cmbboxProcedure.Location = New System.Drawing.Point(25, 35)
        Me.cmbboxProcedure.Name = "cmbboxProcedure"
        Me.cmbboxProcedure.Size = New System.Drawing.Size(344, 28)
        Me.cmbboxProcedure.TabIndex = 7
        '
        'lblProcedure6
        '
        Me.lblProcedure6.AutoSize = True
        Me.lblProcedure6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProcedure6.ForeColor = System.Drawing.Color.Black
        Me.lblProcedure6.Location = New System.Drawing.Point(21, 329)
        Me.lblProcedure6.Name = "lblProcedure6"
        Me.lblProcedure6.Size = New System.Drawing.Size(88, 20)
        Me.lblProcedure6.TabIndex = 352
        Me.lblProcedure6.Text = "Procedure 6"
        Me.lblProcedure6.Visible = False
        '
        'lblProcedure
        '
        Me.lblProcedure.AutoSize = True
        Me.lblProcedure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProcedure.ForeColor = System.Drawing.Color.Black
        Me.lblProcedure.Location = New System.Drawing.Point(21, 13)
        Me.lblProcedure.Name = "lblProcedure"
        Me.lblProcedure.Size = New System.Drawing.Size(76, 20)
        Me.lblProcedure.TabIndex = 301
        Me.lblProcedure.Text = "Procedure"
        '
        'cmbboxProcedure2
        '
        Me.cmbboxProcedure2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxProcedure2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxProcedure2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxProcedure2.FormattingEnabled = True
        Me.cmbboxProcedure2.Items.AddRange(New Object() {"Dental Check up", "Procedure 1", "Procedure 2", "Procedure 3"})
        Me.cmbboxProcedure2.Location = New System.Drawing.Point(25, 98)
        Me.cmbboxProcedure2.Name = "cmbboxProcedure2"
        Me.cmbboxProcedure2.Size = New System.Drawing.Size(344, 28)
        Me.cmbboxProcedure2.TabIndex = 9
        Me.cmbboxProcedure2.Visible = False
        '
        'cmbboxProcedure6
        '
        Me.cmbboxProcedure6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxProcedure6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxProcedure6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxProcedure6.FormattingEnabled = True
        Me.cmbboxProcedure6.Items.AddRange(New Object() {"Dental Check up", "Procedure 1", "Procedure 2", "Procedure 3"})
        Me.cmbboxProcedure6.Location = New System.Drawing.Point(25, 351)
        Me.cmbboxProcedure6.Name = "cmbboxProcedure6"
        Me.cmbboxProcedure6.Size = New System.Drawing.Size(344, 28)
        Me.cmbboxProcedure6.TabIndex = 17
        Me.cmbboxProcedure6.Visible = False
        '
        'lblProcedure2
        '
        Me.lblProcedure2.AutoSize = True
        Me.lblProcedure2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProcedure2.ForeColor = System.Drawing.Color.Black
        Me.lblProcedure2.Location = New System.Drawing.Point(21, 76)
        Me.lblProcedure2.Name = "lblProcedure2"
        Me.lblProcedure2.Size = New System.Drawing.Size(88, 20)
        Me.lblProcedure2.TabIndex = 307
        Me.lblProcedure2.Text = "Procedure 2"
        Me.lblProcedure2.Visible = False
        '
        'txtboxDescription
        '
        Me.txtboxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxDescription.Location = New System.Drawing.Point(428, 36)
        Me.txtboxDescription.Multiline = True
        Me.txtboxDescription.Name = "txtboxDescription"
        Me.txtboxDescription.Size = New System.Drawing.Size(364, 343)
        Me.txtboxDescription.TabIndex = 18
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Location = New System.Drawing.Point(424, 14)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(85, 20)
        Me.lblDescription.TabIndex = 304
        Me.lblDescription.Text = "Description"
        '
        'lblProcedure3
        '
        Me.lblProcedure3.AutoSize = True
        Me.lblProcedure3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProcedure3.ForeColor = System.Drawing.Color.Black
        Me.lblProcedure3.Location = New System.Drawing.Point(21, 139)
        Me.lblProcedure3.Name = "lblProcedure3"
        Me.lblProcedure3.Size = New System.Drawing.Size(88, 20)
        Me.lblProcedure3.TabIndex = 312
        Me.lblProcedure3.Text = "Procedure 3"
        Me.lblProcedure3.Visible = False
        '
        'cmbboxProcedure3
        '
        Me.cmbboxProcedure3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxProcedure3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxProcedure3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxProcedure3.FormattingEnabled = True
        Me.cmbboxProcedure3.Items.AddRange(New Object() {"Dental Check up", "Procedure 1", "Procedure 2", "Procedure 3"})
        Me.cmbboxProcedure3.Location = New System.Drawing.Point(25, 161)
        Me.cmbboxProcedure3.Name = "cmbboxProcedure3"
        Me.cmbboxProcedure3.Size = New System.Drawing.Size(344, 28)
        Me.cmbboxProcedure3.TabIndex = 11
        Me.cmbboxProcedure3.Visible = False
        '
        'lblProcedure5
        '
        Me.lblProcedure5.AutoSize = True
        Me.lblProcedure5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProcedure5.ForeColor = System.Drawing.Color.Black
        Me.lblProcedure5.Location = New System.Drawing.Point(21, 268)
        Me.lblProcedure5.Name = "lblProcedure5"
        Me.lblProcedure5.Size = New System.Drawing.Size(88, 20)
        Me.lblProcedure5.TabIndex = 349
        Me.lblProcedure5.Text = "Procedure 5"
        Me.lblProcedure5.Visible = False
        '
        'cmbboxProcedure4
        '
        Me.cmbboxProcedure4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxProcedure4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxProcedure4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxProcedure4.FormattingEnabled = True
        Me.cmbboxProcedure4.Items.AddRange(New Object() {"Dental Check up", "Procedure 1", "Procedure 2", "Procedure 3"})
        Me.cmbboxProcedure4.Location = New System.Drawing.Point(25, 226)
        Me.cmbboxProcedure4.Name = "cmbboxProcedure4"
        Me.cmbboxProcedure4.Size = New System.Drawing.Size(344, 28)
        Me.cmbboxProcedure4.TabIndex = 13
        Me.cmbboxProcedure4.Visible = False
        '
        'lblProcedure4
        '
        Me.lblProcedure4.AutoSize = True
        Me.lblProcedure4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProcedure4.ForeColor = System.Drawing.Color.Black
        Me.lblProcedure4.Location = New System.Drawing.Point(21, 204)
        Me.lblProcedure4.Name = "lblProcedure4"
        Me.lblProcedure4.Size = New System.Drawing.Size(88, 20)
        Me.lblProcedure4.TabIndex = 317
        Me.lblProcedure4.Text = "Procedure 4"
        Me.lblProcedure4.Visible = False
        '
        'cmbboxProcedure5
        '
        Me.cmbboxProcedure5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxProcedure5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxProcedure5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxProcedure5.FormattingEnabled = True
        Me.cmbboxProcedure5.Items.AddRange(New Object() {"Dental Check up", "Procedure 1", "Procedure 2", "Procedure 3"})
        Me.cmbboxProcedure5.Location = New System.Drawing.Point(25, 290)
        Me.cmbboxProcedure5.Name = "cmbboxProcedure5"
        Me.cmbboxProcedure5.Size = New System.Drawing.Size(344, 28)
        Me.cmbboxProcedure5.TabIndex = 15
        Me.cmbboxProcedure5.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(16, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(385, 10)
        Me.Panel3.TabIndex = 339
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtboxDentistName)
        Me.GroupBox2.Controls.Add(Me.cmbboxDentist)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtboxPatientName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtboxPatientNo)
        Me.GroupBox2.Controls.Add(Me.dtpickerStartTime)
        Me.GroupBox2.Controls.Add(Me.lblStartTime)
        Me.GroupBox2.Controls.Add(Me.lblEndTime)
        Me.GroupBox2.Controls.Add(Me.dtpickerEndTime)
        Me.GroupBox2.Controls.Add(Me.txtboxDuration)
        Me.GroupBox2.Controls.Add(Me.lblDuration)
        Me.GroupBox2.Controls.Add(Me.dtpickerAppDate)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(420, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(827, 251)
        Me.GroupBox2.TabIndex = 307
        Me.GroupBox2.TabStop = False
        '
        'txtboxDentistName
        '
        Me.txtboxDentistName.BackColor = System.Drawing.Color.White
        Me.txtboxDentistName.Location = New System.Drawing.Point(42, 218)
        Me.txtboxDentistName.Name = "txtboxDentistName"
        Me.txtboxDentistName.ReadOnly = True
        Me.txtboxDentistName.Size = New System.Drawing.Size(364, 27)
        Me.txtboxDentistName.TabIndex = 328
        Me.txtboxDentistName.Visible = False
        '
        'cmbboxDentist
        '
        Me.cmbboxDentist.AccessibleName = "Dentisti Name"
        Me.cmbboxDentist.BackColor = System.Drawing.Color.White
        Me.cmbboxDentist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxDentist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxDentist.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxDentist.FormattingEnabled = True
        Me.cmbboxDentist.Items.AddRange(New Object() {"Princess", "Leo", "Jevah", "Mark"})
        Me.cmbboxDentist.Location = New System.Drawing.Point(42, 131)
        Me.cmbboxDentist.Name = "cmbboxDentist"
        Me.cmbboxDentist.Size = New System.Drawing.Size(364, 28)
        Me.cmbboxDentist.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(38, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 327
        Me.Label5.Text = "Dentist Name"
        '
        'txtboxPatientName
        '
        Me.txtboxPatientName.AccessibleName = "Patient Name"
        Me.txtboxPatientName.BackColor = System.Drawing.Color.White
        Me.txtboxPatientName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxPatientName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtboxPatientName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxPatientName.ForeColor = System.Drawing.Color.Black
        Me.txtboxPatientName.Location = New System.Drawing.Point(42, 67)
        Me.txtboxPatientName.Name = "txtboxPatientName"
        Me.txtboxPatientName.ReadOnly = True
        Me.txtboxPatientName.Size = New System.Drawing.Size(364, 25)
        Me.txtboxPatientName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(38, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 323
        Me.Label1.Text = "Patient Name"
        '
        'txtboxPatientNo
        '
        Me.txtboxPatientNo.AccessibleName = "Patient Number"
        Me.txtboxPatientNo.BackColor = System.Drawing.Color.White
        Me.txtboxPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxPatientNo.Location = New System.Drawing.Point(42, 189)
        Me.txtboxPatientNo.Name = "txtboxPatientNo"
        Me.txtboxPatientNo.ReadOnly = True
        Me.txtboxPatientNo.Size = New System.Drawing.Size(364, 27)
        Me.txtboxPatientNo.TabIndex = 321
        Me.txtboxPatientNo.Visible = False
        '
        'dtpickerStartTime
        '
        Me.dtpickerStartTime.AccessibleName = "Start Time"
        Me.dtpickerStartTime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpickerStartTime.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtpickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpickerStartTime.Location = New System.Drawing.Point(428, 131)
        Me.dtpickerStartTime.Name = "dtpickerStartTime"
        Me.dtpickerStartTime.ShowUpDown = True
        Me.dtpickerStartTime.Size = New System.Drawing.Size(185, 27)
        Me.dtpickerStartTime.TabIndex = 4
        Me.dtpickerStartTime.Value = New Date(2022, 10, 3, 1, 14, 0, 0)
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStartTime.ForeColor = System.Drawing.Color.Black
        Me.lblStartTime.Location = New System.Drawing.Point(424, 109)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(77, 20)
        Me.lblStartTime.TabIndex = 315
        Me.lblStartTime.Text = "Start Time"
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEndTime.ForeColor = System.Drawing.Color.Black
        Me.lblEndTime.Location = New System.Drawing.Point(615, 109)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(71, 20)
        Me.lblEndTime.TabIndex = 316
        Me.lblEndTime.Text = "End Time"
        '
        'dtpickerEndTime
        '
        Me.dtpickerEndTime.AccessibleName = "End Time"
        Me.dtpickerEndTime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpickerEndTime.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtpickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpickerEndTime.Location = New System.Drawing.Point(619, 131)
        Me.dtpickerEndTime.Name = "dtpickerEndTime"
        Me.dtpickerEndTime.ShowUpDown = True
        Me.dtpickerEndTime.Size = New System.Drawing.Size(173, 27)
        Me.dtpickerEndTime.TabIndex = 5
        '
        'txtboxDuration
        '
        Me.txtboxDuration.AccessibleName = "Duration"
        Me.txtboxDuration.BackColor = System.Drawing.Color.White
        Me.txtboxDuration.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxDuration.Enabled = False
        Me.txtboxDuration.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxDuration.ForeColor = System.Drawing.Color.Black
        Me.txtboxDuration.Location = New System.Drawing.Point(428, 191)
        Me.txtboxDuration.Name = "txtboxDuration"
        Me.txtboxDuration.ReadOnly = True
        Me.txtboxDuration.Size = New System.Drawing.Size(364, 23)
        Me.txtboxDuration.TabIndex = 6
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDuration.ForeColor = System.Drawing.Color.Black
        Me.lblDuration.Location = New System.Drawing.Point(424, 167)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(67, 20)
        Me.lblDuration.TabIndex = 319
        Me.lblDuration.Text = "Duration"
        '
        'dtpickerAppDate
        '
        Me.dtpickerAppDate.AccessibleName = "Appointment Date"
        Me.dtpickerAppDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpickerAppDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpickerAppDate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtpickerAppDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpickerAppDate.Location = New System.Drawing.Point(428, 73)
        Me.dtpickerAppDate.Name = "dtpickerAppDate"
        Me.dtpickerAppDate.Size = New System.Drawing.Size(364, 27)
        Me.dtpickerAppDate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(424, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 308
        Me.Label2.Text = "Appointment Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(556, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 309
        Me.Label3.Text = "Input (yyyy/mm/dd)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleName = "Cancel"
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(1105, 724)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 41)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.AccessibleName = "Save"
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(992, 724)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 41)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'NextAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1268, 846)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NextAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtgridAppDateViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpickerEndTime As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpickerStartTime As DateTimePicker
    Friend WithEvents txtboxPatientName As TextBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents List As ListBox
    Friend WithEvents txtboxDuration As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbboxProcedure As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents dtpickerAppDate As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblProcedure4 As Label
    Friend WithEvents cmbboxProcedure4 As ComboBox
    Friend WithEvents btnAddProcedure2 As Button
    Friend WithEvents btnAddProcedure4 As Button
    Friend WithEvents cmbboxProcedure3 As ComboBox
    Friend WithEvents lblProcedure3 As Label
    Friend WithEvents btnAddProcedure3 As Button
    Friend WithEvents lblProcedure2 As Label
    Friend WithEvents cmbboxProcedure2 As ComboBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtboxDescription As TextBox
    Friend WithEvents lblProcedure As Label
    Friend WithEvents txtboxPatientNo As TextBox
    Friend WithEvents lblStartTime As Label
    Friend WithEvents lblEndTime As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents cmbboxDentist As ComboBox
    Friend WithEvents btnAddProcedure6 As Button
    Friend WithEvents lblProcedure6 As Label
    Friend WithEvents cmbboxProcedure6 As ComboBox
    Friend WithEvents btnAddProcedure5 As Button
    Friend WithEvents lblProcedure5 As Label
    Friend WithEvents cmbboxProcedure5 As ComboBox
    Friend WithEvents lblGridDate As Label
    Friend WithEvents dtgridAppDateViewer As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents StartTime As DataGridViewTextBoxColumn
    Friend WithEvents EndTime As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete5 As Button
    Friend WithEvents btnDelete4 As Button
    Friend WithEvents btnDelete3 As Button
    Friend WithEvents btnDelete2 As Button
    Friend WithEvents btnDelete1 As Button
    Friend WithEvents txtboxDentistName As TextBox
    Friend WithEvents Label10 As Label
End Class
