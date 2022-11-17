using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000C1")]
	[Preserve]
	public class JTokenEqualityComparer : IEqualityComparer<JToken>
	{
		[Token(Token = "0x6000591")]
		[Address(RVA = "0xCFCEC8", Offset = "0xCFCEC8", VA = "0xCFCEC8", Slot = "4")]
		public bool Equals(JToken x, JToken y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xCFCF40", Offset = "0xCFCF40", VA = "0xCFCF40", Slot = "5")]
		public int GetHashCode(JToken obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xCFCF64", Offset = "0xCFCF64", VA = "0xCFCF64")]
		public JTokenEqualityComparer()
		{
		}
	}
}
