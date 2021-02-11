Imports System
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

' Token: 0x0200004E RID: 78
<CompilerGenerated()>
<TypeIdentifier("c9178c19-99cf-4f6d-85c6-3ef5a176f9fb", "JSWSCAPILib.JswAttr")>
Public Enum GEnum9
	' Token: 0x04000218 RID: 536
	JswAttr_APChannel = 4097
	' Token: 0x04000219 RID: 537
	JswAttr_AssociationState
	' Token: 0x0400021A RID: 538
	JswAttr_AuthenticationType
	' Token: 0x0400021B RID: 539
	JswAttr_AuthenticationTypeFlags
	' Token: 0x0400021C RID: 540
	JswAttr_Authenticator
	' Token: 0x0400021D RID: 541
	JswAttr_ConfigMethods = 4104
	' Token: 0x0400021E RID: 542
	JswAttr_ConfigurationError
	' Token: 0x0400021F RID: 543
	JswAttr_ConfirmationURL4
	' Token: 0x04000220 RID: 544
	JswAttr_ConfirmationURL6
	' Token: 0x04000221 RID: 545
	JswAttr_ConnectionType
	' Token: 0x04000222 RID: 546
	JswAttr_ConnectionTypeFlags
	' Token: 0x04000223 RID: 547
	JswAttr_Credential
	' Token: 0x04000224 RID: 548
	JswAttr_DeviceName = 4113
	' Token: 0x04000225 RID: 549
	JswAttr_DevicePasswordID
	' Token: 0x04000226 RID: 550
	JswAttr_E_Hash1 = 4116
	' Token: 0x04000227 RID: 551
	JswAttr_E_Hash2
	' Token: 0x04000228 RID: 552
	JswAttr_E_SNonce1
	' Token: 0x04000229 RID: 553
	JswAttr_E_SNonce2
	' Token: 0x0400022A RID: 554
	JswAttr_EncryptedSettings
	' Token: 0x0400022B RID: 555
	JswAttr_EncryptionType = 4111
	' Token: 0x0400022C RID: 556
	JswAttr_EncryptionTypeFlags
	' Token: 0x0400022D RID: 557
	JswAttr_EnrolleeNonce = 4122
	' Token: 0x0400022E RID: 558
	JswAttr_FeatureID
	' Token: 0x0400022F RID: 559
	JswAttr_Identity
	' Token: 0x04000230 RID: 560
	JswAttr_IdentityProof
	' Token: 0x04000231 RID: 561
	JswAttr_KeyWrapAuthenticator
	' Token: 0x04000232 RID: 562
	JswAttr_KeyIdentifier
	' Token: 0x04000233 RID: 563
	JswAttr_MACAddress
	' Token: 0x04000234 RID: 564
	JswAttr_Manufacturer
	' Token: 0x04000235 RID: 565
	JswAttr_MessageType
	' Token: 0x04000236 RID: 566
	JswAttr_ModelName
	' Token: 0x04000237 RID: 567
	JswAttr_ModelNumber
	' Token: 0x04000238 RID: 568
	JswAttr_NetworkIndex = 4134
	' Token: 0x04000239 RID: 569
	JswAttr_NetworkKey
	' Token: 0x0400023A RID: 570
	JswAttr_NetworkKeyIndex
	' Token: 0x0400023B RID: 571
	JswAttr_NewDeviceName
	' Token: 0x0400023C RID: 572
	JswAttr_NewPassword
	' Token: 0x0400023D RID: 573
	JswAttr_OOBDevicePassword = 4140
	' Token: 0x0400023E RID: 574
	JswAttr_OSVersion
	' Token: 0x0400023F RID: 575
	JswAttr_PowerLevel = 4143
	' Token: 0x04000240 RID: 576
	JswAttr_PSKCurrent
	' Token: 0x04000241 RID: 577
	JswAttr_PSKMax
	' Token: 0x04000242 RID: 578
	JswAttr_PublicKey
	' Token: 0x04000243 RID: 579
	JswAttr_RadioEnabled
	' Token: 0x04000244 RID: 580
	JswAttr_Reboot
	' Token: 0x04000245 RID: 581
	JswAttr_RegistrarCurrent
	' Token: 0x04000246 RID: 582
	JswAttr_RegistrarEstablished
	' Token: 0x04000247 RID: 583
	JswAttr_RegistrarList
	' Token: 0x04000248 RID: 584
	JswAttr_RegistrarMax
	' Token: 0x04000249 RID: 585
	JswAttr_RegistrarNonce
	' Token: 0x0400024A RID: 586
	JswAttr_RequestType
	' Token: 0x0400024B RID: 587
	JswAttr_ResponseType
	' Token: 0x0400024C RID: 588
	JswAttr_RFBand
	' Token: 0x0400024D RID: 589
	JswAttr_R_Hash1
	' Token: 0x0400024E RID: 590
	JswAttr_R_Hash2
	' Token: 0x0400024F RID: 591
	JswAttr_R_SNonce1
	' Token: 0x04000250 RID: 592
	JswAttr_R_SNonce2
	' Token: 0x04000251 RID: 593
	JswAttr_SelectedRegistrar
	' Token: 0x04000252 RID: 594
	JswAttr_SerialNumber
	' Token: 0x04000253 RID: 595
	JswAttr_SimpleConfigState = 4164
	' Token: 0x04000254 RID: 596
	JswAttr_SSID
	' Token: 0x04000255 RID: 597
	JswAttr_TotalNetworks
	' Token: 0x04000256 RID: 598
	JswAttr_UUID_E
	' Token: 0x04000257 RID: 599
	JswAttr_UUID_R
	' Token: 0x04000258 RID: 600
	JswAttr_VendorExtension
	' Token: 0x04000259 RID: 601
	JswAttr_Version
	' Token: 0x0400025A RID: 602
	JswAttr_X509CertificateRequest
	' Token: 0x0400025B RID: 603
	JswAttr_X509Certificate
	' Token: 0x0400025C RID: 604
	JswAttr_EAPIdentity
	' Token: 0x0400025D RID: 605
	JswAttr_MessageCounter
	' Token: 0x0400025E RID: 606
	JswAttr_PublicKeyHash
	' Token: 0x0400025F RID: 607
	JswAttr_RekeyKey
	' Token: 0x04000260 RID: 608
	JswAttr_KeyLifetime
	' Token: 0x04000261 RID: 609
	JswAttr_PermittedConfigMethods
	' Token: 0x04000262 RID: 610
	JswAttr_SelectedRegistrarConfigMethods
	' Token: 0x04000263 RID: 611
	JswAttr_PrimaryDeviceType
	' Token: 0x04000264 RID: 612
	JswAttr_SecondaryDeviceTypeList
	' Token: 0x04000265 RID: 613
	JswAttr_PortableDevice
	' Token: 0x04000266 RID: 614
	JswAttr_APSetupLocked
	' Token: 0x04000267 RID: 615
	JswAttr_ApplicationExtension
	' Token: 0x04000268 RID: 616
	JswAttr_EAPType
	' Token: 0x04000269 RID: 617
	JswAttr_InitializationVector = 4192
	' Token: 0x0400026A RID: 618
	JswAttr_KeyProvidedAutomatically
	' Token: 0x0400026B RID: 619
	JswAttr_8021xEnabled
	' Token: 0x0400026C RID: 620
	JswAttr_AthDeviceTypeFlags = 24576
	' Token: 0x0400026D RID: 621
	JswAttr_AthDeviceType
	' Token: 0x0400026E RID: 622
	JswAttr_AthExtendedAssociation
	' Token: 0x0400026F RID: 623
	JswAttr_StartAtherosJswAttr = 268435456
	' Token: 0x04000270 RID: 624
	JswAttr_SimpleConfigIEs
	' Token: 0x04000271 RID: 625
	JswAttr_PrivacyBitSet
	' Token: 0x04000272 RID: 626
	JswAttr_Rssi
	' Token: 0x04000273 RID: 627
	JswAttr_SupportedRates
	' Token: 0x04000274 RID: 628
	JswAttr_VendorExtID = 268439556
	' Token: 0x04000275 RID: 629
	JswAttr_ApplicationExtID
	' Token: 0x04000276 RID: 630
	JswAttr_Data
End Enum
