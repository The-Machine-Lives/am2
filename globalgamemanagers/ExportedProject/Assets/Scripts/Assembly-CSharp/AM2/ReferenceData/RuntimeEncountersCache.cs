using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000329")]
	public class RuntimeEncountersCache : RuntimeDataCache<Encounter, RDEncounter>
	{
		[Token(Token = "0x4000FAC")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, IActionScene> m_allActionScenes;

		[Token(Token = "0x6001992")]
		[Address(RVA = "0x96C6B0", Offset = "0x96C6B0", VA = "0x96C6B0")]
		public RuntimeEncountersCache(DepotEntity<RDEncounter> depot, Dictionary<string, IActionScene> allActionScenes)
		{
		}

		[Token(Token = "0x6001993")]
		[Address(RVA = "0x96C71C", Offset = "0x96C71C", VA = "0x96C71C", Slot = "5")]
		protected override Encounter CreateRuntimeData(string reference, RDEncounter refDataDocument)
		{
			return null;
		}
	}
}
