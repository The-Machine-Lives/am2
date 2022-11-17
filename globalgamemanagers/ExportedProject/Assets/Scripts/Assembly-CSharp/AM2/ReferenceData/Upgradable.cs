using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200036C")]
	public class Upgradable : RuntimeData<RDUpgradable>, IResearchable, ISubTabItemModel, IItemModel, IInfoText
	{
		[Token(Token = "0x40010DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B5A8", Offset = "0x82B5A8")]
		private SubTab _003CsubTab_003Ek__BackingField;

		[Token(Token = "0x40010DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B5B8", Offset = "0x82B5B8")]
		private SubTab _003CresearchableSubTab_003Ek__BackingField;

		[Token(Token = "0x40010DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B5C8", Offset = "0x82B5C8")]
		private Section _003Csection_003Ek__BackingField;

		[Token(Token = "0x40010DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B5D8", Offset = "0x82B5D8")]
		private Section _003CresearchableSection_003Ek__BackingField;

		[Token(Token = "0x40010E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B5E8", Offset = "0x82B5E8")]
		private ENumericDisplayType _003CamountDisplayType_003Ek__BackingField;

		[Token(Token = "0x40010E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B5F8", Offset = "0x82B5F8")]
		private bool _003CallowAmountDecimals_003Ek__BackingField;

		[Token(Token = "0x40010E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WeakReference<Upgradable> m_sisterUpgradable;

		[Token(Token = "0x40010E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Localizations m_localizationController;

		[Token(Token = "0x40010E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x40010E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private UpgradableItem m_item;

		[Token(Token = "0x40010E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Formula m_amountFormula;

		[Token(Token = "0x40010E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Formula m_costFormula;

		[Token(Token = "0x40010E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<CostResource> costResources;

		[Token(Token = "0x40010E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<CostResource> levelGates;

		[Token(Token = "0x170004A6")]
		public string buyName
		{
			[Token(Token = "0x6001B31")]
			[Address(RVA = "0x971BF8", Offset = "0x971BF8", VA = "0x971BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A7")]
		public string costItemRef
		{
			[Token(Token = "0x6001B32")]
			[Address(RVA = "0x971C24", Offset = "0x971C24", VA = "0x971C24", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A8")]
		public EBuyType buyType
		{
			[Token(Token = "0x6001B33")]
			[Address(RVA = "0x96F698", Offset = "0x96F698", VA = "0x96F698", Slot = "9")]
			get
			{
				return default(EBuyType);
			}
		}

		[Token(Token = "0x170004A9")]
		public EBuyRefDataType buyRefDataType
		{
			[Token(Token = "0x6001B34")]
			[Address(RVA = "0x971C50", Offset = "0x971C50", VA = "0x971C50", Slot = "10")]
			get
			{
				return default(EBuyRefDataType);
			}
		}

		[Token(Token = "0x170004AA")]
		public string localizedAcquireText
		{
			[Token(Token = "0x6001B35")]
			[Address(RVA = "0x971C58", Offset = "0x971C58", VA = "0x971C58", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004AB")]
		public long calculatedAmountLong
		{
			[Token(Token = "0x6001B36")]
			[Address(RVA = "0x96B0C0", Offset = "0x96B0C0", VA = "0x96B0C0")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170004AC")]
		public long calculatedNextAmountLong
		{
			[Token(Token = "0x6001B37")]
			[Address(RVA = "0x971D1C", Offset = "0x971D1C", VA = "0x971D1C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170004AD")]
		public double calculatedAmount
		{
			[Token(Token = "0x6001B38")]
			[Address(RVA = "0x96B714", Offset = "0x96B714", VA = "0x96B714")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170004AE")]
		public double calculatedNextAmount
		{
			[Token(Token = "0x6001B39")]
			[Address(RVA = "0x971D4C", Offset = "0x971D4C", VA = "0x971D4C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170004AF")]
		public long currentLevel
		{
			[Token(Token = "0x6001B3A")]
			[Address(RVA = "0x971D74", Offset = "0x971D74", VA = "0x971D74")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170004B0")]
		public long costQuantity
		{
			[Token(Token = "0x6001B3B")]
			[Address(RVA = "0x971E28", Offset = "0x971E28", VA = "0x971E28", Slot = "8")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170004B1")]
		public string readableItemName
		{
			[Token(Token = "0x6001B3C")]
			[Address(RVA = "0x971F70", Offset = "0x971F70", VA = "0x971F70", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B2")]
		public double remainingTimeToProgressInSeconds
		{
			[Token(Token = "0x6001B3D")]
			[Address(RVA = "0x971F9C", Offset = "0x971F9C", VA = "0x971F9C", Slot = "11")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6001B3E")]
			[Address(RVA = "0x97205C", Offset = "0x97205C", VA = "0x97205C", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x170004B3")]
		public bool isFormulaBonusType
		{
			[Token(Token = "0x6001B3F")]
			[Address(RVA = "0x97209C", Offset = "0x97209C", VA = "0x97209C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170004B4")]
		public double bonusConstant
		{
			[Token(Token = "0x6001B40")]
			[Address(RVA = "0x9720CC", Offset = "0x9720CC", VA = "0x9720CC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170004B5")]
		public SubTab subTab
		{
			[Token(Token = "0x6001B41")]
			[Address(RVA = "0x9720FC", Offset = "0x9720FC", VA = "0x9720FC", Slot = "22")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838360", Offset = "0x838360")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B42")]
			[Address(RVA = "0x972104", Offset = "0x972104", VA = "0x972104")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838370", Offset = "0x838370")]
			private set
			{
			}
		}

		[Token(Token = "0x170004B6")]
		public SubTab researchableSubTab
		{
			[Token(Token = "0x6001B43")]
			[Address(RVA = "0x97210C", Offset = "0x97210C", VA = "0x97210C", Slot = "23")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838380", Offset = "0x838380")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B44")]
			[Address(RVA = "0x972114", Offset = "0x972114", VA = "0x972114")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838390", Offset = "0x838390")]
			private set
			{
			}
		}

		[Token(Token = "0x170004B7")]
		public Section section
		{
			[Token(Token = "0x6001B45")]
			[Address(RVA = "0x97211C", Offset = "0x97211C", VA = "0x97211C", Slot = "24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8383A0", Offset = "0x8383A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B46")]
			[Address(RVA = "0x972124", Offset = "0x972124", VA = "0x972124")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8383B0", Offset = "0x8383B0")]
			private set
			{
			}
		}

		[Token(Token = "0x170004B8")]
		public Section researchableSection
		{
			[Token(Token = "0x6001B47")]
			[Address(RVA = "0x97212C", Offset = "0x97212C", VA = "0x97212C", Slot = "25")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8383C0", Offset = "0x8383C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B48")]
			[Address(RVA = "0x972134", Offset = "0x972134", VA = "0x972134")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8383D0", Offset = "0x8383D0")]
			private set
			{
			}
		}

		[Token(Token = "0x170004B9")]
		public ENumericDisplayType amountDisplayType
		{
			[Token(Token = "0x6001B49")]
			[Address(RVA = "0x97213C", Offset = "0x97213C", VA = "0x97213C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8383E0", Offset = "0x8383E0")]
			get
			{
				return default(ENumericDisplayType);
			}
			[Token(Token = "0x6001B4A")]
			[Address(RVA = "0x972144", Offset = "0x972144", VA = "0x972144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8383F0", Offset = "0x8383F0")]
			private set
			{
			}
		}

		[Token(Token = "0x170004BA")]
		public bool allowAmountDecimals
		{
			[Token(Token = "0x6001B4B")]
			[Address(RVA = "0x97214C", Offset = "0x97214C", VA = "0x97214C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838400", Offset = "0x838400")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B4C")]
			[Address(RVA = "0x972154", Offset = "0x972154", VA = "0x972154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838410", Offset = "0x838410")]
			private set
			{
			}
		}

		[Token(Token = "0x170004BB")]
		public long maxLevel
		{
			[Token(Token = "0x6001B4D")]
			[Address(RVA = "0x972160", Offset = "0x972160", VA = "0x972160")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170004BC")]
		public string description
		{
			[Token(Token = "0x6001B4E")]
			[Address(RVA = "0x97218C", Offset = "0x97218C", VA = "0x97218C", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004BD")]
		public string researchInfoText
		{
			[Token(Token = "0x6001B4F")]
			[Address(RVA = "0x9721B8", Offset = "0x9721B8", VA = "0x9721B8", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004BE")]
		public string infoImageSource
		{
			[Token(Token = "0x6001B50")]
			[Address(RVA = "0x9721E4", Offset = "0x9721E4", VA = "0x9721E4", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004BF")]
		public BISoundEvents.EventKey upgradeClickSoundEventOverride
		{
			[Token(Token = "0x6001B51")]
			[Address(RVA = "0x97222C", Offset = "0x97222C", VA = "0x97222C")]
			get
			{
				return default(BISoundEvents.EventKey);
			}
		}

		[Token(Token = "0x170004C0")]
		public BISoundEvents.EventKey bonusUpgradeClickSoundEventOverride
		{
			[Token(Token = "0x6001B52")]
			[Address(RVA = "0x972258", Offset = "0x972258", VA = "0x972258")]
			get
			{
				return default(BISoundEvents.EventKey);
			}
		}

		[Token(Token = "0x6001B53")]
		[Address(RVA = "0x972284", Offset = "0x972284", VA = "0x972284", Slot = "19")]
		public Dictionary<string, long> GetCostsDict()
		{
			return null;
		}

		[Token(Token = "0x6001B54")]
		[Address(RVA = "0x9722E0", Offset = "0x9722E0", VA = "0x9722E0")]
		public Dictionary<string, long> GetCostsDictAtLevel(long level)
		{
			return null;
		}

		[Token(Token = "0x6001B55")]
		[Address(RVA = "0x9723FC", Offset = "0x9723FC", VA = "0x9723FC", Slot = "20")]
		public Dictionary<string, long> GetDictionaryLevelGates()
		{
			return null;
		}

		[Token(Token = "0x6001B56")]
		[Address(RVA = "0x972458", Offset = "0x972458", VA = "0x972458")]
		public Dictionary<string, long> GetDictionaryLevelGatesAtLevel(long level)
		{
			return null;
		}

		[Token(Token = "0x6001B57")]
		[Address(RVA = "0x9725F4", Offset = "0x9725F4", VA = "0x9725F4")]
		public static long GetTotalCalculatedAmountLong(Upgradable mainUpgradable, Upgradable bonusUpgradable, long mainUpgradableLevel = -1L)
		{
			return default(long);
		}

		[Token(Token = "0x6001B58")]
		[Address(RVA = "0x97260C", Offset = "0x97260C", VA = "0x97260C")]
		public static double GetTotalCalculatedAmountDouble(Upgradable mainUpgradable, Upgradable bonusUpgradable, long mainUpgradableLevel = -1L)
		{
			return default(double);
		}

		[Token(Token = "0x6001B59")]
		[Address(RVA = "0x96F1A0", Offset = "0x96F1A0", VA = "0x96F1A0")]
		public void Setup(RuntimeDataCache<SubTab, RDSubTab> subTabs, RuntimeDataCache<Formula, RDFormula> formulas, RuntimeDataCache<Section, RDSection> sections, RuntimeCostResourceCache costResourceCache, Localizations localizationController, InventoryController inventoryController)
		{
		}

		[Token(Token = "0x6001B5A")]
		[Address(RVA = "0x9726A0", Offset = "0x9726A0", VA = "0x9726A0")]
		public void SetupSisterUpgrade([Optional] Upgradable sisterUpgradable)
		{
		}

		[Token(Token = "0x6001B5B")]
		[Address(RVA = "0x96B6CC", Offset = "0x96B6CC", VA = "0x96B6CC")]
		public void SetupNumericParameters(ENumericDisplayType inAmountDisplayType, bool inAllowAmountDecimals)
		{
		}

		[Token(Token = "0x6001B5C")]
		[Address(RVA = "0x972710", Offset = "0x972710", VA = "0x972710", Slot = "18")]
		public bool IsLevelMaxed()
		{
			return default(bool);
		}

		[Token(Token = "0x6001B5D")]
		[Address(RVA = "0x971DB8", Offset = "0x971DB8", VA = "0x971DB8")]
		public double CalculateAmount(long level)
		{
			return default(double);
		}

		[Token(Token = "0x6001B5E")]
		[Address(RVA = "0x9727A8", Offset = "0x9727A8", VA = "0x9727A8", Slot = "13")]
		public BuyDisplayInfo GetBuyDisplayInfo()
		{
			return default(BuyDisplayInfo);
		}

		[Token(Token = "0x6001B5F")]
		[Address(RVA = "0x972A30", Offset = "0x972A30", VA = "0x972A30", Slot = "14")]
		public string GetBuyName()
		{
			return null;
		}

		[Token(Token = "0x6001B60")]
		[Address(RVA = "0x971FCC", Offset = "0x971FCC", VA = "0x971FCC")]
		private UpgradableItem GetItem()
		{
			return null;
		}

		[Token(Token = "0x6001B61")]
		[Address(RVA = "0x972CAC", Offset = "0x972CAC", VA = "0x972CAC", Slot = "15")]
		public void SetResearchProgress(long progress)
		{
		}

		[Token(Token = "0x6001B62")]
		[Address(RVA = "0x972CE4", Offset = "0x972CE4", VA = "0x972CE4", Slot = "16")]
		public long GetResearchProgress()
		{
			return default(long);
		}

		[Token(Token = "0x6001B63")]
		[Address(RVA = "0x972D14", Offset = "0x972D14", VA = "0x972D14")]
		public void IncrementAmountBulk(long amount)
		{
		}

		[Token(Token = "0x6001B64")]
		[Address(RVA = "0x972DC0", Offset = "0x972DC0", VA = "0x972DC0", Slot = "17")]
		public void IncrementAmount()
		{
		}

		[Token(Token = "0x6001B65")]
		[Address(RVA = "0x9729B8", Offset = "0x9729B8", VA = "0x9729B8")]
		private Upgradable GetSisterUpgradable()
		{
			return null;
		}

		[Token(Token = "0x6001B66")]
		[Address(RVA = "0x972E68", Offset = "0x972E68", VA = "0x972E68")]
		public Upgradable()
		{
		}
	}
}
