using System;
using System.Collections.Generic;
using AM2;
using Il2CppDummyDll;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004E3")]
	public class AdConfigs : DepotController
	{
		[Serializable]
		[Token(Token = "0x2000843")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821498", Offset = "0x821498")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40023AA")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40023AB")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<AdConfig> _003C_003E9__27_0;

			[Token(Token = "0x6003358")]
			[Address(RVA = "0xA21E00", Offset = "0xA21E00", VA = "0xA21E00")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6003359")]
			[Address(RVA = "0xA21E08", Offset = "0xA21E08", VA = "0xA21E08")]
			internal int _003CGetOwnedAdConfigsSortedByPriority_003Eb__27_0(AdConfig adConfig1, AdConfig adConfig2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400171B")]
		public const string c_persistenNotificationFeatureKey = "persistent_ad_notification";

		[Token(Token = "0x400171C")]
		private const string c_adItemType = "AdItem";

		[Token(Token = "0x400171D")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F14C", Offset = "0x82F14C")]
		private bool _003CpersistentNotification_003Ek__BackingField;

		[Token(Token = "0x400171E")]
		[FieldOffset(Offset = "0x24")]
		public int NumberOfRoundsPlayed;

		[Token(Token = "0x400171F")]
		[FieldOffset(Offset = "0x28")]
		private float m_refreshTime;

		[Token(Token = "0x4001720")]
		[FieldOffset(Offset = "0x2C")]
		public bool HasPlayedRound;

		[Token(Token = "0x4001721")]
		[FieldOffset(Offset = "0x2D")]
		private bool m_previousHasAdViews;

		[Token(Token = "0x4001722")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, AdConfig> m_dataCache;

		[Token(Token = "0x4001723")]
		[FieldOffset(Offset = "0x38")]
		private UserSegments m_userSegments;

		[Token(Token = "0x4001724")]
		[FieldOffset(Offset = "0x40")]
		private UserProfiler m_userProfiler;

		[Token(Token = "0x4001725")]
		[FieldOffset(Offset = "0x48")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x4001726")]
		[FieldOffset(Offset = "0x50")]
		private Features m_features;

		[Token(Token = "0x4001727")]
		[FieldOffset(Offset = "0x58")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x4001728")]
		[FieldOffset(Offset = "0x60")]
		private UIAlertController m_uiAlertController;

		[Token(Token = "0x4001729")]
		[FieldOffset(Offset = "0x68")]
		private UkenTimeController m_timeController;

		[Token(Token = "0x17000656")]
		public bool persistentNotification
		{
			[Token(Token = "0x60025B0")]
			[Address(RVA = "0xA21004", Offset = "0xA21004", VA = "0xA21004")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839EFC", Offset = "0x839EFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60025B1")]
			[Address(RVA = "0xA2100C", Offset = "0xA2100C", VA = "0xA2100C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839F0C", Offset = "0x839F0C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000657")]
		private DepotEntity<RDAdConfig> m_AdConfigs
		{
			[Token(Token = "0x60025B2")]
			[Address(RVA = "0xA21018", Offset = "0xA21018", VA = "0xA21018")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000658")]
		private DepotEntity<RDAdsConfigGroup> m_AdsConfigGroup
		{
			[Token(Token = "0x60025B3")]
			[Address(RVA = "0xA21180", Offset = "0xA21180", VA = "0xA21180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60025B4")]
		[Address(RVA = "0xA212E8", Offset = "0xA212E8", VA = "0xA212E8")]
		public AdConfigs(CasualDataStoreController controller, UserSegments userSegments, UserProfiler userProfiler, InventoryController inventoryController, SharedDataCacheController dataCacheController, Features features, UIAlertController uiAlertController, UkenTimeController timeController)
		{
		}

		[Token(Token = "0x60025B5")]
		[Address(RVA = "0xA213B8", Offset = "0xA213B8", VA = "0xA213B8", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x60025B6")]
		[Address(RVA = "0xA21458", Offset = "0xA21458", VA = "0xA21458")]
		public AdConfig FindOrCreate(string AdConfigReference)
		{
			return null;
		}

		[Token(Token = "0x60025B7")]
		[Address(RVA = "0xA2157C", Offset = "0xA2157C", VA = "0xA2157C")]
		public List<AdConfig> GetAllAds()
		{
			return null;
		}

		[Token(Token = "0x60025B8")]
		[Address(RVA = "0xA215AC", Offset = "0xA215AC", VA = "0xA215AC")]
		public List<AdConfig> GetOwnedAdConfigs()
		{
			return null;
		}

		[Token(Token = "0x60025B9")]
		[Address(RVA = "0xA21704", Offset = "0xA21704", VA = "0xA21704")]
		public List<AdConfig> GetOwnedAdConfigsSortedByPriority()
		{
			return null;
		}

		[Token(Token = "0x60025BA")]
		[Address(RVA = "0xA21820", Offset = "0xA21820", VA = "0xA21820")]
		public AdConfig GetAvailableAdConfig(string adsGroupReference, bool isInterstitial = false)
		{
			return null;
		}

		[Token(Token = "0x60025BB")]
		[Address(RVA = "0xA219C8", Offset = "0xA219C8", VA = "0xA219C8")]
		public AdConfig GetAvailableAdConfig(bool isInterstitial = false)
		{
			return null;
		}

		[Token(Token = "0x60025BC")]
		[Address(RVA = "0xA21B6C", Offset = "0xA21B6C", VA = "0xA21B6C", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x60025BD")]
		[Address(RVA = "0xA21BD0", Offset = "0xA21BD0", VA = "0xA21BD0")]
		private void RefreshAdState()
		{
		}
	}
}
