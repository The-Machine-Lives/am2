using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;
using Uken.Library.UkenTime;

namespace AM2
{
	[Token(Token = "0x200030B")]
	public class SharedDataCacheController : DepotController, IInventoryProgressTracker
	{
		[Token(Token = "0x4000E29")]
		public const string c_powerResourceName = "power";

		[Token(Token = "0x4000E2A")]
		public const string c_powerRecipeResourceName = "power_recipe";

		[Token(Token = "0x4000E2B")]
		public const string c_researchSlotName = "research_slot_";

		[Token(Token = "0x4000E2C")]
		public const string c_dynamicAdName = "dynamic";

		[Token(Token = "0x4000E2D")]
		private const int c_TEMP_MAX_POSSIBLE_RESEARCH_SLOTS = 10;

		[Token(Token = "0x4000E2E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826814", Offset = "0x826814")]
		private ResearchSystem _003CresearchSystem_003Ek__BackingField;

		[Token(Token = "0x4000E2F")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826824", Offset = "0x826824")]
		private Power _003Cpower_003Ek__BackingField;

		[Token(Token = "0x4000E30")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826834", Offset = "0x826834")]
		private Recipe _003CpowerRecipe_003Ek__BackingField;

		[Token(Token = "0x4000E31")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826844", Offset = "0x826844")]
		private RuntimeDataCache<RewardGroup, RDRewardGroup> _003CrewardGroupsCache_003Ek__BackingField;

		[Token(Token = "0x4000E32")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826854", Offset = "0x826854")]
		private RuntimeRewardsCache _003CrewardsCache_003Ek__BackingField;

		[Token(Token = "0x4000E33")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826864", Offset = "0x826864")]
		private RuntimeDataCache<SubTab, RDSubTab> _003CsubTabCache_003Ek__BackingField;

		[Token(Token = "0x4000E34")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826874", Offset = "0x826874")]
		private RuntimeDataCache<Section, RDSection> _003CsectionCache_003Ek__BackingField;

		[Token(Token = "0x4000E35")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826884", Offset = "0x826884")]
		private FormulaDataCache _003CformulaCache_003Ek__BackingField;

		[Token(Token = "0x4000E36")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826894", Offset = "0x826894")]
		private RuntimeItemModelDataCache<Tag, RDTag> _003CtagsCache_003Ek__BackingField;

		[Token(Token = "0x4000E37")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8268A4", Offset = "0x8268A4")]
		private RuntimeDataCache<Choice, RDChoice> _003CchoicesCache_003Ek__BackingField;

		[Token(Token = "0x4000E38")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8268B4", Offset = "0x8268B4")]
		private RuntimeDataCache<EquipmentEffect, RDEquipmentEffect> _003CequipmentEffectsCache_003Ek__BackingField;

		[Token(Token = "0x4000E39")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8268C4", Offset = "0x8268C4")]
		private RuntimeCostResourceCache _003CcostResourcesCache_003Ek__BackingField;

		[Token(Token = "0x4000E3A")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8268D4", Offset = "0x8268D4")]
		private List<Recipe> _003CallRecipesInTree_003Ek__BackingField;

		[Token(Token = "0x4000E3B")]
		[FieldOffset(Offset = "0x88")]
		private RuntimeDataCache<GlobalLeaderboard, RDGlobalLeaderboard> m_globalLeaderboardsCache;

		[Token(Token = "0x4000E3C")]
		[FieldOffset(Offset = "0x90")]
		private RuntimeDataCache<RewardScaleSet, RDRewardScaleSet> m_rewardScaleSetsCache;

		[Token(Token = "0x4000E3D")]
		[FieldOffset(Offset = "0x98")]
		private RuntimeDataCache<ScaleSetEntry, RDScaleSetEntry> m_scaleSetEntriesCache;

		[Token(Token = "0x4000E3E")]
		[FieldOffset(Offset = "0xA0")]
		private RuntimeDataCache<Regent, RDRegent> m_regentsCache;

		[Token(Token = "0x4000E3F")]
		[FieldOffset(Offset = "0xA8")]
		private RuntimeDataCache<Tab, RDTab> m_tabCache;

		[Token(Token = "0x4000E40")]
		[FieldOffset(Offset = "0xB0")]
		private RuntimeRecipesCache m_recipesCache;

		[Token(Token = "0x4000E41")]
		[FieldOffset(Offset = "0xB8")]
		private RuntimeUpgradablesCache m_upgradablesCache;

		[Token(Token = "0x4000E42")]
		[FieldOffset(Offset = "0xC0")]
		private RuntimeAdsCache m_adsCache;

		[Token(Token = "0x4000E43")]
		[FieldOffset(Offset = "0xC8")]
		private RuntimeStoreItemCache m_storeItemsCache;

		[Token(Token = "0x4000E44")]
		[FieldOffset(Offset = "0xD0")]
		private RuntimeDataCache<SpeedBoosterReward, RDSpeedBoosterReward> m_speedBoosterRewardsCache;

		[Token(Token = "0x4000E45")]
		[FieldOffset(Offset = "0xD8")]
		private RuntimeItemModelDataCache<SpeedBooster, RDSpeedBooster> m_speedBoosterCache;

		[Token(Token = "0x4000E46")]
		[FieldOffset(Offset = "0xE0")]
		private RuntimeItemConverterCache m_itemConvertersCache;

		[Token(Token = "0x4000E47")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8268E4", Offset = "0x8268E4")]
		private RuntimeTasksCache _003Cm_tasksCache_003Ek__BackingField;

		[Token(Token = "0x4000E48")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8268F4", Offset = "0x8268F4")]
		private RuntimeQuestsCache _003Cm_questsCache_003Ek__BackingField;

		[Token(Token = "0x4000E49")]
		[FieldOffset(Offset = "0xF8")]
		private RuntimeEventQuestsCache m_eventQuestsCache;

		[Token(Token = "0x4000E4A")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826904", Offset = "0x826904")]
		private RuntimeAbilityGroupsCache _003CabilityGroupsCache_003Ek__BackingField;

		[Token(Token = "0x4000E4B")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826914", Offset = "0x826914")]
		private RuntimeAbilitiesCache _003CabilitiesCache_003Ek__BackingField;

		[Token(Token = "0x4000E4C")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826924", Offset = "0x826924")]
		private RuntimeDataCache<StatusEffectStun, RDStatusEffectStun> _003CstatusEffectsStunCache_003Ek__BackingField;

		[Token(Token = "0x4000E4D")]
		[FieldOffset(Offset = "0x118")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826934", Offset = "0x826934")]
		private RuntimeDataCache<StatusEffectReflectDamage, RDStatusEffectReflectDamage> _003CstatusEffectsReflectDamageCache_003Ek__BackingField;

		[Token(Token = "0x4000E4E")]
		[FieldOffset(Offset = "0x120")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826944", Offset = "0x826944")]
		private RuntimeDataCache<StatusEffectStatModifier, RDStatusEffectStatModifier> _003CstatusEffectsStatModifierCache_003Ek__BackingField;

		[Token(Token = "0x4000E4F")]
		[FieldOffset(Offset = "0x128")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826954", Offset = "0x826954")]
		private RuntimeDataCache<StatusEffectImmuneToBuff, RDStatusEffectImmuneToBuff> _003CstatusEffectsImmuneToBuffCache_003Ek__BackingField;

		[Token(Token = "0x4000E50")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826964", Offset = "0x826964")]
		private RuntimeDataCache<DiffHealth, RDDiffHealth> _003CdiffHealthsCache_003Ek__BackingField;

		[Token(Token = "0x4000E51")]
		[FieldOffset(Offset = "0x138")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826974", Offset = "0x826974")]
		private RuntimeBuffsCache _003CbuffsCache_003Ek__BackingField;

		[Token(Token = "0x4000E52")]
		[FieldOffset(Offset = "0x140")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826984", Offset = "0x826984")]
		private RuntimePrestigeLevelUpRewardsCache _003CprestigeLevelUpRewardsCache_003Ek__BackingField;

		[Token(Token = "0x4000E53")]
		[FieldOffset(Offset = "0x148")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826994", Offset = "0x826994")]
		private RuntimePrestigesCache _003CprestigesCache_003Ek__BackingField;

		[Token(Token = "0x4000E54")]
		[FieldOffset(Offset = "0x150")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8269A4", Offset = "0x8269A4")]
		private RuntimePrestigePermanentItemsCache _003CprestigePermanentItemsCache_003Ek__BackingField;

		[Token(Token = "0x4000E55")]
		[FieldOffset(Offset = "0x158")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8269B4", Offset = "0x8269B4")]
		private RuntimeDataCache<TierDropRate, RDTierDropRate> _003CtierDropRateCache_003Ek__BackingField;

		[Token(Token = "0x4000E56")]
		[FieldOffset(Offset = "0x160")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8269C4", Offset = "0x8269C4")]
		private RuntimeDataCache<TierDropSet, RDTierDropSet> _003CtierDropSetCache_003Ek__BackingField;

		[Token(Token = "0x4000E57")]
		[FieldOffset(Offset = "0x168")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8269D4", Offset = "0x8269D4")]
		private RuntimeItemModelDataCache<DynamicAds, RDDynamicAds> _003CdynamicAdsCache_003Ek__BackingField;

		[Token(Token = "0x4000E58")]
		[FieldOffset(Offset = "0x170")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8269E4", Offset = "0x8269E4")]
		private RuntimeDataCache<Credits, RDCredits> _003CcreditsCache_003Ek__BackingField;

		[Token(Token = "0x4000E59")]
		[FieldOffset(Offset = "0x178")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8269F4", Offset = "0x8269F4")]
		private RuntimeItemModelDataCache<MiniEvent, RDMiniEvent> _003CminiEventCache_003Ek__BackingField;

		[Token(Token = "0x4000E5A")]
		[FieldOffset(Offset = "0x180")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826A04", Offset = "0x826A04")]
		private RuntimeDataCache<LTOGroups, RDLTOGroups> _003ClTOGroupsCache_003Ek__BackingField;

		[Token(Token = "0x4000E5B")]
		[FieldOffset(Offset = "0x188")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826A14", Offset = "0x826A14")]
		private RuntimeDataCache<AutoConversion, RDAutoConversion> _003CautoConversionCache_003Ek__BackingField;

		[Token(Token = "0x4000E5C")]
		[FieldOffset(Offset = "0x190")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826A24", Offset = "0x826A24")]
		private RuntimeItemModelDataCache<VIPStatus, RDVIPStatus> _003CvIPStatusCache_003Ek__BackingField;

		[Token(Token = "0x4000E5D")]
		[FieldOffset(Offset = "0x198")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826A34", Offset = "0x826A34")]
		private RuntimeDataCache<GlobalScaler, RDGlobalScaler> _003CglobalScalerCache_003Ek__BackingField;

		[Token(Token = "0x4000E5E")]
		[FieldOffset(Offset = "0x1A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826A44", Offset = "0x826A44")]
		private Dictionary<string, IAbilityEffect> _003CallAbilityEffects_003Ek__BackingField;

		[Token(Token = "0x4000E5F")]
		[FieldOffset(Offset = "0x1A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826A54", Offset = "0x826A54")]
		private Dictionary<string, IStatusEffect> _003CallStatusEffects_003Ek__BackingField;

		[Token(Token = "0x4000E60")]
		[FieldOffset(Offset = "0x1B0")]
		private Dictionary<string, Tag> m_inventoryTags;

		[Token(Token = "0x4000E61")]
		[FieldOffset(Offset = "0x1B8")]
		private UkenTimeController m_time;

		[Token(Token = "0x4000E62")]
		[FieldOffset(Offset = "0x1C0")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x4000E63")]
		[FieldOffset(Offset = "0x1C8")]
		private CasualDataCacheController m_casualDataCacheController;

		[Token(Token = "0x17000324")]
		public ResearchSystem researchSystem
		{
			[Token(Token = "0x60017E7")]
			[Address(RVA = "0x9733AC", Offset = "0x9733AC", VA = "0x9733AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837530", Offset = "0x837530")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017E8")]
			[Address(RVA = "0x9733B4", Offset = "0x9733B4", VA = "0x9733B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837540", Offset = "0x837540")]
			private set
			{
			}
		}

		[Token(Token = "0x17000325")]
		public Power power
		{
			[Token(Token = "0x60017E9")]
			[Address(RVA = "0x9733BC", Offset = "0x9733BC", VA = "0x9733BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837550", Offset = "0x837550")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017EA")]
			[Address(RVA = "0x9733C4", Offset = "0x9733C4", VA = "0x9733C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837560", Offset = "0x837560")]
			private set
			{
			}
		}

		[Token(Token = "0x17000326")]
		public Recipe powerRecipe
		{
			[Token(Token = "0x60017EB")]
			[Address(RVA = "0x9733CC", Offset = "0x9733CC", VA = "0x9733CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837570", Offset = "0x837570")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017EC")]
			[Address(RVA = "0x9733D4", Offset = "0x9733D4", VA = "0x9733D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837580", Offset = "0x837580")]
			private set
			{
			}
		}

		[Token(Token = "0x17000327")]
		public RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache
		{
			[Token(Token = "0x60017ED")]
			[Address(RVA = "0x9733DC", Offset = "0x9733DC", VA = "0x9733DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837590", Offset = "0x837590")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017EE")]
			[Address(RVA = "0x9733E4", Offset = "0x9733E4", VA = "0x9733E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8375A0", Offset = "0x8375A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000328")]
		public RuntimeRewardsCache rewardsCache
		{
			[Token(Token = "0x60017EF")]
			[Address(RVA = "0x9733EC", Offset = "0x9733EC", VA = "0x9733EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8375B0", Offset = "0x8375B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017F0")]
			[Address(RVA = "0x9733F4", Offset = "0x9733F4", VA = "0x9733F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8375C0", Offset = "0x8375C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000329")]
		public RuntimeDataCache<SubTab, RDSubTab> subTabCache
		{
			[Token(Token = "0x60017F1")]
			[Address(RVA = "0x9733FC", Offset = "0x9733FC", VA = "0x9733FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8375D0", Offset = "0x8375D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017F2")]
			[Address(RVA = "0x973404", Offset = "0x973404", VA = "0x973404")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8375E0", Offset = "0x8375E0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700032A")]
		public RuntimeDataCache<Section, RDSection> sectionCache
		{
			[Token(Token = "0x60017F3")]
			[Address(RVA = "0x97340C", Offset = "0x97340C", VA = "0x97340C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8375F0", Offset = "0x8375F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017F4")]
			[Address(RVA = "0x973414", Offset = "0x973414", VA = "0x973414")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837600", Offset = "0x837600")]
			private set
			{
			}
		}

		[Token(Token = "0x1700032B")]
		public FormulaDataCache formulaCache
		{
			[Token(Token = "0x60017F5")]
			[Address(RVA = "0x97341C", Offset = "0x97341C", VA = "0x97341C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837610", Offset = "0x837610")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017F6")]
			[Address(RVA = "0x973424", Offset = "0x973424", VA = "0x973424")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837620", Offset = "0x837620")]
			private set
			{
			}
		}

		[Token(Token = "0x1700032C")]
		public RuntimeItemModelDataCache<Tag, RDTag> tagsCache
		{
			[Token(Token = "0x60017F7")]
			[Address(RVA = "0x97342C", Offset = "0x97342C", VA = "0x97342C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837630", Offset = "0x837630")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017F8")]
			[Address(RVA = "0x973434", Offset = "0x973434", VA = "0x973434")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837640", Offset = "0x837640")]
			private set
			{
			}
		}

		[Token(Token = "0x1700032D")]
		public RuntimeDataCache<Choice, RDChoice> choicesCache
		{
			[Token(Token = "0x60017F9")]
			[Address(RVA = "0x97343C", Offset = "0x97343C", VA = "0x97343C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837650", Offset = "0x837650")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017FA")]
			[Address(RVA = "0x973444", Offset = "0x973444", VA = "0x973444")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837660", Offset = "0x837660")]
			private set
			{
			}
		}

		[Token(Token = "0x1700032E")]
		public RuntimeDataCache<EquipmentEffect, RDEquipmentEffect> equipmentEffectsCache
		{
			[Token(Token = "0x60017FB")]
			[Address(RVA = "0x97344C", Offset = "0x97344C", VA = "0x97344C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837670", Offset = "0x837670")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017FC")]
			[Address(RVA = "0x973454", Offset = "0x973454", VA = "0x973454")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837680", Offset = "0x837680")]
			private set
			{
			}
		}

		[Token(Token = "0x1700032F")]
		public RuntimeCostResourceCache costResourcesCache
		{
			[Token(Token = "0x60017FD")]
			[Address(RVA = "0x97345C", Offset = "0x97345C", VA = "0x97345C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837690", Offset = "0x837690")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017FE")]
			[Address(RVA = "0x973464", Offset = "0x973464", VA = "0x973464")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8376A0", Offset = "0x8376A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000330")]
		public List<Recipe> allRecipesInTree
		{
			[Token(Token = "0x60017FF")]
			[Address(RVA = "0x97346C", Offset = "0x97346C", VA = "0x97346C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8376B0", Offset = "0x8376B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001800")]
			[Address(RVA = "0x973474", Offset = "0x973474", VA = "0x973474")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8376C0", Offset = "0x8376C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000331")]
		public RuntimeTasksCache m_tasksCache
		{
			[Token(Token = "0x6001801")]
			[Address(RVA = "0x97347C", Offset = "0x97347C", VA = "0x97347C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8376D0", Offset = "0x8376D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001802")]
			[Address(RVA = "0x973484", Offset = "0x973484", VA = "0x973484")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8376E0", Offset = "0x8376E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000332")]
		public RuntimeQuestsCache m_questsCache
		{
			[Token(Token = "0x6001803")]
			[Address(RVA = "0x97348C", Offset = "0x97348C", VA = "0x97348C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8376F0", Offset = "0x8376F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001804")]
			[Address(RVA = "0x973494", Offset = "0x973494", VA = "0x973494")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837700", Offset = "0x837700")]
			private set
			{
			}
		}

		[Token(Token = "0x17000333")]
		public RuntimeAbilityGroupsCache abilityGroupsCache
		{
			[Token(Token = "0x6001805")]
			[Address(RVA = "0x97349C", Offset = "0x97349C", VA = "0x97349C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837710", Offset = "0x837710")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001806")]
			[Address(RVA = "0x9734A4", Offset = "0x9734A4", VA = "0x9734A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837720", Offset = "0x837720")]
			private set
			{
			}
		}

		[Token(Token = "0x17000334")]
		public RuntimeAbilitiesCache abilitiesCache
		{
			[Token(Token = "0x6001807")]
			[Address(RVA = "0x9734AC", Offset = "0x9734AC", VA = "0x9734AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837730", Offset = "0x837730")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001808")]
			[Address(RVA = "0x9734B4", Offset = "0x9734B4", VA = "0x9734B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837740", Offset = "0x837740")]
			private set
			{
			}
		}

		[Token(Token = "0x17000335")]
		public RuntimeDataCache<StatusEffectStun, RDStatusEffectStun> statusEffectsStunCache
		{
			[Token(Token = "0x6001809")]
			[Address(RVA = "0x9734BC", Offset = "0x9734BC", VA = "0x9734BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837750", Offset = "0x837750")]
			get
			{
				return null;
			}
			[Token(Token = "0x600180A")]
			[Address(RVA = "0x9734C4", Offset = "0x9734C4", VA = "0x9734C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837760", Offset = "0x837760")]
			private set
			{
			}
		}

		[Token(Token = "0x17000336")]
		public RuntimeDataCache<StatusEffectReflectDamage, RDStatusEffectReflectDamage> statusEffectsReflectDamageCache
		{
			[Token(Token = "0x600180B")]
			[Address(RVA = "0x9734CC", Offset = "0x9734CC", VA = "0x9734CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837770", Offset = "0x837770")]
			get
			{
				return null;
			}
			[Token(Token = "0x600180C")]
			[Address(RVA = "0x9734D4", Offset = "0x9734D4", VA = "0x9734D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837780", Offset = "0x837780")]
			private set
			{
			}
		}

		[Token(Token = "0x17000337")]
		public RuntimeDataCache<StatusEffectStatModifier, RDStatusEffectStatModifier> statusEffectsStatModifierCache
		{
			[Token(Token = "0x600180D")]
			[Address(RVA = "0x9734DC", Offset = "0x9734DC", VA = "0x9734DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837790", Offset = "0x837790")]
			get
			{
				return null;
			}
			[Token(Token = "0x600180E")]
			[Address(RVA = "0x9734E4", Offset = "0x9734E4", VA = "0x9734E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8377A0", Offset = "0x8377A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000338")]
		public RuntimeDataCache<StatusEffectImmuneToBuff, RDStatusEffectImmuneToBuff> statusEffectsImmuneToBuffCache
		{
			[Token(Token = "0x600180F")]
			[Address(RVA = "0x9734EC", Offset = "0x9734EC", VA = "0x9734EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8377B0", Offset = "0x8377B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001810")]
			[Address(RVA = "0x9734F4", Offset = "0x9734F4", VA = "0x9734F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8377C0", Offset = "0x8377C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000339")]
		public RuntimeDataCache<DiffHealth, RDDiffHealth> diffHealthsCache
		{
			[Token(Token = "0x6001811")]
			[Address(RVA = "0x9734FC", Offset = "0x9734FC", VA = "0x9734FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8377D0", Offset = "0x8377D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001812")]
			[Address(RVA = "0x973504", Offset = "0x973504", VA = "0x973504")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8377E0", Offset = "0x8377E0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700033A")]
		public RuntimeBuffsCache buffsCache
		{
			[Token(Token = "0x6001813")]
			[Address(RVA = "0x97350C", Offset = "0x97350C", VA = "0x97350C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8377F0", Offset = "0x8377F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001814")]
			[Address(RVA = "0x973514", Offset = "0x973514", VA = "0x973514")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837800", Offset = "0x837800")]
			private set
			{
			}
		}

		[Token(Token = "0x1700033B")]
		public RuntimePrestigeLevelUpRewardsCache prestigeLevelUpRewardsCache
		{
			[Token(Token = "0x6001815")]
			[Address(RVA = "0x97351C", Offset = "0x97351C", VA = "0x97351C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837810", Offset = "0x837810")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001816")]
			[Address(RVA = "0x973524", Offset = "0x973524", VA = "0x973524")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837820", Offset = "0x837820")]
			private set
			{
			}
		}

		[Token(Token = "0x1700033C")]
		public RuntimePrestigesCache prestigesCache
		{
			[Token(Token = "0x6001817")]
			[Address(RVA = "0x97352C", Offset = "0x97352C", VA = "0x97352C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837830", Offset = "0x837830")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001818")]
			[Address(RVA = "0x973534", Offset = "0x973534", VA = "0x973534")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837840", Offset = "0x837840")]
			private set
			{
			}
		}

		[Token(Token = "0x1700033D")]
		public RuntimePrestigePermanentItemsCache prestigePermanentItemsCache
		{
			[Token(Token = "0x6001819")]
			[Address(RVA = "0x97353C", Offset = "0x97353C", VA = "0x97353C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837850", Offset = "0x837850")]
			get
			{
				return null;
			}
			[Token(Token = "0x600181A")]
			[Address(RVA = "0x973544", Offset = "0x973544", VA = "0x973544")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837860", Offset = "0x837860")]
			private set
			{
			}
		}

		[Token(Token = "0x1700033E")]
		public RuntimeDataCache<TierDropRate, RDTierDropRate> tierDropRateCache
		{
			[Token(Token = "0x600181B")]
			[Address(RVA = "0x97354C", Offset = "0x97354C", VA = "0x97354C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837870", Offset = "0x837870")]
			get
			{
				return null;
			}
			[Token(Token = "0x600181C")]
			[Address(RVA = "0x973554", Offset = "0x973554", VA = "0x973554")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837880", Offset = "0x837880")]
			private set
			{
			}
		}

		[Token(Token = "0x1700033F")]
		public RuntimeDataCache<TierDropSet, RDTierDropSet> tierDropSetCache
		{
			[Token(Token = "0x600181D")]
			[Address(RVA = "0x97355C", Offset = "0x97355C", VA = "0x97355C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837890", Offset = "0x837890")]
			get
			{
				return null;
			}
			[Token(Token = "0x600181E")]
			[Address(RVA = "0x973564", Offset = "0x973564", VA = "0x973564")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8378A0", Offset = "0x8378A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000340")]
		public RuntimeItemModelDataCache<DynamicAds, RDDynamicAds> dynamicAdsCache
		{
			[Token(Token = "0x600181F")]
			[Address(RVA = "0x97356C", Offset = "0x97356C", VA = "0x97356C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8378B0", Offset = "0x8378B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001820")]
			[Address(RVA = "0x973574", Offset = "0x973574", VA = "0x973574")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8378C0", Offset = "0x8378C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000341")]
		public RuntimeDataCache<Credits, RDCredits> creditsCache
		{
			[Token(Token = "0x6001821")]
			[Address(RVA = "0x97357C", Offset = "0x97357C", VA = "0x97357C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8378D0", Offset = "0x8378D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001822")]
			[Address(RVA = "0x973584", Offset = "0x973584", VA = "0x973584")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8378E0", Offset = "0x8378E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000342")]
		public RuntimeItemModelDataCache<MiniEvent, RDMiniEvent> miniEventCache
		{
			[Token(Token = "0x6001823")]
			[Address(RVA = "0x97358C", Offset = "0x97358C", VA = "0x97358C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8378F0", Offset = "0x8378F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001824")]
			[Address(RVA = "0x973594", Offset = "0x973594", VA = "0x973594")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837900", Offset = "0x837900")]
			private set
			{
			}
		}

		[Token(Token = "0x17000343")]
		public RuntimeDataCache<LTOGroups, RDLTOGroups> lTOGroupsCache
		{
			[Token(Token = "0x6001825")]
			[Address(RVA = "0x97359C", Offset = "0x97359C", VA = "0x97359C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837910", Offset = "0x837910")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001826")]
			[Address(RVA = "0x9735A4", Offset = "0x9735A4", VA = "0x9735A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837920", Offset = "0x837920")]
			private set
			{
			}
		}

		[Token(Token = "0x17000344")]
		public RuntimeDataCache<AutoConversion, RDAutoConversion> autoConversionCache
		{
			[Token(Token = "0x6001827")]
			[Address(RVA = "0x9735AC", Offset = "0x9735AC", VA = "0x9735AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837930", Offset = "0x837930")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001828")]
			[Address(RVA = "0x9735B4", Offset = "0x9735B4", VA = "0x9735B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837940", Offset = "0x837940")]
			private set
			{
			}
		}

		[Token(Token = "0x17000345")]
		public RuntimeItemModelDataCache<VIPStatus, RDVIPStatus> vIPStatusCache
		{
			[Token(Token = "0x6001829")]
			[Address(RVA = "0x9735BC", Offset = "0x9735BC", VA = "0x9735BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837950", Offset = "0x837950")]
			get
			{
				return null;
			}
			[Token(Token = "0x600182A")]
			[Address(RVA = "0x9735C4", Offset = "0x9735C4", VA = "0x9735C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837960", Offset = "0x837960")]
			private set
			{
			}
		}

		[Token(Token = "0x17000346")]
		public RuntimeDataCache<GlobalScaler, RDGlobalScaler> globalScalerCache
		{
			[Token(Token = "0x600182B")]
			[Address(RVA = "0x9735CC", Offset = "0x9735CC", VA = "0x9735CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837970", Offset = "0x837970")]
			get
			{
				return null;
			}
			[Token(Token = "0x600182C")]
			[Address(RVA = "0x9735D4", Offset = "0x9735D4", VA = "0x9735D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837980", Offset = "0x837980")]
			private set
			{
			}
		}

		[Token(Token = "0x17000347")]
		public Dictionary<string, IAbilityEffect> allAbilityEffects
		{
			[Token(Token = "0x600182D")]
			[Address(RVA = "0x9735DC", Offset = "0x9735DC", VA = "0x9735DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837990", Offset = "0x837990")]
			get
			{
				return null;
			}
			[Token(Token = "0x600182E")]
			[Address(RVA = "0x9735E4", Offset = "0x9735E4", VA = "0x9735E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8379A0", Offset = "0x8379A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000348")]
		public Dictionary<string, IStatusEffect> allStatusEffects
		{
			[Token(Token = "0x600182F")]
			[Address(RVA = "0x9735EC", Offset = "0x9735EC", VA = "0x9735EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8379B0", Offset = "0x8379B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001830")]
			[Address(RVA = "0x9735F4", Offset = "0x9735F4", VA = "0x9735F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8379C0", Offset = "0x8379C0")]
			private set
			{
			}
		}

		[Token(Token = "0x6001831")]
		[Address(RVA = "0x9735FC", Offset = "0x9735FC", VA = "0x9735FC")]
		public SharedDataCacheController(AM2DataStoreController dataStoreController, InventoryController inventoryController, CasualDataCacheController casualDataCacheController)
		{
		}

		[Token(Token = "0x6001832")]
		[Address(RVA = "0x9736BC", Offset = "0x9736BC", VA = "0x9736BC", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x6001833")]
		[Address(RVA = "0x975944", Offset = "0x975944", VA = "0x975944", Slot = "8")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x6001834")]
		[Address(RVA = "0x974E04", Offset = "0x974E04", VA = "0x974E04")]
		private void PopulateTreeOfRecipes()
		{
		}

		[Token(Token = "0x6001835")]
		[Address(RVA = "0x9759DC", Offset = "0x9759DC", VA = "0x9759DC", Slot = "10")]
		public void TrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
		{
		}

		[Token(Token = "0x6001836")]
		[Address(RVA = "0x975A7C", Offset = "0x975A7C", VA = "0x975A7C")]
		public void TrackAbilityProgress(string reference, long delta, ItemMinimalDetails itemDetails)
		{
		}

		[Token(Token = "0x6001837")]
		[Address(RVA = "0x9756B4", Offset = "0x9756B4", VA = "0x9756B4")]
		private void PopulateInventoryTags()
		{
		}

		[Token(Token = "0x6001838")]
		[Address(RVA = "0x975D5C", Offset = "0x975D5C", VA = "0x975D5C")]
		public RewardScaleSet GetRewardScaleSet(string reference)
		{
			return null;
		}

		[Token(Token = "0x6001839")]
		[Address(RVA = "0x975DCC", Offset = "0x975DCC", VA = "0x975DCC")]
		public List<ScaleSetEntry> GetScaleSetEntries(List<string> scaleSetEntryRefs)
		{
			return null;
		}

		[Token(Token = "0x600183A")]
		[Address(RVA = "0x975E3C", Offset = "0x975E3C", VA = "0x975E3C")]
		public RepeatingEventSchedule GetRepeatingEventSchedule(string reference)
		{
			return null;
		}

		[Token(Token = "0x600183B")]
		[Address(RVA = "0x975E74", Offset = "0x975E74", VA = "0x975E74")]
		public List<TimeSlot> GetTimeSlots(List<string> timeSlotReferences)
		{
			return null;
		}

		[Token(Token = "0x600183C")]
		[Address(RVA = "0x975EAC", Offset = "0x975EAC", VA = "0x975EAC")]
		public EventSchedule GetEventSchedule(string reference)
		{
			return null;
		}

		[Token(Token = "0x600183D")]
		[Address(RVA = "0x975EE4", Offset = "0x975EE4", VA = "0x975EE4")]
		public GlobalLeaderboard GetGlobalLeaderboard(string reference)
		{
			return null;
		}

		[Token(Token = "0x600183E")]
		[Address(RVA = "0x975F54", Offset = "0x975F54", VA = "0x975F54")]
		public List<GlobalLeaderboard> GetAllGlobalLeaderboards()
		{
			return null;
		}

		[Token(Token = "0x600183F")]
		[Address(RVA = "0x973224", Offset = "0x973224", VA = "0x973224")]
		public RewardGroup GetRewardGroup(string reference)
		{
			return null;
		}

		[Token(Token = "0x6001840")]
		[Address(RVA = "0x96B65C", Offset = "0x96B65C", VA = "0x96B65C")]
		public Upgradable GetUpgradable(string reference)
		{
			return null;
		}

		[Token(Token = "0x6001841")]
		[Address(RVA = "0x975FB4", Offset = "0x975FB4", VA = "0x975FB4")]
		public List<string> GetAllUpgradablesOfType(EBuyType buyType)
		{
			return null;
		}

		[Token(Token = "0x6001842")]
		[Address(RVA = "0x975FE8", Offset = "0x975FE8", VA = "0x975FE8")]
		public bool MiniEventExistsInCache(string reference)
		{
			return default(bool);
		}

		[Token(Token = "0x6001843")]
		[Address(RVA = "0x976064", Offset = "0x976064", VA = "0x976064")]
		public bool SpeedBoosterExistsInCache(string reference)
		{
			return default(bool);
		}

		[Token(Token = "0x6001844")]
		[Address(RVA = "0x9760E0", Offset = "0x9760E0", VA = "0x9760E0")]
		public SpeedBooster GetSpeedBooster(string reference)
		{
			return null;
		}

		[Token(Token = "0x6001845")]
		[Address(RVA = "0x976150", Offset = "0x976150", VA = "0x976150")]
		public List<SpeedBooster> GetAllSpeedBoosters()
		{
			return null;
		}

		[Token(Token = "0x6001846")]
		[Address(RVA = "0x970230", Offset = "0x970230", VA = "0x970230")]
		public List<SpeedBoosterReward> GetSpeedBoosterRewardsFromRefs(List<string> speedBoosterRewardRefs)
		{
			return null;
		}

		[Token(Token = "0x6001847")]
		[Address(RVA = "0x9761B0", Offset = "0x9761B0", VA = "0x9761B0")]
		public int GetNumResearchSlots()
		{
			return default(int);
		}

		[Token(Token = "0x6001848")]
		[Address(RVA = "0x9761DC", Offset = "0x9761DC", VA = "0x9761DC")]
		public List<Recipe> GetAllRecipes()
		{
			return null;
		}

		[Token(Token = "0x6001849")]
		[Address(RVA = "0x97623C", Offset = "0x97623C", VA = "0x97623C")]
		public List<Recipe> GetRecipesWithNoRecipeButQuantity()
		{
			return null;
		}

		[Token(Token = "0x600184A")]
		[Address(RVA = "0x974D94", Offset = "0x974D94", VA = "0x974D94")]
		public Recipe GetRecipe(string reference)
		{
			return null;
		}

		[Token(Token = "0x600184B")]
		[Address(RVA = "0x976268", Offset = "0x976268", VA = "0x976268")]
		public Dictionary<string, Recipe> GetVisiblyUnlockedRecipes()
		{
			return null;
		}

		[Token(Token = "0x600184C")]
		[Address(RVA = "0x97597C", Offset = "0x97597C", VA = "0x97597C")]
		public int RecipesCount()
		{
			return default(int);
		}

		[Token(Token = "0x600184D")]
		[Address(RVA = "0x9762C8", Offset = "0x9762C8", VA = "0x9762C8")]
		public List<AdConfig> GetAllAds()
		{
			return null;
		}

		[Token(Token = "0x600184E")]
		[Address(RVA = "0x976328", Offset = "0x976328", VA = "0x976328")]
		public List<StoreItem> GetAllStoreItems()
		{
			return null;
		}

		[Token(Token = "0x600184F")]
		[Address(RVA = "0x976380", Offset = "0x976380", VA = "0x976380")]
		public StoreItem GetStoreItem(string reference)
		{
			return null;
		}

		[Token(Token = "0x6001850")]
		[Address(RVA = "0x9763E8", Offset = "0x9763E8", VA = "0x9763E8")]
		public List<ItemConverter> GetAllItemConverters()
		{
			return null;
		}

		[Token(Token = "0x6001851")]
		[Address(RVA = "0x976448", Offset = "0x976448", VA = "0x976448")]
		public List<EventQuest> GetAllEventQuests()
		{
			return null;
		}

		[Token(Token = "0x6001852")]
		[Address(RVA = "0x9764A8", Offset = "0x9764A8", VA = "0x9764A8")]
		public List<PrestigeLevelUpRewards> GetAllPrestigeLevelUpRewards()
		{
			return null;
		}

		[Token(Token = "0x6001853")]
		[Address(RVA = "0x976508", Offset = "0x976508", VA = "0x976508")]
		public List<Prestiges> GetAllPrestiges()
		{
			return null;
		}

		[Token(Token = "0x6001854")]
		[Address(RVA = "0x976568", Offset = "0x976568", VA = "0x976568")]
		public List<PrestigePermanentItems> GetAllPrestigePermanentItems()
		{
			return null;
		}

		[Token(Token = "0x6001855")]
		[Address(RVA = "0x9765C8", Offset = "0x9765C8", VA = "0x9765C8")]
		public List<DynamicAds> GetAllDynamicAds()
		{
			return null;
		}

		[Token(Token = "0x6001856")]
		[Address(RVA = "0x976628", Offset = "0x976628", VA = "0x976628")]
		public DynamicAds GetDynamicAd(string reference)
		{
			return null;
		}

		[Token(Token = "0x6001857")]
		[Address(RVA = "0x976698", Offset = "0x976698", VA = "0x976698")]
		public List<Credits> GetAllCredits()
		{
			return null;
		}

		[Token(Token = "0x6001858")]
		[Address(RVA = "0x9766F8", Offset = "0x9766F8", VA = "0x9766F8")]
		public Credits GetCredits(string reference)
		{
			return null;
		}

		[Token(Token = "0x6001859")]
		[Address(RVA = "0x976768", Offset = "0x976768", VA = "0x976768")]
		public List<MiniEvent> GetAllMiniEvent()
		{
			return null;
		}

		[Token(Token = "0x600185A")]
		[Address(RVA = "0x9767C8", Offset = "0x9767C8", VA = "0x9767C8")]
		public MiniEvent GetMiniEvent(string reference)
		{
			return null;
		}

		[Token(Token = "0x600185B")]
		[Address(RVA = "0x976838", Offset = "0x976838", VA = "0x976838")]
		public List<LTOGroups> GetAllLTOGroups()
		{
			return null;
		}

		[Token(Token = "0x600185C")]
		[Address(RVA = "0x976898", Offset = "0x976898", VA = "0x976898")]
		public LTOGroups GetLTOGroups(string reference)
		{
			return null;
		}

		[Token(Token = "0x600185D")]
		[Address(RVA = "0x976908", Offset = "0x976908", VA = "0x976908")]
		public List<AutoConversion> GetAllAutoConversion()
		{
			return null;
		}

		[Token(Token = "0x600185E")]
		[Address(RVA = "0x976968", Offset = "0x976968", VA = "0x976968")]
		public AutoConversion GetAutoConversion(string reference)
		{
			return null;
		}

		[Token(Token = "0x600185F")]
		[Address(RVA = "0x9769D8", Offset = "0x9769D8", VA = "0x9769D8")]
		public List<VIPStatus> GetAllVIPStatus()
		{
			return null;
		}

		[Token(Token = "0x6001860")]
		[Address(RVA = "0x976A38", Offset = "0x976A38", VA = "0x976A38")]
		public VIPStatus GetVIPStatus(string reference)
		{
			return null;
		}

		[Token(Token = "0x6001861")]
		[Address(RVA = "0x976AA8", Offset = "0x976AA8", VA = "0x976AA8")]
		public List<GlobalScaler> GetAllGlobalScaler()
		{
			return null;
		}

		[Token(Token = "0x6001862")]
		[Address(RVA = "0x976B08", Offset = "0x976B08", VA = "0x976B08")]
		public GlobalScaler GetGlobalScaler(string reference)
		{
			return null;
		}

		[Token(Token = "0x6001863")]
		[Address(RVA = "0x976B78", Offset = "0x976B78", VA = "0x976B78")]
		public ItemConverter GetItemConverter(string reference)
		{
			return null;
		}

		[Token(Token = "0x6001864")]
		[Address(RVA = "0x976BE8", Offset = "0x976BE8", VA = "0x976BE8")]
		public Dictionary<string, ItemConverter> GetVisiblyUnlockedItemConverters()
		{
			return null;
		}

		[Token(Token = "0x6001865")]
		[Address(RVA = "0x976C48", Offset = "0x976C48", VA = "0x976C48")]
		public Tab GetTab(string reference)
		{
			return null;
		}

		[Token(Token = "0x6001866")]
		[Address(RVA = "0x976CB8", Offset = "0x976CB8", VA = "0x976CB8")]
		public SubTab GetSubTab(string reference)
		{
			return null;
		}

		[Token(Token = "0x6001867")]
		[Address(RVA = "0x976D28", Offset = "0x976D28", VA = "0x976D28")]
		public int GetLoadoutSlotCount()
		{
			return default(int);
		}

		[Token(Token = "0x6001868")]
		[Address(RVA = "0x976D54", Offset = "0x976D54", VA = "0x976D54")]
		public int GetEquipmentSlotCount()
		{
			return default(int);
		}

		[Token(Token = "0x6001869")]
		[Address(RVA = "0x976D80", Offset = "0x976D80", VA = "0x976D80")]
		public double GetGlobalPrestigeSpeedBoost()
		{
			return default(double);
		}

		[Token(Token = "0x600186A")]
		[Address(RVA = "0x975444", Offset = "0x975444", VA = "0x975444")]
		public Dictionary<string, IStatusEffect> GetAllStatusEffects()
		{
			return null;
		}

		[Token(Token = "0x600186B")]
		[Address(RVA = "0x9755C0", Offset = "0x9755C0", VA = "0x9755C0")]
		public Dictionary<string, IAbilityEffect> GetAllAbilityEffects()
		{
			return null;
		}

		[Token(Token = "0x600186C")]
		[Address(RVA = "0x976DAC", Offset = "0x976DAC", VA = "0x976DAC")]
		public List<Tag> GetOwnedTagsForInventorySubTab()
		{
			return null;
		}

		[Token(Token = "0x600186D")]
		[Address(RVA = "0x976FA4", Offset = "0x976FA4", VA = "0x976FA4")]
		public bool ContainsInventoryTag(IEnumerable<string> tagRefs)
		{
			return default(bool);
		}

		[Token(Token = "0x600186E")]
		[Address(RVA = "0x9772B0", Offset = "0x9772B0", VA = "0x9772B0")]
		public void SetRecipeResearchLocked(string recipeRef)
		{
		}

		[Token(Token = "0x600186F")]
		[Address(RVA = "0x977320", Offset = "0x977320", VA = "0x977320")]
		public void SetItemConverterResearchLocked(string itemConverterRef)
		{
		}

		[Token(Token = "0x6001870")]
		[Address(RVA = "0x977390", Offset = "0x977390", VA = "0x977390")]
		public void RemoveItemConverterFromCacheHack(string key)
		{
		}
	}
}
