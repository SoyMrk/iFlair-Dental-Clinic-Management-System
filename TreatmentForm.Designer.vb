<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TreatmentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TreatmentForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.dtpickerFilter = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbboxFilter = New System.Windows.Forms.ComboBox()
        Me.txtboxSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pnlTreatmentHistory = New System.Windows.Forms.Panel()
        Me.dataviewTreatment = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DatePaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gross = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Procedure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTreatmentHistory.SuspendLayout()
        CType(Me.dataviewTreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel9.Controls.Add(Me.dtpickerFilter)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Controls.Add(Me.cmbboxFilter)
        Me.Panel9.Controls.Add(Me.txtboxSearch)
        Me.Panel9.Controls.Add(Me.PictureBox3)
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1924, 63)
        Me.Panel9.TabIndex = 224
        '
        'dtpickerFilter
        '
        Me.dtpickerFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpickerFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpickerFilter.CustomFormat = "yyyy-dd-mm"
        Me.dtpickerFilter.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpickerFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpickerFilter.Location = New System.Drawing.Point(1376, 18)
        Me.dtpickerFilter.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpickerFilter.Name = "dtpickerFilter"
        Me.dtpickerFilter.Size = New System.Drawing.Size(133, 27)
        Me.dtpickerFilter.TabIndex = 214
        Me.dtpickerFilter.TabStop = False
        Me.ToolTip1.SetToolTip(Me.dtpickerFilter, "Use this to filter procedure history by treatment date")
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1195, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 28)
        Me.Label1.TabIndex = 209
        Me.Label1.Text = "Filter by:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbboxFilter
        '
        Me.cmbboxFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbboxFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cmbboxFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbboxFilter.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxFilter.ForeColor = System.Drawing.Color.White
        Me.cmbboxFilter.FormattingEnabled = True
        Me.cmbboxFilter.IntegralHeight = False
        Me.cmbboxFilter.Items.AddRange(New Object() {"All", "Today", "Week", "Month"})
        Me.cmbboxFilter.Location = New System.Drawing.Point(1265, 18)
        Me.cmbboxFilter.Name = "cmbboxFilter"
        Me.cmbboxFilter.Size = New System.Drawing.Size(105, 27)
        Me.cmbboxFilter.TabIndex = 39
        Me.cmbboxFilter.TabStop = False
        '
        'txtboxSearch
        '
        Me.txtboxSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxSearch.ForeColor = System.Drawing.Color.White
        Me.txtboxSearch.Location = New System.Drawing.Point(1544, 18)
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(358, 27)
        Me.txtboxSearch.TabIndex = 203
        Me.txtboxSearch.TabStop = False
        Me.txtboxSearch.Text = "  Search here"
        Me.ToolTip1.SetToolTip(Me.txtboxSearch, "Search by procedure name")
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1515, 18)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.PictureBox3.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox3.TabIndex = 204
        Me.PictureBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(8, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 25)
        Me.Label11.TabIndex = 202
        Me.Label11.Text = "Procedure History"
        '
        'pnlTreatmentHistory
        '
        Me.pnlTreatmentHistory.Controls.Add(Me.dataviewTreatment)
        Me.pnlTreatmentHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTreatmentHistory.Location = New System.Drawing.Point(0, 63)
        Me.pnlTreatmentHistory.Name = "pnlTreatmentHistory"
        Me.pnlTreatmentHistory.Size = New System.Drawing.Size(1924, 1014)
        Me.pnlTreatmentHistory.TabIndex = 235
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
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataviewTreatment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataviewTreatment.ColumnHeadersHeight = 50
        Me.dataviewTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataviewTreatment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TreatmentDate, Me.Procedure, Me.Gross, Me.AmountPaid, Me.Balance, Me.DatePaid})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataviewTreatment.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataviewTreatment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataviewTreatment.EnableHeadersVisualStyles = False
        Me.dataviewTreatment.Location = New System.Drawing.Point(0, 0)
        Me.dataviewTreatment.Name = "dataviewTreatment"
        Me.dataviewTreatment.ReadOnly = True
        Me.dataviewTreatment.RowHeadersVisible = False
        Me.dataviewTreatment.RowHeadersWidth = 20
        Me.dataviewTreatment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dataviewTreatment.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dataviewTreatment.RowTemplate.Height = 29
        Me.dataviewTreatment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataviewTreatment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataviewTreatment.ShowCellToolTips = False
        Me.dataviewTreatment.Size = New System.Drawing.Size(1924, 1014)
        Me.dataviewTreatment.TabIndex = 241
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        '
        'DatePaid
        '
        Me.DatePaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DatePaid.HeaderText = "Date Paid"
        Me.DatePaid.MinimumWidth = 6
        Me.DatePaid.Name = "DatePaid"
        Me.DatePaid.ReadOnly = True
        '
        'Balance
        '
        Me.Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Balance.HeaderText = "Balance"
        Me.Balance.MinimumWidth = 6
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        '
        'AmountPaid
        '
        Me.AmountPaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AmountPaid.HeaderText = "Total Amount Paid"
        Me.AmountPaid.MinimumWidth = 6
        Me.AmountPaid.Name = "AmountPaid"
        Me.AmountPaid.ReadOnly = True
        '
        'Gross
        '
        Me.Gross.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Gross.HeaderText = "Gross"
        Me.Gross.MinimumWidth = 6
        Me.Gross.Name = "Gross"
        Me.Gross.ReadOnly = True
        '
        'Procedure
        '
        Me.Procedure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Procedure.HeaderText = "Procedure"
        Me.Procedure.MinimumWidth = 6
        Me.Procedure.Name = "Procedure"
        Me.Procedure.ReadOnly = True
        '
        'TreatmentDate
        '
        Me.TreatmentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TreatmentDate.HeaderText = "Treatment Date"
        Me.TreatmentDate.MinimumWidth = 6
        Me.TreatmentDate.Name = "TreatmentDate"
        Me.TreatmentDate.ReadOnly = True
        '
        'TreatmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1077)
        Me.Controls.Add(Me.pnlTreatmentHistory)
        Me.Controls.Add(Me.Panel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TreatmentForm"
        Me.Text = "TreatmentForm"
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTreatmentHistory.ResumeLayout(False)
        CType(Me.dataviewTreatment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents pnlTreatmentHistory As Panel
    Friend WithEvents dataviewTreatment As DataGridView
    Friend WithEvents txtboxSearch As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents cmbboxFilter As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpickerFilter As DateTimePicker
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TreatmentDate As DataGridViewTextBoxColumn
    Friend WithEvents Procedure As DataGridViewTextBoxColumn
    Friend WithEvents Gross As DataGridViewTextBoxColumn
    Friend WithEvents AmountPaid As DataGridViewTextBoxColumn
    Friend WithEvents Balance As DataGridViewTextBoxColumn
    Friend WithEvents DatePaid As DataGridViewTextBoxColumn
End Class
