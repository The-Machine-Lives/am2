using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200033A")]
	public class ActionSceneRuntimeDataCache<T, U> : RuntimeItemModelDataCache<T, U> where T : ActionScene<U>, new()where U : RDActionScene
	{
		[Token(Token = "0x4000FE4")]
		[FieldOffset(Offset = "0x0")]
		protected Localizations m_localizationController;

		[Token(Token = "0x4000FE5")]
		[FieldOffset(Offset = "0x0")]
		protected RewardGroupsController m_rewardGroupsCountroller;

		[Token(Token = "0x4000FE6")]
		[FieldOffset(Offset = "0x0")]
		protected new InventoryController m_inventoryController;

		[Token(Token = "0x4000FE7")]
		[FieldOffset(Offset = "0x0")]
		protected Dictionary<string, IAbilityEffect> m_allAbilityEffects;

		[Token(Token = "0x60019EE")]
		public ActionSceneRuntimeDataCache(DepotEntity<U> depot, Localizations localizationController, RewardGroupsController rewardGroupsCountroller, InventoryController inventoryController, Dictionary<string, IAbilityEffect> allAbilityEffects)
		{
		}

		[Token(Token = "0x60019EF")]
		protected override T CreateRuntimeData(string reference, U refDataDocument)
		{
			return null;
		}
	}
}
