using Il2CppDummyDll;

namespace Uken.Library.Scoreboards
{
	[Token(Token = "0x20003F3")]
	public class ScoreboardResult
	{
		[Token(Token = "0x400128D")]
		[FieldOffset(Offset = "0x10")]
		public ScoreboardDefinition leaderboard;

		[Token(Token = "0x400128E")]
		[FieldOffset(Offset = "0x18")]
		public ScoreboardEntity selfEntity;

		[Token(Token = "0x6001E4E")]
		[Address(RVA = "0xB3DAB0", Offset = "0xB3DAB0", VA = "0xB3DAB0")]
		public ScoreboardResult()
		{
		}

		[Token(Token = "0x6001E4F")]
		[Address(RVA = "0xB3DB38", Offset = "0xB3DB38", VA = "0xB3DB38", Slot = "4")]
		public virtual string GetLeaderboardReference()
		{
			return null;
		}
	}
}
