using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004A6")]
	public class ConstructionController : UkenController
	{
		[Token(Token = "0x400156E")]
		public const string c_powerResourceName = "power";

		[Token(Token = "0x400156F")]
		public const string c_powerRecipeResourceName = "power_recipe";

		[Token(Token = "0x4001570")]
		public const string c_researchSlotName = "research_slot_";

		[Token(Token = "0x4001571")]
		private const int c_TEMP_MAX_POSSIBLE_RESEARCH_SLOTS = 10;

		[Token(Token = "0x4001572")]
		private const string dustingEventName = "dusting";

		[Token(Token = "0x4001573")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EAAC", Offset = "0x82EAAC")]
		private RecipeItem _003CpowerRecipeItem_003Ek__BackingField;

		[Token(Token = "0x4001574")]
		[FieldOffset(Offset = "0x20")]
		private UkenTimeController m_time;

		[Token(Token = "0x4001575")]
		[FieldOffset(Offset = "0x28")]
		private bool m_activeRecipesDirty;

		[Token(Token = "0x4001576")]
		[FieldOffset(Offset = "0x30")]
		private List<Recipe> m_cachedActiveRecipesInOrder;

		[Token(Token = "0x4001577")]
		[FieldOffset(Offset = "0x38")]
		private bool m_ownedItemConvertersDirty;

		[Token(Token = "0x4001578")]
		[FieldOffset(Offset = "0x40")]
		private List<ItemConverter> m_cachedOwnedItemConverters;

		[Token(Token = "0x4001579")]
		[FieldOffset(Offset = "0x48")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x400157A")]
		[FieldOffset(Offset = "0x50")]
		private Localizations m_localizationController;

		[Token(Token = "0x400157B")]
		[FieldOffset(Offset = "0x58")]
		private ZoneController m_zoneController;

		[Token(Token = "0x400157C")]
		[FieldOffset(Offset = "0x60")]
		private FTUEController m_ftueController;

		[Token(Token = "0x400157D")]
		[FieldOffset(Offset = "0x68")]
		private RewardGroupsController m_rewardGroupsController;

		[Token(Token = "0x400157E")]
		[FieldOffset(Offset = "0x70")]
		private AM2InventoryController m_inventoryController;

		[Token(Token = "0x400157F")]
		[FieldOffset(Offset = "0x78")]
		private UIAlertController m_uiAlertController;

		[Token(Token = "0x170005E9")]
		public ResearchSystem researchSystem
		{
			[Token(Token = "0x6002251")]
			[Address(RVA = "0xA57C6C", Offset = "0xA57C6C", VA = "0xA57C6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005EA")]
		public Power power
		{
			[Token(Token = "0x6002252")]
			[Address(RVA = "0xA57C9C", Offset = "0xA57C9C", VA = "0xA57C9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005EB")]
		public Recipe powerRecipe
		{
			[Token(Token = "0x6002253")]
			[Address(RVA = "0xA57CCC", Offset = "0xA57CCC", VA = "0xA57CCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005EC")]
		public RecipeItem powerRecipeItem
		{
			[Token(Token = "0x6002254")]
			[Address(RVA = "0xA57CFC", Offset = "0xA57CFC", VA = "0xA57CFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8395B4", Offset = "0x8395B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002255")]
			[Address(RVA = "0xA57D04", Offset = "0xA57D04", VA = "0xA57D04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8395C4", Offset = "0x8395C4")]
			private set
			{
			}
		}

		[Token(Token = "0x170005ED")]
		public Upgradable maxRateUpgradable
		{
			[Token(Token = "0x6002256")]
			[Address(RVA = "0xA57D0C", Offset = "0xA57D0C", VA = "0xA57D0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005EE")]
		public Upgradable researchSlotsUpgradable
		{
			[Token(Token = "0x6002257")]
			[Address(RVA = "0xA57D3C", Offset = "0xA57D3C", VA = "0xA57D3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005EF")]
		public Upgradable loadoutSlotsUpgradable
		{
			[Token(Token = "0x6002258")]
			[Address(RVA = "0xA57D6C", Offset = "0xA57D6C", VA = "0xA57D6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005F0")]
		public Upgradable equipmentSlotsUpgradable
		{
			[Token(Token = "0x6002259")]
			[Address(RVA = "0xA57D9C", Offset = "0xA57D9C", VA = "0xA57D9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005F1")]
		public Upgradable globalSpeedBoostUpgradable
		{
			[Token(Token = "0x600225A")]
			[Address(RVA = "0xA57DCC", Offset = "0xA57DCC", VA = "0xA57DCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005F2")]
		public double powerDecayTime
		{
			[Token(Token = "0x600225B")]
			[Address(RVA = "0xA57DFC", Offset = "0xA57DFC", VA = "0xA57DFC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170005F3")]
		public double powerGrowthRate
		{
			[Token(Token = "0x600225C")]
			[Address(RVA = "0xA57ECC", Offset = "0xA57ECC", VA = "0xA57ECC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x600225D")]
		[Address(RVA = "0xA57FF8", Offset = "0xA57FF8", VA = "0xA57FF8")]
		public ConstructionController(SharedDataCacheController dataCacheController, AM2InventoryController inventoryController, ZoneController zoneController, Localizations localizationController, FTUEController ftueController, RewardGroupsController rewardGroupsController, UkenTimeController time, UIAlertController uiAlertController)
		{
		}

		[Token(Token = "0x600225E")]
		[Address(RVA = "0xA58100", Offset = "0xA58100", VA = "0xA58100", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x600225F")]
		[Address(RVA = "0xA58374", Offset = "0xA58374", VA = "0xA58374", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6002260")]
		[Address(RVA = "0xA58CE8", Offset = "0xA58CE8", VA = "0xA58CE8")]
		public bool CanDust(IDustable dustableItem)
		{
			return default(bool);
		}

		[Token(Token = "0x6002261")]
		[Address(RVA = "0xA58DF4", Offset = "0xA58DF4", VA = "0xA58DF4")]
		public List<Recipe> GetAllRecipes()
		{
			return null;
		}

		[Token(Token = "0x6002262")]
		[Address(RVA = "0xA58E24", Offset = "0xA58E24", VA = "0xA58E24")]
		public bool CanAffordToProduce(IResearchable researchable)
		{
			return default(bool);
		}

		[Token(Token = "0x6002263")]
		[Address(RVA = "0xA58F68", Offset = "0xA58F68", VA = "0xA58F68")]
		public bool CanAffordToProduce(Dictionary<string, long> costResources, Dictionary<string, long> levelGates)
		{
			return default(bool);
		}

		[Token(Token = "0x6002264")]
		[Address(RVA = "0xA59280", Offset = "0xA59280", VA = "0xA59280")]
		public List<IResearchable> GetAllResearchablesOfType(EBuyType buyType)
		{
			return null;
		}

		[Token(Token = "0x6002265")]
		[Address(RVA = "0xA59E94", Offset = "0xA59E94", VA = "0xA59E94")]
		public void RemoveResearch(string itemRef)
		{
		}

		[Token(Token = "0x6002266")]
		[Address(RVA = "0xA5A0A4", Offset = "0xA5A0A4", VA = "0xA5A0A4")]
		public bool DustEquipmentStyleItem(IDustable dusableItem)
		{
			return default(bool);
		}

		[Token(Token = "0x6002267")]
		[Address(RVA = "0xA5A330", Offset = "0xA5A330", VA = "0xA5A330")]
		public bool DustUkenStyleItem(IDustable dusableItem, long count)
		{
			return default(bool);
		}

		[Token(Token = "0x6002268")]
		[Address(RVA = "0xA59CD4", Offset = "0xA59CD4", VA = "0xA59CD4")]
		private void TryAddResearchToList(EBuyType buyType, IResearchable researchable, List<IResearchable> allResearchables)
		{
		}

		[Token(Token = "0x6002269")]
		[Address(RVA = "0xA5A658", Offset = "0xA5A658", VA = "0xA5A658")]
		public void SetActiveRecipesDirty()
		{
		}

		[Token(Token = "0x600226A")]
		[Address(RVA = "0xA5A664", Offset = "0xA5A664", VA = "0xA5A664")]
		public void SetOwnedItemConvertersDirty()
		{
		}

		[Token(Token = "0x600226B")]
		[Address(RVA = "0xA5A670", Offset = "0xA5A670", VA = "0xA5A670")]
		public void SetRatePerSecond(ResearchSlotItem researchSlotItem, long rate)
		{
		}

		[Token(Token = "0x600226C")]
		[Address(RVA = "0xA5A6A8", Offset = "0xA5A6A8", VA = "0xA5A6A8")]
		public ConstructionItem GetPowerConstructionItem()
		{
			return null;
		}

		[Token(Token = "0x600226D")]
		[Address(RVA = "0xA5A714", Offset = "0xA5A714", VA = "0xA5A714")]
		public List<Tag> GetOwnedTagsForInventorySubTab()
		{
			return null;
		}

		[Token(Token = "0x600226E")]
		[Address(RVA = "0xA5A744", Offset = "0xA5A744", VA = "0xA5A744")]
		public bool ContainsInventoryTag(IEnumerable<string> tagRefs)
		{
			return default(bool);
		}

		[Token(Token = "0x600226F")]
		[Address(RVA = "0xA5A77C", Offset = "0xA5A77C", VA = "0xA5A77C")]
		public List<Recipe> GetRecipesWithNoRecipeButQuantity()
		{
			return null;
		}

		[Token(Token = "0x6002270")]
		[Address(RVA = "0xA58920", Offset = "0xA58920", VA = "0xA58920")]
		public List<Recipe> GetAllActiveRecipesInOrder()
		{
			return null;
		}

		[Token(Token = "0x6002271")]
		[Address(RVA = "0xA5A7AC", Offset = "0xA5A7AC", VA = "0xA5A7AC")]
		private SortedList<sbyte, List<Recipe>> GroupOwnedRecipesByPriority(List<Recipe> recipes)
		{
			return null;
		}

		[Token(Token = "0x6002272")]
		[Address(RVA = "0xA58B50", Offset = "0xA58B50", VA = "0xA58B50")]
		public List<ItemConverter> GetAllOwnedItemConverters()
		{
			return null;
		}

		[Token(Token = "0x6002273")]
		[Address(RVA = "0xA5AA20", Offset = "0xA5AA20", VA = "0xA5AA20")]
		public int GetNumResearchSlots()
		{
			return default(int);
		}

		[Token(Token = "0x6002274")]
		[Address(RVA = "0xA5AA50", Offset = "0xA5AA50", VA = "0xA5AA50")]
		public IResearchable GetResearchable(ResearchSlotItem researchSlotItem)
		{
			return null;
		}

		[Token(Token = "0x6002275")]
		[Address(RVA = "0xA5AC20", Offset = "0xA5AC20", VA = "0xA5AC20")]
		public Recipe GetRecipe(string reference)
		{
			return null;
		}

		[Token(Token = "0x6002276")]
		[Address(RVA = "0xA5AC60", Offset = "0xA5AC60", VA = "0xA5AC60")]
		public Tag GetTag(string reference)
		{
			return null;
		}

		[Token(Token = "0x6002277")]
		[Address(RVA = "0xA5ACE8", Offset = "0xA5ACE8", VA = "0xA5ACE8")]
		public Tab GetTab(string reference)
		{
			return null;
		}

		[Token(Token = "0x6002278")]
		[Address(RVA = "0xA5AD20", Offset = "0xA5AD20", VA = "0xA5AD20")]
		public SubTab GetSubTab(string reference)
		{
			return null;
		}
	}
}
