using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20002D5")]
	public enum ResponseStatus
	{
		[Token(Token = "0x4000D6A")]
		Success = 1,
		[Token(Token = "0x4000D6B")]
		SuccessWithStale = 2,
		[Token(Token = "0x4000D6C")]
		LicenseCheckFailed = -1,
		[Token(Token = "0x4000D6D")]
		InternalError = -2,
		[Token(Token = "0x4000D6E")]
		NotAuthorized = -3,
		[Token(Token = "0x4000D6F")]
		VersionUpdateRequired = -4,
		[Token(Token = "0x4000D70")]
		Timeout = -5
	}
}
