Imports System
Imports System.Runtime.CompilerServices
Imports System.Threading

' Token: 0x02000018 RID: 24
Public Class GClass7
	Implements GInterface8

	' Token: 0x14000004 RID: 4
	' (add) Token: 0x060001A3 RID: 419 RVA: 0x00008D9C File Offset: 0x00006F9C
	' (remove) Token: 0x060001A4 RID: 420 RVA: 0x00008DD8 File Offset: 0x00006FD8
	Public Custom Event Event_0 As GClass7.GDelegate3
		<CompilerGenerated()>
		AddHandler
			Dim gdelegate As GClass7.GDelegate3 = Me.gdelegate3_0
			Dim gdelegate2 As GClass7.GDelegate3
			Do
				gdelegate2 = gdelegate
				Dim value2 As GClass7.GDelegate3 = CType([Delegate].Combine(gdelegate2, value), GClass7.GDelegate3)
				gdelegate = Interlocked.CompareExchange(Of GClass7.GDelegate3)(Me.gdelegate3_0, value2, gdelegate2)
			Loop While gdelegate IsNot gdelegate2
		End AddHandler
		<CompilerGenerated()>
		RemoveHandler
			Dim gdelegate As GClass7.GDelegate3 = Me.gdelegate3_0
			Dim gdelegate2 As GClass7.GDelegate3
			Do
				gdelegate2 = gdelegate
				Dim value2 As GClass7.GDelegate3 = CType([Delegate].Remove(gdelegate2, value), GClass7.GDelegate3)
				gdelegate = Interlocked.CompareExchange(Of GClass7.GDelegate3)(Me.gdelegate3_0, value2, gdelegate2)
			Loop While gdelegate IsNot gdelegate2
		End RemoveHandler
	End Event

	' Token: 0x060001A5 RID: 421 RVA: 0x00008E10 File Offset: 0x00007010
	Public Sub OnJswEngineEvent([event] As GEnum14, evtData As Integer, evtString As String) Implements GInterface8.OnJswEngineEvent
		Dim gdelegate As GClass7.GDelegate3 = Me.gdelegate3_0
		If gdelegate IsNot Nothing Then
			gdelegate([event], evtData, evtString)
		End If
	End Sub

	' Token: 0x0400008B RID: 139
	<CompilerGenerated()>
	Private gdelegate3_0 As GClass7.GDelegate3

	' Token: 0x02000019 RID: 25
	' (Invoke) Token: 0x060001A9 RID: 425
	Public Delegate Sub GDelegate3([event] As GEnum14, evtData As Integer, evtString As String)
End Class
