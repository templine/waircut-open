Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace wAirCut
	' Token: 0x02000030 RID: 48
	<DesignerGenerated()>
	Public Partial Class RandomPinForm
		Inherits Form

		' Token: 0x0600035F RID: 863 RVA: 0x0001425C File Offset: 0x0001245C
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

		' Token: 0x17000169 RID: 361
		' (get) Token: 0x06000361 RID: 865 RVA: 0x0000442D File Offset: 0x0000262D
		' (set) Token: 0x06000362 RID: 866 RVA: 0x00004435 File Offset: 0x00002635
		Friend Overridable Property ToolStrip1 As ToolStrip

		' Token: 0x1700016A RID: 362
		' (get) Token: 0x06000363 RID: 867 RVA: 0x0000443E File Offset: 0x0000263E
		' (set) Token: 0x06000364 RID: 868 RVA: 0x00004446 File Offset: 0x00002646
		Friend Overridable Property ToolStripSeparator1 As ToolStripSeparator

		' Token: 0x1700016B RID: 363
		' (get) Token: 0x06000365 RID: 869 RVA: 0x0000444F File Offset: 0x0000264F
		' (set) Token: 0x06000366 RID: 870 RVA: 0x00014B30 File Offset: 0x00012D30
		Friend Overridable Property TbTime As ToolStripTextBox
			<CompilerGenerated()>
			Get
				Return Me._TbTime
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripTextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.method_19
				Dim tbTime As ToolStripTextBox = Me._TbTime
				If tbTime IsNot Nothing Then
					RemoveHandler tbTime.KeyPress, value2
				End If
				Me._TbTime = value
				tbTime = Me._TbTime
				If tbTime IsNot Nothing Then
					AddHandler tbTime.KeyPress, value2
				End If
			End Set
		End Property

		' Token: 0x1700016C RID: 364
		' (get) Token: 0x06000367 RID: 871 RVA: 0x00004457 File Offset: 0x00002657
		' (set) Token: 0x06000368 RID: 872 RVA: 0x00014B74 File Offset: 0x00012D74
		Friend Overridable Property TbStart As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._TbStart
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_3
				Dim tbStart As ToolStripButton = Me._TbStart
				If tbStart IsNot Nothing Then
					RemoveHandler tbStart.Click, value2
				End If
				Me._TbStart = value
				tbStart = Me._TbStart
				If tbStart IsNot Nothing Then
					AddHandler tbStart.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700016D RID: 365
		' (get) Token: 0x06000369 RID: 873 RVA: 0x0000445F File Offset: 0x0000265F
		' (set) Token: 0x0600036A RID: 874 RVA: 0x00014BB8 File Offset: 0x00012DB8
		Friend Overridable Property TbStop As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._TbStop
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_4
				Dim tbStop As ToolStripButton = Me._TbStop
				If tbStop IsNot Nothing Then
					RemoveHandler tbStop.Click, value2
				End If
				Me._TbStop = value
				tbStop = Me._TbStop
				If tbStop IsNot Nothing Then
					AddHandler tbStop.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700016E RID: 366
		' (get) Token: 0x0600036B RID: 875 RVA: 0x00004467 File Offset: 0x00002667
		' (set) Token: 0x0600036C RID: 876 RVA: 0x00014BFC File Offset: 0x00012DFC
		Friend Overridable Property Timer_0 As Timer
			<CompilerGenerated()>
			Get
				Return Me.timer_0
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.method_11
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

		' Token: 0x1700016F RID: 367
		' (get) Token: 0x0600036D RID: 877 RVA: 0x0000446F File Offset: 0x0000266F
		' (set) Token: 0x0600036E RID: 878 RVA: 0x00014C40 File Offset: 0x00012E40
		Friend Overridable Property tsbOpen As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._tsbOpen
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_13
				Dim tsbOpen As ToolStripButton = Me._tsbOpen
				If tsbOpen IsNot Nothing Then
					RemoveHandler tsbOpen.Click, value2
				End If
				Me._tsbOpen = value
				tsbOpen = Me._tsbOpen
				If tsbOpen IsNot Nothing Then
					AddHandler tsbOpen.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000170 RID: 368
		' (get) Token: 0x0600036F RID: 879 RVA: 0x00004477 File Offset: 0x00002677
		' (set) Token: 0x06000370 RID: 880 RVA: 0x0000447F File Offset: 0x0000267F
		Friend Overridable Property ProgressBar1 As Class12

		' Token: 0x17000171 RID: 369
		' (get) Token: 0x06000371 RID: 881 RVA: 0x00004488 File Offset: 0x00002688
		' (set) Token: 0x06000372 RID: 882 RVA: 0x00004490 File Offset: 0x00002690
		Friend Overridable Property DgvInfo As DataGridView

		' Token: 0x17000172 RID: 370
		' (get) Token: 0x06000373 RID: 883 RVA: 0x00004499 File Offset: 0x00002699
		' (set) Token: 0x06000374 RID: 884 RVA: 0x00014C84 File Offset: 0x00012E84
		Friend Overridable Property tsbSaveMenu As ToolStripDropDownButton
			<CompilerGenerated()>
			Get
				Return Me._tsbSaveMenu
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripDropDownButton)
				Dim value2 As EventHandler = AddressOf Me.method_15
				Dim tsbSaveMenu As ToolStripDropDownButton = Me._tsbSaveMenu
				If tsbSaveMenu IsNot Nothing Then
					RemoveHandler tsbSaveMenu.Click, value2
				End If
				Me._tsbSaveMenu = value
				tsbSaveMenu = Me._tsbSaveMenu
				If tsbSaveMenu IsNot Nothing Then
					AddHandler tsbSaveMenu.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000173 RID: 371
		' (get) Token: 0x06000375 RID: 885 RVA: 0x000044A1 File Offset: 0x000026A1
		' (set) Token: 0x06000376 RID: 886 RVA: 0x00014CC8 File Offset: 0x00012EC8
		Friend Overridable Property tsbAutoSave As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsbAutoSave
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_18
				Dim tsbAutoSave As ToolStripMenuItem = Me._tsbAutoSave
				If tsbAutoSave IsNot Nothing Then
					RemoveHandler tsbAutoSave.CheckedChanged, value2
				End If
				Me._tsbAutoSave = value
				tsbAutoSave = Me._tsbAutoSave
				If tsbAutoSave IsNot Nothing Then
					AddHandler tsbAutoSave.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000174 RID: 372
		' (get) Token: 0x06000377 RID: 887 RVA: 0x000044A9 File Offset: 0x000026A9
		' (set) Token: 0x06000378 RID: 888 RVA: 0x00014D0C File Offset: 0x00012F0C
		Friend Overridable Property TsbSave As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._TsbSave
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_14
				Dim tsbSave As ToolStripMenuItem = Me._TsbSave
				If tsbSave IsNot Nothing Then
					RemoveHandler tsbSave.Click, value2
				End If
				Me._TsbSave = value
				tsbSave = Me._TsbSave
				If tsbSave IsNot Nothing Then
					AddHandler tsbSave.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000175 RID: 373
		' (get) Token: 0x06000379 RID: 889 RVA: 0x000044B1 File Offset: 0x000026B1
		' (set) Token: 0x0600037A RID: 890 RVA: 0x000044B9 File Offset: 0x000026B9
		Friend Overridable Property OpenFileDialog_0 As OpenFileDialog

		' Token: 0x17000176 RID: 374
		' (get) Token: 0x0600037B RID: 891 RVA: 0x000044C2 File Offset: 0x000026C2
		' (set) Token: 0x0600037C RID: 892 RVA: 0x000044CA File Offset: 0x000026CA
		Friend Overridable Property SaveFileDialog_0 As SaveFileDialog

		' Token: 0x17000177 RID: 375
		' (get) Token: 0x0600037D RID: 893 RVA: 0x000044D3 File Offset: 0x000026D3
		' (set) Token: 0x0600037E RID: 894 RVA: 0x000044DB File Offset: 0x000026DB
		Friend Overridable Property DgvDataCampo As DataGridViewTextBoxColumn

		' Token: 0x17000178 RID: 376
		' (get) Token: 0x0600037F RID: 895 RVA: 0x000044E4 File Offset: 0x000026E4
		' (set) Token: 0x06000380 RID: 896 RVA: 0x000044EC File Offset: 0x000026EC
		Friend Overridable Property DgvDataValor As DataGridViewTextBoxColumn

		' Token: 0x17000179 RID: 377
		' (get) Token: 0x06000381 RID: 897 RVA: 0x000044F5 File Offset: 0x000026F5
		' (set) Token: 0x06000382 RID: 898 RVA: 0x000044FD File Offset: 0x000026FD
		Friend Overridable Property lbResult As Label

		' Token: 0x1700017A RID: 378
		' (get) Token: 0x06000383 RID: 899 RVA: 0x00004506 File Offset: 0x00002706
		' (set) Token: 0x06000384 RID: 900 RVA: 0x0000450E File Offset: 0x0000270E
		Friend Overridable Property tsFormatMenu As ToolStrip

		' Token: 0x1700017B RID: 379
		' (get) Token: 0x06000385 RID: 901 RVA: 0x00004517 File Offset: 0x00002717
		' (set) Token: 0x06000386 RID: 902 RVA: 0x0000451F File Offset: 0x0000271F
		Friend Overridable Property ToolStripLabel1 As ToolStripLabel

		' Token: 0x1700017C RID: 380
		' (get) Token: 0x06000387 RID: 903 RVA: 0x00004528 File Offset: 0x00002728
		' (set) Token: 0x06000388 RID: 904 RVA: 0x00014D50 File Offset: 0x00012F50
		Friend Overridable Property tbPinFormat1 As ToolStripTextBox
			<CompilerGenerated()>
			Get
				Return Me._tbPinFormat1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripTextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.method_5
				Dim tbPinFormat As ToolStripTextBox = Me._tbPinFormat1
				If tbPinFormat IsNot Nothing Then
					RemoveHandler tbPinFormat.KeyPress, value2
				End If
				Me._tbPinFormat1 = value
				tbPinFormat = Me._tbPinFormat1
				If tbPinFormat IsNot Nothing Then
					AddHandler tbPinFormat.KeyPress, value2
				End If
			End Set
		End Property

		' Token: 0x1700017D RID: 381
		' (get) Token: 0x06000389 RID: 905 RVA: 0x00004530 File Offset: 0x00002730
		' (set) Token: 0x0600038A RID: 906 RVA: 0x00014D94 File Offset: 0x00012F94
		Friend Overridable Property tsbCalculate As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._tsbCalculate
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_7
				Dim tsbCalculate As ToolStripButton = Me._tsbCalculate
				If tsbCalculate IsNot Nothing Then
					RemoveHandler tsbCalculate.Click, value2
				End If
				Me._tsbCalculate = value
				tsbCalculate = Me._tsbCalculate
				If tsbCalculate IsNot Nothing Then
					AddHandler tsbCalculate.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700017E RID: 382
		' (get) Token: 0x0600038B RID: 907 RVA: 0x00004538 File Offset: 0x00002738
		' (set) Token: 0x0600038C RID: 908 RVA: 0x00014DD8 File Offset: 0x00012FD8
		Friend Overridable Property tbPinFormat2 As ToolStripTextBox
			<CompilerGenerated()>
			Get
				Return Me._tbPinFormat2
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripTextBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.method_6
				Dim tbPinFormat As ToolStripTextBox = Me._tbPinFormat2
				If tbPinFormat IsNot Nothing Then
					RemoveHandler tbPinFormat.KeyPress, value2
				End If
				Me._tbPinFormat2 = value
				tbPinFormat = Me._tbPinFormat2
				If tbPinFormat IsNot Nothing Then
					AddHandler tbPinFormat.KeyPress, value2
				End If
			End Set
		End Property

		' Token: 0x1700017F RID: 383
		' (get) Token: 0x0600038D RID: 909 RVA: 0x00004540 File Offset: 0x00002740
		' (set) Token: 0x0600038E RID: 910 RVA: 0x00014E1C File Offset: 0x0001301C
		Private Overridable Property GClass8_0 As GClass8
			<CompilerGenerated()>
			Get
				Return Me.gclass8_0
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass8)
				Dim value2 As GClass8.GDelegate8 = AddressOf Me.method_8
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

		' Token: 0x0600038F RID: 911 RVA: 0x00014E60 File Offset: 0x00013060
		Public Sub New(ByRef gclass8_1 As GClass8, ByRef gclass9_1 As GClass9, bool_7 As Boolean)
			AddHandler MyBase.Load, AddressOf Me.RandomPinForm_Load
			AddHandler MyBase.FormClosed, AddressOf Me.RandomPinForm_FormClosed
			Me.gclass13_0 = New GClass13()
			Me.gclass12_0 = New GClass12("12345670", GClass12.GEnum5.Manual)
			Me.string_0 = ""
			Me.bool_0 = False
			Me.int_2 = 0
			Me.bool_1 = False
			Me.double_0 = 0.0
			Me.int_3 = 0
			Me.int_4 = 0
			Me.string_1 = ""
			Me.bool_3 = False
			Me.int_5 = 0
			Me.int_6 = 0
			Me.bool_4 = False
			Me.string_2 = ""
			Me.genum6_0 = RandomPinForm.GEnum6.None
			Me.genum6_1 = RandomPinForm.GEnum6.None
			Me.int_7 = -1
			Me.bool_5 = False
			Me.list_0 = New List(Of String)()
			Me.bool_6 = True
			Me.InitializeComponent()
			If bool_7 Then
				Me.list_0 = Me.gclass13_0.method_3(Me.bool_6)
				Me.Text = Class10.String_73
			Else
				Try
					For Each gclass As GClass12 In gclass9_1.gclass15_0
						Me.list_0.Add(gclass.Pin)
					Next
				Finally
					Dim enumerator As IEnumerator(Of GClass12)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Me.Text = Class10.String_74
				Me.tsFormatMenu.Visible = False
			End If
			Me.int_7 = 0
			Me.gclass12_0 = New GClass12(Me.list_0(Me.int_7), GClass12.GEnum5.BruteForce)
			Me.ProgressBar1.Maximum = Me.list_0.Count
			Me.bool_5 = bool_7
			Me.gclass9_0 = gclass9_1
			Me.GClass8_0 = gclass8_1
			Me.string_2 = "log\" + gclass9_1.BSSID.Replace(":", "") + ".log"
			Me.method_1()
			Me.tbPinFormat1.Tag = ""
			Me.tbPinFormat2.Tag = ""
		End Sub

		' Token: 0x06000390 RID: 912 RVA: 0x00015084 File Offset: 0x00013284
		Private Sub RandomPinForm_Load(sender As Object, e As EventArgs)
			Me.method_2()
			Me.DgvInfo.ClearSelection()
			Me.tsbOpen.Visible = Me.bool_5
			Me.tsbSaveMenu.Visible = Me.bool_5
			If File.Exists(Me.string_2) Then
				If MessageBox.Show(Class10.String_64, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
					Me.method_0()
				End If
			End If
		End Sub

		' Token: 0x06000391 RID: 913 RVA: 0x000150F0 File Offset: 0x000132F0
		Private Sub method_0()
			Me.list_0.Clear()
			If Me.method_16(Me.string_2) Then
				If Me.int_7 = -1 Then
					Me.int_7 = 0
				End If
				If Me.int_7 >= Me.list_0.Count Then
					' The following expression was wrapped in a checked-expression
					Me.int_7 = Me.list_0.Count - 1
				End If
				Me.gclass12_0 = New GClass12(Me.list_0(Me.int_7), GClass12.GEnum5.BruteForce)
				Me.method_2()
			End If
		End Sub

		' Token: 0x06000392 RID: 914 RVA: 0x00004548 File Offset: 0x00002748
		Private Sub RandomPinForm_FormClosed(sender As Object, e As FormClosedEventArgs)
			Me.TbStop.PerformClick()
		End Sub

		' Token: 0x06000393 RID: 915 RVA: 0x00015174 File Offset: 0x00013374
		Private Sub method_1()
			Me.DgvInfo.Rows.Add(7)
			Me.DgvInfo.Rows(0).Cells(0).Value = "SSID"
			Me.DgvInfo.Rows(1).Cells(0).Value = "BSSID"
			Me.DgvInfo.Rows(2).Cells(0).Value = Class10.String_27
			Me.DgvInfo.Rows(3).Cells(0).Value = Class10.String_28
			Me.DgvInfo.Rows(4).Cells(0).Value = Class10.String_26
			Me.DgvInfo.Rows(5).Cells(0).Value = "PIN"
			Me.DgvInfo.Rows(6).Cells(0).Value = "Key"
		End Sub

		' Token: 0x06000394 RID: 916 RVA: 0x000152A0 File Offset: 0x000134A0
		Private Sub method_2()
			Me.timeSpan_0 = TimeSpan.FromSeconds(Me.double_0)
			Me.DgvInfo.Rows(0).Cells(1).Value = Me.gclass9_0.SSID
			While True
				IL_15D:
				Me.DgvInfo.Rows(1).Cells(1).Value = Me.gclass9_0.BSSID
				Me.DgvInfo.Rows(2).Cells(1).Value = String.Format(Class10.String_63, New Object() { Me.timeSpan_0.Days, Me.timeSpan_0.Hours, Me.timeSpan_0.Minutes, Me.timeSpan_0.Seconds, Me.timeSpan_1.Days, Me.timeSpan_1.Hours, Me.timeSpan_1.Minutes, Me.timeSpan_1.Seconds })
				Me.DgvInfo.Rows(3).Cells(1).Value = String.Format(Class10.String_72, Me.int_7.ToString("00000"), Me.list_0.Count.ToString("00000"))
				While True
					IL_12F:
					Me.DgvInfo.Rows(4).Cells(1).Value = Me.int_2
					While True
						IL_126:
						Dim genum As RandomPinForm.GEnum6 = Me.genum6_1
						While True
							IL_FF:
							Select Case genum
								Case RandomPinForm.GEnum6.None
									GoTo IL_2AA
								Case RandomPinForm.GEnum6.Ok
									GoTo IL_2E5
								Case RandomPinForm.GEnum6.NoOk
									GoTo IL_35C
								Case RandomPinForm.GEnum6.fHalfOk
									GoTo IL_3A7
								Case RandomPinForm.GEnum6.Fault
									GoTo IL_3F2
								Case RandomPinForm.GEnum6.ApLocked
									GoTo IL_466
								Case RandomPinForm.GEnum6.PinNotFound
									GoTo IL_494
								Case Else
									Dim num2 As UInteger
									Dim num As Integer = CInt((num2 * 935932444UI Xor 264177942UI))
									While True
										Dim num3 As Integer = num Xor -25873012
										num2 = CUInt(num3)
										Select Case num3 Mod 35
											Case 0
												GoTo IL_392
											Case 1, 3, 6, 7, 12, 32
												GoTo IL_4C0
											Case 2
												num = CInt((num2 * 125493163UI Xor 2325440787UI))
												Continue For
											Case 4
												GoTo IL_2AA
											Case 5
												GoTo IL_3D2
											Case 9
												GoTo IL_466
											Case 10
												GoTo IL_31B
											Case 11, 24
												GoTo IL_15D
											Case 13
												GoTo IL_33B
											Case 14
												GoTo IL_310
											Case 15
												GoTo IL_527
											Case 16
												GoTo IL_12F
											Case 17
												GoTo IL_4A4
											Case 18
												GoTo IL_476
											Case 19
												GoTo IL_438
											Case 20
												GoTo IL_387
											Case 21
												GoTo IL_428
											Case 22
												GoTo IL_FF
											Case 23
												GoTo IL_2E5
											Case 25
												GoTo IL_3A7
											Case 26
												GoTo IL_32B
											Case 27
												GoTo IL_458
											Case 28
												GoTo IL_126
											Case 29
												GoTo IL_3F2
											Case 30
												GoTo IL_4B4
											Case 31
												GoTo IL_494
											Case 33
												GoTo IL_35C
											Case 34
												GoTo IL_3DD
										End Select
										GoTo Block_1
									End While
							End Select
						End While
					End While
				End While
			End While
			Block_1:
			GoTo IL_553
			IL_2AA:
			Me.DgvInfo.Rows(5).Cells(1).Style.ForeColor = Control.DefaultForeColor
			Me.string_1 = ""
			GoTo IL_4C0
			IL_2E5:
			Me.DgvInfo.Rows(5).Cells(1).Style.ForeColor = Color.Green
			IL_310:
			Me.string_1 = Class10.String_75
			IL_31B:
			Me.ProgressBar1.Color_0 = Color.Green
			IL_32B:
			Me.lbResult.Text = Class10.String_69
			IL_33B:
			Me.lbResult.BackColor = Color.Green
			Me.lbResult.Visible = True
			GoTo IL_4C0
			IL_35C:
			Me.DgvInfo.Rows(5).Cells(1).Style.ForeColor = Color.Red
			IL_387:
			Me.string_1 = Class10.String_68
			IL_392:
			Me.ProgressBar1.Color_0 = Color.Red
			GoTo IL_4C0
			IL_3A7:
			Me.DgvInfo.Rows(5).Cells(1).Style.ForeColor = Color.Orange
			IL_3D2:
			Me.string_1 = Class10.String_66
			IL_3DD:
			Me.ProgressBar1.Color_0 = Color.Yellow
			GoTo IL_4C0
			IL_3F2:
			Me.DgvInfo.Rows(5).Cells(1).Style.ForeColor = Color.Red
			Me.string_1 = Class10.String_71
			IL_428:
			Me.ProgressBar1.Color_0 = Color.Red
			IL_438:
			Me.lbResult.Text = Class10.String_71
			Me.lbResult.BackColor = Color.Red
			IL_458:
			Me.lbResult.Visible = True
			GoTo IL_4C0
			IL_466:
			Me.lbResult.Text = Class10.String_62
			IL_476:
			Me.lbResult.BackColor = Color.Red
			Me.lbResult.Visible = True
			GoTo IL_4C0
			IL_494:
			Me.lbResult.Text = Class10.String_70
			IL_4A4:
			Me.lbResult.BackColor = Color.Red
			IL_4B4:
			Me.lbResult.Visible = True
			IL_4C0:
			Me.DgvInfo.Rows(5).Cells(1).Value = String.Format("{0} {1}", Me.gclass12_0.Pin, Me.string_1)
			Me.DgvInfo.Rows(6).Cells(1).Style.ForeColor = Color.Green
			IL_527:
			Me.DgvInfo.Rows(6).Cells(1).Value = Me.gclass9_0.NetworkKey
			IL_553:
			Me.ProgressBar1.Maximum = Me.list_0.Count
			Me.ProgressBar1.Value = Me.int_7
		End Sub

		' Token: 0x06000395 RID: 917 RVA: 0x00015828 File Offset: 0x00013A28
		Private Sub method_3(sender As Object, e As EventArgs)
			If Conversions.ToInteger(Me.TbTime.Text) < 5 Then
				Me.TbTime.Text = "5"
			End If
			Me.TbTime.Enabled = False
			Me.GClass8_0.method_7(Me.gclass9_0, Me.gclass12_0)
			Me.genum6_0 = RandomPinForm.GEnum6.None
			Me.genum6_1 = RandomPinForm.GEnum6.None
			Me.bool_1 = True
			RandomPinForm.bool_2 = True
			Me.Timer_0.Enabled = True
			Me.tsbOpen.Enabled = False
			Me.tsbSaveMenu.Enabled = True
			Me.TbStop.Enabled = True
			Me.TbStart.Enabled = False
			Me.lbResult.Visible = False
			Me.tbPinFormat1.Enabled = False
			Me.tbPinFormat2.Enabled = False
			Me.tsbCalculate.Enabled = False
			If Me.int_7 <= 0 Then
				' The following expression was wrapped in a checked-expression
				Me.timeSpan_1 = TimeSpan.FromSeconds(CDbl((Me.list_0.Count * Conversions.ToInteger(Me.TbTime.Text) + Me.int_7 * 4)))
				Return
			End If
			Me.timeSpan_1 = TimeSpan.FromSeconds(Me.double_0 / CDbl(Me.int_7) * CDbl((Me.list_0.Count - Me.int_7)))
		End Sub

		' Token: 0x06000396 RID: 918 RVA: 0x0001596C File Offset: 0x00013B6C
		Private Sub method_4(sender As Object, e As EventArgs)
			Me.TbTime.Enabled = True
			Me.method_2()
			Me.int_2 = 0
			Me.bool_1 = False
			RandomPinForm.bool_2 = False
			Me.GClass8_0.method_10(True)
			Me.Timer_0.Enabled = False
			Me.tsbOpen.Enabled = True
			Me.tsbSaveMenu.Enabled = True
			Me.TbStop.Enabled = False
			Me.TbStart.Enabled = True
			Me.tbPinFormat1.Enabled = True
			Me.tbPinFormat2.Enabled = True
			Me.tsbCalculate.Enabled = True
		End Sub

		' Token: 0x06000397 RID: 919 RVA: 0x00015A0C File Offset: 0x00013C0C
		Private Sub method_5(sender As Object, e As KeyPressEventArgs)
			Dim num As Integer = 4
			Dim left As String = ""
			Me.tbPinFormat1.Tag = ""
			If Me.tbPinFormat1.SelectionStart > 0 Then
				left = Conversions.ToString(Me.tbPinFormat1.Text(Me.tbPinFormat1.SelectionStart - 1))
				Dim num2 As Integer = Me.tbPinFormat1.SelectionStart - 1
				For i As Integer = 0 To num2
					Dim c As Char = Me.tbPinFormat1.Text(i)
					If c <> "-"c Then
						If c = "["c Then
							Me.tbPinFormat1.Tag = "["
						ElseIf c = "]"c Then
							Me.tbPinFormat1.Tag = ""
						End If
					Else
						Me.tbPinFormat1.Tag = "[-"
					End If
				Next
			End If
			Dim num3 As Integer = Me.tbPinFormat1.Text.Length - 1
			For j As Integer = 0 To num3
				If Operators.CompareString(Conversions.ToString(Me.tbPinFormat1.Text(j)), "[", False) = 0 Then
					num += 4
				End If
			Next
			Dim text As String
			If Operators.CompareString(left, "[", False) <> 0 Then
				If Operators.CompareString(left, "-", False) = 0 Then
					text = "01234567890"
				Else
					Dim tag As Object = Me.tbPinFormat1.Tag
					If Not Operators.ConditionalCompareObjectEqual(tag, "[", False) Then
						If Not Operators.ConditionalCompareObjectEqual(tag, "[-", False) Then
							text = "01234567890[?"
						Else
							text = "]"
						End If
					Else
						text = "-"
					End If
				End If
			Else
				text = "01234567890"
			End If
			If e.KeyChar >= " "c AndAlso Not text.Contains(Conversions.ToString(e.KeyChar)) Then
				e.Handled = True
			End If
			If text.Contains(Conversions.ToString(e.KeyChar)) And Me.tbPinFormat1.Text.Length >= num Then
				e.Handled = True
			End If
		End Sub

		' Token: 0x06000398 RID: 920 RVA: 0x00015BF4 File Offset: 0x00013DF4
		Private Sub method_6(sender As Object, e As KeyPressEventArgs)
			Dim num As Integer = 4
			Dim left As String = ""
			Me.tbPinFormat2.Tag = ""
			If Me.tbPinFormat2.SelectionStart > 0 Then
				left = Conversions.ToString(Me.tbPinFormat2.Text(Me.tbPinFormat2.SelectionStart - 1))
				Dim num2 As Integer = Me.tbPinFormat2.SelectionStart - 1
				For i As Integer = 0 To num2
					Dim c As Char = Me.tbPinFormat2.Text(i)
					If c = "-"c Then
						Me.tbPinFormat2.Tag = "[-"
					ElseIf c = "["c Then
						Me.tbPinFormat2.Tag = "["
					ElseIf c = "]"c Then
						Me.tbPinFormat2.Tag = ""
					End If
				Next
			End If
			Dim num3 As Integer = Me.tbPinFormat2.Text.Length - 1
			For j As Integer = 0 To num3
				If Operators.CompareString(Conversions.ToString(Me.tbPinFormat2.Text(j)), "[", False) = 0 Then
					num += 4
				End If
			Next
			Dim text As String
			If Operators.CompareString(left, "[", False) = 0 Then
				text = "01234567890"
			ElseIf Operators.CompareString(left, "-", False) = 0 Then
				text = "01234567890"
			Else
				Dim tag As Object = Me.tbPinFormat2.Tag
				If Operators.ConditionalCompareObjectEqual(tag, "[", False) Then
					text = "-"
				ElseIf Not Operators.ConditionalCompareObjectEqual(tag, "[-", False) Then
					If Me.tbPinFormat2.SelectionStart <> num - 1 Then
						text = "01234567890[?"
					Else
						text = "01234567890?C"
					End If
				Else
					text = "]"
				End If
			End If
			If e.KeyChar >= " "c AndAlso Not text.Contains(Conversions.ToString(e.KeyChar)) Then
				e.Handled = True
			End If
			If text.Contains(Conversions.ToString(e.KeyChar)) And Me.tbPinFormat2.Text.Length >= num Then
				e.Handled = True
			End If
		End Sub

		' Token: 0x06000399 RID: 921 RVA: 0x00015DF4 File Offset: 0x00013FF4
		Private Sub method_7(sender As Object, e As EventArgs)
			Me.list_0 = Me.gclass13_0.method_4(Me.tbPinFormat1.Text, Me.tbPinFormat2.Text)
			Me.int_7 = 0
			Me.gclass12_0 = New GClass12(Me.list_0(Me.int_7), GClass12.GEnum5.BruteForce)
			Me.genum6_1 = RandomPinForm.GEnum6.None
			Me.string_1 = ""
			Me.method_2()
		End Sub

		' Token: 0x0600039A RID: 922 RVA: 0x00015E64 File Offset: 0x00014064
		Private Sub method_8(genum1_0 As GClass8.GEnum1)
			Try
				If MyBase.InvokeRequired Then
					Dim method As RandomPinForm.GDelegate11 = AddressOf Me.method_8
					MyBase.Invoke(method, New Object() { genum1_0 })
				Else
					Me.method_9(genum1_0)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600039B RID: 923 RVA: 0x00015EC8 File Offset: 0x000140C8
		Private Sub method_9(genum1_0 As GClass8.GEnum1)
			While True
				IL_F4:
				Dim num2 As UInteger
				Dim num As Integer
				Select Case genum1_0
					Case GClass8.GEnum1.[Stop]
						IL_D5:
						If Not Me.bool_1 Then
							GoTo Block_3
						End If
						GoTo IL_AC
					Case GClass8.GEnum1.Start
						GoTo IL_16B
					Case GClass8.GEnum1.Testing, CType(3, GClass8.GEnum1), GClass8.GEnum1.Success, GClass8.GEnum1.NACK, GClass8.GEnum1.Updated, GClass8.GEnum1.PixieSucced
						Return
					Case GClass8.GEnum1.Locked
						GoTo IL_17A
					Case GClass8.GEnum1.ApNotFound
						GoTo IL_188
					Case GClass8.GEnum1.AssociationFailed
						GoTo IL_1CE
					Case Else
						num = CInt((num2 * 177209341UI Xor 4035751871UI))
				End Select
				While True
					IL_23:
					Dim num3 As Integer = num Xor 967167044
					num2 = CUInt(num3)
					Select Case num3 Mod 29
						Case 0, 12
							GoTo IL_F4
						Case 1
							GoTo IL_1A2
						Case 2
							GoTo IL_138
						Case 3
							GoTo IL_15D
						Case 4
							GoTo IL_17A
						Case 5
							GoTo IL_188
						Case 6, 11
							GoTo IL_163
						Case 7
							GoTo IL_129
						Case 8
							Return
						Case 9
							Return
						Case 10
							Return
						Case 13
							GoTo IL_18F
						Case 14
							GoTo IL_181
						Case 15
							Return
						Case 16
							GoTo IL_14E
						Case 17
							GoTo IL_AC
						Case 18
							num = CInt((num2 * 3375262021UI Xor 1924676518UI))
							Continue For
						Case 19
							Return
						Case 20
							GoTo IL_156
						Case 21
							GoTo IL_1AB
						Case 22
							GoTo IL_D5
						Case 23
							GoTo IL_1CE
						Case 25
							GoTo IL_147
						Case 26
							GoTo IL_1B7
						Case 27
							GoTo IL_16B
						Case 28
							GoTo IL_172
					End Select
					GoTo Block_1
				End While
				IL_AC:
				Select Case Me.GClass8_0.genum2_0
					Case GClass8.GEnum2.Nok
						GoTo IL_129
					Case GClass8.GEnum2.Ok
						GoTo IL_138
					Case GClass8.GEnum2.fHalfOk
						GoTo IL_147
					Case GClass8.GEnum2.Fault
						GoTo IL_156
					Case Else
						num = CInt((num2 * 1164684242UI Xor 4050660562UI))
						GoTo IL_23
				End Select
			End While
			Block_1:
			Return
			Block_3:
			GoTo IL_163
			IL_129:
			Me.genum6_0 = RandomPinForm.GEnum6.NoOk
			RandomPinForm.bool_2 = False
			GoTo IL_163
			IL_138:
			Me.genum6_0 = RandomPinForm.GEnum6.Ok
			RandomPinForm.bool_2 = False
			GoTo IL_163
			IL_147:
			Me.genum6_0 = RandomPinForm.GEnum6.fHalfOk
			IL_14E:
			RandomPinForm.bool_2 = False
			GoTo IL_163
			IL_156:
			Me.genum6_0 = RandomPinForm.GEnum6.Fault
			IL_15D:
			RandomPinForm.bool_2 = False
			IL_163:
			Me.bool_4 = True
			Return
			IL_16B:
			Me.genum6_0 = RandomPinForm.GEnum6.None
			IL_172:
			Me.int_6 = 0
			Return
			IL_17A:
			Me.genum6_0 = RandomPinForm.GEnum6.ApLocked
			IL_181:
			RandomPinForm.bool_2 = False
			Return
			IL_188:
			Me.genum6_0 = RandomPinForm.GEnum6.ApNotFound
			IL_18F:
			RandomPinForm.bool_2 = False
			Dim ptr As Integer = Me.int_6
			Me.int_6 = ptr + 1
			IL_1A2:
			If Me.int_6 <= 5 Then
				GoTo IL_1B7
			End If
			IL_1AB:
			Me.TbStop.PerformClick()
			Return
			IL_1B7:
			Me.int_2 = Conversions.ToInteger(Me.TbTime.Text)
			Return
			IL_1CE:
			Me.genum6_0 = RandomPinForm.GEnum6.AssociationFailed
		End Sub

		' Token: 0x0600039C RID: 924 RVA: 0x000160AC File Offset: 0x000142AC
		Private Sub method_10()
			Dim genum As RandomPinForm.GEnum6 = Me.genum6_0
			While True
				IL_B5:
				Select Case genum
					Case RandomPinForm.GEnum6.Ok
						GoTo IL_E2
					Case RandomPinForm.GEnum6.NoOk
						GoTo IL_F2
					Case RandomPinForm.GEnum6.fHalfOk
						GoTo IL_11A
					Case RandomPinForm.GEnum6.Fault
						GoTo IL_1BA
					Case RandomPinForm.GEnum6.ApLocked
						GoTo IL_206
					Case RandomPinForm.GEnum6.PinNotFound
						GoTo IL_26F
					Case RandomPinForm.GEnum6.ApNotFound
						GoTo IL_213
					Case RandomPinForm.GEnum6.AssociationFailed
						GoTo IL_24E
					Case Else
						Dim num2 As UInteger
						Dim num As Integer = CInt((num2 * 3667114684UI Xor 1250860089UI))
						While True
							Dim num3 As Integer = num Xor -1900173091
							num2 = CUInt(num3)
							Select Case num3 Mod 30
								Case 0
									GoTo IL_236
								Case 1
									GoTo IL_24E
								Case 2
									GoTo IL_12C
								Case 3
									GoTo IL_1CE
								Case 4
									GoTo IL_192
								Case 5
									GoTo IL_14B
								Case 6, 10, 11, 17, 22, 26
									GoTo IL_26F
								Case 7
									GoTo IL_1D7
								Case 8
									GoTo IL_213
								Case 9
									GoTo IL_E2
								Case 12
									GoTo IL_F2
								Case 13
									GoTo IL_1EE
								Case 14
									GoTo IL_206
								Case 15, 16
									GoTo IL_B5
								Case 18
									GoTo IL_264
								Case 19
									GoTo IL_11A
								Case 20
									num = CInt((num2 * 800848034UI Xor 1475077945UI))
									Continue For
								Case 21
									GoTo IL_1C1
								Case 23
									GoTo IL_229
								Case 24
									GoTo IL_220
								Case 25
									GoTo IL_168
								Case 28
									GoTo IL_19F
								Case 29
									GoTo IL_1BA
							End Select
							GoTo Block_1
						End While
				End Select
			End While
			Block_1:
			Return
			IL_E2:
			Me.TbStop.PerformClick()
			GoTo IL_26F
			IL_F2:
			Dim ptr As Integer = Me.int_7
			Me.int_7 = ptr + 1
			Me.int_2 = Conversions.ToInteger(Me.TbTime.Text)
			GoTo IL_26F
			IL_11A:
			If Not(Not Me.bool_0 And Me.bool_5) Then
				GoTo IL_192
			End If
			IL_12C:
			Me.string_0 = Me.gclass12_0.Pin.Substring(0, 4)
			Me.bool_0 = True
			IL_14B:
			Me.list_0 = Me.gclass13_0.method_5(Conversions.ToInteger(Me.string_0), True)
			IL_168:
			Me.list_0.Remove(Conversions.ToString(Conversions.ToUInteger(Me.gclass12_0.Pin)))
			Me.int_7 = 0
			GoTo IL_19F
			IL_192:
			ptr = Me.int_7
			Me.int_7 = ptr + 1
			IL_19F:
			Me.int_2 = Conversions.ToInteger(Me.TbTime.Text)
			GoTo IL_26F
			IL_1BA:
			Me.bool_3 = True
			IL_1C1:
			ptr = Me.int_5
			Me.int_5 = ptr + 1
			IL_1CE:
			If Me.int_5 < 6 Then
				GoTo IL_1EE
			End If
			IL_1D7:
			Me.genum6_0 = RandomPinForm.GEnum6.Fault
			Me.TbStop.PerformClick()
			GoTo IL_26F
			IL_1EE:
			Me.int_2 = Conversions.ToInteger(Me.TbTime.Text)
			GoTo IL_26F
			IL_206:
			Me.TbStop.PerformClick()
			GoTo IL_26F
			IL_213:
			ptr = Me.int_6
			Me.int_6 = ptr + 1
			IL_220:
			If Me.int_6 <= 5 Then
				GoTo IL_236
			End If
			IL_229:
			Me.TbStop.PerformClick()
			GoTo IL_26F
			IL_236:
			Me.int_2 = Conversions.ToInteger(Me.TbTime.Text)
			GoTo IL_26F
			IL_24E:
			ptr = Me.int_6
			Me.int_6 = ptr + 1
			If Me.int_6 <= 5 Then
				GoTo IL_26F
			End If
			IL_264:
			Me.TbStop.PerformClick()
			IL_26F:
			Me.genum6_1 = Me.genum6_0
			Me.genum6_0 = RandomPinForm.GEnum6.None
		End Sub

		' Token: 0x0600039D RID: 925 RVA: 0x0001633C File Offset: 0x0001453C
		Private Sub method_11(sender As Object, e As EventArgs)
			If MyBase.InvokeRequired Then
				Dim method As RandomPinForm.GDelegate12 = AddressOf Me.method_11
				MyBase.Invoke(method, New Object() { sender, e })
				Return
			End If
			Me.method_12(RuntimeHelpers.GetObjectValue(sender), e)
		End Sub

		' Token: 0x0600039E RID: 926 RVA: 0x00016384 File Offset: 0x00014584
		Private Sub method_12(sender As Object, e As EventArgs)
			Me.Timer_0.[Stop]()
			If Me.bool_1 Then
				Dim ptr2 As Double
				If Me.int_2 > 0 Then
					If Me.int_7 >= Me.list_0.Count Then
						Me.int_7 = Me.list_0.Count
						Me.genum6_0 = RandomPinForm.GEnum6.PinNotFound
						Me.genum6_1 = Me.genum6_0
						Me.method_2()
						Me.TbStop.PerformClick()
					Else
						Dim ptr As Integer = Me.int_2
						Me.int_2 = ptr - 1
						RandomPinForm.bool_2 = False
					End If
				End If
				If RandomPinForm.bool_2 Then
					Dim ptr As Integer = Me.int_3
					Me.int_3 = ptr + 1
				Else
					Me.int_4 = Me.int_3
					Me.timeSpan_1 = TimeSpan.FromSeconds(CDbl(((Conversions.ToInteger(Me.TbTime.Text) + Me.int_4) * (Me.list_0.Count - Me.int_7))))
				End If
				ptr2 = Me.double_0
				Me.double_0 = ptr2 + 1.0
				If(Not RandomPinForm.bool_2 And Me.genum6_0 > RandomPinForm.GEnum6.None) Or (RandomPinForm.bool_2 And Me.genum6_0 = RandomPinForm.GEnum6.AssociationFailed) Then
					Me.method_10()
				End If
				If Me.int_2 = 0 And Not RandomPinForm.bool_2 And Me.bool_1 Then
					If Me.int_7 < Me.list_0.Count Then
						Me.gclass12_0 = New GClass12(Me.list_0(Me.int_7), GClass12.GEnum5.BruteForce)
						Me.bool_3 = False
						Me.genum6_0 = RandomPinForm.GEnum6.None
						Me.genum6_1 = Me.genum6_0
						Me.method_2()
						Me.GClass8_0.method_7(Me.gclass9_0, Me.gclass12_0)
						RandomPinForm.bool_2 = True
						Me.int_3 = 0
					End If
				Else
					Me.method_2()
				End If
			End If
			If(Me.bool_4 And Me.bool_5) AndAlso (Me.tsbAutoSave.Checked And Operators.CompareString(Me.string_2, "", False) <> 0) Then
				Me.TsbSave.PerformClick()
			End If
			Me.Timer_0.Start()
		End Sub

		' Token: 0x0600039F RID: 927 RVA: 0x00004555 File Offset: 0x00002755
		Private Sub method_13(sender As Object, e As EventArgs)
			Me.OpenFileDialog_0.FileName = Me.string_2
			If Me.OpenFileDialog_0.ShowDialog() = DialogResult.OK Then
				Me.string_2 = Me.OpenFileDialog_0.FileName
				Me.method_0()
			End If
		End Sub

		' Token: 0x060003A0 RID: 928 RVA: 0x00016584 File Offset: 0x00014784
		Private Sub method_14(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.string_2, "", False) = 0 Then
				Me.SaveFileDialog_0.FileName = Me.string_2
				If Me.SaveFileDialog_0.ShowDialog() = DialogResult.OK Then
					Me.string_2 = Me.SaveFileDialog_0.FileName
				End If
			End If
			If Operators.CompareString(Me.string_2, "", False) <> 0 Then
				Me.method_17(Me.string_2)
				Me.bool_4 = False
			End If
		End Sub

		' Token: 0x060003A1 RID: 929 RVA: 0x0000458F File Offset: 0x0000278F
		Private Sub method_15(sender As Object, e As EventArgs)
			Me.TsbSave.Enabled = Not Me.tsbAutoSave.Checked
		End Sub

		' Token: 0x060003A2 RID: 930 RVA: 0x000165FC File Offset: 0x000147FC
		Public Function method_16(string_3 As String) As Boolean
			Dim fileStream As FileStream = New FileStream(string_3, FileMode.Open, FileAccess.Read)
			Dim binaryReader As BinaryReader = New BinaryReader(fileStream)
			Dim left As String = New String(binaryReader.ReadChars(7))
			Dim num As Integer = CInt(binaryReader.ReadUInt32())
			Dim num2 As Integer = CInt(binaryReader.ReadUInt32())
			Dim left2 As String = New String(binaryReader.ReadChars(num2))
			num2 = CInt(binaryReader.ReadUInt32())
			New String(binaryReader.ReadChars(num2))
			Dim result As Boolean
			If Not(Operators.CompareString(left, "WairCut", False) <> 0 Or num > 2) Then
				If Operators.CompareString(left2, Me.gclass9_0.BSSID, False) <> 0 Then
					MessageBox.Show(Class10.String_67, "Error...", MessageBoxButtons.OK)
					result = False
				Else
					If num >= 2 Then
						num2 = CInt(binaryReader.ReadUInt32())
						Me.tbPinFormat1.Text = New String(binaryReader.ReadChars(num2))
						num2 = CInt(binaryReader.ReadUInt32())
						Me.tbPinFormat2.Text = New String(binaryReader.ReadChars(num2))
					End If
					Me.TbTime.Text = binaryReader.ReadInt32().ToString()
					Me.int_7 = binaryReader.ReadInt32()
					Me.bool_0 = binaryReader.ReadBoolean()
					Me.double_0 = CDbl(binaryReader.ReadInt32())
					num2 = binaryReader.ReadInt32()
					Dim num3 As Integer = num2 - 1
					For i As Integer = 0 To num3
						Me.list_0.Add(Conversions.ToString(binaryReader.ReadUInt32()))
					Next
					binaryReader.Close()
					fileStream.Close()
					result = True
				End If
			Else
				MessageBox.Show(Class10.String_65, "Error...", MessageBoxButtons.OK)
				result = False
			End If
			Return result
		End Function

		' Token: 0x060003A3 RID: 931 RVA: 0x0001678C File Offset: 0x0001498C
		Private Sub method_17(string_3 As String)
			Dim fileStream As FileStream = New FileStream(string_3, FileMode.Create, FileAccess.Write)
			Dim binaryWriter As BinaryWriter = New BinaryWriter(fileStream)
			binaryWriter.Write("WairCut".ToCharArray())
			binaryWriter.Write(2)
			binaryWriter.Write(Me.gclass9_0.BSSID.Length)
			binaryWriter.Write(Me.gclass9_0.BSSID.ToCharArray())
			binaryWriter.Write(Me.gclass9_0.SSID.Length)
			binaryWriter.Write(Me.gclass9_0.SSID.ToCharArray())
			binaryWriter.Write(Me.tbPinFormat1.Text.Length)
			binaryWriter.Write(Me.tbPinFormat1.Text.ToCharArray())
			binaryWriter.Write(Me.tbPinFormat2.Text.Length)
			binaryWriter.Write(Me.tbPinFormat2.Text.ToCharArray())
			binaryWriter.Write(Conversions.ToInteger(Me.TbTime.Text))
			binaryWriter.Write(Me.int_7)
			binaryWriter.Write(Me.bool_0)
			binaryWriter.Write(CInt(Math.Round(Me.double_0)))
			binaryWriter.Write(Me.list_0.Count)
			Try
				For Each value As String In Me.list_0
					Dim value2 As UInteger = Conversions.ToUInteger(value)
					binaryWriter.Write(value2)
				Next
			Finally
				Dim enumerator As List(Of String).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			binaryWriter.Close()
			fileStream.Close()
		End Sub

		' Token: 0x060003A4 RID: 932 RVA: 0x000045AA File Offset: 0x000027AA
		Private Sub method_18(sender As Object, e As EventArgs)
			If Me.tsbAutoSave.Checked Then
				Me.tsbSaveMenu.Image = GClass0.Bitmap_5
				Return
			End If
			Me.tsbSaveMenu.Image = GClass0.Bitmap_49
		End Sub

		' Token: 0x060003A5 RID: 933 RVA: 0x00003B20 File Offset: 0x00001D20
		Private Sub method_19(sender As Object, e As KeyPressEventArgs)
			If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
				e.Handled = False
				Return
			End If
			e.Handled = True
		End Sub

		' Token: 0x0400017D RID: 381
		<CompilerGenerated()>
		<AccessedThroughProperty("TUpdate")>
		Private timer_0 As Timer

		' Token: 0x04000184 RID: 388
		<CompilerGenerated()>
		<AccessedThroughProperty("OpenFileDialog1")>
		Private openFileDialog_0 As OpenFileDialog

		' Token: 0x04000185 RID: 389
		<AccessedThroughProperty("SaveFileDialog1")>
		<CompilerGenerated()>
		Private saveFileDialog_0 As SaveFileDialog

		' Token: 0x0400018E RID: 398
		Private Const int_0 As Integer = 10000

		' Token: 0x0400018F RID: 399
		Private Const int_1 As Integer = 1000

		' Token: 0x04000190 RID: 400
		Private gclass13_0 As GClass13

		' Token: 0x04000191 RID: 401
		Private gclass9_0 As GClass9

		' Token: 0x04000192 RID: 402
		Private gclass12_0 As GClass12

		' Token: 0x04000193 RID: 403
		Private string_0 As String

		' Token: 0x04000194 RID: 404
		Private bool_0 As Boolean

		' Token: 0x04000195 RID: 405
		<AccessedThroughProperty("jsApi")>
		<CompilerGenerated()>
		Private gclass8_0 As GClass8

		' Token: 0x04000196 RID: 406
		Private int_2 As Integer

		' Token: 0x04000197 RID: 407
		Private bool_1 As Boolean

		' Token: 0x04000198 RID: 408
		Private Shared bool_2 As Boolean = False

		' Token: 0x04000199 RID: 409
		Private timeSpan_0 As TimeSpan

		' Token: 0x0400019A RID: 410
		Private timeSpan_1 As TimeSpan

		' Token: 0x0400019B RID: 411
		Private double_0 As Double

		' Token: 0x0400019C RID: 412
		Private int_3 As Integer

		' Token: 0x0400019D RID: 413
		Private int_4 As Integer

		' Token: 0x0400019E RID: 414
		Private string_1 As String

		' Token: 0x0400019F RID: 415
		Private bool_3 As Boolean

		' Token: 0x040001A0 RID: 416
		Private int_5 As Integer

		' Token: 0x040001A1 RID: 417
		Private int_6 As Integer

		' Token: 0x040001A2 RID: 418
		Private bool_4 As Boolean

		' Token: 0x040001A3 RID: 419
		Private string_2 As String

		' Token: 0x040001A4 RID: 420
		Private genum6_0 As RandomPinForm.GEnum6

		' Token: 0x040001A5 RID: 421
		Private genum6_1 As RandomPinForm.GEnum6

		' Token: 0x040001A6 RID: 422
		Private int_7 As Integer

		' Token: 0x040001A7 RID: 423
		Private bool_5 As Boolean

		' Token: 0x040001A8 RID: 424
		Private list_0 As List(Of String)

		' Token: 0x040001A9 RID: 425
		Private bool_6 As Boolean

		' Token: 0x02000031 RID: 49
		Public Enum GEnum6
			' Token: 0x040001AB RID: 427
			None
			' Token: 0x040001AC RID: 428
			Ok
			' Token: 0x040001AD RID: 429
			NoOk
			' Token: 0x040001AE RID: 430
			fHalfOk
			' Token: 0x040001AF RID: 431
			Fault
			' Token: 0x040001B0 RID: 432
			ApLocked
			' Token: 0x040001B1 RID: 433
			PinNotFound
			' Token: 0x040001B2 RID: 434
			ApNotFound
			' Token: 0x040001B3 RID: 435
			AssociationFailed
		End Enum

		' Token: 0x02000032 RID: 50
		' (Invoke) Token: 0x060003A9 RID: 937
		Public Delegate Sub GDelegate11(status As GClass8.GEnum1)

		' Token: 0x02000033 RID: 51
		' (Invoke) Token: 0x060003AD RID: 941
		Public Delegate Sub GDelegate12(sender As Object, e As EventArgs)
	End Class
End Namespace
