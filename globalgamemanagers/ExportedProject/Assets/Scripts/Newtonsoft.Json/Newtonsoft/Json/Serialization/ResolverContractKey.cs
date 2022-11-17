using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000088")]
	[Preserve]
	internal struct ResolverContractKey
	{
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x0")]
		private readonly Type _resolverType;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x8")]
		private readonly Type _contractType;

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x8A5C70", Offset = "0x8A5C70", VA = "0x8A5C70")]
		public ResolverContractKey(Type resolverType, Type contractType)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x8A5C78", Offset = "0x8A5C78", VA = "0x8A5C78", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x8A5C80", Offset = "0x8A5C80", VA = "0x8A5C80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x8A5C88", Offset = "0x8A5C88", VA = "0x8A5C88")]
		public bool Equals(ResolverContractKey other)
		{
			return default(bool);
		}
	}
}
