using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200000B")]
	[Preserve]
	public enum ConstructorHandling
	{
		[Token(Token = "0x4000009")]
		Default = 0,
		[Token(Token = "0x400000A")]
		AllowNonPublicDefaultConstructor = 1
	}
}
