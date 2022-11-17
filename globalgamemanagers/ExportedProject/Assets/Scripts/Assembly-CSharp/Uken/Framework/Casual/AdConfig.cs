using System;
using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004E1")]
	public class AdConfig : RuntimeData<RDAdConfig>, ITag, ISubTabItemModel, IItemModel, IInfoText
	{
		[Token(Token = "0x4001711")]
		[FieldOffset(Offset = "0x18")]
		public Formula maxAdsFormula;

		[Token(Token = "0x4001712")]
		[FieldOffset(Offset = "0x20")]
		private RewardGroup rewardGroup;

		[Token(Token = "0x4001713")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F0FC", Offset = "0x82F0FC")]
		private readonly SubTab _003CsubTab_003Ek__BackingField;

		[Token(Token = "0x4001714")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F10C", Offset = "0x82F10C")]
		private readonly SubTab _003CresearchableSubTab_003Ek__BackingField;

		[Token(Token = "0x4001715")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F11C", Offset = "0x82F11C")]
		private readonly Section _003Csection_003Ek__BackingField;

		[Token(Token = "0x4001716")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F12C", Offset = "0x82F12C")]
		private readonly Section _003CresearchableSection_003Ek__BackingField;

		[Token(Token = "0x4001717")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F13C", Offset = "0x82F13C")]
		private readonly bool _003CisDescriptorTag_003Ek__BackingField;

		[Token(Token = "0x4001718")]
		[FieldOffset(Offset = "0x49")]
		public bool m_notificationSeen;

		[Token(Token = "0x1700063E")]
		public long MaxAdViews
		{
			[Token(Token = "0x6002589")]
			[Address(RVA = "0xA1F978", Offset = "0xA1F978", VA = "0xA1F978")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700063F")]
		public long TimeAfterEachAd
		{
			[Token(Token = "0x600258A")]
			[Address(RVA = "0xA1F9A4", Offset = "0xA1F9A4", VA = "0xA1F9A4")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000640")]
		public long TimeAfterEachGroupOfAds
		{
			[Token(Token = "0x600258B")]
			[Address(RVA = "0xA1F9D0", Offset = "0xA1F9D0", VA = "0xA1F9D0")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000641")]
		public bool showProgressBar
		{
			[Token(Token = "0x600258C")]
			[Address(RVA = "0xA1F9FC", Offset = "0xA1F9FC", VA = "0xA1F9FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000642")]
		public bool hasGlobalBoostReward
		{
			[Token(Token = "0x600258D")]
			[Address(RVA = "0xA1FA28", Offset = "0xA1FA28", VA = "0xA1FA28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000643")]
		public double globalSpeedBoostDurationInSeconds
		{
			[Token(Token = "0x600258E")]
			[Address(RVA = "0xA1FA5C", Offset = "0xA1FA5C", VA = "0xA1FA5C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000644")]
		public double globalSpeedBoostPercent
		{
			[Token(Token = "0x600258F")]
			[Address(RVA = "0xA1FA88", Offset = "0xA1FA88", VA = "0xA1FA88")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000645")]
		public bool IsIntersitialConfig
		{
			[Token(Token = "0x6002590")]
			[Address(RVA = "0xA1FAB4", Offset = "0xA1FAB4", VA = "0xA1FAB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000646")]
		public long RoundsBetweenAds
		{
			[Token(Token = "0x6002591")]
			[Address(RVA = "0xA1FAE0", Offset = "0xA1FAE0", VA = "0xA1FAE0")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000647")]
		public List<string> UserSegmentReferences
		{
			[Token(Token = "0x6002592")]
			[Address(RVA = "0xA1FB0C", Offset = "0xA1FB0C", VA = "0xA1FB0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000648")]
		public bool skippable
		{
			[Token(Token = "0x6002593")]
			[Address(RVA = "0xA1FB38", Offset = "0xA1FB38", VA = "0xA1FB38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000649")]
		public string buttonText
		{
			[Token(Token = "0x6002594")]
			[Address(RVA = "0xA1FB64", Offset = "0xA1FB64", VA = "0xA1FB64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064A")]
		public SubTab subTab
		{
			[Token(Token = "0x6002595")]
			[Address(RVA = "0xA1FB90", Offset = "0xA1FB90", VA = "0xA1FB90", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839EAC", Offset = "0x839EAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064B")]
		public SubTab researchableSubTab
		{
			[Token(Token = "0x6002596")]
			[Address(RVA = "0xA1FB98", Offset = "0xA1FB98", VA = "0xA1FB98", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839EBC", Offset = "0x839EBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064C")]
		public Section section
		{
			[Token(Token = "0x6002597")]
			[Address(RVA = "0xA1FBA0", Offset = "0xA1FBA0", VA = "0xA1FBA0", Slot = "12")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839ECC", Offset = "0x839ECC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064D")]
		public Section researchableSection
		{
			[Token(Token = "0x6002598")]
			[Address(RVA = "0xA1FBA8", Offset = "0xA1FBA8", VA = "0xA1FBA8", Slot = "13")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839EDC", Offset = "0x839EDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064E")]
		public string readableItemName
		{
			[Token(Token = "0x6002599")]
			[Address(RVA = "0xA1FBB0", Offset = "0xA1FBB0", VA = "0xA1FBB0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064F")]
		public bool isDescriptorTag
		{
			[Token(Token = "0x600259A")]
			[Address(RVA = "0xA1FBDC", Offset = "0xA1FBDC", VA = "0xA1FBDC", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839EEC", Offset = "0x839EEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000650")]
		public string readableName
		{
			[Token(Token = "0x600259B")]
			[Address(RVA = "0xA1FBE4", Offset = "0xA1FBE4", VA = "0xA1FBE4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000651")]
		public string description
		{
			[Token(Token = "0x600259C")]
			[Address(RVA = "0xA1FC10", Offset = "0xA1FC10", VA = "0xA1FC10", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000652")]
		public string researchInfoText
		{
			[Token(Token = "0x600259D")]
			[Address(RVA = "0xA1FC60", Offset = "0xA1FC60", VA = "0xA1FC60", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000653")]
		public string infoImageSource
		{
			[Token(Token = "0x600259E")]
			[Address(RVA = "0xA1FCB0", Offset = "0xA1FCB0", VA = "0xA1FCB0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000654")]
		public sbyte displayPriority
		{
			[Token(Token = "0x600259F")]
			[Address(RVA = "0xA1FD00", Offset = "0xA1FD00", VA = "0xA1FD00")]
			get
			{
				return default(sbyte);
			}
		}

		[Token(Token = "0x17000655")]
		public string m_reference
		{
			[Token(Token = "0x60025A0")]
			[Address(RVA = "0xA1FD2C", Offset = "0xA1FD2C", VA = "0xA1FD2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60025A1")]
		[Address(RVA = "0xA1FD58", Offset = "0xA1FD58", VA = "0xA1FD58")]
		public AdConfig()
		{
		}

		[Token(Token = "0x60025A2")]
		[Address(RVA = "0xA1FDA8", Offset = "0xA1FDA8", VA = "0xA1FDA8")]
		public AdConfig(RDAdConfig referenceData)
		{
		}

		[Token(Token = "0x60025A3")]
		[Address(RVA = "0xA1FE0C", Offset = "0xA1FE0C", VA = "0xA1FE0C")]
		public void Setup(RuntimeDataCache<Formula, RDFormula> formulas, RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache)
		{
		}

		[Token(Token = "0x60025A4")]
		[Address(RVA = "0xA1FF04", Offset = "0xA1FF04", VA = "0xA1FF04")]
		public bool IsValid(UserSegments userSegments, UserProfiler user)
		{
			return default(bool);
		}

		[Token(Token = "0x60025A5")]
		[Address(RVA = "0xA20094", Offset = "0xA20094", VA = "0xA20094")]
		public long GetAdViewCount()
		{
			return default(long);
		}

		[Token(Token = "0x60025A6")]
		[Address(RVA = "0xA202D4", Offset = "0xA202D4", VA = "0xA202D4")]
		public void TrackWatchedAd(AdsController.WatchType watchType)
		{
		}

		[Token(Token = "0x60025A7")]
		[Address(RVA = "0xA20400", Offset = "0xA20400", VA = "0xA20400")]
		public DateTime GetNextViewTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x60025A8")]
		[Address(RVA = "0xA20544", Offset = "0xA20544", VA = "0xA20544")]
		public DateTime GetNextGroupTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x60025A9")]
		[Address(RVA = "0xA206B0", Offset = "0xA206B0", VA = "0xA206B0")]
		public void ClearGroup()
		{
		}

		[Token(Token = "0x60025AA")]
		[Address(RVA = "0xA20754", Offset = "0xA20754", VA = "0xA20754")]
		public RewardGroup ReturnAndPopulateRewardGroup()
		{
			return null;
		}

		[Token(Token = "0x60025AB")]
		[Address(RVA = "0xA2089C", Offset = "0xA2089C", VA = "0xA2089C")]
		public void TryToGrantTheRewardGroup(string eventName, Dictionary<string, long> transactions)
		{
		}

		[Token(Token = "0x60025AC")]
		[Address(RVA = "0xA20B74", Offset = "0xA20B74", VA = "0xA20B74")]
		public string GetPossibleAdRewards(long viewCountOverride = -1L)
		{
			return null;
		}

		[Token(Token = "0x60025AD")]
		[Address(RVA = "0xA20F8C", Offset = "0xA20F8C", VA = "0xA20F8C")]
		public Reward GetFirstRewardReference()
		{
			return null;
		}
	}
}
