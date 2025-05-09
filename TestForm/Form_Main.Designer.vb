<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Panel1 = New Panel()
        AUX = New CheckBox()
        Panel4 = New Panel()
        Button6 = New Button()
        dn = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        rotate_button = New Button()
        Button1 = New Button()
        up = New Button()
        SRC = New Button()
        BND = New Button()
        last_one = New Button()
        next_one = New Button()
        music = New Button()
        DISP = New Button()
        COMstr = New TextBox()
        BAUstr = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Connect = New Button()
        System_Version = New Label()
        Panel5 = New Panel()
        comport_info = New Label()
        comport_Set = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Timer1 = New Timer(components)
        Getversion = New Button()
        MenuStrip1 = New MenuStrip()
        Test1ToolStripMenuItem = New ToolStripMenuItem()
        Test2ToolStripMenuItem = New ToolStripMenuItem()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        ComboBox1.Location = New Point(768, 42)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(36, 23)
        ComboBox1.TabIndex = 1
        ComboBox1.Text = "1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(731, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 15)
        Label1.TabIndex = 2
        Label1.Text = "機種"
        ' 
        ' Panel1
        ' 
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Controls.Add(AUX)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(dn)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(rotate_button)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(up)
        Panel1.Controls.Add(SRC)
        Panel1.Controls.Add(BND)
        Panel1.Controls.Add(last_one)
        Panel1.Controls.Add(next_one)
        Panel1.Controls.Add(music)
        Panel1.Controls.Add(DISP)
        Panel1.Location = New Point(9, 86)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(758, 226)
        Panel1.TabIndex = 4
        ' 
        ' AUX
        ' 
        AUX.AutoSize = True
        AUX.Location = New Point(681, 173)
        AUX.Name = "AUX"
        AUX.Size = New Size(15, 14)
        AUX.TabIndex = 6
        AUX.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Lime
        Panel4.Location = New Point(532, 71)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(25, 12)
        Panel4.TabIndex = 2
        ' 
        ' Button6
        ' 
        Button6.Anchor = AnchorStyles.None
        Button6.BackColor = SystemColors.ActiveBorder
        Button6.Location = New Point(592, 186)
        Button6.Name = "Button6"
        Button6.Size = New Size(38, 20)
        Button6.TabIndex = 5
        Button6.Text = "B6"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' dn
        ' 
        dn.BackColor = SystemColors.ActiveBorder
        dn.Location = New Point(284, 151)
        dn.Name = "dn"
        dn.Size = New Size(30, 23)
        dn.TabIndex = 5
        dn.Text = "dn"
        dn.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.None
        Button5.BackColor = SystemColors.ActiveBorder
        Button5.Location = New Point(534, 186)
        Button5.Name = "Button5"
        Button5.Size = New Size(38, 20)
        Button5.TabIndex = 5
        Button5.Text = "B5"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.None
        Button4.BackColor = SystemColors.ActiveBorder
        Button4.Location = New Point(480, 186)
        Button4.Name = "Button4"
        Button4.Size = New Size(38, 20)
        Button4.TabIndex = 5
        Button4.Text = "B4"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.None
        Button3.BackColor = SystemColors.ActiveBorder
        Button3.Location = New Point(423, 186)
        Button3.Name = "Button3"
        Button3.Size = New Size(38, 20)
        Button3.TabIndex = 5
        Button3.Text = "B3"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.BackColor = SystemColors.ActiveBorder
        Button2.Location = New Point(379, 186)
        Button2.Name = "Button2"
        Button2.Size = New Size(38, 20)
        Button2.TabIndex = 5
        Button2.Text = "B2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' rotate_button
        ' 
        rotate_button.BackColor = SystemColors.ActiveBorder
        rotate_button.Location = New Point(236, 115)
        rotate_button.Name = "rotate_button"
        rotate_button.Size = New Size(38, 24)
        rotate_button.TabIndex = 5
        rotate_button.Text = "R"
        rotate_button.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.BackColor = SystemColors.ActiveBorder
        Button1.Location = New Point(321, 186)
        Button1.Name = "Button1"
        Button1.Size = New Size(38, 20)
        Button1.TabIndex = 5
        Button1.Text = "B1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' up
        ' 
        up.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        up.BackColor = SystemColors.ActiveBorder
        up.Location = New Point(283, 80)
        up.Name = "up"
        up.Size = New Size(30, 23)
        up.TabIndex = 5
        up.Text = "up"
        up.UseVisualStyleBackColor = False
        ' 
        ' SRC
        ' 
        SRC.BackColor = SystemColors.ActiveBorder
        SRC.Location = New Point(68, 73)
        SRC.Name = "SRC"
        SRC.Size = New Size(38, 20)
        SRC.TabIndex = 5
        SRC.Text = "SRC"
        SRC.UseVisualStyleBackColor = False
        ' 
        ' BND
        ' 
        BND.BackColor = SystemColors.ActiveBorder
        BND.Font = New Font("Microsoft JhengHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        BND.Location = New Point(139, 74)
        BND.Name = "BND"
        BND.Size = New Size(42, 20)
        BND.TabIndex = 5
        BND.Text = "BND"
        BND.UseVisualStyleBackColor = False
        ' 
        ' last_one
        ' 
        last_one.BackColor = SystemColors.ActiveBorder
        last_one.Font = New Font("Microsoft JhengHei UI Light", 8F, FontStyle.Bold)
        last_one.Location = New Point(37, 111)
        last_one.Name = "last_one"
        last_one.Size = New Size(49, 30)
        last_one.TabIndex = 5
        last_one.Text = "|◀◀"
        last_one.UseVisualStyleBackColor = False
        ' 
        ' next_one
        ' 
        next_one.BackColor = SystemColors.ActiveBorder
        next_one.Font = New Font("Microsoft JhengHei UI Light", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(136))
        next_one.Location = New Point(100, 111)
        next_one.Name = "next_one"
        next_one.Size = New Size(43, 30)
        next_one.TabIndex = 5
        next_one.Text = "▶▶|"
        next_one.UseVisualStyleBackColor = False
        ' 
        ' music
        ' 
        music.BackColor = SystemColors.ActiveBorder
        music.Location = New Point(139, 159)
        music.Name = "music"
        music.Size = New Size(60, 30)
        music.TabIndex = 5
        music.Text = "♪"
        music.UseVisualStyleBackColor = False
        ' 
        ' DISP
        ' 
        DISP.BackColor = SystemColors.ActiveBorder
        DISP.Location = New Point(81, 159)
        DISP.Name = "DISP"
        DISP.Size = New Size(60, 30)
        DISP.TabIndex = 5
        DISP.Text = "DISP"
        DISP.UseVisualStyleBackColor = False
        ' 
        ' COMstr
        ' 
        COMstr.Location = New Point(147, 31)
        COMstr.Name = "COMstr"
        COMstr.Size = New Size(54, 23)
        COMstr.TabIndex = 5
        COMstr.Text = "COM4"
        ' 
        ' BAUstr
        ' 
        BAUstr.Location = New Point(147, 60)
        BAUstr.Name = "BAUstr"
        BAUstr.Size = New Size(54, 23)
        BAUstr.TabIndex = 5
        BAUstr.Text = "115200"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(109, 34)
        Label9.Name = "Label9"
        Label9.Size = New Size(37, 15)
        Label9.TabIndex = 6
        Label9.Text = "COM"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(76, 63)
        Label10.Name = "Label10"
        Label10.Size = New Size(70, 15)
        Label10.TabIndex = 6
        Label10.Text = "BAUDRATE"
        ' 
        ' Connect
        ' 
        Connect.AutoSize = True
        Connect.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        Connect.Location = New Point(28, 27)
        Connect.Name = "Connect"
        Connect.Size = New Size(50, 25)
        Connect.TabIndex = 5
        Connect.Text = "ON"
        Connect.UseVisualStyleBackColor = False
        ' 
        ' System_Version
        ' 
        System_Version.AutoSize = True
        System_Version.Location = New Point(356, 62)
        System_Version.Name = "System_Version"
        System_Version.Size = New Size(94, 15)
        System_Version.TabIndex = 6
        System_Version.Text = "System_Version"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Red
        Panel5.Location = New Point(81, 31)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(28, 19)
        Panel5.TabIndex = 2
        ' 
        ' comport_info
        ' 
        comport_info.AutoSize = True
        comport_info.Location = New Point(207, 63)
        comport_info.Name = "comport_info"
        comport_info.Size = New Size(83, 15)
        comport_info.TabIndex = 6
        comport_info.Text = "comport_info"
        ' 
        ' comport_Set
        ' 
        comport_Set.AutoSize = True
        comport_Set.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        comport_Set.Location = New Point(28, 55)
        comport_Set.Name = "comport_Set"
        comport_Set.Size = New Size(50, 25)
        comport_Set.TabIndex = 5
        comport_Set.Text = "Set"
        comport_Set.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(811, 82)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(54, 23)
        TextBox1.TabIndex = 5
        TextBox1.Text = "0"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(811, 111)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(54, 23)
        TextBox2.TabIndex = 5
        TextBox2.Text = "0"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(811, 140)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(54, 23)
        TextBox3.TabIndex = 5
        TextBox3.Text = "0"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(811, 169)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(54, 23)
        TextBox4.TabIndex = 5
        TextBox4.Text = "0"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(811, 198)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(54, 23)
        TextBox5.TabIndex = 5
        TextBox5.Text = "0"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(811, 227)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(54, 23)
        TextBox6.TabIndex = 5
        TextBox6.Text = "0"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(811, 256)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(54, 23)
        TextBox7.TabIndex = 5
        TextBox7.Text = "0"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(811, 285)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(54, 23)
        TextBox8.TabIndex = 5
        TextBox8.Text = "0"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(768, 85)
        Label11.Name = "Label11"
        Label11.Size = New Size(38, 15)
        Label11.TabIndex = 6
        Label11.Text = "Byte0"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(768, 114)
        Label12.Name = "Label12"
        Label12.Size = New Size(38, 15)
        Label12.TabIndex = 6
        Label12.Text = "Byte1"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(768, 143)
        Label13.Name = "Label13"
        Label13.Size = New Size(38, 15)
        Label13.TabIndex = 6
        Label13.Text = "Byte2"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(768, 172)
        Label14.Name = "Label14"
        Label14.Size = New Size(38, 15)
        Label14.TabIndex = 6
        Label14.Text = "Byte3"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(768, 201)
        Label15.Name = "Label15"
        Label15.Size = New Size(38, 15)
        Label15.TabIndex = 6
        Label15.Text = "Byte4"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(768, 230)
        Label16.Name = "Label16"
        Label16.Size = New Size(38, 15)
        Label16.TabIndex = 6
        Label16.Text = "Byte5"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(768, 259)
        Label17.Name = "Label17"
        Label17.Size = New Size(38, 15)
        Label17.TabIndex = 6
        Label17.Text = "Byte6"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(768, 288)
        Label18.Name = "Label18"
        Label18.Size = New Size(38, 15)
        Label18.TabIndex = 6
        Label18.Text = "Byte7"
        ' 
        ' Timer1
        ' 
        ' 
        ' Getversion
        ' 
        Getversion.AutoSize = True
        Getversion.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        Getversion.Location = New Point(303, 57)
        Getversion.Name = "Getversion"
        Getversion.Size = New Size(50, 25)
        Getversion.TabIndex = 5
        Getversion.Text = "Get"
        Getversion.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.Control
        MenuStrip1.GripStyle = ToolStripGripStyle.Visible
        MenuStrip1.Items.AddRange(New ToolStripItem() {Test1ToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(886, 24)
        MenuStrip1.TabIndex = 7
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Test1ToolStripMenuItem
        ' 
        Test1ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Test2ToolStripMenuItem})
        Test1ToolStripMenuItem.Name = "Test1ToolStripMenuItem"
        Test1ToolStripMenuItem.Size = New Size(48, 20)
        Test1ToolStripMenuItem.Text = "Form"
        ' 
        ' Test2ToolStripMenuItem
        ' 
        Test2ToolStripMenuItem.Name = "Test2ToolStripMenuItem"
        Test2ToolStripMenuItem.Size = New Size(131, 22)
        Test2ToolStripMenuItem.Text = "Form_Test"
        ' 
        ' Form_Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(886, 337)
        Controls.Add(Panel5)
        Controls.Add(comport_info)
        Controls.Add(System_Version)
        Controls.Add(Label10)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label9)
        Controls.Add(BAUstr)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(COMstr)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Controls.Add(Getversion)
        Controls.Add(comport_Set)
        Controls.Add(Connect)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form_Main"
        Text = "Form_Main"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents rotate_button As Button
    Friend WithEvents BND As Button
    Friend WithEvents DISP As Button
    Friend WithEvents SRC As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents COMstr As TextBox
    Friend WithEvents BAUstr As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Connect As Button
    Friend WithEvents System_Version As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents comport_info As Label
    Friend WithEvents comport_Set As Button
    Friend WithEvents dn As Button
    Friend WithEvents up As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Getversion As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Test1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Test2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button6 As Button
    Friend WithEvents last_one As Button
    Friend WithEvents next_one As Button
    Friend WithEvents music As Button
    Friend WithEvents AUX As CheckBox

End Class
