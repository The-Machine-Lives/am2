using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004E2")]
	public class RuntimeAdsCache : RuntimeItemModelDataCache<AdConfig, RDAdConfig>
	{
		[Token(Token = "0x4001719")]
		[FieldOffset(Offset = "0x48")]
		private RuntimeDataCache<Formula, RDFormula> m_formulas;

		[Token(Token = "0x400171A")]
		[FieldOffset(Offset = "0x50")]
		private RuntimeDataCache<RewardGroup, RDRewardGroup> m_rewardGroups;

		[Token(Token = "0x60025AE")]
		[Address(RVA = "0xA8C708", Offset = "0xA8C708", VA = "0xA8C708")]
		public RuntimeAdsCache(DepotEntity<RDAdConfig> depot, RuntimeDataCache<Formula, RDFormula> formulas, RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache)
		{
		}

		[Token(Token = "0x60025AF")]
		[Address(RVA = "0xA8C78C", Offset = "0xA8C78C", VA = "0xA8C78C", Slot = "5")]
		protected override AdConfig CreateRuntimeData(string reference, RDAdConfig refDataDocument)
		{
			return null;
		}
	}
}
