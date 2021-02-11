Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

' Token: 0x02000037 RID: 55
Public Class GClass16(Of T)
	Inherits Comparer(Of T)

	' Token: 0x060003C1 RID: 961 RVA: 0x00004649 File Offset: 0x00002849
	Public Sub New(propertyDescriptor_1 As PropertyDescriptor, listSortDirection_1 As ListSortDirection)
		Me.propertyDescriptor_0 = propertyDescriptor_1
		Me.listSortDirection_0 = listSortDirection_1
	End Sub

	' Token: 0x060003C2 RID: 962 RVA: 0x00017070 File Offset: 0x00015270
	Public Overridable Function Compare(x As T, y As T) As Integer
		Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.method_4(x, Me.propertyDescriptor_0.Name))
		Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Me.method_4(y, Me.propertyDescriptor_0.Name))
		Dim result As Integer
		If Me.listSortDirection_0 = ListSortDirection.Ascending Then
			result = Me.method_2(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(objectValue2))
		Else
			result = Me.method_3(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(objectValue2))
		End If
		Return result
	End Function

	' Token: 0x060003C3 RID: 963 RVA: 0x0000465F File Offset: 0x0000285F
	Public Function method_0(gparam_0 As T, gparam_1 As T) As Boolean
		Return gparam_0.Equals(gparam_1)
	End Function

	' Token: 0x060003C4 RID: 964 RVA: 0x00004674 File Offset: 0x00002874
	Public Function method_1(gparam_0 As T) As Integer
		Return gparam_0.GetHashCode()
	End Function

	' Token: 0x060003C5 RID: 965 RVA: 0x000170E0 File Offset: 0x000152E0
	Private Function method_2(object_0 As Object, object_1 As Object) As Integer
		Dim result As Integer
		If TypeOf object_0 Is IComparable Then
			result = CType(object_0, IComparable).CompareTo(RuntimeHelpers.GetObjectValue(object_1))
		ElseIf Not object_0.Equals(RuntimeHelpers.GetObjectValue(object_1)) Then
			result = object_0.ToString().CompareTo(object_1.ToString())
		Else
			result = 0
		End If
		Return result
	End Function

	' Token: 0x060003C6 RID: 966 RVA: 0x00004683 File Offset: 0x00002883
	Private Function method_3(object_0 As Object, object_1 As Object) As Integer
		' The following expression was wrapped in a checked-expression
		Return Me.method_2(RuntimeHelpers.GetObjectValue(object_0), RuntimeHelpers.GetObjectValue(object_1)) * -1
	End Function

	' Token: 0x060003C7 RID: 967 RVA: 0x00004699 File Offset: 0x00002899
	Private Function method_4(gparam_0 As T, string_0 As String) As Object
		Return gparam_0.[GetType]().GetProperty(string_0).GetValue(gparam_0, Nothing)
	End Function

	' Token: 0x040001C0 RID: 448
	Private propertyDescriptor_0 As PropertyDescriptor

	' Token: 0x040001C1 RID: 449
	Private listSortDirection_0 As ListSortDirection
End Class
