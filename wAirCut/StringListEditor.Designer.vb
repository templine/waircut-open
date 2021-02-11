Namespace wAirCut
	' Token: 0x02000038 RID: 56
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class StringListEditor
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060003CA RID: 970 RVA: 0x00017170 File Offset: 0x00015370
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.wAirCut.StringListEditor))
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.ToolStrip1 = New Global.System.Windows.Forms.ToolStrip()
			Me.tsbAcept = New Global.System.Windows.Forms.ToolStripButton()
			Me.tsbCancel = New Global.System.Windows.Forms.ToolStripButton()
			Me.ToolStrip1.SuspendLayout()
			MyBase.SuspendLayout()
			componentResourceManager.ApplyResources(Me.TextBox1, "TextBox1")
			Me.TextBox1.Name = "TextBox1"
			componentResourceManager.ApplyResources(Me.ToolStrip1, "ToolStrip1")
			Me.ToolStrip1.GripStyle = Global.System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.ToolStrip1.ImageScalingSize = New Global.System.Drawing.Size(32, 32)
			Me.ToolStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.tsbAcept, Me.tsbCancel })
			Me.ToolStrip1.Name = "ToolStrip1"
			componentResourceManager.ApplyResources(Me.tsbAcept, "tsbAcept")
			Me.tsbAcept.Image = Global.GClass0.Bitmap_1
			Me.tsbAcept.Name = "tsbAcept"
			componentResourceManager.ApplyResources(Me.tsbCancel, "tsbCancel")
			Me.tsbCancel.Alignment = Global.System.Windows.Forms.ToolStripItemAlignment.Right
			Me.tsbCancel.Image = Global.GClass0.Bitmap_13
			Me.tsbCancel.Name = "tsbCancel"
			componentResourceManager.ApplyResources(Me, "$this")
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.Controls.Add(Me.TextBox1)
			MyBase.Controls.Add(Me.ToolStrip1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "StringListEditor"
			MyBase.ShowIcon = False
			Me.ToolStrip1.ResumeLayout(False)
			Me.ToolStrip1.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub
	End Class
End Namespace
