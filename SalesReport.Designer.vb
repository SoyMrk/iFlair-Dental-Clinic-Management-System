<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesReport))
        Me.TopGrayPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlSalesReport = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblSalesTitle = New System.Windows.Forms.Label()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblRemoveProc = New System.Windows.Forms.Label()
        Me.btnProcedureFilter = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rbWeekly = New System.Windows.Forms.RadioButton()
        Me.btnSelectDates = New System.Windows.Forms.Button()
        Me.rbDaily = New System.Windows.Forms.RadioButton()
        Me.rbMonthly = New System.Windows.Forms.RadioButton()
        Me.lblProcedures = New System.Windows.Forms.Label()
        Me.cmbboxProcedure = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.grpboxDateRange = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpickStart = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpickEnd = New System.Windows.Forms.DateTimePicker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopGrayPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpboxDateRange.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopGrayPanel
        '
        Me.TopGrayPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TopGrayPanel.Controls.Add(Me.Label1)
        Me.TopGrayPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopGrayPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopGrayPanel.Name = "TopGrayPanel"
        Me.TopGrayPanel.Size = New System.Drawing.Size(1906, 63)
        Me.TopGrayPanel.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 28)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Transaction Report"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(13, 1017)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1880, 13)
        Me.Panel4.TabIndex = 35
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1893, 76)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 954)
        Me.Panel3.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 954)
        Me.Panel2.TabIndex = 33
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 63)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1906, 13)
        Me.Panel7.TabIndex = 32
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlSalesReport)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(13, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1880, 941)
        Me.Panel1.TabIndex = 36
        '
        'pnlSalesReport
        '
        Me.pnlSalesReport.BackColor = System.Drawing.Color.White
        Me.pnlSalesReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSalesReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSalesReport.Location = New System.Drawing.Point(0, 354)
        Me.pnlSalesReport.Name = "pnlSalesReport"
        Me.pnlSalesReport.Size = New System.Drawing.Size(1880, 587)
        Me.pnlSalesReport.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lblSalesTitle)
        Me.Panel5.Controls.Add(Me.btnExcel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 257)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1880, 97)
        Me.Panel5.TabIndex = 6
        '
        'lblSalesTitle
        '
        Me.lblSalesTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSalesTitle.ForeColor = System.Drawing.Color.White
        Me.lblSalesTitle.Location = New System.Drawing.Point(16, 22)
        Me.lblSalesTitle.Name = "lblSalesTitle"
        Me.lblSalesTitle.Size = New System.Drawing.Size(1184, 55)
        Me.lblSalesTitle.TabIndex = 37
        Me.lblSalesTitle.Text = "Flair Dental Clinic Transaction Report"
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
        Me.btnExcel.Location = New System.Drawing.Point(1713, 30)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Padding = New System.Windows.Forms.Padding(5)
        Me.btnExcel.Size = New System.Drawing.Size(146, 38)
        Me.btnExcel.TabIndex = 43
        Me.btnExcel.Text = "Export to excel"
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnExcel, "Excel")
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 244)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1880, 13)
        Me.Panel8.TabIndex = 231
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GroupBox1)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.btnGenerateReport)
        Me.Panel6.Controls.Add(Me.grpboxDateRange)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1880, 244)
        Me.Panel6.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRemoveProc)
        Me.GroupBox1.Controls.Add(Me.btnProcedureFilter)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.rbWeekly)
        Me.GroupBox1.Controls.Add(Me.btnSelectDates)
        Me.GroupBox1.Controls.Add(Me.rbDaily)
        Me.GroupBox1.Controls.Add(Me.rbMonthly)
        Me.GroupBox1.Controls.Add(Me.lblProcedures)
        Me.GroupBox1.Controls.Add(Me.cmbboxProcedure)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 161)
        Me.GroupBox1.TabIndex = 230
        Me.GroupBox1.TabStop = False
        '
        'lblRemoveProc
        '
        Me.lblRemoveProc.AutoSize = True
        Me.lblRemoveProc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRemoveProc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblRemoveProc.ForeColor = System.Drawing.Color.Red
        Me.lblRemoveProc.Location = New System.Drawing.Point(332, 86)
        Me.lblRemoveProc.Name = "lblRemoveProc"
        Me.lblRemoveProc.Size = New System.Drawing.Size(63, 20)
        Me.lblRemoveProc.TabIndex = 233
        Me.lblRemoveProc.Text = "Remove"
        Me.ToolTip1.SetToolTip(Me.lblRemoveProc, "Remove filter")
        Me.lblRemoveProc.Visible = False
        '
        'btnProcedureFilter
        '
        Me.btnProcedureFilter.Location = New System.Drawing.Point(27, 96)
        Me.btnProcedureFilter.Name = "btnProcedureFilter"
        Me.btnProcedureFilter.Size = New System.Drawing.Size(158, 29)
        Me.btnProcedureFilter.TabIndex = 232
        Me.btnProcedureFilter.Text = "Filter by a Procedure"
        Me.btnProcedureFilter.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(7, 1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 20)
        Me.Label12.TabIndex = 231
        Me.Label12.Text = "Filter by"
        '
        'rbWeekly
        '
        Me.rbWeekly.AutoSize = True
        Me.rbWeekly.Location = New System.Drawing.Point(108, 49)
        Me.rbWeekly.Name = "rbWeekly"
        Me.rbWeekly.Size = New System.Drawing.Size(77, 24)
        Me.rbWeekly.TabIndex = 227
        Me.rbWeekly.TabStop = True
        Me.rbWeekly.Text = "Weekly"
        Me.rbWeekly.UseVisualStyleBackColor = True
        '
        'btnSelectDates
        '
        Me.btnSelectDates.Image = CType(resources.GetObject("btnSelectDates.Image"), System.Drawing.Image)
        Me.btnSelectDates.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSelectDates.Location = New System.Drawing.Point(296, 45)
        Me.btnSelectDates.Name = "btnSelectDates"
        Me.btnSelectDates.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btnSelectDates.Size = New System.Drawing.Size(99, 29)
        Me.btnSelectDates.TabIndex = 229
        Me.btnSelectDates.Text = "Custom"
        Me.btnSelectDates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelectDates.UseVisualStyleBackColor = True
        '
        'rbDaily
        '
        Me.rbDaily.AutoSize = True
        Me.rbDaily.Location = New System.Drawing.Point(27, 49)
        Me.rbDaily.Name = "rbDaily"
        Me.rbDaily.Size = New System.Drawing.Size(64, 24)
        Me.rbDaily.TabIndex = 225
        Me.rbDaily.TabStop = True
        Me.rbDaily.Text = "Daily"
        Me.rbDaily.UseVisualStyleBackColor = True
        '
        'rbMonthly
        '
        Me.rbMonthly.AutoSize = True
        Me.rbMonthly.Location = New System.Drawing.Point(204, 49)
        Me.rbMonthly.Name = "rbMonthly"
        Me.rbMonthly.Size = New System.Drawing.Size(84, 24)
        Me.rbMonthly.TabIndex = 226
        Me.rbMonthly.TabStop = True
        Me.rbMonthly.Text = "Monthly"
        Me.rbMonthly.UseVisualStyleBackColor = True
        '
        'lblProcedures
        '
        Me.lblProcedures.AutoSize = True
        Me.lblProcedures.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProcedures.ForeColor = System.Drawing.Color.Black
        Me.lblProcedures.Location = New System.Drawing.Point(22, 86)
        Me.lblProcedures.Name = "lblProcedures"
        Me.lblProcedures.Size = New System.Drawing.Size(84, 20)
        Me.lblProcedures.TabIndex = 216
        Me.lblProcedures.Text = "Procedure:"
        Me.lblProcedures.Visible = False
        '
        'cmbboxProcedure
        '
        Me.cmbboxProcedure.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbboxProcedure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxProcedure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxProcedure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbboxProcedure.ForeColor = System.Drawing.Color.Black
        Me.cmbboxProcedure.FormattingEnabled = True
        Me.cmbboxProcedure.IntegralHeight = False
        Me.cmbboxProcedure.Items.AddRange(New Object() {"All", "Cleaning", "Braces"})
        Me.cmbboxProcedure.Location = New System.Drawing.Point(27, 109)
        Me.cmbboxProcedure.Name = "cmbboxProcedure"
        Me.cmbboxProcedure.Size = New System.Drawing.Size(368, 28)
        Me.cmbboxProcedure.TabIndex = 223
        Me.cmbboxProcedure.TabStop = False
        Me.cmbboxProcedure.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(18, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Filters"
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerateReport.FlatAppearance.BorderSize = 0
        Me.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateReport.ForeColor = System.Drawing.Color.White
        Me.btnGenerateReport.Location = New System.Drawing.Point(463, 165)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(185, 49)
        Me.btnGenerateReport.TabIndex = 3
        Me.btnGenerateReport.Text = "Generate Report"
        Me.btnGenerateReport.UseVisualStyleBackColor = False
        '
        'grpboxDateRange
        '
        Me.grpboxDateRange.Controls.Add(Me.Label10)
        Me.grpboxDateRange.Controls.Add(Me.Label3)
        Me.grpboxDateRange.Controls.Add(Me.dtpickStart)
        Me.grpboxDateRange.Controls.Add(Me.Label4)
        Me.grpboxDateRange.Controls.Add(Me.dtpickEnd)
        Me.grpboxDateRange.Location = New System.Drawing.Point(463, 53)
        Me.grpboxDateRange.Name = "grpboxDateRange"
        Me.grpboxDateRange.Size = New System.Drawing.Size(531, 106)
        Me.grpboxDateRange.TabIndex = 6
        Me.grpboxDateRange.TabStop = False
        Me.grpboxDateRange.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(6, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 20)
        Me.Label10.TabIndex = 224
        Me.Label10.Text = "Date Range"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(23, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "From:"
        '
        'dtpickStart
        '
        Me.dtpickStart.CustomFormat = "yyyy-MM-dd"
        Me.dtpickStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpickStart.Location = New System.Drawing.Point(78, 49)
        Me.dtpickStart.Name = "dtpickStart"
        Me.dtpickStart.Size = New System.Drawing.Size(187, 27)
        Me.dtpickStart.TabIndex = 1
        Me.dtpickStart.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(282, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "To:"
        '
        'dtpickEnd
        '
        Me.dtpickEnd.CustomFormat = "yyyy-MM-dd"
        Me.dtpickEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpickEnd.Location = New System.Drawing.Point(317, 50)
        Me.dtpickEnd.Name = "dtpickEnd"
        Me.dtpickEnd.Size = New System.Drawing.Size(187, 27)
        Me.dtpickEnd.TabIndex = 2
        Me.dtpickEnd.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 20
        '
        'SalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1906, 1030)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.TopGrayPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SalesReport"
        Me.Text = "SalesReport"
        Me.TopGrayPanel.ResumeLayout(False)
        Me.TopGrayPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpboxDateRange.ResumeLayout(False)
        Me.grpboxDateRange.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopGrayPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpickStart As DateTimePicker
    Friend WithEvents dtpickEnd As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents pnlSalesReport As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblSalesTitle As Label
    Friend WithEvents lblProcedures As Label
    Friend WithEvents cmbboxProcedure As ComboBox
    Friend WithEvents rbWeekly As RadioButton
    Friend WithEvents rbMonthly As RadioButton
    Friend WithEvents rbDaily As RadioButton
    Friend WithEvents btnSelectDates As Button
    Friend WithEvents grpboxDateRange As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblRemoveProc As Label
    Friend WithEvents btnProcedureFilter As Button
End Class
