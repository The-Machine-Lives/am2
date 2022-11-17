using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000363")]
	public class RuntimeRecipesCache : RuntimeResearchableDataCache<Recipe, RDRecipe, RecipeItem>
	{
		[Token(Token = "0x400109A")]
		[FieldOffset(Offset = "0x78")]
		protected RuntimeDataCache<Regent, RDRegent> m_regents;

		[Token(Token = "0x400109B")]
		[FieldOffset(Offset = "0x80")]
		protected RuntimeDataCache<SubTab, RDSubTab> m_subTabs;

		[Token(Token = "0x400109C")]
		[FieldOffset(Offset = "0x88")]
		protected RuntimeDataCache<Section, RDSection> m_sections;

		[Token(Token = "0x400109D")]
		[FieldOffset(Offset = "0x90")]
		protected RuntimeDataCache<Upgradable, RDUpgradable> m_upgradables;

		[Token(Token = "0x400109E")]
		[FieldOffset(Offset = "0x98")]
		private HashSet<string> m_itemRefsWithNoRecipeButQuantity;

		[Token(Token = "0x400109F")]
		[FieldOffset(Offset = "0xA0")]
		private List<Recipe> m_cachedRecipesWithNoRecipeButQuantity;

		[Token(Token = "0x40010A0")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_itemRefsWithNoRecipeButQuantityDirty;

		[Token(Token = "0x6001AE0")]
		[Address(RVA = "0x96D104", Offset = "0x96D104", VA = "0x96D104")]
		public RuntimeRecipesCache(DepotEntity<RDRecipe> depot, RuntimeDataCache<Regent, RDRegent> regents, RuntimeDataCache<SubTab, RDSubTab> subTab, RuntimeDataCache<Upgradable, RDUpgradable> upgradables, RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache, RuntimeDataCache<Section, RDSection> sectionCache, RuntimeCostResourceCache costResourceCache)
		{
		}

		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x96D230", Offset = "0x96D230", VA = "0x96D230", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6001AE2")]
		[Address(RVA = "0x96D518", Offset = "0x96D518", VA = "0x96D518")]
		public void Cleanup()
		{
		}

		[Token(Token = "0x6001AE3")]
		[Address(RVA = "0x96D66C", Offset = "0x96D66C", VA = "0x96D66C")]
		public List<Recipe> GetRecipesWithNoRecipeButQuantity()
		{
			return null;
		}

		[Token(Token = "0x6001AE4")]
		[Address(RVA = "0x96D810", Offset = "0x96D810", VA = "0x96D810")]
		protected void TryAddToItemsWithNoRecipeButQuantity(string constructionItemReference)
		{
		}

		[Token(Token = "0x6001AE5")]
		[Address(RVA = "0x96D8C8", Offset = "0x96D8C8", VA = "0x96D8C8")]
		protected void RemoveFromItemsWithNoRecipeButQuantity(string constructionItemReference)
		{
		}

		[Token(Token = "0x6001AE6")]
		[Address(RVA = "0x96D948", Offset = "0x96D948", VA = "0x96D948", Slot = "10")]
		public override void OnTrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
		{
		}

		[Token(Token = "0x6001AE7")]
		[Address(RVA = "0x96DB2C", Offset = "0x96DB2C", VA = "0x96DB2C", Slot = "5")]
		protected override Recipe CreateRuntimeData(string reference, RDRecipe refDataDocument)
		{
			return null;
		}

		[Token(Token = "0x6001AE8")]
		[Address(RVA = "0x96DC7C", Offset = "0x96DC7C", VA = "0x96DC7C", Slot = "7")]
		public override Dictionary<string, ItemMinimalDetails> GetAllItemDetails()
		{
			return null;
		}
	}
}
