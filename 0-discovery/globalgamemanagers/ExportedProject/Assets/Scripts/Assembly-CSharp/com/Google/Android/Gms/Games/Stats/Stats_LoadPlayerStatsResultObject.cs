using System;
using Com.Google.Android.Gms.Common.Api;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	[Token(Token = "0x2000239")]
	public class Stats_LoadPlayerStatsResultObject : JavaObjWrapper, Stats_LoadPlayerStatsResult, Result
	{
		[Token(Token = "0x4000CA3")]
		private const string CLASS_NAME = "com/google/android/gms/games/stats/Stats$LoadPlayerStatsResult";

		[Token(Token = "0x6000FF6")]
		[Address(RVA = "0xA51120", Offset = "0xA51120", VA = "0xA51120")]
		public Stats_LoadPlayerStatsResultObject(IntPtr ptr)
		{
		}

		[Token(Token = "0x6000FF7")]
		[Address(RVA = "0xA51128", Offset = "0xA51128", VA = "0xA51128", Slot = "5")]
		public PlayerStats getPlayerStats()
		{
			return null;
		}

		[Token(Token = "0x6000FF8")]
		[Address(RVA = "0xA511D4", Offset = "0xA511D4", VA = "0xA511D4", Slot = "6")]
		public Status getStatus()
		{
			return null;
		}
	}
}
