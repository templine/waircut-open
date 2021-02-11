Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

' Token: 0x02000036 RID: 54
Public Class GClass15(Of T)
	Inherits BindingList(Of T)

	' Token: 0x060003B9 RID: 953 RVA: 0x00004616 File Offset: 0x00002816
	Public Sub New()
		Me.bool_0 = False
	End Sub

	' Token: 0x17000183 RID: 387
	' (get) Token: 0x060003BA RID: 954 RVA: 0x00004625 File Offset: 0x00002825
	Protected Overridable ReadOnly Property SupportsSortingCore As Boolean
		Get
			Return True
		End Get
	End Property

	' Token: 0x17000184 RID: 388
	' (get) Token: 0x060003BB RID: 955 RVA: 0x00004628 File Offset: 0x00002828
	Protected Overridable ReadOnly Property IsSortedCore As Boolean
		Get
			Return Me.bool_0
		End Get
	End Property

	' Token: 0x060003BC RID: 956 RVA: 0x00004630 File Offset: 0x00002830
	Protected Overridable Sub RemoveSortCore()
		Me.bool_0 = False
	End Sub

	' Token: 0x060003BD RID: 957 RVA: 0x00016FA8 File Offset: 0x000151A8
	Public Sub method_0(ienumerable_0 As IEnumerable(Of T))
		Try
			For Each item As T In ienumerable_0
				MyBase.Items.Add(item)
			Next
		Finally
			Dim enumerator As IEnumerator(Of T)
			If enumerator IsNot Nothing Then
				enumerator.Dispose()
			End If
		End Try
	End Sub

	' Token: 0x060003BE RID: 958 RVA: 0x00016FF8 File Offset: 0x000151F8
	Protected Overridable Sub ApplySortCore(prop As PropertyDescriptor, direction As ListSortDirection)
		Dim list As List(Of T) = TryCast(MyBase.Items, List(Of T))
		Try
			If list IsNot Nothing Then
				Me.listSortDirection_0 = direction
				Me.propertyDescriptor_0 = prop
				Dim comparer As GClass16(Of T) = New GClass16(Of T)(prop, direction)
				list.Sort(comparer)
				Me.bool_0 = True
			Else
				Me.bool_0 = False
			End If
			Me.OnListChanged(New ListChangedEventArgs(ListChangedType.Reset, -1))
		Catch ex As Exception
		End Try
	End Sub

	' Token: 0x17000185 RID: 389
	' (get) Token: 0x060003BF RID: 959 RVA: 0x00004639 File Offset: 0x00002839
	Protected Overridable ReadOnly Property SortPropertyCore As PropertyDescriptor
		Get
			Return Me.propertyDescriptor_0
		End Get
	End Property

	' Token: 0x17000186 RID: 390
	' (get) Token: 0x060003C0 RID: 960 RVA: 0x00004641 File Offset: 0x00002841
	Protected Overridable ReadOnly Property SortDirectionCore As ListSortDirection
		Get
			Return Me.listSortDirection_0
		End Get
	End Property

	' Token: 0x040001BD RID: 445
	Private bool_0 As Boolean

	' Token: 0x040001BE RID: 446
	Private listSortDirection_0 As ListSortDirection

	' Token: 0x040001BF RID: 447
	Private propertyDescriptor_0 As PropertyDescriptor
End Class
