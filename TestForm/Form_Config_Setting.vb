Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form_Config_Setting

    Private ComboBoxList() As System.Windows.Forms.ComboBox
    Private Parameter(11) As Byte

    Private Sub Form_Config_Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' 初始化 ComboBox 列表
        ComboBoxList = {ComboBox1, ComboBox2, ComboBox3, ComboBox4, ComboBox5, ComboBox6, ComboBox7, ComboBox8, ComboBox9, ComboBox10, ComboBox11}

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
        ComboBox1.SelectedIndex = 6 'Africa/GCC
        ComboBox2.SelectedIndex = 0 'Passive
        ComboBox3.SelectedIndex = 0 '4ch
        ComboBox4.SelectedIndex = 1 'LHD
        ComboBox5.SelectedIndex = 0 'with phonebook
        ComboBox6.SelectedIndex = 0 'not jpn
        ComboBox7.SelectedIndex = 2 'none
        ComboBox8.SelectedIndex = 0 'Enable
        ComboBox9.SelectedIndex = 1 'Default Bass/Tre
        ComboBox10.SelectedIndex = 0 ' CombinationA
        ComboBox11.SelectedIndex = 1 ' Brank
        Set_Parameter()
    End Sub
    Private Sub SampleA2_Click(sender As Object, e As EventArgs) Handles SampleA2.Click ' with BT
        ComboBox1.SelectedIndex = 0 'Japan
        ComboBox2.SelectedIndex = 0 'Passive
        ComboBox3.SelectedIndex = 0 '4ch
        ComboBox4.SelectedIndex = 0 'RHD
        ComboBox5.SelectedIndex = 1 'without phonebook
        ComboBox6.SelectedIndex = 1 'jpn
        ComboBox7.SelectedIndex = 0 '3key+2Key
        ComboBox8.SelectedIndex = 1 'Disable
        ComboBox9.SelectedIndex = 0 'Default GEQ
        ComboBox10.SelectedIndex = 1 ' CombinationB
        ComboBox11.SelectedIndex = 1 ' Brank
        Set_Parameter()
    End Sub
    Private Sub SampleA3_Click(sender As Object, e As EventArgs) Handles SampleA3.Click ' without BT
        ComboBox1.SelectedIndex = 0 'Japan
        ComboBox2.SelectedIndex = 0 'Passive
        ComboBox3.SelectedIndex = 0 '4ch
        ComboBox4.SelectedIndex = 0 'RHD
        ComboBox5.SelectedIndex = 1 'without phonebook
        ComboBox6.SelectedIndex = 1 'jpn
        ComboBox7.SelectedIndex = 0 '3key+2Key
        ComboBox8.SelectedIndex = 1 'Disable
        ComboBox9.SelectedIndex = 0 'Default GEQ
        ComboBox10.SelectedIndex = 1 ' CombinationB
        ComboBox11.SelectedIndex = 1 ' Brank
        Set_Parameter()
    End Sub
    Private Sub SampleA4_Click(sender As Object, e As EventArgs) Handles SampleA4.Click
        ComboBox1.SelectedIndex = 5 'Latin2
        ComboBox2.SelectedIndex = 1 'Active
        ComboBox3.SelectedIndex = 1 '2ch
        ComboBox4.SelectedIndex = 1 'LHD
        ComboBox5.SelectedIndex = 0 'with phonebook
        ComboBox6.SelectedIndex = 0 'not jpn
        ComboBox7.SelectedIndex = 1 '2Key+1Key
        ComboBox8.SelectedIndex = 0 'Enable
        ComboBox9.SelectedIndex = 1 'Default Bass/Tre
        ComboBox10.SelectedIndex = 4 ' CombinationE
        ComboBox11.SelectedIndex = 1 ' Brank
        Set_Parameter()
    End Sub

    'Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged,
    '                                                                                    ComboBox2.SelectedIndexChanged,
    '                                                                                    ComboBox3.SelectedIndexChanged,
    '                                                                                    ComboBox4.SelectedIndexChanged,
    '                                                                                    ComboBox5.SelectedIndexChanged,
    '                                                                                    ComboBox6.SelectedIndexChanged,
    '                                                                                    ComboBox7.SelectedIndexChanged,
    '                                                                                    ComboBox8.SelectedIndexChanged,
    '                                                                                    ComboBox9.SelectedIndexChanged,
    '                                                                                    ComboBox10.SelectedIndexChanged,
    '                                                                                    ComboBox11.SelectedIndexChanged
    '    'Set_Parameter()
    'End Sub

    Private Sub Set_Parameter()
        For i = 0 To 10
            Try
                Parameter(i) = ComboBoxList(i).SelectedIndex
                'TextBoxList(i).Text = Parameter(i)
                DataGridView1.Rows(i).Cells(0).Value = $"Byte{i} = {Parameter(i)}"
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
                DataGridView1.Rows(i).Cells(1).Value = $"Byte{i} = {buffer(i)}"
                If Not buffer(i) = Parameter(i) Then
                    is_correct = False
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
        Set_Parameter()
        Form_Main.set_queue(2, 11, Parameter)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_Main.set_queue(3, 0, {})
    End Sub
End Class