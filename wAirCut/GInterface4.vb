Imports System
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

' Token: 0x02000042 RID: 66
<Guid("0AC1AF15-ED13-4E43-966C-9D838C6F6B97")>
<TypeIdentifier()>
<InterfaceType(1S)>
<CompilerGenerated()>
<ComImport()>
Public Interface GInterface4
	' Token: 0x0600047B RID: 1147
	<MethodImpl(MethodImplOptions.InternalCall)>
	Sub OnJswApiTraceMessage(<[In]()> threadID As Integer, <MarshalAs(UnmanagedType.BStr)> <[In]()> message As String)

	' Token: 0x0600047C RID: 1148
	<MethodImpl(MethodImplOptions.InternalCall)>
	Sub OnJswApiEvent(<[In]()> [event] As GEnum8, <MarshalAs(UnmanagedType.BStr)> <[In]()> evtString As String)
End Interface
