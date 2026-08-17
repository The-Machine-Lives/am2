using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000359")]
	public class FormulaDataCache : RuntimeDataCache<Formula, RDFormula>
	{
		[Token(Token = "0x6001A7B")]
		[Address(RVA = "0x9B414C", Offset = "0x9B414C", VA = "0x9B414C")]
		public FormulaDataCache(DepotEntity<RDFormula> depot)
		{
		}

		[Token(Token = "0x6001A7C")]
		[Address(RVA = "0x9B41AC", Offset = "0x9B41AC", VA = "0x9B41AC", Slot = "4")]
		public override void Initialize()
		{
		}
	}
}
