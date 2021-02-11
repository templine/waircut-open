Imports System
Imports System.Runtime.CompilerServices
Imports System.Threading

' Token: 0x02000013 RID: 19
Public Class GClass5
	Implements GInterface4

	' Token: 0x0600018B RID: 395 RVA: 0x00003980 File Offset: 0x00001B80
	Public Sub New()
		Me.string_0 = ""
	End Sub

	' Token: 0x14000001 RID: 1
	' (add) Token: 0x0600018C RID: 396 RVA: 0x00008A5C File Offset: 0x00006C5C
	' (remove) Token: 0x0600018D RID: 397 RVA: 0x00008A98 File Offset: 0x00006C98
	Public Custom Event Event_0 As GClass5.GDelegate0
		<CompilerGenerated()>
		AddHandler
			Dim gdelegate As GClass5.GDelegate0 = Me.gdelegate0_0
			Dim gdelegate2 As GClass5.GDelegate0
			Do
				gdelegate2 = gdelegate
				Dim value2 As GClass5.GDelegate0 = CType([Delegate].Combine(gdelegate2, value), GClass5.GDelegate0)
				gdelegate = Interlocked.CompareExchange(Of GClass5.GDelegate0)(Me.gdelegate0_0, value2, gdelegate2)
			Loop While gdelegate IsNot gdelegate2
		End AddHandler
		<CompilerGenerated()>
		RemoveHandler
			Dim gdelegate As GClass5.GDelegate0 = Me.gdelegate0_0
			Dim gdelegate2 As GClass5.GDelegate0
			Do
				gdelegate2 = gdelegate
				Dim value2 As GClass5.GDelegate0 = CType([Delegate].Remove(gdelegate2, value), GClass5.GDelegate0)
				gdelegate = Interlocked.CompareExchange(Of GClass5.GDelegate0)(Me.gdelegate0_0, value2, gdelegate2)
			Loop While gdelegate IsNot gdelegate2
		End RemoveHandler
	End Event

	' Token: 0x14000002 RID: 2
	' (add) Token: 0x0600018E RID: 398 RVA: 0x00008AD0 File Offset: 0x00006CD0
	' (remove) Token: 0x0600018F RID: 399 RVA: 0x00008B0C File Offset: 0x00006D0C
	Public Custom Event Event_1 As GClass5.GDelegate1
		<CompilerGenerated()>
		AddHandler
			Dim gdelegate As GClass5.GDelegate1 = Me.gdelegate1_0
			Dim gdelegate2 As GClass5.GDelegate1
			Do
				gdelegate2 = gdelegate
				Dim value2 As GClass5.GDelegate1 = CType([Delegate].Combine(gdelegate2, value), GClass5.GDelegate1)
				gdelegate = Interlocked.CompareExchange(Of GClass5.GDelegate1)(Me.gdelegate1_0, value2, gdelegate2)
			Loop While gdelegate IsNot gdelegate2
		End AddHandler
		<CompilerGenerated()>
		RemoveHandler
			Dim gdelegate As GClass5.GDelegate1 = Me.gdelegate1_0
			Dim gdelegate2 As GClass5.GDelegate1
			Do
				gdelegate2 = gdelegate
				Dim value2 As GClass5.GDelegate1 = CType([Delegate].Remove(gdelegate2, value), GClass5.GDelegate1)
				gdelegate = Interlocked.CompareExchange(Of GClass5.GDelegate1)(Me.gdelegate1_0, value2, gdelegate2)
			Loop While gdelegate IsNot gdelegate2
		End RemoveHandler
	End Event

	' Token: 0x06000190 RID: 400 RVA: 0x00008B48 File Offset: 0x00006D48
	Public Sub OnJswApiEvent([event] As GEnum8, evtString As String) Implements GInterface4.OnJswApiEvent
		If [event] <> GEnum8.JswApiEvt_AdapterRemoved Then
			If [event] = GEnum8.JswApiEvt_AdapterAdded Then
				Dim ptr As String = Me.string_0
				Me.string_0 = ptr + "API: Adapter added" & vbCrLf
			End If
		Else
			Dim ptr As String = Me.string_0
			Me.string_0 = ptr + "API: Adapter removed" & vbCrLf
		End If
		Dim gdelegate As GClass5.GDelegate0 = Me.gdelegate0_0
		If gdelegate IsNot Nothing Then
			gdelegate([event], evtString, Me.string_0)
		End If
	End Sub

	' Token: 0x06000191 RID: 401 RVA: 0x00008BA8 File Offset: 0x00006DA8
	Public Sub OnJswApiTraceMessage(threadID As Integer, message As String) Implements GInterface4.OnJswApiTraceMessage
		Dim gdelegate As GClass5.GDelegate1 = Me.gdelegate1_0
		If gdelegate IsNot Nothing Then
			gdelegate(threadID, message)
		End If
	End Sub

	' Token: 0x04000086 RID: 134
	Public string_0 As String

	' Token: 0x04000087 RID: 135
	<CompilerGenerated()>
	Private gdelegate0_0 As GClass5.GDelegate0

	' Token: 0x04000088 RID: 136
	<CompilerGenerated()>
	Private gdelegate1_0 As GClass5.GDelegate1

	' Token: 0x02000014 RID: 20
	' (Invoke) Token: 0x06000195 RID: 405
	Public Delegate Sub GDelegate0([event] As GEnum8, evtString As String, message As String)

	' Token: 0x02000015 RID: 21
	' (Invoke) Token: 0x06000199 RID: 409
	Public Delegate Sub GDelegate1(threadID As Integer, _message As String)
End Class
