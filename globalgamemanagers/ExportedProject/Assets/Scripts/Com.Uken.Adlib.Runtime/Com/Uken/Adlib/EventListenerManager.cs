using System;
using Il2CppDummyDll;

namespace Com.Uken.Adlib
{
	[Token(Token = "0x200000B")]
	public static class EventListenerManager
	{
		[Token(Token = "0x2000012")]
		public enum AdUnitMopubEvent
		{
			[Token(Token = "0x4000033")]
			OnSdkInitializedEvent = 0,
			[Token(Token = "0x4000034")]
			OnBannerAdClickedEvent = 1,
			[Token(Token = "0x4000035")]
			OnInterstitialLoadedEvent = 2,
			[Token(Token = "0x4000036")]
			OnInterstitialDismissedEvent = 3,
			[Token(Token = "0x4000037")]
			OnInterstitialExpiredEvent = 4,
			[Token(Token = "0x4000038")]
			OnInterstitialShownEvent = 5,
			[Token(Token = "0x4000039")]
			OnInterstitialClickedEvent = 6,
			[Token(Token = "0x400003A")]
			OnRewardedVideoLoadedEvent = 7,
			[Token(Token = "0x400003B")]
			OnRewardedVideoExpiredEvent = 8,
			[Token(Token = "0x400003C")]
			OnRewardedVideoShownEvent = 9,
			[Token(Token = "0x400003D")]
			OnRewardedVideoClickedEvent = 10,
			[Token(Token = "0x400003E")]
			OnRewardedVideoClosedEvent = 11,
			[Token(Token = "0x400003F")]
			OnRewardedVideoLeavingApplicationEvent = 12
		}

		[Token(Token = "0x2000013")]
		public enum FailureMopubEvent
		{
			[Token(Token = "0x4000041")]
			OnBannerAdFailedEvent = 0,
			[Token(Token = "0x4000042")]
			OnInterstitialFailedEvent = 1,
			[Token(Token = "0x4000043")]
			OnRewardedVideoFailedEvent = 2,
			[Token(Token = "0x4000044")]
			OnRewardedVideoFailedToPlayEvent = 3
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x17D4374", Offset = "0x17D4374", VA = "0x17D4374")]
		public static void AddAdUnitMopubListener(Action<string> callback, AdUnitMopubEvent eventType)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x17D454C", Offset = "0x17D454C", VA = "0x17D454C")]
		public static void RemoveAdUnitMopubListener(Action<string> callback, AdUnitMopubEvent eventType)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x17D4724", Offset = "0x17D4724", VA = "0x17D4724")]
		public static void AddAdUnitFailureMopubListener(Action<string, string> callback, FailureMopubEvent eventType)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x17D4824", Offset = "0x17D4824", VA = "0x17D4824")]
		public static void RemoveAdUnitFailureMopubListener(Action<string, string> callback, FailureMopubEvent eventType)
		{
		}
	}
}
