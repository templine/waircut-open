Imports System
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

' Token: 0x02000046 RID: 70
<Guid("F170B8DD-13A9-456B-B10B-04430660A0D2")>
<CompilerGenerated()>
<InterfaceType(1S)>
<TypeIdentifier()>
<ComImport()>
Public Interface GInterface8
	' Token: 0x06000489 RID: 1161
	<MethodImpl(MethodImplOptions.InternalCall)>
	Sub OnJswEngineEvent(<[In]()> [event] As GEnum14, <[In]()> evtData As Integer, <MarshalAs(UnmanagedType.BStr)> <[In]()> evtString As String)
End Interface
