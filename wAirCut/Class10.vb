Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices

' Token: 0x02000008 RID: 8
<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
<DebuggerNonUserCode()>
<CompilerGenerated()>
Friend Class Class10
	' Token: 0x06000028 RID: 40 RVA: 0x000021AE File Offset: 0x000003AE
	Friend Sub New()
	End Sub

	' Token: 0x1700000D RID: 13
	' (get) Token: 0x06000029 RID: 41 RVA: 0x0000238A File Offset: 0x0000058A
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	Friend Shared ReadOnly Property ResourceManager_0 As ResourceManager
		Get
			If Object.ReferenceEquals(Class10.resourceManager_0, Nothing) Then
				Class10.resourceManager_0 = New ResourceManager("wAirCut.language", GetType(Class10).Assembly)
			End If
			Return Class10.resourceManager_0
		End Get
	End Property

	' Token: 0x1700000E RID: 14
	' (set) Token: 0x0600002A RID: 42 RVA: 0x000023BC File Offset: 0x000005BC
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	Friend Shared WriteOnly Property CultureInfo_0 As CultureInfo
		Set(value As CultureInfo)
			Class10.cultureInfo_0 = value
		End Set
	End Property

	' Token: 0x1700000F RID: 15
	' (get) Token: 0x0600002B RID: 43 RVA: 0x000023C4 File Offset: 0x000005C4
	Friend Shared ReadOnly Property String_0 As String
		Get
			Return Class10.ResourceManager_0.GetString("ABOUT", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000010 RID: 16
	' (get) Token: 0x0600002C RID: 44 RVA: 0x000023DA File Offset: 0x000005DA
	Friend Shared ReadOnly Property String_1 As String
		Get
			Return Class10.ResourceManager_0.GetString("ABOUT_VERSION", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000011 RID: 17
	' (get) Token: 0x0600002D RID: 45 RVA: 0x000023F0 File Offset: 0x000005F0
	Friend Shared ReadOnly Property String_2 As String
		Get
			Return Class10.ResourceManager_0.GetString("API_EVENT", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000012 RID: 18
	' (get) Token: 0x0600002E RID: 46 RVA: 0x00002406 File Offset: 0x00000606
	Friend Shared ReadOnly Property String_3 As String
		Get
			Return Class10.ResourceManager_0.GetString("API_TRACE_MSG", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000013 RID: 19
	' (get) Token: 0x0600002F RID: 47 RVA: 0x0000241C File Offset: 0x0000061C
	Friend Shared ReadOnly Property String_4 As String
		Get
			Return Class10.ResourceManager_0.GetString("CONSOLE_CONTRACT_INFO", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000014 RID: 20
	' (get) Token: 0x06000030 RID: 48 RVA: 0x00002432 File Offset: 0x00000632
	Friend Shared ReadOnly Property String_5 As String
		Get
			Return Class10.ResourceManager_0.GetString("CONSOLE_EXPAND_INFO", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000015 RID: 21
	' (get) Token: 0x06000031 RID: 49 RVA: 0x00002448 File Offset: 0x00000648
	Friend Shared ReadOnly Property String_6 As String
		Get
			Return Class10.ResourceManager_0.GetString("DB_RELEASE", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000016 RID: 22
	' (get) Token: 0x06000032 RID: 50 RVA: 0x0000245E File Offset: 0x0000065E
	Friend Shared ReadOnly Property String_7 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_AP_ALGORITHM_KNOW", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000017 RID: 23
	' (get) Token: 0x06000033 RID: 51 RVA: 0x00002474 File Offset: 0x00000674
	Friend Shared ReadOnly Property String_8 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_AP_GENERIC_PINS_KNOW", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000018 RID: 24
	' (get) Token: 0x06000034 RID: 52 RVA: 0x0000248A File Offset: 0x0000068A
	Friend Shared ReadOnly Property String_9 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_AP_GENERIC_PINS_UNKNOW", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000019 RID: 25
	' (get) Token: 0x06000035 RID: 53 RVA: 0x000024A0 File Offset: 0x000006A0
	Friend Shared ReadOnly Property String_10 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_AP_ONE_GENERIC_PIN", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700001A RID: 26
	' (get) Token: 0x06000036 RID: 54 RVA: 0x000024B6 File Offset: 0x000006B6
	Friend Shared ReadOnly Property String_11 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_AP_PIN_TRIED_NOK", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700001B RID: 27
	' (get) Token: 0x06000037 RID: 55 RVA: 0x000024CC File Offset: 0x000006CC
	Friend Shared ReadOnly Property String_12 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_AP_PIN_TRIED_OK", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700001C RID: 28
	' (get) Token: 0x06000038 RID: 56 RVA: 0x000024E2 File Offset: 0x000006E2
	Friend Shared ReadOnly Property String_13 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_AP_PIXIE_VULNERABLE", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700001D RID: 29
	' (get) Token: 0x06000039 RID: 57 RVA: 0x000024F8 File Offset: 0x000006F8
	Friend Shared ReadOnly Property String_14 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_ATTR_BAND", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700001E RID: 30
	' (get) Token: 0x0600003A RID: 58 RVA: 0x0000250E File Offset: 0x0000070E
	Friend Shared ReadOnly Property String_15 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_ATTR_CONFIG", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700001F RID: 31
	' (get) Token: 0x0600003B RID: 59 RVA: 0x00002524 File Offset: 0x00000724
	Friend Shared ReadOnly Property String_16 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_ATTR_LOCKED", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000020 RID: 32
	' (get) Token: 0x0600003C RID: 60 RVA: 0x0000253A File Offset: 0x0000073A
	Friend Shared ReadOnly Property String_17 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_ATTR_MANUFACTURER", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000021 RID: 33
	' (get) Token: 0x0600003D RID: 61 RVA: 0x00002550 File Offset: 0x00000750
	Friend Shared ReadOnly Property String_18 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_ATTR_MODEL_NAME", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000022 RID: 34
	' (get) Token: 0x0600003E RID: 62 RVA: 0x00002566 File Offset: 0x00000766
	Friend Shared ReadOnly Property String_19 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_ATTR_MODEL_NUMBER", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000023 RID: 35
	' (get) Token: 0x0600003F RID: 63 RVA: 0x0000257C File Offset: 0x0000077C
	Friend Shared ReadOnly Property String_20 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_ATTR_NAME", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000024 RID: 36
	' (get) Token: 0x06000040 RID: 64 RVA: 0x00002592 File Offset: 0x00000792
	Friend Shared ReadOnly Property String_21 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_ATTR_NETWORK_KEY", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000025 RID: 37
	' (get) Token: 0x06000041 RID: 65 RVA: 0x000025A8 File Offset: 0x000007A8
	Friend Shared ReadOnly Property String_22 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_ATTR_SECURITY", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000026 RID: 38
	' (get) Token: 0x06000042 RID: 66 RVA: 0x000025BE File Offset: 0x000007BE
	Friend Shared ReadOnly Property String_23 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_ATTR_SERIAL_NUMBER", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000027 RID: 39
	' (get) Token: 0x06000043 RID: 67 RVA: 0x000025D4 File Offset: 0x000007D4
	Friend Shared ReadOnly Property String_24 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_ATTR_WPS_PIN", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000028 RID: 40
	' (get) Token: 0x06000044 RID: 68 RVA: 0x000025EA File Offset: 0x000007EA
	Friend Shared ReadOnly Property String_25 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_ATTR_WPS_VERSION", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000029 RID: 41
	' (get) Token: 0x06000045 RID: 69 RVA: 0x00002600 File Offset: 0x00000800
	Friend Shared ReadOnly Property String_26 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_RANDINFO_PAUSE", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700002A RID: 42
	' (get) Token: 0x06000046 RID: 70 RVA: 0x00002616 File Offset: 0x00000816
	Friend Shared ReadOnly Property String_27 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_RANDINFO_TIME", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700002B RID: 43
	' (get) Token: 0x06000047 RID: 71 RVA: 0x0000262C File Offset: 0x0000082C
	Friend Shared ReadOnly Property String_28 As String
		Get
			Return Class10.ResourceManager_0.GetString("DGW_RANDINFO_TRIEDS", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700002C RID: 44
	' (get) Token: 0x06000048 RID: 72 RVA: 0x00002642 File Offset: 0x00000842
	Friend Shared ReadOnly Property String_29 As String
		Get
			Return Class10.ResourceManager_0.GetString("DISCLAIMER", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700002D RID: 45
	' (get) Token: 0x06000049 RID: 73 RVA: 0x00002658 File Offset: 0x00000858
	Friend Shared ReadOnly Property String_30 As String
		Get
			Return Class10.ResourceManager_0.GetString("DONATE_MESSAGE", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700002E RID: 46
	' (get) Token: 0x0600004A RID: 74 RVA: 0x0000266E File Offset: 0x0000086E
	Friend Shared ReadOnly Property String_31 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_AP_LOCKED", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700002F RID: 47
	' (get) Token: 0x0600004B RID: 75 RVA: 0x00002684 File Offset: 0x00000884
	Friend Shared ReadOnly Property String_32 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_ASSOCIATING", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000030 RID: 48
	' (get) Token: 0x0600004C RID: 76 RVA: 0x0000269A File Offset: 0x0000089A
	Friend Shared ReadOnly Property String_33 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_ASSOCIATION_FAILED", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000031 RID: 49
	' (get) Token: 0x0600004D RID: 77 RVA: 0x000026B0 File Offset: 0x000008B0
	Friend Shared ReadOnly Property String_34 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_BAD_FRAME", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000032 RID: 50
	' (get) Token: 0x0600004E RID: 78 RVA: 0x000026C6 File Offset: 0x000008C6
	Friend Shared ReadOnly Property String_35 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_FAILED_DEVICE_INIZIALIZED", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000033 RID: 51
	' (get) Token: 0x0600004F RID: 79 RVA: 0x000026DC File Offset: 0x000008DC
	Friend Shared ReadOnly Property String_36 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_FAILED_INIZIALIZED", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000034 RID: 52
	' (get) Token: 0x06000050 RID: 80 RVA: 0x000026F2 File Offset: 0x000008F2
	Friend Shared ReadOnly Property String_37 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_FIRST_HALF_VALID", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000035 RID: 53
	' (get) Token: 0x06000051 RID: 81 RVA: 0x00002708 File Offset: 0x00000908
	Friend Shared ReadOnly Property String_38 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_INVALID_PIN", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000036 RID: 54
	' (get) Token: 0x06000052 RID: 82 RVA: 0x0000271E File Offset: 0x0000091E
	Friend Shared ReadOnly Property String_39 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_MULTIPLES_AP_IN_PB_MODE", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000037 RID: 55
	' (get) Token: 0x06000053 RID: 83 RVA: 0x00002734 File Offset: 0x00000934
	Friend Shared ReadOnly Property String_40 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_NETWORK_KEY", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000038 RID: 56
	' (get) Token: 0x06000054 RID: 84 RVA: 0x0000274A File Offset: 0x0000094A
	Friend Shared ReadOnly Property String_41 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_NO_CANDIDATE_AP_FOUND", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000039 RID: 57
	' (get) Token: 0x06000055 RID: 85 RVA: 0x00002760 File Offset: 0x00000960
	Friend Shared ReadOnly Property String_42 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_NONE", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700003A RID: 58
	' (get) Token: 0x06000056 RID: 86 RVA: 0x00002776 File Offset: 0x00000976
	Friend Shared ReadOnly Property String_43 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_PROTOCOL_FAILED", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700003B RID: 59
	' (get) Token: 0x06000057 RID: 87 RVA: 0x0000278C File Offset: 0x0000098C
	Friend Shared ReadOnly Property String_44 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_PROTOCOL_FAILED_RESET_PIN", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700003C RID: 60
	' (get) Token: 0x06000058 RID: 88 RVA: 0x000027A2 File Offset: 0x000009A2
	Friend Shared ReadOnly Property String_45 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_PROTOCOL_TIMEOUT", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700003D RID: 61
	' (get) Token: 0x06000059 RID: 89 RVA: 0x000027B8 File Offset: 0x000009B8
	Friend Shared ReadOnly Property String_46 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_PUSHBUTTON_TIMEOUT", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700003E RID: 62
	' (get) Token: 0x0600005A RID: 90 RVA: 0x000027CE File Offset: 0x000009CE
	Friend Shared ReadOnly Property String_47 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_SCANNING_FOR_APS", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700003F RID: 63
	' (get) Token: 0x0600005B RID: 91 RVA: 0x000027E4 File Offset: 0x000009E4
	Friend Shared ReadOnly Property String_48 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_SELECTED_AP", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000040 RID: 64
	' (get) Token: 0x0600005C RID: 92 RVA: 0x000027FA File Offset: 0x000009FA
	Friend Shared ReadOnly Property String_49 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_START_PROTOCOL", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000041 RID: 65
	' (get) Token: 0x0600005D RID: 93 RVA: 0x00002810 File Offset: 0x00000A10
	Friend Shared ReadOnly Property String_50 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_SUPLICAN_RECEIVE_MSG", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000042 RID: 66
	' (get) Token: 0x0600005E RID: 94 RVA: 0x00002826 File Offset: 0x00000A26
	Friend Shared ReadOnly Property String_51 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_SUPLICANT_SENT_MSG", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000043 RID: 67
	' (get) Token: 0x0600005F RID: 95 RVA: 0x0000283C File Offset: 0x00000A3C
	Friend Shared ReadOnly Property String_52 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_TRY_PIN", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000044 RID: 68
	' (get) Token: 0x06000060 RID: 96 RVA: 0x00002852 File Offset: 0x00000A52
	Friend Shared ReadOnly Property String_53 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_TRY_PIXIE", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000045 RID: 69
	' (get) Token: 0x06000061 RID: 97 RVA: 0x00002868 File Offset: 0x00000A68
	Friend Shared ReadOnly Property String_54 As String
		Get
			Return Class10.ResourceManager_0.GetString("ENGINE_VALID_PIN", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000046 RID: 70
	' (get) Token: 0x06000062 RID: 98 RVA: 0x0000287E File Offset: 0x00000A7E
	Friend Shared ReadOnly Property String_55 As String
		Get
			Return Class10.ResourceManager_0.GetString("INTERFACE_NOT_FOUND", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000047 RID: 71
	' (get) Token: 0x06000063 RID: 99 RVA: 0x00002894 File Offset: 0x00000A94
	Friend Shared ReadOnly Property String_56 As String
		Get
			Return Class10.ResourceManager_0.GetString("JSW_UNCOMPATIBLE_VERSION", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000048 RID: 72
	' (get) Token: 0x06000064 RID: 100 RVA: 0x000028AA File Offset: 0x00000AAA
	Friend Shared ReadOnly Property String_57 As String
		Get
			Return Class10.ResourceManager_0.GetString("JSW_UNINSTALED", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000049 RID: 73
	' (get) Token: 0x06000065 RID: 101 RVA: 0x000028C0 File Offset: 0x00000AC0
	Friend Shared ReadOnly Property String_58 As String
		Get
			Return Class10.ResourceManager_0.GetString("LANGUAGE_CHANGE_QUESTION", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700004A RID: 74
	' (get) Token: 0x06000066 RID: 102 RVA: 0x000028D6 File Offset: 0x00000AD6
	Friend Shared ReadOnly Property String_59 As String
		Get
			Return Class10.ResourceManager_0.GetString("MSG_INCORRECT_FORMAT_PIN", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700004B RID: 75
	' (get) Token: 0x06000067 RID: 103 RVA: 0x000028EC File Offset: 0x00000AEC
	Friend Shared ReadOnly Property String_60 As String
		Get
			Return Class10.ResourceManager_0.GetString("NEW_RELEASE", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700004C RID: 76
	' (get) Token: 0x06000068 RID: 104 RVA: 0x00002902 File Offset: 0x00000B02
	Friend Shared ReadOnly Property String_61 As String
		Get
			Return Class10.ResourceManager_0.GetString("OS_INCOMPATIBLE", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700004D RID: 77
	' (get) Token: 0x06000069 RID: 105 RVA: 0x00002918 File Offset: 0x00000B18
	Friend Shared ReadOnly Property String_62 As String
		Get
			Return Class10.ResourceManager_0.GetString("RAND_AP_LOCKED", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700004E RID: 78
	' (get) Token: 0x0600006A RID: 106 RVA: 0x0000292E File Offset: 0x00000B2E
	Friend Shared ReadOnly Property String_63 As String
		Get
			Return Class10.ResourceManager_0.GetString("RAND_DURATION", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700004F RID: 79
	' (get) Token: 0x0600006B RID: 107 RVA: 0x00002944 File Offset: 0x00000B44
	Friend Shared ReadOnly Property String_64 As String
		Get
			Return Class10.ResourceManager_0.GetString("RAND_FILE_EXIST", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000050 RID: 80
	' (get) Token: 0x0600006C RID: 108 RVA: 0x0000295A File Offset: 0x00000B5A
	Friend Shared ReadOnly Property String_65 As String
		Get
			Return Class10.ResourceManager_0.GetString("RAND_FILE_FORMAT_ERROR", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000051 RID: 81
	' (get) Token: 0x0600006D RID: 109 RVA: 0x00002970 File Offset: 0x00000B70
	Friend Shared ReadOnly Property String_66 As String
		Get
			Return Class10.ResourceManager_0.GetString("RAND_FIRST_HALF_OK", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000052 RID: 82
	' (get) Token: 0x0600006E RID: 110 RVA: 0x00002986 File Offset: 0x00000B86
	Friend Shared ReadOnly Property String_67 As String
		Get
			Return Class10.ResourceManager_0.GetString("RAND_INCORRECT_AP_FILE", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000053 RID: 83
	' (get) Token: 0x0600006F RID: 111 RVA: 0x0000299C File Offset: 0x00000B9C
	Friend Shared ReadOnly Property String_68 As String
		Get
			Return Class10.ResourceManager_0.GetString("RAND_INVALID_PIN", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000054 RID: 84
	' (get) Token: 0x06000070 RID: 112 RVA: 0x000029B2 File Offset: 0x00000BB2
	Friend Shared ReadOnly Property String_69 As String
		Get
			Return Class10.ResourceManager_0.GetString("RAND_PIN_FOUNT", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000055 RID: 85
	' (get) Token: 0x06000071 RID: 113 RVA: 0x000029C8 File Offset: 0x00000BC8
	Friend Shared ReadOnly Property String_70 As String
		Get
			Return Class10.ResourceManager_0.GetString("RAND_PIN_NOT_FOUND", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000056 RID: 86
	' (get) Token: 0x06000072 RID: 114 RVA: 0x000029DE File Offset: 0x00000BDE
	Friend Shared ReadOnly Property String_71 As String
		Get
			Return Class10.ResourceManager_0.GetString("RAND_RETRY_TIMEOUT", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000057 RID: 87
	' (get) Token: 0x06000073 RID: 115 RVA: 0x000029F4 File Offset: 0x00000BF4
	Friend Shared ReadOnly Property String_72 As String
		Get
			Return Class10.ResourceManager_0.GetString("RAND_TESTED_PINS", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000058 RID: 88
	' (get) Token: 0x06000074 RID: 116 RVA: 0x00002A0A File Offset: 0x00000C0A
	Friend Shared ReadOnly Property String_73 As String
		Get
			Return Class10.ResourceManager_0.GetString("RAND_TITLE", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000059 RID: 89
	' (get) Token: 0x06000075 RID: 117 RVA: 0x00002A20 File Offset: 0x00000C20
	Friend Shared ReadOnly Property String_74 As String
		Get
			Return Class10.ResourceManager_0.GetString("RAND_TITLE_ALLPIN", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700005A RID: 90
	' (get) Token: 0x06000076 RID: 118 RVA: 0x00002A36 File Offset: 0x00000C36
	Friend Shared ReadOnly Property String_75 As String
		Get
			Return Class10.ResourceManager_0.GetString("RAND_VALID_PIN", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700005B RID: 91
	' (get) Token: 0x06000077 RID: 119 RVA: 0x00002A4C File Offset: 0x00000C4C
	Friend Shared ReadOnly Property String_76 As String
		Get
			Return Class10.ResourceManager_0.GetString("WAITING_COMPLETION", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x1700005C RID: 92
	' (get) Token: 0x06000078 RID: 120 RVA: 0x00002A62 File Offset: 0x00000C62
	Friend Shared ReadOnly Property String_77 As String
		Get
			Return Class10.ResourceManager_0.GetString("WAITING_PB_AP", Class10.cultureInfo_0)
		End Get
	End Property

	' Token: 0x0400000E RID: 14
	Private Shared resourceManager_0 As ResourceManager

	' Token: 0x0400000F RID: 15
	Private Shared cultureInfo_0 As CultureInfo
End Class
