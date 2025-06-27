<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Test
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
        dgv = New DataGridView()
        Get_Script = New Button()
        LB_scriptResult = New Label()
        Data_Path = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        LB_PassCount = New Label()
        LB_FailCount = New Label()
        LB_LineCount = New Label()
        LB_Execute_Time = New Label()
        Start_Scirpt = New Button()
        Clear = New Button()
        Display_Info = New Label()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv
        ' 
        dgv.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(11, 38)
        dgv.Name = "dgv"
        dgv.Size = New Size(621, 491)
        dgv.TabIndex = 0
        ' 
        ' Get_Script
        ' 
        Get_Script.AutoSize = True
        Get_Script.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        Get_Script.Location = New Point(11, 7)
        Get_Script.Name = "Get_Script"
        Get_Script.Size = New Size(50, 25)
        Get_Script.TabIndex = 6
        Get_Script.Text = "Get"
        Get_Script.UseVisualStyleBackColor = False
        ' 
        ' LB_scriptResult
        ' 
        LB_scriptResult.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LB_scriptResult.AutoSize = True
        LB_scriptResult.BorderStyle = BorderStyle.FixedSingle
        LB_scriptResult.Font = New Font("Microsoft JhengHei UI", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(136))
        LB_scriptResult.Location = New Point(638, 38)
        LB_scriptResult.Name = "LB_scriptResult"
        LB_scriptResult.Size = New Size(192, 124)
        LB_scriptResult.TabIndex = 7
        LB_scriptResult.Text = "OK"
        ' 
        ' Data_Path
        ' 
        Data_Path.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Data_Path.Location = New Point(67, 8)
        Data_Path.Name = "Data_Path"
        Data_Path.Size = New Size(720, 23)
        Data_Path.TabIndex = 8
        Data_Path.Text = "D:\Script\Test.csv"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label2.Location = New Point(638, 171)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 9
        Label2.Text = "PASS:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(638, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 9
        Label3.Text = "FAIL:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(638, 206)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 9
        Label4.Text = "TOTAL:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(638, 239)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 15)
        Label5.TabIndex = 9
        Label5.Text = "Execute Time:"
        ' 
        ' LB_PassCount
        ' 
        LB_PassCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LB_PassCount.AutoSize = True
        LB_PassCount.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        LB_PassCount.Location = New Point(685, 171)
        LB_PassCount.Name = "LB_PassCount"
        LB_PassCount.Size = New Size(38, 15)
        LB_PassCount.TabIndex = 9
        LB_PassCount.Text = "NULL"
        ' 
        ' LB_FailCount
        ' 
        LB_FailCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LB_FailCount.AutoSize = True
        LB_FailCount.ForeColor = Color.Red
        LB_FailCount.Location = New Point(685, 188)
        LB_FailCount.Name = "LB_FailCount"
        LB_FailCount.Size = New Size(38, 15)
        LB_FailCount.TabIndex = 9
        LB_FailCount.Text = "NULL"
        ' 
        ' LB_LineCount
        ' 
        LB_LineCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LB_LineCount.AutoSize = True
        LB_LineCount.Location = New Point(685, 206)
        LB_LineCount.Name = "LB_LineCount"
        LB_LineCount.Size = New Size(38, 15)
        LB_LineCount.TabIndex = 9
        LB_LineCount.Text = "NULL"
        ' 
        ' LB_Execute_Time
        ' 
        LB_Execute_Time.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LB_Execute_Time.AutoSize = True
        LB_Execute_Time.Location = New Point(729, 239)
        LB_Execute_Time.Name = "LB_Execute_Time"
        LB_Execute_Time.Size = New Size(38, 15)
        LB_Execute_Time.TabIndex = 9
        LB_Execute_Time.Text = "NULL"
        ' 
        ' Start_Scirpt
        ' 
        Start_Scirpt.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Start_Scirpt.AutoSize = True
        Start_Scirpt.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        Start_Scirpt.Location = New Point(793, 6)
        Start_Scirpt.Name = "Start_Scirpt"
        Start_Scirpt.Size = New Size(50, 25)
        Start_Scirpt.TabIndex = 10
        Start_Scirpt.Text = "Start"
        Start_Scirpt.UseVisualStyleBackColor = False
        ' 
        ' Clear
        ' 
        Clear.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Clear.AutoSize = True
        Clear.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        Clear.Location = New Point(11, 535)
        Clear.Name = "Clear"
        Clear.Size = New Size(50, 25)
        Clear.TabIndex = 11
        Clear.Text = "Clear"
        Clear.UseVisualStyleBackColor = False
        ' 
        ' Display_Info
        ' 
        Display_Info.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Display_Info.AutoSize = True
        Display_Info.Location = New Point(67, 540)
        Display_Info.Name = "Display_Info"
        Display_Info.Size = New Size(75, 15)
        Display_Info.TabIndex = 12
        Display_Info.Text = "Display_Info"
        ' 
        ' Form_Test
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(858, 567)
        Controls.Add(Display_Info)
        Controls.Add(Clear)
        Controls.Add(Start_Scirpt)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(LB_Execute_Time)
        Controls.Add(LB_LineCount)
        Controls.Add(LB_FailCount)
        Controls.Add(LB_PassCount)
        Controls.Add(Label2)
        Controls.Add(Data_Path)
        Controls.Add(LB_scriptResult)
        Controls.Add(Get_Script)
        Controls.Add(dgv)
        Name = "Form_Test"
        Text = "Form_Test"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents Get_Script As Button
    Friend WithEvents LB_scriptResult As Label
    Friend WithEvents Data_Path As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LB_PassCount As Label
    Friend WithEvents LB_FailCount As Label
    Friend WithEvents LB_LineCount As Label
    Friend WithEvents LB_Execute_Time As Label
    Friend WithEvents Start_Scirpt As Button
    Friend WithEvents Clear As Button
    Friend WithEvents Display_Info As Label
End Class
