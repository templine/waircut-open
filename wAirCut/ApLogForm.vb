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
Imports Microsoft.VisualBasic.CompilerServices

Namespace wAirCut
	' Token: 0x0200000D RID: 13
	<DesignerGenerated()>
	Public Partial Class ApLogForm
		Inherits Form

		' Token: 0x060000E7 RID: 231 RVA: 0x0000523C File Offset: 0x0000343C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.ApLogForm_Load
			Me.sqliteConnection_0 = New SQLiteConnection("Data Source=Bd\ApLog.db;Version=3;")
			Me.dataTable_0 = New DataTable()
			Me.BindingSource_0 = New BindingSource()
			Me.dataTable_1 = New DataTable()
			Me.toolTip_1 = New ToolTip()
			Me.InitializeComponent()
		End Sub

		' Token: 0x060000E8 RID: 232 RVA: 0x000052A4 File Offset: 0x000034A4
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

		' Token: 0x170000B1 RID: 177
		' (get) Token: 0x060000EA RID: 234 RVA: 0x000034D1 File Offset: 0x000016D1
		' (set) Token: 0x060000EB RID: 235 RVA: 0x000063C0 File Offset: 0x000045C0
		Friend Overridable Property dgvAp As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvAp
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim value2 As DataGridViewCellEventHandler = AddressOf Me.method_1
				Dim value3 As KeyEventHandler = AddressOf Me.method_3
				Dim value4 As DataGridViewRowsRemovedEventHandler = AddressOf Me.method_4
				Dim value5 As DataGridViewDataErrorEventHandler = AddressOf Me.method_5
				Dim value6 As DataGridViewCellFormattingEventHandler = AddressOf Me.method_6
				Dim dgvAp As DataGridView = Me._dgvAp
				If dgvAp IsNot Nothing Then
					RemoveHandler dgvAp.RowValidated, value2
					RemoveHandler dgvAp.KeyDown, value3
					RemoveHandler dgvAp.RowsRemoved, value4
					RemoveHandler dgvAp.DataError, value5
					RemoveHandler dgvAp.CellFormatting, value6
				End If
				Me._dgvAp = value
				dgvAp = Me._dgvAp
				If dgvAp IsNot Nothing Then
					AddHandler dgvAp.RowValidated, value2
					AddHandler dgvAp.KeyDown, value3
					AddHandler dgvAp.RowsRemoved, value4
					AddHandler dgvAp.DataError, value5
					AddHandler dgvAp.CellFormatting, value6
				End If
			End Set
		End Property

		' Token: 0x170000B2 RID: 178
		' (get) Token: 0x060000EC RID: 236 RVA: 0x000034D9 File Offset: 0x000016D9
		' (set) Token: 0x060000ED RID: 237 RVA: 0x000034E1 File Offset: 0x000016E1
		Friend Overridable Property bnavAp As BindingNavigator

		' Token: 0x170000B3 RID: 179
		' (get) Token: 0x060000EE RID: 238 RVA: 0x000034EA File Offset: 0x000016EA
		' (set) Token: 0x060000EF RID: 239 RVA: 0x000034F2 File Offset: 0x000016F2
		Friend Overridable Property BindingNavigatorAddNewItem As ToolStripButton

		' Token: 0x170000B4 RID: 180
		' (get) Token: 0x060000F0 RID: 240 RVA: 0x000034FB File Offset: 0x000016FB
		' (set) Token: 0x060000F1 RID: 241 RVA: 0x00003503 File Offset: 0x00001703
		Friend Overridable Property BindingNavigatorCountItem As ToolStripLabel

		' Token: 0x170000B5 RID: 181
		' (get) Token: 0x060000F2 RID: 242 RVA: 0x0000350C File Offset: 0x0000170C
		' (set) Token: 0x060000F3 RID: 243 RVA: 0x00006480 File Offset: 0x00004680
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

		' Token: 0x170000B6 RID: 182
		' (get) Token: 0x060000F4 RID: 244 RVA: 0x00003514 File Offset: 0x00001714
		' (set) Token: 0x060000F5 RID: 245 RVA: 0x0000351C File Offset: 0x0000171C
		Friend Overridable Property BindingNavigatorMoveFirstItem As ToolStripButton

		' Token: 0x170000B7 RID: 183
		' (get) Token: 0x060000F6 RID: 246 RVA: 0x00003525 File Offset: 0x00001725
		' (set) Token: 0x060000F7 RID: 247 RVA: 0x0000352D File Offset: 0x0000172D
		Friend Overridable Property BindingNavigatorMovePreviousItem As ToolStripButton

		' Token: 0x170000B8 RID: 184
		' (get) Token: 0x060000F8 RID: 248 RVA: 0x00003536 File Offset: 0x00001736
		' (set) Token: 0x060000F9 RID: 249 RVA: 0x0000353E File Offset: 0x0000173E
		Friend Overridable Property BindingNavigatorSeparator As ToolStripSeparator

		' Token: 0x170000B9 RID: 185
		' (get) Token: 0x060000FA RID: 250 RVA: 0x00003547 File Offset: 0x00001747
		' (set) Token: 0x060000FB RID: 251 RVA: 0x0000354F File Offset: 0x0000174F
		Friend Overridable Property BindingNavigatorPositionItem As ToolStripTextBox

		' Token: 0x170000BA RID: 186
		' (get) Token: 0x060000FC RID: 252 RVA: 0x00003558 File Offset: 0x00001758
		' (set) Token: 0x060000FD RID: 253 RVA: 0x00003560 File Offset: 0x00001760
		Friend Overridable Property BindingNavigatorSeparator1 As ToolStripSeparator

		' Token: 0x170000BB RID: 187
		' (get) Token: 0x060000FE RID: 254 RVA: 0x00003569 File Offset: 0x00001769
		' (set) Token: 0x060000FF RID: 255 RVA: 0x00003571 File Offset: 0x00001771
		Friend Overridable Property BindingNavigatorMoveNextItem As ToolStripButton

		' Token: 0x170000BC RID: 188
		' (get) Token: 0x06000100 RID: 256 RVA: 0x0000357A File Offset: 0x0000177A
		' (set) Token: 0x06000101 RID: 257 RVA: 0x00003582 File Offset: 0x00001782
		Friend Overridable Property BindingNavigatorMoveLastItem As ToolStripButton

		' Token: 0x170000BD RID: 189
		' (get) Token: 0x06000102 RID: 258 RVA: 0x0000358B File Offset: 0x0000178B
		' (set) Token: 0x06000103 RID: 259 RVA: 0x00003593 File Offset: 0x00001793
		Friend Overridable Property BindingNavigatorSeparator2 As ToolStripSeparator

		' Token: 0x170000BE RID: 190
		' (get) Token: 0x06000104 RID: 260 RVA: 0x0000359C File Offset: 0x0000179C
		' (set) Token: 0x06000105 RID: 261 RVA: 0x000035A4 File Offset: 0x000017A4
		Friend Overridable Property ToolStripSeparator1 As ToolStripSeparator

		' Token: 0x170000BF RID: 191
		' (get) Token: 0x06000106 RID: 262 RVA: 0x000035AD File Offset: 0x000017AD
		' (set) Token: 0x06000107 RID: 263 RVA: 0x000064C4 File Offset: 0x000046C4
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

		' Token: 0x170000C0 RID: 192
		' (get) Token: 0x06000108 RID: 264 RVA: 0x000035B5 File Offset: 0x000017B5
		' (set) Token: 0x06000109 RID: 265 RVA: 0x000035BD File Offset: 0x000017BD
		Friend Overridable Property Panel1 As Panel

		' Token: 0x170000C1 RID: 193
		' (get) Token: 0x0600010A RID: 266 RVA: 0x000035C6 File Offset: 0x000017C6
		' (set) Token: 0x0600010B RID: 267 RVA: 0x000035CE File Offset: 0x000017CE
		Friend Overridable Property tbDeviceName As TextBox

		' Token: 0x170000C2 RID: 194
		' (get) Token: 0x0600010C RID: 268 RVA: 0x000035D7 File Offset: 0x000017D7
		' (set) Token: 0x0600010D RID: 269 RVA: 0x000035DF File Offset: 0x000017DF
		Friend Overridable Property Label1 As Label

		' Token: 0x170000C3 RID: 195
		' (get) Token: 0x0600010E RID: 270 RVA: 0x000035E8 File Offset: 0x000017E8
		' (set) Token: 0x0600010F RID: 271 RVA: 0x000035F0 File Offset: 0x000017F0
		Friend Overridable Property tbConfigMethod As TextBox

		' Token: 0x170000C4 RID: 196
		' (get) Token: 0x06000110 RID: 272 RVA: 0x000035F9 File Offset: 0x000017F9
		' (set) Token: 0x06000111 RID: 273 RVA: 0x00003601 File Offset: 0x00001801
		Friend Overridable Property Label10 As Label

		' Token: 0x170000C5 RID: 197
		' (get) Token: 0x06000112 RID: 274 RVA: 0x0000360A File Offset: 0x0000180A
		' (set) Token: 0x06000113 RID: 275 RVA: 0x00003612 File Offset: 0x00001812
		Friend Overridable Property tbEncryption As TextBox

		' Token: 0x170000C6 RID: 198
		' (get) Token: 0x06000114 RID: 276 RVA: 0x0000361B File Offset: 0x0000181B
		' (set) Token: 0x06000115 RID: 277 RVA: 0x00003623 File Offset: 0x00001823
		Friend Overridable Property Label9 As Label

		' Token: 0x170000C7 RID: 199
		' (get) Token: 0x06000116 RID: 278 RVA: 0x0000362C File Offset: 0x0000182C
		' (set) Token: 0x06000117 RID: 279 RVA: 0x00003634 File Offset: 0x00001834
		Friend Overridable Property tbVersion As TextBox

		' Token: 0x170000C8 RID: 200
		' (get) Token: 0x06000118 RID: 280 RVA: 0x0000363D File Offset: 0x0000183D
		' (set) Token: 0x06000119 RID: 281 RVA: 0x00003645 File Offset: 0x00001845
		Friend Overridable Property Label8 As Label

		' Token: 0x170000C9 RID: 201
		' (get) Token: 0x0600011A RID: 282 RVA: 0x0000364E File Offset: 0x0000184E
		' (set) Token: 0x0600011B RID: 283 RVA: 0x00006508 File Offset: 0x00004708
		Friend Overridable Property tbUUID As TextBox
			<CompilerGenerated()>
			Get
				Return Me._tbUUID
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.method_7
				Dim tbUUID As TextBox = Me._tbUUID
				If tbUUID IsNot Nothing Then
					RemoveHandler tbUUID.TextChanged, value2
				End If
				Me._tbUUID = value
				tbUUID = Me._tbUUID
				If tbUUID IsNot Nothing Then
					AddHandler tbUUID.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170000CA RID: 202
		' (get) Token: 0x0600011C RID: 284 RVA: 0x00003656 File Offset: 0x00001856
		' (set) Token: 0x0600011D RID: 285 RVA: 0x0000365E File Offset: 0x0000185E
		Friend Overridable Property Label7 As Label

		' Token: 0x170000CB RID: 203
		' (get) Token: 0x0600011E RID: 286 RVA: 0x00003667 File Offset: 0x00001867
		' (set) Token: 0x0600011F RID: 287 RVA: 0x0000366F File Offset: 0x0000186F
		Friend Overridable Property tbRfBand As TextBox

		' Token: 0x170000CC RID: 204
		' (get) Token: 0x06000120 RID: 288 RVA: 0x00003678 File Offset: 0x00001878
		' (set) Token: 0x06000121 RID: 289 RVA: 0x00003680 File Offset: 0x00001880
		Friend Overridable Property Label6 As Label

		' Token: 0x170000CD RID: 205
		' (get) Token: 0x06000122 RID: 290 RVA: 0x00003689 File Offset: 0x00001889
		' (set) Token: 0x06000123 RID: 291 RVA: 0x0000654C File Offset: 0x0000474C
		Friend Overridable Property tbSerialNumber As TextBox
			<CompilerGenerated()>
			Get
				Return Me._tbSerialNumber
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.method_8
				Dim tbSerialNumber As TextBox = Me._tbSerialNumber
				If tbSerialNumber IsNot Nothing Then
					RemoveHandler tbSerialNumber.TextChanged, value2
				End If
				Me._tbSerialNumber = value
				tbSerialNumber = Me._tbSerialNumber
				If tbSerialNumber IsNot Nothing Then
					AddHandler tbSerialNumber.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170000CE RID: 206
		' (get) Token: 0x06000124 RID: 292 RVA: 0x00003691 File Offset: 0x00001891
		' (set) Token: 0x06000125 RID: 293 RVA: 0x00003699 File Offset: 0x00001899
		Friend Overridable Property Label5 As Label

		' Token: 0x170000CF RID: 207
		' (get) Token: 0x06000126 RID: 294 RVA: 0x000036A2 File Offset: 0x000018A2
		' (set) Token: 0x06000127 RID: 295 RVA: 0x000036AA File Offset: 0x000018AA
		Friend Overridable Property tbManufacturer As TextBox

		' Token: 0x170000D0 RID: 208
		' (get) Token: 0x06000128 RID: 296 RVA: 0x000036B3 File Offset: 0x000018B3
		' (set) Token: 0x06000129 RID: 297 RVA: 0x000036BB File Offset: 0x000018BB
		Friend Overridable Property Label4 As Label

		' Token: 0x170000D1 RID: 209
		' (get) Token: 0x0600012A RID: 298 RVA: 0x000036C4 File Offset: 0x000018C4
		' (set) Token: 0x0600012B RID: 299 RVA: 0x000036CC File Offset: 0x000018CC
		Friend Overridable Property tbModelNumber As TextBox

		' Token: 0x170000D2 RID: 210
		' (get) Token: 0x0600012C RID: 300 RVA: 0x000036D5 File Offset: 0x000018D5
		' (set) Token: 0x0600012D RID: 301 RVA: 0x000036DD File Offset: 0x000018DD
		Friend Overridable Property Label3 As Label

		' Token: 0x170000D3 RID: 211
		' (get) Token: 0x0600012E RID: 302 RVA: 0x000036E6 File Offset: 0x000018E6
		' (set) Token: 0x0600012F RID: 303 RVA: 0x000036EE File Offset: 0x000018EE
		Friend Overridable Property tbModelName As TextBox

		' Token: 0x170000D4 RID: 212
		' (get) Token: 0x06000130 RID: 304 RVA: 0x000036F7 File Offset: 0x000018F7
		' (set) Token: 0x06000131 RID: 305 RVA: 0x000036FF File Offset: 0x000018FF
		Friend Overridable Property Label2 As Label

		' Token: 0x170000D5 RID: 213
		' (get) Token: 0x06000132 RID: 306 RVA: 0x00003708 File Offset: 0x00001908
		' (set) Token: 0x06000133 RID: 307 RVA: 0x00003710 File Offset: 0x00001910
		Friend Overridable Property tbImport As ToolStripButton

		' Token: 0x170000D6 RID: 214
		' (get) Token: 0x06000134 RID: 308 RVA: 0x00003719 File Offset: 0x00001919
		' (set) Token: 0x06000135 RID: 309 RVA: 0x00003721 File Offset: 0x00001921
		Friend Overridable Property tbExport As ToolStripButton

		' Token: 0x170000D7 RID: 215
		' (get) Token: 0x06000136 RID: 310 RVA: 0x0000372A File Offset: 0x0000192A
		' (set) Token: 0x06000137 RID: 311 RVA: 0x00003732 File Offset: 0x00001932
		Friend Overridable Property ToolStripLabel1 As ToolStripLabel

		' Token: 0x170000D8 RID: 216
		' (get) Token: 0x06000138 RID: 312 RVA: 0x0000373B File Offset: 0x0000193B
		' (set) Token: 0x06000139 RID: 313 RVA: 0x00003743 File Offset: 0x00001943
		Friend Overridable Property Label11 As Label

		' Token: 0x170000D9 RID: 217
		' (get) Token: 0x0600013A RID: 314 RVA: 0x0000374C File Offset: 0x0000194C
		' (set) Token: 0x0600013B RID: 315 RVA: 0x00003754 File Offset: 0x00001954
		Friend Overridable Property dgvApStatus As DataGridViewImageColumn

		' Token: 0x170000DA RID: 218
		' (get) Token: 0x0600013C RID: 316 RVA: 0x0000375D File Offset: 0x0000195D
		' (set) Token: 0x0600013D RID: 317 RVA: 0x00003765 File Offset: 0x00001965
		Friend Overridable Property dgvApBssid As DataGridViewTextBoxColumn

		' Token: 0x170000DB RID: 219
		' (get) Token: 0x0600013E RID: 318 RVA: 0x0000376E File Offset: 0x0000196E
		' (set) Token: 0x0600013F RID: 319 RVA: 0x00003776 File Offset: 0x00001976
		Friend Overridable Property dgvApSSID As DataGridViewTextBoxColumn

		' Token: 0x170000DC RID: 220
		' (get) Token: 0x06000140 RID: 320 RVA: 0x0000377F File Offset: 0x0000197F
		' (set) Token: 0x06000141 RID: 321 RVA: 0x00003787 File Offset: 0x00001987
		Friend Overridable Property dgvApPin As DataGridViewTextBoxColumn

		' Token: 0x170000DD RID: 221
		' (get) Token: 0x06000142 RID: 322 RVA: 0x00003790 File Offset: 0x00001990
		' (set) Token: 0x06000143 RID: 323 RVA: 0x00003798 File Offset: 0x00001998
		Friend Overridable Property dgvApKey As DataGridViewTextBoxColumn

		' Token: 0x170000DE RID: 222
		' (get) Token: 0x06000144 RID: 324 RVA: 0x000037A1 File Offset: 0x000019A1
		' (set) Token: 0x06000145 RID: 325 RVA: 0x00006590 File Offset: 0x00004790
		Friend Overridable Property tbNetworkKey As TextBox
			<CompilerGenerated()>
			Get
				Return Me._tbNetworkKey
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.method_10
				Dim tbNetworkKey As TextBox = Me._tbNetworkKey
				If tbNetworkKey IsNot Nothing Then
					RemoveHandler tbNetworkKey.TextChanged, value2
				End If
				Me._tbNetworkKey = value
				tbNetworkKey = Me._tbNetworkKey
				If tbNetworkKey IsNot Nothing Then
					AddHandler tbNetworkKey.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170000DF RID: 223
		' (get) Token: 0x06000146 RID: 326 RVA: 0x000037A9 File Offset: 0x000019A9
		' (set) Token: 0x06000147 RID: 327 RVA: 0x000037B1 File Offset: 0x000019B1
		Friend Overridable Property Label12 As Label

		' Token: 0x170000E0 RID: 224
		' (get) Token: 0x06000148 RID: 328 RVA: 0x000037BA File Offset: 0x000019BA
		' (set) Token: 0x06000149 RID: 329 RVA: 0x000065D4 File Offset: 0x000047D4
		Friend Overridable Property tbWpsPin As TextBox
			<CompilerGenerated()>
			Get
				Return Me._tbWpsPin
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.method_9
				Dim tbWpsPin As TextBox = Me._tbWpsPin
				If tbWpsPin IsNot Nothing Then
					RemoveHandler tbWpsPin.TextChanged, value2
				End If
				Me._tbWpsPin = value
				tbWpsPin = Me._tbWpsPin
				If tbWpsPin IsNot Nothing Then
					AddHandler tbWpsPin.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170000E1 RID: 225
		' (get) Token: 0x0600014A RID: 330 RVA: 0x000037C2 File Offset: 0x000019C2
		' (set) Token: 0x0600014B RID: 331 RVA: 0x000037CA File Offset: 0x000019CA
		Friend Overridable Property Label13 As Label

		' Token: 0x170000E2 RID: 226
		' (get) Token: 0x0600014C RID: 332 RVA: 0x000037D3 File Offset: 0x000019D3
		' (set) Token: 0x0600014D RID: 333 RVA: 0x00006618 File Offset: 0x00004818
		Friend Overridable Property tbUpload As ToolStripButton
			<CompilerGenerated()>
			Get
				Return Me._tbUpload
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.method_11
				Dim tbUpload As ToolStripButton = Me._tbUpload
				If tbUpload IsNot Nothing Then
					RemoveHandler tbUpload.Click, value2
				End If
				Me._tbUpload = value
				tbUpload = Me._tbUpload
				If tbUpload IsNot Nothing Then
					AddHandler tbUpload.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E3 RID: 227
		' (get) Token: 0x0600014E RID: 334 RVA: 0x000037DB File Offset: 0x000019DB
		' (set) Token: 0x0600014F RID: 335 RVA: 0x000037E3 File Offset: 0x000019E3
		Friend Overridable Property ToolTip_0 As ToolTip

		' Token: 0x170000E4 RID: 228
		' (get) Token: 0x06000150 RID: 336 RVA: 0x000037EC File Offset: 0x000019EC
		' (set) Token: 0x06000151 RID: 337 RVA: 0x0000665C File Offset: 0x0000485C
		Friend Overridable Property Timer_0 As Timer
			<CompilerGenerated()>
			Get
				Return Me.timer_0
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.method_12
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

		' Token: 0x170000E5 RID: 229
		' (get) Token: 0x06000152 RID: 338 RVA: 0x000037F4 File Offset: 0x000019F4
		' (set) Token: 0x06000153 RID: 339 RVA: 0x000037FC File Offset: 0x000019FC
		Private Overridable Property BindingSource_0 As BindingSource

		' Token: 0x06000154 RID: 340 RVA: 0x000066A0 File Offset: 0x000048A0
		Private Sub ApLogForm_Load(sender As Object, e As EventArgs)
			Me.sqliteCommand_0 = New SQLiteCommand("Select * From Networks", Me.sqliteConnection_0)
			Me.sqliteCommand_1 = New SQLiteCommand("Select * From Algorithms", Me.sqliteConnection_0)
			Me.sqliteDataAdapter_0 = New SQLiteDataAdapter(Me.sqliteCommand_0)
			Me.sqliteDataAdapter_1 = New SQLiteDataAdapter(Me.sqliteCommand_1)
			Me.sqliteCommandBuilder_0 = New SQLiteCommandBuilder(Me.sqliteDataAdapter_0)
			Me.dataTable_0.Locale = CultureInfo.InvariantCulture
			Me.sqliteDataAdapter_0.Fill(Me.dataTable_0)
			Me.BindingSource_0.DataSource = Me.dataTable_0
			Me.sqliteDataAdapter_1.Fill(Me.dataTable_1)
			Me.dgvAp.AutoGenerateColumns = False
			Me.dgvAp.DataSource = Me.BindingSource_0
			Me.tbDeviceName.DataBindings.Add("Text", Me.BindingSource_0, "DeviceName")
			Me.tbModelName.DataBindings.Add("Text", Me.BindingSource_0, "ModelName")
			Me.tbModelNumber.DataBindings.Add("Text", Me.BindingSource_0, "ModelNumber")
			Me.tbManufacturer.DataBindings.Add("Text", Me.BindingSource_0, "Manufacturer")
			Me.tbSerialNumber.DataBindings.Add("Text", Me.BindingSource_0, "SerialNumber")
			Me.tbRfBand.DataBindings.Add("Text", Me.BindingSource_0, "RfBand")
			Me.tbUUID.DataBindings.Add("Text", Me.BindingSource_0, "UUID")
			Me.tbVersion.DataBindings.Add("Text", Me.BindingSource_0, "Version")
			Me.tbEncryption.DataBindings.Add("Text", Me.BindingSource_0, "Encryption")
			Me.tbConfigMethod.DataBindings.Add("Text", Me.BindingSource_0, "ConfigMethods")
			Me.tbWpsPin.DataBindings.Add("Text", Me.BindingSource_0, "PIN")
			Me.tbNetworkKey.DataBindings.Add("Text", Me.BindingSource_0, "Key")
			Me.bnavAp.BindingSource = Me.BindingSource_0
			Me.tbUpload.Enabled = Class13.smethod_16()
			Me.Timer_0.Enabled = Class13.smethod_16()
		End Sub

		' Token: 0x06000155 RID: 341 RVA: 0x00003805 File Offset: 0x00001A05
		Private Sub method_0(sender As Object, e As EventArgs)
			Me.BindingSource_0.Filter = String.Format("BSSID like '%{0}%' or SSID like '%{0}%' or ModelName like '%{0}%'", Me.tbSearch.Text)
		End Sub

		' Token: 0x06000156 RID: 342 RVA: 0x0000692C File Offset: 0x00004B2C
		Private Sub method_1(sender As Object, e As DataGridViewCellEventArgs)
			Try
				Me.sqliteDataAdapter_0.Update(Me.dataTable_0)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000157 RID: 343 RVA: 0x0000696C File Offset: 0x00004B6C
		Private Sub method_2(sender As Object, e As EventArgs)
			If MessageBox.Show("Se van a eliminar los datos seleccionados, ¿desea continuar?", "Confirm Delete!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
				Try
					For Each obj As Object In Me.dgvAp.SelectedRows
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

		' Token: 0x06000158 RID: 344 RVA: 0x00003827 File Offset: 0x00001A27
		Private Sub method_3(sender As Object, e As KeyEventArgs)
			If(If((-If(((e.KeyCode = Keys.Delete) > False), DataGridViewEditMode.EditOnKeystroke, DataGridViewEditMode.EditOnEnter)), DataGridViewEditMode.EditOnKeystroke, DataGridViewEditMode.EditOnEnter) And Not Me.dgvAp.EditMode) > DataGridViewEditMode.EditOnEnter AndAlso Me.dgvAp.SelectedRows.Count > 0 Then
				Me.BindingNavigatorDeleteItem.PerformClick()
			End If
		End Sub

		' Token: 0x06000159 RID: 345 RVA: 0x0000692C File Offset: 0x00004B2C
		Private Sub method_4(sender As Object, e As DataGridViewRowsRemovedEventArgs)
			Try
				Me.sqliteDataAdapter_0.Update(Me.dataTable_0)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600015A RID: 346 RVA: 0x00003867 File Offset: 0x00001A67
		Private Sub method_5(sender As Object, e As DataGridViewDataErrorEventArgs)
			MessageBox.Show(e.Exception.Message, "Wps Pin data base Error", MessageBoxButtons.OK)
			e.Cancel = True
		End Sub

		' Token: 0x0600015B RID: 347 RVA: 0x000069F4 File Offset: 0x00004BF4
		Private Sub method_6(sender As Object, e As DataGridViewCellFormattingEventArgs)
			Dim name As String = CType(sender, DataGridView).Columns(e.ColumnIndex).Name
			If Operators.CompareString(name, "dgvApStatus", False) = 0 Then
				While True
					IL_CE:
					Dim genum As GClass9.GEnum3 = CType(Conversions.ToInteger(e.Value), GClass9.GEnum3)
					While True
						IL_B7:
						Select Case genum
							Case GClass9.GEnum3.Unknow
								GoTo IL_16A
							Case GClass9.GEnum3.Ok
								GoTo IL_177
							Case GClass9.GEnum3.Nok
								GoTo IL_1B4
							Case Else
								Dim num2 As UInteger
								Dim num As Integer = CInt((num2 * 401074821UI Xor 2237776855UI))
								While True
									Dim num3 As Integer = num Xor 1994210728
									num2 = CUInt(num3)
									Select Case num3 Mod 21
										Case 0
											GoTo IL_EA
										Case 1, 4, 18
											GoTo IL_1EF
										Case 2
											GoTo IL_146
										Case 3
											num = CInt((num2 * 2268136565UI Xor 3654789821UI))
											Continue For
										Case 5
											GoTo IL_14E
										Case 6
											GoTo IL_182
										Case 7
											GoTo IL_16A
										Case 8
											Return
										Case 9
											GoTo IL_F8
										Case 10
											GoTo IL_B7
										Case 11
											GoTo IL_106
										Case 13, 16
											GoTo IL_DC
										Case 14
											GoTo IL_177
										Case 15
											Return
										Case 17
											GoTo IL_1BF
										Case 19
											GoTo IL_1B4
										Case 20
											GoTo IL_CE
									End Select
									GoTo Block_2
								End While
						End Select
					End While
				End While
				Block_2:
				Return
				IL_16A:
				e.Value = GClass0.Bitmap_6
				GoTo IL_1EF
				IL_177:
				e.Value = GClass0.Bitmap_15
				IL_182:
				Me.dgvAp.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = Class10.String_12
				GoTo IL_1EF
				IL_1B4:
				e.Value = GClass0.Bitmap_16
				IL_1BF:
				Me.dgvAp.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = Class10.String_11
				IL_1EF:
				e.FormattingApplied = True
				Return
			End If
			IL_DC:
			If Operators.CompareString(name, "dgvApSSID", False) = 0 Then
				GoTo IL_146
			End If
			IL_EA:
			If Operators.CompareString(name, "dgvApKey", False) = 0 Then
				GoTo IL_146
			End If
			IL_F8:
			If Operators.CompareString(name, "dgvApBSSID", False) <> 0 Then
				Return
			End If
			IL_106:
			e.Value = Operators.ConcatenateObject(NewLateBinding.LateGet(e.Value, Nothing, "Substring", New Object() { 0, 9 }, Nothing, Nothing, Nothing), "XX:XX:XX")
			Return
			IL_146:
			If Class13.bool_1 Then
				GoTo IL_14E
			End If
			Return
			IL_14E:
			e.Value = Class13.smethod_13(Conversions.ToString(e.Value), "X")
		End Sub

		' Token: 0x0600015C RID: 348 RVA: 0x00003887 File Offset: 0x00001A87
		Private Sub method_7(sender As Object, e As EventArgs)
			If Class13.bool_1 Then
				Me.tbUUID.Text = Class13.smethod_13(Me.tbUUID.Text, "X")
			End If
		End Sub

		' Token: 0x0600015D RID: 349 RVA: 0x000038B0 File Offset: 0x00001AB0
		Private Sub method_8(sender As Object, e As EventArgs)
			If Class13.bool_1 Then
				Me.tbSerialNumber.Text = Class13.smethod_13(Me.tbSerialNumber.Text, "X")
			End If
		End Sub

		' Token: 0x0600015E RID: 350 RVA: 0x000038D9 File Offset: 0x00001AD9
		Private Sub method_9(sender As Object, e As EventArgs)
			If Class13.bool_1 Then
				Me.tbWpsPin.Text = Class13.smethod_13(Me.tbWpsPin.Text, "X")
			End If
		End Sub

		' Token: 0x0600015F RID: 351 RVA: 0x00003902 File Offset: 0x00001B02
		Private Sub method_10(sender As Object, e As EventArgs)
			If Class13.bool_1 Then
				Me.tbNetworkKey.Text = Class13.smethod_13(Me.tbNetworkKey.Text, "X")
			End If
		End Sub

		' Token: 0x06000160 RID: 352 RVA: 0x0000392B File Offset: 0x00001B2B
		Private Sub method_11(sender As Object, e As EventArgs)
			If Class13.smethod_16() Then
				New GClass1().method_0()
				MessageBox.Show("Gracias, Thanks, merci, спасибо", "Uploaded...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		' Token: 0x06000161 RID: 353 RVA: 0x00006BF8 File Offset: 0x00004DF8
		Private Sub method_12(sender As Object, e As EventArgs)
			If Me.Timer_0.Interval < 4000 Then
				Me.toolTip_1.ToolTipIcon = ToolTipIcon.None
				Me.toolTip_1.IsBalloon = True
				Me.toolTip_1.UseAnimation = True
				Me.toolTip_1.UseFading = True
				Me.toolTip_1.AutomaticDelay = 500
				Me.toolTip_1.Show(Me.tbUpload.ToolTipText, Me, New Point(Me.tbUpload.Bounds.Location.X, Me.tbUpload.Bounds.Location.Y - 7))
				Me.Timer_0.Interval = 4000
				Return
			End If
			Me.toolTip_1.Dispose()
			Me.Timer_0.Enabled = False
		End Sub

		' Token: 0x04000051 RID: 81
		<AccessedThroughProperty("ToolTip1")>
		<CompilerGenerated()>
		Private toolTip_0 As ToolTip

		' Token: 0x04000052 RID: 82
		<CompilerGenerated()>
		<AccessedThroughProperty("TimerToolTip")>
		Private timer_0 As Timer

		' Token: 0x04000053 RID: 83
		Private sqliteConnection_0 As SQLiteConnection

		' Token: 0x04000054 RID: 84
		Private sqliteCommand_0 As SQLiteCommand

		' Token: 0x04000055 RID: 85
		Private sqliteDataAdapter_0 As SQLiteDataAdapter

		' Token: 0x04000056 RID: 86
		Private sqliteCommandBuilder_0 As SQLiteCommandBuilder

		' Token: 0x04000057 RID: 87
		Private dataTable_0 As DataTable

		' Token: 0x04000058 RID: 88
		<CompilerGenerated()>
		<AccessedThroughProperty("bsAp")>
		Private bindingSource_0 As BindingSource

		' Token: 0x04000059 RID: 89
		Private sqliteCommand_1 As SQLiteCommand

		' Token: 0x0400005A RID: 90
		Private sqliteDataAdapter_1 As SQLiteDataAdapter

		' Token: 0x0400005B RID: 91
		Private dataTable_1 As DataTable

		' Token: 0x0400005C RID: 92
		Private toolTip_1 As ToolTip
	End Class
End Namespace
