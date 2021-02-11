Namespace wAirCut
	' Token: 0x02000030 RID: 48
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class RandomPinForm
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000360 RID: 864 RVA: 0x0001429C File Offset: 0x0001249C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.icontainer_0 = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.wAirCut.RandomPinForm))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.ToolStrip1 = New Global.System.Windows.Forms.ToolStrip()
			Me.tsbOpen = New Global.System.Windows.Forms.ToolStripButton()
			Me.tsbSaveMenu = New Global.System.Windows.Forms.ToolStripDropDownButton()
			Me.TsbSave = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.tsbAutoSave = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.TbTime = New Global.System.Windows.Forms.ToolStripTextBox()
			Me.TbStart = New Global.System.Windows.Forms.ToolStripButton()
			Me.TbStop = New Global.System.Windows.Forms.ToolStripButton()
			Me.Timer_0 = New Global.System.Windows.Forms.Timer(Me.icontainer_0)
			Me.DgvInfo = New Global.System.Windows.Forms.DataGridView()
			Me.DgvDataCampo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.DgvDataValor = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.OpenFileDialog_0 = New Global.System.Windows.Forms.OpenFileDialog()
			Me.SaveFileDialog_0 = New Global.System.Windows.Forms.SaveFileDialog()
			Me.lbResult = New Global.System.Windows.Forms.Label()
			Me.tsFormatMenu = New Global.System.Windows.Forms.ToolStrip()
			Me.ToolStripLabel1 = New Global.System.Windows.Forms.ToolStripLabel()
			Me.tbPinFormat1 = New Global.System.Windows.Forms.ToolStripTextBox()
			Me.tbPinFormat2 = New Global.System.Windows.Forms.ToolStripTextBox()
			Me.tsbCalculate = New Global.System.Windows.Forms.ToolStripButton()
			Me.ProgressBar1 = New Global.Class12()
			Me.ToolStrip1.SuspendLayout()
			CType(Me.DgvInfo, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tsFormatMenu.SuspendLayout()
			MyBase.SuspendLayout()
			Me.ToolStrip1.GripStyle = Global.System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.ToolStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.tsbOpen, Me.tsbSaveMenu, Me.ToolStripSeparator1, Me.TbTime, Me.TbStart, Me.TbStop })
			componentResourceManager.ApplyResources(Me.ToolStrip1, "ToolStrip1")
			Me.ToolStrip1.Name = "ToolStrip1"
			Me.tsbOpen.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.tsbOpen.Image = Global.GClass0.Bitmap_39
			componentResourceManager.ApplyResources(Me.tsbOpen, "tsbOpen")
			Me.tsbOpen.Name = "tsbOpen"
			Me.tsbSaveMenu.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.tsbSaveMenu.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.TsbSave, Me.tsbAutoSave })
			Me.tsbSaveMenu.Image = Global.GClass0.Bitmap_49
			componentResourceManager.ApplyResources(Me.tsbSaveMenu, "tsbSaveMenu")
			Me.tsbSaveMenu.Name = "tsbSaveMenu"
			Me.TsbSave.Image = Global.GClass0.Bitmap_49
			Me.TsbSave.Name = "TsbSave"
			componentResourceManager.ApplyResources(Me.TsbSave, "TsbSave")
			Me.tsbAutoSave.Checked = True
			Me.tsbAutoSave.CheckOnClick = True
			Me.tsbAutoSave.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.tsbAutoSave.Name = "tsbAutoSave"
			componentResourceManager.ApplyResources(Me.tsbAutoSave, "tsbAutoSave")
			Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
			componentResourceManager.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
			Me.TbTime.Name = "TbTime"
			componentResourceManager.ApplyResources(Me.TbTime, "TbTime")
			Me.TbStart.Image = Global.GClass0.Bitmap_40
			componentResourceManager.ApplyResources(Me.TbStart, "TbStart")
			Me.TbStart.Name = "TbStart"
			componentResourceManager.ApplyResources(Me.TbStop, "TbStop")
			Me.TbStop.Image = Global.GClass0.Bitmap_51
			Me.TbStop.Name = "TbStop"
			Me.Timer_0.Interval = 1000
			Me.DgvInfo.AllowUserToAddRows = False
			Me.DgvInfo.AllowUserToDeleteRows = False
			Me.DgvInfo.AllowUserToResizeColumns = False
			Me.DgvInfo.AllowUserToResizeRows = False
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.LemonChiffon
			Me.DgvInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.DgvInfo.BackgroundColor = Global.System.Drawing.SystemColors.Info
			Me.DgvInfo.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.DgvInfo.ColumnHeadersVisible = False
			Me.DgvInfo.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.DgvDataCampo, Me.DgvDataValor })
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.LightGoldenrodYellow
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.DgvInfo.DefaultCellStyle = dataGridViewCellStyle2
			componentResourceManager.ApplyResources(Me.DgvInfo, "DgvInfo")
			Me.DgvInfo.MultiSelect = False
			Me.DgvInfo.Name = "DgvInfo"
			Me.DgvInfo.[ReadOnly] = True
			Me.DgvInfo.RowHeadersVisible = False
			Me.DgvInfo.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.DgvInfo.ShowCellErrors = False
			Me.DgvInfo.StandardTab = True
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.DgvDataCampo.DefaultCellStyle = dataGridViewCellStyle3
			componentResourceManager.ApplyResources(Me.DgvDataCampo, "DgvDataCampo")
			Me.DgvDataCampo.Name = "DgvDataCampo"
			Me.DgvDataCampo.[ReadOnly] = True
			Me.DgvDataValor.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
			componentResourceManager.ApplyResources(Me.DgvDataValor, "DgvDataValor")
			Me.DgvDataValor.Name = "DgvDataValor"
			Me.DgvDataValor.[ReadOnly] = True
			Me.OpenFileDialog_0.DefaultExt = "log"
			Me.OpenFileDialog_0.FileName = "OpenFileDialog1"
			componentResourceManager.ApplyResources(Me.OpenFileDialog_0, "OpenFileDialog1")
			Me.OpenFileDialog_0.InitialDirectory = "Log"
			Me.SaveFileDialog_0.DefaultExt = "log"
			componentResourceManager.ApplyResources(Me.SaveFileDialog_0, "SaveFileDialog1")
			Me.SaveFileDialog_0.InitialDirectory = "Log"
			Me.lbResult.BackColor = Global.System.Drawing.Color.Red
			componentResourceManager.ApplyResources(Me.lbResult, "lbResult")
			Me.lbResult.ForeColor = Global.System.Drawing.Color.White
			Me.lbResult.Name = "lbResult"
			Me.tsFormatMenu.GripStyle = Global.System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.tsFormatMenu.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ToolStripLabel1, Me.tbPinFormat1, Me.tbPinFormat2, Me.tsbCalculate })
			componentResourceManager.ApplyResources(Me.tsFormatMenu, "tsFormatMenu")
			Me.tsFormatMenu.Name = "tsFormatMenu"
			Me.ToolStripLabel1.Name = "ToolStripLabel1"
			componentResourceManager.ApplyResources(Me.ToolStripLabel1, "ToolStripLabel1")
			componentResourceManager.ApplyResources(Me.tbPinFormat1, "tbPinFormat1")
			Me.tbPinFormat1.ForeColor = Global.System.Drawing.Color.DarkGreen
			Me.tbPinFormat1.Name = "tbPinFormat1"
			Me.tbPinFormat1.Tag = ""
			componentResourceManager.ApplyResources(Me.tbPinFormat2, "tbPinFormat2")
			Me.tbPinFormat2.ForeColor = Global.System.Drawing.Color.DarkGreen
			Me.tbPinFormat2.Name = "tbPinFormat2"
			Me.tsbCalculate.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.tsbCalculate.Image = Global.GClass0.Bitmap_9
			componentResourceManager.ApplyResources(Me.tsbCalculate, "tsbCalculate")
			Me.tsbCalculate.Name = "tsbCalculate"
			Me.ProgressBar1.Color_0 = Global.System.Drawing.Color.Red
			componentResourceManager.ApplyResources(Me.ProgressBar1, "ProgressBar1")
			Me.ProgressBar1.ForeColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			Me.ProgressBar1.Name = "ProgressBar1"
			Me.ProgressBar1.Style = Global.System.Windows.Forms.ProgressBarStyle.Continuous
			componentResourceManager.ApplyResources(Me, "$this")
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.Controls.Add(Me.lbResult)
			MyBase.Controls.Add(Me.DgvInfo)
			MyBase.Controls.Add(Me.ProgressBar1)
			MyBase.Controls.Add(Me.tsFormatMenu)
			MyBase.Controls.Add(Me.ToolStrip1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "RandomPinForm"
			MyBase.ShowIcon = False
			Me.ToolStrip1.ResumeLayout(False)
			Me.ToolStrip1.PerformLayout()
			CType(Me.DgvInfo, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.tsFormatMenu.ResumeLayout(False)
			Me.tsFormatMenu.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000177 RID: 375
		Private icontainer_0 As Global.System.ComponentModel.IContainer
	End Class
End Namespace
