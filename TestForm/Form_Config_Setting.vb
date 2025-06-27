Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form_Config_Setting

    Public ComboBoxList() As System.Windows.Forms.ComboBox
    Public Sending_Parameter(11) As Byte
    Public Recevice_Parameter(11) As Byte

    Private Sub Form_Config_Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' 初始化 ComboBox 列表
        ComboBoxList = {CB_Country, CB_Antenna, CB_Number_of_Speaker, CB_Steering_Wheel_Place, CB_Phonebook_HP_related, CB_Traffic_Info_For_JPN, CB_Steering_Wheel_Remote, CB_Browsing_Search, CB_Default_GEQ_Bass_Tre, CB_Default_Radio_Preset, CB_HF_Parameter}

        ' 初始化 DataGridView
        InitializeDataGridView()

        ' 初始化 ComboBox 值
        ComboBoxList(0).SelectedIndex = 7
        ComboBoxList(1).SelectedIndex = 0
        ComboBoxList(2).SelectedIndex = 0
        ComboBoxList(3).SelectedIndex = 1
        ComboBoxList(4).SelectedIndex = 0
        ComboBoxList(5).SelectedIndex = 0
        ComboBoxList(6).SelectedIndex = 2
        ComboBoxList(7).SelectedIndex = 0
        ComboBoxList(8).SelectedIndex = 1
        ComboBoxList(9).SelectedIndex = 0
        ComboBoxList(10).SelectedIndex = 0
        Set_Parameter()

    End Sub

    Public Sub Sending_Parameter_Init()
        For i = 0 To 10
            Sending_Parameter(i) = 0
        Next
    End Sub
    Public Sub Recevice_Parameter_Init()
        For i = 0 To 10
            Recevice_Parameter(i) = 0
        Next
    End Sub
    Public Sub Sending()
        Recevice_Parameter_Init()
        Set_Parameter()
        Form_Main.set_queue(2, 11, Sending_Parameter)
    End Sub

    Private Sub InitializeDataGridView()

        ' 設置 DataGridView 的基本屬性
        DataGridView1.ColumnCount = 2 ' 設置列數為 2
        DataGridView1.RowCount = 11  ' 設置行數為 11
        'DataGridView1.AllowUserToAddRows = False ' 禁止用戶添加新行
        'DataGridView1.AllowUserToResizeRows = False ' 禁止調整行高
        'DataGridView1.AllowUserToResizeColumns = False ' 禁止調整列寬
        DataGridView1.RowHeadersVisible = False ' 隱藏行頭
        DataGridView1.ColumnHeadersVisible = True ' 顯示列標題

        ' 設置列標題
        DataGridView1.Columns(0).Name = "Sending"
        DataGridView1.Columns(1).Name = "Receiving"

        '' 填充測試數據
        'For i As Integer = 0 To DataGridView1.RowCount - 1
        '    DataGridView1.Rows(i).Cells(0).Value = $"Row {i + 1}, Col 1"
        '    DataGridView1.Rows(i).Cells(1).Value = $"Row {i + 1}, Col 2"
        'Next

        ' 設置行的交替顏色
        For i As Integer = 0 To DataGridView1.RowCount - 1
            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White ' 偶數行顏色
            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightGray ' 奇數行顏色
            End If
        Next

        ' 欄寬自動填滿DGV
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub SampleA1_Click(sender As Object, e As EventArgs) Handles SampleA1.Click
        Sending_SampleA1()
    End Sub
    Private Sub SampleA2_Click(sender As Object, e As EventArgs) Handles SampleA2.Click ' with BT
        Sending_SampleA2()
    End Sub
    Private Sub SampleA3_Click(sender As Object, e As EventArgs) Handles SampleA3.Click ' without BT
        Sending_SampleA3()
    End Sub
    Private Sub SampleA4_Click(sender As Object, e As EventArgs) Handles SampleA4.Click
        Sending_SampleA4()
    End Sub

    Public Sub Sending_SampleA1()
        CB_Country.SelectedIndex = 6 'Africa/GCC
        CB_Antenna.SelectedIndex = 0 'Passive
        CB_Number_of_Speaker.SelectedIndex = 0 '4ch
        CB_Steering_Wheel_Place.SelectedIndex = 1 'LHD
        CB_Phonebook_HP_related.SelectedIndex = 0 'with phonebook
        CB_Traffic_Info_For_JPN.SelectedIndex = 0 'not jpn
        CB_Steering_Wheel_Remote.SelectedIndex = 2 'none
        CB_Browsing_Search.SelectedIndex = 0 'Enable
        CB_Default_GEQ_Bass_Tre.SelectedIndex = 1 'Default Bass/Tre
        CB_Default_Radio_Preset.SelectedIndex = 0 ' CombinationA
        CB_HF_Parameter.SelectedIndex = 1 ' Brank
        Set_Parameter()
    End Sub
    Public Sub Sending_SampleA2()
        CB_Country.SelectedIndex = 0 'Japan
        CB_Antenna.SelectedIndex = 0 'Passive
        CB_Number_of_Speaker.SelectedIndex = 0 '4ch
        CB_Steering_Wheel_Place.SelectedIndex = 0 'RHD
        CB_Phonebook_HP_related.SelectedIndex = 1 'without phonebook
        CB_Traffic_Info_For_JPN.SelectedIndex = 1 'jpn
        CB_Steering_Wheel_Remote.SelectedIndex = 0 '3key+2Key
        CB_Browsing_Search.SelectedIndex = 1 'Disable
        CB_Default_GEQ_Bass_Tre.SelectedIndex = 0 'Default GEQ
        CB_Default_Radio_Preset.SelectedIndex = 1 ' CombinationB
        CB_HF_Parameter.SelectedIndex = 1 ' Brank
        Set_Parameter()
    End Sub
    Public Sub Sending_SampleA3()
        CB_Country.SelectedIndex = 0 'Japan
        CB_Antenna.SelectedIndex = 0 'Passive
        CB_Number_of_Speaker.SelectedIndex = 0 '4ch
        CB_Steering_Wheel_Place.SelectedIndex = 0 'RHD
        CB_Phonebook_HP_related.SelectedIndex = 1 'without phonebook
        CB_Traffic_Info_For_JPN.SelectedIndex = 1 'jpn
        CB_Steering_Wheel_Remote.SelectedIndex = 0 '3key+2Key
        CB_Browsing_Search.SelectedIndex = 1 'Disable
        CB_Default_GEQ_Bass_Tre.SelectedIndex = 0 'Default GEQ
        CB_Default_Radio_Preset.SelectedIndex = 1 ' CombinationB
        CB_HF_Parameter.SelectedIndex = 1 ' Brank
        Set_Parameter()
    End Sub
    Public Sub Sending_SampleA4()
        CB_Country.SelectedIndex = 5 'Latin2
        CB_Antenna.SelectedIndex = 1 'Active
        CB_Number_of_Speaker.SelectedIndex = 1 '2ch
        CB_Steering_Wheel_Place.SelectedIndex = 1 'LHD
        CB_Phonebook_HP_related.SelectedIndex = 0 'with phonebook
        CB_Traffic_Info_For_JPN.SelectedIndex = 0 'not jpn
        CB_Steering_Wheel_Remote.SelectedIndex = 1 '2Key+1Key
        CB_Browsing_Search.SelectedIndex = 0 'Enable
        CB_Default_GEQ_Bass_Tre.SelectedIndex = 1 'Default Bass/Tre
        CB_Default_Radio_Preset.SelectedIndex = 4 ' CombinationE
        CB_HF_Parameter.SelectedIndex = 1 ' Brank
        Set_Parameter()
    End Sub

    'Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Country.SelectedIndexChanged,
    '                                                                                    CB_Antenna.SelectedIndexChanged,
    '                                                                                    CB_Number_of_Speaker.SelectedIndexChanged,
    '                                                                                    CB_Steering_Wheel_Place.SelectedIndexChanged,
    '                                                                                    CB_Phonebook_HP_related.SelectedIndexChanged,
    '                                                                                    CB_Traffic_Info_For_JPN.SelectedIndexChanged,
    '                                                                                    CB_Steering_Wheel_Remote.SelectedIndexChanged,
    '                                                                                    CB_Browsing_Search.SelectedIndexChanged,
    '                                                                                    CB_Default_GEQ_Bass_Tre.SelectedIndexChanged,
    '                                                                                    CB_Default_Radio_Preset.SelectedIndexChanged,
    '                                                                                    CB_HF_Parameter.SelectedIndexChanged
    '    Set_Parameter()
    'End Sub

    Private Sub Set_Parameter()
        For i = 0 To 10
            Try
                Sending_Parameter(i) = ComboBoxList(i).SelectedIndex
                'TextBoxList(i).Text = Sending_Parameter(i)
                DataGridView1.Rows(i).Cells(0).Value = $"Byte{i} = {Sending_Parameter(i)}"
            Catch ex As Exception
                ' Do nothging
            Finally
                ' Do nothging
            End Try
        Next
    End Sub

    Public Sub Get_Parameter(ByRef buffer() As Byte)
        Dim is_correct As Boolean = True
        For i = 0 To 10
            Try
                Recevice_Parameter(i) = buffer(i)
                DataGridView1.Rows(i).Cells(1).Value = $"Byte{i} = {Recevice_Parameter(i)}"
                If Not buffer(i) = Sending_Parameter(i) Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
                    is_correct = False
                Else
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White
                End If
            Catch ex As Exception
                ' Do nothging
            Finally
                ' Do nothging
            End Try
        Next
        If is_correct = True Then
            Result_Background.BackColor = Color.LimeGreen
            Result.Text = "OK"
        Else
            Result_Background.BackColor = Color.Red
            Result.Text = "NG"
        End If
    End Sub

    Private Sub SendButtonCmd_Click(sender As Object, e As EventArgs) Handles SendButtonCmd.Click
        Sending()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Disconncet.Click
        Form_Main.set_queue(3, 0, {})
    End Sub
End Class