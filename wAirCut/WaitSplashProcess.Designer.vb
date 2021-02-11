Namespace wAirCut
	' Token: 0x0200003C RID: 60
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class WaitSplashProcess
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000412 RID: 1042 RVA: 0x000186A8 File Offset: 0x000168A8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.btStop = New Global.System.Windows.Forms.Button()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.ScrollLabel1 = New Global.GClass14()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.btStop.BackgroundImage = Global.GClass0.Bitmap_52
			Me.btStop.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.btStop.Location = New Global.System.Drawing.Point(111, 12)
			Me.btStop.Name = "btStop"
			Me.btStop.Size = New Global.System.Drawing.Size(40, 40)
			Me.btStop.TabIndex = 0
			Me.btStop.UseVisualStyleBackColor = True
			Me.PictureBox1.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.PictureBox1.Image = Global.GClass0.Bitmap_35
			Me.PictureBox1.InitialImage = Nothing
			Me.PictureBox1.Location = New Global.System.Drawing.Point(12, 6)
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.Size = New Global.System.Drawing.Size(69, 50)
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 1
			Me.PictureBox1.TabStop = False
			Me.ScrollLabel1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.ScrollLabel1.ForeColor = Global.System.Drawing.Color.Silver
			Me.ScrollLabel1.Int32_0 = 20
			Me.ScrollLabel1.Location = New Global.System.Drawing.Point(0, 50)
			Me.ScrollLabel1.Name = "ScrollLabel1"
			Me.ScrollLabel1.GEnum7_0 = Global.GClass14.GEnum7.horizontal
			Me.ScrollLabel1.Size = New Global.System.Drawing.Size(163, 13)
			Me.ScrollLabel1.TabIndex = 2
			Me.ScrollLabel1.Text = "Waiting for completion..."
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			MyBase.ClientSize = New Global.System.Drawing.Size(163, 63)
			MyBase.Controls.Add(Me.ScrollLabel1)
			MyBase.Controls.Add(Me.PictureBox1)
			MyBase.Controls.Add(Me.btStop)
			Me.DoubleBuffered = True
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Name = "WaitSplashProcess"
			MyBase.Opacity = 0.9
			Me.Text = "WaitSplashProcess"
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub
	End Class
End Namespace
