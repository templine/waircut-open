Imports System
Imports System.Runtime.CompilerServices
Imports System.Threading

' Token: 0x02000016 RID: 22
Public Class GClass6
	Implements GInterface9

	' Token: 0x0600019A RID: 410 RVA: 0x00003993 File Offset: 0x00001B93
	Public Sub New()
		Me.string_0 = ""
	End Sub

	' Token: 0x14000003 RID: 3
	' (add) Token: 0x0600019B RID: 411 RVA: 0x00008BC8 File Offset: 0x00006DC8
	' (remove) Token: 0x0600019C RID: 412 RVA: 0x00008C00 File Offset: 0x00006E00
	Public Custom Event Event_0 As GClass6.GDelegate2
		<CompilerGenerated()>
		AddHandler
			Dim gdelegate As GClass6.GDelegate2 = Me.gdelegate2_0
			Dim gdelegate2 As GClass6.GDelegate2
			Do
				gdelegate2 = gdelegate
				Dim value2 As GClass6.GDelegate2 = CType([Delegate].Combine(gdelegate2, value), GClass6.GDelegate2)
				gdelegate = Interlocked.CompareExchange(Of GClass6.GDelegate2)(Me.gdelegate2_0, value2, gdelegate2)
			Loop While gdelegate IsNot gdelegate2
		End AddHandler
		<CompilerGenerated()>
		RemoveHandler
			Dim gdelegate As GClass6.GDelegate2 = Me.gdelegate2_0
			Dim gdelegate2 As GClass6.GDelegate2
			Do
				gdelegate2 = gdelegate
				Dim value2 As GClass6.GDelegate2 = CType([Delegate].Remove(gdelegate2, value), GClass6.GDelegate2)
				gdelegate = Interlocked.CompareExchange(Of GClass6.GDelegate2)(Me.gdelegate2_0, value2, gdelegate2)
			Loop While gdelegate IsNot gdelegate2
		End RemoveHandler
	End Event

	' Token: 0x0600019D RID: 413 RVA: 0x00008C3C File Offset: 0x00006E3C
	Public Sub OnJswSupplicantEvent([event] As GEnum17, evtData As Integer, evtString As String) Implements GInterface9.OnJswSupplicantEvent
		Select Case [event]
			Case GEnum17.JswSuppEvt_None
				Dim ptr As String = Me.string_0
				Me.string_0 = ptr + "Supplicant: None" & vbCrLf
			Case GEnum17.JswSuppEvt_ReceivedCredentials
				Dim ptr As String = Me.string_0
				Me.string_0 = ptr + "Supplicant: Received credential" & vbCrLf
			Case GEnum17.JswSuppEvt_ProtocolSuccess
				Dim ptr As String = Me.string_0
				Me.string_0 = ptr + "Supplicant: Protocol success" & vbCrLf
			Case GEnum17.JswSuppEvt_ProtocolFailure
				Dim ptr As String = Me.string_0
				Me.string_0 = ptr + "Supplicant: Protocol failure" & vbCrLf
			Case GEnum17.JswSuppEvt_ProtocolFailurePIN
				Dim ptr As String = Me.string_0
				Me.string_0 = ptr + "Supplicant: Protocol failure PIN" & vbCrLf
			Case GEnum17.JswSuppEvt_ProtocolFailureTimeout
				Dim ptr As String = Me.string_0
				Me.string_0 = ptr + "Supplicant: timeout" & vbCrLf
			Case GEnum17.JswSuppEvt_ReceivedMessage
				Dim genum As GEnum16 = CType(evtData, GEnum16)
				Dim ptr As String = Me.string_0
				Me.string_0 = ptr + "Supplicant: Received Message: " + genum.ToString() + vbCrLf
			Case GEnum17.JswSuppEvt_SentMessage
				Dim genum2 As GEnum16 = CType(evtData, GEnum16)
				Dim ptr As String = Me.string_0
				Me.string_0 = ptr + "Supplicant: Sent Message: " + genum2.ToString() + vbCrLf
			Case GEnum17.JswSuppEvt_ProtocolWillSucceed
				Dim ptr As String = Me.string_0
				Me.string_0 = ptr + "Supplicant: Protocol will succeed" & vbCrLf
		End Select
		Dim gdelegate As GClass6.GDelegate2 = Me.gdelegate2_0
		If gdelegate IsNot Nothing Then
			gdelegate([event], evtData, evtString, Me.string_0)
		End If
	End Sub

	' Token: 0x04000089 RID: 137
	Public string_0 As String

	' Token: 0x0400008A RID: 138
	<CompilerGenerated()>
	Private gdelegate2_0 As GClass6.GDelegate2

	' Token: 0x02000017 RID: 23
	' (Invoke) Token: 0x060001A1 RID: 417
	Public Delegate Sub GDelegate2([event] As GEnum17, evtData As Integer, evtString As String, message As String)
End Class
