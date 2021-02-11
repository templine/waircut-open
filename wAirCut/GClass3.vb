Imports System
Imports System.Diagnostics
Imports System.Linq
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports wAirCut

' Token: 0x02000010 RID: 16
Public NotInheritable Module GClass3
	' Token: 0x06000169 RID: 361 RVA: 0x000075F0 File Offset: 0x000057F0
	Public Function smethod_0(int_0 As Integer) As Integer
		Dim num As Integer = 0
		If int_0 > 9999999 Then
			int_0 = CInt(Math.Round(CDbl(int_0) / 10.0))
		End If
		While int_0 <> 0
			num += 3 * (int_0 Mod 10)
			int_0 /= 10
			num += int_0 Mod 10
			int_0 /= 10
		End While
		Return(10 - num Mod 10) Mod 10
	End Function

	' Token: 0x0600016A RID: 362 RVA: 0x0000764C File Offset: 0x0000584C
	Public Function smethod_1(string_0 As String) As String
		Dim array As String() = New String(6) {}
		array = string_0.Split(New Char() { ":"c })
		Dim num As Integer = Convert.ToInt32(array(3) + array(4) + array(5), 16)
		num = num Mod 10000000
		Return num.ToString("D7") + GClass3.smethod_0(num).ToString()
	End Function

	' Token: 0x0600016B RID: 363 RVA: 0x00003952 File Offset: 0x00001B52
	Public Function smethod_2() As String
		Return ""
	End Function

	' Token: 0x0600016C RID: 364 RVA: 0x000076B4 File Offset: 0x000058B4
	Public Function smethod_3(string_0 As String) As String
		Dim array As String() = New String(6) {}
		array = string_0.Split(New Char() { ":"c })
		Dim text As String = Conversions.ToString((Convert.ToInt32(array(0), 16) + Convert.ToInt32(array(1), 16)) Mod 10) + Conversions.ToString((Convert.ToInt32(array(1), 16) + Convert.ToInt32(array(2), 16)) Mod 10) + Conversions.ToString((Convert.ToInt32(array(2), 16) + Convert.ToInt32(array(3), 16)) Mod 10) + Conversions.ToString((Convert.ToInt32(array(3), 16) + Convert.ToInt32(array(4), 16)) Mod 10) + Conversions.ToString((Convert.ToInt32(array(4), 16) + Convert.ToInt32(array(5), 16)) Mod 10) + Conversions.ToString((Convert.ToInt32(array(5), 16) + Convert.ToInt32(array(0), 16)) Mod 10) + Conversions.ToString((Convert.ToInt32(array(0), 16) + Convert.ToInt32(array(1), 16)) Mod 10)
		Return text + GClass3.smethod_0(Convert.ToInt32(text)).ToString()
	End Function

	' Token: 0x0600016D RID: 365 RVA: 0x000077DC File Offset: 0x000059DC
	Public Function smethod_4(string_0 As String) As Object
		Dim num As Integer = Convert.ToInt32(string_0.Replace(":", "").Substring(6, 6), 16) Xor 5614165
		num = num Xor ((num And 15) << 4) + ((num And 15) << 8) + ((num And 15) << 12) + ((num And 15) << 16) + ((num And 15) << 20)
		Dim text As String = (num Mod 10000000).ToString().PadLeft(7, "0"c)
		Return text + Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(text)))
	End Function

	' Token: 0x0600016E RID: 366 RVA: 0x00007864 File Offset: 0x00005A64
	Public Function smethod_5(string_0 As String) As String
		Dim text As String = string_0.Replace(":", "")
		Dim text2 As String = Convert.ToInt32(text.Substring(8, 4), 16).ToString("00000")
		Dim array As Byte() = New Byte(11) {}
		Dim num As Integer = 0
		Dim array2 As Byte()
		Do
			array(num) = CByte(Convert.ToInt32(text.Substring(num, 1), 16))
			num += 1
		Loop While num <= 11
		array2 = New Byte(4) {}
		Dim num2 As Integer = 0
		Do
			array2(num2) = CByte(Convert.ToInt32(text2.Substring(num2, 1), 16))
			num2 += 1
		Loop While num2 <= 4
		Dim num3 As Integer = CInt(((array2(1) + array2(2) + array(10) + array(11)) Mod 16))
		Dim num4 As Integer = CInt(((array2(3) + array2(4) + array(8) + array(9)) Mod 16))
		Dim array3 As Byte() = New Byte() { CByte(((num3 Xor CInt(array2(4))) Mod 16)), CByte(((num3 Xor CInt(array2(3))) Mod 16)), CByte(((num4 Xor CInt(array(9))) Mod 16)), CByte(((num4 Xor CInt(array(10))) Mod 16)), (array(10) Xor array2(4)) Mod 16, (array(11) Xor array2(3)) Mod 16, CByte(((num3 Xor CInt(array2(2))) Mod 16)) }
		Dim text3 As String = ""
		Dim num5 As Integer = 0
		Do
			text3 += Conversion.Hex(array3(num5))
			num5 += 1
		Loop While num5 <= 6
		text3 = (Convert.ToInt32(text3, 16) Mod 10000000).ToString()
		text3 += Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(text3.PadLeft(7, "0"c))))
		Return text3.PadLeft(8, "0"c)
	End Function

	' Token: 0x0600016F RID: 367 RVA: 0x00007A20 File Offset: 0x00005C20
	Public Function smethod_6(string_0 As String, string_1 As String) As String
		' The following expression was wrapped in a checked-statement
		Dim result As String
		If string_1.Length >= 10 AndAlso Versioned.IsNumeric(string_1.Substring(1, 9)) Then
			Dim text As String = string_0.Replace(":", "")
			Dim value As ULong = CULng(Convert.ToInt64(text, 16))
			text = Convert.ToUInt64(Decimal.Subtract(New Decimal(value), 2D)).ToString("X12")
			Dim text2 As String = string_1.Substring(1, 9)
			Dim array As Byte() = New Byte(11) {}
			Dim num As Integer = 0
			Do
				array(11 - num) = CByte(Convert.ToInt32(text.Substring(num, 1), 16))
				num += 1
			Loop While num <= 11
			Dim array2 As Byte() = New Byte(8) {}
			Dim num2 As Integer = 0
			Do
				array2(8 - num2) = CByte(Convert.ToInt32(text2.Substring(num2, 1), 16))
				num2 += 1
			Loop While num2 <= 8
			Dim num3 As Integer
			Dim num4 As Integer

				num3 = CInt(((array2(2) + array2(3) + array(0) + array(1)) Mod 16))
				num4 = CInt(((array2(0) + array2(1) + array(2) + array(3)) Mod 16))

			Dim array3 As Byte() = New Byte() { CByte(((num3 Xor CInt(array2(0))) Mod 16)), CByte(((num3 Xor CInt(array2(1))) Mod 16)), CByte(((num4 Xor CInt(array(2))) Mod 16)), CByte(((num4 Xor CInt(array(1))) Mod 16)), (array(1) Xor array2(0)) Mod 16, (array(0) Xor array2(1)) Mod 16, CByte(((num3 Xor CInt(array2(2))) Mod 16)) }
			Dim text3 As String = ""
			Dim num5 As Integer = 0
			Do
				text3 += Conversion.Hex(array3(num5))
				num5 += 1
			Loop While num5 <= 6
			text3 = (Convert.ToInt32(text3, 16) Mod 10000000).ToString()
			text3 += Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(text3.PadLeft(7, "0"c))))
			result = text3.PadLeft(8, "0"c)
		Else
			result = ""
		End If
		Return result
	End Function

	' Token: 0x06000170 RID: 368 RVA: 0x00007C2C File Offset: 0x00005E2C
	Public Function smethod_7(string_0 As String) As String
		Dim array As String() = New String(6) {}
		array = string_0.Split(New Char() { ":"c })
		Dim text As String = Convert.ToInt32(array(5) + array(4) + array(3), 16).ToString().PadLeft(7, "0"c)
		Dim text2 As String = text.Substring(text.Length - 7, 7)
		Return text2 + Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(text2)))
	End Function

	' Token: 0x06000171 RID: 369 RVA: 0x00007C9C File Offset: 0x00005E9C
	Public Function smethod_8(string_0 As String) As String()
		Dim array As String() = New String() { "00000000", "00000000", "00000000" }
		Dim num As Integer = Convert.ToInt32(string_0.Replace(":", "").Substring(6, 6), 16) Mod 10000000
		array(0) = num.ToString("0000000")
		Dim array2 As String() = array
		Dim num2 As Integer = 0
		Dim ptr As String = array2(num2)
		array2(num2) = ptr + Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(array(0))))
		array(1) = (num + 8).ToString("0000000")
		Dim array3 As String() = array
		Dim num3 As Integer = 1
		ptr = array3(num3)
		array3(num3) = ptr + Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(array(1))))
		array(2) = (num + 14).ToString("0000000")
		Dim array4 As String() = array
		Dim num4 As Integer = 2
		ptr = array4(num4)
		array4(num4) = ptr + Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(array(2))))
		Return array
	End Function

	' Token: 0x06000172 RID: 370 RVA: 0x00007D90 File Offset: 0x00005F90
	Public Function smethod_9(string_0 As String, string_1 As String) As String
		' The following expression was wrapped in a checked-expression
		Dim text As String = (Convert.ToInt32(string_0.Replace(":", "").Substring(6, 4) + string_1.Substring(6, 2), 16) Mod 10000000 + 7).ToString("0000000")
		Return(text + Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(text)))).PadLeft(7, "0"c)
	End Function

	' Token: 0x06000173 RID: 371 RVA: 0x00007DFC File Offset: 0x00005FFC
	Public Function smethod_10(string_0 As String) As String
		Dim text As String = string_0.Replace(":", "")
		Dim array As Integer() = New Integer(5) {}
		Dim array2 As Byte() = New Byte(7) {}
		Dim text2 As String = ""
		Dim num As Integer = 0
		Do
			array(num) = Convert.ToInt32(text.Substring(num * 2, 2), 16)
			num += 1
		Loop While num <= 5
		Dim num2 As Integer = 0
		Do
			array2(num2) = CByte(((array(num2 Mod 6) + array(5)) Mod (10 - (num2 + array(1) + array(2) + array(3) + array(4) + array(5)) Mod 7)))
			text2 += array2(num2).ToString("X1")
			num2 += 1
		Loop While num2 <= 7
		text2 = text2.ToString().PadLeft(7, "0"c)
		text2 = text2.Substring(0, 7)
		Return text2 + Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(text2)))
	End Function

	' Token: 0x06000174 RID: 372 RVA: 0x00007EDC File Offset: 0x000060DC
	Public Function smethod_11(string_0 As String) As String
		Dim num As ULong = Convert.ToUInt64(string_0.Replace(":", ""), 16)
		num = CULng(((CLng(num) And 16777215L) Mod 10000000L))
		Return Convert.ToUInt64(Decimal.Add(Decimal.Multiply(New Decimal(num), 10D), New Decimal(GClass3.smethod_0(Conversions.ToInteger(num.ToString("0000000")))))).ToString("00000000")
	End Function

	' Token: 0x06000175 RID: 373 RVA: 0x00007F64 File Offset: 0x00006164
	Public Function smethod_12(string_0 As String) As String
		Dim num As ULong = Convert.ToUInt64(string_0.Replace(":", ""), 16)
		num = CULng(((CLng(num) And 268435455L) Mod 10000000L))
		Return Convert.ToUInt64(Decimal.Add(Decimal.Multiply(New Decimal(num), 10D), New Decimal(GClass3.smethod_0(Conversions.ToInteger(num.ToString("0000000")))))).ToString("00000000")
	End Function

	' Token: 0x06000176 RID: 374 RVA: 0x00007FEC File Offset: 0x000061EC
	Public Function smethod_13(string_0 As String) As String
		Dim value As ULong = Convert.ToUInt64(string_0.Replace(":", ""), 16)
		value = Convert.ToUInt64(Decimal.Remainder(Decimal.Remainder(New Decimal(value), 4294967296D), 10000000D))
		Return Convert.ToUInt64(Decimal.Add(Decimal.Multiply(New Decimal(value), 10D), New Decimal(GClass3.smethod_0(Conversions.ToInteger(value.ToString("0000000")))))).ToString("00000000")
	End Function

	' Token: 0x06000177 RID: 375 RVA: 0x0000808C File Offset: 0x0000628C
	Public Function smethod_14(string_0 As String) As String
		Dim value As ULong = Convert.ToUInt64(string_0.Replace(":", ""), 16)
		value = Convert.ToUInt64(Decimal.Remainder(Decimal.Remainder(New Decimal(value), 68719476736D), 10000000D))
		Return Convert.ToUInt64(Decimal.Add(Decimal.Multiply(New Decimal(value), 10D), New Decimal(GClass3.smethod_0(Conversions.ToInteger(value.ToString("0000000")))))).ToString("00000000")
	End Function

	' Token: 0x06000178 RID: 376 RVA: 0x0000812C File Offset: 0x0000632C
	Public Function smethod_15(string_0 As String) As String
		Dim value As ULong = Convert.ToUInt64(string_0.Replace(":", ""), 16)
		value = Convert.ToUInt64(Decimal.Remainder(Decimal.Remainder(New Decimal(value), 1099511627776D), 10000000D))
		Return Convert.ToUInt64(Decimal.Add(Decimal.Multiply(New Decimal(value), 10D), New Decimal(GClass3.smethod_0(Conversions.ToInteger(value.ToString("0000000")))))).ToString("00000000")
	End Function

	' Token: 0x06000179 RID: 377 RVA: 0x000081D0 File Offset: 0x000063D0
	Public Function smethod_16(string_0 As String) As String
		Dim value As ULong = Convert.ToUInt64(string_0.Replace(":", ""), 16)
		value = Convert.ToUInt64(Decimal.Remainder(Decimal.Remainder(New Decimal(value), 17592186044416D), 10000000D))
		Return Convert.ToUInt64(Decimal.Add(Decimal.Multiply(New Decimal(value), 10D), New Decimal(GClass3.smethod_0(Conversions.ToInteger(value.ToString("0000000")))))).ToString("00000000")
	End Function

	' Token: 0x0600017A RID: 378 RVA: 0x00008274 File Offset: 0x00006474
	Public Function smethod_17(string_0 As String) As String
		Dim value As ULong = Convert.ToUInt64(string_0.Replace(":", ""), 16)
		value = Convert.ToUInt64(Decimal.Remainder(Decimal.Remainder(New Decimal(value), 281474976710656D), 10000000D))
		Return Convert.ToUInt64(Decimal.Add(Decimal.Multiply(New Decimal(value), 10D), New Decimal(GClass3.smethod_0(Conversions.ToInteger(value.ToString("0000000")))))).ToString("00000000")
	End Function

	' Token: 0x0600017B RID: 379 RVA: 0x00008318 File Offset: 0x00006518
	Public Function smethod_18(string_0 As String) As String
		Dim array As String() = New String(6) {}
		array = string_0.Split(New Char() { ":"c })
		Dim num As ULong = Convert.ToUInt64(array(5) + array(4) + array(3), 16)
		num = Convert.ToUInt64(Decimal.Remainder(New Decimal(num), 10000000D))
		Return num.ToString("D7") + GClass3.smethod_0(CInt(num)).ToString()
	End Function

	' Token: 0x0600017C RID: 380 RVA: 0x000083A0 File Offset: 0x000065A0
	Public Function smethod_19(string_0 As String) As String
		Dim array As String() = New String(6) {}
		array = string_0.Split(New Char() { ":"c })
		Dim num As ULong = Convert.ToUInt64(array(5) + array(4) + array(3) + array(2), 16)
		num = Convert.ToUInt64(Decimal.Remainder(New Decimal(num), 10000000D))
		Return num.ToString("D7") + GClass3.smethod_0(CInt(num)).ToString()
	End Function

	' Token: 0x0600017D RID: 381 RVA: 0x00008428 File Offset: 0x00006628
	Public Function smethod_20(string_0 As String) As String
		Dim array As String() = New String(6) {}
		array = string_0.Split(New Char() { ":"c })
		Dim num As ULong = Convert.ToUInt64(String.Concat(New String() { array(5), array(4), array(3), array(2), array(1), array(0) }), 16)
		num = Convert.ToUInt64(Decimal.Remainder(New Decimal(num), 10000000D))
		Return num.ToString("D7") + GClass3.smethod_0(CInt(num)).ToString()
	End Function

	' Token: 0x0600017E RID: 382 RVA: 0x00003959 File Offset: 0x00001B59
	Public Function smethod_21(string_0 As String) As String
		Return GClass3.smethod_18(GClass3.smethod_24(string_0))
	End Function

	' Token: 0x0600017F RID: 383 RVA: 0x00003966 File Offset: 0x00001B66
	Public Function smethod_22(string_0 As String) As String
		Return GClass3.smethod_19(GClass3.smethod_24(string_0))
	End Function

	' Token: 0x06000180 RID: 384 RVA: 0x00003973 File Offset: 0x00001B73
	Public Function smethod_23(string_0 As String) As String
		Return GClass3.smethod_20(GClass3.smethod_24(string_0))
	End Function

	' Token: 0x06000181 RID: 385 RVA: 0x000084D0 File Offset: 0x000066D0
	Private Function smethod_24(string_0 As String) As String
		Dim array As String() = New String(6) {}
		array = string_0.Split(New Char() { ":"c })
		Dim num As Integer = 0
		Do
			array(num) = String.Join(Of Char)("", array(num).Reverse())
			num += 1
		Loop While num <= 5
		Return String.Join(":", array)
	End Function

	' Token: 0x06000182 RID: 386 RVA: 0x00008524 File Offset: 0x00006724
	Public Function smethod_25(gclass9_0 As GClass9, genum0_0 As GClass3.GEnum0) As String
		Dim result As String = ""
		While True
			IL_BE:
			Select Case genum0_0
				Case GClass3.GEnum0.ZAO
					GoTo IL_121
				Case GClass3.GEnum0.FTE
					GoTo IL_132
				Case GClass3.GEnum0.EasyBox
					GoTo IL_149
				Case GClass3.GEnum0.dLINK
					GoTo IL_15A
				Case GClass3.GEnum0.TrendNet
					GoTo IL_170
				Case GClass3.GEnum0.AiroConru
					GoTo IL_181
				Case GClass3.GEnum0.Asus
					GoTo IL_192
				Case GClass3.GEnum0.LiveBox
					GoTo IL_1A3
				Case GClass3.GEnum0.PinNull
					GoTo IL_1BA
				Case CType(9, GClass3.GEnum0)
					Return result
				Case GClass3.GEnum0.d28bit
					GoTo IL_1C5
				Case GClass3.GEnum0.d32bit
					GoTo IL_1D6
				Case GClass3.GEnum0.d36bit
					GoTo IL_1E7
				Case GClass3.GEnum0.d40bit
					GoTo IL_1F5
				Case GClass3.GEnum0.d44bit
					GoTo IL_203
				Case GClass3.GEnum0.d48bit
					GoTo IL_211
				Case GClass3.GEnum0.d24rhbit
					GoTo IL_21F
				Case GClass3.GEnum0.d32rhbit
					GoTo IL_22D
				Case GClass3.GEnum0.d48rhbit
					GoTo IL_23B
				Case GClass3.GEnum0.d24rnbit
					GoTo IL_249
				Case GClass3.GEnum0.d32rnbit
					GoTo IL_257
				Case GClass3.GEnum0.d48rnbit
					GoTo IL_265
				Case Else
					Dim num2 As UInteger
					Dim num As Integer = CInt((num2 * 3824409724UI Xor 3255173091UI))
					While True
						Dim num3 As Integer = num Xor -1097764852
						num2 = CUInt(num3)
						Select Case num3 Mod 32
							Case 0
								GoTo IL_203
							Case 2
								GoTo IL_1BA
							Case 3
								GoTo IL_21F
							Case 4
								GoTo IL_1D6
							Case 5
								GoTo IL_181
							Case 6
								GoTo IL_121
							Case 8
								GoTo IL_1C5
							Case 9
								GoTo IL_249
							Case 10
								GoTo IL_22D
							Case 11
								GoTo IL_15A
							Case 12
								GoTo IL_211
							Case 13, 18
								GoTo IL_BE
							Case 14
								GoTo IL_149
							Case 16
								GoTo IL_1E7
							Case 17
								GoTo IL_170
							Case 19
								GoTo IL_192
							Case 21
								GoTo IL_257
							Case 23
								num = CInt((num2 * 3880420547UI Xor 2093315112UI))
								Continue For
							Case 24
								GoTo IL_23B
							Case 26
								GoTo IL_1A3
							Case 27
								GoTo IL_265
							Case 29
								GoTo IL_132
							Case 30
								GoTo IL_1F5
						End Select
						GoTo Block_1
					End While
			End Select
		End While
		Block_1:
		Return result
		IL_121:
		Return GClass3.smethod_1(gclass9_0.BSSID)
		IL_132:
		Return GClass3.smethod_9(gclass9_0.BSSID, gclass9_0.SSID)
		IL_149:
		Return GClass3.smethod_5(gclass9_0.BSSID)
		IL_15A:
		Return Conversions.ToString(GClass3.smethod_4(gclass9_0.BSSID))
		IL_170:
		Return GClass3.smethod_7(gclass9_0.BSSID)
		IL_181:
		Return GClass3.smethod_3(gclass9_0.BSSID)
		IL_192:
		Return GClass3.smethod_10(gclass9_0.BSSID)
		IL_1A3:
		Return GClass3.smethod_6(gclass9_0.BSSID, gclass9_0.SerialNumber)
		IL_1BA:
		Return GClass3.smethod_2()
		IL_1C5:
		Return GClass3.smethod_12(gclass9_0.BSSID)
		IL_1D6:
		Return GClass3.smethod_13(gclass9_0.BSSID)
		IL_1E7:
		Return GClass3.smethod_14(gclass9_0.BSSID)
		IL_1F5:
		Return GClass3.smethod_15(gclass9_0.BSSID)
		IL_203:
		Return GClass3.smethod_16(gclass9_0.BSSID)
		IL_211:
		Return GClass3.smethod_17(gclass9_0.BSSID)
		IL_21F:
		Return GClass3.smethod_18(gclass9_0.BSSID)
		IL_22D:
		Return GClass3.smethod_19(gclass9_0.BSSID)
		IL_23B:
		Return GClass3.smethod_20(gclass9_0.BSSID)
		IL_249:
		Return GClass3.smethod_21(gclass9_0.BSSID)
		IL_257:
		Return GClass3.smethod_22(gclass9_0.BSSID)
		IL_265:
		result = GClass3.smethod_23(gclass9_0.BSSID)
		Return result
	End Function

	' Token: 0x06000183 RID: 387 RVA: 0x000087A4 File Offset: 0x000069A4
	Public Function smethod_26(ByRef gclass9_0 As GClass9, string_0 As String) As String
		Return GClass3.smethod_27("-e " + gclass9_0.PKE + " -r " + gclass9_0.PKR + " -s " + gclass9_0.E_HAS1 + " -z " + gclass9_0.E_HAS2 + " -a " + gclass9_0.AuthKey + " -n " + gclass9_0.E_NONCE + " -m " + gclass9_0.R_NONCE + string_0)
	End Function

	' Token: 0x06000184 RID: 388 RVA: 0x00008834 File Offset: 0x00006A34
	Public Function smethod_27(string_0 As String) As String
		Dim process As Process = New Process()
		Return GClass3.smethod_28(string_0, process)
	End Function

	' Token: 0x06000185 RID: 389 RVA: 0x00008850 File Offset: 0x00006A50
	Public Function smethod_28(string_0 As String, ByRef process_0 As Process) As String
		Dim waitSplashProcess As WaitSplashProcess = New WaitSplashProcess(Class6.Class7_0.MainForm_0.RtbMessage, Class10.String_76)
		Dim process As Process = process_0
		process.StartInfo = New ProcessStartInfo("PixieWps\pixiewps.exe", string_0)
		Dim startInfo As ProcessStartInfo = process.StartInfo
		startInfo.CreateNoWindow = True
		startInfo.UseShellExecute = False
		startInfo.RedirectStandardOutput = True
		Dim now As DateTime = DateAndTime.Now
		process.Start()
		While Not process.HasExited
			Application.DoEvents()
			If(DateAndTime.Now - now).TotalSeconds > 2.0 Then
				If waitSplashProcess.IsDisposed Then
					process.Kill()
				Else
					If Not waitSplashProcess.Visible Then
						waitSplashProcess.Show()
					End If
					waitSplashProcess.Refresh()
				End If
			End If
		End While
		If Not waitSplashProcess.IsDisposed Then
			waitSplashProcess.Dispose()
		End If
		Return process_0.StandardOutput.ReadToEnd()
	End Function

	' Token: 0x02000011 RID: 17
	Public Enum GEnum0
		' Token: 0x0400006F RID: 111
		[Nothing] = -1
		' Token: 0x04000070 RID: 112
		ZAO
		' Token: 0x04000071 RID: 113
		FTE
		' Token: 0x04000072 RID: 114
		EasyBox
		' Token: 0x04000073 RID: 115
		dLINK
		' Token: 0x04000074 RID: 116
		TrendNet
		' Token: 0x04000075 RID: 117
		AiroConru
		' Token: 0x04000076 RID: 118
		Asus
		' Token: 0x04000077 RID: 119
		LiveBox
		' Token: 0x04000078 RID: 120
		PinNull
		' Token: 0x04000079 RID: 121
		d28bit = 10
		' Token: 0x0400007A RID: 122
		d32bit
		' Token: 0x0400007B RID: 123
		d36bit
		' Token: 0x0400007C RID: 124
		d40bit
		' Token: 0x0400007D RID: 125
		d44bit
		' Token: 0x0400007E RID: 126
		d48bit
		' Token: 0x0400007F RID: 127
		d24rhbit
		' Token: 0x04000080 RID: 128
		d32rhbit
		' Token: 0x04000081 RID: 129
		d48rhbit
		' Token: 0x04000082 RID: 130
		d24rnbit
		' Token: 0x04000083 RID: 131
		d32rnbit
		' Token: 0x04000084 RID: 132
		d48rnbit
	End Enum
End Module
