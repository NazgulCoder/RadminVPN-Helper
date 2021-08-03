Imports System.Text.RegularExpressions

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HexClose1_Click(sender As Object, e As EventArgs) Handles HexClose1.Click
        Me.Hide()
    End Sub

    Private Sub setwifidns_Click(sender As Object, e As EventArgs) Handles setwifidns.Click
        Shell("netsh dnsclient delete dnsserver ""Wi-Fi"" all")
        Shell("netsh interface ip set dns ""Wi-Fi"" static 8.8.8.8")
        Shell("netsh interface ip add dns name=""Wi-Fi"" 8.8.4.4 index=2")
        Shell("ipconfig /flushdns")
    End Sub

    Private Sub ethernetdns_Click(sender As Object, e As EventArgs) Handles ethernetdns.Click
        Shell("netsh dnsclient delete dnsserver ""Ethernet0"" all")
        Shell("netsh interface ip set dns ""Ethernet0"" static 8.8.8.8")
        Shell("netsh interface ip add dns name=""Ethernet0"" 8.8.4.4 index=2")
        Shell("ipconfig /flushdns")
    End Sub

    Private Sub ipv6fix_Click(sender As Object, e As EventArgs) Handles ipv6fix.Click
        Shell("netsh int ipv6 set teredo enterpriseclient")
        Shell("netsh interface teredo set state servername=win1910.ipv6.microsoft.com")
    End Sub

    Private Sub resetinternetsettings_Click(sender As Object, e As EventArgs) Handles resetinternetsettings.Click
        If My.Computer.FileSystem.FileExists("C:\reset-internet.bat") Then
            Process.Start("C:\reset-internet.bat")
        Else
            My.Computer.FileSystem.WriteAllText("C:\reset-internet.bat", My.Resources.reset_internet, False)
            Process.Start("C:\reset-internet.bat")
        End If
    End Sub

    Private Sub error1603microsoft_Click(sender As Object, e As EventArgs) Handles error1603microsoft.Click
        If My.Computer.FileSystem.FileExists("C:\Microsoft1603.diagcab") Then
            Process.Start("C:\Microsoft1603.diagcab")
        Else
            My.Computer.FileSystem.WriteAllBytes("C:\Microsoft1603.diagcab", My.Resources.Microsoft1603, False)
            Process.Start("C:\Microsoft1603.diagcab")
        End If
    End Sub

    Private Sub disablewindefender_Click(sender As Object, e As EventArgs) Handles disablewindefender.Click
        Process.Start("wscui.cpl")
    End Sub

    Private Sub cleanerbutton_Click(sender As Object, e As EventArgs) Handles cleanerbutton.Click
        If My.Computer.FileSystem.FileExists("C:\cleaner.bat") Then
            Process.Start("C:\cleaner.bat")
        Else
            My.Computer.FileSystem.WriteAllText("C:\cleaner.bat", My.Resources.cleaner, False)
            Process.Start("C:\cleaner.bat")
        End If
    End Sub

    Private Sub radminuninstaller_Click(sender As Object, e As EventArgs) Handles radminuninstaller.Click
        If My.Computer.FileSystem.FileExists("C:\wmicRadminHelper.txt") Then
            My.Computer.FileSystem.DeleteFile("C:\wmicRadminHelper.txt")
        End If

        If My.Computer.FileSystem.FileExists("C:\wmicRadminHelper.bat") Then
            Process.Start("C:\wmicRadminHelper.bat")
        Else
            My.Computer.FileSystem.WriteAllText("C:\wmicRadminHelper.bat", My.Resources.wmicRadminHelper, False)
            Process.Start("C:\wmicRadminHelper.bat")
        End If

        Dim psi As New ProcessStartInfo("C:\wmicRadminHelper.bat")
        psi.RedirectStandardError = True
        psi.RedirectStandardOutput = True
        psi.CreateNoWindow = False
        'psi.WindowStyle = ProcessWindowStyle.Hidden
        psi.UseShellExecute = False
        Dim proc As Process = Process.Start(psi)
        proc.WaitForExit()

        Dim strArr() As String
        Dim reader As String = My.Computer.FileSystem.ReadAllText("C:\wmicRadminHelper.txt")
        reader = Regex.Replace(reader, " {2,}", " ") 'removes all empty spaces except 1
        strArr = reader.Split(vbCrLf)

        Dim i As Integer = 0
        While i < strArr.Length
            If strArr(i).Contains("Radmin") Then
                'strArr(i) = Regex.Replace(strArr(i), "\r\n", String.Empty)
                'strArr(i).Replace(vbLf, "")
                ExecuteUninstaller(Trim(strArr(i)))
                'Shell("wmic product where name=""" & Trim(strArr(i)) & """ call uninstall")
                i += 1
            Else
                i += 1
            End If
        End While
    End Sub

    Private Sub ExecuteUninstaller(ByVal file2uninstall As String)
        file2uninstall = Regex.Replace(file2uninstall, "\r\n", String.Empty)
        file2uninstall = file2uninstall.Replace(vbLf, "")
        My.Computer.FileSystem.WriteAllText("C:\" & file2uninstall & ".bat", "@echo off" & vbCrLf & "wmic product where name=""" & file2uninstall & """ call uninstall" & vbCrLf & "pause" & vbCrLf & "exit", False)
        Dim psi As New ProcessStartInfo("C:\" & file2uninstall & ".bat")
        'psi.RedirectStandardError = True
        'psi.RedirectStandardOutput = True
        'psi.CreateNoWindow = False
        'psi.WindowStyle = ProcessWindowStyle.Hidden
        'psi.UseShellExecute = False
        Dim proc As Process = Process.Start(psi)
        proc.WaitForExit()
        My.Computer.FileSystem.DeleteFile("C:\" & file2uninstall & ".bat")
    End Sub
End Class