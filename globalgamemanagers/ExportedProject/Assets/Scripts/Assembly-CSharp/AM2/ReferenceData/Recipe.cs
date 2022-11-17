using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000362")]
	public class Recipe : ResearchableRuntimeData<RDRecipe, RecipeItem>, IDustable
	{
		[Token(Token = "0x20007A7")]
		public class UpgradableContext
		{
			[Token(Token = "0x400224B")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832F60", Offset = "0x832F60")]
			private Upgradable _003Cupgradable_003Ek__BackingField;

			[Token(Token = "0x400224C")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832F70", Offset = "0x832F70")]
			private string _003Ccategory_003Ek__BackingField;

			[Token(Token = "0x400224D")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832F80", Offset = "0x832F80")]
			private EUnlockType _003CunlockType_003Ek__BackingField;

			[Token(Token = "0x17000808")]
			public Upgradable upgradable
			{
				[Token(Token = "0x60031A7")]
				[Address(RVA = "0x96AEE0", Offset = "0x96AEE0", VA = "0x96AEE0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B7AC", Offset = "0x83B7AC")]
				get
				{
					return null;
				}
				[Token(Token = "0x60031A8")]
				[Address(RVA = "0x96AEE8", Offset = "0x96AEE8", VA = "0x96AEE8")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B7BC", Offset = "0x83B7BC")]
				set
				{
				}
			}

			[Token(Token = "0x17000809")]
			public string category
			{
				[Token(Token = "0x60031A9")]
				[Address(RVA = "0x96AEF0", Offset = "0x96AEF0", VA = "0x96AEF0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B7CC", Offset = "0x83B7CC")]
				get
				{
					return null;
				}
				[Token(Token = "0x60031AA")]
				[Address(RVA = "0x96AEF8", Offset = "0x96AEF8", VA = "0x96AEF8")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B7DC", Offset = "0x83B7DC")]
				set
				{
				}
			}

			[Token(Token = "0x1700080A")]
			public EUnlockType unlockType
			{
				[Token(Token = "0x60031AB")]
				[Address(RVA = "0x96AF00", Offset = "0x96AF00", VA = "0x96AF00")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B7EC", Offset = "0x83B7EC")]
				get
				{
					return default(EUnlockType);
				}
				[Token(Token = "0x60031AC")]
				[Address(RVA = "0x96AF08", Offset = "0x96AF08", VA = "0x96AF08")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B7FC", Offset = "0x83B7FC")]
				set
				{
				}
			}

			[Token(Token = "0x60031AD")]
			[Address(RVA = "0x96AF10", Offset = "0x96AF10", VA = "0x96AF10")]
			public UpgradableContext(Upgradable inUpgradable, string inCategory, EUnlockType inUnlockType)
			{
			}
		}

		[Token(Token = "0x400108B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82A7E8", Offset = "0x82A7E8")]
		private string _003CrecipeItemReference_003Ek__BackingField;

		[Token(Token = "0x400108C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82A7F8", Offset = "0x82A7F8")]
		private string _003CconstructionItemReference_003Ek__BackingField;

		[Token(Token = "0x400108D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82A808", Offset = "0x82A808")]
		private Upgradable _003CmaxCapacityUpgradable_003Ek__BackingField;

		[Token(Token = "0x400108E")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82A818", Offset = "0x82A818")]
		private Upgradable _003CcyclesPerSecondUpgradable_003Ek__BackingField;

		[Token(Token = "0x400108F")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82A828", Offset = "0x82A828")]
		private Upgradable _003CvolumeUpgradable_003Ek__BackingField;

		[Token(Token = "0x4001090")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82A838", Offset = "0x82A838")]
		private Upgradable _003CsustainTimeUpgradable_003Ek__BackingField;

		[Token(Token = "0x4001091")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82A848", Offset = "0x82A848")]
		private Upgradable _003CbonusMaxCapacityUpgradable_003Ek__BackingField;

		[Token(Token = "0x4001092")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82A858", Offset = "0x82A858")]
		private Upgradable _003CbonusCyclesPerSecondUpgradable_003Ek__BackingField;

		[Token(Token = "0x4001093")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82A868", Offset = "0x82A868")]
		private Upgradable _003CbonusVolumeUpgradable_003Ek__BackingField;

		[Token(Token = "0x4001094")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82A878", Offset = "0x82A878")]
		private List<Regent> _003Cregents_003Ek__BackingField;

		[Token(Token = "0x4001095")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82A888", Offset = "0x82A888")]
		private HashSet<Recipe> _003CparentRecipes_003Ek__BackingField;

		[Token(Token = "0x4001096")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82A898", Offset = "0x82A898")]
		private HashSet<Recipe> _003CchildrenRecipes_003Ek__BackingField;

		[Token(Token = "0x4001097")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82A8A8", Offset = "0x82A8A8")]
		private List<UpgradableContext> _003CallUpgradables_003Ek__BackingField;

		[Token(Token = "0x4001098")]
		[FieldOffset(Offset = "0xD0")]
		private ZoneController m_zoneController;

		[Token(Token = "0x4001099")]
		[FieldOffset(Offset = "0xD8")]
		private ConstructionController m_constructionController;

		[Token(Token = "0x17000468")]
		public override string reference
		{
			[Token(Token = "0x6001AAC")]
			[Address(RVA = "0x9BACB8", Offset = "0x9BACB8", VA = "0x9BACB8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000469")]
		public string recipeItemReference
		{
			[Token(Token = "0x6001AAD")]
			[Address(RVA = "0x9BACC0", Offset = "0x9BACC0", VA = "0x9BACC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838020", Offset = "0x838020")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AAE")]
			[Address(RVA = "0x9BACC8", Offset = "0x9BACC8", VA = "0x9BACC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838030", Offset = "0x838030")]
			private set
			{
			}
		}

		[Token(Token = "0x1700046A")]
		public string constructionItemReference
		{
			[Token(Token = "0x6001AAF")]
			[Address(RVA = "0x9BACD0", Offset = "0x9BACD0", VA = "0x9BACD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838040", Offset = "0x838040")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AB0")]
			[Address(RVA = "0x9BACD8", Offset = "0x9BACD8", VA = "0x9BACD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838050", Offset = "0x838050")]
			private set
			{
			}
		}

		[Token(Token = "0x1700046B")]
		public double cyclesPerSecondTimesVolume
		{
			[Token(Token = "0x6001AB1")]
			[Address(RVA = "0x9BACE0", Offset = "0x9BACE0", VA = "0x9BACE0")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700046C")]
		public long maxCapacity
		{
			[Token(Token = "0x6001AB2")]
			[Address(RVA = "0x9BAD68", Offset = "0x9BAD68", VA = "0x9BAD68")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700046D")]
		public double cyclesPerSecond
		{
			[Token(Token = "0x6001AB3")]
			[Address(RVA = "0x9BAD38", Offset = "0x9BAD38", VA = "0x9BAD38")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700046E")]
		public long volume
		{
			[Token(Token = "0x6001AB4")]
			[Address(RVA = "0x9BAD50", Offset = "0x9BAD50", VA = "0x9BAD50")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700046F")]
		public bool fullyAutoSustained
		{
			[Token(Token = "0x6001AB5")]
			[Address(RVA = "0x9BADB0", Offset = "0x9BADB0", VA = "0x9BADB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000470")]
		public long sustainTimeInSeconds
		{
			[Token(Token = "0x6001AB6")]
			[Address(RVA = "0x9BAE0C", Offset = "0x9BAE0C", VA = "0x9BAE0C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000471")]
		public double previousCyclesPerSecond
		{
			[Token(Token = "0x6001AB7")]
			[Address(RVA = "0x9BAE28", Offset = "0x9BAE28", VA = "0x9BAE28")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000472")]
		public Upgradable maxCapacityUpgradable
		{
			[Token(Token = "0x6001AB8")]
			[Address(RVA = "0x9BAD80", Offset = "0x9BAD80", VA = "0x9BAD80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838060", Offset = "0x838060")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AB9")]
			[Address(RVA = "0x9BAEBC", Offset = "0x9BAEBC", VA = "0x9BAEBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838070", Offset = "0x838070")]
			private set
			{
			}
		}

		[Token(Token = "0x17000473")]
		public Upgradable cyclesPerSecondUpgradable
		{
			[Token(Token = "0x6001ABA")]
			[Address(RVA = "0x9BAD90", Offset = "0x9BAD90", VA = "0x9BAD90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838080", Offset = "0x838080")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001ABB")]
			[Address(RVA = "0x9BAEC4", Offset = "0x9BAEC4", VA = "0x9BAEC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838090", Offset = "0x838090")]
			private set
			{
			}
		}

		[Token(Token = "0x17000474")]
		public Upgradable volumeUpgradable
		{
			[Token(Token = "0x6001ABC")]
			[Address(RVA = "0x9BADA0", Offset = "0x9BADA0", VA = "0x9BADA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8380A0", Offset = "0x8380A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001ABD")]
			[Address(RVA = "0x9BAECC", Offset = "0x9BAECC", VA = "0x9BAECC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8380B0", Offset = "0x8380B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000475")]
		public Upgradable sustainTimeUpgradable
		{
			[Token(Token = "0x6001ABE")]
			[Address(RVA = "0x9BAE04", Offset = "0x9BAE04", VA = "0x9BAE04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8380C0", Offset = "0x8380C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001ABF")]
			[Address(RVA = "0x9BAED4", Offset = "0x9BAED4", VA = "0x9BAED4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8380D0", Offset = "0x8380D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000476")]
		public Upgradable bonusMaxCapacityUpgradable
		{
			[Token(Token = "0x6001AC0")]
			[Address(RVA = "0x9BAD88", Offset = "0x9BAD88", VA = "0x9BAD88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8380E0", Offset = "0x8380E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AC1")]
			[Address(RVA = "0x9BAEDC", Offset = "0x9BAEDC", VA = "0x9BAEDC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8380F0", Offset = "0x8380F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000477")]
		public Upgradable bonusCyclesPerSecondUpgradable
		{
			[Token(Token = "0x6001AC2")]
			[Address(RVA = "0x9BAD98", Offset = "0x9BAD98", VA = "0x9BAD98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838100", Offset = "0x838100")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AC3")]
			[Address(RVA = "0x9BAEE4", Offset = "0x9BAEE4", VA = "0x9BAEE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838110", Offset = "0x838110")]
			private set
			{
			}
		}

		[Token(Token = "0x17000478")]
		public Upgradable bonusVolumeUpgradable
		{
			[Token(Token = "0x6001AC4")]
			[Address(RVA = "0x9BADA8", Offset = "0x9BADA8", VA = "0x9BADA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838120", Offset = "0x838120")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AC5")]
			[Address(RVA = "0x9BAEEC", Offset = "0x9BAEEC", VA = "0x9BAEEC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838130", Offset = "0x838130")]
			private set
			{
			}
		}

		[Token(Token = "0x17000479")]
		public override string localizedAcquireText
		{
			[Token(Token = "0x6001AC6")]
			[Address(RVA = "0x9BAEF4", Offset = "0x9BAEF4", VA = "0x9BAEF4", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700047A")]
		public string category
		{
			[Token(Token = "0x6001AC7")]
			[Address(RVA = "0x9BAFE4", Offset = "0x9BAFE4", VA = "0x9BAFE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700047B")]
		public string bonusCategory
		{
			[Token(Token = "0x6001AC8")]
			[Address(RVA = "0x9BB010", Offset = "0x9BB010", VA = "0x9BB010")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700047C")]
		public sbyte displayPriority
		{
			[Token(Token = "0x6001AC9")]
			[Address(RVA = "0x9BB03C", Offset = "0x9BB03C", VA = "0x9BB03C")]
			get
			{
				return default(sbyte);
			}
		}

		[Token(Token = "0x1700047D")]
		public List<Regent> regents
		{
			[Token(Token = "0x6001ACA")]
			[Address(RVA = "0x9BB068", Offset = "0x9BB068", VA = "0x9BB068")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838140", Offset = "0x838140")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001ACB")]
			[Address(RVA = "0x9BB070", Offset = "0x9BB070", VA = "0x9BB070")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838150", Offset = "0x838150")]
			set
			{
			}
		}

		[Token(Token = "0x1700047E")]
		public HashSet<Recipe> parentRecipes
		{
			[Token(Token = "0x6001ACC")]
			[Address(RVA = "0x9BB078", Offset = "0x9BB078", VA = "0x9BB078")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838160", Offset = "0x838160")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001ACD")]
			[Address(RVA = "0x9BB080", Offset = "0x9BB080", VA = "0x9BB080")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838170", Offset = "0x838170")]
			set
			{
			}
		}

		[Token(Token = "0x1700047F")]
		public HashSet<Recipe> childrenRecipes
		{
			[Token(Token = "0x6001ACE")]
			[Address(RVA = "0x9BB088", Offset = "0x9BB088", VA = "0x9BB088")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838180", Offset = "0x838180")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001ACF")]
			[Address(RVA = "0x9BB090", Offset = "0x9BB090", VA = "0x9BB090")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838190", Offset = "0x838190")]
			set
			{
			}
		}

		[Token(Token = "0x17000480")]
		public List<UpgradableContext> allUpgradables
		{
			[Token(Token = "0x6001AD0")]
			[Address(RVA = "0x9B8E54", Offset = "0x9B8E54", VA = "0x9B8E54")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8381A0", Offset = "0x8381A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AD1")]
			[Address(RVA = "0x9BB098", Offset = "0x9BB098", VA = "0x9BB098")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8381B0", Offset = "0x8381B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000481")]
		public string readableName
		{
			[Token(Token = "0x6001AD2")]
			[Address(RVA = "0x9BAFB8", Offset = "0x9BAFB8", VA = "0x9BAFB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000482")]
		public override string readableItemName
		{
			[Token(Token = "0x6001AD3")]
			[Address(RVA = "0x9BB0A0", Offset = "0x9BB0A0", VA = "0x9BB0A0", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000483")]
		public BISoundEvents.EventKey jobStartSoundEventOverride
		{
			[Token(Token = "0x6001AD4")]
			[Address(RVA = "0x9BB0CC", Offset = "0x9BB0CC", VA = "0x9BB0CC")]
			get
			{
				return default(BISoundEvents.EventKey);
			}
		}

		[Token(Token = "0x17000484")]
		public BISoundEvents.EventKey jobSustainSoundEventOverride
		{
			[Token(Token = "0x6001AD5")]
			[Address(RVA = "0x9BB0F8", Offset = "0x9BB0F8", VA = "0x9BB0F8")]
			get
			{
				return default(BISoundEvents.EventKey);
			}
		}

		[Token(Token = "0x17000485")]
		public string dustInputItem
		{
			[Token(Token = "0x6001AD6")]
			[Address(RVA = "0x9BB124", Offset = "0x9BB124", VA = "0x9BB124", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000486")]
		public long dustOutputAmount
		{
			[Token(Token = "0x6001AD7")]
			[Address(RVA = "0x9BB150", Offset = "0x9BB150", VA = "0x9BB150", Slot = "33")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6001AAB")]
		[Address(RVA = "0x9BAC64", Offset = "0x9BAC64", VA = "0x9BAC64")]
		public static string GetRecipeItemReference(string baseReference)
		{
			return null;
		}

		[Token(Token = "0x6001AD8")]
		[Address(RVA = "0x9BB17C", Offset = "0x9BB17C", VA = "0x9BB17C")]
		public Recipe()
		{
		}

		[Token(Token = "0x6001AD9")]
		[Address(RVA = "0x9BB270", Offset = "0x9BB270", VA = "0x9BB270", Slot = "4")]
		public override void Initialize(RDRecipe referenceData)
		{
		}

		[Token(Token = "0x6001ADA")]
		[Address(RVA = "0x9BB2FC", Offset = "0x9BB2FC", VA = "0x9BB2FC")]
		public void Setup(RuntimeDataCache<Upgradable, RDUpgradable> upgradablesCache, RuntimeDataCache<Regent, RDRegent> regentsCache, RuntimeDataCache<SubTab, RDSubTab> subTabCache, RuntimeDataCache<Section, RDSection> sectionCache, RuntimeCostResourceCache costResourceCache)
		{
		}

		[Token(Token = "0x6001ADB")]
		[Address(RVA = "0x9BBA48", Offset = "0x9BBA48", VA = "0x9BBA48")]
		private void AddUpgradableToList(Upgradable inUpgradable, string category, EUnlockType inUnlockType)
		{
		}

		[Token(Token = "0x6001ADC")]
		[Address(RVA = "0x9BBB08", Offset = "0x9BBB08", VA = "0x9BBB08")]
		public void ApplyBooster(SpeedBooster booster)
		{
		}

		[Token(Token = "0x6001ADD")]
		[Address(RVA = "0x9BBB0C", Offset = "0x9BBB0C", VA = "0x9BBB0C")]
		public void RemoveBooster(SpeedBooster booster)
		{
		}

		[Token(Token = "0x6001ADE")]
		[Address(RVA = "0x9BBB10", Offset = "0x9BBB10", VA = "0x9BBB10")]
		public void ClearReferences()
		{
		}

		[Token(Token = "0x6001ADF")]
		[Address(RVA = "0x9BBB94", Offset = "0x9BBB94", VA = "0x9BBB94", Slot = "34")]
		public bool Dust(long count)
		{
			return default(bool);
		}
	}
}
