using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000469")]
	public struct StoreMetaData
	{
		[Token(Token = "0x400146E")]
		[FieldOffset(Offset = "0x0")]
		public List<string> depots;

		[Token(Token = "0x400146F")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<string, string> alt_value_drivers;
	}
}
