Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports wAirCut

' Token: 0x02000004 RID: 4
<GeneratedCode("MyTemplate", "11.0.0.0")>
<HideModuleName()>
Friend NotInheritable Module Class6
	' Token: 0x17000001 RID: 1
	' (get) Token: 0x06000007 RID: 7 RVA: 0x0000215D File Offset: 0x0000035D
	<HelpKeyword("My.Computer")>
	Friend ReadOnly Property Class5_0 As Class5
		<DebuggerHidden()>
		Get
			Return Class6.class9_0.Prop_0
		End Get
	End Property

	' Token: 0x17000002 RID: 2
	' (get) Token: 0x06000008 RID: 8 RVA: 0x00002169 File Offset: 0x00000369
	<HelpKeyword("My.Application")>
	Friend ReadOnly Property Form0_0 As Form0
		<DebuggerHidden()>
		Get
			Return Class6.class9_1.Prop_0
		End Get
	End Property

	' Token: 0x17000003 RID: 3
	' (get) Token: 0x06000009 RID: 9 RVA: 0x00002175 File Offset: 0x00000375
	<HelpKeyword("My.User")>
	Friend ReadOnly Property User_0 As User
		<DebuggerHidden()>
		Get
			Return Class6.class9_2.Prop_0
		End Get
	End Property

	' Token: 0x17000004 RID: 4
	' (get) Token: 0x0600000A RID: 10 RVA: 0x00002181 File Offset: 0x00000381
	<HelpKeyword("My.Forms")>
	Friend ReadOnly Property Class7_0 As Class6.Class7
		<DebuggerHidden()>
		Get
			Return Class6.class9_3.Prop_0
		End Get
	End Property

	' Token: 0x17000005 RID: 5
	' (get) Token: 0x0600000B RID: 11 RVA: 0x0000218D File Offset: 0x0000038D
	<HelpKeyword("My.WebServices")>
	Friend ReadOnly Property Class8_0 As Class6.Class8
		<DebuggerHidden()>
		Get
			Return Class6.class9_4.Prop_0
		End Get
	End Property

	' Token: 0x04000001 RID: 1
	Private class9_0 As Class6.Class9(Of Class5) = New Class6.Class9(Of Class5)()

	' Token: 0x04000002 RID: 2
	Private class9_1 As Class6.Class9(Of Form0) = New Class6.Class9(Of Form0)()

	' Token: 0x04000003 RID: 3
	Private class9_2 As Class6.Class9(Of User) = New Class6.Class9(Of User)()

	' Token: 0x04000004 RID: 4
	Private class9_3 As Class6.Class9(Of Class6.Class7) = New Class6.Class9(Of Class6.Class7)()

	' Token: 0x04000005 RID: 5
	Private class9_4 As Class6.Class9(Of Class6.Class8) = New Class6.Class9(Of Class6.Class8)()

	' Token: 0x02000005 RID: 5
	<EditorBrowsable(EditorBrowsableState.Never)>
	<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
	Friend NotInheritable Class Class7
		' Token: 0x0600000C RID: 12 RVA: 0x00004C10 File Offset: 0x00002E10
		<DebuggerHidden()>
		Private Shared Function smethod_0(Of T As{Form, New})(gparam_0 As T) As T
			Dim result As T
			If gparam_0 IsNot Nothing AndAlso Not gparam_0.IsDisposed Then
				result = gparam_0
			Else
				If Class6.Class7.hashtable_0 IsNot Nothing Then
					If Class6.Class7.hashtable_0.ContainsKey(GetType(T)) Then
						Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
					End If
				Else
					Class6.Class7.hashtable_0 = New Hashtable()
				End If
				Class6.Class7.hashtable_0.Add(GetType(T), Nothing)
				Try
					result = Activator.CreateInstance(Of T)()
				Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
					Throw New InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message }), ex.InnerException)
				Finally
					Class6.Class7.hashtable_0.Remove(GetType(T))
				End Try
			End If
			Return result
		End Function

		' Token: 0x0600000D RID: 13 RVA: 0x00002199 File Offset: 0x00000399
		<DebuggerHidden()>
		Private Sub method_0(Of T As Form)(ByRef gparam_0 As T)
			gparam_0.Dispose()
			gparam_0 = Nothing
		End Sub

		' Token: 0x0600000E RID: 14 RVA: 0x000021AE File Offset: 0x000003AE
		<EditorBrowsable(EditorBrowsableState.Never)>
		<DebuggerHidden()>
		Public Sub New()
		End Sub

		' Token: 0x0600000F RID: 15 RVA: 0x000021B6 File Offset: 0x000003B6
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Equals(obj As Object) As Boolean
			Return MyBase.Equals(RuntimeHelpers.GetObjectValue(obj))
		End Function

		' Token: 0x06000010 RID: 16 RVA: 0x000021C4 File Offset: 0x000003C4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetHashCode() As Integer
			Return MyBase.GetHashCode()
		End Function

		' Token: 0x06000011 RID: 17 RVA: 0x000021CC File Offset: 0x000003CC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend Function method_1() As Type
			Return GetType(Class6.Class7)
		End Function

		' Token: 0x06000012 RID: 18 RVA: 0x000021D8 File Offset: 0x000003D8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function ToString() As String
			Return MyBase.ToString()
		End Function

		' Token: 0x17000006 RID: 6
		' (get) Token: 0x06000013 RID: 19 RVA: 0x000021E0 File Offset: 0x000003E0
		' (set) Token: 0x06000019 RID: 25 RVA: 0x00002276 File Offset: 0x00000476
		Public Property AboutForm_0 As AboutForm
			Get
				Me.aboutForm_0 = Class6.Class7.smethod_0(Of AboutForm)(Me.aboutForm_0)
				Return Me.aboutForm_0
			End Get
			Set(value As AboutForm)
				If value IsNot Me.aboutForm_0 Then
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.method_0(Of AboutForm)(Me.aboutForm_0)
				End If
			End Set
		End Property

		' Token: 0x17000007 RID: 7
		' (get) Token: 0x06000014 RID: 20 RVA: 0x000021F9 File Offset: 0x000003F9
		' (set) Token: 0x0600001A RID: 26 RVA: 0x0000229B File Offset: 0x0000049B
		Public Property ApLogForm_0 As ApLogForm
			Get
				Me.apLogForm_0 = Class6.Class7.smethod_0(Of ApLogForm)(Me.apLogForm_0)
				Return Me.apLogForm_0
			End Get
			Set(value As ApLogForm)
				If value IsNot Me.apLogForm_0 Then
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.method_0(Of ApLogForm)(Me.apLogForm_0)
				End If
			End Set
		End Property

		' Token: 0x17000008 RID: 8
		' (get) Token: 0x06000015 RID: 21 RVA: 0x00002212 File Offset: 0x00000412
		' (set) Token: 0x0600001B RID: 27 RVA: 0x000022C2 File Offset: 0x000004C2
		Public Property MainForm_0 As MainForm
			Get
				Me.mainForm_0 = Class6.Class7.smethod_0(Of MainForm)(Me.mainForm_0)
				Return Me.mainForm_0
			End Get
			Set(value As MainForm)
				If value IsNot Me.mainForm_0 Then
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.method_0(Of MainForm)(Me.mainForm_0)
				End If
			End Set
		End Property

		' Token: 0x17000009 RID: 9
		' (get) Token: 0x06000016 RID: 22 RVA: 0x0000222B File Offset: 0x0000042B
		' (set) Token: 0x0600001C RID: 28 RVA: 0x000022E9 File Offset: 0x000004E9
		Public Property StringListEditor_0 As StringListEditor
			Get
				Me.stringListEditor_0 = Class6.Class7.smethod_0(Of StringListEditor)(Me.stringListEditor_0)
				Return Me.stringListEditor_0
			End Get
			Set(value As StringListEditor)
				If value IsNot Me.stringListEditor_0 Then
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.method_0(Of StringListEditor)(Me.stringListEditor_0)
				End If
			End Set
		End Property

		' Token: 0x1700000A RID: 10
		' (get) Token: 0x06000017 RID: 23 RVA: 0x00002244 File Offset: 0x00000444
		' (set) Token: 0x0600001D RID: 29 RVA: 0x0000230E File Offset: 0x0000050E
		Public Property UpdateForm_0 As UpdateForm
			Get
				Me.updateForm_0 = Class6.Class7.smethod_0(Of UpdateForm)(Me.updateForm_0)
				Return Me.updateForm_0
			End Get
			Set(value As UpdateForm)
				If value IsNot Me.updateForm_0 Then
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.method_0(Of UpdateForm)(Me.updateForm_0)
				End If
			End Set
		End Property

		' Token: 0x1700000B RID: 11
		' (get) Token: 0x06000018 RID: 24 RVA: 0x0000225D File Offset: 0x0000045D
		' (set) Token: 0x0600001E RID: 30 RVA: 0x00002333 File Offset: 0x00000533
		Public Property WpsPinForm_0 As WpsPinForm
			Get
				Me.wpsPinForm_0 = Class6.Class7.smethod_0(Of WpsPinForm)(Me.wpsPinForm_0)
				Return Me.wpsPinForm_0
			End Get
			Set(value As WpsPinForm)
				If value IsNot Me.wpsPinForm_0 Then
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.method_0(Of WpsPinForm)(Me.wpsPinForm_0)
				End If
			End Set
		End Property

		' Token: 0x04000006 RID: 6
		<ThreadStatic()>
		Private Shared hashtable_0 As Hashtable

		' Token: 0x04000007 RID: 7
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public aboutForm_0 As AboutForm

		' Token: 0x04000008 RID: 8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public apLogForm_0 As ApLogForm

		' Token: 0x04000009 RID: 9
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public mainForm_0 As MainForm

		' Token: 0x0400000A RID: 10
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public stringListEditor_0 As StringListEditor

		' Token: 0x0400000B RID: 11
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public updateForm_0 As UpdateForm

		' Token: 0x0400000C RID: 12
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public wpsPinForm_0 As WpsPinForm
	End Class

	' Token: 0x02000006 RID: 6
	<EditorBrowsable(EditorBrowsableState.Never)>
	<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
	Friend NotInheritable Class Class8
		' Token: 0x0600001F RID: 31 RVA: 0x000021B6 File Offset: 0x000003B6
		<EditorBrowsable(EditorBrowsableState.Never)>
		<DebuggerHidden()>
		Public Function Equals(obj As Object) As Boolean
			Return MyBase.Equals(RuntimeHelpers.GetObjectValue(obj))
		End Function

		' Token: 0x06000020 RID: 32 RVA: 0x000021C4 File Offset: 0x000003C4
		<DebuggerHidden()>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetHashCode() As Integer
			Return MyBase.GetHashCode()
		End Function

		' Token: 0x06000021 RID: 33 RVA: 0x00002358 File Offset: 0x00000558
		<EditorBrowsable(EditorBrowsableState.Never)>
		<DebuggerHidden()>
		Friend Function method_0() As Type
			Return GetType(Class6.Class8)
		End Function

		' Token: 0x06000022 RID: 34 RVA: 0x000021D8 File Offset: 0x000003D8
		<DebuggerHidden()>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function ToString() As String
			Return MyBase.ToString()
		End Function

		' Token: 0x06000023 RID: 35 RVA: 0x00004D14 File Offset: 0x00002F14
		<DebuggerHidden()>
		Private Shared Function smethod_0(Of T As New)(gparam_0 As T) As T
			Dim result As T
			If gparam_0 Is Nothing Then
				result = Activator.CreateInstance(Of T)()
			Else
				result = gparam_0
			End If
			Return result
		End Function

		' Token: 0x06000024 RID: 36 RVA: 0x00002364 File Offset: 0x00000564
		<DebuggerHidden()>
		Private Sub method_1(Of T)(ByRef gparam_0 As T)
			gparam_0 = Nothing
		End Sub

		' Token: 0x06000025 RID: 37 RVA: 0x000021AE File Offset: 0x000003AE
		<DebuggerHidden()>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub New()
		End Sub
	End Class

	' Token: 0x02000007 RID: 7
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(False)>
	Friend NotInheritable Class Class9(Of T As New)
		' Token: 0x1700000C RID: 12
		' (get) Token: 0x06000026 RID: 38 RVA: 0x0000236D File Offset: 0x0000056D
		Friend ReadOnly Property Prop_0 As T
			<DebuggerHidden()>
			Get
				If Class6.Class9(Of T).gparam_0 Is Nothing Then
					Class6.Class9(Of T).gparam_0 = Activator.CreateInstance(Of T)()
				End If
				Return Class6.Class9(Of T).gparam_0
			End Get
		End Property

		' Token: 0x06000027 RID: 39 RVA: 0x000021AE File Offset: 0x000003AE
		<EditorBrowsable(EditorBrowsableState.Never)>
		<DebuggerHidden()>
		Public Sub New()
		End Sub

		' Token: 0x0400000D RID: 13
		<CompilerGenerated()>
		<ThreadStatic()>
		Private Shared gparam_0 As T
	End Class
End Module
