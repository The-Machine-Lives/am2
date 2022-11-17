using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x20002FA")]
	public enum InitializationStatus
	{
		[Token(Token = "0x4000DED")]
		Success = 0,
		[Token(Token = "0x4000DEE")]
		VersionUpdateRequired = 1,
		[Token(Token = "0x4000DEF")]
		InternalError = 2
	}
}
