using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004EC")]
	public class CasualDataStore<T> : DataStore<T> where T : CasualDataStoreModel, new()
	{
		[Token(Token = "0x4001766")]
		[FieldOffset(Offset = "0x0")]
		protected T m_dataStore;

		[Token(Token = "0x1700066A")]
		public CasualDataStoreModel CasualData
		{
			[Token(Token = "0x60025F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60025F1")]
		public CasualDataStore()
		{
		}
	}
	[Token(Token = "0x20004EF")]
	public class CasualDataStore : CasualDataStore<CasualDataStoreModel>
	{
		[Token(Token = "0x6002615")]
		[Address(RVA = "0xA2ADC8", Offset = "0xA2ADC8", VA = "0xA2ADC8", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x6002616")]
		[Address(RVA = "0xA2ADD4", Offset = "0xA2ADD4", VA = "0xA2ADD4")]
		public CasualDataStore()
		{
		}
	}
}
