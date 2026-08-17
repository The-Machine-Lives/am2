using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20002D6")]
	public enum UIStatus
	{
		[Token(Token = "0x4000D72")]
		Valid = 1,
		[Token(Token = "0x4000D73")]
		InternalError = -2,
		[Token(Token = "0x4000D74")]
		NotAuthorized = -3,
		[Token(Token = "0x4000D75")]
		VersionUpdateRequired = -4,
		[Token(Token = "0x4000D76")]
		Timeout = -5,
		[Token(Token = "0x4000D77")]
		UserClosedUI = -6,
		[Token(Token = "0x4000D78")]
		UiBusy = -12,
		[Token(Token = "0x4000D79")]
		LeftRoom = -18
	}
}
