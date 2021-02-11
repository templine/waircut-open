Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace wAirCut
	' Token: 0x02000039 RID: 57
	<DesignerGenerated()>
	Public Partial Class UpdateForm
		Inherits Form

		' Token: 0x060003D7 RID: 983 RVA: 0x0000474D File Offset: 0x0000294D
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.UpdateForm_Load
			Me.string_0 = ""
			Me.InitializeComponent()
		End Sub

		' Token: 0x060003D8 RID: 984 RVA: 0x00017440 File Offset: 0x00015640
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

		' Token: 0x1700018B RID: 395
		' (get) Token: 0x060003DA RID: 986 RVA: 0x00004778 File Offset: 0x00002978
		' (set) Token: 0x060003DB RID: 987 RVA: 0x00004780 File Offset: 0x00002980
		Friend Overridable Property PictureBox1 As PictureBox

		' Token: 0x1700018C RID: 396
		' (get) Token: 0x060003DC RID: 988 RVA: 0x00004789 File Offset: 0x00002989
		' (set) Token: 0x060003DD RID: 989 RVA: 0x00004791 File Offset: 0x00002991
		Friend Overridable Property lbTitle As Label

		' Token: 0x1700018D RID: 397
		' (get) Token: 0x060003DE RID: 990 RVA: 0x0000479A File Offset: 0x0000299A
		' (set) Token: 0x060003DF RID: 991 RVA: 0x000047A2 File Offset: 0x000029A2
		Friend Overridable Property Label1 As Label

		' Token: 0x1700018E RID: 398
		' (get) Token: 0x060003E0 RID: 992 RVA: 0x000047AB File Offset: 0x000029AB
		' (set) Token: 0x060003E1 RID: 993 RVA: 0x000047B3 File Offset: 0x000029B3
		Friend Overridable Property Label2 As Label

		' Token: 0x1700018F RID: 399
		' (get) Token: 0x060003E2 RID: 994 RVA: 0x000047BC File Offset: 0x000029BC
		' (set) Token: 0x060003E3 RID: 995 RVA: 0x000047C4 File Offset: 0x000029C4
		Friend Overridable Property lbVersion As Label

		' Token: 0x17000190 RID: 400
		' (get) Token: 0x060003E4 RID: 996 RVA: 0x000047CD File Offset: 0x000029CD
		' (set) Token: 0x060003E5 RID: 997 RVA: 0x000047D5 File Offset: 0x000029D5
		Friend Overridable Property lbLastVersion As Label

		' Token: 0x17000191 RID: 401
		' (get) Token: 0x060003E6 RID: 998 RVA: 0x000047DE File Offset: 0x000029DE
		' (set) Token: 0x060003E7 RID: 999 RVA: 0x00017864 File Offset: 0x00015A64
		Friend Overridable Property btDownload As Button
			<CompilerGenerated()>
			Get
				Return Me._btDownload
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.method_0
				Dim btDownload As Button = Me._btDownload
				If btDownload IsNot Nothing Then
					RemoveHandler btDownload.Click, value2
				End If
				Me._btDownload = value
				btDownload = Me._btDownload
				If btDownload IsNot Nothing Then
					AddHandler btDownload.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000192 RID: 402
		' (get) Token: 0x060003E8 RID: 1000 RVA: 0x000047E6 File Offset: 0x000029E6
		' (set) Token: 0x060003E9 RID: 1001 RVA: 0x000047EE File Offset: 0x000029EE
		Friend Overridable Property btDonate As Button

		' Token: 0x17000193 RID: 403
		' (get) Token: 0x060003EA RID: 1002 RVA: 0x000047F7 File Offset: 0x000029F7
		' (set) Token: 0x060003EB RID: 1003 RVA: 0x000047FF File Offset: 0x000029FF
		Friend Overridable Property Panel2 As Panel

		' Token: 0x17000194 RID: 404
		' (get) Token: 0x060003EC RID: 1004 RVA: 0x00004808 File Offset: 0x00002A08
		' (set) Token: 0x060003ED RID: 1005 RVA: 0x00004810 File Offset: 0x00002A10
		Friend Overridable Property ScrollLabel1 As GClass14

		' Token: 0x060003EE RID: 1006 RVA: 0x00004819 File Offset: 0x00002A19
		Private Sub UpdateForm_Load(sender As Object, e As EventArgs)
			Me.ScrollLabel1.Text = Class10.String_60
			Me.lbVersion.Text = Class13.Version
			Me.lbLastVersion.Text = Me.string_0
			Me.btDonate.Visible = False
		End Sub

		' Token: 0x060003EF RID: 1007 RVA: 0x000178A8 File Offset: 0x00015AA8
		Private Sub method_0(sender As Object, e As EventArgs)
			Try
				Process.Start("https://sourceforge.net/projects/waircut")
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x040001C7 RID: 455
		Private icontainer_0 As IContainer

		' Token: 0x040001D2 RID: 466
		Public string_0 As String
	End Class
End Namespace
