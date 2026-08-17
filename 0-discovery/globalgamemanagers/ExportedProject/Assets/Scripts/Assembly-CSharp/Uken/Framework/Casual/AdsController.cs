using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004C2")]
	public class AdsController : UkenController
	{
		[Token(Token = "0x200082C")]
		public enum AdShowState
		{
			[Token(Token = "0x4002372")]
			Failed = 0,
			[Token(Token = "0x4002373")]
			Finished = 1,
			[Token(Token = "0x4002374")]
			Skipped = 2
		}

		[Token(Token = "0x200082D")]
		public enum WatchType
		{
			[Token(Token = "0x4002376")]
			Video = 0,
			[Token(Token = "0x4002377")]
			Interstitial = 1,
			[Token(Token = "0x4002378")]
			Skippable = 2,
			[Token(Token = "0x4002379")]
			Signal = 3
		}

		[Token(Token = "0x200082E")]
		public enum CanWatchResult
		{
			[Token(Token = "0x400237B")]
			Can_Watch = 0,
			[Token(Token = "0x400237C")]
			Loading = 1,
			[Token(Token = "0x400237D")]
			No_Network = 2,
			[Token(Token = "0x400237E")]
			No_Fill = 3,
			[Token(Token = "0x400237F")]
			Unavailable = 4
		}

		[Token(Token = "0x200082F")]
		public class LogName
		{
			[Token(Token = "0x4002380")]
			public const string View = "view";

			[Token(Token = "0x4002381")]
			public const string Click = "click";

			[Token(Token = "0x4002382")]
			public const string AdRewarded = "ad_rewarded";

			[Token(Token = "0x4002383")]
			public const string AdStarted = "ad_started";

			[Token(Token = "0x4002384")]
			public const string AdFinished = "ad_finished";

			[Token(Token = "0x4002385")]
			public const string AdAborted = "ad_aborted";

			[Token(Token = "0x4002386")]
			public const string AdErrored = "ad_errored";

			[Token(Token = "0x4002387")]
			public const string CantDisplayAd = "cant_display_ad";

			[Token(Token = "0x4002388")]
			public const string DontShowInterstitialAd = "dont_show_interstitial_ad";

			[Token(Token = "0x600332A")]
			[Address(RVA = "0xA23BD0", Offset = "0xA23BD0", VA = "0xA23BD0")]
			public LogName()
			{
			}
		}

		[Token(Token = "0x400164A")]
		public const string c_unityVideoAdsFeatureReference = "unity_video_ads_android";

		[Token(Token = "0x400164B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x82EB8C", Offset = "0x82EB8C")]
		public const string VideoAdRewardsMetaData = "video_add_rewards_counter";

		[Token(Token = "0x400164C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x82EBC4", Offset = "0x82EBC4")]
		public const string StoreRewardAdsMetaData = "store_reward_ads";

		[Token(Token = "0x400164D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		protected bool bDebugAds;

		[Token(Token = "0x400164E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string adRequestID;

		[Token(Token = "0x400164F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool bForceDisableAds;

		[Token(Token = "0x4001650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action<AdShowState> m_onDisplayComplete;

		[Token(Token = "0x4001651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WatchType lastRequestedWatchType;

		[Token(Token = "0x4001652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string lastRequestedVideoAdCurrency;

		[Token(Token = "0x4001653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private long lastRequestedRewardAmount;

		[Token(Token = "0x4001654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool lastRequestIsDynamic;

		[Token(Token = "0x4001655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AdConfig lastAdConfig;

		[Token(Token = "0x4001656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, long> lastTransaction;

		[Token(Token = "0x4001657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AdConfigs adConfigs;

		[Token(Token = "0x4001658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private VIPStatusController m_vipStatusController;

		[Token(Token = "0x4001659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ExternalAdProvider m_externalProvider;

		[Token(Token = "0x60023FA")]
		[Address(RVA = "0xA22660", Offset = "0xA22660", VA = "0xA22660")]
		public AdsController()
		{
		}

		[Token(Token = "0x60023FB")]
		[Address(RVA = "0xA226B8", Offset = "0xA226B8", VA = "0xA226B8")]
		public void SetExternalProvider(ExternalAdProvider newProvider)
		{
		}

		[Token(Token = "0x60023FC")]
		[Address(RVA = "0xA226D8", Offset = "0xA226D8", VA = "0xA226D8", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60023FD")]
		[Address(RVA = "0xA22840", Offset = "0xA22840", VA = "0xA22840", Slot = "10")]
		public virtual bool IsCurrentPlatformSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x60023FE")]
		[Address(RVA = "0xA22860", Offset = "0xA22860", VA = "0xA22860")]
		private void GrantRewardsandTrackAdWatch(AdConfig adConfig, WatchType watchType, Dictionary<string, long> transactions)
		{
		}

		[Token(Token = "0x60023FF")]
		[Address(RVA = "0xA2291C", Offset = "0xA2291C", VA = "0xA2291C")]
		public void HandleAdTriggered(AdConfig adConfig, Action<AdShowState> onComplete, bool isDynamic = false, [Optional] Dictionary<string, long> transactions)
		{
		}

		[Token(Token = "0x6002400")]
		[Address(RVA = "0xA229E8", Offset = "0xA229E8", VA = "0xA229E8")]
		private void ClaimSkippableRewards(AdConfig adConfig, Action<AdShowState> onComplete, WatchType watchType, Dictionary<string, long> transactions)
		{
		}

		[Token(Token = "0x6002401")]
		[Address(RVA = "0xA22A80", Offset = "0xA22A80", VA = "0xA22A80")]
		private void HandleViewAd(AdConfig adConfig, Action<AdShowState> onComplete, bool isDynamic, Dictionary<string, long> transactions)
		{
		}

		[Token(Token = "0x6002402")]
		[Address(RVA = "0xA22BAC", Offset = "0xA22BAC", VA = "0xA22BAC", Slot = "11")]
		public virtual CanWatchResult CanDisplayAds(WatchType type)
		{
			return default(CanWatchResult);
		}

		[Token(Token = "0x6002403")]
		[Address(RVA = "0xA22F20", Offset = "0xA22F20", VA = "0xA22F20", Slot = "12")]
		public virtual bool DisplayVideoAd(Action<AdShowState> onComplete, string rewardType, long rewardAmount, bool isDynamic, AdConfig adConfig, Dictionary<string, long> transactions)
		{
			return default(bool);
		}

		[Token(Token = "0x6002404")]
		[Address(RVA = "0xA232E0", Offset = "0xA232E0", VA = "0xA232E0")]
		private void StoreLastAdData(string rewardType, long rewardAmount, bool isDynamic, AdConfig adConfig, Dictionary<string, long> transactions)
		{
		}

		[Token(Token = "0x6002405")]
		[Address(RVA = "0xA232F8", Offset = "0xA232F8", VA = "0xA232F8", Slot = "13")]
		public virtual void OnDisplayComplete(AdShowState state)
		{
		}

		[Token(Token = "0x6002406")]
		[Address(RVA = "0xA23878", Offset = "0xA23878", VA = "0xA23878")]
		public void PrepareRewardedAdIfNecessary()
		{
		}

		[Token(Token = "0x6002407")]
		[Address(RVA = "0xA238D0", Offset = "0xA238D0", VA = "0xA238D0", Slot = "8")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x6002408")]
		[Address(RVA = "0xA23904", Offset = "0xA23904", VA = "0xA23904")]
		public void PrepareRewardedAdIfAvailable()
		{
		}

		[Token(Token = "0x6002409")]
		[Address(RVA = "0xA23994", Offset = "0xA23994", VA = "0xA23994", Slot = "14")]
		public virtual bool ShouldShowInterstitialAd()
		{
			return default(bool);
		}

		[Token(Token = "0x600240A")]
		[Address(RVA = "0xA239CC", Offset = "0xA239CC", VA = "0xA239CC", Slot = "15")]
		public virtual bool DisplayInterstitialAd(Action<AdShowState> onComplete)
		{
			return default(bool);
		}
	}
}
