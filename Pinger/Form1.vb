Imports System.ComponentModel
Imports System.Text
Imports Newtonsoft.Json
Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions

Partial Public Class Form1
#Disable Warning IDE0044 ' Add read only modifier
    Dim pingInfo1 As New PingInfo
    Dim pingInfo2 As New PingInfo
    Dim pingInfo3 As New PingInfo
    Dim pingInfo4 As New PingInfo
    Dim pingInfo5 As New PingInfo
    Dim pingInfo6 As New PingInfo
    Dim pingInfo7 As New PingInfo
    Dim pingInfo8 As New PingInfo
    Dim pingInfo9 As New PingInfo
    Dim pingInfo10 As New PingInfo
    Dim pingInfo11 As New PingInfo
    Dim pingInfo12 As New PingInfo
    Dim data As String = Application.StartupPath & "\Data_Folder\data.json"
    Private Delegate Sub dlgUpdateStatus(text As String)
#Enable Warning IDE0044 ' Add read only modifier
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(data) = True Then
            Load_settings()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        bgwPing.CancelAsync()
        Threading.Thread.Sleep(100)
        bgwPing.Dispose()
        Threading.Thread.Sleep(200)
        settings.HidePopup()
        NotifyIcon1.Visible = False
        NotifyIcon1.Dispose()
        Threading.Thread.Sleep(100)
        Save_data()
        Me.Dispose()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        bgwPing.RunWorkerAsync()
        NotifyIcon1.Visible = True
    End Sub

    Private Sub Always_was_Top_Toggled(sender As Object, e As EventArgs) Handles Always_was_Top.Toggled
        If Always_was_Top.IsOn = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

#Region "Saving/loading Json File"
    Private Sub Load_settings()

        Dim json As String = File.ReadAllText(data)
        Dim list As List(Of Save_Items) = JsonConvert.DeserializeObject(Of List(Of Save_Items))(json)

        For a As Integer = 0 To list.Count - 1


            Select Case list(a).Id

                Case 1
                    IPAd1.Text = list(a).Ip
                    IpAdName1.Text = list(a).DispalyName
                    Name_set_lbl1.Text = list(a).Settingslblname
                Case 2
                    IPAd2.Text = list(a).Ip
                    IpAdName2.Text = list(a).DispalyName
                    Name_set_lbl2.Text = list(a).Settingslblname
                Case 3
                    IPAd3.Text = list(a).Ip
                    IpAdName3.Text = list(a).DispalyName
                    Name_set_lbl3.Text = list(a).Settingslblname
                Case 4
                    IPAd4.Text = list(a).Ip
                    IpAdName4.Text = list(a).DispalyName
                    Name_set_lbl4.Text = list(a).Settingslblname
                Case 5
                    IPAd5.Text = list(a).Ip
                    IpAdName5.Text = list(a).DispalyName
                    Name_set_lbl5.Text = list(a).Settingslblname
                Case 6
                    IPAd6.Text = list(a).Ip
                    IpAdName6.Text = list(a).DispalyName
                    Name_set_lbl6.Text = list(a).Settingslblname
                Case 7
                    IPAd7.Text = list(a).Ip
                    IpAdName7.Text = list(a).DispalyName
                    Name_set_lbl7.Text = list(a).Settingslblname
                Case 8
                    IPAd8.Text = list(a).Ip
                    IpAdName8.Text = list(a).DispalyName
                    Name_set_lbl8.Text = list(a).Settingslblname
                Case 9
                    IPAd9.Text = list(a).Ip
                    IpAdName9.Text = list(a).DispalyName
                    Name_set_lbl9.Text = list(a).Settingslblname
                Case 10
                    IPAd10.Text = list(a).Ip
                    IpAdName10.Text = list(a).DispalyName
                    Name_set_lbl10.Text = list(a).Settingslblname
                Case 11
                    IPAd11.Text = list(a).Ip
                    IpAdName11.Text = list(a).DispalyName
                    Name_set_lbl11.Text = list(a).Settingslblname
                Case 12
                    IPAd12.Text = list(a).Ip
                    IpAdName12.Text = list(a).DispalyName
                    Name_set_lbl12.Text = list(a).Settingslblname
                Case 13
                    Always_was_Top.IsOn = list(a).AlwaysNoTop
                    PingfqSelc.SelectedIndex = list(a).Pingfq1
                    MswornSelc.SelectedIndex = list(a).MSworn
            End Select
        Next
    End Sub

    Private Sub Save_data()
        Dim list As New List(Of Save_Items)
        For Each c As Control In Me.Controls
#Disable Warning IDE0017 ' Simplify object initialization

            Dim item As New Save_Items

            item.Id = 1
            item.Ip = IPAd1.Text
            item.DispalyName = IpAdName1.Text
            item.Settingslblname = Name_set_lbl1.Text
            list.Add(item)

            item = New Save_Items
            item.Id = 2
            item.Ip = IPAd2.Text
            item.DispalyName = IpAdName2.Text
            item.Settingslblname = Name_set_lbl2.Text
            list.Add(item)

            item = New Save_Items
            item.Id = 3
            item.Ip = IPAd3.Text
            item.DispalyName = IpAdName3.Text
            item.Settingslblname = Name_set_lbl3.Text
            list.Add(item)

            item = New Save_Items
            item.Id = 4
            item.Ip = IPAd4.Text
            item.DispalyName = IpAdName4.Text
            item.Settingslblname = Name_set_lbl4.Text
            list.Add(item)

            item = New Save_Items
            item.Id = 5
            item.Ip = IPAd5.Text
            item.DispalyName = IpAdName5.Text
            item.Settingslblname = Name_set_lbl5.Text
            list.Add(item)

            item = New Save_Items
            item.Id = 6
            item.Ip = IPAd6.Text
            item.DispalyName = IpAdName6.Text
            item.Settingslblname = Name_set_lbl6.Text
            list.Add(item)

            item = New Save_Items
            item.Id = 7
            item.Ip = IPAd7.Text
            item.DispalyName = IpAdName7.Text
            item.Settingslblname = Name_set_lbl7.Text
            list.Add(item)

            item = New Save_Items
            item.Id = 8
            item.Ip = IPAd8.Text
            item.DispalyName = IpAdName8.Text
            item.Settingslblname = Name_set_lbl8.Text
            list.Add(item)

            item = New Save_Items
            item.Id = 9
            item.Ip = IPAd9.Text
            item.DispalyName = IpAdName9.Text
            item.Settingslblname = Name_set_lbl9.Text
            list.Add(item)

            item = New Save_Items
            item.Id = 10
            item.Ip = IPAd10.Text
            item.DispalyName = IpAdName10.Text
            item.Settingslblname = Name_set_lbl10.Text
            list.Add(item)

            item = New Save_Items
            item.Id = 11
            item.Ip = IPAd11.Text
            item.DispalyName = IpAdName11.Text
            item.Settingslblname = Name_set_lbl11.Text
            list.Add(item)


            item = New Save_Items
            item.Id = 12
            item.Ip = IPAd12.Text
            item.DispalyName = IpAdName12.Text
            item.Settingslblname = Name_set_lbl12.Text
            list.Add(item)

            item = New Save_Items
            item.Id = 13
            item.AlwaysNoTop = Always_was_Top.IsOn
            item.Pingfq1 = PingfqSelc.SelectedIndex
            item.MSworn = MswornSelc.SelectedIndex
            list.Add(item)

#Enable Warning IDE0017 ' Simplify object initialization
        Next
        File.WriteAllText(data, JsonConvert.SerializeObject(list))
    End Sub
#End Region

