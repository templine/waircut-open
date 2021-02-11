Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace wAirCut.My
	' Token: 0x0200000A RID: 10
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")>
	<CompilerGenerated()>
	Friend NotInheritable Partial Class MySettings
		Inherits ApplicationSettingsBase

		' Token: 0x060000BC RID: 188 RVA: 0x0000329C File Offset: 0x0000149C
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		<DebuggerNonUserCode()>
		Private Shared Sub smethod_0(sender As Object, e As EventArgs)
			If Class6.Form0_0.SaveMySettingsOnExit Then
				MySettings.[Default].Save()
			End If
		End Sub

		' Token: 0x1700009D RID: 157
		' (get) Token: 0x060000BD RID: 189 RVA: 0x00004D34 File Offset: 0x00002F34
		Public Shared ReadOnly Property [Default] As MySettings
			Get
				If Not MySettings.bool_0 Then
					Dim obj As Object = MySettings.object_0
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					SyncLock obj
						If Not MySettings.bool_0 Then
							AddHandler Class6.Form0_0.Shutdown, AddressOf MySettings.smethod_0
							MySettings.bool_0 = True
						End If
					End SyncLock
				End If
				Return MySettings.mySettings_0
			End Get
		End Property

		' Token: 0x1700009E RID: 158
		' (get) Token: 0x060000BE RID: 190 RVA: 0x000032B4 File Offset: 0x000014B4
		' (set) Token: 0x060000BF RID: 191 RVA: 0x000032C6 File Offset: 0x000014C6
		<UserScopedSetting()>
		<DefaultSettingValue("01/31/2017 21:23:00")>
		<DebuggerNonUserCode()>
		Public Property LastDateNewsWatched As DateTime
			Get
				Return Conversions.ToDate(Me("LastDateNewsWatched"))
			End Get
			Set(value As DateTime)
				Me("LastDateNewsWatched") = value
			End Set
		End Property

		' Token: 0x1700009F RID: 159
		' (get) Token: 0x060000C0 RID: 192 RVA: 0x000032D9 File Offset: 0x000014D9
		' (set) Token: 0x060000C1 RID: 193 RVA: 0x000032EB File Offset: 0x000014EB
		<UserScopedSetting()>
		<DefaultSettingValue("0")>
		<DebuggerNonUserCode()>
		Public Property ServiceHours As Integer
			Get
				Return Conversions.ToInteger(Me("ServiceHours"))
			End Get
			Set(value As Integer)
				Me("ServiceHours") = value
			End Set
		End Property

		' Token: 0x170000A0 RID: 160
		' (get) Token: 0x060000C2 RID: 194 RVA: 0x000032FE File Offset: 0x000014FE
		' (set) Token: 0x060000C3 RID: 195 RVA: 0x00003310 File Offset: 0x00001510
		<DebuggerNonUserCode()>
		<DefaultSettingValue("0")>
		<UserScopedSetting()>
		Public Property nRigth As Integer
			Get
				Return Conversions.ToInteger(Me("nRigth"))
			End Get
			Set(value As Integer)
				Me("nRigth") = value
			End Set
		End Property

		' Token: 0x170000A1 RID: 161
		' (get) Token: 0x060000C4 RID: 196 RVA: 0x00003323 File Offset: 0x00001523
		' (set) Token: 0x060000C5 RID: 197 RVA: 0x00003335 File Offset: 0x00001535
		<UserScopedSetting()>
		<DefaultSettingValue("0")>
		<DebuggerNonUserCode()>
		Public Property nWrong As Integer
			Get
				Return Conversions.ToInteger(Me("nWrong"))
			End Get
			Set(value As Integer)
				Me("nWrong") = value
			End Set
		End Property

		' Token: 0x170000A2 RID: 162
		' (get) Token: 0x060000C6 RID: 198 RVA: 0x00003348 File Offset: 0x00001548
		' (set) Token: 0x060000C7 RID: 199 RVA: 0x0000335A File Offset: 0x0000155A
		<DefaultSettingValue("01/31/1990 21:42:00")>
		<UserScopedSetting()>
		<DebuggerNonUserCode()>
		Public Property LastDateOnlineNews As DateTime
			Get
				Return Conversions.ToDate(Me("LastDateOnlineNews"))
			End Get
			Set(value As DateTime)
				Me("LastDateOnlineNews") = value
			End Set
		End Property

		' Token: 0x170000A3 RID: 163
		' (get) Token: 0x060000C8 RID: 200 RVA: 0x0000336D File Offset: 0x0000156D
		' (set) Token: 0x060000C9 RID: 201 RVA: 0x0000337F File Offset: 0x0000157F
		<DebuggerNonUserCode()>
		<DefaultSettingValue("")>
		<UserScopedSetting()>
		Public Property Culture As String
			Get
				Return Conversions.ToString(Me("Culture"))
			End Get
			Set(value As String)
				Me("Culture") = value
			End Set
		End Property

		' Token: 0x170000A4 RID: 164
		' (get) Token: 0x060000CA RID: 202 RVA: 0x0000338D File Offset: 0x0000158D
		' (set) Token: 0x060000CB RID: 203 RVA: 0x0000339F File Offset: 0x0000159F
		<UserScopedSetting()>
		<DebuggerNonUserCode()>
		<DefaultSettingValue("False")>
		Public Property mbl As Boolean
			Get
				Return Conversions.ToBoolean(Me("mbl"))
			End Get
			Set(value As Boolean)
				Me("mbl") = value
			End Set
		End Property

		' Token: 0x170000A5 RID: 165
		' (get) Token: 0x060000CC RID: 204 RVA: 0x000033B2 File Offset: 0x000015B2
		' (set) Token: 0x060000CD RID: 205 RVA: 0x000033C4 File Offset: 0x000015C4
		<DebuggerNonUserCode()>
		<DefaultSettingValue("2016-02-20")>
		<UserScopedSetting()>
		Public Property StartTime As DateTime
			Get
				Return Conversions.ToDate(Me("StartTime"))
			End Get
			Set(value As DateTime)
				Me("StartTime") = value
			End Set
		End Property

		' Token: 0x170000A6 RID: 166
		' (get) Token: 0x060000CE RID: 206 RVA: 0x000033D7 File Offset: 0x000015D7
		' (set) Token: 0x060000CF RID: 207 RVA: 0x000033E9 File Offset: 0x000015E9
		<DebuggerNonUserCode()>
		<DefaultSettingValue("6")>
		<UserScopedSetting()>
		Public Property ScanTime As Integer
			Get
				Return Conversions.ToInteger(Me("ScanTime"))
			End Get
			Set(value As Integer)
				Me("ScanTime") = value
			End Set
		End Property

		' Token: 0x170000A7 RID: 167
		' (get) Token: 0x060000D0 RID: 208 RVA: 0x000033FC File Offset: 0x000015FC
		' (set) Token: 0x060000D1 RID: 209 RVA: 0x0000340E File Offset: 0x0000160E
		<UserScopedSetting()>
		<DefaultSettingValue("01/31/1990 21:42:00")>
		<DebuggerNonUserCode()>
		Public Property LastDBDate As DateTime
			Get
				Return Conversions.ToDate(Me("LastDBDate"))
			End Get
			Set(value As DateTime)
				Me("LastDBDate") = value
			End Set
		End Property

		' Token: 0x04000012 RID: 18
		Private Shared mySettings_0 As MySettings = CType(SettingsBase.Synchronized(New MySettings()), MySettings)

		' Token: 0x04000013 RID: 19
		Private Shared bool_0 As Boolean

		' Token: 0x04000014 RID: 20
		Private Shared object_0 As Object = RuntimeHelpers.GetObjectValue(New Object())
	End Class
End Namespace
