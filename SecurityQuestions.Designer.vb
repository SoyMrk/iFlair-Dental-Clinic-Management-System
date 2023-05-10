<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SecurityQuestions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SecurityQuestions))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpboxSecurityQuestion = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cmbboxQuestion3 = New System.Windows.Forms.ComboBox()
        Me.txtboxQuestion3Answer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbboxQuestion2 = New System.Windows.Forms.ComboBox()
        Me.txtboxQuestion2Answer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbboxQuestion1 = New System.Windows.Forms.ComboBox()
        Me.txtboxQuestion1Answer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxSecurityQuestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(602, 54)
        Me.Panel1.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 15)
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
        Me.Label6.Location = New System.Drawing.Point(42, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 28)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Security Questions"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpboxSecurityQuestion
        '
        Me.grpboxSecurityQuestion.BackColor = System.Drawing.Color.Transparent
        Me.grpboxSecurityQuestion.Controls.Add(Me.Label29)
        Me.grpboxSecurityQuestion.Controls.Add(Me.cmbboxQuestion3)
        Me.grpboxSecurityQuestion.Controls.Add(Me.txtboxQuestion3Answer)
        Me.grpboxSecurityQuestion.Controls.Add(Me.Label5)
        Me.grpboxSecurityQuestion.Controls.Add(Me.Label7)
        Me.grpboxSecurityQuestion.Controls.Add(Me.cmbboxQuestion2)
        Me.grpboxSecurityQuestion.Controls.Add(Me.txtboxQuestion2Answer)
        Me.grpboxSecurityQuestion.Controls.Add(Me.Label2)
        Me.grpboxSecurityQuestion.Controls.Add(Me.Label4)
        Me.grpboxSecurityQuestion.Controls.Add(Me.cmbboxQuestion1)
        Me.grpboxSecurityQuestion.Controls.Add(Me.txtboxQuestion1Answer)
        Me.grpboxSecurityQuestion.Controls.Add(Me.Label1)
        Me.grpboxSecurityQuestion.Controls.Add(Me.Label3)
        Me.grpboxSecurityQuestion.Location = New System.Drawing.Point(12, 56)
        Me.grpboxSecurityQuestion.Name = "grpboxSecurityQuestion"
        Me.grpboxSecurityQuestion.Size = New System.Drawing.Size(602, 535)
        Me.grpboxSecurityQuestion.TabIndex = 34
        Me.grpboxSecurityQuestion.TabStop = False
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label29.ForeColor = System.Drawing.Color.DimGray
        Me.Label29.Location = New System.Drawing.Point(32, 26)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(538, 34)
        Me.Label29.TabIndex = 103
        Me.Label29.Text = "To help ensure the security of your account, choose three questions and provide y" &
    "our answers below."
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbboxQuestion3
        '
        Me.cmbboxQuestion3.AccessibleName = "Question 3"
        Me.cmbboxQuestion3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxQuestion3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxQuestion3.FormattingEnabled = True
        Me.cmbboxQuestion3.Items.AddRange(New Object() {"What is the name of your first pet?", "What elementary school did you attend?", "What is your childhood nickname?", "When you were young, what did you want to be when you grew up?", "Where was your best family vacation as a kid?", "Who was your first crush?"})
        Me.cmbboxQuestion3.Location = New System.Drawing.Point(32, 396)
        Me.cmbboxQuestion3.Name = "cmbboxQuestion3"
        Me.cmbboxQuestion3.Size = New System.Drawing.Size(538, 33)
        Me.cmbboxQuestion3.TabIndex = 5
        '
        'txtboxQuestion3Answer
        '
        Me.txtboxQuestion3Answer.AccessibleName = "Answer"
        Me.txtboxQuestion3Answer.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxQuestion3Answer.Location = New System.Drawing.Point(32, 460)
        Me.txtboxQuestion3Answer.Name = "txtboxQuestion3Answer"
        Me.txtboxQuestion3Answer.Size = New System.Drawing.Size(538, 32)
        Me.txtboxQuestion3Answer.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(28, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Question 3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 437)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Answer"
        '
        'cmbboxQuestion2
        '
        Me.cmbboxQuestion2.AccessibleName = "Question 2"
        Me.cmbboxQuestion2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxQuestion2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxQuestion2.FormattingEnabled = True
        Me.cmbboxQuestion2.Items.AddRange(New Object() {"What is the name of your first pet?", "What elementary school did you attend?", "What is your childhood nickname?", "When you were young, what did you want to be when you grew up?", "Where was your best family vacation as a kid?", "Who was your first crush?"})
        Me.cmbboxQuestion2.Location = New System.Drawing.Point(32, 255)
        Me.cmbboxQuestion2.Name = "cmbboxQuestion2"
        Me.cmbboxQuestion2.Size = New System.Drawing.Size(538, 33)
        Me.cmbboxQuestion2.TabIndex = 3
        '
        'txtboxQuestion2Answer
        '
        Me.txtboxQuestion2Answer.AccessibleName = "Answer"
        Me.txtboxQuestion2Answer.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxQuestion2Answer.Location = New System.Drawing.Point(32, 319)
        Me.txtboxQuestion2Answer.Name = "txtboxQuestion2Answer"
        Me.txtboxQuestion2Answer.Size = New System.Drawing.Size(538, 32)
        Me.txtboxQuestion2Answer.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(28, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Question 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Answer"
        '
        'cmbboxQuestion1
        '
        Me.cmbboxQuestion1.AccessibleName = "Question 1"
        Me.cmbboxQuestion1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxQuestion1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxQuestion1.FormattingEnabled = True
        Me.cmbboxQuestion1.Items.AddRange(New Object() {"What is the name of your first pet?", "What elementary school did you attend?", "What is your childhood nickname?", "When you were young, what did you want to be when you grew up?", "Where was your best family vacation as a kid?", "Who was your first crush?"})
        Me.cmbboxQuestion1.Location = New System.Drawing.Point(32, 111)
        Me.cmbboxQuestion1.Name = "cmbboxQuestion1"
        Me.cmbboxQuestion1.Size = New System.Drawing.Size(538, 33)
        Me.cmbboxQuestion1.TabIndex = 1
        '
        'txtboxQuestion1Answer
        '
        Me.txtboxQuestion1Answer.AccessibleName = "Answer"
        Me.txtboxQuestion1Answer.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxQuestion1Answer.Location = New System.Drawing.Point(32, 177)
        Me.txtboxQuestion1Answer.Name = "txtboxQuestion1Answer"
        Me.txtboxQuestion1Answer.Size = New System.Drawing.Size(538, 32)
        Me.txtboxQuestion1Answer.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(28, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Question 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Answer"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(475, 620)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 41)
        Me.btnSave.TabIndex = 44
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'SecurityQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(626, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpboxSecurityQuestion)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SecurityQuestions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SecurityQuestions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxSecurityQuestion.ResumeLayout(False)
        Me.grpboxSecurityQuestion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents grpboxSecurityQuestion As GroupBox
    Friend WithEvents cmbboxQuestion1 As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtboxQuestion1Answer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbboxQuestion3 As ComboBox
    Friend WithEvents txtboxQuestion3Answer As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbboxQuestion2 As ComboBox
    Friend WithEvents txtboxQuestion2Answer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label29 As Label
End Class
