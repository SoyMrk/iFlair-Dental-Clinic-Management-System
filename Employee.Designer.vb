<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TopGrayPanel = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnAddNewEmployee = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtboxFoundEmp = New System.Windows.Forms.TextBox()
        Me.txtboxSearchEmployee = New System.Windows.Forms.TextBox()
        Me.picboxSearchEmployee = New System.Windows.Forms.PictureBox()
        Me.datagridEmployee = New System.Windows.Forms.DataGridView()
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofBirth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopGrayPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.picboxSearchEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopGrayPanel
        '
        Me.TopGrayPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TopGrayPanel.Controls.Add(Me.Panel5)
        Me.TopGrayPanel.Controls.Add(Me.Label2)
        Me.TopGrayPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopGrayPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopGrayPanel.Name = "TopGrayPanel"
        Me.TopGrayPanel.Size = New System.Drawing.Size(1898, 63)
        Me.TopGrayPanel.TabIndex = 28
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnAddNewEmployee)
        Me.Panel5.Location = New System.Drawing.Point(119, 17)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(31, 31)
        Me.Panel5.TabIndex = 25
        '
        'btnAddNewEmployee
        '
        Me.btnAddNewEmployee.BackColor = System.Drawing.Color.White
        Me.btnAddNewEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewEmployee.FlatAppearance.BorderSize = 0
        Me.btnAddNewEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnAddNewEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAddNewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddNewEmployee.ForeColor = System.Drawing.Color.White
        Me.btnAddNewEmployee.Image = CType(resources.GetObject("btnAddNewEmployee.Image"), System.Drawing.Image)
        Me.btnAddNewEmployee.Location = New System.Drawing.Point(-8, -4)
        Me.btnAddNewEmployee.Name = "btnAddNewEmployee"
        Me.btnAddNewEmployee.Size = New System.Drawing.Size(45, 38)
        Me.btnAddNewEmployee.TabIndex = 1
        Me.btnAddNewEmployee.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnAddNewEmployee, "Add new employee")
        Me.btnAddNewEmployee.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 28)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Employee"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(13, 1089)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1872, 13)
        Me.Panel4.TabIndex = 35
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1885, 76)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 1026)
        Me.Panel3.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 1026)
        Me.Panel2.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1898, 13)
        Me.Panel1.TabIndex = 32
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel6.Controls.Add(Me.txtboxFoundEmp)
        Me.Panel6.Controls.Add(Me.txtboxSearchEmployee)
        Me.Panel6.Controls.Add(Me.picboxSearchEmployee)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(13, 76)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1872, 50)
        Me.Panel6.TabIndex = 36
        '
        'txtboxFoundEmp
        '
        Me.txtboxFoundEmp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxFoundEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtboxFoundEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxFoundEmp.ForeColor = System.Drawing.Color.White
        Me.txtboxFoundEmp.Location = New System.Drawing.Point(1658, 14)
        Me.txtboxFoundEmp.Name = "txtboxFoundEmp"
        Me.txtboxFoundEmp.ReadOnly = True
        Me.txtboxFoundEmp.Size = New System.Drawing.Size(199, 20)
        Me.txtboxFoundEmp.TabIndex = 1
        Me.txtboxFoundEmp.TabStop = False
        Me.txtboxFoundEmp.Text = "4 employee found"
        Me.txtboxFoundEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtboxSearchEmployee
        '
        Me.txtboxSearchEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtboxSearchEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxSearchEmployee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxSearchEmployee.ForeColor = System.Drawing.Color.White
        Me.txtboxSearchEmployee.Location = New System.Drawing.Point(41, 11)
        Me.txtboxSearchEmployee.Name = "txtboxSearchEmployee"
        Me.txtboxSearchEmployee.Size = New System.Drawing.Size(305, 27)
        Me.txtboxSearchEmployee.TabIndex = 2
        Me.txtboxSearchEmployee.TabStop = False
        Me.txtboxSearchEmployee.Text = "  Search here"
        Me.ToolTip1.SetToolTip(Me.txtboxSearchEmployee, "Search by employee name, job position and/or address")
        '
        'picboxSearchEmployee
        '
        Me.picboxSearchEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.picboxSearchEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxSearchEmployee.Image = CType(resources.GetObject("picboxSearchEmployee.Image"), System.Drawing.Image)
        Me.picboxSearchEmployee.Location = New System.Drawing.Point(12, 11)
        Me.picboxSearchEmployee.Name = "picboxSearchEmployee"
        Me.picboxSearchEmployee.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.picboxSearchEmployee.Size = New System.Drawing.Size(30, 27)
        Me.picboxSearchEmployee.TabIndex = 21
        Me.picboxSearchEmployee.TabStop = False
        '
        'datagridEmployee
        '
        Me.datagridEmployee.AllowUserToAddRows = False
        Me.datagridEmployee.AllowUserToDeleteRows = False
        Me.datagridEmployee.AllowUserToResizeColumns = False
        Me.datagridEmployee.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.datagridEmployee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datagridEmployee.BackgroundColor = System.Drawing.Color.White
        Me.datagridEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.datagridEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.datagridEmployee.ColumnHeadersHeight = 50
        Me.datagridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagridEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeID, Me.LastName, Me.FirstName, Me.MiddleName, Me.JobPosition, Me.Address, Me.DateofBirth, Me.EmailAddress, Me.ContactNo, Me.Edit, Me.Delete})
        Me.datagridEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridEmployee.DefaultCellStyle = DataGridViewCellStyle7
        Me.datagridEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridEmployee.EnableHeadersVisualStyles = False
        Me.datagridEmployee.Location = New System.Drawing.Point(13, 126)
        Me.datagridEmployee.Name = "datagridEmployee"
        Me.datagridEmployee.ReadOnly = True
        Me.datagridEmployee.RowHeadersVisible = False
        Me.datagridEmployee.RowHeadersWidth = 51
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.datagridEmployee.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.datagridEmployee.RowTemplate.Height = 29
        Me.datagridEmployee.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datagridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridEmployee.ShowCellToolTips = False
        Me.datagridEmployee.Size = New System.Drawing.Size(1872, 963)
        Me.datagridEmployee.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.datagridEmployee, "Click to view Employee Details")
        '
        'EmployeeID
        '
        Me.EmployeeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmployeeID.HeaderText = "Employee ID"
        Me.EmployeeID.MinimumWidth = 6
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.ReadOnly = True
        Me.EmployeeID.Visible = False
        '
        'LastName
        '
        Me.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.MinimumWidth = 6
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        '
        'FirstName
        '
        Me.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.MinimumWidth = 6
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        '
        'MiddleName
        '
        Me.MiddleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MiddleName.HeaderText = "Middle Name"
        Me.MiddleName.MinimumWidth = 6
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.ReadOnly = True
        '
        'JobPosition
        '
        Me.JobPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.JobPosition.HeaderText = "Job Position"
        Me.JobPosition.MinimumWidth = 6
        Me.JobPosition.Name = "JobPosition"
        Me.JobPosition.ReadOnly = True
        '
        'Address
        '
        Me.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Address.HeaderText = "Address"
        Me.Address.MinimumWidth = 6
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        '
        'DateofBirth
        '
        Me.DateofBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateofBirth.HeaderText = "Date of Birth"
        Me.DateofBirth.MinimumWidth = 6
        Me.DateofBirth.Name = "DateofBirth"
        Me.DateofBirth.ReadOnly = True
        '
        'EmailAddress
        '
        Me.EmailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmailAddress.HeaderText = "Email Address"
        Me.EmailAddress.MinimumWidth = 6
        Me.EmailAddress.Name = "EmailAddress"
        Me.EmailAddress.ReadOnly = True
        '
        'ContactNo
        '
        Me.ContactNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ContactNo.HeaderText = "Contact Number"
        Me.ContactNo.MinimumWidth = 6
        Me.ContactNo.Name = "ContactNo"
        Me.ContactNo.ReadOnly = True
        '
        'Edit
        '
        Me.Edit.HeaderText = ""
        Me.Edit.Image = CType(resources.GetObject("Edit.Image"), System.Drawing.Image)
        Me.Edit.MinimumWidth = 6
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Edit.ToolTipText = "Update"
        Me.Edit.Width = 60
        '
        'Delete
        '
        Me.Delete.HeaderText = ""
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.MinimumWidth = 6
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Delete.ToolTipText = "Delete"
        Me.Delete.Width = 60
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
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1898, 1102)
        Me.Controls.Add(Me.datagridEmployee)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TopGrayPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.TopGrayPanel.ResumeLayout(False)
        Me.TopGrayPanel.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.picboxSearchEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopGrayPanel As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtboxFoundEmp As TextBox
    Friend WithEvents txtboxSearchEmployee As TextBox
    Friend WithEvents picboxSearchEmployee As PictureBox
    Friend WithEvents datagridEmployee As DataGridView
    Friend WithEvents btnAddNewEmployee As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents EmployeeID As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents MiddleName As DataGridViewTextBoxColumn
    Friend WithEvents JobPosition As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents DateofBirth As DataGridViewTextBoxColumn
    Friend WithEvents EmailAddress As DataGridViewTextBoxColumn
    Friend WithEvents ContactNo As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewImageColumn
    Friend WithEvents Delete As DataGridViewImageColumn
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel5 As Panel
End Class
