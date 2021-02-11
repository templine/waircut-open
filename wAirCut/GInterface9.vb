Imports System
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

' Token: 0x02000047 RID: 71
<Guid("D95318F7-B1D4-46F6-8932-038A886A7722")>
<CompilerGenerated()>
<InterfaceType(1S)>
<TypeIdentifier()>
<ComImport()>
Public Interface GInterface9
	' Token: 0x0600048A RID: 1162
	<MethodImpl(MethodImplOptions.InternalCall)>
	Sub OnJswSupplicantEvent(<[In]()> [event] As GEnum17, <[In]()> evtData As Integer, <MarshalAs(UnmanagedType.BStr)> <[In]()> evtString As String)
End Interface