#Region "Background Worker"
    Private Sub UpdateStatus(text As String)
        Dim errormessage As String = ""
        Dim msWorn As Integer = 3

        'The InvokeRequired method returns True if the thread that calls it     
        'is running from a different thread. In that case we create a delegate  
        'to do the update of the control's text otherwise we can update the     
        'text directly.                                                         

        If Lab1_stat.InvokeRequired Then
            Dim dlg As New dlgUpdateStatus(AddressOf UpdateStatus)
            Try
                Me.Invoke(dlg, text)
            Catch ex As Exception

            End Try
        Else
            Select Case MswornSelc.SelectedIndex
                Case 0
                    msWorn = 3
                Case 1
                    msWorn = 4
                Case 2
                    msWorn = 5
                Case 3
                    msWorn = 6
                Case 4
                    msWorn = 7
                Case 5
                    msWorn = 8
                Case 6
                    msWorn = 9
                Case 7
                    msWorn = 10
            End Select

            Select Case workingonip
                Case 1
                    If text.StartsWith("Responding") Then
                        Lab1_stat.ForeColor = Color.Green
                        Lab1_stat.Text = text
                        Lab1_stat.ToolTipTitle = "Ping: " & pingInfo1.HighPing & " |--| " & "Time: " & pingInfo1.HighDate
                        Lab1_stat.ToolTip = "Ping: " & pingInfo1.LowPing & " |--| " & "Time: " & pingInfo1.LowDate
                        If pingInfo1.HighPing > msWorn Then
                            Lab1_stat.ForeColor = Color.Orange
                        ElseIf PingInfo1.HighPing < msWorn Then
                            Lab1_stat.ForeColor = Color.Green
                        End If
                    Else
                        Lab1_stat.ForeColor = Color.Red
                    End If
                    If text <> "Error" Then
                        IP1_lab.Text = IpAdName1.Text
                        IP1_lab.ToolTip = IPAd1.Text
                        TSIPNAME1.Text = IpAdName1.Text
                        TSIPAD1.Text = IPAd1.Text
                        TSPING1.Text = text
                        Lab1_stat.Text = text
                        Stat_PIc1.Image = ImageList1.Images(1)
                    Else
                        IP1_lab.Text = IPAd1.Text
                        IP1_lab.ToolTip = IpAdName1.Text
                        IPAd1.BackColor = Color.Red
                        TSIPAD1.BackColor = Color.Red
                        Stat_PIc1.Image = ImageList1.Images(3)
                    End If

                    If text = "Not Responding" Then
                        IP1_lab.Text = IPAd1.Text
                        IP1_lab.ToolTip = IpAdName1.Text
                        TSIPAD1.Text = IPAd1.Text
                        Lab1_stat.Text = text
                        IPAd1.BackColor = Color.Red
                        TSIPAD1.BackColor = Color.OrangeRed
                        TSPING1.BackColor = Color.LightGray
                        Stat_PIc1.Image = ImageList1.Images(2)
                    End If

                    If text = "Not Set" Then
                        IP1_lab.Text = "0.0.0.0"
                        Lab1_stat.Text = text
                        Lab1_stat.ForeColor = Color.Yellow
                        TSPING1.BackColor = Color.Yellow
                        TSIPAD1.BackColor = Color.LightGray
                        Stat_PIc1.Image = ImageList1.Images(0)
                    End If

                Case 2
                    If text.StartsWith("Responding") Then
                        Lab2_stat.ForeColor = Color.Green
                        Lab2_stat.Text = text
                        Lab2_stat.ToolTipTitle = "Ping: " & pingInfo2.HighPing & " |--| " & "Time: " & pingInfo2.HighDate
                        Lab2_stat.ToolTip = "Ping: " & pingInfo2.LowPing & " |--| " & "Time: " & pingInfo2.LowDate
                        If pingInfo2.HighPing > msWorn Then
                            Lab2_stat.ForeColor = Color.Orange
                        ElseIf PingInfo2.HighPing < msWorn Then
                            Lab2_stat.ForeColor = Color.Green
                        End If
                    Else
                        Lab2_stat.ForeColor = Color.Red
                    End If
                    If text <> "Error" Then
                        IP2_lab.Text = IpAdName2.Text
                        IP2_lab.ToolTip = IPAd2.Text
                        Lab2_stat.Text = text
                        TSIPAD2.Text = IPAd2.Text
                        TSPING2.Text = text
                        TSIPNAME2.Text = IpAdName2.Text
                        Stat_PIc2.Image = ImageList1.Images(1)
                    Else
                        IPAd2.BackColor = Color.Red
                        TSIPAD2.BackColor = Color.Red
                        Stat_PIc2.Image = ImageList1.Images(3)
                    End If

                    If text = "Not Responding" Then
                        IP2_lab.Text = IPAd2.Text
                        IP2_lab.ToolTip = IpAdName2.Text
                        TSIPAD2.Text = IPAd2.Text
                        Lab2_stat.Text = text
                        IPAd2.BackColor = Color.Red
                        TSIPAD2.BackColor = Color.OrangeRed
                        TSPING2.BackColor = Color.LightGray
                        Stat_PIc2.Image = ImageList1.Images(2)
                    End If

                    If text = "Not Set" Then
                        IP2_lab.Text = "0.0.0.0"
                        Lab2_stat.Text = text
                        Lab2_stat.ForeColor = Color.Yellow
                        TSPING2.BackColor = Color.Yellow
                        TSIPAD2.BackColor = Color.LightGray
                        Stat_PIc2.Image = ImageList1.Images(0)
                    End If

                Case 3
                    If text.StartsWith("Responding") Then
                        Lab3_stat.ForeColor = Color.Green
                        Lab3_stat.Text = text
                        Lab3_stat.ToolTipTitle = "Ping: " & pingInfo3.HighPing & " |--| " & "Time: " & pingInfo3.HighDate
                        Lab3_stat.ToolTip = "Ping: " & pingInfo3.LowPing & " |--| " & "Time: " & pingInfo3.LowDate
                        If pingInfo3.HighPing > msWorn Then
                            Lab3_stat.ForeColor = Color.Orange
                        ElseIf PingInfo3.HighPing < msWorn Then
                            Lab3_stat.ForeColor = Color.Green
                        End If
                    Else
                        Lab3_stat.ForeColor = Color.Red
                    End If
                    If text <> "Error" Then
                        IP3_lab.Text = IpAdName3.Text
                        IP3_lab.ToolTip = IPAd3.Text
                        Lab3_stat.Text = text
                        TSIPAD3.Text = IPAd3.Text
                        TSPING3.Text = text
                        TSIPNAME3.Text = IpAdName3.Text
                        Stat_PIc3.Image = ImageList1.Images(1)
                    Else
                        IPAd3.BackColor = Color.Red
                        TSIPAD3.BackColor = Color.Red
                        Stat_PIc3.Image = ImageList1.Images(3)
                    End If

                    If text = "Not Responding" Then
                        IP3_lab.Text = IPAd3.Text
                        IP3_lab.ToolTip = IpAdName3.Text
                        TSIPAD3.Text = IPAd3.Text
                        Lab3_stat.Text = text
                        IPAd3.BackColor = Color.Red
                        TSIPAD3.BackColor = Color.OrangeRed
                        TSPING3.BackColor = Color.LightGray
                        Stat_PIc3.Image = ImageList1.Images(2)
                    End If

                    If text = "Not Set" Then
                        IP3_lab.Text = "0.0.0.0"
                        Lab3_stat.Text = text
                        Lab3_stat.ForeColor = Color.Yellow
                        TSPING3.BackColor = Color.Yellow
                        TSIPAD3.BackColor = Color.LightGray
                        Stat_PIc3.Image = ImageList1.Images(0)
                    End If

                Case 4
                    If text.StartsWith("Responding") Then
                        Lab4_stat.ForeColor = Color.Green
                        Lab4_stat.Text = text
                        Lab4_stat.ToolTipTitle = "Ping: " & pingInfo4.HighPing & " |--| " & "Time: " & pingInfo4.HighDate
                        Lab4_stat.ToolTip = "Ping: " & pingInfo4.LowPing & " |--| " & "Time: " & pingInfo4.LowDate
                        If pingInfo4.HighPing > msWorn Then
                            Lab4_stat.ForeColor = Color.Orange
                        ElseIf PingInfo4.HighPing < msWorn Then
                            Lab4_stat.ForeColor = Color.Green
                        End If
                    Else
                        Lab4_stat.ForeColor = Color.Red
                    End If
                    If text <> "Error" Then
                        IP4_lab.Text = IpAdName4.Text
                        IP4_lab.ToolTip = IPAd4.Text
                        Lab4_stat.Text = text
                        TSIPAD4.Text = IPAd4.Text
                        TSPING4.Text = text
                        TSIPNAME4.Text = IpAdName4.Text
                        Stat_PIc4.Image = ImageList1.Images(1)
                    Else
                        IPAd4.BackColor = Color.Red
                        TSIPAD4.BackColor = Color.Red
                        Stat_PIc4.Image = ImageList1.Images(3)
                    End If

                    If text = "Not Responding" Then
                        IP4_lab.Text = IPAd4.Text
                        IP4_lab.ToolTip = IpAdName4.Text
                        TSIPAD4.Text = IPAd4.Text
                        Lab4_stat.Text = text
                        IPAd4.BackColor = Color.Red
                        TSIPAD4.BackColor = Color.OrangeRed
                        TSPING4.BackColor = Color.LightGray
                        Stat_PIc4.Image = ImageList1.Images(2)
                    End If

                    If text = "Not Set" Then
                        IP4_lab.Text = "0.0.0.0"
                        Lab4_stat.Text = text
                        Lab4_stat.ForeColor = Color.Yellow
                        TSPING4.BackColor = Color.Yellow
                        TSIPAD4.BackColor = Color.LightGray
                        Stat_PIc4.Image = ImageList1.Images(0)
                    End If

                Case 5
                    If text.StartsWith("Responding") Then
                        Lab5_stat.ForeColor = Color.Green
                        Lab5_stat.Text = text
                        Lab5_stat.ToolTipTitle = "Ping: " & pingInfo5.HighPing & " |--| " & "Time: " & pingInfo5.HighDate
                        Lab5_stat.ToolTip = "Ping: " & pingInfo5.LowPing & " |--| " & "Time: " & pingInfo5.LowDate
                        If pingInfo5.HighPing > msWorn Then
                            Lab5_stat.ForeColor = Color.Orange
                        ElseIf PingInfo5.HighPing < msWorn Then
                            Lab5_stat.ForeColor = Color.Green
                        End If
                    Else
                        Lab5_stat.ForeColor = Color.Red
                    End If
                    If text <> "Error" Then
                        IP5_lab.Text = IpAdName5.Text
                        IP5_lab.ToolTip = IPAd5.Text
                        Lab5_stat.Text = text
                        TSIPAD5.Text = IPAd5.Text
                        TSPING5.Text = text
                        TSIPNAME5.Text = IpAdName5.Text
                        Stat_PIc5.Image = ImageList1.Images(1)
                    Else
                        IPAd5.BackColor = Color.Red
                        TSIPAD5.BackColor = Color.Red
                        Stat_PIc5.Image = ImageList1.Images(3)
                    End If

                    If text = "Not Responding" Then
                        IP5_lab.Text = IPAd5.Text
                        IP5_lab.ToolTip = IpAdName5.Text
                        TSIPAD5.Text = IPAd5.Text
                        Lab5_stat.Text = text
                        IPAd5.BackColor = Color.Red
                        TSIPAD5.BackColor = Color.OrangeRed
                        TSPING5.BackColor = Color.LightGray
                        Stat_PIc5.Image = ImageList1.Images(2)
                    End If

                    If text = "Not Set" Then
                        IP5_lab.Text = "0.0.0.0"
                        Lab5_stat.Text = text
                        Lab5_stat.ForeColor = Color.Yellow
                        TSPING5.BackColor = Color.Yellow
                        TSIPAD5.BackColor = Color.LightGray
                        Stat_PIc5.Image = ImageList1.Images(0)
                    End If

                Case 6
                    If text.StartsWith("Responding") Then
                        Lab6_stat.ForeColor = Color.Green
                        Lab6_stat.Text = text
                        Lab6_stat.ToolTipTitle = "Ping: " & pingInfo6.HighPing & " |--| " & "Time: " & pingInfo6.HighDate
                        Lab6_stat.ToolTip = "Ping: " & pingInfo6.LowPing & " |--| " & "Time: " & pingInfo6.LowDate
                        If pingInfo6.HighPing > msWorn Then
                            Lab6_stat.ForeColor = Color.Orange
                        ElseIf PingInfo6.HighPing < msWorn Then
                            Lab6_stat.ForeColor = Color.Green
                        End If
                    Else
                        Lab6_stat.ForeColor = Color.Red
                    End If
                    If text <> "Error" Then
                        IP6_lab.Text = IpAdName6.Text
                        IP6_lab.ToolTip = IPAd6.Text
                        Lab6_stat.Text = text
                        TSIPAD6.Text = IPAd6.Text
                        TSPING6.Text = text
                        TSIPNAME6.Text = IpAdName6.Text
                        Stat_PIc6.Image = ImageList1.Images(1)
                    Else
                        TSIPAD6.BackColor = Color.Red
                        IPAd6.BackColor = Color.Red
                        Stat_PIc6.Image = ImageList1.Images(0)
                    End If

                    If text = "Not Responding" Then
                        IP6_lab.Text = IPAd6.Text
                        IP6_lab.ToolTip = IpAdName6.Text
                        TSIPAD6.Text = IPAd6.Text
                        Lab6_stat.Text = text
                        IPAd6.BackColor = Color.Red
                        TSIPAD6.BackColor = Color.OrangeRed
                        TSPING6.BackColor = Color.LightGray
                        Stat_PIc6.Image = ImageList1.Images(2)
                    End If

                    If text = "Not Set" Then
                        IP6_lab.Text = "0.0.0.0"
                        Lab6_stat.Text = text
                        Lab6_stat.ForeColor = Color.Yellow
                        TSPING6.BackColor = Color.Yellow
                        TSIPAD6.BackColor = Color.LightGray
                        Stat_PIc6.Image = ImageList1.Images(0)
                    End If

                Case 7

                    If text.StartsWith("Responding") Then
                        Lab7_stat.ForeColor = Color.Green
                        Lab7_stat.Text = text
                        Lab7_stat.ToolTipTitle = "Ping: " & pingInfo7.HighPing & " |--| " & "Time: " & pingInfo7.HighDate
                        Lab7_stat.ToolTip = "Ping: " & pingInfo7.LowPing & " |--| " & "Time: " & pingInfo7.LowDate
                        If pingInfo7.HighPing > msWorn Then
                            Lab7_stat.ForeColor = Color.Orange
                        ElseIf PingInfo7.HighPing < msWorn Then
                            Lab7_stat.ForeColor = Color.Green
                        End If
                    Else
                        Lab7_stat.ForeColor = Color.Red
                    End If
                    If text <> "Error" Then
                        IP7_lab.Text = IpAdName7.Text
                        IP7_lab.ToolTip = IPAd7.Text
                        Lab7_stat.Text = text
                        TSIPAD7.Text = IPAd7.Text
                        TSPING7.Text = text
                        TSIPNAME7.Text = IpAdName7.Text
                        Stat_PIc7.Image = ImageList1.Images(1)
                    Else
                        TSIPAD7.BackColor = Color.Red
                        IPAd7.BackColor = Color.Red
                        Stat_PIc7.Image = ImageList1.Images(0)
                    End If

                    If text = "Not Responding" Then
                        IP7_lab.Text = IPAd7.Text
                        IP7_lab.ToolTip = IpAdName7.Text
                        TSIPAD7.Text = IPAd7.Text
                        Lab7_stat.Text = text
                        IPAd7.BackColor = Color.Red
                        TSIPAD7.BackColor = Color.OrangeRed
                        TSPING7.BackColor = Color.LightGray
                        Stat_PIc7.Image = ImageList1.Images(2)
                    End If

                    If text = "Not Set" Then
                        IP7_lab.Text = "0.0.0.0"
                        Lab7_stat.Text = text
                        Lab7_stat.ForeColor = Color.Yellow
                        TSPING7.BackColor = Color.Yellow
                        TSIPAD7.BackColor = Color.LightGray
                        Stat_PIc7.Image = ImageList1.Images(0)
                    End If

                Case 8

                    If text.StartsWith("Responding") Then
                        Lab8_stat.ForeColor = Color.Green
                        Lab8_stat.Text = text
                        Lab8_stat.ToolTipTitle = "Ping: " & pingInfo8.HighPing & " |--| " & "Time: " & pingInfo8.HighDate
                        Lab8_stat.ToolTip = "Ping: " & pingInfo8.LowPing & " |--| " & "Time: " & pingInfo8.LowDate
                        If pingInfo8.HighPing > msWorn Then
                            Lab8_stat.ForeColor = Color.Orange
                        ElseIf PingInfo8.HighPing < msWorn Then
                            Lab8_stat.ForeColor = Color.Green
                        End If
                    Else
                        Lab8_stat.ForeColor = Color.Red
                    End If
                    If text <> "Error" Then
                        IP8_lab.Text = IpAdName8.Text
                        IP8_lab.ToolTip = IPAd8.Text
                        Lab8_stat.Text = text
                        TSIPAD8.Text = IPAd8.Text
                        TSPING8.Text = text
                        TSIPNAME8.Text = IpAdName8.Text
                        Stat_PIc8.Image = ImageList1.Images(1)
                    Else
                        TSIPAD8.BackColor = Color.Red
                        IPAd8.BackColor = Color.Red
                        Stat_PIc8.Image = ImageList1.Images(0)
                    End If

                    If text = "Not Responding" Then
                        IP8_lab.Text = IpAdName8.Text
                        IP8_lab.ToolTip = IPAd1.Text
                        TSIPAD8.Text = IPAd8.Text
                        Lab8_stat.Text = text
                        IPAd8.BackColor = Color.Red
                        TSIPAD8.BackColor = Color.OrangeRed
                        TSPING8.BackColor = Color.LightGray
                        Stat_PIc8.Image = ImageList1.Images(2)
                    End If

                    If text = "Not Set" Then
                        IP8_lab.Text = "0.0.0.0"
                        Lab8_stat.Text = text
                        Lab8_stat.ForeColor = Color.Yellow
                        TSPING8.BackColor = Color.Yellow
                        TSIPAD8.BackColor = Color.LightGray
                        Stat_PIc8.Image = ImageList1.Images(0)
                    End If

                Case 9

                    If text.StartsWith("Responding") Then
                        Lab9_stat.ForeColor = Color.Green
                        Lab9_stat.Text = text
                        Lab9_stat.ToolTipTitle = "Ping: " & pingInfo9.HighPing & " |--| " & "Time: " & pingInfo9.HighDate
                        Lab9_stat.ToolTip = "Ping: " & pingInfo9.LowPing & " |--| " & "Time: " & pingInfo9.LowDate
                        If pingInfo9.HighPing > msWorn Then
                            Lab9_stat.ForeColor = Color.Orange
                        ElseIf PingInfo9.HighPing < msWorn Then
                            Lab9_stat.ForeColor = Color.Green
                        End If
                    Else
                        Lab9_stat.ForeColor = Color.Red
                    End If
                    If text <> "Error" Then
                        IP9_lab.Text = IpAdName9.Text
                        IP9_lab.ToolTip = IPAd9.Text
                        Lab9_stat.Text = text
                        TSIPAD9.Text = IPAd9.Text
                        TSPING9.Text = text
                        TSIPNAME9.Text = IpAdName9.Text
                        Stat_PIc9.Image = ImageList1.Images(1)
                    Else
                        TSIPAD9.BackColor = Color.Red
                        IPAd9.BackColor = Color.Red
                        Stat_PIc9.Image = ImageList1.Images(0)
                    End If

                    If text = "Not Responding" Then
                        IP9_lab.Text = IPAd9.Text
                        IP9_lab.ToolTip = IpAdName9.Text
                        TSIPAD9.Text = IPAd9.Text
                        Lab9_stat.Text = text
                        IPAd9.BackColor = Color.Red
                        TSIPAD9.BackColor = Color.OrangeRed
                        TSPING9.BackColor = Color.LightGray
                        Stat_PIc9.Image = ImageList1.Images(2)
                    End If

                    If text = "Not Set" Then
                        IP9_lab.Text = "0.0.0.0"
                        Lab9_stat.Text = text
                        Lab9_stat.ForeColor = Color.Yellow
                        TSPING9.BackColor = Color.Yellow
                        TSIPAD9.BackColor = Color.LightGray
                        Stat_PIc9.Image = ImageList1.Images(0)
                    End If

                Case 10

                    If text.StartsWith("Responding") Then
                        Lab10_stat.ForeColor = Color.Green
                        Lab10_stat.Text = text
                        Lab10_stat.ToolTipTitle = "Ping: " & pingInfo10.HighPing & " |--| " & "Time: " & pingInfo10.HighDate
                        Lab10_stat.ToolTip = "Ping: " & pingInfo10.LowPing & " |--| " & "Time: " & pingInfo10.LowDate
                        If pingInfo10.HighPing > msWorn Then
                            Lab10_stat.ForeColor = Color.Orange
                        ElseIf PingInfo10.HighPing < msWorn Then
                            Lab10_stat.ForeColor = Color.Green
                        End If
                    Else
                        Lab10_stat.ForeColor = Color.Red
                    End If
                    If text <> "Error" Then
                        IP10_lab.Text = IpAdName10.Text
                        IP10_lab.ToolTip = IPAd10.Text
                        Lab10_stat.Text = text
                        TSIPAD10.Text = IPAd10.Text
                        TSPING10.Text = text
                        TSIPNAME10.Text = IpAdName10.Text
                        Stat_PIc10.Image = ImageList1.Images(1)
                    Else
                        TSIPAD10.BackColor = Color.Red
                        IPAd10.BackColor = Color.Red
                        Stat_PIc10.Image = ImageList1.Images(0)
                    End If

                    If text = "Not Responding" Then
                        IP10_lab.Text = IPAd10.Text
                        IP10_lab.ToolTip = IpAdName10.Text
                        TSIPAD10.Text = IPAd10.Text
                        Lab10_stat.Text = text
                        IPAd10.BackColor = Color.Red
                        TSIPAD10.BackColor = Color.OrangeRed
                        TSPING10.BackColor = Color.LightGray
                        Stat_PIc10.Image = ImageList1.Images(2)
                    End If

                    If text = "Not Set" Then
                        IP10_lab.Text = "0.0.0.0"
                        Lab10_stat.Text = text
                        Lab10_stat.ForeColor = Color.Yellow
                        TSPING10.BackColor = Color.Yellow
                        TSIPAD10.BackColor = Color.LightGray
                        Stat_PIc10.Image = ImageList1.Images(0)
                    End If

                Case 11

                    If text.StartsWith("Responding") Then
                        Lab11_stat.ForeColor = Color.Green
                        Lab11_stat.Text = text
                        Lab11_stat.ToolTipTitle = "Ping: " & pingInfo11.HighPing & " |--| " & "Time: " & pingInfo11.HighDate
                        Lab11_stat.ToolTip = "Ping: " & pingInfo11.LowPing & " |--| " & "Time: " & pingInfo11.LowDate
                        If pingInfo11.HighPing > msWorn Then
                            Lab11_stat.ForeColor = Color.Orange
                        ElseIf PingInfo11.HighPing < msWorn Then
                            Lab11_stat.ForeColor = Color.Green
                        End If
                    Else
                        Lab11_stat.ForeColor = Color.Red
                    End If
                    If text <> "Error" Then
                        IP11_lab.Text = IpAdName11.Text
                        IP11_lab.ToolTip = IPAd11.Text
                        Lab11_stat.Text = text
                        TSIPAD11.Text = IPAd11.Text
                        TSPING11.Text = text
                        TSIPNAME11.Text = IpAdName11.Text
                        Stat_PIc11.Image = ImageList1.Images(1)
                    Else
                        TSIPAD11.BackColor = Color.Red
                        IPAd11.BackColor = Color.Red
                        Stat_PIc11.Image = ImageList1.Images(0)
                    End If

                    If text = "Not Responding" Then
                        IP11_lab.Text = IPAd11.Text
                        IP11_lab.ToolTip = IpAdName11.Text
                        TSIPAD11.Text = IPAd11.Text
                        Lab11_stat.Text = text
                        IPAd11.BackColor = Color.Red
                        TSIPAD11.BackColor = Color.OrangeRed
                        TSPING11.BackColor = Color.LightGray
                        Stat_PIc11.Image = ImageList1.Images(2)
                    End If

                    If text = "Not Set" Then
                        IP11_lab.Text = "0.0.0.0"
                        Lab11_stat.Text = text
                        Lab11_stat.ForeColor = Color.Yellow
                        TSPING11.BackColor = Color.Yellow
                        TSIPAD11.BackColor = Color.LightGray
                        Stat_PIc11.Image = ImageList1.Images(0)
                    End If

                Case 12

                    If text.StartsWith("Responding") Then
                        Lab12_stat.ForeColor = Color.Green
                        Lab12_stat.Text = text
                        Lab12_stat.ToolTipTitle = "Ping: " & pingInfo12.HighPing & " |--| " & "Time: " & pingInfo12.HighDate
                        Lab12_stat.ToolTip = "Ping: " & pingInfo12.LowPing & " |--| " & "Time: " & pingInfo12.LowDate
                        If pingInfo12.HighPing > msWorn Then
                            Lab12_stat.ForeColor = Color.Orange
                        ElseIf PingInfo12.HighPing < msWorn Then
                            Lab12_stat.ForeColor = Color.Green
                        End If
                    Else
                        Lab12_stat.ForeColor = Color.Red
                    End If
                    If text <> "Error" Then
                        IP12_lab.Text = IpAdName12.Text
                        IP12_lab.ToolTip = IPAd12.Text
                        Lab12_stat.Text = text
                        TSIPAD12.Text = IPAd12.Text
                        TSPING12.Text = text
                        TSIPNAME12.Text = IpAdName12.Text
                        Stat_PIc12.Image = ImageList1.Images(1)
                    Else
                        TSIPAD12.BackColor = Color.Red
                        IPAd12.BackColor = Color.Red
                        Stat_PIc12.Image = ImageList1.Images(0)
                    End If

                    If text = "Not Responding" Then
                        IP12_lab.Text = IPAd12.Text
                        IP12_lab.ToolTip = IpAdName12.Text
                        TSIPAD12.Text = IPAd12.Text
                        Lab12_stat.Text = text
                        IPAd12.BackColor = Color.Red
                        TSIPAD12.BackColor = Color.OrangeRed
                        TSPING12.BackColor = Color.LightGray
                        Stat_PIc12.Image = ImageList1.Images(2)
                    End If

                    If text = "Not Set" Then
                        IP12_lab.Text = "0.0.0.0"
                        Lab12_stat.Text = text
                        Lab12_stat.ForeColor = Color.Yellow
                        TSPING12.BackColor = Color.Yellow
                        TSIPAD12.BackColor = Color.LightGray
                        Stat_PIc12.Image = ImageList1.Images(0)
                    End If

                Case 100
                    If text = "Stopped" Then
                        MsgBox("One or more ip's could not be pinged! Stopping all ping requests", MsgBoxStyle.Critical)
                        '      bgwPing.CancelAsync()
                    End If

            End Select
        End If

        Try
            lp_lbl.Text = TimeOfDay.ToString("hh:mm:ss tt")
        Catch ex As Exception

        End Try
    End Sub
    Dim workingonip As Integer = 0

    Private Sub BgwPing_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwPing.DoWork
        Dim workingon As String = "Setting UP"
        Do
            Dim ip As Net.IPAddress = Nothing
            Dim ping As New Net.NetworkInformation.Ping


            'If the foreground thread requested a cancellation then set the     
            'appropriate flag and exit the loop.                                

            If bgwPing.CancellationPending Then
                e.Cancel = True
                Exit Do
            End If

            'do the ping and update the status label

            Try
                If IPAd1.Text = Nothing Then
                    workingonip = 1
                    UpdateStatus("Not Set")
                Else
                    workingon = IPAd1.Text
                    If IPAddress.TryParse(IPAd1.Text, ip) = True Then
                        If My.Computer.Network.Ping(IPAd1.Text) Then
                            workingonip = 1

                            Dim pingtime As Long = ping.Send(IPAd1.Text).RoundtripTime

                            If pingInfo1.HighPing < pingtime Then
                                pingInfo1.HighPing = pingtime
                                pingInfo1.HighDate = Now
                            End If

                            If pingInfo1.LowPing > pingtime Then
                                pingInfo1.LowPing = pingtime
                                pingInfo1.LowDate = Now
                            End If

                            UpdateStatus("Responding " & pingtime.ToString & "ms")
                        Else
                            workingonip = 1
                            UpdateStatus("Not Responding")
                        End If
                    Else
                        workingonip = 1
                        UpdateStatus("Error")
                    End If
                End If


                If IPAd2.Text = Nothing Then
                    workingonip = 2
                    UpdateStatus("Not Set")
                Else

                    If IPAddress.TryParse(IPAd2.Text, ip) = True Then
                        If My.Computer.Network.Ping(IPAd2.Text) Then
                            workingonip = 2

                            Dim pingtime As Long = ping.Send(IPAd2.Text).RoundtripTime

                            If pingInfo2.HighPing < pingtime Then
                                pingInfo2.HighPing = pingtime
                                pingInfo2.HighDate = Now
                            End If

                            If pingInfo2.LowPing > pingtime Then
                                pingInfo2.LowPing = pingtime
                                pingInfo2.LowDate = Now
                            End If

                            UpdateStatus("Responding " & pingtime.ToString & "ms")
                        Else
                            workingonip = 2
                            UpdateStatus("Not Responding")
                        End If
                    Else
                        workingonip = 2
                        UpdateStatus("Error")
                    End If
                End If

                If IPAd3.Text = Nothing Then
                    workingonip = 3
                    UpdateStatus("Not Set")
                Else
                    If IPAddress.TryParse(IPAd3.Text, ip) = True Then
                        If My.Computer.Network.Ping(IPAd3.Text) Then
                            workingonip = 3

                            Dim pingtime As Long = ping.Send(IPAd3.Text).RoundtripTime

                            If pingInfo3.HighPing < pingtime Then
                                pingInfo3.HighPing = pingtime
                                pingInfo3.HighDate = Now
                            End If

                            If pingInfo3.LowPing > pingtime Then
                                pingInfo3.LowPing = pingtime
                                pingInfo3.LowDate = Now
                            End If

                            UpdateStatus("Responding " & pingtime.ToString & "ms")
                        Else
                            workingonip = 3
                            UpdateStatus("Not Responding")
                        End If
                    Else
                        workingonip = 3
                        UpdateStatus("Error")
                    End If
                End If

                If IPAd4.Text = Nothing Then
                    workingonip = 4
                    UpdateStatus("Not Set")
                Else
                    If IPAddress.TryParse(IPAd4.Text, ip) = True Then
                        If My.Computer.Network.Ping(IPAd4.Text) Then
                            workingonip = 4

                            Dim pingtime As Long = ping.Send(IPAd4.Text).RoundtripTime

                            If pingInfo4.HighPing < pingtime Then
                                pingInfo4.HighPing = pingtime
                                pingInfo4.HighDate = Now
                            End If

                            If pingInfo4.LowPing > pingtime Then
                                pingInfo4.LowPing = pingtime
                                pingInfo4.LowDate = Now
                            End If

                            UpdateStatus("Responding " & pingtime.ToString & "ms")
                        Else
                            workingonip = 4
                            UpdateStatus("Not Responding")
                        End If
                    Else
                        workingonip = 4
                        UpdateStatus("Error")
                    End If
                End If

                If IPAd5.Text = Nothing Then
                    workingonip = 5
                    UpdateStatus("Not Set")
                Else
                    If IPAddress.TryParse(IPAd5.Text, ip) = True Then
                        If My.Computer.Network.Ping(IPAd5.Text) Then
                            workingonip = 5

                            Dim pingtime As Long = ping.Send(IPAd5.Text).RoundtripTime

                            If pingInfo5.HighPing < pingtime Then
                                pingInfo5.HighPing = pingtime
                                pingInfo5.HighDate = Now
                            End If

                            If pingInfo5.LowPing > pingtime Then
                                pingInfo5.LowPing = pingtime
                                pingInfo5.LowDate = Now
                            End If

                            UpdateStatus("Responding " & pingtime.ToString & "ms")
                        Else
                            workingonip = 5
                            UpdateStatus("Not Responding")
                        End If
                    Else
                        workingonip = 5
                        UpdateStatus("Error")
                    End If
                End If

                If IPAd6.Text = Nothing Then
                    workingonip = 6
                    UpdateStatus("Not Set")
                Else
                    If IPAddress.TryParse(IPAd6.Text, ip) = True Then
                        If My.Computer.Network.Ping(IPAd6.Text) Then
                            workingonip = 6

                            Dim pingtime As Long = ping.Send(IPAd6.Text).RoundtripTime

                            If pingInfo6.HighPing < pingtime Then
                                pingInfo6.HighPing = pingtime
                                pingInfo6.HighDate = Now
                            End If

                            If pingInfo6.LowPing > pingtime Then
                                pingInfo6.LowPing = pingtime
                                pingInfo6.LowDate = Now
                            End If

                            UpdateStatus("Responding " & pingtime.ToString & "ms")
                        Else
                            workingonip = 6
                            UpdateStatus("Not Responding")
                        End If
                    Else
                        workingonip = 6
                        UpdateStatus("Error")
                    End If
                End If

                If IPAd7.Text = Nothing Then
                    workingonip = 7
                    UpdateStatus("Not Set")
                Else
                    If IPAddress.TryParse(IPAd7.Text, ip) = True Then
                        If My.Computer.Network.Ping(IPAd7.Text) Then
                            workingonip = 7

                            Dim pingtime As Long = ping.Send(IPAd7.Text).RoundtripTime

                            If pingInfo7.HighPing < pingtime Then
                                pingInfo7.HighPing = pingtime
                                pingInfo7.HighDate = Now
                            End If

                            If pingInfo7.LowPing > pingtime Then
                                pingInfo7.LowPing = pingtime
                                pingInfo7.LowDate = Now
                            End If

                            UpdateStatus("Responding " & pingtime.ToString & "ms")
                        Else
                            workingonip = 7
                            UpdateStatus("Not Responding")
                        End If
                    Else
                        workingonip = 7
                        UpdateStatus("Error")
                    End If
                End If


                If IPAd8.Text = Nothing Then
                    workingonip = 8
                    UpdateStatus("Not Set")
                Else

                    If IPAddress.TryParse(IPAd8.Text, ip) = True Then
                        If My.Computer.Network.Ping(IPAd8.Text) Then
                            workingonip = 8

                            Dim pingtime As Long = ping.Send(IPAd8.Text).RoundtripTime

                            If pingInfo8.HighPing < pingtime Then
                                pingInfo8.HighPing = pingtime
                                pingInfo8.HighDate = Now
                            End If

                            If pingInfo8.LowPing > pingtime Then
                                pingInfo8.LowPing = pingtime
                                pingInfo8.LowDate = Now
                            End If

                            UpdateStatus("Responding " & pingtime.ToString & "ms")
                        Else
                            workingonip = 8
                            UpdateStatus("Not Responding")
                        End If
                    Else
                        workingonip = 8
                        UpdateStatus("Error")
                    End If
                End If

                If IPAd9.Text = Nothing Then
                    workingonip = 9
                    UpdateStatus("Not Set")
                Else
                    If IPAddress.TryParse(IPAd9.Text, ip) = True Then
                        If My.Computer.Network.Ping(IPAd9.Text) Then
                            workingonip = 9

                            Dim pingtime As Long = ping.Send(IPAd9.Text).RoundtripTime

                            If pingInfo9.HighPing < pingtime Then
                                pingInfo9.HighPing = pingtime
                                pingInfo9.HighDate = Now
                            End If

                            If pingInfo9.LowPing > pingtime Then
                                pingInfo9.LowPing = pingtime
                                pingInfo9.LowDate = Now
                            End If

                            UpdateStatus("Responding " & pingtime.ToString & "ms")
                        Else
                            workingonip = 9
                            UpdateStatus("Not Responding")
                        End If
                    Else
                        workingonip = 9
                        UpdateStatus("Error")
                    End If
                End If

                If IPAd10.Text = Nothing Then
                    workingonip = 10
                    UpdateStatus("Not Set")
                Else
                    If IPAddress.TryParse(IPAd10.Text, ip) = True Then
                        If My.Computer.Network.Ping(IPAd10.Text) Then
                            workingonip = 10

                            Dim pingtime As Long = ping.Send(IPAd10.Text).RoundtripTime

                            If pingInfo10.HighPing < pingtime Then
                                pingInfo10.HighPing = pingtime
                                pingInfo10.HighDate = Now
                            End If

                            If pingInfo10.LowPing > pingtime Then
                                pingInfo10.LowPing = pingtime
                                pingInfo10.LowDate = Now
                            End If

                            UpdateStatus("Responding " & pingtime.ToString & "ms")
                        Else
                            workingonip = 10
                            UpdateStatus("Not Responding")
                        End If
                    Else
                        workingonip = 10
                        UpdateStatus("Error")
                    End If
                End If

                If IPAd11.Text = Nothing Then
                    workingonip = 11
                    UpdateStatus("Not Set")
                Else
                    If IPAddress.TryParse(IPAd11.Text, ip) = True Then
                        If My.Computer.Network.Ping(IPAd11.Text) Then

                            workingonip = 11

                            Dim pingtime As Long = ping.Send(IPAd11.Text).RoundtripTime

                            If pingInfo11.HighPing < pingtime Then
                                pingInfo11.HighPing = pingtime
                                pingInfo11.HighDate = Now
                            End If

                            If pingInfo11.LowPing > pingtime Then
                                pingInfo11.LowPing = pingtime
                                pingInfo11.LowDate = Now
                            End If

                            UpdateStatus("Responding " & pingtime.ToString & "ms")
                        Else
                            workingonip = 11
                            UpdateStatus("Not Responding")
                        End If
                    Else
                        workingonip = 11
                        UpdateStatus("Error")
                    End If
                End If

                If IPAd12.Text = Nothing Then
                    workingonip = 12
                    UpdateStatus("Not Set")
                Else
                    If IPAddress.TryParse(IPAd12.Text, ip) = True Then
                        If My.Computer.Network.Ping(IPAd12.Text) Then
                            workingonip = 12

                            Dim pingtime As Long = ping.Send(IPAd12.Text).RoundtripTime

                            If pingInfo12.HighPing < pingtime Then
                                pingInfo12.HighPing = pingtime
                                pingInfo12.HighDate = Now
                            End If

                            If pingInfo12.LowPing > pingtime Then
                                pingInfo12.LowPing = pingtime
                                pingInfo12.LowDate = Now
                            End If

                            UpdateStatus("Responding " & pingtime.ToString & "ms")
                        Else
                            workingonip = 12
                            UpdateStatus("Not Responding")
                        End If
                    Else
                        workingonip = 12
                        UpdateStatus("Error")
                    End If
                End If

            Catch ex As Exception
                MsgBox("Their has been an error with IP Address: " & workingon & vbNewLine & "Error Message: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "IP Address Error")
                workingonip = 100
                '   UpdateStatus("Stopped")
            End Try
            Dim sleepint As Integer = 5000
            'suspend for user selected time (5 Sec is default) before the next ping
            Select Case PingfqSelc.SelectedIndex

                Case 0
                    sleepint = 5000
                Case 1
                    sleepint = 10000
                Case 2
                    sleepint = 15000
                Case 3
                    sleepint = 20000

            End Select

            System.Threading.Thread.Sleep(sleepint)

        Loop
    End Sub
#End Region

#Region "Edit Region"
    Private Sub Edit_but_Click(sender As Object, e As EventArgs) Handles Edit_but.Click
        bgwPing.CancelAsync()
        IPAd1.ReadOnly = False
        IPAd2.ReadOnly = False
        IPAd3.ReadOnly = False
        IPAd4.ReadOnly = False
        IPAd5.ReadOnly = False
        IPAd6.ReadOnly = False
        IPAd7.ReadOnly = False
        IPAd8.ReadOnly = False
        IPAd9.ReadOnly = False
        IPAd10.ReadOnly = False
        IPAd11.ReadOnly = False
        IPAd12.ReadOnly = False
        IPAd1.BackColor = Color.White
        IPAd2.BackColor = Color.White
        IPAd3.BackColor = Color.White
        IPAd4.BackColor = Color.White
        IPAd5.BackColor = Color.White
        IPAd6.BackColor = Color.White
        IPAd7.BackColor = Color.White
        IPAd8.BackColor = Color.White
        IPAd9.BackColor = Color.White
        IPAd10.BackColor = Color.White
        IPAd11.BackColor = Color.White
        IPAd12.BackColor = Color.White
        Edit_but.Enabled = False
        Start_But_Info.Visible = True
        Start_but.Enabled = True
        MswornSelc.Enabled = True
    End Sub

    Private Sub Start_but_Click(sender As Object, e As EventArgs) Handles Start_but.Click

        Dim rx As New Regex("^(?:(?:25[0-5]|2[0-4]\d|[01]\d\d|\d?\d)(?(?=\.?\d)\.)){4}$")

        If Not IPAd1.Text = "" And Not rx.IsMatch(IPAd1.Text) Then
            error_lbl.Visible = True
            IPAd1.BackColor = Color.Red
            ValiAD1.Image = ImageList1.Images(5)
            IPAd1.SelectAll()
            Exit Sub
        End If

        If Not IPAd2.Text = "" And Not rx.IsMatch(IPAd2.Text) Then
            error_lbl.Visible = True
            IPAd2.BackColor = Color.Red
            ValiAD2.Image = ImageList1.Images(5)
            IPAd2.SelectAll()
            Exit Sub
        End If

        If Not IPAd3.Text = "" And Not rx.IsMatch(IPAd3.Text) Then
            error_lbl.Visible = True
            IPAd3.BackColor = Color.Red
            ValiAD3.Image = ImageList1.Images(5)
            IPAd3.SelectAll()
            Exit Sub
        End If

        If Not IPAd4.Text = "" And Not rx.IsMatch(IPAd4.Text) Then
            error_lbl.Visible = True
            IPAd4.BackColor = Color.Red
            ValiAD4.Image = ImageList1.Images(5)
            IPAd4.SelectAll()
            Exit Sub
        End If

        If Not IPAd5.Text = "" And Not rx.IsMatch(IPAd5.Text) Then
            error_lbl.Visible = True
            IPAd5.BackColor = Color.Red
            ValiAD5.Image = ImageList1.Images(5)
            IPAd5.SelectAll()
            Exit Sub
        End If

        If Not IPAd6.Text = "" And Not rx.IsMatch(IPAd6.Text) Then
            error_lbl.Visible = True
            IPAd6.BackColor = Color.Red
            ValiAD6.Image = ImageList1.Images(5)
            IPAd6.SelectAll()
            Exit Sub
        End If

        If Not IPAd7.Text = "" And Not rx.IsMatch(IPAd7.Text) Then
            error_lbl.Visible = True
            IPAd7.BackColor = Color.Red
            ValiAD7.Image = ImageList1.Images(5)
            IPAd7.SelectAll()
            Exit Sub
        End If

        If Not IPAd8.Text = "" And Not rx.IsMatch(IPAd8.Text) Then
            error_lbl.Visible = True
            IPAd8.BackColor = Color.Red
            ValiAD8.Image = ImageList1.Images(5)
            IPAd8.SelectAll()
            Exit Sub
        End If

        If Not IPAd9.Text = "" And Not rx.IsMatch(IPAd9.Text) Then
            error_lbl.Visible = True
            IPAd9.BackColor = Color.Red
            ValiAD9.Image = ImageList1.Images(5)
            IPAd9.SelectAll()
            Exit Sub
        End If

        If Not IPAd10.Text = "" And Not rx.IsMatch(IPAd10.Text) Then
            error_lbl.Visible = True
            IPAd10.BackColor = Color.Red
            ValiAD10.Image = ImageList1.Images(5)
            IPAd10.SelectAll()
            Exit Sub
        End If

        If Not IPAd11.Text = "" And Not rx.IsMatch(IPAd11.Text) Then
            error_lbl.Visible = True
            IPAd11.BackColor = Color.Red
            ValiAD11.Image = ImageList1.Images(5)
            IPAd11.SelectAll()
            Exit Sub
        End If

        If Not IPAd12.Text = "" And Not rx.IsMatch(IPAd12.Text) Then
            error_lbl.Visible = True
            IPAd12.BackColor = Color.Red
            ValiAD12.Image = ImageList1.Images(5)
            IPAd12.SelectAll()
            Exit Sub
        End If

        bgwPing.RunWorkerAsync()
        IPAd1.ReadOnly = True
        IPAd2.ReadOnly = True
        IPAd3.ReadOnly = True
        IPAd4.ReadOnly = True
        IPAd5.ReadOnly = True
        IPAd6.ReadOnly = True
        IPAd7.ReadOnly = True
        IPAd8.ReadOnly = True
        IPAd9.ReadOnly = True
        IPAd10.ReadOnly = True
        IPAd11.ReadOnly = True
        IPAd12.ReadOnly = True
        Edit_but.Enabled = True
        ValiAD1.Image = Nothing
        ValiAD2.Image = Nothing
        ValiAD3.Image = Nothing
        ValiAD4.Image = Nothing
        ValiAD5.Image = Nothing
        ValiAD6.Image = Nothing
        ValiAD7.Image = Nothing
        ValiAD8.Image = Nothing
        ValiAD9.Image = Nothing
        ValiAD10.Image = Nothing
        ValiAD11.Image = Nothing
        ValiAD12.Image = Nothing
        IPAd1.BackColor = Color.Gainsboro
        IPAd2.BackColor = Color.Gainsboro
        IPAd3.BackColor = Color.Gainsboro
        IPAd4.BackColor = Color.Gainsboro
        IPAd5.BackColor = Color.Gainsboro
        IPAd6.BackColor = Color.Gainsboro
        IPAd7.BackColor = Color.Gainsboro
        IPAd8.BackColor = Color.Gainsboro
        IPAd9.BackColor = Color.Gainsboro
        IPAd10.BackColor = Color.Gainsboro
        IPAd11.BackColor = Color.Gainsboro
        IPAd12.BackColor = Color.Gainsboro
        Start_But_Info.Visible = False
        Start_but.Enabled = False
        error_lbl.Visible = False
        MswornSelc.Enabled = False
    End Sub
#End Region

#Region "Change IP Address Name / Clear Ip address and name"
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        settings.HidePopup()
    End Sub

    Private Sub Change_name_but_Ok_Click(sender As Object, e As EventArgs) Handles Change_name_but_Ok.Click

        If Ipname_set1.Text = Nothing Then
            IpAdName1.Text = IpAdName1.Text
        Else
            IpAdName1.Text = Ipname_set1.Text
        End If

        If Ipname_set2.Text = Nothing Then
            IpAdName2.Text = IpAdName2.Text
        Else
            IpAdName2.Text = Ipname_set2.Text
        End If

        If Ipname_set3.Text = Nothing Then
            IpAdName3.Text = IpAdName3.Text
        Else
            IpAdName3.Text = Ipname_set3.Text
        End If

        If Ipname_set4.Text = Nothing Then
            IpAdName4.Text = IpAdName4.Text
        Else
            IpAdName4.Text = Ipname_set4.Text
        End If

        If Ipname_set5.Text = Nothing Then
            IpAdName5.Text = IpAdName5.Text
        Else
            IpAdName5.Text = Ipname_set5.Text
        End If

        If Ipname_set6.Text = Nothing Then
            IpAdName6.Text = IpAdName6.Text
        Else
            IpAdName6.Text = Ipname_set6.Text
        End If

        If Ipname_set7.Text = Nothing Then
            IpAdName7.Text = IpAdName7.Text
        Else
            IpAdName7.Text = Ipname_set7.Text
        End If

        If Ipname_set8.Text = Nothing Then
            IpAdName8.Text = IpAdName8.Text
        Else
            IpAdName8.Text = Ipname_set8.Text
        End If

        If Ipname_set9.Text = Nothing Then
            IpAdName9.Text = IpAdName9.Text
        Else
            IpAdName9.Text = Ipname_set9.Text
        End If

        If Ipname_set10.Text = Nothing Then
            IpAdName10.Text = IpAdName10.Text
        Else
            IpAdName10.Text = Ipname_set10.Text
        End If

        If Ipname_set11.Text = Nothing Then
            IpAdName11.Text = IpAdName11.Text
        Else
            IpAdName11.Text = Ipname_set11.Text
        End If

        If Ipname_set12.Text = Nothing Then
            IpAdName12.Text = IpAdName12.Text
        Else
            IpAdName12.Text = Ipname_set12.Text
        End If

        settings.HidePopup()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        IpAdName1.Text = "IP Address 1:"
        IpAdName2.Text = "IP Address 2:"
        IpAdName3.Text = "IP Address 3:"
        IpAdName4.Text = "IP Address 4:"
        IpAdName5.Text = "IP Address 5:"
        IpAdName6.Text = "IP Address 6:"
        IpAdName7.Text = "IP Address 7:"
        IpAdName8.Text = "IP Address 8:"
        IpAdName9.Text = "IP Address 9:"
        IpAdName10.Text = "IP Address 10:"
        IpAdName11.Text = "IP Address 11:"
        IpAdName12.Text = "IP Address 12:"
        Ipname_set1.Text = ""
        Ipname_set2.Text = ""
        Ipname_set3.Text = ""
        Ipname_set4.Text = ""
        Ipname_set5.Text = ""
        Ipname_set6.Text = ""
        Ipname_set7.Text = ""
        Ipname_set8.Text = ""
        Ipname_set9.Text = ""
        Ipname_set10.Text = ""
        Ipname_set11.Text = ""
        Ipname_set12.Text = ""
    End Sub

    Private Sub Settings_BeforePopup(sender As Object, e As CancelEventArgs) Handles settings.BeforePopup

        If Ipname_set1.Text = IpAdName1.Text Then
            Ipname_set1.Text = ""
            Name_set_lbl1.Text = IpAdName1.Text
        End If

        If Ipname_set2.Text = IpAdName2.Text Then
            Ipname_set2.Text = ""
            Name_set_lbl2.Text = IpAdName2.Text
        End If

        If Ipname_set3.Text = IpAdName3.Text Then
            Ipname_set3.Text = ""
            Name_set_lbl3.Text = IpAdName3.Text
        End If

        If Ipname_set4.Text = IpAdName4.Text Then
            Ipname_set4.Text = ""
            Name_set_lbl4.Text = IpAdName4.Text
        End If

        If Ipname_set5.Text = IpAdName5.Text Then
            Ipname_set5.Text = ""
            Name_set_lbl5.Text = IpAdName5.Text
        End If

        If Ipname_set6.Text = IpAdName6.Text Then
            Ipname_set6.Text = ""
            Name_set_lbl6.Text = IpAdName6.Text
        End If

        If Ipname_set7.Text = IpAdName7.Text Then
            Ipname_set7.Text = ""
            Name_set_lbl7.Text = IpAdName7.Text
        End If

        If Ipname_set8.Text = IpAdName8.Text Then
            Ipname_set8.Text = ""
            Name_set_lbl8.Text = IpAdName8.Text
        End If

        If Ipname_set9.Text = IpAdName9.Text Then
            Ipname_set9.Text = ""
            Name_set_lbl9.Text = IpAdName9.Text
        End If

        If Ipname_set10.Text = IpAdName10.Text Then
            Ipname_set10.Text = ""
            Name_set_lbl10.Text = IpAdName10.Text
        End If

        If Ipname_set11.Text = IpAdName11.Text Then
            Ipname_set11.Text = ""
            Name_set_lbl11.Text = IpAdName11.Text
        End If

        If Ipname_set12.Text = IpAdName12.Text Then
            Ipname_set12.Text = ""
            Name_set_lbl12.Text = IpAdName12.Text
        End If

    End Sub

    Private Sub Clearpopup_BeforePopup(sender As Object, e As CancelEventArgs) Handles Clearpopup.BeforePopup
        Name_clear_1.Text = IpAdName1.Text
        Name_clear_2.Text = IpAdName2.Text
        Name_clear_3.Text = IpAdName3.Text
        Name_clear_4.Text = IpAdName4.Text
        Name_clear_5.Text = IpAdName5.Text
        Name_clear_6.Text = IpAdName6.Text
        Name_clear_7.Text = IpAdName7.Text
        Name_clear_8.Text = IpAdName8.Text
        Name_clear_9.Text = IpAdName9.Text
        Name_clear_10.Text = IpAdName10.Text
        Name_clear_11.Text = IpAdName11.Text
        Name_clear_12.Text = IpAdName12.Text
        Ip_clear_1.Text = IPAd1.Text
        Ip_clear_2.Text = IPAd2.Text
        Ip_clear_3.Text = IPAd3.Text
        Ip_clear_4.Text = IPAd4.Text
        Ip_clear_5.Text = IPAd5.Text
        Ip_clear_6.Text = IPAd6.Text
        Ip_clear_7.Text = IPAd7.Text
        Ip_clear_8.Text = IPAd8.Text
        Ip_clear_9.Text = IPAd9.Text
        Ip_clear_10.Text = IPAd10.Text
        Ip_clear_11.Text = IPAd11.Text
        Ip_clear_12.Text = IPAd12.Text
    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        For Each c As Control In Me.Controls
            If TypeOf c Is DevExpress.XtraBars.PopupControlContainer Then
                For Each ch As Control In c.Controls
                    If TypeOf ch Is DevExpress.XtraEditors.CheckEdit Then

                    End If
                Next
            End If
        Next
    End Sub
#End Region
End Class


Class PingInfo
    Public IP As String
    Public HighPing As Long = -1
    Public LowPing As Long = 100

    Public HighDate As Date
    Public LowDate As Date

End Class
