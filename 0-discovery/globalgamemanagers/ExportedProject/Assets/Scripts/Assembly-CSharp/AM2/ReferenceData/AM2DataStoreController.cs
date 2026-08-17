using System;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200030F")]
	public class AM2DataStoreController : CasualDataStoreController
	{
		[Token(Token = "0x4000F2C")]
		[FieldOffset(Offset = "0x48")]
		public AM2DataStore m_dataStore;

		[Token(Token = "0x170003A3")]
		public AM2DataStoreModel Data
		{
			[Token(Token = "0x60018E7")]
			[Address(RVA = "0x9A6F70", Offset = "0x9A6F70", VA = "0x9A6F70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60018E8")]
		[Address(RVA = "0x9A6FD0", Offset = "0x9A6FD0", VA = "0x9A6FD0")]
		public AM2DataStoreController(string sHost, Action<WebRequest> webSend, VersionPlatform platform, Version currentVersion)
		{
		}

		[Token(Token = "0x60018E9")]
		[Address(RVA = "0x9A6FD8", Offset = "0x9A6FD8", VA = "0x9A6FD8", Slot = "10")]
		public override BaseDataStore CreateDataStore()
		{
			return null;
		}
	}
}
