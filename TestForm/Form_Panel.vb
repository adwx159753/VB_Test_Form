Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form_Panel
    Private TextBoxList() As System.Windows.Forms.TextBox
    Private Sub Form_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Cursor = System.Windows.Forms.Cursors.Default
        TextBoxList = {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8}
    End Sub

    ' ------------------------------------------------------------------------------
    ' ---------------------------- [Data Setting Field] ---------------------------|
    ' ------------------------------------------------------------------------------

    Dim BottonDataBuf(8) As Byte
    Public Sub UpdateBottonDataBuf()
        For i = 0 To 7
            BottonDataBuf(i) = Int(TextBoxList(i).Text)
        Next
    End Sub

    ' ------------------------------------------------------------------------------
    ' -------------------------------- [CMD Setting] ------------------------------|
    ' ------------------------------------------------------------------------------
    Private Sub Send_Button_Cmd()
        Form_Main.set_queue(1, 8, BottonDataBuf)
    End Sub
    Public Sub Get_Arduino_Version()
        Form_Main.set_queue(0, 0, {})
    End Sub

    ' ------------------------------------------------------------------------------
    ' -------------------------------- [CMD Process] ------------------------------|
    ' ------------------------------------------------------------------------------
    Public Sub Get_Ver(ByVal buffer As Byte())
        System_Version.Text = "v" + buffer(0).ToString + "." + buffer(1).ToString + "." + buffer(2).ToString
    End Sub

    Private Sub GetVersion_Click(sender As Object, e As EventArgs) Handles Getversion.Click
        Get_Arduino_Version()
    End Sub

    Private Sub SendButtonCmd_Click(sender As Object, e As EventArgs) Handles SendButtonCmd.Click
        UpdateBottonDataBuf()
        Send_Button_Cmd()
    End Sub
    ' ------------------------------------------------------------------------------
    ' -------------------------------- [Button Field] -----------------------------|
    ' ------------------------------------------------------------------------------
    Protected Sub SRC_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SRC.Click
        ' Button Event
        BottonDataBuf(0) = 1
        BottonDataBuf(1) = 0
        BottonDataBuf(2) = 0
        BottonDataBuf(3) = 0
        BottonDataBuf(4) = 0
        BottonDataBuf(5) = 0
        BottonDataBuf(6) = 0
        BottonDataBuf(7) = 0
        Send_Button_Cmd()
    End Sub
    Protected Sub BND_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BND.Click
        ' Button Event
        BottonDataBuf(0) = 2
        BottonDataBuf(1) = 0
        BottonDataBuf(2) = 0
        BottonDataBuf(3) = 0
        BottonDataBuf(4) = 0
        BottonDataBuf(5) = 0
        BottonDataBuf(6) = 0
        BottonDataBuf(7) = 0
        Send_Button_Cmd()
    End Sub
    Private Sub next_one_Click(sender As Object, e As EventArgs) Handles next_one.Click
        ' Button Event
        BottonDataBuf(0) = 4
        BottonDataBuf(1) = 0
        BottonDataBuf(2) = 0
        BottonDataBuf(3) = 0
        BottonDataBuf(4) = 0
        BottonDataBuf(5) = 0
        BottonDataBuf(6) = 0
        BottonDataBuf(7) = 0
        Send_Button_Cmd()
    End Sub

    Private Sub last_one_Click(sender As Object, e As EventArgs) Handles last_one.Click
        ' Button Event
        BottonDataBuf(0) = 8
        BottonDataBuf(1) = 0
        BottonDataBuf(2) = 0
        BottonDataBuf(3) = 0
        BottonDataBuf(4) = 0
        BottonDataBuf(5) = 0
        BottonDataBuf(6) = 0
        BottonDataBuf(7) = 0
        Send_Button_Cmd()
    End Sub
    Protected Sub DISP_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DISP.Click
        ' Button Event
        BottonDataBuf(0) = 16
        BottonDataBuf(1) = 0
        BottonDataBuf(2) = 0
        BottonDataBuf(3) = 0
        BottonDataBuf(4) = 0
        BottonDataBuf(5) = 0
        BottonDataBuf(6) = 0
        BottonDataBuf(7) = 0
        Send_Button_Cmd()
    End Sub

    Private Sub music_Click(sender As Object, e As EventArgs) Handles music.Click
        ' Button Event
        BottonDataBuf(0) = 32
        BottonDataBuf(1) = 0
        BottonDataBuf(2) = 0
        BottonDataBuf(3) = 0
        BottonDataBuf(4) = 0
        BottonDataBuf(5) = 0
        BottonDataBuf(6) = 0
        BottonDataBuf(7) = 0
        Send_Button_Cmd()
    End Sub

    Private Sub rotate_button_Click(sender As Object, e As EventArgs) Handles rotate_button.Click
        ' VOL button
        BottonDataBuf(0) = 0
        BottonDataBuf(1) = 1
        BottonDataBuf(2) = 0
        BottonDataBuf(3) = 0
        BottonDataBuf(4) = 0
        BottonDataBuf(5) = 0
        BottonDataBuf(6) = 0
        BottonDataBuf(7) = 0
        Send_Button_Cmd()
    End Sub

    Private Sub up_Click(sender As Object, e As EventArgs) Handles up.Click
        ' VOL minus
        BottonDataBuf(0) = 0
        BottonDataBuf(1) = 2
        BottonDataBuf(2) = 0
        BottonDataBuf(3) = 0
        BottonDataBuf(4) = 0
        BottonDataBuf(5) = 0
        BottonDataBuf(6) = 0
        BottonDataBuf(7) = 0
        Send_Button_Cmd()
    End Sub

    Private Sub dn_Click(sender As Object, e As EventArgs) Handles dn.Click
        ' VOL plus
        BottonDataBuf(0) = 0
        BottonDataBuf(1) = 4
        BottonDataBuf(2) = 0
        BottonDataBuf(3) = 0
        BottonDataBuf(4) = 0
        BottonDataBuf(5) = 0
        BottonDataBuf(6) = 0
        BottonDataBuf(7) = 0
        Send_Button_Cmd()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        ' Button Event
        BottonDataBuf(0) = 0
        BottonDataBuf(1) = 0
        BottonDataBuf(2) = 1
        BottonDataBuf(3) = 0
        BottonDataBuf(4) = 0
        BottonDataBuf(5) = 0
        BottonDataBuf(6) = 0
        BottonDataBuf(7) = 0
        Send_Button_Cmd()
    End Sub
    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        ' Button Event
        BottonDataBuf(0) = 0
        BottonDataBuf(1) = 0
        BottonDataBuf(2) = 2
        BottonDataBuf(3) = 0
        BottonDataBuf(4) = 0
        BottonDataBuf(5) = 0
        BottonDataBuf(6) = 0
        BottonDataBuf(7) = 0
        Send_Button_Cmd()
    End Sub
    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        ' Button Event
        BottonDataBuf(0) = 0
        BottonDataBuf(1) = 0
        BottonDataBuf(2) = 4
        BottonDataBuf(3) = 0
        BottonDataBuf(4) = 0
        BottonDataBuf(5) = 0
        BottonDataBuf(6) = 0
        BottonDataBuf(7) = 0
        Send_Button_Cmd()
    End Sub
    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        ' Button Event
        BottonDataBuf(0) = 0
        BottonDataBuf(1) = 0
        BottonDataBuf(2) = 8
        BottonDataBuf(3) = 0
        BottonDataBuf(4) = 0
        BottonDataBuf(5) = 0
        BottonDataBuf(6) = 0
        BottonDataBuf(7) = 0
        Send_Button_Cmd()
    End Sub
    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        ' Button Event
        BottonDataBuf(0) = 0
        BottonDataBuf(1) = 0
        BottonDataBuf(2) = 16
        BottonDataBuf(3) = 0
        BottonDataBuf(4) = 0
        BottonDataBuf(5) = 0
        BottonDataBuf(6) = 0
        BottonDataBuf(7) = 0
        Send_Button_Cmd()
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Button Event
        BottonDataBuf(0) = 0
        BottonDataBuf(1) = 0
        BottonDataBuf(2) = 32
        BottonDataBuf(3) = 0
        BottonDataBuf(4) = 0
        BottonDataBuf(5) = 0
        BottonDataBuf(6) = 0
        BottonDataBuf(7) = 0
        Send_Button_Cmd()
    End Sub

    ' ------------------------------------------------------------------------------
    ' ------------------------------ [Check Box Field] ----------------------------|
    ' ------------------------------------------------------------------------------
    ' TextBox1
    Private Sub SRC_c_CheckedChanged(sender As Object, e As EventArgs) Handles SRC_c.CheckedChanged
        TextBox1.Text = Int(TextBox1.Text) Xor 1
        UpdateBottonDataBuf()
    End Sub

    Private Sub BND_C_CheckedChanged(sender As Object, e As EventArgs) Handles BND_C.CheckedChanged
        TextBox1.Text = Int(TextBox1.Text) Xor 2
        UpdateBottonDataBuf()
    End Sub

    Private Sub next_c_CheckedChanged(sender As Object, e As EventArgs) Handles next_c.CheckedChanged
        TextBox1.Text = Int(TextBox1.Text) Xor 4
        UpdateBottonDataBuf()
    End Sub

    Private Sub last_c_CheckedChanged(sender As Object, e As EventArgs) Handles last_c.CheckedChanged
        TextBox1.Text = Int(TextBox1.Text) Xor 8
        UpdateBottonDataBuf()
    End Sub

    Private Sub DISP_c_CheckedChanged(sender As Object, e As EventArgs) Handles DISP_c.CheckedChanged
        TextBox1.Text = Int(TextBox1.Text) Xor 16
        UpdateBottonDataBuf()
    End Sub

    Private Sub music_c_CheckedChanged(sender As Object, e As EventArgs) Handles music_c.CheckedChanged
        TextBox1.Text = Int(TextBox1.Text) Xor 32
        UpdateBottonDataBuf()
    End Sub

    ' TextBox2
    Private Sub up_c_CheckedChanged(sender As Object, e As EventArgs) Handles up_c.CheckedChanged
        TextBox2.Text = Int(TextBox2.Text) Xor 2
        UpdateBottonDataBuf()
    End Sub

    Private Sub dn_c_CheckedChanged(sender As Object, e As EventArgs) Handles dn_c.CheckedChanged
        TextBox2.Text = Int(TextBox2.Text) Xor 4
        UpdateBottonDataBuf()
    End Sub

    Private Sub R_c_CheckedChanged(sender As Object, e As EventArgs) Handles R_c.CheckedChanged
        TextBox2.Text = Int(TextBox2.Text) Xor 1
        UpdateBottonDataBuf()
    End Sub

    ' TextBox3
    Private Sub B1_c_CheckedChanged(sender As Object, e As EventArgs) Handles B1_c.CheckedChanged
        TextBox3.Text = Int(TextBox3.Text) Xor 1
        UpdateBottonDataBuf()
    End Sub
    Private Sub B2_c_CheckedChanged(sender As Object, e As EventArgs) Handles B2_c.CheckedChanged
        TextBox3.Text = Int(TextBox3.Text) Xor 2
        UpdateBottonDataBuf()
    End Sub

    Private Sub B3_c_CheckedChanged(sender As Object, e As EventArgs) Handles B3_c.CheckedChanged
        TextBox3.Text = Int(TextBox3.Text) Xor 4
        UpdateBottonDataBuf()
    End Sub

    Private Sub B4_c_CheckedChanged(sender As Object, e As EventArgs) Handles B4_c.CheckedChanged
        TextBox3.Text = Int(TextBox3.Text) Xor 8
        UpdateBottonDataBuf()
    End Sub

    Private Sub B5_c_CheckedChanged(sender As Object, e As EventArgs) Handles B5_c.CheckedChanged
        TextBox3.Text = Int(TextBox3.Text) Xor 16
        UpdateBottonDataBuf()
    End Sub

    Private Sub B6_c_CheckedChanged(sender As Object, e As EventArgs) Handles B6_c.CheckedChanged
        TextBox3.Text = Int(TextBox3.Text) Xor 32
        UpdateBottonDataBuf()
    End Sub

    ' TextBox4
    Private Sub AUX_CheckedChanged(sender As Object, e As EventArgs) Handles AUX.CheckedChanged
        TextBox4.Text = Int(TextBox4.Text) Xor 1
        UpdateBottonDataBuf()
    End Sub

    Private Sub USB_CheckedChanged(sender As Object, e As EventArgs) Handles USB.CheckedChanged
        TextBox4.Text = Int(TextBox4.Text) Xor 2
        UpdateBottonDataBuf()
    End Sub

    Private Sub Hold_CheckedChanged(sender As Object, e As EventArgs) Handles Hold.CheckedChanged
        TextBox4.Text = Int(TextBox5.Text) Xor 1
        UpdateBottonDataBuf()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SRC_c.CheckState = CheckState.Unchecked
        BND_C.CheckState = CheckState.Unchecked
        last_c.CheckState = CheckState.Unchecked
        next_c.CheckState = CheckState.Unchecked
        DISP_c.CheckState = CheckState.Unchecked
        music_c.CheckState = CheckState.Unchecked
        up_c.CheckState = CheckState.Unchecked
        R_c.CheckState = CheckState.Unchecked
        dn_c.CheckState = CheckState.Unchecked
        B1_c.CheckState = CheckState.Unchecked
        B2_c.CheckState = CheckState.Unchecked
        B3_c.CheckState = CheckState.Unchecked
        B4_c.CheckState = CheckState.Unchecked
        B5_c.CheckState = CheckState.Unchecked
        B6_c.CheckState = CheckState.Unchecked
        USB.CheckState = CheckState.Unchecked
        AUX.CheckState = CheckState.Unchecked
        UpdateBottonDataBuf()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Form_Main.set_queue(2, 0, {})
    End Sub
End Class