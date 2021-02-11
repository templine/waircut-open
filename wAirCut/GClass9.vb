Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.SQLite
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

' Token: 0x02000024 RID: 36
Public Class GClass9
	Implements INotifyPropertyChanged

	' Token: 0x14000009 RID: 9
	' (add) Token: 0x060002CC RID: 716 RVA: 0x000102E4 File Offset: 0x0000E4E4
	' (remove) Token: 0x060002CD RID: 717 RVA: 0x0001031C File Offset: 0x0000E51C
	Custom Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		<CompilerGenerated()>
		AddHandler
			Dim propertyChangedEventHandler As PropertyChangedEventHandler = Me.propertyChangedEventHandler_0
			Dim propertyChangedEventHandler2 As PropertyChangedEventHandler
			Do
				propertyChangedEventHandler2 = propertyChangedEventHandler
				Dim value2 As PropertyChangedEventHandler = CType([Delegate].Combine(propertyChangedEventHandler2, value), PropertyChangedEventHandler)
				propertyChangedEventHandler = Interlocked.CompareExchange(Of PropertyChangedEventHandler)(Me.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2)
			Loop While propertyChangedEventHandler IsNot propertyChangedEventHandler2
		End AddHandler
		<CompilerGenerated()>
		RemoveHandler
			Dim propertyChangedEventHandler As PropertyChangedEventHandler = Me.propertyChangedEventHandler_0
			Dim propertyChangedEventHandler2 As PropertyChangedEventHandler
			Do
				propertyChangedEventHandler2 = propertyChangedEventHandler
				Dim value2 As PropertyChangedEventHandler = CType([Delegate].Remove(propertyChangedEventHandler2, value), PropertyChangedEventHandler)
				propertyChangedEventHandler = Interlocked.CompareExchange(Of PropertyChangedEventHandler)(Me.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2)
			Loop While propertyChangedEventHandler IsNot propertyChangedEventHandler2
		End RemoveHandler
	End Event

	' Token: 0x060002CE RID: 718 RVA: 0x00010354 File Offset: 0x0000E554
	Public Sub New(ByRef ginterface5_2 As GInterface5)
		Me.ginterface5_1 = New GInterface5(16) {}
		Me.string_0 = ""
		Me.string_1 = ""
		Me.string_2 = ""
		Me.string_3 = ""
		Me.string_4 = ""
		Me.string_5 = ""
		Me.string_6 = ""
		Me.string_7 = ""
		Me.bool_0 = False
		Me.string_8 = ""
		Me.string_9 = ""
		Me.string_10 = ""
		Me.string_11 = ""
		Me.int_0 = 0
		Me.string_12 = ""
		Me.gclass15_0 = New GClass15(Of GClass12)()
		Me.bool_1 = False
		Me.string_13 = ""
		Me.gclass12_0 = New GClass12()
		Me.string_14 = ""
		Me.string_15 = ""
		Me.string_20 = ""
		Me.genum3_0 = GClass9.GEnum3.Unknow
		Me.genum4_0 = GClass9.GEnum4.[Nothing]
		Me.bool_2 = False
		Me.sqliteConnection_0 = New SQLiteConnection("Data Source=Bd\WpsPin.db;Version=3;")
		Me.sqliteConnection_1 = New SQLiteConnection("Data Source=Bd\WpsProbePin.db;Version=3;")
		Me.sqliteConnection_2 = New SQLiteConnection("Data Source=Bd\ApLog.db;Version=3;")
		Me.method_3(ginterface5_2)
		Me.method_10()
		Me.method_0()
	End Sub

	' Token: 0x060002CF RID: 719 RVA: 0x000104B4 File Offset: 0x0000E6B4
	Private Sub method_0()
		Me.method_9()
		Try
			For Each gclass As GClass12 In Me.gclass15_0
				If gclass.genum0_0 = GClass3.GEnum0.[Nothing] Then
					Dim count As Integer = Me.gclass15_0.Count
					If count = 0 Then
						Me.genum4_0 = GClass9.GEnum4.[Nothing]
					ElseIf count = 1 Then
						Me.genum4_0 = GClass9.GEnum4.[Single]
					ElseIf count > 1 Then
						Me.genum4_0 = GClass9.GEnum4.Several
					End If
				Else
					Me.genum4_0 = GClass9.GEnum4.Algorithm
				End If
				If gclass.gclass11_0.bool_0 Then
					Me.bool_1 = True
				End If
			Next
		Finally
			Dim enumerator As IEnumerator(Of GClass12)
			If enumerator IsNot Nothing Then
				enumerator.Dispose()
			End If
		End Try
		If Operators.CompareString(Me.gclass12_0.Pin, "", False) <> 0 AndAlso Not Me.gclass15_0.Contains(Me.gclass12_0) Then
			Me.gclass15_0.Add(Me.gclass12_0)
		End If
	End Sub

	' Token: 0x060002D0 RID: 720 RVA: 0x00003FD5 File Offset: 0x000021D5
	Public Sub method_1(ginterface5_2 As GInterface5)
		Me.bool_0 = Operators.ConditionalCompareObjectEqual(Me.method_7(ginterface5_2, GEnum9.JswAttr_ConfigurationError), GEnum10.JswConfigError_SetupLocked, False)
	End Sub

	' Token: 0x060002D1 RID: 721 RVA: 0x00010594 File Offset: 0x0000E794
	Public Sub method_2(ByRef ginterface5_2 As GInterface5, genum16_0 As GEnum16)
		Try
			Dim flag As Boolean = Me.bool_2
			If genum16_0 = GEnum16.JswMsgType_Beacon Then
				Me.method_3(ginterface5_2)
			ElseIf genum16_0 = GEnum16.JswMsgType_M1 Then
				Me.method_4(ginterface5_2)
			End If
			If Not flag And Me.bool_2 Then
				Me.gclass15_0.Clear()
				Me.method_0()
			End If
			Dim propertyChangedEventHandler As PropertyChangedEventHandler = Me.propertyChangedEventHandler_0
			If propertyChangedEventHandler IsNot Nothing Then
				propertyChangedEventHandler(Me, New PropertyChangedEventArgs(Me.BSSID))
			End If
		Catch ex As Exception
		End Try
	End Sub

	' Token: 0x060002D2 RID: 722 RVA: 0x00010620 File Offset: 0x0000E820
	Private Sub method_3(ByRef ginterface5_2 As GInterface5)
		Me.ginterface5_0 = ginterface5_2
		Try
			Me.string_8 = Conversions.ToString(Me.method_7(ginterface5_2, GEnum9.JswAttr_MACAddress))
			Me.string_11 = Me.method_7(ginterface5_2, GEnum9.JswAttr_SSID).ToString()
			If Me.int_0 = 0 Then
				Me.int_0 = Conversions.ToInteger(Me.method_7(ginterface5_2, GEnum9.JswAttr_Rssi))
			Else
				Me.int_0 = Conversions.ToInteger(Operators.DivideObject(Operators.AddObject(Me.int_0, Me.method_7(ginterface5_2, GEnum9.JswAttr_Rssi)), 2))
			End If
			Me.string_12 = Conversions.ToString(Me.method_7(ginterface5_2, GEnum9.JswAttr_APChannel))
			If Operators.CompareString(Me.string_9, "", False) = 0 Then
				Me.string_9 = Conversions.ToString(Operators.ConcatenateObject(Me.method_7(ginterface5_2, GEnum9.JswAttr_AuthenticationTypeFlags), Me.method_7(ginterface5_2, GEnum9.JswAttr_EncryptionTypeFlags)))
			End If
			Dim ginterface As GInterface5 = CType(ginterface5_2.imethod_0(GEnum9.JswAttr_SimpleConfigIEs), GInterface5)
			If Operators.CompareString(Me.string_0, "", False) = 0 Then
				Me.string_0 = Conversions.ToString(Me.method_7(ginterface, GEnum9.JswAttr_DeviceName))
			End If
			If Operators.CompareString(Me.string_1, "", False) = 0 Then
				Me.string_1 = Conversions.ToString(Me.method_7(ginterface, GEnum9.JswAttr_Manufacturer))
			End If
			If Operators.CompareString(Me.string_2, "", False) = 0 Then
				Me.string_2 = Conversions.ToString(Me.method_7(ginterface, GEnum9.JswAttr_ModelName))
			End If
			If Operators.CompareString(Me.string_3, "", False) = 0 Then
				Me.string_3 = Conversions.ToString(Me.method_7(ginterface, GEnum9.JswAttr_ModelNumber))
			End If
			If Operators.CompareString(Me.SerialNumber, "", False) = 0 Then
				Me.string_4 = Conversions.ToString(Me.method_7(ginterface, GEnum9.JswAttr_SerialNumber))
			End If
			If Operators.CompareString(Me.string_5, "", False) = 0 Then
				Me.string_5 = Conversions.ToString(Me.method_7(ginterface, GEnum9.JswAttr_RFBand))
			End If
			If Operators.CompareString(Me.string_6, "", False) = 0 Then
				Me.string_6 = Conversions.ToString(Me.method_7(ginterface, GEnum9.JswAttr_UUID_E))
			End If
			If Operators.CompareString(Me.string_7, "", False) = 0 Then
				Me.string_7 = Conversions.ToString(Me.method_7(ginterface, GEnum9.JswAttr_Version))
			End If
			Dim ginterface2 As GInterface5 = CType(Me.method_7(ginterface, GEnum9.JswAttr_VendorExtension), GInterface5)
			Me.method_5(ginterface2)
			Me.bool_0 = Conversions.ToBoolean(Me.method_7(ginterface, GEnum9.JswAttr_APSetupLocked))
			If Operators.CompareString(Me.string_10, "", False) = 0 Then
				Me.string_10 = Conversions.ToString(Me.method_7(ginterface, GEnum9.JswAttr_ConfigMethods))
			End If
			Me.bool_2 = (Operators.CompareString(Me.string_0, "", False) <> 0 And Operators.CompareString(Me.string_1, "", False) <> 0 And Operators.CompareString(Me.string_2, "", False) <> 0 And Operators.CompareString(Me.SerialNumber, "", False) <> 0)
		Catch ex As Exception
		End Try
	End Sub

	' Token: 0x060002D3 RID: 723 RVA: 0x00010958 File Offset: 0x0000EB58
	Private Sub method_4(ByRef ginterface5_2 As GInterface5)
		Me.string_1 = Conversions.ToString(Me.method_7(ginterface5_2, GEnum9.JswAttr_Manufacturer))
		Me.string_2 = Conversions.ToString(Me.method_7(ginterface5_2, GEnum9.JswAttr_ModelName))
		Me.string_3 = Conversions.ToString(Me.method_7(ginterface5_2, GEnum9.JswAttr_ModelNumber))
		Me.string_4 = Conversions.ToString(Me.method_7(ginterface5_2, GEnum9.JswAttr_SerialNumber))
		Me.string_0 = Conversions.ToString(Me.method_7(ginterface5_2, GEnum9.JswAttr_DeviceName))
		Me.string_5 = Conversions.ToString(Me.method_7(ginterface5_2, GEnum9.JswAttr_RFBand))
		Me.string_6 = Conversions.ToString(Me.method_7(ginterface5_2, GEnum9.JswAttr_UUID_E))
		Me.string_10 = Conversions.ToString(Me.method_7(ginterface5_2, GEnum9.JswAttr_ConfigMethods))
		Me.bool_0 = Operators.ConditionalCompareObjectEqual(Me.method_7(ginterface5_2, GEnum9.JswAttr_ConfigurationError), GEnum10.JswConfigError_SetupLocked, False)
		Me.bool_2 = True
	End Sub

	' Token: 0x060002D4 RID: 724 RVA: 0x00010A44 File Offset: 0x0000EC44
	Private Sub method_5(ByRef ginterface5_2 As GInterface5)
		If ginterface5_2.imethod_1() <> 0 AndAlso Operators.ConditionalCompareObjectEqual(ginterface5_2.imethod_0(GEnum9.JswAttr_VendorExtID), 14122, False) Then
			Dim array As Byte() = New Byte(1024) {}
			array = CType(ginterface5_2.imethod_0(GEnum9.JswAttr_Data), Byte())
			If array(0) = 0 Then
				Dim num As Integer = Conversions.ToInteger(Conversion.Hex(array(2)))
				Me.string_7 = String.Format("{0}.{1}", CDbl(num) / 10.0, CDbl(num) - CDbl(num) / 10.0 * 10.0)
			End If
		End If
	End Sub

	' Token: 0x1700013C RID: 316
	' (get) Token: 0x060002D5 RID: 725 RVA: 0x00010AF0 File Offset: 0x0000ECF0
	' (set) Token: 0x060002D6 RID: 726 RVA: 0x00003FF7 File Offset: 0x000021F7
	Public Property SerialNumber As String
		Get
			Dim result As String
			If Not Class13.bool_1 Then
				result = Me.string_4
			Else
				result = Class13.smethod_13(Me.string_4, "X")
			End If
			Return result
		End Get
		Set(value As String)
			Me.string_4 = value
		End Set
	End Property

	' Token: 0x1700013D RID: 317
	' (get) Token: 0x060002D7 RID: 727 RVA: 0x00010B20 File Offset: 0x0000ED20
	' (set) Token: 0x060002D8 RID: 728 RVA: 0x00004000 File Offset: 0x00002200
	Public Property UUID As String
		Get
			Dim result As String
			If Not Class13.bool_1 Then
				result = Me.string_6
			Else
				result = Class13.smethod_13(Me.string_6, "X")
			End If
			Return result
		End Get
		Set(value As String)
			Me.string_6 = value
		End Set
	End Property

	' Token: 0x1700013E RID: 318
	' (get) Token: 0x060002D9 RID: 729 RVA: 0x00004009 File Offset: 0x00002209
	Public ReadOnly Property Version As String
		Get
			Return Me.string_7
		End Get
	End Property

	' Token: 0x1700013F RID: 319
	' (get) Token: 0x060002DA RID: 730 RVA: 0x00010B50 File Offset: 0x0000ED50
	Public ReadOnly Property BSSID As String
		Get
			Dim result As String
			If Not Class13.bool_1 Then
				result = Me.string_8
			Else
				result = Me.string_8.Substring(0, 9) + "XX:XX:XX"
			End If
			Return result
		End Get
	End Property

	' Token: 0x17000140 RID: 320
	' (get) Token: 0x060002DB RID: 731 RVA: 0x00010B88 File Offset: 0x0000ED88
	Public ReadOnly Property SSID As String
		Get
			Dim result As String
			If Not Class13.bool_1 Then
				result = Me.string_11
			Else
				result = Class13.smethod_13(Me.string_11, "?")
			End If
			Return result
		End Get
	End Property

	' Token: 0x17000141 RID: 321
	' (get) Token: 0x060002DC RID: 732 RVA: 0x00004011 File Offset: 0x00002211
	Public ReadOnly Property Channel As String
		Get
			Return Me.string_12
		End Get
	End Property

	' Token: 0x17000142 RID: 322
	' (get) Token: 0x060002DD RID: 733 RVA: 0x00004019 File Offset: 0x00002219
	Public ReadOnly Property RSSI As String
		Get
			Return Me.int_0.ToString()
		End Get
	End Property

	' Token: 0x17000143 RID: 323
	' (get) Token: 0x060002DE RID: 734 RVA: 0x00004026 File Offset: 0x00002226
	Public ReadOnly Property ApSetupLocked As Boolean
		Get
			Return Me.bool_0
		End Get
	End Property

	' Token: 0x17000144 RID: 324
	' (get) Token: 0x060002DF RID: 735 RVA: 0x0000402E File Offset: 0x0000222E
	' (set) Token: 0x060002E0 RID: 736 RVA: 0x00004036 File Offset: 0x00002236
	Public Property Status As GClass9.GEnum3
		Get
			Return Me.genum3_0
		End Get
		Set(value As GClass9.GEnum3)
			Me.genum3_0 = value
			If Me.method_13() Then
				Me.method_12()
				Return
			End If
			Me.method_11()
		End Set
	End Property

	' Token: 0x17000145 RID: 325
	' (get) Token: 0x060002E1 RID: 737 RVA: 0x00004054 File Offset: 0x00002254
	Public ReadOnly Property PinStatus As GClass9.GEnum4
		Get
			Return Me.genum4_0
		End Get
	End Property

	' Token: 0x17000146 RID: 326
	' (get) Token: 0x060002E2 RID: 738 RVA: 0x00010BB8 File Offset: 0x0000EDB8
	' (set) Token: 0x060002E3 RID: 739 RVA: 0x0000405C File Offset: 0x0000225C
	Public Property NetworkKey As String
		Get
			Dim result As String
			If Not Class13.bool_1 Then
				result = Me.string_13
			Else
				result = Class13.smethod_13(Me.string_13, "X")
			End If
			Return result
		End Get
		Set(value As String)
			Me.string_13 = value
		End Set
	End Property

	' Token: 0x17000147 RID: 327
	' (get) Token: 0x060002E4 RID: 740 RVA: 0x00004065 File Offset: 0x00002265
	Public ReadOnly Property PKE As String
		Get
			If Me.ginterface5_1(4) IsNot Nothing Then
				Me.string_14 = Class13.smethod_8(CType(Me.ginterface5_1(4).imethod_0(GEnum9.JswAttr_PublicKey), Array), ":")
			End If
			Return Me.string_14
		End Get
	End Property

	' Token: 0x17000148 RID: 328
	' (get) Token: 0x060002E5 RID: 741 RVA: 0x0000409E File Offset: 0x0000229E
	Public ReadOnly Property PKR As String
		Get
			If Me.ginterface5_1(4) IsNot Nothing Then
				Me.string_15 = Class13.smethod_8(CType(Me.ginterface5_1(5).imethod_0(GEnum9.JswAttr_PublicKey), Array), ":")
			End If
			Return Me.string_15
		End Get
	End Property

	' Token: 0x17000149 RID: 329
	' (get) Token: 0x060002E6 RID: 742 RVA: 0x000040D7 File Offset: 0x000022D7
	Public ReadOnly Property E_HAS1 As String
		Get
			If Me.ginterface5_1(4) IsNot Nothing Then
				Me.string_16 = Class13.smethod_8(CType(Me.ginterface5_1(7).imethod_0(GEnum9.JswAttr_E_Hash1), Array), ":")
			End If
			Return Me.string_16
		End Get
	End Property

	' Token: 0x1700014A RID: 330
	' (get) Token: 0x060002E7 RID: 743 RVA: 0x00004110 File Offset: 0x00002310
	Public ReadOnly Property E_HAS2 As String
		Get
			If Me.ginterface5_1(4) IsNot Nothing Then
				Me.string_17 = Class13.smethod_8(CType(Me.ginterface5_1(7).imethod_0(GEnum9.JswAttr_E_Hash2), Array), ":")
			End If
			Return Me.string_17
		End Get
	End Property

	' Token: 0x1700014B RID: 331
	' (get) Token: 0x060002E8 RID: 744 RVA: 0x00004149 File Offset: 0x00002349
	Public ReadOnly Property E_NONCE As String
		Get
			If Me.ginterface5_1(4) IsNot Nothing Then
				Me.string_18 = Class13.smethod_8(CType(Me.ginterface5_1(4).imethod_0(GEnum9.JswAttr_EnrolleeNonce), Array), ":")
			End If
			Return Me.string_18
		End Get
	End Property

	' Token: 0x1700014C RID: 332
	' (get) Token: 0x060002E9 RID: 745 RVA: 0x00004182 File Offset: 0x00002382
	Public ReadOnly Property R_NONCE As String
		Get
			If Me.ginterface5_1(4) IsNot Nothing Then
				Me.string_19 = Class13.smethod_8(CType(Me.ginterface5_1(5).imethod_0(GEnum9.JswAttr_RegistrarNonce), Array), ":")
			End If
			Return Me.string_19
		End Get
	End Property

	' Token: 0x1700014D RID: 333
	' (get) Token: 0x060002EA RID: 746 RVA: 0x00010BE8 File Offset: 0x0000EDE8
	Public ReadOnly Property AuthKey As String
		Get
			Dim result As String
			If Me.ginterface5_1(5) IsNot Nothing Then
				Dim ginterface As GInterface5 = CType(Me.ginterface5_1(5).imethod_0(GEnum9.JswAttr_VendorExtension), GInterface5)
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.method_7(ginterface, GEnum9.JswAttr_Data))
				Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Me.method_7(Me.ginterface5_1(5), GEnum9.JswAttr_PublicKey))
				result = Class13.smethod_9(CType(objectValue, Array), CType(objectValue2, Array))
			Else
				result = ""
			End If
			Return result
		End Get
	End Property

	' Token: 0x1700014E RID: 334
	' (get) Token: 0x060002EB RID: 747 RVA: 0x000041BB File Offset: 0x000023BB
	' (set) Token: 0x060002EC RID: 748 RVA: 0x000041C3 File Offset: 0x000023C3
	Public Property Pin As GClass12
		Get
			Return Me.gclass12_0
		End Get
		Set(value As GClass12)
			Me.gclass12_0 = value
			Me.method_6()
			If Me.method_13() Then
				Me.method_12()
				Return
			End If
			Me.method_11()
		End Set
	End Property

	' Token: 0x060002ED RID: 749 RVA: 0x00010C60 File Offset: 0x0000EE60
	Private Sub method_6()
		Try
			If Not Me.gclass15_0.Contains(Me.gclass12_0) Then
				Me.gclass15_0.Add(Me.gclass12_0)
			End If
		Catch ex As Exception
		End Try
	End Sub

	' Token: 0x060002EE RID: 750 RVA: 0x00010CB4 File Offset: 0x0000EEB4
	Private Function method_7(ByRef ginterface5_2 As GInterface5, genum9_0 As GEnum9) As Object
		Dim text As String = ""
		Dim result As Object
		Try
			IL_167:
			While genum9_0 > GEnum9.JswAttr_MACAddress
				IL_15D:
				While genum9_0 <= GEnum9.JswAttr_Version
					IL_150:
					Dim left2 As Object
					While genum9_0 <> GEnum9.JswAttr_RFBand
						While True
							Select Case genum9_0
								Case GEnum9.JswAttr_UUID_E, GEnum9.JswAttr_UUID_R
									GoTo IL_7D3
								Case GEnum9.JswAttr_VendorExtension
									GoTo IL_7F0
								Case GEnum9.JswAttr_Version
									GoTo IL_7FE
								Case Else
									Dim num2 As UInteger
									Dim num As UInteger = num2 * 2304662080UI Xor 4085628245UI Xor 430986772UI
									num2 = num
									Select Case num Mod 64UI
										Case 0UI
											GoTo IL_585
										Case 1UI, 17UI, 25UI, 35UI
											GoTo IL_7F0
										Case 2UI
											GoTo IL_15D
										Case 3UI
											GoTo IL_3B1
										Case 4UI
											GoTo IL_864
										Case 5UI
											GoTo IL_196
										Case 6UI
											GoTo IL_19C
										Case 7UI
											GoTo IL_171
										Case 8UI
											GoTo IL_402
										Case 9UI
											GoTo IL_181
										Case 10UI
											GoTo IL_5CB
										Case 11UI
											GoTo IL_18C
										Case 12UI
											GoTo IL_2FF
										Case 13UI
											GoTo IL_1D1
										Case 14UI
											GoTo IL_5C9
										Case 15UI
											GoTo IL_1DE
										Case 16UI
											GoTo IL_84C
										Case 18UI
											Continue For
										Case 20UI
											GoTo IL_672
										Case 21UI
											GoTo IL_838
										Case 22UI
											GoTo IL_88C
										Case 23UI, 63UI
											GoTo IL_167
										Case 24UI
											GoTo IL_884
										Case 26UI
											GoTo IL_874
										Case 27UI
											GoTo IL_251
										Case 28UI
											GoTo IL_150
										Case 29UI
											GoTo IL_7FE
										Case 30UI
											GoTo IL_81F
										Case 31UI
											GoTo IL_3CF
										Case 32UI
											GoTo IL_259
										Case 33UI
											GoTo IL_894
										Case 34UI
											GoTo IL_266
										Case 36UI
											GoTo IL_365
										Case 37UI
											GoTo IL_7D3
										Case 38UI
											GoTo IL_3A6
										Case 39UI
											GoTo IL_83E
										Case 40UI
											GoTo IL_29B
										Case 41UI
											GoTo IL_604
										Case 42UI
											GoTo IL_2CC
										Case 43UI
											GoTo IL_4AD
										Case 44UI
											GoTo IL_785
										Case 45UI
											GoTo IL_435
										Case 46UI
											GoTo IL_3C9
										Case 47UI
											GoTo IL_827
										Case 48UI
											GoTo IL_6A9
										Case 49UI
											GoTo IL_717
										Case 50UI
											GoTo IL_7EB
										Case 51UI
											GoTo IL_80E
										Case 52UI
											GoTo IL_39E
										Case 53UI
											GoTo IL_4B2
										Case 54UI
											GoTo IL_51E
										Case 55UI
											GoTo IL_842
										Case 56UI
											GoTo IL_63B
										Case 57UI
											GoTo IL_7CC
										Case 58UI
											GoTo IL_892
										Case 59UI
											GoTo IL_4EB
										Case 60UI
											GoTo IL_5D0
										Case 61UI
											GoTo IL_862
										Case 62UI
											GoTo IL_85C
									End Select
									GoTo Block_3
							End Select
						End While
						Block_3:
						GoTo IL_216
						IL_7D3:
						result = Class13.smethod_8(CType(ginterface5_2.imethod_0(genum9_0), Array), "")
						IL_7EB:
						Return result
						IL_7FE:
						text = ""
						Dim left As Object = ginterface5_2.imethod_0(genum9_0)
						IL_80E:
						If Not Operators.ConditionalCompareObjectEqual(left, 16, False) Then
							GoTo IL_827
						End If
						IL_81F:
						text = "1.0"
						GoTo IL_83E
						IL_827:
						If Not Operators.ConditionalCompareObjectEqual(left, 17, False) Then
							GoTo IL_83E
						End If
						IL_838:
						text = "1.1"
						IL_83E:
						Return text
						IL_84C:
						If Not Operators.ConditionalCompareObjectEqual(left2, 1, False) Then
							GoTo IL_864
						End If
						IL_85C:
						result = "2.4 Ghz"
						IL_862:
						Return result
						IL_864:
						If Operators.ConditionalCompareObjectEqual(left2, 2, False) Then
							GoTo IL_894
						End If
						IL_874:
						If Operators.ConditionalCompareObjectEqual(left2, 3, False) Then
							GoTo IL_88C
						End If
						IL_884:
						Return ""
						IL_88C:
						result = "2.4 Ghz, 5.0 Ghz"
						IL_892:
						Return result
						IL_894:
						Return "5.0 Ghz"
					End While
					GoTo IL_842
					IL_171:
					If genum9_0 <> GEnum9.JswAttr_APSetupLocked Then
						GoTo IL_259
					End If
					IL_216:
					Try
						Return Interaction.IIf(ginterface5_2.imethod_0(genum9_0) Is Nothing, False, True)
					Catch ex As Exception
						Return False
					End Try
					GoTo IL_251
					IL_259:
					If genum9_0 <> GEnum9.JswAttr_Rssi Then
						GoTo IL_7F0
					End If
					IL_29B:
					Return Interaction.IIf(Operators.ConditionalCompareObjectEqual(ginterface5_2.imethod_0(genum9_0), 0, False), "", RuntimeHelpers.GetObjectValue(ginterface5_2.imethod_0(genum9_0)))
					IL_842:
					left2 = ginterface5_2.imethod_0(genum9_0)
					GoTo IL_84C
				End While
				GoTo IL_171
				IL_181:
				If genum9_0 > GEnum9.JswAttr_ConfigMethods Then
					GoTo IL_39E
				End If
				IL_18C:
				If genum9_0 <> GEnum9.JswAttr_AuthenticationTypeFlags Then
					GoTo IL_1D1
				End If
				IL_196:
				text = ""
				IL_19C:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 1)), "OPEN, ", "")))
				GoTo IL_1DE
				IL_1D1:
				If genum9_0 <> GEnum9.JswAttr_ConfigMethods Then
					GoTo IL_7F0
				End If
				GoTo IL_251
				IL_1DE:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 2)), "WPA PSK, ", "")))
				GoTo IL_4EB
				IL_251:
				text = ""
				IL_266:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 1)), "USBA, ", "")))
				IL_2CC:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 2)), "Ethernet, ", "")))
				IL_2FF:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 4)), "Label, ", "")))
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 8)), "Display, ", "")))
				IL_365:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 16)), "Ext. NFC Token, ", "")))
				GoTo IL_4B2
				IL_39E:
				If genum9_0 = GEnum9.JswAttr_EncryptionTypeFlags Then
					GoTo IL_3C9
				End If
				IL_3A6:
				If genum9_0 <> GEnum9.JswAttr_MACAddress Then
					GoTo IL_7F0
				End If
				IL_3B1:
				Return Class13.smethod_1(CType(ginterface5_2.imethod_0(genum9_0), Byte()))
				IL_3C9:
				text = ""
				IL_3CF:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 1)), "None, ", "")))
				IL_402:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 2)), "WEP, ", "")))
				IL_435:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 4)), "TKIP, ", "")))
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 8)), "AES, ", "")))
				text = text.Substring(0, text.Length - 2)
				result = text
				IL_4AD:
				Return result
				IL_4B2:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 32)), "Int. NFC Token, ", "")))
				GoTo IL_5D0
				IL_4EB:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 4)), "SHARED, ", "")))
				IL_51E:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 8)), "WPA, ", "")))
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 16)), "WPA2, ", "")))
				IL_585:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 32)), "WPA2 PSK, ", "")))
				text = text.Substring(0, text.Length - 2)
				IL_5C9:
				result = text
				IL_5CB:
				Return result
				IL_5D0:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 64)), "NFC Interface, ", "")))
				IL_604:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 128)), "PushButton, ", "")))
				IL_63B:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 256)), "Keypad, ", "")))
				IL_672:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 640)), "Virtual Push Button, ", "")))
				IL_6A9:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 1152)), "Physical Push Button, ", "")))
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 2176)), "(Reserved), ", "")))
				IL_717:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 4096)), "P2Ps Default Configuration Method, ", "")))
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 8200)), "Virtual Display PIN, ", "")))
				IL_785:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 16392)), "Physical Display PIN, ", "")))
				text = text.Substring(0, text.Length - 2)
				IL_7CC:
				Return text
				IL_7F0:
				Return ginterface5_2.imethod_0(genum9_0)
			End While
			GoTo IL_181
		Catch ex2 As Exception
			result = ""
		End Try
		Return result
	End Function

	' Token: 0x060002EF RID: 751 RVA: 0x000115A8 File Offset: 0x0000F7A8
	Public Overridable Function Equals(obj As Object) As Boolean
		Dim gclass As GClass9 = TryCast(obj, GClass9)
		Return gclass IsNot Nothing AndAlso gclass.BSSID.Equals(Me.BSSID)
	End Function

	' Token: 0x060002F0 RID: 752 RVA: 0x000041E7 File Offset: 0x000023E7
	Public Overridable Function GetHashCode() As Integer
		Return Me.BSSID.GetHashCode()
	End Function

	' Token: 0x060002F1 RID: 753 RVA: 0x000115D8 File Offset: 0x0000F7D8
	Private Sub method_8()
		Dim sqliteCommand As SQLiteCommand = New SQLiteCommand("Select * From WPSPins where BSSID = @bssid", Me.sqliteConnection_0)
		Dim value As String = Me.string_8.Substring(0, 8)
		Dim gclass As GClass15(Of GClass12) = New GClass15(Of GClass12)()
		Dim gclass2 As GClass15(Of GClass12) = New GClass15(Of GClass12)()
		Dim gclass3 As GClass15(Of GClass12) = New GClass15(Of GClass12)()
		Dim gclass4 As GClass15(Of GClass12) = New GClass15(Of GClass12)()
		Try
			Me.sqliteConnection_0.Open()
			sqliteCommand.Parameters.AddWithValue("@bssid", value)
			Dim sqliteDataReader As SQLiteDataReader = sqliteCommand.ExecuteReader()
			While sqliteDataReader.Read()
				Dim gclass5 As GClass11 = New GClass11()
				gclass5.string_0 = sqliteDataReader("BSSID").ToString()
				gclass5.string_1 = sqliteDataReader("SSID").ToString()
				gclass5.string_2 = sqliteDataReader("Model").ToString()
				gclass5.bool_0 = Conversions.ToBoolean(sqliteDataReader("PixieDust"))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqliteDataReader("AlgorithmId"))) Then
					gclass5.genum0_0 = CType(Conversions.ToInteger(sqliteDataReader("AlgorithmId")), GClass3.GEnum0)
				End If
				Dim gclass6 As GClass15(Of GClass12) = New GClass15(Of GClass12)()
				Me.bool_1 = gclass5.bool_0
				If gclass5.genum0_0 = GClass3.GEnum0.[Nothing] Then
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqliteDataReader("PIN"))) Then
						For Each text As String In sqliteDataReader("PIN").ToString().Split(New Char() { ";"c })
							gclass6.Add(New GClass12(text, GClass12.GEnum5.Generic, gclass5))
						Next
					End If
				Else
					gclass6.Add(New GClass12(GClass3.smethod_25(Me, CType(Conversions.ToInteger(sqliteDataReader("AlgorithmId")), GClass3.GEnum0)), CType(Conversions.ToInteger(sqliteDataReader("AlgorithmId")), GClass3.GEnum0), gclass5))
				End If
				If Not LikeOperator.LikeString(Me.string_11.ToLower(), gclass5.string_1.ToLower(), CompareMethod.Binary) Then
					If LikeOperator.LikeString(Me.string_2.ToLower(), "*" + gclass5.string_2.ToLower() + "*", CompareMethod.Binary) Or LikeOperator.LikeString(Me.string_0.ToLower(), "*" + gclass5.string_2.ToLower() + "*", CompareMethod.Binary) Or LikeOperator.LikeString(Me.string_3.ToLower(), "*" + gclass5.string_2.ToLower() + "*", CompareMethod.Binary) Then
						gclass3.method_0(gclass6)
					End If
				ElseIf LikeOperator.LikeString(Me.string_2.ToLower(), "*" + gclass5.string_2.ToLower() + "*", CompareMethod.Binary) Or LikeOperator.LikeString(Me.string_0.ToLower(), "*" + gclass5.string_2.ToLower() + "*", CompareMethod.Binary) Or LikeOperator.LikeString(Me.string_3.ToLower(), "*" + gclass5.string_2.ToLower() + "*", CompareMethod.Binary) Then
					gclass4.method_0(gclass6)
				Else
					gclass2.method_0(gclass6)
				End If
			End While
			If gclass4.Count <= 0 Then
				If gclass2.Count > 0 Then
					Me.gclass15_0.method_0(gclass2)
				ElseIf gclass3.Count > 0 Then
					Me.gclass15_0.method_0(gclass3)
				ElseIf gclass.Count > 0 Then
					Me.gclass15_0.method_0(gclass)
				End If
			Else
				Me.gclass15_0.method_0(gclass4)
			End If
			sqliteDataReader.Close()
			sqliteCommand.Dispose()
			Me.sqliteConnection_0.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message, "DB GetPins", MessageBoxButtons.OK)
			Me.sqliteConnection_0.Close()
		End Try
	End Sub

	' Token: 0x060002F2 RID: 754 RVA: 0x000119C4 File Offset: 0x0000FBC4
	Private Sub method_9()
		Dim sqliteCommand As SQLiteCommand = New SQLiteCommand("Select * From WPSPins where @DeviceName Like DeviceName and @modelname Like ModelName and @modelnumber Like ModelNumber", Me.sqliteConnection_1)
		Me.string_8.Substring(0, 8)
		New GClass15(Of GClass12)()
		New GClass15(Of GClass12)()
		New GClass15(Of GClass12)()
		New GClass15(Of GClass12)()
		Try
			Me.sqliteConnection_1.Open()
			If LikeOperator.LikeString(Me.string_11, "MOVISTAR*", CompareMethod.Binary) Then
				Me.string_11 = Me.string_11
			End If
			sqliteCommand.Parameters.AddWithValue("@DeviceName", Me.string_0)
			sqliteCommand.Parameters.AddWithValue("@ModelName", Me.string_2)
			sqliteCommand.Parameters.AddWithValue("@ModelNumber", Me.string_3)
			Dim sqliteDataReader As SQLiteDataReader = sqliteCommand.ExecuteReader()
			While sqliteDataReader.Read()
				Dim gclass As GClass11 = New GClass11()
				gclass.string_0 = sqliteDataReader("BSSID").ToString()
				gclass.string_2 = sqliteDataReader("ModelName").ToString()
				gclass.string_3 = sqliteDataReader("ModelNumber").ToString()
				gclass.string_4 = sqliteDataReader("DeviceName").ToString()
				gclass.bool_0 = Conversions.ToBoolean(sqliteDataReader("PixieDust"))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqliteDataReader("AlgorithmId"))) Then
					gclass.genum0_0 = CType(Conversions.ToInteger(sqliteDataReader("AlgorithmId")), GClass3.GEnum0)
				End If
				Dim gclass2 As GClass15(Of GClass12) = New GClass15(Of GClass12)()
				Me.bool_1 = gclass.bool_0
				If gclass.genum0_0 <> GClass3.GEnum0.[Nothing] Then
					gclass2.Add(New GClass12(GClass3.smethod_25(Me, CType(Conversions.ToInteger(sqliteDataReader("AlgorithmId")), GClass3.GEnum0)), CType(Conversions.ToInteger(sqliteDataReader("AlgorithmId")), GClass3.GEnum0), gclass))
				ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqliteDataReader("PIN"))) Then
					For Each left As String In sqliteDataReader("PIN").ToString().Split(New Char() { ";"c })
						If Operators.CompareString(left, "", False) <> 0 Then
							gclass2.Add(New GClass12(left, GClass12.GEnum5.Generic, gclass))
						End If
					Next
				End If
				Me.gclass15_0.method_0(gclass2)
			End While
			sqliteDataReader.Close()
			sqliteCommand.Dispose()
			Me.sqliteConnection_1.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message, "DB GetProbePins", MessageBoxButtons.OK)
			Me.sqliteConnection_1.Close()
		End Try
	End Sub

	' Token: 0x060002F3 RID: 755 RVA: 0x00011C60 File Offset: 0x0000FE60
	Public Sub method_10()
		Dim sqliteCommand As SQLiteCommand = New SQLiteCommand("Select * From Networks where BSSID = @bssid", Me.sqliteConnection_2)
		Try
			Me.sqliteConnection_2.Open()
			sqliteCommand.Parameters.AddWithValue("@bssid", Me.string_8)
			Dim sqliteDataReader As SQLiteDataReader = sqliteCommand.ExecuteReader()
			If sqliteDataReader.Read() Then
				Me.string_0 = sqliteDataReader("DeviceName").ToString()
				Me.string_1 = sqliteDataReader("Manufacturer").ToString()
				Me.string_2 = sqliteDataReader("ModelName").ToString()
				Me.string_3 = sqliteDataReader("ModelNumber").ToString()
				Me.string_4 = sqliteDataReader("SerialNumber").ToString()
				Me.string_5 = sqliteDataReader("RFBand").ToString()
				Me.string_6 = sqliteDataReader("UUID").ToString()
				Me.string_7 = sqliteDataReader("Version").ToString()
				Me.string_9 = sqliteDataReader("Encryption").ToString()
				Me.string_10 = sqliteDataReader("ConfigMethods").ToString()
				Me.genum3_0 = CType(Conversions.ToInteger(sqliteDataReader("Status")), GClass9.GEnum3)
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqliteDataReader("Pin"))) AndAlso Operators.CompareString(sqliteDataReader("Pin").ToString(), "", False) <> 0 Then
					Me.gclass12_0 = New GClass12(sqliteDataReader("Pin").ToString(), CType(Conversions.ToInteger(sqliteDataReader("DecryptMode")), GClass12.GEnum5))
				End If
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqliteDataReader("Key"))) AndAlso Operators.CompareString(sqliteDataReader("Key").ToString(), "", False) <> 0 Then
					Me.string_13 = sqliteDataReader("Key").ToString()
				End If
			End If
			sqliteDataReader.Close()
			sqliteCommand.Dispose()
			Me.sqliteConnection_2.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message, "DB GetApLog", MessageBoxButtons.OK)
			Me.sqliteConnection_0.Close()
		End Try
	End Sub

	' Token: 0x060002F4 RID: 756 RVA: 0x00011EB0 File Offset: 0x000100B0
	Public Sub method_11()
		Dim sqliteCommand As SQLiteCommand = New SQLiteCommand("Insert into Networks values(@BSSID," & vbCrLf & "                                                                      @SSID," & vbCrLf & "                                                                      @DeviceName," & vbCrLf & "                                                                      @Manufacturer," & vbCrLf & "                                                                      @ModelName," & vbCrLf & "                                                                      @ModelNumber," & vbCrLf & "                                                                      @SerialNumber," & vbCrLf & "                                                                      @RFBand," & vbCrLf & "                                                                      @UUID," & vbCrLf & "                                                                      @Version," & vbCrLf & "                                                                      @Encryption," & vbCrLf & "                                                                      @ConfigMethods," & vbCrLf & "                                                                      @Pin," & vbCrLf & "                                                                      @Key," & vbCrLf & "                                                                      @DecryptMode," & vbCrLf & "                                                                      @Know," & vbCrLf & "                                                                      @Status)", Me.sqliteConnection_2)
		Try
			Me.sqliteConnection_2.Open()
			sqliteCommand.Parameters.AddWithValue("@BSSID", Me.string_8)
			sqliteCommand.Parameters.AddWithValue("@SSID", Me.string_11)
			sqliteCommand.Parameters.AddWithValue("@DeviceName", Me.string_0)
			sqliteCommand.Parameters.AddWithValue("@Manufacturer", Me.string_1)
			sqliteCommand.Parameters.AddWithValue("@ModelName", Me.string_2)
			sqliteCommand.Parameters.AddWithValue("@ModelNumber", Me.string_3)
			sqliteCommand.Parameters.AddWithValue("@SerialNumber", Me.string_4)
			sqliteCommand.Parameters.AddWithValue("@RFBand", Me.string_5)
			sqliteCommand.Parameters.AddWithValue("@UUID", Me.string_6)
			sqliteCommand.Parameters.AddWithValue("@Version", Me.string_7)
			sqliteCommand.Parameters.AddWithValue("@Encryption", Me.string_9)
			sqliteCommand.Parameters.AddWithValue("@ConfigMethods", Me.string_10)
			sqliteCommand.Parameters.AddWithValue("@Pin", Me.gclass12_0.Pin)
			sqliteCommand.Parameters.AddWithValue("@Key", Me.string_13)
			sqliteCommand.Parameters.AddWithValue("@DecryptMode", Me.gclass12_0.Type)
			sqliteCommand.Parameters.AddWithValue("@Know", 0)
			sqliteCommand.Parameters.AddWithValue("@Status", Me.genum3_0)
			sqliteCommand.ExecuteNonQuery()
			sqliteCommand.Dispose()
			Me.sqliteConnection_2.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message, "DB InsertAp", MessageBoxButtons.OK)
		End Try
	End Sub

	' Token: 0x060002F5 RID: 757 RVA: 0x000120CC File Offset: 0x000102CC
	Public Sub method_12()
		Dim sqliteCommand As SQLiteCommand = New SQLiteCommand("Update Networks set SSID=@SSID," & vbCrLf & "                                          DeviceName=@DeviceName," & vbCrLf & "                                          Manufacturer=@Manufacturer," & vbCrLf & "                                          ModelName=@ModelName," & vbCrLf & "                                          ModelNumber=@ModelNumber," & vbCrLf & "                                          SerialNumber=@SerialNumber," & vbCrLf & "                                          RFBand=@RFBand," & vbCrLf & "                                          UUID=@UUID," & vbCrLf & "                                          Version=@Version," & vbCrLf & "                                          Encryption=@Encryption," & vbCrLf & "                                          ConfigMethods=@ConfigMethods," & vbCrLf & "                                          Pin=@Pin," & vbCrLf & "                                          Key=@Key," & vbCrLf & "                                          DecryptMode=@DecryptMode," & vbCrLf & "                                          Know=@Know," & vbCrLf & "                                          Status=@Status " & vbCrLf & "                                          where BSSID=@BSSID", Me.sqliteConnection_2)
		Try
			Me.sqliteConnection_2.Open()
			sqliteCommand.Parameters.AddWithValue("@BSSID", Me.string_8)
			sqliteCommand.Parameters.AddWithValue("@SSID", Me.string_11)
			sqliteCommand.Parameters.AddWithValue("@DeviceName", Me.string_0)
			sqliteCommand.Parameters.AddWithValue("@Manufacturer", Me.string_1)
			sqliteCommand.Parameters.AddWithValue("@ModelName", Me.string_2)
			sqliteCommand.Parameters.AddWithValue("@ModelNumber", Me.string_3)
			sqliteCommand.Parameters.AddWithValue("@SerialNumber", Me.string_4)
			sqliteCommand.Parameters.AddWithValue("@RFBand", Me.string_5)
			sqliteCommand.Parameters.AddWithValue("@UUID", Me.string_6)
			sqliteCommand.Parameters.AddWithValue("@Version", Me.string_7)
			sqliteCommand.Parameters.AddWithValue("@Encryption", Me.string_9)
			sqliteCommand.Parameters.AddWithValue("@ConfigMethods", Me.string_10)
			sqliteCommand.Parameters.AddWithValue("@Pin", Me.gclass12_0.Pin)
			sqliteCommand.Parameters.AddWithValue("@Key", Me.string_13)
			sqliteCommand.Parameters.AddWithValue("@DecryptMode", Me.gclass12_0.Type)
			sqliteCommand.Parameters.AddWithValue("@Know", 0)
			sqliteCommand.Parameters.AddWithValue("@Status", Me.genum3_0)
			sqliteCommand.ExecuteNonQuery()
			sqliteCommand.Dispose()
			Me.sqliteConnection_2.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message, "DB UpdateAp", MessageBoxButtons.OK)
		End Try
	End Sub

	' Token: 0x060002F6 RID: 758 RVA: 0x000122E8 File Offset: 0x000104E8
	Public Function method_13() As Boolean
		Dim sqliteCommand As SQLiteCommand = New SQLiteCommand("Select * From Networks where BSSID = @bssid", Me.sqliteConnection_2)
		Dim result As Boolean = False
		Try
			Me.sqliteConnection_2.Open()
			sqliteCommand.Parameters.AddWithValue("@bssid", Me.string_8)
			Dim sqliteDataReader As SQLiteDataReader = sqliteCommand.ExecuteReader()
			result = sqliteDataReader.Read()
			sqliteDataReader.Close()
			sqliteCommand.Dispose()
			Me.sqliteConnection_2.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Is Ap in Db", MessageBoxButtons.OK)
			Me.sqliteConnection_0.Close()
		End Try
		Return result
	End Function

	' Token: 0x04000112 RID: 274
	<CompilerGenerated()>
	Private propertyChangedEventHandler_0 As PropertyChangedEventHandler

	' Token: 0x04000113 RID: 275
	Public ginterface5_0 As GInterface5

	' Token: 0x04000114 RID: 276
	Public ginterface5_1 As GInterface5()

	' Token: 0x04000115 RID: 277
	Public string_0 As String

	' Token: 0x04000116 RID: 278
	Public string_1 As String

	' Token: 0x04000117 RID: 279
	Public string_2 As String

	' Token: 0x04000118 RID: 280
	Public string_3 As String

	' Token: 0x04000119 RID: 281
	Private string_4 As String

	' Token: 0x0400011A RID: 282
	Public string_5 As String

	' Token: 0x0400011B RID: 283
	Private string_6 As String

	' Token: 0x0400011C RID: 284
	Private string_7 As String

	' Token: 0x0400011D RID: 285
	Private bool_0 As Boolean

	' Token: 0x0400011E RID: 286
	Private string_8 As String

	' Token: 0x0400011F RID: 287
	Public string_9 As String

	' Token: 0x04000120 RID: 288
	Public string_10 As String

	' Token: 0x04000121 RID: 289
	Private string_11 As String

	' Token: 0x04000122 RID: 290
	Private int_0 As Integer

	' Token: 0x04000123 RID: 291
	Private string_12 As String

	' Token: 0x04000124 RID: 292
	Public gclass15_0 As GClass15(Of GClass12)

	' Token: 0x04000125 RID: 293
	Public bool_1 As Boolean

	' Token: 0x04000126 RID: 294
	Private string_13 As String

	' Token: 0x04000127 RID: 295
	Private gclass12_0 As GClass12

	' Token: 0x04000128 RID: 296
	Private string_14 As String

	' Token: 0x04000129 RID: 297
	Private string_15 As String

	' Token: 0x0400012A RID: 298
	Private string_16 As String

	' Token: 0x0400012B RID: 299
	Private string_17 As String

	' Token: 0x0400012C RID: 300
	Private string_18 As String

	' Token: 0x0400012D RID: 301
	Private string_19 As String

	' Token: 0x0400012E RID: 302
	Private string_20 As String

	' Token: 0x0400012F RID: 303
	Private genum3_0 As GClass9.GEnum3

	' Token: 0x04000130 RID: 304
	Private genum4_0 As GClass9.GEnum4

	' Token: 0x04000131 RID: 305
	Private bool_2 As Boolean

	' Token: 0x04000132 RID: 306
	Private sqliteConnection_0 As SQLiteConnection

	' Token: 0x04000133 RID: 307
	Private sqliteConnection_1 As SQLiteConnection

	' Token: 0x04000134 RID: 308
	Private sqliteConnection_2 As SQLiteConnection

	' Token: 0x02000025 RID: 37
	Public Enum GEnum3
		' Token: 0x04000136 RID: 310
		Unknow
		' Token: 0x04000137 RID: 311
		Ok
		' Token: 0x04000138 RID: 312
		Nok
	End Enum

	' Token: 0x02000026 RID: 38
	Public Enum GEnum4
		' Token: 0x0400013A RID: 314
		[Nothing]
		' Token: 0x0400013B RID: 315
		[Single]
		' Token: 0x0400013C RID: 316
		Several
		' Token: 0x0400013D RID: 317
		Algorithm
	End Enum
End Class
