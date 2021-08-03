Imports System.Management

Public Class Form1
    Dim firewallenabled As String
    Dim RadminService() As System.Diagnostics.Process

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deleteAuxFiles()
    End Sub

    Private Sub HexClose1_Click(sender As Object, e As EventArgs) Handles HexClose1.Click
        deleteAuxFiles()
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub deleteAuxFiles()
        If My.Computer.FileSystem.FileExists("C:\Microsoft1603.diagcab") Then
            My.Computer.FileSystem.DeleteFile("C:\Microsoft1603.diagcab")
        End If
        If My.Computer.FileSystem.FileExists("C:\cleaner.bat") Then
            My.Computer.FileSystem.DeleteFile("C:\cleaner.bat")
        End If
        If My.Computer.FileSystem.FileExists("C:\reset-internet.bat") Then
            My.Computer.FileSystem.DeleteFile("C:\reset-internet.bat")
        End If
        If My.Computer.FileSystem.FileExists("C:\wmicRadminHelper.txt") Then
            My.Computer.FileSystem.DeleteFile("C:\wmicRadminHelper.txt")
        End If
        If My.Computer.FileSystem.FileExists("C:\wmicRadminHelper.bat") Then
            My.Computer.FileSystem.DeleteFile("C:\wmicRadminHelper.bat")
        End If
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

    Private Sub killsvcbutton_Click(sender As Object, e As EventArgs) Handles killsvcbutton.Click
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

    Private Sub openform2_Click(sender As Object, e As EventArgs) Handles openform2.Click
        Form2.Show()
    End Sub
End Class
