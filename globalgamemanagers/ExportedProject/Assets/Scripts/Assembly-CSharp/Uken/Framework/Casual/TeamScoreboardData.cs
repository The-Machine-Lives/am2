using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000563")]
	public class TeamScoreboardData
	{
		[Token(Token = "0x4001999")]
		[FieldOffset(Offset = "0x10")]
		public string m_eventTeamConfigReference;

		[Token(Token = "0x400199A")]
		[FieldOffset(Offset = "0x18")]
		public int m_eventTeamIndex;

		[Token(Token = "0x600292F")]
		[Address(RVA = "0xA9A324", Offset = "0xA9A324", VA = "0xA9A324")]
		public TeamScoreboardData()
		{
		}

		[Token(Token = "0x6002930")]
		[Address(RVA = "0xA9A39C", Offset = "0xA9A39C", VA = "0xA9A39C")]
		public TeamScoreboardData(string eventTeamConfigReference, int eventTeamIndex)
		{
		}

		[Token(Token = "0x6002931")]
		[Address(RVA = "0xA9A418", Offset = "0xA9A418", VA = "0xA9A418")]
		public string Serialize()
		{
			return null;
		}

		[Token(Token = "0x6002932")]
		[Address(RVA = "0xA9A49C", Offset = "0xA9A49C", VA = "0xA9A49C")]
		public void Deserialize(string csvText)
		{
		}
	}
}
