using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.LeagueService
{
	[Token(Token = "0x200041D")]
	public class LeagueServiceGetLeagueResponse
	{
		[Token(Token = "0x4001321")]
		[FieldOffset(Offset = "0x10")]
		public int entityTierIndex;

		[Token(Token = "0x4001322")]
		[FieldOffset(Offset = "0x18")]
		public string leagueId;

		[Token(Token = "0x4001323")]
		[FieldOffset(Offset = "0x20")]
		public LeagueServiceLeague league;

		[Token(Token = "0x4001324")]
		[FieldOffset(Offset = "0x28")]
		public LeagueServiceRank overallRank;

		[Token(Token = "0x4001325")]
		[FieldOffset(Offset = "0x30")]
		public List<LeagueServiceRank> tierRanks;

		[Token(Token = "0x6001F12")]
		[Address(RVA = "0xBAB658", Offset = "0xBAB658", VA = "0xBAB658")]
		public LeagueServiceGetLeagueResponse()
		{
		}
	}
}
