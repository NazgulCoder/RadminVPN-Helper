﻿Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Drawing.Text

Enum MouseState
    None = 0
    Over = 1
    Down = 2
End Enum

Class HexTheme
    Inherits ContainerControl

#Region " Declarations "
    Private _Down As Boolean = False
    Private _Header As Integer = 30
    Private _MousePoint As Point
#End Region

#Region " Mouse States "
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If e.Y < _Header AndAlso e.Button = Windows.Forms.MouseButtons.Left Then
            _Down = True
            _MousePoint = e.Location
        End If
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _Down = False
    End Sub
    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        If _Down = True Then
            ParentForm.Location = MousePosition - _MousePoint
        End If
    End Sub
#End Region

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        ParentForm.FormBorderStyle = FormBorderStyle.None
        ParentForm.TransparencyKey = Color.Fuchsia
        Dock = DockStyle.Fill
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(47, 51, 60))
        G.FillRectangle(New SolidBrush(Color.FromArgb(30, 33, 40)), New Rectangle(0, _Header, Width, Height - _Header))
        Dim _StringF As New StringFormat
        _StringF.Alignment = StringAlignment.Center
        _StringF.LineAlignment = StringAlignment.Center
        G.DrawString(Text, New Font("Segoe UI", 11), New SolidBrush(Color.FromArgb(236, 95, 75)), New RectangleF(0, 0, Width, _Header), _StringF)
    End Sub

End Class

Class HexButton
    Inherits Control

#Region " Declarations "
    Private _State As MouseState
#End Region

#Region " Mouse States "
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        _State = MouseState.Down
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        _State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        _State = MouseState.None
        Invalidate()
    End Sub
#End Region

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
               ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        Size = New Size(90, 30)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(30, 33, 40))
        G.DrawPath(New Pen(Color.FromArgb(236, 95, 75)), RoundRec(New Rectangle(0, 0, Width - 1, Height - 1), 4))
        G.FillPath(New SolidBrush(Color.FromArgb(236, 95, 75)), RoundRec(New Rectangle(0, 0, Width - 1, Height - 1), 4))

        Select Case _State
            Case MouseState.Over
                G.DrawPath(New Pen(Color.FromArgb(20, Color.White)), RoundRec(New Rectangle(0, 0, Width - 1, Height - 1), 4))
                G.FillPath(New SolidBrush(Color.FromArgb(20, Color.White)), RoundRec(New Rectangle(0, 0, Width - 1, Height - 1), 4))
            Case MouseState.Down
                G.DrawPath(New Pen(Color.FromArgb(25, Color.Black)), RoundRec(New Rectangle(0, 0, Width - 1, Height - 1), 4))
                G.FillPath(New SolidBrush(Color.FromArgb(25, Color.Black)), RoundRec(New Rectangle(0, 0, Width - 1, Height - 1), 4))
        End Select

        Dim _StringF As New StringFormat
        _StringF.Alignment = StringAlignment.Center
        _StringF.LineAlignment = StringAlignment.Center
        G.DrawString(Text, New Font("Segoe UI", 9), Brushes.White, New RectangleF(0, 0, Width - 1, Height - 1), _StringF)
    End Sub

End Class

Class HexGroupBox
    Inherits ContainerControl

    Sub New()
        Size = New Size(200, 100)
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(30, 33, 40))
        G.DrawPath(New Pen(Color.FromArgb(236, 95, 75)), RoundRec(New Rectangle(0, 0, Width - 1, Height - 1), 4))
        G.DrawString(Text, New Font("Segoe UI", 9), Brushes.White, New Point(5, 5))
    End Sub

End Class

<DefaultEvent("CheckedChanged")>
Class HexRadioButton
    Inherits Control

#Region " Variables"

    Private _State As MouseState = MouseState.None
    Private _Checked As Boolean

#End Region

#Region " Properties "
    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(value As Boolean)
            _Checked = value
            InvalidateControls()
            RaiseEvent CheckedChanged(Me)
            Invalidate()
        End Set
    End Property
    Event CheckedChanged(ByVal sender As Object)
    Protected Overrides Sub OnClick(e As EventArgs)
        If Not _Checked Then Checked = True
        MyBase.OnClick(e)
    End Sub
    Private Sub InvalidateControls()
        If Not IsHandleCreated OrElse Not _Checked Then Return
        For Each C As Control In Parent.Controls
            If C IsNot Me AndAlso TypeOf C Is HexRadioButton Then
                DirectCast(C, HexRadioButton).Checked = False
                Invalidate()
            End If
        Next
    End Sub
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        InvalidateControls()
    End Sub


    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 16
    End Sub

#Region " Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        _State = MouseState.Down
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        _State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        _State = MouseState.None
        Invalidate()
    End Sub

