Imports System.Management

Public Class Form1
    Dim firewallenabled As String
    Dim RadminService() As System.Diagnostics.Process

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HexClose1_Click(sender As Object, e As EventArgs) Handles HexClose1.Click
        If My.Computer.FileSystem.FileExists("C:\Microsoft1603.diagcab") Then
            My.Computer.FileSystem.DeleteFile("C:\Microsoft1603.diagcab")
        End If
        If My.Computer.FileSystem.FileExists("C:\cleaner.bat") Then
            My.Computer.FileSystem.DeleteFile("C:\cleaner.bat")
        End If
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        firewallenabled = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile", "EnableFirewall", "")
        If firewallenabled = 1 Then
            firewalllabel.ForeColor = Color.Green
            firewalllabel.Text = "Firewall: ON"
        Else
            firewalllabel.ForeColor = Color.Red
            firewalllabel.Text = "Firewall: OFF"
        End If

        RadminService = System.Diagnostics.Process.GetProcessesByName("RvControlSvc")
        If RadminService.Length > 0 Then
            radminservicelabel.ForeColor = Color.Green
            killsvcbutton.Enabled = True
        Else
            radminservicelabel.ForeColor = Color.Red
            killsvcbutton.Enabled = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As DialogResult = MsgBox("Would you like to open Radmin official website?", MsgBoxStyle.YesNo, "RadminVPN Website")
        If result = DialogResult.Yes Then
            Process.Start("www.radmin-vpn.com")
        End If
    End Sub

    Private Sub HexButton1_Click(sender As Object, e As EventArgs) Handles killsvcbutton.Click
        If radminservicelabel.ForeColor = Color.Green Then
            Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("RvControlSvc")
            For Each p As Process In pProcess
                p.Kill()
            Next
        Else
            MsgBox("Looks like RadminControlService is Off")
        End If
    End Sub

    Private Sub firewallon_Click(sender As Object, e As EventArgs) Handles firewallon.Click
        Dim firewall As New Process()
        firewall.StartInfo.FileName = "cmd.exe"
        firewall.StartInfo.WorkingDirectory = "\windows\system32"
        firewall.StartInfo.Arguments = "/c netsh firewall set opmode mode=enable"
        firewall.Start()
    End Sub

    Private Sub firewalloff_Click(sender As Object, e As EventArgs) Handles firewalloff.Click
        Dim firewall As New Process()
        firewall.StartInfo.FileName = "cmd.exe"
        firewall.StartInfo.WorkingDirectory = "\windows\system32"
        firewall.StartInfo.Arguments = "/c netsh firewall set opmode mode=disable"
        firewall.Start()
    End Sub

    Private Sub HexButton1_Click_1(sender As Object, e As EventArgs) Handles wifidns.Click
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

    Private Sub HexButton1_Click_2(sender As Object, e As EventArgs) Handles HexButton1.Click
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
End Class
