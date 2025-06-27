Imports System.Text
Imports System.IO
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.ComponentModel.Composition.Primitives
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System.Security.Policy

Public Class Form_Test

    ' ------------------------------------------------------------------------------
    ' ------------------------------- [Variable Field] ----------------------------|
    ' ------------------------------------------------------------------------------
    Private Structure Script
        Dim row As String
        Dim cmd As Integer
        Dim setting As String
        Dim expect As String
        Dim actual As String
        Dim delay As Integer 'ms
        Dim description As String
        Dim script_step As Byte
        Dim result As Boolean
        Dim execute_time As Double
    End Structure
    Dim scr As Script

    ' Use Delegate to pointer different function
    Delegate Sub ScriptOperation()
    Delegate Function ScriptGetActual() As String
    Dim Operation As ScriptOperation
    Dim GetAcual As ScriptGetActual


    ' ------------------------------------------------------------------------------
    ' ---------------------------- [Main Function Field] --------------------------|
    ' ------------------------------------------------------------------------------
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 設置DataGridView的屬性
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        script_init()
        Delegate_Init()
    End Sub

    Private Async Sub Script_Execute()
        Dim headers As String() = {"行數", "命令", "設定值", "預期值", "實際值", "最大等待時間(ms)", "描述"}
        Dim dt As New DataTable()
        Dim passCount As Integer = 0
        Dim failCount As Integer = 0

        dgv_clear()
        scr.execute_time = 0

        Try
            Using sr As New StreamReader(Data_Path.Text, Encoding.Default)
                'Add Headers
                For Each header As String In headers
                    dt.Columns.Add(header)
                Next
                dgv.DataSource = dt
                For Each col As DataGridViewColumn In dgv.Columns
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                Next

                Dim skip_first_line As Boolean = True
                'Read Data
                While Not sr.EndOfStream
                    Dim rows As String() = sr.ReadLine().Split(","c)

                    If skip_first_line Then
                        skip_first_line = False
                        Continue While
                    End If

                    ' Set cmd
                    For Each r As String In rows
                        Script_Data_Update(r)
                        ' Debug.WriteLine(scr.script_step)
                    Next

                    ' Cmd Process (also wait for delay)
                    Await Script_cmd_process()

                    ' dt value update
                    Array.Resize(rows, rows.Length + 1)
                    rows(0) = scr.row
                    rows(1) = scr.cmd
                    rows(2) = scr.setting
                    rows(3) = scr.expect
                    rows(4) = scr.actual
                    rows(5) = scr.delay
                    rows(6) = scr.description
                    If rows.Length = dt.Columns.Count Then
                        dt.Rows.Add(rows)
                    End If

                    ' If doesn't care about expect value.
                    If scr.expect = "" Then
                        scr.result = True
                    End If

                    ' new row for dgv
                    dgv.DataSource = dt
                    If scr.result = False Then
                        dgv.Rows(dgv.Rows.Count - 2).DefaultCellStyle.BackColor = Color.Yellow
                        failCount += 1
                        LB_FailCount.Text = failCount
                    Else
                        dgv.Rows(dgv.Rows.Count - 2).DefaultCellStyle.BackColor = Color.White
                        passCount += 1
                        LB_PassCount.Text = passCount
                    End If
                    LB_LineCount.Text = (passCount + failCount)

                    script_init()

                End While
            End Using

            ' Final Result
            If failCount > 0 Then
                LB_scriptResult.Text = "NG"
                LB_scriptResult.BackColor = Color.Red
            Else
                LB_scriptResult.Text = "OK"
                LB_scriptResult.BackColor = Color.LimeGreen
            End If

        Catch ex As IOException
            MessageBox.Show("dgv資料寫入異常")

        Catch ex As Exception
            MessageBox.Show("請檢查script是否正確")

        End Try
    End Sub

    ' Read the whole row, and split it into script structure.
    Private Sub Script_Data_Update(ByRef str As String)
        Select Case scr.script_step
            Case 0
                scr.row = str                   '行數
                scr.script_step += 1
            Case 1
                scr.cmd = Convert.ToInt32(str)  '命令
                scr.script_step += 1
            Case 2
                scr.setting = str               '設定
                scr.script_step += 1
            Case 3
                scr.expect = str                '期待
                scr.script_step += 1
            Case 4                              '最大等待時間(ms)
                If str IsNot "" Then
                    scr.delay = Convert.ToInt32(str)
                Else
                    scr.delay = 0
                End If
                scr.script_step += 1
            Case 5                              '描述
                scr.description = str
                scr.script_step = 0
            Case Else
                ' do nothing
        End Select
    End Sub


    ' ------------------------------------------------------------------------------
    ' ------------------------- [Operation Function Field] ------------------------|
    ' ------------------------------------------------------------------------------
    ' Update here for Operation function
    ' Some Command Might only need to check the value or only need to run some function.
    Private Sub Operation_CMD()
        Select Case scr.cmd
            ' Cmd < 1000 is for function operating (No setting value)
            Case 0 ' Getting Version (Only for Test)
                Form_Panel.Get_Arduino_Version()

            Case 1 ' Setting Sample A1
                Form_Config_Setting.Sending_SampleA1()
                Form_Config_Setting.Sending()

            Case 2 ' Setting Sample A2
                Form_Config_Setting.Sending_SampleA2()
                Form_Config_Setting.Sending()

            Case 3 ' Setting Sample A3
                Form_Config_Setting.Sending_SampleA3()
                Form_Config_Setting.Sending()

            Case 4 ' Setting Sample A4
                Form_Config_Setting.Sending_SampleA4()
                Form_Config_Setting.Sending()

            ' Cmd 1000~2000 is for value setting only.
            Case 1000
                Form_Config_Setting.Sending()

            Case 1001 'Country Setting
                '0. Japan
                '1. North America
                '2. China
                '3. Asia
                '4. Latin1
                '5. Latin2
                '6. Brazil
                '7. Africa/ GCC
                Form_Config_Setting.ComboBoxList(scr.cmd - 1001).SelectedIndex = Convert.ToInt32(scr.setting)

            Case 1002 'Antenna Setting
                '0. Passive Antenna
                '1. Active Antenna
                Form_Config_Setting.ComboBoxList(scr.cmd - 1001).SelectedIndex = Convert.ToInt32(scr.setting)

            Case 1003 ' Number of Speakers
                '0. 4ch: w/ Fader
                '1. 2ch: w/ o Fater
                Form_Config_Setting.ComboBoxList(scr.cmd - 1001).SelectedIndex = Convert.ToInt32(scr.setting)

            Case 1004 ' Steering Wheel place
                '0. RHD:            MIC beam right
                '1. LHD:            MIC beam left
                Form_Config_Setting.ComboBoxList(scr.cmd - 1001).SelectedIndex = Convert.ToInt32(scr.setting)

            Case 1005 ' Phonebook & HP related
                '0. with phonebook
                '1. without phonebook
                Form_Config_Setting.ComboBoxList(scr.cmd - 1001).SelectedIndex = Convert.ToInt32(scr.setting)

            Case 1006 ' Traffic Info for JPN
                '0. Not JPN
                '1. JPN Traffic Info
                Form_Config_Setting.ComboBoxList(scr.cmd - 1001).SelectedIndex = Convert.ToInt32(scr.setting)

            Case 1007 ' Steering Wheel Remote
                '0. 3Key+2Key
                '1. 2Key+1Key
                '2. None
                Form_Config_Setting.ComboBoxList(scr.cmd - 1001).SelectedIndex = Convert.ToInt32(scr.setting)

            Case 1008 ' Browsing Search
                '0. Enable
                '1. Disable
                Form_Config_Setting.ComboBoxList(scr.cmd - 1001).SelectedIndex = Convert.ToInt32(scr.setting)

            Case 1009 ' Default of GEQ/Bass Tre
                '0. Default: GEQ
                '1. Default: Bass/ Tre
                Form_Config_Setting.ComboBoxList(scr.cmd - 1001).SelectedIndex = Convert.ToInt32(scr.setting)

            Case 1010 ' Default of Radio Preset
                '0. CombinationA
                '1. CombinationB
                '2. CombinationC
                '3. CombinationD
                '4. CombinationE
                '5. CombinationF
                Form_Config_Setting.ComboBoxList(scr.cmd - 1001).SelectedIndex = Convert.ToInt32(scr.setting)

            Case 1011 ' HF Parameter
                '0. TBC
                '1. Brank
                Form_Config_Setting.ComboBoxList(scr.cmd - 1001).SelectedIndex = Convert.ToInt32(scr.setting)

            ' Case 2000~2100 is for form displaying 
            Case 2000 ' Showing Form_Config_Setting to init the data
                Form_Config_Setting.Show()

            Case 2001 ' Showing Form_Panel to init the data
                Form_Panel.Show()


            Case Else ' Unexpect CMD
                ' Do nothing 
        End Select
    End Sub

    Private Sub Unexpect_CMD()
        Debug.WriteLine("Unexpect CMD!")
    End Sub

    ' ------------------------------------------------------------------------------
    ' ------------------------------ [Get Value Field] ----------------------------|
    ' ------------------------------------------------------------------------------
    Private Function Get_Actual_CMD()
        Dim str As String
        Select Case scr.cmd
            ' Cmd < 1000 is for function operating (No setting value)
            Case 0 ' Getting Version (Only for Test)
                str = Form_Panel.System_Version.Text

            Case 1 To 4 ' Checking result: Sample A1~A4
                str = Form_Config_Setting.Result.Text


            ' Cmd > 1000 is for value setting only
            Case 1001 To 1011 ' Check if the setting is complete
                'str = Form_Config_Setting.Recevice_Parameter(scr.cmd - 1001)
                str = Form_Config_Setting.ComboBoxList(scr.cmd - 1001).Text

            Case 2000 To 2100 ' Form display, No expect Output
                str = "Form display"

            Case Else ' Unexpect CMD
                str = "Unexpect CMD!"
                ' Do nothing 
        End Select
        Return str
    End Function

    ' ------------------------------------------------------------------------------
    ' --------------------------- [Async Function Field] --------------------------|
    ' ------------------------------------------------------------------------------
    Private Async Function Script_cmd_process() As Task(Of Boolean)
        Operation = AddressOf Operation_CMD
        GetAcual = AddressOf Get_Actual_CMD
        scr.result = Await DelayWithConditionAsync()
        Return scr.result
    End Function

    Private Async Function DelayWithConditionAsync() As Task(Of Boolean) ' Real Processing Function
        Dim delayInterval As Integer = 100 ' Check the value every 100ms.
        Dim timer As Integer = 0
        Display_Info.Text = scr.description

        ' Function Pointer, operate the same function but have different result.
        Operation() ' Operation specific function


        While timer < scr.delay ' Max Delay
            ' Task Delay 100ms
            Await Task.Delay(delayInterval)
            timer += delayInterval

            ' Execute time display
            scr.execute_time += delayInterval
            LB_Execute_Time.Text = (scr.execute_time / 1000).ToString + "s"

            If scr.expect = "" Then
                Continue While
            End If

            Try
                ' Function Pointer, operate the same function but have different result.
                scr.actual = GetAcual() ' Getting specific Value (string only)
            Catch
                ' do nothing
            Finally
                ' do nothing
            End Try

            ' Check if the actual value is same as expect value.
            If scr.expect = scr.actual Then
                Debug.WriteLine("Is True!")
                Return True ' Condition Satisfy
            End If
        End While

        Debug.WriteLine("Is False!")
        Return False ' Timeout, Condition unsatisfy.
    End Function

    ' ------------------------------------------------------------------------------
    ' ---------------------------- [Init Function Field] --------------------------|
    ' ------------------------------------------------------------------------------
    Private Sub Label_clear()
        LB_FailCount.Text = "0"
        LB_LineCount.Text = "0"
        LB_PassCount.Text = "0"
        LB_Execute_Time.Text = "0"
    End Sub

    Private Sub dgv_clear()
        Try
            ' 清空 DataGridView 的資料
            dgv.Columns.Clear()
        Catch
            ' if the dgv already clear
        Finally
            ' do nothing
        End Try
    End Sub

    Private Sub script_init()
        scr.row = ""
        scr.cmd = 0
        scr.setting = ""
        scr.expect = ""
        scr.actual = ""
        scr.delay = 0
        scr.description = ""
        scr.script_step = 0
        scr.result = False
        'scr.execute_time = 0
    End Sub

    Private Sub Delegate_Init()
        Operation = Nothing
        GetAcual = Nothing
    End Sub

    ' ------------------------------------------------------------------------------
    ' --------------------------- [Event Function Field] --------------------------|
    ' ------------------------------------------------------------------------------
    Private Sub Get_Script_Click(sender As Object, e As EventArgs) Handles Get_Script.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.InitialDirectory = "D:\Script"
        openFileDialog.Filter = "CSV files (*.csv)|*.csv"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            Data_Path.Text = filePath
        End If
    End Sub


    Private Sub Start_Scirpt_Click(sender As Object, e As EventArgs) Handles Start_Scirpt.Click
        Try
            Script_Execute()
        Catch
            ' do nothing
        Finally
            ' do nothing
        End Try
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        dgv_clear()
    End Sub

End Class