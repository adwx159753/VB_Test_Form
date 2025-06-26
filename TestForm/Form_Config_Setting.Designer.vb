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
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox5 = New ComboBox()
        ComboBox6 = New ComboBox()
        ComboBox7 = New ComboBox()
        ComboBox8 = New ComboBox()
        ComboBox9 = New ComboBox()
        ComboBox10 = New ComboBox()
        ComboBox11 = New ComboBox()
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
        Button1 = New Button()
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
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Japan", "North America", "China", "Asia", "Latin1", "Latin2", "Brazil", "Africa/GCC"})
        ComboBox1.Location = New Point(93, 12)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(516, 23)
        ComboBox1.TabIndex = 57
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Passive Antenna", "Active Antenna"})
        ComboBox2.Location = New Point(93, 37)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(516, 23)
        ComboBox2.TabIndex = 57
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"4ch: w/ Fader", "2ch: w/o Fater"})
        ComboBox3.Location = New Point(93, 62)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(516, 23)
        ComboBox3.TabIndex = 57
        ' 
        ' ComboBox4
        ' 
        ComboBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"RHD: MIC beam right", "LHD: MIC beam left"})
        ComboBox4.Location = New Point(93, 87)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(516, 23)
        ComboBox4.TabIndex = 57
        ' 
        ' ComboBox5
        ' 
        ComboBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox5.FormattingEnabled = True
        ComboBox5.Items.AddRange(New Object() {"with phonebook", "without phonebook"})
        ComboBox5.Location = New Point(93, 112)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(516, 23)
        ComboBox5.TabIndex = 57
        ' 
        ' ComboBox6
        ' 
        ComboBox6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox6.FormattingEnabled = True
        ComboBox6.Items.AddRange(New Object() {"Not JPN", "JPN Traffic Info"})
        ComboBox6.Location = New Point(93, 137)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(516, 23)
        ComboBox6.TabIndex = 57
        ' 
        ' ComboBox7
        ' 
        ComboBox7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox7.FormattingEnabled = True
        ComboBox7.Items.AddRange(New Object() {"3Key+2Key", "2Key+1Key", "None"})
        ComboBox7.Location = New Point(93, 162)
        ComboBox7.Name = "ComboBox7"
        ComboBox7.Size = New Size(516, 23)
        ComboBox7.TabIndex = 57
        ' 
        ' ComboBox8
        ' 
        ComboBox8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox8.FormattingEnabled = True
        ComboBox8.Items.AddRange(New Object() {"Enable", "Disable"})
        ComboBox8.Location = New Point(93, 187)
        ComboBox8.Name = "ComboBox8"
        ComboBox8.Size = New Size(516, 23)
        ComboBox8.TabIndex = 57
        ' 
        ' ComboBox9
        ' 
        ComboBox9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox9.FormattingEnabled = True
        ComboBox9.Items.AddRange(New Object() {"Default: GEQ", "Default: Bass/Tre"})
        ComboBox9.Location = New Point(93, 212)
        ComboBox9.Name = "ComboBox9"
        ComboBox9.Size = New Size(516, 23)
        ComboBox9.TabIndex = 57
        ' 
        ' ComboBox10
        ' 
        ComboBox10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox10.FormattingEnabled = True
        ComboBox10.Items.AddRange(New Object() {"CombinationA", "CombinationB", "CombinationC", "CombinationD", "CombinationE", "CombinationF"})
        ComboBox10.Location = New Point(93, 237)
        ComboBox10.Name = "ComboBox10"
        ComboBox10.Size = New Size(516, 23)
        ComboBox10.TabIndex = 57
        ' 
        ' ComboBox11
        ' 
        ComboBox11.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox11.FormattingEnabled = True
        ComboBox11.Items.AddRange(New Object() {"TBC", "Brank"})
        ComboBox11.Location = New Point(93, 262)
        ComboBox11.Name = "ComboBox11"
        ComboBox11.Size = New Size(516, 23)
        ComboBox11.TabIndex = 57
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
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        Button1.Location = New Point(615, 396)
        Button1.Name = "Button1"
        Button1.Size = New Size(50, 25)
        Button1.TabIndex = 58
        Button1.Text = "Send"
        Button1.UseVisualStyleBackColor = False
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
        Controls.Add(Button1)
        Controls.Add(SendButtonCmd)
        Controls.Add(ComboBox11)
        Controls.Add(ComboBox10)
        Controls.Add(ComboBox5)
        Controls.Add(ComboBox9)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox8)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox7)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox6)
        Controls.Add(ComboBox1)
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents ComboBox10 As ComboBox
    Friend WithEvents ComboBox11 As ComboBox
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
    Friend WithEvents Button1 As Button
End Class
