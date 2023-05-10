<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ButtonAddMedicalHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ButtonAddMedicalHistory))
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.pnlAdd = New System.Windows.Forms.Panel()
        Me.btnAddMedicalHistory = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel9.SuspendLayout()
        Me.pnlAdd.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel9.Controls.Add(Me.pnlAdd)
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1898, 68)
        Me.Panel9.TabIndex = 210
        '
        'pnlAdd
        '
        Me.pnlAdd.Controls.Add(Me.btnAddMedicalHistory)
        Me.pnlAdd.Location = New System.Drawing.Point(166, 19)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.Size = New System.Drawing.Size(31, 31)
        Me.pnlAdd.TabIndex = 205
        '
        'btnAddMedicalHistory
        '
        Me.btnAddMedicalHistory.BackColor = System.Drawing.Color.White
        Me.btnAddMedicalHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddMedicalHistory.FlatAppearance.BorderSize = 0
        Me.btnAddMedicalHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnAddMedicalHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAddMedicalHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddMedicalHistory.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddMedicalHistory.ForeColor = System.Drawing.Color.White
        Me.btnAddMedicalHistory.Image = CType(resources.GetObject("btnAddMedicalHistory.Image"), System.Drawing.Image)
        Me.btnAddMedicalHistory.Location = New System.Drawing.Point(-8, -4)
        Me.btnAddMedicalHistory.Name = "btnAddMedicalHistory"
        Me.btnAddMedicalHistory.Size = New System.Drawing.Size(45, 38)
        Me.btnAddMedicalHistory.TabIndex = 204
        Me.ToolTip1.SetToolTip(Me.btnAddMedicalHistory, "Add medical history")
        Me.btnAddMedicalHistory.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 25)
        Me.Label11.TabIndex = 202
        Me.Label11.Text = "Medical History"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1898, 81)
        Me.Panel1.TabIndex = 211
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(59, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(314, 20)
        Me.Label13.TabIndex = 227
        Me.Label13.Text = "There is no medical history for this patient yet."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 40)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 149)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1898, 49)
        Me.Panel3.TabIndex = 214
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.BackColor = System.Drawing.Color.White
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 50
        '
        'ButtonAddMedicalHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1898, 198)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ButtonAddMedicalHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ButtonAddMedicalHistory"
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.pnlAdd.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAddMedicalHistory As Button
    Friend WithEvents pnlAdd As Panel
    Friend WithEvents ToolTip1 As ToolTip
End Class
