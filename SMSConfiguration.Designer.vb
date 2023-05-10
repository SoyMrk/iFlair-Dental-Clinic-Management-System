<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SMSConfiguration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMSConfiguration))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtboxAuthToken = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxPhoneNumber = New System.Windows.Forms.TextBox()
        Me.btnShowAuthToken = New System.Windows.Forms.Button()
        Me.txtboxAccountSID = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbboxSMSConfig = New System.Windows.Forms.ComboBox()
        Me.btnConfigureSMS = New System.Windows.Forms.Button()
        Me.btnSetConfiguration = New System.Windows.Forms.Button()
        Me.btnAddSMSConfig = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(584, 68)
        Me.Panel1.TabIndex = 65
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(42, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 28)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "SMS Configuration"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtboxAuthToken
        '
        Me.txtboxAuthToken.AccessibleName = "Auth Token"
        Me.txtboxAuthToken.BackColor = System.Drawing.Color.White
        Me.txtboxAuthToken.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxAuthToken.Location = New System.Drawing.Point(26, 231)
        Me.txtboxAuthToken.Name = "txtboxAuthToken"
        Me.txtboxAuthToken.ReadOnly = True
        Me.txtboxAuthToken.Size = New System.Drawing.Size(496, 34)
        Me.txtboxAuthToken.TabIndex = 5
        Me.txtboxAuthToken.TabStop = False
        Me.txtboxAuthToken.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 181
        Me.Label1.Text = "Auth Token"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 20)
        Me.Label2.TabIndex = 184
        Me.Label2.Text = "Twilio phone number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 179
        Me.Label3.Text = "Account SID"
        '
        'txtboxPhoneNumber
        '
        Me.txtboxPhoneNumber.AccessibleName = "Twilio Phone Number"
        Me.txtboxPhoneNumber.BackColor = System.Drawing.Color.White
        Me.txtboxPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxPhoneNumber.Location = New System.Drawing.Point(26, 301)
        Me.txtboxPhoneNumber.Name = "txtboxPhoneNumber"
        Me.txtboxPhoneNumber.ReadOnly = True
        Me.txtboxPhoneNumber.Size = New System.Drawing.Size(496, 34)
        Me.txtboxPhoneNumber.TabIndex = 7
        Me.txtboxPhoneNumber.TabStop = False
        '
        'btnShowAuthToken
        '
        Me.btnShowAuthToken.BackColor = System.Drawing.Color.White
        Me.btnShowAuthToken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnShowAuthToken.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowAuthToken.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnShowAuthToken.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnShowAuthToken.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnShowAuthToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAuthToken.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnShowAuthToken.ForeColor = System.Drawing.Color.White
        Me.btnShowAuthToken.Image = CType(resources.GetObject("btnShowAuthToken.Image"), System.Drawing.Image)
        Me.btnShowAuthToken.Location = New System.Drawing.Point(489, 234)
        Me.btnShowAuthToken.Name = "btnShowAuthToken"
        Me.btnShowAuthToken.Size = New System.Drawing.Size(32, 26)
        Me.btnShowAuthToken.TabIndex = 6
        Me.btnShowAuthToken.TabStop = False
        Me.btnShowAuthToken.UseVisualStyleBackColor = False
        '
        'txtboxAccountSID
        '
        Me.txtboxAccountSID.AccessibleName = "Account SID"
        Me.txtboxAccountSID.BackColor = System.Drawing.Color.White
        Me.txtboxAccountSID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxAccountSID.Location = New System.Drawing.Point(27, 158)
        Me.txtboxAccountSID.Name = "txtboxAccountSID"
        Me.txtboxAccountSID.ReadOnly = True
        Me.txtboxAccountSID.Size = New System.Drawing.Size(494, 34)
        Me.txtboxAccountSID.TabIndex = 4
        Me.txtboxAccountSID.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnShowAuthToken)
        Me.GroupBox3.Controls.Add(Me.btnDelete)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cmbboxSMSConfig)
        Me.GroupBox3.Controls.Add(Me.btnConfigureSMS)
        Me.GroupBox3.Controls.Add(Me.txtboxAccountSID)
        Me.GroupBox3.Controls.Add(Me.txtboxPhoneNumber)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtboxAuthToken)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox3.Location = New System.Drawing.Point(18, 124)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(549, 432)
        Me.GroupBox3.TabIndex = 217
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SMS Details"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.ForeColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(443, 45)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(78, 30)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Remove"
        Me.ToolTip1.SetToolTip(Me.btnDelete, "This will remove SMS configuration")
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 20)
        Me.Label4.TabIndex = 223
        Me.Label4.Text = "Select Configuration"
        '
        'cmbboxSMSConfig
        '
        Me.cmbboxSMSConfig.BackColor = System.Drawing.Color.White
        Me.cmbboxSMSConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxSMSConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxSMSConfig.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxSMSConfig.ForeColor = System.Drawing.Color.Black
        Me.cmbboxSMSConfig.FormattingEnabled = True
        Me.cmbboxSMSConfig.Location = New System.Drawing.Point(27, 81)
        Me.cmbboxSMSConfig.Name = "cmbboxSMSConfig"
        Me.cmbboxSMSConfig.Size = New System.Drawing.Size(495, 36)
        Me.cmbboxSMSConfig.TabIndex = 2
        '
        'btnConfigureSMS
        '
        Me.btnConfigureSMS.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigureSMS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfigureSMS.FlatAppearance.BorderSize = 0
        Me.btnConfigureSMS.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnConfigureSMS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue
        Me.btnConfigureSMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnConfigureSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigureSMS.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnConfigureSMS.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnConfigureSMS.Location = New System.Drawing.Point(27, 353)
        Me.btnConfigureSMS.Name = "btnConfigureSMS"
        Me.btnConfigureSMS.Size = New System.Drawing.Size(168, 29)
        Me.btnConfigureSMS.TabIndex = 8
        Me.btnConfigureSMS.TabStop = False
        Me.btnConfigureSMS.Text = "Update Configuration"
        Me.btnConfigureSMS.UseVisualStyleBackColor = False
        '
        'btnSetConfiguration
        '
        Me.btnSetConfiguration.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSetConfiguration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetConfiguration.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSetConfiguration.ForeColor = System.Drawing.Color.White
        Me.btnSetConfiguration.Location = New System.Drawing.Point(339, 610)
        Me.btnSetConfiguration.Name = "btnSetConfiguration"
        Me.btnSetConfiguration.Size = New System.Drawing.Size(201, 40)
        Me.btnSetConfiguration.TabIndex = 9
        Me.btnSetConfiguration.TabStop = False
        Me.btnSetConfiguration.Text = "Set Active Configuration"
        Me.btnSetConfiguration.UseVisualStyleBackColor = False
        '
        'btnAddSMSConfig
        '
        Me.btnAddSMSConfig.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAddSMSConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddSMSConfig.FlatAppearance.BorderSize = 0
        Me.btnAddSMSConfig.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnAddSMSConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSMSConfig.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddSMSConfig.ForeColor = System.Drawing.Color.White
        Me.btnAddSMSConfig.Image = CType(resources.GetObject("btnAddSMSConfig.Image"), System.Drawing.Image)
        Me.btnAddSMSConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddSMSConfig.Location = New System.Drawing.Point(461, 83)
        Me.btnAddSMSConfig.Name = "btnAddSMSConfig"
        Me.btnAddSMSConfig.Padding = New System.Windows.Forms.Padding(2)
        Me.btnAddSMSConfig.Size = New System.Drawing.Size(106, 35)
        Me.btnAddSMSConfig.TabIndex = 1
        Me.btnAddSMSConfig.TabStop = False
        Me.btnAddSMSConfig.Text = "Add new"
        Me.btnAddSMSConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnAddSMSConfig, "Add new SMS configuration")
        Me.btnAddSMSConfig.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.BackColor = System.Drawing.Color.White
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 20
        '
        'SMSConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 662)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnSetConfiguration)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAddSMSConfig)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SMSConfiguration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtboxAuthToken As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxPhoneNumber As TextBox
    Friend WithEvents btnShowAuthToken As Button
    Friend WithEvents txtboxAccountSID As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnConfigureSMS As Button
    Friend WithEvents btnSetConfiguration As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbboxSMSConfig As ComboBox
    Friend WithEvents btnAddSMSConfig As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
