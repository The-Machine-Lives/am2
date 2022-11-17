using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Com.Uken.Adlib
{
	[Token(Token = "0x2000006")]
	public class Ads
	{
		[Token(Token = "0x400000D")]
		public const string Version = "1.1.14";

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<AdProvider, IProvider> availableProviders;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x8")]
		private static bool wasInitialized;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8138E8", Offset = "0x8138E8")]
		private static bool _003CKillSwitchActive_003Ek__BackingField;

		[Token(Token = "0x17000006")]
		public static bool KillSwitchActive
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x17D37F0", Offset = "0x17D37F0", VA = "0x17D37F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813938", Offset = "0x813938")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x17D3858", Offset = "0x17D3858", VA = "0x17D3858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813948", Offset = "0x813948")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public static Dictionary<AdProvider, IProvider> AvailableProviders
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x17D38C8", Offset = "0x17D38C8", VA = "0x17D38C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x17D3644", Offset = "0x17D3644", VA = "0x17D3644")]
		static Ads()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x17D3930", Offset = "0x17D3930", VA = "0x17D3930")]
		public static void Initialize(AdPlacement[] adPlacements)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x17D3B54", Offset = "0x17D3B54", VA = "0x17D3B54")]
		public static void Fetch(AdPlacement adPlacement, Action<string, bool> onLoaded, AdProvider adProvider = AdProvider.Mopub)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x17D3D54", Offset = "0x17D3D54", VA = "0x17D3D54")]
		public static bool Show(AdPlacement adPlacement, Action<AdPlacementShowResult> onAdShown, Action<MoPub.ImpressionData> onImpressionTracked, bool forceInvokeOnAdShown = true, AdProvider adProvider = AdProvider.Mopub)
		{
			return default(bool);
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x17D3F94", Offset = "0x17D3F94", VA = "0x17D3F94")]
		public static bool CanBeFetched(AdPlacement adPlacement, AdProvider adProvider = AdProvider.Mopub)
		{
			return default(bool);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x17D40E0", Offset = "0x17D40E0", VA = "0x17D40E0")]
		public static bool IsReady(AdPlacement adPlacement, AdProvider adProvider = AdProvider.Mopub)
		{
			return default(bool);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x17D422C", Offset = "0x17D422C", VA = "0x17D422C")]
		public static void HideBanner(BannerAdPlacement adPlacement, AdProvider adProvider = AdProvider.Mopub)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x17D4370", Offset = "0x17D4370", VA = "0x17D4370")]
		public static void AddAdUnitMopubListener(Action<string> callback, EventListenerManager.AdUnitMopubEvent eventType)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x17D4548", Offset = "0x17D4548", VA = "0x17D4548")]
		public static void RemoveAdUnitMopubListener(Action<string> callback, EventListenerManager.AdUnitMopubEvent eventType)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x17D4720", Offset = "0x17D4720", VA = "0x17D4720")]
		public static void AddAdUnitFailureMopubListener(Action<string, string> callback, EventListenerManager.FailureMopubEvent eventType)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x17D4820", Offset = "0x17D4820", VA = "0x17D4820")]
		public static void RemoveAdUnitFailureMopubListener(Action<string, string> callback, EventListenerManager.FailureMopubEvent eventType)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x17D4920", Offset = "0x17D4920", VA = "0x17D4920")]
		public static void SetKillSwitch(bool activateKillSwitch)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x17D4984", Offset = "0x17D4984", VA = "0x17D4984")]
		public static void ToggleLegitimateInterest(bool blockLegitimateInterest, AdProvider adProvider = AdProvider.Mopub)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x17D3CA4", Offset = "0x17D3CA4", VA = "0x17D3CA4")]
		private static void CheckIfInitialized()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x17D4A98", Offset = "0x17D4A98", VA = "0x17D4A98")]
		public Ads()
		{
		}
	}
}
