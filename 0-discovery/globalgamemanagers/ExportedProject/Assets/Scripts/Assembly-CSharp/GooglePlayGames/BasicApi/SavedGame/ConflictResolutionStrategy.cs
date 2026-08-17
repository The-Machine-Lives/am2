using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	[Token(Token = "0x20002EA")]
	public enum ConflictResolutionStrategy
	{
		[Token(Token = "0x4000DC8")]
		UseLongestPlaytime = 0,
		[Token(Token = "0x4000DC9")]
		UseOriginal = 1,
		[Token(Token = "0x4000DCA")]
		UseUnmerged = 2,
		[Token(Token = "0x4000DCB")]
		UseManual = 3,
		[Token(Token = "0x4000DCC")]
		UseLastKnownGood = 4,
		[Token(Token = "0x4000DCD")]
		UseMostRecentlySaved = 5
	}
}
