﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Advanced
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Advanced))
        Me.TooltipHelper = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MephTheme1 = New SilentETHMiner.MephTheme()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.toggleInstallSystem32 = New SilentETHMiner.MephToggleSwitch()
        Me.toggleDownloader = New SilentETHMiner.MephToggleSwitch()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStealthTargets = New SilentETHMiner.MephTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.toggleAdministrator = New SilentETHMiner.MephToggleSwitch()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.toggleEnableDebug = New SilentETHMiner.MephToggleSwitch()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.chkAdvanced = New SilentETHMiner.MephCheckBox()
        Me.txtAdvParam = New SilentETHMiner.MephTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.toggleObfuscation = New SilentETHMiner.MephToggleSwitch()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.toggleKillWD = New SilentETHMiner.MephToggleSwitch()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkRemoteConfig = New SilentETHMiner.MephCheckBox()
        Me.txtRemoteConfig = New SilentETHMiner.MephTextBox()
        Me.MephTheme1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TooltipHelper
        '
        Me.TooltipHelper.AutoPopDelay = 32000
        Me.TooltipHelper.BackColor = System.Drawing.Color.White
        Me.TooltipHelper.ForeColor = System.Drawing.Color.Black
        Me.TooltipHelper.InitialDelay = 100
        Me.TooltipHelper.IsBalloon = True
        Me.TooltipHelper.ReshowDelay = 100
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline)
        Me.Label13.ForeColor = System.Drawing.Color.Teal
        Me.Label13.Location = New System.Drawing.Point(127, 200)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "?"
        Me.TooltipHelper.SetToolTip(Me.Label13, resources.GetString("Label13.ToolTip"))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline)
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(119, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "?"
        Me.TooltipHelper.SetToolTip(Me.Label7, "Enable this to download the miner from online (GitHub) instead of embedding it in" &
        " the file." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will greatly decrease the file size and usually greatly decreas" &
        "es detections.")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline)
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(383, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "?"
        Me.TooltipHelper.SetToolTip(Me.Label12, resources.GetString("Label12.ToolTip"))
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline)
        Me.Label9.ForeColor = System.Drawing.Color.Teal
        Me.Label9.Location = New System.Drawing.Point(141, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "?"
        Me.TooltipHelper.SetToolTip(Me.Label9, "Will make the miner ask for administrator privileges to run." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is required fo" &
        "r the ""Kill"" Windows Defender option.")
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline)
        Me.Label26.ForeColor = System.Drawing.Color.Teal
        Me.Label26.Location = New System.Drawing.Point(59, 280)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(13, 13)
        Me.Label26.TabIndex = 60
        Me.Label26.Text = "?"
        Me.TooltipHelper.SetToolTip(Me.Label26, "Will enable DEBUG mode which will display errors when they occur in the miner. !W" &
        "ARNING! Should only be used when testing!")
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline)
        Me.Label19.ForeColor = System.Drawing.Color.Teal
        Me.Label19.Location = New System.Drawing.Point(379, 236)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 13)
        Me.Label19.TabIndex = 66
        Me.Label19.Text = "?"
        Me.TooltipHelper.SetToolTip(Me.Label19, "The parameters to mine with. ONLY CHANGE THESE IF YOU KNOW WHAT YOU ARE DOING.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline)
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(148, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "?"
        Me.TooltipHelper.SetToolTip(Me.Label1, resources.GetString("Label1.ToolTip"))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline)
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(174, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "?"
        Me.TooltipHelper.SetToolTip(Me.Label3, "Will run commands to exclude the general folders that the miner uses or can use. " &
        "This is good to enable to bypass future detections." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This option requires Admini" &
        "strator privileges!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline)
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(378, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "?"
        Me.TooltipHelper.SetToolTip(Me.Label6, resources.GetString("Label6.ToolTip"))
        '
        'MephTheme1
        '
        Me.MephTheme1.AccentColor = System.Drawing.Color.DarkRed
        Me.MephTheme1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MephTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MephTheme1.Controls.Add(Me.PictureBox2)
        Me.MephTheme1.Controls.Add(Me.Label13)
        Me.MephTheme1.Controls.Add(Me.Label14)
        Me.MephTheme1.Controls.Add(Me.toggleInstallSystem32)
        Me.MephTheme1.Controls.Add(Me.toggleDownloader)
        Me.MephTheme1.Controls.Add(Me.Label7)
        Me.MephTheme1.Controls.Add(Me.Label8)
        Me.MephTheme1.Controls.Add(Me.Label12)
        Me.MephTheme1.Controls.Add(Me.Label11)
        Me.MephTheme1.Controls.Add(Me.txtStealthTargets)
        Me.MephTheme1.Controls.Add(Me.Label9)
        Me.MephTheme1.Controls.Add(Me.Label10)
        Me.MephTheme1.Controls.Add(Me.toggleAdministrator)
        Me.MephTheme1.Controls.Add(Me.PictureBox1)
        Me.MephTheme1.Controls.Add(Me.Label26)
        Me.MephTheme1.Controls.Add(Me.Label27)
        Me.MephTheme1.Controls.Add(Me.toggleEnableDebug)
        Me.MephTheme1.Controls.Add(Me.Label20)
        Me.MephTheme1.Controls.Add(Me.Label19)
        Me.MephTheme1.Controls.Add(Me.chkAdvanced)
        Me.MephTheme1.Controls.Add(Me.txtAdvParam)
        Me.MephTheme1.Controls.Add(Me.Label1)
        Me.MephTheme1.Controls.Add(Me.Label2)
        Me.MephTheme1.Controls.Add(Me.toggleObfuscation)
        Me.MephTheme1.Controls.Add(Me.Label3)
        Me.MephTheme1.Controls.Add(Me.Label4)
        Me.MephTheme1.Controls.Add(Me.toggleKillWD)
        Me.MephTheme1.Controls.Add(Me.Label5)
        Me.MephTheme1.Controls.Add(Me.Label6)
        Me.MephTheme1.Controls.Add(Me.chkRemoteConfig)
        Me.MephTheme1.Controls.Add(Me.txtRemoteConfig)
        Me.MephTheme1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MephTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MephTheme1.Name = "MephTheme1"
        Me.MephTheme1.Size = New System.Drawing.Size(436, 307)
        Me.MephTheme1.SubHeader = "Advanced Options"
        Me.MephTheme1.TabIndex = 0
        Me.MephTheme1.Text = "Silent ETH Miner Builder"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.SilentETHMiner.My.Resources.Resources.microsoft_admin
        Me.PictureBox2.Location = New System.Drawing.Point(243, 196)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 94
        Me.PictureBox2.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.Label14.ForeColor = System.Drawing.Color.Gray
        Me.Label14.Location = New System.Drawing.Point(11, 197)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 17)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "Install to System32:"
        '
        'toggleInstallSystem32
        '
        Me.toggleInstallSystem32.BackColor = System.Drawing.Color.Transparent
        Me.toggleInstallSystem32.Checked = False
        Me.toggleInstallSystem32.ForeColor = System.Drawing.Color.Black
        Me.toggleInstallSystem32.Location = New System.Drawing.Point(190, 194)
        Me.toggleInstallSystem32.Margin = New System.Windows.Forms.Padding(2)
        Me.toggleInstallSystem32.Name = "toggleInstallSystem32"
        Me.toggleInstallSystem32.Size = New System.Drawing.Size(50, 24)
        Me.toggleInstallSystem32.TabIndex = 91
        Me.toggleInstallSystem32.Text = "Install System32"
        '
        'toggleDownloader
        '
        Me.toggleDownloader.BackColor = System.Drawing.Color.Transparent
        Me.toggleDownloader.Checked = True
        Me.toggleDownloader.ForeColor = System.Drawing.Color.Black
        Me.toggleDownloader.Location = New System.Drawing.Point(190, 104)
        Me.toggleDownloader.Margin = New System.Windows.Forms.Padding(2)
        Me.toggleDownloader.Name = "toggleDownloader"
        Me.toggleDownloader.Size = New System.Drawing.Size(50, 24)
        Me.toggleDownloader.TabIndex = 90
        Me.toggleDownloader.Text = "Enable Nicehash Mining"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(11, 106)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 17)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Online Download:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(290, 73)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 17)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Stealth Targets:"
        '
        'txtStealthTargets
        '
        Me.txtStealthTargets.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtStealthTargets.ForeColor = System.Drawing.Color.Silver
        Me.txtStealthTargets.Location = New System.Drawing.Point(291, 93)
        Me.txtStealthTargets.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStealthTargets.MaxLength = 32767
        Me.txtStealthTargets.MultiLine = False
        Me.txtStealthTargets.Name = "txtStealthTargets"
        Me.txtStealthTargets.Size = New System.Drawing.Size(136, 24)
        Me.txtStealthTargets.TabIndex = 85
        Me.txtStealthTargets.Text = "Taskmgr.exe,ProcessHacker.exe,perfmon.exe,procexp.exe,procexp64.exe"
        Me.txtStealthTargets.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtStealthTargets.UseSystemPasswordChar = False
        Me.txtStealthTargets.WordWrap = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(12, 137)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 17)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Run as Administrator:"
        '
        'toggleAdministrator
        '
        Me.toggleAdministrator.BackColor = System.Drawing.Color.Transparent
        Me.toggleAdministrator.Checked = False
        Me.toggleAdministrator.ForeColor = System.Drawing.Color.Black
        Me.toggleAdministrator.Location = New System.Drawing.Point(190, 135)
        Me.toggleAdministrator.Margin = New System.Windows.Forms.Padding(2)
        Me.toggleAdministrator.Name = "toggleAdministrator"
        Me.toggleAdministrator.Size = New System.Drawing.Size(50, 24)
        Me.toggleAdministrator.TabIndex = 82
        Me.toggleAdministrator.Text = "Enable Nicehash Mining"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SilentETHMiner.My.Resources.Resources.microsoft_admin
        Me.PictureBox1.Location = New System.Drawing.Point(243, 167)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(11, 278)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(52, 17)
        Me.Label27.TabIndex = 59
        Me.Label27.Text = "DEBUG:"
        '
        'toggleEnableDebug
        '
        Me.toggleEnableDebug.BackColor = System.Drawing.Color.Transparent
        Me.toggleEnableDebug.Checked = False
        Me.toggleEnableDebug.ForeColor = System.Drawing.Color.Black
        Me.toggleEnableDebug.Location = New System.Drawing.Point(75, 275)
        Me.toggleEnableDebug.Margin = New System.Windows.Forms.Padding(2)
        Me.toggleEnableDebug.Name = "toggleEnableDebug"
        Me.toggleEnableDebug.Size = New System.Drawing.Size(50, 24)
        Me.toggleEnableDebug.TabIndex = 58
        Me.toggleEnableDebug.Text = "Enable Nicehash Mining"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Gray
        Me.Label20.Location = New System.Drawing.Point(291, 257)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(138, 17)
        Me.Label20.TabIndex = 67
        Me.Label20.Text = "Advanced Parameters:"
        '
        'chkAdvanced
        '
        Me.chkAdvanced.AccentColor = System.Drawing.Color.ForestGreen
        Me.chkAdvanced.BackColor = System.Drawing.Color.Transparent
        Me.chkAdvanced.Checked = False
        Me.chkAdvanced.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkAdvanced.ForeColor = System.Drawing.Color.Black
        Me.chkAdvanced.Location = New System.Drawing.Point(293, 231)
        Me.chkAdvanced.Margin = New System.Windows.Forms.Padding(2)
        Me.chkAdvanced.Name = "chkAdvanced"
        Me.chkAdvanced.Size = New System.Drawing.Size(111, 24)
        Me.chkAdvanced.TabIndex = 65
        Me.chkAdvanced.Text = "Disabled"
        '
        'txtAdvParam
        '
        Me.txtAdvParam.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtAdvParam.Enabled = False
        Me.txtAdvParam.ForeColor = System.Drawing.Color.Silver
        Me.txtAdvParam.Location = New System.Drawing.Point(292, 275)
        Me.txtAdvParam.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAdvParam.MaxLength = 32767
        Me.txtAdvParam.MultiLine = False
        Me.txtAdvParam.Name = "txtAdvParam"
        Me.txtAdvParam.Size = New System.Drawing.Size(136, 24)
        Me.txtAdvParam.TabIndex = 64
        Me.txtAdvParam.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAdvParam.UseSystemPasswordChar = False
        Me.txtAdvParam.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 17)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Pause for Obfuscation:"
        '
        'toggleObfuscation
        '
        Me.toggleObfuscation.BackColor = System.Drawing.Color.Transparent
        Me.toggleObfuscation.Checked = False
        Me.toggleObfuscation.ForeColor = System.Drawing.Color.Black
        Me.toggleObfuscation.Location = New System.Drawing.Point(189, 73)
        Me.toggleObfuscation.Margin = New System.Windows.Forms.Padding(2)
        Me.toggleObfuscation.Name = "toggleObfuscation"
        Me.toggleObfuscation.Size = New System.Drawing.Size(50, 24)
        Me.toggleObfuscation.TabIndex = 68
        Me.toggleObfuscation.Text = "Enable Nicehash Mining"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(12, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 17)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Bypass Windows Defender:"
        '
        'toggleKillWD
        '
        Me.toggleKillWD.BackColor = System.Drawing.Color.Transparent
        Me.toggleKillWD.Checked = False
        Me.toggleKillWD.ForeColor = System.Drawing.Color.Black
        Me.toggleKillWD.Location = New System.Drawing.Point(190, 165)
        Me.toggleKillWD.Margin = New System.Windows.Forms.Padding(2)
        Me.toggleKillWD.Name = "toggleKillWD"
        Me.toggleKillWD.Size = New System.Drawing.Size(50, 24)
        Me.toggleKillWD.TabIndex = 71
        Me.toggleKillWD.Text = "Enable Nicehash Mining"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(290, 184)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 17)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Remote Configuration:"
        '
        'chkRemoteConfig
        '
        Me.chkRemoteConfig.AccentColor = System.Drawing.Color.ForestGreen
        Me.chkRemoteConfig.BackColor = System.Drawing.Color.Transparent
        Me.chkRemoteConfig.Checked = False
        Me.chkRemoteConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkRemoteConfig.ForeColor = System.Drawing.Color.Black
        Me.chkRemoteConfig.Location = New System.Drawing.Point(292, 158)
        Me.chkRemoteConfig.Margin = New System.Windows.Forms.Padding(2)
        Me.chkRemoteConfig.Name = "chkRemoteConfig"
        Me.chkRemoteConfig.Size = New System.Drawing.Size(111, 24)
        Me.chkRemoteConfig.TabIndex = 75
        Me.chkRemoteConfig.Text = "Disabled"
        '
        'txtRemoteConfig
        '
        Me.txtRemoteConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRemoteConfig.Enabled = False
        Me.txtRemoteConfig.ForeColor = System.Drawing.Color.Silver
        Me.txtRemoteConfig.Location = New System.Drawing.Point(291, 202)
        Me.txtRemoteConfig.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRemoteConfig.MaxLength = 32767
        Me.txtRemoteConfig.MultiLine = False
        Me.txtRemoteConfig.Name = "txtRemoteConfig"
        Me.txtRemoteConfig.Size = New System.Drawing.Size(136, 24)
        Me.txtRemoteConfig.TabIndex = 74
        Me.txtRemoteConfig.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtRemoteConfig.UseSystemPasswordChar = False
        Me.txtRemoteConfig.WordWrap = False
        '
        'Advanced
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(436, 307)
        Me.Controls.Add(Me.MephTheme1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.729167!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(436, 307)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(436, 307)
        Me.Name = "Advanced"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advanced"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MephTheme1.ResumeLayout(False)
        Me.MephTheme1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MephTheme1 As MephTheme
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents toggleEnableDebug As MephToggleSwitch
    Friend WithEvents TooltipHelper As ToolTip
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents chkAdvanced As MephCheckBox
    Friend WithEvents txtAdvParam As MephTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents toggleObfuscation As MephToggleSwitch
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents toggleKillWD As MephToggleSwitch
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chkRemoteConfig As MephCheckBox
    Friend WithEvents txtRemoteConfig As MephTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents toggleAdministrator As MephToggleSwitch
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtStealthTargets As MephTextBox
    Friend WithEvents toggleDownloader As MephToggleSwitch
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents toggleInstallSystem32 As MephToggleSwitch
End Class
