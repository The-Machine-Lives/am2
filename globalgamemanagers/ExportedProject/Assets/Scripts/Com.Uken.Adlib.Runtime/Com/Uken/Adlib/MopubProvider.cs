using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Com.Uken.Adlib
{
	[Token(Token = "0x2000011")]
	public class MopubProvider : IProvider
	{
		[Token(Token = "0x2000014")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8138C8", Offset = "0x8138C8")]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x4000045")]
			[FieldOffset(Offset = "0x10")]
			public MopubProvider _003C_003E4__this;

			[Token(Token = "0x4000046")]
			[FieldOffset(Offset = "0x18")]
			public List<string> interstitialAdUnits;

			[Token(Token = "0x4000047")]
			[FieldOffset(Offset = "0x20")]
			public List<string> rewardedAdUnits;

			[Token(Token = "0x4000048")]
			[FieldOffset(Offset = "0x28")]
			public List<string> bannerAdUnits;

			[Token(Token = "0x600005F")]
			[Address(RVA = "0x17D56E4", Offset = "0x17D56E4", VA = "0x17D56E4")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000060")]
			[Address(RVA = "0x17D80E8", Offset = "0x17D80E8", VA = "0x17D80E8")]
			internal void _003CInitialize_003Eb__0(string adUnitId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8138D8", Offset = "0x8138D8")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400004A")]
			[FieldOffset(Offset = "0x8")]
			public static Action<string> _003C_003E9__16_10;

			[Token(Token = "0x6000062")]
			[Address(RVA = "0x17D8000", Offset = "0x17D8000", VA = "0x17D8000")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000063")]
			[Address(RVA = "0x17D8008", Offset = "0x17D8008", VA = "0x17D8008")]
			internal void _003CRegisterListeners_003Eb__16_10(string msg)
			{
			}
		}

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, bool> loadedAdUnits;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, List<Action<string, bool>>> fetchActions;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, Action<AdPlacementShowResult>> adUnitShowCallbacks;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, Action<MoPub.ImpressionData>> adUnitImpressionTrackedCallbacks;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x30")]
		private AdPlacement[] adPlacements;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x38")]
		private bool blockLegitimateInterest;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x17D4F44", Offset = "0x17D4F44", VA = "0x17D4F44", Slot = "4")]
		public string GetName()
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x17D4F8C", Offset = "0x17D4F8C", VA = "0x17D4F8C", Slot = "5")]
		public string GetVersionNumber()
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x17D4FD4", Offset = "0x17D4FD4", VA = "0x17D4FD4", Slot = "6")]
		public void Initialize(AdPlacement[] allAdPlacements)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x17D5FC0", Offset = "0x17D5FC0", VA = "0x17D5FC0", Slot = "10")]
		public bool CanBeFetched(AdPlacement adPlacement)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x17D5FFC", Offset = "0x17D5FFC", VA = "0x17D5FFC", Slot = "11")]
		public void HideBanner(BannerAdPlacement adPlacement)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x17D6088", Offset = "0x17D6088", VA = "0x17D6088", Slot = "12")]
		public void BlockLegitimateInterest(bool blockLI)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x17D6094", Offset = "0x17D6094", VA = "0x17D6094", Slot = "7")]
		public bool IsAdReady(AdPlacement adPlacement)
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x17D6178", Offset = "0x17D6178", VA = "0x17D6178", Slot = "8")]
		public void FetchAd(AdPlacement adPlacement, Action<string, bool> onLoaded)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x17D6434", Offset = "0x17D6434", VA = "0x17D6434", Slot = "9")]
		public bool ShowAd(AdPlacement adPlacement, bool forceInvokeOnAdShown, Action<AdPlacementShowResult> onAdShown, Action<MoPub.ImpressionData> onImpressionTracked)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x17D5A7C", Offset = "0x17D5A7C", VA = "0x17D5A7C")]
		private void InitializeSDKs(string adUnitToInitialize)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x17D56EC", Offset = "0x17D56EC", VA = "0x17D56EC")]
		private void RegisterListeners()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x17D6DA0", Offset = "0x17D6DA0", VA = "0x17D6DA0")]
		private void LoadPluginsForAdUnits(string[] interstitial, string[] rewarded, string[] banner)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x17D6E30", Offset = "0x17D6E30", VA = "0x17D6E30")]
		private void OnAdFailedToPlay(AdType adType, string adUnitId, string errorMessage)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x17D7100", Offset = "0x17D7100", VA = "0x17D7100")]
		private void OnAdFailedToLoad(AdType adType, string adUnitId, string errorMessage)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x17D7404", Offset = "0x17D7404", VA = "0x17D7404")]
		private void OnAdLoaded(string adUnitId)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x17D767C", Offset = "0x17D767C", VA = "0x17D767C")]
		private AdPlacement GetAdPlacementForAdUnit(string adUnitId)
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x17D7798", Offset = "0x17D7798", VA = "0x17D7798")]
		private void OnAdClosed(AdType adType, string adUnitId, AdResult result)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x17D6FF0", Offset = "0x17D6FF0", VA = "0x17D6FF0")]
		private void InvokeOnShowCallback(string adUnitId, AdResult result)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x17D78B8", Offset = "0x17D78B8", VA = "0x17D78B8")]
		private void InvokeOnImpressionTrackedCallback(string adUnitId, MoPub.ImpressionData impressionData)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x17D68C0", Offset = "0x17D68C0", VA = "0x17D68C0")]
		private void ClearUnusedCallbacks(string adUnitId, bool forceInvokeCallback)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x17D6638", Offset = "0x17D6638", VA = "0x17D6638")]
		private void ShowBannerAd(AdPlacement adPlacement, string adUnitId)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x17D6B04", Offset = "0x17D6B04", VA = "0x17D6B04")]
		private void ShowVideoAd(AdPlacement adPlacement, string adUnitId)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x17D61F0", Offset = "0x17D61F0", VA = "0x17D61F0")]
		private void Fetch(AdType adType, string adUnitId, Action<string, bool> onLoaded)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x17D3700", Offset = "0x17D3700", VA = "0x17D3700")]
		public MopubProvider()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x17D79E4", Offset = "0x17D79E4", VA = "0x17D79E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8139A8", Offset = "0x8139A8")]
		private void _003CRegisterListeners_003Eb__16_0(string adUnitId)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x17D7AA8", Offset = "0x17D7AA8", VA = "0x17D7AA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8139B8", Offset = "0x8139B8")]
		private void _003CRegisterListeners_003Eb__16_1(string adUnitId)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x17D7B6C", Offset = "0x17D7B6C", VA = "0x17D7B6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8139C8", Offset = "0x8139C8")]
		private void _003CRegisterListeners_003Eb__16_2(string adUnitId)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x17D7C6C", Offset = "0x17D7C6C", VA = "0x17D7C6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8139D8", Offset = "0x8139D8")]
		private void _003CRegisterListeners_003Eb__16_3(string adUnitId, string label, float amount)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x17D7E38", Offset = "0x17D7E38", VA = "0x17D7E38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8139E8", Offset = "0x8139E8")]
		private void _003CRegisterListeners_003Eb__16_4(string adUnitId)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x17D7F38", Offset = "0x17D7F38", VA = "0x17D7F38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8139F8", Offset = "0x8139F8")]
		private void _003CRegisterListeners_003Eb__16_5(string adUnitId, float height)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x17D7F3C", Offset = "0x17D7F3C", VA = "0x17D7F3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813A08", Offset = "0x813A08")]
		private void _003CRegisterListeners_003Eb__16_6(string adUnitId, string errorMessage)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x17D7F54", Offset = "0x17D7F54", VA = "0x17D7F54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813A18", Offset = "0x813A18")]
		private void _003CRegisterListeners_003Eb__16_7(string adUnitId, string errorMessage)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x17D7F6C", Offset = "0x17D7F6C", VA = "0x17D7F6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813A28", Offset = "0x813A28")]
		private void _003CRegisterListeners_003Eb__16_8(string adUnitId, string errorMessage)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x17D7F84", Offset = "0x17D7F84", VA = "0x17D7F84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813A38", Offset = "0x813A38")]
		private void _003CRegisterListeners_003Eb__16_9(string adUnitId, string errorMessage)
		{
		}
	}
}
