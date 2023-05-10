<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Treatment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Treatment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TopGrayPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnResetFilter = New System.Windows.Forms.Button()
        Me.dtpickerFilter = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbboxFilterTransactions = New System.Windows.Forms.ComboBox()
        Me.pnldatagrid = New System.Windows.Forms.Panel()
        Me.dataviewTreatment = New System.Windows.Forms.DataGridView()
        Me.TreatmentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Procedure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gross = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtboxAppsFound = New System.Windows.Forms.TextBox()
        Me.txtboxTreatmentFound = New System.Windows.Forms.TextBox()
        Me.txtboxSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopGrayPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnldatagrid.SuspendLayout()
        CType(Me.dataviewTreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
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
        Me.TopGrayPanel.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 28)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Transaction"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(13, 1064)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1898, 13)
        Me.Panel4.TabIndex = 35
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1911, 125)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 952)
        Me.Panel3.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 952)
        Me.Panel2.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.dtpickerFilter)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbboxFilterTransactions)
        Me.Panel1.Controls.Add(Me.btnResetFilter)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1924, 62)
        Me.Panel1.TabIndex = 32
        '
        'btnResetFilter
        '
        Me.btnResetFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResetFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnResetFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetFilter.Image = CType(resources.GetObject("btnResetFilter.Image"), System.Drawing.Image)
        Me.btnResetFilter.Location = New System.Drawing.Point(1877, 18)
        Me.btnResetFilter.Name = "btnResetFilter"
        Me.btnResetFilter.Padding = New System.Windows.Forms.Padding(3)
        Me.btnResetFilter.Size = New System.Drawing.Size(33, 27)
        Me.btnResetFilter.TabIndex = 3
        Me.btnResetFilter.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnResetFilter, "Clear filter")
        Me.btnResetFilter.UseVisualStyleBackColor = False
        '
        'dtpickerFilter
        '
        Me.dtpickerFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpickerFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpickerFilter.CustomFormat = "yyyy-MM-dd"
        Me.dtpickerFilter.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpickerFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpickerFilter.Location = New System.Drawing.Point(1746, 18)
        Me.dtpickerFilter.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpickerFilter.Name = "dtpickerFilter"
        Me.dtpickerFilter.Size = New System.Drawing.Size(133, 27)
        Me.dtpickerFilter.TabIndex = 2
        Me.dtpickerFilter.TabStop = False
        Me.ToolTip1.SetToolTip(Me.dtpickerFilter, "Use this to filter transaction by treatment date")
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1565, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 213
        Me.Label2.Text = "Filter by:"
        '
        'cmbboxFilterTransactions
        '
        Me.cmbboxFilterTransactions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbboxFilterTransactions.BackColor = System.Drawing.SystemColors.Control
        Me.cmbboxFilterTransactions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxFilterTransactions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxFilterTransactions.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxFilterTransactions.ForeColor = System.Drawing.Color.Black
        Me.cmbboxFilterTransactions.FormattingEnabled = True
        Me.cmbboxFilterTransactions.IntegralHeight = False
        Me.cmbboxFilterTransactions.Items.AddRange(New Object() {"All", "Today", "Week", "Month"})
        Me.cmbboxFilterTransactions.Location = New System.Drawing.Point(1636, 18)
        Me.cmbboxFilterTransactions.Name = "cmbboxFilterTransactions"
        Me.cmbboxFilterTransactions.Size = New System.Drawing.Size(104, 27)
        Me.cmbboxFilterTransactions.TabIndex = 1
        Me.cmbboxFilterTransactions.TabStop = False
        '
        'pnldatagrid
        '
        Me.pnldatagrid.Controls.Add(Me.dataviewTreatment)
        Me.pnldatagrid.Controls.Add(Me.Panel6)
        Me.pnldatagrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnldatagrid.Location = New System.Drawing.Point(13, 125)
        Me.pnldatagrid.Name = "pnldatagrid"
        Me.pnldatagrid.Size = New System.Drawing.Size(1898, 939)
        Me.pnldatagrid.TabIndex = 36
        '
        'dataviewTreatment
        '
        Me.dataviewTreatment.AllowUserToAddRows = False
        Me.dataviewTreatment.AllowUserToDeleteRows = False
        Me.dataviewTreatment.AllowUserToResizeColumns = False
        Me.dataviewTreatment.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dataviewTreatment.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataviewTreatment.BackgroundColor = System.Drawing.Color.White
        Me.dataviewTreatment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataviewTreatment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dataviewTreatment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataviewTreatment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataviewTreatment.ColumnHeadersHeight = 50
        Me.dataviewTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataviewTreatment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TreatmentDate, Me.PatientName, Me.Procedure, Me.Gross, Me.TotalAmountPaid, Me.Balance})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataviewTreatment.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataviewTreatment.Dock = System.Windows.Forms.DockStyle.Top
        Me.dataviewTreatment.EnableHeadersVisualStyles = False
        Me.dataviewTreatment.Location = New System.Drawing.Point(0, 50)
        Me.dataviewTreatment.Name = "dataviewTreatment"
        Me.dataviewTreatment.ReadOnly = True
        Me.dataviewTreatment.RowHeadersVisible = False
        Me.dataviewTreatment.RowHeadersWidth = 20
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dataviewTreatment.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dataviewTreatment.RowTemplate.Height = 10
        Me.dataviewTreatment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataviewTreatment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataviewTreatment.ShowCellToolTips = False
        Me.dataviewTreatment.Size = New System.Drawing.Size(1898, 955)
        Me.dataviewTreatment.TabIndex = 233
        '
        'TreatmentDate
        '
        Me.TreatmentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TreatmentDate.HeaderText = "Treatment Date"
        Me.TreatmentDate.MinimumWidth = 6
        Me.TreatmentDate.Name = "TreatmentDate"
        Me.TreatmentDate.ReadOnly = True
        '
        'PatientName
        '
        Me.PatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PatientName.HeaderText = "Patient Name"
        Me.PatientName.MinimumWidth = 6
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
        '
        'Procedure
        '
        Me.Procedure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Procedure.HeaderText = "Procedure"
        Me.Procedure.MinimumWidth = 6
        Me.Procedure.Name = "Procedure"
        Me.Procedure.ReadOnly = True
        '
        'Gross
        '
        Me.Gross.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Gross.HeaderText = "Gross"
        Me.Gross.MinimumWidth = 6
        Me.Gross.Name = "Gross"
        Me.Gross.ReadOnly = True
        '
        'TotalAmountPaid
        '
        Me.TotalAmountPaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TotalAmountPaid.HeaderText = "Total Amount Paid"
        Me.TotalAmountPaid.MinimumWidth = 6
        Me.TotalAmountPaid.Name = "TotalAmountPaid"
        Me.TotalAmountPaid.ReadOnly = True
        '
        'Balance
        '
        Me.Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Balance.HeaderText = "Balance"
        Me.Balance.MinimumWidth = 6
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel6.Controls.Add(Me.txtboxAppsFound)
        Me.Panel6.Controls.Add(Me.txtboxTreatmentFound)
        Me.Panel6.Controls.Add(Me.txtboxSearch)
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1898, 50)
        Me.Panel6.TabIndex = 37
        '
        'txtboxAppsFound
        '
        Me.txtboxAppsFound.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxAppsFound.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtboxAppsFound.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxAppsFound.ForeColor = System.Drawing.Color.White
        Me.txtboxAppsFound.Location = New System.Drawing.Point(1715, 14)
        Me.txtboxAppsFound.Name = "txtboxAppsFound"
        Me.txtboxAppsFound.ReadOnly = True
        Me.txtboxAppsFound.Size = New System.Drawing.Size(168, 20)
        Me.txtboxAppsFound.TabIndex = 38
        Me.txtboxAppsFound.Text = "4 transaction/s found"
        Me.txtboxAppsFound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtboxTreatmentFound
        '
        Me.txtboxTreatmentFound.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxTreatmentFound.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtboxTreatmentFound.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxTreatmentFound.ForeColor = System.Drawing.Color.White
        Me.txtboxTreatmentFound.Location = New System.Drawing.Point(1729, 14)
        Me.txtboxTreatmentFound.Name = "txtboxTreatmentFound"
        Me.txtboxTreatmentFound.Size = New System.Drawing.Size(151, 20)
        Me.txtboxTreatmentFound.TabIndex = 1
        Me.txtboxTreatmentFound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtboxSearch
        '
        Me.txtboxSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxSearch.ForeColor = System.Drawing.Color.White
        Me.txtboxSearch.Location = New System.Drawing.Point(41, 11)
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(305, 27)
        Me.txtboxSearch.TabIndex = 19
        Me.txtboxSearch.Text = "  Search here"
        Me.ToolTip1.SetToolTip(Me.txtboxSearch, "Search by patient name and/or procedure")
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
        'Treatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1077)
        Me.Controls.Add(Me.pnldatagrid)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TopGrayPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Treatment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Treatment"
        Me.TopGrayPanel.ResumeLayout(False)
        Me.TopGrayPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnldatagrid.ResumeLayout(False)
        CType(Me.dataviewTreatment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopGrayPanel As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dataviewTreatment As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents pnldatagrid As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtboxTreatmentFound As TextBox
    Friend WithEvents txtboxSearch As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents chckboxToday As CheckBox
    Friend WithEvents cmbboxProcedure As ComboBox
    Friend WithEvents chckboxWeek As CheckBox
    Friend WithEvents chckboxMonth As CheckBox
    Friend WithEvents txtboxAppsFound As TextBox
    Friend WithEvents TreatmentDate As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents Procedure As DataGridViewTextBoxColumn
    Friend WithEvents Gross As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountPaid As DataGridViewTextBoxColumn
    Friend WithEvents Balance As DataGridViewTextBoxColumn
    Friend WithEvents cmbboxFilterTransactions As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDiscount As Button
    Friend WithEvents btnResetFilter As Button
    Friend WithEvents dtpickerFilter As DateTimePicker
    Friend WithEvents ToolTip1 As ToolTip
End Class
