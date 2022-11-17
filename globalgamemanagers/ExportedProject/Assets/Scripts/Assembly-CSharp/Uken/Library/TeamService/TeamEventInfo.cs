using Il2CppDummyDll;

namespace Uken.Library.TeamService
{
	[Token(Token = "0x20003E8")]
	public class TeamEventInfo
	{
		[Token(Token = "0x4001263")]
		[FieldOffset(Offset = "0x10")]
		public string eventId;

		[Token(Token = "0x4001264")]
		[FieldOffset(Offset = "0x18")]
		public int expireTime;

		[Token(Token = "0x4001265")]
		[FieldOffset(Offset = "0x1C")]
		public int startTime;

		[Token(Token = "0x4001266")]
		[FieldOffset(Offset = "0x20")]
		public int endTime;

		[Token(Token = "0x4001267")]
		[FieldOffset(Offset = "0x28")]
		public string strategy;

		[Token(Token = "0x4001268")]
		[FieldOffset(Offset = "0x30")]
		public int teamCount;

		[Token(Token = "0x4001269")]
		[FieldOffset(Offset = "0x34")]
		public int maxEntityCount;

		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0xB3DE1C", Offset = "0xB3DE1C", VA = "0xB3DE1C")]
		public TeamEventInfo()
		{
		}
	}
}
