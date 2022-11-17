using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000C0")]
	[Preserve]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x80EED0", Offset = "0x80EED0")]
	public interface IJEnumerable<T> : IEnumerable<T>, IEnumerable where T : JToken
	{
	}
}
