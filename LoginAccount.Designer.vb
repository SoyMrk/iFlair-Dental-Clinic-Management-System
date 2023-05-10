<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginAccount))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pictureboxFlairLogo = New System.Windows.Forms.PictureBox()
        Me.pictureboxFlairName = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelRegisterAccount = New System.Windows.Forms.Label()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnShowPassword = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.labelForgotPassword = New System.Windows.Forms.Label()
        Me.txtboxUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pictureboxFlairLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureboxFlairName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(712, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 25
        '
        'pictureboxFlairLogo
        '
        Me.pictureboxFlairLogo.BackColor = System.Drawing.Color.Transparent
        Me.pictureboxFlairLogo.Image = CType(resources.GetObject("pictureboxFlairLogo.Image"), System.Drawing.Image)
        Me.pictureboxFlairLogo.Location = New System.Drawing.Point(167, 162)
        Me.pictureboxFlairLogo.Name = "pictureboxFlairLogo"
        Me.pictureboxFlairLogo.Size = New System.Drawing.Size(214, 245)
        Me.pictureboxFlairLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureboxFlairLogo.TabIndex = 0
        Me.pictureboxFlairLogo.TabStop = False
        '
        'pictureboxFlairName
        '
        Me.pictureboxFlairName.BackColor = System.Drawing.Color.Transparent
        Me.pictureboxFlairName.Image = CType(resources.GetObject("pictureboxFlairName.Image"), System.Drawing.Image)
        Me.pictureboxFlairName.Location = New System.Drawing.Point(167, 405)
        Me.pictureboxFlairName.Name = "pictureboxFlairName"
        Me.pictureboxFlairName.Size = New System.Drawing.Size(214, 51)
        Me.pictureboxFlairName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureboxFlairName.TabIndex = 1
        Me.pictureboxFlairName.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.pictureboxFlairName)
        Me.Panel1.Controls.Add(Me.pictureboxFlairLogo)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 628)
        Me.Panel1.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.btnTest)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(563, 12)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(586, 628)
        Me.Panel2.TabIndex = 63
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.labelRegisterAccount)
        Me.GroupBox2.Location = New System.Drawing.Point(92, 457)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 85)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(63, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 20)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Don't have an account?"
        '
        'labelRegisterAccount
        '
        Me.labelRegisterAccount.AccessibleName = "Register Account"
        Me.labelRegisterAccount.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labelRegisterAccount.AutoSize = True
        Me.labelRegisterAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelRegisterAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelRegisterAccount.ForeColor = System.Drawing.Color.Red
        Me.labelRegisterAccount.Location = New System.Drawing.Point(223, 37)
        Me.labelRegisterAccount.Name = "labelRegisterAccount"
        Me.labelRegisterAccount.Size = New System.Drawing.Size(124, 20)
        Me.labelRegisterAccount.TabIndex = 6
        Me.labelRegisterAccount.Text = "Register Account"
        '
        'btnTest
        '
        Me.btnTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTest.BackColor = System.Drawing.Color.Transparent
        Me.btnTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnTest.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTest.ForeColor = System.Drawing.Color.DimGray
        Me.btnTest.Location = New System.Drawing.Point(452, 13)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(122, 28)
        Me.btnTest.TabIndex = 7
        Me.btnTest.TabStop = False
        Me.btnTest.Text = "Test Connection"
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnShowPassword)
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Controls.Add(Me.labelForgotPassword)
        Me.GroupBox1.Controls.Add(Me.txtboxUsername)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtboxPassword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(92, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 368)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login Account"
        '
        'btnShowPassword
        '
        Me.btnShowPassword.AccessibleName = "Show Password"
        Me.btnShowPassword.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnShowPassword.BackColor = System.Drawing.Color.White
        Me.btnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowPassword.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnShowPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnShowPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPassword.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnShowPassword.ForeColor = System.Drawing.Color.White
        Me.btnShowPassword.Image = CType(resources.GetObject("btnShowPassword.Image"), System.Drawing.Image)
        Me.btnShowPassword.Location = New System.Drawing.Point(321, 168)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New System.Drawing.Size(32, 26)
        Me.btnShowPassword.TabIndex = 3
        Me.btnShowPassword.TabStop = False
        Me.btnShowPassword.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.AccessibleName = "Login"
        Me.btnLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(65, 246)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(289, 42)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login "
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'labelForgotPassword
        '
        Me.labelForgotPassword.AccessibleName = "Forgot Password"
        Me.labelForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.labelForgotPassword.AutoSize = True
        Me.labelForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labelForgotPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelForgotPassword.Location = New System.Drawing.Point(155, 307)
        Me.labelForgotPassword.Name = "labelForgotPassword"
        Me.labelForgotPassword.Size = New System.Drawing.Size(119, 19)
        Me.labelForgotPassword.TabIndex = 5
        Me.labelForgotPassword.Text = "Forgot Password?"
        '
        'txtboxUsername
        '
        Me.txtboxUsername.AccessibleName = "Username"
        Me.txtboxUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxUsername.Location = New System.Drawing.Point(65, 98)
        Me.txtboxUsername.Name = "txtboxUsername"
        Me.txtboxUsername.Size = New System.Drawing.Size(289, 30)
        Me.txtboxUsername.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(62, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Password"
        '
        'txtboxPassword
        '
        Me.txtboxPassword.AccessibleName = "Password"
        Me.txtboxPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxPassword.Location = New System.Drawing.Point(65, 167)
        Me.txtboxPassword.Name = "txtboxPassword"
        Me.txtboxPassword.Size = New System.Drawing.Size(289, 30)
        Me.txtboxPassword.TabIndex = 2
        Me.txtboxPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(59, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Username"
        '
        'LoginAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1161, 652)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "LoginAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pictureboxFlairLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureboxFlairName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents pictureboxFlairLogo As PictureBox
    Friend WithEvents pictureboxFlairName As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTest As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnShowPassword As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents labelForgotPassword As Label
    Friend WithEvents txtboxUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents labelRegisterAccount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
