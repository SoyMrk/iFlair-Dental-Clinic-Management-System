<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1885, 63)
        Me.Panel3.TabIndex = 242
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(3227, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(358, 27)
        Me.TextBox1.TabIndex = 19
        Me.TextBox1.Text = "  Search"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3198, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.PictureBox1.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1885, 1102)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents TopGrayPanel As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel38 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel39 As Panel
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel41 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel18 As Panel
    Friend WithEvents dtgridInventoryWarning As DataGridView
    Friend WithEvents SupplyName As DataGridViewTextBoxColumn
    Friend WithEvents RemainingStock As DataGridViewTextBoxColumn
    Friend WithEvents SupplyStatus As DataGridViewTextBoxColumn
    Friend WithEvents Panel24 As Panel
    Friend WithEvents btnInventory As Button
    Friend WithEvents Panel40 As Panel
    Friend WithEvents Panel29 As Panel
    Friend WithEvents Panel33 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents dtgridPatientTomorrow As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents dtgridPatientToday As DataGridView
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents StartTime As DataGridViewTextBoxColumn
    Friend WithEvents EndTime As DataGridViewTextBoxColumn
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chckboxToday As CheckBox
    Friend WithEvents cmbboxStatus As ComboBox
    Friend WithEvents chckboxWeek As CheckBox
    Friend WithEvents chckboxMonth As CheckBox
    Friend WithEvents cmbbocFilter As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents lblNoShow As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Panel36 As Panel
    Friend WithEvents Panel37 As Panel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents lblCompleted As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel30 As Panel
    Friend WithEvents Panel28 As Panel
    Friend WithEvents lblCancel As Label
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Panel35 As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents lblRevenueToday As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
