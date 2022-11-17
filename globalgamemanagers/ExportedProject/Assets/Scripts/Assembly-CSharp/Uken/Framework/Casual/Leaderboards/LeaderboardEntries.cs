using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual.Leaderboards
{
	[Token(Token = "0x2000591")]
	public class LeaderboardEntries
	{
		[Token(Token = "0x2000865")]
		public class LeaderboardsByName
		{
			[Token(Token = "0x4002412")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<string, Leaderboard> m_leaderboards;

			[Token(Token = "0x600339F")]
			[Address(RVA = "0xA711D4", Offset = "0xA711D4", VA = "0xA711D4")]
			public void AddLeaderboards(List<Leaderboard> leaderboards)
			{
			}

			[Token(Token = "0x60033A0")]
			[Address(RVA = "0xA712F4", Offset = "0xA712F4", VA = "0xA712F4")]
			public Leaderboard GetLeaderboard(string leaderboardName)
			{
				return null;
			}

			[Token(Token = "0x60033A1")]
			[Address(RVA = "0xA71164", Offset = "0xA71164", VA = "0xA71164")]
			public LeaderboardsByName()
			{
			}
		}

		[Token(Token = "0x4001A63")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, LeaderboardsByName> m_resultsByEntityID;

		[Token(Token = "0x6002A91")]
		[Address(RVA = "0xA70B8C", Offset = "0xA70B8C", VA = "0xA70B8C")]
		public void AddLeaderboards(string entityID, List<Leaderboard> leaderboards)
		{
		}

		[Token(Token = "0x6002A92")]
		[Address(RVA = "0xA6FAC8", Offset = "0xA6FAC8", VA = "0xA6FAC8")]
		public Leaderboard GetLatestLeaderboardEntries(string entityID, string leaderboardName)
		{
			return null;
		}

		[Token(Token = "0x6002A93")]
		[Address(RVA = "0xA6F734", Offset = "0xA6F734", VA = "0xA6F734")]
		public LeaderboardEntries()
		{
		}
	}
}
