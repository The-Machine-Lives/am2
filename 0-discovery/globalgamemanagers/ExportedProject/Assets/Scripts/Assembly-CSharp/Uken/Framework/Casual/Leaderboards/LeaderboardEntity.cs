using Il2CppDummyDll;
using Uken.Library.Scoreboards;

namespace Uken.Framework.Casual.Leaderboards
{
	[Token(Token = "0x2000593")]
	public class LeaderboardEntity
	{
		[Token(Token = "0x4001A6A")]
		[FieldOffset(Offset = "0x10")]
		private ScoreboardEntity m_scoreboardEntity;

		[Token(Token = "0x4001A6B")]
		[FieldOffset(Offset = "0x18")]
		private Leaderboard m_parentLeaderboard;

		[Token(Token = "0x17000777")]
		public long Rank
		{
			[Token(Token = "0x6002AA1")]
			[Address(RVA = "0xA710AC", Offset = "0xA710AC", VA = "0xA710AC")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000778")]
		public long Score
		{
			[Token(Token = "0x6002AA2")]
			[Address(RVA = "0xA710D8", Offset = "0xA710D8", VA = "0xA710D8")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000779")]
		public string EntityId
		{
			[Token(Token = "0x6002AA3")]
			[Address(RVA = "0xA6F5D8", Offset = "0xA6F5D8", VA = "0xA6F5D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700077A")]
		public string EntityData
		{
			[Token(Token = "0x6002AA4")]
			[Address(RVA = "0xA71104", Offset = "0xA71104", VA = "0xA71104")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002AA5")]
		[Address(RVA = "0xA6F5A0", Offset = "0xA6F5A0", VA = "0xA6F5A0")]
		public LeaderboardEntity(ScoreboardEntity e, Leaderboard parentLeaderboard)
		{
		}

		[Token(Token = "0x6002AA6")]
		[Address(RVA = "0xA71130", Offset = "0xA71130", VA = "0xA71130")]
		public LeaderboardType GetEntityType()
		{
			return default(LeaderboardType);
		}

		[Token(Token = "0x6002AA7")]
		[Address(RVA = "0xA7115C", Offset = "0xA7115C", VA = "0xA7115C")]
		public Leaderboard GetLeaderboard()
		{
			return null;
		}
	}
}
