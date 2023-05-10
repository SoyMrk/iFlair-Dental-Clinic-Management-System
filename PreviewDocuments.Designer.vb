<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreviewDocuments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreviewDocuments))
        Me.picboxPreview = New System.Windows.Forms.PictureBox()
        Me.btnAddDocument = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxDocumentName = New System.Windows.Forms.TextBox()
        CType(Me.picboxPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picboxPreview
        '
        Me.picboxPreview.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picboxPreview.Location = New System.Drawing.Point(12, 12)
        Me.picboxPreview.Name = "picboxPreview"
        Me.picboxPreview.Size = New System.Drawing.Size(621, 609)
        Me.picboxPreview.TabIndex = 0
        Me.picboxPreview.TabStop = False
        '
        'btnAddDocument
        '
        Me.btnAddDocument.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAddDocument.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDocument.ForeColor = System.Drawing.Color.White
        Me.btnAddDocument.Location = New System.Drawing.Point(514, 656)
        Me.btnAddDocument.Name = "btnAddDocument"
        Me.btnAddDocument.Size = New System.Drawing.Size(119, 29)
        Me.btnAddDocument.TabIndex = 1
        Me.btnAddDocument.Text = "Add File"
        Me.btnAddDocument.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 660)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Document Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtboxDocumentName
        '
        Me.txtboxDocumentName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxDocumentName.Location = New System.Drawing.Point(141, 657)
        Me.txtboxDocumentName.Name = "txtboxDocumentName"
        Me.txtboxDocumentName.Size = New System.Drawing.Size(354, 27)
        Me.txtboxDocumentName.TabIndex = 3
        '
        'PreviewDocuments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(645, 748)
        Me.Controls.Add(Me.txtboxDocumentName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddDocument)
        Me.Controls.Add(Me.picboxPreview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PreviewDocuments"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picboxPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picboxPreview As PictureBox
    Friend WithEvents btnAddDocument As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxDocumentName As TextBox
End Class
