using System;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004EE")]
	public class CasualDataStoreController : DataStoreController
	{
		[Token(Token = "0x4001767")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F984", Offset = "0x82F984")]
		private string _003CdataStoreDefaultsPath_003Ek__BackingField;

		[Token(Token = "0x17000687")]
		public string dataStoreDefaultsPath
		{
			[Token(Token = "0x6002610")]
			[Address(RVA = "0xA2AE24", Offset = "0xA2AE24", VA = "0xA2AE24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839F3C", Offset = "0x839F3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002611")]
			[Address(RVA = "0xA2AE2C", Offset = "0xA2AE2C", VA = "0xA2AE2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839F4C", Offset = "0x839F4C")]
			set
			{
			}
		}

		[Token(Token = "0x6002612")]
		[Address(RVA = "0xA2AE34", Offset = "0xA2AE34", VA = "0xA2AE34")]
		public CasualDataStoreController(string hostURL, Action<WebRequest> webSend, VersionPlatform platform, Version currentVersion)
		{
		}

		[Token(Token = "0x6002613")]
		[Address(RVA = "0xA2AEE0", Offset = "0xA2AEE0", VA = "0xA2AEE0", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6002614")]
		[Address(RVA = "0xA2B020", Offset = "0xA2B020", VA = "0xA2B020", Slot = "10")]
		public override BaseDataStore CreateDataStore()
		{
			return null;
		}
	}
}
