Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SQLite
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace wAirCut
	' Token: 0x0200003D RID: 61
	<DesignerGenerated()>
	Public Partial Class WpsPinForm
		Inherits Form

		' Token: 0x06000423 RID: 1059 RVA: 0x00018A6C File Offset: 0x00016C6C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.WpsPinForm_Load
			Me.sqliteConnection_0 = New SQLiteConnection("Data Source=Bd\WpsProbePin.db;Version=3;")
			Me.dataTable_0 = New DataTable()
			Me.BindingSource_0 = New BindingSource()
			Me.dataTable_1 = New DataTable()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000424 RID: 1060 RVA: 0x00018AC8 File Offset: 0x00016CC8
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

		' Token: 0x1700019E RID: 414
		' (get) Token: 0x06000426 RID: 1062 RVA: 0x000049C5 File Offset: 0x00002BC5
		' (set) Token: 0x06000427 RID: 1063 RVA: 0x000049CD File Offset: 0x00002BCD
		Friend Overridable Property bnavWpsPin As BindingNavigator

		' Token: 0x1700019F RID: 415
		' (get) Token: 0x06000428 RID: 1064 RVA: 0x000049D6 File Offset: 0x00002BD6
		' (set) Token: 0x06000429 RID: 1065 RVA: 0x000049DE File Offset: 0x00002BDE
		Friend Overridable Property BindingNavigatorAddNewItem As ToolStripButton

		' Token: 0x170001A0 RID: 416
		' (get) Token: 0x0600042A RID: 1066 RVA: 0x000049E7 File Offset: 0x00002BE7
		' (set) Token: 0x0600042B RID: 1067 RVA: 0x000049EF File Offset: 0x00002BEF
		Friend Overridable Property BindingNavigatorCountItem As ToolStripLabel

		' Token: 0x170001A1 RID: 417
		' (get) Token: 0x0600042C RID: 1068 RVA: 0x000049F8 File Offset: 0x00002BF8
		' (set) Token: 0x0600042D RID: 1069 RVA: 0x00019480 File Offset: 0x00017680
		Friend Overridable Property BindingNavigatorDeleteItem As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._BindingNavigatorDeleteItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_2
				Dim bindingNavigatorDeleteItem As ToolStripButton = Me._BindingNavigatorDeleteItem
				If bindingNavigatorDeleteItem IsNot Nothing Then
					RemoveHandler bindingNavigatorDeleteItem.Click, value2
				End If
				Me._BindingNavigatorDeleteItem = value
				bindingNavigatorDeleteItem = Me._BindingNavigatorDeleteItem
				If bindingNavigatorDeleteItem IsNot Nothing Then
					AddHandler bindingNavigatorDeleteItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001A2 RID: 418
		' (get) Token: 0x0600042E RID: 1070 RVA: 0x00004A00 File Offset: 0x00002C00
		' (set) Token: 0x0600042F RID: 1071 RVA: 0x00004A08 File Offset: 0x00002C08
		Friend Overridable Property BindingNavigatorMoveFirstItem As ToolStripButton

		' Token: 0x170001A3 RID: 419
		' (get) Token: 0x06000430 RID: 1072 RVA: 0x00004A11 File Offset: 0x00002C11
		' (set) Token: 0x06000431 RID: 1073 RVA: 0x00004A19 File Offset: 0x00002C19
		Friend Overridable Property BindingNavigatorMovePreviousItem As ToolStripButton

		' Token: 0x170001A4 RID: 420
		' (get) Token: 0x06000432 RID: 1074 RVA: 0x00004A22 File Offset: 0x00002C22
		' (set) Token: 0x06000433 RID: 1075 RVA: 0x00004A2A File Offset: 0x00002C2A
		Friend Overridable Property BindingNavigatorSeparator As ToolStripSeparator

		' Token: 0x170001A5 RID: 421
		' (get) Token: 0x06000434 RID: 1076 RVA: 0x00004A33 File Offset: 0x00002C33
		' (set) Token: 0x06000435 RID: 1077 RVA: 0x00004A3B File Offset: 0x00002C3B
		Friend Overridable Property BindingNavigatorPositionItem As ToolStripTextBox

		' Token: 0x170001A6 RID: 422
		' (get) Token: 0x06000436 RID: 1078 RVA: 0x00004A44 File Offset: 0x00002C44
		' (set) Token: 0x06000437 RID: 1079 RVA: 0x00004A4C File Offset: 0x00002C4C
		Friend Overridable Property BindingNavigatorSeparator1 As ToolStripSeparator

		' Token: 0x170001A7 RID: 423
		' (get) Token: 0x06000438 RID: 1080 RVA: 0x00004A55 File Offset: 0x00002C55
		' (set) Token: 0x06000439 RID: 1081 RVA: 0x00004A5D File Offset: 0x00002C5D
		Friend Overridable Property BindingNavigatorMoveNextItem As ToolStripButton

		' Token: 0x170001A8 RID: 424
		' (get) Token: 0x0600043A RID: 1082 RVA: 0x00004A66 File Offset: 0x00002C66
		' (set) Token: 0x0600043B RID: 1083 RVA: 0x00004A6E File Offset: 0x00002C6E
		Friend Overridable Property BindingNavigatorMoveLastItem As ToolStripButton

		' Token: 0x170001A9 RID: 425
		' (get) Token: 0x0600043C RID: 1084 RVA: 0x00004A77 File Offset: 0x00002C77
		' (set) Token: 0x0600043D RID: 1085 RVA: 0x00004A7F File Offset: 0x00002C7F
		Friend Overridable Property BindingNavigatorSeparator2 As ToolStripSeparator

		' Token: 0x170001AA RID: 426
		' (get) Token: 0x0600043E RID: 1086 RVA: 0x00004A88 File Offset: 0x00002C88
		' (set) Token: 0x0600043F RID: 1087 RVA: 0x00004A90 File Offset: 0x00002C90
		Friend Overridable Property ToolStripSeparator1 As ToolStripSeparator

		' Token: 0x170001AB RID: 427
		' (get) Token: 0x06000440 RID: 1088 RVA: 0x00004A99 File Offset: 0x00002C99
		' (set) Token: 0x06000441 RID: 1089 RVA: 0x000194C4 File Offset: 0x000176C4
		Friend Overridable Property tbSearch As ToolStripTextBox
			<CompilerGenerated()>
			Get
				Return Me._tbSearch
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripTextBox)
				Dim value2 As EventHandler = AddressOf Me.method_0
				Dim tbSearch As ToolStripTextBox = Me._tbSearch
				If tbSearch IsNot Nothing Then
					RemoveHandler tbSearch.TextChanged, value2
				End If
				Me._tbSearch = value
				tbSearch = Me._tbSearch
				If tbSearch IsNot Nothing Then
					AddHandler tbSearch.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170001AC RID: 428
		' (get) Token: 0x06000442 RID: 1090 RVA: 0x00004AA1 File Offset: 0x00002CA1
		' (set) Token: 0x06000443 RID: 1091 RVA: 0x00019508 File Offset: 0x00017708
		Friend Overridable Property dgvWps As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvWps
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim value2 As DataGridViewCellEventHandler = AddressOf Me.method_1
				Dim value3 As KeyEventHandler = AddressOf Me.method_3
				Dim value4 As DataGridViewRowsRemovedEventHandler = AddressOf Me.method_4
				Dim value5 As DataGridViewDataErrorEventHandler = AddressOf Me.method_5
				Dim value6 As DataGridViewCellCancelEventHandler = AddressOf Me.method_8
				Dim dgvWps As DataGridView = Me._dgvWps
				If dgvWps IsNot Nothing Then
					RemoveHandler dgvWps.RowValidated, value2
					RemoveHandler dgvWps.KeyDown, value3
					RemoveHandler dgvWps.RowsRemoved, value4
					RemoveHandler dgvWps.DataError, value5
					RemoveHandler dgvWps.CellBeginEdit, value6
				End If
				Me._dgvWps = value
				dgvWps = Me._dgvWps
				If dgvWps IsNot Nothing Then
					AddHandler dgvWps.RowValidated, value2
					AddHandler dgvWps.KeyDown, value3
					AddHandler dgvWps.RowsRemoved, value4
					AddHandler dgvWps.DataError, value5
					AddHandler dgvWps.CellBeginEdit, value6
				End If
			End Set
		End Property

		' Token: 0x170001AD RID: 429
		' (get) Token: 0x06000444 RID: 1092 RVA: 0x00004AA9 File Offset: 0x00002CA9
		' (set) Token: 0x06000445 RID: 1093 RVA: 0x00004AB1 File Offset: 0x00002CB1
		Friend Overridable Property tbExport As ToolStripButton

		' Token: 0x170001AE RID: 430
		' (get) Token: 0x06000446 RID: 1094 RVA: 0x00004ABA File Offset: 0x00002CBA
		' (set) Token: 0x06000447 RID: 1095 RVA: 0x00004AC2 File Offset: 0x00002CC2
		Friend Overridable Property tbImport As ToolStripButton

		' Token: 0x170001AF RID: 431
		' (get) Token: 0x06000448 RID: 1096 RVA: 0x00004ACB File Offset: 0x00002CCB
		' (set) Token: 0x06000449 RID: 1097 RVA: 0x00004AD3 File Offset: 0x00002CD3
		Friend Overridable Property ToolStripLabel1 As ToolStripLabel

		' Token: 0x170001B0 RID: 432
		' (get) Token: 0x0600044A RID: 1098 RVA: 0x00004ADC File Offset: 0x00002CDC
		' (set) Token: 0x0600044B RID: 1099 RVA: 0x00004AE4 File Offset: 0x00002CE4
		Friend Overridable Property ToolTip_0 As ToolTip

		' Token: 0x170001B1 RID: 433
		' (get) Token: 0x0600044C RID: 1100 RVA: 0x00004AED File Offset: 0x00002CED
		' (set) Token: 0x0600044D RID: 1101 RVA: 0x00004AF5 File Offset: 0x00002CF5
		Friend Overridable Property dgvWPSId As DataGridViewTextBoxColumn

		' Token: 0x170001B2 RID: 434
		' (get) Token: 0x0600044E RID: 1102 RVA: 0x00004AFE File Offset: 0x00002CFE
		' (set) Token: 0x0600044F RID: 1103 RVA: 0x00004B06 File Offset: 0x00002D06
		Friend Overridable Property dgvWpsDeviceName As DataGridViewTextBoxColumn

		' Token: 0x170001B3 RID: 435
		' (get) Token: 0x06000450 RID: 1104 RVA: 0x00004B0F File Offset: 0x00002D0F
		' (set) Token: 0x06000451 RID: 1105 RVA: 0x00004B17 File Offset: 0x00002D17
		Friend Overridable Property dgvWPSModelName As DataGridViewTextBoxColumn

		' Token: 0x170001B4 RID: 436
		' (get) Token: 0x06000452 RID: 1106 RVA: 0x00004B20 File Offset: 0x00002D20
		' (set) Token: 0x06000453 RID: 1107 RVA: 0x00004B28 File Offset: 0x00002D28
		Friend Overridable Property dgvWPSModelNumber As DataGridViewTextBoxColumn

		' Token: 0x170001B5 RID: 437
		' (get) Token: 0x06000454 RID: 1108 RVA: 0x00004B31 File Offset: 0x00002D31
		' (set) Token: 0x06000455 RID: 1109 RVA: 0x00004B39 File Offset: 0x00002D39
		Friend Overridable Property dgvWpsBssid As DataGridViewTextBoxColumn

		' Token: 0x170001B6 RID: 438
		' (get) Token: 0x06000456 RID: 1110 RVA: 0x00004B42 File Offset: 0x00002D42
		' (set) Token: 0x06000457 RID: 1111 RVA: 0x00004B4A File Offset: 0x00002D4A
		Friend Overridable Property dgvWpsPin As DataGridViewTextBoxColumn

		' Token: 0x170001B7 RID: 439
		' (get) Token: 0x06000458 RID: 1112 RVA: 0x00004B53 File Offset: 0x00002D53
		' (set) Token: 0x06000459 RID: 1113 RVA: 0x00004B5B File Offset: 0x00002D5B
		Friend Overridable Property dgvWpsAlgorithmId As DataGridViewComboBoxColumn

		' Token: 0x170001B8 RID: 440
		' (get) Token: 0x0600045A RID: 1114 RVA: 0x00004B64 File Offset: 0x00002D64
		' (set) Token: 0x0600045B RID: 1115 RVA: 0x00004B6C File Offset: 0x00002D6C
		Friend Overridable Property dgvWpsPixie As DataGridViewCheckBoxColumn

		' Token: 0x170001B9 RID: 441
		' (get) Token: 0x0600045C RID: 1116 RVA: 0x00004B75 File Offset: 0x00002D75
		' (set) Token: 0x0600045D RID: 1117 RVA: 0x000195C8 File Offset: 0x000177C8
		Private Overridable Property BindingSource_0 As BindingSource
			<CompilerGenerated()>
			Get
				Return Me.bindingSource_0
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As BindingSource)
				Dim value2 As AddingNewEventHandler = AddressOf Me.method_6
				Dim bindingSource As BindingSource = Me.bindingSource_0
				If bindingSource IsNot Nothing Then
					RemoveHandler bindingSource.AddingNew, value2
				End If
				Me.bindingSource_0 = value
				bindingSource = Me.bindingSource_0
				If bindingSource IsNot Nothing Then
					AddHandler bindingSource.AddingNew, value2
				End If
			End Set
		End Property

		' Token: 0x0600045E RID: 1118 RVA: 0x0001960C File Offset: 0x0001780C
		Private Sub WpsPinForm_Load(sender As Object, e As EventArgs)
			Me.sqliteCommand_0 = New SQLiteCommand("Select * From WPSPins", Me.sqliteConnection_0)
			Me.sqliteCommand_1 = New SQLiteCommand("Select * From Algorithms", Me.sqliteConnection_0)
			Me.sqliteDataAdapter_0 = New SQLiteDataAdapter(Me.sqliteCommand_0)
			Me.sqliteDataAdapter_1 = New SQLiteDataAdapter(Me.sqliteCommand_1)
			Me.sqliteCommandBuilder_0 = New SQLiteCommandBuilder(Me.sqliteDataAdapter_0)
			Me.dataTable_0.Locale = CultureInfo.InvariantCulture
			Me.sqliteDataAdapter_0.Fill(Me.dataTable_0)
			Me.BindingSource_0.DataSource = Me.dataTable_0
			Me.sqliteDataAdapter_1.Fill(Me.dataTable_1)
			Me.dgvWpsAlgorithmId.DataSource = Me.dataTable_1
			Me.dgvWpsAlgorithmId.DataPropertyName = "AlgorithmId"
			Me.dgvWpsAlgorithmId.DisplayMember = "Name"
			Me.dgvWpsAlgorithmId.ValueMember = "id"
			Me.dgvWps.AutoGenerateColumns = False
			Me.dgvWps.DataSource = Me.BindingSource_0
			Me.bnavWpsPin.BindingSource = Me.BindingSource_0
		End Sub

		' Token: 0x0600045F RID: 1119 RVA: 0x00004B7D File Offset: 0x00002D7D
		Private Sub method_0(sender As Object, e As EventArgs)
			Me.BindingSource_0.Filter = String.Format("BSSID like '%{0}%' or ModelName like '%{0}%' or ModelNumber like '%{0}%' or DeviceName like '%{0}%' or PIN like '%{0}%'", Me.tbSearch.Text)
		End Sub

		' Token: 0x06000460 RID: 1120 RVA: 0x0001972C File Offset: 0x0001792C
		Private Sub method_1(sender As Object, e As DataGridViewCellEventArgs)
			Try
				Me.sqliteDataAdapter_0.Update(Me.dataTable_0)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000461 RID: 1121 RVA: 0x0001976C File Offset: 0x0001796C
		Private Sub method_2(sender As Object, e As EventArgs)
			If MessageBox.Show("Se van a eliminar los datos seleccionados, ¿desea continuar?", "Confirm Delete!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
				Try
					For Each obj As Object In Me.dgvWps.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						If Not dataGridViewRow.IsNewRow Then
							Me.BindingSource_0.RemoveAt(dataGridViewRow.Index)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06000462 RID: 1122 RVA: 0x00004B9F File Offset: 0x00002D9F
		Private Sub method_3(sender As Object, e As KeyEventArgs)
			If(If((-If(((e.KeyCode = Keys.Delete) > False), DataGridViewEditMode.EditOnKeystroke, DataGridViewEditMode.EditOnEnter)), DataGridViewEditMode.EditOnKeystroke, DataGridViewEditMode.EditOnEnter) And Not Me.dgvWps.EditMode) > DataGridViewEditMode.EditOnEnter AndAlso Me.dgvWps.SelectedRows.Count > 0 Then
				Me.BindingNavigatorDeleteItem.PerformClick()
			End If
		End Sub

		' Token: 0x06000463 RID: 1123 RVA: 0x0001972C File Offset: 0x0001792C
		Private Sub method_4(sender As Object, e As DataGridViewRowsRemovedEventArgs)
			Try
				Me.sqliteDataAdapter_0.Update(Me.dataTable_0)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000464 RID: 1124 RVA: 0x00003867 File Offset: 0x00001A67
		Private Sub method_5(sender As Object, e As DataGridViewDataErrorEventArgs)
			MessageBox.Show(e.Exception.Message, "Wps Pin data base Error", MessageBoxButtons.OK)
			e.Cancel = True
		End Sub

		' Token: 0x06000465 RID: 1125 RVA: 0x000197F4 File Offset: 0x000179F4
		Private Sub method_6(sender As Object, e As AddingNewEventArgs)
			Dim dataRowView As DataRowView = CType(Me.BindingSource_0.List, DataView).AddNew()
			dataRowView("id") = Me.method_7(Me.sqliteConnection_0, "WPSPins") + 1
			dataRowView("AlgorithmId") = -1
			dataRowView("PixieDust") = 0
			dataRowView("DeviceName") = ""
			dataRowView("ModelName") = ""
			dataRowView("ModelNumber") = ""
			e.NewObject = dataRowView
			Me.BindingSource_0.MoveLast()
		End Sub

		' Token: 0x06000466 RID: 1126 RVA: 0x00004BDF File Offset: 0x00002DDF
		Private Function method_7(sqliteConnection_1 As SQLiteConnection, string_0 As String) As Integer
			Dim sqliteCommand As SQLiteCommand = New SQLiteCommand("Select MAX(id) From " + string_0, sqliteConnection_1)
			sqliteConnection_1.Open()
			Dim result As Integer = Conversions.ToInteger(sqliteCommand.ExecuteScalar())
			sqliteConnection_1.Close()
			Return result
		End Function

		' Token: 0x06000467 RID: 1127 RVA: 0x000198A0 File Offset: 0x00017AA0
		Private Sub method_8(sender As Object, e As DataGridViewCellCancelEventArgs)
			Dim stringListEditor As StringListEditor = New StringListEditor()
			If(e.ColumnIndex = 4 Or e.ColumnIndex = 5) AndAlso Not Information.IsDBNull(Me.dgvWps.SelectedCells(e.ColumnIndex)) Then
				stringListEditor.method_2(Conversions.ToString(Me.dgvWps.SelectedCells(e.ColumnIndex).Value))
				stringListEditor.Text = Me.dgvWps.Columns(e.ColumnIndex).HeaderText
				If stringListEditor.ShowDialog() = DialogResult.OK Then
					Me.dgvWps.SelectedCells(e.ColumnIndex).Value = stringListEditor.method_3()
				End If
			End If
		End Sub

		' Token: 0x04000202 RID: 514
		<CompilerGenerated()>
		<AccessedThroughProperty("ToolTip1")>
		Private toolTip_0 As ToolTip

		' Token: 0x0400020B RID: 523
		Private sqliteConnection_0 As SQLiteConnection

		' Token: 0x0400020C RID: 524
		Private sqliteCommand_0 As SQLiteCommand

		' Token: 0x0400020D RID: 525
		Private sqliteDataAdapter_0 As SQLiteDataAdapter

		' Token: 0x0400020E RID: 526
		Private sqliteCommandBuilder_0 As SQLiteCommandBuilder

		' Token: 0x0400020F RID: 527
		Private dataTable_0 As DataTable

		' Token: 0x04000210 RID: 528
		<CompilerGenerated()>
		<AccessedThroughProperty("bsPin")>
		Private bindingSource_0 As BindingSource

		' Token: 0x04000211 RID: 529
		Private sqliteCommand_1 As SQLiteCommand

		' Token: 0x04000212 RID: 530
		Private sqliteDataAdapter_1 As SQLiteDataAdapter

		' Token: 0x04000213 RID: 531
		Private dataTable_1 As DataTable
	End Class
End Namespace
