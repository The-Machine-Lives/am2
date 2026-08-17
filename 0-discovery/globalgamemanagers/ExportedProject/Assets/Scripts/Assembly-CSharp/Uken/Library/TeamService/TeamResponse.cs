using Il2CppDummyDll;

namespace Uken.Library.TeamService
{
	[Token(Token = "0x20003ED")]
	public class TeamResponse
	{
		[Token(Token = "0x4001275")]
		[FieldOffset(Offset = "0x10")]
		public string eventId;

		[Token(Token = "0x4001276")]
		[FieldOffset(Offset = "0x18")]
		public int teamIndex;

		[Token(Token = "0x4001277")]
		[FieldOffset(Offset = "0x20")]
		public string userId;

		[Token(Token = "0x4001278")]
		[FieldOffset(Offset = "0x28")]
		public bool newAssignment;

		[Token(Token = "0x6001E41")]
		[Address(RVA = "0xB3DF24", Offset = "0xB3DF24", VA = "0xB3DF24")]
		public TeamResponse()
		{
		}
	}
}
