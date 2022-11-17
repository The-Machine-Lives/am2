using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000089")]
	[Preserve]
	internal class DefaultContractResolverState
	{
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<ResolverContractKey, JsonContract> ContractCache;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x18")]
		public PropertyNameTable NameTable;

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xD0792C", Offset = "0xD0792C", VA = "0xD0792C")]
		public DefaultContractResolverState()
		{
		}
	}
}
