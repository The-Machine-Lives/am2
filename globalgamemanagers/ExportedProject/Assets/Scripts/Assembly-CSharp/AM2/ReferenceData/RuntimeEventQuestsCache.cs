using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200039C")]
	public class RuntimeEventQuestsCache : RuntimeItemModelDataCache<EventQuest, RDEventQuest>, IItemModelIndexer
	{
		[Token(Token = "0x4001173")]
		[FieldOffset(Offset = "0x48")]
		private RuntimeDataCache<Quest, RDQuest> m_questsCache;

		[Token(Token = "0x6001C33")]
		[Address(RVA = "0x96C7AC", Offset = "0x96C7AC", VA = "0x96C7AC")]
		public RuntimeEventQuestsCache(DepotEntity<RDEventQuest> depot, RuntimeDataCache<Quest, RDQuest> questCache)
		{
		}

		[Token(Token = "0x6001C34")]
		[Address(RVA = "0x96C824", Offset = "0x96C824", VA = "0x96C824", Slot = "5")]
		protected override EventQuest CreateRuntimeData(string reference, RDEventQuest refDataDocument)
		{
			return null;
		}
	}
}
