using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.LeagueService
{
	[Token(Token = "0x2000419")]
	public class LeagueServiceRank
	{
		[Token(Token = "0x400130E")]
		[FieldOffset(Offset = "0x10")]
		public int tierIndex;

		[Token(Token = "0x400130F")]
		[FieldOffset(Offset = "0x18")]
		public LeagueServiceEntity selfEntity;

		[Token(Token = "0x4001310")]
		[FieldOffset(Offset = "0x20")]
		public List<LeagueServiceEntity> aboveEntities;

		[Token(Token = "0x4001311")]
		[FieldOffset(Offset = "0x28")]
		public List<LeagueServiceEntity> belowEntities;

		[Token(Token = "0x4001312")]
		[FieldOffset(Offset = "0x30")]
		public List<LeagueServiceEntity> topEntities;

		[Token(Token = "0x4001313")]
		[FieldOffset(Offset = "0x38")]
		public int totalEntityNumber;

		[Token(Token = "0x6001F0E")]
		[Address(RVA = "0xBAB678", Offset = "0xBAB678", VA = "0xBAB678")]
		public LeagueServiceRank()
		{
		}
	}
}
