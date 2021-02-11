Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports wAirCut.My

Namespace wAirCut
	' Token: 0x0200001A RID: 26
	<DesignerGenerated()>
	Public Partial Class MainForm
		Inherits Form

		' Token: 0x170000E6 RID: 230
		' (get) Token: 0x060001AA RID: 426 RVA: 0x000039A6 File Offset: 0x00001BA6
		' (set) Token: 0x060001AB RID: 427 RVA: 0x00008E30 File Offset: 0x00007030
		Private Overridable Property GClass8_0 As GClass8
			<CompilerGenerated()>
			Get
				Return Me.gclass8_0
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass8)
				Dim value2 As GClass8.GDelegate6 = AddressOf Me.method_21
				Dim value3 As GClass8.GDelegate8 = AddressOf Me.method_24
				Dim gclass As GClass8 = Me.gclass8_0
				If gclass IsNot Nothing Then
					RemoveHandler gclass.Event_0, value2
					RemoveHandler gclass.Event_2, value3
				End If
				Me.gclass8_0 = value
				gclass = Me.gclass8_0
				If gclass IsNot Nothing Then
					AddHandler gclass.Event_0, value2
					AddHandler gclass.Event_2, value3
				End If
			End Set
		End Property

		' Token: 0x170000E7 RID: 231
		' (get) Token: 0x060001AC RID: 428 RVA: 0x000039AE File Offset: 0x00001BAE
		' (set) Token: 0x060001AD RID: 429 RVA: 0x00008E90 File Offset: 0x00007090
		Private Overridable Property GClass10_0 As GClass10
			<CompilerGenerated()>
			Get
				Return Me.gclass10_0
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass10)
				Dim value2 As GClass10.GDelegate9 = AddressOf Me.method_61
				Dim gclass As GClass10 = Me.gclass10_0
				If gclass IsNot Nothing Then
					RemoveHandler gclass.Event_0, value2
				End If
				Me.gclass10_0 = value
				gclass = Me.gclass10_0
				If gclass IsNot Nothing Then
					AddHandler gclass.Event_0, value2
				End If
			End Set
		End Property

		' Token: 0x060001AE RID: 430 RVA: 0x00008ED4 File Offset: 0x000070D4
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.MainForm_Load
			AddHandler MyBase.FormClosing, AddressOf Me.MainForm_FormClosing
			Me.gclass15_0 = New GClass15(Of GClass9)()
			Me.gclass12_0 = New GClass12()
			Me.int_0 = 0
			Me.bool_0 = False
			Me.bool_1 = False
			Me.bool_2 = False
			Me.bool_3 = False
			Me.bindingSource_0 = New BindingSource()
			Me.bindingSource_1 = New BindingSource()
			If Operators.CompareString(MySettings.[Default].Culture, "", False) = 0 Then
				MySettings.[Default].Culture = Thread.CurrentThread.CurrentUICulture.Name
			End If
			Thread.CurrentThread.CurrentUICulture = New CultureInfo(MySettings.[Default].Culture)
			Me.InitializeComponent()
		End Sub

		' Token: 0x060001AF RID: 431 RVA: 0x00008FAC File Offset: 0x000071AC
		Private Sub MainForm_Load(sender As Object, e As EventArgs)
			Me.TsCpyRigth.Text = Class6.Form0_0.Info.Copyright
			Dim name As String = Thread.CurrentThread.CurrentUICulture.Name
			Dim flag As Boolean = True
			If True = name.Contains("es") Then
				Me.cbLanguage.SelectedIndex = 0
			ElseIf flag = name.Contains("en") Then
				Me.cbLanguage.SelectedIndex = 1
			ElseIf flag <> name.Contains("ru") Then
				If flag <> name.Contains("fr") Then
					Me.cbLanguage.SelectedIndex = 1
				Else
					Me.cbLanguage.SelectedIndex = 3
				End If
			Else
				Me.cbLanguage.SelectedIndex = 2
			End If
			AddHandler Me.cbLanguage.SelectedIndexChanged, AddressOf Me.method_62
			If Class13.bool_0 Then
				Me.ScrollLabel1.Visible = False
				Me.btDonate.Visible = False
			End If
			If Not Class13.smethod_4() Then
				MessageBox.Show(Class10.String_61, "ERROR", MessageBoxButtons.OK)
				Application.[Exit]()
			Else
				Dim creationTime As DateTime = File.GetCreationTime(Assembly.GetExecutingAssembly().Location)
				If DateTime.Compare(MySettings.[Default].StartTime, creationTime) < 0 Then
					If MessageBox.Show(Class10.String_29, "ATTENTION", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
						MySettings.[Default].StartTime = DateAndTime.Now
					Else
						Application.[Exit]()
					End If
				End If
				If Not Class13.smethod_5() Then
					Application.[Exit]()
				End If
			End If
			Class13.string_7 = String.Format("waircut_{0}.log", DateAndTime.Now.[Date].ToString("ddMMyyyy"))
			Me.btPrivateMode.Visible = False
			Me.Text = String.Format("{0} - Release {1}", Class6.Form0_0.Info.Description, Class13.Version)
			Me.method_0()
			Me.GClass8_0 = New GClass8()
			Me.method_1()
			If Me.GClass8_0.list_0.Count = 0 Then
				MessageBox.Show(Class10.String_55, "ERROR", MessageBoxButtons.OK)
				Application.[Exit]()
			End If
			Me.method_2()
			Me.DgvAttributes.ClearSelection()
			Me.ToolTip_0.SetToolTip(Me.BtExpandMessage, Class10.String_5)
			Me.DgvAps.AutoGenerateColumns = False
			Me.GClass10_0 = New GClass10()
			If Operators.CompareString(Class13.string_6, "", False) = 0 Then
				Class13.string_6 = Class10.String_30
			End If
			Me.ScrollLabel1.Text = Class13.string_6
			Me.tbScanTime.Text = Conversions.ToString(MySettings.[Default].ScanTime)
		End Sub

		' Token: 0x060001B0 RID: 432 RVA: 0x000039B6 File Offset: 0x00001BB6
		Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs)
			If Me.GClass10_0 IsNot Nothing Then
				Me.GClass10_0.method_0()
			End If
			Class13.smethod_3(GClass0.String_0)
			MySettings.[Default].Save()
		End Sub

		' Token: 0x060001B1 RID: 433 RVA: 0x0000922C File Offset: 0x0000742C
		Private Sub method_0()
			For Each str As String In Class13.string_0
				Me.method_22(vbTab & vbTab & vbTab & vbTab + str, Color.Green, True)
			Next
		End Sub

		' Token: 0x060001B2 RID: 434 RVA: 0x00009268 File Offset: 0x00007468
		Private Sub method_1()
			Me.cbAdapters.Items.Clear()
			Me.GClass8_0.method_3()
			Try
				For Each ginterface As GInterface1 In Me.GClass8_0.list_0
					Me.cbAdapters.Items.Add(ginterface.String_0)
				Next
			Finally
				Dim enumerator As List(Of GInterface1).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			If Me.cbAdapters.Items.Count > 0 Then
				Me.cbAdapters.SelectedIndex = 0
			End If
		End Sub

		' Token: 0x060001B3 RID: 435 RVA: 0x0000930C File Offset: 0x0000750C
		Private Sub method_2()
			Me.DgvAttributes.Rows.Add(14)
			Me.DgvAttributes.Rows(0).Cells(0).Value = Class10.String_20
			Me.DgvAttributes.Rows(1).Cells(0).Value = Class10.String_17
			Me.DgvAttributes.Rows(2).Cells(0).Value = Class10.String_18
			Me.DgvAttributes.Rows(3).Cells(0).Value = Class10.String_19
			Me.DgvAttributes.Rows(4).Cells(0).Value = Class10.String_23
			Me.DgvAttributes.Rows(5).Cells(0).Value = Class10.String_14
			Me.DgvAttributes.Rows(6).Cells(0).Value = "UUID"
			Me.DgvAttributes.Rows(7).Cells(0).Value = Class10.String_25
			Me.DgvAttributes.Rows(8).Cells(0).Value = Class10.String_16
			Me.DgvAttributes.Rows(9).Cells(0).Value = "MAC"
			Me.DgvAttributes.Rows(10).Cells(0).Value = Class10.String_22
			Me.DgvAttributes.Rows(11).Cells(0).Value = Class10.String_15
			Me.DgvAttributes.Rows(12).Cells(0).Value = Class10.String_24
			Me.DgvAttributes.Rows(13).Cells(0).Value = Class10.String_21
		End Sub

		' Token: 0x060001B4 RID: 436 RVA: 0x000039DF File Offset: 0x00001BDF
		Private Sub method_3(sender As Object, e As EventArgs)
			Me.method_1()
		End Sub

		' Token: 0x060001B5 RID: 437 RVA: 0x00009548 File Offset: 0x00007748
		Private Sub method_4(sender As Object, e As EventArgs)
			Me.Cursor = Cursors.WaitCursor
			Me.gclass15_0 = Me.GClass8_0.method_6(Me.tsWPSOnly.Checked, MySettings.[Default].ScanTime)
			Me.Cursor = Cursors.[Default]
			Me.method_7()
		End Sub

		' Token: 0x060001B6 RID: 438 RVA: 0x00009598 File Offset: 0x00007798
		Private Sub method_5(sender As Object, e As EventArgs)
			If Me.DgvPins.IsCurrentRowDirty Then
				Me.DgvPins.EndEdit()
			Else
				Me.DgvPins.CancelEdit()
			End If
			Me.method_7()
			Me.tsApToolMenu.Enabled = False
			Me.method_23(False)
			Dim gclass As GClass8 = Me.GClass8_0
			Dim gclass2 As GClass9 = Nothing
			Dim dgvAps As Control = Me.DgvAps
			Dim text As String = gclass.method_12(gclass2, Me.gclass15_0, dgvAps)
			Me.DgvAps = CType(dgvAps, DataGridView)
			Dim right As String = text
			Try
				For Each gclass3 As GClass9 In Me.gclass15_0
					If Operators.CompareString(gclass3.BSSID, right, False) = 0 Then
						Me.gclass9_0 = gclass3
						Me.gclass12_0.Pin = ""
						Me.gclass12_0.Type = GClass12.GEnum5.PushButton
						Me.GClass8_0.method_8(Me.gclass9_0, Me.gclass12_0)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of GClass9)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Me.tsApToolMenu.Enabled = True
			Me.method_23(True)
		End Sub

		' Token: 0x060001B7 RID: 439 RVA: 0x000096A8 File Offset: 0x000078A8
		Private Sub method_6(int_1 As Integer, genum3_0 As GClass9.GEnum3)
			Select Case genum3_0
				Case GClass9.GEnum3.Unknow
					Me.DgvAps.Rows(int_1).Cells("dgvApsStatus").Value = GClass0.Bitmap_6
					Return
				Case GClass9.GEnum3.Ok
					Me.DgvAps.Rows(int_1).Cells("dgvApsStatus").Value = GClass0.Bitmap_15
					Me.DgvAps.Rows(int_1).Cells("dgvApsStatus").ToolTipText = Class10.String_12
					Return
				Case GClass9.GEnum3.Nok
					Me.DgvAps.Rows(int_1).Cells("dgvApsStatus").Value = GClass0.Bitmap_16
					Me.DgvAps.Rows(int_1).Cells("dgvApsStatus").ToolTipText = Class10.String_11
					Return
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x060001B8 RID: 440 RVA: 0x000039E7 File Offset: 0x00001BE7
		Private Sub method_7()
			Me.bindingSource_0.DataSource = Me.gclass15_0
			Me.DgvAps.DataSource = Me.bindingSource_0
			Me.DgvAps.Invalidate()
		End Sub

		' Token: 0x060001B9 RID: 441 RVA: 0x000097A0 File Offset: 0x000079A0
		Private Sub method_8(sender As Object, e As EventArgs)
			If Me.cbAdapters.SelectedIndex >= 0 Then
				Me.DgvAps.Rows.Clear()
				Me.DgvPins.Rows.Clear()
				Me.DgvAttributes.Rows.Clear()
				Me.method_2()
				Me.GClass8_0 = New GClass8()
				Me.gclass15_0.Clear()
				Try
					Me.int_0 = Me.cbAdapters.SelectedIndex
					Me.GClass8_0.method_4(Me.int_0)
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x060001BA RID: 442 RVA: 0x0000984C File Offset: 0x00007A4C
		Private Sub method_9(ByRef gclass9_1 As GClass9)
			Me.DgvAttributes.Rows(0).Cells(1).Value = gclass9_1.string_0
			Me.DgvAttributes.Rows(1).Cells(1).Value = gclass9_1.string_1
			Me.DgvAttributes.Rows(2).Cells(1).Value = gclass9_1.string_2
			Me.DgvAttributes.Rows(3).Cells(1).Value = gclass9_1.string_3
			Me.DgvAttributes.Rows(4).Cells(1).Value = gclass9_1.SerialNumber
			Me.DgvAttributes.Rows(5).Cells(1).Value = gclass9_1.string_5
			Me.DgvAttributes.Rows(6).Cells(1).Value = gclass9_1.UUID
			Me.DgvAttributes.Rows(7).Cells(1).Value = gclass9_1.Version
			Me.DgvAttributes.Rows(8).Cells(1).Value = gclass9_1.ApSetupLocked
			Me.DgvAttributes.Rows(9).Cells(1).Value = gclass9_1.BSSID
			Me.DgvAttributes.Rows(10).Cells(1).Value = gclass9_1.string_9
			Me.DgvAttributes.Rows(11).Cells(1).Value = gclass9_1.string_10
			Me.DgvAttributes.Rows(12).Cells(1).Style.ForeColor = Color.Blue
			Me.DgvAttributes.Rows(12).Cells(1).Value = gclass9_1.Pin.Pin
			Me.DgvAttributes.Rows(13).Cells(1).Style.ForeColor = Color.Blue
			Me.DgvAttributes.Rows(13).Cells(1).Value = gclass9_1.NetworkKey
		End Sub

		' Token: 0x060001BB RID: 443 RVA: 0x00009AF0 File Offset: 0x00007CF0
		Private Sub method_10(sender As Object, e As EventArgs)
			If Me.DgvAps.SelectedRows.Count <> 0 Then
				Me.gclass9_0 = CType(Me.bindingSource_0.Current, GClass9)
				Me.bindingSource_1.DataSource = Me.gclass9_0.gclass15_0
				Me.DgvPins.DataSource = Me.bindingSource_1
				Me.DgvPins.Invalidate()
				If Me.DgvAps.SelectedRows.Count = 0 Or Me.gclass15_0.Count = 0 Then
					Me.TsbPin.Enabled = False
					Me.TsbAllPin.Enabled = False
					Me.TsbRandomPin.Enabled = False
					Me.TsbPixie.Enabled = False
					Me.tsbPButton.Enabled = False
					Return
				End If
				Try
					Me.method_9(Me.gclass9_0)
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x060001BC RID: 444 RVA: 0x00003A16 File Offset: 0x00001C16
		Private Sub method_11(sender As Object, e As DataGridViewBindingCompleteEventArgs)
			Me.DgvPins.Enabled = (Me.gclass15_0.Count > 0)
		End Sub

		' Token: 0x060001BD RID: 445 RVA: 0x00009BE8 File Offset: 0x00007DE8
		Private Sub method_12(sender As Object, e As DataGridViewBindingCompleteEventArgs)
			If Not Me.bool_1 Then
				If Me.gclass15_0.Count > 0 Then
					Me.TsbPin.Enabled = (Me.gclass9_0.gclass15_0.Count > 0)
					Me.TsbAllPin.Enabled = (Me.gclass9_0.gclass15_0.Count > 1)
					Me.tsbPButton.Enabled = True
					Me.TsbRandomPin.Enabled = True
					Me.TsbPixie.Enabled = True
					Return
				End If
				Me.TsbPin.Enabled = False
				Me.TsbAllPin.Enabled = False
				Me.TsbRandomPin.Enabled = False
				Me.TsbPixie.Enabled = False
				Me.tsbPButton.Enabled = False
			End If
		End Sub

		' Token: 0x060001BE RID: 446 RVA: 0x00009CAC File Offset: 0x00007EAC
		Private Sub method_13(sender As Object, e As DataGridViewCellValidatingEventArgs)
			If(e.RowIndex >= 0 And e.ColumnIndex >= 0) AndAlso Operators.ConditionalCompareObjectNotEqual(e.FormattedValue, Me.DgvPins.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, False) Then
				CType(Me.bindingSource_1.Current, GClass12).Description = "Manual"
			End If
		End Sub

		' Token: 0x060001BF RID: 447 RVA: 0x00003A31 File Offset: 0x00001C31
		Private Sub method_14(sender As Object, e As DataGridViewDataErrorEventArgs)
		End Sub

		' Token: 0x060001C0 RID: 448 RVA: 0x00009D28 File Offset: 0x00007F28
		Private Sub method_15(sender As Object, e As EventArgs)
			If Me.DgvPins.IsCurrentRowDirty Then
				Me.DgvPins.EndEdit()
			Else
				Me.DgvPins.CancelEdit()
			End If
			Me.gclass12_0 = CType(Me.bindingSource_1.Current, GClass12)
			Me.GClass8_0.method_7(Me.gclass9_0, Me.gclass12_0)
		End Sub

		' Token: 0x060001C1 RID: 449 RVA: 0x00009D8C File Offset: 0x00007F8C
		Private Sub method_16(sender As Object, e As EventArgs)
			If Me.DgvPins.IsCurrentRowDirty Then
				Me.DgvPins.EndEdit()
			Else
				Me.DgvPins.CancelEdit()
			End If
			Dim gclass As GClass8 = Me.GClass8_0
			Dim randomPinForm As RandomPinForm = New RandomPinForm(gclass, Me.gclass9_0, False)
			Me.GClass8_0 = gclass
			randomPinForm.ShowDialog()
			randomPinForm.Dispose()
		End Sub

		' Token: 0x060001C2 RID: 450 RVA: 0x00009DE8 File Offset: 0x00007FE8
		Private Sub method_17(sender As Object, e As EventArgs)
			If Me.DgvPins.IsCurrentRowDirty Then
				Me.DgvPins.EndEdit()
			Else
				Me.DgvPins.CancelEdit()
			End If
			Me.method_23(False)
			Me.DgvAps.Enabled = False
			Dim gclass As GClass8 = Me.GClass8_0
			Dim rtbMessage As Control = Me.RtbMessage
			Dim left As String = gclass.method_12(Me.gclass9_0, Me.gclass15_0, rtbMessage)
			Me.RtbMessage = CType(rtbMessage, RichTextBox)
			If Operators.CompareString(left, Me.gclass9_0.BSSID, False) = 0 Then
				Me.gclass12_0.Pin = ""
				Me.gclass12_0.Type = GClass12.GEnum5.PushButton
				Me.GClass8_0.method_8(Me.gclass9_0, Me.gclass12_0)
			End If
			Me.method_23(True)
			Me.DgvAps.Enabled = True
		End Sub

		' Token: 0x060001C3 RID: 451 RVA: 0x00009EB4 File Offset: 0x000080B4
		Private Sub method_18(sender As Object, e As EventArgs)
			Dim gclass As GClass8 = Me.GClass8_0
			Dim randomPinForm As RandomPinForm = New RandomPinForm(gclass, Me.gclass9_0, True)
			Me.GClass8_0 = gclass
			randomPinForm.ShowDialog()
			randomPinForm.Dispose()
		End Sub

		' Token: 0x060001C4 RID: 452 RVA: 0x00003A33 File Offset: 0x00001C33
		Private Sub method_19(sender As Object, e As EventArgs)
			Me.GClass8_0.method_9(Me.gclass9_0)
			Me.bool_3 = True
		End Sub

		' Token: 0x060001C5 RID: 453 RVA: 0x00003A4D File Offset: 0x00001C4D
		Private Sub method_20(sender As Object, e As EventArgs)
			Me.GClass8_0.method_10(True)
			Me.bool_3 = False
		End Sub

		' Token: 0x060001C6 RID: 454 RVA: 0x00009EEC File Offset: 0x000080EC
		Private Sub method_21(string_0 As String, color_0 As Color, bool_4 As Boolean)
			If MyBase.InvokeRequired Then
				Try
					Dim method As MainForm.GDelegate4 = AddressOf Me.method_21
					MyBase.Invoke(method, New Object() { string_0, color_0, bool_4 })
					Return
				Catch ex As Exception
					Return
				End Try
			End If
			Me.method_22(string_0, color_0, bool_4)
		End Sub

		' Token: 0x060001C7 RID: 455 RVA: 0x00009F5C File Offset: 0x0000815C
		Public Sub method_22(string_0 As String, color_0 As Color, bool_4 As Boolean)
			Try
				If Me.RtbMessage.Lines.Count() > 2000 Then
					Me.RtbMessage.Clear()
				End If
				If string_0 <> String.Empty Then
					Me.RtbMessage.SelectionColor = color_0
					If bool_4 Then
						string_0 += vbCrLf
					End If
					Me.RtbMessage.AppendText(string_0)
					If Class13.bool_2 Then
						Class13.smethod_15(Class13.string_7, string_0)
					End If
					Class13.smethod_14(Me.RtbMessage)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060001C8 RID: 456 RVA: 0x00009FF8 File Offset: 0x000081F8
		Private Sub method_23(bool_4 As Boolean)
			Try
				Me.btScan.Enabled = bool_4
				Me.tsbPbcScan.Enabled = bool_4
				Me.btRefresh.Enabled = bool_4
				Me.tsWPSOnly.Enabled = bool_4
				Me.TsbAllPin.Enabled = (bool_4 And (Me.gclass9_0 IsNot Nothing AndAlso Me.gclass9_0.gclass15_0.Count > 1))
				Me.TsbPin.Enabled = (bool_4 And (Me.gclass9_0 IsNot Nothing AndAlso Me.gclass9_0.gclass15_0.Count > 0))
				Me.TsbRandomPin.Enabled = bool_4
				Me.TsbPixie.Enabled = bool_4
				Me.tsbPButton.Enabled = bool_4
				Me.TsbStop.Enabled = Not bool_4
				Me.cbAdapters.Enabled = bool_4
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060001C9 RID: 457 RVA: 0x0000A0EC File Offset: 0x000082EC
		Private Sub method_24(genum1_0 As GClass8.GEnum1)
			If MyBase.InvokeRequired Then
				Try
					Dim method As MainForm.GDelegate5 = AddressOf Me.method_24
					MyBase.Invoke(method, New Object() { genum1_0 })
					Return
				Catch ex As Exception
					Return
				End Try
			End If
			Me.method_25(genum1_0)
		End Sub

		' Token: 0x060001CA RID: 458 RVA: 0x0000A14C File Offset: 0x0000834C
		Private Sub method_25(genum1_0 As GClass8.GEnum1)
			If genum1_0 <= GClass8.GEnum1.Start Then
				If genum1_0 = GClass8.GEnum1.[Stop] Then
					Me.method_23(True)
					Me.method_9(Me.gclass9_0)
					Me.bool_1 = False
					Me.method_7()
					Return
				End If
				If genum1_0 <> GClass8.GEnum1.Start Then
					Return
				End If
				Me.method_23(False)
				Me.bool_1 = True
				Return
			Else
				If genum1_0 = GClass8.GEnum1.Updated Then
					Me.method_9(Me.gclass9_0)
					Return
				End If
				If genum1_0 = GClass8.GEnum1.PixieSucced Then
					If Me.bool_3 Then
						Me.GClass8_0.method_10(False)
						Me.method_22(vbCrLf & "[P] AuthKey: " + Me.gclass9_0.AuthKey, Color.White, True)
						Me.method_22("[P]     PKE: " + Me.gclass9_0.PKE, Color.White, True)
						Me.method_22("[P]     PKR: " + Me.gclass9_0.PKR, Color.White, True)
						Me.method_22("[P] E-HASH1: " + Me.gclass9_0.E_HAS1, Color.White, True)
						Me.method_22("[P] E-HASH2: " + Me.gclass9_0.E_HAS2, Color.White, True)
						Me.method_22("[P] E-NONCE: " + Me.gclass9_0.E_NONCE, Color.White, True)
						Me.method_22("[P] R-NONCE: " + Me.gclass9_0.R_NONCE, Color.White, True)
						Me.method_22(Class13.string_4, Color.LightGreen, False)
						If Me.bool_3 Then
							Me.method_60("-f", True)
						End If
					End If
					Return
				End If
				Return
			End If
		End Sub

		' Token: 0x060001CB RID: 459 RVA: 0x0000A2D8 File Offset: 0x000084D8
		Private Sub method_26(sender As Object, e As EventArgs)
			Me.bool_0 = Not Me.bool_0
			If Me.bool_0 Then
				Me.BtExpandMessage.BackgroundImage = GClass0.Bitmap_3
				Me.ToolTip_0.SetToolTip(Me.BtExpandMessage, Class10.String_4)
			Else
				Me.BtExpandMessage.BackgroundImage = GClass0.Bitmap_4
				Me.ToolTip_0.SetToolTip(Me.BtExpandMessage, Class10.String_5)
			End If
			Me.GClass8_0.bool_2 = Me.bool_0
		End Sub

		' Token: 0x060001CC RID: 460 RVA: 0x00003A62 File Offset: 0x00001C62
		Private Sub method_27(sender As Object, e As EventArgs)
			Me.RtbMessage.Clear()
			Me.method_22(Class13.string_4, Color.LightGreen, False)
		End Sub

		' Token: 0x060001CD RID: 461 RVA: 0x00003A80 File Offset: 0x00001C80
		Private Sub method_28(sender As Object, e As EventArgs)
			New AboutForm().ShowDialog()
		End Sub

		' Token: 0x060001CE RID: 462 RVA: 0x00003A8D File Offset: 0x00001C8D
		Private Sub method_29(sender As Object, e As EventArgs)
			Class13.bool_1 = Me.btPrivateMode.Checked
		End Sub

		' Token: 0x060001CF RID: 463 RVA: 0x00003A9F File Offset: 0x00001C9F
		Private Sub method_30(sender As Object, e As EventArgs)
			Dim wpsPinForm As WpsPinForm = New WpsPinForm()
			wpsPinForm.ShowDialog()
			wpsPinForm.Dispose()
		End Sub

		' Token: 0x060001D0 RID: 464 RVA: 0x00003AB2 File Offset: 0x00001CB2
		Private Sub method_31(sender As Object, e As EventArgs)
			Dim apLogForm As ApLogForm = New ApLogForm()
			apLogForm.ShowDialog()
			apLogForm.Dispose()
		End Sub

		' Token: 0x060001D1 RID: 465 RVA: 0x0000A35C File Offset: 0x0000855C
		Private Sub method_32(sender As Object, e As EventArgs)
			Dim gclass As GClass8 = Me.GClass8_0
			Dim pixieForm As PixieForm = New PixieForm(gclass, Me.gclass9_0)
			Me.GClass8_0 = gclass
			pixieForm.ShowDialog()
			pixieForm.Dispose()
		End Sub

		' Token: 0x060001D2 RID: 466 RVA: 0x00003AC5 File Offset: 0x00001CC5
		Private Sub method_33(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
			Me.bool_2 = True
		End Sub

		' Token: 0x060001D3 RID: 467 RVA: 0x0000A390 File Offset: 0x00008590
		Private Sub method_34(sender As Object, e As DataGridViewCellFormattingEventArgs)
			Dim name As String = CType(sender, DataGridView).Columns(e.ColumnIndex).Name
			IL_119:
			While Operators.CompareString(name, "dgvApsStatus", False) <> 0
				IL_106:
				While Operators.CompareString(name, "DgvApsPinStatus", False) = 0
					While True
						IL_F8:
						Dim genum As GClass3.GEnum0 = CType(Conversions.ToInteger(e.Value), GClass3.GEnum0)
						While True
							IL_DD:
							Select Case genum
								Case GClass3.GEnum0.ZAO
									GoTo IL_12C
								Case GClass3.GEnum0.FTE
									GoTo IL_16C
								Case GClass3.GEnum0.EasyBox
									GoTo IL_1A9
								Case GClass3.GEnum0.dLINK
									GoTo IL_1E6
								Case Else
									Dim num2 As UInteger
									Dim num As Integer = CInt((num2 * 658693119UI Xor 2816349336UI))
									While True
										Dim num3 As Integer = num Xor -817351656
										num2 = CUInt(num3)
										Select Case num3 Mod 34
											Case 0, 29
												GoTo IL_119
											Case 1, 13, 19, 27
												GoTo IL_221
											Case 2
												GoTo IL_32E
											Case 3
												GoTo IL_16C
											Case 4
												GoTo IL_12C
											Case 5
												GoTo IL_1A9
											Case 6, 10, 12, 31
												GoTo IL_3B3
											Case 7
												Return
											Case 9
												GoTo IL_177
											Case 11
												Return
											Case 14
												GoTo IL_1F1
											Case 15
												GoTo IL_378
											Case 16
												GoTo IL_346
											Case 17
												GoTo IL_253
											Case 18
												GoTo IL_29B
											Case 20
												GoTo IL_1E6
											Case 21
												GoTo IL_106
											Case 22
												GoTo IL_30B
											Case 23
												GoTo IL_F8
											Case 24
												num = CInt((num2 * 645486715UI Xor 2589827669UI))
												Continue For
											Case 25
												GoTo IL_2B0
											Case 26
												GoTo IL_DD
											Case 28
												GoTo IL_33B
											Case 30
												GoTo IL_2CA
											Case 32
												GoTo IL_2C3
											Case 33
												GoTo IL_241
										End Select
										GoTo Block_1
									End While
							End Select
						End While
					End While
					Block_1:
					Return
					IL_12C:
					e.Value = GClass0.Bitmap_21
					Me.DgvAps.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = Class10.String_9
					GoTo IL_221
					IL_16C:
					e.Value = GClass0.Bitmap_20
					IL_177:
					Me.DgvAps.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = Class10.String_10
					GoTo IL_221
					IL_1A9:
					e.Value = GClass0.Bitmap_22
					Me.DgvAps.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = Class10.String_8
					GoTo IL_221
					IL_1E6:
					e.Value = GClass0.Bitmap_19
					IL_1F1:
					Me.DgvAps.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = Class10.String_7
					IL_221:
					If Not CType(Me.bindingSource_0(e.RowIndex), GClass9).bool_1 Then
						Return
					End If
					IL_241:
					Dim bitmap As Bitmap = New Bitmap(16, 16)
					Dim graphics As Graphics = Graphics.FromImage(bitmap)
					IL_253:
					Dim instance As Object = graphics
					Dim type As Type = Nothing
					Dim memberName As String = "DrawImage"
					Dim array As Object() = New Object() { e.Value, New Point(0, 0) }
					Dim array2 As Object() = array
					Dim argumentNames As String() = Nothing
					Dim typeArguments As Type() = Nothing
					Dim array3 As Boolean() = New Boolean(1) {}
					array3(0) = True
					Dim array4 As Boolean() = array3
					NewLateBinding.LateCall(instance, type, memberName, array, argumentNames, typeArguments, array3, True)
					If Not array4(0) Then
						GoTo IL_2B0
					End If
					IL_29B:
					e.Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2(0)))
					IL_2B0:
					graphics.DrawImage(GClass0.Bitmap_55, New Point(0, 0))
					IL_2C3:
					e.Value = bitmap
					IL_2CA:
					Dim dataGridViewCell As DataGridViewCell = Me.DgvAps.Rows(e.RowIndex).Cells(e.ColumnIndex)
					Dim dataGridViewCell2 As DataGridViewCell = dataGridViewCell
					dataGridViewCell.ToolTipText = dataGridViewCell2.ToolTipText + Class10.String_13
					Return
				End While
				Return
				IL_32E:
				e.Value = GClass0.Bitmap_6
				GoTo IL_3B3
				IL_33B:
				e.Value = GClass0.Bitmap_15
				IL_346:
				Me.DgvAps.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = Class10.String_12
				GoTo IL_3B3
				IL_378:
				e.Value = GClass0.Bitmap_16
				Me.DgvAps.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = Class10.String_11
				IL_3B3:
				e.FormattingApplied = True
				Return
			End While
			IL_30B:
			Select Case Conversions.ToInteger(e.Value)
				Case 0
					GoTo IL_32E
				Case 1
					GoTo IL_33B
				Case 2
					GoTo IL_378
				Case Else
					GoTo IL_3B3
			End Select
		End Sub

		' Token: 0x060001D4 RID: 468 RVA: 0x0000A758 File Offset: 0x00008958
		Private Sub method_35(sender As Object, e As CancelEventArgs)
			Me.tbMenuPin_Checksum.Enabled = (Operators.CompareString(Me.ContextMenuPin.SourceControl.Name, "DgvAps", False) <> 0)
			Dim name As String = Me.ContextMenuPin.SourceControl.Name
			If Operators.CompareString(name, "DgvAps", False) = 0 Then
				e.Cancel = (Me.DgvAps.SelectedRows.Count = 0)
				Return
			End If
			If Operators.CompareString(name, "DgvPins", False) = 0 Then
				e.Cancel = (Me.DgvPins.SelectedRows.Count = 0)
				Return
			End If
		End Sub

		' Token: 0x060001D5 RID: 469 RVA: 0x0000A7F0 File Offset: 0x000089F0
		Private Sub method_36(sender As Object, e As EventArgs)
			If Me.DgvPins.SelectedRows.Count <> 0 Then
				Dim text As String = Conversions.ToString(Me.DgvPins.SelectedRows(0).Cells("DgvPinsPin").Value)
				If Operators.CompareString(text, "", False) <> 0 Then
					text = text.Substring(0, 7)
					text += GClass3.smethod_0(Conversions.ToInteger(text)).ToString()
					Me.DgvPins.SelectedRows(0).Cells("DgvPinsPin").Value = text
				End If
			End If
		End Sub

		' Token: 0x060001D6 RID: 470 RVA: 0x0000A894 File Offset: 0x00008A94
		Private Sub method_37(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_1(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.ZAO))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001D7 RID: 471 RVA: 0x0000A8F4 File Offset: 0x00008AF4
		Private Sub method_38(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_3(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.AiroConru))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001D8 RID: 472 RVA: 0x0000A954 File Offset: 0x00008B54
		Private Sub method_39(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_5(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.EasyBox))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001D9 RID: 473 RVA: 0x0000A9B4 File Offset: 0x00008BB4
		Private Sub method_40(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_7(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.TrendNet))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001DA RID: 474 RVA: 0x0000AA14 File Offset: 0x00008C14
		Private Sub method_41(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(Conversions.ToString(GClass3.smethod_4(CType(Me.bindingSource_0.Current, GClass9).BSSID)), GClass3.GEnum0.dLINK))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001DB RID: 475 RVA: 0x0000AA78 File Offset: 0x00008C78
		Private Sub method_42(sender As Object, e As EventArgs)
			Dim ssid As String = CType(Me.bindingSource_0.Current, GClass9).SSID
			If LikeOperator.LikeString(ssid, "FTE-????", CompareMethod.Binary) Then
				Me.bindingSource_1.CancelEdit()
				Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_9(CType(Me.bindingSource_0.Current, GClass9).BSSID, ssid), GClass3.GEnum0.FTE))
				Me.bindingSource_1.EndEdit()
				Me.DgvPins.Invalidate()
				Return
			End If
			Dim array As String() = New String() { "", "", "" }
			Dim array2 As String() = GClass3.smethod_8(CType(Me.bindingSource_0.Current, GClass9).BSSID)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(array2(0), GClass3.GEnum0.FTE))
			Me.gclass9_0.gclass15_0.Add(New GClass12(array2(1), GClass3.GEnum0.FTE))
			Me.gclass9_0.gclass15_0.Add(New GClass12(array2(2), GClass3.GEnum0.FTE))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001DC RID: 476 RVA: 0x0000ABA4 File Offset: 0x00008DA4
		Private Sub method_43(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_10(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.Asus))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001DD RID: 477 RVA: 0x0000AC04 File Offset: 0x00008E04
		Private Sub method_44(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_12(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.d28bit))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001DE RID: 478 RVA: 0x0000AC64 File Offset: 0x00008E64
		Private Sub method_45(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_13(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.d32bit))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001DF RID: 479 RVA: 0x0000ACC4 File Offset: 0x00008EC4
		Private Sub method_46(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_14(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.d36bit))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001E0 RID: 480 RVA: 0x0000AD24 File Offset: 0x00008F24
		Private Sub method_47(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_15(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.d40bit))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001E1 RID: 481 RVA: 0x0000AD84 File Offset: 0x00008F84
		Private Sub method_48(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_16(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.d44bit))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001E2 RID: 482 RVA: 0x0000ADE4 File Offset: 0x00008FE4
		Private Sub method_49(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_17(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.d48bit))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001E3 RID: 483 RVA: 0x0000AE44 File Offset: 0x00009044
		Private Sub method_50(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_18(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.d24rhbit))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001E4 RID: 484 RVA: 0x0000AEA4 File Offset: 0x000090A4
		Private Sub method_51(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_19(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.d32rhbit))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001E5 RID: 485 RVA: 0x0000AF04 File Offset: 0x00009104
		Private Sub method_52(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_20(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.d48rhbit))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001E6 RID: 486 RVA: 0x0000AF64 File Offset: 0x00009164
		Private Sub method_53(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_21(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.d24rnbit))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001E7 RID: 487 RVA: 0x0000AFC4 File Offset: 0x000091C4
		Private Sub method_54(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_22(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.d32rnbit))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001E8 RID: 488 RVA: 0x0000B024 File Offset: 0x00009224
		Private Sub method_55(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_23(CType(Me.bindingSource_0.Current, GClass9).BSSID), GClass3.GEnum0.d48rnbit))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001E9 RID: 489 RVA: 0x0000B084 File Offset: 0x00009284
		Private Sub method_56(sender As Object, e As EventArgs)
			Me.tsMenuPin_ZAO.PerformClick()
			Me.tsMenuPin_28bit.PerformClick()
			Me.tsMenuPin_32bit.PerformClick()
			Me.tsMenuPin_36bit.PerformClick()
			Me.tsMenuPin_40bit.PerformClick()
			Me.tsMenuPin_44bit.PerformClick()
			Me.tsMenuPin_48bit.PerformClick()
			Me.tsMenuPin_24RHbit.PerformClick()
			Me.tsMenuPin_32RHbit.PerformClick()
			Me.tsMenuPin_48RHbit.PerformClick()
			Me.tsMenuPin_24RNbit.PerformClick()
			Me.tsMenuPin_32RNbit.PerformClick()
			Me.tsMenuPin_48RNbit.PerformClick()
		End Sub

		' Token: 0x060001EA RID: 490 RVA: 0x0000B120 File Offset: 0x00009320
		Private Sub method_57(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_6(CType(Me.bindingSource_0.Current, GClass9).BSSID, CType(Me.bindingSource_0.Current, GClass9).SerialNumber), GClass3.GEnum0.LiveBox))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001EB RID: 491 RVA: 0x00003ACE File Offset: 0x00001CCE
		Private Sub method_58(sender As Object, e As EventArgs)
			Me.bindingSource_1.CancelEdit()
			Me.gclass9_0.gclass15_0.Add(New GClass12(GClass3.smethod_2(), GClass3.GEnum0.PinNull))
			Me.bindingSource_1.EndEdit()
			Me.DgvPins.Invalidate()
		End Sub

		' Token: 0x060001EC RID: 492 RVA: 0x0000B194 File Offset: 0x00009394
		Private Sub method_59(sender As Object, e As EventArgs)
			Me.tsMenuPin_AiroCon.PerformClick()
			Me.tsMenuPin_EasyBox.PerformClick()
			Me.tsMenuPin_LiveBox.PerformClick()
			Me.tsMenuPin_Trend.PerformClick()
			Me.tsMenuPin_Dlink.PerformClick()
			Me.tsMenuPin_FTE.PerformClick()
			Me.tsMenuPin_Allxbit.PerformClick()
			Me.tsMenuPin_Null.PerformClick()
		End Sub

		' Token: 0x060001ED RID: 493 RVA: 0x0000B1FC File Offset: 0x000093FC
		Private Sub method_60(string_0 As String, bool_4 As Boolean)
			Dim text As String = "-e " + Me.gclass9_0.PKE
			text = text + " -r " + Me.gclass9_0.PKR
			text = text + " -s " + Me.gclass9_0.E_HAS1
			text = text + " -z " + Me.gclass9_0.E_HAS2
			text = text + " -a " + Me.gclass9_0.AuthKey
			text = text + " -n " + Me.gclass9_0.E_NONCE
			text = text + " " + string_0
			Me.method_22(" PixieWps " + text, Color.White, True)
			Dim text2 As String = GClass3.smethod_27(text)
			Me.method_22(text2, Color.White, True)
			Me.bool_3 = False
			If Not Class13.smethod_11(text2, Me.gclass12_0) Then
				If Me.gclass9_0.Status = GClass9.GEnum3.Unknow Then
					Me.gclass9_0.Status = GClass9.GEnum3.Nok
				End If
			Else
				Me.gclass9_0.Pin = Me.gclass12_0
				Me.method_22(Class13.string_4, Color.LightGreen, False)
				If bool_4 Then
					Me.GClass8_0.method_7(Me.gclass9_0, Me.gclass12_0)
					Return
				End If
			End If
		End Sub

		' Token: 0x060001EE RID: 494 RVA: 0x00003B0C File Offset: 0x00001D0C
		Private Sub method_61(string_0 As String)
			New UpdateForm() With { .string_0 = string_0 }.ShowDialog()
		End Sub

		' Token: 0x060001EF RID: 495 RVA: 0x0000B340 File Offset: 0x00009540
		Private Sub method_62(sender As Object, e As EventArgs)
			If MessageBox.Show(Class10.String_58, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
				While True
					IL_90:
					Dim selectedIndex As Integer = Me.cbLanguage.SelectedIndex
					While True
						IL_78:
						Select Case selectedIndex
							Case 0
								GoTo IL_9E
							Case 1
								GoTo IL_AF
							Case 2
								GoTo IL_C0
							Case 3
								GoTo IL_D1
							Case Else
								Dim num2 As UInteger
								Dim num As Integer = CInt((num2 * 1094233503UI Xor 826448192UI))
								While True
									Dim num3 As Integer = num Xor -1108102372
									num2 = CUInt(num3)
									Select Case num3 Mod 12
										Case 0, 5, 8
											GoTo IL_E0
										Case 1
											GoTo IL_AF
										Case 2
											GoTo IL_C0
										Case 3, 9
											GoTo IL_90
										Case 4
											GoTo IL_D1
										Case 6
											GoTo IL_78
										Case 7
											GoTo IL_9E
										Case 10
											num = CInt((num2 * 1563691460UI Xor 3985386060UI))
											Continue For
									End Select
									GoTo Block_2
								End While
						End Select
					End While
				End While
				Block_2:
				Return
				IL_9E:
				MySettings.[Default].Culture = "es"
				GoTo IL_E0
				IL_AF:
				MySettings.[Default].Culture = "en"
				GoTo IL_E0
				IL_C0:
				MySettings.[Default].Culture = "ru"
				GoTo IL_E0
				IL_D1:
				MySettings.[Default].Culture = "fr"
				IL_E0:
				Application.Restart()
			End If
		End Sub

		' Token: 0x060001F0 RID: 496 RVA: 0x0000B434 File Offset: 0x00009634
		Private Sub method_63(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.tbScanTime.Text, "", False) <> 0 And Versioned.IsNumeric(Me.tbScanTime.Text) Then
				MySettings.[Default].ScanTime = Conversions.ToInteger(Me.tbScanTime.Text)
				MySettings.[Default].Save()
			End If
		End Sub

		' Token: 0x060001F1 RID: 497 RVA: 0x00003B20 File Offset: 0x00001D20
		Private Sub method_64(sender As Object, e As KeyPressEventArgs)
			If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
				e.Handled = False
				Return
			End If
			e.Handled = True
		End Sub

		' Token: 0x060001F2 RID: 498 RVA: 0x00003B4A File Offset: 0x00001D4A
		Private Sub method_65(sender As Object, e As EventArgs)
			Me.tbScanTime.Text = Conversions.ToString(MySettings.[Default].ScanTime)
		End Sub

		' Token: 0x060001F3 RID: 499 RVA: 0x0000B494 File Offset: 0x00009694
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

		' Token: 0x170000E8 RID: 232
		' (get) Token: 0x060001F5 RID: 501 RVA: 0x00003B66 File Offset: 0x00001D66
		' (set) Token: 0x060001F6 RID: 502 RVA: 0x00003B6E File Offset: 0x00001D6E
		Friend Overridable Property SplitContainer1 As SplitContainer

		' Token: 0x170000E9 RID: 233
		' (get) Token: 0x060001F7 RID: 503 RVA: 0x00003B77 File Offset: 0x00001D77
		' (set) Token: 0x060001F8 RID: 504 RVA: 0x00003B7F File Offset: 0x00001D7F
		Friend Overridable Property RtbMessage As RichTextBox

		' Token: 0x170000EA RID: 234
		' (get) Token: 0x060001F9 RID: 505 RVA: 0x00003B88 File Offset: 0x00001D88
		' (set) Token: 0x060001FA RID: 506 RVA: 0x0000D7D8 File Offset: 0x0000B9D8
		Friend Overridable Property BtExpandMessage As Button
			<CompilerGenerated()>
			Get
				Return Me._BtExpandMessage
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.method_26
				Dim btExpandMessage As Button = Me._BtExpandMessage
				If btExpandMessage IsNot Nothing Then
					RemoveHandler btExpandMessage.Click, value2
				End If
				Me._BtExpandMessage = value
				btExpandMessage = Me._BtExpandMessage
				If btExpandMessage IsNot Nothing Then
					AddHandler btExpandMessage.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000EB RID: 235
		' (get) Token: 0x060001FB RID: 507 RVA: 0x00003B90 File Offset: 0x00001D90
		' (set) Token: 0x060001FC RID: 508 RVA: 0x00003B98 File Offset: 0x00001D98
		Friend Overridable Property ImageList_0 As ImageList

		' Token: 0x170000EC RID: 236
		' (get) Token: 0x060001FD RID: 509 RVA: 0x00003BA1 File Offset: 0x00001DA1
		' (set) Token: 0x060001FE RID: 510 RVA: 0x00003BA9 File Offset: 0x00001DA9
		Friend Overridable Property ToolTip_0 As ToolTip

		' Token: 0x170000ED RID: 237
		' (get) Token: 0x060001FF RID: 511 RVA: 0x00003BB2 File Offset: 0x00001DB2
		' (set) Token: 0x06000200 RID: 512 RVA: 0x00003BBA File Offset: 0x00001DBA
		Friend Overridable Property StatusStrip1 As StatusStrip

		' Token: 0x170000EE RID: 238
		' (get) Token: 0x06000201 RID: 513 RVA: 0x00003BC3 File Offset: 0x00001DC3
		' (set) Token: 0x06000202 RID: 514 RVA: 0x00003BCB File Offset: 0x00001DCB
		Friend Overridable Property tsInterfaces As ToolStrip

		' Token: 0x170000EF RID: 239
		' (get) Token: 0x06000203 RID: 515 RVA: 0x00003BD4 File Offset: 0x00001DD4
		' (set) Token: 0x06000204 RID: 516 RVA: 0x0000D81C File Offset: 0x0000BA1C
		Friend Overridable Property btRefresh As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._btRefresh
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_3
				Dim btRefresh As ToolStripButton = Me._btRefresh
				If btRefresh IsNot Nothing Then
					RemoveHandler btRefresh.Click, value2
				End If
				Me._btRefresh = value
				btRefresh = Me._btRefresh
				If btRefresh IsNot Nothing Then
					AddHandler btRefresh.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000F0 RID: 240
		' (get) Token: 0x06000205 RID: 517 RVA: 0x00003BDC File Offset: 0x00001DDC
		' (set) Token: 0x06000206 RID: 518 RVA: 0x0000D860 File Offset: 0x0000BA60
		Friend Overridable Property cbAdapters As ToolStripComboBox
			<CompilerGenerated()>
			Get
				Return Me._cbAdapters
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripComboBox)
				Dim value2 As EventHandler = AddressOf Me.method_8
				Dim cbAdapters As ToolStripComboBox = Me._cbAdapters
				If cbAdapters IsNot Nothing Then
					RemoveHandler cbAdapters.SelectedIndexChanged, value2
				End If
				Me._cbAdapters = value
				cbAdapters = Me._cbAdapters
				If cbAdapters IsNot Nothing Then
					AddHandler cbAdapters.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170000F1 RID: 241
		' (get) Token: 0x06000207 RID: 519 RVA: 0x00003BE4 File Offset: 0x00001DE4
		' (set) Token: 0x06000208 RID: 520 RVA: 0x00003BEC File Offset: 0x00001DEC
		Friend Overridable Property ToolStripSeparator2 As ToolStripSeparator

		' Token: 0x170000F2 RID: 242
		' (get) Token: 0x06000209 RID: 521 RVA: 0x00003BF5 File Offset: 0x00001DF5
		' (set) Token: 0x0600020A RID: 522 RVA: 0x00003BFD File Offset: 0x00001DFD
		Friend Overridable Property SplitContainer3 As SplitContainer

		' Token: 0x170000F3 RID: 243
		' (get) Token: 0x0600020B RID: 523 RVA: 0x00003C06 File Offset: 0x00001E06
		' (set) Token: 0x0600020C RID: 524 RVA: 0x00003C0E File Offset: 0x00001E0E
		Friend Overridable Property SplitContainer2 As SplitContainer

		' Token: 0x170000F4 RID: 244
		' (get) Token: 0x0600020D RID: 525 RVA: 0x00003C17 File Offset: 0x00001E17
		' (set) Token: 0x0600020E RID: 526 RVA: 0x0000D8A4 File Offset: 0x0000BAA4
		Friend Overridable Property DgvAps As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._DgvAps
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim value2 As EventHandler = AddressOf Me.method_10
				Dim value3 As DataGridViewBindingCompleteEventHandler = AddressOf Me.method_11
				Dim value4 As DataGridViewCellFormattingEventHandler = AddressOf Me.method_34
				Dim dgvAps As DataGridView = Me._DgvAps
				If dgvAps IsNot Nothing Then
					RemoveHandler dgvAps.SelectionChanged, value2
					RemoveHandler dgvAps.DataBindingComplete, value3
					RemoveHandler dgvAps.CellFormatting, value4
				End If
				Me._DgvAps = value
				dgvAps = Me._DgvAps
				If dgvAps IsNot Nothing Then
					AddHandler dgvAps.SelectionChanged, value2
					AddHandler dgvAps.DataBindingComplete, value3
					AddHandler dgvAps.CellFormatting, value4
				End If
			End Set
		End Property

		' Token: 0x170000F5 RID: 245
		' (get) Token: 0x0600020F RID: 527 RVA: 0x00003C1F File Offset: 0x00001E1F
		' (set) Token: 0x06000210 RID: 528 RVA: 0x00003C27 File Offset: 0x00001E27
		Friend Overridable Property DgvAttributes As DataGridView

		' Token: 0x170000F6 RID: 246
		' (get) Token: 0x06000211 RID: 529 RVA: 0x00003C30 File Offset: 0x00001E30
		' (set) Token: 0x06000212 RID: 530 RVA: 0x0000D920 File Offset: 0x0000BB20
		Friend Overridable Property DgvPins As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._DgvPins
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim value2 As DataGridViewBindingCompleteEventHandler = AddressOf Me.method_12
				Dim value3 As DataGridViewCellValidatingEventHandler = AddressOf Me.method_13
				Dim value4 As DataGridViewDataErrorEventHandler = AddressOf Me.method_14
				Dim dgvPins As DataGridView = Me._DgvPins
				If dgvPins IsNot Nothing Then
					RemoveHandler dgvPins.DataBindingComplete, value2
					RemoveHandler dgvPins.CellValidating, value3
					RemoveHandler dgvPins.DataError, value4
				End If
				Me._DgvPins = value
				dgvPins = Me._DgvPins
				If dgvPins IsNot Nothing Then
					AddHandler dgvPins.DataBindingComplete, value2
					AddHandler dgvPins.CellValidating, value3
					AddHandler dgvPins.DataError, value4
				End If
			End Set
		End Property

		' Token: 0x170000F7 RID: 247
		' (get) Token: 0x06000213 RID: 531 RVA: 0x00003C38 File Offset: 0x00001E38
		' (set) Token: 0x06000214 RID: 532 RVA: 0x00003C40 File Offset: 0x00001E40
		Friend Overridable Property tsApToolMenu As ToolStrip

		' Token: 0x170000F8 RID: 248
		' (get) Token: 0x06000215 RID: 533 RVA: 0x00003C49 File Offset: 0x00001E49
		' (set) Token: 0x06000216 RID: 534 RVA: 0x0000D99C File Offset: 0x0000BB9C
		Friend Overridable Property TsbPin As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._TsbPin
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_15
				Dim tsbPin As ToolStripButton = Me._TsbPin
				If tsbPin IsNot Nothing Then
					RemoveHandler tsbPin.Click, value2
				End If
				Me._TsbPin = value
				tsbPin = Me._TsbPin
				If tsbPin IsNot Nothing Then
					AddHandler tsbPin.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000F9 RID: 249
		' (get) Token: 0x06000217 RID: 535 RVA: 0x00003C51 File Offset: 0x00001E51
		' (set) Token: 0x06000218 RID: 536 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		Friend Overridable Property TsbAllPin As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._TsbAllPin
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_16
				Dim tsbAllPin As ToolStripButton = Me._TsbAllPin
				If tsbAllPin IsNot Nothing Then
					RemoveHandler tsbAllPin.Click, value2
				End If
				Me._TsbAllPin = value
				tsbAllPin = Me._TsbAllPin
				If tsbAllPin IsNot Nothing Then
					AddHandler tsbAllPin.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000FA RID: 250
		' (get) Token: 0x06000219 RID: 537 RVA: 0x00003C59 File Offset: 0x00001E59
		' (set) Token: 0x0600021A RID: 538 RVA: 0x0000DA24 File Offset: 0x0000BC24
		Friend Overridable Property TsbRandomPin As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._TsbRandomPin
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_18
				Dim tsbRandomPin As ToolStripButton = Me._TsbRandomPin
				If tsbRandomPin IsNot Nothing Then
					RemoveHandler tsbRandomPin.Click, value2
				End If
				Me._TsbRandomPin = value
				tsbRandomPin = Me._TsbRandomPin
				If tsbRandomPin IsNot Nothing Then
					AddHandler tsbRandomPin.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000FB RID: 251
		' (get) Token: 0x0600021B RID: 539 RVA: 0x00003C61 File Offset: 0x00001E61
		' (set) Token: 0x0600021C RID: 540 RVA: 0x0000DA68 File Offset: 0x0000BC68
		Friend Overridable Property TsbStop As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._TsbStop
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_20
				Dim tsbStop As ToolStripButton = Me._TsbStop
				If tsbStop IsNot Nothing Then
					RemoveHandler tsbStop.Click, value2
				End If
				Me._TsbStop = value
				tsbStop = Me._TsbStop
				If tsbStop IsNot Nothing Then
					AddHandler tsbStop.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000FC RID: 252
		' (get) Token: 0x0600021D RID: 541 RVA: 0x00003C69 File Offset: 0x00001E69
		' (set) Token: 0x0600021E RID: 542 RVA: 0x00003C71 File Offset: 0x00001E71
		Friend Overridable Property TsCpyRigth As ToolStripStatusLabel

		' Token: 0x170000FD RID: 253
		' (get) Token: 0x0600021F RID: 543 RVA: 0x00003C7A File Offset: 0x00001E7A
		' (set) Token: 0x06000220 RID: 544 RVA: 0x00003C82 File Offset: 0x00001E82
		Friend Overridable Property PbLicense As PictureBox

		' Token: 0x170000FE RID: 254
		' (get) Token: 0x06000221 RID: 545 RVA: 0x00003C8B File Offset: 0x00001E8B
		' (set) Token: 0x06000222 RID: 546 RVA: 0x0000DAAC File Offset: 0x0000BCAC
		Friend Overridable Property btAbout As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._btAbout
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_28
				Dim btAbout As ToolStripButton = Me._btAbout
				If btAbout IsNot Nothing Then
					RemoveHandler btAbout.Click, value2
				End If
				Me._btAbout = value
				btAbout = Me._btAbout
				If btAbout IsNot Nothing Then
					AddHandler btAbout.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000FF RID: 255
		' (get) Token: 0x06000223 RID: 547 RVA: 0x00003C93 File Offset: 0x00001E93
		' (set) Token: 0x06000224 RID: 548 RVA: 0x0000DAF0 File Offset: 0x0000BCF0
		Friend Overridable Property btPrivateMode As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._btPrivateMode
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_29
				Dim btPrivateMode As ToolStripButton = Me._btPrivateMode
				If btPrivateMode IsNot Nothing Then
					RemoveHandler btPrivateMode.CheckedChanged, value2
				End If
				Me._btPrivateMode = value
				btPrivateMode = Me._btPrivateMode
				If btPrivateMode IsNot Nothing Then
					AddHandler btPrivateMode.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000100 RID: 256
		' (get) Token: 0x06000225 RID: 549 RVA: 0x00003C9B File Offset: 0x00001E9B
		' (set) Token: 0x06000226 RID: 550 RVA: 0x00003CA3 File Offset: 0x00001EA3
		Friend Overridable Property btDataBase As ToolStripDropDownButton

		' Token: 0x17000101 RID: 257
		' (get) Token: 0x06000227 RID: 551 RVA: 0x00003CAC File Offset: 0x00001EAC
		' (set) Token: 0x06000228 RID: 552 RVA: 0x0000DB34 File Offset: 0x0000BD34
		Friend Overridable Property btPinDb As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._btPinDb
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_30
				Dim btPinDb As ToolStripMenuItem = Me._btPinDb
				If btPinDb IsNot Nothing Then
					RemoveHandler btPinDb.Click, value2
				End If
				Me._btPinDb = value
				btPinDb = Me._btPinDb
				If btPinDb IsNot Nothing Then
					AddHandler btPinDb.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000102 RID: 258
		' (get) Token: 0x06000229 RID: 553 RVA: 0x00003CB4 File Offset: 0x00001EB4
		' (set) Token: 0x0600022A RID: 554 RVA: 0x0000DB78 File Offset: 0x0000BD78
		Friend Overridable Property btNetsBD As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._btNetsBD
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_31
				Dim btNetsBD As ToolStripMenuItem = Me._btNetsBD
				If btNetsBD IsNot Nothing Then
					RemoveHandler btNetsBD.Click, value2
				End If
				Me._btNetsBD = value
				btNetsBD = Me._btNetsBD
				If btNetsBD IsNot Nothing Then
					AddHandler btNetsBD.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000103 RID: 259
		' (get) Token: 0x0600022B RID: 555 RVA: 0x00003CBC File Offset: 0x00001EBC
		' (set) Token: 0x0600022C RID: 556 RVA: 0x00003CC4 File Offset: 0x00001EC4
		Friend Overridable Property ToolStripSeparator4 As ToolStripSeparator

		' Token: 0x17000104 RID: 260
		' (get) Token: 0x0600022D RID: 557 RVA: 0x00003CCD File Offset: 0x00001ECD
		' (set) Token: 0x0600022E RID: 558 RVA: 0x0000DBBC File Offset: 0x0000BDBC
		Friend Overridable Property ContextMenuPin As ContextMenuStrip
			<CompilerGenerated()>
			Get
				Return Me._ContextMenuPin
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Dim value2 As CancelEventHandler = AddressOf Me.method_35
				Dim contextMenuPin As ContextMenuStrip = Me._ContextMenuPin
				If contextMenuPin IsNot Nothing Then
					RemoveHandler contextMenuPin.Opening, value2
				End If
				Me._ContextMenuPin = value
				contextMenuPin = Me._ContextMenuPin
				If contextMenuPin IsNot Nothing Then
					AddHandler contextMenuPin.Opening, value2
				End If
			End Set
		End Property

		' Token: 0x17000105 RID: 261
		' (get) Token: 0x0600022F RID: 559 RVA: 0x00003CD5 File Offset: 0x00001ED5
		' (set) Token: 0x06000230 RID: 560 RVA: 0x0000DC00 File Offset: 0x0000BE00
		Friend Overridable Property tbMenuPin_Checksum As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tbMenuPin_Checksum
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_36
				Dim tbMenuPin_Checksum As ToolStripMenuItem = Me._tbMenuPin_Checksum
				If tbMenuPin_Checksum IsNot Nothing Then
					RemoveHandler tbMenuPin_Checksum.Click, value2
				End If
				Me._tbMenuPin_Checksum = value
				tbMenuPin_Checksum = Me._tbMenuPin_Checksum
				If tbMenuPin_Checksum IsNot Nothing Then
					AddHandler tbMenuPin_Checksum.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000106 RID: 262
		' (get) Token: 0x06000231 RID: 561 RVA: 0x00003CDD File Offset: 0x00001EDD
		' (set) Token: 0x06000232 RID: 562 RVA: 0x00003CE5 File Offset: 0x00001EE5
		Friend Overridable Property ToolStripMenuItem1 As ToolStripSeparator

		' Token: 0x17000107 RID: 263
		' (get) Token: 0x06000233 RID: 563 RVA: 0x00003CEE File Offset: 0x00001EEE
		' (set) Token: 0x06000234 RID: 564 RVA: 0x00003CF6 File Offset: 0x00001EF6
		Friend Overridable Property tsMenuAlgorithms As ToolStripMenuItem

		' Token: 0x17000108 RID: 264
		' (get) Token: 0x06000235 RID: 565 RVA: 0x00003CFF File Offset: 0x00001EFF
		' (set) Token: 0x06000236 RID: 566 RVA: 0x0000DC44 File Offset: 0x0000BE44
		Friend Overridable Property tsMenuPin_ZAO As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_ZAO
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_37
				Dim tsMenuPin_ZAO As ToolStripMenuItem = Me._tsMenuPin_ZAO
				If tsMenuPin_ZAO IsNot Nothing Then
					RemoveHandler tsMenuPin_ZAO.Click, value2
				End If
				Me._tsMenuPin_ZAO = value
				tsMenuPin_ZAO = Me._tsMenuPin_ZAO
				If tsMenuPin_ZAO IsNot Nothing Then
					AddHandler tsMenuPin_ZAO.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000109 RID: 265
		' (get) Token: 0x06000237 RID: 567 RVA: 0x00003D07 File Offset: 0x00001F07
		' (set) Token: 0x06000238 RID: 568 RVA: 0x0000DC88 File Offset: 0x0000BE88
		Friend Overridable Property tsMenuPin_EasyBox As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_EasyBox
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_39
				Dim tsMenuPin_EasyBox As ToolStripMenuItem = Me._tsMenuPin_EasyBox
				If tsMenuPin_EasyBox IsNot Nothing Then
					RemoveHandler tsMenuPin_EasyBox.Click, value2
				End If
				Me._tsMenuPin_EasyBox = value
				tsMenuPin_EasyBox = Me._tsMenuPin_EasyBox
				If tsMenuPin_EasyBox IsNot Nothing Then
					AddHandler tsMenuPin_EasyBox.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700010A RID: 266
		' (get) Token: 0x06000239 RID: 569 RVA: 0x00003D0F File Offset: 0x00001F0F
		' (set) Token: 0x0600023A RID: 570 RVA: 0x0000DCCC File Offset: 0x0000BECC
		Friend Overridable Property tsMenuPin_Trend As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_Trend
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_40
				Dim tsMenuPin_Trend As ToolStripMenuItem = Me._tsMenuPin_Trend
				If tsMenuPin_Trend IsNot Nothing Then
					RemoveHandler tsMenuPin_Trend.Click, value2
				End If
				Me._tsMenuPin_Trend = value
				tsMenuPin_Trend = Me._tsMenuPin_Trend
				If tsMenuPin_Trend IsNot Nothing Then
					AddHandler tsMenuPin_Trend.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700010B RID: 267
		' (get) Token: 0x0600023B RID: 571 RVA: 0x00003D17 File Offset: 0x00001F17
		' (set) Token: 0x0600023C RID: 572 RVA: 0x0000DD10 File Offset: 0x0000BF10
		Friend Overridable Property tsMenuPin_Dlink As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_Dlink
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_41
				Dim tsMenuPin_Dlink As ToolStripMenuItem = Me._tsMenuPin_Dlink
				If tsMenuPin_Dlink IsNot Nothing Then
					RemoveHandler tsMenuPin_Dlink.Click, value2
				End If
				Me._tsMenuPin_Dlink = value
				tsMenuPin_Dlink = Me._tsMenuPin_Dlink
				If tsMenuPin_Dlink IsNot Nothing Then
					AddHandler tsMenuPin_Dlink.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700010C RID: 268
		' (get) Token: 0x0600023D RID: 573 RVA: 0x00003D1F File Offset: 0x00001F1F
		' (set) Token: 0x0600023E RID: 574 RVA: 0x0000DD54 File Offset: 0x0000BF54
		Friend Overridable Property tsMenuPin_FTE As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_FTE
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_42
				Dim tsMenuPin_FTE As ToolStripMenuItem = Me._tsMenuPin_FTE
				If tsMenuPin_FTE IsNot Nothing Then
					RemoveHandler tsMenuPin_FTE.Click, value2
				End If
				Me._tsMenuPin_FTE = value
				tsMenuPin_FTE = Me._tsMenuPin_FTE
				If tsMenuPin_FTE IsNot Nothing Then
					AddHandler tsMenuPin_FTE.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700010D RID: 269
		' (get) Token: 0x0600023F RID: 575 RVA: 0x00003D27 File Offset: 0x00001F27
		' (set) Token: 0x06000240 RID: 576 RVA: 0x0000DD98 File Offset: 0x0000BF98
		Friend Overridable Property tsMenuPin_AiroCon As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_AiroCon
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_38
				Dim tsMenuPin_AiroCon As ToolStripMenuItem = Me._tsMenuPin_AiroCon
				If tsMenuPin_AiroCon IsNot Nothing Then
					RemoveHandler tsMenuPin_AiroCon.Click, value2
				End If
				Me._tsMenuPin_AiroCon = value
				tsMenuPin_AiroCon = Me._tsMenuPin_AiroCon
				If tsMenuPin_AiroCon IsNot Nothing Then
					AddHandler tsMenuPin_AiroCon.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700010E RID: 270
		' (get) Token: 0x06000241 RID: 577 RVA: 0x00003D2F File Offset: 0x00001F2F
		' (set) Token: 0x06000242 RID: 578 RVA: 0x00003D37 File Offset: 0x00001F37
		Private Overridable Property cbLanguage As ToolStripComboBox

		' Token: 0x1700010F RID: 271
		' (get) Token: 0x06000243 RID: 579 RVA: 0x00003D40 File Offset: 0x00001F40
		' (set) Token: 0x06000244 RID: 580 RVA: 0x0000DDDC File Offset: 0x0000BFDC
		Friend Overridable Property btClearConsole As Button
			<CompilerGenerated()>
			Get
				Return Me._btClearConsole
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.method_27
				Dim btClearConsole As Button = Me._btClearConsole
				If btClearConsole IsNot Nothing Then
					RemoveHandler btClearConsole.Click, value2
				End If
				Me._btClearConsole = value
				btClearConsole = Me._btClearConsole
				If btClearConsole IsNot Nothing Then
					AddHandler btClearConsole.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000110 RID: 272
		' (get) Token: 0x06000245 RID: 581 RVA: 0x00003D48 File Offset: 0x00001F48
		' (set) Token: 0x06000246 RID: 582 RVA: 0x00003D50 File Offset: 0x00001F50
		Friend Overridable Property btDonate As Button

		' Token: 0x17000111 RID: 273
		' (get) Token: 0x06000247 RID: 583 RVA: 0x00003D59 File Offset: 0x00001F59
		' (set) Token: 0x06000248 RID: 584 RVA: 0x00003D61 File Offset: 0x00001F61
		Friend Overridable Property ScrollLabel1 As GClass14

		' Token: 0x17000112 RID: 274
		' (get) Token: 0x06000249 RID: 585 RVA: 0x00003D6A File Offset: 0x00001F6A
		' (set) Token: 0x0600024A RID: 586 RVA: 0x0000DE20 File Offset: 0x0000C020
		Friend Overridable Property TsbPixie As ToolStripSplitButton
			<CompilerGenerated()>
			Get
				Return Me._TsbPixie
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSplitButton)
				Dim value2 As EventHandler = AddressOf Me.method_19
				Dim tsbPixie As ToolStripSplitButton = Me._TsbPixie
				If tsbPixie IsNot Nothing Then
					RemoveHandler tsbPixie.ButtonClick, value2
				End If
				Me._TsbPixie = value
				tsbPixie = Me._TsbPixie
				If tsbPixie IsNot Nothing Then
					AddHandler tsbPixie.ButtonClick, value2
				End If
			End Set
		End Property

		' Token: 0x17000113 RID: 275
		' (get) Token: 0x0600024B RID: 587 RVA: 0x00003D72 File Offset: 0x00001F72
		' (set) Token: 0x0600024C RID: 588 RVA: 0x0000DE64 File Offset: 0x0000C064
		Friend Overridable Property TsbPixieAdvance As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._TsbPixieAdvance
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_32
				Dim tsbPixieAdvance As ToolStripMenuItem = Me._TsbPixieAdvance
				If tsbPixieAdvance IsNot Nothing Then
					RemoveHandler tsbPixieAdvance.Click, value2
				End If
				Me._TsbPixieAdvance = value
				tsbPixieAdvance = Me._TsbPixieAdvance
				If tsbPixieAdvance IsNot Nothing Then
					AddHandler tsbPixieAdvance.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000114 RID: 276
		' (get) Token: 0x0600024D RID: 589 RVA: 0x00003D7A File Offset: 0x00001F7A
		' (set) Token: 0x0600024E RID: 590 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		Friend Overridable Property tsMenuPin_Asus As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_Asus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_43
				Dim tsMenuPin_Asus As ToolStripMenuItem = Me._tsMenuPin_Asus
				If tsMenuPin_Asus IsNot Nothing Then
					RemoveHandler tsMenuPin_Asus.Click, value2
				End If
				Me._tsMenuPin_Asus = value
				tsMenuPin_Asus = Me._tsMenuPin_Asus
				If tsMenuPin_Asus IsNot Nothing Then
					AddHandler tsMenuPin_Asus.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000115 RID: 277
		' (get) Token: 0x0600024F RID: 591 RVA: 0x00003D82 File Offset: 0x00001F82
		' (set) Token: 0x06000250 RID: 592 RVA: 0x00003D8A File Offset: 0x00001F8A
		Friend Overridable Property XBitToolStripMenuItem As ToolStripMenuItem

		' Token: 0x17000116 RID: 278
		' (get) Token: 0x06000251 RID: 593 RVA: 0x00003D93 File Offset: 0x00001F93
		' (set) Token: 0x06000252 RID: 594 RVA: 0x0000DEEC File Offset: 0x0000C0EC
		Friend Overridable Property tsMenuPin_28bit As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_28bit
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_44
				Dim tsMenuPin_28bit As ToolStripMenuItem = Me._tsMenuPin_28bit
				If tsMenuPin_28bit IsNot Nothing Then
					RemoveHandler tsMenuPin_28bit.Click, value2
				End If
				Me._tsMenuPin_28bit = value
				tsMenuPin_28bit = Me._tsMenuPin_28bit
				If tsMenuPin_28bit IsNot Nothing Then
					AddHandler tsMenuPin_28bit.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000117 RID: 279
		' (get) Token: 0x06000253 RID: 595 RVA: 0x00003D9B File Offset: 0x00001F9B
		' (set) Token: 0x06000254 RID: 596 RVA: 0x0000DF30 File Offset: 0x0000C130
		Friend Overridable Property tsMenuPin_32bit As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_32bit
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_45
				Dim tsMenuPin_32bit As ToolStripMenuItem = Me._tsMenuPin_32bit
				If tsMenuPin_32bit IsNot Nothing Then
					RemoveHandler tsMenuPin_32bit.Click, value2
				End If
				Me._tsMenuPin_32bit = value
				tsMenuPin_32bit = Me._tsMenuPin_32bit
				If tsMenuPin_32bit IsNot Nothing Then
					AddHandler tsMenuPin_32bit.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000118 RID: 280
		' (get) Token: 0x06000255 RID: 597 RVA: 0x00003DA3 File Offset: 0x00001FA3
		' (set) Token: 0x06000256 RID: 598 RVA: 0x0000DF74 File Offset: 0x0000C174
		Friend Overridable Property tsMenuPin_36bit As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_36bit
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_46
				Dim tsMenuPin_36bit As ToolStripMenuItem = Me._tsMenuPin_36bit
				If tsMenuPin_36bit IsNot Nothing Then
					RemoveHandler tsMenuPin_36bit.Click, value2
				End If
				Me._tsMenuPin_36bit = value
				tsMenuPin_36bit = Me._tsMenuPin_36bit
				If tsMenuPin_36bit IsNot Nothing Then
					AddHandler tsMenuPin_36bit.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000119 RID: 281
		' (get) Token: 0x06000257 RID: 599 RVA: 0x00003DAB File Offset: 0x00001FAB
		' (set) Token: 0x06000258 RID: 600 RVA: 0x0000DFB8 File Offset: 0x0000C1B8
		Friend Overridable Property tsMenuPin_40bit As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_40bit
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_47
				Dim tsMenuPin_40bit As ToolStripMenuItem = Me._tsMenuPin_40bit
				If tsMenuPin_40bit IsNot Nothing Then
					RemoveHandler tsMenuPin_40bit.Click, value2
				End If
				Me._tsMenuPin_40bit = value
				tsMenuPin_40bit = Me._tsMenuPin_40bit
				If tsMenuPin_40bit IsNot Nothing Then
					AddHandler tsMenuPin_40bit.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700011A RID: 282
		' (get) Token: 0x06000259 RID: 601 RVA: 0x00003DB3 File Offset: 0x00001FB3
		' (set) Token: 0x0600025A RID: 602 RVA: 0x0000DFFC File Offset: 0x0000C1FC
		Friend Overridable Property tsMenuPin_44bit As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_44bit
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_48
				Dim tsMenuPin_44bit As ToolStripMenuItem = Me._tsMenuPin_44bit
				If tsMenuPin_44bit IsNot Nothing Then
					RemoveHandler tsMenuPin_44bit.Click, value2
				End If
				Me._tsMenuPin_44bit = value
				tsMenuPin_44bit = Me._tsMenuPin_44bit
				If tsMenuPin_44bit IsNot Nothing Then
					AddHandler tsMenuPin_44bit.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700011B RID: 283
		' (get) Token: 0x0600025B RID: 603 RVA: 0x00003DBB File Offset: 0x00001FBB
		' (set) Token: 0x0600025C RID: 604 RVA: 0x0000E040 File Offset: 0x0000C240
		Friend Overridable Property tsMenuPin_48bit As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_48bit
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_49
				Dim tsMenuPin_48bit As ToolStripMenuItem = Me._tsMenuPin_48bit
				If tsMenuPin_48bit IsNot Nothing Then
					RemoveHandler tsMenuPin_48bit.Click, value2
				End If
				Me._tsMenuPin_48bit = value
				tsMenuPin_48bit = Me._tsMenuPin_48bit
				If tsMenuPin_48bit IsNot Nothing Then
					AddHandler tsMenuPin_48bit.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700011C RID: 284
		' (get) Token: 0x0600025D RID: 605 RVA: 0x00003DC3 File Offset: 0x00001FC3
		' (set) Token: 0x0600025E RID: 606 RVA: 0x00003DCB File Offset: 0x00001FCB
		Friend Overridable Property AllToolStripMenuItem As ToolStripSeparator

		' Token: 0x1700011D RID: 285
		' (get) Token: 0x0600025F RID: 607 RVA: 0x00003DD4 File Offset: 0x00001FD4
		' (set) Token: 0x06000260 RID: 608 RVA: 0x0000E084 File Offset: 0x0000C284
		Friend Overridable Property tsMenuPin_Allxbit As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_Allxbit
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_56
				Dim tsMenuPin_Allxbit As ToolStripMenuItem = Me._tsMenuPin_Allxbit
				If tsMenuPin_Allxbit IsNot Nothing Then
					RemoveHandler tsMenuPin_Allxbit.Click, value2
				End If
				Me._tsMenuPin_Allxbit = value
				tsMenuPin_Allxbit = Me._tsMenuPin_Allxbit
				If tsMenuPin_Allxbit IsNot Nothing Then
					AddHandler tsMenuPin_Allxbit.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700011E RID: 286
		' (get) Token: 0x06000261 RID: 609 RVA: 0x00003DDC File Offset: 0x00001FDC
		' (set) Token: 0x06000262 RID: 610 RVA: 0x00003DE4 File Offset: 0x00001FE4
		Friend Overridable Property AllToolStripMenuItem1 As ToolStripSeparator

		' Token: 0x1700011F RID: 287
		' (get) Token: 0x06000263 RID: 611 RVA: 0x00003DED File Offset: 0x00001FED
		' (set) Token: 0x06000264 RID: 612 RVA: 0x0000E0C8 File Offset: 0x0000C2C8
		Friend Overridable Property tsMenuPin_All As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_All
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_59
				Dim tsMenuPin_All As ToolStripMenuItem = Me._tsMenuPin_All
				If tsMenuPin_All IsNot Nothing Then
					RemoveHandler tsMenuPin_All.Click, value2
				End If
				Me._tsMenuPin_All = value
				tsMenuPin_All = Me._tsMenuPin_All
				If tsMenuPin_All IsNot Nothing Then
					AddHandler tsMenuPin_All.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000120 RID: 288
		' (get) Token: 0x06000265 RID: 613 RVA: 0x00003DF5 File Offset: 0x00001FF5
		' (set) Token: 0x06000266 RID: 614 RVA: 0x0000E10C File Offset: 0x0000C30C
		Friend Overridable Property tsMenuPin_24RHbit As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_24RHbit
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_50
				Dim tsMenuPin_24RHbit As ToolStripMenuItem = Me._tsMenuPin_24RHbit
				If tsMenuPin_24RHbit IsNot Nothing Then
					RemoveHandler tsMenuPin_24RHbit.Click, value2
				End If
				Me._tsMenuPin_24RHbit = value
				tsMenuPin_24RHbit = Me._tsMenuPin_24RHbit
				If tsMenuPin_24RHbit IsNot Nothing Then
					AddHandler tsMenuPin_24RHbit.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000121 RID: 289
		' (get) Token: 0x06000267 RID: 615 RVA: 0x00003DFD File Offset: 0x00001FFD
		' (set) Token: 0x06000268 RID: 616 RVA: 0x0000E150 File Offset: 0x0000C350
		Friend Overridable Property tsMenuPin_32RHbit As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_32RHbit
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_51
				Dim tsMenuPin_32RHbit As ToolStripMenuItem = Me._tsMenuPin_32RHbit
				If tsMenuPin_32RHbit IsNot Nothing Then
					RemoveHandler tsMenuPin_32RHbit.Click, value2
				End If
				Me._tsMenuPin_32RHbit = value
				tsMenuPin_32RHbit = Me._tsMenuPin_32RHbit
				If tsMenuPin_32RHbit IsNot Nothing Then
					AddHandler tsMenuPin_32RHbit.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000122 RID: 290
		' (get) Token: 0x06000269 RID: 617 RVA: 0x00003E05 File Offset: 0x00002005
		' (set) Token: 0x0600026A RID: 618 RVA: 0x00003E0D File Offset: 0x0000200D
		Friend Overridable Property ToolStripMenuItem3 As ToolStripSeparator

		' Token: 0x17000123 RID: 291
		' (get) Token: 0x0600026B RID: 619 RVA: 0x00003E16 File Offset: 0x00002016
		' (set) Token: 0x0600026C RID: 620 RVA: 0x0000E194 File Offset: 0x0000C394
		Friend Overridable Property tsMenuPin_24RNbit As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_24RNbit
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_53
				Dim tsMenuPin_24RNbit As ToolStripMenuItem = Me._tsMenuPin_24RNbit
				If tsMenuPin_24RNbit IsNot Nothing Then
					RemoveHandler tsMenuPin_24RNbit.Click, value2
				End If
				Me._tsMenuPin_24RNbit = value
				tsMenuPin_24RNbit = Me._tsMenuPin_24RNbit
				If tsMenuPin_24RNbit IsNot Nothing Then
					AddHandler tsMenuPin_24RNbit.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000124 RID: 292
		' (get) Token: 0x0600026D RID: 621 RVA: 0x00003E1E File Offset: 0x0000201E
		' (set) Token: 0x0600026E RID: 622 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		Friend Overridable Property tsMenuPin_32RNbit As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_32RNbit
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_54
				Dim tsMenuPin_32RNbit As ToolStripMenuItem = Me._tsMenuPin_32RNbit
				If tsMenuPin_32RNbit IsNot Nothing Then
					RemoveHandler tsMenuPin_32RNbit.Click, value2
				End If
				Me._tsMenuPin_32RNbit = value
				tsMenuPin_32RNbit = Me._tsMenuPin_32RNbit
				If tsMenuPin_32RNbit IsNot Nothing Then
					AddHandler tsMenuPin_32RNbit.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000125 RID: 293
		' (get) Token: 0x0600026F RID: 623 RVA: 0x00003E26 File Offset: 0x00002026
		' (set) Token: 0x06000270 RID: 624 RVA: 0x0000E21C File Offset: 0x0000C41C
		Friend Overridable Property tsMenuPin_48RNbit As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_48RNbit
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_55
				Dim tsMenuPin_48RNbit As ToolStripMenuItem = Me._tsMenuPin_48RNbit
				If tsMenuPin_48RNbit IsNot Nothing Then
					RemoveHandler tsMenuPin_48RNbit.Click, value2
				End If
				Me._tsMenuPin_48RNbit = value
				tsMenuPin_48RNbit = Me._tsMenuPin_48RNbit
				If tsMenuPin_48RNbit IsNot Nothing Then
					AddHandler tsMenuPin_48RNbit.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000126 RID: 294
		' (get) Token: 0x06000271 RID: 625 RVA: 0x00003E2E File Offset: 0x0000202E
		' (set) Token: 0x06000272 RID: 626 RVA: 0x00003E36 File Offset: 0x00002036
		Friend Overridable Property ToolStripMenuItem2 As ToolStripSeparator

		' Token: 0x17000127 RID: 295
		' (get) Token: 0x06000273 RID: 627 RVA: 0x00003E3F File Offset: 0x0000203F
		' (set) Token: 0x06000274 RID: 628 RVA: 0x0000E260 File Offset: 0x0000C460
		Friend Overridable Property tsMenuPin_48RHbit As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_48RHbit
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_52
				Dim tsMenuPin_48RHbit As ToolStripMenuItem = Me._tsMenuPin_48RHbit
				If tsMenuPin_48RHbit IsNot Nothing Then
					RemoveHandler tsMenuPin_48RHbit.Click, value2
				End If
				Me._tsMenuPin_48RHbit = value
				tsMenuPin_48RHbit = Me._tsMenuPin_48RHbit
				If tsMenuPin_48RHbit IsNot Nothing Then
					AddHandler tsMenuPin_48RHbit.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000128 RID: 296
		' (get) Token: 0x06000275 RID: 629 RVA: 0x00003E47 File Offset: 0x00002047
		' (set) Token: 0x06000276 RID: 630 RVA: 0x00003E4F File Offset: 0x0000204F
		Friend Overridable Property DgvDataCampo As DataGridViewTextBoxColumn

		' Token: 0x17000129 RID: 297
		' (get) Token: 0x06000277 RID: 631 RVA: 0x00003E58 File Offset: 0x00002058
		' (set) Token: 0x06000278 RID: 632 RVA: 0x00003E60 File Offset: 0x00002060
		Friend Overridable Property DgvDataValor As DataGridViewTextBoxColumn

		' Token: 0x1700012A RID: 298
		' (get) Token: 0x06000279 RID: 633 RVA: 0x00003E69 File Offset: 0x00002069
		' (set) Token: 0x0600027A RID: 634 RVA: 0x0000E2A4 File Offset: 0x0000C4A4
		Friend Overridable Property tsMenuPin_LiveBox As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_LiveBox
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_57
				Dim tsMenuPin_LiveBox As ToolStripMenuItem = Me._tsMenuPin_LiveBox
				If tsMenuPin_LiveBox IsNot Nothing Then
					RemoveHandler tsMenuPin_LiveBox.Click, value2
				End If
				Me._tsMenuPin_LiveBox = value
				tsMenuPin_LiveBox = Me._tsMenuPin_LiveBox
				If tsMenuPin_LiveBox IsNot Nothing Then
					AddHandler tsMenuPin_LiveBox.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012B RID: 299
		' (get) Token: 0x0600027B RID: 635 RVA: 0x00003E71 File Offset: 0x00002071
		' (set) Token: 0x0600027C RID: 636 RVA: 0x0000E2E8 File Offset: 0x0000C4E8
		Friend Overridable Property tsMenuPin_Null As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._tsMenuPin_Null
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.method_58
				Dim tsMenuPin_Null As ToolStripMenuItem = Me._tsMenuPin_Null
				If tsMenuPin_Null IsNot Nothing Then
					RemoveHandler tsMenuPin_Null.Click, value2
				End If
				Me._tsMenuPin_Null = value
				tsMenuPin_Null = Me._tsMenuPin_Null
				If tsMenuPin_Null IsNot Nothing Then
					AddHandler tsMenuPin_Null.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012C RID: 300
		' (get) Token: 0x0600027D RID: 637 RVA: 0x00003E79 File Offset: 0x00002079
		' (set) Token: 0x0600027E RID: 638 RVA: 0x00003E81 File Offset: 0x00002081
		Friend Overridable Property DgvPinsPin As DataGridViewTextBoxColumn

		' Token: 0x1700012D RID: 301
		' (get) Token: 0x0600027F RID: 639 RVA: 0x00003E8A File Offset: 0x0000208A
		' (set) Token: 0x06000280 RID: 640 RVA: 0x00003E92 File Offset: 0x00002092
		Friend Overridable Property DgvPinsDescription As DataGridViewTextBoxColumn

		' Token: 0x1700012E RID: 302
		' (get) Token: 0x06000281 RID: 641 RVA: 0x00003E9B File Offset: 0x0000209B
		' (set) Token: 0x06000282 RID: 642 RVA: 0x0000E32C File Offset: 0x0000C52C
		Friend Overridable Property tbScanTime As ToolStripTextBox
			<CompilerGenerated()>
			Get
				Return Me._tbScanTime
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripTextBox)
				Dim value2 As EventHandler = AddressOf Me.method_63
				Dim value3 As KeyPressEventHandler = AddressOf Me.method_64
				Dim value4 As EventHandler = AddressOf Me.method_65
				Dim tbScanTime As ToolStripTextBox = Me._tbScanTime
				If tbScanTime IsNot Nothing Then
					RemoveHandler tbScanTime.TextChanged, value2
					RemoveHandler tbScanTime.KeyPress, value3
					RemoveHandler tbScanTime.Validated, value4
				End If
				Me._tbScanTime = value
				tbScanTime = Me._tbScanTime
				If tbScanTime IsNot Nothing Then
					AddHandler tbScanTime.TextChanged, value2
					AddHandler tbScanTime.KeyPress, value3
					AddHandler tbScanTime.Validated, value4
				End If
			End Set
		End Property

		' Token: 0x1700012F RID: 303
		' (get) Token: 0x06000283 RID: 643 RVA: 0x00003EA3 File Offset: 0x000020A3
		' (set) Token: 0x06000284 RID: 644 RVA: 0x00003EAB File Offset: 0x000020AB
		Friend Overridable Property dgvApsStatus As DataGridViewImageColumn

		' Token: 0x17000130 RID: 304
		' (get) Token: 0x06000285 RID: 645 RVA: 0x00003EB4 File Offset: 0x000020B4
		' (set) Token: 0x06000286 RID: 646 RVA: 0x00003EBC File Offset: 0x000020BC
		Friend Overridable Property DgvApsPinStatus As DataGridViewImageColumn

		' Token: 0x17000131 RID: 305
		' (get) Token: 0x06000287 RID: 647 RVA: 0x00003EC5 File Offset: 0x000020C5
		' (set) Token: 0x06000288 RID: 648 RVA: 0x00003ECD File Offset: 0x000020CD
		Friend Overridable Property DgvApsSSID As DataGridViewTextBoxColumn

		' Token: 0x17000132 RID: 306
		' (get) Token: 0x06000289 RID: 649 RVA: 0x00003ED6 File Offset: 0x000020D6
		' (set) Token: 0x0600028A RID: 650 RVA: 0x00003EDE File Offset: 0x000020DE
		Friend Overridable Property DgvApsBSSID As DataGridViewTextBoxColumn

		' Token: 0x17000133 RID: 307
		' (get) Token: 0x0600028B RID: 651 RVA: 0x00003EE7 File Offset: 0x000020E7
		' (set) Token: 0x0600028C RID: 652 RVA: 0x00003EEF File Offset: 0x000020EF
		Friend Overridable Property DgvApsChannel As DataGridViewTextBoxColumn

		' Token: 0x17000134 RID: 308
		' (get) Token: 0x0600028D RID: 653 RVA: 0x00003EF8 File Offset: 0x000020F8
		' (set) Token: 0x0600028E RID: 654 RVA: 0x00003F00 File Offset: 0x00002100
		Friend Overridable Property DgvApsSignal As DataGridViewTextBoxColumn

		' Token: 0x17000135 RID: 309
		' (get) Token: 0x0600028F RID: 655 RVA: 0x00003F09 File Offset: 0x00002109
		' (set) Token: 0x06000290 RID: 656 RVA: 0x00003F11 File Offset: 0x00002111
		Friend Overridable Property DgvApsVersion As DataGridViewTextBoxColumn

		' Token: 0x17000136 RID: 310
		' (get) Token: 0x06000291 RID: 657 RVA: 0x00003F1A File Offset: 0x0000211A
		' (set) Token: 0x06000292 RID: 658 RVA: 0x00003F22 File Offset: 0x00002122
		Friend Overridable Property DgvApsLocked As DataGridViewCheckBoxColumn

		' Token: 0x17000137 RID: 311
		' (get) Token: 0x06000293 RID: 659 RVA: 0x00003F2B File Offset: 0x0000212B
		' (set) Token: 0x06000294 RID: 660 RVA: 0x0000E3A8 File Offset: 0x0000C5A8
		Friend Overridable Property tsbPButton As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._tsbPButton
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_17
				Dim tsbPButton As ToolStripButton = Me._tsbPButton
				If tsbPButton IsNot Nothing Then
					RemoveHandler tsbPButton.Click, value2
				End If
				Me._tsbPButton = value
				tsbPButton = Me._tsbPButton
				If tsbPButton IsNot Nothing Then
					AddHandler tsbPButton.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000138 RID: 312
		' (get) Token: 0x06000295 RID: 661 RVA: 0x00003F33 File Offset: 0x00002133
		' (set) Token: 0x06000296 RID: 662 RVA: 0x0000E3EC File Offset: 0x0000C5EC
		Friend Overridable Property tsbPbcScan As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._tsbPbcScan
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_5
				Dim tsbPbcScan As ToolStripButton = Me._tsbPbcScan
				If tsbPbcScan IsNot Nothing Then
					RemoveHandler tsbPbcScan.Click, value2
				End If
				Me._tsbPbcScan = value
				tsbPbcScan = Me._tsbPbcScan
				If tsbPbcScan IsNot Nothing Then
					AddHandler tsbPbcScan.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000139 RID: 313
		' (get) Token: 0x06000297 RID: 663 RVA: 0x00003F3B File Offset: 0x0000213B
		' (set) Token: 0x06000298 RID: 664 RVA: 0x0000E430 File Offset: 0x0000C630
		Friend Overridable Property btScan As ToolStripSplitButton
			<CompilerGenerated()>
			Get
				Return Me._btScan
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSplitButton)
				Dim value2 As EventHandler = AddressOf Me.method_4
				Dim btScan As ToolStripSplitButton = Me._btScan
				If btScan IsNot Nothing Then
					RemoveHandler btScan.ButtonClick, value2
				End If
				Me._btScan = value
				btScan = Me._btScan
				If btScan IsNot Nothing Then
					AddHandler btScan.ButtonClick, value2
				End If
			End Set
		End Property

		' Token: 0x1700013A RID: 314
		' (get) Token: 0x06000299 RID: 665 RVA: 0x00003F43 File Offset: 0x00002143
		' (set) Token: 0x0600029A RID: 666 RVA: 0x00003F4B File Offset: 0x0000214B
		Friend Overridable Property tsWPSOnly As ToolStripMenuItem

		' Token: 0x0400008C RID: 140
		<CompilerGenerated()>
		<AccessedThroughProperty("jsApi")>
		Private gclass8_0 As GClass8

		' Token: 0x0400008D RID: 141
		Private gclass15_0 As GClass15(Of GClass9)

		' Token: 0x0400008E RID: 142
		Private gclass9_0 As GClass9

		' Token: 0x0400008F RID: 143
		Private gclass12_0 As GClass12

		' Token: 0x04000090 RID: 144
		Private int_0 As Integer

		' Token: 0x04000091 RID: 145
		Private bool_0 As Boolean

		' Token: 0x04000092 RID: 146
		Private bool_1 As Boolean

		' Token: 0x04000093 RID: 147
		Private bool_2 As Boolean

		' Token: 0x04000094 RID: 148
		Private bool_3 As Boolean

		' Token: 0x04000095 RID: 149
		Private bindingSource_0 As BindingSource

		' Token: 0x04000096 RID: 150
		Private bindingSource_1 As BindingSource

		' Token: 0x04000097 RID: 151
		<CompilerGenerated()>
		<AccessedThroughProperty("NewsMangr")>
		Private gclass10_0 As GClass10

		' Token: 0x0400009C RID: 156
		<AccessedThroughProperty("ImageList1")>
		<CompilerGenerated()>
		Private imageList_0 As ImageList

		' Token: 0x0400009D RID: 157
		<AccessedThroughProperty("ToolTip1")>
		<CompilerGenerated()>
		Private toolTip_0 As ToolTip

		' Token: 0x0200001B RID: 27
		' (Invoke) Token: 0x0600029E RID: 670
		Public Delegate Sub GDelegate4(message As String, color As Color, autoCrLf As Boolean)

		' Token: 0x0200001C RID: 28
		' (Invoke) Token: 0x060002A2 RID: 674
		Public Delegate Sub GDelegate5(status As GClass8.GEnum1)
	End Class
End Namespace
