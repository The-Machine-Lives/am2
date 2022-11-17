using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.Jingot;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200050C")]
	public class RDJingotTest : BaseEntityDocument
	{
		[Token(Token = "0x40017B9")]
		[FieldOffset(Offset = "0x30")]
		public JingotEntityType entityType;

		[Token(Token = "0x40017BA")]
		[FieldOffset(Offset = "0x38")]
		public List<ABGroupConfig> abGroups;

		[Token(Token = "0x40017BB")]
		[FieldOffset(Offset = "0x40")]
		[ValidateJingotFilter]
		public List<ABFilterConfig> abFilters;

		[Token(Token = "0x6002692")]
		[Address(RVA = "0xA81234", Offset = "0xA81234", VA = "0xA81234")]
		public RDJingotTest(string _refName)
		{
		}

		[Token(Token = "0x6002693")]
		[Address(RVA = "0xA812BC", Offset = "0xA812BC", VA = "0xA812BC")]
		private void SetDefaultGroups()
		{
		}
	}
}
