<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Procedure
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Procedure))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TopGrayPanel = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnAddNewProcedure = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dataGridProcedure = New System.Windows.Forms.DataGridView()
        Me.ProcedureNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcedureName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcedurePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcedureDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcedureCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtboxProcFound = New System.Windows.Forms.TextBox()
        Me.txtboxSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopGrayPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dataGridProcedure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopGrayPanel
        '
        Me.TopGrayPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TopGrayPanel.Controls.Add(Me.Panel5)
        Me.TopGrayPanel.Controls.Add(Me.Label2)
        Me.TopGrayPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopGrayPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopGrayPanel.Name = "TopGrayPanel"
        Me.TopGrayPanel.Size = New System.Drawing.Size(1924, 63)
        Me.TopGrayPanel.TabIndex = 28
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnAddNewProcedure)
        Me.Panel5.Location = New System.Drawing.Point(122, 17)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(31, 31)
        Me.Panel5.TabIndex = 22
        '
        'btnAddNewProcedure
        '
        Me.btnAddNewProcedure.BackColor = System.Drawing.Color.White
        Me.btnAddNewProcedure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewProcedure.FlatAppearance.BorderSize = 0
        Me.btnAddNewProcedure.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnAddNewProcedure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAddNewProcedure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewProcedure.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddNewProcedure.ForeColor = System.Drawing.Color.White
        Me.btnAddNewProcedure.Image = CType(resources.GetObject("btnAddNewProcedure.Image"), System.Drawing.Image)
        Me.btnAddNewProcedure.Location = New System.Drawing.Point(-8, -4)
        Me.btnAddNewProcedure.Name = "btnAddNewProcedure"
        Me.btnAddNewProcedure.Size = New System.Drawing.Size(45, 38)
        Me.btnAddNewProcedure.TabIndex = 1
        Me.btnAddNewProcedure.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnAddNewProcedure, "Add new procedure")
        Me.btnAddNewProcedure.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 28)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Procedure"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(13, 1064)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1898, 13)
        Me.Panel4.TabIndex = 35
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1911, 76)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 1001)
        Me.Panel3.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 1001)
        Me.Panel2.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1924, 13)
        Me.Panel1.TabIndex = 32
        '
        'dataGridProcedure
        '
        Me.dataGridProcedure.AllowUserToAddRows = False
        Me.dataGridProcedure.AllowUserToDeleteRows = False
        Me.dataGridProcedure.AllowUserToResizeColumns = False
        Me.dataGridProcedure.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dataGridProcedure.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridProcedure.BackgroundColor = System.Drawing.Color.White
        Me.dataGridProcedure.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridProcedure.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dataGridProcedure.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridProcedure.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridProcedure.ColumnHeadersHeight = 50
        Me.dataGridProcedure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridProcedure.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProcedureNumber, Me.ProcedureName, Me.ProcedurePrice, Me.ProcedureDescription, Me.ProcedureCategory, Me.Edit})
        Me.dataGridProcedure.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridProcedure.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataGridProcedure.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridProcedure.EnableHeadersVisualStyles = False
        Me.dataGridProcedure.Location = New System.Drawing.Point(13, 137)
        Me.dataGridProcedure.Name = "dataGridProcedure"
        Me.dataGridProcedure.ReadOnly = True
        Me.dataGridProcedure.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataGridProcedure.RowHeadersVisible = False
        Me.dataGridProcedure.RowHeadersWidth = 20
        Me.dataGridProcedure.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridProcedure.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dataGridProcedure.RowTemplate.Height = 29
        Me.dataGridProcedure.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataGridProcedure.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridProcedure.ShowCellToolTips = False
        Me.dataGridProcedure.Size = New System.Drawing.Size(1898, 927)
        Me.dataGridProcedure.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.dataGridProcedure, "Click to view procedure details")
        '
        'ProcedureNumber
        '
        Me.ProcedureNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProcedureNumber.HeaderText = "Procedure Number"
        Me.ProcedureNumber.MinimumWidth = 6
        Me.ProcedureNumber.Name = "ProcedureNumber"
        Me.ProcedureNumber.ReadOnly = True
        Me.ProcedureNumber.Visible = False
        '
        'ProcedureName
        '
        Me.ProcedureName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProcedureName.HeaderText = "Procedure Name"
        Me.ProcedureName.MinimumWidth = 6
        Me.ProcedureName.Name = "ProcedureName"
        Me.ProcedureName.ReadOnly = True
        '
        'ProcedurePrice
        '
        Me.ProcedurePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProcedurePrice.HeaderText = "Procedure Price"
        Me.ProcedurePrice.MinimumWidth = 6
        Me.ProcedurePrice.Name = "ProcedurePrice"
        Me.ProcedurePrice.ReadOnly = True
        '
        'ProcedureDescription
        '
        Me.ProcedureDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProcedureDescription.HeaderText = "Description"
        Me.ProcedureDescription.MinimumWidth = 6
        Me.ProcedureDescription.Name = "ProcedureDescription"
        Me.ProcedureDescription.ReadOnly = True
        '
        'ProcedureCategory
        '
        Me.ProcedureCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProcedureCategory.HeaderText = "Category"
        Me.ProcedureCategory.MinimumWidth = 6
        Me.ProcedureCategory.Name = "ProcedureCategory"
        Me.ProcedureCategory.ReadOnly = True
        '
        'Edit
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = CType(resources.GetObject("DataGridViewCellStyle3.NullValue"), Object)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue
        Me.Edit.DefaultCellStyle = DataGridViewCellStyle3
        Me.Edit.HeaderText = ""
        Me.Edit.Image = CType(resources.GetObject("Edit.Image"), System.Drawing.Image)
        Me.Edit.MinimumWidth = 6
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Width = 60
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel6.Controls.Add(Me.txtboxProcFound)
        Me.Panel6.Controls.Add(Me.txtboxSearch)
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(13, 76)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1898, 61)
        Me.Panel6.TabIndex = 36
        '
        'txtboxProcFound
        '
        Me.txtboxProcFound.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxProcFound.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtboxProcFound.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxProcFound.ForeColor = System.Drawing.Color.White
        Me.txtboxProcFound.Location = New System.Drawing.Point(1727, 20)
        Me.txtboxProcFound.Name = "txtboxProcFound"
        Me.txtboxProcFound.ReadOnly = True
        Me.txtboxProcFound.Size = New System.Drawing.Size(151, 20)
        Me.txtboxProcFound.TabIndex = 38
        Me.txtboxProcFound.TabStop = False
        Me.txtboxProcFound.Text = "4 procedure/s found"
        Me.txtboxProcFound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtboxSearch
        '
        Me.txtboxSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxSearch.ForeColor = System.Drawing.Color.White
        Me.txtboxSearch.Location = New System.Drawing.Point(39, 18)
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(305, 27)
        Me.txtboxSearch.TabIndex = 2
        Me.txtboxSearch.TabStop = False
        Me.txtboxSearch.Text = "  Search here"
        Me.ToolTip1.SetToolTip(Me.txtboxSearch, "Search by procedure name")
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(10, 18)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.PictureBox3.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
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
        'Procedure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1077)
        Me.Controls.Add(Me.dataGridProcedure)
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
        Me.Name = "Procedure"
        Me.Text = "Procedure"
        Me.TopGrayPanel.ResumeLayout(False)
        Me.TopGrayPanel.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.dataGridProcedure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopGrayPanel As Panel
    Friend WithEvents btnAddNewProcedure As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dataGridProcedure As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtboxSearch As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtboxProcFound As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnDiscount As Button
    Friend WithEvents ProcedureNumber As DataGridViewTextBoxColumn
    Friend WithEvents ProcedureName As DataGridViewTextBoxColumn
    Friend WithEvents ProcedurePrice As DataGridViewTextBoxColumn
    Friend WithEvents ProcedureDescription As DataGridViewTextBoxColumn
    Friend WithEvents ProcedureCategory As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewImageColumn
    Friend WithEvents Panel5 As Panel
End Class
