using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200038B")]
	public class RuntimePrestigesCache : RuntimeItemModelDataCache<Prestiges, RDPrestiges>
	{
		[Token(Token = "0x400114C")]
		[FieldOffset(Offset = "0x48")]
		private RuntimeDataCache<Upgradable, RDUpgradable> m_upgradableItemCache;

		[Token(Token = "0x6001BDD")]
		[Address(RVA = "0x96CE90", Offset = "0x96CE90", VA = "0x96CE90")]
		public RuntimePrestigesCache(DepotEntity<RDPrestiges> depot, RuntimeDataCache<Upgradable, RDUpgradable> upgradableItemCache)
		{
		}

		[Token(Token = "0x6001BDE")]
		[Address(RVA = "0x96CF08", Offset = "0x96CF08", VA = "0x96CF08", Slot = "5")]
		protected override Prestiges CreateRuntimeData(string reference, RDPrestiges refDataDocument)
		{
			return null;
		}
	}
}
