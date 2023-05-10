<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreviewXray
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreviewXray))
        Me.picBoxPreviewXray = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxXrayName = New System.Windows.Forms.TextBox()
        Me.btnAddXRay = New System.Windows.Forms.Button()
        CType(Me.picBoxPreviewXray, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBoxPreviewXray
        '
        Me.picBoxPreviewXray.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picBoxPreviewXray.Location = New System.Drawing.Point(21, 27)
        Me.picBoxPreviewXray.Name = "picBoxPreviewXray"
        Me.picBoxPreviewXray.Size = New System.Drawing.Size(1200, 575)
        Me.picBoxPreviewXray.TabIndex = 0
        Me.picBoxPreviewXray.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(528, 633)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X-Ray Name :"
        '
        'txtboxXrayName
        '
        Me.txtboxXrayName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxXrayName.Location = New System.Drawing.Point(629, 630)
        Me.txtboxXrayName.Name = "txtboxXrayName"
        Me.txtboxXrayName.Size = New System.Drawing.Size(456, 27)
        Me.txtboxXrayName.TabIndex = 2
        '
        'btnAddXRay
        '
        Me.btnAddXRay.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAddXRay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddXRay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddXRay.ForeColor = System.Drawing.Color.White
        Me.btnAddXRay.Location = New System.Drawing.Point(1102, 628)
        Me.btnAddXRay.Name = "btnAddXRay"
        Me.btnAddXRay.Size = New System.Drawing.Size(119, 29)
        Me.btnAddXRay.TabIndex = 3
        Me.btnAddXRay.Text = "Add X-Ray"
        Me.btnAddXRay.UseVisualStyleBackColor = False
        '
        'PreviewXray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1243, 680)
        Me.Controls.Add(Me.btnAddXRay)
        Me.Controls.Add(Me.txtboxXrayName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picBoxPreviewXray)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PreviewXray"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picBoxPreviewXray, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBoxPreviewXray As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxXrayName As TextBox
    Friend WithEvents btnAddXRay As Button
End Class