#End Region
#End Region

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.SmoothingMode = 2
        G.TextRenderingHint = 5
        G.Clear(Color.FromArgb(30, 33, 40))
        G.FillEllipse(New SolidBrush(Color.FromArgb(47, 51, 60)), New Rectangle(0, 0, 15, 15))
        If Checked Then
            G.FillEllipse(New SolidBrush(Color.FromArgb(236, 95, 75)), New Rectangle(4, 4, 7, 7))
        End If
        G.DrawString(Text, New Font("Segoe UI", 9), Brushes.White, New Point(18, -1))
    End Sub

End Class

<DefaultEvent("CheckedChanged")>
Class HexCheckBox
    Inherits Control

#Region " Variables "
    Private _State As MouseState = MouseState.None
    Private _Checked As Boolean
#End Region

#Region " Properties "
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub

    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal value As Boolean)
            _Checked = value
            Invalidate()
        End Set
    End Property

    Event CheckedChanged(ByVal sender As Object)
    Protected Overrides Sub OnClick(ByVal e As System.EventArgs)
        _Checked = Not _Checked
        RaiseEvent CheckedChanged(Me)
        MyBase.OnClick(e)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 16
    End Sub

#End Region

#Region " Mouse States "

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        _State = MouseState.Down
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        _State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        _State = MouseState.None
        Invalidate()
    End Sub

#End Region

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(30, 33, 40))

        G.FillRectangle(New SolidBrush(Color.FromArgb(47, 51, 60)), New Rectangle(0, 0, 15, 15))
        If Checked Then
            G.FillRectangle(New SolidBrush(Color.FromArgb(236, 95, 75)), New Rectangle(4, 4, 7, 7))
        End If
        G.DrawString(Text, New Font("Segoe UI", 9), Brushes.White, New Point(18, -1))
    End Sub
End Class

Class HexProgressBar
    Inherits Control

#Region " Variables "

    Private _Value As Integer = 0
    Private _Maximum As Integer = 100

#End Region

#Region " Control "
    <Category("Control")>
    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(V As Integer)
            Select Case V
                Case Is < _Value
                    _Value = V
            End Select
            _Maximum = V
            Invalidate()
        End Set
    End Property

    <Category("Control")>
    Public Property Value() As Integer
        Get
            Select Case _Value
                Case 0
                    Return 0
                    Invalidate()
                Case Else
                    Return _Value
                    Invalidate()
            End Select
        End Get
        Set(V As Integer)
            Select Case V
                Case Is > _Maximum
                    V = _Maximum
                    Invalidate()
            End Select
            _Value = V
            Invalidate()
        End Set
    End Property
#End Region

#Region "Events "
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 25
    End Sub

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Height = 25
    End Sub

    Public Sub Increment(ByVal Amount As Integer)
        Value += Amount
    End Sub
#End Region

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        G.SmoothingMode = SmoothingMode.HighQuality
        G.PixelOffsetMode = PixelOffsetMode.HighQuality
        G.Clear(Color.FromArgb(47, 51, 60))
        Dim ProgVal As Integer = CInt(_Value / _Maximum * Width)
        G.FillRectangle(New SolidBrush(Color.FromArgb(236, 95, 75)), New Rectangle(0, 0, ProgVal - 1, Height))
        G.InterpolationMode = CType(7, InterpolationMode)
    End Sub
End Class

<DefaultEvent("TextChanged")>
Class HexTextBox
    Inherits Control

#Region " Variables "

    Private _State As MouseState = MouseState.None
    Private WithEvents TB As Windows.Forms.TextBox

#End Region

#Region " Properties "

