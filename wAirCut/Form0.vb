Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices

' Token: 0x02000002 RID: 2
<GeneratedCode("MyTemplate", "11.0.0.0")>
<EditorBrowsable(EditorBrowsableState.Never)>
Friend Class Form0
	Inherits WindowsFormsApplicationBase

	' Token: 0x06000002 RID: 2 RVA: 0x000020D3 File Offset: 0x000002D3
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	<STAThread()>
	<DebuggerHidden()>
	<MethodImpl(MethodImplOptions.NoOptimization)>
	Friend Shared Sub Main(args As String())
		Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering)
		Class6.Form0_0.Run(args)
	End Sub

	' Token: 0x06000003 RID: 3 RVA: 0x000020EA File Offset: 0x000002EA
	<DebuggerStepThrough()>
	Public Sub New()
		MyBase.New(AuthenticationMode.Windows)
		MyBase.IsSingleInstance = True
		MyBase.EnableVisualStyles = True
		MyBase.SaveMySettingsOnExit = True
		MyBase.ShutdownStyle = ShutdownMode.AfterMainFormCloses
	End Sub

	' Token: 0x06000004 RID: 4 RVA: 0x0000210F File Offset: 0x0000030F
	<DebuggerStepThrough()>
	Protected Overridable Sub OnCreateMainForm()
		MyBase.MainForm = Class6.Class7_0.MainForm_0
	End Sub
End Class
