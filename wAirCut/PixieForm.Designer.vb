Namespace wAirCut
	' Token: 0x0200002C RID: 44
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class PixieForm
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000317 RID: 791 RVA: 0x00012C1C File Offset: 0x00010E1C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.wAirCut.PixieForm))
			Me.cbMode = New Global.System.Windows.Forms.ComboBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.dtpStart = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.dtpEnd = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.cbxForce = New Global.System.Windows.Forms.CheckBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.cbxRNonce = New Global.System.Windows.Forms.CheckBox()
			Me.cbxEBssid = New Global.System.Windows.Forms.CheckBox()
			Me.ToolStrip1 = New Global.System.Windows.Forms.ToolStrip()
			Me.btExcute = New Global.System.Windows.Forms.ToolStripButton()
			Me.btRetry = New Global.System.Windows.Forms.ToolStripButton()
			Me.btStop = New Global.System.Windows.Forms.ToolStripButton()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.cbxLength = New Global.System.Windows.Forms.CheckBox()
			Me.ToolStrip1.SuspendLayout()
			Me.Panel1.SuspendLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.cbMode.FormattingEnabled = True
			Me.cbMode.Items.AddRange(New Object() { componentResourceManager.GetString("cbMode.Items"), componentResourceManager.GetString("cbMode.Items1"), componentResourceManager.GetString("cbMode.Items2"), componentResourceManager.GetString("cbMode.Items3"), componentResourceManager.GetString("cbMode.Items4"), componentResourceManager.GetString("cbMode.Items5") })
			componentResourceManager.ApplyResources(Me.cbMode, "cbMode")
			Me.cbMode.Name = "cbMode"
			componentResourceManager.ApplyResources(Me.Label1, "Label1")
			Me.Label1.Name = "Label1"
			componentResourceManager.ApplyResources(Me.dtpStart, "dtpStart")
			Me.dtpStart.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpStart.Name = "dtpStart"
			Me.dtpStart.ShowUpDown = True
			componentResourceManager.ApplyResources(Me.Label2, "Label2")
			Me.Label2.Name = "Label2"
			componentResourceManager.ApplyResources(Me.dtpEnd, "dtpEnd")
			Me.dtpEnd.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpEnd.Name = "dtpEnd"
			Me.dtpEnd.ShowUpDown = True
			componentResourceManager.ApplyResources(Me.Label3, "Label3")
			Me.Label3.Name = "Label3"
			componentResourceManager.ApplyResources(Me.cbxForce, "cbxForce")
			Me.cbxForce.Name = "cbxForce"
			Me.cbxForce.UseVisualStyleBackColor = True
			componentResourceManager.ApplyResources(Me.Label4, "Label4")
			Me.Label4.Name = "Label4"
			componentResourceManager.ApplyResources(Me.cbxRNonce, "cbxRNonce")
			Me.cbxRNonce.Name = "cbxRNonce"
			Me.cbxRNonce.UseVisualStyleBackColor = True
			componentResourceManager.ApplyResources(Me.cbxEBssid, "cbxEBssid")
			Me.cbxEBssid.Name = "cbxEBssid"
			Me.cbxEBssid.UseVisualStyleBackColor = True
			componentResourceManager.ApplyResources(Me.ToolStrip1, "ToolStrip1")
			Me.ToolStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.btExcute, Me.btRetry, Me.btStop })
			Me.ToolStrip1.Name = "ToolStrip1"
			Me.btExcute.Image = Global.GClass0.Bitmap_56
			componentResourceManager.ApplyResources(Me.btExcute, "btExcute")
			Me.btExcute.Name = "btExcute"
			componentResourceManager.ApplyResources(Me.btRetry, "btRetry")
			Me.btRetry.Image = Global.GClass0.Bitmap_40
			Me.btRetry.Name = "btRetry"
			Me.btStop.Alignment = Global.System.Windows.Forms.ToolStripItemAlignment.Right
			componentResourceManager.ApplyResources(Me.btStop, "btStop")
			Me.btStop.Image = Global.GClass0.Bitmap_51
			Me.btStop.Name = "btStop"
			Me.Panel1.BackColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			Me.Panel1.Controls.Add(Me.PictureBox1)
			Me.Panel1.Controls.Add(Me.Label5)
			componentResourceManager.ApplyResources(Me.Panel1, "Panel1")
			Me.Panel1.Name = "Panel1"
			Me.PictureBox1.Image = Global.GClass0.Bitmap_57
			componentResourceManager.ApplyResources(Me.PictureBox1, "PictureBox1")
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.TabStop = False
			componentResourceManager.ApplyResources(Me.Label5, "Label5")
			Me.Label5.Name = "Label5"
			componentResourceManager.ApplyResources(Me.cbxLength, "cbxLength")
			Me.cbxLength.Name = "cbxLength"
			Me.cbxLength.UseVisualStyleBackColor = True
			componentResourceManager.ApplyResources(Me, "$this")
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.Controls.Add(Me.cbxLength)
			MyBase.Controls.Add(Me.ToolStrip1)
			MyBase.Controls.Add(Me.cbxEBssid)
			MyBase.Controls.Add(Me.cbxRNonce)
			MyBase.Controls.Add(Me.Label4)
			MyBase.Controls.Add(Me.cbxForce)
			MyBase.Controls.Add(Me.Label3)
			MyBase.Controls.Add(Me.dtpEnd)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.dtpStart)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.cbMode)
			MyBase.Controls.Add(Me.Panel1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "PixieForm"
			Me.ToolStrip1.ResumeLayout(False)
			Me.ToolStrip1.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub
	End Class
End Namespace
