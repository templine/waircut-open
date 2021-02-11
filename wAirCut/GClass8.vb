Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports wAirCut
Imports wAirCut.My

' Token: 0x0200001D RID: 29
Public Class GClass8
	' Token: 0x1700013B RID: 315
	' (get) Token: 0x060002A3 RID: 675 RVA: 0x00003F54 File Offset: 0x00002154
	' (set) Token: 0x060002A4 RID: 676 RVA: 0x0000E474 File Offset: 0x0000C674
	Private Overridable Property GClass7_0 As GClass7
		<CompilerGenerated()>
		Get
			Return Me.gclass7_0
		End Get
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Set(value As GClass7)
			Dim value2 As GClass7.GDelegate3 = AddressOf Me.method_13
			Dim gclass As GClass7 = Me.gclass7_0
			If gclass IsNot Nothing Then
				RemoveHandler gclass.Event_0, value2
			End If
			Me.gclass7_0 = value
			gclass = Me.gclass7_0
			If gclass IsNot Nothing Then
				AddHandler gclass.Event_0, value2
			End If
		End Set
	End Property

	' Token: 0x14000005 RID: 5
	' (add) Token: 0x060002A5 RID: 677 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
	' (remove) Token: 0x060002A6 RID: 678 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
	Public Custom Event Event_0 As GClass8.GDelegate6
		<CompilerGenerated()>
		AddHandler
			Dim gdelegate As GClass8.GDelegate6 = Me.gdelegate6_0
			Dim gdelegate2 As GClass8.GDelegate6
			Do
				gdelegate2 = gdelegate
				Dim value2 As GClass8.GDelegate6 = CType([Delegate].Combine(gdelegate2, value), GClass8.GDelegate6)
				gdelegate = Interlocked.CompareExchange(Of GClass8.GDelegate6)(Me.gdelegate6_0, value2, gdelegate2)
			Loop While gdelegate IsNot gdelegate2
		End AddHandler
		<CompilerGenerated()>
		RemoveHandler
			Dim gdelegate As GClass8.GDelegate6 = Me.gdelegate6_0
			Dim gdelegate2 As GClass8.GDelegate6
			Do
				gdelegate2 = gdelegate
				Dim value2 As GClass8.GDelegate6 = CType([Delegate].Remove(gdelegate2, value), GClass8.GDelegate6)
				gdelegate = Interlocked.CompareExchange(Of GClass8.GDelegate6)(Me.gdelegate6_0, value2, gdelegate2)
			Loop While gdelegate IsNot gdelegate2
		End RemoveHandler
	End Event

	' Token: 0x14000006 RID: 6
	' (add) Token: 0x060002A7 RID: 679 RVA: 0x0000E528 File Offset: 0x0000C728
	' (remove) Token: 0x060002A8 RID: 680 RVA: 0x0000E564 File Offset: 0x0000C764
	Public Custom Event Event_1 As GClass8.GDelegate7
		<CompilerGenerated()>
		AddHandler
			Dim gdelegate As GClass8.GDelegate7 = Me.gdelegate7_0
			Dim gdelegate2 As GClass8.GDelegate7
			Do
				gdelegate2 = gdelegate
				Dim value2 As GClass8.GDelegate7 = CType([Delegate].Combine(gdelegate2, value), GClass8.GDelegate7)
				gdelegate = Interlocked.CompareExchange(Of GClass8.GDelegate7)(Me.gdelegate7_0, value2, gdelegate2)
			Loop While gdelegate IsNot gdelegate2
		End AddHandler
		<CompilerGenerated()>
		RemoveHandler
			Dim gdelegate As GClass8.GDelegate7 = Me.gdelegate7_0
			Dim gdelegate2 As GClass8.GDelegate7
			Do
				gdelegate2 = gdelegate
				Dim value2 As GClass8.GDelegate7 = CType([Delegate].Remove(gdelegate2, value), GClass8.GDelegate7)
				gdelegate = Interlocked.CompareExchange(Of GClass8.GDelegate7)(Me.gdelegate7_0, value2, gdelegate2)
			Loop While gdelegate IsNot gdelegate2
		End RemoveHandler
	End Event

	' Token: 0x14000007 RID: 7
	' (add) Token: 0x060002A9 RID: 681 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
	' (remove) Token: 0x060002AA RID: 682 RVA: 0x0000E5D8 File Offset: 0x0000C7D8
	Public Custom Event Event_2 As GClass8.GDelegate8
		<CompilerGenerated()>
		AddHandler
			Dim gdelegate As GClass8.GDelegate8 = Me.gdelegate8_0
			Dim gdelegate2 As GClass8.GDelegate8
			Do
				gdelegate2 = gdelegate
				Dim value2 As GClass8.GDelegate8 = CType([Delegate].Combine(gdelegate2, value), GClass8.GDelegate8)
				gdelegate = Interlocked.CompareExchange(Of GClass8.GDelegate8)(Me.gdelegate8_0, value2, gdelegate2)
			Loop While gdelegate IsNot gdelegate2
		End AddHandler
		<CompilerGenerated()>
		RemoveHandler
			Dim gdelegate As GClass8.GDelegate8 = Me.gdelegate8_0
			Dim gdelegate2 As GClass8.GDelegate8
			Do
				gdelegate2 = gdelegate
				Dim value2 As GClass8.GDelegate8 = CType([Delegate].Remove(gdelegate2, value), GClass8.GDelegate8)
				gdelegate = Interlocked.CompareExchange(Of GClass8.GDelegate8)(Me.gdelegate8_0, value2, gdelegate2)
			Loop While gdelegate IsNot gdelegate2
		End RemoveHandler
	End Event

	' Token: 0x14000008 RID: 8
	' (add) Token: 0x060002AB RID: 683 RVA: 0x0000E610 File Offset: 0x0000C810
	' (remove) Token: 0x060002AC RID: 684 RVA: 0x0000E64C File Offset: 0x0000C84C
	Private Custom Event Event_3 As GClass8.Delegate0
		<CompilerGenerated()>
		AddHandler
			Dim [delegate] As GClass8.Delegate0 = Me.delegate0_0
			Dim delegate2 As GClass8.Delegate0
			Do
				delegate2 = [delegate]
				Dim value2 As GClass8.Delegate0 = CType([Delegate].Combine(delegate2, value), GClass8.Delegate0)
				[delegate] = Interlocked.CompareExchange(Of GClass8.Delegate0)(Me.delegate0_0, value2, delegate2)
			Loop While [delegate] IsNot delegate2
		End AddHandler
		<CompilerGenerated()>
		RemoveHandler
			Dim [delegate] As GClass8.Delegate0 = Me.delegate0_0
			Dim delegate2 As GClass8.Delegate0
			Do
				delegate2 = [delegate]
				Dim value2 As GClass8.Delegate0 = CType([Delegate].Remove(delegate2, value), GClass8.Delegate0)
				[delegate] = Interlocked.CompareExchange(Of GClass8.Delegate0)(Me.delegate0_0, value2, delegate2)
			Loop While [delegate] IsNot delegate2
		End RemoveHandler
	End Event

	' Token: 0x060002AD RID: 685 RVA: 0x0000E684 File Offset: 0x0000C884
	Public Sub New()
		Me.int_0 = 0
		Me.list_0 = New List(Of GInterface1)()
		Me.GClass7_0 = New GClass7()
		Me.bool_0 = False
		Me.gclass12_0 = New GClass12("12345670", GClass12.GEnum5.Manual)
		Me.string_0 = ""
		Me.bool_1 = True
		Me.genum1_0 = GClass8.GEnum1.[Stop]
		Me.genum2_0 = GClass8.GEnum2.None
		Me.genum16_0 = GEnum16.JswMsgType_None
		Me.bool_2 = False
		Me.bool_3 = False
		Class13.smethod_3(GClass0.String_0)
		Me.method_0()
		Me.method_3()
	End Sub

	' Token: 0x060002AE RID: 686 RVA: 0x00003F5C File Offset: 0x0000215C
	Private Sub method_0()
		Me.ginterface3_0 = CType(Activator.CreateInstance(Type.GetTypeFromCLSID(New Guid("77594188-FA62-45EE-A6D6-77FEBAE0AA77"))), GInterface14)
		Me.ginterface3_0.imethod_0()
	End Sub

	' Token: 0x060002AF RID: 687 RVA: 0x0000E718 File Offset: 0x0000C918
	Private Sub method_1(int_1 As Integer)
		Me.ginterface0_0 = Me.ginterface3_0.imethod_2(CType(Me.list_0(int_1), GInterface12))
		Dim text As String = Class13.smethod_1(CType(Me.ginterface0_0.imethod_3().Object_0, Byte()))
		If Class13.bool_1 Then
			text = Class13.smethod_13(text, "X")
		End If
		Dim gdelegate As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate IsNot Nothing Then
			gdelegate(String.Format("Adapter -Start {0}", text), Color.White, True)
		End If
		Me.method_2()
	End Sub

	' Token: 0x060002B0 RID: 688 RVA: 0x0000E79C File Offset: 0x0000C99C
	Private Sub method_2()
		Me.ginterface7_0 = Me.ginterface3_0.imethod_3(GEnum15.JswEngMode_JoinNetworkApPin, CType(Me.ginterface0_0, GInterface11), Nothing)
		Dim gdelegate As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate IsNot Nothing Then
			gdelegate(Class13.string_4, Color.LightGreen, False)
		End If
		Me.bool_3 = True
		Me.ginterface7_0.imethod_2(Me.GClass7_0)
	End Sub

	' Token: 0x060002B1 RID: 689 RVA: 0x0000E7FC File Offset: 0x0000C9FC
	Public Sub method_3()
		Me.list_0.Clear()
		Me.ginterface2_0 = Me.ginterface3_0.imethod_1()
		If Not Me.bool_3 Then
			Dim gdelegate As GClass8.GDelegate6 = Me.gdelegate6_0
			If gdelegate IsNot Nothing Then
				gdelegate(Class13.string_4, Color.LightGreen, False)
			End If
		End If
		Dim gdelegate2 As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate2 IsNot Nothing Then
			gdelegate2("AdapterList -ALL_WIRELESS_ONLY", Color.White, True)
		End If
		Try
			While Me.ginterface2_0 IsNot Nothing
				Dim ginterface As GInterface12 = Me.ginterface2_0.imethod_0()
				If ginterface.GEnum13_0 = GEnum13.JswDeviceType_WiFi And Not ginterface.String_0.Contains("Virtual") Then
					Me.list_0.Add(ginterface)
					Dim text As String = Class13.smethod_1(CType(ginterface.Object_0, Byte()))
					If Class13.bool_1 Then
						text = Class13.smethod_13(text, "X")
					End If
					Dim gdelegate3 As GClass8.GDelegate6 = Me.gdelegate6_0
					If gdelegate3 IsNot Nothing Then
						gdelegate3(String.Format("{0}    {1}", text, ginterface.String_0), Color.White, True)
					End If
				End If
			End While
		Catch ex As Exception
		End Try
		If Not Me.bool_3 Then
			Dim gdelegate4 As GClass8.GDelegate6 = Me.gdelegate6_0
			If gdelegate4 IsNot Nothing Then
				gdelegate4(Class13.string_4, Color.LightGreen, False)
			End If
		End If
	End Sub

	' Token: 0x060002B2 RID: 690 RVA: 0x0000E940 File Offset: 0x0000CB40
	Public Sub method_4(int_1 As Integer)
		Try
			Me.int_0 = int_1
			Me.method_1(Me.int_0)
		Catch ex As Exception
		End Try
	End Sub

	' Token: 0x060002B3 RID: 691 RVA: 0x00003F88 File Offset: 0x00002188
	Private Sub method_5()
		Class13.smethod_3(GClass0.String_0)
		Me.method_0()
		Me.method_3()
		Me.method_1(Me.int_0)
		Me.method_6(Me.bool_1, 1)
	End Sub

	' Token: 0x060002B4 RID: 692 RVA: 0x0000E980 File Offset: 0x0000CB80
	Public Function method_6(bool_4 As Boolean, int_1 As Integer) As GClass15(Of GClass9)
		Dim gclass As GClass15(Of GClass9) = New GClass15(Of GClass9)()
		Dim i As Integer = 0
		Me.bool_1 = bool_4
		Dim gdelegate As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate IsNot Nothing Then
			gdelegate(String.Format("Scan -WPSONLY {0}", bool_4), Color.White, True)
		End If
		Try
			If Me.genum1_0 = GClass8.GEnum1.[Stop] Then
				Dim waitSplashForm As WaitSplashForm = New WaitSplashForm("Scanning", int_1, Class6.Class7_0.MainForm_0)
				waitSplashForm.Show()
				While i < int_1
					Dim ginterface As GInterface16 = Me.ginterface0_0.imethod_1(bool_4)
					Me.ginterface0_0.imethod_0()
					Dim gdelegate2 As GClass8.GDelegate6 = Me.gdelegate6_0
					If gdelegate2 IsNot Nothing Then
						gdelegate2(".", Color.Yellow, False)
					End If
					Dim num As Integer = 500000
					Dim now As DateTime = DateAndTime.Now
					Dim timeSpan As TimeSpan = DateAndTime.Now.Subtract(DateAndTime.Now)
					now = DateAndTime.Now
					timeSpan = DateAndTime.Now.Subtract(now)
					While timeSpan.TotalMilliseconds < 1000.0
						Application.DoEvents()
						num -= 1
						timeSpan = DateAndTime.Now.Subtract(now)
					End While
					ginterface = Me.ginterface0_0.imethod_1(bool_4)
					i += 1
					waitSplashForm.Int32_0 = i
					Dim num2 As Integer = ginterface.imethod_1() - 1
					For j As Integer = 0 To num2
						Dim ginterface2 As GInterface15 = ginterface.imethod_0()
						Dim ginterface3 As GInterface5 = ginterface2
						Dim gclass2 As GClass9 = New GClass9(ginterface3)
						ginterface2 = CType(ginterface3, GInterface15)
						Dim item As GClass9 = gclass2
						If gclass.Contains(item) Then
							Dim index As Integer = gclass.IndexOf(item)
							Dim gclass3 As GClass9 = gclass(index)
							ginterface3 = ginterface2
							gclass3.method_2(ginterface3, GEnum16.JswMsgType_Beacon)
							ginterface2 = CType(ginterface3, GInterface15)
						Else
							gclass.Add(item)
							If Me.bool_2 Then
								Dim gdelegate3 As GClass8.GDelegate6 = Me.gdelegate6_0
								If gdelegate3 IsNot Nothing Then
									gdelegate3(Class13.smethod_12(ginterface2.imethod_2()), Color.Gray, True)
								End If
							End If
						End If
					Next
				End While
				waitSplashForm.Dispose()
				Dim gdelegate4 As GClass8.GDelegate6 = Me.gdelegate6_0
				If gdelegate4 IsNot Nothing Then
					gdelegate4(".", Color.Yellow, True)
				End If
				Dim gdelegate5 As GClass8.GDelegate6 = Me.gdelegate6_0
				If gdelegate5 IsNot Nothing Then
					gdelegate5(Class13.smethod_0(gclass), Color.White, True)
				End If
			End If
		Catch ex As Exception
			Dim gdelegate6 As GClass8.GDelegate6 = Me.gdelegate6_0
			If gdelegate6 IsNot Nothing Then
				gdelegate6(ex.Message, Color.IndianRed, True)
			End If
		End Try
		Dim gdelegate7 As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate7 IsNot Nothing Then
			gdelegate7(Class13.string_4, Color.LightGreen, False)
		End If
		Return gclass
	End Function

	' Token: 0x060002B5 RID: 693 RVA: 0x0000EC0C File Offset: 0x0000CE0C
	Public Sub method_7(ByRef gclass9_1 As GClass9, gclass12_1 As GClass12)
		Try
			Me.gclass9_0 = gclass9_1
			Me.gclass12_0 = gclass12_1
			If Me.method_11() Then
				If Me.ginterface0_0.imethod_2() Then
					NewLateBinding.LateCall(Me.ginterface0_0, Nothing, "ResetConnection", New Object() { True, GEnum11.JswConnResetMethod_Default }, Nothing, Nothing, Nothing, True)
				End If
				Me.genum16_0 = GEnum16.JswMsgType_None
				Me.ginterface7_0 = Me.ginterface3_0.imethod_3(GEnum15.JswEngMode_JoinNetworkApPin, CType(Me.ginterface0_0, GInterface11), Nothing)
				Me.ginterface7_0.imethod_2(Me.GClass7_0)
				If Me.ginterface7_0 IsNot Nothing Then
					Me.ginterface7_0.imethod_4(CType(Me.gclass9_0.ginterface5_0, GInterface15))
					Me.ginterface7_0.imethod_3(Me.gclass12_0.Pin)
					Me.ginterface7_0.imethod_0()
				End If
				Me.genum1_0 = GClass8.GEnum1.Start
				Dim gdelegate As GClass8.GDelegate8 = Me.gdelegate8_0
				If gdelegate IsNot Nothing Then
					gdelegate(Me.genum1_0)
				End If
			End If
		Catch ex As Exception
			Dim gdelegate2 As GClass8.GDelegate6 = Me.gdelegate6_0
			If gdelegate2 IsNot Nothing Then
				gdelegate2(ex.Message, Color.IndianRed, True)
			End If
			Me.method_5()
		End Try
	End Sub

	' Token: 0x060002B6 RID: 694 RVA: 0x0000ED48 File Offset: 0x0000CF48
	Public Sub method_8(ByRef gclass9_1 As GClass9, ByRef gclass12_1 As GClass12)
		Try
			Me.gclass9_0 = gclass9_1
			Me.gclass12_0 = gclass12_1
			If Me.ginterface0_0.imethod_2() Then
				NewLateBinding.LateCall(Me.ginterface0_0, Nothing, "ResetConnection", New Object() { True, GEnum11.JswConnResetMethod_Default }, Nothing, Nothing, Nothing, True)
			End If
			Me.genum16_0 = GEnum16.JswMsgType_None
			Me.ginterface7_0 = Me.ginterface3_0.imethod_3(GEnum15.JswEngMode_JoinNetworkPushbutton, CType(Me.ginterface0_0, GInterface11), Nothing)
			Me.ginterface7_0.imethod_2(Me.GClass7_0)
			If Me.ginterface7_0 IsNot Nothing Then
				Me.ginterface7_0.imethod_4(CType(Me.gclass9_0.ginterface5_0, GInterface15))
				Me.ginterface7_0.imethod_0()
			End If
			Me.genum1_0 = GClass8.GEnum1.Start
			Dim gdelegate As GClass8.GDelegate8 = Me.gdelegate8_0
			If gdelegate IsNot Nothing Then
				gdelegate(Me.genum1_0)
			End If
		Catch ex As Exception
			Dim gdelegate2 As GClass8.GDelegate6 = Me.gdelegate6_0
			If gdelegate2 IsNot Nothing Then
				gdelegate2(ex.Message, Color.IndianRed, True)
			End If
			Me.method_5()
		End Try
	End Sub

	' Token: 0x060002B7 RID: 695 RVA: 0x00003FBA File Offset: 0x000021BA
	Public Sub method_9(ByRef gclass9_1 As GClass9)
		Me.bool_0 = True
		Me.method_7(gclass9_1, New GClass12("12345670", GClass12.GEnum5.Manual))
	End Sub

	' Token: 0x060002B8 RID: 696 RVA: 0x0000EE64 File Offset: 0x0000D064
	Public Sub method_10(bool_4 As Boolean)
		Try
			If Me.ginterface7_0 IsNot Nothing Then
				Me.ginterface7_0.imethod_1()
				If Me.ginterface0_0.imethod_2() Then
					NewLateBinding.LateCall(Me.ginterface0_0, Nothing, "ResetConnection", New Object() { True, GEnum11.JswConnResetMethod_Default }, Nothing, Nothing, Nothing, True)
				End If
				Me.bool_0 = False
				If Me.genum1_0 <> GClass8.GEnum1.[Stop] Then
					Me.genum1_0 = GClass8.GEnum1.[Stop]
					Dim gdelegate As GClass8.GDelegate8 = Me.gdelegate8_0
					If gdelegate IsNot Nothing Then
						gdelegate(Me.genum1_0)
					End If
					If bool_4 Then
						Me.ginterface7_0 = Nothing
					End If
				End If
			End If
		Catch ex As Exception
			Dim gdelegate2 As GClass8.GDelegate6 = Me.gdelegate6_0
			If gdelegate2 IsNot Nothing Then
				gdelegate2(ex.Message, Color.IndianRed, True)
			End If
			Me.method_5()
		End Try
	End Sub

	' Token: 0x060002B9 RID: 697 RVA: 0x0000EF38 File Offset: 0x0000D138
	Private Function method_11() As Boolean
		Dim num As Integer = 10
		Dim flag As Boolean = False
		Dim now As DateTime = DateAndTime.Now
		Dim timeSpan As TimeSpan = DateAndTime.Now.Subtract(DateAndTime.Now)
		Dim gdelegate As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate IsNot Nothing Then
			gdelegate(String.Format("Scan -BSSID {0}", Me.gclass9_0.BSSID), Color.White, True)
		End If
		Dim gdelegate2 As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate2 IsNot Nothing Then
			gdelegate2(Class10.String_47, Color.Yellow, False)
		End If
		While num > 0 And Not flag
			Dim gdelegate3 As GClass8.GDelegate6 = Me.gdelegate6_0
			If gdelegate3 IsNot Nothing Then
				gdelegate3(".", Color.Yellow, False)
			End If
			Dim ginterface As GInterface16 = Me.ginterface0_0.imethod_1(Me.bool_1)
			Me.ginterface0_0.imethod_0()
			Dim i As Integer = 500000
			now = DateAndTime.Now
			timeSpan = DateAndTime.Now.Subtract(now)
			While timeSpan.TotalMilliseconds < 1600.0
				Application.DoEvents()
				i -= 1
				timeSpan = DateAndTime.Now.Subtract(now)
			End While
			ginterface = Me.ginterface0_0.imethod_1(Me.bool_1)
			If ginterface.imethod_1() > 0 Then
				num -= 1
			End If
			Dim num2 As Integer = ginterface.imethod_1() - 1
			i = 0
			While i <= num2
				Dim ginterface2 As GInterface15 = ginterface.imethod_0()
				If Operators.CompareString(Class13.smethod_1(CType(ginterface2.imethod_0(GEnum9.JswAttr_MACAddress), Byte())), Class13.smethod_1(CType(Me.gclass9_0.ginterface5_0.imethod_0(GEnum9.JswAttr_MACAddress), Byte())), False) = 0 Then
					Dim gclass As GClass9 = Me.gclass9_0
					Dim ginterface3 As GInterface5 = ginterface2
					gclass.method_2(ginterface3, GEnum16.JswMsgType_Beacon)
					ginterface2 = CType(ginterface3, GInterface15)
					flag = True
				End If
				i += 1
			End While
		End While
		If Not flag Then
			Dim gdelegate4 As GClass8.GDelegate6 = Me.gdelegate6_0
			If gdelegate4 IsNot Nothing Then
				gdelegate4(vbCrLf + Class10.String_41, Color.Red, True)
			End If
			Dim gdelegate5 As GClass8.GDelegate8 = Me.gdelegate8_0
			If gdelegate5 IsNot Nothing Then
				gdelegate5(GClass8.GEnum1.ApNotFound)
			End If
		Else
			Dim gdelegate6 As GClass8.GDelegate6 = Me.gdelegate6_0
			If gdelegate6 IsNot Nothing Then
				gdelegate6("", Color.LightGreen, True)
			End If
		End If
		Dim gdelegate7 As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate7 IsNot Nothing Then
			gdelegate7(Class13.string_4, Color.LightGreen, False)
		End If
		Return flag
	End Function

	' Token: 0x060002BA RID: 698 RVA: 0x0000F170 File Offset: 0x0000D370
	Public Function method_12(ByRef gclass9_1 As GClass9, ByRef gclass15_0 As GClass15(Of GClass9), ByRef control_0 As Control) As String
		Dim flag As Boolean = False
		Dim text As String = ""
		Dim now As DateTime = DateAndTime.Now
		Dim timeSpan As TimeSpan = DateAndTime.Now.Subtract(DateAndTime.Now)
		Dim waitSplashProcess As WaitSplashProcess = New WaitSplashProcess(control_0, Class10.String_77)
		If gclass9_1 Is Nothing Then
			Dim gdelegate As GClass8.GDelegate6 = Me.gdelegate6_0
			If gdelegate IsNot Nothing Then
				gdelegate("WaitingPBC -ALL", Color.White, True)
			End If
		Else
			Dim gdelegate2 As GClass8.GDelegate6 = Me.gdelegate6_0
			If gdelegate2 IsNot Nothing Then
				gdelegate2(String.Format("WaitingPBC -BSSID {0}", gclass9_1.BSSID), Color.White, True)
			End If
		End If
		While Operators.CompareString(text, "", False) = 0 And Not flag
			Dim ginterface As GInterface16 = Me.ginterface0_0.imethod_1(Me.bool_1)
			Me.ginterface0_0.imethod_0()
			Dim i As Integer = 500000
			now = DateAndTime.Now
			timeSpan = DateAndTime.Now.Subtract(now)
			While timeSpan.TotalMilliseconds < 1600.0
				Application.DoEvents()
				i -= 1
				timeSpan = DateAndTime.Now.Subtract(now)
			End While
			If Not waitSplashProcess.IsDisposed Then
				If Not waitSplashProcess.Visible Then
					waitSplashProcess.Show()
				End If
				waitSplashProcess.Refresh()
			Else
				flag = True
			End If
			Try
				ginterface = Me.ginterface0_0.imethod_1(Me.bool_1)
				Dim num As Integer = ginterface.imethod_1() - 1
				i = 0
				While i <= num
					Dim ginterface2 As GInterface15 = ginterface.imethod_0()
					If gclass9_1 Is Nothing Then
						GoTo IL_1FE
					End If
					Dim ginterface3 As GInterface5
					If Operators.CompareString(Class13.smethod_1(CType(ginterface2.imethod_0(GEnum9.JswAttr_MACAddress), Byte())), Class13.smethod_1(CType(gclass9_1.ginterface5_0.imethod_0(GEnum9.JswAttr_MACAddress), Byte())), False) = 0 Then
						Dim gclass As GClass9 = gclass9_1
						ginterface3 = ginterface2
						gclass.method_2(ginterface3, GEnum16.JswMsgType_Beacon)
						ginterface2 = CType(ginterface3, GInterface15)
						Try
							If Operators.ConditionalCompareObjectEqual(CType(ginterface2.imethod_0(GEnum9.JswAttr_SimpleConfigIEs), GInterface15).imethod_0(GEnum9.JswAttr_DevicePasswordID), GEnum12.JswDevicePasswordID_PushButton, False) Then
								text = Class13.smethod_1(CType(ginterface2.imethod_0(GEnum9.JswAttr_MACAddress), Byte()))
							End If
							GoTo IL_2A4
						Catch ex As Exception
							GoTo IL_2A4
						End Try
						GoTo IL_1FE
					End If
					IL_2A4:
					i += 1
					Continue While
					IL_1FE:
					ginterface3 = ginterface2
					Dim gclass2 As GClass9 = New GClass9(ginterface3)
					ginterface2 = CType(ginterface3, GInterface15)
					Dim item As GClass9 = gclass2
					If Not gclass15_0.Contains(item) Then
						gclass15_0.Add(item)
					Else
						Dim index As Integer = gclass15_0.IndexOf(item)
						Dim gclass3 As GClass9 = gclass15_0(index)
						ginterface3 = ginterface2
						gclass3.method_2(ginterface3, GEnum16.JswMsgType_Beacon)
						ginterface2 = CType(ginterface3, GInterface15)
					End If
					Try
						If Operators.ConditionalCompareObjectEqual(CType(ginterface2.imethod_0(GEnum9.JswAttr_SimpleConfigIEs), GInterface15).imethod_0(GEnum9.JswAttr_DevicePasswordID), GEnum12.JswDevicePasswordID_PushButton, False) Then
							text = Class13.smethod_1(CType(ginterface2.imethod_0(GEnum9.JswAttr_MACAddress), Byte()))
						End If
					Catch ex2 As Exception
					End Try
					GoTo IL_2A4
				End While
			Catch ex3 As Exception
			End Try
		End While
		If Not waitSplashProcess.IsDisposed Then
			waitSplashProcess.Dispose()
		End If
		If Operators.CompareString(text, "", False) = 0 Then
			Dim gdelegate3 As GClass8.GDelegate8 = Me.gdelegate8_0
			If gdelegate3 IsNot Nothing Then
				gdelegate3(GClass8.GEnum1.ApNotFound)
			End If
		Else
			Dim gdelegate4 As GClass8.GDelegate6 = Me.gdelegate6_0
			If gdelegate4 IsNot Nothing Then
				gdelegate4("", Color.LightGreen, True)
			End If
		End If
		Dim gdelegate5 As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate5 IsNot Nothing Then
			gdelegate5(Class13.string_4, Color.LightGreen, False)
		End If
		Return text
	End Function

	' Token: 0x060002BB RID: 699 RVA: 0x0000F514 File Offset: 0x0000D714
	Private Sub method_13(genum14_0 As GEnum14, int_1 As Integer, string_1 As String)
		Class6.Form0_0.ChangeUICulture(MySettings.[Default].Culture)
		While True
			IL_37B:
			While True
				IL_318:
				Select Case genum14_0
					Case GEnum14.JswEngEvt_None
						GoTo IL_37F
					Case GEnum14.JswEngEvt_FailedInitialize
						GoTo IL_3A5
					Case GEnum14.JswEngEvt_Starting
						GoTo IL_3CB
					Case GEnum14.JswEngEvt_ScanningForAps
						GoTo IL_534
					Case GEnum14.JswEngEvt_NoCandidateApsFound
						GoTo IL_55A
					Case GEnum14.JswEngEvt_SelectedAp
						GoTo IL_580
					Case GEnum14.JswEngEvt_Associating
						GoTo IL_5AE
					Case GEnum14.JswEngEvt_AssociationFailed
						GoTo IL_5D1
					Case GEnum14.JswEngEvt_StartProtocol
						GoTo IL_606
					Case GEnum14.JswEngEvt_ProtocolSuccess, GEnum14.JswEngEvt_ProtocolAttemptFailed
						GoTo IL_D11
					Case GEnum14.JswEngEvt_ProtocolFailed
						GoTo IL_62C
					Case GEnum14.JswEngEvt_MultipleApsInPbMode
						GoTo IL_652
					Case GEnum14.JswEngEvt_ReceivedCredentials
						GoTo IL_678
					Case GEnum14.JswEngEvt_PushButtonTimeout
						GoTo IL_6AE
					Case GEnum14.JswEngEvt_SupplicantReceivedMsg
						GoTo IL_6D4
					Case GEnum14.JswEngEvt_SupplicantSentMsg
						GoTo IL_810
					Case GEnum14.JswEngEvt_ProtocolFailedResetPin
						GoTo IL_C28
					Case GEnum14.JswEngEvt_ApInSetupLockedState
						GoTo IL_C4E
					Case GEnum14.JswEngEvt_Initializing
						GoTo IL_CA4
					Case GEnum14.JswEngEvt_FailedDeviceInitialize
						GoTo IL_CD3
					Case GEnum14.JswEngEvt_ProtocolTimeout
						GoTo IL_CF3
					Case Else
						Dim num2 As UInteger
						Dim num As Integer = CInt((num2 * 1883954165UI Xor 3868796024UI))
						While True
							Dim num3 As Integer = num Xor 112626749
							num2 = CUInt(num3)
							Select Case num3 Mod 178
								Case 0
									GoTo IL_8E5
								Case 1
									GoTo IL_CF3
								Case 2
									GoTo IL_63B
								Case 3
									GoTo IL_BC6
								Case 4, 100
									GoTo IL_37B
								Case 5
									GoTo IL_CDF
								Case 6, 12, 19, 31, 44, 56, 58, 63, 64, 91, 108, 111, 112, 117, 127, 129, 140, 159, 168
									GoTo IL_D11
								Case 7
									GoTo IL_69C
								Case 8
									GoTo IL_53C
								Case 9
									GoTo IL_B1D
								Case 10
									GoTo IL_6FD
								Case 11, 34, 150
									GoTo IL_7F4
								Case 13
									GoTo IL_A6B
								Case 14
									GoTo IL_65A
								Case 15
									GoTo IL_9B1
								Case 16
									GoTo IL_716
								Case 17
									GoTo IL_8C2
								Case 18
									GoTo IL_37F
								Case 20
									GoTo IL_D31
								Case 21
									GoTo IL_8D5
								Case 22
									GoTo IL_5F9
								Case 23
									GoTo IL_C56
								Case 24
									GoTo IL_3D2
								Case 25
									GoTo IL_C5A
								Case 26
									GoTo IL_522
								Case 27
									GoTo IL_678
								Case 28
									GoTo IL_AF5
								Case 29
									GoTo IL_78B
								Case 30
									GoTo IL_7FC
								Case 32
									GoTo IL_661
								Case 33
									GoTo IL_C93
								Case 35
									num = CInt((num2 * 909184755UI Xor 1462892102UI))
									Continue For
								Case 36
									GoTo IL_C9B
								Case 37
									GoTo IL_7B4
								Case 38
									GoTo IL_B5E
								Case 39
									GoTo IL_BD2
								Case 40
									GoTo IL_3B4
								Case 41
									GoTo IL_6AE
								Case 42
									GoTo IL_B78
								Case 43
									GoTo IL_A19
								Case 45
									GoTo IL_543
								Case 46
									GoTo IL_BE7
								Case 47
									GoTo IL_998
								Case 48
									GoTo IL_D40
								Case 49
									GoTo IL_C87
								Case 50
									GoTo IL_71F
								Case 51
									GoTo IL_903
								Case 52
									GoTo IL_62C
								Case 53
									GoTo IL_9A5
								Case 54
									GoTo IL_803
								Case 55, 75
									GoTo IL_505
								Case 57
									GoTo IL_A38
								Case 59
									GoTo IL_6BD
								Case 60
									GoTo IL_513
								Case 61
									GoTo IL_38E
								Case 62
									GoTo IL_46D
								Case 65
									GoTo IL_3E5
								Case 66
									GoTo IL_798
								Case 67
									GoTo IL_C0F
								Case 68
									GoTo IL_A2C
								Case 69
									GoTo IL_B52
								Case 70
									GoTo IL_C00
								Case 71
									GoTo IL_B74
								Case 72
									GoTo IL_4A5
								Case 73
									GoTo IL_AB5
								Case 74
									GoTo IL_C28
								Case 76
									GoTo IL_8CD
								Case 77
									GoTo IL_A34
								Case 78
									GoTo IL_5B5
								Case 79
									GoTo IL_9B8
								Case 80
									GoTo IL_9C4
								Case 81
									GoTo IL_7C3
								Case 82
									GoTo IL_461
								Case 83
									GoTo IL_8DD
								Case 84
									GoTo IL_9CD
								Case 85
									GoTo IL_A67
								Case 86
									GoTo IL_B2C
								Case 87
									GoTo IL_C16
								Case 88
									GoTo IL_58C
								Case 89
									GoTo IL_3A5
								Case 90
									GoTo IL_3CB
								Case 92
									GoTo IL_7A1
								Case 93
									GoTo IL_BF4
								Case 94
									GoTo IL_7EC
								Case 95
									GoTo IL_3E9
								Case 96
									GoTo IL_88E
								Case 97
									GoTo IL_A99
								Case 98
									GoTo IL_CDB
								Case 99
									GoTo IL_CFB
								Case 101
									GoTo IL_3DD
								Case 102
									GoTo IL_93E
								Case 103
									GoTo IL_55A
								Case 104
									GoTo IL_96A
								Case 105
									GoTo IL_A8D
								Case 106
									GoTo IL_425
								Case 107
									GoTo IL_CD3
								Case 109
									GoTo IL_AA4
								Case 110
									GoTo IL_CAC
								Case 113
									GoTo IL_580
								Case 114
									GoTo IL_788
								Case 115
									GoTo IL_6D4
								Case 116
									GoTo IL_652
								Case 118
									GoTo IL_6B6
								Case 119
									GoTo IL_70F
								Case 120
									GoTo IL_957
								Case 121
									GoTo IL_CA4
								Case 122
									GoTo IL_94B
								Case 123
									GoTo IL_4AD
								Case 124
									GoTo IL_790
								Case 125
									GoTo IL_C4E
								Case 126
									GoTo IL_6E0
								Case 128
									GoTo IL_CFF
								Case 130
									GoTo IL_810
								Case 131
									GoTo IL_5EC
								Case 132
									GoTo IL_686
								Case 133
									GoTo IL_A5F
								Case 134
									GoTo IL_BB3
								Case 135
									GoTo IL_4B1
								Case 136
									GoTo IL_569
								Case 137
									GoTo IL_B6C
								Case 138
									GoTo IL_318
								Case 139
									GoTo IL_976
								Case 141
									GoTo IL_8F7
								Case 142
									GoTo IL_A25
								Case 143
									GoTo IL_5F3
								Case 144
									GoTo IL_D21
								Case 145
									GoTo IL_534
								Case 146
									GoTo IL_469
								Case 147
									GoTo IL_695
								Case 149
									GoTo IL_5D1
								Case 151
									GoTo IL_CCA
								Case 152
									GoTo IL_C8F
								Case 153
									GoTo IL_B24
								Case 154
									GoTo IL_B30
								Case 155
									GoTo IL_8BA
								Case 156
									GoTo IL_C37
								Case 157
									GoTo IL_9DE
								Case 158
									GoTo IL_CB8
								Case 160
									GoTo IL_8EE
								Case 161
									GoTo IL_CB4
								Case 162
									GoTo IL_59E
								Case 163
									GoTo IL_5AE
								Case 164
									GoTo IL_416
								Case 165
									GoTo IL_886
								Case 166
									GoTo IL_6DC
								Case 167
									GoTo IL_5BB
								Case 169
									GoTo IL_B9A
								Case 170
									GoTo IL_D39
								Case 171
									GoTo IL_8AF
								Case 172
									GoTo IL_BA7
								Case 173
									GoTo IL_615
								Case 174
									GoTo IL_5DB
								Case 175
									GoTo IL_892
								Case 176
									GoTo IL_606
								Case 177
									GoTo IL_60E
							End Select
							GoTo Block_1
						End While
				End Select
			End While
		End While
		Block_1:
		Return
		IL_37F:
		Dim gdelegate As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate Is Nothing Then
			GoTo IL_D11
		End If
		IL_38E:
		gdelegate(Class10.String_42, Color.White, True)
		GoTo IL_D11
		IL_3A5:
		Dim gdelegate2 As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate2 Is Nothing Then
			GoTo IL_D11
		End If
		IL_3B4:
		gdelegate2(Class10.String_36, Color.Red, True)
		GoTo IL_D11
		IL_3CB:
		Me.bool_3 = False
		IL_3D2:
		If Not Me.bool_0 Then
			GoTo IL_461
		End If
		IL_3DD:
		Dim gdelegate3 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_3E5:
		If gdelegate3 Is Nothing Then
			GoTo IL_416
		End If
		IL_3E9:
		gdelegate3(String.Format(" PixieDust -SSID {0}  -BSSID {1}", Me.gclass9_0.SSID, Me.gclass9_0.BSSID), Color.White, True)
		IL_416:
		Dim gdelegate4 As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate4 Is Nothing Then
			GoTo IL_505
		End If
		IL_425:
		gdelegate4(String.Format(Class10.String_53, Me.gclass9_0.SSID, Me.gclass9_0.BSSID, DateAndTime.Now), Color.Yellow, True)
		GoTo IL_505
		IL_461:
		Dim gdelegate5 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_469:
		If gdelegate5 Is Nothing Then
			GoTo IL_4A5
		End If
		IL_46D:
		gdelegate5(String.Format(" WpsPin -PIN {0} -SSID {1}  -BSSID {2}", Me.gclass12_0.Pin, Me.gclass9_0.SSID, Me.gclass9_0.BSSID), Color.White, True)
		IL_4A5:
		Dim gdelegate6 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_4AD:
		If gdelegate6 Is Nothing Then
			GoTo IL_505
		End If
		IL_4B1:
		gdelegate6(String.Format(Class10.String_52, New Object() { Me.gclass12_0.Pin, Me.gclass9_0.SSID, Me.gclass9_0.BSSID, DateAndTime.Now }), Color.Yellow, True)
		IL_505:
		Me.genum1_0 = GClass8.GEnum1.Testing
		Me.genum2_0 = GClass8.GEnum2.None
		IL_513:
		Dim gdelegate7 As GClass8.GDelegate8 = Me.gdelegate8_0
		If gdelegate7 Is Nothing Then
			GoTo IL_D11
		End If
		IL_522:
		gdelegate7(Me.genum1_0)
		GoTo IL_D11
		IL_534:
		Dim gdelegate8 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_53C:
		If gdelegate8 Is Nothing Then
			GoTo IL_D11
		End If
		IL_543:
		gdelegate8(Class10.String_47, Color.LightGreen, True)
		GoTo IL_D11
		IL_55A:
		Dim gdelegate9 As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate9 Is Nothing Then
			GoTo IL_D11
		End If
		IL_569:
		gdelegate9(Class10.String_41, Color.Red, True)
		GoTo IL_D11
		IL_580:
		Dim gdelegate10 As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate10 Is Nothing Then
			GoTo IL_59E
		End If
		IL_58C:
		gdelegate10(Class10.String_48, Color.LightGreen, True)
		IL_59E:
		Me.ginterface0_0.imethod_0()
		GoTo IL_D11
		IL_5AE:
		Dim gdelegate11 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_5B5:
		If gdelegate11 Is Nothing Then
			GoTo IL_D11
		End If
		IL_5BB:
		gdelegate11(Class10.String_32, Color.LightGreen, True)
		GoTo IL_D11
		IL_5D1:
		Dim gdelegate12 As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate12 Is Nothing Then
			GoTo IL_5EC
		End If
		IL_5DB:
		gdelegate12(Class10.String_33, Color.Red, True)
		IL_5EC:
		Dim gdelegate13 As GClass8.GDelegate8 = Me.gdelegate8_0
		IL_5F3:
		If gdelegate13 Is Nothing Then
			GoTo IL_D11
		End If
		IL_5F9:
		gdelegate13(GClass8.GEnum1.AssociationFailed)
		GoTo IL_D11
		IL_606:
		Dim gdelegate14 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_60E:
		If gdelegate14 Is Nothing Then
			GoTo IL_D11
		End If
		IL_615:
		gdelegate14(Class10.String_49, Color.LightGreen, True)
		GoTo IL_D11
		IL_62C:
		Dim gdelegate15 As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate15 Is Nothing Then
			GoTo IL_D11
		End If
		IL_63B:
		gdelegate15(Class10.String_43, Color.Red, True)
		GoTo IL_D11
		IL_652:
		Dim gdelegate16 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_65A:
		If gdelegate16 Is Nothing Then
			GoTo IL_D11
		End If
		IL_661:
		gdelegate16(Class10.String_39, Color.Orange, True)
		GoTo IL_D11
		IL_678:
		If Me.genum1_0 <> GClass8.GEnum1.Testing Then
			GoTo IL_D11
		End If
		IL_686:
		Me.genum1_0 = GClass8.GEnum1.Success
		Dim gdelegate17 As GClass8.GDelegate8 = Me.gdelegate8_0
		IL_695:
		If gdelegate17 Is Nothing Then
			GoTo IL_D11
		End If
		IL_69C:
		gdelegate17(Me.genum1_0)
		GoTo IL_D11
		IL_6AE:
		Dim gdelegate18 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_6B6:
		If gdelegate18 Is Nothing Then
			GoTo IL_D11
		End If
		IL_6BD:
		gdelegate18(Class10.String_46, Color.Orange, True)
		GoTo IL_D11
		IL_6D4:
		Dim gdelegate19 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_6DC:
		If gdelegate19 Is Nothing Then
			GoTo IL_6FD
		End If
		IL_6E0:
		gdelegate19(Class10.String_50 + Class13.smethod_10(CType(int_1, GEnum16)), Color.AliceBlue, True)
		IL_6FD:
		If Not(int_1 >= 4 And int_1 <= 12) Then
			GoTo IL_716
		End If
		IL_70F:
		Me.genum16_0 = CType(int_1, GEnum16)
		IL_716:
		If Me.genum1_0 <> GClass8.GEnum1.Testing Then
			GoTo IL_788
		End If
		IL_71F:
		Dim ginterface5_ As GInterface5() = Me.gclass9_0.ginterface5_1
		Dim num4 As Integer = int_1
		Dim instance As Object = Me.ginterface7_0
		Dim type As Type = Nothing
		Dim memberName As String = "GetProtocolMsg"
		Dim array As Object() = New Object() { int_1 }
		Dim array2 As Object() = array
		Dim argumentNames As String() = Nothing
		Dim typeArguments As Type() = Nothing
		Dim array3 As Boolean() = New Boolean() { True }
		Dim array4 As Boolean() = array3
		Dim obj As Object = NewLateBinding.LateGet(instance, type, memberName, array, argumentNames, typeArguments, array3)
		If array4(0) Then
			int_1 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(Integer)))
		End If
		ginterface5_(num4) = CType(obj, GInterface5)
		IL_788:
		Dim num5 As Integer = int_1
		IL_78B:
		If num5 = 4 Then
			GoTo IL_7C3
		End If
		IL_790:
		If num5 <> 14 Then
			GoTo IL_7F4
		End If
		IL_798:
		If Me.genum1_0 <> GClass8.GEnum1.Testing Then
			GoTo IL_7F4
		End If
		IL_7A1:
		Me.genum1_0 = GClass8.GEnum1.NACK
		Dim gdelegate20 As GClass8.GDelegate8 = Me.gdelegate8_0
		If gdelegate20 Is Nothing Then
			GoTo IL_7F4
		End If
		IL_7B4:
		gdelegate20(Me.genum1_0)
		GoTo IL_7F4
		IL_7C3:
		Me.gclass9_0.method_2(Me.gclass9_0.ginterface5_1(int_1), GEnum16.JswMsgType_M1)
		Dim gdelegate21 As GClass8.GDelegate8 = Me.gdelegate8_0
		If gdelegate21 Is Nothing Then
			GoTo IL_7F4
		End If
		IL_7EC:
		gdelegate21(GClass8.GEnum1.Updated)
		IL_7F4:
		Dim gdelegate22 As GClass8.GDelegate7 = Me.gdelegate7_0
		IL_7FC:
		If gdelegate22 Is Nothing Then
			GoTo IL_D11
		End If
		IL_803:
		gdelegate22(CType(int_1, GEnum16))
		GoTo IL_D11
		IL_810:
		Dim ginterface5_2 As GInterface5() = Me.gclass9_0.ginterface5_1
		Dim num6 As Integer = int_1
		Dim instance2 As Object = Me.ginterface7_0
		Dim type2 As Type = Nothing
		Dim memberName2 As String = "GetProtocolMsg"
		Dim array5 As Object() = New Object() { int_1 }
		array2 = array5
		Dim argumentNames2 As String() = Nothing
		Dim typeArguments2 As Type() = Nothing
		Dim array6 As Boolean() = New Boolean() { True }
		array4 = array6
		Dim obj2 As Object = NewLateBinding.LateGet(instance2, type2, memberName2, array5, argumentNames2, typeArguments2, array6)
		If array4(0) Then
			int_1 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(Integer)))
		End If
		ginterface5_2(num6) = CType(obj2, GInterface5)
		If Me.bool_0 And int_1 = 8 Then
			GoTo IL_8AF
		End If
		IL_886:
		Dim gdelegate23 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_88E:
		If gdelegate23 Is Nothing Then
			GoTo IL_8AF
		End If
		IL_892:
		gdelegate23(Class10.String_51 + Class13.smethod_10(CType(int_1, GEnum16)), Color.AliceBlue, True)
		IL_8AF:
		Dim num7 As Integer = int_1
		If num7 = 8 Then
			GoTo IL_BD2
		End If
		IL_8BA:
		If num7 = 14 Then
			GoTo IL_8CD
		End If
		IL_8C2:
		If num7 <> 15 Then
			GoTo IL_D11
		End If
		IL_8CD:
		Dim genum As GEnum16 = Me.genum16_0
		IL_8D5:
		If genum < GEnum16.JswMsgType_M3 Then
			GoTo IL_BC6
		End If
		IL_8DD:
		If genum = GEnum16.JswMsgType_M3 Then
			GoTo IL_B5E
		End If
		IL_8E5:
		If genum <> GEnum16.JswMsgType_M5 Then
			GoTo IL_9C4
		End If
		IL_8EE:
		If Me.genum1_0 <> GClass8.GEnum1.NACK Then
			GoTo IL_96A
		End If
		IL_8F7:
		Dim gdelegate24 As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate24 Is Nothing Then
			GoTo IL_93E
		End If
		IL_903:
		gdelegate24(String.Format(Class10.String_37, Me.gclass12_0.Pin.Substring(0, 4), Me.gclass12_0.Pin.Substring(4, 4)), Color.Orange, True)
		IL_93E:
		If Me.gclass9_0.Status <> GClass9.GEnum3.Unknow Then
			GoTo IL_957
		End If
		IL_94B:
		Me.gclass9_0.Status = GClass9.GEnum3.Nok
		IL_957:
		Me.genum2_0 = GClass8.GEnum2.fHalfOk
		Me.method_10(True)
		GoTo IL_D11
		IL_96A:
		Dim gdelegate25 As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate25 Is Nothing Then
			GoTo IL_998
		End If
		IL_976:
		gdelegate25(String.Format(Class10.String_34, Me.gclass12_0.Pin), Color.Red, True)
		IL_998:
		If Me.gclass9_0.Status <> GClass9.GEnum3.Unknow Then
			GoTo IL_9B1
		End If
		IL_9A5:
		Me.gclass9_0.Status = GClass9.GEnum3.Nok
		IL_9B1:
		Me.genum2_0 = GClass8.GEnum2.Nok
		IL_9B8:
		Me.method_10(True)
		GoTo IL_D11
		IL_9C4:
		If genum <> GEnum16.JswMsgType_M7 Then
			GoTo IL_A99
		End If
		IL_9CD:
		Me.gclass9_0.Pin = Me.gclass12_0
		IL_9DE:
		Dim ginterface As GInterface5 = CType(Me.gclass9_0.ginterface5_1(11).imethod_0(GEnum9.JswAttr_EncryptedSettings), GInterface5)
		Me.gclass9_0.NetworkKey = Conversions.ToString(ginterface.imethod_0(GEnum9.JswAttr_NetworkKey))
		IL_A19:
		Me.gclass9_0.Status = GClass9.GEnum3.Ok
		IL_A25:
		Me.genum2_0 = GClass8.GEnum2.Ok
		IL_A2C:
		Dim gdelegate26 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_A34:
		If gdelegate26 Is Nothing Then
			GoTo IL_A5F
		End If
		IL_A38:
		gdelegate26(Class10.String_54 + Me.gclass9_0.Pin.Pin, Color.Lime, True)
		IL_A5F:
		Dim gdelegate27 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_A67:
		If gdelegate27 Is Nothing Then
			GoTo IL_A8D
		End If
		IL_A6B:
		gdelegate27(Class10.String_40 + Me.gclass9_0.NetworkKey, Color.Lime, True)
		IL_A8D:
		Me.method_10(True)
		GoTo IL_D11
		IL_A99:
		If genum <> GEnum16.JswMsgType_M8 Then
			GoTo IL_D11
		End If
		IL_AA4:
		Me.gclass9_0.Pin = Me.gclass12_0
		IL_AB5:
		Dim ginterface2 As GInterface5 = CType(NewLateBinding.LateGet(Me.gclass9_0.ginterface5_1(12).imethod_0(GEnum9.JswAttr_EncryptedSettings), Nothing, "GetItem", New Object() { GEnum9.JswAttr_Credential }, Nothing, Nothing, Nothing), GInterface5)
		IL_AF5:
		Me.gclass9_0.NetworkKey = Conversions.ToString(ginterface2.imethod_0(GEnum9.JswAttr_NetworkKey))
		Me.gclass9_0.Status = GClass9.GEnum3.Ok
		IL_B1D:
		Me.genum2_0 = GClass8.GEnum2.Ok
		IL_B24:
		Dim gdelegate28 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_B2C:
		If gdelegate28 Is Nothing Then
			GoTo IL_B52
		End If
		IL_B30:
		gdelegate28(Class10.String_40 + Me.gclass9_0.NetworkKey, Color.Lime, True)
		IL_B52:
		Me.method_10(True)
		GoTo IL_D11
		IL_B5E:
		If Me.genum1_0 <> GClass8.GEnum1.NACK Then
			GoTo IL_D11
		End If
		IL_B6C:
		Dim gdelegate29 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_B74:
		If gdelegate29 Is Nothing Then
			GoTo IL_B9A
		End If
		IL_B78:
		gdelegate29(String.Format(Class10.String_38, Me.gclass12_0.Pin), Color.Red, True)
		IL_B9A:
		If Me.gclass9_0.Status <> GClass9.GEnum3.Unknow Then
			GoTo IL_BB3
		End If
		IL_BA7:
		Me.gclass9_0.Status = GClass9.GEnum3.Nok
		IL_BB3:
		Me.genum2_0 = GClass8.GEnum2.Nok
		Me.method_10(True)
		GoTo IL_D11
		IL_BC6:
		Me.genum2_0 = GClass8.GEnum2.Fault
		GoTo IL_D11
		IL_BD2:
		If Not(Me.bool_0 And Me.genum1_0 = GClass8.GEnum1.Testing) Then
			GoTo IL_D11
		End If
		IL_BE7:
		If Me.gclass9_0.Status <> GClass9.GEnum3.Unknow Then
			GoTo IL_C00
		End If
		IL_BF4:
		Me.gclass9_0.Status = GClass9.GEnum3.Nok
		IL_C00:
		Me.genum1_0 = GClass8.GEnum1.PixieSucced
		Dim gdelegate30 As GClass8.GDelegate8 = Me.gdelegate8_0
		IL_C0F:
		If gdelegate30 Is Nothing Then
			GoTo IL_D11
		End If
		IL_C16:
		gdelegate30(Me.genum1_0)
		GoTo IL_D11
		IL_C28:
		Dim gdelegate31 As GClass8.GDelegate6 = Me.gdelegate6_0
		If gdelegate31 Is Nothing Then
			GoTo IL_D11
		End If
		IL_C37:
		gdelegate31(Class10.String_44, Color.Red, True)
		GoTo IL_D11
		IL_C4E:
		Dim gdelegate32 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_C56:
		If gdelegate32 Is Nothing Then
			GoTo IL_C87
		End If
		IL_C5A:
		gdelegate32(String.Format(Class10.String_31, Me.gclass9_0.BSSID, Me.gclass9_0.SSID), Color.Red, True)
		IL_C87:
		Dim gdelegate33 As GClass8.GDelegate8 = Me.gdelegate8_0
		IL_C8F:
		If gdelegate33 Is Nothing Then
			GoTo IL_C9B
		End If
		IL_C93:
		gdelegate33(GClass8.GEnum1.Locked)
		IL_C9B:
		Me.method_10(True)
		GoTo IL_D11
		IL_CA4:
		If Me.bool_3 Then
			GoTo IL_D11
		End If
		IL_CAC:
		Dim gdelegate34 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_CB4:
		If gdelegate34 Is Nothing Then
			GoTo IL_CCA
		End If
		IL_CB8:
		gdelegate34(Class13.string_4, Color.LightGreen, False)
		IL_CCA:
		Me.bool_3 = True
		GoTo IL_D11
		IL_CD3:
		Dim gdelegate35 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_CDB:
		If gdelegate35 Is Nothing Then
			GoTo IL_D11
		End If
		IL_CDF:
		gdelegate35(Class10.String_35, Color.Red, True)
		GoTo IL_D11
		IL_CF3:
		Dim gdelegate36 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_CFB:
		If gdelegate36 Is Nothing Then
			GoTo IL_D11
		End If
		IL_CFF:
		gdelegate36(Class10.String_45, Color.Orange, True)
		IL_D11:
		If Me.bool_0 And int_1 = 8 Then
			Return
		End If
		IL_D21:
		If Not(int_1 <> 0 And Me.bool_2) Then
			Return
		End If
		IL_D31:
		Dim gdelegate37 As GClass8.GDelegate6 = Me.gdelegate6_0
		IL_D39:
		If gdelegate37 Is Nothing Then
			Return
		End If
		IL_D40:
		Dim gdelegate38 As GClass8.GDelegate6 = gdelegate37
		Dim instance3 As Object = Me.ginterface7_0
		Dim type3 As Type = Nothing
		Dim memberName3 As String = "GetProtocolMsg"
		Dim array7 As Object() = New Object() { int_1 }
		array2 = array7
		Dim argumentNames3 As String() = Nothing
		Dim typeArguments3 As Type() = Nothing
		Dim array8 As Boolean() = New Boolean() { True }
		array4 = array8
		Dim instance4 As Object = NewLateBinding.LateGet(instance3, type3, memberName3, array7, argumentNames3, typeArguments3, array8)
		If array4(0) Then
			int_1 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(Integer)))
		End If
		gdelegate38(Class13.smethod_12(Conversions.ToString(NewLateBinding.LateGet(instance4, Nothing, "OutputToString", New Object(-1) {}, Nothing, Nothing, Nothing))), Color.Gray, True)
	End Sub

	' Token: 0x040000EC RID: 236
	Private ginterface3_0 As GInterface3

	' Token: 0x040000ED RID: 237
	Private ginterface2_0 As GInterface2

	' Token: 0x040000EE RID: 238
	Private int_0 As Integer

	' Token: 0x040000EF RID: 239
	Public list_0 As List(Of GInterface1)

	' Token: 0x040000F0 RID: 240
	Private ginterface0_0 As GInterface0

	' Token: 0x040000F1 RID: 241
	Private ginterface7_0 As GInterface7

	' Token: 0x040000F2 RID: 242
	<CompilerGenerated()>
	<AccessedThroughProperty("engineListener")>
	Private gclass7_0 As GClass7

	' Token: 0x040000F3 RID: 243
	Private bool_0 As Boolean

	' Token: 0x040000F4 RID: 244
	Private gclass9_0 As GClass9

	' Token: 0x040000F5 RID: 245
	Private gclass12_0 As GClass12

	' Token: 0x040000F6 RID: 246
	Public string_0 As String

	' Token: 0x040000F7 RID: 247
	Private bool_1 As Boolean

	' Token: 0x040000F8 RID: 248
	Private genum1_0 As GClass8.GEnum1

	' Token: 0x040000F9 RID: 249
	Public genum2_0 As GClass8.GEnum2

	' Token: 0x040000FA RID: 250
	Public genum16_0 As GEnum16

	' Token: 0x040000FB RID: 251
	Public bool_2 As Boolean

	' Token: 0x040000FC RID: 252
	<CompilerGenerated()>
	Private gdelegate6_0 As GClass8.GDelegate6

	' Token: 0x040000FD RID: 253
	<CompilerGenerated()>
	Private gdelegate7_0 As GClass8.GDelegate7

	' Token: 0x040000FE RID: 254
	<CompilerGenerated()>
	Private gdelegate8_0 As GClass8.GDelegate8

	' Token: 0x040000FF RID: 255
	<CompilerGenerated()>
	Private delegate0_0 As GClass8.Delegate0

	' Token: 0x04000100 RID: 256
	Private bool_3 As Boolean

	' Token: 0x0200001E RID: 30
	' (Invoke) Token: 0x060002BF RID: 703
	Public Delegate Sub GDelegate6(message As String, color As Color, autoCrLf As Boolean)

	' Token: 0x0200001F RID: 31
	' (Invoke) Token: 0x060002C3 RID: 707
	Public Delegate Sub GDelegate7(MessageType As GEnum16)

	' Token: 0x02000020 RID: 32
	' (Invoke) Token: 0x060002C7 RID: 711
	Public Delegate Sub GDelegate8(Status As GClass8.GEnum1)

	' Token: 0x02000021 RID: 33
	' (Invoke) Token: 0x060002CB RID: 715
	Private Delegate Sub Delegate0()

	' Token: 0x02000022 RID: 34
	Public Enum GEnum1
		' Token: 0x04000102 RID: 258
		[Stop]
		' Token: 0x04000103 RID: 259
		Start
		' Token: 0x04000104 RID: 260
		Testing
		' Token: 0x04000105 RID: 261
		Success = 4
		' Token: 0x04000106 RID: 262
		NACK
		' Token: 0x04000107 RID: 263
		Updated
		' Token: 0x04000108 RID: 264
		Locked
		' Token: 0x04000109 RID: 265
		PixieSucced
		' Token: 0x0400010A RID: 266
		ApNotFound
		' Token: 0x0400010B RID: 267
		AssociationFailed
	End Enum

	' Token: 0x02000023 RID: 35
	Public Enum GEnum2
		' Token: 0x0400010D RID: 269
		None
		' Token: 0x0400010E RID: 270
		Nok
		' Token: 0x0400010F RID: 271
		Ok
		' Token: 0x04000110 RID: 272
		fHalfOk
		' Token: 0x04000111 RID: 273
		Fault
	End Enum
End Class
