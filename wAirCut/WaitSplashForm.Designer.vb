Namespace wAirCut
	' Token: 0x0200003B RID: 59
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class WaitSplashForm
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000405 RID: 1029 RVA: 0x0001834C File Offset: 0x0001654C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.ProgressBar = New Global.System.Windows.Forms.ProgressBar()
			Me.lbMessage = New Global.System.Windows.Forms.Label()
			Me.Panel1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel1.Controls.Add(Me.lbMessage)
			Me.Panel1.Controls.Add(Me.ProgressBar)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.Panel1.Location = New Global.System.Drawing.Point(0, 0)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(161, 42)
			Me.Panel1.TabIndex = 2
			Me.ProgressBar.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.ProgressBar.Location = New Global.System.Drawing.Point(0, 23)
			Me.ProgressBar.Name = "ProgressBar"
			Me.ProgressBar.Size = New Global.System.Drawing.Size(159, 17)
			Me.ProgressBar.TabIndex = 2
			Me.lbMessage.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.lbMessage.Font = New Global.System.Drawing.Font("Calibri", 11.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lbMessage.Location = New Global.System.Drawing.Point(0, 0)
			Me.lbMessage.Name = "lbMessage"
			Me.lbMessage.Size = New Global.System.Drawing.Size(159, 23)
			Me.lbMessage.TabIndex = 3
			Me.lbMessage.Text = "message"
			Me.lbMessage.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(161, 42)
			MyBase.Controls.Add(Me.Panel1)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Name = "WaitSplashForm"
			MyBase.Opacity = 0.9
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "WaitSplashForm"
			MyBase.TopMost = True
			Me.Panel1.ResumeLayout(False)
			MyBase.ResumeLayout(False)
		End Sub
	End Class
End Namespace
