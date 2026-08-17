using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000342")]
	public class RuntimeFightScenesCache : ActionSceneRuntimeDataCache<FightScene, RDFightScene>
	{
		[Token(Token = "0x4000FF4")]
		[FieldOffset(Offset = "0x68")]
		private RuntimeDataCache<Monster, RDMonster> m_monstersCache;

		[Token(Token = "0x6001A07")]
		[Address(RVA = "0x96C8B4", Offset = "0x96C8B4", VA = "0x96C8B4")]
		public RuntimeFightScenesCache(DepotEntity<RDFightScene> depot, Localizations localizationController, RewardGroupsController rewardGroupsCountroller, RuntimeDataCache<Monster, RDMonster> monstersCache, InventoryController inventoryController, Dictionary<string, IAbilityEffect> allAbilityEffects)
		{
		}

		[Token(Token = "0x6001A08")]
		[Address(RVA = "0x96C950", Offset = "0x96C950", VA = "0x96C950", Slot = "5")]
		protected override FightScene CreateRuntimeData(string reference, RDFightScene refDataDocument)
		{
			return null;
		}
	}
}
