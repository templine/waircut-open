Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace wAirCut
	' Token: 0x0200003C RID: 60
	<DesignerGenerated()>
	Public Partial Class WaitSplashProcess
		Inherits Form

		' Token: 0x06000411 RID: 1041 RVA: 0x00018668 File Offset: 0x00016868
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

		' Token: 0x1700019A RID: 410
		' (get) Token: 0x06000413 RID: 1043 RVA: 0x0000497A File Offset: 0x00002B7A
		' (set) Token: 0x06000414 RID: 1044 RVA: 0x00018914 File Offset: 0x00016B14
		Friend Overridable Property btStop As Button
			<CompilerGenerated()>
			Get
				Return Me._btStop
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.method_0
				Dim btStop As Button = Me._btStop
				If btStop IsNot Nothing Then
					RemoveHandler btStop.Click, value2
				End If
				Me._btStop = value
				btStop = Me._btStop
				If btStop IsNot Nothing Then
					AddHandler btStop.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700019B RID: 411
		' (get) Token: 0x06000415 RID: 1045 RVA: 0x00004982 File Offset: 0x00002B82
		' (set) Token: 0x06000416 RID: 1046 RVA: 0x0000498A File Offset: 0x00002B8A
		Friend Overridable Property PictureBox1 As PictureBox

		' Token: 0x1700019C RID: 412
		' (get) Token: 0x06000417 RID: 1047 RVA: 0x00004993 File Offset: 0x00002B93
		' (set) Token: 0x06000418 RID: 1048 RVA: 0x0000499B File Offset: 0x00002B9B
		Friend Overridable Property ScrollLabel1 As GClass14

		' Token: 0x1700019D RID: 413
		' (get) Token: 0x06000419 RID: 1049 RVA: 0x000049A4 File Offset: 0x00002BA4
		' (set) Token: 0x0600041A RID: 1050 RVA: 0x000049AC File Offset: 0x00002BAC
		Private Overridable Property Control_0 As Control

		' Token: 0x0600041B RID: 1051 RVA: 0x00018958 File Offset: 0x00016B58
		Public Sub New(Optional control_1 As Control = Nothing, Optional string_0 As String = "Waiting for completion...")
			AddHandler MyBase.Load, AddressOf Me.WaitSplashProcess_Load
			AddHandler MyBase.Deactivate, AddressOf Me.WaitSplashProcess_Deactivate
			Me.Control_0 = Nothing
			Me.InitializeComponent()
			Me.Control_0 = control_1
			MyBase.Owner = control_1.FindForm()
			Me.ScrollLabel1.Text = string_0
			AddHandler MyBase.Owner.Move, AddressOf Me.method_3
			AddHandler MyBase.Owner.Resize, AddressOf Me.method_4
		End Sub

		' Token: 0x0600041C RID: 1052 RVA: 0x000034C9 File Offset: 0x000016C9
		Private Sub method_0(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x0600041D RID: 1053 RVA: 0x000189EC File Offset: 0x00016BEC
		Private Sub method_1()
			Dim rectangle As Rectangle
			If Me.Control_0 IsNot Nothing Then
				rectangle = Me.Control_0.RectangleToScreen(Me.Control_0.ClientRectangle)
			Else
				rectangle = Screen.FromPoint(MyBase.Location).WorkingArea
			End If
			Dim x As Integer = rectangle.Left + (rectangle.Width - MyBase.Width) / 2
			Dim y As Integer = rectangle.Top + (rectangle.Height - MyBase.Height) / 3
			MyBase.Location = New Point(x, y)
		End Sub

		' Token: 0x0600041E RID: 1054 RVA: 0x000049B5 File Offset: 0x00002BB5
		Private Sub WaitSplashProcess_Load(sender As Object, e As EventArgs)
			Me.method_1()
		End Sub

		' Token: 0x0600041F RID: 1055 RVA: 0x000049B5 File Offset: 0x00002BB5
		Private Sub method_2(sender As Object, e As EventArgs)
			Me.method_1()
		End Sub

		' Token: 0x06000420 RID: 1056 RVA: 0x000049BD File Offset: 0x00002BBD
		Private Sub WaitSplashProcess_Deactivate(sender As Object, e As EventArgs)
			MyBase.Show()
		End Sub

		' Token: 0x06000421 RID: 1057 RVA: 0x000049B5 File Offset: 0x00002BB5
		<CompilerGenerated()>
		Private Sub method_3(sender As Object, e As EventArgs)
			Me.method_1()
		End Sub

		' Token: 0x06000422 RID: 1058 RVA: 0x000049B5 File Offset: 0x00002BB5
		<CompilerGenerated()>
		Private Sub method_4(sender As Object, e As EventArgs)
			Me.method_1()
		End Sub

		' Token: 0x040001EA RID: 490
		Private icontainer_0 As IContainer

		' Token: 0x040001EE RID: 494
		<AccessedThroughProperty("parentFrm")>
		<CompilerGenerated()>
		Private control_0 As Control
	End Class
End Namespace
