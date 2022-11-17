using Com.Google.Android.Gms.Common.Api;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	[Token(Token = "0x200023C")]
	public interface Stats
	{
		[Token(Token = "0x6001011")]
		PendingResult<Stats_LoadPlayerStatsResultObject> loadPlayerStats(GoogleApiClient arg_GoogleApiClient_1, bool arg_bool_2);
	}
}
