using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000385")]
	public class RuntimePrestigeLevelUpRewardsCache : RuntimeDataCache<PrestigeLevelUpRewards, RDPrestigeLevelUpRewards>
	{
		[Token(Token = "0x400112F")]
		[FieldOffset(Offset = "0x38")]
		private RuntimeDataCache<RewardGroup, RDRewardGroup> m_rewardGroupsCache;

		[Token(Token = "0x6001BB9")]
		[Address(RVA = "0x96CC88", Offset = "0x96CC88", VA = "0x96CC88")]
		public RuntimePrestigeLevelUpRewardsCache(DepotEntity<RDPrestigeLevelUpRewards> depot, RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache)
		{
		}

		[Token(Token = "0x6001BBA")]
		[Address(RVA = "0x96CCF4", Offset = "0x96CCF4", VA = "0x96CCF4", Slot = "5")]
		protected override PrestigeLevelUpRewards CreateRuntimeData(string reference, RDPrestigeLevelUpRewards refDataDocument)
		{
			return null;
		}
	}
}
