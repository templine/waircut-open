Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

' Token: 0x02000034 RID: 52
Public Class GClass14
	Inherits Label

	' Token: 0x17000180 RID: 384
	' (get) Token: 0x060003AE RID: 942 RVA: 0x000045DA File Offset: 0x000027DA
	' (set) Token: 0x060003AF RID: 943 RVA: 0x00016918 File Offset: 0x00014B18
	Private Overridable Property Timer_0 As Timer
		<CompilerGenerated()>
		Get
			Return Me.timer_0
		End Get
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Set(value As Timer)
			Dim value2 As EventHandler = AddressOf Me.method_2
			Dim timer As Timer = Me.timer_0
			If timer IsNot Nothing Then
				RemoveHandler timer.Tick, value2
			End If
			Me.timer_0 = value
			timer = Me.timer_0
			If timer IsNot Nothing Then
				AddHandler timer.Tick, value2
			End If
		End Set
	End Property

	' Token: 0x060003B0 RID: 944 RVA: 0x0001695C File Offset: 0x00014B5C
	Public Sub New()
		Me.Timer_0 = New Timer()
		Me.int_0 = MyBase.Width
		Me.int_1 = CInt(Math.Round(CDbl((CSng(MyBase.Height) - Me.sizeF_0.Height / 2F))))
		Me.list_0 = New List(Of String)()
		Me.DoubleBuffered = True
		Me.int_0 = MyBase.Width
		Me.Timer_0.Interval = 200
		Me.Timer_0.Start()
		If Me.GEnum7_0 = GClass14.GEnum7.vertical Then
			Me.int_1 = CInt(Math.Round(CDbl(MyBase.Height) / 2.0))
		End If
	End Sub

	' Token: 0x060003B1 RID: 945 RVA: 0x00016A10 File Offset: 0x00014C10
	Protected Overridable Sub OnPaint(e As PaintEventArgs)
		Me.method_0()
		Using solidBrush As SolidBrush = New SolidBrush(Me.ForeColor)
			Dim genum As GClass14.GEnum7 = Me.genum7_0
			If genum <> GClass14.GEnum7.horizontal Then
				If genum <> GClass14.GEnum7.vertical Then
					Return
				End If
				Me.sizeF_0 = e.Graphics.MeasureString(Me.Text, Me.Font)
				Dim num As Integer = Me.int_1
				Try
					Dim enumerator As List(Of String).Enumerator = Me.list_0.GetEnumerator()
					IL_275:
					While enumerator.MoveNext()
						Dim text As String
						While True
							IL_153:
							text = enumerator.Current
							While True
								IL_143:
								Dim textAlign As ContentAlignment = Me.TextAlign
								If textAlign > ContentAlignment.MiddleCenter Then
									GoTo Block_12
								End If
								While True
									IL_125:
									Select Case textAlign
										Case ContentAlignment.TopLeft
											GoTo IL_192
										Case ContentAlignment.TopCenter
											GoTo IL_1A9
										Case CType(3, ContentAlignment)
											GoTo IL_224
										Case ContentAlignment.TopRight
											GoTo IL_1E2
										Case Else
											Dim num3 As UInteger
											Dim num2 As Integer = CInt((num3 * 3534347052UI Xor 3729251263UI))
											While True
												Dim num4 As Integer = num2 Xor -1510963182
												num3 = CUInt(num4)
												Select Case num4 Mod 22
													Case 0
														GoTo IL_1A9
													Case 1
														num2 = CInt((If((textAlign = ContentAlignment.MiddleLeft), 3795029050UI, 2683898963UI) Xor num3 * 3972945967UI))
														Continue For
													Case 2, 13, 18
														GoTo IL_275
													Case 3
														GoTo IL_192
													Case 4
														GoTo IL_125
													Case 5, 9, 12
														GoTo IL_224
													Case 6
														GoTo IL_167
													Case 7
														GoTo IL_242
													Case 8
														num2 = CInt((num3 * 2137640444UI Xor 513112017UI))
														Continue For
													Case 10
														num2 = CInt((If((textAlign = ContentAlignment.MiddleCenter), 2211913550UI, 2576379918UI) Xor num3 * 1822409120UI))
														Continue For
													Case 11
														GoTo IL_1E2
													Case 14
														GoTo IL_184
													Case 15
														GoTo IL_170
													Case 16
														GoTo IL_143
													Case 19
														GoTo IL_15E
													Case 20
														GoTo IL_153
													Case 21
														GoTo IL_17E
												End Select
												GoTo Block_10
											End While
									End Select
								End While
							End While
						End While
						IL_242:
						num = CInt(Math.Round(CDbl(num) + CDbl(e.Graphics.MeasureString(text, Me.Font).Height) * 1.3))
						Continue While
						IL_224:
						e.Graphics.DrawString(text, Me.Font, solidBrush, CSng(Me.int_0), CSng(num))
						GoTo IL_242
						Block_10:
						Exit While
						IL_170:
						Dim textAlign As ContentAlignment
						If textAlign <> ContentAlignment.BottomRight Then
							GoTo IL_224
						End If
						GoTo IL_1E2
						IL_167:
						If textAlign <> ContentAlignment.BottomCenter Then
							GoTo IL_170
						End If
						GoTo IL_1A9
						IL_15E:
						If textAlign > ContentAlignment.BottomLeft Then
							GoTo IL_167
						End If
						GoTo IL_17E
						Block_12:
						GoTo IL_15E
						IL_184:
						If textAlign <> ContentAlignment.BottomLeft Then
							GoTo IL_224
						End If
						GoTo IL_192
						IL_17E:
						If textAlign <> ContentAlignment.MiddleRight Then
							GoTo IL_184
						End If
						GoTo IL_1E2
						IL_192:
						Me.int_0 = MyBase.Margin.Left
						GoTo IL_224
						IL_1A9:
						Me.int_0 = CInt(Math.Round(CDbl((CSng(MyBase.Width) - e.Graphics.MeasureString(text, Me.Font).Width / 2F))))
						GoTo IL_224
						IL_1E2:
						Me.int_0 = CInt(Math.Round(CDbl((CSng(MyBase.Width) - e.Graphics.MeasureString(text, Me.Font).Width - CSng(MyBase.Margin.Right)))))
						GoTo IL_224
					End While
					Return
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
			Dim text2 As String = ""
			Try
				For Each str As String In Me.list_0
					text2 = text2 + str + " "
				Next
			Finally
				Dim enumerator2 As List(Of String).Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			Me.sizeF_0 = e.Graphics.MeasureString(text2, Me.Font)
			e.Graphics.DrawString(text2, Me.Font, solidBrush, CSng(Me.int_0), CSng(Me.int_1))
		End Using
	End Sub

	' Token: 0x060003B2 RID: 946 RVA: 0x00016D88 File Offset: 0x00014F88
	Private Sub method_0()
		Dim text As String = ""
		Dim separator As Char() = New Char() { " "c, vbCr }
		Dim array As String() = Me.Text.Split(separator)
		Dim graphics As Graphics = MyBase.CreateGraphics()
		Me.list_0.Clear()
		For Each text2 As String In array
			If graphics.MeasureString(text + text2, Me.Font).Width < CSng(MyBase.Width) And Not text2.Contains(vbLf) And Not text2.Contains(vbCr) And Not text2.Contains(vbCrLf) Then
				text = text + text2 + " "
			Else
				Me.list_0.Add(text)
				text2 = text2.Replace(vbLf, "")
				text2 = text2.Replace(vbCr, "")
				text2 = text2.Replace(vbCrLf, "")
				text = text2 + " "
			End If
		Next
		If Operators.CompareString(text, "", False) <> 0 Then
			Me.list_0.Add(text)
		End If
	End Sub

	' Token: 0x060003B3 RID: 947 RVA: 0x00016EC0 File Offset: 0x000150C0
	Private Sub method_1()
		Me.Timer_0.[Stop]()
		Dim genum As GClass14.GEnum7 = Me.genum7_0
		If genum <> GClass14.GEnum7.horizontal Then
			If genum = GClass14.GEnum7.vertical Then
				Me.int_0 = 0
				If CDbl(Me.int_1) >= -(CDbl(((Me.list_0.Count + 1) * Me.Font.Height)) * 1.3) Then
					Dim ptr As Integer = Me.int_1
					Me.int_1 = ptr - 1
				Else
					Me.int_1 = MyBase.Height
				End If
			End If
		Else
			' The following expression was wrapped in a checked-expression
			Me.int_1 = CInt(Math.Round(CDbl((MyBase.Height - Me.Font.Height)) / 2.0))
			If CSng(Me.int_0) < -Me.sizeF_0.Width Then
				Me.int_0 = MyBase.Width
			Else
				Dim ptr As Integer = Me.int_0
				Me.int_0 = ptr - 1
			End If
		End If
		MyBase.Invalidate()
		Me.Timer_0.Start()
	End Sub

	' Token: 0x17000181 RID: 385
	' (get) Token: 0x060003B4 RID: 948 RVA: 0x000045E2 File Offset: 0x000027E2
	' (set) Token: 0x060003B5 RID: 949 RVA: 0x000045EF File Offset: 0x000027EF
	<Browsable(True)>
	<EditorBrowsable(EditorBrowsableState.Always)>
	<Category("Behavior")>
	Public Property Int32_0 As Integer
		Get
			Return Me.Timer_0.Interval
		End Get
		Set(value As Integer)
			Me.Timer_0.Interval = value
		End Set
	End Property

	' Token: 0x17000182 RID: 386
	' (get) Token: 0x060003B6 RID: 950 RVA: 0x000045FD File Offset: 0x000027FD
	' (set) Token: 0x060003B7 RID: 951 RVA: 0x00004605 File Offset: 0x00002805
	<Category("Appearance")>
	<EditorBrowsable(EditorBrowsableState.Always)>
	<Browsable(True)>
	Public Property GEnum7_0 As GClass14.GEnum7
		Get
			Return Me.genum7_0
		End Get
		Set(value As GClass14.GEnum7)
			Me.genum7_0 = value
		End Set
	End Property

	' Token: 0x060003B8 RID: 952 RVA: 0x0000460E File Offset: 0x0000280E
	<CompilerGenerated()>
	Private Sub method_2(sender As Object, e As EventArgs)
		Me.method_1()
	End Sub

	' Token: 0x040001B4 RID: 436
	<CompilerGenerated()>
	<AccessedThroughProperty("tick")>
	Private timer_0 As Timer

	' Token: 0x040001B5 RID: 437
	Private int_0 As Integer

	' Token: 0x040001B6 RID: 438
	Private int_1 As Integer

	' Token: 0x040001B7 RID: 439
	Private sizeF_0 As SizeF

	' Token: 0x040001B8 RID: 440
	Private list_0 As List(Of String)

	' Token: 0x040001B9 RID: 441
	Private genum7_0 As GClass14.GEnum7

	' Token: 0x02000035 RID: 53
	Public Enum GEnum7
		' Token: 0x040001BB RID: 443
		horizontal
		' Token: 0x040001BC RID: 444
		vertical
	End Enum
End Class
