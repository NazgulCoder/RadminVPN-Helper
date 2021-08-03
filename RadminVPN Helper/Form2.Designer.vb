<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.HexTheme1 = New RadminVPN_Helper.HexTheme()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.radminuninstaller = New RadminVPN_Helper.HexButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cleanerbutton = New RadminVPN_Helper.HexButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.disablewindefender = New RadminVPN_Helper.HexButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.error1603microsoft = New RadminVPN_Helper.HexButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.resetinternetsettings = New RadminVPN_Helper.HexButton()
        Me.ipv6fix = New RadminVPN_Helper.HexButton()
        Me.ethernetdns = New RadminVPN_Helper.HexButton()
        Me.setwifidns = New RadminVPN_Helper.HexButton()
        Me.HexClose1 = New RadminVPN_Helper.HexClose()
        Me.HexTheme1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HexTheme1
        '
        Me.HexTheme1.Controls.Add(Me.Label8)
        Me.HexTheme1.Controls.Add(Me.radminuninstaller)
        Me.HexTheme1.Controls.Add(Me.Label7)
        Me.HexTheme1.Controls.Add(Me.cleanerbutton)
        Me.HexTheme1.Controls.Add(Me.Label6)
        Me.HexTheme1.Controls.Add(Me.disablewindefender)
        Me.HexTheme1.Controls.Add(Me.Label5)
        Me.HexTheme1.Controls.Add(Me.error1603microsoft)
        Me.HexTheme1.Controls.Add(Me.PictureBox2)
        Me.HexTheme1.Controls.Add(Me.Label4)
        Me.HexTheme1.Controls.Add(Me.Label3)
        Me.HexTheme1.Controls.Add(Me.Label2)
        Me.HexTheme1.Controls.Add(Me.Label1)
        Me.HexTheme1.Controls.Add(Me.resetinternetsettings)
        Me.HexTheme1.Controls.Add(Me.ipv6fix)
        Me.HexTheme1.Controls.Add(Me.ethernetdns)
        Me.HexTheme1.Controls.Add(Me.setwifidns)
        Me.HexTheme1.Controls.Add(Me.HexClose1)
        Me.HexTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HexTheme1.Location = New System.Drawing.Point(0, 0)
        Me.HexTheme1.Name = "HexTheme1"
        Me.HexTheme1.Size = New System.Drawing.Size(473, 346)
        Me.HexTheme1.TabIndex = 0
        Me.HexTheme1.Text = "RadminVPN Helper - Tools"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(95, 315)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(253, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Uninstall RadminVPN, Viewer and Server"
        '
        'radminuninstaller
        '
        Me.radminuninstaller.Location = New System.Drawing.Point(3, 308)
        Me.radminuninstaller.Name = "radminuninstaller"
        Me.radminuninstaller.Size = New System.Drawing.Size(86, 30)
        Me.radminuninstaller.TabIndex = 29
        Me.radminuninstaller.Text = "Uninstall RadminVPN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(95, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(368, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Junk files cleaner to remove files that may block RadminVPN"
        '
        'cleanerbutton
        '
        Me.cleanerbutton.Location = New System.Drawing.Point(3, 272)
        Me.cleanerbutton.Name = "cleanerbutton"
        Me.cleanerbutton.Size = New System.Drawing.Size(86, 30)
        Me.cleanerbutton.TabIndex = 27
        Me.cleanerbutton.Text = "Cleaner"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(95, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(357, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Opens the direct window to fully disable Windows Defender"
        '
        'disablewindefender
        '
        Me.disablewindefender.Location = New System.Drawing.Point(3, 236)
        Me.disablewindefender.Name = "disablewindefender"
        Me.disablewindefender.Size = New System.Drawing.Size(86, 30)
        Me.disablewindefender.TabIndex = 25
        Me.disablewindefender.Text = "Disable WinDefender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(95, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(321, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Microsoft Utility to Fix un/installing errors with .msi files"
        '
        'error1603microsoft
        '
        Me.error1603microsoft.Location = New System.Drawing.Point(3, 200)
        Me.error1603microsoft.Name = "error1603microsoft"
        Me.error1603microsoft.Size = New System.Drawing.Size(86, 30)
        Me.error1603microsoft.TabIndex = 23
        Me.error1603microsoft.Text = "Error 1603 Fixer"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 179)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(467, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(95, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Full Internet Settings reset"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(95, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Fix the Teredo Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(95, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Set Ethernet0 Google DNS and purge cache"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(95, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Set Wi-Fi Google DNS and purge cache"
        '
        'resetinternetsettings
        '
        Me.resetinternetsettings.Location = New System.Drawing.Point(3, 143)
        Me.resetinternetsettings.Name = "resetinternetsettings"
        Me.resetinternetsettings.Size = New System.Drawing.Size(86, 30)
        Me.resetinternetsettings.TabIndex = 17
        Me.resetinternetsettings.Text = "Reset Internet Settings"
        '
        'ipv6fix
        '
        Me.ipv6fix.Location = New System.Drawing.Point(3, 107)
        Me.ipv6fix.Name = "ipv6fix"
        Me.ipv6fix.Size = New System.Drawing.Size(86, 30)
        Me.ipv6fix.TabIndex = 16
        Me.ipv6fix.Text = "Fix IPv6 DNS"
        '
        'ethernetdns
        '
        Me.ethernetdns.Location = New System.Drawing.Point(3, 71)
        Me.ethernetdns.Name = "ethernetdns"
        Me.ethernetdns.Size = New System.Drawing.Size(86, 30)
        Me.ethernetdns.TabIndex = 12
        Me.ethernetdns.Text = "Ethernet0 DNS"
        '
        'setwifidns
        '
        Me.setwifidns.Location = New System.Drawing.Point(3, 35)
        Me.setwifidns.Name = "setwifidns"
        Me.setwifidns.Size = New System.Drawing.Size(86, 30)
        Me.setwifidns.TabIndex = 11
        Me.setwifidns.Text = "Wi-Fi DNS"
        '
        'HexClose1
        '
        Me.HexClose1.Location = New System.Drawing.Point(458, 3)
        Me.HexClose1.Name = "HexClose1"
        Me.HexClose1.Size = New System.Drawing.Size(12, 12)
        Me.HexClose1.TabIndex = 0
        Me.HexClose1.Text = "HexClose1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 346)
        Me.Controls.Add(Me.HexTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "RadminVPN Helper - Tools"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.HexTheme1.ResumeLayout(False)
        Me.HexTheme1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HexTheme1 As HexTheme
    Friend WithEvents HexClose1 As HexClose
    Friend WithEvents setwifidns As HexButton
    Friend WithEvents ethernetdns As HexButton
    Friend WithEvents ipv6fix As HexButton
    Friend WithEvents resetinternetsettings As HexButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents error1603microsoft As HexButton
    Friend WithEvents disablewindefender As HexButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cleanerbutton As HexButton
    Friend WithEvents Label8 As Label
    Friend WithEvents radminuninstaller As HexButton
End Class
