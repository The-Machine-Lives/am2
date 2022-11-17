using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	[Token(Token = "0x200023A")]
	public interface PlayerStats
	{
		[Token(Token = "0x6000FF9")]
		float getAverageSessionLength();

		[Token(Token = "0x6000FFA")]
		float getChurnProbability();

		[Token(Token = "0x6000FFB")]
		int getDaysSinceLastPlayed();

		[Token(Token = "0x6000FFC")]
		int getNumberOfPurchases();

		[Token(Token = "0x6000FFD")]
		int getNumberOfSessions();

		[Token(Token = "0x6000FFE")]
		float getSessionPercentile();

		[Token(Token = "0x6000FFF")]
		float getSpendPercentile();

		[Token(Token = "0x6001000")]
		float getSpendProbability();

		[Token(Token = "0x6001001")]
		float getHighSpenderProbability();

		[Token(Token = "0x6001002")]
		float getTotalSpendNext28Days();
	}
}
