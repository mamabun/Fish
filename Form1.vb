Imports System.Diagnostics
Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim proc = Process.GetProcessesByName("Fish")
        For i As Integer = 0 To proc.Count - 1
            proc(i).CloseMainWindow()
        Next i

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myProcess = New Process()
        myProcess.StartInfo.UseShellExecute = True
        myProcess.StartInfo.FileName = "https://www.youtube.com/watch?v=sdYjJsr6FS8"
        myProcess.Start()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("Fish.exe")
    End Sub
End Class
