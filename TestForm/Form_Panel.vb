Public Class Form_Panel
    ' ------------------------------------------------------------------------------
    ' ---------------------------- [Data Setting Field] ---------------------------|
    ' ------------------------------------------------------------------------------

    Dim BottonDataBuf(8) As Byte
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
    ' -------------------------------- [CMD Setting] ------------------------------|
    ' ------------------------------------------------------------------------------
    Private Sub Send_Button_Data()
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

    ' ------------------------------------------------------------------------------
    ' -------------------------------- [Button Field] -----------------------------|
    ' ------------------------------------------------------------------------------
    Protected Sub SRC_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SRC.Click
        ' Button Event
        TextBox1.Text = Int(TextBox1.Text) Xor 1
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub
    Protected Sub BND_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BND.Click
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

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        TextBox3.Text = Int(TextBox3.Text) Xor 1
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub
    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        ' Button Event
        TextBox3.Text = Int(TextBox3.Text) Xor 2
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub
    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        ' Button Event
        TextBox3.Text = Int(TextBox3.Text) Xor 4
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub
    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox4.Text = Int(TextBox4.Text) Xor 2
        UpdateBottonDataBuf()
        Send_Button_Data()
    End Sub
End Class