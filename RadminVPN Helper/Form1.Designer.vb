<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HexTheme1 = New RadminVPN_Helper.HexTheme()
        Me.disablewindefender = New RadminVPN_Helper.HexButton()
        Me.HexButton1 = New RadminVPN_Helper.HexButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ipv6fix = New RadminVPN_Helper.HexButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ethernetdns = New RadminVPN_Helper.HexButton()
        Me.wifidns = New RadminVPN_Helper.HexButton()
        Me.firewallon = New RadminVPN_Helper.HexButton()
        Me.firewalloff = New RadminVPN_Helper.HexButton()
        Me.killsvcbutton = New RadminVPN_Helper.HexButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radminservicelabel = New System.Windows.Forms.Label()
        Me.firewalllabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HexClose1 = New RadminVPN_Helper.HexClose()
        Me.cleanerbutton = New RadminVPN_Helper.HexButton()
        Me.HexTheme1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'HexTheme1
        '
        Me.HexTheme1.Controls.Add(Me.cleanerbutton)
        Me.HexTheme1.Controls.Add(Me.disablewindefender)
        Me.HexTheme1.Controls.Add(Me.HexButton1)
        Me.HexTheme1.Controls.Add(Me.PictureBox3)
        Me.HexTheme1.Controls.Add(Me.ipv6fix)
        Me.HexTheme1.Controls.Add(Me.PictureBox2)
        Me.HexTheme1.Controls.Add(Me.ethernetdns)
        Me.HexTheme1.Controls.Add(Me.wifidns)
        Me.HexTheme1.Controls.Add(Me.firewallon)
        Me.HexTheme1.Controls.Add(Me.firewalloff)
        Me.HexTheme1.Controls.Add(Me.killsvcbutton)
        Me.HexTheme1.Controls.Add(Me.Label4)
        Me.HexTheme1.Controls.Add(Me.radminservicelabel)
        Me.HexTheme1.Controls.Add(Me.firewalllabel)
        Me.HexTheme1.Controls.Add(Me.PictureBox1)
        Me.HexTheme1.Controls.Add(Me.HexClose1)
        Me.HexTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HexTheme1.Location = New System.Drawing.Point(0, 0)
        Me.HexTheme1.Name = "HexTheme1"
        Me.HexTheme1.Size = New System.Drawing.Size(317, 212)
        Me.HexTheme1.TabIndex = 0
        Me.HexTheme1.Text = "RadminVPN Helper"
        '
        'disablewindefender
        '
        Me.disablewindefender.Location = New System.Drawing.Point(110, 168)
        Me.disablewindefender.Name = "disablewindefender"
        Me.disablewindefender.Size = New System.Drawing.Size(122, 30)
        Me.disablewindefender.TabIndex = 18
        Me.disablewindefender.Text = "Disable WinDefender"
        '
        'HexButton1
        '
        Me.HexButton1.Location = New System.Drawing.Point(3, 168)
        Me.HexButton1.Name = "HexButton1"
        Me.HexButton1.Size = New System.Drawing.Size(101, 30)
        Me.HexButton1.TabIndex = 17
        Me.HexButton1.Text = "Error 1603 Fixer"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-76, 147)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(468, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'ipv6fix
        '
        Me.ipv6fix.Location = New System.Drawing.Point(179, 111)
        Me.ipv6fix.Name = "ipv6fix"
        Me.ipv6fix.Size = New System.Drawing.Size(78, 30)
        Me.ipv6fix.TabIndex = 15
        Me.ipv6fix.Text = "Fix IPv6 DNS"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-76, 90)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(468, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'ethernetdns
        '
        Me.ethernetdns.Location = New System.Drawing.Point(87, 111)
        Me.ethernetdns.Name = "ethernetdns"
        Me.ethernetdns.Size = New System.Drawing.Size(86, 30)
        Me.ethernetdns.TabIndex = 11
        Me.ethernetdns.Text = "Ethernet0 DNS"
        '
        'wifidns
        '
        Me.wifidns.Location = New System.Drawing.Point(3, 111)
        Me.wifidns.Name = "wifidns"
        Me.wifidns.Size = New System.Drawing.Size(78, 30)
        Me.wifidns.TabIndex = 10
        Me.wifidns.Text = "Wi-Fi DNS"
        '
        'firewallon
        '
        Me.firewallon.Location = New System.Drawing.Point(62, 54)
        Me.firewallon.Name = "firewallon"
        Me.firewallon.Size = New System.Drawing.Size(42, 30)
        Me.firewallon.TabIndex = 9
        Me.firewallon.Text = "ON"
        '
        'firewalloff
        '
        Me.firewalloff.Location = New System.Drawing.Point(110, 54)
        Me.firewalloff.Name = "firewalloff"
        Me.firewalloff.Size = New System.Drawing.Size(42, 30)
        Me.firewalloff.TabIndex = 8
        Me.firewalloff.Text = "OFF"
        '
        'killsvcbutton
        '
        Me.killsvcbutton.Location = New System.Drawing.Point(184, 54)
        Me.killsvcbutton.Name = "killsvcbutton"
        Me.killsvcbutton.Size = New System.Drawing.Size(130, 30)
        Me.killsvcbutton.TabIndex = 6
        Me.killsvcbutton.Text = "Kill Service"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(159, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "|"
        '
        'radminservicelabel
        '
        Me.radminservicelabel.AutoSize = True
        Me.radminservicelabel.BackColor = System.Drawing.Color.Transparent
        Me.radminservicelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radminservicelabel.ForeColor = System.Drawing.Color.White
        Me.radminservicelabel.Location = New System.Drawing.Point(180, 31)
        Me.radminservicelabel.Name = "radminservicelabel"
        Me.radminservicelabel.Size = New System.Drawing.Size(134, 20)
        Me.radminservicelabel.TabIndex = 4
        Me.radminservicelabel.Text = "RvControlSvc.exe"
        '
        'firewalllabel
        '
        Me.firewalllabel.AutoSize = True
        Me.firewalllabel.BackColor = System.Drawing.Color.Transparent
        Me.firewalllabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firewalllabel.ForeColor = System.Drawing.Color.White
        Me.firewalllabel.Location = New System.Drawing.Point(56, 31)
        Me.firewalllabel.Name = "firewalllabel"
        Me.firewalllabel.Size = New System.Drawing.Size(96, 20)
        Me.firewalllabel.TabIndex = 3
        Me.firewalllabel.Text = "Firewall: N/A"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'HexClose1
        '
        Me.HexClose1.Location = New System.Drawing.Point(302, 3)
        Me.HexClose1.Name = "HexClose1"
        Me.HexClose1.Size = New System.Drawing.Size(12, 12)
        Me.HexClose1.TabIndex = 0
        Me.HexClose1.Text = "HexClose1"
        '
        'cleanerbutton
        '
        Me.cleanerbutton.Location = New System.Drawing.Point(238, 168)
        Me.cleanerbutton.Name = "cleanerbutton"
        Me.cleanerbutton.Size = New System.Drawing.Size(76, 30)
        Me.cleanerbutton.TabIndex = 19
        Me.cleanerbutton.Text = "Cleaner"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 212)
        Me.Controls.Add(Me.HexTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "RadminVPN Helper"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.HexTheme1.ResumeLayout(False)
        Me.HexTheme1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HexTheme1 As HexTheme
    Friend WithEvents HexClose1 As HexClose
    Friend WithEvents Label4 As Label
    Friend WithEvents radminservicelabel As Label
    Friend WithEvents firewalllabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents killsvcbutton As HexButton
    Friend WithEvents firewallon As HexButton
    Friend WithEvents firewalloff As HexButton
    Friend WithEvents wifidns As HexButton
    Friend WithEvents ethernetdns As HexButton
    Friend WithEvents ipv6fix As HexButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents HexButton1 As HexButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents disablewindefender As HexButton
    Friend WithEvents cleanerbutton As HexButton
End Class
