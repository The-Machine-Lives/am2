using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.LeagueService
{
	[Token(Token = "0x2000421")]
	public class LeagueServiceGetTierResponse
	{
		[Token(Token = "0x400132C")]
		[FieldOffset(Offset = "0x10")]
		public List<LeagueServiceEntity> topEntities;

		[Token(Token = "0x400132D")]
		[FieldOffset(Offset = "0x18")]
		public List<LeagueServiceEntity> aboveEntities;

		[Token(Token = "0x400132E")]
		[FieldOffset(Offset = "0x20")]
		public List<LeagueServiceEntity> belowEntities;

		[Token(Token = "0x400132F")]
		[FieldOffset(Offset = "0x28")]
		public LeagueServiceEntity selfEntity;

		[Token(Token = "0x4001330")]
		[FieldOffset(Offset = "0x30")]
		public int tierIndex;

		[Token(Token = "0x6001F16")]
		[Address(RVA = "0xBAB668", Offset = "0xBAB668", VA = "0xBAB668")]
		public LeagueServiceGetTierResponse()
		{
		}
	}
}
