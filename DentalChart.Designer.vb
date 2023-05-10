<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DentalChart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DentalChart))
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFullscreen = New System.Windows.Forms.Button()
        Me.pnlAdd = New System.Windows.Forms.Panel()
        Me.btnAddNewChart = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbboxDentalChart = New System.Windows.Forms.ComboBox()
        Me.pnlDentalChart = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picboxDentalChart = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel9.SuspendLayout()
        Me.pnlAdd.SuspendLayout()
        Me.pnlDentalChart.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picboxDentalChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel9.Controls.Add(Me.btnPrint)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Controls.Add(Me.btnFullscreen)
        Me.Panel9.Controls.Add(Me.pnlAdd)
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Controls.Add(Me.cmbboxDentalChart)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1657, 68)
        Me.Panel9.TabIndex = 229
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(1485, 20)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Size = New System.Drawing.Size(99, 30)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "View PDF"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Print dental chart")
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1137, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 2767
        Me.Label1.Text = "Dental chart:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFullscreen
        '
        Me.btnFullscreen.BackColor = System.Drawing.Color.Transparent
        Me.btnFullscreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFullscreen.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnFullscreen.FlatAppearance.BorderSize = 0
        Me.btnFullscreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnFullscreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFullscreen.Image = CType(resources.GetObject("btnFullscreen.Image"), System.Drawing.Image)
        Me.btnFullscreen.Location = New System.Drawing.Point(1591, 19)
        Me.btnFullscreen.Name = "btnFullscreen"
        Me.btnFullscreen.Size = New System.Drawing.Size(32, 28)
        Me.btnFullscreen.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnFullscreen, "Enter full screen")
        Me.btnFullscreen.UseVisualStyleBackColor = False
        '
        'pnlAdd
        '
        Me.pnlAdd.Controls.Add(Me.btnAddNewChart)
        Me.pnlAdd.Location = New System.Drawing.Point(151, 19)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.Size = New System.Drawing.Size(31, 31)
        Me.pnlAdd.TabIndex = 2765
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
        Me.btnAddNewChart.Location = New System.Drawing.Point(-8, -4)
        Me.btnAddNewChart.Name = "btnAddNewChart"
        Me.btnAddNewChart.Size = New System.Drawing.Size(45, 38)
        Me.btnAddNewChart.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnAddNewChart, "Add new dental chart")
        Me.btnAddNewChart.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 25)
        Me.Label11.TabIndex = 202
        Me.Label11.Text = "Dental Record"
        '
        'cmbboxDentalChart
        '
        Me.cmbboxDentalChart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbboxDentalChart.BackColor = System.Drawing.Color.White
        Me.cmbboxDentalChart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxDentalChart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxDentalChart.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxDentalChart.ForeColor = System.Drawing.Color.Black
        Me.cmbboxDentalChart.FormattingEnabled = True
        Me.cmbboxDentalChart.Items.AddRange(New Object() {"Chart 1", "Chart 2"})
        Me.cmbboxDentalChart.Location = New System.Drawing.Point(1239, 21)
        Me.cmbboxDentalChart.Name = "cmbboxDentalChart"
        Me.cmbboxDentalChart.Size = New System.Drawing.Size(240, 28)
        Me.cmbboxDentalChart.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cmbboxDentalChart, "Select to view dental chart record")
        '
        'pnlDentalChart
        '
        Me.pnlDentalChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDentalChart.Controls.Add(Me.Panel1)
        Me.pnlDentalChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDentalChart.Location = New System.Drawing.Point(0, 68)
        Me.pnlDentalChart.Name = "pnlDentalChart"
        Me.pnlDentalChart.Size = New System.Drawing.Size(1657, 683)
        Me.pnlDentalChart.TabIndex = 230
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.picboxDentalChart)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1655, 684)
        Me.Panel1.TabIndex = 2757
        '
        'picboxDentalChart
        '
        Me.picboxDentalChart.BackColor = System.Drawing.Color.White
        Me.picboxDentalChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picboxDentalChart.Location = New System.Drawing.Point(0, 0)
        Me.picboxDentalChart.Name = "picboxDentalChart"
        Me.picboxDentalChart.Size = New System.Drawing.Size(1655, 684)
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
        'DentalChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1657, 751)
        Me.Controls.Add(Me.pnlDentalChart)
        Me.Controls.Add(Me.Panel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DentalChart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dental Chart"
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.pnlAdd.ResumeLayout(False)
        Me.pnlDentalChart.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.picboxDentalChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents pnlDentalChart As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox236 As PictureBox
    Friend WithEvents PictureBox237 As PictureBox
    Friend WithEvents PictureBox238 As PictureBox
    Friend WithEvents PictureBox239 As PictureBox
    Friend WithEvents PictureBox240 As PictureBox
    Friend WithEvents PictureBox241 As PictureBox
    Friend WithEvents PictureBox242 As PictureBox
    Friend WithEvents PictureBox243 As PictureBox
    Friend WithEvents PictureBox244 As PictureBox
    Friend WithEvents PictureBox245 As PictureBox
    Friend WithEvents PictureBox246 As PictureBox
    Friend WithEvents PictureBox247 As PictureBox
    Friend WithEvents PictureBox248 As PictureBox
    Friend WithEvents PictureBox249 As PictureBox
    Friend WithEvents PictureBox250 As PictureBox
    Friend WithEvents PictureBox251 As PictureBox
    Friend WithEvents PictureBox252 As PictureBox
    Friend WithEvents PictureBox253 As PictureBox
    Friend WithEvents PictureBox254 As PictureBox
    Friend WithEvents PictureBox255 As PictureBox
    Friend WithEvents PictureBox256 As PictureBox
    Friend WithEvents PictureBox257 As PictureBox
    Friend WithEvents PictureBox258 As PictureBox
    Friend WithEvents PictureBox259 As PictureBox
    Friend WithEvents PictureBox260 As PictureBox
    Friend WithEvents PictureBox51 As PictureBox
    Friend WithEvents PictureBox52 As PictureBox
    Friend WithEvents PictureBox53 As PictureBox
    Friend WithEvents PictureBox54 As PictureBox
    Friend WithEvents PictureBox55 As PictureBox
    Friend WithEvents PictureBox56 As PictureBox
    Friend WithEvents PictureBox57 As PictureBox
    Friend WithEvents PictureBox58 As PictureBox
    Friend WithEvents PictureBox59 As PictureBox
    Friend WithEvents PictureBox60 As PictureBox
    Friend WithEvents PictureBox61 As PictureBox
    Friend WithEvents PictureBox62 As PictureBox
    Friend WithEvents PictureBox63 As PictureBox
    Friend WithEvents PictureBox64 As PictureBox
    Friend WithEvents PictureBox65 As PictureBox
    Friend WithEvents PictureBox86 As PictureBox
    Friend WithEvents PictureBox87 As PictureBox
    Friend WithEvents PictureBox88 As PictureBox
    Friend WithEvents PictureBox89 As PictureBox
    Friend WithEvents PictureBox90 As PictureBox
    Friend WithEvents PictureBox66 As PictureBox
    Friend WithEvents PictureBox67 As PictureBox
    Friend WithEvents PictureBox68 As PictureBox
    Friend WithEvents PictureBox69 As PictureBox
    Friend WithEvents PictureBox70 As PictureBox
    Friend WithEvents PictureBox71 As PictureBox
    Friend WithEvents PictureBox72 As PictureBox
    Friend WithEvents PictureBox73 As PictureBox
    Friend WithEvents PictureBox74 As PictureBox
    Friend WithEvents PictureBox75 As PictureBox
    Friend WithEvents PictureBox76 As PictureBox
    Friend WithEvents PictureBox77 As PictureBox
    Friend WithEvents PictureBox78 As PictureBox
    Friend WithEvents PictureBox79 As PictureBox
    Friend WithEvents PictureBox80 As PictureBox
    Friend WithEvents PictureBox81 As PictureBox
    Friend WithEvents PictureBox82 As PictureBox
    Friend WithEvents PictureBox83 As PictureBox
    Friend WithEvents PictureBox84 As PictureBox
    Friend WithEvents PictureBox85 As PictureBox
    Friend WithEvents PictureBox196 As PictureBox
    Friend WithEvents PictureBox197 As PictureBox
    Friend WithEvents PictureBox198 As PictureBox
    Friend WithEvents PictureBox199 As PictureBox
    Friend WithEvents PictureBox200 As PictureBox
    Friend WithEvents PictureBox201 As PictureBox
    Friend WithEvents PictureBox202 As PictureBox
    Friend WithEvents PictureBox203 As PictureBox
    Friend WithEvents PictureBox204 As PictureBox
    Friend WithEvents PictureBox205 As PictureBox
    Friend WithEvents PictureBox206 As PictureBox
    Friend WithEvents PictureBox207 As PictureBox
    Friend WithEvents PictureBox208 As PictureBox
    Friend WithEvents PictureBox209 As PictureBox
    Friend WithEvents PictureBox210 As PictureBox
    Friend WithEvents PictureBox211 As PictureBox
    Friend WithEvents PictureBox212 As PictureBox
    Friend WithEvents PictureBox213 As PictureBox
    Friend WithEvents PictureBox214 As PictureBox
    Friend WithEvents PictureBox215 As PictureBox
    Friend WithEvents PictureBox216 As PictureBox
    Friend WithEvents PictureBox217 As PictureBox
    Friend WithEvents PictureBox218 As PictureBox
    Friend WithEvents PictureBox219 As PictureBox
    Friend WithEvents PictureBox220 As PictureBox
    Friend WithEvents PictureBox221 As PictureBox
    Friend WithEvents PictureBox222 As PictureBox
    Friend WithEvents PictureBox223 As PictureBox
    Friend WithEvents PictureBox224 As PictureBox
    Friend WithEvents PictureBox225 As PictureBox
    Friend WithEvents PictureBox226 As PictureBox
    Friend WithEvents PictureBox227 As PictureBox
    Friend WithEvents PictureBox228 As PictureBox
    Friend WithEvents PictureBox229 As PictureBox
    Friend WithEvents PictureBox230 As PictureBox
    Friend WithEvents PictureBox231 As PictureBox
    Friend WithEvents PictureBox232 As PictureBox
    Friend WithEvents PictureBox233 As PictureBox
    Friend WithEvents PictureBox234 As PictureBox
    Friend WithEvents PictureBox235 As PictureBox
    Friend WithEvents PictureBox156 As PictureBox
    Friend WithEvents PictureBox157 As PictureBox
    Friend WithEvents PictureBox158 As PictureBox
    Friend WithEvents PictureBox159 As PictureBox
    Friend WithEvents PictureBox160 As PictureBox
    Friend WithEvents PictureBox161 As PictureBox
    Friend WithEvents PictureBox162 As PictureBox
    Friend WithEvents PictureBox163 As PictureBox
    Friend WithEvents PictureBox164 As PictureBox
    Friend WithEvents PictureBox165 As PictureBox
    Friend WithEvents PictureBox166 As PictureBox
    Friend WithEvents PictureBox167 As PictureBox
    Friend WithEvents PictureBox168 As PictureBox
    Friend WithEvents PictureBox169 As PictureBox
    Friend WithEvents PictureBox170 As PictureBox
    Friend WithEvents PictureBox171 As PictureBox
    Friend WithEvents PictureBox172 As PictureBox
    Friend WithEvents PictureBox173 As PictureBox
    Friend WithEvents PictureBox174 As PictureBox
    Friend WithEvents PictureBox175 As PictureBox
    Friend WithEvents PictureBox176 As PictureBox
    Friend WithEvents PictureBox177 As PictureBox
    Friend WithEvents PictureBox178 As PictureBox
    Friend WithEvents PictureBox179 As PictureBox
    Friend WithEvents PictureBox180 As PictureBox
    Friend WithEvents PictureBox181 As PictureBox
    Friend WithEvents PictureBox182 As PictureBox
    Friend WithEvents PictureBox183 As PictureBox
    Friend WithEvents PictureBox184 As PictureBox
    Friend WithEvents PictureBox185 As PictureBox
    Friend WithEvents PictureBox186 As PictureBox
    Friend WithEvents PictureBox187 As PictureBox
    Friend WithEvents PictureBox188 As PictureBox
    Friend WithEvents PictureBox189 As PictureBox
    Friend WithEvents PictureBox190 As PictureBox
    Friend WithEvents PictureBox191 As PictureBox
    Friend WithEvents PictureBox192 As PictureBox
    Friend WithEvents PictureBox193 As PictureBox
    Friend WithEvents PictureBox194 As PictureBox
    Friend WithEvents PictureBox195 As PictureBox
    Friend WithEvents PictureBox111 As PictureBox
    Friend WithEvents PictureBox112 As PictureBox
    Friend WithEvents PictureBox113 As PictureBox
    Friend WithEvents PictureBox114 As PictureBox
    Friend WithEvents PictureBox115 As PictureBox
    Friend WithEvents PictureBox116 As PictureBox
    Friend WithEvents PictureBox117 As PictureBox
    Friend WithEvents PictureBox118 As PictureBox
    Friend WithEvents PictureBox119 As PictureBox
    Friend WithEvents PictureBox120 As PictureBox
    Friend WithEvents PictureBox121 As PictureBox
    Friend WithEvents PictureBox122 As PictureBox
    Friend WithEvents PictureBox123 As PictureBox
    Friend WithEvents PictureBox124 As PictureBox
    Friend WithEvents PictureBox125 As PictureBox
    Friend WithEvents PictureBox91 As PictureBox
    Friend WithEvents PictureBox92 As PictureBox
    Friend WithEvents PictureBox93 As PictureBox
    Friend WithEvents PictureBox94 As PictureBox
    Friend WithEvents PictureBox95 As PictureBox
    Friend WithEvents PictureBox96 As PictureBox
    Friend WithEvents PictureBox97 As PictureBox
    Friend WithEvents PictureBox98 As PictureBox
    Friend WithEvents PictureBox99 As PictureBox
    Friend WithEvents PictureBox100 As PictureBox
    Friend WithEvents PictureBox101 As PictureBox
    Friend WithEvents PictureBox102 As PictureBox
    Friend WithEvents PictureBox103 As PictureBox
    Friend WithEvents PictureBox104 As PictureBox
    Friend WithEvents PictureBox105 As PictureBox
    Friend WithEvents PictureBox106 As PictureBox
    Friend WithEvents PictureBox107 As PictureBox
    Friend WithEvents PictureBox108 As PictureBox
    Friend WithEvents PictureBox109 As PictureBox
    Friend WithEvents PictureBox110 As PictureBox
    Friend WithEvents PictureBox126 As PictureBox
    Friend WithEvents PictureBox127 As PictureBox
    Friend WithEvents PictureBox128 As PictureBox
    Friend WithEvents PictureBox129 As PictureBox
    Friend WithEvents PictureBox130 As PictureBox
    Friend WithEvents PictureBox131 As PictureBox
    Friend WithEvents PictureBox132 As PictureBox
    Friend WithEvents PictureBox133 As PictureBox
    Friend WithEvents PictureBox134 As PictureBox
    Friend WithEvents PictureBox135 As PictureBox
    Friend WithEvents PictureBox136 As PictureBox
    Friend WithEvents PictureBox137 As PictureBox
    Friend WithEvents PictureBox138 As PictureBox
    Friend WithEvents PictureBox139 As PictureBox
    Friend WithEvents PictureBox140 As PictureBox
    Friend WithEvents PictureBox141 As PictureBox
    Friend WithEvents PictureBox142 As PictureBox
    Friend WithEvents PictureBox143 As PictureBox
    Friend WithEvents PictureBox144 As PictureBox
    Friend WithEvents PictureBox145 As PictureBox
    Friend WithEvents PictureBox146 As PictureBox
    Friend WithEvents PictureBox147 As PictureBox
    Friend WithEvents PictureBox148 As PictureBox
    Friend WithEvents PictureBox149 As PictureBox
    Friend WithEvents PictureBox150 As PictureBox
    Friend WithEvents PictureBox151 As PictureBox
    Friend WithEvents PictureBox152 As PictureBox
    Friend WithEvents PictureBox153 As PictureBox
    Friend WithEvents PictureBox154 As PictureBox
    Friend WithEvents PictureBox155 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents PictureBox26 As PictureBox
    Friend WithEvents PictureBox36 As PictureBox
    Friend WithEvents PictureBox37 As PictureBox
    Friend WithEvents PictureBox38 As PictureBox
    Friend WithEvents PictureBox39 As PictureBox
    Friend WithEvents PictureBox40 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents PictureBox21 As PictureBox
    Friend WithEvents PictureBox22 As PictureBox
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents PictureBox24 As PictureBox
    Friend WithEvents PictureBox25 As PictureBox
    Friend WithEvents PictureBox27 As PictureBox
    Friend WithEvents PictureBox28 As PictureBox
    Friend WithEvents PictureBox29 As PictureBox
    Friend WithEvents PictureBox30 As PictureBox
    Friend WithEvents PictureBox31 As PictureBox
    Friend WithEvents PictureBox32 As PictureBox
    Friend WithEvents PictureBox33 As PictureBox
    Friend WithEvents PictureBox34 As PictureBox
    Friend WithEvents PictureBox35 As PictureBox
    Friend WithEvents PictureBox41 As PictureBox
    Friend WithEvents PictureBox42 As PictureBox
    Friend WithEvents PictureBox43 As PictureBox
    Friend WithEvents PictureBox44 As PictureBox
    Friend WithEvents PictureBox45 As PictureBox
    Friend WithEvents PictureBox46 As PictureBox
    Friend WithEvents PictureBox47 As PictureBox
    Friend WithEvents PictureBox48 As PictureBox
    Friend WithEvents PictureBox49 As PictureBox
    Friend WithEvents PictureBox50 As PictureBox
    Friend WithEvents ComboBox95 As ComboBox
    Friend WithEvents ComboBox96 As ComboBox
    Friend WithEvents ComboBox97 As ComboBox
    Friend WithEvents ComboBox98 As ComboBox
    Friend WithEvents ComboBox99 As ComboBox
    Friend WithEvents ComboBox100 As ComboBox
    Friend WithEvents ComboBox101 As ComboBox
    Friend WithEvents ComboBox102 As ComboBox
    Friend WithEvents ComboBox103 As ComboBox
    Friend WithEvents ComboBox104 As ComboBox
    Friend WithEvents ComboBox79 As ComboBox
    Friend WithEvents ComboBox80 As ComboBox
    Friend WithEvents ComboBox81 As ComboBox
    Friend WithEvents ComboBox82 As ComboBox
    Friend WithEvents ComboBox83 As ComboBox
    Friend WithEvents ComboBox84 As ComboBox
    Friend WithEvents ComboBox85 As ComboBox
    Friend WithEvents ComboBox86 As ComboBox
    Friend WithEvents ComboBox87 As ComboBox
    Friend WithEvents ComboBox88 As ComboBox
    Friend WithEvents ComboBox89 As ComboBox
    Friend WithEvents ComboBox90 As ComboBox
    Friend WithEvents ComboBox91 As ComboBox
    Friend WithEvents ComboBox92 As ComboBox
    Friend WithEvents ComboBox93 As ComboBox
    Friend WithEvents ComboBox94 As ComboBox
    Friend WithEvents ComboBox63 As ComboBox
    Friend WithEvents ComboBox64 As ComboBox
    Friend WithEvents ComboBox65 As ComboBox
    Friend WithEvents ComboBox66 As ComboBox
    Friend WithEvents ComboBox67 As ComboBox
    Friend WithEvents ComboBox68 As ComboBox
    Friend WithEvents ComboBox69 As ComboBox
    Friend WithEvents ComboBox70 As ComboBox
    Friend WithEvents ComboBox71 As ComboBox
    Friend WithEvents ComboBox72 As ComboBox
    Friend WithEvents ComboBox73 As ComboBox
    Friend WithEvents ComboBox74 As ComboBox
    Friend WithEvents ComboBox75 As ComboBox
    Friend WithEvents ComboBox76 As ComboBox
    Friend WithEvents ComboBox77 As ComboBox
    Friend WithEvents ComboBox78 As ComboBox
    Friend WithEvents ComboBox53 As ComboBox
    Friend WithEvents ComboBox54 As ComboBox
    Friend WithEvents ComboBox55 As ComboBox
    Friend WithEvents ComboBox56 As ComboBox
    Friend WithEvents ComboBox57 As ComboBox
    Friend WithEvents ComboBox58 As ComboBox
    Friend WithEvents ComboBox59 As ComboBox
    Friend WithEvents ComboBox60 As ComboBox
    Friend WithEvents ComboBox61 As ComboBox
    Friend WithEvents ComboBox62 As ComboBox
    Friend WithEvents ComboBox43 As ComboBox
    Friend WithEvents ComboBox33 As ComboBox
    Friend WithEvents ComboBox44 As ComboBox
    Friend WithEvents ComboBox45 As ComboBox
    Friend WithEvents ComboBox34 As ComboBox
    Friend WithEvents ComboBox46 As ComboBox
    Friend WithEvents ComboBox35 As ComboBox
    Friend WithEvents ComboBox47 As ComboBox
    Friend WithEvents ComboBox36 As ComboBox
    Friend WithEvents ComboBox48 As ComboBox
    Friend WithEvents ComboBox37 As ComboBox
    Friend WithEvents ComboBox49 As ComboBox
    Friend WithEvents ComboBox38 As ComboBox
    Friend WithEvents ComboBox50 As ComboBox
    Friend WithEvents ComboBox39 As ComboBox
    Friend WithEvents ComboBox51 As ComboBox
    Friend WithEvents ComboBox40 As ComboBox
    Friend WithEvents ComboBox52 As ComboBox
    Friend WithEvents ComboBox41 As ComboBox
    Friend WithEvents ComboBox42 As ComboBox
    Friend WithEvents ComboBox17 As ComboBox
    Friend WithEvents ComboBox18 As ComboBox
    Friend WithEvents ComboBox19 As ComboBox
    Friend WithEvents ComboBox20 As ComboBox
    Friend WithEvents ComboBox21 As ComboBox
    Friend WithEvents ComboBox22 As ComboBox
    Friend WithEvents ComboBox23 As ComboBox
    Friend WithEvents ComboBox24 As ComboBox
    Friend WithEvents ComboBox25 As ComboBox
    Friend WithEvents ComboBox26 As ComboBox
    Friend WithEvents ComboBox27 As ComboBox
    Friend WithEvents ComboBox28 As ComboBox
    Friend WithEvents ComboBox29 As ComboBox
    Friend WithEvents ComboBox30 As ComboBox
    Friend WithEvents ComboBox31 As ComboBox
    Friend WithEvents ComboBox32 As ComboBox
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents ComboBox10 As ComboBox
    Friend WithEvents ComboBox11 As ComboBox
    Friend WithEvents ComboBox12 As ComboBox
    Friend WithEvents ComboBox13 As ComboBox
    Friend WithEvents ComboBox14 As ComboBox
    Friend WithEvents ComboBox15 As ComboBox
    Friend WithEvents ComboBox16 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cmbboxDentalChart As ComboBox
    Friend WithEvents picboxDentalChart As PictureBox
    Friend WithEvents btnAddNewChart As Button
    Friend WithEvents btnFullscreen As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pnlAdd As Panel
    Friend WithEvents pnlFullScreen As Panel
    Friend WithEvents btnPrint As Button
End Class
