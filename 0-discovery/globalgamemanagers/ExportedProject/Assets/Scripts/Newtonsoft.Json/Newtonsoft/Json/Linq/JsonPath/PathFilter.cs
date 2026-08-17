using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Token(Token = "0x20000ED")]
	[Preserve]
	internal abstract class PathFilter
	{
		[Token(Token = "0x60007A0")]
		public abstract IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch);

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xD02950", Offset = "0xD02950", VA = "0xD02950")]
		protected static JToken GetTokenIndex(JToken t, bool errorWhenNoMatch, int index)
		{
			return null;
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xD02158", Offset = "0xD02158", VA = "0xD02158")]
		protected PathFilter()
		{
		}
	}
}
