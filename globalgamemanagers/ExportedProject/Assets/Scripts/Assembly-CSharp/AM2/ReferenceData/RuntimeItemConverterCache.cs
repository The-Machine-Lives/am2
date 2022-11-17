using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200035C")]
	public class RuntimeItemConverterCache : RuntimeResearchableDataCache<ItemConverter, RDItemConverter, ItemConverterItem>
	{
		[Token(Token = "0x4001064")]
		[FieldOffset(Offset = "0x78")]
		private RuntimeDataCache<Formula, RDFormula> m_formulas;

		[Token(Token = "0x6001A8C")]
		[Address(RVA = "0x96C9E4", Offset = "0x96C9E4", VA = "0x96C9E4")]
		public RuntimeItemConverterCache(DepotEntity<RDItemConverter> depot, RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache, RuntimeDataCache<SubTab, RDSubTab> subTab, RuntimeDataCache<Section, RDSection> sectionCache, RuntimeDataCache<Formula, RDFormula> formulas, RuntimeCostResourceCache costResourceCache)
		{
		}

		[Token(Token = "0x6001A8D")]
		[Address(RVA = "0x96CA9C", Offset = "0x96CA9C", VA = "0x96CA9C", Slot = "5")]
		protected override ItemConverter CreateRuntimeData(string reference, RDItemConverter refDataDocument)
		{
			return null;
		}
	}
}
