Imports System.IO
Imports System.IO.Ports
Imports System.Text
Imports System.Threading
Imports System.Drawing
Imports System.Math
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form_Main
    ' ------------------------------------------------------------------------------
    ' ------------------------------ [Variable Field] -----------------------------|
    ' ------------------------------------------------------------------------------

    ' Connect
    Private T As Thread
    Public RS232 As SerialPort
    Dim receving As Boolean
    Dim buf_index As Byte = 0
    Dim Uart_Step As Byte = 1
    Dim ID As Byte = 0
    Dim LEN As Byte = 0
    Dim cksum As Integer = 0
    ' Only if CHECK_CODE1, CHECK_CODE2, and CHECK_CODE3 are correct, the system will process the CMD.
    Private CHECK_CODE1 As Byte = 12
    Private CHECK_CODE2 As Byte = 34
    Private CHECK_CODE3 As Byte = 56
    'get cmd from Test mechine
    Dim tmpList(256) As Byte
    ' Send cmd to Text mechine
    Dim BottonDataBuf(8) As Byte
    ' Tx/Rx Counter
    Dim Tx_Counter As UInt64
    Dim Rx_Counter As UInt64
    Dim Rx_Counter_Tmp As UInt64
    ' data structure for sending queue
    Public Structure send_struct
        Dim id As Byte
        Dim len As Byte
        Dim data() As Byte
        Dim isSend As Boolean
    End Structure
    Private send_struct_queue(256) As send_struct
    Private send_real_way_index As Byte = 0
    Private index As Byte = 0

    Dim MaxLines As Integer = 100 ' 定義最大行數

    Private Sub send_struct_queue_init()
        For i = 0 To 255
            send_struct_queue(i).id = 0
            send_struct_queue(i).len = 0
            ReDim send_struct_queue(i).data(1)
            send_struct_queue(i).isSend = False
        Next
    End Sub

    ' ------------------------------------------------------------------------------
    ' ---------------------------- [Main Function Field] --------------------------|
    ' ------------------------------------------------------------------------------
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Event when the Form has been called
        LoadComPorts() ' 加載 COM Port 清單
        COMstr.SelectedIndex = 1
        BAUstr.SelectedIndex = 0
        comport_info.Text = COMstr.Text + ", "
        comport_info.Text += BAUstr.Text
        RS232 = New SerialPort(COMstr.Text, Val(BAUstr.Text), Parity.None, 8, StopBits.One)

        Debug.WriteLine("Start!")
        'If Not RS232.IsOpen Then
        '    Try
        '        RS232.Open()
        '        receving = True
        '        T = New Thread(AddressOf Task_Receive)
        '        T.IsBackground = True
        '        T.Start()
        '    Catch ex As Exception
        '        MessageBox.Show(String.Format("Form_Load: 請連接" + COMstr.Text))
        '    Finally
        '        'receving = False
        '    End Try
        'End If

        send_struct_queue_init()
    End Sub
    ' Use Thread to run this unlimit while loop.
    Private Sub Task_Receive()
        While receving = True
            If RS232.IsOpen = True Then
                Try
                    If RS232.BytesToRead <> 0 Then
                        Get_CMD()
                    End If
                Catch ex As Exception
                    MessageBox.Show(String.Format("連線中斷，請重新連接" + COMstr.Text))
                Finally
                    'receving = False
                End Try
            End If
        End While
    End Sub

    Private Sub Get_CMD()
        Dim Str As Byte = RS232.ReadByte()
        Debug.Write("Receive: ")
        Debug.WriteLine(Str)

        Dim MaxLines As Integer = 100 ' 定義最大行數

        ReceiveText.Invoke(Sub()
                               ' 使用 AppendText 高效添加文字
                               ReceiveText.AppendText(ChrW(Str))

                               ' 限制行數，保留最近的 MaxLines 行
                               Dim lines As String() = ReceiveText.Lines
                               If lines.Length > MaxLines Then
                                   ' 丟棄多餘的行，只保留最近的 MaxLines 行
                                   ReceiveText.Lines = lines.Skip(lines.Length - MaxLines).ToArray()
                               End If

                               ' 滾動到最後一行
                               ReceiveText.SelectionStart = ReceiveText.Text.Length
                               ReceiveText.ScrollToCaret()
                           End Sub)

        Select Case Uart_Step
            ' Sync the data
            ' If we don't have this sync signal, the order of data flow might be wrong.
            Case 1
                If Str = CHECK_CODE1 Then
                    Uart_Step = 2
                Else
                    Uart_Step = 1
                End If
            Case 2
                If Str = CHECK_CODE2 Then
                    Uart_Step = 3
                Else
                    Uart_Step = 1
                End If
            Case 3
                If Str = CHECK_CODE3 Then
                    Uart_Step = 4
                Else
                    Uart_Step = 1
                End If

           ' Head
            Case 4
                ID = Str
                cksum = ID
                Uart_Step = 5
            Case 5
                LEN = Str
                cksum += LEN
                Uart_Step = 6

            ' Data
            Case 6
                If buf_index > LEN - 1 Then
                    cksum = cksum Mod 256
                    If cksum = Str Then
                        'Console.WriteLine("CHECKSUM!")
                        _Uart_Parse(tmpList)
                    End If
                    Uart_Step = 1
                    buf_index = 0
                Else
                    tmpList(buf_index) = Str
                    cksum += Str
                    buf_index += 1
                End If
        End Select
    End Sub
    Private Delegate Sub Display(ByVal buffer As Byte())
    Private Sub _Uart_Parse(ByVal tmpList() As Byte)
        Dim d As New Display(AddressOf CMD_Process)
        Me.Invoke(d, New Object() {tmpList.ToArray()})
    End Sub
    ' ------------------------------------------------------------------------------
    ' ------------------------------ [RS232 Control] ------------------------------|
    ' ------------------------------------------------------------------------------
    Private Sub Comport_Set_Click(sender As Object, e As EventArgs) Handles comport_Set.Click
        RS232.Close()
        RS232.PortName = COMstr.Text
        RS232.BaudRate = Val(BAUstr.Text)
        comport_info.Text = COMstr.Text + ", "
        comport_info.Text += BAUstr.Text
        Try
            RS232.Open()
        Catch ex As Exception
            MessageBox.Show(String.Format("Comport_Set_Click: 無法開啟連接埠"))
        Finally
            'receving = False
        End Try
    End Sub

    ' connect on/off
    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles Connect.Click

        If RS232.IsOpen Then
            Connect.Text = "OFF"
            RS232.Close()
            'Panel5.BackColor = Color.Red
        Else
            'Panel5.BackColor = Color.Lime
            Try
                Connect.Text = "ON"
                RS232.Open()
            Catch ex As Exception
                MessageBox.Show(String.Format("Connect_Click: 無法開啟連接埠"))
            Finally
                'receving = False
            End Try
        End If
    End Sub

    ' 加載可用的 COM Port 到 ComboBox
    Private Sub LoadComPorts()
        Try
            ' 獲取所有可用的 COM Port
            Dim ports As String() = SerialPort.GetPortNames()

            ' 清空 ComboBox
            COMstr.Items.Clear()

            ' 將每個 COM Port 添加到 ComboBox
            For Each port As String In ports
                COMstr.Items.Add(port)
            Next

            ' 如果有可用的 COM Port，選中第一個作為預設值
            If COMstr.Items.Count > 0 Then
                COMstr.SelectedIndex = 0
            Else
                MessageBox.Show("未檢測到可用的 COM Port！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"發生錯誤: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub COMstr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMstr.SelectedIndexChanged
        ' 加載可用的 COM Port 到 ComboBox
        'LoadComPorts()
    End Sub
    ' ------------------------------------------------------------------------------
    ' ---------------------------- [Data Sending Field] ---------------------------|
    ' ------------------------------------------------------------------------------
    Public Sub _Send_Real_Way1(CMDtype As Byte, dat_len As Byte, qq() As Byte)

        Dim rec_buf As New List(Of Byte)

        If CMDtype < 255 Then ' 如果非純文字資料
            Dim tmp As UInt16
            Dim chksum As Byte
            rec_buf.Add(CHECK_CODE1)
            rec_buf.Add(CHECK_CODE2)
            rec_buf.Add(CHECK_CODE3)
            rec_buf.Add(CType(CMDtype, Byte))
            rec_buf.Add(CType(dat_len, Byte))
            tmp += CMDtype
            tmp += dat_len
            'For Each q In qq
            '    Debug.WriteLine(q)
            '    rec_buf.Add(CType(q, Byte))
            '    tmp += q
            'Next
            For i = 0 To dat_len - 1
                'Debug.WriteLine(qq(i))
                rec_buf.Add(CType(qq(i), Byte))
                tmp += qq(i)
            Next
            tmp = tmp Mod 256
            chksum = tmp
            'Debug.WriteLine(chksum)
            rec_buf.Add(CType(chksum, Byte))
        Else
            For i = 0 To dat_len - 1
                'Debug.WriteLine(qq(i))
                rec_buf.Add(CType(qq(i), Byte))
            Next
        End If
        'For Each a In rec_buf
        '    Debug.WriteLine(a)
        'Next

        If RS232.IsOpen = False Then
            Try
                RS232.Open()
            Catch ex As Exception
                MessageBox.Show(String.Format("Send_real_way1: 請連接COMPORT"))
            Finally
                'receving = False
            End Try
        Else
            Try
                Tx_Counter += 1
                'End If
                'Debug.WriteLine("Sending!")
                Dim result As String
                If CMDtype < 255 Then ' 如果非純文字資料
                    RS232.Write(rec_buf.ToArray(), 0, dat_len + 6)
                    result = BitConverter.ToString(rec_buf.ToArray()) + vbCrLf
                Else
                    RS232.Write(rec_buf.ToArray(), 0, dat_len)
                    ' 輸出中文用
                    result = System.Text.Encoding.UTF8.GetString(rec_buf.ToArray())
                End If

                InputLogText.Invoke(Sub()
                                        ' 使用 AppendText 高效添加文字
                                        InputLogText.AppendText(result)

                                        ' 限制行數，保留最近的 MaxLines 行
                                        Dim lines As String() = InputLogText.Lines
                                        If lines.Length > MaxLines Then
                                            ' 丟棄多餘的行，只保留最近的 MaxLines 行
                                            InputLogText.Lines = lines.Skip(lines.Length - MaxLines).ToArray()
                                        End If

                                        ' 滾動到最後一行
                                        InputLogText.SelectionStart = InputLogText.Text.Length
                                        InputLogText.ScrollToCaret()
                                    End Sub)
            Catch ex As Exception
                'Debug.WriteLine("Sending Fail!")
                MessageBox.Show(String.Format("Send_real_way1: 無法送出資料"))
            Finally
                'receving = False
            End Try
        End If
    End Sub

    Public Sub set_queue(id As Byte, len As Byte, data() As Byte)
        send_struct_queue(index).id = id
        send_struct_queue(index).len = len
        ReDim send_struct_queue(index).data(len)
        For i = 0 To len - 1
            send_struct_queue(index).data(i) = data(i)
        Next
        send_struct_queue(index).isSend = True ' Mark as new data
        index = (index + 1) Mod 256
        'Debug.WriteLine(index)
    End Sub

    Private Sub send_queue()
        If send_struct_queue(send_real_way_index).isSend = True And RS232.IsOpen Then ' Check if the data has been send
            _Send_Real_Way1(send_struct_queue(send_real_way_index).id,
                        send_struct_queue(send_real_way_index).len,
                        send_struct_queue(send_real_way_index).data)
            send_struct_queue(send_real_way_index).isSend = False
            send_real_way_index = (send_real_way_index + 1) Mod 256
            'Debug.WriteLine(send_real_way_index)
        End If
    End Sub

    ' ------------------------------------------------------------------------------
    ' -------------------------------- [CMD Setting] ------------------------------|
    ' ------------------------------------------------------------------------------


    ' ------------------------------------------------------------------------------
    ' -------------------------------- [CMD Process] ------------------------------|
    ' ------------------------------------------------------------------------------
    ' If another CMD has been reseved, code here.
    Private Sub CMD_Process(ByVal buffer As Byte())
        Rx_Counter += 1
        Select Case ID
            Case 0 'Version Take
                Form_Panel.Get_Ver(buffer)
            Case 1
                ' Do something
            Case 2
                ' Do something
        End Select
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' 在資料後追加結束符號
        Dim formattedData As String = InputText.Text & vbCrLf
        ' 將資料轉換為 ASCII 編碼
        Dim bytes As Byte() = System.Text.Encoding.ASCII.GetBytes(formattedData)
        ' 發送資料
        'RS232.Write(bytes, 0, bytes.Length)
        set_queue(255, bytes.Length, bytes)
    End Sub

    ' ------------------------------------------------------------------------------
    ' -------------------------------- [Event Field] ------------------------------|
    ' ------------------------------------------------------------------------------
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        send_queue() ' Send the data every 100ms by queue
        If RS232.IsOpen Then
            Panel5.BackColor = Color.LimeGreen
        Else
            Panel5.BackColor = Color.Red
        End If
    End Sub

    Private Sub Test2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormTestToolStripMenuItem.Click
        Form_Test.Show()
    End Sub

    Private Sub FormPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormPanelToolStripMenuItem.Click
        Form_Panel.Show()
    End Sub
End Class
