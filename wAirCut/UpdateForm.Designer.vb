Namespace wAirCut
	' Token: 0x02000039 RID: 57
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class UpdateForm
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060003D9 RID: 985 RVA: 0x00017480 File Offset: 0x00015680
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.wAirCut.UpdateForm))
			Me.lbTitle = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.lbVersion = New Global.System.Windows.Forms.Label()
			Me.lbLastVersion = New Global.System.Windows.Forms.Label()
			Me.btDonate = New Global.System.Windows.Forms.Button()
			Me.btDownload = New Global.System.Windows.Forms.Button()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.ScrollLabel1 = New Global.GClass14()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel2.SuspendLayout()
			MyBase.SuspendLayout()
			componentResourceManager.ApplyResources(Me.lbTitle, "lbTitle")
			Me.lbTitle.ForeColor = Global.System.Drawing.Color.ForestGreen
			Me.lbTitle.Name = "lbTitle"
			componentResourceManager.ApplyResources(Me.Label1, "Label1")
			Me.Label1.Name = "Label1"
			componentResourceManager.ApplyResources(Me.Label2, "Label2")
			Me.Label2.Name = "Label2"
			componentResourceManager.ApplyResources(Me.lbVersion, "lbVersion")
			Me.lbVersion.ForeColor = Global.System.Drawing.Color.Red
			Me.lbVersion.Name = "lbVersion"
			componentResourceManager.ApplyResources(Me.lbLastVersion, "lbLastVersion")
			Me.lbLastVersion.ForeColor = Global.System.Drawing.Color.Green
			Me.lbLastVersion.Name = "lbLastVersion"
			componentResourceManager.ApplyResources(Me.btDonate, "btDonate")
			Me.btDonate.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.btDonate.Image = Global.GClass0.Bitmap_43
			Me.btDonate.Name = "btDonate"
			Me.btDonate.UseVisualStyleBackColor = True
			componentResourceManager.ApplyResources(Me.btDownload, "btDownload")
			Me.btDownload.Image = Global.GClass0.Bitmap_14
			Me.btDownload.Name = "btDownload"
			Me.btDownload.UseVisualStyleBackColor = True
			componentResourceManager.ApplyResources(Me.PictureBox1, "PictureBox1")
			Me.PictureBox1.Image = Global.GClass0.Bitmap_54
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.TabStop = False
			componentResourceManager.ApplyResources(Me.Panel2, "Panel2")
			Me.Panel2.BackColor = Global.System.Drawing.SystemColors.Window
			Me.Panel2.Controls.Add(Me.btDonate)
			Me.Panel2.Controls.Add(Me.PictureBox1)
			Me.Panel2.Controls.Add(Me.Label2)
			Me.Panel2.Controls.Add(Me.lbLastVersion)
			Me.Panel2.Controls.Add(Me.Label1)
			Me.Panel2.Controls.Add(Me.lbVersion)
			Me.Panel2.Name = "Panel2"
			componentResourceManager.ApplyResources(Me.ScrollLabel1, "ScrollLabel1")
			Me.ScrollLabel1.Int32_0 = 60
			Me.ScrollLabel1.Name = "ScrollLabel1"
			Me.ScrollLabel1.GEnum7_0 = Global.GClass14.GEnum7.vertical
			componentResourceManager.ApplyResources(Me, "$this")
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.Controls.Add(Me.ScrollLabel1)
			MyBase.Controls.Add(Me.Panel2)
			MyBase.Controls.Add(Me.btDownload)
			MyBase.Controls.Add(Me.lbTitle)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "UpdateForm"
			MyBase.ShowIcon = False
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel2.ResumeLayout(False)
			Me.Panel2.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub
	End Class
End Namespace
