using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000353")]
	public class RuntimeCostResourceCache : RuntimeDataCache<CostResource, RDCostResource>
	{
		[Token(Token = "0x4001018")]
		[FieldOffset(Offset = "0x38")]
		private RuntimeDataCache<Formula, RDFormula> m_formulas;

		[Token(Token = "0x6001A40")]
		[Address(RVA = "0x96C5B4", Offset = "0x96C5B4", VA = "0x96C5B4")]
		public RuntimeCostResourceCache(DepotEntity<RDCostResource> depot, RuntimeDataCache<Formula, RDFormula> formulas)
		{
		}

		[Token(Token = "0x6001A41")]
		[Address(RVA = "0x96C620", Offset = "0x96C620", VA = "0x96C620", Slot = "5")]
		protected override CostResource CreateRuntimeData(string reference, RDCostResource refDataDocument)
		{
			return null;
		}
	}
}
