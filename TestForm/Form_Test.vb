Imports System.Text

Public Class Form_Test

    Private Structure Script
        Dim row As String
        Dim cmd As Integer
        Dim setting As String
        Dim expect As String
        Dim delay As Integer 'ms
        Dim description As String
        Dim script_step As Byte
    End Structure

    Private Structure Result
        Dim row As String
        Dim cmd As Integer
        Dim expect As String
        Dim real_value As String
        Dim delay As Integer
        Dim result As String
        Dim description As String
        Dim Result_step As Byte
    End Structure

    Dim scr As Script
    Dim res As Result

    Private Sub script_init()
        scr.row = 0
        scr.cmd = 0
        scr.setting = 0
        scr.expect = 0
        scr.delay = 0
        scr.description = ""
        scr.script_step = 0
    End Sub

    Private Sub result_init()
        res.row = 0
        res.cmd = 0
        res.expect = 0
        res.real_value = 0
        res.delay = 0
        res.description = ""
        res.Result_step = 0
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 設置DataGridView的屬性
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        ' 添加測試資料
        Dim dt As New DataTable()
        'dt.Columns.Add("Column1")
        'dt.Columns.Add("Column2")
        'dt.Columns.Add("Column3")
        DataGridView1.DataSource = dt

        script_init()
        result_init()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.InitialDirectory = "D:\Script"
        openFileDialog.Filter = "CSV files (*.csv)|*.csv"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            Dim dt As New DataTable()
            TextBox1.Text = filePath

            Try
                Using sr As New StreamReader(filePath, Encoding.Default)

                    'Read header
                    Dim headers As String() = sr.ReadLine().Split(","c)
                    For Each header As String In headers
                        dt.Columns.Add(header)
                    Next

                    'Read Data
                    While Not sr.EndOfStream
                        Dim rows As String() = sr.ReadLine().Split(","c)

                        ' Set cmd
                        For Each r As String In rows
                            Script_Data_Update(r)
                            Debug.WriteLine(scr.script_step)
                        Next

                        ' Cmd Process
                        If scr.script_step = 6 Then
                            scr.script_step = 0
                            script_cmd_process()
                        End If

                        ' Next row
                        If rows.Length = dt.Columns.Count Then
                            dt.Rows.Add(rows)
                        End If

                    End While
                End Using
                DataGridView1.DataSource = dt

            Catch ex As IOException
                MessageBox.Show("IO Exception!")

            Catch ex As Exception
                MessageBox.Show("Exception!")
            End Try
        End If
    End Sub

    Private Sub Script_Data_Update(ByRef str As String)
        Select Case scr.script_step
            Case 0
                scr.row = Convert.ToInt32(str)
                scr.script_step += 1
            Case 1
                scr.cmd = Convert.ToInt32(str)
                scr.script_step += 1
            Case 2
                scr.setting = str
                scr.script_step += 1
            Case 3
                scr.expect = str
                scr.script_step += 1
            Case 4
                If str IsNot "" Then
                    scr.delay = Convert.ToInt32(str)
                Else
                    scr.delay = 0
                End If
                scr.script_step += 1
            Case 5
                scr.description = str
                scr.script_step += 1
            Case Else
                ' do nothing
        End Select
    End Sub

    Private Sub script_cmd_process()
        Select Case scr.cmd
            Case 0
                ' cmd 0
                Form_Main.Get_Arduino_Version()
                Debug.WriteLine("cmd 0!")
            Case 1
                ' cmd 1
                Debug.WriteLine("cmd 1!")
            Case 2
                ' cmd 2
                Debug.WriteLine("cmd 2!")
            Case 3
                ' cmd 3
                Debug.WriteLine("cmd 3!")
        End Select
    End Sub

End Class