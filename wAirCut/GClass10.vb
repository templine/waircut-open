Imports System
Imports System.ComponentModel
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Windows.Forms
Imports wAirCut.My

' Token: 0x02000027 RID: 39
Public Class GClass10
	' Token: 0x1700014F RID: 335
	' (get) Token: 0x060002F7 RID: 759 RVA: 0x000041F4 File Offset: 0x000023F4
	' (set) Token: 0x060002F8 RID: 760 RVA: 0x0001238C File Offset: 0x0001058C
	Private Overridable Property BackgroundWorker_0 As BackgroundWorker
		<CompilerGenerated()>
		Get
			Return Me.backgroundWorker_0
		End Get
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Set(value As BackgroundWorker)
			Dim value2 As DoWorkEventHandler = AddressOf Me.method_1
			Dim value3 As RunWorkerCompletedEventHandler = AddressOf Me.method_2
			Dim value4 As ProgressChangedEventHandler = AddressOf Me.method_3
			Dim backgroundWorker As BackgroundWorker = Me.backgroundWorker_0
			If backgroundWorker IsNot Nothing Then
				RemoveHandler backgroundWorker.DoWork, value2
				RemoveHandler backgroundWorker.RunWorkerCompleted, value3
				RemoveHandler backgroundWorker.ProgressChanged, value4
			End If
			Me.backgroundWorker_0 = value
			backgroundWorker = Me.backgroundWorker_0
			If backgroundWorker IsNot Nothing Then
				AddHandler backgroundWorker.DoWork, value2
				AddHandler backgroundWorker.RunWorkerCompleted, value3
				AddHandler backgroundWorker.ProgressChanged, value4
			End If
		End Set
	End Property

	' Token: 0x1400000A RID: 10
	' (add) Token: 0x060002F9 RID: 761 RVA: 0x00012408 File Offset: 0x00010608
	' (remove) Token: 0x060002FA RID: 762 RVA: 0x00012444 File Offset: 0x00010644
	Public Custom Event Event_0 As GClass10.GDelegate9
		<CompilerGenerated()>
		AddHandler
			Dim gdelegate As GClass10.GDelegate9 = Me.gdelegate9_0
			Dim gdelegate2 As GClass10.GDelegate9
			Do
				gdelegate2 = gdelegate
				Dim value2 As GClass10.GDelegate9 = CType([Delegate].Combine(gdelegate2, value), GClass10.GDelegate9)
				gdelegate = Interlocked.CompareExchange(Of GClass10.GDelegate9)(Me.gdelegate9_0, value2, gdelegate2)
			Loop While gdelegate IsNot gdelegate2
		End AddHandler
		<CompilerGenerated()>
		RemoveHandler
			Dim gdelegate As GClass10.GDelegate9 = Me.gdelegate9_0
			Dim gdelegate2 As GClass10.GDelegate9
			Do
				gdelegate2 = gdelegate
				Dim value2 As GClass10.GDelegate9 = CType([Delegate].Remove(gdelegate2, value), GClass10.GDelegate9)
				gdelegate = Interlocked.CompareExchange(Of GClass10.GDelegate9)(Me.gdelegate9_0, value2, gdelegate2)
			Loop While gdelegate IsNot gdelegate2
		End RemoveHandler
	End Event

	' Token: 0x060002FB RID: 763 RVA: 0x00012480 File Offset: 0x00010680
	Public Sub New()
		Me.BackgroundWorker_0 = New BackgroundWorker()
		Me.bool_0 = False
		Me.int_0 = 0
		Me.gclass1_0 = New GClass1()
		Me.BackgroundWorker_0.WorkerReportsProgress = True
		Me.BackgroundWorker_0.WorkerSupportsCancellation = True
		Me.BackgroundWorker_0.RunWorkerAsync()
	End Sub

	' Token: 0x060002FC RID: 764 RVA: 0x000041FC File Offset: 0x000023FC
	Public Sub method_0()
		Me.BackgroundWorker_0.CancelAsync()
	End Sub

	' Token: 0x060002FD RID: 765 RVA: 0x000124DC File Offset: 0x000106DC
	Private Sub method_1(sender As Object, e As DoWorkEventArgs)
		If Class13.smethod_16() Then
			Me.method_4("https://sourceforge.net/projects/waircut/files/", 15)
			Me.method_5("https://sourceforge.net/projects/waircut/files/", 15)
			Me.BackgroundWorker_0.ReportProgress(1)
		End If
		While True
			Me.BackgroundWorker_0.ReportProgress(1)
			Thread.Sleep(60000)
			Dim ptr As Integer = Me.int_0
			Me.int_0 = ptr + 1
		End While
	End Sub

	' Token: 0x060002FE RID: 766 RVA: 0x00003A31 File Offset: 0x00001C31
	Private Sub method_2(sender As Object, e As RunWorkerCompletedEventArgs)
	End Sub

	' Token: 0x060002FF RID: 767 RVA: 0x0001253C File Offset: 0x0001073C
	Private Sub method_3(sender As Object, e As ProgressChangedEventArgs)
		If Not Class13.bool_0 Then
			If Not(Me.method_6() And Not Me.bool_0) Then
				If DateTime.Compare(Me.dateTime_2, MySettings.[Default].LastDBDate) > 0 AndAlso MessageBox.Show(Class10.String_6, "Update News...", MessageBoxButtons.YesNo) = DialogResult.Yes Then
					Me.method_7("https://sourceforge.net/projects/waircut/files/WpsPin.db", "WpsPin.db")
					MySettings.[Default].LastDBDate = Me.dateTime_2
				End If
			Else
				Me.bool_0 = True
				Dim gdelegate As GClass10.GDelegate9 = Me.gdelegate9_0
				If gdelegate IsNot Nothing Then
					gdelegate(Me.version_0.ToString())
					Return
				End If
			End If
		End If
	End Sub

	' Token: 0x06000300 RID: 768 RVA: 0x000125D8 File Offset: 0x000107D8
	Private Sub method_4(string_0 As String, int_1 As Integer)
		Dim webRequest As WebRequest = WebRequest.Create(New Uri(string_0))
		webRequest.Timeout = 1000 * int_1
		Try
			Using responseStream As Stream = webRequest.GetResponse().GetResponseStream()
				Using streamReader As StreamReader = New StreamReader(responseStream)
					Dim input As String = streamReader.ReadToEnd()
					Dim match As Match = New Regex("Waircut.*?(\d+.\d+).zip", RegexOptions.IgnoreCase Or RegexOptions.Singleline).Match(input)
					If match.Success Then
						Me.version_0 = New Version(match.Groups(1).ToString())
					End If
				End Using
			End Using
			webRequest.GetResponse().Close()
		Catch ex As WebException
		End Try
	End Sub

	' Token: 0x06000301 RID: 769 RVA: 0x000126B0 File Offset: 0x000108B0
	Private Sub method_5(string_0 As String, int_1 As Integer)
		Dim webRequest As WebRequest = WebRequest.Create(New Uri(string_0))
		webRequest.Timeout = 1000 * int_1
		Try
			Using responseStream As Stream = webRequest.GetResponse().GetResponseStream()
				Using streamReader As StreamReader = New StreamReader(responseStream)
					Dim input As String = streamReader.ReadToEnd()
					Dim match As Match = New Regex("WpsPin.db.*?<td headers=""files_date_h"" class=""opt""><abbr title="".*?([0-9]{4}-[0-9]{2}-[0-9]{2} [0-9]{2}:[0-9]{2}:[0-9]{2})", RegexOptions.IgnoreCase Or RegexOptions.Singleline).Match(input)
					If match.Success Then
						Me.dateTime_2 = DateTime.ParseExact(match.Groups(1).ToString(), "yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)
					End If
				End Using
			End Using
			webRequest.GetResponse().Close()
		Catch ex As WebException
		End Try
	End Sub

	' Token: 0x06000302 RID: 770 RVA: 0x00012790 File Offset: 0x00010990
	Private Function method_6() As Boolean
		Return Me.version_0 IsNot Nothing AndAlso (Me.version_0.Major > Class6.Form0_0.Info.Version.Major Or (Me.version_0.Major = Class6.Form0_0.Info.Version.Major And Me.version_0.Minor > Class6.Form0_0.Info.Version.Minor))
	End Function

	' Token: 0x06000303 RID: 771 RVA: 0x00012810 File Offset: 0x00010A10
	Private Sub method_7(string_0 As String, string_1 As String)
		Try
			Dim address As Uri = New Uri(string_0)
			Dim webClient As WebClient = New WebClient()
			AddHandler webClient.DownloadFileCompleted, AddressOf Me.method_8
			webClient.DownloadFileAsync(address, string_1, string_1)
		Catch ex As Exception
		End Try
	End Sub

	' Token: 0x06000304 RID: 772 RVA: 0x00003A31 File Offset: 0x00001C31
	Private Sub method_8(sender As Object, e As AsyncCompletedEventArgs)
	End Sub

	' Token: 0x0400013E RID: 318
	<CompilerGenerated()>
	<AccessedThroughProperty("backWorker")>
	Private backgroundWorker_0 As BackgroundWorker

	' Token: 0x0400013F RID: 319
	Private version_0 As Version

	' Token: 0x04000140 RID: 320
	Private dateTime_0 As DateTime

	' Token: 0x04000141 RID: 321
	Private dateTime_1 As DateTime

	' Token: 0x04000142 RID: 322
	Private dateTime_2 As DateTime

	' Token: 0x04000143 RID: 323
	Private bool_0 As Boolean

	' Token: 0x04000144 RID: 324
	Private int_0 As Integer

	' Token: 0x04000145 RID: 325
	Private gclass1_0 As GClass1

	' Token: 0x04000146 RID: 326
	<CompilerGenerated()>
	Private gdelegate9_0 As GClass10.GDelegate9

	' Token: 0x02000028 RID: 40
	' (Invoke) Token: 0x06000308 RID: 776
	Public Delegate Sub GDelegate9(version As String)
End Class
