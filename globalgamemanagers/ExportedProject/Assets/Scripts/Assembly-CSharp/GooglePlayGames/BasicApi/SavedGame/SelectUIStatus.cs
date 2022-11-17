using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	[Token(Token = "0x20002EC")]
	public enum SelectUIStatus
	{
		[Token(Token = "0x4000DD5")]
		SavedGameSelected = 1,
		[Token(Token = "0x4000DD6")]
		UserClosedUI = 2,
		[Token(Token = "0x4000DD7")]
		InternalError = -1,
		[Token(Token = "0x4000DD8")]
		TimeoutError = -2,
		[Token(Token = "0x4000DD9")]
		AuthenticationError = -3,
		[Token(Token = "0x4000DDA")]
		BadInputError = -4
	}
}
