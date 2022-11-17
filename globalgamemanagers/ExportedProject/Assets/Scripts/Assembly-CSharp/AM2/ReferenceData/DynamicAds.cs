using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using UnityEngine;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000355")]
	public class DynamicAds : RuntimeData<RDDynamicAds>, IItemModel, IInfoText
	{
		[Token(Token = "0x4001027")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82978C", Offset = "0x82978C")]
		private UserSegment _003CuserSegment_003Ek__BackingField;

		[Token(Token = "0x4001028")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82979C", Offset = "0x82979C")]
		private AdConfig _003CadConfig_003Ek__BackingField;

		[Token(Token = "0x4001029")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8297AC", Offset = "0x8297AC")]
		private float _003CdynamicAdStartTimeSeconds_003Ek__BackingField;

		[Token(Token = "0x400102A")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8297BC", Offset = "0x8297BC")]
		private float _003CdynamicAdDurationTimeSeconds_003Ek__BackingField;

		[Token(Token = "0x400102B")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8297CC", Offset = "0x8297CC")]
		private Color _003CorbNormalColor_003Ek__BackingField;

		[Token(Token = "0x400102C")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8297DC", Offset = "0x8297DC")]
		private Color _003CorbHighlighColor_003Ek__BackingField;

		[Token(Token = "0x400102D")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8297EC", Offset = "0x8297EC")]
		private Color _003CorbPressedColor_003Ek__BackingField;

		[Token(Token = "0x400102E")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8297FC", Offset = "0x8297FC")]
		private Color _003CorbBorderColor_003Ek__BackingField;

		[Token(Token = "0x400102F")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82980C", Offset = "0x82980C")]
		private Dictionary<string, long> _003CcurrentRewardTranaction_003Ek__BackingField;

		[Token(Token = "0x4001030")]
		[FieldOffset(Offset = "0x78")]
		private RewardGroup m_rewardGroup;

		[Token(Token = "0x4001031")]
		[FieldOffset(Offset = "0x80")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x4001032")]
		[FieldOffset(Offset = "0x88")]
		private DynamicAdItem m_dynamicAdItem;

		[Token(Token = "0x4001033")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82981C", Offset = "0x82981C")]
		private bool _003CadActive_003Ek__BackingField;

		[Token(Token = "0x1700043A")]
		public UserSegment userSegment
		{
			[Token(Token = "0x6001A43")]
			[Address(RVA = "0x9B02D4", Offset = "0x9B02D4", VA = "0x9B02D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837E20", Offset = "0x837E20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A44")]
			[Address(RVA = "0x9B02DC", Offset = "0x9B02DC", VA = "0x9B02DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837E30", Offset = "0x837E30")]
			private set
			{
			}
		}

		[Token(Token = "0x1700043B")]
		public AdConfig adConfig
		{
			[Token(Token = "0x6001A45")]
			[Address(RVA = "0x9B02E4", Offset = "0x9B02E4", VA = "0x9B02E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837E40", Offset = "0x837E40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A46")]
			[Address(RVA = "0x9B02EC", Offset = "0x9B02EC", VA = "0x9B02EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837E50", Offset = "0x837E50")]
			private set
			{
			}
		}

		[Token(Token = "0x1700043C")]
		public int priority
		{
			[Token(Token = "0x6001A47")]
			[Address(RVA = "0x9B02F4", Offset = "0x9B02F4", VA = "0x9B02F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700043D")]
		public float dynamicAdStartTimeSeconds
		{
			[Token(Token = "0x6001A48")]
			[Address(RVA = "0x9B0320", Offset = "0x9B0320", VA = "0x9B0320")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837E60", Offset = "0x837E60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6001A49")]
			[Address(RVA = "0x9B0328", Offset = "0x9B0328", VA = "0x9B0328")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837E70", Offset = "0x837E70")]
			private set
			{
			}
		}

		[Token(Token = "0x1700043E")]
		public float dynamicAdDurationTimeSeconds
		{
			[Token(Token = "0x6001A4A")]
			[Address(RVA = "0x9B0330", Offset = "0x9B0330", VA = "0x9B0330")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837E80", Offset = "0x837E80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6001A4B")]
			[Address(RVA = "0x9B0338", Offset = "0x9B0338", VA = "0x9B0338")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837E90", Offset = "0x837E90")]
			private set
			{
			}
		}

		[Token(Token = "0x1700043F")]
		public Color orbNormalColor
		{
			[Token(Token = "0x6001A4C")]
			[Address(RVA = "0x9B0340", Offset = "0x9B0340", VA = "0x9B0340")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837EA0", Offset = "0x837EA0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6001A4D")]
			[Address(RVA = "0x9B034C", Offset = "0x9B034C", VA = "0x9B034C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837EB0", Offset = "0x837EB0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000440")]
		public Color orbHighlighColor
		{
			[Token(Token = "0x6001A4E")]
			[Address(RVA = "0x9B0358", Offset = "0x9B0358", VA = "0x9B0358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837EC0", Offset = "0x837EC0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6001A4F")]
			[Address(RVA = "0x9B0364", Offset = "0x9B0364", VA = "0x9B0364")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837ED0", Offset = "0x837ED0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000441")]
		public Color orbPressedColor
		{
			[Token(Token = "0x6001A50")]
			[Address(RVA = "0x9B0370", Offset = "0x9B0370", VA = "0x9B0370")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837EE0", Offset = "0x837EE0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6001A51")]
			[Address(RVA = "0x9B037C", Offset = "0x9B037C", VA = "0x9B037C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837EF0", Offset = "0x837EF0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000442")]
		public Color orbBorderColor
		{
			[Token(Token = "0x6001A52")]
			[Address(RVA = "0x9B0388", Offset = "0x9B0388", VA = "0x9B0388")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837F00", Offset = "0x837F00")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6001A53")]
			[Address(RVA = "0x9B0394", Offset = "0x9B0394", VA = "0x9B0394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837F10", Offset = "0x837F10")]
			private set
			{
			}
		}

		[Token(Token = "0x17000443")]
		public Dictionary<string, long> currentRewardTranaction
		{
			[Token(Token = "0x6001A54")]
			[Address(RVA = "0x9B03A0", Offset = "0x9B03A0", VA = "0x9B03A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837F20", Offset = "0x837F20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A55")]
			[Address(RVA = "0x9B03A8", Offset = "0x9B03A8", VA = "0x9B03A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837F30", Offset = "0x837F30")]
			private set
			{
			}
		}

		[Token(Token = "0x17000444")]
		public string readableItemName
		{
			[Token(Token = "0x6001A56")]
			[Address(RVA = "0x9B03B0", Offset = "0x9B03B0", VA = "0x9B03B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000445")]
		public string description
		{
			[Token(Token = "0x6001A57")]
			[Address(RVA = "0x9B0400", Offset = "0x9B0400", VA = "0x9B0400", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000446")]
		public string researchInfoText
		{
			[Token(Token = "0x6001A58")]
			[Address(RVA = "0x9B0450", Offset = "0x9B0450", VA = "0x9B0450", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000447")]
		public string infoImageSource
		{
			[Token(Token = "0x6001A59")]
			[Address(RVA = "0x9B04A0", Offset = "0x9B04A0", VA = "0x9B04A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000448")]
		public DynamicAdItem dynamicAdItem
		{
			[Token(Token = "0x6001A5A")]
			[Address(RVA = "0x9B04F0", Offset = "0x9B04F0", VA = "0x9B04F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000449")]
		public bool adActive
		{
			[Token(Token = "0x6001A6A")]
			[Address(RVA = "0x9B1060", Offset = "0x9B1060", VA = "0x9B1060")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837F40", Offset = "0x837F40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001A6B")]
			[Address(RVA = "0x9B1068", Offset = "0x9B1068", VA = "0x9B1068")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837F50", Offset = "0x837F50")]
			set
			{
			}
		}

		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0x9B0580", Offset = "0x9B0580", VA = "0x9B0580", Slot = "4")]
		public override void Initialize(RDDynamicAds referenceData)
		{
		}

		[Token(Token = "0x6001A5C")]
		[Address(RVA = "0x9B0698", Offset = "0x9B0698", VA = "0x9B0698")]
		private void FindOrCreatedReferencedEntities()
		{
		}

		[Token(Token = "0x6001A5D")]
		[Address(RVA = "0x9B09B0", Offset = "0x9B09B0", VA = "0x9B09B0")]
		private void InitializeColors()
		{
		}

		[Token(Token = "0x6001A5E")]
		[Address(RVA = "0x9B0B1C", Offset = "0x9B0B1C", VA = "0x9B0B1C")]
		public double GlobalSpeedBoostDurationSeconds()
		{
			return default(double);
		}

		[Token(Token = "0x6001A5F")]
		[Address(RVA = "0x9B0B5C", Offset = "0x9B0B5C", VA = "0x9B0B5C")]
		public double GlobalSpeedBoostPercentage()
		{
			return default(double);
		}

		[Token(Token = "0x6001A60")]
		[Address(RVA = "0x9B0B9C", Offset = "0x9B0B9C", VA = "0x9B0B9C")]
		public bool HasGlobalSpeedBoostReward()
		{
			return default(bool);
		}

		[Token(Token = "0x6001A61")]
		[Address(RVA = "0x9B0BDC", Offset = "0x9B0BDC", VA = "0x9B0BDC")]
		private DateTime VariableStartTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x9B0C38", Offset = "0x9B0C38", VA = "0x9B0C38")]
		public double TimeRemainingSeconds()
		{
			return default(double);
		}

		[Token(Token = "0x6001A63")]
		[Address(RVA = "0x9B0D3C", Offset = "0x9B0D3C", VA = "0x9B0D3C")]
		public bool UserSegmentRequirementsMet(UserProfiler user)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x9B0D58", Offset = "0x9B0D58", VA = "0x9B0D58")]
		public bool ShowOfferRequirementsMet(UserProfiler user)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x9B0E18", Offset = "0x9B0E18", VA = "0x9B0E18")]
		public bool CanSetVariableStartTime()
		{
			return default(bool);
		}

		[Token(Token = "0x6001A66")]
		[Address(RVA = "0x9B0ED4", Offset = "0x9B0ED4", VA = "0x9B0ED4")]
		public bool Skippable()
		{
			return default(bool);
		}

		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x9B0F38", Offset = "0x9B0F38", VA = "0x9B0F38")]
		public void GenerateNewDynamicAdTimeInSeconds()
		{
		}

		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x9B1004", Offset = "0x9B1004", VA = "0x9B1004")]
		public void GenerateDynamicAdDurationInSeconds()
		{
		}

		[Token(Token = "0x6001A69")]
		[Address(RVA = "0x9B1058", Offset = "0x9B1058", VA = "0x9B1058")]
		public void ResetStartAndDurationTimers()
		{
		}

		[Token(Token = "0x6001A6C")]
		[Address(RVA = "0x9B1074", Offset = "0x9B1074", VA = "0x9B1074")]
		public void GenerateNewRewardsForCurrentInstance()
		{
		}

		[Token(Token = "0x6001A6D")]
		[Address(RVA = "0x9B10D0", Offset = "0x9B10D0", VA = "0x9B10D0")]
		public void ClearCurrentInstanceRewards()
		{
		}

		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0x9B1130", Offset = "0x9B1130", VA = "0x9B1130")]
		public string GetListOfVisibleRewardsFromCurrentTransaction()
		{
			return null;
		}

		[Token(Token = "0x6001A6F")]
		[Address(RVA = "0x9B1470", Offset = "0x9B1470", VA = "0x9B1470")]
		public DynamicAds()
		{
		}
	}
}
