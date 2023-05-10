<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ButtonUploadDocu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ButtonUploadDocu))
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnUploadXray = New System.Windows.Forms.Button()
        Me.btnUploadDocument = New System.Windows.Forms.Button()
        Me.btnViewFiles = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel9.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel9.Controls.Add(Me.btnUploadXray)
        Me.Panel9.Controls.Add(Me.btnUploadDocument)
        Me.Panel9.Controls.Add(Me.btnViewFiles)
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1898, 68)
        Me.Panel9.TabIndex = 211
        '
        'btnUploadXray
        '
        Me.btnUploadXray.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUploadXray.BackColor = System.Drawing.Color.Gray
        Me.btnUploadXray.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadXray.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnUploadXray.FlatAppearance.BorderSize = 0
        Me.btnUploadXray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadXray.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUploadXray.ForeColor = System.Drawing.Color.White
        Me.btnUploadXray.Image = CType(resources.GetObject("btnUploadXray.Image"), System.Drawing.Image)
        Me.btnUploadXray.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUploadXray.Location = New System.Drawing.Point(1701, 15)
        Me.btnUploadXray.Name = "btnUploadXray"
        Me.btnUploadXray.Size = New System.Drawing.Size(86, 38)
        Me.btnUploadXray.TabIndex = 245
        Me.btnUploadXray.TabStop = False
        Me.btnUploadXray.Text = "X-Ray"
        Me.btnUploadXray.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnUploadXray, "Upload new X-Ray")
        Me.btnUploadXray.UseVisualStyleBackColor = False
        '
        'btnUploadDocument
        '
        Me.btnUploadDocument.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUploadDocument.BackColor = System.Drawing.Color.Orange
        Me.btnUploadDocument.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadDocument.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnUploadDocument.FlatAppearance.BorderSize = 0
        Me.btnUploadDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadDocument.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUploadDocument.ForeColor = System.Drawing.Color.White
        Me.btnUploadDocument.Image = CType(resources.GetObject("btnUploadDocument.Image"), System.Drawing.Image)
        Me.btnUploadDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUploadDocument.Location = New System.Drawing.Point(1793, 15)
        Me.btnUploadDocument.Name = "btnUploadDocument"
        Me.btnUploadDocument.Size = New System.Drawing.Size(86, 38)
        Me.btnUploadDocument.TabIndex = 203
        Me.btnUploadDocument.Text = "Photo"
        Me.btnUploadDocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnUploadDocument, "Upload new photo")
        Me.btnUploadDocument.UseVisualStyleBackColor = False
        '
        'btnViewFiles
        '
        Me.btnViewFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewFiles.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnViewFiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewFiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnViewFiles.FlatAppearance.BorderSize = 0
        Me.btnViewFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewFiles.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnViewFiles.ForeColor = System.Drawing.Color.White
        Me.btnViewFiles.Image = CType(resources.GetObject("btnViewFiles.Image"), System.Drawing.Image)
        Me.btnViewFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewFiles.Location = New System.Drawing.Point(1594, 15)
        Me.btnViewFiles.Name = "btnViewFiles"
        Me.btnViewFiles.Size = New System.Drawing.Size(101, 38)
        Me.btnViewFiles.TabIndex = 244
        Me.btnViewFiles.Text = "Open File"
        Me.btnViewFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnViewFiles, "Open patient file")
        Me.btnViewFiles.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(13, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 25)
        Me.Label11.TabIndex = 202
        Me.Label11.Text = "Photos"
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
        Me.Panel1.Size = New System.Drawing.Size(1898, 106)
        Me.Panel1.TabIndex = 214
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(62, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(169, 20)
        Me.Label13.TabIndex = 227
        Me.Label13.Text = "There are no photos yet."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 40)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 174)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1898, 49)
        Me.Panel3.TabIndex = 216
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
        'ButtonUploadDocu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1898, 222)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ButtonUploadDocu"
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnUploadDocument As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnViewFiles As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnUploadXray As Button
End Class
