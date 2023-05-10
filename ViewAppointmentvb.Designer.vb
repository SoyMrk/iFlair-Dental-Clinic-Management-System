<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAppointmentvb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewAppointmentvb))
        Me.TopGrayPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEditAppointment = New System.Windows.Forms.Button()
        Me.btnToPatientProfile = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ListboxProcedure = New System.Windows.Forms.ListBox()
        Me.txtboxDentist = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxPatientName = New System.Windows.Forms.TextBox()
        Me.txtboxEndTime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxStartTime = New System.Windows.Forms.TextBox()
        Me.lblAppointmentStatus = New System.Windows.Forms.Label()
        Me.txtboxAppointmentStatus = New System.Windows.Forms.TextBox()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.txtboxAppointmentDate = New System.Windows.Forms.TextBox()
        Me.txtboxDuration = New System.Windows.Forms.TextBox()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopGrayPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopGrayPanel
        '
        Me.TopGrayPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TopGrayPanel.Controls.Add(Me.PictureBox1)
        Me.TopGrayPanel.Controls.Add(Me.Label1)
        Me.TopGrayPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopGrayPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopGrayPanel.Name = "TopGrayPanel"
        Me.TopGrayPanel.Size = New System.Drawing.Size(526, 68)
        Me.TopGrayPanel.TabIndex = 208
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(40, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 28)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Appointment Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnEditAppointment)
        Me.Panel1.Controls.Add(Me.btnToPatientProfile)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 779)
        Me.Panel1.TabIndex = 209
        '
        'btnEditAppointment
        '
        Me.btnEditAppointment.BackColor = System.Drawing.Color.ForestGreen
        Me.btnEditAppointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditAppointment.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEditAppointment.ForeColor = System.Drawing.Color.White
        Me.btnEditAppointment.Image = CType(resources.GetObject("btnEditAppointment.Image"), System.Drawing.Image)
        Me.btnEditAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditAppointment.Location = New System.Drawing.Point(444, 14)
        Me.btnEditAppointment.Name = "btnEditAppointment"
        Me.btnEditAppointment.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnEditAppointment.Size = New System.Drawing.Size(70, 32)
        Me.btnEditAppointment.TabIndex = 1
        Me.btnEditAppointment.Text = "   Edit"
        Me.btnEditAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnEditAppointment, "Update appointment")
        Me.btnEditAppointment.UseVisualStyleBackColor = False
        Me.btnEditAppointment.Visible = False
        '
        'btnToPatientProfile
        '
        Me.btnToPatientProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnToPatientProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToPatientProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnToPatientProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToPatientProfile.ForeColor = System.Drawing.Color.White
        Me.btnToPatientProfile.Location = New System.Drawing.Point(147, 726)
        Me.btnToPatientProfile.Name = "btnToPatientProfile"
        Me.btnToPatientProfile.Size = New System.Drawing.Size(212, 41)
        Me.btnToPatientProfile.TabIndex = 2
        Me.btnToPatientProfile.Text = "Proceed To Patient Profile"
        Me.btnToPatientProfile.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(365, 726)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(107, 41)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.ListboxProcedure)
        Me.GroupBox1.Controls.Add(Me.txtboxDentist)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtboxPatientName)
        Me.GroupBox1.Controls.Add(Me.txtboxEndTime)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtboxStartTime)
        Me.GroupBox1.Controls.Add(Me.lblAppointmentStatus)
        Me.GroupBox1.Controls.Add(Me.txtboxAppointmentStatus)
        Me.GroupBox1.Controls.Add(Me.lblDuration)
        Me.GroupBox1.Controls.Add(Me.txtboxAppointmentDate)
        Me.GroupBox1.Controls.Add(Me.txtboxDuration)
        Me.GroupBox1.Controls.Add(Me.lblEndTime)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblStartTime)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 623)
        Me.GroupBox1.TabIndex = 345
        Me.GroupBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(245, 394)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 53)
        Me.Panel4.TabIndex = 478
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Location = New System.Drawing.Point(242, 394)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 53)
        Me.Panel3.TabIndex = 477
        '
        'ListboxProcedure
        '
        Me.ListboxProcedure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListboxProcedure.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListboxProcedure.ForeColor = System.Drawing.Color.Black
        Me.ListboxProcedure.FormattingEnabled = True
        Me.ListboxProcedure.ItemHeight = 23
        Me.ListboxProcedure.Location = New System.Drawing.Point(42, 210)
        Me.ListboxProcedure.Name = "ListboxProcedure"
        Me.ListboxProcedure.Size = New System.Drawing.Size(418, 94)
        Me.ListboxProcedure.TabIndex = 471
        Me.ListboxProcedure.TabStop = False
        '
        'txtboxDentist
        '
        Me.txtboxDentist.BackColor = System.Drawing.Color.White
        Me.txtboxDentist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxDentist.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxDentist.ForeColor = System.Drawing.Color.Black
        Me.txtboxDentist.Location = New System.Drawing.Point(42, 546)
        Me.txtboxDentist.Name = "txtboxDentist"
        Me.txtboxDentist.ReadOnly = True
        Me.txtboxDentist.Size = New System.Drawing.Size(418, 30)
        Me.txtboxDentist.TabIndex = 475
        Me.txtboxDentist.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(38, 523)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 473
        Me.Label5.Text = "Dentist Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(38, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 472
        Me.Label3.Text = "Procedure/s"
        '
        'txtboxPatientName
        '
        Me.txtboxPatientName.BackColor = System.Drawing.Color.White
        Me.txtboxPatientName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxPatientName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxPatientName.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtboxPatientName.Location = New System.Drawing.Point(42, 78)
        Me.txtboxPatientName.Name = "txtboxPatientName"
        Me.txtboxPatientName.ReadOnly = True
        Me.txtboxPatientName.Size = New System.Drawing.Size(418, 27)
        Me.txtboxPatientName.TabIndex = 1
        Me.txtboxPatientName.TabStop = False
        '
        'txtboxEndTime
        '
        Me.txtboxEndTime.BackColor = System.Drawing.Color.White
        Me.txtboxEndTime.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxEndTime.ForeColor = System.Drawing.Color.Black
        Me.txtboxEndTime.Location = New System.Drawing.Point(262, 417)
        Me.txtboxEndTime.Name = "txtboxEndTime"
        Me.txtboxEndTime.ReadOnly = True
        Me.txtboxEndTime.Size = New System.Drawing.Size(198, 30)
        Me.txtboxEndTime.TabIndex = 344
        Me.txtboxEndTime.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(38, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 327
        Me.Label2.Text = "Appointment Date"
        '
        'txtboxStartTime
        '
        Me.txtboxStartTime.BackColor = System.Drawing.Color.White
        Me.txtboxStartTime.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxStartTime.ForeColor = System.Drawing.Color.Black
        Me.txtboxStartTime.Location = New System.Drawing.Point(42, 417)
        Me.txtboxStartTime.Name = "txtboxStartTime"
        Me.txtboxStartTime.ReadOnly = True
        Me.txtboxStartTime.Size = New System.Drawing.Size(186, 30)
        Me.txtboxStartTime.TabIndex = 343
        Me.txtboxStartTime.TabStop = False
        '
        'lblAppointmentStatus
        '
        Me.lblAppointmentStatus.AutoSize = True
        Me.lblAppointmentStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAppointmentStatus.ForeColor = System.Drawing.Color.Black
        Me.lblAppointmentStatus.Location = New System.Drawing.Point(38, 329)
        Me.lblAppointmentStatus.Name = "lblAppointmentStatus"
        Me.lblAppointmentStatus.Size = New System.Drawing.Size(141, 20)
        Me.lblAppointmentStatus.TabIndex = 330
        Me.lblAppointmentStatus.Text = "Appointment Status"
        '
        'txtboxAppointmentStatus
        '
        Me.txtboxAppointmentStatus.BackColor = System.Drawing.Color.White
        Me.txtboxAppointmentStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxAppointmentStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxAppointmentStatus.ForeColor = System.Drawing.Color.Black
        Me.txtboxAppointmentStatus.Location = New System.Drawing.Point(42, 351)
        Me.txtboxAppointmentStatus.Name = "txtboxAppointmentStatus"
        Me.txtboxAppointmentStatus.ReadOnly = True
        Me.txtboxAppointmentStatus.Size = New System.Drawing.Size(418, 30)
        Me.txtboxAppointmentStatus.TabIndex = 342
        Me.txtboxAppointmentStatus.TabStop = False
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDuration.ForeColor = System.Drawing.Color.Black
        Me.lblDuration.Location = New System.Drawing.Point(38, 459)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(67, 20)
        Me.lblDuration.TabIndex = 336
        Me.lblDuration.Text = "Duration"
        '
        'txtboxAppointmentDate
        '
        Me.txtboxAppointmentDate.BackColor = System.Drawing.Color.White
        Me.txtboxAppointmentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxAppointmentDate.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxAppointmentDate.ForeColor = System.Drawing.Color.Black
        Me.txtboxAppointmentDate.Location = New System.Drawing.Point(42, 142)
        Me.txtboxAppointmentDate.Name = "txtboxAppointmentDate"
        Me.txtboxAppointmentDate.ReadOnly = True
        Me.txtboxAppointmentDate.Size = New System.Drawing.Size(418, 30)
        Me.txtboxAppointmentDate.TabIndex = 341
        Me.txtboxAppointmentDate.TabStop = False
        '
        'txtboxDuration
        '
        Me.txtboxDuration.BackColor = System.Drawing.Color.White
        Me.txtboxDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxDuration.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxDuration.ForeColor = System.Drawing.Color.Black
        Me.txtboxDuration.Location = New System.Drawing.Point(42, 481)
        Me.txtboxDuration.Name = "txtboxDuration"
        Me.txtboxDuration.ReadOnly = True
        Me.txtboxDuration.Size = New System.Drawing.Size(418, 30)
        Me.txtboxDuration.TabIndex = 333
        Me.txtboxDuration.TabStop = False
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEndTime.ForeColor = System.Drawing.Color.Black
        Me.lblEndTime.Location = New System.Drawing.Point(258, 394)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(71, 20)
        Me.lblEndTime.TabIndex = 335
        Me.lblEndTime.Text = "End Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(38, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 339
        Me.Label6.Text = "Patient Name"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStartTime.ForeColor = System.Drawing.Color.Black
        Me.lblStartTime.Location = New System.Drawing.Point(38, 394)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(77, 20)
        Me.lblStartTime.TabIndex = 334
        Me.lblStartTime.Text = "Start Time"
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
        'ViewAppointmentvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(526, 847)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TopGrayPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewAppointmentvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.TopGrayPanel.ResumeLayout(False)
        Me.TopGrayPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopGrayPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtboxPatientName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblStartTime As Label
    Friend WithEvents lblEndTime As Label
    Friend WithEvents txtboxDuration As TextBox
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblAppointmentStatus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxEndTime As TextBox
    Friend WithEvents txtboxStartTime As TextBox
    Friend WithEvents txtboxAppointmentStatus As TextBox
    Friend WithEvents txtboxAppointmentDate As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnViewPatientProfile As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ListboxProcedure As ListBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnToPatientProfile As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtboxDentist As TextBox
    Friend WithEvents btnEditAppointment As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
