using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000369")]
	public abstract class ResearchableRuntimeData<T, U> : RuntimeData<T>, IResearchable, ISubTabItemModel, IItemModel, IInfoText where T : RDResearchable where U : ResearchableUnlockableItem, new()
	{
		[Token(Token = "0x40010C0")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B13C", Offset = "0x82B13C")]
		private RewardGroup _003ConResearchRewardGroup_003Ek__BackingField;

		[Token(Token = "0x40010C1")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B14C", Offset = "0x82B14C")]
		private SubTab _003CsubTab_003Ek__BackingField;

		[Token(Token = "0x40010C2")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B15C", Offset = "0x82B15C")]
		private SubTab _003CresearchableSubTab_003Ek__BackingField;

		[Token(Token = "0x40010C3")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B16C", Offset = "0x82B16C")]
		private Section _003Csection_003Ek__BackingField;

		[Token(Token = "0x40010C4")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B17C", Offset = "0x82B17C")]
		private Section _003CresearchableSection_003Ek__BackingField;

		[Token(Token = "0x40010C5")]
		[FieldOffset(Offset = "0x0")]
		protected EBuyRefDataType m_buyRefDataType;

		[Token(Token = "0x40010C6")]
		[FieldOffset(Offset = "0x0")]
		private U m_item;

		[Token(Token = "0x40010C7")]
		[FieldOffset(Offset = "0x0")]
		protected InventoryController m_inventoryController;

		[Token(Token = "0x40010C8")]
		[FieldOffset(Offset = "0x0")]
		protected Localizations m_localizationController;

		[Token(Token = "0x40010C9")]
		[FieldOffset(Offset = "0x0")]
		private ConstructionController m_constructionController;

		[Token(Token = "0x17000497")]
		public string costItemRef
		{
			[Token(Token = "0x6001B0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000498")]
		public long costQuantity
		{
			[Token(Token = "0x6001B0D")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000499")]
		public EBuyType buyType
		{
			[Token(Token = "0x6001B0E")]
			get
			{
				return default(EBuyType);
			}
		}

		[Token(Token = "0x1700049A")]
		public EBuyRefDataType buyRefDataType
		{
			[Token(Token = "0x6001B0F")]
			get
			{
				return default(EBuyRefDataType);
			}
		}

		[Token(Token = "0x1700049B")]
		public virtual string localizedAcquireText
		{
			[Token(Token = "0x6001B10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700049C")]
		public RewardGroup onResearchRewardGroup
		{
			[Token(Token = "0x6001B11")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8382C0", Offset = "0x8382C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B12")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8382D0", Offset = "0x8382D0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700049D")]
		public double remainingTimeToProgressInSeconds
		{
			[Token(Token = "0x6001B13")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6001B14")]
			set
			{
			}
		}

		[Token(Token = "0x1700049E")]
		public SubTab subTab
		{
			[Token(Token = "0x6001B15")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8382E0", Offset = "0x8382E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B16")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8382F0", Offset = "0x8382F0")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700049F")]
		public SubTab researchableSubTab
		{
			[Token(Token = "0x6001B17")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838300", Offset = "0x838300")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838310", Offset = "0x838310")]
			private set
			{
			}
		}

		[Token(Token = "0x170004A0")]
		public Section section
		{
			[Token(Token = "0x6001B19")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838320", Offset = "0x838320")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B1A")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838330", Offset = "0x838330")]
			protected set
			{
			}
		}

		[Token(Token = "0x170004A1")]
		public Section researchableSection
		{
			[Token(Token = "0x6001B1B")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838340", Offset = "0x838340")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838350", Offset = "0x838350")]
			protected set
			{
			}
		}

		[Token(Token = "0x170004A2")]
		public virtual string readableItemName
		{
			[Token(Token = "0x6001B1D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A3")]
		public string description
		{
			[Token(Token = "0x6001B1E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A4")]
		public string researchInfoText
		{
			[Token(Token = "0x6001B1F")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A5")]
		public string infoImageSource
		{
			[Token(Token = "0x6001B20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001B21")]
		public Dictionary<string, long> GetCostsDict()
		{
			return null;
		}

		[Token(Token = "0x6001B22")]
		public Dictionary<string, long> GetDictionaryLevelGates()
		{
			return null;
		}

		[Token(Token = "0x6001B23")]
		public void Setup(RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache, RuntimeDataCache<SubTab, RDSubTab> subTabCache, RuntimeDataCache<Section, RDSection> sectionCache, RuntimeCostResourceCache costResourceCache)
		{
		}

		[Token(Token = "0x6001B24")]
		public BuyDisplayInfo GetBuyDisplayInfo()
		{
			return default(BuyDisplayInfo);
		}

		[Token(Token = "0x6001B25")]
		public string GetBuyName()
		{
			return null;
		}

		[Token(Token = "0x6001B26")]
		private U GetItem()
		{
			return null;
		}

		[Token(Token = "0x6001B27")]
		public void SetResearchProgress(long progress)
		{
		}

		[Token(Token = "0x6001B28")]
		public long GetResearchProgress()
		{
			return default(long);
		}

		[Token(Token = "0x6001B29")]
		public void IncrementAmount()
		{
		}

		[Token(Token = "0x6001B2A")]
		public bool IsLevelMaxed()
		{
			return default(bool);
		}

		[Token(Token = "0x6001B2B")]
		protected ResearchableRuntimeData()
		{
		}
	}
}
