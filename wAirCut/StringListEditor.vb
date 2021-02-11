Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace wAirCut
	' Token: 0x02000038 RID: 56
	<DesignerGenerated()>
	Public Partial Class StringListEditor
		Inherits Form

		' Token: 0x060003C8 RID: 968 RVA: 0x000046BA File Offset: 0x000028BA
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x060003C9 RID: 969 RVA: 0x00017130 File Offset: 0x00015330
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

		' Token: 0x17000187 RID: 391
		' (get) Token: 0x060003CB RID: 971 RVA: 0x000046C8 File Offset: 0x000028C8
		' (set) Token: 0x060003CC RID: 972 RVA: 0x000046D0 File Offset: 0x000028D0
		Friend Overridable Property TextBox1 As TextBox

		' Token: 0x17000188 RID: 392
		' (get) Token: 0x060003CD RID: 973 RVA: 0x000046D9 File Offset: 0x000028D9
		' (set) Token: 0x060003CE RID: 974 RVA: 0x000046E1 File Offset: 0x000028E1
		Friend Overridable Property ToolStrip1 As ToolStrip

		' Token: 0x17000189 RID: 393
		' (get) Token: 0x060003CF RID: 975 RVA: 0x000046EA File Offset: 0x000028EA
		' (set) Token: 0x060003D0 RID: 976 RVA: 0x00017344 File Offset: 0x00015544
		Friend Overridable Property tsbAcept As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._tsbAcept
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_1
				Dim tsbAcept As ToolStripButton = Me._tsbAcept
				If tsbAcept IsNot Nothing Then
					RemoveHandler tsbAcept.Click, value2
				End If
				Me._tsbAcept = value
				tsbAcept = Me._tsbAcept
				If tsbAcept IsNot Nothing Then
					AddHandler tsbAcept.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700018A RID: 394
		' (get) Token: 0x060003D1 RID: 977 RVA: 0x000046F2 File Offset: 0x000028F2
		' (set) Token: 0x060003D2 RID: 978 RVA: 0x00017388 File Offset: 0x00015588
		Friend Overridable Property tsbCancel As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._tsbCancel
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_0
				Dim tsbCancel As ToolStripButton = Me._tsbCancel
				If tsbCancel IsNot Nothing Then
					RemoveHandler tsbCancel.Click, value2
				End If
				Me._tsbCancel = value
				tsbCancel = Me._tsbCancel
				If tsbCancel IsNot Nothing Then
					AddHandler tsbCancel.Click, value2
				End If
			End Set
		End Property

		' Token: 0x060003D3 RID: 979 RVA: 0x000046FA File Offset: 0x000028FA
		Private Sub method_0(sender As Object, e As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
			MyBase.Close()
		End Sub

		' Token: 0x060003D4 RID: 980 RVA: 0x00004709 File Offset: 0x00002909
		Private Sub method_1(sender As Object, e As EventArgs)
			MyBase.DialogResult = DialogResult.OK
			MyBase.Close()
		End Sub

		' Token: 0x060003D5 RID: 981 RVA: 0x00004718 File Offset: 0x00002918
		Public Sub method_2(string_0 As String)
			Me.TextBox1.Lines = string_0.Split(New Char() { ";"c })
			Me.TextBox1.[Select](Me.TextBox1.TextLength, 0)
		End Sub

		' Token: 0x060003D6 RID: 982 RVA: 0x000173CC File Offset: 0x000155CC
		Public Function method_3() As String
			Dim text As String = ""
			For Each text2 As String In Me.TextBox1.Lines
				text2.Replace(" ", "")
				If text2.Length > 0 Then
					text = text + text2 + ";"
				End If
			Next
			If text.Length > 0 Then
				' The following expression was wrapped in a checked-expression
				text = text.Remove(text.Length - 1, 1)
			End If
			Return text
		End Function

		' Token: 0x040001C2 RID: 450
		Private icontainer_0 As IContainer
	End Class
End Namespace
