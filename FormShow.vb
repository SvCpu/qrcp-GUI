Imports System.Text
Imports Ys.QRCode
'代碼引用說明:
'Region關鍵字範圍[QrCodeMode]以內代碼來自GitHub:
'https://github.com/yas78/QRCodeLibVB
'有部分修改,如需獲取修改部分請前往原地址下載並且自行對比(Region關鍵字範圍[QrCodeMode]以內)
'專案QRCodeLib未修改(完整復制)
'以下代碼(Region關鍵字範圍[QrCodeMode]以內)已修改為適合本程式使用的版本
'如果需要修改本代碼引用說明陳述方式或者停止發布相關內容,請版權持有者或者作者主動聯繫我(Email:2582439@gmail.com),聯繫時請出示QRCodeLibVB版權持有相關證明或者著作權相關證明(只用於證明您是QRCodeLibVB版權方或者作者)
'注意:你只能要求停止包含你的項目任何部分的相关内容(專案QRCodeLib,Region關鍵字範圍[QrCodeMode]以內)發布
Public Class FormShow
    ReadOnly inipath As String = Application.StartupPath + "\setting.ini"
    Public qrcppath As String
    Private Filepath() As String
    Private FilepathNum As Integer = 0
    Private Start As Boolean = False
    Private Sub FormShow_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Files(inipath) Then
            If GINI("CallMode", "qrcpURL", "", inipath) = CStr(0) Then
                qrcppath = Application.StartupPath + "\"
            ElseIf GINI("CallMode", "qrcpURL", "", inipath) = CStr(1) Then
                If GINI("CallMode", "qrcpURLs", "", inipath) = "" Then
                    qrcppath = Application.StartupPath + "\"
                    MsgBox("自定義地址未配置,您可以嘗試使用重置配置文件來處理這個問題")
                Else
                    qrcppath = GINI("CallMode", "qrcpURLs", "", inipath)
                End If
            Else
                MsgBox("系統在配置文件中未找到設定")
            End If
            If GINI("CallMode", "QrMode", "", inipath) = CStr(0) Then
                Qr調試面板ToolStripMenuItem.Visible = False
                Label1.Visible = False
                TextBox2.Visible = False
            End If
        Else
            MsgBox("系統在當前目錄找不到檔案setting.ini", 0 + 16, "")
            Close()
        End If
#Region "QrCode"
        QrSet.cmbErrorCorrectionLevel.DataSource =
    [Enum].GetValues(GetType(ErrorCorrectionLevel))
        QrSet.cmbErrorCorrectionLevel.SelectedItem = ErrorCorrectionLevel.L

        For i As Integer = Constants.MIN_VERSION To Constants.MAX_VERSION
            QrSet.cmbMaxVersion.Items.Add(i)
        Next

        QrSet.cmbMaxVersion.SelectedIndex = QrSet.cmbMaxVersion.Items.Count - 1

        QrSet.cmbEncoding.DisplayMember = "DisplayName"
        QrSet.cmbEncoding.ValueMember = "Name"
        QrSet.cmbEncoding.DataSource = Encoding.GetEncodings()
        QrSet.cmbEncoding.Text = Encoding.Default.EncodingName

        QrSet.nudModuleSize.Value = 7
        QrSet.chkStructuredAppend.Checked = False
        QrSet.btnSave.Enabled = False
    End Sub
#End Region

    Private Sub 設定檔ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 設定檔ToolStripMenuItem.Click
        Setini.ShowDialog()
    End Sub

    Private Sub TextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextToolStripMenuItem.Click
        If MsgBox("當前操作會覆蓋先前設定" & Chr(13) & "此功能通常用於刪除配置文件後重新配置", 1 + 48, "警告") = 1 Then
            Try
                WINI("CallMode", "Hidewindow", 0, inipath)
                WINI("CallMode", "qrcpURL", 0, inipath)
                WINI("CallMode", "qrcpURLs", "", inipath)
                WINI("CallMode", "QrMode", 0, inipath)
                Close()
            Catch ex As Exception
                MsgBox("出現未知問題無法寫入o((⊙﹏⊙))o." & Chr(13) & ex.ToString)
            End Try
        End If
    End Sub
