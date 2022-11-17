using Il2CppDummyDll;

namespace Uken.Library.LeagueService
{
	[Token(Token = "0x2000417")]
	public class LeagueServiceEntity
	{
		[Token(Token = "0x4001301")]
		[FieldOffset(Offset = "0x10")]
		public string entityId;

		[Token(Token = "0x4001302")]
		[FieldOffset(Offset = "0x18")]
		public string entityData;

		[Token(Token = "0x4001303")]
		[FieldOffset(Offset = "0x20")]
		public int point;

		[Token(Token = "0x4001304")]
		[FieldOffset(Offset = "0x24")]
		public int rank;

		[Token(Token = "0x6001F0C")]
		[Address(RVA = "0xBAB650", Offset = "0xBAB650", VA = "0xBAB650")]
		public LeagueServiceEntity()
		{
		}
	}
}
