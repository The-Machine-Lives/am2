using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000004")]
internal class MoPubAdUnit
{
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly MoPubAdUnit NullMoPubAdUnit;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected readonly string AdUnitId;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected readonly string AdType;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected MoPub.Reward SelectedReward;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x17594F4", Offset = "0x17594F4", VA = "0x17594F4")]
	protected MoPubAdUnit(string adUnitId, [Optional] string adType)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1757174", Offset = "0x1757174", VA = "0x1757174")]
	internal static MoPubAdUnit CreateMoPubAdUnit(string adUnitId, [Optional] string adType)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x17596D4", Offset = "0x17596D4", VA = "0x17596D4", Slot = "4")]
	internal virtual bool IsPluginReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x17596DC", Offset = "0x17596DC", VA = "0x17596DC", Slot = "5")]
	internal virtual void RequestBanner(float width, float height, MoPub.AdPosition position)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x17596E0", Offset = "0x17596E0", VA = "0x17596E0", Slot = "6")]
	internal virtual void ShowBanner(bool shouldShow)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x17596E4", Offset = "0x17596E4", VA = "0x17596E4", Slot = "7")]
	internal virtual void RequestInterstitialAd(string keywords = "", string userDataKeywords = "")
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x17596E8", Offset = "0x17596E8", VA = "0x17596E8", Slot = "8")]
	internal virtual void ShowInterstitialAd()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x17596EC", Offset = "0x17596EC", VA = "0x17596EC", Slot = "9")]
	internal virtual void RequestRewardedVideo([Optional] List<MoPub.LocalMediationSetting> mediationSettings, [Optional] string keywords, [Optional] string userDataKeywords, double latitude = 99999.0, double longitude = 99999.0, [Optional] string customerId)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x17596F0", Offset = "0x17596F0", VA = "0x17596F0", Slot = "10")]
	internal virtual void ShowRewardedVideo(string customData)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x17596F4", Offset = "0x17596F4", VA = "0x17596F4")]
	protected bool CheckPluginReady()
	{
		return default(bool);
	}
}
