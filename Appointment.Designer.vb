<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Appointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Appointment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbboxFilterStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrintapp = New System.Windows.Forms.Button()
        Me.cmbboxFilterDate = New System.Windows.Forms.ComboBox()
        Me.TopGrayPanel = New System.Windows.Forms.Panel()
        Me.paneladd = New System.Windows.Forms.Panel()
        Me.btnAddNewAppointment = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlDatagrid = New System.Windows.Forms.Panel()
        Me.dtGridAppointment = New System.Windows.Forms.DataGridView()
        Me.colPatID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAppID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPatName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAppDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDuration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDentistName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAppStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtboxAppsFound = New System.Windows.Forms.TextBox()
        Me.txtboxSearchApp = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PatientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TopGrayPanel.SuspendLayout()
        Me.paneladd.SuspendLayout()
        Me.pnlDatagrid.SuspendLayout()
        CType(Me.dtGridAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(13, 1064)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1898, 13)
        Me.Panel4.TabIndex = 31
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1911, 125)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 952)
        Me.Panel3.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 952)
        Me.Panel2.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.cmbboxFilterStatus)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnPrintapp)
        Me.Panel1.Controls.Add(Me.cmbboxFilterDate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1924, 62)
        Me.Panel1.TabIndex = 28
        '
        'cmbboxFilterStatus
        '
        Me.cmbboxFilterStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbboxFilterStatus.BackColor = System.Drawing.SystemColors.Control
        Me.cmbboxFilterStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxFilterStatus.ForeColor = System.Drawing.Color.Black
        Me.cmbboxFilterStatus.FormattingEnabled = True
        Me.cmbboxFilterStatus.IntegralHeight = False
        Me.cmbboxFilterStatus.Items.AddRange(New Object() {"No Filter", "Scheduled/Rescheduled", "Completed", "Cancelled", "No Show"})
        Me.cmbboxFilterStatus.Location = New System.Drawing.Point(1594, 18)
        Me.cmbboxFilterStatus.Name = "cmbboxFilterStatus"
        Me.cmbboxFilterStatus.Size = New System.Drawing.Size(166, 28)
        Me.cmbboxFilterStatus.TabIndex = 3
        Me.cmbboxFilterStatus.TabStop = False
        Me.ToolTip1.SetToolTip(Me.cmbboxFilterStatus, "Filter by appointment status")
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(1416, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 212
        Me.Label1.Text = "Filter by:"
        '
        'btnPrintapp
        '
        Me.btnPrintapp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintapp.BackColor = System.Drawing.Color.ForestGreen
        Me.btnPrintapp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintapp.FlatAppearance.BorderSize = 0
        Me.btnPrintapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintapp.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPrintapp.ForeColor = System.Drawing.Color.White
        Me.btnPrintapp.Image = CType(resources.GetObject("btnPrintapp.Image"), System.Drawing.Image)
        Me.btnPrintapp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintapp.Location = New System.Drawing.Point(1776, 18)
        Me.btnPrintapp.Name = "btnPrintapp"
        Me.btnPrintapp.Padding = New System.Windows.Forms.Padding(2)
        Me.btnPrintapp.Size = New System.Drawing.Size(135, 28)
        Me.btnPrintapp.TabIndex = 4
        Me.btnPrintapp.TabStop = False
        Me.btnPrintapp.Text = "Export to excel"
        Me.btnPrintapp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnPrintapp, "Export to Excel")
        Me.btnPrintapp.UseVisualStyleBackColor = False
        '
        'cmbboxFilterDate
        '
        Me.cmbboxFilterDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbboxFilterDate.BackColor = System.Drawing.SystemColors.Control
        Me.cmbboxFilterDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxFilterDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxFilterDate.ForeColor = System.Drawing.Color.Black
        Me.cmbboxFilterDate.FormattingEnabled = True
        Me.cmbboxFilterDate.IntegralHeight = False
        Me.cmbboxFilterDate.Items.AddRange(New Object() {"All", "Today", "Tomorrow", "Week", "Month"})
        Me.cmbboxFilterDate.Location = New System.Drawing.Point(1483, 18)
        Me.cmbboxFilterDate.Name = "cmbboxFilterDate"
        Me.cmbboxFilterDate.Size = New System.Drawing.Size(104, 28)
        Me.cmbboxFilterDate.TabIndex = 2
        Me.cmbboxFilterDate.TabStop = False
        '
        'TopGrayPanel
        '
        Me.TopGrayPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TopGrayPanel.Controls.Add(Me.paneladd)
        Me.TopGrayPanel.Controls.Add(Me.Label2)
        Me.TopGrayPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopGrayPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopGrayPanel.Name = "TopGrayPanel"
        Me.TopGrayPanel.Size = New System.Drawing.Size(1924, 63)
        Me.TopGrayPanel.TabIndex = 27
        '
        'paneladd
        '
        Me.paneladd.Controls.Add(Me.btnAddNewAppointment)
        Me.paneladd.Location = New System.Drawing.Point(151, 17)
        Me.paneladd.Name = "paneladd"
        Me.paneladd.Size = New System.Drawing.Size(31, 31)
        Me.paneladd.TabIndex = 23
        '
        'btnAddNewAppointment
        '
        Me.btnAddNewAppointment.BackColor = System.Drawing.Color.White
        Me.btnAddNewAppointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewAppointment.FlatAppearance.BorderSize = 0
        Me.btnAddNewAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnAddNewAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAddNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewAppointment.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddNewAppointment.ForeColor = System.Drawing.Color.White
        Me.btnAddNewAppointment.Image = CType(resources.GetObject("btnAddNewAppointment.Image"), System.Drawing.Image)
        Me.btnAddNewAppointment.Location = New System.Drawing.Point(-8, -4)
        Me.btnAddNewAppointment.Name = "btnAddNewAppointment"
        Me.btnAddNewAppointment.Size = New System.Drawing.Size(45, 38)
        Me.btnAddNewAppointment.TabIndex = 1
        Me.btnAddNewAppointment.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnAddNewAppointment, "Add new appointment")
        Me.btnAddNewAppointment.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 28)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Appointment"
        '
        'pnlDatagrid
        '
        Me.pnlDatagrid.Controls.Add(Me.dtGridAppointment)
        Me.pnlDatagrid.Controls.Add(Me.Panel6)
        Me.pnlDatagrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDatagrid.Location = New System.Drawing.Point(13, 125)
        Me.pnlDatagrid.Name = "pnlDatagrid"
        Me.pnlDatagrid.Size = New System.Drawing.Size(1898, 939)
        Me.pnlDatagrid.TabIndex = 34
        '
        'dtGridAppointment
        '
        Me.dtGridAppointment.AllowUserToAddRows = False
        Me.dtGridAppointment.AllowUserToDeleteRows = False
        Me.dtGridAppointment.AllowUserToResizeColumns = False
        Me.dtGridAppointment.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dtGridAppointment.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtGridAppointment.BackgroundColor = System.Drawing.Color.White
        Me.dtGridAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtGridAppointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dtGridAppointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtGridAppointment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtGridAppointment.ColumnHeadersHeight = 50
        Me.dtGridAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtGridAppointment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPatID, Me.colAppID, Me.colPatName, Me.colAppDate, Me.colDescription, Me.colStartTime, Me.colEndTime, Me.colDuration, Me.colDentistName, Me.colAppStatus})
        Me.dtGridAppointment.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtGridAppointment.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtGridAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridAppointment.EnableHeadersVisualStyles = False
        Me.dtGridAppointment.GridColor = System.Drawing.Color.Silver
        Me.dtGridAppointment.Location = New System.Drawing.Point(0, 50)
        Me.dtGridAppointment.Name = "dtGridAppointment"
        Me.dtGridAppointment.ReadOnly = True
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtGridAppointment.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtGridAppointment.RowHeadersVisible = False
        Me.dtGridAppointment.RowHeadersWidth = 20
        Me.dtGridAppointment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dtGridAppointment.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dtGridAppointment.RowTemplate.Height = 29
        Me.dtGridAppointment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtGridAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGridAppointment.ShowCellToolTips = False
        Me.dtGridAppointment.Size = New System.Drawing.Size(1898, 889)
        Me.dtGridAppointment.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.dtGridAppointment, "Click to view appointment details")
        '
        'colPatID
        '
        Me.colPatID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPatID.HeaderText = "PatientID"
        Me.colPatID.MinimumWidth = 6
        Me.colPatID.Name = "colPatID"
        Me.colPatID.ReadOnly = True
        Me.colPatID.Visible = False
        '
        'colAppID
        '
        Me.colAppID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colAppID.HeaderText = "AppID"
        Me.colAppID.MinimumWidth = 6
        Me.colAppID.Name = "colAppID"
        Me.colAppID.ReadOnly = True
        Me.colAppID.Visible = False
        '
        'colPatName
        '
        Me.colPatName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPatName.HeaderText = "Patient Name"
        Me.colPatName.MinimumWidth = 6
        Me.colPatName.Name = "colPatName"
        Me.colPatName.ReadOnly = True
        '
        'colAppDate
        '
        Me.colAppDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colAppDate.HeaderText = "Appointment Date"
        Me.colAppDate.MinimumWidth = 6
        Me.colAppDate.Name = "colAppDate"
        Me.colAppDate.ReadOnly = True
        '
        'colDescription
        '
        Me.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.MinimumWidth = 6
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        '
        'colStartTime
        '
        Me.colStartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colStartTime.HeaderText = "Start Time"
        Me.colStartTime.MinimumWidth = 6
        Me.colStartTime.Name = "colStartTime"
        Me.colStartTime.ReadOnly = True
        '
        'colEndTime
        '
        Me.colEndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEndTime.HeaderText = "End Time"
        Me.colEndTime.MinimumWidth = 6
        Me.colEndTime.Name = "colEndTime"
        Me.colEndTime.ReadOnly = True
        '
        'colDuration
        '
        Me.colDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDuration.HeaderText = "Duration"
        Me.colDuration.MinimumWidth = 6
        Me.colDuration.Name = "colDuration"
        Me.colDuration.ReadOnly = True
        '
        'colDentistName
        '
        Me.colDentistName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDentistName.HeaderText = "Dentist Name"
        Me.colDentistName.MinimumWidth = 6
        Me.colDentistName.Name = "colDentistName"
        Me.colDentistName.ReadOnly = True
        '
        'colAppStatus
        '
        Me.colAppStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colAppStatus.HeaderText = "Appointment Status"
        Me.colAppStatus.MinimumWidth = 6
        Me.colAppStatus.Name = "colAppStatus"
        Me.colAppStatus.ReadOnly = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.txtboxSearchApp)
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1898, 50)
        Me.Panel6.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.Controls.Add(Me.txtboxAppsFound)
        Me.Panel5.Location = New System.Drawing.Point(1693, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(215, 50)
        Me.Panel5.TabIndex = 31
        '
        'txtboxAppsFound
        '
        Me.txtboxAppsFound.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxAppsFound.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtboxAppsFound.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxAppsFound.ForeColor = System.Drawing.Color.White
        Me.txtboxAppsFound.Location = New System.Drawing.Point(3, 15)
        Me.txtboxAppsFound.Name = "txtboxAppsFound"
        Me.txtboxAppsFound.ReadOnly = True
        Me.txtboxAppsFound.Size = New System.Drawing.Size(192, 20)
        Me.txtboxAppsFound.TabIndex = 1
        Me.txtboxAppsFound.TabStop = False
        Me.txtboxAppsFound.Text = "4 appointments found"
        Me.txtboxAppsFound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtboxSearchApp
        '
        Me.txtboxSearchApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtboxSearchApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxSearchApp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxSearchApp.ForeColor = System.Drawing.Color.White
        Me.txtboxSearchApp.Location = New System.Drawing.Point(42, 11)
        Me.txtboxSearchApp.Name = "txtboxSearchApp"
        Me.txtboxSearchApp.Size = New System.Drawing.Size(305, 27)
        Me.txtboxSearchApp.TabIndex = 5
        Me.txtboxSearchApp.TabStop = False
        Me.txtboxSearchApp.Text = "  Search here"
        Me.ToolTip1.SetToolTip(Me.txtboxSearchApp, "Search by patient name and dentist name")
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(13, 11)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.PictureBox3.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'PatientID
        '
        Me.PatientID.HeaderText = "PatientID"
        Me.PatientID.MinimumWidth = 6
        Me.PatientID.Name = "PatientID"
        Me.PatientID.Visible = False
        Me.PatientID.Width = 125
        '
        'AppID
        '
        Me.AppID.HeaderText = "AppID"
        Me.AppID.MinimumWidth = 6
        Me.AppID.Name = "AppID"
        Me.AppID.Visible = False
        Me.AppID.Width = 125
        '
        'PatientName
        '
        Me.PatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PatientName.HeaderText = "Patient Name"
        Me.PatientName.MinimumWidth = 6
        Me.PatientName.Name = "PatientName"
        '
        'AppointmentDate
        '
        Me.AppointmentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AppointmentDate.HeaderText = "Appointment Date"
        Me.AppointmentDate.MinimumWidth = 6
        Me.AppointmentDate.Name = "AppointmentDate"
        '
        'StartTime
        '
        Me.StartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StartTime.HeaderText = "Start Time"
        Me.StartTime.MinimumWidth = 6
        Me.StartTime.Name = "StartTime"
        '
        'EndTime
        '
        Me.EndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EndTime.HeaderText = "End Time"
        Me.EndTime.MinimumWidth = 6
        Me.EndTime.Name = "EndTime"
        '
        'Duration
        '
        Me.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Duration.HeaderText = "Duration"
        Me.Duration.MinimumWidth = 6
        Me.Duration.Name = "Duration"
        '
        'AppStatus
        '
        Me.AppStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AppStatus.HeaderText = "Appoinment Status"
        Me.AppStatus.MinimumWidth = 6
        Me.AppStatus.Name = "AppStatus"
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
        'Appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1077)
        Me.Controls.Add(Me.pnlDatagrid)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TopGrayPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Appointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TopGrayPanel.ResumeLayout(False)
        Me.TopGrayPanel.PerformLayout()
        Me.paneladd.ResumeLayout(False)
        Me.pnlDatagrid.ResumeLayout(False)
        CType(Me.dtGridAppointment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TopGrayPanel As Panel
    Friend WithEvents pnlDatagrid As Panel
    Friend WithEvents btnAddNewAppointment As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dataGridAppointment As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnPayment As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtboxSearch As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents App As TextBox
    Friend WithEvents txtboxAppsFound As TextBox
    Friend WithEvents txtboxSearchApp As TextBox
    Friend WithEvents DateCreated As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewImageColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents cbmboxStatus As ComboBox
    Friend WithEvents PatientID As DataGridViewTextBoxColumn
    Friend WithEvents AppID As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentDate As DataGridViewTextBoxColumn
    Friend WithEvents StartTime As DataGridViewTextBoxColumn
    Friend WithEvents EndTime As DataGridViewTextBoxColumn
    Friend WithEvents Duration As DataGridViewTextBoxColumn
    Friend WithEvents AppStatus As DataGridViewTextBoxColumn
    Friend WithEvents dtGridAppointment As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cmbboxStatus As ComboBox
    Friend WithEvents cmbbocFilter As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbboxFilterStatus As ComboBox
    Friend WithEvents cmbboxFilterDate As ComboBox
    Friend WithEvents btnPrintapp As Button
    Friend WithEvents paneladd As Panel
    Private WithEvents ToolTip1 As ToolTip
    Friend WithEvents colPatID As DataGridViewTextBoxColumn
    Friend WithEvents colAppID As DataGridViewTextBoxColumn
    Friend WithEvents colPatName As DataGridViewTextBoxColumn
    Friend WithEvents colAppDate As DataGridViewTextBoxColumn
    Friend WithEvents colDescription As DataGridViewTextBoxColumn
    Friend WithEvents colStartTime As DataGridViewTextBoxColumn
    Friend WithEvents colEndTime As DataGridViewTextBoxColumn
    Friend WithEvents colDuration As DataGridViewTextBoxColumn
    Friend WithEvents colDentistName As DataGridViewTextBoxColumn
    Friend WithEvents colAppStatus As DataGridViewTextBoxColumn
End Class
