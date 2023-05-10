<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountProfile))
        Me.TopGrayPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlAccountProfile = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnUploadPhoto = New System.Windows.Forms.Button()
        Me.pnlProfile = New System.Windows.Forms.Panel()
        Me.picboxEmployeePhoto = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnProfileAccountInfo = New System.Windows.Forms.Button()
        Me.pnlClicked = New System.Windows.Forms.Panel()
        Me.btnProfileAddressInfo = New System.Windows.Forms.Button()
        Me.btnProfileBasicInfo = New System.Windows.Forms.Button()
        Me.txtboxDateofBirth = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtboxContactNo = New System.Windows.Forms.TextBox()
        Me.txtboxMunPov = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtboxRole = New System.Windows.Forms.TextBox()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.TopGrayPanel.SuspendLayout()
        Me.pnlAccountProfile.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.picboxEmployeePhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopGrayPanel
        '
        Me.TopGrayPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TopGrayPanel.Controls.Add(Me.Label2)
        Me.TopGrayPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopGrayPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopGrayPanel.Name = "TopGrayPanel"
        Me.TopGrayPanel.Size = New System.Drawing.Size(1689, 63)
        Me.TopGrayPanel.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 28)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Account Profile"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1689, 15)
        Me.Panel1.TabIndex = 73
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.Control
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 15)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(13, 1012)
        Me.Panel11.TabIndex = 244
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.Control
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel12.Location = New System.Drawing.Point(1676, 15)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(13, 1024)
        Me.Panel12.TabIndex = 245
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 1027)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1676, 12)
        Me.Panel3.TabIndex = 419
        '
        'pnlAccountProfile
        '
        Me.pnlAccountProfile.Controls.Add(Me.Panel4)
        Me.pnlAccountProfile.Controls.Add(Me.Panel11)
        Me.pnlAccountProfile.Controls.Add(Me.Panel3)
        Me.pnlAccountProfile.Controls.Add(Me.Panel12)
        Me.pnlAccountProfile.Controls.Add(Me.Panel1)
        Me.pnlAccountProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAccountProfile.Location = New System.Drawing.Point(0, 63)
        Me.pnlAccountProfile.Name = "pnlAccountProfile"
        Me.pnlAccountProfile.Size = New System.Drawing.Size(1689, 1039)
        Me.pnlAccountProfile.TabIndex = 420
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnUploadPhoto)
        Me.Panel4.Controls.Add(Me.pnlProfile)
        Me.Panel4.Controls.Add(Me.picboxEmployeePhoto)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.txtboxDateofBirth)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtboxContactNo)
        Me.Panel4.Controls.Add(Me.txtboxMunPov)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtboxRole)
        Me.Panel4.Controls.Add(Me.txtboxName)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(13, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1663, 1012)
        Me.Panel4.TabIndex = 423
        '
        'btnUploadPhoto
        '
        Me.btnUploadPhoto.BackColor = System.Drawing.Color.White
        Me.btnUploadPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadPhoto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUploadPhoto.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnUploadPhoto.Image = CType(resources.GetObject("btnUploadPhoto.Image"), System.Drawing.Image)
        Me.btnUploadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUploadPhoto.Location = New System.Drawing.Point(657, 26)
        Me.btnUploadPhoto.Name = "btnUploadPhoto"
        Me.btnUploadPhoto.Size = New System.Drawing.Size(34, 34)
        Me.btnUploadPhoto.TabIndex = 416
        Me.btnUploadPhoto.UseVisualStyleBackColor = False
        '
        'pnlProfile
        '
        Me.pnlProfile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlProfile.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlProfile.Location = New System.Drawing.Point(372, 292)
        Me.pnlProfile.Name = "pnlProfile"
        Me.pnlProfile.Size = New System.Drawing.Size(971, 714)
        Me.pnlProfile.TabIndex = 415
        '
        'picboxEmployeePhoto
        '
        Me.picboxEmployeePhoto.BackColor = System.Drawing.Color.Gainsboro
        Me.picboxEmployeePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxEmployeePhoto.Image = CType(resources.GetObject("picboxEmployeePhoto.Image"), System.Drawing.Image)
        Me.picboxEmployeePhoto.Location = New System.Drawing.Point(372, 26)
        Me.picboxEmployeePhoto.Name = "picboxEmployeePhoto"
        Me.picboxEmployeePhoto.Size = New System.Drawing.Size(319, 205)
        Me.picboxEmployeePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picboxEmployeePhoto.TabIndex = 385
        Me.picboxEmployeePhoto.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnProfileAccountInfo)
        Me.Panel2.Controls.Add(Me.pnlClicked)
        Me.Panel2.Controls.Add(Me.btnProfileAddressInfo)
        Me.Panel2.Controls.Add(Me.btnProfileBasicInfo)
        Me.Panel2.Location = New System.Drawing.Point(372, 237)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(971, 55)
        Me.Panel2.TabIndex = 414
        '
        'btnProfileAccountInfo
        '
        Me.btnProfileAccountInfo.BackColor = System.Drawing.Color.White
        Me.btnProfileAccountInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProfileAccountInfo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnProfileAccountInfo.FlatAppearance.BorderSize = 0
        Me.btnProfileAccountInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnProfileAccountInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnProfileAccountInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfileAccountInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnProfileAccountInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnProfileAccountInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfileAccountInfo.Location = New System.Drawing.Point(370, 0)
        Me.btnProfileAccountInfo.Name = "btnProfileAccountInfo"
        Me.btnProfileAccountInfo.Size = New System.Drawing.Size(185, 55)
        Me.btnProfileAccountInfo.TabIndex = 204
        Me.btnProfileAccountInfo.Text = "Account Information"
        Me.btnProfileAccountInfo.UseVisualStyleBackColor = False
        '
        'pnlClicked
        '
        Me.pnlClicked.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlClicked.Location = New System.Drawing.Point(0, 48)
        Me.pnlClicked.Name = "pnlClicked"
        Me.pnlClicked.Size = New System.Drawing.Size(185, 11)
        Me.pnlClicked.TabIndex = 198
        '
        'btnProfileAddressInfo
        '
        Me.btnProfileAddressInfo.BackColor = System.Drawing.Color.White
        Me.btnProfileAddressInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProfileAddressInfo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnProfileAddressInfo.FlatAppearance.BorderSize = 0
        Me.btnProfileAddressInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnProfileAddressInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnProfileAddressInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfileAddressInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnProfileAddressInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnProfileAddressInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfileAddressInfo.Location = New System.Drawing.Point(185, 0)
        Me.btnProfileAddressInfo.Name = "btnProfileAddressInfo"
        Me.btnProfileAddressInfo.Size = New System.Drawing.Size(185, 55)
        Me.btnProfileAddressInfo.TabIndex = 200
        Me.btnProfileAddressInfo.Text = "Address Information"
        Me.btnProfileAddressInfo.UseVisualStyleBackColor = False
        '
        'btnProfileBasicInfo
        '
        Me.btnProfileBasicInfo.BackColor = System.Drawing.Color.White
        Me.btnProfileBasicInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProfileBasicInfo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnProfileBasicInfo.FlatAppearance.BorderSize = 0
        Me.btnProfileBasicInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnProfileBasicInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnProfileBasicInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfileBasicInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnProfileBasicInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnProfileBasicInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfileBasicInfo.Location = New System.Drawing.Point(0, 0)
        Me.btnProfileBasicInfo.Name = "btnProfileBasicInfo"
        Me.btnProfileBasicInfo.Size = New System.Drawing.Size(185, 55)
        Me.btnProfileBasicInfo.TabIndex = 198
        Me.btnProfileBasicInfo.Text = "Basic Information"
        Me.btnProfileBasicInfo.UseVisualStyleBackColor = False
        '
        'txtboxDateofBirth
        '
        Me.txtboxDateofBirth.BackColor = System.Drawing.Color.White
        Me.txtboxDateofBirth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxDateofBirth.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxDateofBirth.Location = New System.Drawing.Point(744, 173)
        Me.txtboxDateofBirth.Name = "txtboxDateofBirth"
        Me.txtboxDateofBirth.ReadOnly = True
        Me.txtboxDateofBirth.Size = New System.Drawing.Size(346, 24)
        Me.txtboxDateofBirth.TabIndex = 413
        Me.txtboxDateofBirth.Text = "January 28, 2001"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(703, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 20)
        Me.Label3.TabIndex = 408
        Me.Label3.Text = "     "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(703, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 20)
        Me.Label5.TabIndex = 412
        Me.Label5.Text = "     "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtboxContactNo
        '
        Me.txtboxContactNo.BackColor = System.Drawing.Color.White
        Me.txtboxContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxContactNo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxContactNo.Location = New System.Drawing.Point(744, 108)
        Me.txtboxContactNo.Name = "txtboxContactNo"
        Me.txtboxContactNo.ReadOnly = True
        Me.txtboxContactNo.Size = New System.Drawing.Size(346, 24)
        Me.txtboxContactNo.TabIndex = 409
        Me.txtboxContactNo.Text = "09074342722"
        '
        'txtboxMunPov
        '
        Me.txtboxMunPov.BackColor = System.Drawing.Color.White
        Me.txtboxMunPov.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxMunPov.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxMunPov.Location = New System.Drawing.Point(744, 142)
        Me.txtboxMunPov.Name = "txtboxMunPov"
        Me.txtboxMunPov.ReadOnly = True
        Me.txtboxMunPov.Size = New System.Drawing.Size(346, 24)
        Me.txtboxMunPov.TabIndex = 411
        Me.txtboxMunPov.Text = "Daraga, Albay"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(703, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 20)
        Me.Label4.TabIndex = 410
        Me.Label4.Text = "     "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtboxRole
        '
        Me.txtboxRole.BackColor = System.Drawing.Color.White
        Me.txtboxRole.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxRole.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxRole.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtboxRole.Location = New System.Drawing.Point(703, 57)
        Me.txtboxRole.Name = "txtboxRole"
        Me.txtboxRole.ReadOnly = True
        Me.txtboxRole.Size = New System.Drawing.Size(444, 24)
        Me.txtboxRole.TabIndex = 407
        Me.txtboxRole.Text = "Administrator"
        '
        'txtboxName
        '
        Me.txtboxName.BackColor = System.Drawing.Color.White
        Me.txtboxName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxName.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxName.Location = New System.Drawing.Point(703, 16)
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.ReadOnly = True
        Me.txtboxName.Size = New System.Drawing.Size(387, 36)
        Me.txtboxName.TabIndex = 405
        Me.txtboxName.Text = "Montas, Jevah Rea Blancaflor"
        '
        'AccountProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1689, 1102)
        Me.Controls.Add(Me.pnlAccountProfile)
        Me.Controls.Add(Me.TopGrayPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AccountProfile"
        Me.Text = "AccountProfile"
        Me.TopGrayPanel.ResumeLayout(False)
        Me.TopGrayPanel.PerformLayout()
        Me.pnlAccountProfile.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.picboxEmployeePhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopGrayPanel As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnlAccountProfile As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents picboxEmployeePhoto As PictureBox
    Friend WithEvents txtboxName As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtboxDateofBirth As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtboxContactNo As TextBox
    Friend WithEvents txtboxMunPov As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnProfileAccountInfo As Button
    Friend WithEvents pnlClicked As Panel
    Friend WithEvents btnProfileAddressInfo As Button
    Friend WithEvents btnProfileBasicInfo As Button
    Friend WithEvents pnlProfile As Panel
    Friend WithEvents btnUploadPhoto As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxRole As TextBox
End Class
