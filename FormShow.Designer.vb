<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormShow
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.設定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.語言ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.繁體中文ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.設定檔ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Qr調試面板ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.幫助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.什麼是QrcpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.什麼是QrcpGUIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.它可以做什麼ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QRCodeLibVBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QRCodeLibVBToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.qrcodePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.設定ToolStripMenuItem, Me.Qr調試面板ToolStripMenuItem, Me.幫助ToolStripMenuItem, Me.QRCodeLibVBToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(304, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '設定ToolStripMenuItem
        '
        Me.設定ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.語言ToolStripMenuItem, Me.設定檔ToolStripMenuItem, Me.TextToolStripMenuItem})
        Me.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem"
        Me.設定ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.設定ToolStripMenuItem.Text = "設定"
        '
        '語言ToolStripMenuItem
        '
        Me.語言ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.繁體中文ToolStripMenuItem})
        Me.語言ToolStripMenuItem.Name = "語言ToolStripMenuItem"
        Me.語言ToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.語言ToolStripMenuItem.Text = "語言"
        '
        '繁體中文ToolStripMenuItem
        '
        Me.繁體中文ToolStripMenuItem.Name = "繁體中文ToolStripMenuItem"
        Me.繁體中文ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.繁體中文ToolStripMenuItem.Text = "繁體中文"
        '
        '設定檔ToolStripMenuItem
        '
        Me.設定檔ToolStripMenuItem.Name = "設定檔ToolStripMenuItem"
        Me.設定檔ToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.設定檔ToolStripMenuItem.Text = "設定檔"
        '
        'TextToolStripMenuItem
        '
        Me.TextToolStripMenuItem.Name = "TextToolStripMenuItem"
        Me.TextToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.TextToolStripMenuItem.Text = "重置配置文件"
        '
        'Qr調試面板ToolStripMenuItem
        '
        Me.Qr調試面板ToolStripMenuItem.Name = "Qr調試面板ToolStripMenuItem"
        Me.Qr調試面板ToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.Qr調試面板ToolStripMenuItem.Text = "QrCode調試面板"
        '
        '幫助ToolStripMenuItem
        '
        Me.幫助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.什麼是QrcpToolStripMenuItem, Me.什麼是QrcpGUIToolStripMenuItem, Me.它可以做什麼ToolStripMenuItem})
        Me.幫助ToolStripMenuItem.Name = "幫助ToolStripMenuItem"
        Me.幫助ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.幫助ToolStripMenuItem.Text = "幫助"
        '
        '什麼是QrcpToolStripMenuItem
        '
        Me.什麼是QrcpToolStripMenuItem.Name = "什麼是QrcpToolStripMenuItem"
        Me.什麼是QrcpToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.什麼是QrcpToolStripMenuItem.Text = "什麼是Qrcp?"
        '
        '什麼是QrcpGUIToolStripMenuItem
        '
        Me.什麼是QrcpGUIToolStripMenuItem.Name = "什麼是QrcpGUIToolStripMenuItem"
        Me.什麼是QrcpGUIToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.什麼是QrcpGUIToolStripMenuItem.Text = "什麼是Qrcp GUI?"
        '
        '它可以做什麼ToolStripMenuItem
        '
        Me.它可以做什麼ToolStripMenuItem.Name = "它可以做什麼ToolStripMenuItem"
        Me.它可以做什麼ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.它可以做什麼ToolStripMenuItem.Text = "它可以做什麼?"
        '
        'QRCodeLibVBToolStripMenuItem
        '
        Me.QRCodeLibVBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QRCodeLibVBToolStripMenuItem1})
        Me.QRCodeLibVBToolStripMenuItem.Name = "QRCodeLibVBToolStripMenuItem"
        Me.QRCodeLibVBToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.QRCodeLibVBToolStripMenuItem.Text = "引用項目"
        '
        'QRCodeLibVBToolStripMenuItem1
        '
        Me.QRCodeLibVBToolStripMenuItem1.Name = "QRCodeLibVBToolStripMenuItem1"
        Me.QRCodeLibVBToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.QRCodeLibVBToolStripMenuItem1.Text = "QRCodeLibVB"
        '
        'qrcodePanel
        '
        Me.qrcodePanel.Location = New System.Drawing.Point(12, 36)
        Me.qrcodePanel.Name = "qrcodePanel"
        Me.qrcodePanel.Size = New System.Drawing.Size(282, 282)
        Me.qrcodePanel.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(219, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "啟動程序"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 324)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 58)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "檔案拖拽到此"
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(276, 36)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Location = New System.Drawing.Point(15, 388)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(276, 23)
        Me.Panel2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(253, 23)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Location = New System.Drawing.Point(253, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(23, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "🗂"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Multiselect = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(66, 429)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(147, 22)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.TabStop = False
        Me.TextBox2.Tag = "將生成的地址放到這裡生成qrcode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 432)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "QrCode:"
        '
        'FormShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 464)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.qrcodePanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormShow"
        Me.Text = "Qrcp GUI(免費軟件,不得用於任何盈利用途)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 設定ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 語言ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 繁體中文ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 設定檔ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents qrcodePanel As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Qr調試面板ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents 幫助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 什麼是QrcpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 什麼是QrcpGUIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 它可以做什麼ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QRCodeLibVBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QRCodeLibVBToolStripMenuItem1 As ToolStripMenuItem
End Class
