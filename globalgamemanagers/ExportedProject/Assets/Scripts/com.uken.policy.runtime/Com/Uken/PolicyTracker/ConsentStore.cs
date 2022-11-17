using System;
using Il2CppDummyDll;

namespace Com.Uken.PolicyTracker
{
	[Token(Token = "0x2000002")]
	public static class ConsentStore
	{
		[Token(Token = "0x4000001")]
		private const string MIN_VERSION = "0.0";

		[Token(Token = "0x4000002")]
		private const string PLAYER_PREFS_PREFIX = "uken.policytracker.consent.";

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x181A864", Offset = "0x181A864", VA = "0x181A864")]
		public static Version LatestConsentByType(PolicySystem.PolicyType policyType)
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x181AA08", Offset = "0x181AA08", VA = "0x181AA08")]
		public static void StoreConsent(Policy policy)
		{
		}
	}
}
