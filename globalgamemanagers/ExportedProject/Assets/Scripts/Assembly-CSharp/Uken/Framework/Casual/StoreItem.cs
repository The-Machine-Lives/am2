using System;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Library.Inventory;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200054A")]
	public class StoreItem : RuntimeData<RDStoreItem>, ITag, ISubTabItemModel, IItemModel, IInfoText
	{
		[Token(Token = "0x4001932")]
		private const string c_genericOfferSectionReference = "iap_2_section";

		[Token(Token = "0x4001933")]
		[FieldOffset(Offset = "0x18")]
		private readonly DateTime c_maxDateTimeValue;

		[Token(Token = "0x4001934")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83222C", Offset = "0x83222C")]
		private SubTab _003CsubTab_003Ek__BackingField;

		[Token(Token = "0x4001935")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83223C", Offset = "0x83223C")]
		private Section _003Csection_003Ek__BackingField;

		[Token(Token = "0x4001936")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83224C", Offset = "0x83224C")]
		private readonly bool _003CisDescriptorTag_003Ek__BackingField;

		[Token(Token = "0x4001937")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83225C", Offset = "0x83225C")]
		private readonly string _003CreadableName_003Ek__BackingField;

		[Token(Token = "0x4001938")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83226C", Offset = "0x83226C")]
		private readonly string _003CreadableItemName_003Ek__BackingField;

		[Token(Token = "0x4001939")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83227C", Offset = "0x83227C")]
		private UserSegment _003CuserSegment_003Ek__BackingField;

		[Token(Token = "0x400193A")]
		[FieldOffset(Offset = "0x50")]
		private StoreInventoryItem m_storeInventoryItem;

		[Token(Token = "0x400193B")]
		[FieldOffset(Offset = "0x58")]
		private LTOGroups m_ltoGroup;

		[Token(Token = "0x400193C")]
		[FieldOffset(Offset = "0x60")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x400193D")]
		[FieldOffset(Offset = "0x68")]
		private EventSchedule m_ltoEventSchedule;

		[Token(Token = "0x400193E")]
		[FieldOffset(Offset = "0x70")]
		private RDStoreItem m_storeItemData;

		[Token(Token = "0x400193F")]
		[FieldOffset(Offset = "0x78")]
		private RewardGroup m_rewardGroup;

		[Token(Token = "0x4001940")]
		[FieldOffset(Offset = "0x80")]
		private SharedDataCacheController m_sharedDataCacheController;

		[Token(Token = "0x1700070D")]
		public override string reference
		{
			[Token(Token = "0x6002861")]
			[Address(RVA = "0xA958DC", Offset = "0xA958DC", VA = "0xA958DC", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700070E")]
		public string name
		{
			[Token(Token = "0x6002862")]
			[Address(RVA = "0xA95908", Offset = "0xA95908", VA = "0xA95908")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700070F")]
		public string description
		{
			[Token(Token = "0x6002863")]
			[Address(RVA = "0xA95934", Offset = "0xA95934", VA = "0xA95934", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000710")]
		public string imagePath
		{
			[Token(Token = "0x6002864")]
			[Address(RVA = "0xA95960", Offset = "0xA95960", VA = "0xA95960")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000711")]
		public string currencyCode
		{
			[Token(Token = "0x6002865")]
			[Address(RVA = "0xA9598C", Offset = "0xA9598C", VA = "0xA9598C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000712")]
		public double cost
		{
			[Token(Token = "0x6002866")]
			[Address(RVA = "0xA959B8", Offset = "0xA959B8", VA = "0xA959B8")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000713")]
		public string vendorProductId
		{
			[Token(Token = "0x6002867")]
			[Address(RVA = "0xA959E4", Offset = "0xA959E4", VA = "0xA959E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000714")]
		public string bonusText
		{
			[Token(Token = "0x6002868")]
			[Address(RVA = "0xA95A10", Offset = "0xA95A10", VA = "0xA95A10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000715")]
		public string rewardGroupName
		{
			[Token(Token = "0x6002869")]
			[Address(RVA = "0xA95A3C", Offset = "0xA95A3C", VA = "0xA95A3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000716")]
		public string bonusTextColor
		{
			[Token(Token = "0x600286A")]
			[Address(RVA = "0xA95A68", Offset = "0xA95A68", VA = "0xA95A68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000717")]
		public SubTab subTab
		{
			[Token(Token = "0x600286B")]
			[Address(RVA = "0xA95ACC", Offset = "0xA95ACC", VA = "0xA95ACC", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A280", Offset = "0x83A280")]
			get
			{
				return null;
			}
			[Token(Token = "0x600286C")]
			[Address(RVA = "0xA95AD4", Offset = "0xA95AD4", VA = "0xA95AD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A290", Offset = "0x83A290")]
			private set
			{
			}
		}

		[Token(Token = "0x17000718")]
		public SubTab researchableSubTab
		{
			[Token(Token = "0x600286D")]
			[Address(RVA = "0xA95ADC", Offset = "0xA95ADC", VA = "0xA95ADC", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000719")]
		public Section section
		{
			[Token(Token = "0x600286E")]
			[Address(RVA = "0xA95AE4", Offset = "0xA95AE4", VA = "0xA95AE4", Slot = "12")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A2A0", Offset = "0x83A2A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600286F")]
			[Address(RVA = "0xA95AEC", Offset = "0xA95AEC", VA = "0xA95AEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A2B0", Offset = "0x83A2B0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700071A")]
		public Section researchableSection
		{
			[Token(Token = "0x6002870")]
			[Address(RVA = "0xA95AF4", Offset = "0xA95AF4", VA = "0xA95AF4", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700071B")]
		public bool isDescriptorTag
		{
			[Token(Token = "0x6002871")]
			[Address(RVA = "0xA95AFC", Offset = "0xA95AFC", VA = "0xA95AFC", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A2C0", Offset = "0x83A2C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700071C")]
		public string readableName
		{
			[Token(Token = "0x6002872")]
			[Address(RVA = "0xA95B04", Offset = "0xA95B04", VA = "0xA95B04", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A2D0", Offset = "0x83A2D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700071D")]
		public string readableItemName
		{
			[Token(Token = "0x6002873")]
			[Address(RVA = "0xA95B0C", Offset = "0xA95B0C", VA = "0xA95B0C", Slot = "14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A2E0", Offset = "0x83A2E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700071E")]
		public string researchInfoText
		{
			[Token(Token = "0x6002874")]
			[Address(RVA = "0xA95B14", Offset = "0xA95B14", VA = "0xA95B14", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700071F")]
		public string infoImageSource
		{
			[Token(Token = "0x6002875")]
			[Address(RVA = "0xA95B64", Offset = "0xA95B64", VA = "0xA95B64", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000720")]
		public UserSegment userSegment
		{
			[Token(Token = "0x6002876")]
			[Address(RVA = "0xA95BB4", Offset = "0xA95BB4", VA = "0xA95BB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A2F0", Offset = "0x83A2F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002877")]
			[Address(RVA = "0xA95BBC", Offset = "0xA95BBC", VA = "0xA95BBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A300", Offset = "0x83A300")]
			private set
			{
			}
		}

		[Token(Token = "0x17000721")]
		private StoreInventoryItem storeInventoryItem
		{
			[Token(Token = "0x6002878")]
			[Address(RVA = "0xA95BC4", Offset = "0xA95BC4", VA = "0xA95BC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000722")]
		public long ltoStartTimeDelaySeconds
		{
			[Token(Token = "0x6002879")]
			[Address(RVA = "0xA95C54", Offset = "0xA95C54", VA = "0xA95C54")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000723")]
		public long ltoDurationSeconds
		{
			[Token(Token = "0x600287A")]
			[Address(RVA = "0xA95C80", Offset = "0xA95C80", VA = "0xA95C80")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000724")]
		public bool showInfoPopup
		{
			[Token(Token = "0x600287B")]
			[Address(RVA = "0xA95CAC", Offset = "0xA95CAC", VA = "0xA95CAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600287C")]
		[Address(RVA = "0xA95CD8", Offset = "0xA95CD8", VA = "0xA95CD8")]
		public StoreItem(RDStoreItem storeItemData, RewardGroupsController rewardGroups)
		{
		}

		[Token(Token = "0x600287D")]
		[Address(RVA = "0xA95DD0", Offset = "0xA95DD0", VA = "0xA95DD0")]
		public StoreItem()
		{
		}

		[Token(Token = "0x600287E")]
		[Address(RVA = "0xA8CCAC", Offset = "0xA8CCAC", VA = "0xA8CCAC")]
		public void Setup(RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache)
		{
		}

		[Token(Token = "0x600287F")]
		[Address(RVA = "0xA95FC8", Offset = "0xA95FC8", VA = "0xA95FC8")]
		public RewardGroup GetRewards()
		{
			return null;
		}

		[Token(Token = "0x6002880")]
		[Address(RVA = "0xA95FD0", Offset = "0xA95FD0", VA = "0xA95FD0")]
		public bool HasVariableDuration()
		{
			return default(bool);
		}

		[Token(Token = "0x6002881")]
		[Address(RVA = "0xA96004", Offset = "0xA96004", VA = "0xA96004")]
		private DateTime VariableStartTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x6002882")]
		[Address(RVA = "0xA96070", Offset = "0xA96070", VA = "0xA96070")]
		public bool CanSetVariableStartTime()
		{
			return default(bool);
		}

		[Token(Token = "0x6002883")]
		[Address(RVA = "0xA96148", Offset = "0xA96148", VA = "0xA96148")]
		public bool IsSpecialOffer()
		{
			return default(bool);
		}

		[Token(Token = "0x6002884")]
		[Address(RVA = "0xA961AC", Offset = "0xA961AC", VA = "0xA961AC")]
		public bool IsOfferActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6002885")]
		[Address(RVA = "0xA96560", Offset = "0xA96560", VA = "0xA96560")]
		public bool UserSegmentRequirementMet(UserProfiler user)
		{
			return default(bool);
		}

		[Token(Token = "0x6002886")]
		[Address(RVA = "0xA965DC", Offset = "0xA965DC", VA = "0xA965DC")]
		public bool ShowRequirementsMet(UserProfiler user)
		{
			return default(bool);
		}

		[Token(Token = "0x6002887")]
		[Address(RVA = "0xA965C4", Offset = "0xA965C4", VA = "0xA965C4")]
		public bool HasMetGroupRequirements(UserProfiler user)
		{
			return default(bool);
		}

		[Token(Token = "0x6002888")]
		[Address(RVA = "0xA96688", Offset = "0xA96688", VA = "0xA96688")]
		public bool HasReachedActivationLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x6002889")]
		[Address(RVA = "0xA96410", Offset = "0xA96410", VA = "0xA96410")]
		public double TimeRemainingSeconds()
		{
			return default(double);
		}

		[Token(Token = "0x600288A")]
		[Address(RVA = "0xA96734", Offset = "0xA96734", VA = "0xA96734")]
		public DateTime DateVariableOfferExpires()
		{
			return default(DateTime);
		}

		[Token(Token = "0x600288B")]
		[Address(RVA = "0xA96830", Offset = "0xA96830", VA = "0xA96830")]
		public bool HasCountdownTimer()
		{
			return default(bool);
		}

		[Token(Token = "0x600288C")]
		[Address(RVA = "0xA96874", Offset = "0xA96874", VA = "0xA96874")]
		public void GenerateNewCooldownTime()
		{
		}

		[Token(Token = "0x600288D")]
		[Address(RVA = "0xA968F0", Offset = "0xA968F0", VA = "0xA968F0")]
		private bool NeedsToGenerateCooldownTime()
		{
			return default(bool);
		}

		[Token(Token = "0x600288E")]
		[Address(RVA = "0xA96950", Offset = "0xA96950", VA = "0xA96950")]
		public long CooldownTimeSeconds()
		{
			return default(long);
		}

		[Token(Token = "0x600288F")]
		[Address(RVA = "0xA96298", Offset = "0xA96298", VA = "0xA96298")]
		public bool IsInCooldown()
		{
			return default(bool);
		}

		[Token(Token = "0x6002890")]
		[Address(RVA = "0xA96998", Offset = "0xA96998", VA = "0xA96998")]
		public void SetLastTimePurchased(DateTime lastPurchased)
		{
		}

		[Token(Token = "0x6002891")]
		[Address(RVA = "0xA969D0", Offset = "0xA969D0", VA = "0xA969D0")]
		public void SetFirstSeenTime(DateTime firstSeenTime)
		{
		}

		[Token(Token = "0x6002892")]
		[Address(RVA = "0xA96704", Offset = "0xA96704", VA = "0xA96704")]
		public bool HasOfferBeenSeen()
		{
			return default(bool);
		}

		[Token(Token = "0x6002893")]
		[Address(RVA = "0xA96B34", Offset = "0xA96B34", VA = "0xA96B34")]
		public void SetUnlockTimeForVariableStart(DateTime unlockTime)
		{
		}

		[Token(Token = "0x6002894")]
		[Address(RVA = "0xA96B6C", Offset = "0xA96B6C", VA = "0xA96B6C")]
		public DateTime DateOfferWasUnlocked()
		{
			return default(DateTime);
		}

		[Token(Token = "0x6002895")]
		[Address(RVA = "0xA96B9C", Offset = "0xA96B9C", VA = "0xA96B9C")]
		public void MarkPurchased()
		{
		}

		[Token(Token = "0x6002896")]
		[Address(RVA = "0xA96C14", Offset = "0xA96C14", VA = "0xA96C14")]
		private void ResetOfferVisibility()
		{
		}

		[Token(Token = "0x6002897")]
		[Address(RVA = "0xA96CA4", Offset = "0xA96CA4", VA = "0xA96CA4")]
		public bool HasMetRequirementsToSetUnlockTime(UserProfiler userProfile)
		{
			return default(bool);
		}

		[Token(Token = "0x6002898")]
		[Address(RVA = "0xA96D4C", Offset = "0xA96D4C", VA = "0xA96D4C")]
		public void ResetTraits()
		{
		}

		[Token(Token = "0x6002899")]
		[Address(RVA = "0xA96D84", Offset = "0xA96D84", VA = "0xA96D84")]
		public bool IsATraitResetRequired()
		{
			return default(bool);
		}

		[Token(Token = "0x600289A")]
		[Address(RVA = "0xA96E54", Offset = "0xA96E54", VA = "0xA96E54")]
		public void UpdateTimeSlotReferencesToCurrent()
		{
		}

		[Token(Token = "0x600289B")]
		[Address(RVA = "0xA96AFC", Offset = "0xA96AFC", VA = "0xA96AFC")]
		public void SetLastActiveTimeSlotReference(string timeslotReference)
		{
		}

		[Token(Token = "0x600289C")]
		[Address(RVA = "0xA96F00", Offset = "0xA96F00", VA = "0xA96F00")]
		public void SetLTOGroup(LTOGroups ltoGroup)
		{
		}
	}
}
