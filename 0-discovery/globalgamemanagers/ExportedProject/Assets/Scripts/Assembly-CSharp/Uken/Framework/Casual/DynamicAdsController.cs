using System;
using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Inventory;
using Uken.Library.Observe;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004A8")]
	public class DynamicAdsController : UkenController, IUkenObserver<List<Unlocker>>
	{
		[Serializable]
		[Token(Token = "0x200081E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821328", Offset = "0x821328")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4002357")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4002358")]
			[FieldOffset(Offset = "0x8")]
			public static Func<DynamicAds, int> _003C_003E9__29_0;

			[Token(Token = "0x60032F5")]
			[Address(RVA = "0xA5D030", Offset = "0xA5D030", VA = "0xA5D030")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60032F6")]
			[Address(RVA = "0xA5D038", Offset = "0xA5D038", VA = "0xA5D038")]
			internal int _003CGetAllAvailableDynamicAds_003Eb__29_0(DynamicAds o)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200081F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821338", Offset = "0x821338")]
		private sealed class _003C_003Ec__DisplayClass34_0
		{
			[Token(Token = "0x4002359")]
			[FieldOffset(Offset = "0x10")]
			public string refName;

			[Token(Token = "0x60032F7")]
			[Address(RVA = "0xA5CB34", Offset = "0xA5CB34", VA = "0xA5CB34")]
			public _003C_003Ec__DisplayClass34_0()
			{
			}

			[Token(Token = "0x60032F8")]
			[Address(RVA = "0xA5D068", Offset = "0xA5D068", VA = "0xA5D068")]
			internal bool _003CForceDynamicAd_003Eb__0(DynamicAds o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4001581")]
		private const string c_bubbleRewardEventName = "bubble_reward";

		[Token(Token = "0x4001582")]
		private const string c_watchAdRewardEventName = "watch_ad_reward";

		[Token(Token = "0x4001583")]
		private const string c_skippedAdRewardEventName = "skipped_ad_reward";

		[Token(Token = "0x4001584")]
		[FieldOffset(Offset = "0x18")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x4001585")]
		[FieldOffset(Offset = "0x20")]
		private FTUEController m_ftueController;

		[Token(Token = "0x4001586")]
		[FieldOffset(Offset = "0x28")]
		private AdsController m_adsController;

		[Token(Token = "0x4001587")]
		[FieldOffset(Offset = "0x30")]
		private UserProfiler m_userProfiler;

		[Token(Token = "0x4001588")]
		[FieldOffset(Offset = "0x38")]
		private VIPStatusController m_vipStatusController;

		[Token(Token = "0x4001589")]
		[FieldOffset(Offset = "0x40")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x400158A")]
		[FieldOffset(Offset = "0x48")]
		private Localizations m_localizationController;

		[Token(Token = "0x400158B")]
		[FieldOffset(Offset = "0x50")]
		private SpeedBoosterController m_speedBoosterController;

		[Token(Token = "0x400158C")]
		[FieldOffset(Offset = "0x58")]
		private UkenUnsubscriber<List<Unlocker>> m_unsubscriber;

		[Token(Token = "0x400158D")]
		[FieldOffset(Offset = "0x60")]
		private List<DynamicAds> m_allDynamicAds;

		[Token(Token = "0x400158E")]
		[FieldOffset(Offset = "0x68")]
		private List<DynamicAds> m_currentlyUnavailableDynamicAds;

		[Token(Token = "0x400158F")]
		[FieldOffset(Offset = "0x70")]
		private List<DynamicAds> m_currentlyAvailableDynamicAds;

		[Token(Token = "0x4001590")]
		[FieldOffset(Offset = "0x78")]
		private bool locked;

		[Token(Token = "0x4001591")]
		[FieldOffset(Offset = "0x80")]
		private UkenObservable<DynamicAdState> m_dynamicAdActiveToggle;

		[Token(Token = "0x600227C")]
		[Address(RVA = "0xA5B568", Offset = "0xA5B568", VA = "0xA5B568")]
		public DynamicAdsController(SharedDataCacheController dataCacheController, FTUEController ftueController, AdsController adsController, UserProfiler userProfiler, VIPStatusController vipStatusController, InventoryController inventoryController, Localizations localizationsController, SpeedBoosterController speedBoosterController)
		{
		}

		[Token(Token = "0x600227D")]
		[Address(RVA = "0xA5B698", Offset = "0xA5B698", VA = "0xA5B698", Slot = "5")]
		public override bool LoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x600227E")]
		[Address(RVA = "0xA5B758", Offset = "0xA5B758", VA = "0xA5B758", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x600227F")]
		[Address(RVA = "0xA5B7E0", Offset = "0xA5B7E0", VA = "0xA5B7E0")]
		private void InitializeDynamicAdLists()
		{
		}

		[Token(Token = "0x6002280")]
		[Address(RVA = "0xA5B9B0", Offset = "0xA5B9B0", VA = "0xA5B9B0")]
		private List<DynamicAds> GetAllUnavailableAds()
		{
			return null;
		}

		[Token(Token = "0x6002281")]
		[Address(RVA = "0xA5BB3C", Offset = "0xA5BB3C", VA = "0xA5BB3C")]
		private List<DynamicAds> GetAllAvailableAds()
		{
			return null;
		}

		[Token(Token = "0x6002282")]
		[Address(RVA = "0xA5B83C", Offset = "0xA5B83C", VA = "0xA5B83C")]
		private void SetCurrentAdActiveState()
		{
		}

		[Token(Token = "0x6002283")]
		[Address(RVA = "0xA5BCC8", Offset = "0xA5BCC8", VA = "0xA5BCC8", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6002284")]
		[Address(RVA = "0xA5BD0C", Offset = "0xA5BD0C", VA = "0xA5BD0C")]
		private void TryToDeactivateDynamicAds()
		{
		}

		[Token(Token = "0x6002285")]
		[Address(RVA = "0xA5BDF0", Offset = "0xA5BDF0", VA = "0xA5BDF0")]
		private void TryToActivateDynamicAds()
		{
		}

		[Token(Token = "0x6002286")]
		[Address(RVA = "0xA5C1B4", Offset = "0xA5C1B4", VA = "0xA5C1B4")]
		private void SetFirstSeenTimeForDynamicAd(DynamicAds dynamicAd)
		{
		}

		[Token(Token = "0x6002287")]
		[Address(RVA = "0xA5C0D0", Offset = "0xA5C0D0", VA = "0xA5C0D0")]
		private void SetUnlockTimeForDynamicAd(DynamicAds dynamicAd)
		{
		}

		[Token(Token = "0x6002288")]
		[Address(RVA = "0xA5C3F4", Offset = "0xA5C3F4", VA = "0xA5C3F4")]
		public List<DynamicAds> GetAllAvailableDynamicAds()
		{
			return null;
		}

		[Token(Token = "0x6002289")]
		[Address(RVA = "0xA5C2A4", Offset = "0xA5C2A4", VA = "0xA5C2A4")]
		public bool DynamicAdsShowRequirementsMet(DynamicAds dynamicAd)
		{
			return default(bool);
		}

		[Token(Token = "0x600228A")]
		[Address(RVA = "0xA5C4F4", Offset = "0xA5C4F4", VA = "0xA5C4F4")]
		public bool IsVideoAdReady(DynamicAds dynamicAd)
		{
			return default(bool);
		}

		[Token(Token = "0x600228B")]
		[Address(RVA = "0xA5C2F8", Offset = "0xA5C2F8", VA = "0xA5C2F8")]
		public void OnDynamicAdStart(DynamicAds dynamicAd)
		{
		}

		[Token(Token = "0x600228C")]
		[Address(RVA = "0xA5C594", Offset = "0xA5C594", VA = "0xA5C594")]
		public void ForceDynamicAd()
		{
		}

		[Token(Token = "0x600228D")]
		[Address(RVA = "0xA5CA04", Offset = "0xA5CA04", VA = "0xA5CA04")]
		public void ForceDynamicAd(string refName)
		{
		}

		[Token(Token = "0x600228E")]
		[Address(RVA = "0xA5BF9C", Offset = "0xA5BF9C", VA = "0xA5BF9C")]
		public void OnDynamicAdEnd(DynamicAds dynamicAd)
		{
		}

		[Token(Token = "0x600228F")]
		[Address(RVA = "0xA5CB3C", Offset = "0xA5CB3C", VA = "0xA5CB3C")]
		public UkenUnsubscriber<DynamicAdState> Subscribe(IUkenObserver<DynamicAdState> observer, bool emitOnSubscribe = false)
		{
			return null;
		}

		[Token(Token = "0x6002290")]
		[Address(RVA = "0xA5CBB4", Offset = "0xA5CBB4", VA = "0xA5CBB4", Slot = "10")]
		public void OnEmit(List<Unlocker> unlockers)
		{
		}

		[Token(Token = "0x6002291")]
		[Address(RVA = "0xA5CCE8", Offset = "0xA5CCE8", VA = "0xA5CCE8", Slot = "8")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x6002292")]
		[Address(RVA = "0xA5CD50", Offset = "0xA5CD50", VA = "0xA5CD50")]
		public bool HasGlobalSpeedBoostReward(DynamicAds dynamicAd)
		{
			return default(bool);
		}

		[Token(Token = "0x6002293")]
		[Address(RVA = "0xA5C74C", Offset = "0xA5C74C", VA = "0xA5C74C")]
		public string GetListOfRewards(DynamicAds dynamicAd)
		{
			return null;
		}

		[Token(Token = "0x6002294")]
		[Address(RVA = "0xA5CD80", Offset = "0xA5CD80", VA = "0xA5CD80")]
		public void GrantRewards(DynamicAds dynamicAd)
		{
		}
	}
}
