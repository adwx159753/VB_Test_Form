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
        Label9 = New Label()
        Label10 = New Label()
        Connect = New Button()
        Panel5 = New Panel()
        comport_info = New Label()
        comport_Set = New Button()
        Timer1 = New Timer(components)
        MenuStrip1 = New MenuStrip()
        Test1ToolStripMenuItem = New ToolStripMenuItem()
        FormTestToolStripMenuItem = New ToolStripMenuItem()
        FormPanelToolStripMenuItem = New ToolStripMenuItem()
        InputText = New TextBox()
        Button7 = New Button()
        ReceiveText = New TextBox()
        InputLogText = New TextBox()
        COMstr = New ComboBox()
        BAUstr = New ComboBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(156, 39)
        Label9.Name = "Label9"
        Label9.Size = New Size(37, 15)
        Label9.TabIndex = 6
        Label9.Text = "COM"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(266, 39)
        Label10.Name = "Label10"
        Label10.Size = New Size(70, 15)
        Label10.TabIndex = 6
        Label10.Text = "BAUDRATE"
        ' 
        ' Connect
        ' 
        Connect.AutoSize = True
        Connect.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        Connect.Location = New Point(16, 34)
        Connect.Name = "Connect"
        Connect.Size = New Size(50, 25)
        Connect.TabIndex = 5
        Connect.Text = "ON"
        Connect.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Red
        Panel5.Location = New Point(123, 37)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(28, 19)
        Panel5.TabIndex = 2
        ' 
        ' comport_info
        ' 
        comport_info.AutoSize = True
        comport_info.Location = New Point(628, 39)
        comport_info.Name = "comport_info"
        comport_info.Size = New Size(83, 15)
        comport_info.TabIndex = 6
        comport_info.Text = "comport_info"
        comport_info.TextAlign = ContentAlignment.TopRight
        ' 
        ' comport_Set
        ' 
        comport_Set.AutoSize = True
        comport_Set.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        comport_Set.Location = New Point(67, 34)
        comport_Set.Name = "comport_Set"
        comport_Set.Size = New Size(50, 25)
        comport_Set.TabIndex = 5
        comport_Set.Text = "Set"
        comport_Set.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.Control
        MenuStrip1.GripStyle = ToolStripGripStyle.Visible
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {Test1ToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(739, 24)
        MenuStrip1.TabIndex = 7
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Test1ToolStripMenuItem
        ' 
        Test1ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FormTestToolStripMenuItem, FormPanelToolStripMenuItem})
        Test1ToolStripMenuItem.Name = "Test1ToolStripMenuItem"
        Test1ToolStripMenuItem.Size = New Size(48, 20)
        Test1ToolStripMenuItem.Text = "Form"
        ' 
        ' FormTestToolStripMenuItem
        ' 
        FormTestToolStripMenuItem.Name = "FormTestToolStripMenuItem"
        FormTestToolStripMenuItem.Size = New Size(139, 22)
        FormTestToolStripMenuItem.Text = "Form_Test"
        ' 
        ' FormPanelToolStripMenuItem
        ' 
        FormPanelToolStripMenuItem.Name = "FormPanelToolStripMenuItem"
        FormPanelToolStripMenuItem.Size = New Size(139, 22)
        FormPanelToolStripMenuItem.Text = "Form_Panel"
        ' 
        ' InputText
        ' 
        InputText.Location = New Point(16, 442)
        InputText.Name = "InputText"
        InputText.Size = New Size(648, 23)
        InputText.TabIndex = 5
        InputText.Text = "AT+I2SCFG=1" & vbLf & " "
        ' 
        ' Button7
        ' 
        Button7.AutoSize = True
        Button7.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        Button7.Location = New Point(670, 440)
        Button7.Name = "Button7"
        Button7.Size = New Size(50, 25)
        Button7.TabIndex = 5
        Button7.Text = "Send"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' ReceiveText
        ' 
        ReceiveText.AllowDrop = True
        ReceiveText.BackColor = SystemColors.ButtonHighlight
        ReceiveText.Location = New Point(16, 65)
        ReceiveText.Multiline = True
        ReceiveText.Name = "ReceiveText"
        ReceiveText.ReadOnly = True
        ReceiveText.ScrollBars = ScrollBars.Both
        ReceiveText.Size = New Size(704, 302)
        ReceiveText.TabIndex = 5
        ' 
        ' InputLogText
        ' 
        InputLogText.AllowDrop = True
        InputLogText.BackColor = SystemColors.ButtonHighlight
        InputLogText.Location = New Point(16, 373)
        InputLogText.Multiline = True
        InputLogText.Name = "InputLogText"
        InputLogText.ReadOnly = True
        InputLogText.ScrollBars = ScrollBars.Both
        InputLogText.Size = New Size(704, 63)
        InputLogText.TabIndex = 5
        ' 
        ' COMstr
        ' 
        COMstr.FormattingEnabled = True
        COMstr.Location = New Point(199, 36)
        COMstr.Name = "COMstr"
        COMstr.Size = New Size(61, 23)
        COMstr.TabIndex = 8
        ' 
        ' BAUstr
        ' 
        BAUstr.FormattingEnabled = True
        BAUstr.Items.AddRange(New Object() {"115200", "57600", "38400", "19200", "14400", "9600", "4800"})
        BAUstr.Location = New Point(342, 36)
        BAUstr.Name = "BAUstr"
        BAUstr.Size = New Size(70, 23)
        BAUstr.TabIndex = 8
        BAUstr.Text = "115200"
        ' 
        ' Form_Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.Disable
        ClientSize = New Size(739, 477)
        Controls.Add(BAUstr)
        Controls.Add(COMstr)
        Controls.Add(Panel5)
        Controls.Add(comport_info)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(InputLogText)
        Controls.Add(ReceiveText)
        Controls.Add(InputText)
        Controls.Add(Button7)
        Controls.Add(comport_Set)
        Controls.Add(Connect)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form_Main"
        Text = "Form_Main"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Connect As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents comport_info As Label
    Friend WithEvents comport_Set As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Test1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormTestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputText As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents FormPanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceiveText As TextBox
    Friend WithEvents InputLogText As TextBox
    Friend WithEvents COMstr As ComboBox
    Friend WithEvents BAUstr As ComboBox

End Class
