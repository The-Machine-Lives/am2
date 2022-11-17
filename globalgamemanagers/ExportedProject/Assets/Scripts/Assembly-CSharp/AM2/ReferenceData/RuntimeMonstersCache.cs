using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200032E")]
	public class RuntimeMonstersCache : RuntimeItemModelDataCache<Monster, RDMonster>
	{
		[Token(Token = "0x4000FBD")]
		[FieldOffset(Offset = "0x48")]
		private RuntimeDataCache<Tag, RDTag> m_tagsCache;

		[Token(Token = "0x4000FBE")]
		[FieldOffset(Offset = "0x50")]
		private RuntimeDataCache<RewardGroup, RDRewardGroup> m_rewardGroupsCache;

		[Token(Token = "0x4000FBF")]
		[FieldOffset(Offset = "0x58")]
		private RuntimeDataCache<AbilityGroup, RDAbilityGroup> m_abilityGroupsCache;

		[Token(Token = "0x4000FC0")]
		[FieldOffset(Offset = "0x60")]
		private RuntimeDataCache<Buff, RDBuff> m_buffsCache;

		[Token(Token = "0x4000FC1")]
		[FieldOffset(Offset = "0x68")]
		private RuntimeDataCache<HealthType, RDHealthType> m_healthTypesCache;

		[Token(Token = "0x60019A9")]
		[Address(RVA = "0x96CB48", Offset = "0x96CB48", VA = "0x96CB48")]
		public RuntimeMonstersCache(DepotEntity<RDMonster> depot, RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache, RuntimeDataCache<AbilityGroup, RDAbilityGroup> abilityGroupsCache, RuntimeDataCache<Buff, RDBuff> buffsCache, RuntimeDataCache<HealthType, RDHealthType> healthTypesCache)
		{
		}

		[Token(Token = "0x60019AA")]
		[Address(RVA = "0x96CBE0", Offset = "0x96CBE0", VA = "0x96CBE0", Slot = "5")]
		protected override Monster CreateRuntimeData(string reference, RDMonster refDataDocument)
		{
			return null;
		}
	}
}
