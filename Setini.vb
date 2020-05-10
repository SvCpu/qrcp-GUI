Public Class Setini
    ReadOnly inipath As String = Application.StartupPath + "\setting.ini"
    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click
        If RadioButton1.Checked Then
            Panel1.Enabled = False
        Else
            Panel1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CType(sender, Button).Enabled = False
        If RadioButton1.Checked Then
            WINI("CallMode", "qrcpURL", "0", inipath)
        Else
            WINI("CallMode", "qrcpURL", "1", inipath)
            WINI("CallMode", "qrcpURLs", TextBox1.Text, inipath)
        End If
        If RadioButton3.Checked Then
            WINI("CallMode", "Hidewindow", "0", inipath)
        Else
            WINI("CallMode", "Hidewindow", "1", inipath)
        End If
        If RadioButton5.Checked Then
            WINI("CallMode", "QrMode", "1", inipath)
        Else
            WINI("CallMode", "QrMode", "0", inipath)
        End If
        CType(sender, Button).Enabled = True
    End Sub

    Private Sub Setini_Load(sender As Object, e As EventArgs) Handles Me.Load
        If GINI("CallMode", "Hidewindow", "", inipath) = "" Or GINI("CallMode", "qrcpURL", "", inipath) = "" Or GINI("CallMode", "QrMode", "", inipath) = "" Then
            MsgBox("配置文件出現問題,請重新下載", 0 + 16)
            Try
                WINI("Load", "text", "TEXT", inipath)
            Catch ex As Exception
                MsgBox("")
            End Try
            Application.Exit()
        Else
            If GINI("CallMode", "Hidewindow", "", inipath) = 0 Then
                RadioButton3.Checked = True
                RadioButton6.Enabled = False
            ElseIf GINI("CallMode", "Hidewindow", "", inipath) = 1 Then
                RadioButton4.Checked = True
            End If
            If GINI("CallMode", "qrcpURL", "", inipath) = 0 Then
                RadioButton1.Checked = True
                Panel1.Enabled = False
            ElseIf GINI("CallMode", "qrcpURL", "", inipath) = 1 Then
                RadioButton2.Checked = True
                Panel1.Enabled = True
                TextBox1.Text = GINI("CallMode", "qrcpURL", "", inipath)
            End If
            If GINI("CallMode", "QrMode", "", inipath) = 0 Then
                RadioButton6.Checked = True
            ElseIf GINI("CallMode", "QrMode", "", inipath) = 1 Then
                RadioButton5.Checked = True
            End If
        End If
    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click, RadioButton4.Click
        If RadioButton4.Checked Then
            RadioButton5.Checked = True
            RadioButton6.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
    End Sub
End Class