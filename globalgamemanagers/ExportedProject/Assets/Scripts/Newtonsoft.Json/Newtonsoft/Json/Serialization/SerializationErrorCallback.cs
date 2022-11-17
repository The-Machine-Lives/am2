using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200009B")]
	[Preserve]
	public delegate void SerializationErrorCallback(object o, StreamingContext context, ErrorContext errorContext);
}