#Region " TextBox Properties "

    Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Left
    <Category("Options")>
    Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            _TextAlign = value
            If TB IsNot Nothing Then
                TB.TextAlign = value
            End If
        End Set
    End Property
    Private _MaxLength As Integer = 32767
    <Category("Options")>
    Property MaxLength() As Integer
        Get
            Return _MaxLength
        End Get
        Set(ByVal value As Integer)
            _MaxLength = value
            If TB IsNot Nothing Then
                TB.MaxLength = value
            End If
        End Set
    End Property
    Private _ReadOnly As Boolean
    <Category("Options")>
    Property [ReadOnly]() As Boolean
        Get
            Return _ReadOnly
        End Get
        Set(ByVal value As Boolean)
            _ReadOnly = value
            If TB IsNot Nothing Then
                TB.ReadOnly = value
            End If
        End Set
    End Property
    Private _UseSystemPasswordChar As Boolean
    <Category("Options")>
    Property UseSystemPasswordChar() As Boolean
        Get
            Return _UseSystemPasswordChar
        End Get
        Set(ByVal value As Boolean)
            _UseSystemPasswordChar = value
            If TB IsNot Nothing Then
                TB.UseSystemPasswordChar = value
            End If
        End Set
    End Property
    Private _Multiline As Boolean
    <Category("Options")>
    Property Multiline() As Boolean
        Get
            Return _Multiline
        End Get
        Set(ByVal value As Boolean)
            _Multiline = value
            If TB IsNot Nothing Then
                TB.Multiline = value

                If value Then
                    TB.Height = Height - 11
                Else
                    Height = TB.Height + 11
                End If

            End If
        End Set
    End Property
    <Category("Options")>
    Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            If TB IsNot Nothing Then
                TB.Text = value
            End If
        End Set
    End Property
    <Category("Options")>
    Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            If TB IsNot Nothing Then
                TB.Font = value
                TB.Location = New Point(3, 5)
                TB.Width = Width - 6

                If Not _Multiline Then
                    Height = TB.Height + 11
                End If
            End If
        End Set
    End Property

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Not Controls.Contains(TB) Then
            Controls.Add(TB)
        End If
    End Sub
    Private Sub OnBaseTextChanged(ByVal s As Object, ByVal e As EventArgs)
        Text = TB.Text
    End Sub
    Private Sub OnBaseKeyDown(ByVal s As Object, ByVal e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.A Then
            TB.SelectAll()
            e.SuppressKeyPress = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.C Then
            TB.Copy()
            e.SuppressKeyPress = True
        End If
    End Sub
    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        TB.Location = New Point(5, 5)
        TB.Width = Width - 10

        If _Multiline Then
            TB.Height = Height - 11
        Else
            Height = TB.Height + 11
        End If

        MyBase.OnResize(e)
    End Sub

#End Region

#Region " Mouse States "

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        _State = MouseState.Down
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _State = MouseState.Over
        TB.Focus()
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        _State = MouseState.Over
        TB.Focus()
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        _State = MouseState.None
        Invalidate()
    End Sub

#End Region

#End Region

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True

        BackColor = Color.Transparent

        TB = New Windows.Forms.TextBox
        TB.Font = New Font("Segoe UI", 9)
        TB.Text = Text
        TB.BackColor = Color.FromArgb(47, 51, 60)
        TB.ForeColor = Color.FromArgb(236, 95, 75)
        TB.MaxLength = _MaxLength
        TB.Multiline = _Multiline
        TB.ReadOnly = _ReadOnly
        TB.UseSystemPasswordChar = _UseSystemPasswordChar
        TB.BorderStyle = BorderStyle.None
        TB.Location = New Point(5, 5)
        TB.Width = Width - 10

        TB.Cursor = Cursors.IBeam

        If _Multiline Then
            TB.Height = Height - 11
        Else
            Height = TB.Height + 11
        End If

        AddHandler TB.TextChanged, AddressOf OnBaseTextChanged
        AddHandler TB.KeyDown, AddressOf OnBaseKeyDown
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(47, 51, 60))
    End Sub

End Class

Class HexClose
    Inherits Control

#Region " Declarations "
    Private _State As MouseState
#End Region

#Region " Mouse States "
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        _State = MouseState.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        _State = MouseState.None
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        _State = MouseState.Down
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _State = MouseState.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        Environment.Exit(0)
    End Sub
#End Region

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(12, 12)
    End Sub

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        Size = New Size(12, 12)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics

        G.Clear(Color.FromArgb(47, 51, 60))

        Dim _StringF As New StringFormat
        _StringF.Alignment = StringAlignment.Center
        _StringF.LineAlignment = StringAlignment.Center

        G.DrawString("r", New Font("Marlett", 11), Brushes.White, New RectangleF(0, 0, Width, Height), _StringF)

        Select Case _State
            Case MouseState.Down
                G.DrawString("r", New Font("Marlett", 11), New SolidBrush(Color.FromArgb(40, Color.Black)), New RectangleF(0, 0, Width, Height), _StringF)
        End Select

    End Sub

End Class

Class HexMini
    Inherits Control

#Region " Declarations "
    Private _State As MouseState
#End Region

#Region " Mouse States "
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        _State = MouseState.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        _State = MouseState.None
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        _State = MouseState.Down
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _State = MouseState.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        FindForm.WindowState = FormWindowState.Minimized
    End Sub
#End Region

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(12, 12)
    End Sub

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        Size = New Size(12, 12)
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics

        G.Clear(Color.FromArgb(47, 51, 60))

        Dim _StringF As New StringFormat
        _StringF.Alignment = StringAlignment.Center
        _StringF.LineAlignment = StringAlignment.Center
        G.DrawString("0", New Font("Marlett", 11), Brushes.White, New RectangleF(0, 0, Width, Height), _StringF)
        Select Case _State
            Case MouseState.Down
                G.DrawString("0", New Font("Marlett", 11), New SolidBrush(Color.FromArgb(40, Color.Black)), New RectangleF(0, 0, Width, Height), _StringF)
        End Select
    End Sub

End Class

Module Functions
    Public Function RoundRec(ByVal Rectangle As Rectangle, ByVal Curve As Integer) As GraphicsPath
        Dim P As GraphicsPath = New GraphicsPath()
        Dim ArcRectangleWidth As Integer = Curve * 2
        P.AddArc(New Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90)
        P.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90)
        P.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90)
        P.AddArc(New Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90)
        P.AddLine(New Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), New Point(Rectangle.X, Curve + Rectangle.Y))
        Return P
    End Function

End Module