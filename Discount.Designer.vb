<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Discount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Discount))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbboxDiscount = New System.Windows.Forms.ComboBox()
        Me.txtboxPercent = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddDiscount = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEditDiscount = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.Panel1.TabIndex = 66
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 25)
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
        Me.Label6.Size = New System.Drawing.Size(278, 28)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Discounts for Dental Services"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbboxDiscount)
        Me.GroupBox1.Controls.Add(Me.txtboxPercent)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(15, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 221)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discount Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(24, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 20)
        Me.Label4.TabIndex = 229
        Me.Label4.Text = "Discount Name"
        '
        'cmbboxDiscount
        '
        Me.cmbboxDiscount.BackColor = System.Drawing.Color.White
        Me.cmbboxDiscount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxDiscount.ForeColor = System.Drawing.Color.Black
        Me.cmbboxDiscount.FormattingEnabled = True
        Me.cmbboxDiscount.Location = New System.Drawing.Point(28, 77)
        Me.cmbboxDiscount.Name = "cmbboxDiscount"
        Me.cmbboxDiscount.Size = New System.Drawing.Size(500, 28)
        Me.cmbboxDiscount.TabIndex = 2
        '
        'txtboxPercent
        '
        Me.txtboxPercent.AccessibleName = "Account SID"
        Me.txtboxPercent.BackColor = System.Drawing.Color.White
        Me.txtboxPercent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxPercent.Enabled = False
        Me.txtboxPercent.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxPercent.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtboxPercent.Location = New System.Drawing.Point(29, 143)
        Me.txtboxPercent.Name = "txtboxPercent"
        Me.txtboxPercent.ReadOnly = True
        Me.txtboxPercent.Size = New System.Drawing.Size(499, 36)
        Me.txtboxPercent.TabIndex = 4
        Me.txtboxPercent.TabStop = False
        Me.txtboxPercent.Text = "20%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 20)
        Me.Label3.TabIndex = 226
        Me.Label3.Text = "Discount in percent (%)"
        '
        'btnAddDiscount
        '
        Me.btnAddDiscount.BackColor = System.Drawing.Color.White
        Me.btnAddDiscount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddDiscount.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnAddDiscount.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnAddDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDiscount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddDiscount.ForeColor = System.Drawing.Color.Black
        Me.btnAddDiscount.Image = CType(resources.GetObject("btnAddDiscount.Image"), System.Drawing.Image)
        Me.btnAddDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddDiscount.Location = New System.Drawing.Point(436, 77)
        Me.btnAddDiscount.Name = "btnAddDiscount"
        Me.btnAddDiscount.Size = New System.Drawing.Size(136, 32)
        Me.btnAddDiscount.TabIndex = 1
        Me.btnAddDiscount.TabStop = False
        Me.btnAddDiscount.Text = "Add Discount"
        Me.btnAddDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnAddDiscount, "Add new discount")
        Me.btnAddDiscount.UseVisualStyleBackColor = False
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
        'btnEditDiscount
        '
        Me.btnEditDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEditDiscount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditDiscount.FlatAppearance.BorderSize = 0
        Me.btnEditDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditDiscount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEditDiscount.ForeColor = System.Drawing.Color.White
        Me.btnEditDiscount.Location = New System.Drawing.Point(275, 366)
        Me.btnEditDiscount.Name = "btnEditDiscount"
        Me.btnEditDiscount.Size = New System.Drawing.Size(155, 41)
        Me.btnEditDiscount.TabIndex = 5
        Me.btnEditDiscount.TabStop = False
        Me.btnEditDiscount.Text = "Update Discount"
        Me.btnEditDiscount.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(436, 366)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 41)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 419)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEditDiscount)
        Me.Controls.Add(Me.btnAddDiscount)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Discount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbboxDiscount As ComboBox
    Friend WithEvents txtboxPercent As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddDiscount As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnEditDiscount As Button
    Friend WithEvents btnCancel As Button
End Class
