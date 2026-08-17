using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003A4")]
	public class RuntimeTasksCache : RuntimeDataCache<Task, RDTask>
	{
		[Token(Token = "0x400118E")]
		[FieldOffset(Offset = "0x38")]
		private RuntimeDataCache<Formula, RDFormula> m_formulaCache;

		[Token(Token = "0x6001C5E")]
		[Address(RVA = "0x96E090", Offset = "0x96E090", VA = "0x96E090")]
		public RuntimeTasksCache(DepotEntity<RDTask> depot, RuntimeDataCache<Formula, RDFormula> formulaCache)
		{
		}

		[Token(Token = "0x6001C5F")]
		[Address(RVA = "0x96E0FC", Offset = "0x96E0FC", VA = "0x96E0FC", Slot = "5")]
		protected override Task CreateRuntimeData(string reference, RDTask refDataDocument)
		{
			return null;
		}
	}
}
