Imports System
Imports System.Collections
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.ServiceProcess
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

' Token: 0x0200003A RID: 58
Friend NotInheritable Module Class13
	' Token: 0x17000195 RID: 405
	' (get) Token: 0x060003F1 RID: 1009 RVA: 0x000179E4 File Offset: 0x00015BE4
	Public ReadOnly Property Version As String
		Get
			Dim text As String = String.Format("{0}.{1}", Class6.Form0_0.Info.Version.Major, Class6.Form0_0.Info.Version.Minor)
			If Class13.bool_0 Then
				text += " beta"
			End If
			Return text
		End Get
	End Property

	' Token: 0x060003F2 RID: 1010 RVA: 0x00017A44 File Offset: 0x00015C44
	Public Function smethod_0(gclass15_0 As GClass15(Of GClass9)) As String
		Dim text As String = ""
		Dim format As String = "{0}       {1,3}      {2,4}     {3,5}         {4}" & vbCrLf
		text += "BSSID     " & vbTab & "         Channel    RSSI    WPS Locked    ESSID" & vbCrLf
		text += "-------------------------------------------------------------------------------------" & vbCrLf
		Dim num As Integer = gclass15_0.Count - 1
		For i As Integer = 0 To num
			text += String.Format(format, New Object() { gclass15_0(i).BSSID, gclass15_0(i).Channel, gclass15_0(i).RSSI, gclass15_0(i).ApSetupLocked, gclass15_0(i).SSID })
		Next
		Return text
	End Function

	' Token: 0x060003F3 RID: 1011 RVA: 0x00017AF0 File Offset: 0x00015CF0
	Public Function smethod_1(byte_0 As Byte()) As String
		Dim text As String = ""
		Dim num As Integer = byte_0.Length - 1
		For i As Integer = 0 To num
			If i > 0 And i < byte_0.Length Then
				text += ":"
			End If
			text += byte_0(i).ToString("X2")
		Next
		Return text
	End Function

	' Token: 0x060003F4 RID: 1012 RVA: 0x00017B48 File Offset: 0x00015D48
	Public Sub smethod_2(string_9 As String)
		Dim serviceController As ServiceController = New ServiceController(string_9)
		If serviceController.Status.Equals(ServiceControllerStatus.Running) Then
			Try
				serviceController.[Stop]()
				serviceController.WaitForStatus(ServiceControllerStatus.Stopped)
			Catch ex As Exception
			End Try
		End If
	End Sub

	' Token: 0x060003F5 RID: 1013 RVA: 0x00017BA8 File Offset: 0x00015DA8
	Public Sub smethod_3(string_9 As String)
		Dim serviceController As ServiceController = New ServiceController(string_9)
		Try
			serviceController.[Stop]()
			serviceController.WaitForStatus(ServiceControllerStatus.Stopped)
			serviceController.Start()
			serviceController.WaitForStatus(ServiceControllerStatus.Running)
		Catch ex As Exception
		End Try
	End Sub

	' Token: 0x060003F6 RID: 1014 RVA: 0x00004858 File Offset: 0x00002A58
	Public Function smethod_4() As Boolean
		Return Environment.OSVersion.Version.Major >= 6
	End Function

	' Token: 0x060003F7 RID: 1015 RVA: 0x00017BF8 File Offset: 0x00015DF8
	Public Function smethod_5() As Boolean
		Dim text As String = GClass0.String_0
		Dim serviceController As ServiceController = New ServiceController(text)
		Dim text2 As String = ""
		Dim result As Boolean = False
		Try
			Dim left As String = Class13.smethod_6(AppDomain.CurrentDomain.BaseDirectory + "\es\wAirCut.resources.dll")
			If Operators.CompareString(left, "908576645D406E5D543E1F16428FCFDB", False) <> 0 Then
				MessageBox.Show("Resorce file is wrong", "Waircut", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			left = Class13.smethod_6(AppDomain.CurrentDomain.BaseDirectory + "\ru\wAirCut.resources.dll")
			If Operators.CompareString(left, "C994E6B19DB5C8A8E4D0549F79CE32A5", False) <> 0 Then
				MessageBox.Show("Resorce file is wrong", "Waircut", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			left = Class13.smethod_6(AppDomain.CurrentDomain.BaseDirectory + "\fr\wAirCut.resources.dll")
			If Operators.CompareString(left, "BF000AC77F51D507E038272A8E998290", False) <> 0 Then
				MessageBox.Show("Resorce file is wrong", "Waircut", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			If serviceController.DisplayName IsNot Nothing Then
				Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services")
				If registryKey IsNot Nothing Then
					Class13.smethod_2(text)
					registryKey.OpenSubKey(text).GetValue("ImagePath")
					text2 = Path.GetDirectoryName(registryKey.OpenSubKey(text).GetValue("ImagePath").ToString())
				End If
				If Operators.CompareString(text2, "", False) <> 0 Then
					left = Class13.smethod_6(text2 + "\jswscsup.dll")
					If Operators.CompareString(left, "1FB6E3E894EDDFF1B2277235BAB769E9", False) = 0 Then
						result = True
					Else
						Dim gclass As GClass4 = New GClass4(left)
						Dim byte_ As Byte() = GClass0.Byte_0
						Dim array As Byte() = gclass.method_2(byte_)
						left = Class13.smethod_7(array)
						If Operators.CompareString(left, "1FB6E3E894EDDFF1B2277235BAB769E9", False) <> 0 Then
							MessageBox.Show(Class10.String_56, "Jumpstart Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Return False
						End If
						Dim lastWriteTime As DateTime = File.GetLastWriteTime(text2 + "\jswscsup.dll")
						Dim creationTime As DateTime = File.GetCreationTime(text2 + "\jswscsup.dll")
						If Class6.Class5_0.FileSystem.FileExists(text2 + "\jswscsup-tmp.dll") Then
							Class6.Class5_0.FileSystem.DeleteFile(text2 + "\jswscsup-tmp.dll")
						End If
						Class6.Class5_0.FileSystem.RenameFile(text2 + "\jswscsup.dll", "jswscsup-tmp.dll")
						File.WriteAllBytes(text2 + "\jswscsup.dll", array)
						File.SetLastWriteTime(text2 + "\jswscsup.dll", lastWriteTime)
						File.SetCreationTime(text2 + "\jswscsup.dll", creationTime)
						If Class6.Class5_0.FileSystem.FileExists(text2 + "\jswscsup-tmp.dll") Then
							Class6.Class5_0.FileSystem.DeleteFile(text2 + "\jswscsup-tmp.dll")
						End If
						result = Class13.smethod_5()
					End If
				End If
			End If
		Catch ex As Exception
			MessageBox.Show(Class10.String_57, "Jumpstart Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Try
		Return result
	End Function

	' Token: 0x060003F8 RID: 1016 RVA: 0x0000486F File Offset: 0x00002A6F
	Public Function smethod_6(string_9 As String) As String
		Return Class13.smethod_7(File.ReadAllBytes(string_9))
	End Function

	' Token: 0x060003F9 RID: 1017 RVA: 0x00017EFC File Offset: 0x000160FC
	Public Function smethod_7(byte_0 As Byte()) As String
		Dim stream As Stream = New MemoryStream(byte_0)
		Dim md5CryptoServiceProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
		md5CryptoServiceProvider.ComputeHash(stream)
		stream.Close()
		Dim stringBuilder As StringBuilder = New StringBuilder()
		Dim num As Integer = md5CryptoServiceProvider.Hash.Length - 1
		For i As Integer = 0 To num
			stringBuilder.Append(md5CryptoServiceProvider.Hash(i).ToString("X2"))
		Next
		Return stringBuilder.ToString()
	End Function

	' Token: 0x060003FA RID: 1018 RVA: 0x00017F6C File Offset: 0x0001616C
	Public Function smethod_8(array_0 As Array, string_9 As String) As String
		Dim text As String = ""
		Try
			For Each obj As Object In array_0
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj)
				text = text + Conversion.Hex(RuntimeHelpers.GetObjectValue(objectValue)).PadLeft(2, "0"c) + string_9
			Next
		Finally
			Dim enumerator As IEnumerator
			If TypeOf enumerator Is IDisposable Then
				TryCast(enumerator, IDisposable).Dispose()
			End If
		End Try
		If Operators.CompareString(string_9, String.Empty, False) <> 0 Then
			' The following expression was wrapped in a checked-expression
			text = text.Substring(0, text.Length - 1)
		End If
		Return text
	End Function

	' Token: 0x060003FB RID: 1019 RVA: 0x00017FFC File Offset: 0x000161FC
	Public Function smethod_9(array_0 As Array, array_1 As Array) As String
		Dim array As Byte() = New Byte(31) {}
		Dim num As Integer = 0
		Do
			array(num) = Conversions.ToByte(Operators.XorObject(Operators.XorObject(NewLateBinding.LateIndexGet(array_0, New Object() { num + 3 }, Nothing), NewLateBinding.LateIndexGet(array_1, New Object() { num }, Nothing)), NewLateBinding.LateIndexGet(array_1, New Object() { 32 + num }, Nothing)))
			num += 1
		Loop While num <= 31
		Return Class13.smethod_8(array, ":")
	End Function

	' Token: 0x060003FC RID: 1020 RVA: 0x00018084 File Offset: 0x00016284
	Public Function smethod_10(genum16_0 As GEnum16) As String
		While True
			IL_C4:
			Select Case genum16_0
				Case GEnum16.JswMsgType_None
					GoTo IL_117
				Case GEnum16.JswMsgType_Beacon
					GoTo IL_11F
				Case GEnum16.JswMsgType_ProbeRequest
					GoTo IL_127
				Case GEnum16.JswMsgType_ProbeResponse
					GoTo IL_12F
				Case GEnum16.JswMsgType_M1
					GoTo IL_137
				Case GEnum16.JswMsgType_M2
					GoTo IL_13F
				Case GEnum16.JswMsgType_M2D
					GoTo IL_147
				Case GEnum16.JswMsgType_M3
					GoTo IL_14F
				Case GEnum16.JswMsgType_M4
					GoTo IL_157
				Case GEnum16.JswMsgType_M5
					GoTo IL_15F
				Case GEnum16.JswMsgType_M6
					GoTo IL_167
				Case GEnum16.JswMsgType_M7
					GoTo IL_16F
				Case GEnum16.JswMsgType_M8
					GoTo IL_177
				Case GEnum16.JswMsgType_WSC_ACK
					GoTo IL_17F
				Case GEnum16.JswMsgType_WSC_NACK
					GoTo IL_187
				Case GEnum16.JswMsgType_WSC_DONE
					GoTo IL_18F
				Case Else
					Dim num2 As UInteger
					Dim num As Integer = CInt((num2 * 2167104212UI Xor 1017883846UI))
					While True
						Dim num3 As Integer = num Xor 51483762
						num2 = CUInt(num3)
						Select Case num3 Mod 35
							Case 0
								GoTo IL_147
							Case 2
								GoTo IL_167
							Case 3
								GoTo IL_137
							Case 4
								GoTo IL_157
							Case 9, 31
								GoTo IL_C4
							Case 10
								GoTo IL_177
							Case 12
								GoTo IL_117
							Case 13
								GoTo IL_17F
							Case 15
								GoTo IL_15F
							Case 16
								GoTo IL_16F
							Case 18
								GoTo IL_12F
							Case 22
								GoTo IL_14F
							Case 23
								GoTo IL_13F
							Case 25
								num = CInt((num2 * 3737786953UI Xor 2751621205UI))
								Continue For
							Case 26
								GoTo IL_10F
							Case 27
								GoTo IL_187
							Case 28
								GoTo IL_18F
							Case 29
								GoTo IL_11F
							Case 34
								GoTo IL_127
						End Select
						GoTo Block_1
					End While
			End Select
		End While
		Block_1:
		Dim result As String
		Return result
		IL_10F:
		Return "Undefined"
		IL_117:
		Return "None"
		IL_11F:
		Return "Beacon frame"
		IL_127:
		Return "Probe request"
		IL_12F:
		Return "Probe response"
		IL_137:
		Return "M1"
		IL_13F:
		Return "M2"
		IL_147:
		Return "M2D"
		IL_14F:
		Return "M3"
		IL_157:
		Return "M4"
		IL_15F:
		Return "M5"
		IL_167:
		Return "M6"
		IL_16F:
		Return "M7"
		IL_177:
		Return "M8"
		IL_17F:
		Return "WSC ACK"
		IL_187:
		Return "WSC NACK"
		IL_18F:
		result = "WSC DONE"
		Return result
	End Function

	' Token: 0x060003FD RID: 1021 RVA: 0x00018228 File Offset: 0x00016428
	Public Function smethod_11(string_9 As String, ByRef gclass12_0 As GClass12) As Boolean
		Dim match As Match = New Regex("WPS pin:.*?(\w+)", RegexOptions.IgnoreCase Or RegexOptions.Singleline).Match(string_9)
		Dim result As Boolean
		If Not match.Success Then
			result = False
		Else
			If Operators.CompareString(match.Groups(1).ToString(), "empty", False) = 0 Then
				gclass12_0.Pin = ""
			Else
				gclass12_0.Pin = match.Groups(1).ToString()
			End If
			gclass12_0.Type = GClass12.GEnum5.PixieDust
			gclass12_0.genum0_0 = GClass3.GEnum0.[Nothing]
			gclass12_0.Description = gclass12_0.Type.ToString()
			result = True
		End If
		Return result
	End Function

	' Token: 0x060003FE RID: 1022 RVA: 0x0000487C File Offset: 0x00002A7C
	Public Function smethod_12(string_9 As String) As String
		Return New Regex("Jsw.*?_|{|}[\n\r\s]+", RegexOptions.IgnoreCase Or RegexOptions.Singleline).Replace(string_9, "")
	End Function

	' Token: 0x060003FF RID: 1023 RVA: 0x00004895 File Offset: 0x00002A95
	Public Function smethod_13(string_9 As String, string_10 As String) As String
		' The following expression was wrapped in a checked-expression
		Return string_9.Substring(0, string_9.Length / 2) + Strings.StrDup(string_9.Length - string_9.Length / 2, string_10)
	End Function

	' Token: 0x06000400 RID: 1024
	Private Declare Auto Function SendMessage Lib "user32.dll" (intptr_0 As IntPtr, int_3 As Integer, intptr_1 As IntPtr, intptr_2 As IntPtr) As Integer

	' Token: 0x06000401 RID: 1025 RVA: 0x000048C0 File Offset: 0x00002AC0
	Public Sub smethod_14(richTextBox_0 As RichTextBox)
		Class13.SendMessage(richTextBox_0.Handle, 277, CType(7, IntPtr), IntPtr.Zero)
	End Sub

	' Token: 0x06000402 RID: 1026 RVA: 0x000182C4 File Offset: 0x000164C4
	Public Sub smethod_15(string_9 As String, string_10 As String)
		Dim fileStream As FileStream = New FileStream(AppDomain.CurrentDomain.BaseDirectory + "\log\" + string_9, FileMode.Append, FileAccess.Write)
		Dim bytes As Byte() = New UTF8Encoding(True).GetBytes(string_10)
		fileStream.Write(bytes, 0, bytes.Length)
		fileStream.Close()
	End Sub

	' Token: 0x06000403 RID: 1027 RVA: 0x000048DE File Offset: 0x00002ADE
	Public Function smethod_16() As Boolean
		Return Class6.Class5_0.Network.IsAvailable
	End Function

	' Token: 0x040001D3 RID: 467
	Public string_0 As String() = New String() { " _  _  _       _            _                           _           ______           ", "| || || |     (_)          | |                     /\  (_)         / _____)     _    ", "| || || | ____ _  ____ ____| | ____  ___  ___     /  \  _  ____   | /     _   _| |_  ", "| ||_|| |/ _  | |/ ___) _  ) |/ _  )/___)/___)   / /\ \| |/ ___)  | |    | | | |  _) ", "| |___| ( ( | | | |  ( (/ /| ( (/ /|___ |___ |  | |__| | | |      | \____| |_| | |__ ", " \______|\_||_|_|_|   \____)_|\____|___/(___/   |______|_|_|       \______)____|\___)", "                                                                                     ", "                        ---   " + Class6.Form0_0.Info.Copyright + "    ---                          ", "     Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International      ", "                                                                                     " }

	' Token: 0x040001D4 RID: 468
	Public string_1 As String = ""

	' Token: 0x040001D5 RID: 469
	Public bool_0 As Boolean = False

	' Token: 0x040001D6 RID: 470
	Public string_2 As String = Environment.MachineName

	' Token: 0x040001D7 RID: 471
	Public string_3 As String = Environment.UserName

	' Token: 0x040001D8 RID: 472
	Public string_4 As String = vbCrLf + String.Format("{0}@{1}:#_> ", Class13.string_3, Class13.string_2)

	' Token: 0x040001D9 RID: 473
	Public bool_1 As Boolean = False

	' Token: 0x040001DA RID: 474
	Public string_5 As String = ""

	' Token: 0x040001DB RID: 475
	Public string_6 As String = ""

	' Token: 0x040001DC RID: 476
	Public int_0 As Integer = 0

	' Token: 0x040001DD RID: 477
	Public bool_2 As Boolean = False

	' Token: 0x040001DE RID: 478
	Public string_7 As String = "waircut.log"

	' Token: 0x040001DF RID: 479
	Public string_8 As String = "1FB6E3E894EDDFF1B2277235BAB769E9"

	' Token: 0x040001E0 RID: 480
	Private Const int_1 As Integer = 277

	' Token: 0x040001E1 RID: 481
	Private Const int_2 As Integer = 7
End Module
