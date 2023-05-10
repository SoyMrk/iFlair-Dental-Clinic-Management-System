<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Document
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Document))
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnViewFiles = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnUploadDoc = New System.Windows.Forms.Button()
        Me.pnlDocument = New System.Windows.Forms.Panel()
        Me.picboxPhoto5 = New System.Windows.Forms.PictureBox()
        Me.picboxPhoto4 = New System.Windows.Forms.PictureBox()
        Me.picboxPhoto3 = New System.Windows.Forms.PictureBox()
        Me.picboxPhoto2 = New System.Windows.Forms.PictureBox()
        Me.picboxPhoto1 = New System.Windows.Forms.PictureBox()
        Me.btnPrint5 = New System.Windows.Forms.Button()
        Me.btnPrint4 = New System.Windows.Forms.Button()
        Me.btnPrint3 = New System.Windows.Forms.Button()
        Me.btnPrint2 = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnDelete5 = New System.Windows.Forms.Button()
        Me.btnDelete4 = New System.Windows.Forms.Button()
        Me.btnDelete3 = New System.Windows.Forms.Button()
        Me.btnDelete2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPrintXray = New System.Windows.Forms.Button()
        Me.btnAddXray = New System.Windows.Forms.Button()
        Me.btnDeleteXray = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbboxXrayList = New System.Windows.Forms.ComboBox()
        Me.picboxXray = New System.Windows.Forms.PictureBox()
        Me.btnDelete1 = New System.Windows.Forms.Button()
        Me.lblPhotoName5 = New System.Windows.Forms.Label()
        Me.lblPhotoName4 = New System.Windows.Forms.Label()
        Me.lblPhotoName3 = New System.Windows.Forms.Label()
        Me.lblPhotoName2 = New System.Windows.Forms.Label()
        Me.lblPhotoName1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDoc2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDoc3 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDoc4 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDoc5 = New System.Drawing.Printing.PrintDocument()
        Me.PrintXray = New System.Drawing.Printing.PrintDocument()
        Me.Panel9.SuspendLayout()
        Me.pnlDocument.SuspendLayout()
        CType(Me.picboxPhoto5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxPhoto4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxPhoto3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxPhoto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxPhoto1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picboxXray, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel9.Controls.Add(Me.btnViewFiles)
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Controls.Add(Me.btnUploadDoc)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1689, 68)
        Me.Panel9.TabIndex = 229
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
        Me.btnViewFiles.Location = New System.Drawing.Point(1353, 14)
        Me.btnViewFiles.Name = "btnViewFiles"
        Me.btnViewFiles.Size = New System.Drawing.Size(101, 38)
        Me.btnViewFiles.TabIndex = 1
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
        Me.Label11.Location = New System.Drawing.Point(12, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 25)
        Me.Label11.TabIndex = 202
        Me.Label11.Text = "Documents"
        '
        'btnUploadDoc
        '
        Me.btnUploadDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUploadDoc.BackColor = System.Drawing.Color.Orange
        Me.btnUploadDoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadDoc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnUploadDoc.FlatAppearance.BorderSize = 0
        Me.btnUploadDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadDoc.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUploadDoc.ForeColor = System.Drawing.Color.White
        Me.btnUploadDoc.Image = CType(resources.GetObject("btnUploadDoc.Image"), System.Drawing.Image)
        Me.btnUploadDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUploadDoc.Location = New System.Drawing.Point(1462, 14)
        Me.btnUploadDoc.Name = "btnUploadDoc"
        Me.btnUploadDoc.Size = New System.Drawing.Size(138, 38)
        Me.btnUploadDoc.TabIndex = 2
        Me.btnUploadDoc.Text = "Upload Photo"
        Me.btnUploadDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnUploadDoc, "Upload new photo")
        Me.btnUploadDoc.UseVisualStyleBackColor = False
        '
        'pnlDocument
        '
        Me.pnlDocument.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDocument.Controls.Add(Me.picboxPhoto5)
        Me.pnlDocument.Controls.Add(Me.picboxPhoto4)
        Me.pnlDocument.Controls.Add(Me.picboxPhoto3)
        Me.pnlDocument.Controls.Add(Me.picboxPhoto2)
        Me.pnlDocument.Controls.Add(Me.picboxPhoto1)
        Me.pnlDocument.Controls.Add(Me.btnPrint5)
        Me.pnlDocument.Controls.Add(Me.btnPrint4)
        Me.pnlDocument.Controls.Add(Me.btnPrint3)
        Me.pnlDocument.Controls.Add(Me.btnPrint2)
        Me.pnlDocument.Controls.Add(Me.btnPrint)
        Me.pnlDocument.Controls.Add(Me.btnDelete5)
        Me.pnlDocument.Controls.Add(Me.btnDelete4)
        Me.pnlDocument.Controls.Add(Me.btnDelete3)
        Me.pnlDocument.Controls.Add(Me.btnDelete2)
        Me.pnlDocument.Controls.Add(Me.Panel2)
        Me.pnlDocument.Controls.Add(Me.btnDelete1)
        Me.pnlDocument.Controls.Add(Me.lblPhotoName5)
        Me.pnlDocument.Controls.Add(Me.lblPhotoName4)
        Me.pnlDocument.Controls.Add(Me.lblPhotoName3)
        Me.pnlDocument.Controls.Add(Me.lblPhotoName2)
        Me.pnlDocument.Controls.Add(Me.lblPhotoName1)
        Me.pnlDocument.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDocument.Location = New System.Drawing.Point(0, 68)
        Me.pnlDocument.Name = "pnlDocument"
        Me.pnlDocument.Size = New System.Drawing.Size(1689, 759)
        Me.pnlDocument.TabIndex = 230
        '
        'picboxPhoto5
        '
        Me.picboxPhoto5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxPhoto5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picboxPhoto5.Location = New System.Drawing.Point(1330, 66)
        Me.picboxPhoto5.Name = "picboxPhoto5"
        Me.picboxPhoto5.Size = New System.Drawing.Size(269, 212)
        Me.picboxPhoto5.TabIndex = 22
        Me.picboxPhoto5.TabStop = False
        Me.picboxPhoto5.Visible = False
        '
        'picboxPhoto4
        '
        Me.picboxPhoto4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxPhoto4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picboxPhoto4.Location = New System.Drawing.Point(1021, 66)
        Me.picboxPhoto4.Name = "picboxPhoto4"
        Me.picboxPhoto4.Size = New System.Drawing.Size(269, 212)
        Me.picboxPhoto4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxPhoto4.TabIndex = 19
        Me.picboxPhoto4.TabStop = False
        Me.picboxPhoto4.Visible = False
        '
        'picboxPhoto3
        '
        Me.picboxPhoto3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxPhoto3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picboxPhoto3.Location = New System.Drawing.Point(712, 66)
        Me.picboxPhoto3.Name = "picboxPhoto3"
        Me.picboxPhoto3.Size = New System.Drawing.Size(269, 212)
        Me.picboxPhoto3.TabIndex = 16
        Me.picboxPhoto3.TabStop = False
        Me.picboxPhoto3.Visible = False
        '
        'picboxPhoto2
        '
        Me.picboxPhoto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxPhoto2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picboxPhoto2.Location = New System.Drawing.Point(402, 66)
        Me.picboxPhoto2.Name = "picboxPhoto2"
        Me.picboxPhoto2.Size = New System.Drawing.Size(269, 212)
        Me.picboxPhoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picboxPhoto2.TabIndex = 13
        Me.picboxPhoto2.TabStop = False
        Me.picboxPhoto2.Visible = False
        '
        'picboxPhoto1
        '
        Me.picboxPhoto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxPhoto1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picboxPhoto1.Location = New System.Drawing.Point(94, 66)
        Me.picboxPhoto1.Name = "picboxPhoto1"
        Me.picboxPhoto1.Size = New System.Drawing.Size(269, 212)
        Me.picboxPhoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxPhoto1.TabIndex = 1
        Me.picboxPhoto1.TabStop = False
        Me.picboxPhoto1.Visible = False
        '
        'btnPrint5
        '
        Me.btnPrint5.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint5.ForeColor = System.Drawing.Color.White
        Me.btnPrint5.Image = CType(resources.GetObject("btnPrint5.Image"), System.Drawing.Image)
        Me.btnPrint5.Location = New System.Drawing.Point(1330, 284)
        Me.btnPrint5.Name = "btnPrint5"
        Me.btnPrint5.Size = New System.Drawing.Size(33, 29)
        Me.btnPrint5.TabIndex = 209
        Me.btnPrint5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnPrint5, "Print this photo")
        Me.btnPrint5.UseVisualStyleBackColor = False
        Me.btnPrint5.Visible = False
        '
        'btnPrint4
        '
        Me.btnPrint4.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint4.ForeColor = System.Drawing.Color.White
        Me.btnPrint4.Image = CType(resources.GetObject("btnPrint4.Image"), System.Drawing.Image)
        Me.btnPrint4.Location = New System.Drawing.Point(1021, 284)
        Me.btnPrint4.Name = "btnPrint4"
        Me.btnPrint4.Size = New System.Drawing.Size(33, 29)
        Me.btnPrint4.TabIndex = 208
        Me.btnPrint4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnPrint4, "Print this photo")
        Me.btnPrint4.UseVisualStyleBackColor = False
        Me.btnPrint4.Visible = False
        '
        'btnPrint3
        '
        Me.btnPrint3.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint3.ForeColor = System.Drawing.Color.White
        Me.btnPrint3.Image = CType(resources.GetObject("btnPrint3.Image"), System.Drawing.Image)
        Me.btnPrint3.Location = New System.Drawing.Point(712, 284)
        Me.btnPrint3.Name = "btnPrint3"
        Me.btnPrint3.Size = New System.Drawing.Size(33, 29)
        Me.btnPrint3.TabIndex = 207
        Me.btnPrint3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnPrint3, "Print this photo")
        Me.btnPrint3.UseVisualStyleBackColor = False
        Me.btnPrint3.Visible = False
        '
        'btnPrint2
        '
        Me.btnPrint2.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint2.ForeColor = System.Drawing.Color.White
        Me.btnPrint2.Image = CType(resources.GetObject("btnPrint2.Image"), System.Drawing.Image)
        Me.btnPrint2.Location = New System.Drawing.Point(402, 284)
        Me.btnPrint2.Name = "btnPrint2"
        Me.btnPrint2.Size = New System.Drawing.Size(33, 29)
        Me.btnPrint2.TabIndex = 206
        Me.btnPrint2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnPrint2, "Print this photo")
        Me.btnPrint2.UseVisualStyleBackColor = False
        Me.btnPrint2.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(94, 284)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(33, 29)
        Me.btnPrint.TabIndex = 205
        Me.btnPrint.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Print this photo")
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'btnDelete5
        '
        Me.btnDelete5.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete5.ForeColor = System.Drawing.Color.White
        Me.btnDelete5.Image = CType(resources.GetObject("btnDelete5.Image"), System.Drawing.Image)
        Me.btnDelete5.Location = New System.Drawing.Point(1364, 284)
        Me.btnDelete5.Name = "btnDelete5"
        Me.btnDelete5.Size = New System.Drawing.Size(33, 29)
        Me.btnDelete5.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btnDelete5, "Delete this photo")
        Me.btnDelete5.UseVisualStyleBackColor = False
        Me.btnDelete5.Visible = False
        '
        'btnDelete4
        '
        Me.btnDelete4.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete4.ForeColor = System.Drawing.Color.White
        Me.btnDelete4.Image = CType(resources.GetObject("btnDelete4.Image"), System.Drawing.Image)
        Me.btnDelete4.Location = New System.Drawing.Point(1055, 284)
        Me.btnDelete4.Name = "btnDelete4"
        Me.btnDelete4.Size = New System.Drawing.Size(33, 29)
        Me.btnDelete4.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.btnDelete4, "Delete this photo")
        Me.btnDelete4.UseVisualStyleBackColor = False
        Me.btnDelete4.Visible = False
        '
        'btnDelete3
        '
        Me.btnDelete3.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete3.ForeColor = System.Drawing.Color.White
        Me.btnDelete3.Image = CType(resources.GetObject("btnDelete3.Image"), System.Drawing.Image)
        Me.btnDelete3.Location = New System.Drawing.Point(746, 284)
        Me.btnDelete3.Name = "btnDelete3"
        Me.btnDelete3.Size = New System.Drawing.Size(33, 29)
        Me.btnDelete3.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.btnDelete3, "Delete this photo")
        Me.btnDelete3.UseVisualStyleBackColor = False
        Me.btnDelete3.Visible = False
        '
        'btnDelete2
        '
        Me.btnDelete2.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete2.ForeColor = System.Drawing.Color.White
        Me.btnDelete2.Image = CType(resources.GetObject("btnDelete2.Image"), System.Drawing.Image)
        Me.btnDelete2.Location = New System.Drawing.Point(436, 284)
        Me.btnDelete2.Name = "btnDelete2"
        Me.btnDelete2.Size = New System.Drawing.Size(33, 29)
        Me.btnDelete2.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.btnDelete2, "Delete this photo")
        Me.btnDelete2.UseVisualStyleBackColor = False
        Me.btnDelete2.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.btnPrintXray)
        Me.Panel2.Controls.Add(Me.btnAddXray)
        Me.Panel2.Controls.Add(Me.btnDeleteXray)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cmbboxXrayList)
        Me.Panel2.Controls.Add(Me.picboxXray)
        Me.Panel2.Location = New System.Drawing.Point(94, 338)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1503, 388)
        Me.Panel2.TabIndex = 25
        '
        'btnPrintXray
        '
        Me.btnPrintXray.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintXray.ForeColor = System.Drawing.Color.Black
        Me.btnPrintXray.Image = CType(resources.GetObject("btnPrintXray.Image"), System.Drawing.Image)
        Me.btnPrintXray.Location = New System.Drawing.Point(43, 97)
        Me.btnPrintXray.Name = "btnPrintXray"
        Me.btnPrintXray.Size = New System.Drawing.Size(33, 29)
        Me.btnPrintXray.TabIndex = 211
        Me.ToolTip1.SetToolTip(Me.btnPrintXray, "Print this X-ray")
        Me.btnPrintXray.UseVisualStyleBackColor = True
        '
        'btnAddXray
        '
        Me.btnAddXray.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAddXray.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddXray.FlatAppearance.BorderSize = 0
        Me.btnAddXray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddXray.ForeColor = System.Drawing.Color.White
        Me.btnAddXray.Image = CType(resources.GetObject("btnAddXray.Image"), System.Drawing.Image)
        Me.btnAddXray.Location = New System.Drawing.Point(372, 56)
        Me.btnAddXray.Name = "btnAddXray"
        Me.btnAddXray.Size = New System.Drawing.Size(37, 35)
        Me.btnAddXray.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.btnAddXray, "Add new x-ray")
        Me.btnAddXray.UseVisualStyleBackColor = False
        '
        'btnDeleteXray
        '
        Me.btnDeleteXray.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteXray.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteXray.ForeColor = System.Drawing.Color.White
        Me.btnDeleteXray.Image = CType(resources.GetObject("btnDeleteXray.Image"), System.Drawing.Image)
        Me.btnDeleteXray.Location = New System.Drawing.Point(77, 97)
        Me.btnDeleteXray.Name = "btnDeleteXray"
        Me.btnDeleteXray.Size = New System.Drawing.Size(33, 29)
        Me.btnDeleteXray.TabIndex = 4
        Me.btnDeleteXray.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnDeleteXray, "Delete this X-ray")
        Me.btnDeleteXray.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(38, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 28)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Patient X-Ray"
        '
        'cmbboxXrayList
        '
        Me.cmbboxXrayList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbboxXrayList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxXrayList.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbboxXrayList.FormattingEnabled = True
        Me.cmbboxXrayList.Items.AddRange(New Object() {"No Xray Data"})
        Me.cmbboxXrayList.Location = New System.Drawing.Point(43, 55)
        Me.cmbboxXrayList.Name = "cmbboxXrayList"
        Me.cmbboxXrayList.Size = New System.Drawing.Size(325, 36)
        Me.cmbboxXrayList.TabIndex = 12
        '
        'picboxXray
        '
        Me.picboxXray.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picboxXray.BackColor = System.Drawing.Color.White
        Me.picboxXray.Image = CType(resources.GetObject("picboxXray.Image"), System.Drawing.Image)
        Me.picboxXray.Location = New System.Drawing.Point(450, 17)
        Me.picboxXray.Name = "picboxXray"
        Me.picboxXray.Size = New System.Drawing.Size(1009, 354)
        Me.picboxXray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picboxXray.TabIndex = 2
        Me.picboxXray.TabStop = False
        '
        'btnDelete1
        '
        Me.btnDelete1.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete1.ForeColor = System.Drawing.Color.White
        Me.btnDelete1.Image = CType(resources.GetObject("btnDelete1.Image"), System.Drawing.Image)
        Me.btnDelete1.Location = New System.Drawing.Point(128, 284)
        Me.btnDelete1.Name = "btnDelete1"
        Me.btnDelete1.Size = New System.Drawing.Size(33, 29)
        Me.btnDelete1.TabIndex = 3
        Me.btnDelete1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnDelete1, "Delete this photo")
        Me.btnDelete1.UseVisualStyleBackColor = False
        Me.btnDelete1.Visible = False
        '
        'lblPhotoName5
        '
        Me.lblPhotoName5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPhotoName5.Location = New System.Drawing.Point(1325, 36)
        Me.lblPhotoName5.Name = "lblPhotoName5"
        Me.lblPhotoName5.Size = New System.Drawing.Size(269, 32)
        Me.lblPhotoName5.TabIndex = 24
        Me.lblPhotoName5.Text = "Label"
        Me.lblPhotoName5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPhotoName5.Visible = False
        '
        'lblPhotoName4
        '
        Me.lblPhotoName4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPhotoName4.Location = New System.Drawing.Point(1016, 36)
        Me.lblPhotoName4.Name = "lblPhotoName4"
        Me.lblPhotoName4.Size = New System.Drawing.Size(269, 32)
        Me.lblPhotoName4.TabIndex = 21
        Me.lblPhotoName4.Text = "Label"
        Me.lblPhotoName4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPhotoName4.Visible = False
        '
        'lblPhotoName3
        '
        Me.lblPhotoName3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPhotoName3.Location = New System.Drawing.Point(707, 36)
        Me.lblPhotoName3.Name = "lblPhotoName3"
        Me.lblPhotoName3.Size = New System.Drawing.Size(269, 32)
        Me.lblPhotoName3.TabIndex = 18
        Me.lblPhotoName3.Text = "Label"
        Me.lblPhotoName3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPhotoName3.Visible = False
        '
        'lblPhotoName2
        '
        Me.lblPhotoName2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPhotoName2.Location = New System.Drawing.Point(397, 36)
        Me.lblPhotoName2.Name = "lblPhotoName2"
        Me.lblPhotoName2.Size = New System.Drawing.Size(269, 32)
        Me.lblPhotoName2.TabIndex = 15
        Me.lblPhotoName2.Text = "Label"
        Me.lblPhotoName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPhotoName2.Visible = False
        '
        'lblPhotoName1
        '
        Me.lblPhotoName1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPhotoName1.Location = New System.Drawing.Point(89, 36)
        Me.lblPhotoName1.Name = "lblPhotoName1"
        Me.lblPhotoName1.Size = New System.Drawing.Size(269, 32)
        Me.lblPhotoName1.TabIndex = 5
        Me.lblPhotoName1.Text = "Label"
        Me.lblPhotoName1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPhotoName1.Visible = False
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
        'PrintDoc
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDoc2
        '
        '
        'PrintDoc3
        '
        '
        'PrintDoc4
        '
        '
        'PrintDoc5
        '
        '
        'PrintXray
        '
        '
        'Document
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1689, 827)
        Me.Controls.Add(Me.pnlDocument)
        Me.Controls.Add(Me.Panel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Document"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.pnlDocument.ResumeLayout(False)
        CType(Me.picboxPhoto5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxPhoto4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxPhoto3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxPhoto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxPhoto1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picboxXray, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents pnlDocument As Panel
    Friend WithEvents btnUploadDoc As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picboxPhoto1 As PictureBox
    Friend WithEvents picboxXray As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnDeleteXray As Button
    Friend WithEvents lblPhotoName As Label
    Friend WithEvents lblPhotoName2 As Label
    Friend WithEvents btnDelete2 As Button
    Friend WithEvents picboxPhoto2 As PictureBox
    Friend WithEvents cmbboxXrayList As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblPhotoName5 As Label
    Friend WithEvents btnDelete5 As Button
    Friend WithEvents picboxPhoto5 As PictureBox
    Friend WithEvents lblPhotoName4 As Label
    Friend WithEvents btnDelete4 As Button
    Friend WithEvents picboxPhoto4 As PictureBox
    Friend WithEvents lblPhotoName3 As Label
    Friend WithEvents btnDelete3 As Button
    Friend WithEvents picboxPhoto3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPhotoName1 As Label
    Friend WithEvents btnDelete1 As Button
    Friend WithEvents btnAddXray As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents btnPrint5 As Button
    Friend WithEvents btnPrint4 As Button
    Friend WithEvents btnPrint3 As Button
    Friend WithEvents btnPrint2 As Button
    Friend WithEvents PrintDoc2 As Printing.PrintDocument
    Friend WithEvents PrintDoc3 As Printing.PrintDocument
    Friend WithEvents PrintDoc4 As Printing.PrintDocument
    Friend WithEvents PrintDoc5 As Printing.PrintDocument
    Friend WithEvents PrintXray As Printing.PrintDocument
    Friend WithEvents btnPrintXray As Button
    Friend WithEvents btnViewFiles As Button
End Class
