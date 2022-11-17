using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200033F")]
	public class RuntimeChoiceScenesCache : ActionSceneRuntimeDataCache<ChoiceScene, RDChoiceScene>
	{
		[Token(Token = "0x60019FE")]
		[Address(RVA = "0x96C494", Offset = "0x96C494", VA = "0x96C494")]
		public RuntimeChoiceScenesCache(DepotEntity<RDChoiceScene> depot, Dictionary<string, IAbilityEffect> allAbilityEffects, Localizations localizationController, RewardGroupsController rewardGroupsCountroller, InventoryController inventoryController)
		{
		}

		[Token(Token = "0x60019FF")]
		[Address(RVA = "0x96C524", Offset = "0x96C524", VA = "0x96C524", Slot = "5")]
		protected override ChoiceScene CreateRuntimeData(string reference, RDChoiceScene refDataDocument)
		{
			return null;
		}
	}
}
