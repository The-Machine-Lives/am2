using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200054B")]
	public class RuntimeStoreItemCache : RuntimeItemModelDataCache<StoreItem, RDStoreItem>
	{
		[Token(Token = "0x4001941")]
		[FieldOffset(Offset = "0x48")]
		private RuntimeDataCache<RewardGroup, RDRewardGroup> m_rewardGroups;

		[Token(Token = "0x600289D")]
		[Address(RVA = "0xA8CBA8", Offset = "0xA8CBA8", VA = "0xA8CBA8")]
		public RuntimeStoreItemCache(DepotEntity<RDStoreItem> depot, RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache)
		{
		}

		[Token(Token = "0x600289E")]
		[Address(RVA = "0xA8CC20", Offset = "0xA8CC20", VA = "0xA8CC20", Slot = "5")]
		protected override StoreItem CreateRuntimeData(string reference, RDStoreItem refDataDocument)
		{
			return null;
		}
	}
}
