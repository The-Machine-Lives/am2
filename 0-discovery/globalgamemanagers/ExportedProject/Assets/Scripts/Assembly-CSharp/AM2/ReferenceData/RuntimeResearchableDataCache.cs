using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200036A")]
	public class RuntimeResearchableDataCache<T, U, V> : RuntimeVisiblyUnlockableDataCache<T, U, V> where T : ResearchableRuntimeData<U, V>, new()where U : RDResearchable where V : ResearchableUnlockableItem, new()
	{
		[Token(Token = "0x40010CA")]
		[FieldOffset(Offset = "0x0")]
		protected RuntimeDataCache<RewardGroup, RDRewardGroup> m_rewardGroupsCache;

		[Token(Token = "0x40010CB")]
		[FieldOffset(Offset = "0x0")]
		protected RuntimeDataCache<SubTab, RDSubTab> m_subTabCache;

		[Token(Token = "0x40010CC")]
		[FieldOffset(Offset = "0x0")]
		protected RuntimeDataCache<Section, RDSection> m_sectionCache;

		[Token(Token = "0x40010CD")]
		[FieldOffset(Offset = "0x0")]
		protected RuntimeCostResourceCache m_costResourceCache;

		[Token(Token = "0x6001B2C")]
		public RuntimeResearchableDataCache(DepotEntity<U> depot, string inItemType, string inUnlockableItemType, RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache, RuntimeDataCache<SubTab, RDSubTab> subTabCache, RuntimeDataCache<Section, RDSection> sectionCache, RuntimeCostResourceCache costResourceCache)
		{
		}

		[Token(Token = "0x6001B2D")]
		protected override string GetReadableResearchNameForItem(T runtimeData)
		{
			return null;
		}

		[Token(Token = "0x6001B2E")]
		protected override T CreateRuntimeData(string reference, U refDataDocument)
		{
			return null;
		}

		[Token(Token = "0x6001B2F")]
		public override void OnTrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
		{
		}
	}
}
