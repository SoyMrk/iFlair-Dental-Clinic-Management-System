<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddAppointment))
        Me.pnlBG = New System.Windows.Forms.Panel()
        Me.pnlAddAppointment = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlClicked = New System.Windows.Forms.Panel()
        Me.btnOldPatient = New System.Windows.Forms.Button()
        Me.btnNewPatient = New System.Windows.Forms.Button()
        Me.TopGrayPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlBG.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TopGrayPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBG
        '
        Me.pnlBG.Controls.Add(Me.pnlAddAppointment)
        Me.pnlBG.Controls.Add(Me.Panel1)
        Me.pnlBG.Controls.Add(Me.TopGrayPanel)
        Me.pnlBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBG.Location = New System.Drawing.Point(0, 0)
        Me.pnlBG.Name = "pnlBG"
        Me.pnlBG.Size = New System.Drawing.Size(1354, 985)
        Me.pnlBG.TabIndex = 0
        '
        'pnlAddAppointment
        '
        Me.pnlAddAppointment.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlAddAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAddAppointment.Location = New System.Drawing.Point(0, 123)
        Me.pnlAddAppointment.Name = "pnlAddAppointment"
        Me.pnlAddAppointment.Size = New System.Drawing.Size(1354, 862)
        Me.pnlAddAppointment.TabIndex = 418
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlClicked)
        Me.Panel1.Controls.Add(Me.btnOldPatient)
        Me.Panel1.Controls.Add(Me.btnNewPatient)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1354, 55)
        Me.Panel1.TabIndex = 417
        '
        'pnlClicked
        '
        Me.pnlClicked.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlClicked.Location = New System.Drawing.Point(0, 48)
        Me.pnlClicked.Name = "pnlClicked"
        Me.pnlClicked.Size = New System.Drawing.Size(185, 11)
        Me.pnlClicked.TabIndex = 198
        '
        'btnOldPatient
        '
        Me.btnOldPatient.BackColor = System.Drawing.Color.White
        Me.btnOldPatient.FlatAppearance.BorderSize = 0
        Me.btnOldPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOldPatient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOldPatient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnOldPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOldPatient.Location = New System.Drawing.Point(192, 5)
        Me.btnOldPatient.Name = "btnOldPatient"
        Me.btnOldPatient.Size = New System.Drawing.Size(185, 39)
        Me.btnOldPatient.TabIndex = 200
        Me.btnOldPatient.Text = "Old Patient"
        Me.btnOldPatient.UseVisualStyleBackColor = False
        '
        'btnNewPatient
        '
        Me.btnNewPatient.BackColor = System.Drawing.Color.White
        Me.btnNewPatient.FlatAppearance.BorderSize = 0
        Me.btnNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewPatient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnNewPatient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnNewPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewPatient.Location = New System.Drawing.Point(3, 5)
        Me.btnNewPatient.Name = "btnNewPatient"
        Me.btnNewPatient.Size = New System.Drawing.Size(182, 39)
        Me.btnNewPatient.TabIndex = 198
        Me.btnNewPatient.Text = "New Patient"
        Me.btnNewPatient.UseVisualStyleBackColor = False
        '
        'TopGrayPanel
        '
        Me.TopGrayPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TopGrayPanel.Controls.Add(Me.PictureBox1)
        Me.TopGrayPanel.Controls.Add(Me.Label1)
        Me.TopGrayPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopGrayPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopGrayPanel.Name = "TopGrayPanel"
        Me.TopGrayPanel.Size = New System.Drawing.Size(1354, 68)
        Me.TopGrayPanel.TabIndex = 204
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 25)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(40, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 28)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Add Appointment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1354, 985)
        Me.Controls.Add(Me.pnlBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlBG.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TopGrayPanel.ResumeLayout(False)
        Me.TopGrayPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBG As Panel
    Friend WithEvents TopGrayPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnProfileAddressInfo As Button
    Friend WithEvents btnNewPatient As Button
    Friend WithEvents pnlAddAppointment As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlClicked As Panel
    Friend WithEvents btnOldPatient As Button
End Class
