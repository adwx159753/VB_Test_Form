<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Config_Setting
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        SampleA4 = New Button()
        SampleA3 = New Button()
        SampleA2 = New Button()
        SampleA1 = New Button()
        CB_Country = New ComboBox()
        CB_Antenna = New ComboBox()
        CB_Number_of_Speaker = New ComboBox()
        CB_Steering_Wheel_Place = New ComboBox()
        CB_Phonebook_HP_related = New ComboBox()
        CB_Traffic_Info_For_JPN = New ComboBox()
        CB_Steering_Wheel_Remote = New ComboBox()
        CB_Browsing_Search = New ComboBox()
        CB_Default_GEQ_Bass_Tre = New ComboBox()
        CB_Default_Radio_Preset = New ComboBox()
        CB_HF_Parameter = New ComboBox()
        SendButtonCmd = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        DataGridView1 = New DataGridView()
        Result = New Label()
        Result_Background = New Panel()
        Disconncet = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Result_Background.SuspendLayout()
        SuspendLayout()
        ' 
        ' SampleA4
        ' 
        SampleA4.AutoSize = True
        SampleA4.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        SampleA4.Location = New Point(12, 105)
        SampleA4.Name = "SampleA4"
        SampleA4.Size = New Size(75, 25)
        SampleA4.TabIndex = 34
        SampleA4.Text = "SampleA4"
        SampleA4.UseVisualStyleBackColor = False
        ' 
        ' SampleA3
        ' 
        SampleA3.AutoSize = True
        SampleA3.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        SampleA3.Location = New Point(12, 74)
        SampleA3.Name = "SampleA3"
        SampleA3.Size = New Size(75, 25)
        SampleA3.TabIndex = 33
        SampleA3.Text = "SampleA3"
        SampleA3.UseVisualStyleBackColor = False
        ' 
        ' SampleA2
        ' 
        SampleA2.AutoSize = True
        SampleA2.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        SampleA2.Location = New Point(12, 43)
        SampleA2.Name = "SampleA2"
        SampleA2.Size = New Size(75, 25)
        SampleA2.TabIndex = 32
        SampleA2.Text = "SampleA2"
        SampleA2.UseVisualStyleBackColor = False
        ' 
        ' SampleA1
        ' 
        SampleA1.AutoSize = True
        SampleA1.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        SampleA1.Location = New Point(12, 12)
        SampleA1.Name = "SampleA1"
        SampleA1.Size = New Size(75, 25)
        SampleA1.TabIndex = 31
        SampleA1.Text = "SampleA1"
        SampleA1.UseVisualStyleBackColor = False
        ' 
        ' CB_Country
        ' 
        CB_Country.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CB_Country.FormattingEnabled = True
        CB_Country.Items.AddRange(New Object() {"Japan", "North America", "China", "Asia", "Latin1", "Latin2", "Brazil", "Africa/GCC"})
        CB_Country.Location = New Point(93, 12)
        CB_Country.Name = "CB_Country"
        CB_Country.Size = New Size(516, 23)
        CB_Country.TabIndex = 57
        ' 
        ' CB_Antenna
        ' 
        CB_Antenna.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CB_Antenna.FormattingEnabled = True
        CB_Antenna.Items.AddRange(New Object() {"Passive Antenna", "Active Antenna"})
        CB_Antenna.Location = New Point(93, 37)
        CB_Antenna.Name = "CB_Antenna"
        CB_Antenna.Size = New Size(516, 23)
        CB_Antenna.TabIndex = 57
        ' 
        ' CB_Number_of_Speaker
        ' 
        CB_Number_of_Speaker.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CB_Number_of_Speaker.FormattingEnabled = True
        CB_Number_of_Speaker.Items.AddRange(New Object() {"4ch: w/ Fader", "2ch: w/o Fater"})
        CB_Number_of_Speaker.Location = New Point(93, 62)
        CB_Number_of_Speaker.Name = "CB_Number_of_Speaker"
        CB_Number_of_Speaker.Size = New Size(516, 23)
        CB_Number_of_Speaker.TabIndex = 57
        ' 
        ' CB_Steering_Wheel_Place
        ' 
        CB_Steering_Wheel_Place.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CB_Steering_Wheel_Place.FormattingEnabled = True
        CB_Steering_Wheel_Place.Items.AddRange(New Object() {"RHD: MIC beam right", "LHD: MIC beam left"})
        CB_Steering_Wheel_Place.Location = New Point(93, 87)
        CB_Steering_Wheel_Place.Name = "CB_Steering_Wheel_Place"
        CB_Steering_Wheel_Place.Size = New Size(516, 23)
        CB_Steering_Wheel_Place.TabIndex = 57
        ' 
        ' CB_Phonebook_HP_related
        ' 
        CB_Phonebook_HP_related.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CB_Phonebook_HP_related.FormattingEnabled = True
        CB_Phonebook_HP_related.Items.AddRange(New Object() {"with phonebook", "without phonebook"})
        CB_Phonebook_HP_related.Location = New Point(93, 112)
        CB_Phonebook_HP_related.Name = "CB_Phonebook_HP_related"
        CB_Phonebook_HP_related.Size = New Size(516, 23)
        CB_Phonebook_HP_related.TabIndex = 57
        ' 
        ' CB_Traffic_Info_For_JPN
        ' 
        CB_Traffic_Info_For_JPN.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CB_Traffic_Info_For_JPN.FormattingEnabled = True
        CB_Traffic_Info_For_JPN.Items.AddRange(New Object() {"Not JPN", "JPN Traffic Info"})
        CB_Traffic_Info_For_JPN.Location = New Point(93, 137)
        CB_Traffic_Info_For_JPN.Name = "CB_Traffic_Info_For_JPN"
        CB_Traffic_Info_For_JPN.Size = New Size(516, 23)
        CB_Traffic_Info_For_JPN.TabIndex = 57
        ' 
        ' CB_Steering_Wheel_Remote
        ' 
        CB_Steering_Wheel_Remote.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CB_Steering_Wheel_Remote.FormattingEnabled = True
        CB_Steering_Wheel_Remote.Items.AddRange(New Object() {"3Key+2Key", "2Key+1Key", "None"})
        CB_Steering_Wheel_Remote.Location = New Point(93, 162)
        CB_Steering_Wheel_Remote.Name = "CB_Steering_Wheel_Remote"
        CB_Steering_Wheel_Remote.Size = New Size(516, 23)
        CB_Steering_Wheel_Remote.TabIndex = 57
        ' 
        ' CB_Browsing_Search
        ' 
        CB_Browsing_Search.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CB_Browsing_Search.FormattingEnabled = True
        CB_Browsing_Search.Items.AddRange(New Object() {"Enable", "Disable"})
        CB_Browsing_Search.Location = New Point(93, 187)
        CB_Browsing_Search.Name = "CB_Browsing_Search"
        CB_Browsing_Search.Size = New Size(516, 23)
        CB_Browsing_Search.TabIndex = 57
        ' 
        ' CB_Default_GEQ_Bass_Tre
        ' 
        CB_Default_GEQ_Bass_Tre.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CB_Default_GEQ_Bass_Tre.FormattingEnabled = True
        CB_Default_GEQ_Bass_Tre.Items.AddRange(New Object() {"Default: GEQ", "Default: Bass/Tre"})
        CB_Default_GEQ_Bass_Tre.Location = New Point(93, 212)
        CB_Default_GEQ_Bass_Tre.Name = "CB_Default_GEQ_Bass_Tre"
        CB_Default_GEQ_Bass_Tre.Size = New Size(516, 23)
        CB_Default_GEQ_Bass_Tre.TabIndex = 57
        ' 
        ' CB_Default_Radio_Preset
        ' 
        CB_Default_Radio_Preset.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CB_Default_Radio_Preset.FormattingEnabled = True
        CB_Default_Radio_Preset.Items.AddRange(New Object() {"CombinationA", "CombinationB", "CombinationC", "CombinationD", "CombinationE", "CombinationF"})
        CB_Default_Radio_Preset.Location = New Point(93, 237)
        CB_Default_Radio_Preset.Name = "CB_Default_Radio_Preset"
        CB_Default_Radio_Preset.Size = New Size(516, 23)
        CB_Default_Radio_Preset.TabIndex = 57
        ' 
        ' CB_HF_Parameter
        ' 
        CB_HF_Parameter.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CB_HF_Parameter.FormattingEnabled = True
        CB_HF_Parameter.Items.AddRange(New Object() {"TBC", "Brank"})
        CB_HF_Parameter.Location = New Point(93, 262)
        CB_HF_Parameter.Name = "CB_HF_Parameter"
        CB_HF_Parameter.Size = New Size(516, 23)
        CB_HF_Parameter.TabIndex = 57
        ' 
        ' SendButtonCmd
        ' 
        SendButtonCmd.AutoSize = True
        SendButtonCmd.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        SendButtonCmd.Location = New Point(12, 260)
        SendButtonCmd.Name = "SendButtonCmd"
        SendButtonCmd.Size = New Size(50, 25)
        SendButtonCmd.TabIndex = 58
        SendButtonCmd.Text = "Send"
        SendButtonCmd.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(615, 265)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 15)
        Label4.TabIndex = 69
        Label4.Text = "HF Parameter"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(615, 240)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 15)
        Label5.TabIndex = 68
        Label5.Text = "Default of Radio Preset"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Location = New Point(615, 215)
        Label6.Name = "Label6"
        Label6.Size = New Size(142, 15)
        Label6.TabIndex = 67
        Label6.Text = "Default of GEQ/Bass Tre"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Location = New Point(615, 190)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 15)
        Label7.TabIndex = 66
        Label7.Text = "Browsing Search"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Location = New Point(615, 165)
        Label8.Name = "Label8"
        Label8.Size = New Size(141, 15)
        Label8.TabIndex = 65
        Label8.Text = "Steering Wheel Remote"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Location = New Point(615, 140)
        Label9.Name = "Label9"
        Label9.Size = New Size(111, 15)
        Label9.TabIndex = 64
        Label9.Text = "Traffic Info for JPN"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Location = New Point(615, 115)
        Label10.Name = "Label10"
        Label10.Size = New Size(138, 15)
        Label10.TabIndex = 63
        Label10.Text = "Phonebook & HP related"
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label19.AutoSize = True
        Label19.Location = New Point(615, 90)
        Label19.Name = "Label19"
        Label19.Size = New Size(127, 15)
        Label19.TabIndex = 62
        Label19.Text = "Steering Wheel place"
        ' 
        ' Label20
        ' 
        Label20.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label20.AutoSize = True
        Label20.Location = New Point(615, 65)
        Label20.Name = "Label20"
        Label20.Size = New Size(123, 15)
        Label20.TabIndex = 61
        Label20.Text = "Number of Speakers"
        ' 
        ' Label21
        ' 
        Label21.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label21.AutoSize = True
        Label21.Location = New Point(615, 40)
        Label21.Name = "Label21"
        Label21.Size = New Size(54, 15)
        Label21.TabIndex = 60
        Label21.Text = "Antenna"
        ' 
        ' Label22
        ' 
        Label22.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label22.AutoSize = True
        Label22.Location = New Point(615, 15)
        Label22.Name = "Label22"
        Label22.Size = New Size(51, 15)
        Label22.TabIndex = 59
        Label22.Text = "Country"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 292)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(597, 297)
        DataGridView1.TabIndex = 70
        ' 
        ' Result
        ' 
        Result.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Result.AutoSize = True
        Result.Font = New Font("Microsoft JhengHei UI", 54F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        Result.Location = New Point(0, 4)
        Result.Name = "Result"
        Result.Size = New Size(150, 91)
        Result.TabIndex = 71
        Result.Text = "NG"
        Result.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Result_Background
        ' 
        Result_Background.BorderStyle = BorderStyle.FixedSingle
        Result_Background.Controls.Add(Result)
        Result_Background.Location = New Point(615, 292)
        Result_Background.Name = "Result_Background"
        Result_Background.Size = New Size(156, 98)
        Result_Background.TabIndex = 72
        ' 
        ' Disconncet
        ' 
        Disconncet.AutoSize = True
        Disconncet.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        Disconncet.Location = New Point(615, 396)
        Disconncet.Name = "Disconncet"
        Disconncet.Size = New Size(79, 25)
        Disconncet.TabIndex = 58
        Disconncet.Text = "Disconncet"
        Disconncet.UseVisualStyleBackColor = False
        ' 
        ' Form_Config_Setting
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(779, 601)
        Controls.Add(Result_Background)
        Controls.Add(DataGridView1)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Label19)
        Controls.Add(Label20)
        Controls.Add(Label21)
        Controls.Add(Label22)
        Controls.Add(Disconncet)
        Controls.Add(SendButtonCmd)
        Controls.Add(CB_HF_Parameter)
        Controls.Add(CB_Default_Radio_Preset)
        Controls.Add(CB_Phonebook_HP_related)
        Controls.Add(CB_Default_GEQ_Bass_Tre)
        Controls.Add(CB_Steering_Wheel_Place)
        Controls.Add(CB_Browsing_Search)
        Controls.Add(CB_Number_of_Speaker)
        Controls.Add(CB_Steering_Wheel_Remote)
        Controls.Add(CB_Antenna)
        Controls.Add(CB_Traffic_Info_For_JPN)
        Controls.Add(CB_Country)
        Controls.Add(SampleA4)
        Controls.Add(SampleA3)
        Controls.Add(SampleA2)
        Controls.Add(SampleA1)
        Name = "Form_Config_Setting"
        Text = "Form_Config_Setting"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Result_Background.ResumeLayout(False)
        Result_Background.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SampleA4 As Button
    Friend WithEvents SampleA3 As Button
    Friend WithEvents SampleA2 As Button
    Friend WithEvents SampleA1 As Button
    Friend WithEvents CB_Country As ComboBox
    Friend WithEvents CB_Antenna As ComboBox
    Friend WithEvents CB_Number_of_Speaker As ComboBox
    Friend WithEvents CB_Steering_Wheel_Place As ComboBox
    Friend WithEvents CB_Phonebook_HP_related As ComboBox
    Friend WithEvents CB_Traffic_Info_For_JPN As ComboBox
    Friend WithEvents CB_Steering_Wheel_Remote As ComboBox
    Friend WithEvents CB_Browsing_Search As ComboBox
    Friend WithEvents CB_Default_GEQ_Bass_Tre As ComboBox
    Friend WithEvents CB_Default_Radio_Preset As ComboBox
    Friend WithEvents CB_HF_Parameter As ComboBox
    Friend WithEvents SendButtonCmd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Result As Label
    Friend WithEvents Result_Background As Panel
    Friend WithEvents Disconncet As Button
End Class
