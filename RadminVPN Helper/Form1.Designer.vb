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
        Me.openform2 = New RadminVPN_Helper.HexButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.firewallon = New RadminVPN_Helper.HexButton()
        Me.firewalloff = New RadminVPN_Helper.HexButton()
        Me.killsvcbutton = New RadminVPN_Helper.HexButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radminservicelabel = New System.Windows.Forms.Label()
        Me.firewalllabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HexClose1 = New RadminVPN_Helper.HexClose()
        Me.HexTheme1.SuspendLayout()
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
        Me.HexTheme1.Controls.Add(Me.openform2)
        Me.HexTheme1.Controls.Add(Me.PictureBox2)
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
        Me.HexTheme1.Size = New System.Drawing.Size(317, 149)
        Me.HexTheme1.TabIndex = 0
        Me.HexTheme1.Text = "RadminVPN Helper"
        '
        'openform2
        '
        Me.openform2.Location = New System.Drawing.Point(3, 111)
        Me.openform2.Name = "openform2"
        Me.openform2.Size = New System.Drawing.Size(170, 30)
        Me.openform2.TabIndex = 15
        Me.openform2.Text = "Open Troubleshooting Tools"
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
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 149)
        Me.Controls.Add(Me.HexTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "RadminVPN Helper"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.HexTheme1.ResumeLayout(False)
        Me.HexTheme1.PerformLayout()
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
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents openform2 As HexButton
End Class
