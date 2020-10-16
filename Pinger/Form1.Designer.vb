Partial Public Class Form1
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit12 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit14 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit15 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit17 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit18 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.bgwPing = New System.ComponentModel.BackgroundWorker()
        Me.IpAdName1 = New System.Windows.Forms.Label()
        Me.IPAd2 = New System.Windows.Forms.TextBox()
        Me.IpAdName2 = New System.Windows.Forms.Label()
        Me.IPAd3 = New System.Windows.Forms.TextBox()
        Me.IpAdName3 = New System.Windows.Forms.Label()
        Me.IPAd4 = New System.Windows.Forms.TextBox()
        Me.IpAdName4 = New System.Windows.Forms.Label()
        Me.IPAd5 = New System.Windows.Forms.TextBox()
        Me.IpAdName5 = New System.Windows.Forms.Label()
        Me.IPAd6 = New System.Windows.Forms.TextBox()
        Me.IpAdName6 = New System.Windows.Forms.Label()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.SeparatorControl3 = New DevExpress.XtraEditors.SeparatorControl()
        Me.SeparatorControl4 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lp_lbl_not = New System.Windows.Forms.Label()
        Me.Edit_but = New DevExpress.XtraEditors.SimpleButton()
        Me.lp_lbl = New System.Windows.Forms.Label()
        Me.Start_but = New DevExpress.XtraEditors.SimpleButton()
        Me.Stat_PIc1 = New System.Windows.Forms.PictureBox()
        Me.Stat_PIc2 = New System.Windows.Forms.PictureBox()
        Me.Stat_PIc3 = New System.Windows.Forms.PictureBox()
        Me.Stat_PIc4 = New System.Windows.Forms.PictureBox()
        Me.Stat_PIc5 = New System.Windows.Forms.PictureBox()
        Me.Stat_PIc6 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Always_was_Top = New DevExpress.XtraEditors.ToggleSwitch()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIPNAME1 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSIPAD1 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSPING1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSIPNAME2 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSIPAD2 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSPING2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSIPNAME3 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSIPAD3 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSPING3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSIPNAME4 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSIPAD4 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSPING4 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSIPNAME5 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSIPAD5 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSPING5 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSIPNAME6 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSIPAD6 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSPING6 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIPNAME7 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSIPAD7 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSPING7 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSIPNAME8 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSIPAD8 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSPING8 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSIPNAME9 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSIPAD9 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSPING9 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSIPNAME10 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSIPAD10 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSPING10 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSIPNAME11 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSIPAD11 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSPING11 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSIPNAME12 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSIPAD12 = New System.Windows.Forms.ToolStripTextBox()
        Me.TSPING12 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PingfqSelc = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DropDownButton1 = New DevExpress.XtraEditors.DropDownButton()
        Me.settings = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MswornSelc = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.error_lbl = New System.Windows.Forms.Label()
        Me.ValiAD12 = New System.Windows.Forms.PictureBox()
        Me.ValiAD11 = New System.Windows.Forms.PictureBox()
        Me.ValiAD10 = New System.Windows.Forms.PictureBox()
        Me.ValiAD9 = New System.Windows.Forms.PictureBox()
        Me.ValiAD8 = New System.Windows.Forms.PictureBox()
        Me.ValiAD7 = New System.Windows.Forms.PictureBox()
        Me.ValiAD6 = New System.Windows.Forms.PictureBox()
        Me.ValiAD5 = New System.Windows.Forms.PictureBox()
        Me.ValiAD4 = New System.Windows.Forms.PictureBox()
        Me.ValiAD3 = New System.Windows.Forms.PictureBox()
        Me.ValiAD2 = New System.Windows.Forms.PictureBox()
        Me.ValiAD1 = New System.Windows.Forms.PictureBox()
        Me.IPAd1 = New System.Windows.Forms.TextBox()
        Me.Name_set_lbl7 = New System.Windows.Forms.Label()
        Me.Ipname_set7 = New System.Windows.Forms.TextBox()
        Me.Name_set_lbl8 = New System.Windows.Forms.Label()
        Me.Name_set_lbl10 = New System.Windows.Forms.Label()
        Me.Ipname_set10 = New System.Windows.Forms.TextBox()
        Me.Ipname_set8 = New System.Windows.Forms.TextBox()
        Me.Name_set_lbl11 = New System.Windows.Forms.Label()
        Me.Ipname_set11 = New System.Windows.Forms.TextBox()
        Me.Name_set_lbl9 = New System.Windows.Forms.Label()
        Me.Name_set_lbl12 = New System.Windows.Forms.Label()
        Me.Ipname_set9 = New System.Windows.Forms.TextBox()
        Me.Ipname_set12 = New System.Windows.Forms.TextBox()
        Me.IpAdName7 = New System.Windows.Forms.Label()
        Me.IPAd7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IpAdName8 = New System.Windows.Forms.Label()
        Me.IpAdName10 = New System.Windows.Forms.Label()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.IPAd10 = New System.Windows.Forms.TextBox()
        Me.Change_name_but_Ok = New DevExpress.XtraEditors.SimpleButton()
        Me.IPAd8 = New System.Windows.Forms.TextBox()
        Me.IpAdName11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Ipname_set6 = New System.Windows.Forms.TextBox()
        Me.IPAd11 = New System.Windows.Forms.TextBox()
        Me.IpAdName9 = New System.Windows.Forms.Label()
        Me.Name_set_lbl6 = New System.Windows.Forms.Label()
        Me.IpAdName12 = New System.Windows.Forms.Label()
        Me.Ipname_set5 = New System.Windows.Forms.TextBox()
        Me.IPAd9 = New System.Windows.Forms.TextBox()
        Me.IPAd12 = New System.Windows.Forms.TextBox()
        Me.Name_set_lbl5 = New System.Windows.Forms.Label()
        Me.Ipname_set4 = New System.Windows.Forms.TextBox()
        Me.Name_set_lbl4 = New System.Windows.Forms.Label()
        Me.Ipname_set3 = New System.Windows.Forms.TextBox()
        Me.Name_set_lbl3 = New System.Windows.Forms.Label()
        Me.Ipname_set2 = New System.Windows.Forms.TextBox()
        Me.Name_set_lbl2 = New System.Windows.Forms.Label()
        Me.Ipname_set1 = New System.Windows.Forms.TextBox()
        Me.Name_set_lbl1 = New System.Windows.Forms.Label()
        Me.Start_But_Info = New System.Windows.Forms.Label()
        Me.SeparatorControl6 = New DevExpress.XtraEditors.SeparatorControl()
        Me.SeparatorControl7 = New DevExpress.XtraEditors.SeparatorControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem3 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem4 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem5 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem6 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem7 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem8 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem9 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem10 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem11 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem12 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem13 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem14 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem15 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem16 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem17 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem18 = New DevExpress.XtraBars.BarEditItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Clearpopup = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Ip_clear_12 = New DevExpress.XtraEditors.CheckEdit()
        Me.Ip_clear_11 = New DevExpress.XtraEditors.CheckEdit()
        Me.Ip_clear_10 = New DevExpress.XtraEditors.CheckEdit()
        Me.Ip_clear_9 = New DevExpress.XtraEditors.CheckEdit()
        Me.Ip_clear_8 = New DevExpress.XtraEditors.CheckEdit()
        Me.Ip_clear_7 = New DevExpress.XtraEditors.CheckEdit()
        Me.Ip_clear_6 = New DevExpress.XtraEditors.CheckEdit()
        Me.Ip_clear_5 = New DevExpress.XtraEditors.CheckEdit()
        Me.Ip_clear_4 = New DevExpress.XtraEditors.CheckEdit()
        Me.Ip_clear_3 = New DevExpress.XtraEditors.CheckEdit()
        Me.Ip_clear_2 = New DevExpress.XtraEditors.CheckEdit()
        Me.Ip_clear_1 = New DevExpress.XtraEditors.CheckEdit()
        Me.Name_clear_12 = New DevExpress.XtraEditors.CheckEdit()
        Me.Name_clear_11 = New DevExpress.XtraEditors.CheckEdit()
        Me.Name_clear_10 = New DevExpress.XtraEditors.CheckEdit()
        Me.Name_clear_9 = New DevExpress.XtraEditors.CheckEdit()
        Me.Name_clear_8 = New DevExpress.XtraEditors.CheckEdit()
        Me.Name_clear_7 = New DevExpress.XtraEditors.CheckEdit()
        Me.Name_clear_6 = New DevExpress.XtraEditors.CheckEdit()
        Me.Name_clear_5 = New DevExpress.XtraEditors.CheckEdit()
        Me.Name_clear_4 = New DevExpress.XtraEditors.CheckEdit()
        Me.Name_clear_3 = New DevExpress.XtraEditors.CheckEdit()
        Me.Name_clear_2 = New DevExpress.XtraEditors.CheckEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Name_clear_1 = New DevExpress.XtraEditors.CheckEdit()
        Me.SeparatorControl5 = New DevExpress.XtraEditors.SeparatorControl()
        Me.DropDownButton2 = New DevExpress.XtraEditors.DropDownButton()
        Me.SeparatorControl8 = New DevExpress.XtraEditors.SeparatorControl()
        Me.Stat_PIc12 = New System.Windows.Forms.PictureBox()
        Me.Stat_PIc11 = New System.Windows.Forms.PictureBox()
        Me.Stat_PIc10 = New System.Windows.Forms.PictureBox()
        Me.Stat_PIc9 = New System.Windows.Forms.PictureBox()
        Me.Stat_PIc8 = New System.Windows.Forms.PictureBox()
        Me.Stat_PIc7 = New System.Windows.Forms.PictureBox()
        Me.IP1_lab = New DevExpress.XtraEditors.LabelControl()
        Me.IP2_lab = New DevExpress.XtraEditors.LabelControl()
        Me.IP3_lab = New DevExpress.XtraEditors.LabelControl()
        Me.IP4_lab = New DevExpress.XtraEditors.LabelControl()
        Me.IP5_lab = New DevExpress.XtraEditors.LabelControl()
        Me.IP6_lab = New DevExpress.XtraEditors.LabelControl()
        Me.IP7_lab = New DevExpress.XtraEditors.LabelControl()
        Me.IP8_lab = New DevExpress.XtraEditors.LabelControl()
        Me.IP9_lab = New DevExpress.XtraEditors.LabelControl()
        Me.IP10_lab = New DevExpress.XtraEditors.LabelControl()
        Me.IP11_lab = New DevExpress.XtraEditors.LabelControl()
        Me.IP12_lab = New DevExpress.XtraEditors.LabelControl()
        Me.Lab1_stat = New DevExpress.XtraEditors.LabelControl()
        Me.Lab2_stat = New DevExpress.XtraEditors.LabelControl()
        Me.Lab3_stat = New DevExpress.XtraEditors.LabelControl()
        Me.Lab4_stat = New DevExpress.XtraEditors.LabelControl()
        Me.Lab5_stat = New DevExpress.XtraEditors.LabelControl()
        Me.Lab6_stat = New DevExpress.XtraEditors.LabelControl()
        Me.Lab7_stat = New DevExpress.XtraEditors.LabelControl()
        Me.Lab8_stat = New DevExpress.XtraEditors.LabelControl()
        Me.Lab9_stat = New DevExpress.XtraEditors.LabelControl()
        Me.Lab10_stat = New DevExpress.XtraEditors.LabelControl()
        Me.Lab11_stat = New DevExpress.XtraEditors.LabelControl()
        Me.Lab12_stat = New DevExpress.XtraEditors.LabelControl()
        Me.clear_ping_info_but = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stat_PIc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stat_PIc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stat_PIc3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stat_PIc4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stat_PIc5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stat_PIc6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Always_was_Top.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NotifyMenu.SuspendLayout()
        CType(Me.PingfqSelc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.settings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.settings.SuspendLayout()
        CType(Me.MswornSelc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValiAD12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValiAD11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValiAD10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValiAD9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValiAD8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValiAD7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValiAD6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValiAD5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValiAD4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValiAD3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValiAD2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValiAD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clearpopup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Clearpopup.SuspendLayout()
        CType(Me.Ip_clear_12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ip_clear_11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ip_clear_10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ip_clear_9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ip_clear_8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ip_clear_7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ip_clear_6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ip_clear_5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ip_clear_4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ip_clear_3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ip_clear_2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ip_clear_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_clear_12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_clear_11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_clear_10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_clear_9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_clear_8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_clear_7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_clear_6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_clear_5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_clear_4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_clear_3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_clear_2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name_clear_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stat_PIc12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stat_PIc11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stat_PIc10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stat_PIc9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stat_PIc8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stat_PIc7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'RepositoryItemTextEdit8
        '
        Me.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8"
        '
        'RepositoryItemTextEdit9
        '
        Me.RepositoryItemTextEdit9.Name = "RepositoryItemTextEdit9"
        '
        'RepositoryItemTextEdit10
        '
        Me.RepositoryItemTextEdit10.Name = "RepositoryItemTextEdit10"
        '
        'RepositoryItemTextEdit11
        '
        Me.RepositoryItemTextEdit11.Name = "RepositoryItemTextEdit11"
        '
        'RepositoryItemTextEdit12
        '
        Me.RepositoryItemTextEdit12.Name = "RepositoryItemTextEdit12"
        '
        'RepositoryItemTextEdit13
        '
        Me.RepositoryItemTextEdit13.Name = "RepositoryItemTextEdit13"
        '
        'RepositoryItemTextEdit14
        '
        Me.RepositoryItemTextEdit14.Name = "RepositoryItemTextEdit14"
        '
        'RepositoryItemTextEdit15
        '
        Me.RepositoryItemTextEdit15.Name = "RepositoryItemTextEdit15"
        '
        'RepositoryItemTextEdit16
        '
        Me.RepositoryItemTextEdit16.Name = "RepositoryItemTextEdit16"
        '
        'RepositoryItemTextEdit17
        '
        Me.RepositoryItemTextEdit17.Name = "RepositoryItemTextEdit17"
        '
        'RepositoryItemTextEdit18
        '
        Me.RepositoryItemTextEdit18.Name = "RepositoryItemTextEdit18"
        '
        'bgwPing
        '
        Me.bgwPing.WorkerSupportsCancellation = Global.Pinger.Settings.Default.Pinger
        '
        'IpAdName1
        '
        Me.IpAdName1.AutoSize = True
        Me.IpAdName1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpAdName1.ForeColor = System.Drawing.Color.Lime
        Me.IpAdName1.Location = New System.Drawing.Point(573, 55)
        Me.IpAdName1.Name = "IpAdName1"
        Me.IpAdName1.Size = New System.Drawing.Size(106, 19)
        Me.IpAdName1.TabIndex = 0
        Me.IpAdName1.Text = "IP Address &1:"
        '
        'IPAd2
        '
        Me.IPAd2.BackColor = System.Drawing.Color.Gainsboro
        Me.IPAd2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPAd2.Location = New System.Drawing.Point(699, 85)
        Me.IPAd2.Name = "IPAd2"
        Me.IPAd2.ReadOnly = True
        Me.IPAd2.Size = New System.Drawing.Size(129, 26)
        Me.IPAd2.TabIndex = 2
        '
        'IpAdName2
        '
        Me.IpAdName2.AutoSize = True
        Me.IpAdName2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpAdName2.ForeColor = System.Drawing.Color.Lime
        Me.IpAdName2.Location = New System.Drawing.Point(573, 87)
        Me.IpAdName2.Name = "IpAdName2"
        Me.IpAdName2.Size = New System.Drawing.Size(106, 19)
        Me.IpAdName2.TabIndex = 2
        Me.IpAdName2.Text = "IP Address &2:"
        '
        'IPAd3
        '
        Me.IPAd3.BackColor = System.Drawing.Color.Gainsboro
        Me.IPAd3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPAd3.Location = New System.Drawing.Point(699, 117)
        Me.IPAd3.Name = "IPAd3"
        Me.IPAd3.ReadOnly = True
        Me.IPAd3.Size = New System.Drawing.Size(129, 26)
        Me.IPAd3.TabIndex = 3
        '
        'IpAdName3
        '
        Me.IpAdName3.AutoSize = True
        Me.IpAdName3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpAdName3.ForeColor = System.Drawing.Color.Lime
        Me.IpAdName3.Location = New System.Drawing.Point(573, 122)
        Me.IpAdName3.Name = "IpAdName3"
        Me.IpAdName3.Size = New System.Drawing.Size(106, 19)
        Me.IpAdName3.TabIndex = 4
        Me.IpAdName3.Text = "IP Address &3:"
        '
        'IPAd4
        '
        Me.IPAd4.BackColor = System.Drawing.Color.Gainsboro
        Me.IPAd4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPAd4.Location = New System.Drawing.Point(699, 150)
        Me.IPAd4.Name = "IPAd4"
        Me.IPAd4.ReadOnly = True
        Me.IPAd4.Size = New System.Drawing.Size(129, 26)
        Me.IPAd4.TabIndex = 4
        '
        'IpAdName4
        '
        Me.IpAdName4.AutoSize = True
        Me.IpAdName4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpAdName4.ForeColor = System.Drawing.Color.Lime
        Me.IpAdName4.Location = New System.Drawing.Point(573, 152)
        Me.IpAdName4.Name = "IpAdName4"
        Me.IpAdName4.Size = New System.Drawing.Size(106, 19)
        Me.IpAdName4.TabIndex = 6
        Me.IpAdName4.Text = "IP Address &4:"
        '
        'IPAd5
        '
        Me.IPAd5.BackColor = System.Drawing.Color.Gainsboro
        Me.IPAd5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPAd5.Location = New System.Drawing.Point(699, 182)
        Me.IPAd5.Name = "IPAd5"
        Me.IPAd5.ReadOnly = True
        Me.IPAd5.Size = New System.Drawing.Size(129, 26)
        Me.IPAd5.TabIndex = 5
        '
        'IpAdName5
        '
        Me.IpAdName5.AutoSize = True
        Me.IpAdName5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpAdName5.ForeColor = System.Drawing.Color.Lime
        Me.IpAdName5.Location = New System.Drawing.Point(573, 184)
        Me.IpAdName5.Name = "IpAdName5"
        Me.IpAdName5.Size = New System.Drawing.Size(106, 19)
        Me.IpAdName5.TabIndex = 8
        Me.IpAdName5.Text = "IP Address &5:"
        '
        'IPAd6
        '
        Me.IPAd6.BackColor = System.Drawing.Color.Gainsboro
        Me.IPAd6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPAd6.Location = New System.Drawing.Point(699, 214)
        Me.IPAd6.Name = "IPAd6"
        Me.IPAd6.ReadOnly = True
        Me.IPAd6.Size = New System.Drawing.Size(129, 26)
        Me.IPAd6.TabIndex = 6
        '
        'IpAdName6
        '
        Me.IpAdName6.AutoSize = True
        Me.IpAdName6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpAdName6.ForeColor = System.Drawing.Color.Lime
        Me.IpAdName6.Location = New System.Drawing.Point(573, 216)
        Me.IpAdName6.Name = "IpAdName6"
        Me.IpAdName6.Size = New System.Drawing.Size(106, 19)
        Me.IpAdName6.TabIndex = 10
        Me.IpAdName6.Text = "IP Address &6:"
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.LineColor = System.Drawing.Color.Black
        Me.SeparatorControl2.Location = New System.Drawing.Point(-6, 42)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(1385, 23)
        Me.SeparatorControl2.TabIndex = 51
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.LineColor = System.Drawing.Color.Black
        Me.SeparatorControl1.Location = New System.Drawing.Point(-6, 13)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(1385, 23)
        Me.SeparatorControl1.TabIndex = 50
        '
        'SeparatorControl3
        '
        Me.SeparatorControl3.LineColor = System.Drawing.Color.Black
        Me.SeparatorControl3.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl3.Location = New System.Drawing.Point(333, -1)
        Me.SeparatorControl3.Name = "SeparatorControl3"
        Me.SeparatorControl3.Size = New System.Drawing.Size(28, 83)
        Me.SeparatorControl3.TabIndex = 52
        '
        'SeparatorControl4
        '
        Me.SeparatorControl4.LineColor = System.Drawing.Color.Black
        Me.SeparatorControl4.Location = New System.Drawing.Point(-6, 73)
        Me.SeparatorControl4.Name = "SeparatorControl4"
        Me.SeparatorControl4.Size = New System.Drawing.Size(1385, 23)
        Me.SeparatorControl4.TabIndex = 53
        '
        'lp_lbl_not
        '
        Me.lp_lbl_not.AutoSize = True
        Me.lp_lbl_not.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lp_lbl_not.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lp_lbl_not.Location = New System.Drawing.Point(550, 96)
        Me.lp_lbl_not.Name = "lp_lbl_not"
        Me.lp_lbl_not.Size = New System.Drawing.Size(134, 19)
        Me.lp_lbl_not.TabIndex = 57
        Me.lp_lbl_not.Text = "Lasted Pinged At:"
        '
        'Edit_but
        '
        Me.Edit_but.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_but.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Edit_but.Appearance.Options.UseFont = True
        Me.Edit_but.Appearance.Options.UseForeColor = True
        Me.Edit_but.ImageOptions.Image = CType(resources.GetObject("Edit_but.ImageOptions.Image"), System.Drawing.Image)
        Me.Edit_but.Location = New System.Drawing.Point(795, 271)
        Me.Edit_but.Name = "Edit_but"
        Me.Edit_but.Size = New System.Drawing.Size(93, 39)
        Me.Edit_but.TabIndex = 0
        Me.Edit_but.Text = "Edit"
        '
        'lp_lbl
        '
        Me.lp_lbl.AutoSize = True
        Me.lp_lbl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lp_lbl.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lp_lbl.Location = New System.Drawing.Point(690, 96)
        Me.lp_lbl.Name = "lp_lbl"
        Me.lp_lbl.Size = New System.Drawing.Size(101, 19)
        Me.lp_lbl.TabIndex = 58
        Me.lp_lbl.Text = "00:00:00 PM"
        '
        'Start_but
        '
        Me.Start_but.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Start_but.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Start_but.Appearance.Options.UseFont = True
        Me.Start_but.Appearance.Options.UseForeColor = True
        Me.Start_but.Enabled = False
        Me.Start_but.ImageOptions.Image = CType(resources.GetObject("Start_but.ImageOptions.Image"), System.Drawing.Image)
        Me.Start_but.Location = New System.Drawing.Point(894, 271)
        Me.Start_but.Name = "Start_but"
        Me.Start_but.Size = New System.Drawing.Size(93, 39)
        Me.Start_but.TabIndex = 0
        Me.Start_but.Text = "Start"
        '
        'Stat_PIc1
        '
        Me.Stat_PIc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Stat_PIc1.Location = New System.Drawing.Point(11, 2)
        Me.Stat_PIc1.Name = "Stat_PIc1"
        Me.Stat_PIc1.Size = New System.Drawing.Size(16, 16)
        Me.Stat_PIc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Stat_PIc1.TabIndex = 61
        Me.Stat_PIc1.TabStop = False
        '
        'Stat_PIc2
        '
        Me.Stat_PIc2.Location = New System.Drawing.Point(11, 32)
        Me.Stat_PIc2.Name = "Stat_PIc2"
        Me.Stat_PIc2.Size = New System.Drawing.Size(16, 16)
        Me.Stat_PIc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Stat_PIc2.TabIndex = 62
        Me.Stat_PIc2.TabStop = False
        '
        'Stat_PIc3
        '
        Me.Stat_PIc3.Location = New System.Drawing.Point(11, 60)
        Me.Stat_PIc3.Name = "Stat_PIc3"
        Me.Stat_PIc3.Size = New System.Drawing.Size(16, 16)
        Me.Stat_PIc3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Stat_PIc3.TabIndex = 63
        Me.Stat_PIc3.TabStop = False
        '
        'Stat_PIc4
        '
        Me.Stat_PIc4.Location = New System.Drawing.Point(359, 2)
        Me.Stat_PIc4.Name = "Stat_PIc4"
        Me.Stat_PIc4.Size = New System.Drawing.Size(16, 16)
        Me.Stat_PIc4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Stat_PIc4.TabIndex = 64
        Me.Stat_PIc4.TabStop = False
        '
        'Stat_PIc5
        '
        Me.Stat_PIc5.Location = New System.Drawing.Point(359, 32)
        Me.Stat_PIc5.Name = "Stat_PIc5"
        Me.Stat_PIc5.Size = New System.Drawing.Size(16, 16)
        Me.Stat_PIc5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Stat_PIc5.TabIndex = 65
        Me.Stat_PIc5.TabStop = False
        '
        'Stat_PIc6
        '
        Me.Stat_PIc6.Location = New System.Drawing.Point(359, 60)
        Me.Stat_PIc6.Name = "Stat_PIc6"
        Me.Stat_PIc6.Size = New System.Drawing.Size(16, 16)
        Me.Stat_PIc6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Stat_PIc6.TabIndex = 66
        Me.Stat_PIc6.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Close-2-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "Ok-icon.png")
        Me.ImageList1.Images.SetKeyName(2, "icons8-disconnected-32.png")
        Me.ImageList1.Images.SetKeyName(3, "icons8-error-32.png")
        Me.ImageList1.Images.SetKeyName(4, "icons8-info-32.png")
        Me.ImageList1.Images.SetKeyName(5, "icons8-box-important-16.png")
        '
        'Always_was_Top
        '
        Me.Always_was_Top.Location = New System.Drawing.Point(1262, 113)
        Me.Always_was_Top.Name = "Always_was_Top"
        Me.Always_was_Top.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Always_was_Top.Properties.Appearance.Options.UseForeColor = True
        Me.Always_was_Top.Properties.OffText = "Off"
        Me.Always_was_Top.Properties.OnText = "On"
        Me.Always_was_Top.Size = New System.Drawing.Size(95, 24)
        Me.Always_was_Top.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Lime
        Me.Label8.Location = New System.Drawing.Point(1259, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 18)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Always On Top:"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.NotifyMenu
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Pinger"
        '
        'NotifyMenu
        '
        Me.NotifyMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PingsToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripSeparator6, Me.ExitToolStripMenuItem})
        Me.NotifyMenu.Name = "NotifyMenu"
        Me.NotifyMenu.Size = New System.Drawing.Size(143, 76)
        '
        'PingsToolStripMenuItem
        '
        Me.PingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSIPNAME1, Me.TSIPAD1, Me.TSPING1, Me.ToolStripSeparator1, Me.TSIPNAME2, Me.TSIPAD2, Me.TSPING2, Me.ToolStripSeparator2, Me.TSIPNAME3, Me.TSIPAD3, Me.TSPING3, Me.ToolStripSeparator3, Me.TSIPNAME4, Me.TSIPAD4, Me.TSPING4, Me.ToolStripSeparator4, Me.TSIPNAME5, Me.TSIPAD5, Me.TSPING5, Me.ToolStripSeparator5, Me.TSIPNAME6, Me.TSIPAD6, Me.TSPING6})
        Me.PingsToolStripMenuItem.Name = "PingsToolStripMenuItem"
        Me.PingsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.PingsToolStripMenuItem.Text = "Ip Pings 1-6"
        '
        'TSIPNAME1
        '
        Me.TSIPNAME1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TSIPNAME1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPNAME1.Name = "TSIPNAME1"
        Me.TSIPNAME1.ReadOnly = True
        Me.TSIPNAME1.Size = New System.Drawing.Size(100, 23)
        Me.TSIPNAME1.Text = "IP Adress 1"
        '
        'TSIPAD1
        '
        Me.TSIPAD1.BackColor = System.Drawing.Color.LightGray
        Me.TSIPAD1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPAD1.Name = "TSIPAD1"
        Me.TSIPAD1.ReadOnly = True
        Me.TSIPAD1.Size = New System.Drawing.Size(100, 23)
        '
        'TSPING1
        '
        Me.TSPING1.BackColor = System.Drawing.Color.LightGray
        Me.TSPING1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSPING1.Name = "TSPING1"
        Me.TSPING1.ReadOnly = True
        Me.TSPING1.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'TSIPNAME2
        '
        Me.TSIPNAME2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TSIPNAME2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPNAME2.Name = "TSIPNAME2"
        Me.TSIPNAME2.ReadOnly = True
        Me.TSIPNAME2.Size = New System.Drawing.Size(100, 23)
        Me.TSIPNAME2.Text = "IP Adress 2"
        '
        'TSIPAD2
        '
        Me.TSIPAD2.BackColor = System.Drawing.Color.LightGray
        Me.TSIPAD2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPAD2.Name = "TSIPAD2"
        Me.TSIPAD2.ReadOnly = True
        Me.TSIPAD2.Size = New System.Drawing.Size(100, 23)
        '
        'TSPING2
        '
        Me.TSPING2.BackColor = System.Drawing.Color.LightGray
        Me.TSPING2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSPING2.Name = "TSPING2"
        Me.TSPING2.ReadOnly = True
        Me.TSPING2.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(157, 6)
        '
        'TSIPNAME3
        '
        Me.TSIPNAME3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TSIPNAME3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPNAME3.Name = "TSIPNAME3"
        Me.TSIPNAME3.ReadOnly = True
        Me.TSIPNAME3.Size = New System.Drawing.Size(100, 23)
        Me.TSIPNAME3.Text = "IP Adress 3"
        '
        'TSIPAD3
        '
        Me.TSIPAD3.BackColor = System.Drawing.Color.LightGray
        Me.TSIPAD3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPAD3.Name = "TSIPAD3"
        Me.TSIPAD3.ReadOnly = True
        Me.TSIPAD3.Size = New System.Drawing.Size(100, 23)
        '
        'TSPING3
        '
        Me.TSPING3.BackColor = System.Drawing.Color.LightGray
        Me.TSPING3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSPING3.Name = "TSPING3"
        Me.TSPING3.ReadOnly = True
        Me.TSPING3.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(157, 6)
        '
        'TSIPNAME4
        '
        Me.TSIPNAME4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TSIPNAME4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPNAME4.Name = "TSIPNAME4"
        Me.TSIPNAME4.ReadOnly = True
        Me.TSIPNAME4.Size = New System.Drawing.Size(100, 23)
        Me.TSIPNAME4.Text = "IP Adress 4"
        '
        'TSIPAD4
        '
        Me.TSIPAD4.BackColor = System.Drawing.Color.LightGray
        Me.TSIPAD4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPAD4.Name = "TSIPAD4"
        Me.TSIPAD4.ReadOnly = True
        Me.TSIPAD4.Size = New System.Drawing.Size(100, 23)
        '
        'TSPING4
        '
        Me.TSPING4.BackColor = System.Drawing.Color.LightGray
        Me.TSPING4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSPING4.Name = "TSPING4"
        Me.TSPING4.ReadOnly = True
        Me.TSPING4.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(157, 6)
        '
        'TSIPNAME5
        '
        Me.TSIPNAME5.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TSIPNAME5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPNAME5.Name = "TSIPNAME5"
        Me.TSIPNAME5.ReadOnly = True
        Me.TSIPNAME5.Size = New System.Drawing.Size(100, 23)
        Me.TSIPNAME5.Text = "IP Adress 5"
        '
        'TSIPAD5
        '
        Me.TSIPAD5.BackColor = System.Drawing.Color.LightGray
        Me.TSIPAD5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPAD5.Name = "TSIPAD5"
        Me.TSIPAD5.ReadOnly = True
        Me.TSIPAD5.Size = New System.Drawing.Size(100, 23)
        '
        'TSPING5
        '
        Me.TSPING5.BackColor = System.Drawing.Color.LightGray
        Me.TSPING5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSPING5.Name = "TSPING5"
        Me.TSPING5.ReadOnly = True
        Me.TSPING5.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(157, 6)
        '
        'TSIPNAME6
        '
        Me.TSIPNAME6.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TSIPNAME6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPNAME6.Name = "TSIPNAME6"
        Me.TSIPNAME6.ReadOnly = True
        Me.TSIPNAME6.Size = New System.Drawing.Size(100, 23)
        Me.TSIPNAME6.Text = "IP Adress 6"
        '
        'TSIPAD6
        '
        Me.TSIPAD6.BackColor = System.Drawing.Color.LightGray
        Me.TSIPAD6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPAD6.Name = "TSIPAD6"
        Me.TSIPAD6.ReadOnly = True
        Me.TSIPAD6.Size = New System.Drawing.Size(100, 23)
        '
        'TSPING6
        '
        Me.TSPING6.BackColor = System.Drawing.Color.LightGray
        Me.TSPING6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSPING6.Name = "TSPING6"
        Me.TSPING6.ReadOnly = True
        Me.TSPING6.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSIPNAME7, Me.TSIPAD7, Me.TSPING7, Me.ToolStripSeparator7, Me.TSIPNAME8, Me.TSIPAD8, Me.TSPING8, Me.ToolStripSeparator8, Me.TSIPNAME9, Me.TSIPAD9, Me.TSPING9, Me.ToolStripSeparator9, Me.TSIPNAME10, Me.TSIPAD10, Me.TSPING10, Me.ToolStripSeparator10, Me.TSIPNAME11, Me.TSIPAD11, Me.TSPING11, Me.ToolStripSeparator11, Me.TSIPNAME12, Me.TSIPAD12, Me.TSPING12})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.ToolStripMenuItem1.Text = "Ip Pings 7-12"
        '
        'TSIPNAME7
        '
        Me.TSIPNAME7.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TSIPNAME7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPNAME7.Name = "TSIPNAME7"
        Me.TSIPNAME7.ReadOnly = True
        Me.TSIPNAME7.Size = New System.Drawing.Size(100, 23)
        '
        'TSIPAD7
        '
        Me.TSIPAD7.BackColor = System.Drawing.Color.LightGray
        Me.TSIPAD7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPAD7.Name = "TSIPAD7"
        Me.TSIPAD7.ReadOnly = True
        Me.TSIPAD7.Size = New System.Drawing.Size(100, 23)
        '
        'TSPING7
        '
        Me.TSPING7.BackColor = System.Drawing.Color.LightGray
        Me.TSPING7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSPING7.Name = "TSPING7"
        Me.TSPING7.ReadOnly = True
        Me.TSPING7.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(157, 6)
        '
        'TSIPNAME8
        '
        Me.TSIPNAME8.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TSIPNAME8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPNAME8.Name = "TSIPNAME8"
        Me.TSIPNAME8.ReadOnly = True
        Me.TSIPNAME8.Size = New System.Drawing.Size(100, 23)
        '
        'TSIPAD8
        '
        Me.TSIPAD8.BackColor = System.Drawing.Color.LightGray
        Me.TSIPAD8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPAD8.Name = "TSIPAD8"
        Me.TSIPAD8.ReadOnly = True
        Me.TSIPAD8.Size = New System.Drawing.Size(100, 23)
        '
        'TSPING8
        '
        Me.TSPING8.BackColor = System.Drawing.Color.LightGray
        Me.TSPING8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSPING8.Name = "TSPING8"
        Me.TSPING8.ReadOnly = True
        Me.TSPING8.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(157, 6)
        '
        'TSIPNAME9
        '
        Me.TSIPNAME9.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TSIPNAME9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPNAME9.Name = "TSIPNAME9"
        Me.TSIPNAME9.ReadOnly = True
        Me.TSIPNAME9.Size = New System.Drawing.Size(100, 23)
        '
        'TSIPAD9
        '
        Me.TSIPAD9.BackColor = System.Drawing.Color.LightGray
        Me.TSIPAD9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPAD9.Name = "TSIPAD9"
        Me.TSIPAD9.ReadOnly = True
        Me.TSIPAD9.Size = New System.Drawing.Size(100, 23)
        '
        'TSPING9
        '
        Me.TSPING9.BackColor = System.Drawing.Color.LightGray
        Me.TSPING9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSPING9.Name = "TSPING9"
        Me.TSPING9.ReadOnly = True
        Me.TSPING9.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(157, 6)
        '
        'TSIPNAME10
        '
        Me.TSIPNAME10.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TSIPNAME10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPNAME10.Name = "TSIPNAME10"
        Me.TSIPNAME10.ReadOnly = True
        Me.TSIPNAME10.Size = New System.Drawing.Size(100, 23)
        '
        'TSIPAD10
        '
        Me.TSIPAD10.BackColor = System.Drawing.Color.LightGray
        Me.TSIPAD10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPAD10.Name = "TSIPAD10"
        Me.TSIPAD10.ReadOnly = True
        Me.TSIPAD10.Size = New System.Drawing.Size(100, 23)
        '
        'TSPING10
        '
        Me.TSPING10.BackColor = System.Drawing.Color.LightGray
        Me.TSPING10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSPING10.Name = "TSPING10"
        Me.TSPING10.ReadOnly = True
        Me.TSPING10.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(157, 6)
        '
        'TSIPNAME11
        '
        Me.TSIPNAME11.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TSIPNAME11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPNAME11.Name = "TSIPNAME11"
        Me.TSIPNAME11.ReadOnly = True
        Me.TSIPNAME11.Size = New System.Drawing.Size(100, 23)
        '
        'TSIPAD11
        '
        Me.TSIPAD11.BackColor = System.Drawing.Color.LightGray
        Me.TSIPAD11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPAD11.Name = "TSIPAD11"
        Me.TSIPAD11.ReadOnly = True
        Me.TSIPAD11.Size = New System.Drawing.Size(100, 23)
        '
        'TSPING11
        '
        Me.TSPING11.BackColor = System.Drawing.Color.LightGray
        Me.TSPING11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSPING11.Name = "TSPING11"
        Me.TSPING11.ReadOnly = True
        Me.TSPING11.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(157, 6)
        '
        'TSIPNAME12
        '
        Me.TSIPNAME12.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TSIPNAME12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPNAME12.Name = "TSIPNAME12"
        Me.TSIPNAME12.ReadOnly = True
        Me.TSIPNAME12.Size = New System.Drawing.Size(100, 23)
        '
        'TSIPAD12
        '
        Me.TSIPAD12.BackColor = System.Drawing.Color.LightGray
        Me.TSIPAD12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSIPAD12.Name = "TSIPAD12"
        Me.TSIPAD12.ReadOnly = True
        Me.TSIPAD12.Size = New System.Drawing.Size(100, 23)
        '
        'TSPING12
        '
        Me.TSPING12.BackColor = System.Drawing.Color.LightGray
        Me.TSPING12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TSPING12.Name = "TSPING12"
        Me.TSPING12.ReadOnly = True
        Me.TSPING12.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(139, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PingfqSelc
        '
        Me.PingfqSelc.EditValue = "5 Sec (Default)"
        Me.PingfqSelc.Location = New System.Drawing.Point(1052, 291)
        Me.PingfqSelc.Name = "PingfqSelc"
        Me.PingfqSelc.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.PingfqSelc.Properties.Appearance.Options.UseForeColor = True
        Me.PingfqSelc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PingfqSelc.Properties.DropDownRows = 5
        Me.PingfqSelc.Properties.Items.AddRange(New Object() {"5 Sec (Default)", "10 Sec", "15 Sec", "20 Sec"})
        Me.PingfqSelc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.PingfqSelc.Size = New System.Drawing.Size(101, 20)
        Me.PingfqSelc.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Lime
        Me.Label9.Location = New System.Drawing.Point(1049, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Frequency Of Ping"
        '
        'DropDownButton1
        '
        Me.DropDownButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.DropDownButton1.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.DropDownButton1.Appearance.Options.UseFont = True
        Me.DropDownButton1.Appearance.Options.UseForeColor = True
        Me.DropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide
        Me.DropDownButton1.DropDownControl = Me.settings
        Me.DropDownButton1.ImageOptions.Image = CType(resources.GetObject("DropDownButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.DropDownButton1.Location = New System.Drawing.Point(11, 96)
        Me.DropDownButton1.Name = "DropDownButton1"
        Me.DropDownButton1.Size = New System.Drawing.Size(126, 34)
        Me.DropDownButton1.TabIndex = 0
        Me.DropDownButton1.Text = "Settings"
        '
        'settings
        '
        Me.settings.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.settings.Controls.Add(Me.Label1)
        Me.settings.Controls.Add(Me.MswornSelc)
        Me.settings.Controls.Add(Me.error_lbl)
        Me.settings.Controls.Add(Me.ValiAD12)
        Me.settings.Controls.Add(Me.ValiAD11)
        Me.settings.Controls.Add(Me.ValiAD10)
        Me.settings.Controls.Add(Me.ValiAD9)
        Me.settings.Controls.Add(Me.ValiAD8)
        Me.settings.Controls.Add(Me.ValiAD7)
        Me.settings.Controls.Add(Me.ValiAD6)
        Me.settings.Controls.Add(Me.ValiAD5)
        Me.settings.Controls.Add(Me.ValiAD4)
        Me.settings.Controls.Add(Me.ValiAD3)
        Me.settings.Controls.Add(Me.ValiAD2)
        Me.settings.Controls.Add(Me.ValiAD1)
        Me.settings.Controls.Add(Me.IPAd1)
        Me.settings.Controls.Add(Me.Name_set_lbl7)
        Me.settings.Controls.Add(Me.Ipname_set7)
        Me.settings.Controls.Add(Me.Name_set_lbl8)
        Me.settings.Controls.Add(Me.Name_set_lbl10)
        Me.settings.Controls.Add(Me.Ipname_set10)
        Me.settings.Controls.Add(Me.Ipname_set8)
        Me.settings.Controls.Add(Me.Name_set_lbl11)
        Me.settings.Controls.Add(Me.Ipname_set11)
        Me.settings.Controls.Add(Me.Name_set_lbl9)
        Me.settings.Controls.Add(Me.Name_set_lbl12)
        Me.settings.Controls.Add(Me.Ipname_set9)
        Me.settings.Controls.Add(Me.Ipname_set12)
        Me.settings.Controls.Add(Me.IpAdName7)
        Me.settings.Controls.Add(Me.IPAd7)
        Me.settings.Controls.Add(Me.Label7)
        Me.settings.Controls.Add(Me.IpAdName8)
        Me.settings.Controls.Add(Me.IpAdName10)
        Me.settings.Controls.Add(Me.SimpleButton2)
        Me.settings.Controls.Add(Me.IPAd10)
        Me.settings.Controls.Add(Me.Change_name_but_Ok)
        Me.settings.Controls.Add(Me.Label9)
        Me.settings.Controls.Add(Me.PingfqSelc)
        Me.settings.Controls.Add(Me.IPAd8)
        Me.settings.Controls.Add(Me.IpAdName11)
        Me.settings.Controls.Add(Me.Label10)
        Me.settings.Controls.Add(Me.Ipname_set6)
        Me.settings.Controls.Add(Me.IPAd11)
        Me.settings.Controls.Add(Me.IpAdName9)
        Me.settings.Controls.Add(Me.Name_set_lbl6)
        Me.settings.Controls.Add(Me.IpAdName12)
        Me.settings.Controls.Add(Me.Ipname_set5)
        Me.settings.Controls.Add(Me.IPAd9)
        Me.settings.Controls.Add(Me.Start_but)
        Me.settings.Controls.Add(Me.IPAd12)
        Me.settings.Controls.Add(Me.Name_set_lbl5)
        Me.settings.Controls.Add(Me.Edit_but)
        Me.settings.Controls.Add(Me.Ipname_set4)
        Me.settings.Controls.Add(Me.Name_set_lbl4)
        Me.settings.Controls.Add(Me.Ipname_set3)
        Me.settings.Controls.Add(Me.Name_set_lbl3)
        Me.settings.Controls.Add(Me.Ipname_set2)
        Me.settings.Controls.Add(Me.Name_set_lbl2)
        Me.settings.Controls.Add(Me.Ipname_set1)
        Me.settings.Controls.Add(Me.Name_set_lbl1)
        Me.settings.Controls.Add(Me.IpAdName1)
        Me.settings.Controls.Add(Me.Start_But_Info)
        Me.settings.Controls.Add(Me.IpAdName2)
        Me.settings.Controls.Add(Me.IPAd2)
        Me.settings.Controls.Add(Me.IpAdName3)
        Me.settings.Controls.Add(Me.IPAd3)
        Me.settings.Controls.Add(Me.IpAdName4)
        Me.settings.Controls.Add(Me.IPAd4)
        Me.settings.Controls.Add(Me.IpAdName5)
        Me.settings.Controls.Add(Me.IPAd5)
        Me.settings.Controls.Add(Me.IpAdName6)
        Me.settings.Controls.Add(Me.IPAd6)
        Me.settings.Controls.Add(Me.SeparatorControl6)
        Me.settings.Controls.Add(Me.SeparatorControl7)
        Me.settings.Location = New System.Drawing.Point(544, 501)
        Me.settings.Manager = Me.BarManager1
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(1162, 325)
        Me.settings.TabIndex = 73
        Me.settings.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(581, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Show Worning is Ping ms is over:"
        '
        'MswornSelc
        '
        Me.MswornSelc.EditValue = "3 MS (Default)"
        Me.MswornSelc.Enabled = False
        Me.MswornSelc.Location = New System.Drawing.Point(585, 290)
        Me.MswornSelc.Name = "MswornSelc"
        Me.MswornSelc.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.MswornSelc.Properties.Appearance.Options.UseForeColor = True
        Me.MswornSelc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MswornSelc.Properties.DropDownRows = 5
        Me.MswornSelc.Properties.Items.AddRange(New Object() {"3 MS (Default)", "4 MS", "5 MS", "6 MS", "7 MS", "8 MS", "9 MS", "10 MS"})
        Me.MswornSelc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.MswornSelc.Size = New System.Drawing.Size(101, 20)
        Me.MswornSelc.TabIndex = 0
        '
        'error_lbl
        '
        Me.error_lbl.AutoSize = True
        Me.error_lbl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_lbl.ForeColor = System.Drawing.Color.LightGray
        Me.error_lbl.Location = New System.Drawing.Point(721, 33)
        Me.error_lbl.Name = "error_lbl"
        Me.error_lbl.Size = New System.Drawing.Size(298, 16)
        Me.error_lbl.TabIndex = 96
        Me.error_lbl.Text = "The Highlighted IP address is not in proper format!"
        Me.error_lbl.Visible = False
        '
        'ValiAD12
        '
        Me.ValiAD12.Location = New System.Drawing.Point(1133, 219)
        Me.ValiAD12.Name = "ValiAD12"
        Me.ValiAD12.Size = New System.Drawing.Size(16, 16)
        Me.ValiAD12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ValiAD12.TabIndex = 95
        Me.ValiAD12.TabStop = False
        '
        'ValiAD11
        '
        Me.ValiAD11.Location = New System.Drawing.Point(1133, 187)
        Me.ValiAD11.Name = "ValiAD11"
        Me.ValiAD11.Size = New System.Drawing.Size(16, 16)
        Me.ValiAD11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ValiAD11.TabIndex = 94
        Me.ValiAD11.TabStop = False
        '
        'ValiAD10
        '
        Me.ValiAD10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ValiAD10.Location = New System.Drawing.Point(1133, 155)
        Me.ValiAD10.Name = "ValiAD10"
        Me.ValiAD10.Size = New System.Drawing.Size(16, 16)
        Me.ValiAD10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ValiAD10.TabIndex = 93
        Me.ValiAD10.TabStop = False
        '
        'ValiAD9
        '
        Me.ValiAD9.Location = New System.Drawing.Point(1133, 122)
        Me.ValiAD9.Name = "ValiAD9"
        Me.ValiAD9.Size = New System.Drawing.Size(16, 16)
        Me.ValiAD9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ValiAD9.TabIndex = 92
        Me.ValiAD9.TabStop = False
        '
        'ValiAD8
        '
        Me.ValiAD8.Location = New System.Drawing.Point(1133, 90)
        Me.ValiAD8.Name = "ValiAD8"
        Me.ValiAD8.Size = New System.Drawing.Size(16, 16)
        Me.ValiAD8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ValiAD8.TabIndex = 91
        Me.ValiAD8.TabStop = False
        '
        'ValiAD7
        '
        Me.ValiAD7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ValiAD7.Location = New System.Drawing.Point(1133, 58)
        Me.ValiAD7.Name = "ValiAD7"
        Me.ValiAD7.Size = New System.Drawing.Size(16, 16)
        Me.ValiAD7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ValiAD7.TabIndex = 90
        Me.ValiAD7.TabStop = False
        '
        'ValiAD6
        '
        Me.ValiAD6.Location = New System.Drawing.Point(834, 219)
        Me.ValiAD6.Name = "ValiAD6"
        Me.ValiAD6.Size = New System.Drawing.Size(16, 16)
        Me.ValiAD6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ValiAD6.TabIndex = 89
        Me.ValiAD6.TabStop = False
        '
        'ValiAD5
        '
        Me.ValiAD5.Location = New System.Drawing.Point(834, 187)
        Me.ValiAD5.Name = "ValiAD5"
        Me.ValiAD5.Size = New System.Drawing.Size(16, 16)
        Me.ValiAD5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ValiAD5.TabIndex = 88
        Me.ValiAD5.TabStop = False
        '
        'ValiAD4
        '
        Me.ValiAD4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ValiAD4.Location = New System.Drawing.Point(834, 155)
        Me.ValiAD4.Name = "ValiAD4"
        Me.ValiAD4.Size = New System.Drawing.Size(16, 16)
        Me.ValiAD4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ValiAD4.TabIndex = 87
        Me.ValiAD4.TabStop = False
        '
        'ValiAD3
        '
        Me.ValiAD3.Location = New System.Drawing.Point(834, 122)
        Me.ValiAD3.Name = "ValiAD3"
        Me.ValiAD3.Size = New System.Drawing.Size(16, 16)
        Me.ValiAD3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ValiAD3.TabIndex = 86
        Me.ValiAD3.TabStop = False
        '
        'ValiAD2
        '
        Me.ValiAD2.Location = New System.Drawing.Point(834, 90)
        Me.ValiAD2.Name = "ValiAD2"
        Me.ValiAD2.Size = New System.Drawing.Size(16, 16)
        Me.ValiAD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ValiAD2.TabIndex = 85
        Me.ValiAD2.TabStop = False
        '
        'ValiAD1
        '
        Me.ValiAD1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ValiAD1.Location = New System.Drawing.Point(834, 58)
        Me.ValiAD1.Name = "ValiAD1"
        Me.ValiAD1.Size = New System.Drawing.Size(16, 16)
        Me.ValiAD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ValiAD1.TabIndex = 84
        Me.ValiAD1.TabStop = False
        '
        'IPAd1
        '
        Me.IPAd1.BackColor = System.Drawing.Color.Gainsboro
        Me.IPAd1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPAd1.Location = New System.Drawing.Point(699, 53)
        Me.IPAd1.Name = "IPAd1"
        Me.IPAd1.ReadOnly = True
        Me.IPAd1.Size = New System.Drawing.Size(129, 26)
        Me.IPAd1.TabIndex = 1
        '
        'Name_set_lbl7
        '
        Me.Name_set_lbl7.AutoSize = True
        Me.Name_set_lbl7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_set_lbl7.ForeColor = System.Drawing.Color.Lime
        Me.Name_set_lbl7.Location = New System.Drawing.Point(278, 55)
        Me.Name_set_lbl7.Name = "Name_set_lbl7"
        Me.Name_set_lbl7.Size = New System.Drawing.Size(106, 19)
        Me.Name_set_lbl7.TabIndex = 70
        Me.Name_set_lbl7.Text = "IP Address &7:"
        '
        'Ipname_set7
        '
        Me.Ipname_set7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ipname_set7.Location = New System.Drawing.Point(404, 53)
        Me.Ipname_set7.Name = "Ipname_set7"
        Me.Ipname_set7.Size = New System.Drawing.Size(129, 26)
        Me.Ipname_set7.TabIndex = 19
        '
        'Name_set_lbl8
        '
        Me.Name_set_lbl8.AutoSize = True
        Me.Name_set_lbl8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_set_lbl8.ForeColor = System.Drawing.Color.Lime
        Me.Name_set_lbl8.Location = New System.Drawing.Point(278, 87)
        Me.Name_set_lbl8.Name = "Name_set_lbl8"
        Me.Name_set_lbl8.Size = New System.Drawing.Size(106, 19)
        Me.Name_set_lbl8.TabIndex = 72
        Me.Name_set_lbl8.Text = "IP Address &8:"
        '
        'Name_set_lbl10
        '
        Me.Name_set_lbl10.AutoSize = True
        Me.Name_set_lbl10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_set_lbl10.ForeColor = System.Drawing.Color.Lime
        Me.Name_set_lbl10.Location = New System.Drawing.Point(278, 152)
        Me.Name_set_lbl10.Name = "Name_set_lbl10"
        Me.Name_set_lbl10.Size = New System.Drawing.Size(115, 19)
        Me.Name_set_lbl10.TabIndex = 76
        Me.Name_set_lbl10.Text = "IP Address 1&0:"
        '
        'Ipname_set10
        '
        Me.Ipname_set10.BackColor = System.Drawing.SystemColors.Control
        Me.Ipname_set10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ipname_set10.Location = New System.Drawing.Point(404, 150)
        Me.Ipname_set10.Name = "Ipname_set10"
        Me.Ipname_set10.Size = New System.Drawing.Size(129, 26)
        Me.Ipname_set10.TabIndex = 22
        '
        'Ipname_set8
        '
        Me.Ipname_set8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ipname_set8.Location = New System.Drawing.Point(404, 85)
        Me.Ipname_set8.Name = "Ipname_set8"
        Me.Ipname_set8.Size = New System.Drawing.Size(129, 26)
        Me.Ipname_set8.TabIndex = 20
        '
        'Name_set_lbl11
        '
        Me.Name_set_lbl11.AutoSize = True
        Me.Name_set_lbl11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_set_lbl11.ForeColor = System.Drawing.Color.Lime
        Me.Name_set_lbl11.Location = New System.Drawing.Point(278, 184)
        Me.Name_set_lbl11.Name = "Name_set_lbl11"
        Me.Name_set_lbl11.Size = New System.Drawing.Size(115, 19)
        Me.Name_set_lbl11.TabIndex = 78
        Me.Name_set_lbl11.Text = "IP Address 1&1:"
        '
        'Ipname_set11
        '
        Me.Ipname_set11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ipname_set11.Location = New System.Drawing.Point(404, 182)
        Me.Ipname_set11.Name = "Ipname_set11"
        Me.Ipname_set11.Size = New System.Drawing.Size(129, 26)
        Me.Ipname_set11.TabIndex = 23
        '
        'Name_set_lbl9
        '
        Me.Name_set_lbl9.AutoSize = True
        Me.Name_set_lbl9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_set_lbl9.ForeColor = System.Drawing.Color.Lime
        Me.Name_set_lbl9.Location = New System.Drawing.Point(278, 119)
        Me.Name_set_lbl9.Name = "Name_set_lbl9"
        Me.Name_set_lbl9.Size = New System.Drawing.Size(106, 19)
        Me.Name_set_lbl9.TabIndex = 74
        Me.Name_set_lbl9.Text = "IP Address &9:"
        '
        'Name_set_lbl12
        '
        Me.Name_set_lbl12.AutoSize = True
        Me.Name_set_lbl12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_set_lbl12.ForeColor = System.Drawing.Color.Lime
        Me.Name_set_lbl12.Location = New System.Drawing.Point(278, 216)
        Me.Name_set_lbl12.Name = "Name_set_lbl12"
        Me.Name_set_lbl12.Size = New System.Drawing.Size(115, 19)
        Me.Name_set_lbl12.TabIndex = 80
        Me.Name_set_lbl12.Text = "IP Address &12:"
        '
        'Ipname_set9
        '
        Me.Ipname_set9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ipname_set9.Location = New System.Drawing.Point(404, 117)
        Me.Ipname_set9.Name = "Ipname_set9"
        Me.Ipname_set9.Size = New System.Drawing.Size(129, 26)
        Me.Ipname_set9.TabIndex = 21
        '
        'Ipname_set12
        '
        Me.Ipname_set12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ipname_set12.Location = New System.Drawing.Point(404, 214)
        Me.Ipname_set12.Name = "Ipname_set12"
        Me.Ipname_set12.Size = New System.Drawing.Size(129, 26)
        Me.Ipname_set12.TabIndex = 24
        '
        'IpAdName7
        '
        Me.IpAdName7.AutoSize = True
        Me.IpAdName7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpAdName7.ForeColor = System.Drawing.Color.Lime
        Me.IpAdName7.Location = New System.Drawing.Point(872, 55)
        Me.IpAdName7.Name = "IpAdName7"
        Me.IpAdName7.Size = New System.Drawing.Size(106, 19)
        Me.IpAdName7.TabIndex = 58
        Me.IpAdName7.Text = "IP Address &7:"
        '
        'IPAd7
        '
        Me.IPAd7.BackColor = System.Drawing.Color.Gainsboro
        Me.IPAd7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPAd7.Location = New System.Drawing.Point(998, 53)
        Me.IPAd7.Name = "IPAd7"
        Me.IPAd7.ReadOnly = True
        Me.IPAd7.Size = New System.Drawing.Size(129, 26)
        Me.IPAd7.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Lime
        Me.Label7.Location = New System.Drawing.Point(839, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 18)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Set IP"
        '
        'IpAdName8
        '
        Me.IpAdName8.AutoSize = True
        Me.IpAdName8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpAdName8.ForeColor = System.Drawing.Color.Lime
        Me.IpAdName8.Location = New System.Drawing.Point(872, 87)
        Me.IpAdName8.Name = "IpAdName8"
        Me.IpAdName8.Size = New System.Drawing.Size(106, 19)
        Me.IpAdName8.TabIndex = 60
        Me.IpAdName8.Text = "IP Address &8:"
        '
        'IpAdName10
        '
        Me.IpAdName10.AutoSize = True
        Me.IpAdName10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpAdName10.ForeColor = System.Drawing.Color.Lime
        Me.IpAdName10.Location = New System.Drawing.Point(872, 152)
        Me.IpAdName10.Name = "IpAdName10"
        Me.IpAdName10.Size = New System.Drawing.Size(115, 19)
        Me.IpAdName10.TabIndex = 64
        Me.IpAdName10.Text = "IP Address 1&0:"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(347, 271)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(164, 39)
        Me.SimpleButton2.TabIndex = 0
        Me.SimpleButton2.Text = "Exit Settings"
        '
        'IPAd10
        '
        Me.IPAd10.BackColor = System.Drawing.Color.Gainsboro
        Me.IPAd10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPAd10.Location = New System.Drawing.Point(998, 150)
        Me.IPAd10.Name = "IPAd10"
        Me.IPAd10.ReadOnly = True
        Me.IPAd10.Size = New System.Drawing.Size(129, 26)
        Me.IPAd10.TabIndex = 10
        '
        'Change_name_but_Ok
        '
        Me.Change_name_but_Ok.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Change_name_but_Ok.Appearance.Options.UseForeColor = True
        Me.Change_name_but_Ok.ImageOptions.Image = CType(resources.GetObject("Change_name_but_Ok.ImageOptions.Image"), System.Drawing.Image)
        Me.Change_name_but_Ok.Location = New System.Drawing.Point(45, 271)
        Me.Change_name_but_Ok.Name = "Change_name_but_Ok"
        Me.Change_name_but_Ok.Size = New System.Drawing.Size(164, 39)
        Me.Change_name_but_Ok.TabIndex = 0
        Me.Change_name_but_Ok.Text = "Apply Settings"
        '
        'IPAd8
        '
        Me.IPAd8.BackColor = System.Drawing.Color.Gainsboro
        Me.IPAd8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPAd8.Location = New System.Drawing.Point(998, 85)
        Me.IPAd8.Name = "IPAd8"
        Me.IPAd8.ReadOnly = True
        Me.IPAd8.Size = New System.Drawing.Size(129, 26)
        Me.IPAd8.TabIndex = 8
        '
        'IpAdName11
        '
        Me.IpAdName11.AutoSize = True
        Me.IpAdName11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpAdName11.ForeColor = System.Drawing.Color.Lime
        Me.IpAdName11.Location = New System.Drawing.Point(872, 184)
        Me.IpAdName11.Name = "IpAdName11"
        Me.IpAdName11.Size = New System.Drawing.Size(115, 19)
        Me.IpAdName11.TabIndex = 66
        Me.IpAdName11.Text = "IP Address 1&1:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Lime
        Me.Label10.Location = New System.Drawing.Point(193, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 18)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Change IP Adress Name"
        '
        'Ipname_set6
        '
        Me.Ipname_set6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ipname_set6.Location = New System.Drawing.Point(136, 214)
        Me.Ipname_set6.Name = "Ipname_set6"
        Me.Ipname_set6.Size = New System.Drawing.Size(129, 26)
        Me.Ipname_set6.TabIndex = 18
        '
        'IPAd11
        '
        Me.IPAd11.BackColor = System.Drawing.Color.Gainsboro
        Me.IPAd11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPAd11.Location = New System.Drawing.Point(998, 182)
        Me.IPAd11.Name = "IPAd11"
        Me.IPAd11.ReadOnly = True
        Me.IPAd11.Size = New System.Drawing.Size(129, 26)
        Me.IPAd11.TabIndex = 11
        '
        'IpAdName9
        '
        Me.IpAdName9.AutoSize = True
        Me.IpAdName9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpAdName9.ForeColor = System.Drawing.Color.Lime
        Me.IpAdName9.Location = New System.Drawing.Point(872, 119)
        Me.IpAdName9.Name = "IpAdName9"
        Me.IpAdName9.Size = New System.Drawing.Size(106, 19)
        Me.IpAdName9.TabIndex = 62
        Me.IpAdName9.Text = "IP Address &9:"
        '
        'Name_set_lbl6
        '
        Me.Name_set_lbl6.AutoSize = True
        Me.Name_set_lbl6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_set_lbl6.ForeColor = System.Drawing.Color.Lime
        Me.Name_set_lbl6.Location = New System.Drawing.Point(9, 216)
        Me.Name_set_lbl6.Name = "Name_set_lbl6"
        Me.Name_set_lbl6.Size = New System.Drawing.Size(106, 19)
        Me.Name_set_lbl6.TabIndex = 50
        Me.Name_set_lbl6.Text = "IP Address &6:"
        '
        'IpAdName12
        '
        Me.IpAdName12.AutoSize = True
        Me.IpAdName12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpAdName12.ForeColor = System.Drawing.Color.Lime
        Me.IpAdName12.Location = New System.Drawing.Point(872, 216)
        Me.IpAdName12.Name = "IpAdName12"
        Me.IpAdName12.Size = New System.Drawing.Size(115, 19)
        Me.IpAdName12.TabIndex = 68
        Me.IpAdName12.Text = "IP Address 1&2:"
        '
        'Ipname_set5
        '
        Me.Ipname_set5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ipname_set5.Location = New System.Drawing.Point(136, 182)
        Me.Ipname_set5.Name = "Ipname_set5"
        Me.Ipname_set5.Size = New System.Drawing.Size(129, 26)
        Me.Ipname_set5.TabIndex = 17
        '
        'IPAd9
        '
        Me.IPAd9.BackColor = System.Drawing.Color.Gainsboro
        Me.IPAd9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPAd9.Location = New System.Drawing.Point(998, 117)
        Me.IPAd9.Name = "IPAd9"
        Me.IPAd9.ReadOnly = True
        Me.IPAd9.Size = New System.Drawing.Size(129, 26)
        Me.IPAd9.TabIndex = 9
        '
        'IPAd12
        '
        Me.IPAd12.BackColor = System.Drawing.Color.Gainsboro
        Me.IPAd12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPAd12.Location = New System.Drawing.Point(998, 214)
        Me.IPAd12.Name = "IPAd12"
        Me.IPAd12.ReadOnly = True
        Me.IPAd12.Size = New System.Drawing.Size(129, 26)
        Me.IPAd12.TabIndex = 12
        '
        'Name_set_lbl5
        '
        Me.Name_set_lbl5.AutoSize = True
        Me.Name_set_lbl5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_set_lbl5.ForeColor = System.Drawing.Color.Lime
        Me.Name_set_lbl5.Location = New System.Drawing.Point(9, 184)
        Me.Name_set_lbl5.Name = "Name_set_lbl5"
        Me.Name_set_lbl5.Size = New System.Drawing.Size(106, 19)
        Me.Name_set_lbl5.TabIndex = 48
        Me.Name_set_lbl5.Text = "IP Address &5:"
        '
        'Ipname_set4
        '
        Me.Ipname_set4.BackColor = System.Drawing.SystemColors.Control
        Me.Ipname_set4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ipname_set4.Location = New System.Drawing.Point(136, 150)
        Me.Ipname_set4.Name = "Ipname_set4"
        Me.Ipname_set4.Size = New System.Drawing.Size(129, 26)
        Me.Ipname_set4.TabIndex = 16
        '
        'Name_set_lbl4
        '
        Me.Name_set_lbl4.AutoSize = True
        Me.Name_set_lbl4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_set_lbl4.ForeColor = System.Drawing.Color.Lime
        Me.Name_set_lbl4.Location = New System.Drawing.Point(9, 152)
        Me.Name_set_lbl4.Name = "Name_set_lbl4"
        Me.Name_set_lbl4.Size = New System.Drawing.Size(106, 19)
        Me.Name_set_lbl4.TabIndex = 46
        Me.Name_set_lbl4.Text = "IP Address &4:"
        '
        'Ipname_set3
        '
        Me.Ipname_set3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ipname_set3.Location = New System.Drawing.Point(136, 117)
        Me.Ipname_set3.Name = "Ipname_set3"
        Me.Ipname_set3.Size = New System.Drawing.Size(129, 26)
        Me.Ipname_set3.TabIndex = 15
        '
        'Name_set_lbl3
        '
        Me.Name_set_lbl3.AutoSize = True
        Me.Name_set_lbl3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_set_lbl3.ForeColor = System.Drawing.Color.Lime
        Me.Name_set_lbl3.Location = New System.Drawing.Point(9, 119)
        Me.Name_set_lbl3.Name = "Name_set_lbl3"
        Me.Name_set_lbl3.Size = New System.Drawing.Size(106, 19)
        Me.Name_set_lbl3.TabIndex = 44
        Me.Name_set_lbl3.Text = "IP Address &3:"
        '
        'Ipname_set2
        '
        Me.Ipname_set2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ipname_set2.Location = New System.Drawing.Point(136, 85)
        Me.Ipname_set2.Name = "Ipname_set2"
        Me.Ipname_set2.Size = New System.Drawing.Size(129, 26)
        Me.Ipname_set2.TabIndex = 14
        '
        'Name_set_lbl2
        '
        Me.Name_set_lbl2.AutoSize = True
        Me.Name_set_lbl2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_set_lbl2.ForeColor = System.Drawing.Color.Lime
        Me.Name_set_lbl2.Location = New System.Drawing.Point(9, 87)
        Me.Name_set_lbl2.Name = "Name_set_lbl2"
        Me.Name_set_lbl2.Size = New System.Drawing.Size(106, 19)
        Me.Name_set_lbl2.TabIndex = 42
        Me.Name_set_lbl2.Text = "IP Address &2:"
        '
        'Ipname_set1
        '
        Me.Ipname_set1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ipname_set1.Location = New System.Drawing.Point(136, 53)
        Me.Ipname_set1.Name = "Ipname_set1"
        Me.Ipname_set1.Size = New System.Drawing.Size(129, 26)
        Me.Ipname_set1.TabIndex = 13
        '
        'Name_set_lbl1
        '
        Me.Name_set_lbl1.AutoSize = True
        Me.Name_set_lbl1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_set_lbl1.ForeColor = System.Drawing.Color.Lime
        Me.Name_set_lbl1.Location = New System.Drawing.Point(9, 55)
        Me.Name_set_lbl1.Name = "Name_set_lbl1"
        Me.Name_set_lbl1.Size = New System.Drawing.Size(106, 19)
        Me.Name_set_lbl1.TabIndex = 40
        Me.Name_set_lbl1.Text = "IP Address &1:"
        '
        'Start_But_Info
        '
        Me.Start_But_Info.AutoSize = True
        Me.Start_But_Info.ForeColor = System.Drawing.Color.OrangeRed
        Me.Start_But_Info.Location = New System.Drawing.Point(746, 243)
        Me.Start_But_Info.Name = "Start_But_Info"
        Me.Start_But_Info.Size = New System.Drawing.Size(273, 13)
        Me.Start_But_Info.TabIndex = 78
        Me.Start_But_Info.Text = "Please Wait 5 Seconds Before Pushing The Start Button"
        Me.Start_But_Info.Visible = False
        '
        'SeparatorControl6
        '
        Me.SeparatorControl6.LineColor = System.Drawing.Color.Black
        Me.SeparatorControl6.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl6.Location = New System.Drawing.Point(550, 3)
        Me.SeparatorControl6.Name = "SeparatorControl6"
        Me.SeparatorControl6.Size = New System.Drawing.Size(28, 315)
        Me.SeparatorControl6.TabIndex = 56
        '
        'SeparatorControl7
        '
        Me.SeparatorControl7.LineColor = System.Drawing.Color.Black
        Me.SeparatorControl7.Location = New System.Drawing.Point(3, 247)
        Me.SeparatorControl7.Name = "SeparatorControl7"
        Me.SeparatorControl7.Size = New System.Drawing.Size(1159, 23)
        Me.SeparatorControl7.TabIndex = 82
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarEditItem1, Me.BarEditItem2, Me.BarEditItem3, Me.BarEditItem4, Me.BarEditItem5, Me.BarEditItem6, Me.BarEditItem7, Me.BarEditItem8, Me.BarEditItem9, Me.BarEditItem10, Me.BarEditItem11, Me.BarEditItem12, Me.BarEditItem13, Me.BarEditItem14, Me.BarEditItem15, Me.BarEditItem16, Me.BarEditItem17, Me.BarEditItem18, Me.BarSubItem1, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 20
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1376, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 139)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1376, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 139)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1376, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 139)
        '
        'BarEditItem1
        '
        Me.BarEditItem1.AccessibleName = "TSIPNAME1"
        Me.BarEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem1.Edit = Me.RepositoryItemTextEdit1
        Me.BarEditItem1.EditValue = "IP Adress 1"
        Me.BarEditItem1.Hint = Nothing
        Me.BarEditItem1.Id = 0
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem2
        '
        Me.BarEditItem2.AccessibleName = "TSIPAD1"
        Me.BarEditItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem2.Edit = Me.RepositoryItemTextEdit2
        Me.BarEditItem2.EditValue = ""
        Me.BarEditItem2.Hint = Nothing
        Me.BarEditItem2.Id = 1
        Me.BarEditItem2.Name = "BarEditItem2"
        Me.BarEditItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem3
        '
        Me.BarEditItem3.AccessibleName = "TSPING1"
        Me.BarEditItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem3.Edit = Me.RepositoryItemTextEdit3
        Me.BarEditItem3.EditValue = ""
        Me.BarEditItem3.Hint = Nothing
        Me.BarEditItem3.Id = 2
        Me.BarEditItem3.Name = "BarEditItem3"
        Me.BarEditItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem4
        '
        Me.BarEditItem4.AccessibleName = "TSIPNAME2"
        Me.BarEditItem4.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem4.Edit = Me.RepositoryItemTextEdit4
        Me.BarEditItem4.EditValue = "IP Adress 2"
        Me.BarEditItem4.Hint = Nothing
        Me.BarEditItem4.Id = 3
        Me.BarEditItem4.Name = "BarEditItem4"
        Me.BarEditItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem5
        '
        Me.BarEditItem5.AccessibleName = "TSIPAD2"
        Me.BarEditItem5.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem5.Edit = Me.RepositoryItemTextEdit5
        Me.BarEditItem5.EditValue = ""
        Me.BarEditItem5.Hint = Nothing
        Me.BarEditItem5.Id = 4
        Me.BarEditItem5.Name = "BarEditItem5"
        Me.BarEditItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem6
        '
        Me.BarEditItem6.AccessibleName = "TSPING2"
        Me.BarEditItem6.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem6.Edit = Me.RepositoryItemTextEdit6
        Me.BarEditItem6.EditValue = ""
        Me.BarEditItem6.Hint = Nothing
        Me.BarEditItem6.Id = 5
        Me.BarEditItem6.Name = "BarEditItem6"
        Me.BarEditItem6.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem7
        '
        Me.BarEditItem7.AccessibleName = "TSIPNAME3"
        Me.BarEditItem7.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem7.Edit = Me.RepositoryItemTextEdit7
        Me.BarEditItem7.EditValue = "IP Adress 3"
        Me.BarEditItem7.Hint = Nothing
        Me.BarEditItem7.Id = 6
        Me.BarEditItem7.Name = "BarEditItem7"
        Me.BarEditItem7.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem8
        '
        Me.BarEditItem8.AccessibleName = "TSIPAD3"
        Me.BarEditItem8.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem8.Edit = Me.RepositoryItemTextEdit8
        Me.BarEditItem8.EditValue = ""
        Me.BarEditItem8.Hint = Nothing
        Me.BarEditItem8.Id = 7
        Me.BarEditItem8.Name = "BarEditItem8"
        Me.BarEditItem8.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem9
        '
        Me.BarEditItem9.AccessibleName = "TSPING3"
        Me.BarEditItem9.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem9.Edit = Me.RepositoryItemTextEdit9
        Me.BarEditItem9.EditValue = ""
        Me.BarEditItem9.Hint = Nothing
        Me.BarEditItem9.Id = 8
        Me.BarEditItem9.Name = "BarEditItem9"
        Me.BarEditItem9.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem10
        '
        Me.BarEditItem10.AccessibleName = "TSIPNAME4"
        Me.BarEditItem10.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem10.Edit = Me.RepositoryItemTextEdit10
        Me.BarEditItem10.EditValue = "IP Adress 4"
        Me.BarEditItem10.Hint = Nothing
        Me.BarEditItem10.Id = 9
        Me.BarEditItem10.Name = "BarEditItem10"
        Me.BarEditItem10.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem11
        '
        Me.BarEditItem11.AccessibleName = "TSIPAD4"
        Me.BarEditItem11.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem11.Edit = Me.RepositoryItemTextEdit11
        Me.BarEditItem11.EditValue = ""
        Me.BarEditItem11.Hint = Nothing
        Me.BarEditItem11.Id = 10
        Me.BarEditItem11.Name = "BarEditItem11"
        Me.BarEditItem11.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem12
        '
        Me.BarEditItem12.AccessibleName = "TSPING4"
        Me.BarEditItem12.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem12.Edit = Me.RepositoryItemTextEdit12
        Me.BarEditItem12.EditValue = ""
        Me.BarEditItem12.Hint = Nothing
        Me.BarEditItem12.Id = 11
        Me.BarEditItem12.Name = "BarEditItem12"
        Me.BarEditItem12.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem13
        '
        Me.BarEditItem13.AccessibleName = "TSIPNAME5"
        Me.BarEditItem13.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem13.Edit = Me.RepositoryItemTextEdit13
        Me.BarEditItem13.EditValue = "IP Adress 5"
        Me.BarEditItem13.Hint = Nothing
        Me.BarEditItem13.Id = 12
        Me.BarEditItem13.Name = "BarEditItem13"
        Me.BarEditItem13.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem14
        '
        Me.BarEditItem14.AccessibleName = "TSIPAD5"
        Me.BarEditItem14.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem14.Edit = Me.RepositoryItemTextEdit14
        Me.BarEditItem14.EditValue = ""
        Me.BarEditItem14.Hint = Nothing
        Me.BarEditItem14.Id = 13
        Me.BarEditItem14.Name = "BarEditItem14"
        Me.BarEditItem14.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem15
        '
        Me.BarEditItem15.AccessibleName = "TSPING5"
        Me.BarEditItem15.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem15.Edit = Me.RepositoryItemTextEdit15
        Me.BarEditItem15.EditValue = ""
        Me.BarEditItem15.Hint = Nothing
        Me.BarEditItem15.Id = 14
        Me.BarEditItem15.Name = "BarEditItem15"
        Me.BarEditItem15.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem16
        '
        Me.BarEditItem16.AccessibleName = "TSIPNAME6"
        Me.BarEditItem16.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem16.Edit = Me.RepositoryItemTextEdit16
        Me.BarEditItem16.EditValue = "IP Adress 6"
        Me.BarEditItem16.Hint = Nothing
        Me.BarEditItem16.Id = 15
        Me.BarEditItem16.Name = "BarEditItem16"
        Me.BarEditItem16.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem17
        '
        Me.BarEditItem17.AccessibleName = "TSIPAD6"
        Me.BarEditItem17.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem17.Edit = Me.RepositoryItemTextEdit17
        Me.BarEditItem17.EditValue = ""
        Me.BarEditItem17.Hint = Nothing
        Me.BarEditItem17.Id = 16
        Me.BarEditItem17.Name = "BarEditItem17"
        Me.BarEditItem17.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarEditItem18
        '
        Me.BarEditItem18.AccessibleName = "TSPING6"
        Me.BarEditItem18.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarEditItem18.Edit = Me.RepositoryItemTextEdit18
        Me.BarEditItem18.EditValue = ""
        Me.BarEditItem18.Hint = Nothing
        Me.BarEditItem18.Id = 17
        Me.BarEditItem18.Name = "BarEditItem18"
        Me.BarEditItem18.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarSubItem1
        '
        Me.BarSubItem1.AccessibleName = "PingsToolStripMenuItem"
        Me.BarSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarSubItem1.Caption = "Pings"
        Me.BarSubItem1.Hint = Nothing
        Me.BarSubItem1.Id = 18
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem13, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem15), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem16, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem18)})
        Me.BarSubItem1.Name = "BarSubItem1"
        Me.BarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.AccessibleName = "ExitToolStripMenuItem"
        Me.BarButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarButtonItem1.Caption = "Exit"
        Me.BarButtonItem1.Hint = Nothing
        Me.BarButtonItem1.Id = 19
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(86, 241)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(123, 34)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Clear All"
        '
        'Clearpopup
        '
        Me.Clearpopup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Clearpopup.Controls.Add(Me.SimpleButton3)
        Me.Clearpopup.Controls.Add(Me.Ip_clear_12)
        Me.Clearpopup.Controls.Add(Me.Ip_clear_11)
        Me.Clearpopup.Controls.Add(Me.Ip_clear_10)
        Me.Clearpopup.Controls.Add(Me.Ip_clear_9)
        Me.Clearpopup.Controls.Add(Me.Ip_clear_8)
        Me.Clearpopup.Controls.Add(Me.Ip_clear_7)
        Me.Clearpopup.Controls.Add(Me.Ip_clear_6)
        Me.Clearpopup.Controls.Add(Me.Ip_clear_5)
        Me.Clearpopup.Controls.Add(Me.Ip_clear_4)
        Me.Clearpopup.Controls.Add(Me.Ip_clear_3)
        Me.Clearpopup.Controls.Add(Me.Ip_clear_2)
        Me.Clearpopup.Controls.Add(Me.Ip_clear_1)
        Me.Clearpopup.Controls.Add(Me.Name_clear_12)
        Me.Clearpopup.Controls.Add(Me.Name_clear_11)
        Me.Clearpopup.Controls.Add(Me.Name_clear_10)
        Me.Clearpopup.Controls.Add(Me.Name_clear_9)
        Me.Clearpopup.Controls.Add(Me.Name_clear_8)
        Me.Clearpopup.Controls.Add(Me.Name_clear_7)
        Me.Clearpopup.Controls.Add(Me.Name_clear_6)
        Me.Clearpopup.Controls.Add(Me.Name_clear_5)
        Me.Clearpopup.Controls.Add(Me.Name_clear_4)
        Me.Clearpopup.Controls.Add(Me.Name_clear_3)
        Me.Clearpopup.Controls.Add(Me.Name_clear_2)
        Me.Clearpopup.Controls.Add(Me.Label3)
        Me.Clearpopup.Controls.Add(Me.Label2)
        Me.Clearpopup.Controls.Add(Me.Name_clear_1)
        Me.Clearpopup.Controls.Add(Me.SeparatorControl5)
        Me.Clearpopup.Controls.Add(Me.SimpleButton1)
        Me.Clearpopup.Location = New System.Drawing.Point(90, 428)
        Me.Clearpopup.Manager = Me.BarManager1
        Me.Clearpopup.Name = "Clearpopup"
        Me.Clearpopup.Size = New System.Drawing.Size(701, 286)
        Me.Clearpopup.TabIndex = 149
        Me.Clearpopup.Visible = False
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.SimpleButton3.Appearance.Options.UseForeColor = True
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(425, 241)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(123, 34)
        Me.SimpleButton3.TabIndex = 150
        Me.SimpleButton3.Text = "Clear Selected"
        '
        'Ip_clear_12
        '
        Me.Ip_clear_12.Location = New System.Drawing.Point(530, 200)
        Me.Ip_clear_12.MenuManager = Me.BarManager1
        Me.Ip_clear_12.Name = "Ip_clear_12"
        Me.Ip_clear_12.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Ip_clear_12.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Ip_clear_12.Properties.Appearance.Options.UseFont = True
        Me.Ip_clear_12.Properties.Appearance.Options.UseForeColor = True
        Me.Ip_clear_12.Properties.Caption = "CheckEdit13"
        Me.Ip_clear_12.Size = New System.Drawing.Size(142, 23)
        Me.Ip_clear_12.TabIndex = 99
        '
        'Ip_clear_11
        '
        Me.Ip_clear_11.Location = New System.Drawing.Point(530, 171)
        Me.Ip_clear_11.MenuManager = Me.BarManager1
        Me.Ip_clear_11.Name = "Ip_clear_11"
        Me.Ip_clear_11.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Ip_clear_11.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Ip_clear_11.Properties.Appearance.Options.UseFont = True
        Me.Ip_clear_11.Properties.Appearance.Options.UseForeColor = True
        Me.Ip_clear_11.Properties.Caption = "CheckEdit14"
        Me.Ip_clear_11.Size = New System.Drawing.Size(142, 23)
        Me.Ip_clear_11.TabIndex = 98
        '
        'Ip_clear_10
        '
        Me.Ip_clear_10.Location = New System.Drawing.Point(530, 142)
        Me.Ip_clear_10.MenuManager = Me.BarManager1
        Me.Ip_clear_10.Name = "Ip_clear_10"
        Me.Ip_clear_10.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Ip_clear_10.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Ip_clear_10.Properties.Appearance.Options.UseFont = True
        Me.Ip_clear_10.Properties.Appearance.Options.UseForeColor = True
        Me.Ip_clear_10.Properties.Caption = "CheckEdit15"
        Me.Ip_clear_10.Size = New System.Drawing.Size(142, 23)
        Me.Ip_clear_10.TabIndex = 97
        '
        'Ip_clear_9
        '
        Me.Ip_clear_9.Location = New System.Drawing.Point(530, 113)
        Me.Ip_clear_9.MenuManager = Me.BarManager1
        Me.Ip_clear_9.Name = "Ip_clear_9"
        Me.Ip_clear_9.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Ip_clear_9.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Ip_clear_9.Properties.Appearance.Options.UseFont = True
        Me.Ip_clear_9.Properties.Appearance.Options.UseForeColor = True
        Me.Ip_clear_9.Properties.Caption = "CheckEdit16"
        Me.Ip_clear_9.Size = New System.Drawing.Size(142, 23)
        Me.Ip_clear_9.TabIndex = 96
        '
        'Ip_clear_8
        '
        Me.Ip_clear_8.Location = New System.Drawing.Point(530, 84)
        Me.Ip_clear_8.MenuManager = Me.BarManager1
        Me.Ip_clear_8.Name = "Ip_clear_8"
        Me.Ip_clear_8.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Ip_clear_8.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Ip_clear_8.Properties.Appearance.Options.UseFont = True
        Me.Ip_clear_8.Properties.Appearance.Options.UseForeColor = True
        Me.Ip_clear_8.Properties.Caption = "CheckEdit17"
        Me.Ip_clear_8.Size = New System.Drawing.Size(142, 23)
        Me.Ip_clear_8.TabIndex = 95
        '
        'Ip_clear_7
        '
        Me.Ip_clear_7.Location = New System.Drawing.Point(530, 55)
        Me.Ip_clear_7.MenuManager = Me.BarManager1
        Me.Ip_clear_7.Name = "Ip_clear_7"
        Me.Ip_clear_7.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Ip_clear_7.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Ip_clear_7.Properties.Appearance.Options.UseFont = True
        Me.Ip_clear_7.Properties.Appearance.Options.UseForeColor = True
        Me.Ip_clear_7.Properties.Caption = "CheckEdit18"
        Me.Ip_clear_7.Size = New System.Drawing.Size(142, 23)
        Me.Ip_clear_7.TabIndex = 94
        '
        'Ip_clear_6
        '
        Me.Ip_clear_6.Location = New System.Drawing.Point(347, 200)
        Me.Ip_clear_6.MenuManager = Me.BarManager1
        Me.Ip_clear_6.Name = "Ip_clear_6"
        Me.Ip_clear_6.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Ip_clear_6.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Ip_clear_6.Properties.Appearance.Options.UseFont = True
        Me.Ip_clear_6.Properties.Appearance.Options.UseForeColor = True
        Me.Ip_clear_6.Properties.Caption = "CheckEdit19"
        Me.Ip_clear_6.Size = New System.Drawing.Size(142, 23)
        Me.Ip_clear_6.TabIndex = 93
        '
        'Ip_clear_5
        '
        Me.Ip_clear_5.Location = New System.Drawing.Point(347, 171)
        Me.Ip_clear_5.MenuManager = Me.BarManager1
        Me.Ip_clear_5.Name = "Ip_clear_5"
        Me.Ip_clear_5.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Ip_clear_5.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Ip_clear_5.Properties.Appearance.Options.UseFont = True
        Me.Ip_clear_5.Properties.Appearance.Options.UseForeColor = True
        Me.Ip_clear_5.Properties.Caption = "CheckEdit20"
        Me.Ip_clear_5.Size = New System.Drawing.Size(142, 23)
        Me.Ip_clear_5.TabIndex = 92
        '
        'Ip_clear_4
        '
        Me.Ip_clear_4.Location = New System.Drawing.Point(347, 142)
        Me.Ip_clear_4.MenuManager = Me.BarManager1
        Me.Ip_clear_4.Name = "Ip_clear_4"
        Me.Ip_clear_4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Ip_clear_4.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Ip_clear_4.Properties.Appearance.Options.UseFont = True
        Me.Ip_clear_4.Properties.Appearance.Options.UseForeColor = True
        Me.Ip_clear_4.Properties.Caption = "CheckEdit21"
        Me.Ip_clear_4.Size = New System.Drawing.Size(142, 23)
        Me.Ip_clear_4.TabIndex = 91
        '
        'Ip_clear_3
        '
        Me.Ip_clear_3.Location = New System.Drawing.Point(347, 113)
        Me.Ip_clear_3.MenuManager = Me.BarManager1
        Me.Ip_clear_3.Name = "Ip_clear_3"
        Me.Ip_clear_3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Ip_clear_3.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Ip_clear_3.Properties.Appearance.Options.UseFont = True
        Me.Ip_clear_3.Properties.Appearance.Options.UseForeColor = True
        Me.Ip_clear_3.Properties.Caption = "CheckEdit22"
        Me.Ip_clear_3.Size = New System.Drawing.Size(142, 23)
        Me.Ip_clear_3.TabIndex = 90
        '
        'Ip_clear_2
        '
        Me.Ip_clear_2.Location = New System.Drawing.Point(347, 84)
        Me.Ip_clear_2.MenuManager = Me.BarManager1
        Me.Ip_clear_2.Name = "Ip_clear_2"
        Me.Ip_clear_2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Ip_clear_2.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Ip_clear_2.Properties.Appearance.Options.UseFont = True
        Me.Ip_clear_2.Properties.Appearance.Options.UseForeColor = True
        Me.Ip_clear_2.Properties.Caption = "CheckEdit23"
        Me.Ip_clear_2.Size = New System.Drawing.Size(142, 23)
        Me.Ip_clear_2.TabIndex = 89
        '
        'Ip_clear_1
        '
        Me.Ip_clear_1.Location = New System.Drawing.Point(347, 55)
        Me.Ip_clear_1.MenuManager = Me.BarManager1
        Me.Ip_clear_1.Name = "Ip_clear_1"
        Me.Ip_clear_1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Ip_clear_1.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Ip_clear_1.Properties.Appearance.Options.UseFont = True
        Me.Ip_clear_1.Properties.Appearance.Options.UseForeColor = True
        Me.Ip_clear_1.Properties.Caption = "CheckEdit24"
        Me.Ip_clear_1.Size = New System.Drawing.Size(142, 23)
        Me.Ip_clear_1.TabIndex = 88
        '
        'Name_clear_12
        '
        Me.Name_clear_12.Location = New System.Drawing.Point(182, 200)
        Me.Name_clear_12.MenuManager = Me.BarManager1
        Me.Name_clear_12.Name = "Name_clear_12"
        Me.Name_clear_12.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Name_clear_12.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Name_clear_12.Properties.Appearance.Options.UseFont = True
        Me.Name_clear_12.Properties.Appearance.Options.UseForeColor = True
        Me.Name_clear_12.Properties.Caption = "CheckEdit12"
        Me.Name_clear_12.Size = New System.Drawing.Size(142, 23)
        Me.Name_clear_12.TabIndex = 87
        '
        'Name_clear_11
        '
        Me.Name_clear_11.Location = New System.Drawing.Point(182, 171)
        Me.Name_clear_11.MenuManager = Me.BarManager1
        Me.Name_clear_11.Name = "Name_clear_11"
        Me.Name_clear_11.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Name_clear_11.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Name_clear_11.Properties.Appearance.Options.UseFont = True
        Me.Name_clear_11.Properties.Appearance.Options.UseForeColor = True
        Me.Name_clear_11.Properties.Caption = "CheckEdit11"
        Me.Name_clear_11.Size = New System.Drawing.Size(142, 23)
        Me.Name_clear_11.TabIndex = 86
        '
        'Name_clear_10
        '
        Me.Name_clear_10.Location = New System.Drawing.Point(182, 142)
        Me.Name_clear_10.MenuManager = Me.BarManager1
        Me.Name_clear_10.Name = "Name_clear_10"
        Me.Name_clear_10.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Name_clear_10.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Name_clear_10.Properties.Appearance.Options.UseFont = True
        Me.Name_clear_10.Properties.Appearance.Options.UseForeColor = True
        Me.Name_clear_10.Properties.Caption = "CheckEdit10"
        Me.Name_clear_10.Size = New System.Drawing.Size(142, 23)
        Me.Name_clear_10.TabIndex = 85
        '
        'Name_clear_9
        '
        Me.Name_clear_9.Location = New System.Drawing.Point(182, 113)
        Me.Name_clear_9.MenuManager = Me.BarManager1
        Me.Name_clear_9.Name = "Name_clear_9"
        Me.Name_clear_9.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Name_clear_9.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Name_clear_9.Properties.Appearance.Options.UseFont = True
        Me.Name_clear_9.Properties.Appearance.Options.UseForeColor = True
        Me.Name_clear_9.Properties.Caption = "CheckEdit9"
        Me.Name_clear_9.Size = New System.Drawing.Size(142, 23)
        Me.Name_clear_9.TabIndex = 84
        '
        'Name_clear_8
        '
        Me.Name_clear_8.Location = New System.Drawing.Point(182, 84)
        Me.Name_clear_8.MenuManager = Me.BarManager1
        Me.Name_clear_8.Name = "Name_clear_8"
        Me.Name_clear_8.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Name_clear_8.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Name_clear_8.Properties.Appearance.Options.UseFont = True
        Me.Name_clear_8.Properties.Appearance.Options.UseForeColor = True
        Me.Name_clear_8.Properties.Caption = "CheckEdit8"
        Me.Name_clear_8.Size = New System.Drawing.Size(142, 23)
        Me.Name_clear_8.TabIndex = 83
        '
        'Name_clear_7
        '
        Me.Name_clear_7.Location = New System.Drawing.Point(182, 55)
        Me.Name_clear_7.MenuManager = Me.BarManager1
        Me.Name_clear_7.Name = "Name_clear_7"
        Me.Name_clear_7.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Name_clear_7.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Name_clear_7.Properties.Appearance.Options.UseFont = True
        Me.Name_clear_7.Properties.Appearance.Options.UseForeColor = True
        Me.Name_clear_7.Properties.Caption = "CheckEdit7"
        Me.Name_clear_7.Size = New System.Drawing.Size(142, 23)
        Me.Name_clear_7.TabIndex = 82
        '
        'Name_clear_6
        '
        Me.Name_clear_6.Location = New System.Drawing.Point(17, 200)
        Me.Name_clear_6.MenuManager = Me.BarManager1
        Me.Name_clear_6.Name = "Name_clear_6"
        Me.Name_clear_6.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Name_clear_6.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Name_clear_6.Properties.Appearance.Options.UseFont = True
        Me.Name_clear_6.Properties.Appearance.Options.UseForeColor = True
        Me.Name_clear_6.Properties.Caption = "CheckEdit6"
        Me.Name_clear_6.Size = New System.Drawing.Size(142, 23)
        Me.Name_clear_6.TabIndex = 81
        '
        'Name_clear_5
        '
        Me.Name_clear_5.Location = New System.Drawing.Point(17, 171)
        Me.Name_clear_5.MenuManager = Me.BarManager1
        Me.Name_clear_5.Name = "Name_clear_5"
        Me.Name_clear_5.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Name_clear_5.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Name_clear_5.Properties.Appearance.Options.UseFont = True
        Me.Name_clear_5.Properties.Appearance.Options.UseForeColor = True
        Me.Name_clear_5.Properties.Caption = "CheckEdit5"
        Me.Name_clear_5.Size = New System.Drawing.Size(142, 23)
        Me.Name_clear_5.TabIndex = 80
        '
        'Name_clear_4
        '
        Me.Name_clear_4.Location = New System.Drawing.Point(17, 142)
        Me.Name_clear_4.MenuManager = Me.BarManager1
        Me.Name_clear_4.Name = "Name_clear_4"
        Me.Name_clear_4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Name_clear_4.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Name_clear_4.Properties.Appearance.Options.UseFont = True
        Me.Name_clear_4.Properties.Appearance.Options.UseForeColor = True
        Me.Name_clear_4.Properties.Caption = "CheckEdit4"
        Me.Name_clear_4.Size = New System.Drawing.Size(142, 23)
        Me.Name_clear_4.TabIndex = 79
        '
        'Name_clear_3
        '
        Me.Name_clear_3.Location = New System.Drawing.Point(17, 113)
        Me.Name_clear_3.MenuManager = Me.BarManager1
        Me.Name_clear_3.Name = "Name_clear_3"
        Me.Name_clear_3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Name_clear_3.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Name_clear_3.Properties.Appearance.Options.UseFont = True
        Me.Name_clear_3.Properties.Appearance.Options.UseForeColor = True
        Me.Name_clear_3.Properties.Caption = "CheckEdit3"
        Me.Name_clear_3.Size = New System.Drawing.Size(142, 23)
        Me.Name_clear_3.TabIndex = 78
        '
        'Name_clear_2
        '
        Me.Name_clear_2.Location = New System.Drawing.Point(17, 84)
        Me.Name_clear_2.MenuManager = Me.BarManager1
        Me.Name_clear_2.Name = "Name_clear_2"
        Me.Name_clear_2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Name_clear_2.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Name_clear_2.Properties.Appearance.Options.UseFont = True
        Me.Name_clear_2.Properties.Appearance.Options.UseForeColor = True
        Me.Name_clear_2.Properties.Caption = "CheckEdit2"
        Me.Name_clear_2.Size = New System.Drawing.Size(142, 23)
        Me.Name_clear_2.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(463, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 18)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Clear IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(96, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 18)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Clear IP Adress Name"
        '
        'Name_clear_1
        '
        Me.Name_clear_1.Location = New System.Drawing.Point(17, 55)
        Me.Name_clear_1.MenuManager = Me.BarManager1
        Me.Name_clear_1.Name = "Name_clear_1"
        Me.Name_clear_1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Name_clear_1.Properties.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.Name_clear_1.Properties.Appearance.Options.UseFont = True
        Me.Name_clear_1.Properties.Appearance.Options.UseForeColor = True
        Me.Name_clear_1.Properties.Caption = "CheckEdit1"
        Me.Name_clear_1.Size = New System.Drawing.Size(142, 23)
        Me.Name_clear_1.TabIndex = 0
        '
        'SeparatorControl5
        '
        Me.SeparatorControl5.LineColor = System.Drawing.Color.Black
        Me.SeparatorControl5.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl5.Location = New System.Drawing.Point(312, 20)
        Me.SeparatorControl5.Name = "SeparatorControl5"
        Me.SeparatorControl5.Size = New System.Drawing.Size(28, 223)
        Me.SeparatorControl5.TabIndex = 76
        '
        'DropDownButton2
        '
        Me.DropDownButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.DropDownButton2.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.DropDownButton2.Appearance.Options.UseFont = True
        Me.DropDownButton2.Appearance.Options.UseForeColor = True
        Me.DropDownButton2.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide
        Me.DropDownButton2.DropDownControl = Me.Clearpopup
        Me.DropDownButton2.ImageOptions.Image = CType(resources.GetObject("DropDownButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.DropDownButton2.Location = New System.Drawing.Point(143, 96)
        Me.DropDownButton2.Name = "DropDownButton2"
        Me.DropDownButton2.Size = New System.Drawing.Size(126, 34)
        Me.DropDownButton2.TabIndex = 148
        Me.DropDownButton2.Text = "Clearing"
        '
        'SeparatorControl8
        '
        Me.SeparatorControl8.LineColor = System.Drawing.Color.Black
        Me.SeparatorControl8.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl8.Location = New System.Drawing.Point(656, -1)
        Me.SeparatorControl8.Name = "SeparatorControl8"
        Me.SeparatorControl8.Size = New System.Drawing.Size(28, 86)
        Me.SeparatorControl8.TabIndex = 83
        '
        'Stat_PIc12
        '
        Me.Stat_PIc12.Location = New System.Drawing.Point(1033, 60)
        Me.Stat_PIc12.Name = "Stat_PIc12"
        Me.Stat_PIc12.Size = New System.Drawing.Size(16, 16)
        Me.Stat_PIc12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Stat_PIc12.TabIndex = 101
        Me.Stat_PIc12.TabStop = False
        '
        'Stat_PIc11
        '
        Me.Stat_PIc11.Location = New System.Drawing.Point(1033, 32)
        Me.Stat_PIc11.Name = "Stat_PIc11"
        Me.Stat_PIc11.Size = New System.Drawing.Size(16, 16)
        Me.Stat_PIc11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Stat_PIc11.TabIndex = 100
        Me.Stat_PIc11.TabStop = False
        '
        'Stat_PIc10
        '
        Me.Stat_PIc10.Location = New System.Drawing.Point(1033, 2)
        Me.Stat_PIc10.Name = "Stat_PIc10"
        Me.Stat_PIc10.Size = New System.Drawing.Size(16, 16)
        Me.Stat_PIc10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Stat_PIc10.TabIndex = 99
        Me.Stat_PIc10.TabStop = False
        '
        'Stat_PIc9
        '
        Me.Stat_PIc9.Location = New System.Drawing.Point(685, 60)
        Me.Stat_PIc9.Name = "Stat_PIc9"
        Me.Stat_PIc9.Size = New System.Drawing.Size(16, 16)
        Me.Stat_PIc9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Stat_PIc9.TabIndex = 98
        Me.Stat_PIc9.TabStop = False
        '
        'Stat_PIc8
        '
        Me.Stat_PIc8.Location = New System.Drawing.Point(685, 32)
        Me.Stat_PIc8.Name = "Stat_PIc8"
        Me.Stat_PIc8.Size = New System.Drawing.Size(16, 16)
        Me.Stat_PIc8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Stat_PIc8.TabIndex = 97
        Me.Stat_PIc8.TabStop = False
        '
        'Stat_PIc7
        '
        Me.Stat_PIc7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Stat_PIc7.Location = New System.Drawing.Point(685, 2)
        Me.Stat_PIc7.Name = "Stat_PIc7"
        Me.Stat_PIc7.Size = New System.Drawing.Size(16, 16)
        Me.Stat_PIc7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Stat_PIc7.TabIndex = 96
        Me.Stat_PIc7.TabStop = False
        '
        'IP1_lab
        '
        Me.IP1_lab.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP1_lab.Appearance.Options.UseFont = True
        Me.IP1_lab.Location = New System.Drawing.Point(37, 2)
        Me.IP1_lab.Name = "IP1_lab"
        Me.IP1_lab.Size = New System.Drawing.Size(51, 19)
        Me.IP1_lab.TabIndex = 106
        Me.IP1_lab.Text = "0.0.0.0"
        '
        'IP2_lab
        '
        Me.IP2_lab.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP2_lab.Appearance.Options.UseFont = True
        Me.IP2_lab.Location = New System.Drawing.Point(37, 29)
        Me.IP2_lab.Name = "IP2_lab"
        Me.IP2_lab.Size = New System.Drawing.Size(51, 19)
        Me.IP2_lab.TabIndex = 107
        Me.IP2_lab.Text = "0.0.0.0"
        '
        'IP3_lab
        '
        Me.IP3_lab.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP3_lab.Appearance.Options.UseFont = True
        Me.IP3_lab.Location = New System.Drawing.Point(37, 60)
        Me.IP3_lab.Name = "IP3_lab"
        Me.IP3_lab.Size = New System.Drawing.Size(51, 19)
        Me.IP3_lab.TabIndex = 108
        Me.IP3_lab.Text = "0.0.0.0"
        '
        'IP4_lab
        '
        Me.IP4_lab.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP4_lab.Appearance.Options.UseFont = True
        Me.IP4_lab.Location = New System.Drawing.Point(385, 2)
        Me.IP4_lab.Name = "IP4_lab"
        Me.IP4_lab.Size = New System.Drawing.Size(51, 19)
        Me.IP4_lab.TabIndex = 109
        Me.IP4_lab.Text = "0.0.0.0"
        '
        'IP5_lab
        '
        Me.IP5_lab.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP5_lab.Appearance.Options.UseFont = True
        Me.IP5_lab.Location = New System.Drawing.Point(385, 29)
        Me.IP5_lab.Name = "IP5_lab"
        Me.IP5_lab.Size = New System.Drawing.Size(51, 19)
        Me.IP5_lab.TabIndex = 110
        Me.IP5_lab.Text = "0.0.0.0"
        '
        'IP6_lab
        '
        Me.IP6_lab.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP6_lab.Appearance.Options.UseFont = True
        Me.IP6_lab.Location = New System.Drawing.Point(385, 60)
        Me.IP6_lab.Name = "IP6_lab"
        Me.IP6_lab.Size = New System.Drawing.Size(51, 19)
        Me.IP6_lab.TabIndex = 111
        Me.IP6_lab.Text = "0.0.0.0"
        '
        'IP7_lab
        '
        Me.IP7_lab.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP7_lab.Appearance.Options.UseFont = True
        Me.IP7_lab.Location = New System.Drawing.Point(711, 2)
        Me.IP7_lab.Name = "IP7_lab"
        Me.IP7_lab.Size = New System.Drawing.Size(51, 19)
        Me.IP7_lab.TabIndex = 112
        Me.IP7_lab.Text = "0.0.0.0"
        '
        'IP8_lab
        '
        Me.IP8_lab.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP8_lab.Appearance.Options.UseFont = True
        Me.IP8_lab.Location = New System.Drawing.Point(711, 29)
        Me.IP8_lab.Name = "IP8_lab"
        Me.IP8_lab.Size = New System.Drawing.Size(51, 19)
        Me.IP8_lab.TabIndex = 113
        Me.IP8_lab.Text = "0.0.0.0"
        '
        'IP9_lab
        '
        Me.IP9_lab.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP9_lab.Appearance.Options.UseFont = True
        Me.IP9_lab.Location = New System.Drawing.Point(711, 60)
        Me.IP9_lab.Name = "IP9_lab"
        Me.IP9_lab.Size = New System.Drawing.Size(51, 19)
        Me.IP9_lab.TabIndex = 114
        Me.IP9_lab.Text = "0.0.0.0"
        '
        'IP10_lab
        '
        Me.IP10_lab.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP10_lab.Appearance.Options.UseFont = True
        Me.IP10_lab.Location = New System.Drawing.Point(1059, 2)
        Me.IP10_lab.Name = "IP10_lab"
        Me.IP10_lab.Size = New System.Drawing.Size(51, 19)
        Me.IP10_lab.TabIndex = 115
        Me.IP10_lab.Text = "0.0.0.0"
        '
        'IP11_lab
        '
        Me.IP11_lab.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP11_lab.Appearance.Options.UseFont = True
        Me.IP11_lab.Location = New System.Drawing.Point(1059, 29)
        Me.IP11_lab.Name = "IP11_lab"
        Me.IP11_lab.Size = New System.Drawing.Size(51, 19)
        Me.IP11_lab.TabIndex = 116
        Me.IP11_lab.Text = "0.0.0.0"
        '
        'IP12_lab
        '
        Me.IP12_lab.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP12_lab.Appearance.Options.UseFont = True
        Me.IP12_lab.Location = New System.Drawing.Point(1059, 60)
        Me.IP12_lab.Name = "IP12_lab"
        Me.IP12_lab.Size = New System.Drawing.Size(51, 19)
        Me.IP12_lab.TabIndex = 117
        Me.IP12_lab.Text = "0.0.0.0"
        '
        'Lab1_stat
        '
        Me.Lab1_stat.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lab1_stat.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Lab1_stat.Appearance.Options.UseFont = True
        Me.Lab1_stat.Appearance.Options.UseForeColor = True
        Me.Lab1_stat.Location = New System.Drawing.Point(175, 2)
        Me.Lab1_stat.Name = "Lab1_stat"
        Me.Lab1_stat.Size = New System.Drawing.Size(52, 19)
        Me.Lab1_stat.TabIndex = 127
        Me.Lab1_stat.Text = "Not Set"
        '
        'Lab2_stat
        '
        Me.Lab2_stat.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lab2_stat.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Lab2_stat.Appearance.Options.UseFont = True
        Me.Lab2_stat.Appearance.Options.UseForeColor = True
        Me.Lab2_stat.Location = New System.Drawing.Point(175, 29)
        Me.Lab2_stat.Name = "Lab2_stat"
        Me.Lab2_stat.Size = New System.Drawing.Size(52, 19)
        Me.Lab2_stat.TabIndex = 133
        Me.Lab2_stat.Text = "Not Set"
        '
        'Lab3_stat
        '
        Me.Lab3_stat.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lab3_stat.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Lab3_stat.Appearance.Options.UseFont = True
        Me.Lab3_stat.Appearance.Options.UseForeColor = True
        Me.Lab3_stat.Location = New System.Drawing.Point(175, 60)
        Me.Lab3_stat.Name = "Lab3_stat"
        Me.Lab3_stat.Size = New System.Drawing.Size(52, 19)
        Me.Lab3_stat.TabIndex = 134
        Me.Lab3_stat.Text = "Not Set"
        '
        'Lab4_stat
        '
        Me.Lab4_stat.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lab4_stat.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Lab4_stat.Appearance.Options.UseFont = True
        Me.Lab4_stat.Appearance.Options.UseForeColor = True
        Me.Lab4_stat.Location = New System.Drawing.Point(533, 2)
        Me.Lab4_stat.Name = "Lab4_stat"
        Me.Lab4_stat.Size = New System.Drawing.Size(52, 19)
        Me.Lab4_stat.TabIndex = 135
        Me.Lab4_stat.Text = "Not Set"
        '
        'Lab5_stat
        '
        Me.Lab5_stat.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lab5_stat.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Lab5_stat.Appearance.Options.UseFont = True
        Me.Lab5_stat.Appearance.Options.UseForeColor = True
        Me.Lab5_stat.Location = New System.Drawing.Point(533, 29)
        Me.Lab5_stat.Name = "Lab5_stat"
        Me.Lab5_stat.Size = New System.Drawing.Size(52, 19)
        Me.Lab5_stat.TabIndex = 136
        Me.Lab5_stat.Text = "Not Set"
        '
        'Lab6_stat
        '
        Me.Lab6_stat.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lab6_stat.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Lab6_stat.Appearance.Options.UseFont = True
        Me.Lab6_stat.Appearance.Options.UseForeColor = True
        Me.Lab6_stat.Location = New System.Drawing.Point(533, 60)
        Me.Lab6_stat.Name = "Lab6_stat"
        Me.Lab6_stat.Size = New System.Drawing.Size(52, 19)
        Me.Lab6_stat.TabIndex = 137
        Me.Lab6_stat.Text = "Not Set"
        '
        'Lab7_stat
        '
        Me.Lab7_stat.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lab7_stat.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Lab7_stat.Appearance.Options.UseFont = True
        Me.Lab7_stat.Appearance.Options.UseForeColor = True
        Me.Lab7_stat.Location = New System.Drawing.Point(849, 2)
        Me.Lab7_stat.Name = "Lab7_stat"
        Me.Lab7_stat.Size = New System.Drawing.Size(52, 19)
        Me.Lab7_stat.TabIndex = 138
        Me.Lab7_stat.Text = "Not Set"
        '
        'Lab8_stat
        '
        Me.Lab8_stat.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lab8_stat.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Lab8_stat.Appearance.Options.UseFont = True
        Me.Lab8_stat.Appearance.Options.UseForeColor = True
        Me.Lab8_stat.Location = New System.Drawing.Point(849, 29)
        Me.Lab8_stat.Name = "Lab8_stat"
        Me.Lab8_stat.Size = New System.Drawing.Size(52, 19)
        Me.Lab8_stat.TabIndex = 139
        Me.Lab8_stat.Text = "Not Set"
        '
        'Lab9_stat
        '
        Me.Lab9_stat.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lab9_stat.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Lab9_stat.Appearance.Options.UseFont = True
        Me.Lab9_stat.Appearance.Options.UseForeColor = True
        Me.Lab9_stat.Location = New System.Drawing.Point(849, 60)
        Me.Lab9_stat.Name = "Lab9_stat"
        Me.Lab9_stat.Size = New System.Drawing.Size(52, 19)
        Me.Lab9_stat.TabIndex = 140
        Me.Lab9_stat.Text = "Not Set"
        '
        'Lab10_stat
        '
        Me.Lab10_stat.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lab10_stat.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Lab10_stat.Appearance.Options.UseFont = True
        Me.Lab10_stat.Appearance.Options.UseForeColor = True
        Me.Lab10_stat.Location = New System.Drawing.Point(1207, 2)
        Me.Lab10_stat.Name = "Lab10_stat"
        Me.Lab10_stat.Size = New System.Drawing.Size(52, 19)
        Me.Lab10_stat.TabIndex = 141
        Me.Lab10_stat.Text = "Not Set"
        '
        'Lab11_stat
        '
        Me.Lab11_stat.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lab11_stat.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Lab11_stat.Appearance.Options.UseFont = True
        Me.Lab11_stat.Appearance.Options.UseForeColor = True
        Me.Lab11_stat.Location = New System.Drawing.Point(1207, 29)
        Me.Lab11_stat.Name = "Lab11_stat"
        Me.Lab11_stat.Size = New System.Drawing.Size(52, 19)
        Me.Lab11_stat.TabIndex = 142
        Me.Lab11_stat.Text = "Not Set"
        '
        'Lab12_stat
        '
        Me.Lab12_stat.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lab12_stat.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Lab12_stat.Appearance.Options.UseFont = True
        Me.Lab12_stat.Appearance.Options.UseForeColor = True
        Me.Lab12_stat.Location = New System.Drawing.Point(1207, 60)
        Me.Lab12_stat.Name = "Lab12_stat"
        Me.Lab12_stat.Size = New System.Drawing.Size(52, 19)
        Me.Lab12_stat.TabIndex = 143
        Me.Lab12_stat.Text = "Not Set"
        '
        'clear_ping_info_but
        '
        Me.clear_ping_info_but.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.clear_ping_info_but.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.clear_ping_info_but.Appearance.Options.UseFont = True
        Me.clear_ping_info_but.Appearance.Options.UseForeColor = True
        Me.clear_ping_info_but.ImageOptions.Image = CType(resources.GetObject("clear_ping_info_but.ImageOptions.Image"), System.Drawing.Image)
        Me.clear_ping_info_but.Location = New System.Drawing.Point(272, 96)
        Me.clear_ping_info_but.Name = "clear_ping_info_but"
        Me.clear_ping_info_but.Size = New System.Drawing.Size(142, 34)
        Me.clear_ping_info_but.TabIndex = 154
        Me.clear_ping_info_but.Text = "Clear Ping Info"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1376, 139)
        Me.Controls.Add(Me.clear_ping_info_but)
        Me.Controls.Add(Me.DropDownButton2)
        Me.Controls.Add(Me.Clearpopup)
        Me.Controls.Add(Me.settings)
        Me.Controls.Add(Me.Lab12_stat)
        Me.Controls.Add(Me.Lab11_stat)
        Me.Controls.Add(Me.Lab10_stat)
        Me.Controls.Add(Me.Lab9_stat)
        Me.Controls.Add(Me.Lab8_stat)
        Me.Controls.Add(Me.Lab7_stat)
        Me.Controls.Add(Me.Lab6_stat)
        Me.Controls.Add(Me.Lab5_stat)
        Me.Controls.Add(Me.Lab4_stat)
        Me.Controls.Add(Me.Lab3_stat)
        Me.Controls.Add(Me.Lab2_stat)
        Me.Controls.Add(Me.Lab1_stat)
        Me.Controls.Add(Me.IP12_lab)
        Me.Controls.Add(Me.IP11_lab)
        Me.Controls.Add(Me.IP10_lab)
        Me.Controls.Add(Me.IP9_lab)
        Me.Controls.Add(Me.IP8_lab)
        Me.Controls.Add(Me.IP7_lab)
        Me.Controls.Add(Me.IP6_lab)
        Me.Controls.Add(Me.IP5_lab)
        Me.Controls.Add(Me.IP4_lab)
        Me.Controls.Add(Me.IP3_lab)
        Me.Controls.Add(Me.IP2_lab)
        Me.Controls.Add(Me.IP1_lab)
        Me.Controls.Add(Me.Stat_PIc12)
        Me.Controls.Add(Me.Stat_PIc11)
        Me.Controls.Add(Me.Stat_PIc10)
        Me.Controls.Add(Me.Stat_PIc9)
        Me.Controls.Add(Me.Stat_PIc8)
        Me.Controls.Add(Me.Stat_PIc7)
        Me.Controls.Add(Me.DropDownButton1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Always_was_Top)
        Me.Controls.Add(Me.Stat_PIc6)
        Me.Controls.Add(Me.Stat_PIc5)
        Me.Controls.Add(Me.Stat_PIc4)
        Me.Controls.Add(Me.Stat_PIc3)
        Me.Controls.Add(Me.Stat_PIc2)
        Me.Controls.Add(Me.Stat_PIc1)
        Me.Controls.Add(Me.lp_lbl)
        Me.Controls.Add(Me.lp_lbl_not)
        Me.Controls.Add(Me.SeparatorControl2)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.SeparatorControl3)
        Me.Controls.Add(Me.SeparatorControl4)
        Me.Controls.Add(Me.SeparatorControl8)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Image = Global.Pinger.My.Resources.Resources.icons8_broadcasting_30
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1388, 175)
        Me.Name = "Form1"
        Me.Text = "Main"
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stat_PIc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stat_PIc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stat_PIc3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stat_PIc4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stat_PIc5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stat_PIc6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Always_was_Top.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NotifyMenu.ResumeLayout(False)
        CType(Me.PingfqSelc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.settings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.settings.ResumeLayout(False)
        Me.settings.PerformLayout()
        CType(Me.MswornSelc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValiAD12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValiAD11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValiAD10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValiAD9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValiAD8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValiAD7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValiAD6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValiAD5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValiAD4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValiAD3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValiAD2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValiAD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clearpopup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Clearpopup.ResumeLayout(False)
        Me.Clearpopup.PerformLayout()
        CType(Me.Ip_clear_12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ip_clear_11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ip_clear_10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ip_clear_9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ip_clear_8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ip_clear_7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ip_clear_6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ip_clear_5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ip_clear_4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ip_clear_3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ip_clear_2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ip_clear_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_clear_12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_clear_11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_clear_10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_clear_9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_clear_8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_clear_7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_clear_6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_clear_5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_clear_4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_clear_3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_clear_2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name_clear_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stat_PIc12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stat_PIc11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stat_PIc10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stat_PIc9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stat_PIc8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stat_PIc7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bgwPing As System.ComponentModel.BackgroundWorker
    Friend WithEvents IpAdName1 As Label
    Friend WithEvents IPAd2 As TextBox
    Friend WithEvents IpAdName2 As Label
    Friend WithEvents IPAd3 As TextBox
    Friend WithEvents IpAdName3 As Label
    Friend WithEvents IPAd4 As TextBox
    Friend WithEvents IpAdName4 As Label
    Friend WithEvents IPAd5 As TextBox
    Friend WithEvents IpAdName5 As Label
    Friend WithEvents IPAd6 As TextBox
    Friend WithEvents IpAdName6 As Label
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents SeparatorControl3 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents SeparatorControl4 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents lp_lbl_not As Label
    Friend WithEvents Edit_but As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lp_lbl As Label
    Friend WithEvents Start_but As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Stat_PIc1 As PictureBox
    Friend WithEvents Stat_PIc2 As PictureBox
    Friend WithEvents Stat_PIc3 As PictureBox
    Friend WithEvents Stat_PIc4 As PictureBox
    Friend WithEvents Stat_PIc5 As PictureBox
    Friend WithEvents Stat_PIc6 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Always_was_Top As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents Label8 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents NotifyMenu As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSIPAD1 As ToolStripTextBox
    Friend WithEvents TSPING1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TSIPAD2 As ToolStripTextBox
    Friend WithEvents TSPING2 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TSIPAD3 As ToolStripTextBox
    Friend WithEvents TSPING3 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TSIPAD4 As ToolStripTextBox
    Friend WithEvents TSPING4 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents TSIPAD5 As ToolStripTextBox
    Friend WithEvents TSPING5 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents TSIPAD6 As ToolStripTextBox
    Friend WithEvents TSPING6 As ToolStripTextBox
    Friend WithEvents TSIPNAME1 As ToolStripTextBox
    Friend WithEvents TSIPNAME2 As ToolStripTextBox
    Friend WithEvents TSIPNAME3 As ToolStripTextBox
    Friend WithEvents TSIPNAME4 As ToolStripTextBox
    Friend WithEvents TSIPNAME5 As ToolStripTextBox
    Friend WithEvents TSIPNAME6 As ToolStripTextBox
    Friend WithEvents PingfqSelc As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents DropDownButton1 As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents settings As DevExpress.XtraBars.PopupControlContainer
    Friend WithEvents Change_name_but_Ok As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Ipname_set6 As TextBox
    Friend WithEvents Name_set_lbl6 As Label
    Friend WithEvents Ipname_set5 As TextBox
    Friend WithEvents Name_set_lbl5 As Label
    Friend WithEvents Ipname_set4 As TextBox
    Friend WithEvents Name_set_lbl4 As Label
    Friend WithEvents Ipname_set3 As TextBox
    Friend WithEvents Name_set_lbl3 As Label
    Friend WithEvents Ipname_set2 As TextBox
    Friend WithEvents Name_set_lbl2 As Label
    Friend WithEvents Ipname_set1 As TextBox
    Friend WithEvents Name_set_lbl1 As Label
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Start_But_Info As Label
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem2 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem3 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem4 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem5 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem6 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem7 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem8 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem9 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem10 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem11 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem12 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem13 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem14 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem15 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem16 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem17 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem18 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit12 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit14 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit15 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit17 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit18 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents SeparatorControl6 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents Name_set_lbl7 As Label
    Friend WithEvents Ipname_set7 As TextBox
    Friend WithEvents Name_set_lbl8 As Label
    Friend WithEvents Name_set_lbl10 As Label
    Friend WithEvents Ipname_set10 As TextBox
    Friend WithEvents Ipname_set8 As TextBox
    Friend WithEvents Name_set_lbl11 As Label
    Friend WithEvents Ipname_set11 As TextBox
    Friend WithEvents Name_set_lbl9 As Label
    Friend WithEvents Name_set_lbl12 As Label
    Friend WithEvents Ipname_set9 As TextBox
    Friend WithEvents Ipname_set12 As TextBox
    Friend WithEvents IpAdName7 As Label
    Friend WithEvents IPAd7 As TextBox
    Friend WithEvents IpAdName8 As Label
    Friend WithEvents IpAdName10 As Label
    Friend WithEvents IPAd10 As TextBox
    Friend WithEvents IPAd8 As TextBox
    Friend WithEvents IpAdName11 As Label
    Friend WithEvents IPAd11 As TextBox
    Friend WithEvents IpAdName9 As Label
    Friend WithEvents IpAdName12 As Label
    Friend WithEvents IPAd9 As TextBox
    Friend WithEvents IPAd12 As TextBox
    Friend WithEvents SeparatorControl7 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents Stat_PIc12 As PictureBox
    Friend WithEvents Stat_PIc11 As PictureBox
    Friend WithEvents Stat_PIc10 As PictureBox
    Friend WithEvents Stat_PIc9 As PictureBox
    Friend WithEvents Stat_PIc8 As PictureBox
    Friend WithEvents Stat_PIc7 As PictureBox
    Friend WithEvents SeparatorControl8 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TSIPNAME7 As ToolStripTextBox
    Friend WithEvents TSIPAD7 As ToolStripTextBox
    Friend WithEvents TSPING7 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents TSIPNAME8 As ToolStripTextBox
    Friend WithEvents TSIPAD8 As ToolStripTextBox
    Friend WithEvents TSPING8 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents TSIPNAME9 As ToolStripTextBox
    Friend WithEvents TSIPAD9 As ToolStripTextBox
    Friend WithEvents TSPING9 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents TSIPNAME10 As ToolStripTextBox
    Friend WithEvents TSIPAD10 As ToolStripTextBox
    Friend WithEvents TSPING10 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents TSIPNAME11 As ToolStripTextBox
    Friend WithEvents TSIPAD11 As ToolStripTextBox
    Friend WithEvents TSPING11 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents TSIPNAME12 As ToolStripTextBox
    Friend WithEvents TSIPAD12 As ToolStripTextBox
    Friend WithEvents TSPING12 As ToolStripTextBox
    Friend WithEvents IP1_lab As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IP12_lab As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IP11_lab As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IP10_lab As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IP9_lab As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IP8_lab As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IP7_lab As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IP6_lab As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IP5_lab As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IP4_lab As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IP3_lab As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IP2_lab As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IPAd1 As TextBox
    Friend WithEvents ValiAD12 As PictureBox
    Friend WithEvents ValiAD11 As PictureBox
    Friend WithEvents ValiAD10 As PictureBox
    Friend WithEvents ValiAD9 As PictureBox
    Friend WithEvents ValiAD8 As PictureBox
    Friend WithEvents ValiAD7 As PictureBox
    Friend WithEvents ValiAD6 As PictureBox
    Friend WithEvents ValiAD5 As PictureBox
    Friend WithEvents ValiAD4 As PictureBox
    Friend WithEvents ValiAD3 As PictureBox
    Friend WithEvents ValiAD2 As PictureBox
    Friend WithEvents ValiAD1 As PictureBox
    Friend WithEvents error_lbl As Label
    Friend WithEvents Lab1_stat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Lab12_stat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Lab11_stat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Lab10_stat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Lab9_stat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Lab8_stat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Lab7_stat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Lab6_stat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Lab5_stat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Lab4_stat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Lab3_stat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Lab2_stat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As Label
    Friend WithEvents MswornSelc As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Clearpopup As DevExpress.XtraBars.PopupControlContainer
    Friend WithEvents DropDownButton2 As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Name_clear_1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ip_clear_12 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ip_clear_11 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ip_clear_10 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ip_clear_9 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ip_clear_8 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ip_clear_7 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ip_clear_6 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ip_clear_5 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ip_clear_4 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ip_clear_3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ip_clear_2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ip_clear_1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Name_clear_12 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Name_clear_11 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Name_clear_10 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Name_clear_9 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Name_clear_8 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Name_clear_7 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Name_clear_6 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Name_clear_5 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Name_clear_4 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Name_clear_3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Name_clear_2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SeparatorControl5 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents clear_ping_info_but As DevExpress.XtraEditors.SimpleButton

#End Region

End Class
