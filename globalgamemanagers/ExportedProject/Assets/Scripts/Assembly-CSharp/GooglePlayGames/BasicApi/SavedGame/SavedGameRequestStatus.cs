using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	[Token(Token = "0x20002EB")]
	public enum SavedGameRequestStatus
	{
		[Token(Token = "0x4000DCF")]
		Success = 1,
		[Token(Token = "0x4000DD0")]
		TimeoutError = -1,
		[Token(Token = "0x4000DD1")]
		InternalError = -2,
		[Token(Token = "0x4000DD2")]
		AuthenticationError = -3,
		[Token(Token = "0x4000DD3")]
		BadInputError = -4
	}
}
