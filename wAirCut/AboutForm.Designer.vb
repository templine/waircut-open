Namespace wAirCut
	' Token: 0x0200000C RID: 12
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class AboutForm
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060000D4 RID: 212 RVA: 0x00004DE4 File Offset: 0x00002FE4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.wAirCut.AboutForm))
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.StatusStrip1 = New Global.System.Windows.Forms.StatusStrip()
			Me.lbVersion = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.PictureBox2 = New Global.System.Windows.Forms.PictureBox()
			Me.btDonate = New Global.System.Windows.Forms.Button()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.ScrollLabel1 = New Global.GClass14()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.StatusStrip1.SuspendLayout()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			MyBase.SuspendLayout()
			componentResourceManager.ApplyResources(Me.Label1, "Label1")
			Me.Label1.ForeColor = Global.System.Drawing.Color.DarkBlue
			Me.Label1.Name = "Label1"
			componentResourceManager.ApplyResources(Me.StatusStrip1, "StatusStrip1")
			Me.StatusStrip1.BackColor = Global.System.Drawing.Color.White
			Me.StatusStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.lbVersion })
			Me.StatusStrip1.Name = "StatusStrip1"
			Me.StatusStrip1.SizingGrip = False
			componentResourceManager.ApplyResources(Me.lbVersion, "lbVersion")
			Me.lbVersion.Name = "lbVersion"
			componentResourceManager.ApplyResources(Me.PictureBox2, "PictureBox2")
			Me.PictureBox2.BackColor = Global.System.Drawing.Color.White
			Me.PictureBox2.Image = Global.GClass0.Bitmap_7
			Me.PictureBox2.Name = "PictureBox2"
			Me.PictureBox2.TabStop = False
			componentResourceManager.ApplyResources(Me.btDonate, "btDonate")
			Me.btDonate.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.btDonate.Image = Global.GClass0.Bitmap_43
			Me.btDonate.Name = "btDonate"
			Me.btDonate.UseVisualStyleBackColor = True
			componentResourceManager.ApplyResources(Me.PictureBox1, "PictureBox1")
			Me.PictureBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox1.Image = Global.GClass0.Bitmap_54
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.TabStop = False
			componentResourceManager.ApplyResources(Me.ScrollLabel1, "ScrollLabel1")
			Me.ScrollLabel1.Int32_0 = 60
			Me.ScrollLabel1.Name = "ScrollLabel1"
			Me.ScrollLabel1.GEnum7_0 = Global.GClass14.GEnum7.vertical
			componentResourceManager.ApplyResources(Me.Panel1, "Panel1")
			Me.Panel1.BackColor = Global.System.Drawing.SystemColors.Window
			Me.Panel1.Controls.Add(Me.PictureBox1)
			Me.Panel1.Controls.Add(Me.btDonate)
			Me.Panel1.Name = "Panel1"
			componentResourceManager.ApplyResources(Me, "$this")
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.Controls.Add(Me.Panel1)
			MyBase.Controls.Add(Me.ScrollLabel1)
			MyBase.Controls.Add(Me.PictureBox2)
			MyBase.Controls.Add(Me.StatusStrip1)
			MyBase.Controls.Add(Me.Label1)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "AboutForm"
			MyBase.ShowIcon = False
			Me.StatusStrip1.ResumeLayout(False)
			Me.StatusStrip1.PerformLayout()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub
	End Class
End Namespace
