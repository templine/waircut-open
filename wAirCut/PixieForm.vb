Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace wAirCut
	' Token: 0x0200002C RID: 44
	<DesignerGenerated()>
	Public Partial Class PixieForm
		Inherits Form

		' Token: 0x06000316 RID: 790 RVA: 0x00012BDC File Offset: 0x00010DDC
		<DebuggerNonUserCode()>
		Protected Overridable Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.icontainer_0 IsNot Nothing Then
					Me.icontainer_0.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x17000152 RID: 338
		' (get) Token: 0x06000318 RID: 792 RVA: 0x00004267 File Offset: 0x00002467
		' (set) Token: 0x06000319 RID: 793 RVA: 0x0001326C File Offset: 0x0001146C
		Friend Overridable Property cbMode As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cbMode
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.method_0
				Dim cbMode As ComboBox = Me._cbMode
				If cbMode IsNot Nothing Then
					RemoveHandler cbMode.SelectedIndexChanged, value2
				End If
				Me._cbMode = value
				cbMode = Me._cbMode
				If cbMode IsNot Nothing Then
					AddHandler cbMode.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000153 RID: 339
		' (get) Token: 0x0600031A RID: 794 RVA: 0x0000426F File Offset: 0x0000246F
		' (set) Token: 0x0600031B RID: 795 RVA: 0x00004277 File Offset: 0x00002477
		Friend Overridable Property Label1 As Label

		' Token: 0x17000154 RID: 340
		' (get) Token: 0x0600031C RID: 796 RVA: 0x00004280 File Offset: 0x00002480
		' (set) Token: 0x0600031D RID: 797 RVA: 0x00004288 File Offset: 0x00002488
		Friend Overridable Property dtpStart As DateTimePicker

		' Token: 0x17000155 RID: 341
		' (get) Token: 0x0600031E RID: 798 RVA: 0x00004291 File Offset: 0x00002491
		' (set) Token: 0x0600031F RID: 799 RVA: 0x00004299 File Offset: 0x00002499
		Friend Overridable Property Label2 As Label

		' Token: 0x17000156 RID: 342
		' (get) Token: 0x06000320 RID: 800 RVA: 0x000042A2 File Offset: 0x000024A2
		' (set) Token: 0x06000321 RID: 801 RVA: 0x000042AA File Offset: 0x000024AA
		Friend Overridable Property dtpEnd As DateTimePicker

		' Token: 0x17000157 RID: 343
		' (get) Token: 0x06000322 RID: 802 RVA: 0x000042B3 File Offset: 0x000024B3
		' (set) Token: 0x06000323 RID: 803 RVA: 0x000042BB File Offset: 0x000024BB
		Friend Overridable Property Label3 As Label

		' Token: 0x17000158 RID: 344
		' (get) Token: 0x06000324 RID: 804 RVA: 0x000042C4 File Offset: 0x000024C4
		' (set) Token: 0x06000325 RID: 805 RVA: 0x000132B0 File Offset: 0x000114B0
		Friend Overridable Property cbxForce As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._cbxForce
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.method_1
				Dim cbxForce As CheckBox = Me._cbxForce
				If cbxForce IsNot Nothing Then
					RemoveHandler cbxForce.CheckedChanged, value2
				End If
				Me._cbxForce = value
				cbxForce = Me._cbxForce
				If cbxForce IsNot Nothing Then
					AddHandler cbxForce.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000159 RID: 345
		' (get) Token: 0x06000326 RID: 806 RVA: 0x000042CC File Offset: 0x000024CC
		' (set) Token: 0x06000327 RID: 807 RVA: 0x000042D4 File Offset: 0x000024D4
		Friend Overridable Property Label4 As Label

		' Token: 0x1700015A RID: 346
		' (get) Token: 0x06000328 RID: 808 RVA: 0x000042DD File Offset: 0x000024DD
		' (set) Token: 0x06000329 RID: 809 RVA: 0x000042E5 File Offset: 0x000024E5
		Friend Overridable Property cbxRNonce As CheckBox

		' Token: 0x1700015B RID: 347
		' (get) Token: 0x0600032A RID: 810 RVA: 0x000042EE File Offset: 0x000024EE
		' (set) Token: 0x0600032B RID: 811 RVA: 0x000042F6 File Offset: 0x000024F6
		Friend Overridable Property cbxEBssid As CheckBox

		' Token: 0x1700015C RID: 348
		' (get) Token: 0x0600032C RID: 812 RVA: 0x000042FF File Offset: 0x000024FF
		' (set) Token: 0x0600032D RID: 813 RVA: 0x00004307 File Offset: 0x00002507
		Friend Overridable Property ToolStrip1 As ToolStrip

		' Token: 0x1700015D RID: 349
		' (get) Token: 0x0600032E RID: 814 RVA: 0x00004310 File Offset: 0x00002510
		' (set) Token: 0x0600032F RID: 815 RVA: 0x000132F4 File Offset: 0x000114F4
		Friend Overridable Property btExcute As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._btExcute
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_2
				Dim btExcute As ToolStripButton = Me._btExcute
				If btExcute IsNot Nothing Then
					RemoveHandler btExcute.Click, value2
				End If
				Me._btExcute = value
				btExcute = Me._btExcute
				If btExcute IsNot Nothing Then
					AddHandler btExcute.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700015E RID: 350
		' (get) Token: 0x06000330 RID: 816 RVA: 0x00004318 File Offset: 0x00002518
		' (set) Token: 0x06000331 RID: 817 RVA: 0x00013338 File Offset: 0x00011538
		Friend Overridable Property btRetry As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._btRetry
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_3
				Dim btRetry As ToolStripButton = Me._btRetry
				If btRetry IsNot Nothing Then
					RemoveHandler btRetry.Click, value2
				End If
				Me._btRetry = value
				btRetry = Me._btRetry
				If btRetry IsNot Nothing Then
					AddHandler btRetry.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700015F RID: 351
		' (get) Token: 0x06000332 RID: 818 RVA: 0x00004320 File Offset: 0x00002520
		' (set) Token: 0x06000333 RID: 819 RVA: 0x0001337C File Offset: 0x0001157C
		Friend Overridable Property btStop As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._btStop
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_4
				Dim btStop As ToolStripButton = Me._btStop
				If btStop IsNot Nothing Then
					RemoveHandler btStop.Click, value2
				End If
				Me._btStop = value
				btStop = Me._btStop
				If btStop IsNot Nothing Then
					AddHandler btStop.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000160 RID: 352
		' (get) Token: 0x06000334 RID: 820 RVA: 0x00004328 File Offset: 0x00002528
		' (set) Token: 0x06000335 RID: 821 RVA: 0x00004330 File Offset: 0x00002530
		Friend Overridable Property Panel1 As Panel

		' Token: 0x17000161 RID: 353
		' (get) Token: 0x06000336 RID: 822 RVA: 0x00004339 File Offset: 0x00002539
		' (set) Token: 0x06000337 RID: 823 RVA: 0x00004341 File Offset: 0x00002541
		Friend Overridable Property Label5 As Label

		' Token: 0x17000162 RID: 354
		' (get) Token: 0x06000338 RID: 824 RVA: 0x0000434A File Offset: 0x0000254A
		' (set) Token: 0x06000339 RID: 825 RVA: 0x00004352 File Offset: 0x00002552
		Friend Overridable Property PictureBox1 As PictureBox

		' Token: 0x17000163 RID: 355
		' (get) Token: 0x0600033A RID: 826 RVA: 0x0000435B File Offset: 0x0000255B
		' (set) Token: 0x0600033B RID: 827 RVA: 0x00004363 File Offset: 0x00002563
		Friend Overridable Property cbxLength As CheckBox

		' Token: 0x17000164 RID: 356
		' (get) Token: 0x0600033C RID: 828 RVA: 0x0000436C File Offset: 0x0000256C
		' (set) Token: 0x0600033D RID: 829 RVA: 0x000133C0 File Offset: 0x000115C0
		Private Overridable Property GClass8_0 As GClass8
			<CompilerGenerated()>
			Get
				Return Me.gclass8_0
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass8)
				Dim value2 As GClass8.GDelegate8 = AddressOf Me.method_5
				Dim gclass As GClass8 = Me.gclass8_0
				If gclass IsNot Nothing Then
					RemoveHandler gclass.Event_2, value2
				End If
				Me.gclass8_0 = value
				gclass = Me.gclass8_0
				If gclass IsNot Nothing Then
					AddHandler gclass.Event_2, value2
				End If
			End Set
		End Property

		' Token: 0x0600033E RID: 830 RVA: 0x00013404 File Offset: 0x00011604
		Public Sub New(ByRef gclass8_1 As GClass8, ByRef gclass9_1 As GClass9)
			AddHandler MyBase.Load, AddressOf Me.PixieForm_Load
			Me.gclass12_0 = New GClass12("", GClass12.GEnum5.Manual)
			Me.InitializeComponent()
			Me.gclass9_0 = gclass9_1
			Me.GClass8_0 = gclass8_1
		End Sub

		' Token: 0x0600033F RID: 831 RVA: 0x00013450 File Offset: 0x00011650
		Private Sub PixieForm_Load(sender As Object, e As EventArgs)
			Try
				Me.dtpStart.Value = Me.dtpStart.Value.AddMonths(-1)
				Me.cbMode.SelectedIndex = 0
				If Me.gclass9_0 IsNot Nothing Then
					Me.btRetry.Enabled = (Operators.CompareString(Me.gclass9_0.PKE, "", False) <> 0 And Operators.CompareString(Me.gclass9_0.PKR, "", False) <> 0 And Operators.CompareString(Me.gclass9_0.AuthKey, "", False) <> 0 And Operators.CompareString(Me.gclass9_0.E_HAS1, "", False) <> 0 And Operators.CompareString(Me.gclass9_0.E_HAS2, "", False) <> 0)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000340 RID: 832 RVA: 0x00013540 File Offset: 0x00011740
		Private Sub method_0(sender As Object, e As EventArgs)
			Select Case Me.cbMode.SelectedIndex
				Case 0
					Me.dtpStart.Enabled = True
					Me.dtpEnd.Enabled = True
					Me.cbxForce.Enabled = True
					Return
				Case 1, 2, 4, 5
					Me.dtpStart.Enabled = False
					Me.dtpEnd.Enabled = False
					Me.cbxForce.Enabled = True
					Return
				Case 3
					Me.dtpStart.Enabled = True
					Me.dtpEnd.Enabled = True
					Me.cbxForce.Enabled = True
					Return
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x06000341 RID: 833 RVA: 0x000135E8 File Offset: 0x000117E8
		Private Sub method_1(sender As Object, e As EventArgs)
			If Me.cbMode.SelectedIndex = 3 Then
				Me.dtpStart.Enabled = Not Me.cbxForce.Checked
				Me.dtpEnd.Enabled = Not Me.cbxForce.Checked
			End If
		End Sub

		' Token: 0x06000342 RID: 834 RVA: 0x00013638 File Offset: 0x00011838
		Private Sub method_2(sender As Object, e As EventArgs)
			Me.btExcute.Enabled = False
			Me.btRetry.Enabled = False
			Me.btStop.Enabled = True
			Me.Cursor = Cursors.WaitCursor
			Me.GClass8_0.method_9(Me.gclass9_0)
		End Sub

		' Token: 0x06000343 RID: 835 RVA: 0x00004374 File Offset: 0x00002574
		Private Sub method_3(sender As Object, e As EventArgs)
			Me.btExcute.Enabled = False
			Me.btRetry.Enabled = False
			Me.btStop.Enabled = True
			Me.Cursor = Cursors.WaitCursor
			Me.method_7()
		End Sub

		' Token: 0x06000344 RID: 836 RVA: 0x00013688 File Offset: 0x00011888
		Private Sub method_4(sender As Object, e As EventArgs)
			If Me.process_0 IsNot Nothing AndAlso Not Me.process_0.HasExited Then
				Me.process_0.Kill()
			End If
			Me.GClass8_0.method_10(True)
			Me.btExcute.Enabled = True
			Me.btRetry.Enabled = (Operators.CompareString(Me.gclass9_0.PKE, "", False) <> 0 And Operators.CompareString(Me.gclass9_0.PKR, "", False) <> 0 And Operators.CompareString(Me.gclass9_0.AuthKey, "", False) <> 0 And Operators.CompareString(Me.gclass9_0.E_HAS1, "", False) <> 0 And Operators.CompareString(Me.gclass9_0.E_HAS2, "", False) <> 0)
			Me.btStop.Enabled = False
			Me.Cursor = Cursors.[Default]
		End Sub

		' Token: 0x06000345 RID: 837 RVA: 0x00013770 File Offset: 0x00011970
		Private Sub method_5(genum1_0 As GClass8.GEnum1)
			Try
				If MyBase.InvokeRequired Then
					Dim method As PixieForm.GDelegate10 = AddressOf Me.method_5
					MyBase.Invoke(method, New Object() { genum1_0 })
				Else
					Me.method_6(genum1_0)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000346 RID: 838 RVA: 0x000137D4 File Offset: 0x000119D4
		Private Sub method_6(genum1_0 As GClass8.GEnum1)
			Select Case genum1_0
				Case GClass8.GEnum1.[Stop], GClass8.GEnum1.Start, GClass8.GEnum1.Testing, CType(3, GClass8.GEnum1), GClass8.GEnum1.Success, GClass8.GEnum1.NACK, GClass8.GEnum1.Updated, GClass8.GEnum1.Locked, GClass8.GEnum1.ApNotFound, GClass8.GEnum1.AssociationFailed
				Case GClass8.GEnum1.PixieSucced
					Me.GClass8_0.method_10(False)
					Class6.Class7_0.MainForm_0.method_22(vbCrLf & "[P] AuthKey: " + Me.gclass9_0.AuthKey, Color.White, True)
					Class6.Class7_0.MainForm_0.method_22("[P]     PKE: " + Me.gclass9_0.PKE, Color.White, True)
					Class6.Class7_0.MainForm_0.method_22("[P]     PKR: " + Me.gclass9_0.PKR, Color.White, True)
					Class6.Class7_0.MainForm_0.method_22("[P] E-HASH1: " + Me.gclass9_0.E_HAS1, Color.White, True)
					Class6.Class7_0.MainForm_0.method_22("[P] E-HASH2: " + Me.gclass9_0.E_HAS2, Color.White, True)
					Class6.Class7_0.MainForm_0.method_22("[P] E-NONCE: " + Me.gclass9_0.E_NONCE, Color.White, True)
					Class6.Class7_0.MainForm_0.method_22("[P] R-NONCE: " + Me.gclass9_0.R_NONCE, Color.White, True)
					Class6.Class7_0.MainForm_0.method_22(Class13.string_4, Color.LightGreen, False)
					Me.method_7()
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x06000347 RID: 839 RVA: 0x00013968 File Offset: 0x00011B68
		Private Sub method_7()
			Dim text As String = "-e " + Me.gclass9_0.PKE
			While True
				IL_1BE:
				text = text + " -r " + Me.gclass9_0.PKR
				While True
					IL_1A5:
					text = text + " -s " + Me.gclass9_0.E_HAS1
					While True
						IL_151:
						text = text + " -z " + Me.gclass9_0.E_HAS2
						text = text + " -a " + Me.gclass9_0.AuthKey
						text = text + " -n " + Me.gclass9_0.E_NONCE
						If Me.cbxRNonce.Checked Then
							GoTo IL_12B
						End If
						While True
							IL_142:
							If Me.cbxEBssid.Checked Then
								GoTo IL_112
							End If
							While True
								IL_104:
								Dim selectedIndex As Integer = Me.cbMode.SelectedIndex
								While True
									IL_E1:
									Select Case selectedIndex
										Case 0
											GoTo IL_1D7
										Case 1
											GoTo IL_22D
										Case 2
											GoTo IL_23E
										Case 3
											GoTo IL_24C
										Case 4
											GoTo IL_2A8
										Case 5
											GoTo IL_2B6
										Case Else
											Dim num2 As UInteger
											Dim num As Integer = CInt((num2 * 3820013271UI Xor 3077862196UI))
											While True
												Dim num3 As Integer = num Xor -2038553133
												num2 = CUInt(num3)
												Select Case num3 Mod 35
													Case 0
														GoTo IL_35C
													Case 1, 2, 5, 16, 20
														GoTo IL_2C2
													Case 3
														GoTo IL_12B
													Case 6, 31
														GoTo IL_1BE
													Case 7
														GoTo IL_2F4
													Case 8
														GoTo IL_258
													Case 9
														GoTo IL_104
													Case 10
														GoTo IL_2FF
													Case 11
														GoTo IL_1E7
													Case 12
														GoTo IL_1D7
													Case 13
														GoTo IL_31F
													Case 14
														GoTo IL_2E8
													Case 15
														GoTo IL_22D
													Case 17
														GoTo IL_342
													Case 18
														GoTo IL_2A8
													Case 19
														GoTo IL_32C
													Case 21
														GoTo IL_2B6
													Case 22
														GoTo IL_265
													Case 23
														GoTo IL_369
													Case 24
														GoTo IL_142
													Case 25
														GoTo IL_1A5
													Case 26
														GoTo IL_2DB
													Case 27
														num = CInt((num2 * 781617978UI Xor 1350863861UI))
														Continue For
													Case 28
														GoTo IL_E1
													Case 29
														GoTo IL_112
													Case 30
														GoTo IL_23E
													Case 32
														GoTo IL_2CF
													Case 33
														GoTo IL_24C
													Case 34
														GoTo IL_151
												End Select
												GoTo Block_1
											End While
									End Select
								End While
							End While
							IL_112:
							text = text + " -b " + Me.gclass9_0.BSSID
							GoTo IL_104
						End While
						IL_12B:
						text = text + " -m " + Me.gclass9_0.R_NONCE
						GoTo IL_142
					End While
				End While
			End While
			Block_1:
			Return
			IL_1D7:
			If Me.cbxForce.Checked Then
				GoTo IL_2C2
			End If
			IL_1E7:
			text += String.Format(" --start {0} --end {1}", Me.dtpStart.Value.ToString("MM/yyyy"), Me.dtpEnd.Value.ToString("MM/yyyy"))
			GoTo IL_2C2
			IL_22D:
			text += " --mode 1 "
			GoTo IL_2C2
			IL_23E:
			text += " --mode 2 "
			GoTo IL_2C2
			IL_24C:
			text += " --mode 3 "
			IL_258:
			If Me.cbxForce.Checked Then
				GoTo IL_2C2
			End If
			IL_265:
			text += String.Format(" --start {0} --end {1}", Me.dtpStart.Value.ToString("MM/yyyy"), Me.dtpEnd.Value.ToString("MM/yyyy"))
			GoTo IL_2C2
			IL_2A8:
			text += " --mode 4 "
			GoTo IL_2C2
			IL_2B6:
			text += " --mode 5 "
			IL_2C2:
			If Not Me.cbxForce.Checked Then
				GoTo IL_2DB
			End If
			IL_2CF:
			text += " --force "
			IL_2DB:
			If Not Me.cbxLength.Checked Then
				GoTo IL_2F4
			End If
			IL_2E8:
			text += " --length "
			IL_2F4:
			Me.process_0 = New Process()
			IL_2FF:
			Class6.Class7_0.MainForm_0.method_22(" PixieWps " + text, Color.White, True)
			IL_31F:
			Dim text2 As String = GClass3.smethod_28(text, Me.process_0)
			IL_32C:
			Class6.Class7_0.MainForm_0.method_22(text2, Color.White, True)
			IL_342:
			Class6.Class7_0.MainForm_0.method_22(Class13.string_4, Color.LightGreen, False)
			IL_35C:
			Class13.smethod_11(text2, Me.gclass12_0)
			IL_369:
			Me.btStop.PerformClick()
		End Sub

		' Token: 0x0400015B RID: 347
		Private icontainer_0 As IContainer

		' Token: 0x0400016E RID: 366
		Private gclass9_0 As GClass9

		' Token: 0x0400016F RID: 367
		Private gclass12_0 As GClass12

		' Token: 0x04000170 RID: 368
		<AccessedThroughProperty("jsApi")>
		<CompilerGenerated()>
		Private gclass8_0 As GClass8

		' Token: 0x04000171 RID: 369
		Private process_0 As Process

		' Token: 0x0200002D RID: 45
		' (Invoke) Token: 0x0600034B RID: 843
		Public Delegate Sub GDelegate10(status As GClass8.GEnum1)
	End Class
End Namespace
