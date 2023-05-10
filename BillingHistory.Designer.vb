<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingHistory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BillingHistory))
        Me.TopGrayPanel = New System.Windows.Forms.Panel()
        Me.lblProcedures = New System.Windows.Forms.Label()
        Me.lblTreatmentDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlInventoryHistory = New System.Windows.Forms.Panel()
        Me.datagridBillingHistory = New System.Windows.Forms.DataGridView()
        Me.DatePaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopGrayPanel.SuspendLayout()
        Me.pnlInventoryHistory.SuspendLayout()
        CType(Me.datagridBillingHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopGrayPanel
        '
        Me.TopGrayPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TopGrayPanel.Controls.Add(Me.lblProcedures)
        Me.TopGrayPanel.Controls.Add(Me.lblTreatmentDate)
        Me.TopGrayPanel.Controls.Add(Me.Label2)
        Me.TopGrayPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopGrayPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopGrayPanel.Name = "TopGrayPanel"
        Me.TopGrayPanel.Size = New System.Drawing.Size(1290, 63)
        Me.TopGrayPanel.TabIndex = 12
        '
        'lblProcedures
        '
        Me.lblProcedures.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProcedures.ForeColor = System.Drawing.Color.White
        Me.lblProcedures.Location = New System.Drawing.Point(1069, 6)
        Me.lblProcedures.Name = "lblProcedures"
        Me.lblProcedures.Size = New System.Drawing.Size(205, 28)
        Me.lblProcedures.TabIndex = 9
        Me.lblProcedures.Text = "Billing History"
        Me.lblProcedures.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTreatmentDate
        '
        Me.lblTreatmentDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTreatmentDate.ForeColor = System.Drawing.Color.White
        Me.lblTreatmentDate.Location = New System.Drawing.Point(1121, 31)
        Me.lblTreatmentDate.Name = "lblTreatmentDate"
        Me.lblTreatmentDate.Size = New System.Drawing.Size(149, 28)
        Me.lblTreatmentDate.TabIndex = 9
        Me.lblTreatmentDate.Text = "Billing History"
        Me.lblTreatmentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 28)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Billing History"
        '
        'pnlInventoryHistory
        '
        Me.pnlInventoryHistory.Controls.Add(Me.datagridBillingHistory)
        Me.pnlInventoryHistory.Controls.Add(Me.Panel4)
        Me.pnlInventoryHistory.Controls.Add(Me.Panel3)
        Me.pnlInventoryHistory.Controls.Add(Me.Panel2)
        Me.pnlInventoryHistory.Controls.Add(Me.Panel1)
        Me.pnlInventoryHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInventoryHistory.Location = New System.Drawing.Point(0, 63)
        Me.pnlInventoryHistory.Name = "pnlInventoryHistory"
        Me.pnlInventoryHistory.Size = New System.Drawing.Size(1290, 679)
        Me.pnlInventoryHistory.TabIndex = 13
        '
        'datagridBillingHistory
        '
        Me.datagridBillingHistory.AllowUserToAddRows = False
        Me.datagridBillingHistory.AllowUserToDeleteRows = False
        Me.datagridBillingHistory.AllowUserToOrderColumns = True
        Me.datagridBillingHistory.AllowUserToResizeColumns = False
        Me.datagridBillingHistory.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.datagridBillingHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridBillingHistory.BackgroundColor = System.Drawing.Color.White
        Me.datagridBillingHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridBillingHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.datagridBillingHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridBillingHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridBillingHistory.ColumnHeadersHeight = 50
        Me.datagridBillingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagridBillingHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DatePaid, Me.Column11, Me.Column13, Me.Column12, Me.Column14})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridBillingHistory.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagridBillingHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridBillingHistory.EnableHeadersVisualStyles = False
        Me.datagridBillingHistory.Location = New System.Drawing.Point(13, 13)
        Me.datagridBillingHistory.Name = "datagridBillingHistory"
        Me.datagridBillingHistory.ReadOnly = True
        Me.datagridBillingHistory.RowHeadersVisible = False
        Me.datagridBillingHistory.RowHeadersWidth = 20
        Me.datagridBillingHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.datagridBillingHistory.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.datagridBillingHistory.RowTemplate.Height = 29
        Me.datagridBillingHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datagridBillingHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridBillingHistory.ShowCellToolTips = False
        Me.datagridBillingHistory.Size = New System.Drawing.Size(1264, 653)
        Me.datagridBillingHistory.TabIndex = 245
        '
        'DatePaid
        '
        Me.DatePaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DatePaid.HeaderText = "Date Paid"
        Me.DatePaid.MinimumWidth = 6
        Me.DatePaid.Name = "DatePaid"
        Me.DatePaid.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column11.HeaderText = "Gross"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column13.HeaderText = "Balance"
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column12.HeaderText = "Amount Paid"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column14.HeaderText = "New Balance"
        Me.Column14.MinimumWidth = 6
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(13, 666)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1264, 13)
        Me.Panel4.TabIndex = 248
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1277, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 666)
        Me.Panel3.TabIndex = 247
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 666)
        Me.Panel2.TabIndex = 246
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1290, 13)
        Me.Panel1.TabIndex = 12
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
        'BillingHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1290, 742)
        Me.Controls.Add(Me.pnlInventoryHistory)
        Me.Controls.Add(Me.TopGrayPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BillingHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopGrayPanel.ResumeLayout(False)
        Me.TopGrayPanel.PerformLayout()
        Me.pnlInventoryHistory.ResumeLayout(False)
        CType(Me.datagridBillingHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopGrayPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlInventoryHistory As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents datagridBillingHistory As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Discount As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents DatePaid As DataGridViewTextBoxColumn
    Friend WithEvents lblProcedures As Label
    Friend WithEvents lblTreatmentDate As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ToolTip1 As ToolTip
End Class
