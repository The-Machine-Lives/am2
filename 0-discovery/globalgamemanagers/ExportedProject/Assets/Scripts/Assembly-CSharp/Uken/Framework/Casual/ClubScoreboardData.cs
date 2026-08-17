using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000564")]
	public class ClubScoreboardData
	{
		[Token(Token = "0x400199B")]
		[FieldOffset(Offset = "0x10")]
		public string m_clubName;

		[Token(Token = "0x400199C")]
		[FieldOffset(Offset = "0x18")]
		public string m_dauberIconPath;

		[Token(Token = "0x6002933")]
		[Address(RVA = "0xA56CF8", Offset = "0xA56CF8", VA = "0xA56CF8")]
		public ClubScoreboardData()
		{
		}

		[Token(Token = "0x6002934")]
		[Address(RVA = "0xA56D5C", Offset = "0xA56D5C", VA = "0xA56D5C")]
		public ClubScoreboardData(string clubName, string dauberIconPath)
		{
		}

		[Token(Token = "0x6002935")]
		[Address(RVA = "0xA56DCC", Offset = "0xA56DCC", VA = "0xA56DCC")]
		public string Serialize()
		{
			return null;
		}

		[Token(Token = "0x6002936")]
		[Address(RVA = "0xA56E20", Offset = "0xA56E20", VA = "0xA56E20")]
		public void Deserialize(string csvText)
		{
		}
	}
}
