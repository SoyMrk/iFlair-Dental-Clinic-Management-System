<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewEmployeeDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewEmployeeDetails))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panelViewEmployee = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtboxJobPosition = New System.Windows.Forms.TextBox()
        Me.txtboxGender = New System.Windows.Forms.TextBox()
        Me.txtboxGovID = New System.Windows.Forms.TextBox()
        Me.txtboxZipCode = New System.Windows.Forms.TextBox()
        Me.txtboxBrgy = New System.Windows.Forms.TextBox()
        Me.txtboxMunicipality = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtboxProvince = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtboxStreet = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtboxHouseNo = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.picboxEmployeePhoto = New System.Windows.Forms.PictureBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtboxIDNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpickerDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.txtboxEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtboxContactNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtboxAge = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtboxMiddleName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtboxFirstName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtboxLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxEmployeeNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelViewEmployee.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picboxEmployeePhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(985, 68)
        Me.Panel1.TabIndex = 61
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 25)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(42, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(215, 28)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Employee Information"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelViewEmployee
        '
        Me.panelViewEmployee.AutoScroll = True
        Me.panelViewEmployee.AutoScrollMinSize = New System.Drawing.Size(100, 800)
        Me.panelViewEmployee.Controls.Add(Me.GroupBox2)
        Me.panelViewEmployee.Location = New System.Drawing.Point(0, 68)
        Me.panelViewEmployee.Name = "panelViewEmployee"
        Me.panelViewEmployee.Size = New System.Drawing.Size(985, 817)
        Me.panelViewEmployee.TabIndex = 62
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtboxJobPosition)
        Me.GroupBox2.Controls.Add(Me.txtboxGender)
        Me.GroupBox2.Controls.Add(Me.txtboxGovID)
        Me.GroupBox2.Controls.Add(Me.txtboxZipCode)
        Me.GroupBox2.Controls.Add(Me.txtboxBrgy)
        Me.GroupBox2.Controls.Add(Me.txtboxMunicipality)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.txtboxProvince)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.txtboxStreet)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.txtboxHouseNo)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.picboxEmployeePhoto)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.txtboxIDNumber)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtpickerDateOfBirth)
        Me.GroupBox2.Controls.Add(Me.txtboxEmailAddress)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtboxContactNumber)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtboxAge)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtboxMiddleName)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtboxFirstName)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtboxLastName)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtboxEmployeeNumber)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(962, 795)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'txtboxJobPosition
        '
        Me.txtboxJobPosition.BackColor = System.Drawing.Color.White
        Me.txtboxJobPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxJobPosition.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxJobPosition.Location = New System.Drawing.Point(342, 132)
        Me.txtboxJobPosition.Name = "txtboxJobPosition"
        Me.txtboxJobPosition.ReadOnly = True
        Me.txtboxJobPosition.Size = New System.Drawing.Size(568, 27)
        Me.txtboxJobPosition.TabIndex = 2
        Me.txtboxJobPosition.TabStop = False
        '
        'txtboxGender
        '
        Me.txtboxGender.BackColor = System.Drawing.Color.White
        Me.txtboxGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxGender.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxGender.Location = New System.Drawing.Point(758, 374)
        Me.txtboxGender.Name = "txtboxGender"
        Me.txtboxGender.ReadOnly = True
        Me.txtboxGender.Size = New System.Drawing.Size(152, 27)
        Me.txtboxGender.TabIndex = 8
        Me.txtboxGender.TabStop = False
        '
        'txtboxGovID
        '
        Me.txtboxGovID.BackColor = System.Drawing.Color.White
        Me.txtboxGovID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxGovID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxGovID.Location = New System.Drawing.Point(342, 497)
        Me.txtboxGovID.Name = "txtboxGovID"
        Me.txtboxGovID.ReadOnly = True
        Me.txtboxGovID.Size = New System.Drawing.Size(267, 27)
        Me.txtboxGovID.TabIndex = 11
        Me.txtboxGovID.TabStop = False
        '
        'txtboxZipCode
        '
        Me.txtboxZipCode.BackColor = System.Drawing.Color.White
        Me.txtboxZipCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxZipCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxZipCode.Location = New System.Drawing.Point(616, 737)
        Me.txtboxZipCode.Name = "txtboxZipCode"
        Me.txtboxZipCode.ReadOnly = True
        Me.txtboxZipCode.Size = New System.Drawing.Size(294, 27)
        Me.txtboxZipCode.TabIndex = 18
        Me.txtboxZipCode.TabStop = False
        '
        'txtboxBrgy
        '
        Me.txtboxBrgy.BackColor = System.Drawing.Color.White
        Me.txtboxBrgy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxBrgy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxBrgy.Location = New System.Drawing.Point(342, 677)
        Me.txtboxBrgy.Name = "txtboxBrgy"
        Me.txtboxBrgy.ReadOnly = True
        Me.txtboxBrgy.Size = New System.Drawing.Size(267, 27)
        Me.txtboxBrgy.TabIndex = 15
        Me.txtboxBrgy.TabStop = False
        '
        'txtboxMunicipality
        '
        Me.txtboxMunicipality.BackColor = System.Drawing.Color.White
        Me.txtboxMunicipality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxMunicipality.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxMunicipality.Location = New System.Drawing.Point(616, 677)
        Me.txtboxMunicipality.Name = "txtboxMunicipality"
        Me.txtboxMunicipality.ReadOnly = True
        Me.txtboxMunicipality.Size = New System.Drawing.Size(294, 27)
        Me.txtboxMunicipality.TabIndex = 16
        Me.txtboxMunicipality.TabStop = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(337, 654)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(71, 20)
        Me.Label39.TabIndex = 224
        Me.Label39.Text = "Barangay"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(614, 714)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(70, 20)
        Me.Label37.TabIndex = 227
        Me.Label37.Text = "Zip Code"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(612, 654)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(90, 20)
        Me.Label33.TabIndex = 221
        Me.Label33.Text = "Municipality"
        '
        'txtboxProvince
        '
        Me.txtboxProvince.BackColor = System.Drawing.Color.White
        Me.txtboxProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxProvince.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxProvince.Location = New System.Drawing.Point(342, 737)
        Me.txtboxProvince.Name = "txtboxProvince"
        Me.txtboxProvince.ReadOnly = True
        Me.txtboxProvince.Size = New System.Drawing.Size(267, 27)
        Me.txtboxProvince.TabIndex = 17
        Me.txtboxProvince.TabStop = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(337, 714)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(65, 20)
        Me.Label35.TabIndex = 218
        Me.Label35.Text = "Province"
        '
        'txtboxStreet
        '
        Me.txtboxStreet.BackColor = System.Drawing.Color.White
        Me.txtboxStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxStreet.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxStreet.Location = New System.Drawing.Point(615, 618)
        Me.txtboxStreet.Name = "txtboxStreet"
        Me.txtboxStreet.ReadOnly = True
        Me.txtboxStreet.Size = New System.Drawing.Size(295, 27)
        Me.txtboxStreet.TabIndex = 14
        Me.txtboxStreet.TabStop = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(612, 595)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(48, 20)
        Me.Label31.TabIndex = 215
        Me.Label31.Text = "Street"
        '
        'txtboxHouseNo
        '
        Me.txtboxHouseNo.BackColor = System.Drawing.Color.White
        Me.txtboxHouseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxHouseNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxHouseNo.Location = New System.Drawing.Point(342, 618)
        Me.txtboxHouseNo.Name = "txtboxHouseNo"
        Me.txtboxHouseNo.ReadOnly = True
        Me.txtboxHouseNo.Size = New System.Drawing.Size(267, 27)
        Me.txtboxHouseNo.TabIndex = 13
        Me.txtboxHouseNo.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(337, 595)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(109, 20)
        Me.Label26.TabIndex = 213
        Me.Label26.Text = "House Number"
        '
        'picboxEmployeePhoto
        '
        Me.picboxEmployeePhoto.BackColor = System.Drawing.Color.Gainsboro
        Me.picboxEmployeePhoto.Image = CType(resources.GetObject("picboxEmployeePhoto.Image"), System.Drawing.Image)
        Me.picboxEmployeePhoto.Location = New System.Drawing.Point(52, 114)
        Me.picboxEmployeePhoto.Name = "picboxEmployeePhoto"
        Me.picboxEmployeePhoto.Size = New System.Drawing.Size(266, 227)
        Me.picboxEmployeePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picboxEmployeePhoto.TabIndex = 177
        Me.picboxEmployeePhoto.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(610, 474)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(82, 20)
        Me.Label28.TabIndex = 183
        Me.Label28.Text = "ID Number"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(338, 475)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(109, 20)
        Me.Label25.TabIndex = 180
        Me.Label25.Text = "Government ID"
        '
        'txtboxIDNumber
        '
        Me.txtboxIDNumber.BackColor = System.Drawing.Color.White
        Me.txtboxIDNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxIDNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxIDNumber.Location = New System.Drawing.Point(615, 497)
        Me.txtboxIDNumber.Name = "txtboxIDNumber"
        Me.txtboxIDNumber.ReadOnly = True
        Me.txtboxIDNumber.Size = New System.Drawing.Size(295, 27)
        Me.txtboxIDNumber.TabIndex = 12
        Me.txtboxIDNumber.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(612, 414)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Email Address"
        '
        'dtpickerDateOfBirth
        '
        Me.dtpickerDateOfBirth.Enabled = False
        Me.dtpickerDateOfBirth.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dtpickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpickerDateOfBirth.Location = New System.Drawing.Point(342, 374)
        Me.dtpickerDateOfBirth.Name = "dtpickerDateOfBirth"
        Me.dtpickerDateOfBirth.Size = New System.Drawing.Size(267, 27)
        Me.dtpickerDateOfBirth.TabIndex = 6
        Me.dtpickerDateOfBirth.TabStop = False
        '
        'txtboxEmailAddress
        '
        Me.txtboxEmailAddress.BackColor = System.Drawing.Color.White
        Me.txtboxEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxEmailAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxEmailAddress.Location = New System.Drawing.Point(615, 436)
        Me.txtboxEmailAddress.Name = "txtboxEmailAddress"
        Me.txtboxEmailAddress.ReadOnly = True
        Me.txtboxEmailAddress.Size = New System.Drawing.Size(295, 27)
        Me.txtboxEmailAddress.TabIndex = 10
        Me.txtboxEmailAddress.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(338, 414)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 20)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Contact Number"
        '
        'txtboxContactNumber
        '
        Me.txtboxContactNumber.BackColor = System.Drawing.Color.White
        Me.txtboxContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxContactNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxContactNumber.Location = New System.Drawing.Point(342, 436)
        Me.txtboxContactNumber.Name = "txtboxContactNumber"
        Me.txtboxContactNumber.ReadOnly = True
        Me.txtboxContactNumber.Size = New System.Drawing.Size(267, 27)
        Me.txtboxContactNumber.TabIndex = 9
        Me.txtboxContactNumber.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(338, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 20)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Date of Birth"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(754, 351)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(32, 20)
        Me.Label22.TabIndex = 178
        Me.Label22.Text = "Sex"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label29.ForeColor = System.Drawing.Color.DimGray
        Me.Label29.Location = New System.Drawing.Point(430, 354)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(121, 17)
        Me.Label29.TabIndex = 101
        Me.Label29.Text = "Input (yyyy/mm/dd)"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(611, 352)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 20)
        Me.Label18.TabIndex = 187
        Me.Label18.Text = "Age"
        '
        'txtboxAge
        '
        Me.txtboxAge.BackColor = System.Drawing.Color.White
        Me.txtboxAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxAge.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxAge.Location = New System.Drawing.Point(615, 374)
        Me.txtboxAge.Name = "txtboxAge"
        Me.txtboxAge.ReadOnly = True
        Me.txtboxAge.Size = New System.Drawing.Size(137, 27)
        Me.txtboxAge.TabIndex = 7
        Me.txtboxAge.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Location = New System.Drawing.Point(51, 565)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(858, 10)
        Me.Panel3.TabIndex = 194
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.ForeColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(52, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(858, 10)
        Me.Panel2.TabIndex = 192
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label20.Location = New System.Drawing.Point(47, 539)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(175, 23)
        Me.Label20.TabIndex = 193
        Me.Label20.Tag = ""
        Me.Label20.Text = "Address Information"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(47, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(151, 23)
        Me.Label19.TabIndex = 191
        Me.Label19.Tag = ""
        Me.Label19.Text = "Basic Information"
        '
        'txtboxMiddleName
        '
        Me.txtboxMiddleName.BackColor = System.Drawing.Color.White
        Me.txtboxMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxMiddleName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxMiddleName.Location = New System.Drawing.Point(342, 257)
        Me.txtboxMiddleName.Name = "txtboxMiddleName"
        Me.txtboxMiddleName.ReadOnly = True
        Me.txtboxMiddleName.Size = New System.Drawing.Size(568, 27)
        Me.txtboxMiddleName.TabIndex = 4
        Me.txtboxMiddleName.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(338, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Middle Name"
        '
        'txtboxFirstName
        '
        Me.txtboxFirstName.BackColor = System.Drawing.Color.White
        Me.txtboxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxFirstName.Location = New System.Drawing.Point(342, 197)
        Me.txtboxFirstName.Name = "txtboxFirstName"
        Me.txtboxFirstName.ReadOnly = True
        Me.txtboxFirstName.Size = New System.Drawing.Size(568, 27)
        Me.txtboxFirstName.TabIndex = 3
        Me.txtboxFirstName.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(338, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(338, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 20)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Employee Role"
        '
        'txtboxLastName
        '
        Me.txtboxLastName.BackColor = System.Drawing.Color.White
        Me.txtboxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxLastName.Location = New System.Drawing.Point(342, 314)
        Me.txtboxLastName.Name = "txtboxLastName"
        Me.txtboxLastName.ReadOnly = True
        Me.txtboxLastName.Size = New System.Drawing.Size(568, 27)
        Me.txtboxLastName.TabIndex = 5
        Me.txtboxLastName.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(338, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Last Name"
        '
        'txtboxEmployeeNumber
        '
        Me.txtboxEmployeeNumber.BackColor = System.Drawing.Color.White
        Me.txtboxEmployeeNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxEmployeeNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxEmployeeNumber.Location = New System.Drawing.Point(643, 37)
        Me.txtboxEmployeeNumber.Name = "txtboxEmployeeNumber"
        Me.txtboxEmployeeNumber.ReadOnly = True
        Me.txtboxEmployeeNumber.Size = New System.Drawing.Size(267, 27)
        Me.txtboxEmployeeNumber.TabIndex = 1
        Me.txtboxEmployeeNumber.TabStop = False
        Me.txtboxEmployeeNumber.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(639, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Employee Number"
        Me.Label4.Visible = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(814, 931)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(107, 41)
        Me.btnClose.TabIndex = 63
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'ViewEmployeeDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(985, 984)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.panelViewEmployee)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewEmployeeDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelViewEmployee.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picboxEmployeePhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents panelViewEmployee As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtboxZipCode As TextBox
    Friend WithEvents txtboxBrgy As TextBox
    Friend WithEvents txtboxMunicipality As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txtboxProvince As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtboxStreet As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtboxHouseNo As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents picboxEmployeePhoto As PictureBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtboxIDNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpickerDateOfBirth As DateTimePicker
    Friend WithEvents txtboxEmailAddress As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtboxContactNumber As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtboxMiddleName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtboxFirstName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtboxLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxEmployeeNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents txtboxJobPosition As TextBox
    Friend WithEvents txtboxAge As TextBox
    Friend WithEvents txtboxGender As TextBox
    Friend WithEvents txtboxGovID As TextBox
End Class
