<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditInventory))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtboxSupplyNo = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnInventoryHistory = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtboxNewBalance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtboxSupplyName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtboxCurrentCount = New System.Windows.Forms.TextBox()
        Me.lblNewBalance = New System.Windows.Forms.Label()
        Me.rdRecount = New System.Windows.Forms.RadioButton()
        Me.rdAddCount = New System.Windows.Forms.RadioButton()
        Me.rdMinusCount = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtboxUnit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(272, 559)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 41)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtboxSupplyNo
        '
        Me.txtboxSupplyNo.AccessibleName = "Supplu Number"
        Me.txtboxSupplyNo.BackColor = System.Drawing.Color.White
        Me.txtboxSupplyNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxSupplyNo.Location = New System.Drawing.Point(47, 99)
        Me.txtboxSupplyNo.Name = "txtboxSupplyNo"
        Me.txtboxSupplyNo.ReadOnly = True
        Me.txtboxSupplyNo.Size = New System.Drawing.Size(240, 27)
        Me.txtboxSupplyNo.TabIndex = 2
        Me.txtboxSupplyNo.TabStop = False
        Me.txtboxSupplyNo.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(385, 559)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 41)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnInventoryHistory
        '
        Me.btnInventoryHistory.BackColor = System.Drawing.Color.Transparent
        Me.btnInventoryHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventoryHistory.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnInventoryHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnInventoryHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnInventoryHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventoryHistory.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnInventoryHistory.ForeColor = System.Drawing.Color.Black
        Me.btnInventoryHistory.Image = CType(resources.GetObject("btnInventoryHistory.Image"), System.Drawing.Image)
        Me.btnInventoryHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventoryHistory.Location = New System.Drawing.Point(362, 84)
        Me.btnInventoryHistory.Name = "btnInventoryHistory"
        Me.btnInventoryHistory.Size = New System.Drawing.Size(166, 39)
        Me.btnInventoryHistory.TabIndex = 1
        Me.btnInventoryHistory.Text = "Inventory History"
        Me.btnInventoryHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnInventoryHistory, "View inventory history")
        Me.btnInventoryHistory.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 22)
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
        Me.Label6.Location = New System.Drawing.Point(42, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 28)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Update Inventory"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 68)
        Me.Panel1.TabIndex = 56
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 50
        '
        'txtboxNewBalance
        '
        Me.txtboxNewBalance.AccessibleName = "New Balance"
        Me.txtboxNewBalance.BackColor = System.Drawing.Color.White
        Me.txtboxNewBalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxNewBalance.Location = New System.Drawing.Point(35, 313)
        Me.txtboxNewBalance.Name = "txtboxNewBalance"
        Me.txtboxNewBalance.Size = New System.Drawing.Size(445, 27)
        Me.txtboxNewBalance.TabIndex = 5
        Me.txtboxNewBalance.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(43, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 177
        Me.Label3.Text = "Supply Number"
        Me.Label3.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(31, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 20)
        Me.Label7.TabIndex = 181
        Me.Label7.Text = "Supply Name"
        '
        'txtboxSupplyName
        '
        Me.txtboxSupplyName.AccessibleName = "Supply Name"
        Me.txtboxSupplyName.BackColor = System.Drawing.Color.White
        Me.txtboxSupplyName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxSupplyName.Enabled = False
        Me.txtboxSupplyName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxSupplyName.ForeColor = System.Drawing.Color.Black
        Me.txtboxSupplyName.Location = New System.Drawing.Point(35, 73)
        Me.txtboxSupplyName.Name = "txtboxSupplyName"
        Me.txtboxSupplyName.ReadOnly = True
        Me.txtboxSupplyName.Size = New System.Drawing.Size(445, 25)
        Me.txtboxSupplyName.TabIndex = 3
        Me.txtboxSupplyName.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(31, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 20)
        Me.Label9.TabIndex = 197
        Me.Label9.Text = "Current Stock Count"
        '
        'txtboxCurrentCount
        '
        Me.txtboxCurrentCount.AccessibleName = "Current Count"
        Me.txtboxCurrentCount.BackColor = System.Drawing.Color.White
        Me.txtboxCurrentCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxCurrentCount.Enabled = False
        Me.txtboxCurrentCount.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxCurrentCount.ForeColor = System.Drawing.Color.Black
        Me.txtboxCurrentCount.Location = New System.Drawing.Point(35, 137)
        Me.txtboxCurrentCount.Name = "txtboxCurrentCount"
        Me.txtboxCurrentCount.ReadOnly = True
        Me.txtboxCurrentCount.Size = New System.Drawing.Size(108, 25)
        Me.txtboxCurrentCount.TabIndex = 4
        Me.txtboxCurrentCount.TabStop = False
        '
        'lblNewBalance
        '
        Me.lblNewBalance.AutoSize = True
        Me.lblNewBalance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNewBalance.ForeColor = System.Drawing.Color.Black
        Me.lblNewBalance.Location = New System.Drawing.Point(30, 290)
        Me.lblNewBalance.Name = "lblNewBalance"
        Me.lblNewBalance.Size = New System.Drawing.Size(95, 20)
        Me.lblNewBalance.TabIndex = 199
        Me.lblNewBalance.Text = "New Balance"
        Me.lblNewBalance.Visible = False
        '
        'rdRecount
        '
        Me.rdRecount.AutoSize = True
        Me.rdRecount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdRecount.ForeColor = System.Drawing.Color.Black
        Me.rdRecount.Location = New System.Drawing.Point(239, 246)
        Me.rdRecount.Name = "rdRecount"
        Me.rdRecount.Size = New System.Drawing.Size(150, 24)
        Me.rdRecount.TabIndex = 202
        Me.rdRecount.TabStop = True
        Me.rdRecount.Text = "New Stock Count"
        Me.rdRecount.UseVisualStyleBackColor = True
        '
        'rdAddCount
        '
        Me.rdAddCount.AutoSize = True
        Me.rdAddCount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdAddCount.ForeColor = System.Drawing.Color.Black
        Me.rdAddCount.Location = New System.Drawing.Point(133, 246)
        Me.rdAddCount.Name = "rdAddCount"
        Me.rdAddCount.Size = New System.Drawing.Size(59, 24)
        Me.rdAddCount.TabIndex = 202
        Me.rdAddCount.TabStop = True
        Me.rdAddCount.Text = "Add"
        Me.rdAddCount.UseVisualStyleBackColor = True
        '
        'rdMinusCount
        '
        Me.rdMinusCount.AutoSize = True
        Me.rdMinusCount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdMinusCount.ForeColor = System.Drawing.Color.Black
        Me.rdMinusCount.Location = New System.Drawing.Point(35, 246)
        Me.rdMinusCount.Name = "rdMinusCount"
        Me.rdMinusCount.Size = New System.Drawing.Size(60, 24)
        Me.rdMinusCount.TabIndex = 202
        Me.rdMinusCount.TabStop = True
        Me.rdMinusCount.Text = "Less"
        Me.rdMinusCount.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(31, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 23)
        Me.Label2.TabIndex = 203
        Me.Label2.Text = "New Inventory"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtboxUnit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rdMinusCount)
        Me.GroupBox1.Controls.Add(Me.rdAddCount)
        Me.GroupBox1.Controls.Add(Me.rdRecount)
        Me.GroupBox1.Controls.Add(Me.txtboxNewBalance)
        Me.GroupBox1.Controls.Add(Me.lblNewBalance)
        Me.GroupBox1.Controls.Add(Me.txtboxCurrentCount)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtboxSupplyName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 387)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        '
        'txtboxUnit
        '
        Me.txtboxUnit.AccessibleName = "Current Count"
        Me.txtboxUnit.BackColor = System.Drawing.Color.White
        Me.txtboxUnit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxUnit.Enabled = False
        Me.txtboxUnit.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxUnit.ForeColor = System.Drawing.Color.Black
        Me.txtboxUnit.Location = New System.Drawing.Point(181, 137)
        Me.txtboxUnit.Name = "txtboxUnit"
        Me.txtboxUnit.ReadOnly = True
        Me.txtboxUnit.Size = New System.Drawing.Size(108, 25)
        Me.txtboxUnit.TabIndex = 204
        Me.txtboxUnit.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(177, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 205
        Me.Label1.Text = "- Unit"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(35, 185)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(445, 10)
        Me.Panel3.TabIndex = 202
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, -3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(450, 10)
        Me.Panel4.TabIndex = 10
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'EditInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(540, 612)
        Me.Controls.Add(Me.btnInventoryHistory)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtboxSupplyNo)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents dtpickerDateCreated As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtboxSupplyNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtboxSupplyName As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtboxNexBalance As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtboxCurrentCount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnInventoryHistory As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnRecount As Button
    Friend WithEvents btnAddCount As Button
    Friend WithEvents btnMinusCount As Button
    Friend WithEvents lblNewBalance As Label
    Friend WithEvents rdMinusCount As RadioButton
    Friend WithEvents rdAddCount As RadioButton
    Friend WithEvents rdRecount As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxNewBalance As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents txtboxUnit As TextBox
    Friend WithEvents Label1 As Label
End Class
