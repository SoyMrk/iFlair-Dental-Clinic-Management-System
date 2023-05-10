<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientTransaction))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnResetFilter = New System.Windows.Forms.Button()
        Me.dtpickerFilter = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pnlBilling = New System.Windows.Forms.Panel()
        Me.datagridPatTransaction = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBilling.SuspendLayout()
        CType(Me.datagridPatTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel9.Controls.Add(Me.btnResetFilter)
        Me.Panel9.Controls.Add(Me.dtpickerFilter)
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Controls.Add(Me.txtboxSearch)
        Me.Panel9.Controls.Add(Me.PictureBox3)
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1924, 63)
        Me.Panel9.TabIndex = 224
        '
        'btnResetFilter
        '
        Me.btnResetFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResetFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnResetFilter.FlatAppearance.BorderSize = 0
        Me.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetFilter.Image = CType(resources.GetObject("btnResetFilter.Image"), System.Drawing.Image)
        Me.btnResetFilter.Location = New System.Drawing.Point(1470, 18)
        Me.btnResetFilter.Name = "btnResetFilter"
        Me.btnResetFilter.Size = New System.Drawing.Size(28, 27)
        Me.btnResetFilter.TabIndex = 216
        Me.btnResetFilter.UseVisualStyleBackColor = False
        '
        'dtpickerFilter
        '
        Me.dtpickerFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpickerFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpickerFilter.CustomFormat = "yyyy-dd-MM"
        Me.dtpickerFilter.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpickerFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpickerFilter.Location = New System.Drawing.Point(1337, 18)
        Me.dtpickerFilter.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpickerFilter.Name = "dtpickerFilter"
        Me.dtpickerFilter.Size = New System.Drawing.Size(133, 27)
        Me.dtpickerFilter.TabIndex = 214
        Me.dtpickerFilter.TabStop = False
        Me.ToolTip1.SetToolTip(Me.dtpickerFilter, "Use this to filter transaction history by treatment date")
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1266, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 215
        Me.Label2.Text = "Filter by:"
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
        Me.txtboxSearch.TabIndex = 212
        Me.txtboxSearch.TabStop = False
        Me.txtboxSearch.Text = "  Search here"
        Me.ToolTip1.SetToolTip(Me.txtboxSearch, " Search by procedure name")
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
        Me.PictureBox3.TabIndex = 213
        Me.PictureBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(186, 25)
        Me.Label11.TabIndex = 202
        Me.Label11.Text = "Transaction History"
        '
        'pnlBilling
        '
        Me.pnlBilling.Controls.Add(Me.datagridPatTransaction)
        Me.pnlBilling.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBilling.Location = New System.Drawing.Point(0, 63)
        Me.pnlBilling.Name = "pnlBilling"
        Me.pnlBilling.Size = New System.Drawing.Size(1924, 1014)
        Me.pnlBilling.TabIndex = 232
        '
        'datagridPatTransaction
        '
        Me.datagridPatTransaction.AllowUserToAddRows = False
        Me.datagridPatTransaction.AllowUserToDeleteRows = False
        Me.datagridPatTransaction.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.datagridPatTransaction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridPatTransaction.BackgroundColor = System.Drawing.Color.White
        Me.datagridPatTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridPatTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.datagridPatTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridPatTransaction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridPatTransaction.ColumnHeadersHeight = 50
        Me.datagridPatTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagridPatTransaction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column7, Me.Column10, Me.Column11, Me.Discount, Me.TotalAmountPaid, Me.Column12, Me.DatePaid})
        Me.datagridPatTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridPatTransaction.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagridPatTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridPatTransaction.EnableHeadersVisualStyles = False
        Me.datagridPatTransaction.Location = New System.Drawing.Point(0, 0)
        Me.datagridPatTransaction.Name = "datagridPatTransaction"
        Me.datagridPatTransaction.ReadOnly = True
        Me.datagridPatTransaction.RowHeadersVisible = False
        Me.datagridPatTransaction.RowHeadersWidth = 20
        Me.datagridPatTransaction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridPatTransaction.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.datagridPatTransaction.RowTemplate.Height = 29
        Me.datagridPatTransaction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datagridPatTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridPatTransaction.ShowCellToolTips = False
        Me.datagridPatTransaction.Size = New System.Drawing.Size(1924, 1014)
        Me.datagridPatTransaction.TabIndex = 244
        Me.ToolTip1.SetToolTip(Me.datagridPatTransaction, "Click to view transaction history")
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column8.HeaderText = "PaymentID"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        Me.Column8.Width = 125
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "Treatment Date"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.HeaderText = "Procedure"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column11.HeaderText = "Gross Amount"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Discount
        '
        Me.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Discount.HeaderText = "Discount"
        Me.Discount.MinimumWidth = 6
        Me.Discount.Name = "Discount"
        Me.Discount.ReadOnly = True
        '
        'TotalAmountPaid
        '
        Me.TotalAmountPaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TotalAmountPaid.HeaderText = "Total Amount Paid"
        Me.TotalAmountPaid.MinimumWidth = 6
        Me.TotalAmountPaid.Name = "TotalAmountPaid"
        Me.TotalAmountPaid.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column12.HeaderText = "Last Amount Paid"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'DatePaid
        '
        Me.DatePaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DatePaid.HeaderText = "Last Date Paid"
        Me.DatePaid.MinimumWidth = 6
        Me.DatePaid.Name = "DatePaid"
        Me.DatePaid.ReadOnly = True
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
        'PatientTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1077)
        Me.Controls.Add(Me.pnlBilling)
        Me.Controls.Add(Me.Panel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PatientTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PatientTransaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBilling.ResumeLayout(False)
        CType(Me.datagridPatTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents txtboxSearch As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pnlBilling As Panel
    Friend WithEvents datagridPatTransaction As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Discount As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountPaid As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents DatePaid As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpickerFilter As DateTimePicker
    Friend WithEvents btnResetFilter As Button
End Class
