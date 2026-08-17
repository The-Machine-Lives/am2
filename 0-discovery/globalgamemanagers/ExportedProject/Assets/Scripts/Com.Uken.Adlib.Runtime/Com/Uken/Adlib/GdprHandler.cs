using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Com.Uken.Adlib
{
	[Token(Token = "0x200000D")]
	public static class GdprHandler
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x17D4D28", Offset = "0x17D4D28", VA = "0x17D4D28")]
		public static void GetConsentIfApplicable(bool blockLegitimateInterest, [Optional] Action<MoPub.Consent.Status, MoPub.Consent.Status, bool> onConsentUpdated)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x17D4EA8", Offset = "0x17D4EA8", VA = "0x17D4EA8")]
		public static bool AllowPersonalizedAds(bool blockLegitimateInterest)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x17D4E00", Offset = "0x17D4E00", VA = "0x17D4E00")]
		private static ConsentStatus GetCurrentGdprStatus()
		{
			return default(ConsentStatus);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x17D4EE4", Offset = "0x17D4EE4", VA = "0x17D4EE4")]
		private static void OnConsentDialogLoaded()
		{
		}
	}
}
