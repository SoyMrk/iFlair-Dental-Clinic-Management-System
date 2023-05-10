<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfileAccountInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfileAccountInfo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlProfileAccountInfo = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEditPass = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtboxAccountType = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnEditUsername = New System.Windows.Forms.Button()
        Me.txtboxUsername = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txtboxDateCreated = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlProfileAccountInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 25)
        Me.Label1.TabIndex = 252
        Me.Label1.Text = "Account Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlProfileAccountInfo
        '
        Me.pnlProfileAccountInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlProfileAccountInfo.Controls.Add(Me.Panel1)
        Me.pnlProfileAccountInfo.Controls.Add(Me.GroupBox3)
        Me.pnlProfileAccountInfo.Controls.Add(Me.GroupBox5)
        Me.pnlProfileAccountInfo.Controls.Add(Me.GroupBox4)
        Me.pnlProfileAccountInfo.Controls.Add(Me.GroupBox6)
        Me.pnlProfileAccountInfo.Controls.Add(Me.GroupBox9)
        Me.pnlProfileAccountInfo.Controls.Add(Me.GroupBox10)
        Me.pnlProfileAccountInfo.Location = New System.Drawing.Point(0, 0)
        Me.pnlProfileAccountInfo.Name = "pnlProfileAccountInfo"
        Me.pnlProfileAccountInfo.Size = New System.Drawing.Size(971, 667)
        Me.pnlProfileAccountInfo.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnEditPass)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(971, 81)
        Me.Panel1.TabIndex = 491
        '
        'btnEditPass
        '
        Me.btnEditPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditPass.BackColor = System.Drawing.Color.Transparent
        Me.btnEditPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditPass.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnEditPass.FlatAppearance.BorderSize = 0
        Me.btnEditPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.btnEditPass.ForeColor = System.Drawing.Color.White
        Me.btnEditPass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditPass.Location = New System.Drawing.Point(797, 27)
        Me.btnEditPass.Name = "btnEditPass"
        Me.btnEditPass.Size = New System.Drawing.Size(148, 29)
        Me.btnEditPass.TabIndex = 1
        Me.btnEditPass.TabStop = False
        Me.btnEditPass.Text = "Change Password"
        Me.btnEditPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditPass.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txtboxAccountType)
        Me.GroupBox3.Location = New System.Drawing.Point(334, 67)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(637, 52)
        Me.GroupBox3.TabIndex = 446
        Me.GroupBox3.TabStop = False
        '
        'txtboxAccountType
        '
        Me.txtboxAccountType.AccessibleName = "Account Type"
        Me.txtboxAccountType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxAccountType.BackColor = System.Drawing.Color.White
        Me.txtboxAccountType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxAccountType.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxAccountType.ForeColor = System.Drawing.Color.Black
        Me.txtboxAccountType.Location = New System.Drawing.Point(9, 19)
        Me.txtboxAccountType.Name = "txtboxAccountType"
        Me.txtboxAccountType.ReadOnly = True
        Me.txtboxAccountType.Size = New System.Drawing.Size(591, 23)
        Me.txtboxAccountType.TabIndex = 2
        Me.txtboxAccountType.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.btnEditUsername)
        Me.GroupBox5.Controls.Add(Me.txtboxUsername)
        Me.GroupBox5.Location = New System.Drawing.Point(334, 108)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(637, 52)
        Me.GroupBox5.TabIndex = 448
        Me.GroupBox5.TabStop = False
        '
        'btnEditUsername
        '
        Me.btnEditUsername.AccessibleName = "Edit"
        Me.btnEditUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditUsername.BackColor = System.Drawing.Color.White
        Me.btnEditUsername.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditUsername.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnEditUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditUsername.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnEditUsername.Location = New System.Drawing.Point(551, 16)
        Me.btnEditUsername.Name = "btnEditUsername"
        Me.btnEditUsername.Size = New System.Drawing.Size(49, 29)
        Me.btnEditUsername.TabIndex = 4
        Me.btnEditUsername.TabStop = False
        Me.btnEditUsername.Text = "Edit"
        Me.btnEditUsername.UseVisualStyleBackColor = False
        '
        'txtboxUsername
        '
        Me.txtboxUsername.AccessibleName = "Username"
        Me.txtboxUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxUsername.BackColor = System.Drawing.Color.White
        Me.txtboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxUsername.ForeColor = System.Drawing.Color.Black
        Me.txtboxUsername.Location = New System.Drawing.Point(9, 19)
        Me.txtboxUsername.Name = "txtboxUsername"
        Me.txtboxUsername.ReadOnly = True
        Me.txtboxUsername.Size = New System.Drawing.Size(522, 23)
        Me.txtboxUsername.TabIndex = 3
        Me.txtboxUsername.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 67)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(335, 52)
        Me.GroupBox4.TabIndex = 445
        Me.GroupBox4.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(10, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(113, 23)
        Me.Label21.TabIndex = 253
        Me.Label21.Text = "Account Type"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Location = New System.Drawing.Point(0, 108)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(335, 52)
        Me.GroupBox6.TabIndex = 447
        Me.GroupBox6.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(10, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 23)
        Me.Label18.TabIndex = 257
        Me.Label18.Text = "Username"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox9
        '
        Me.GroupBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox9.Controls.Add(Me.txtboxDateCreated)
        Me.GroupBox9.Location = New System.Drawing.Point(334, 149)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(637, 52)
        Me.GroupBox9.TabIndex = 469
        Me.GroupBox9.TabStop = False
        '
        'txtboxDateCreated
        '
        Me.txtboxDateCreated.AccessibleName = "Date Created"
        Me.txtboxDateCreated.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxDateCreated.BackColor = System.Drawing.Color.White
        Me.txtboxDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxDateCreated.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxDateCreated.ForeColor = System.Drawing.Color.Black
        Me.txtboxDateCreated.Location = New System.Drawing.Point(9, 19)
        Me.txtboxDateCreated.Name = "txtboxDateCreated"
        Me.txtboxDateCreated.ReadOnly = True
        Me.txtboxDateCreated.Size = New System.Drawing.Size(591, 23)
        Me.txtboxDateCreated.TabIndex = 5
        Me.txtboxDateCreated.TabStop = False
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.White
        Me.GroupBox10.Controls.Add(Me.Label2)
        Me.GroupBox10.Location = New System.Drawing.Point(0, 149)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(335, 52)
        Me.GroupBox10.TabIndex = 468
        Me.GroupBox10.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 23)
        Me.Label2.TabIndex = 259
        Me.Label2.Text = "Date Created"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProfileAccountInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(971, 667)
        Me.Controls.Add(Me.pnlProfileAccountInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProfileAccountInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlProfileAccountInfo.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox31 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlProfileAccountInfo As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtboxAccountType As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtboxUsername As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEditUsername As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents txtboxDateCreated As TextBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEditPass As Button
    Friend WithEvents Label3 As Label
End Class
