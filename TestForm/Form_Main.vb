Imports System.IO
Imports System.IO.Ports
Imports System.Text
Imports System.Threading
Imports System.Drawing
Imports System.Math
Imports System.Reflection.Emit

Public Class Form_Main
    'Public Structure Data
    '    Dim Byte0 As Byte
    '    Dim Byte1 As Byte
    '    Dim Byte2 As Byte
    '    Dim Byte3 As Byte
    '    Dim Byte4 As Byte
    '    Dim Byte5 As Byte
    '    Dim Byte6 As Byte
    '    Dim Byte7 As Byte
    'End Structure

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

    ' ------------------------------------------------------------------------------
    ' ---------------------------- [Main Function Field] --------------------------|
    ' ------------------------------------------------------------------------------
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Event when the Form has been called
        COMstr.Text = "COM5"
        BAUstr.Text = "115200"
        comport_info.Text = COMstr.Text + ", "
        comport_info.Text += BAUstr.Text
        RS232 = New SerialPort(COMstr.Text, Val(BAUstr.Text), Parity.None, 8, StopBits.One)

        Debug.WriteLine("Start!")
        If Not RS232.IsOpen Then
            RS232.Open()
            receving = True
            T = New Thread(AddressOf Task_Receive)
            T.IsBackground = True
            T.Start()
        End If
    End Sub
    ' Use Thread to run this unlimit while loop.
    Private Sub Task_Receive()
        While receving = True
            If RS232.IsOpen = True Then
                If RS232.BytesToRead <> 0 Then
                    Get_CMD_From_STM32()
                End If
            End If
        End While
    End Sub

    Private Sub Get_CMD_From_STM32()
        Dim Str As Byte = RS232.ReadByte()

        Debug.Write("Receive: ")
        Debug.WriteLine(Str)
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
        RS232.Open()
    End Sub

    ' connect on/off
    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles Connect.Click
        If RS232.IsOpen Then
            Connect.Text = "OFF"
            RS232.Close()
            Panel5.BackColor = Color.Red
        Else
            Connect.Text = "ON"
            RS232.Open()
            Panel5.BackColor = Color.Lime
        End If
    End Sub
    ' ------------------------------------------------------------------------------
    ' ---------------------------- [Data Setting Field] ---------------------------|
    ' ------------------------------------------------------------------------------
    Public Sub UpdateBottonDataBuf()
        BottonDataBuf(0) = Int(TextBox1.Text)
        BottonDataBuf(1) = Int(TextBox2.Text)
        BottonDataBuf(2) = Int(TextBox3.Text)
        BottonDataBuf(3) = Int(TextBox4.Text)
        BottonDataBuf(4) = Int(TextBox5.Text)
        BottonDataBuf(5) = Int(TextBox6.Text)
        BottonDataBuf(6) = Int(TextBox7.Text)
        BottonDataBuf(7) = Int(TextBox8.Text)
    End Sub

    ' ------------------------------------------------------------------------------
    ' ---------------------------- [Data Sending Field] ---------------------------|
    ' ------------------------------------------------------------------------------
    Public Sub _Send_Real_Way1(CMDtype As Byte, dat_len As Byte, qq() As Byte)
        Dim rec_buf As New List(Of Byte)
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
            Debug.WriteLine(qq(i))
            rec_buf.Add(CType(qq(i), Byte))
            tmp += qq(i)
        Next
        tmp = tmp Mod 256
        chksum = tmp
        Debug.WriteLine(chksum)
        rec_buf.Add(CType(chksum, Byte))

        'For Each a In rec_buf
        '    Debug.WriteLine(a)
        'Next

        If RS232.IsOpen = False Then
            RS232.Open()
        Else
            Try
                'If Not (CMDtype <= 10 And CMDtype >= 7) Then
                Tx_Counter += 1
                'End If
                Debug.WriteLine("Sending!")
                RS232.Write(rec_buf.ToArray(), 0, dat_len + 6)
            Catch ex As Exception
                MessageBox.Show(String.Format(" 出問題啦 :{0}", ex.ToString()))
            Finally
                'receving = False
            End Try
        End If
    End Sub


    Public Sub Get_Arduino_Version()
        _Send_Real_Way1(0, 0, {})
    End Sub
    Private Sub Send_Button_Data()
        _Send_Real_Way1(1, 8, BottonDataBuf)
    End Sub

    ' ------------------------------------------------------------------------------
    ' -------------------------------- [CMD Process] ------------------------------|
    ' ------------------------------------------------------------------------------
    ' If another CMD has been reseved, code here.
    Private Sub CMD_Process(ByVal buffer As Byte())
        Rx_Counter += 1
        Select Case ID
            Case 0 'Version Take
                Get_Ver(buffer)
            Case 1
                ' Do something
            Case 2
                ' Do something
        End Select
    End Sub
    Private Sub Get_Ver(ByVal buffer As Byte())
        System_Version.Text = "v" + buffer(0).ToString + "." + buffer(1).ToString + "." + buffer(2).ToString
    End Sub

    ' ------------------------------------------------------------------------------
    ' -------------------------------- [Button Field] -----------------------------|
    ' ------------------------------------------------------------------------------
    Protected Sub SRC_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SRC.Click
        ' Button Event
        TextBox1.Text = Int(TextBox1.Text) Xor 1
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub
    Protected Sub BND_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BND.Click
        ' Button Event
        TextBox1.Text = Int(TextBox1.Text) Xor 2
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub
    Private Sub next_one_Click(sender As Object, e As EventArgs) Handles next_one.Click
        ' Button Event
        TextBox1.Text = Int(TextBox1.Text) Xor 4
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub

    Private Sub last_one_Click(sender As Object, e As EventArgs) Handles last_one.Click
        ' Button Event
        TextBox1.Text = Int(TextBox1.Text) Xor 8
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub
    Protected Sub DISP_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DISP.Click
        ' Button Event
        TextBox1.Text = Int(TextBox1.Text) Xor 16
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub

    Private Sub music_Click(sender As Object, e As EventArgs) Handles music.Click
        ' Button Event
        TextBox1.Text = Int(TextBox1.Text) Xor 32
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub

    Private Sub rotate_button_Click(sender As Object, e As EventArgs) Handles rotate_button.Click
        ' VOL button
        TextBox2.Text = Int(TextBox2.Text) Xor 1
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub

    Private Sub up_Click(sender As Object, e As EventArgs) Handles up.Click
        ' VOL minus
        TextBox2.Text = Int(TextBox2.Text) Xor 2
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub

    Private Sub dn_Click(sender As Object, e As EventArgs) Handles dn.Click
        ' VOL plus
        TextBox2.Text = Int(TextBox2.Text) Xor 4
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Button Event
        TextBox3.Text = Int(TextBox3.Text) Xor 1
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub
    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Button Event
        TextBox3.Text = Int(TextBox3.Text) Xor 2
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub
    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' Button Event
        TextBox3.Text = Int(TextBox3.Text) Xor 4
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub
    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        ' Button Event
        TextBox3.Text = Int(TextBox3.Text) Xor 8
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub
    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        ' Button Event
        TextBox3.Text = Int(TextBox3.Text) Xor 16
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox3.Text = Int(TextBox3.Text) Xor 32
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub
    Private Sub AUX_CheckedChanged(sender As Object, e As EventArgs) Handles AUX.CheckedChanged
        TextBox4.Text = Int(TextBox4.Text) Xor 1
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub

    Private Sub GetVersion_Click(sender As Object, e As EventArgs) Handles Getversion.Click
        ' VOL button
        Get_Arduino_Version()
    End Sub


    ' ------------------------------------------------------------------------------
    ' -------------------------------- [Event Field] ------------------------------|
    ' ------------------------------------------------------------------------------
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Test2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Test2ToolStripMenuItem.Click
        Form_Test.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

End Class
