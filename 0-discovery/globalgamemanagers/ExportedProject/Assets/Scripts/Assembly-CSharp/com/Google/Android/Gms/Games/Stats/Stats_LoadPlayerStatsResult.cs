using Com.Google.Android.Gms.Common.Api;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	[Token(Token = "0x200023D")]
	public interface Stats_LoadPlayerStatsResult : Result
	{
		[Token(Token = "0x6001012")]
		PlayerStats getPlayerStats();
	}
}
