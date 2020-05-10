<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QrSet
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
        Me.cmbEncoding = New System.Windows.Forms.ComboBox()
        Me.lblEncoding = New System.Windows.Forms.Label()
        Me.chkStructuredAppend = New System.Windows.Forms.CheckBox()
        Me.nudModuleSize = New System.Windows.Forms.NumericUpDown()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmbMaxVersion = New System.Windows.Forms.ComboBox()
        Me.cmbErrorCorrectionLevel = New System.Windows.Forms.ComboBox()
        Me.lbModuleSize = New System.Windows.Forms.Label()
        Me.lblMaxVersion = New System.Windows.Forms.Label()
        Me.lblErrorCorrectionLevel = New System.Windows.Forms.Label()
        CType(Me.nudModuleSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbEncoding
        '
        Me.cmbEncoding.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEncoding.FormattingEnabled = True
        Me.cmbEncoding.Location = New System.Drawing.Point(359, 17)
        Me.cmbEncoding.Name = "cmbEncoding"
        Me.cmbEncoding.Size = New System.Drawing.Size(320, 20)
        Me.cmbEncoding.TabIndex = 14
        '
        'lblEncoding
        '
        Me.lblEncoding.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEncoding.AutoSize = True
        Me.lblEncoding.Location = New System.Drawing.Point(237, 20)
        Me.lblEncoding.Name = "lblEncoding"
        Me.lblEncoding.Size = New System.Drawing.Size(110, 12)
        Me.lblEncoding.TabIndex = 13
        Me.lblEncoding.Text = "Byte mode Encoding :"
        '
        'chkStructuredAppend
        '
        Me.chkStructuredAppend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkStructuredAppend.AutoSize = True
        Me.chkStructuredAppend.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkStructuredAppend.Location = New System.Drawing.Point(237, 48)
        Me.chkStructuredAppend.Name = "chkStructuredAppend"
        Me.chkStructuredAppend.Size = New System.Drawing.Size(132, 17)
        Me.chkStructuredAppend.TabIndex = 17
        Me.chkStructuredAppend.Text = "Structured Append"
        Me.chkStructuredAppend.UseVisualStyleBackColor = True
        '
        'nudModuleSize
        '
        Me.nudModuleSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nudModuleSize.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.nudModuleSize.Location = New System.Drawing.Point(479, 46)
        Me.nudModuleSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudModuleSize.Name = "nudModuleSize"
        Me.nudModuleSize.Size = New System.Drawing.Size(46, 20)
        Me.nudModuleSize.TabIndex = 19
        Me.nudModuleSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSave.Location = New System.Drawing.Point(555, 45)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(124, 23)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cmbMaxVersion
        '
        Me.cmbMaxVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbMaxVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaxVersion.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbMaxVersion.FormattingEnabled = True
        Me.cmbMaxVersion.Location = New System.Drawing.Point(171, 46)
        Me.cmbMaxVersion.Name = "cmbMaxVersion"
        Me.cmbMaxVersion.Size = New System.Drawing.Size(48, 21)
        Me.cmbMaxVersion.TabIndex = 16
        '
        'cmbErrorCorrectionLevel
        '
        Me.cmbErrorCorrectionLevel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbErrorCorrectionLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbErrorCorrectionLevel.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbErrorCorrectionLevel.FormattingEnabled = True
        Me.cmbErrorCorrectionLevel.Location = New System.Drawing.Point(171, 16)
        Me.cmbErrorCorrectionLevel.Name = "cmbErrorCorrectionLevel"
        Me.cmbErrorCorrectionLevel.Size = New System.Drawing.Size(48, 21)
        Me.cmbErrorCorrectionLevel.TabIndex = 12
        '
        'lbModuleSize
        '
        Me.lbModuleSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbModuleSize.AutoSize = True
        Me.lbModuleSize.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbModuleSize.Location = New System.Drawing.Point(391, 50)
        Me.lbModuleSize.Name = "lbModuleSize"
        Me.lbModuleSize.Size = New System.Drawing.Size(82, 13)
        Me.lbModuleSize.TabIndex = 18
        Me.lbModuleSize.Text = "Module Size :"
        '
        'lblMaxVersion
        '
        Me.lblMaxVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMaxVersion.AutoSize = True
        Me.lblMaxVersion.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblMaxVersion.Location = New System.Drawing.Point(16, 50)
        Me.lblMaxVersion.Name = "lblMaxVersion"
        Me.lblMaxVersion.Size = New System.Drawing.Size(83, 13)
        Me.lblMaxVersion.TabIndex = 15
        Me.lblMaxVersion.Text = "Max Version :"
        '
        'lblErrorCorrectionLevel
        '
        Me.lblErrorCorrectionLevel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblErrorCorrectionLevel.AutoSize = True
        Me.lblErrorCorrectionLevel.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblErrorCorrectionLevel.Location = New System.Drawing.Point(16, 20)
        Me.lblErrorCorrectionLevel.Name = "lblErrorCorrectionLevel"
        Me.lblErrorCorrectionLevel.Size = New System.Drawing.Size(143, 13)
        Me.lblErrorCorrectionLevel.TabIndex = 11
        Me.lblErrorCorrectionLevel.Text = "Error Correction Level :"
        '
        'QrSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 83)
        Me.Controls.Add(Me.cmbEncoding)
        Me.Controls.Add(Me.lblEncoding)
        Me.Controls.Add(Me.chkStructuredAppend)
        Me.Controls.Add(Me.nudModuleSize)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbMaxVersion)
        Me.Controls.Add(Me.cmbErrorCorrectionLevel)
        Me.Controls.Add(Me.lbModuleSize)
        Me.Controls.Add(Me.lblMaxVersion)
        Me.Controls.Add(Me.lblErrorCorrectionLevel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QrSet"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "QrSet(此表單所有控件屬於QRCodeLibVB),Save Button控件不可用"
        CType(Me.nudModuleSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblEncoding As Label
    Friend WithEvents lbModuleSize As Label
    Friend WithEvents lblMaxVersion As Label
    Friend WithEvents lblErrorCorrectionLevel As Label
    Public WithEvents cmbEncoding As ComboBox
    Public WithEvents chkStructuredAppend As CheckBox
    Public WithEvents nudModuleSize As NumericUpDown
    Public WithEvents btnSave As Button
    Public WithEvents cmbMaxVersion As ComboBox
    Public WithEvents cmbErrorCorrectionLevel As ComboBox
End Class
