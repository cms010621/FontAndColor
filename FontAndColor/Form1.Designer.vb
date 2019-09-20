<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tlsMenu = New System.Windows.Forms.ToolStrip()
        Me.fontDlg = New System.Windows.Forms.FontDialog()
        Me.colorDlg = New System.Windows.Forms.ColorDialog()
        Me.rtbText = New System.Windows.Forms.RichTextBox()
        Me.tsbtnFont = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnColor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.tlsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 206)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(229, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "3216 최민성  - 폰트 변경"
        '
        'tlsMenu
        '
        Me.tlsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnFont, Me.tsbtnColor})
        Me.tlsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlsMenu.Name = "tlsMenu"
        Me.tlsMenu.Size = New System.Drawing.Size(229, 25)
        Me.tlsMenu.TabIndex = 1
        Me.tlsMenu.Text = "ToolStrip1"
        '
        'rtbText
        '
        Me.rtbText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbText.Location = New System.Drawing.Point(0, 25)
        Me.rtbText.Name = "rtbText"
        Me.rtbText.Size = New System.Drawing.Size(229, 181)
        Me.rtbText.TabIndex = 2
        Me.rtbText.Text = resources.GetString("rtbText.Text")
        '
        'tsbtnFont
        '
        Me.tsbtnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnFont.Image = CType(resources.GetObject("tsbtnFont.Image"), System.Drawing.Image)
        Me.tsbtnFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnFont.Name = "tsbtnFont"
        Me.tsbtnFont.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnFont.Text = "ToolStripButton1"
        '
        'tsbtnColor
        '
        Me.tsbtnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnColor.Image = CType(resources.GetObject("tsbtnColor.Image"), System.Drawing.Image)
        Me.tsbtnColor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnColor.Name = "tsbtnColor"
        Me.tsbtnColor.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnColor.Text = "ToolStripButton2"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(144, 17)
        Me.ToolStripStatusLabel1.Text = "3216 최민성  - 폰트 변경"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 228)
        Me.Controls.Add(Me.rtbText)
        Me.Controls.Add(Me.tlsMenu)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "3216 최민성"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.tlsMenu.ResumeLayout(False)
        Me.tlsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tlsMenu As ToolStrip
    Friend WithEvents fontDlg As FontDialog
    Friend WithEvents colorDlg As ColorDialog
    Friend WithEvents rtbText As RichTextBox
    Friend WithEvents tsbtnFont As ToolStripButton
    Friend WithEvents tsbtnColor As ToolStripButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
