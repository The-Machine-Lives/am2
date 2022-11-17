using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000388")]
	public class RuntimePrestigePermanentItemsCache : RuntimeDataCache<PrestigePermanentItems, RDPrestigePermanentItems>
	{
		[Token(Token = "0x4001147")]
		[FieldOffset(Offset = "0x38")]
		private RuntimeDataCache<Prestiges, RDPrestiges> m_prestigesCache;

		[Token(Token = "0x4001148")]
		[FieldOffset(Offset = "0x40")]
		private RuntimeDataCache<EventQuest, RDEventQuest> m_eventQuestCache;

		[Token(Token = "0x6001BD2")]
		[Address(RVA = "0x96CD84", Offset = "0x96CD84", VA = "0x96CD84")]
		public RuntimePrestigePermanentItemsCache(DepotEntity<RDPrestigePermanentItems> depot, RuntimeDataCache<Prestiges, RDPrestiges> prestigesCache, RuntimeDataCache<EventQuest, RDEventQuest> eventQuestCache)
		{
		}

		[Token(Token = "0x6001BD3")]
		[Address(RVA = "0x96CDFC", Offset = "0x96CDFC", VA = "0x96CDFC", Slot = "5")]
		protected override PrestigePermanentItems CreateRuntimeData(string reference, RDPrestigePermanentItems refDataDocument)
		{
			return null;
		}
	}
}
