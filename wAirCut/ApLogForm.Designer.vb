Namespace wAirCut
	' Token: 0x0200000D RID: 13
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class ApLogForm
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060000E9 RID: 233 RVA: 0x000052E4 File Offset: 0x000034E4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.icontainer_0 = New Global.System.ComponentModel.Container()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.wAirCut.ApLogForm))
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.dgvAp = New Global.System.Windows.Forms.DataGridView()
			Me.dgvApStatus = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.dgvApBssid = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.dgvApSSID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.dgvApPin = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.dgvApKey = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.bnavAp = New Global.System.Windows.Forms.BindingNavigator(Me.icontainer_0)
			Me.BindingNavigatorAddNewItem = New Global.System.Windows.Forms.ToolStripButton()
			Me.BindingNavigatorCountItem = New Global.System.Windows.Forms.ToolStripLabel()
			Me.tbImport = New Global.System.Windows.Forms.ToolStripButton()
			Me.tbExport = New Global.System.Windows.Forms.ToolStripButton()
			Me.BindingNavigatorMoveFirstItem = New Global.System.Windows.Forms.ToolStripButton()
			Me.BindingNavigatorMovePreviousItem = New Global.System.Windows.Forms.ToolStripButton()
			Me.BindingNavigatorSeparator = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.BindingNavigatorPositionItem = New Global.System.Windows.Forms.ToolStripTextBox()
			Me.BindingNavigatorSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.BindingNavigatorMoveNextItem = New Global.System.Windows.Forms.ToolStripButton()
			Me.BindingNavigatorMoveLastItem = New Global.System.Windows.Forms.ToolStripButton()
			Me.BindingNavigatorSeparator2 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.BindingNavigatorDeleteItem = New Global.System.Windows.Forms.ToolStripButton()
			Me.ToolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.ToolStripLabel1 = New Global.System.Windows.Forms.ToolStripLabel()
			Me.tbSearch = New Global.System.Windows.Forms.ToolStripTextBox()
			Me.tbUpload = New Global.System.Windows.Forms.ToolStripButton()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.tbNetworkKey = New Global.System.Windows.Forms.TextBox()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.tbWpsPin = New Global.System.Windows.Forms.TextBox()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.tbConfigMethod = New Global.System.Windows.Forms.TextBox()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.tbEncryption = New Global.System.Windows.Forms.TextBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.tbVersion = New Global.System.Windows.Forms.TextBox()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.tbUUID = New Global.System.Windows.Forms.TextBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.tbRfBand = New Global.System.Windows.Forms.TextBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.tbSerialNumber = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.tbManufacturer = New Global.System.Windows.Forms.TextBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.tbModelNumber = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.tbModelName = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.tbDeviceName = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.ToolTip_0 = New Global.System.Windows.Forms.ToolTip(Me.icontainer_0)
			Me.Timer_0 = New Global.System.Windows.Forms.Timer(Me.icontainer_0)
			CType(Me.dgvAp, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bnavAp, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.bnavAp.SuspendLayout()
			Me.Panel1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.dgvAp.AllowUserToAddRows = False
			Me.dgvAp.AllowUserToDeleteRows = False
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.Azure
			Me.dgvAp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.dgvAp.ClipboardCopyMode = Global.System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
			Me.dgvAp.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvAp.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.dgvApStatus, Me.dgvApBssid, Me.dgvApSSID, Me.dgvApPin, Me.dgvApKey })
			componentResourceManager.ApplyResources(Me.dgvAp, "dgvAp")
			Me.dgvAp.Name = "dgvAp"
			Me.dgvAp.[ReadOnly] = True
			Me.dgvAp.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.dgvApStatus.DataPropertyName = "Status"
			Me.dgvApStatus.FillWeight = 80F
			componentResourceManager.ApplyResources(Me.dgvApStatus, "dgvApStatus")
			Me.dgvApStatus.Name = "dgvApStatus"
			Me.dgvApStatus.[ReadOnly] = True
			Me.dgvApBssid.DataPropertyName = "BSSID"
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Lucida Console", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvApBssid.DefaultCellStyle = dataGridViewCellStyle2
			Me.dgvApBssid.FillWeight = 150F
			componentResourceManager.ApplyResources(Me.dgvApBssid, "dgvApBssid")
			Me.dgvApBssid.Name = "dgvApBssid"
			Me.dgvApBssid.[ReadOnly] = True
			Me.dgvApSSID.DataPropertyName = "SSID"
			Me.dgvApSSID.FillWeight = 200F
			componentResourceManager.ApplyResources(Me.dgvApSSID, "dgvApSSID")
			Me.dgvApSSID.Name = "dgvApSSID"
			Me.dgvApSSID.[ReadOnly] = True
			Me.dgvApPin.DataPropertyName = "PIN"
			Me.dgvApPin.FillWeight = 150F
			componentResourceManager.ApplyResources(Me.dgvApPin, "dgvApPin")
			Me.dgvApPin.Name = "dgvApPin"
			Me.dgvApPin.[ReadOnly] = True
			Me.dgvApKey.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
			Me.dgvApKey.DataPropertyName = "Key"
			Me.dgvApKey.FillWeight = 200F
			componentResourceManager.ApplyResources(Me.dgvApKey, "dgvApKey")
			Me.dgvApKey.Name = "dgvApKey"
			Me.dgvApKey.[ReadOnly] = True
			Me.bnavAp.AddNewItem = Me.BindingNavigatorAddNewItem
			Me.bnavAp.CountItem = Me.BindingNavigatorCountItem
			Me.bnavAp.CountItemFormat = "of {0}"
			Me.bnavAp.DeleteItem = Nothing
			Me.bnavAp.GripStyle = Global.System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.bnavAp.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.tbImport, Me.tbExport, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.tbSearch, Me.tbUpload })
			componentResourceManager.ApplyResources(Me.bnavAp, "bnavAp")
			Me.bnavAp.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
			Me.bnavAp.MoveLastItem = Me.BindingNavigatorMoveLastItem
			Me.bnavAp.MoveNextItem = Me.BindingNavigatorMoveNextItem
			Me.bnavAp.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
			Me.bnavAp.Name = "bnavAp"
			Me.bnavAp.PositionItem = Me.BindingNavigatorPositionItem
			Me.BindingNavigatorAddNewItem.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.BindingNavigatorAddNewItem.Image = Global.GClass0.Bitmap_2
			Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
			componentResourceManager.ApplyResources(Me.BindingNavigatorAddNewItem, "BindingNavigatorAddNewItem")
			componentResourceManager.ApplyResources(Me.BindingNavigatorCountItem, "BindingNavigatorCountItem")
			Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
			Me.tbImport.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			componentResourceManager.ApplyResources(Me.tbImport, "tbImport")
			Me.tbImport.Name = "tbImport"
			Me.tbExport.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			componentResourceManager.ApplyResources(Me.tbExport, "tbExport")
			Me.tbExport.Name = "tbExport"
			Me.BindingNavigatorMoveFirstItem.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.BindingNavigatorMoveFirstItem.Image = Global.GClass0.Bitmap_17
			Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
			componentResourceManager.ApplyResources(Me.BindingNavigatorMoveFirstItem, "BindingNavigatorMoveFirstItem")
			Me.BindingNavigatorMovePreviousItem.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.BindingNavigatorMovePreviousItem.Image = Global.GClass0.Bitmap_37
			Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
			componentResourceManager.ApplyResources(Me.BindingNavigatorMovePreviousItem, "BindingNavigatorMovePreviousItem")
			Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
			componentResourceManager.ApplyResources(Me.BindingNavigatorSeparator, "BindingNavigatorSeparator")
			componentResourceManager.ApplyResources(Me.BindingNavigatorPositionItem, "BindingNavigatorPositionItem")
			Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
			Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
			componentResourceManager.ApplyResources(Me.BindingNavigatorSeparator1, "BindingNavigatorSeparator1")
			Me.BindingNavigatorMoveNextItem.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.BindingNavigatorMoveNextItem.Image = Global.GClass0.Bitmap_38
			Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
			componentResourceManager.ApplyResources(Me.BindingNavigatorMoveNextItem, "BindingNavigatorMoveNextItem")
			Me.BindingNavigatorMoveLastItem.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.BindingNavigatorMoveLastItem.Image = Global.GClass0.Bitmap_18
			Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
			componentResourceManager.ApplyResources(Me.BindingNavigatorMoveLastItem, "BindingNavigatorMoveLastItem")
			Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
			componentResourceManager.ApplyResources(Me.BindingNavigatorSeparator2, "BindingNavigatorSeparator2")
			Me.BindingNavigatorDeleteItem.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.BindingNavigatorDeleteItem.Image = Global.GClass0.Bitmap_13
			Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
			componentResourceManager.ApplyResources(Me.BindingNavigatorDeleteItem, "BindingNavigatorDeleteItem")
			Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
			componentResourceManager.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
			Me.ToolStripLabel1.Image = Global.GClass0.Bitmap_36
			Me.ToolStripLabel1.Name = "ToolStripLabel1"
			componentResourceManager.ApplyResources(Me.ToolStripLabel1, "ToolStripLabel1")
			Me.tbSearch.BackColor = Global.System.Drawing.SystemColors.Info
			Me.tbSearch.Name = "tbSearch"
			componentResourceManager.ApplyResources(Me.tbSearch, "tbSearch")
			Me.tbUpload.Alignment = Global.System.Windows.Forms.ToolStripItemAlignment.Right
			Me.tbUpload.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.tbUpload.Image = Global.GClass0.Bitmap_53
			componentResourceManager.ApplyResources(Me.tbUpload, "tbUpload")
			Me.tbUpload.Name = "tbUpload"
			Me.Panel1.BackColor = Global.System.Drawing.SystemColors.ActiveCaption
			Me.Panel1.Controls.Add(Me.tbNetworkKey)
			Me.Panel1.Controls.Add(Me.Label12)
			Me.Panel1.Controls.Add(Me.tbWpsPin)
			Me.Panel1.Controls.Add(Me.Label13)
			Me.Panel1.Controls.Add(Me.Label11)
			Me.Panel1.Controls.Add(Me.tbConfigMethod)
			Me.Panel1.Controls.Add(Me.Label10)
			Me.Panel1.Controls.Add(Me.tbEncryption)
			Me.Panel1.Controls.Add(Me.Label9)
			Me.Panel1.Controls.Add(Me.tbVersion)
			Me.Panel1.Controls.Add(Me.Label8)
			Me.Panel1.Controls.Add(Me.tbUUID)
			Me.Panel1.Controls.Add(Me.Label7)
			Me.Panel1.Controls.Add(Me.tbRfBand)
			Me.Panel1.Controls.Add(Me.Label6)
			Me.Panel1.Controls.Add(Me.tbSerialNumber)
			Me.Panel1.Controls.Add(Me.Label5)
			Me.Panel1.Controls.Add(Me.tbManufacturer)
			Me.Panel1.Controls.Add(Me.Label4)
			Me.Panel1.Controls.Add(Me.tbModelNumber)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.tbModelName)
			Me.Panel1.Controls.Add(Me.Label2)
			Me.Panel1.Controls.Add(Me.tbDeviceName)
			Me.Panel1.Controls.Add(Me.Label1)
			componentResourceManager.ApplyResources(Me.Panel1, "Panel1")
			Me.Panel1.Name = "Panel1"
			componentResourceManager.ApplyResources(Me.tbNetworkKey, "tbNetworkKey")
			Me.tbNetworkKey.Name = "tbNetworkKey"
			Me.tbNetworkKey.[ReadOnly] = True
			componentResourceManager.ApplyResources(Me.Label12, "Label12")
			Me.Label12.Name = "Label12"
			componentResourceManager.ApplyResources(Me.tbWpsPin, "tbWpsPin")
			Me.tbWpsPin.Name = "tbWpsPin"
			Me.tbWpsPin.[ReadOnly] = True
			componentResourceManager.ApplyResources(Me.Label13, "Label13")
			Me.Label13.Name = "Label13"
			componentResourceManager.ApplyResources(Me.Label11, "Label11")
			Me.Label11.Name = "Label11"
			componentResourceManager.ApplyResources(Me.tbConfigMethod, "tbConfigMethod")
			Me.tbConfigMethod.Name = "tbConfigMethod"
			Me.tbConfigMethod.[ReadOnly] = True
			componentResourceManager.ApplyResources(Me.Label10, "Label10")
			Me.Label10.Name = "Label10"
			componentResourceManager.ApplyResources(Me.tbEncryption, "tbEncryption")
			Me.tbEncryption.Name = "tbEncryption"
			Me.tbEncryption.[ReadOnly] = True
			componentResourceManager.ApplyResources(Me.Label9, "Label9")
			Me.Label9.Name = "Label9"
			componentResourceManager.ApplyResources(Me.tbVersion, "tbVersion")
			Me.tbVersion.Name = "tbVersion"
			Me.tbVersion.[ReadOnly] = True
			componentResourceManager.ApplyResources(Me.Label8, "Label8")
			Me.Label8.Name = "Label8"
			componentResourceManager.ApplyResources(Me.tbUUID, "tbUUID")
			Me.tbUUID.Name = "tbUUID"
			Me.tbUUID.[ReadOnly] = True
			componentResourceManager.ApplyResources(Me.Label7, "Label7")
			Me.Label7.Name = "Label7"
			componentResourceManager.ApplyResources(Me.tbRfBand, "tbRfBand")
			Me.tbRfBand.Name = "tbRfBand"
			Me.tbRfBand.[ReadOnly] = True
			componentResourceManager.ApplyResources(Me.Label6, "Label6")
			Me.Label6.Name = "Label6"
			componentResourceManager.ApplyResources(Me.tbSerialNumber, "tbSerialNumber")
			Me.tbSerialNumber.Name = "tbSerialNumber"
			Me.tbSerialNumber.[ReadOnly] = True
			componentResourceManager.ApplyResources(Me.Label5, "Label5")
			Me.Label5.Name = "Label5"
			componentResourceManager.ApplyResources(Me.tbManufacturer, "tbManufacturer")
			Me.tbManufacturer.Name = "tbManufacturer"
			Me.tbManufacturer.[ReadOnly] = True
			componentResourceManager.ApplyResources(Me.Label4, "Label4")
			Me.Label4.Name = "Label4"
			componentResourceManager.ApplyResources(Me.tbModelNumber, "tbModelNumber")
			Me.tbModelNumber.Name = "tbModelNumber"
			Me.tbModelNumber.[ReadOnly] = True
			componentResourceManager.ApplyResources(Me.Label3, "Label3")
			Me.Label3.Name = "Label3"
			componentResourceManager.ApplyResources(Me.tbModelName, "tbModelName")
			Me.tbModelName.Name = "tbModelName"
			Me.tbModelName.[ReadOnly] = True
			componentResourceManager.ApplyResources(Me.Label2, "Label2")
			Me.Label2.Name = "Label2"
			componentResourceManager.ApplyResources(Me.tbDeviceName, "tbDeviceName")
			Me.tbDeviceName.Name = "tbDeviceName"
			Me.tbDeviceName.[ReadOnly] = True
			componentResourceManager.ApplyResources(Me.Label1, "Label1")
			Me.Label1.Name = "Label1"
			Me.ToolTip_0.IsBalloon = True
			Me.ToolTip_0.ToolTipIcon = Global.System.Windows.Forms.ToolTipIcon.Info
			Me.Timer_0.Interval = 1000
			componentResourceManager.ApplyResources(Me, "$this")
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.Controls.Add(Me.Panel1)
			MyBase.Controls.Add(Me.dgvAp)
			MyBase.Controls.Add(Me.bnavAp)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "ApLogForm"
			CType(Me.dgvAp, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bnavAp, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.bnavAp.ResumeLayout(False)
			Me.bnavAp.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400001E RID: 30
		Private icontainer_0 As Global.System.ComponentModel.IContainer
	End Class
End Namespace
