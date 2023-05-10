<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryHistory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TopGrayPanel = New System.Windows.Forms.Panel()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.txtboxProductName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlInventoryHistory = New System.Windows.Forms.Panel()
        Me.dataviewInvHist = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.InventoryNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSupplyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInitialStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNewBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStockUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopGrayPanel.SuspendLayout()
        Me.pnlInventoryHistory.SuspendLayout()
        CType(Me.dataviewInvHist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopGrayPanel
        '
        Me.TopGrayPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TopGrayPanel.Controls.Add(Me.btnExcel)
        Me.TopGrayPanel.Controls.Add(Me.txtboxProductName)
        Me.TopGrayPanel.Controls.Add(Me.Label2)
        Me.TopGrayPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopGrayPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopGrayPanel.Name = "TopGrayPanel"
        Me.TopGrayPanel.Size = New System.Drawing.Size(1290, 63)
        Me.TopGrayPanel.TabIndex = 11
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackColor = System.Drawing.Color.ForestGreen
        Me.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcel.FlatAppearance.BorderSize = 0
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(1142, 20)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Padding = New System.Windows.Forms.Padding(2)
        Me.btnExcel.Size = New System.Drawing.Size(135, 28)
        Me.btnExcel.TabIndex = 244
        Me.btnExcel.TabStop = False
        Me.btnExcel.Text = "Export to excel"
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'txtboxProductName
        '
        Me.txtboxProductName.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.txtboxProductName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxProductName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxProductName.ForeColor = System.Drawing.Color.White
        Me.txtboxProductName.Location = New System.Drawing.Point(142, 18)
        Me.txtboxProductName.Name = "txtboxProductName"
        Me.txtboxProductName.ReadOnly = True
        Me.txtboxProductName.Size = New System.Drawing.Size(333, 27)
        Me.txtboxProductName.TabIndex = 11
        Me.txtboxProductName.TabStop = False
        Me.txtboxProductName.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 28)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Inventory  -"
        '
        'pnlInventoryHistory
        '
        Me.pnlInventoryHistory.Controls.Add(Me.dataviewInvHist)
        Me.pnlInventoryHistory.Controls.Add(Me.Panel4)
        Me.pnlInventoryHistory.Controls.Add(Me.Panel3)
        Me.pnlInventoryHistory.Controls.Add(Me.Panel2)
        Me.pnlInventoryHistory.Controls.Add(Me.Panel1)
        Me.pnlInventoryHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInventoryHistory.Location = New System.Drawing.Point(0, 63)
        Me.pnlInventoryHistory.Name = "pnlInventoryHistory"
        Me.pnlInventoryHistory.Size = New System.Drawing.Size(1290, 679)
        Me.pnlInventoryHistory.TabIndex = 12
        '
        'dataviewInvHist
        '
        Me.dataviewInvHist.AllowUserToAddRows = False
        Me.dataviewInvHist.AllowUserToDeleteRows = False
        Me.dataviewInvHist.AllowUserToResizeColumns = False
        Me.dataviewInvHist.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dataviewInvHist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataviewInvHist.BackgroundColor = System.Drawing.Color.White
        Me.dataviewInvHist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataviewInvHist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dataviewInvHist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataviewInvHist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataviewInvHist.ColumnHeadersHeight = 50
        Me.dataviewInvHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataviewInvHist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InventoryNo, Me.colSupplyName, Me.colInitialStock, Me.colNewBalance, Me.colStockUnit, Me.colRemarks, Me.colDateUpdated})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataviewInvHist.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataviewInvHist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataviewInvHist.EnableHeadersVisualStyles = False
        Me.dataviewInvHist.Location = New System.Drawing.Point(13, 13)
        Me.dataviewInvHist.Name = "dataviewInvHist"
        Me.dataviewInvHist.ReadOnly = True
        Me.dataviewInvHist.RowHeadersVisible = False
        Me.dataviewInvHist.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataviewInvHist.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dataviewInvHist.RowTemplate.Height = 29
        Me.dataviewInvHist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataviewInvHist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataviewInvHist.Size = New System.Drawing.Size(1264, 653)
        Me.dataviewInvHist.TabIndex = 43
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(13, 666)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1264, 13)
        Me.Panel4.TabIndex = 46
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1277, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 666)
        Me.Panel3.TabIndex = 45
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 666)
        Me.Panel2.TabIndex = 44
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
        'InventoryNo
        '
        Me.InventoryNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.InventoryNo.HeaderText = "Inventory Number"
        Me.InventoryNo.MinimumWidth = 6
        Me.InventoryNo.Name = "InventoryNo"
        Me.InventoryNo.ReadOnly = True
        Me.InventoryNo.Visible = False
        '
        'colSupplyName
        '
        Me.colSupplyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSupplyName.HeaderText = "Supply Name"
        Me.colSupplyName.MinimumWidth = 6
        Me.colSupplyName.Name = "colSupplyName"
        Me.colSupplyName.ReadOnly = True
        '
        'colInitialStock
        '
        Me.colInitialStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colInitialStock.HeaderText = "Initial Stock"
        Me.colInitialStock.MinimumWidth = 6
        Me.colInitialStock.Name = "colInitialStock"
        Me.colInitialStock.ReadOnly = True
        '
        'colNewBalance
        '
        Me.colNewBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNewBalance.HeaderText = "New Balance"
        Me.colNewBalance.MinimumWidth = 6
        Me.colNewBalance.Name = "colNewBalance"
        Me.colNewBalance.ReadOnly = True
        '
        'colStockUnit
        '
        Me.colStockUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colStockUnit.HeaderText = "Unit"
        Me.colStockUnit.MinimumWidth = 6
        Me.colStockUnit.Name = "colStockUnit"
        Me.colStockUnit.ReadOnly = True
        '
        'colRemarks
        '
        Me.colRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colRemarks.HeaderText = "Remarks"
        Me.colRemarks.MinimumWidth = 6
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.ReadOnly = True
        '
        'colDateUpdated
        '
        Me.colDateUpdated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDateUpdated.HeaderText = "Date Updated"
        Me.colDateUpdated.MinimumWidth = 6
        Me.colDateUpdated.Name = "colDateUpdated"
        Me.colDateUpdated.ReadOnly = True
        '
        'InventoryHistory
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
        Me.Name = "InventoryHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopGrayPanel.ResumeLayout(False)
        Me.TopGrayPanel.PerformLayout()
        Me.pnlInventoryHistory.ResumeLayout(False)
        CType(Me.dataviewInvHist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopGrayPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlInventoryHistory As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dataviewInventoryList As DataGridView
    Friend WithEvents dataviewInvHist As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtboxProductName As TextBox
    Friend WithEvents btnExcel As Button
    Friend WithEvents InventoryNo As DataGridViewTextBoxColumn
    Friend WithEvents colSupplyName As DataGridViewTextBoxColumn
    Friend WithEvents colInitialStock As DataGridViewTextBoxColumn
    Friend WithEvents colNewBalance As DataGridViewTextBoxColumn
    Friend WithEvents colStockUnit As DataGridViewTextBoxColumn
    Friend WithEvents colRemarks As DataGridViewTextBoxColumn
    Friend WithEvents colDateUpdated As DataGridViewTextBoxColumn
End Class
