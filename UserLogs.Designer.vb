<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserLogs))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TopGrayPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpickerFilter = New System.Windows.Forms.DateTimePicker()
        Me.btnResetFilter = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtboxSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.UserLogID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataviewUserLogs = New System.Windows.Forms.DataGridView()
        Me.UserLog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogAccountType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogDateTimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogDateTimeOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopGrayPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataviewUserLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopGrayPanel
        '
        Me.TopGrayPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TopGrayPanel.Controls.Add(Me.Label1)
        Me.TopGrayPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopGrayPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopGrayPanel.Name = "TopGrayPanel"
        Me.TopGrayPanel.Size = New System.Drawing.Size(1924, 63)
        Me.TopGrayPanel.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 28)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "User Log Information"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(13, 1064)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1898, 13)
        Me.Panel4.TabIndex = 39
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1911, 125)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 952)
        Me.Panel3.TabIndex = 38
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 952)
        Me.Panel2.TabIndex = 37
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtpickerFilter)
        Me.Panel1.Controls.Add(Me.btnResetFilter)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1924, 62)
        Me.Panel1.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1676, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 213
        Me.Label2.Text = "Filter by:"
        '
        'dtpickerFilter
        '
        Me.dtpickerFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpickerFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpickerFilter.CustomFormat = "yyyy-MM-dd"
        Me.dtpickerFilter.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpickerFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpickerFilter.Location = New System.Drawing.Point(1747, 17)
        Me.dtpickerFilter.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpickerFilter.Name = "dtpickerFilter"
        Me.dtpickerFilter.Size = New System.Drawing.Size(133, 27)
        Me.dtpickerFilter.TabIndex = 26
        Me.dtpickerFilter.TabStop = False
        Me.ToolTip1.SetToolTip(Me.dtpickerFilter, "Use this to filter userlogs by date time in and out")
        '
        'btnResetFilter
        '
        Me.btnResetFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResetFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnResetFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetFilter.Image = CType(resources.GetObject("btnResetFilter.Image"), System.Drawing.Image)
        Me.btnResetFilter.Location = New System.Drawing.Point(1877, 17)
        Me.btnResetFilter.Name = "btnResetFilter"
        Me.btnResetFilter.Padding = New System.Windows.Forms.Padding(3)
        Me.btnResetFilter.Size = New System.Drawing.Size(33, 27)
        Me.btnResetFilter.TabIndex = 214
        Me.btnResetFilter.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnResetFilter, "Clear filter")
        Me.btnResetFilter.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel6.Controls.Add(Me.txtboxSearch)
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(13, 125)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1898, 50)
        Me.Panel6.TabIndex = 40
        '
        'txtboxSearch
        '
        Me.txtboxSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxSearch.ForeColor = System.Drawing.Color.White
        Me.txtboxSearch.Location = New System.Drawing.Point(41, 12)
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(305, 27)
        Me.txtboxSearch.TabIndex = 19
        Me.txtboxSearch.TabStop = False
        Me.txtboxSearch.Tag = ""
        Me.txtboxSearch.Text = "  Search here"
        Me.ToolTip1.SetToolTip(Me.txtboxSearch, "Search by username")
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.PictureBox3.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'UserLogID
        '
        Me.UserLogID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserLogID.HeaderText = "User Log ID"
        Me.UserLogID.MinimumWidth = 6
        Me.UserLogID.Name = "UserLogID"
        '
        'Username
        '
        Me.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Username.HeaderText = "Username"
        Me.Username.MinimumWidth = 6
        Me.Username.Name = "Username"
        '
        'AccountType
        '
        Me.AccountType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AccountType.HeaderText = "Account Type"
        Me.AccountType.MinimumWidth = 6
        Me.AccountType.Name = "AccountType"
        '
        'DateTimeIn
        '
        Me.DateTimeIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateTimeIn.HeaderText = "Date Time In"
        Me.DateTimeIn.MinimumWidth = 6
        Me.DateTimeIn.Name = "DateTimeIn"
        '
        'dataviewUserLogs
        '
        Me.dataviewUserLogs.AllowUserToAddRows = False
        Me.dataviewUserLogs.AllowUserToDeleteRows = False
        Me.dataviewUserLogs.AllowUserToResizeColumns = False
        Me.dataviewUserLogs.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dataviewUserLogs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataviewUserLogs.BackgroundColor = System.Drawing.Color.White
        Me.dataviewUserLogs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataviewUserLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dataviewUserLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataviewUserLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataviewUserLogs.ColumnHeadersHeight = 50
        Me.dataviewUserLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataviewUserLogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserLog, Me.LogUserName, Me.LogAccountType, Me.LogDateTimeIn, Me.LogDateTimeOut})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataviewUserLogs.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataviewUserLogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataviewUserLogs.EnableHeadersVisualStyles = False
        Me.dataviewUserLogs.Location = New System.Drawing.Point(13, 175)
        Me.dataviewUserLogs.Name = "dataviewUserLogs"
        Me.dataviewUserLogs.ReadOnly = True
        Me.dataviewUserLogs.RowHeadersVisible = False
        Me.dataviewUserLogs.RowHeadersWidth = 20
        Me.dataviewUserLogs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dataviewUserLogs.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dataviewUserLogs.RowTemplate.Height = 29
        Me.dataviewUserLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataviewUserLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataviewUserLogs.ShowCellToolTips = False
        Me.dataviewUserLogs.Size = New System.Drawing.Size(1898, 889)
        Me.dataviewUserLogs.TabIndex = 1
        '
        'UserLog
        '
        Me.UserLog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserLog.HeaderText = "User Log ID"
        Me.UserLog.MinimumWidth = 6
        Me.UserLog.Name = "UserLog"
        Me.UserLog.ReadOnly = True
        '
        'LogUserName
        '
        Me.LogUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LogUserName.HeaderText = "Username"
        Me.LogUserName.MinimumWidth = 6
        Me.LogUserName.Name = "LogUserName"
        Me.LogUserName.ReadOnly = True
        '
        'LogAccountType
        '
        Me.LogAccountType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LogAccountType.HeaderText = "Account Type"
        Me.LogAccountType.MinimumWidth = 6
        Me.LogAccountType.Name = "LogAccountType"
        Me.LogAccountType.ReadOnly = True
        '
        'LogDateTimeIn
        '
        Me.LogDateTimeIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LogDateTimeIn.HeaderText = "Date Time In"
        Me.LogDateTimeIn.MinimumWidth = 6
        Me.LogDateTimeIn.Name = "LogDateTimeIn"
        Me.LogDateTimeIn.ReadOnly = True
        '
        'LogDateTimeOut
        '
        Me.LogDateTimeOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LogDateTimeOut.HeaderText = "Date Time Out"
        Me.LogDateTimeOut.MinimumWidth = 6
        Me.LogDateTimeOut.Name = "LogDateTimeOut"
        Me.LogDateTimeOut.ReadOnly = True
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
        'UserLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1077)
        Me.Controls.Add(Me.dataviewUserLogs)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TopGrayPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserLogs"
        Me.TopGrayPanel.ResumeLayout(False)
        Me.TopGrayPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataviewUserLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopGrayPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents UserLogID As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents AccountType As DataGridViewTextBoxColumn
    Friend WithEvents DateTimeIn As DataGridViewTextBoxColumn
    Friend WithEvents dataviewUserLogs As DataGridView
    Friend WithEvents UserLog As DataGridViewTextBoxColumn
    Friend WithEvents LogUserName As DataGridViewTextBoxColumn
    Friend WithEvents LogAccountType As DataGridViewTextBoxColumn
    Friend WithEvents LogDateTimeIn As DataGridViewTextBoxColumn
    Friend WithEvents LogDateTimeOut As DataGridViewTextBoxColumn
    Friend WithEvents txtboxSearch As TextBox
    Friend WithEvents dtpickerFilter As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnResetFilter As Button
End Class
