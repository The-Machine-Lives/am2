using Il2CppDummyDll;

namespace Uken.Library.TeamService
{
	[Token(Token = "0x20003EB")]
	public enum TeamErrorCode
	{
		[Token(Token = "0x4001271")]
		Ok = 0,
		[Token(Token = "0x4001272")]
		ExpiredEvent = 1,
		[Token(Token = "0x4001273")]
		InvalidTeam = 2,
		[Token(Token = "0x4001274")]
		Unknown = 9999
	}
}
