Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

' Token: 0x0200002F RID: 47
Public Class GClass13
	' Token: 0x06000357 RID: 855 RVA: 0x00004407 File Offset: 0x00002607
	Public Sub New()
		Me.random_0 = New Random()
		Me.list_0 = New List(Of String)()
	End Sub

	' Token: 0x06000358 RID: 856 RVA: 0x00013F10 File Offset: 0x00012110
	Public Function method_0(bool_0 As Boolean) As Object
		Dim result As Object
		If bool_0 Then
			result = 11000
		Else
			result = 20000
		End If
		Return result
	End Function

	' Token: 0x06000359 RID: 857 RVA: 0x00013F3C File Offset: 0x0001213C
	Private Sub method_1(bool_0 As Boolean)
		' The following expression was wrapped in a checked-statement
		If bool_0 Then
			Dim num As Integer = 0
			Do
				Dim num2 As Integer = num * 1000 + Me.random_0.[Next](0, 999)
				num2 = num2 * 10 + GClass3.smethod_0(num2)
				Me.list_0.Add(num2.ToString("00000000"))
				num += 1
			Loop While num <= 9999
			Return
		End If
		Dim num3 As Integer = 0
		Do
			Me.list_0.Add((num3 * 10000 + Me.random_0.[Next](0, 9999)).ToString("00000000"))
			num3 += 1
		Loop While num3 <= 9999
	End Sub

	' Token: 0x0600035A RID: 858 RVA: 0x00013FE0 File Offset: 0x000121E0
	Private Sub method_2(string_0 As String, bool_0 As Boolean)
		' The following expression was wrapped in a checked-statement
		If bool_0 Then
			Dim num As Integer = 0
			Do
				' The following expression was wrapped in a unchecked-expression
				Dim num2 As Integer = CInt(Math.Round(Conversions.ToDouble(string_0) * 1000.0 + CDbl(num)))
				num2 = num2 * 10 + GClass3.smethod_0(Conversions.ToInteger(num2.ToString("0000000")))
				Me.list_0.Add(Conversions.ToString(num2))
				num += 1
			Loop While num <= 999
			Return
		End If
		Dim num3 As Integer = 0
		Do
			' The following expression was wrapped in a unchecked-expression
			Me.list_0.Add((Conversions.ToDouble(string_0) * 10000.0 + CDbl(num3)).ToString("00000000"))
			num3 += 1
		Loop While num3 <= 9999
	End Sub

	' Token: 0x0600035B RID: 859 RVA: 0x00014088 File Offset: 0x00012288
	Public Function method_3(bool_0 As Boolean) As List(Of String)
		Dim list As List(Of String) = New List(Of String)()
		Me.method_1(bool_0)
		Dim num As Integer = Me.list_0.Count - 1
		For i As Integer = 0 To num
			Dim index As Integer = Me.random_0.[Next](0, Me.list_0.Count - 1)
			list.Add(Me.list_0(index))
			Me.list_0.RemoveAt(index)
		Next
		Return list
	End Function

	' Token: 0x0600035C RID: 860 RVA: 0x000140F8 File Offset: 0x000122F8
	Public Function method_4(string_0 As String, string_1 As String) As List(Of String)
		Dim text As String = string_0 + string_1
		Dim bool_ As Boolean = Operators.CompareString(Conversions.ToString(text.Last()), "C", False) = 0
		Dim list As List(Of String) = New List(Of String)()
		If string_0.Contains("?") Or string_0.Contains("[") Then
			Me.method_1(bool_)
		Else
			Me.method_2(Conversions.ToString(Conversions.ToUInteger(string_0)), bool_)
		End If
		text = text.Replace("C", "?")
		Dim num As Integer = Me.list_0.Count - 1
		For i As Integer = 0 To num
			Dim index As Integer = Me.random_0.[Next](0, Me.list_0.Count - 1)
			If LikeOperator.LikeString(Me.list_0(index), text, CompareMethod.Binary) Then
				list.Add(Me.list_0(index))
			End If
			Me.list_0.RemoveAt(index)
		Next
		Return list
	End Function

	' Token: 0x0600035D RID: 861 RVA: 0x000141E4 File Offset: 0x000123E4
	Public Function method_5(int_2 As Integer, bool_0 As Boolean) As List(Of String)
		Dim list As List(Of String) = New List(Of String)()
		Me.method_2(Conversions.ToString(int_2), bool_0)
		Dim num As Integer = Me.list_0.Count - 1
		For i As Integer = 0 To num
			Dim index As Integer = Me.random_0.[Next](0, Me.list_0.Count - 1)
			list.Add(Me.list_0(index))
			Me.list_0.RemoveAt(index)
		Next
		Return list
	End Function

	' Token: 0x04000173 RID: 371
	Private Const int_0 As Integer = 10000

	' Token: 0x04000174 RID: 372
	Private Const int_1 As Integer = 1000

	' Token: 0x04000175 RID: 373
	Private random_0 As Random

	' Token: 0x04000176 RID: 374
	Private list_0 As List(Of String)
End Class