#Region "QrCodeMode"
    Public Sub UpdateQRCodePanel(ByVal URL As String)

        qrcodePanel.Controls.Clear()

        If String.IsNullOrEmpty(URL) Then
            Return
        End If

        Dim ecLevel As ErrorCorrectionLevel = CType(QrSet.cmbErrorCorrectionLevel.SelectedItem, ErrorCorrectionLevel)
        Dim version As Integer = CInt(QrSet.cmbMaxVersion.SelectedItem)
        Dim allowStructuredAppend As Boolean = QrSet.chkStructuredAppend.Checked
        Dim encoding As Encoding = CType(QrSet.cmbEncoding.SelectedItem, EncodingInfo).GetEncoding()

        Dim symbols As Symbols = New Symbols(ecLevel, version, allowStructuredAppend, encoding.WebName)

        Try
            symbols.AppendText(URL)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

        For Each symbol As Symbol In symbols
            Dim image As Image = symbol.GetImage(CInt(QrSet.nudModuleSize.Value), False)
            Dim pictureBox = New PictureBox() With {
                .Size = image.Size,
                .Image = image
            }
            qrcodePanel.Controls.Add(pictureBox)
        Next
    End Sub
#End Region
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CType(sender, Button).Enabled = False
        If Start Then
            Dim Strs As String
            For Each s In Filepath
                If Files(s) Then
                    Strs += " " & s
                End If
            Next
            RunCommand(Strs, qrcppath)
        Else
            MsgBox("請選擇檔案")
        End If
        CType(sender, Button).Enabled = True
    End Sub
    Private Sub RunCommand(command As String, WorkingDirectory As String)
        Dim p As New Process()
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.WorkingDirectory = WorkingDirectory
        p.StartInfo.Arguments = "/K qrcp" & command
        p.StartInfo.UseShellExecute = False
        p.Start()
        p.Dispose()
    End Sub

    Private Sub Qr調試面板ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Qr調試面板ToolStripMenuItem.Click
        QrSet.Show()
    End Sub
    Private Sub Panel1_DragDrop(sender As Object, e As DragEventArgs) Handles Panel1.DragDrop
        CType(sender, Panel).Tag += 1
        If CType(sender, Panel).Tag = 2 Then
            MsgBox("都說他把這個東西寫成了垃圾桶你還把東西扔過來（⊙ｏ⊙）")
        ElseIf CType(sender, Panel).Tag = 3 Then
            MsgBox("你再把東西扔過來我就把它給刪了(╬▔皿▔)╯")
        ElseIf CType(sender, Panel).Tag > 3 Then
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
            For Each path In files
                If files(path) Then
                    My.Computer.FileSystem.MoveFile(path, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\刪了(╬▔皿▔)╯\" & IO.Path.GetFileName(path))
                End If
            Next
        Else
            MsgBox("這個不要臉的作者好像把代碼寫錯了<(＿　＿)>" & Chr(13) & "他好像把這個東西寫成了一個垃圾桶了...")
        End If
    End Sub
    Private Sub Panel1_DragEnter(sender As Object, e As DragEventArgs) Handles Panel1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        Dim OutStr As String
        For Each s In OpenFileDialog1.FileNames
            If Files(s) Then
                FilepathNum += 1
                ReDim Preserve Filepath(FilepathNum)
                Filepath(FilepathNum) = s
                OutStr += IO.Path.GetFileName(s) & "/"
                Start = True
            End If
        Next
        TextBox1.Text = OutStr.Remove(OutStr.LastIndexOf("/"), 1)
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        UpdateQRCodePanel(TextBox2.Text)
    End Sub

    Private Sub 繁體中文ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 繁體中文ToolStripMenuItem.Click
        MsgBox("都已經是中文了" & Chr(13) & "你還要切換中文嗎(＃°Д°)")
    End Sub

    Private Sub 它可以做什麼ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 它可以做什麼ToolStripMenuItem.Click
        MsgBox("自己上網找¯\(°_o)/¯")
    End Sub

    Private Sub 什麼是QrcpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 什麼是QrcpToolStripMenuItem.Click
        Process.Start("https://zhuanlan.zhihu.com/p/135919968")
    End Sub

    Private Sub 什麼是QrcpGUIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 什麼是QrcpGUIToolStripMenuItem.Click
        MsgBox("圖形使用者介面（英語：Graphical User Interface，縮寫：GUI）是指採用圖形方式顯示的bla bla bla bla bla......" & Chr(13) & "簡單點說就是你不用打命令了只要點按鈕就可以了" & Chr(13) & "其實你有聽懂嗎XDD")
    End Sub
    Private Sub QRCodeLibVBToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QRCodeLibVBToolStripMenuItem1.Click
        Process.Start("https://github.com/yas78/QRCodeLibVB")
    End Sub
End Class
