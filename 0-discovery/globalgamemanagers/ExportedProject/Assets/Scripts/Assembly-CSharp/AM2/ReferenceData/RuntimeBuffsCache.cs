using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000318")]
	public class RuntimeBuffsCache : RuntimeDataCache<Buff, RDBuff>
	{
		[Token(Token = "0x4000F57")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, IStatusEffect> m_allStatusEffects;

		[Token(Token = "0x6001920")]
		[Address(RVA = "0x96C398", Offset = "0x96C398", VA = "0x96C398")]
		public RuntimeBuffsCache(DepotEntity<RDBuff> depot, Dictionary<string, IStatusEffect> allStatusEffects)
		{
		}

		[Token(Token = "0x6001921")]
		[Address(RVA = "0x96C404", Offset = "0x96C404", VA = "0x96C404", Slot = "5")]
		protected override Buff CreateRuntimeData(string reference, RDBuff refDataDocument)
		{
			return null;
		}
	}
}
