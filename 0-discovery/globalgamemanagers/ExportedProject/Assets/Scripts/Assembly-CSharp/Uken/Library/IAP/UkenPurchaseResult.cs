using Il2CppDummyDll;

namespace Uken.Library.IAP
{
	[Token(Token = "0x2000434")]
	public enum UkenPurchaseResult
	{
		[Token(Token = "0x400136F")]
		Started = 0,
		[Token(Token = "0x4001370")]
		Success = 1,
		[Token(Token = "0x4001371")]
		Cancelled = 2,
		[Token(Token = "0x4001372")]
		Failed = 3,
		[Token(Token = "0x4001373")]
		InProgress = 4,
		[Token(Token = "0x4001374")]
		Claimed = 5
	}
}
