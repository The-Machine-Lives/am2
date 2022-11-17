using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200009A")]
	[Preserve]
	public delegate void SerializationCallback(object o, StreamingContext context);
}
