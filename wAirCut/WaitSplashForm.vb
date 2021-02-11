Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace wAirCut
	' Token: 0x0200003B RID: 59
	<DesignerGenerated()>
	Public Partial Class WaitSplashForm
		Inherits Form

		' Token: 0x06000404 RID: 1028 RVA: 0x0001830C File Offset: 0x0001650C
		<DebuggerNonUserCode()>
		Protected Overridable Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.icontainer_0 IsNot Nothing Then
					Me.icontainer_0.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x17000196 RID: 406
		' (get) Token: 0x06000406 RID: 1030 RVA: 0x000048EF File Offset: 0x00002AEF
		' (set) Token: 0x06000407 RID: 1031 RVA: 0x000048F7 File Offset: 0x00002AF7
		Friend Overridable Property Panel1 As Panel

		' Token: 0x17000197 RID: 407
		' (get) Token: 0x06000408 RID: 1032 RVA: 0x00004900 File Offset: 0x00002B00
		' (set) Token: 0x06000409 RID: 1033 RVA: 0x00004908 File Offset: 0x00002B08
		Friend Overridable Property ProgressBar As ProgressBar

		' Token: 0x17000198 RID: 408
		' (get) Token: 0x0600040A RID: 1034 RVA: 0x00004911 File Offset: 0x00002B11
		' (set) Token: 0x0600040B RID: 1035 RVA: 0x00004919 File Offset: 0x00002B19
		Friend Overridable Property lbMessage As Label

		' Token: 0x0600040C RID: 1036 RVA: 0x0001858C File Offset: 0x0001678C
		Public Sub New(string_1 As String, int_2 As Integer, Optional form_1 As Form = Nothing)
			AddHandler MyBase.Load, AddressOf Me.WaitSplashForm_Load
			Me.string_0 = ""
			Me.int_0 = 100
			Me.form_0 = Nothing
			Me.InitializeComponent()
			Me.string_0 = string_1
			Me.int_0 = int_2
			Me.form_0 = form_1
		End Sub

		' Token: 0x17000199 RID: 409
		' (get) Token: 0x0600040D RID: 1037 RVA: 0x00004922 File Offset: 0x00002B22
		' (set) Token: 0x0600040E RID: 1038 RVA: 0x0000492A File Offset: 0x00002B2A
		Public Property Int32_0 As Integer
			Get
				Return Me.int_1
			End Get
			Set(value As Integer)
				Me.int_1 = value
				Me.ProgressBar.Value = CInt(Math.Round(CDbl((Me.int_1 * 100)) / CDbl(Me.int_0)))
				Me.ProgressBar.Update()
			End Set
		End Property

		' Token: 0x0600040F RID: 1039 RVA: 0x00004961 File Offset: 0x00002B61
		Private Sub WaitSplashForm_Load(sender As Object, e As EventArgs)
			Me.lbMessage.Text = Me.string_0
			Me.method_0()
		End Sub

		' Token: 0x06000410 RID: 1040 RVA: 0x000185E8 File Offset: 0x000167E8
		Private Sub method_0()
			Dim rectangle As Rectangle
			If Me.form_0 IsNot Nothing Then
				rectangle = Me.form_0.RectangleToScreen(Me.form_0.ClientRectangle)
			Else
				rectangle = Screen.FromPoint(MyBase.Location).WorkingArea
			End If
			Dim x As Integer = rectangle.Left + (rectangle.Width - MyBase.Width) / 2
			Dim y As Integer = rectangle.Top + (rectangle.Height - MyBase.Height) / 3
			MyBase.Location = New Point(x, y)
		End Sub

		' Token: 0x040001E2 RID: 482
		Private icontainer_0 As IContainer

		' Token: 0x040001E6 RID: 486
		Private string_0 As String

		' Token: 0x040001E7 RID: 487
		Private int_0 As Integer

		' Token: 0x040001E8 RID: 488
		Private form_0 As Form

		' Token: 0x040001E9 RID: 489
		Private int_1 As Integer
	End Class
End Namespace
