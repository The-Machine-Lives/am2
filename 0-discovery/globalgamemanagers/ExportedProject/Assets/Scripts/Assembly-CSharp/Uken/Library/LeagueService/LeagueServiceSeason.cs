using Il2CppDummyDll;

namespace Uken.Library.LeagueService
{
	[Token(Token = "0x200041A")]
	public class LeagueServiceSeason
	{
		[Token(Token = "0x4001314")]
		[FieldOffset(Offset = "0x10")]
		public long duration;

		[Token(Token = "0x4001315")]
		[FieldOffset(Offset = "0x18")]
		public long initTime;

		[Token(Token = "0x4001316")]
		[FieldOffset(Offset = "0x20")]
		public bool repeat;

		[Token(Token = "0x6001F0F")]
		[Address(RVA = "0xBAB680", Offset = "0xBAB680", VA = "0xBAB680")]
		public LeagueServiceSeason()
		{
		}
	}
}
