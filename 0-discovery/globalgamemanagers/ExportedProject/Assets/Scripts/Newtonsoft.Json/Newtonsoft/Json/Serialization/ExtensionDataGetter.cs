using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200009D")]
	[Preserve]
	public delegate IEnumerable<KeyValuePair<object, object>> ExtensionDataGetter(object o);
}
