﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProcedure
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProcedure))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlAddProcedure = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbboxCategory = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtboxPrice = New System.Windows.Forms.TextBox()
        Me.txtboxDescription = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtboxPrcedureName = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtboxProcedureNumber = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TopGrayPanel = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlAddProcedure.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopGrayPanel.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(201, 534)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 41)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(314, 534)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 41)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'pnlAddProcedure
        '
        Me.pnlAddProcedure.Controls.Add(Me.GroupBox1)
        Me.pnlAddProcedure.Controls.Add(Me.btnCancel)
        Me.pnlAddProcedure.Controls.Add(Me.btnSave)
        Me.pnlAddProcedure.Controls.Add(Me.txtboxProcedureNumber)
        Me.pnlAddProcedure.Controls.Add(Me.Label40)
        Me.pnlAddProcedure.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAddProcedure.Location = New System.Drawing.Point(0, 68)
        Me.pnlAddProcedure.Name = "pnlAddProcedure"
        Me.pnlAddProcedure.Size = New System.Drawing.Size(473, 587)
        Me.pnlAddProcedure.TabIndex = 206
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cmbboxCategory)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.txtboxPrice)
        Me.GroupBox1.Controls.Add(Me.txtboxDescription)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.txtboxPrcedureName)
        Me.GroupBox1.Controls.Add(Me.Label47)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 442)
        Me.GroupBox1.TabIndex = 216
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(98, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 17)
        Me.Label4.TabIndex = 222
        Me.Label4.Text = "*"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(113, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 17)
        Me.Label3.TabIndex = 221
        Me.Label3.Text = "*"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(140, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 17)
        Me.Label2.TabIndex = 220
        Me.Label2.Text = "*"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(147, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 17)
        Me.Label13.TabIndex = 219
        Me.Label13.Text = "*"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbboxCategory
        '
        Me.cmbboxCategory.AccessibleName = "Category"
        Me.cmbboxCategory.BackColor = System.Drawing.Color.White
        Me.cmbboxCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxCategory.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxCategory.ForeColor = System.Drawing.Color.Black
        Me.cmbboxCategory.FormattingEnabled = True
        Me.cmbboxCategory.Items.AddRange(New Object() {"Pediatrics", "Orthodontics", "Cosmetics", "General Dentistry"})
        Me.cmbboxCategory.Location = New System.Drawing.Point(35, 351)
        Me.cmbboxCategory.Name = "cmbboxCategory"
        Me.cmbboxCategory.Size = New System.Drawing.Size(374, 28)
        Me.cmbboxCategory.TabIndex = 4
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(31, 129)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(112, 20)
        Me.Label42.TabIndex = 125
        Me.Label42.Text = "Procedure Price"
        '
        'txtboxPrice
        '
        Me.txtboxPrice.AccessibleName = "Procedure Price"
        Me.txtboxPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxPrice.ForeColor = System.Drawing.Color.Black
        Me.txtboxPrice.Location = New System.Drawing.Point(35, 151)
        Me.txtboxPrice.Name = "txtboxPrice"
        Me.txtboxPrice.Size = New System.Drawing.Size(374, 27)
        Me.txtboxPrice.TabIndex = 2
        '
        'txtboxDescription
        '
        Me.txtboxDescription.AccessibleName = "Description"
        Me.txtboxDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxDescription.ForeColor = System.Drawing.Color.Black
        Me.txtboxDescription.Location = New System.Drawing.Point(35, 213)
        Me.txtboxDescription.Multiline = True
        Me.txtboxDescription.Name = "txtboxDescription"
        Me.txtboxDescription.Size = New System.Drawing.Size(374, 106)
        Me.txtboxDescription.TabIndex = 3
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(31, 329)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(69, 20)
        Me.Label27.TabIndex = 113
        Me.Label27.Text = "Category"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(31, 191)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(85, 20)
        Me.Label37.TabIndex = 111
        Me.Label37.Text = "Description"
        '
        'txtboxPrcedureName
        '
        Me.txtboxPrcedureName.AccessibleName = "Procedure Name"
        Me.txtboxPrcedureName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxPrcedureName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxPrcedureName.ForeColor = System.Drawing.Color.Black
        Me.txtboxPrcedureName.Location = New System.Drawing.Point(35, 89)
        Me.txtboxPrcedureName.Name = "txtboxPrcedureName"
        Me.txtboxPrcedureName.Size = New System.Drawing.Size(374, 27)
        Me.txtboxPrcedureName.TabIndex = 1
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(31, 67)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(120, 20)
        Me.Label47.TabIndex = 107
        Me.Label47.Text = "Procedure Name"
        '
        'txtboxProcedureNumber
        '
        Me.txtboxProcedureNumber.AccessibleName = "Procedure Name"
        Me.txtboxProcedureNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxProcedureNumber.Location = New System.Drawing.Point(47, 486)
        Me.txtboxProcedureNumber.Name = "txtboxProcedureNumber"
        Me.txtboxProcedureNumber.ReadOnly = True
        Me.txtboxProcedureNumber.Size = New System.Drawing.Size(374, 27)
        Me.txtboxProcedureNumber.TabIndex = 63
        Me.txtboxProcedureNumber.Visible = False
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(43, 464)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(134, 20)
        Me.Label40.TabIndex = 105
        Me.Label40.Text = "Procedure Number"
        Me.Label40.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(40, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 28)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Add Procedure"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 25)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'TopGrayPanel
        '
        Me.TopGrayPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TopGrayPanel.Controls.Add(Me.PictureBox1)
        Me.TopGrayPanel.Controls.Add(Me.Label1)
        Me.TopGrayPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopGrayPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopGrayPanel.Name = "TopGrayPanel"
        Me.TopGrayPanel.Size = New System.Drawing.Size(473, 68)
        Me.TopGrayPanel.TabIndex = 205
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AddProcedure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(473, 655)
        Me.Controls.Add(Me.pnlAddProcedure)
        Me.Controls.Add(Me.TopGrayPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddProcedure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlAddProcedure.ResumeLayout(False)
        Me.pnlAddProcedure.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopGrayPanel.ResumeLayout(False)
        Me.TopGrayPanel.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents pnlAddProcedure As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbboxCategory As ComboBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txtboxPrice As TextBox
    Friend WithEvents txtboxDescription As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents txtboxPrcedureName As TextBox
    Friend WithEvents txtboxProcedureNumber As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TopGrayPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
