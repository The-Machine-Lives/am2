using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004F9")]
	public class GameSettings : DepotController
	{
		[Token(Token = "0x17000691")]
		private DepotEntity<RDGameSetting> m_GameSettings
		{
			[Token(Token = "0x6002648")]
			[Address(RVA = "0xA680AC", Offset = "0xA680AC", VA = "0xA680AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002649")]
		[Address(RVA = "0xA68214", Offset = "0xA68214", VA = "0xA68214")]
		public GameSettings(DataStoreController controller)
		{
		}

		[Token(Token = "0x600264A")]
		[Address(RVA = "0xA6821C", Offset = "0xA6821C", VA = "0xA6821C")]
		public string GetString(string reference)
		{
			return null;
		}

		[Token(Token = "0x600264B")]
		[Address(RVA = "0xA68308", Offset = "0xA68308", VA = "0xA68308")]
		public int GetInt(string reference, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x600264C")]
		[Address(RVA = "0xA68344", Offset = "0xA68344", VA = "0xA68344")]
		public float GetFloat(string reference, float defaultValue)
		{
			return default(float);
		}
	}
}
