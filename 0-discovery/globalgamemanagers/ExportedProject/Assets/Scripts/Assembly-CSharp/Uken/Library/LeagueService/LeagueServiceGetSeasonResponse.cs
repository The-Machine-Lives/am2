using Il2CppDummyDll;

namespace Uken.Library.LeagueService
{
	[Token(Token = "0x200041F")]
	public class LeagueServiceGetSeasonResponse
	{
		[Token(Token = "0x4001326")]
		[FieldOffset(Offset = "0x10")]
		public string entityId;

		[Token(Token = "0x4001327")]
		[FieldOffset(Offset = "0x18")]
		public string entityData;

		[Token(Token = "0x4001328")]
		[FieldOffset(Offset = "0x20")]
		public int latestRank;

		[Token(Token = "0x4001329")]
		[FieldOffset(Offset = "0x24")]
		public int latestScore;

		[Token(Token = "0x400132A")]
		[FieldOffset(Offset = "0x28")]
		public LeagueServiceLeague league;

		[Token(Token = "0x400132B")]
		[FieldOffset(Offset = "0x30")]
		public LeagueServiceTier tier;

		[Token(Token = "0x6001F14")]
		[Address(RVA = "0xBAB660", Offset = "0xBAB660", VA = "0xBAB660")]
		public LeagueServiceGetSeasonResponse()
		{
		}
	}
}
