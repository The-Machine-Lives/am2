using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000324")]
	public class RuntimeAbilityGroupsCache : RuntimeDataCache<AbilityGroup, RDAbilityGroup>
	{
		[Token(Token = "0x4000F9E")]
		[FieldOffset(Offset = "0x38")]
		private RuntimeDataCache<Ability, RDAbility> m_abilitiesCache;

		[Token(Token = "0x600197F")]
		[Address(RVA = "0x96C29C", Offset = "0x96C29C", VA = "0x96C29C")]
		public RuntimeAbilityGroupsCache(DepotEntity<RDAbilityGroup> depot, RuntimeDataCache<Ability, RDAbility> abilitiesCache)
		{
		}

		[Token(Token = "0x6001980")]
		[Address(RVA = "0x96C308", Offset = "0x96C308", VA = "0x96C308", Slot = "5")]
		protected override AbilityGroup CreateRuntimeData(string reference, RDAbilityGroup refDataDocument)
		{
			return null;
		}
	}
}
