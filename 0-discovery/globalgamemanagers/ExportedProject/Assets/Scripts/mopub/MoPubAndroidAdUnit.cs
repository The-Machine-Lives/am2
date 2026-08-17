using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000007")]
internal class MoPubAndroidAdUnit : MoPubAdUnit
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly AndroidJavaObject _plugin;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Dictionary<MoPub.Reward, AndroidJavaObject> _rewardsDict;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x175956C", Offset = "0x175956C", VA = "0x175956C")]
	internal MoPubAndroidAdUnit(string adUnitId, [Optional] string adType)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x175A720", Offset = "0x175A720", VA = "0x175A720", Slot = "4")]
	internal override bool IsPluginReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x175A7A4", Offset = "0x175A7A4", VA = "0x175A7A4", Slot = "5")]
	internal override void RequestBanner(float width, float height, MoPub.AdPosition position)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x175A988", Offset = "0x175A988", VA = "0x175A988", Slot = "6")]
	internal override void ShowBanner(bool shouldShow)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x175AA98", Offset = "0x175AA98", VA = "0x175AA98", Slot = "7")]
	internal override void RequestInterstitialAd(string keywords = "", string userDataKeywords = "")
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x175ABC4", Offset = "0x175ABC4", VA = "0x175ABC4", Slot = "8")]
	internal override void ShowInterstitialAd()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x175AC58", Offset = "0x175AC58", VA = "0x175AC58", Slot = "9")]
	internal override void RequestRewardedVideo([Optional] List<MoPub.LocalMediationSetting> mediationSettings, [Optional] string keywords, [Optional] string userDataKeywords, double latitude = 99999.0, double longitude = 99999.0, [Optional] string customerId)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x175AF10", Offset = "0x175AF10", VA = "0x175AF10", Slot = "10")]
	internal override void ShowRewardedVideo(string customData)
	{
	}
}
