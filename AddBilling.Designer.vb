<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddBilling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddBilling))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAddBilling = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblAddDiscount = New System.Windows.Forms.Label()
        Me.txtboxAmountPaid = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtboxChange = New System.Windows.Forms.TextBox()
        Me.lblBillingStatus = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.listboxProcedures = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbboxDiscount = New System.Windows.Forms.ComboBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtboxGross = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxBalance = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pnlInvoice = New System.Windows.Forms.Panel()
        Me.lblDiscountAmount2 = New System.Windows.Forms.Label()
        Me.lblDiscountAmount = New System.Windows.Forms.Label()
        Me.lblDiscountUsed2 = New System.Windows.Forms.Label()
        Me.lblDiscountUsed = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblTenderedAmount = New System.Windows.Forms.Label()
        Me.lblT = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDentistName = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.dtgridInvoice = New System.Windows.Forms.DataGridView()
        Me.Procedure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gross = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.lblBillingDate = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.line = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintInvoice = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.pnlInvoice.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgridInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblAddBilling)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1199, 68)
        Me.Panel1.TabIndex = 36
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 25)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblAddBilling
        '
        Me.lblAddBilling.AutoSize = True
        Me.lblAddBilling.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAddBilling.ForeColor = System.Drawing.Color.White
        Me.lblAddBilling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAddBilling.Location = New System.Drawing.Point(44, 19)
        Me.lblAddBilling.Name = "lblAddBilling"
        Me.lblAddBilling.Size = New System.Drawing.Size(134, 28)
        Me.lblAddBilling.TabIndex = 13
        Me.lblAddBilling.Text = "Add Payment"
        Me.lblAddBilling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblAddDiscount)
        Me.GroupBox2.Controls.Add(Me.txtboxAmountPaid)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtboxChange)
        Me.GroupBox2.Controls.Add(Me.lblBillingStatus)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.Panel6)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.listboxProcedures)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtboxTotal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbboxDiscount)
        Me.GroupBox2.Controls.Add(Me.lblDiscount)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtboxGross)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtboxBalance)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(465, 644)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        '
        'lblAddDiscount
        '
        Me.lblAddDiscount.AutoSize = True
        Me.lblAddDiscount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAddDiscount.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAddDiscount.ForeColor = System.Drawing.Color.Red
        Me.lblAddDiscount.Location = New System.Drawing.Point(41, 390)
        Me.lblAddDiscount.Name = "lblAddDiscount"
        Me.lblAddDiscount.Size = New System.Drawing.Size(134, 25)
        Me.lblAddDiscount.TabIndex = 316
        Me.lblAddDiscount.Text = "Add Discount?"
        '
        'txtboxAmountPaid
        '
        Me.txtboxAmountPaid.AccessibleName = "Amount Paid"
        Me.txtboxAmountPaid.Location = New System.Drawing.Point(46, 463)
        Me.txtboxAmountPaid.Name = "txtboxAmountPaid"
        Me.txtboxAmountPaid.Size = New System.Drawing.Size(374, 27)
        Me.txtboxAmountPaid.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(168, 444)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 17)
        Me.Label17.TabIndex = 216
        Me.Label17.Text = "*"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtboxChange
        '
        Me.txtboxChange.AccessibleName = "Amount Paid"
        Me.txtboxChange.BackColor = System.Drawing.Color.White
        Me.txtboxChange.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxChange.Enabled = False
        Me.txtboxChange.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxChange.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtboxChange.Location = New System.Drawing.Point(46, 527)
        Me.txtboxChange.Name = "txtboxChange"
        Me.txtboxChange.ReadOnly = True
        Me.txtboxChange.Size = New System.Drawing.Size(374, 23)
        Me.txtboxChange.TabIndex = 3
        Me.txtboxChange.Text = "0"
        '
        'lblBillingStatus
        '
        Me.lblBillingStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBillingStatus.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblBillingStatus.Location = New System.Drawing.Point(41, 589)
        Me.lblBillingStatus.Name = "lblBillingStatus"
        Me.lblBillingStatus.Size = New System.Drawing.Size(375, 23)
        Me.lblBillingStatus.TabIndex = 315
        Me.lblBillingStatus.Text = "Complete"
        Me.lblBillingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(42, 505)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 20)
        Me.Label15.TabIndex = 314
        Me.Label15.Text = "Change"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(44, 52)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(376, 10)
        Me.Panel4.TabIndex = 312
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gray
        Me.Panel6.Location = New System.Drawing.Point(44, 54)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(376, 10)
        Me.Panel6.TabIndex = 311
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(44, 185)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(376, 10)
        Me.Panel2.TabIndex = 131
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Location = New System.Drawing.Point(44, 183)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(376, 10)
        Me.Panel3.TabIndex = 130
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(139, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 310
        Me.Label4.Text = "Discount included"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'listboxProcedures
        '
        Me.listboxProcedures.AccessibleName = "List of Procedure"
        Me.listboxProcedures.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listboxProcedures.Enabled = False
        Me.listboxProcedures.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.listboxProcedures.ForeColor = System.Drawing.Color.Black
        Me.listboxProcedures.FormattingEnabled = True
        Me.listboxProcedures.ItemHeight = 23
        Me.listboxProcedures.Location = New System.Drawing.Point(44, 63)
        Me.listboxProcedures.Name = "listboxProcedures"
        Me.listboxProcedures.Size = New System.Drawing.Size(374, 115)
        Me.listboxProcedures.TabIndex = 183
        Me.listboxProcedures.TabStop = False
        Me.ToolTip1.SetToolTip(Me.listboxProcedures, "Procedure and price")
        Me.listboxProcedures.UseTabStops = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(42, 565)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 180
        Me.Label1.Text = "Billing Status"
        '
        'txtboxTotal
        '
        Me.txtboxTotal.AccessibleName = "Total Amount"
        Me.txtboxTotal.BackColor = System.Drawing.Color.White
        Me.txtboxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxTotal.Enabled = False
        Me.txtboxTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxTotal.Location = New System.Drawing.Point(46, 287)
        Me.txtboxTotal.Name = "txtboxTotal"
        Me.txtboxTotal.ReadOnly = True
        Me.txtboxTotal.Size = New System.Drawing.Size(374, 23)
        Me.txtboxTotal.TabIndex = 182
        Me.txtboxTotal.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(42, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 181
        Me.Label5.Text = "Total Amount"
        '
        'cmbboxDiscount
        '
        Me.cmbboxDiscount.AccessibleName = "Discount"
        Me.cmbboxDiscount.BackColor = System.Drawing.Color.White
        Me.cmbboxDiscount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxDiscount.FormattingEnabled = True
        Me.cmbboxDiscount.Items.AddRange(New Object() {"DISC 1"})
        Me.cmbboxDiscount.Location = New System.Drawing.Point(46, 402)
        Me.cmbboxDiscount.Name = "cmbboxDiscount"
        Me.cmbboxDiscount.Size = New System.Drawing.Size(374, 28)
        Me.cmbboxDiscount.TabIndex = 1
        Me.cmbboxDiscount.Visible = False
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDiscount.ForeColor = System.Drawing.Color.Black
        Me.lblDiscount.Location = New System.Drawing.Point(42, 380)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(67, 20)
        Me.lblDiscount.TabIndex = 178
        Me.lblDiscount.Text = "Discount"
        Me.lblDiscount.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(42, 441)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 20)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Tendered Amount"
        '
        'txtboxGross
        '
        Me.txtboxGross.AccessibleName = "Gross"
        Me.txtboxGross.BackColor = System.Drawing.Color.White
        Me.txtboxGross.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxGross.Enabled = False
        Me.txtboxGross.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxGross.ForeColor = System.Drawing.Color.Black
        Me.txtboxGross.Location = New System.Drawing.Point(46, 230)
        Me.txtboxGross.Name = "txtboxGross"
        Me.txtboxGross.ReadOnly = True
        Me.txtboxGross.Size = New System.Drawing.Size(374, 23)
        Me.txtboxGross.TabIndex = 58
        Me.txtboxGross.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(42, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 20)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Gross Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(42, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Procedure"
        '
        'txtboxBalance
        '
        Me.txtboxBalance.AccessibleName = "Balance"
        Me.txtboxBalance.BackColor = System.Drawing.Color.White
        Me.txtboxBalance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxBalance.Enabled = False
        Me.txtboxBalance.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxBalance.ForeColor = System.Drawing.Color.Black
        Me.txtboxBalance.Location = New System.Drawing.Point(46, 344)
        Me.txtboxBalance.Name = "txtboxBalance"
        Me.txtboxBalance.ReadOnly = True
        Me.txtboxBalance.Size = New System.Drawing.Size(374, 23)
        Me.txtboxBalance.TabIndex = 52
        Me.txtboxBalance.TabStop = False
        Me.txtboxBalance.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(42, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Balance"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(1080, 783)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 41)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(967, 783)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 41)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'pnlInvoice
        '
        Me.pnlInvoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.pnlInvoice.Controls.Add(Me.lblDiscountAmount2)
        Me.pnlInvoice.Controls.Add(Me.lblDiscountAmount)
        Me.pnlInvoice.Controls.Add(Me.lblDiscountUsed2)
        Me.pnlInvoice.Controls.Add(Me.lblDiscountUsed)
        Me.pnlInvoice.Controls.Add(Me.lblChange)
        Me.pnlInvoice.Controls.Add(Me.Label19)
        Me.pnlInvoice.Controls.Add(Me.lblTenderedAmount)
        Me.pnlInvoice.Controls.Add(Me.lblT)
        Me.pnlInvoice.Controls.Add(Me.PictureBox2)
        Me.pnlInvoice.Controls.Add(Me.Label13)
        Me.pnlInvoice.Controls.Add(Me.Label10)
        Me.pnlInvoice.Controls.Add(Me.Label9)
        Me.pnlInvoice.Controls.Add(Me.lblDentistName)
        Me.pnlInvoice.Controls.Add(Me.Label16)
        Me.pnlInvoice.Controls.Add(Me.lblDueDate)
        Me.pnlInvoice.Controls.Add(Me.Label14)
        Me.pnlInvoice.Controls.Add(Me.lblTotal)
        Me.pnlInvoice.Controls.Add(Me.Label11)
        Me.pnlInvoice.Controls.Add(Me.lblInvoiceNo)
        Me.pnlInvoice.Controls.Add(Me.dtgridInvoice)
        Me.pnlInvoice.Controls.Add(Me.lblPhoneNumber)
        Me.pnlInvoice.Controls.Add(Me.Label6)
        Me.pnlInvoice.Controls.Add(Me.lblPatientName)
        Me.pnlInvoice.Controls.Add(Me.lblBillingDate)
        Me.pnlInvoice.Controls.Add(Me.Panel5)
        Me.pnlInvoice.Controls.Add(Me.Label12)
        Me.pnlInvoice.Location = New System.Drawing.Point(504, 120)
        Me.pnlInvoice.Name = "pnlInvoice"
        Me.pnlInvoice.Size = New System.Drawing.Size(683, 634)
        Me.pnlInvoice.TabIndex = 56
        '
        'lblDiscountAmount2
        '
        Me.lblDiscountAmount2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDiscountAmount2.ForeColor = System.Drawing.Color.DimGray
        Me.lblDiscountAmount2.Location = New System.Drawing.Point(521, 555)
        Me.lblDiscountAmount2.Name = "lblDiscountAmount2"
        Me.lblDiscountAmount2.Size = New System.Drawing.Size(151, 25)
        Me.lblDiscountAmount2.TabIndex = 137
        Me.lblDiscountAmount2.Text = "0"
        Me.lblDiscountAmount2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscountAmount
        '
        Me.lblDiscountAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDiscountAmount.ForeColor = System.Drawing.Color.DimGray
        Me.lblDiscountAmount.Location = New System.Drawing.Point(381, 555)
        Me.lblDiscountAmount.Name = "lblDiscountAmount"
        Me.lblDiscountAmount.Size = New System.Drawing.Size(127, 25)
        Me.lblDiscountAmount.TabIndex = 136
        Me.lblDiscountAmount.Text = "Discount Amount"
        Me.lblDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscountUsed2
        '
        Me.lblDiscountUsed2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDiscountUsed2.ForeColor = System.Drawing.Color.DimGray
        Me.lblDiscountUsed2.Location = New System.Drawing.Point(521, 534)
        Me.lblDiscountUsed2.Name = "lblDiscountUsed2"
        Me.lblDiscountUsed2.Size = New System.Drawing.Size(151, 25)
        Me.lblDiscountUsed2.TabIndex = 135
        Me.lblDiscountUsed2.Text = "0"
        Me.lblDiscountUsed2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscountUsed
        '
        Me.lblDiscountUsed.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDiscountUsed.ForeColor = System.Drawing.Color.DimGray
        Me.lblDiscountUsed.Location = New System.Drawing.Point(374, 534)
        Me.lblDiscountUsed.Name = "lblDiscountUsed"
        Me.lblDiscountUsed.Size = New System.Drawing.Size(134, 25)
        Me.lblDiscountUsed.TabIndex = 134
        Me.lblDiscountUsed.Text = "Discount Used:"
        Me.lblDiscountUsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblChange
        '
        Me.lblChange.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblChange.ForeColor = System.Drawing.Color.DimGray
        Me.lblChange.Location = New System.Drawing.Point(521, 601)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(151, 25)
        Me.lblChange.TabIndex = 133
        Me.lblChange.Text = "0"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label19.ForeColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(381, 601)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(127, 25)
        Me.Label19.TabIndex = 132
        Me.Label19.Text = "Change:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTenderedAmount
        '
        Me.lblTenderedAmount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTenderedAmount.ForeColor = System.Drawing.Color.DimGray
        Me.lblTenderedAmount.Location = New System.Drawing.Point(521, 576)
        Me.lblTenderedAmount.Name = "lblTenderedAmount"
        Me.lblTenderedAmount.Size = New System.Drawing.Size(151, 25)
        Me.lblTenderedAmount.TabIndex = 131
        Me.lblTenderedAmount.Text = "0"
        Me.lblTenderedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblT
        '
        Me.lblT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblT.ForeColor = System.Drawing.Color.DimGray
        Me.lblT.Location = New System.Drawing.Point(374, 576)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(134, 25)
        Me.lblT.TabIndex = 130
        Me.lblT.Text = "Tendered Amount:"
        Me.lblT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(18, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 129
        Me.PictureBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(14, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(215, 25)
        Me.Label13.TabIndex = 114
        Me.Label13.Text = "INVOICE"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(423, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 25)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "Date:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(436, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 25)
        Me.Label9.TabIndex = 106
        Me.Label9.Text = "Invoice No:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDentistName
        '
        Me.lblDentistName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDentistName.ForeColor = System.Drawing.Color.Black
        Me.lblDentistName.Location = New System.Drawing.Point(129, 262)
        Me.lblDentistName.Name = "lblDentistName"
        Me.lblDentistName.Size = New System.Drawing.Size(215, 23)
        Me.lblDentistName.TabIndex = 105
        Me.lblDentistName.Text = "Dentist Name"
        Me.lblDentistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(9, 262)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(138, 23)
        Me.Label16.TabIndex = 104
        Me.Label16.Text = "Dentist Name:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDueDate
        '
        Me.lblDueDate.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDueDate.ForeColor = System.Drawing.Color.Black
        Me.lblDueDate.Location = New System.Drawing.Point(159, 592)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(151, 25)
        Me.lblDueDate.TabIndex = 103
        Me.lblDueDate.Text = "Date"
        Me.lblDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDueDate.Visible = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(18, 592)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 25)
        Me.Label14.TabIndex = 102
        Me.Label14.Text = "Due:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(522, 509)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(151, 25)
        Me.lblTotal.TabIndex = 101
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(381, 509)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 25)
        Me.Label11.TabIndex = 100
        Me.Label11.Text = "Total Amount:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.ForeColor = System.Drawing.Color.Black
        Me.lblInvoiceNo.Location = New System.Drawing.Point(522, 108)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(151, 25)
        Me.lblInvoiceNo.TabIndex = 107
        Me.lblInvoiceNo.Text = "Invoice No"
        Me.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtgridInvoice
        '
        Me.dtgridInvoice.AllowUserToAddRows = False
        Me.dtgridInvoice.AllowUserToDeleteRows = False
        Me.dtgridInvoice.AllowUserToResizeColumns = False
        Me.dtgridInvoice.AllowUserToResizeRows = False
        Me.dtgridInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgridInvoice.BackgroundColor = System.Drawing.Color.White
        Me.dtgridInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dtgridInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgridInvoice.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgridInvoice.ColumnHeadersHeight = 50
        Me.dtgridInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgridInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Procedure, Me.Gross, Me.Column1, Me.DiscountAmount, Me.TotalAmount})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgridInvoice.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgridInvoice.EnableHeadersVisualStyles = False
        Me.dtgridInvoice.Location = New System.Drawing.Point(11, 311)
        Me.dtgridInvoice.Name = "dtgridInvoice"
        Me.dtgridInvoice.ReadOnly = True
        Me.dtgridInvoice.RowHeadersVisible = False
        Me.dtgridInvoice.RowHeadersWidth = 20
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgridInvoice.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgridInvoice.RowTemplate.Height = 29
        Me.dtgridInvoice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtgridInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgridInvoice.ShowCellToolTips = False
        Me.dtgridInvoice.ShowEditingIcon = False
        Me.dtgridInvoice.Size = New System.Drawing.Size(662, 192)
        Me.dtgridInvoice.TabIndex = 99
        Me.dtgridInvoice.TabStop = False
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
        Me.Gross.HeaderText = "Price"
        Me.Gross.MinimumWidth = 6
        Me.Gross.Name = "Gross"
        Me.Gross.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Discount"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'DiscountAmount
        '
        Me.DiscountAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DiscountAmount.HeaderText = "Discount Amount"
        Me.DiscountAmount.MinimumWidth = 6
        Me.DiscountAmount.Name = "DiscountAmount"
        Me.DiscountAmount.ReadOnly = True
        Me.DiscountAmount.Visible = False
        '
        'TotalAmount
        '
        Me.TotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TotalAmount.HeaderText = "Total Amount"
        Me.TotalAmount.MinimumWidth = 6
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.ReadOnly = True
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPhoneNumber.ForeColor = System.Drawing.Color.Black
        Me.lblPhoneNumber.Location = New System.Drawing.Point(113, 239)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(154, 23)
        Me.lblPhoneNumber.TabIndex = 96
        Me.lblPhoneNumber.Text = "09074342722"
        Me.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 23)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Contact No:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPatientName
        '
        Me.lblPatientName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPatientName.ForeColor = System.Drawing.Color.Black
        Me.lblPatientName.Location = New System.Drawing.Point(9, 214)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(291, 25)
        Me.lblPatientName.TabIndex = 93
        Me.lblPatientName.Text = "Patient Name"
        Me.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBillingDate
        '
        Me.lblBillingDate.ForeColor = System.Drawing.Color.Black
        Me.lblBillingDate.Location = New System.Drawing.Point(522, 87)
        Me.lblBillingDate.Name = "lblBillingDate"
        Me.lblBillingDate.Size = New System.Drawing.Size(151, 25)
        Me.lblBillingDate.TabIndex = 92
        Me.lblBillingDate.Text = "Billing Date"
        Me.lblBillingDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Panel5.Controls.Add(Me.line)
        Me.Panel5.Location = New System.Drawing.Point(14, 161)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(659, 10)
        Me.Panel5.TabIndex = 91
        '
        'line
        '
        Me.line.BackColor = System.Drawing.Color.Gray
        Me.line.Location = New System.Drawing.Point(0, -3)
        Me.line.Name = "line"
        Me.line.Size = New System.Drawing.Size(659, 10)
        Me.line.TabIndex = 90
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(14, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(180, 28)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Flair Dental Clinic"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(1114, 79)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Size = New System.Drawing.Size(73, 29)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Print invoice")
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 20
        '
        'PrintInvoice
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AddBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1199, 836)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.pnlInvoice)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddBilling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnlInvoice.ResumeLayout(False)
        Me.pnlInvoice.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgridInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbboxBillingStatus As ComboBox
    Friend WithEvents cmbboxDiscount As ComboBox
    Friend WithEvents txtboxAmountPaid As TextBox
    Friend WithEvents txtboxGross As TextBox
    Friend WithEvents txtboxBalance As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents listboxProcedures As ListBox
    Friend WithEvents txtboxTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAddBilling As Label
    Friend WithEvents pnlInvoice As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDentistName As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblInvoiceNo As Label
    Friend WithEvents dtgridInvoice As DataGridView
    Friend WithEvents lblBillingNumber As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPatientName As Label
    Friend WithEvents lblBillingDate As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents line As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents lblBillingStatus As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtboxChange As TextBox
    Friend WithEvents lblTenderedAmount As Label
    Friend WithEvents lblT As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents PrintInvoice As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label17 As Label
    Friend WithEvents lblAddDiscount As Label
    Friend WithEvents lblDiscountAmount2 As Label
    Friend WithEvents lblDiscountAmount As Label
    Friend WithEvents lblDiscountUsed2 As Label
    Friend WithEvents lblDiscountUsed As Label
    Friend WithEvents Procedure As DataGridViewTextBoxColumn
    Friend WithEvents Gross As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DiscountAmount As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmount As DataGridViewTextBoxColumn
End Class
