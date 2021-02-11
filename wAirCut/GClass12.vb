Imports System
Imports Microsoft.VisualBasic.CompilerServices

' Token: 0x0200002A RID: 42
Public Class GClass12
	' Token: 0x0600030A RID: 778 RVA: 0x00004209 File Offset: 0x00002409
	Public Sub New()
		Me.Type = GClass12.GEnum5.Manual
		Me._description = ""
		Me.string_0 = ""
		Me.genum0_0 = GClass3.GEnum0.[Nothing]
		Me.gclass11_0 = New GClass11()
	End Sub

	' Token: 0x0600030B RID: 779 RVA: 0x000128C8 File Offset: 0x00010AC8
	Public Sub New(string_1 As String, genum5_0 As GClass12.GEnum5)
		Me.Type = GClass12.GEnum5.Manual
		Me._description = ""
		Me.string_0 = ""
		Me.genum0_0 = GClass3.GEnum0.[Nothing]
		Me.gclass11_0 = New GClass11()
		Me.string_0 = string_1
		Me.Type = genum5_0
	End Sub

	' Token: 0x0600030C RID: 780 RVA: 0x00012918 File Offset: 0x00010B18
	Public Sub New(genum5_0 As GClass12.GEnum5, gclass11_1 As GClass11)
		Me.Type = GClass12.GEnum5.Manual
		Me._description = ""
		Me.string_0 = ""
		Me.genum0_0 = GClass3.GEnum0.[Nothing]
		Me.gclass11_0 = New GClass11()
		Me.Type = genum5_0
		Me.gclass11_0 = gclass11_1
	End Sub

	' Token: 0x0600030D RID: 781 RVA: 0x00012968 File Offset: 0x00010B68
	Public Sub New(string_1 As String, genum5_0 As GClass12.GEnum5, gclass11_1 As GClass11)
		Me.Type = GClass12.GEnum5.Manual
		Me._description = ""
		Me.string_0 = ""
		Me.genum0_0 = GClass3.GEnum0.[Nothing]
		Me.gclass11_0 = New GClass11()
		Me.string_0 = string_1
		Me.Type = genum5_0
		Me.gclass11_0 = gclass11_1
	End Sub

	' Token: 0x0600030E RID: 782 RVA: 0x000129C0 File Offset: 0x00010BC0
	Public Sub New(string_1 As String, genum0_1 As GClass3.GEnum0)
		Me.Type = GClass12.GEnum5.Manual
		Me._description = ""
		Me.string_0 = ""
		Me.genum0_0 = GClass3.GEnum0.[Nothing]
		Me.gclass11_0 = New GClass11()
		Me.string_0 = string_1
		Me.Type = GClass12.GEnum5.Algorithm
		Me.genum0_0 = genum0_1
	End Sub

	' Token: 0x0600030F RID: 783 RVA: 0x00012A18 File Offset: 0x00010C18
	Public Sub New(string_1 As String, genum0_1 As GClass3.GEnum0, gclass11_1 As GClass11)
		Me.Type = GClass12.GEnum5.Manual
		Me._description = ""
		Me.string_0 = ""
		Me.genum0_0 = GClass3.GEnum0.[Nothing]
		Me.gclass11_0 = New GClass11()
		Me.string_0 = string_1
		Me.Type = GClass12.GEnum5.Algorithm
		Me.genum0_0 = genum0_1
		Me.gclass11_0 = gclass11_1
	End Sub

	' Token: 0x17000150 RID: 336
	' (get) Token: 0x06000310 RID: 784 RVA: 0x00012A78 File Offset: 0x00010C78
	' (set) Token: 0x06000311 RID: 785 RVA: 0x00004240 File Offset: 0x00002440
	Public Property Description As String
		Get
			Me._description = Me.Type.ToString()
			If Operators.CompareString(Me.gclass11_0.string_1, "", False) <> 0 Then
				Dim ptr As String = Me._description
				Me._description = ptr + " | " + Me.gclass11_0.string_1
			End If
			If Operators.CompareString(Me.gclass11_0.string_2, "", False) <> 0 AndAlso Operators.CompareString(Me._description, "", False) <> 0 Then
				Dim ptr As String = Me._description
				Me._description = ptr + " | " + Me.gclass11_0.string_2
			End If
			If Me.genum0_0 <> GClass3.GEnum0.[Nothing] Then
				If Operators.CompareString(Me._description, "", False) <> 0 Then
					Dim ptr As String = Me._description
					Me._description = ptr + " | " + Me.genum0_0.ToString()
				End If
			End If
			If Me.Type = GClass12.GEnum5.PixieDust Then
				If Operators.CompareString(Me._description, "", False) <> 0 Then
					Dim ptr As String = Me._description
					Me._description = ptr + " | " + GClass12.GEnum5.PixieDust.ToString()
				End If
			End If
			Return Me._description
		End Get
		Set(value As String)
			Me._description = value
		End Set
	End Property

	' Token: 0x17000151 RID: 337
	' (get) Token: 0x06000312 RID: 786 RVA: 0x00004249 File Offset: 0x00002449
	' (set) Token: 0x06000313 RID: 787 RVA: 0x00004251 File Offset: 0x00002451
	Public Property Pin As String
		Get
			Return Me.string_0
		End Get
		Set(value As String)
			Me.string_0 = value
		End Set
	End Property

	' Token: 0x06000314 RID: 788 RVA: 0x00012BAC File Offset: 0x00010DAC
	Public Overridable Function Equals(obj As Object) As Boolean
		Dim gclass As GClass12 = TryCast(obj, GClass12)
		Return gclass IsNot Nothing AndAlso gclass.Pin.Equals(Me.Pin)
	End Function

	' Token: 0x06000315 RID: 789 RVA: 0x0000425A File Offset: 0x0000245A
	Public Overridable Function GetHashCode() As Integer
		Return Me.Pin.GetHashCode()
	End Function

	' Token: 0x0400014F RID: 335
	Public Type As GClass12.GEnum5

	' Token: 0x04000150 RID: 336
	Private _description As String

	' Token: 0x04000151 RID: 337
	Private string_0 As String

	' Token: 0x04000152 RID: 338
	Public genum0_0 As GClass3.GEnum0

	' Token: 0x04000153 RID: 339
	Public gclass11_0 As GClass11

	' Token: 0x0200002B RID: 43
	Public Enum GEnum5
		' Token: 0x04000155 RID: 341
		Manual
		' Token: 0x04000156 RID: 342
		Generic
		' Token: 0x04000157 RID: 343
		Algorithm
		' Token: 0x04000158 RID: 344
		PixieDust
		' Token: 0x04000159 RID: 345
		BruteForce
		' Token: 0x0400015A RID: 346
		PushButton
	End Enum
End Class
