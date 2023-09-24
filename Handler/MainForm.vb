Imports System.ComponentModel
Imports System.Configuration
Imports System.Net
Imports System.Reflection
Imports System.Security.Policy
Imports System.Threading
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports VoipPlus.StatusLabelExtension

Public Class MainForm

    'without BackgroundWorker because DownloadStringTaskAsync is awaitable
    'Dim Bg1 As New BackgroundWorker
    'Bg1.RunWorkerAsync()

    Dim ConfigCurrent As New List(Of OneConfig)
    Dim ProtAndUrl() As String
    Private Async Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Await Task.Run(Sub()
        '                   Throw New Exception("test exception")
        '               End Sub)

        Dim Prm() As String = Environment.CommandLine.Split(" ")
        Array.ForEach(Of String)(Prm, Sub(One)
                                          If Not One.Contains("VoipPlus.exe") And Not String.IsNullOrEmpty(One) Then
                                              lUrl.Text = One
                                          End If
                                      End Sub)

        If lUrl.Text <> "NoUrl" Then
            ProtAndUrl = lUrl.Text.Split(":")
            If ProtAndUrl.Count = 2 Then
                lProtocol.Text = ProtAndUrl(0)
            Else
                MsgBox("usage: 'VoipPlus.exe ""procol:url""'", MsgBoxStyle.OkOnly, "Wrong parameters")
                Exit Sub
            End If
        End If

        Try
            Dim ConfigFileName As String = IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Config.txt")
            Dim ConfigTxt = My.Computer.FileSystem.ReadAllText(ConfigFileName)
            Dim Lines() As String = ConfigTxt.Split(vbLf)
            If Lines.Count = 0 Then
                MsgBox("Nothing any records in config, please configure VoipPlus firstly", MsgBoxStyle.OkOnly, "Wrong config file")
                Exit Sub
            Else
                Array.ForEach(Of String)(Lines, Sub(X)
                                                    If Not String.IsNullOrWhiteSpace(X) Then
                                                        Dim Y = X.Replace(vbCr, "").Split(",")
                                                        If Y.Count <> 4 Then
                                                            Throw New Exception("Wrong config file" & vbCrLf & X)
                                                        Else
                                                            ConfigCurrent.Add(New OneConfig With {
                                                                 .Protocol = Y(0),
                                                                 .Url = Y(1),
                                                                 .Ext = Y(2),
                                                                 .User = Y(3),
                                                                 .Pass = Y(4)
                                                                })
                                                        End If
                                                    End If

                                                End Sub)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Wrong config file")
            Exit Sub
        End Try
        If ConfigCurrent.Count = 0 Then Exit Sub
        '
        lUrl.Text = $"http://{ConfigCurrent(0).Url}?ext={ConfigCurrent(0).Ext}&user={ConfigCurrent(0).User}&pass={ConfigCurrent(0).Pass}&dest={ProtAndUrl(1)}"
        If Not CBool(My.Settings.AlwaysVisible) Then Invisible()
        '
        'and finally make request
        '
        Dim Status As String = ""
        Try
            Status = Await RequestData(lUrl.Text)
        Catch ex As Exception
            lCode.Text = ex.Message
            Me.Show()
            Exit Sub
        End Try
        lCode.Text = Status
        If Status <> "" Then ReVisible()
    End Sub

    Sub Invisible()
        Me.Visible = False
        Me.Opacity = 0
        Me.ShowInTaskbar = False
    End Sub

    Sub ReVisible()
        Me.Visible = True
        Me.ShowInTaskbar = True
        Me.Opacity = 1
        Me.Show()
    End Sub
    Async Function RequestData(URL As String) As Task(Of String)
        Try
            Dim Client = New WebClient()
            Dim Html As String = Await Client.DownloadStringTaskAsync(URL)
            Return ""
        Catch ex As WebException
            Return ex.Message
        End Try
    End Function


End Class


Public Structure OneConfig
    Property Protocol As String
    Property Url As String
    Property Ext As String
    Property User As String
    Property Pass As String
End Structure

