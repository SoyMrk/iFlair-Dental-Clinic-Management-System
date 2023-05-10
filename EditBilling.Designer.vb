<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditBilling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditBilling))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAddBilling = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtboxChange = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblBillingStatus = New System.Windows.Forms.Label()
        Me.txtboxLastDateAmountPaid = New System.Windows.Forms.TextBox()
        Me.lblLastDateAndAmountPaid = New System.Windows.Forms.Label()
        Me.listboxProcedures = New System.Windows.Forms.ListBox()
        Me.txtboxBalance = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxAmountPaid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtboxGross = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxNewBalance = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pnlInvoice = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblTotalPaidAmount = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.line = New System.Windows.Forms.Panel()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblTenderedAmount = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblLastAmountPaid = New System.Windows.Forms.Label()
        Me.lblLastDatePaid = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDentistName = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblNewTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.dtgridInvoice = New System.Windows.Forms.DataGridView()
        Me.Procedure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gross = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.lblBillingDate = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.printUInvoice = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.pnlInvoice.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgridInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 37
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
        Me.lblAddBilling.Location = New System.Drawing.Point(42, 19)
        Me.lblAddBilling.Name = "lblAddBilling"
        Me.lblAddBilling.Size = New System.Drawing.Size(163, 28)
        Me.lblAddBilling.TabIndex = 13
        Me.lblAddBilling.Text = "Update Payment"
        Me.lblAddBilling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.Panel6)
        Me.GroupBox2.Controls.Add(Me.txtboxChange)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lblBillingStatus)
        Me.GroupBox2.Controls.Add(Me.txtboxLastDateAmountPaid)
        Me.GroupBox2.Controls.Add(Me.lblLastDateAndAmountPaid)
        Me.GroupBox2.Controls.Add(Me.listboxProcedures)
        Me.GroupBox2.Controls.Add(Me.txtboxBalance)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtboxAmountPaid)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtboxGross)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtboxNewBalance)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel7)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(13, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(461, 704)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(44, 54)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(376, 10)
        Me.Panel4.TabIndex = 320
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gray
        Me.Panel6.Location = New System.Drawing.Point(44, 57)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(376, 10)
        Me.Panel6.TabIndex = 319
        '
        'txtboxChange
        '
        Me.txtboxChange.AccessibleName = "Amount Paid"
        Me.txtboxChange.BackColor = System.Drawing.Color.White
        Me.txtboxChange.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxChange.Enabled = False
        Me.txtboxChange.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxChange.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtboxChange.Location = New System.Drawing.Point(46, 553)
        Me.txtboxChange.Name = "txtboxChange"
        Me.txtboxChange.ReadOnly = True
        Me.txtboxChange.Size = New System.Drawing.Size(374, 23)
        Me.txtboxChange.TabIndex = 317
        Me.txtboxChange.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(42, 531)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 20)
        Me.Label15.TabIndex = 318
        Me.Label15.Text = "Change"
        '
        'lblBillingStatus
        '
        Me.lblBillingStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBillingStatus.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblBillingStatus.Location = New System.Drawing.Point(42, 617)
        Me.lblBillingStatus.Name = "lblBillingStatus"
        Me.lblBillingStatus.Size = New System.Drawing.Size(375, 23)
        Me.lblBillingStatus.TabIndex = 316
        Me.lblBillingStatus.Text = "Incomplete"
        Me.lblBillingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtboxLastDateAmountPaid
        '
        Me.txtboxLastDateAmountPaid.AccessibleName = "Last Date and Amount Paid"
        Me.txtboxLastDateAmountPaid.BackColor = System.Drawing.Color.White
        Me.txtboxLastDateAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxLastDateAmountPaid.Enabled = False
        Me.txtboxLastDateAmountPaid.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxLastDateAmountPaid.ForeColor = System.Drawing.Color.Black
        Me.txtboxLastDateAmountPaid.Location = New System.Drawing.Point(46, 234)
        Me.txtboxLastDateAmountPaid.Name = "txtboxLastDateAmountPaid"
        Me.txtboxLastDateAmountPaid.ReadOnly = True
        Me.txtboxLastDateAmountPaid.Size = New System.Drawing.Size(374, 23)
        Me.txtboxLastDateAmountPaid.TabIndex = 185
        Me.txtboxLastDateAmountPaid.TabStop = False
        '
        'lblLastDateAndAmountPaid
        '
        Me.lblLastDateAndAmountPaid.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLastDateAndAmountPaid.ForeColor = System.Drawing.Color.Black
        Me.lblLastDateAndAmountPaid.Location = New System.Drawing.Point(42, 212)
        Me.lblLastDateAndAmountPaid.Name = "lblLastDateAndAmountPaid"
        Me.lblLastDateAndAmountPaid.Size = New System.Drawing.Size(287, 20)
        Me.lblLastDateAndAmountPaid.TabIndex = 184
        Me.lblLastDateAndAmountPaid.Text = "Last amount paid : Last date paid"
        '
        'listboxProcedures
        '
        Me.listboxProcedures.AccessibleName = "List of Procedure"
        Me.listboxProcedures.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.listboxProcedures.FormattingEnabled = True
        Me.listboxProcedures.ItemHeight = 23
        Me.listboxProcedures.Location = New System.Drawing.Point(44, 65)
        Me.listboxProcedures.Name = "listboxProcedures"
        Me.listboxProcedures.Size = New System.Drawing.Size(376, 119)
        Me.listboxProcedures.TabIndex = 183
        Me.listboxProcedures.TabStop = False
        '
        'txtboxBalance
        '
        Me.txtboxBalance.AccessibleName = "Balance"
        Me.txtboxBalance.BackColor = System.Drawing.Color.White
        Me.txtboxBalance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxBalance.Enabled = False
        Me.txtboxBalance.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxBalance.ForeColor = System.Drawing.Color.Black
        Me.txtboxBalance.Location = New System.Drawing.Point(46, 363)
        Me.txtboxBalance.Name = "txtboxBalance"
        Me.txtboxBalance.ReadOnly = True
        Me.txtboxBalance.Size = New System.Drawing.Size(200, 23)
        Me.txtboxBalance.TabIndex = 182
        Me.txtboxBalance.TabStop = False
        Me.txtboxBalance.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(42, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 181
        Me.Label5.Text = "Previous Balance"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(42, 593)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 180
        Me.Label1.Text = "Billing Status"
        '
        'txtboxAmountPaid
        '
        Me.txtboxAmountPaid.AccessibleName = "Amount Paid"
        Me.txtboxAmountPaid.BackColor = System.Drawing.Color.White
        Me.txtboxAmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxAmountPaid.Location = New System.Drawing.Point(46, 426)
        Me.txtboxAmountPaid.Name = "txtboxAmountPaid"
        Me.txtboxAmountPaid.Size = New System.Drawing.Size(374, 27)
        Me.txtboxAmountPaid.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(42, 404)
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
        Me.txtboxGross.Location = New System.Drawing.Point(46, 300)
        Me.txtboxGross.Name = "txtboxGross"
        Me.txtboxGross.ReadOnly = True
        Me.txtboxGross.Size = New System.Drawing.Size(374, 23)
        Me.txtboxGross.TabIndex = 58
        Me.txtboxGross.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(42, 277)
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
        'txtboxNewBalance
        '
        Me.txtboxNewBalance.AccessibleName = "New Balance"
        Me.txtboxNewBalance.BackColor = System.Drawing.Color.White
        Me.txtboxNewBalance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxNewBalance.Enabled = False
        Me.txtboxNewBalance.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxNewBalance.Location = New System.Drawing.Point(46, 488)
        Me.txtboxNewBalance.Name = "txtboxNewBalance"
        Me.txtboxNewBalance.ReadOnly = True
        Me.txtboxNewBalance.Size = New System.Drawing.Size(374, 23)
        Me.txtboxNewBalance.TabIndex = 52
        Me.txtboxNewBalance.TabStop = False
        Me.txtboxNewBalance.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(42, 466)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "New Balance"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(44, 186)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(376, 10)
        Me.Panel3.TabIndex = 181
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Gray
        Me.Panel7.Location = New System.Drawing.Point(44, 184)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(376, 10)
        Me.Panel7.TabIndex = 180
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(1070, 861)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 41)
        Me.btnCancel.TabIndex = 3
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
        Me.btnAdd.Location = New System.Drawing.Point(957, 861)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 41)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'pnlInvoice
        '
        Me.pnlInvoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.pnlInvoice.Controls.Add(Me.Label20)
        Me.pnlInvoice.Controls.Add(Me.lblTotalPaidAmount)
        Me.pnlInvoice.Controls.Add(Me.Panel5)
        Me.pnlInvoice.Controls.Add(Me.lblChange)
        Me.pnlInvoice.Controls.Add(Me.Label4)
        Me.pnlInvoice.Controls.Add(Me.Label18)
        Me.pnlInvoice.Controls.Add(Me.lblTenderedAmount)
        Me.pnlInvoice.Controls.Add(Me.Label19)
        Me.pnlInvoice.Controls.Add(Me.lblLastAmountPaid)
        Me.pnlInvoice.Controls.Add(Me.lblLastDatePaid)
        Me.pnlInvoice.Controls.Add(Me.Label17)
        Me.pnlInvoice.Controls.Add(Me.PictureBox2)
        Me.pnlInvoice.Controls.Add(Me.Label13)
        Me.pnlInvoice.Controls.Add(Me.Label9)
        Me.pnlInvoice.Controls.Add(Me.lblDentistName)
        Me.pnlInvoice.Controls.Add(Me.Label16)
        Me.pnlInvoice.Controls.Add(Me.lblDueDate)
        Me.pnlInvoice.Controls.Add(Me.Label14)
        Me.pnlInvoice.Controls.Add(Me.lblNewTotal)
        Me.pnlInvoice.Controls.Add(Me.Label11)
        Me.pnlInvoice.Controls.Add(Me.lblInvoiceNo)
        Me.pnlInvoice.Controls.Add(Me.dtgridInvoice)
        Me.pnlInvoice.Controls.Add(Me.lblPhoneNumber)
        Me.pnlInvoice.Controls.Add(Me.Label6)
        Me.pnlInvoice.Controls.Add(Me.Label10)
        Me.pnlInvoice.Controls.Add(Me.lblPatientName)
        Me.pnlInvoice.Controls.Add(Me.lblBillingDate)
        Me.pnlInvoice.Controls.Add(Me.Label12)
        Me.pnlInvoice.Location = New System.Drawing.Point(504, 120)
        Me.pnlInvoice.Name = "pnlInvoice"
        Me.pnlInvoice.Size = New System.Drawing.Size(683, 693)
        Me.pnlInvoice.TabIndex = 58
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label20.ForeColor = System.Drawing.Color.DimGray
        Me.Label20.Location = New System.Drawing.Point(318, 540)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(207, 25)
        Me.Label20.TabIndex = 142
        Me.Label20.Text = "Total Amount Paid:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPaidAmount
        '
        Me.lblTotalPaidAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalPaidAmount.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalPaidAmount.Location = New System.Drawing.Point(536, 540)
        Me.lblTotalPaidAmount.Name = "lblTotalPaidAmount"
        Me.lblTotalPaidAmount.Size = New System.Drawing.Size(137, 25)
        Me.lblTotalPaidAmount.TabIndex = 141
        Me.lblTotalPaidAmount.Text = "0"
        Me.lblTotalPaidAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Panel5.Controls.Add(Me.line)
        Me.Panel5.Location = New System.Drawing.Point(14, 161)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(659, 10)
        Me.Panel5.TabIndex = 140
        '
        'line
        '
        Me.line.BackColor = System.Drawing.Color.Gray
        Me.line.Location = New System.Drawing.Point(0, -3)
        Me.line.Name = "line"
        Me.line.Size = New System.Drawing.Size(659, 10)
        Me.line.TabIndex = 90
        '
        'lblChange
        '
        Me.lblChange.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblChange.ForeColor = System.Drawing.Color.DimGray
        Me.lblChange.Location = New System.Drawing.Point(537, 601)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(136, 25)
        Me.lblChange.TabIndex = 139
        Me.lblChange.Text = "0"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(382, 601)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 25)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "Change:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.ForeColor = System.Drawing.Color.DimGray
        Me.Label18.Location = New System.Drawing.Point(370, 571)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(155, 25)
        Me.Label18.TabIndex = 137
        Me.Label18.Text = "Tendered Amount:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTenderedAmount
        '
        Me.lblTenderedAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTenderedAmount.ForeColor = System.Drawing.Color.DimGray
        Me.lblTenderedAmount.Location = New System.Drawing.Point(536, 571)
        Me.lblTenderedAmount.Name = "lblTenderedAmount"
        Me.lblTenderedAmount.Size = New System.Drawing.Size(137, 25)
        Me.lblTenderedAmount.TabIndex = 136
        Me.lblTenderedAmount.Text = "0"
        Me.lblTenderedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label19.ForeColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(395, 511)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(130, 25)
        Me.Label19.TabIndex = 137
        Me.Label19.Text = "Previous Amount Paid:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLastAmountPaid
        '
        Me.lblLastAmountPaid.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLastAmountPaid.ForeColor = System.Drawing.Color.DimGray
        Me.lblLastAmountPaid.Location = New System.Drawing.Point(536, 511)
        Me.lblLastAmountPaid.Name = "lblLastAmountPaid"
        Me.lblLastAmountPaid.Size = New System.Drawing.Size(137, 25)
        Me.lblLastAmountPaid.TabIndex = 136
        Me.lblLastAmountPaid.Text = "0"
        Me.lblLastAmountPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLastDatePaid
        '
        Me.lblLastDatePaid.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLastDatePaid.ForeColor = System.Drawing.Color.DimGray
        Me.lblLastDatePaid.Location = New System.Drawing.Point(536, 481)
        Me.lblLastDatePaid.Name = "lblLastDatePaid"
        Me.lblLastDatePaid.Size = New System.Drawing.Size(137, 25)
        Me.lblLastDatePaid.TabIndex = 135
        Me.lblLastDatePaid.Text = "0"
        Me.lblLastDatePaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(402, 481)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(123, 25)
        Me.Label17.TabIndex = 134
        Me.Label17.Text = "Last Date Paid:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(18, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 128
        Me.PictureBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(423, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 25)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "Date:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(436, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 25)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "Invoice No:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDentistName
        '
        Me.lblDentistName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDentistName.ForeColor = System.Drawing.Color.Black
        Me.lblDentistName.Location = New System.Drawing.Point(129, 250)
        Me.lblDentistName.Name = "lblDentistName"
        Me.lblDentistName.Size = New System.Drawing.Size(215, 23)
        Me.lblDentistName.TabIndex = 124
        Me.lblDentistName.Text = "Dentist Name"
        Me.lblDentistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(9, 250)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(138, 23)
        Me.Label16.TabIndex = 123
        Me.Label16.Text = "Dentist Name:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDueDate
        '
        Me.lblDueDate.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDueDate.ForeColor = System.Drawing.Color.Black
        Me.lblDueDate.Location = New System.Drawing.Point(123, 648)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(136, 25)
        Me.lblDueDate.TabIndex = 122
        Me.lblDueDate.Text = "Date"
        Me.lblDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDueDate.Visible = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(50, 648)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 25)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "Due:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Visible = False
        '
        'lblNewTotal
        '
        Me.lblNewTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNewTotal.ForeColor = System.Drawing.Color.Black
        Me.lblNewTotal.Location = New System.Drawing.Point(537, 632)
        Me.lblNewTotal.Name = "lblNewTotal"
        Me.lblNewTotal.Size = New System.Drawing.Size(136, 25)
        Me.lblNewTotal.TabIndex = 120
        Me.lblNewTotal.Text = "0"
        Me.lblNewTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(402, 631)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 25)
        Me.Label11.TabIndex = 119
        Me.Label11.Text = "New Balance:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.ForeColor = System.Drawing.Color.Black
        Me.lblInvoiceNo.Location = New System.Drawing.Point(522, 108)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(151, 25)
        Me.lblInvoiceNo.TabIndex = 126
        Me.lblInvoiceNo.Text = "Invoice No"
        Me.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtgridInvoice
        '
        Me.dtgridInvoice.AllowUserToAddRows = False
        Me.dtgridInvoice.AllowUserToDeleteRows = False
        Me.dtgridInvoice.AllowUserToResizeColumns = False
        Me.dtgridInvoice.AllowUserToResizeRows = False
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
        Me.dtgridInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Procedure, Me.Gross, Me.Discount, Me.Column1, Me.TotalAmount})
        Me.dtgridInvoice.EnableHeadersVisualStyles = False
        Me.dtgridInvoice.Location = New System.Drawing.Point(11, 283)
        Me.dtgridInvoice.Name = "dtgridInvoice"
        Me.dtgridInvoice.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgridInvoice.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgridInvoice.RowHeadersVisible = False
        Me.dtgridInvoice.RowHeadersWidth = 20
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgridInvoice.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgridInvoice.RowTemplate.Height = 29
        Me.dtgridInvoice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtgridInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgridInvoice.Size = New System.Drawing.Size(662, 192)
        Me.dtgridInvoice.TabIndex = 118
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
        'Discount
        '
        Me.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Discount.HeaderText = "Discount"
        Me.Discount.MinimumWidth = 6
        Me.Discount.Name = "Discount"
        Me.Discount.ReadOnly = True
        Me.Discount.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Discount Amount"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 125
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
        Me.lblPhoneNumber.Location = New System.Drawing.Point(113, 227)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(119, 23)
        Me.lblPhoneNumber.TabIndex = 115
        Me.lblPhoneNumber.Text = "09074342722"
        Me.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 23)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Contact No:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(14, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(215, 25)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "INVOICE"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPatientName
        '
        Me.lblPatientName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPatientName.ForeColor = System.Drawing.Color.Black
        Me.lblPatientName.Location = New System.Drawing.Point(9, 202)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(183, 25)
        Me.lblPatientName.TabIndex = 112
        Me.lblPatientName.Text = "Patient Name"
        Me.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBillingDate
        '
        Me.lblBillingDate.ForeColor = System.Drawing.Color.Black
        Me.lblBillingDate.Location = New System.Drawing.Point(522, 87)
        Me.lblBillingDate.Name = "lblBillingDate"
        Me.lblBillingDate.Size = New System.Drawing.Size(151, 25)
        Me.lblBillingDate.TabIndex = 111
        Me.lblBillingDate.Text = "Billing Date"
        Me.lblBillingDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(14, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(180, 28)
        Me.Label12.TabIndex = 108
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
        Me.btnPrint.Location = New System.Drawing.Point(1115, 79)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Size = New System.Drawing.Size(72, 29)
        Me.btnPrint.TabIndex = 60
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Print Invoice")
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 1000
        Me.ToolTip1.BackColor = System.Drawing.Color.White
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        '
        'printUInvoice
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
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
        'EditBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1199, 914)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.pnlInvoice)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditBilling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnlInvoice.ResumeLayout(False)
        Me.pnlInvoice.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgridInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblAddBilling As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtboxLastDateAmountPaid As TextBox
    Friend WithEvents lblLastDateAndAmountPaid As Label
    Friend WithEvents listboxProcedures As ListBox
    Friend WithEvents txtboxBalance As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbboxBillingStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxAmountPaid As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtboxGross As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxNewBalance As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
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
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPatientName As Label
    Friend WithEvents lblBillingDate As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents lblLastAmountPaid As Label
    Friend WithEvents lblLastDatePaid As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblNewTotal As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblTenderedAmount As Label
    Friend WithEvents btnPDF As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblBillingStatus As Label
    Friend WithEvents txtboxChange As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblChange As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents line As Panel
    Friend WithEvents lblTotalPaidAmount As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblTotalAmountPaid As Label
    Friend WithEvents printUInvoice As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Procedure As DataGridViewTextBoxColumn
    Friend WithEvents Gross As DataGridViewTextBoxColumn
    Friend WithEvents Discount As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmount As DataGridViewTextBoxColumn
End Class
