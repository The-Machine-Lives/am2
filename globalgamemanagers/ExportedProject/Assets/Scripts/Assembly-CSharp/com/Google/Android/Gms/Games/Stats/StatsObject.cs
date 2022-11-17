using System;
using Com.Google.Android.Gms.Common.Api;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	[Token(Token = "0x200023E")]
	public class StatsObject : JavaObjWrapper, Stats
	{
		[Token(Token = "0x4000CA5")]
		private const string CLASS_NAME = "com/google/android/gms/games/stats/Stats";

		[Token(Token = "0x6001013")]
		[Address(RVA = "0xA50F90", Offset = "0xA50F90", VA = "0xA50F90")]
		public StatsObject(IntPtr ptr)
		{
		}

		[Token(Token = "0x6001014")]
		[Address(RVA = "0xA50F98", Offset = "0xA50F98", VA = "0xA50F98", Slot = "5")]
		public PendingResult<Stats_LoadPlayerStatsResultObject> loadPlayerStats(GoogleApiClient arg_GoogleApiClient_1, bool arg_bool_2)
		{
			return null;
		}
	}
}
