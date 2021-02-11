Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports Microsoft.VisualBasic

' Token: 0x0200002E RID: 46
Friend Class Class12
	Inherits ProgressBar

	' Token: 0x0600034C RID: 844 RVA: 0x000043AB File Offset: 0x000025AB
	Public Sub New()
		MyBase.SetStyle(ControlStyles.UserPaint, True)
		MyBase.Style = ProgressBarStyle.Continuous
	End Sub

	' Token: 0x0600034D RID: 845 RVA: 0x00003A31 File Offset: 0x00001C31
	Protected Overridable Sub OnPaintBackground(pevent As PaintEventArgs)
	End Sub

	' Token: 0x0600034E RID: 846 RVA: 0x00013CEC File Offset: 0x00011EEC
	Protected Overridable Sub OnPaint(e As PaintEventArgs)
		Using image As Image = New Bitmap(MyBase.Width, MyBase.Height)
			Using graphics As Graphics = Graphics.FromImage(image)
				Dim rectangle As Rectangle = New Rectangle(0, 0, MyBase.Width, MyBase.Height)
				If ProgressBarRenderer.IsSupported Then
					ProgressBarRenderer.DrawHorizontalBar(graphics, rectangle)
				End If
				rectangle.Inflate(New Size(-2, -2))
				rectangle.Width = CInt(Math.Round(CDbl(rectangle.Width) * (CDbl(MyBase.Value) / CDbl(MyBase.Maximum))))
				If rectangle.Width = 0 Then
					rectangle.Width = 1
				End If
				Dim brush As LinearGradientBrush = New LinearGradientBrush(rectangle, Me.BackColor, Me.color_0, LinearGradientMode.Vertical)
				graphics.FillRectangle(brush, 2, 2, rectangle.Width, rectangle.Height)
				e.Graphics.DrawImage(image, 0, 0)
				image.Dispose()
			End Using
		End Using
	End Sub

	' Token: 0x17000165 RID: 357
	' (get) Token: 0x0600034F RID: 847 RVA: 0x00013DEC File Offset: 0x00011FEC
	Protected Overridable ReadOnly Property CreateParams As CreateParams
		Get
			Dim createParams As CreateParams = MyBase.CreateParams
			If Environment.OSVersion.Platform = PlatformID.Win32NT Then
				If Environment.OSVersion.Version.Major >= 6 Then
					createParams.ExStyle = createParams.ExStyle Or 33554432
				End If
			End If
			Return createParams
		End Get
	End Property

	' Token: 0x06000350 RID: 848 RVA: 0x00013E34 File Offset: 0x00012034
	Protected Overridable Sub WndProc(ByRef m As Message)
		MyBase.WndProc(m)
		If m.Msg = 15 Then
			' The following expression was wrapped in a checked-expression
			Dim text As String = Strings.FormatNumber(CDbl((MyBase.Value * 100)) / CDbl(MyBase.Maximum), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault) + "%"
			Using graphics As Graphics = MyBase.CreateGraphics()
				Using solidBrush As SolidBrush = New SolidBrush(Me.ForeColor)
					Dim sizeF As SizeF = graphics.MeasureString(text, Me.System.Windows.Forms.ProgressBar.Font)
					graphics.DrawString(text, Me.System.Windows.Forms.ProgressBar.Font, solidBrush, (CSng(MyBase.Width) - sizeF.Width) / 2F, (CSng(MyBase.Height) - sizeF.Height) / 2F)
				End Using
			End Using
		End If
	End Sub

	' Token: 0x17000166 RID: 358
	' (get) Token: 0x06000351 RID: 849 RVA: 0x000043C2 File Offset: 0x000025C2
	' (set) Token: 0x06000352 RID: 850 RVA: 0x000043CA File Offset: 0x000025CA
	<Browsable(True)>
	<EditorBrowsable(EditorBrowsableState.Always)>
	Public Overridable Property Text As String
		Get
			Return MyBase.Text
		End Get
		Set(value As String)
			MyBase.Text = value
			Me.Refresh()
		End Set
	End Property

	' Token: 0x17000167 RID: 359
	' (get) Token: 0x06000353 RID: 851 RVA: 0x000043D9 File Offset: 0x000025D9
	' (set) Token: 0x06000354 RID: 852 RVA: 0x000043E1 File Offset: 0x000025E1
	<Browsable(True)>
	<EditorBrowsable(EditorBrowsableState.Always)>
	Public Overridable Property Font As Font
		Get
			Return MyBase.Font
		End Get
		Set(value As Font)
			MyBase.Font = value
			Me.Refresh()
		End Set
	End Property

	' Token: 0x17000168 RID: 360
	' (get) Token: 0x06000355 RID: 853 RVA: 0x000043F0 File Offset: 0x000025F0
	' (set) Token: 0x06000356 RID: 854 RVA: 0x000043F8 File Offset: 0x000025F8
	<Browsable(True)>
	<Category("Appearance")>
	<EditorBrowsable(EditorBrowsableState.Always)>
	Public Property Color_0 As Color
		Get
			Return Me.color_0
		End Get
		Set(value As Color)
			Me.color_0 = value
			Me.Refresh()
		End Set
	End Property

	' Token: 0x04000172 RID: 370
	Private color_0 As Color
End Class
