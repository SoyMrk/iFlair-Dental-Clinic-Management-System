<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DentalChartFullScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DentalChartFullScreen))
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAddNewChart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExitFullScreen = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbboxDentalChart = New System.Windows.Forms.ComboBox()
        Me.picboxDentalChart = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel9.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picboxDentalChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel9.Controls.Add(Me.btnPrint)
        Me.Panel9.Controls.Add(Me.Panel1)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Controls.Add(Me.btnExitFullScreen)
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Controls.Add(Me.cmbboxDentalChart)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1942, 68)
        Me.Panel9.TabIndex = 230
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(1770, 19)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Size = New System.Drawing.Size(99, 30)
        Me.btnPrint.TabIndex = 2768
        Me.btnPrint.Text = "View PDF"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Print dental chart")
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAddNewChart)
        Me.Panel1.Location = New System.Drawing.Point(151, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(31, 31)
        Me.Panel1.TabIndex = 2767
        '
        'btnAddNewChart
        '
        Me.btnAddNewChart.BackColor = System.Drawing.Color.White
        Me.btnAddNewChart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewChart.FlatAppearance.BorderSize = 0
        Me.btnAddNewChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnAddNewChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAddNewChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewChart.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddNewChart.ForeColor = System.Drawing.Color.White
        Me.btnAddNewChart.Image = CType(resources.GetObject("btnAddNewChart.Image"), System.Drawing.Image)
        Me.btnAddNewChart.Location = New System.Drawing.Point(-13, -8)
        Me.btnAddNewChart.Name = "btnAddNewChart"
        Me.btnAddNewChart.Size = New System.Drawing.Size(56, 45)
        Me.btnAddNewChart.TabIndex = 203
        Me.ToolTip1.SetToolTip(Me.btnAddNewChart, "Add new dental chart")
        Me.btnAddNewChart.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1426, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 2766
        Me.Label1.Text = "Dental chart:"
        '
        'btnExitFullScreen
        '
        Me.btnExitFullScreen.BackColor = System.Drawing.Color.Transparent
        Me.btnExitFullScreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExitFullScreen.FlatAppearance.BorderSize = 0
        Me.btnExitFullScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnExitFullScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnExitFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitFullScreen.Image = CType(resources.GetObject("btnExitFullScreen.Image"), System.Drawing.Image)
        Me.btnExitFullScreen.Location = New System.Drawing.Point(1876, 19)
        Me.btnExitFullScreen.Name = "btnExitFullScreen"
        Me.btnExitFullScreen.Size = New System.Drawing.Size(32, 29)
        Me.btnExitFullScreen.TabIndex = 2765
        Me.ToolTip1.SetToolTip(Me.btnExitFullScreen, "Exit full screen")
        Me.btnExitFullScreen.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 25)
        Me.Label11.TabIndex = 202
        Me.Label11.Text = "Dental Record"
        '
        'cmbboxDentalChart
        '
        Me.cmbboxDentalChart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbboxDentalChart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxDentalChart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxDentalChart.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxDentalChart.FormattingEnabled = True
        Me.cmbboxDentalChart.Items.AddRange(New Object() {"Chart 1", "Chart 2"})
        Me.cmbboxDentalChart.Location = New System.Drawing.Point(1525, 20)
        Me.cmbboxDentalChart.Name = "cmbboxDentalChart"
        Me.cmbboxDentalChart.Size = New System.Drawing.Size(240, 28)
        Me.cmbboxDentalChart.TabIndex = 2763
        Me.ToolTip1.SetToolTip(Me.cmbboxDentalChart, "Select to view dental chart record")
        '
        'picboxDentalChart
        '
        Me.picboxDentalChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picboxDentalChart.Location = New System.Drawing.Point(0, 68)
        Me.picboxDentalChart.Name = "picboxDentalChart"
        Me.picboxDentalChart.Size = New System.Drawing.Size(1942, 993)
        Me.picboxDentalChart.TabIndex = 231
        Me.picboxDentalChart.TabStop = False
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
        'DentalChartFullScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1942, 1061)
        Me.Controls.Add(Me.picboxDentalChart)
        Me.Controls.Add(Me.Panel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DentalChartFullScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picboxDentalChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDentalChart As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnExitFullScreen As Button
    Friend WithEvents btnAddNewChart As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbboxDentalChart As ComboBox
    Friend WithEvents picboxDentalChart As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPrint As Button
End Class
