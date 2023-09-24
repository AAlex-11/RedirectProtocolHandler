Imports System.Net
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports Microsoft.Win32

'Pay attention that MS Office always redefine protocol binding in key
'Computer\HKEY_CURRENT_USER\Software\Microsoft\Office\Lync\Capabilities\URLAssociations

Public Class StartForm

    Dim ConfigFileName As String
    Dim NewConfig As Boolean
    Dim AllConfigs As New List(Of OneConfig)

    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConfigFileName = IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Config.txt")
        NewConfig = Not My.Computer.FileSystem.FileExists(ConfigFileName)
        If NewConfig Then
            lRow.Text = 0
            txProtocol.Text = "???"
            txUrl.Text = "???"
            txExt.Text = "???"
            txUser.Text = "???"
            txPass.Text = "???"
            txDest.Text = "???"
            btNext.Enabled = False
            btPrev.Enabled = False
            lNew.Visible = True
        Else
            ReadConfig()
            txProtocol.Text = AllConfigs(0).Protocol
            txUrl.Text = AllConfigs(0).Url
            txExt.Text = AllConfigs(0).Ext
            txUser.Text = AllConfigs(0).User
            txPass.Text = AllConfigs(0).Pass
            txDest.Text = "???"
            lRow.Text = 1
            btPrev.Enabled = False
            lNew.Visible = False
        End If
        Me.Height = 500
    End Sub

    Private Async Sub btTest_Click(sender As Object, e As EventArgs) Handles btTest.Click
        Try
            lCode.Text = Await RequestData(lUrl.Text)
        Catch ex As Exception
            lCode.Text = ex.Message
        End Try
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Try
            If lRow.Text = 1 Then
                btPrev.Enabled = False
                btNext.Enabled = True
            ElseIf lRow.Text = 0 Then
                btPrev.Enabled = False
                btNext.Enabled = False
            Else
                btPrev.Enabled = True
                btNext.Enabled = True
            End If
            If lRow.Text = "0" Then
                NewRec()
                lRow.Text = lRow.Text + 1
            ElseIf lRow.Text >= AllConfigs.Count + 1 Then
                NewRec()
            Else
                SaveCurRec()
            End If
            If lRow.Text < AllConfigs.Count + 1 Then
                lRow.Text = lRow.Text + 1
            End If
            DebugPrint()
        Catch ex As Exception
            MsgBox("Exception: " & ex.Message, MsgBoxStyle.OkOnly, "Save error")
        End Try
    End Sub

    Sub NewRec()
        AllConfigs.Add(New OneConfig With {
            .Protocol = txProtocol.Text,
            .Url = txUrl.Text,
            .Ext = txExt.Text,
            .User = txUser.Text,
            .Pass = txPass.Text
        })
        SaveAllToDisk()
        RegisterURLProtocol(txProtocol.Text, IO.Path.Combine(IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "VoipPlus.exe"))
        txProtocol.Text = "???"
        txUrl.Text = "???"
        txExt.Text = "???"
        txUser.Text = "???"
        txPass.Text = "???"
        lNew.Visible = True
        btNext.Enabled = False
        btPrev.Enabled = True
    End Sub

    Sub SaveCurRec()
        AllConfigs(lRow.Text - 1) = New OneConfig With {
         .Protocol = txProtocol.Text,
         .Url = txUrl.Text,
         .Ext = txExt.Text,
         .User = txUser.Text,
         .Pass = txPass.Text
        }
        SaveAllToDisk()
        RegisterURLProtocol(txProtocol.Text, IO.Path.Combine(IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "VoipPlus.exe"))
        If lRow.Text >= AllConfigs.Count Then
            txProtocol.Text = "???"
            txUrl.Text = "???"
            txExt.Text = "???"
            txUser.Text = "???"
            txPass.Text = "???"
            lNew.Visible = True
            btNext.Enabled = False
            btPrev.Enabled = True
        Else
            lNew.Visible = False
            txProtocol.Text = AllConfigs(lRow.Text).Protocol
            txUrl.Text = AllConfigs(lRow.Text).Url
            txExt.Text = AllConfigs(lRow.Text).Ext
            txUser.Text = AllConfigs(lRow.Text).User
            txPass.Text = AllConfigs(lRow.Text).Pass
            btNext.Enabled = True
            btPrev.Enabled = True
        End If

    End Sub

    Sub SaveAllToDisk()
        Dim Str1 As New StringBuilder
        For i As Integer = 0 To AllConfigs.Count - 1
            Str1.AppendLine($"{AllConfigs(i).Protocol},{AllConfigs(i).Url},{AllConfigs(i).Ext},{AllConfigs(i).User},{AllConfigs(i).Pass}")
        Next
        Dim Data() As Byte = System.Text.UTF8Encoding.UTF8.GetBytes(Str1.ToString)
        My.Computer.FileSystem.WriteAllBytes(IO.Path.Combine(IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Config.txt"), Data, False)
    End Sub

    Private Sub btPrev_Click(sender As Object, e As EventArgs) Handles btPrev.Click
        Try
            If lRow.Text <= 1 Then
                btPrev.Enabled = False
                btNext.Enabled = True
            Else
                lRow.Text = lRow.Text - 1
                If lRow.Text = 1 Then
                    btPrev.Enabled = False
                    btNext.Enabled = True
                Else
                    btPrev.Enabled = True
                    btNext.Enabled = True
                End If

            End If
            txProtocol.Text = AllConfigs(lRow.Text - 1).Protocol
            txUrl.Text = AllConfigs(lRow.Text - 1).Url
            txExt.Text = AllConfigs(lRow.Text - 1).Ext
            txUser.Text = AllConfigs(lRow.Text - 1).User
            txPass.Text = AllConfigs(lRow.Text - 1).Pass
            lNew.Visible = False
            DebugPrint()
        Catch ex As Exception
            MsgBox("Exception: " & ex.Message, MsgBoxStyle.OkOnly, "Prev error")
        End Try

    End Sub

    Private Sub btNext_Click(sender As Object, e As EventArgs) Handles btNext.Click
        Try
            If lRow.Text < AllConfigs.Count Then
                lRow.Text = lRow.Text + 1
                txProtocol.Text = AllConfigs(lRow.Text - 1).Protocol
                txUrl.Text = AllConfigs(lRow.Text - 1).Url
                txExt.Text = AllConfigs(lRow.Text - 1).Ext
                txUser.Text = AllConfigs(lRow.Text - 1).User
                txPass.Text = AllConfigs(lRow.Text - 1).Pass
                lNew.Visible = False
                btPrev.Enabled = True
            Else
                txProtocol.Text = "???"
                txUrl.Text = "???"
                txExt.Text = "???"
                txUser.Text = "???"
                txPass.Text = "???"
                lRow.Text = lRow.Text + 1
                btPrev.Enabled = True
                btNext.Enabled = False
                lNew.Visible = True
            End If
            DebugPrint()
        Catch ex As Exception
            MsgBox("Exception: " & ex.Message, MsgBoxStyle.OkOnly, "Next error")
        End Try
    End Sub

    Sub DebugPrint()
        Dim Str1 As New StringBuilder
        For i As Integer = 0 To AllConfigs.Count - 1
            Str1.AppendLine($"{IIf(i + 1 = lRow.Text, ">", " ")}{i + 1}:{AllConfigs(i).Protocol},{AllConfigs(i).Url},{AllConfigs(i).Ext},{AllConfigs(i).User},{AllConfigs(i).Pass}")
        Next
        If lNew.Visible = True Then
            Str1.AppendLine($">")
        End If
        TextBox1.Text = Str1.ToString
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Application.Exit()
    End Sub

    Private Sub txUrl_TextChanged(sender As Object, e As EventArgs) Handles txUrl.TextChanged, txDest.TextChanged, txExt.TextChanged, txUser.TextChanged, txPass.TextChanged
        lUrl.Text = $"http://{txUrl.Text}?ext={txExt.Text}&user={txUser.Text}&pass={txPass.Text}&dest={txDest.Text}"
    End Sub

    Sub ReadConfig()
        Dim ConfigTxt = My.Computer.FileSystem.ReadAllText(ConfigFileName)
        Dim Lines() As String = ConfigTxt.Split(vbLf)
        Array.ForEach(Of String)(Lines, Sub(X)
                                            If Not String.IsNullOrWhiteSpace(X) Then
                                                Dim Y = X.Replace(vbCr, "").Split(",")
                                                If Y.Count <> 5 Then
                                                    MsgBox("Wrong records in config" & vbCrLf & X)
                                                Else
                                                    AllConfigs.Add(New OneConfig With {
                                                        .Protocol = Y(0),
                                                        .Url = Y(1),
                                                        .Ext = Y(2),
                                                        .User = Y(3),
                                                        .Pass = Y(4)
                                                        })
                                                End If
                                            End If
                                        End Sub)
    End Sub
    Async Function RequestData(URL As String) As Task(Of String)
        Try
            Dim Client = New WebClient()
            Dim Html As String = Await Client.DownloadStringTaskAsync(URL)
            Return "OK"
        Catch ex As WebException
            Return ex.Message
        End Try
    End Function

    Public Sub RegisterURLProtocol(ByVal protocolName As String, ByVal applicationPath As String)
        Try
            Dim Classes = Registry.CurrentUser.OpenSubKey("Software", True).OpenSubKey("Classes", True)
            Dim ProtocolKey As RegistryKey = Classes.CreateSubKey(protocolName)
            ProtocolKey.SetValue("URL Protocol", protocolName)
            ProtocolKey.CreateSubKey("shell\open\command").SetValue("", """" & applicationPath & """ """ & "%1""")
        Catch ex As Exception
            MsgBox("Exception: " & ex.Message, MsgBoxStyle.OkOnly, "Protocol registering error")
        End Try
    End Sub

    Private Sub ShowAllCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowAllCheckBox.CheckedChanged
        If ShowAllCheckBox.Checked Then
            Me.Height = 870
            DebugPrint()
        Else
            Me.Height = 500
        End If
    End Sub
End Class

Public Structure OneConfig
    Property Protocol As String
    Property Url As String
    Property Ext As String
    Property User As String
    Property Pass As String
End Structure