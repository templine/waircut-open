Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

' Token: 0x02000012 RID: 18
Public Class GClass4
	' Token: 0x06000186 RID: 390 RVA: 0x00008920 File Offset: 0x00006B20
	Private Function method_0(string_0 As String, int_0 As Integer) As Byte()
		Dim hashAlgorithm As HashAlgorithm = New SHA1CryptoServiceProvider()
		Dim bytes As Byte() = Encoding.Unicode.GetBytes(string_0)
		Return CType(Utils.CopyArray(hashAlgorithm.ComputeHash(bytes), New Byte(int_0 - 1 + 1 - 1) {}), Byte())
	End Function

	' Token: 0x06000187 RID: 391 RVA: 0x00008958 File Offset: 0x00006B58
	Public Sub New(string_0 As String)
		Me.tripleDESCryptoServiceProvider_0 = New TripleDESCryptoServiceProvider()
		Me.tripleDESCryptoServiceProvider_0.Key = Me.method_0(string_0, Me.tripleDESCryptoServiceProvider_0.KeySize / 8)
		Me.tripleDESCryptoServiceProvider_0.IV = Me.method_0("", Me.tripleDESCryptoServiceProvider_0.BlockSize / 8)
	End Sub

	' Token: 0x06000188 RID: 392 RVA: 0x000089B8 File Offset: 0x00006BB8
	Public Function method_1(ByRef byte_0 As Byte()) As Byte()
		Dim memoryStream As MemoryStream = New MemoryStream()
		Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.tripleDESCryptoServiceProvider_0.CreateEncryptor(), CryptoStreamMode.Write)
		cryptoStream.Write(byte_0, 0, byte_0.Length)
		cryptoStream.FlushFinalBlock()
		Return memoryStream.ToArray()
	End Function

	' Token: 0x06000189 RID: 393 RVA: 0x000089F8 File Offset: 0x00006BF8
	Public Function method_2(ByRef byte_0 As Byte()) As Byte()
		Dim memoryStream As MemoryStream = New MemoryStream()
		Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.tripleDESCryptoServiceProvider_0.CreateDecryptor(), CryptoStreamMode.Write)
		cryptoStream.Write(byte_0, 0, byte_0.Length)
		cryptoStream.FlushFinalBlock()
		Return memoryStream.ToArray()
	End Function

	' Token: 0x0600018A RID: 394 RVA: 0x00008A38 File Offset: 0x00006C38
	Public Function method_3(string_0 As String) As MemoryStream
		Dim array As Byte() = File.ReadAllBytes(string_0)
		Return New MemoryStream(Me.method_2(array))
	End Function

	' Token: 0x04000085 RID: 133
	Private tripleDESCryptoServiceProvider_0 As TripleDESCryptoServiceProvider
End Class
