Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

' Token: 0x02000009 RID: 9
<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
<HideModuleName()>
<CompilerGenerated()>
<DebuggerNonUserCode()>
Public NotInheritable Module GClass0
	' Token: 0x1700005D RID: 93
	' (get) Token: 0x06000079 RID: 121 RVA: 0x00002A78 File Offset: 0x00000C78
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	Public ReadOnly Property ResourceManager_0 As ResourceManager
		Get
			If Object.ReferenceEquals(GClass0.resourceManager_0, Nothing) Then
				GClass0.resourceManager_0 = New ResourceManager("wAirCut.Resources", GetType(GClass0).Assembly)
			End If
			Return GClass0.resourceManager_0
		End Get
	End Property

	' Token: 0x1700005E RID: 94
	' (get) Token: 0x0600007A RID: 122 RVA: 0x00002AAA File Offset: 0x00000CAA
	' (set) Token: 0x0600007B RID: 123 RVA: 0x00002AB1 File Offset: 0x00000CB1
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	Public Property CultureInfo_0 As CultureInfo
		Get
			Return GClass0.cultureInfo_0
		End Get
		Set(value As CultureInfo)
			GClass0.cultureInfo_0 = value
		End Set
	End Property

	' Token: 0x1700005F RID: 95
	' (get) Token: 0x0600007C RID: 124 RVA: 0x00002AB9 File Offset: 0x00000CB9
	Public ReadOnly Property Bitmap_0 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("About_24x24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000060 RID: 96
	' (get) Token: 0x0600007D RID: 125 RVA: 0x00002AD9 File Offset: 0x00000CD9
	Public ReadOnly Property Bitmap_1 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Accept_32x32", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000061 RID: 97
	' (get) Token: 0x0600007E RID: 126 RVA: 0x00002AF9 File Offset: 0x00000CF9
	Public ReadOnly Property Bitmap_2 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("add_24x24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000062 RID: 98
	' (get) Token: 0x0600007F RID: 127 RVA: 0x00002B19 File Offset: 0x00000D19
	Public ReadOnly Property Bitmap_3 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("arrow_contract_24x24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000063 RID: 99
	' (get) Token: 0x06000080 RID: 128 RVA: 0x00002B39 File Offset: 0x00000D39
	Public ReadOnly Property Bitmap_4 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("arrow_expand_24x24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000064 RID: 100
	' (get) Token: 0x06000081 RID: 129 RVA: 0x00002B59 File Offset: 0x00000D59
	Public ReadOnly Property Bitmap_5 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("AutoSave_24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000065 RID: 101
	' (get) Token: 0x06000082 RID: 130 RVA: 0x00002B79 File Offset: 0x00000D79
	Public ReadOnly Property Bitmap_6 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Blank_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000066 RID: 102
	' (get) Token: 0x06000083 RID: 131 RVA: 0x00002B99 File Offset: 0x00000D99
	Public ReadOnly Property Bitmap_7 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("by_nc_nd", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000067 RID: 103
	' (get) Token: 0x06000084 RID: 132 RVA: 0x00002BB9 File Offset: 0x00000DB9
	Public ReadOnly Property Bitmap_8 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("calculator_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000068 RID: 104
	' (get) Token: 0x06000085 RID: 133 RVA: 0x00002BD9 File Offset: 0x00000DD9
	Public ReadOnly Property Bitmap_9 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("calculator_24x24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000069 RID: 105
	' (get) Token: 0x06000086 RID: 134 RVA: 0x00002BF9 File Offset: 0x00000DF9
	Public ReadOnly Property Bitmap_10 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Clear_24x24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700006A RID: 106
	' (get) Token: 0x06000087 RID: 135 RVA: 0x00002C19 File Offset: 0x00000E19
	Public ReadOnly Property Bitmap_11 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("coffeecup", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700006B RID: 107
	' (get) Token: 0x06000088 RID: 136 RVA: 0x00002C39 File Offset: 0x00000E39
	Public ReadOnly Property Bitmap_12 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("database_32x32", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700006C RID: 108
	' (get) Token: 0x06000089 RID: 137 RVA: 0x00002C59 File Offset: 0x00000E59
	Public ReadOnly Property Byte_0 As Byte()
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("dataSource1", GClass0.cultureInfo_0)), Byte())
		End Get
	End Property

	' Token: 0x1700006D RID: 109
	' (get) Token: 0x0600008A RID: 138 RVA: 0x00002C79 File Offset: 0x00000E79
	Public ReadOnly Property Bitmap_13 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("delete_24x24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700006E RID: 110
	' (get) Token: 0x0600008B RID: 139 RVA: 0x00002C99 File Offset: 0x00000E99
	Public ReadOnly Property Bitmap_14 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Download_32x32", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700006F RID: 111
	' (get) Token: 0x0600008C RID: 140 RVA: 0x00002CB9 File Offset: 0x00000EB9
	Public ReadOnly Property Bitmap_15 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Favorites_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000070 RID: 112
	' (get) Token: 0x0600008D RID: 141 RVA: 0x00002CD9 File Offset: 0x00000ED9
	Public ReadOnly Property Bitmap_16 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("forbidden_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000071 RID: 113
	' (get) Token: 0x0600008E RID: 142 RVA: 0x00002CF9 File Offset: 0x00000EF9
	Public ReadOnly Property Bitmap_17 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("hide_left_24x24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000072 RID: 114
	' (get) Token: 0x0600008F RID: 143 RVA: 0x00002D19 File Offset: 0x00000F19
	Public ReadOnly Property Bitmap_18 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("hide_right_24x24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000073 RID: 115
	' (get) Token: 0x06000090 RID: 144 RVA: 0x00002D39 File Offset: 0x00000F39
	Public ReadOnly Property String_0 As String
		Get
			Return GClass0.ResourceManager_0.GetString("JSWServiceName", GClass0.cultureInfo_0)
		End Get
	End Property

	' Token: 0x17000074 RID: 116
	' (get) Token: 0x06000091 RID: 145 RVA: 0x00002D4F File Offset: 0x00000F4F
	Public ReadOnly Property Bitmap_19 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Led_Blue_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000075 RID: 117
	' (get) Token: 0x06000092 RID: 146 RVA: 0x00002D6F File Offset: 0x00000F6F
	Public ReadOnly Property Bitmap_20 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Led_Green_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000076 RID: 118
	' (get) Token: 0x06000093 RID: 147 RVA: 0x00002D8F File Offset: 0x00000F8F
	Public ReadOnly Property Bitmap_21 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Led_Grey_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000077 RID: 119
	' (get) Token: 0x06000094 RID: 148 RVA: 0x00002DAF File Offset: 0x00000FAF
	Public ReadOnly Property Bitmap_22 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Led_Orange_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000078 RID: 120
	' (get) Token: 0x06000095 RID: 149 RVA: 0x00002DCF File Offset: 0x00000FCF
	Public ReadOnly Property Bitmap_23 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Led_Red_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000079 RID: 121
	' (get) Token: 0x06000096 RID: 150 RVA: 0x00002DEF File Offset: 0x00000FEF
	Public ReadOnly Property Bitmap_24 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Letter_A_gold_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700007A RID: 122
	' (get) Token: 0x06000097 RID: 151 RVA: 0x00002E0F File Offset: 0x0000100F
	Public ReadOnly Property Bitmap_25 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Letter_A_pink_icon_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700007B RID: 123
	' (get) Token: 0x06000098 RID: 152 RVA: 0x00002E2F File Offset: 0x0000102F
	Public ReadOnly Property Bitmap_26 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Letter_C_pink_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700007C RID: 124
	' (get) Token: 0x06000099 RID: 153 RVA: 0x00002E4F File Offset: 0x0000104F
	Public ReadOnly Property Bitmap_27 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Letter_D_lg_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700007D RID: 125
	' (get) Token: 0x0600009A RID: 154 RVA: 0x00002E6F File Offset: 0x0000106F
	Public ReadOnly Property Bitmap_28 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Letter_E_red_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700007E RID: 126
	' (get) Token: 0x0600009B RID: 155 RVA: 0x00002E8F File Offset: 0x0000108F
	Public ReadOnly Property Bitmap_29 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Letter_F_grey_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700007F RID: 127
	' (get) Token: 0x0600009C RID: 156 RVA: 0x00002EAF File Offset: 0x000010AF
	Public ReadOnly Property Bitmap_30 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Letter_L_Green_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000080 RID: 128
	' (get) Token: 0x0600009D RID: 157 RVA: 0x00002ECF File Offset: 0x000010CF
	Public ReadOnly Property Bitmap_31 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Letter_N_grey_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000081 RID: 129
	' (get) Token: 0x0600009E RID: 158 RVA: 0x00002EEF File Offset: 0x000010EF
	Public ReadOnly Property Bitmap_32 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Letter_T_dg_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000082 RID: 130
	' (get) Token: 0x0600009F RID: 159 RVA: 0x00002F0F File Offset: 0x0000110F
	Public ReadOnly Property Bitmap_33 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Letter_X_red_icon_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000083 RID: 131
	' (get) Token: 0x060000A0 RID: 160 RVA: 0x00002F2F File Offset: 0x0000112F
	Public ReadOnly Property Bitmap_34 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Letter_Z_blue_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000084 RID: 132
	' (get) Token: 0x060000A1 RID: 161 RVA: 0x00002F4F File Offset: 0x0000114F
	Public ReadOnly Property Bitmap_35 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Loading", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000085 RID: 133
	' (get) Token: 0x060000A2 RID: 162 RVA: 0x00002F6F File Offset: 0x0000116F
	Public ReadOnly Property Bitmap_36 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("loupe_24x24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000086 RID: 134
	' (get) Token: 0x060000A3 RID: 163 RVA: 0x00002F8F File Offset: 0x0000118F
	Public ReadOnly Property Bitmap_37 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("navigate_left_24x24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000087 RID: 135
	' (get) Token: 0x060000A4 RID: 164 RVA: 0x00002FAF File Offset: 0x000011AF
	Public ReadOnly Property Bitmap_38 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("navigate_right_24x24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000088 RID: 136
	' (get) Token: 0x060000A5 RID: 165 RVA: 0x00002FCF File Offset: 0x000011CF
	Public ReadOnly Property Bitmap_39 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("openHS", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000089 RID: 137
	' (get) Token: 0x060000A6 RID: 166 RVA: 0x00002FEF File Offset: 0x000011EF
	Public ReadOnly Property Bitmap_40 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Play_24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700008A RID: 138
	' (get) Token: 0x060000A7 RID: 167 RVA: 0x0000300F File Offset: 0x0000120F
	Public ReadOnly Property Bitmap_41 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Play_All_24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700008B RID: 139
	' (get) Token: 0x060000A8 RID: 168 RVA: 0x0000302F File Offset: 0x0000122F
	Public ReadOnly Property Bitmap_42 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Pledgie_Button", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700008C RID: 140
	' (get) Token: 0x060000A9 RID: 169 RVA: 0x0000304F File Offset: 0x0000124F
	Public ReadOnly Property Bitmap_43 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Pledgie_Button_coffee", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700008D RID: 141
	' (get) Token: 0x060000AA RID: 170 RVA: 0x0000306F File Offset: 0x0000126F
	Public ReadOnly Property Bitmap_44 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Private_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700008E RID: 142
	' (get) Token: 0x060000AB RID: 171 RVA: 0x0000308F File Offset: 0x0000128F
	Public ReadOnly Property Bitmap_45 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("private_32x32", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700008F RID: 143
	' (get) Token: 0x060000AC RID: 172 RVA: 0x000030AF File Offset: 0x000012AF
	Public ReadOnly Property Bitmap_46 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Question_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000090 RID: 144
	' (get) Token: 0x060000AD RID: 173 RVA: 0x000030CF File Offset: 0x000012CF
	Public ReadOnly Property Bitmap_47 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Random_24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000091 RID: 145
	' (get) Token: 0x060000AE RID: 174 RVA: 0x000030EF File Offset: 0x000012EF
	Public ReadOnly Property Bitmap_48 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Refresh_24x24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000092 RID: 146
	' (get) Token: 0x060000AF RID: 175 RVA: 0x0000310F File Offset: 0x0000130F
	Public ReadOnly Property Bitmap_49 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Save", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000093 RID: 147
	' (get) Token: 0x060000B0 RID: 176 RVA: 0x0000312F File Offset: 0x0000132F
	Public ReadOnly Property Bitmap_50 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Scan_32", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000094 RID: 148
	' (get) Token: 0x060000B1 RID: 177 RVA: 0x0000314F File Offset: 0x0000134F
	Public ReadOnly Property Bitmap_51 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("stop_24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000095 RID: 149
	' (get) Token: 0x060000B2 RID: 178 RVA: 0x0000316F File Offset: 0x0000136F
	Public ReadOnly Property Bitmap_52 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Stop_48x48", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000096 RID: 150
	' (get) Token: 0x060000B3 RID: 179 RVA: 0x0000318F File Offset: 0x0000138F
	Public ReadOnly Property Bitmap_53 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Upload_24x24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000097 RID: 151
	' (get) Token: 0x060000B4 RID: 180 RVA: 0x000031AF File Offset: 0x000013AF
	Public ReadOnly Property Bitmap_54 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("WairCut", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000098 RID: 152
	' (get) Token: 0x060000B5 RID: 181 RVA: 0x000031CF File Offset: 0x000013CF
	Public ReadOnly Property Bitmap_55 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Wizard_16x16", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x17000099 RID: 153
	' (get) Token: 0x060000B6 RID: 182 RVA: 0x000031EF File Offset: 0x000013EF
	Public ReadOnly Property Bitmap_56 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("wizard_24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700009A RID: 154
	' (get) Token: 0x060000B7 RID: 183 RVA: 0x0000320F File Offset: 0x0000140F
	Public ReadOnly Property Bitmap_57 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("Wizard2_24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700009B RID: 155
	' (get) Token: 0x060000B8 RID: 184 RVA: 0x0000322F File Offset: 0x0000142F
	Public ReadOnly Property Bitmap_58 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("WPS_24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x1700009C RID: 156
	' (get) Token: 0x060000B9 RID: 185 RVA: 0x0000324F File Offset: 0x0000144F
	Public ReadOnly Property Bitmap_59 As Bitmap
		Get
			Return CType(RuntimeHelpers.GetObjectValue(GClass0.ResourceManager_0.GetObject("WpsLitle_24x24", GClass0.cultureInfo_0)), Bitmap)
		End Get
	End Property

	' Token: 0x04000010 RID: 16
	Private resourceManager_0 As ResourceManager

	' Token: 0x04000011 RID: 17
	Private cultureInfo_0 As CultureInfo
End Module
