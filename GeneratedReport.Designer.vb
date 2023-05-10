<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneratedReport
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgridSalesReport = New System.Windows.Forms.DataGridView()
        Me.colPatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProcedure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTreatmentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLastPaymentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgridSalesReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgridSalesReport
        '
        Me.dtgridSalesReport.AllowUserToAddRows = False
        Me.dtgridSalesReport.AllowUserToDeleteRows = False
        Me.dtgridSalesReport.AllowUserToResizeColumns = False
        Me.dtgridSalesReport.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgridSalesReport.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgridSalesReport.BackgroundColor = System.Drawing.Color.White
        Me.dtgridSalesReport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgridSalesReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dtgridSalesReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgridSalesReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgridSalesReport.ColumnHeadersHeight = 50
        Me.dtgridSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgridSalesReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPatientName, Me.colProcedure, Me.colTreatmentDate, Me.colSalesAmount, Me.colBalance, Me.colLastPaymentDate})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgridSalesReport.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgridSalesReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgridSalesReport.EnableHeadersVisualStyles = False
        Me.dtgridSalesReport.GridColor = System.Drawing.Color.Silver
        Me.dtgridSalesReport.Location = New System.Drawing.Point(0, 0)
        Me.dtgridSalesReport.Name = "dtgridSalesReport"
        Me.dtgridSalesReport.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgridSalesReport.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgridSalesReport.RowHeadersVisible = False
        Me.dtgridSalesReport.RowHeadersWidth = 20
        Me.dtgridSalesReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgridSalesReport.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgridSalesReport.RowTemplate.Height = 29
        Me.dtgridSalesReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtgridSalesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgridSalesReport.ShowCellToolTips = False
        Me.dtgridSalesReport.Size = New System.Drawing.Size(1355, 743)
        Me.dtgridSalesReport.TabIndex = 3
        '
        'colPatientName
        '
        Me.colPatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPatientName.HeaderText = "Patient Name"
        Me.colPatientName.MinimumWidth = 6
        Me.colPatientName.Name = "colPatientName"
        Me.colPatientName.ReadOnly = True
        '
        'colProcedure
        '
        Me.colProcedure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colProcedure.HeaderText = "Procedure"
        Me.colProcedure.MinimumWidth = 6
        Me.colProcedure.Name = "colProcedure"
        Me.colProcedure.ReadOnly = True
        '
        'colTreatmentDate
        '
        Me.colTreatmentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTreatmentDate.HeaderText = "Treatment Date"
        Me.colTreatmentDate.MinimumWidth = 6
        Me.colTreatmentDate.Name = "colTreatmentDate"
        Me.colTreatmentDate.ReadOnly = True
        '
        'colSalesAmount
        '
        Me.colSalesAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSalesAmount.HeaderText = "Sales Amount"
        Me.colSalesAmount.MinimumWidth = 6
        Me.colSalesAmount.Name = "colSalesAmount"
        Me.colSalesAmount.ReadOnly = True
        '
        'colBalance
        '
        Me.colBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colBalance.HeaderText = "Balance"
        Me.colBalance.MinimumWidth = 6
        Me.colBalance.Name = "colBalance"
        Me.colBalance.ReadOnly = True
        '
        'colLastPaymentDate
        '
        Me.colLastPaymentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colLastPaymentDate.HeaderText = "Last Payment Date"
        Me.colLastPaymentDate.MinimumWidth = 6
        Me.colLastPaymentDate.Name = "colLastPaymentDate"
        Me.colLastPaymentDate.ReadOnly = True
        '
        'GeneratedReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1355, 743)
        Me.Controls.Add(Me.dtgridSalesReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GeneratedReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtgridSalesReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtboxSearchPatient As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents dtgridSalesReport As DataGridView
    Friend WithEvents colPatientName As DataGridViewTextBoxColumn
    Friend WithEvents colProcedure As DataGridViewTextBoxColumn
    Friend WithEvents colTreatmentDate As DataGridViewTextBoxColumn
    Friend WithEvents colSalesAmount As DataGridViewTextBoxColumn
    Friend WithEvents colBalance As DataGridViewTextBoxColumn
    Friend WithEvents colLastPaymentDate As DataGridViewTextBoxColumn
End Class
