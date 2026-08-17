using Il2CppDummyDll;

namespace Opencoding.LogHistory
{
	[Token(Token = "0x2000005")]
	public enum LogHistoryLogType
	{
		[Token(Token = "0x400000B")]
		Error = 0,
		[Token(Token = "0x400000C")]
		Assert = 1,
		[Token(Token = "0x400000D")]
		Warning = 2,
		[Token(Token = "0x400000E")]
		Log = 3,
		[Token(Token = "0x400000F")]
		Exception = 4,
		[Token(Token = "0x4000010")]
		ConsoleInput = 5
	}
}
