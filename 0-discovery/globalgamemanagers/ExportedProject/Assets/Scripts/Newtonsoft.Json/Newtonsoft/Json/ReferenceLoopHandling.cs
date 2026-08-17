using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000038")]
	[Preserve]
	public enum ReferenceLoopHandling
	{
		[Token(Token = "0x4000108")]
		Error = 0,
		[Token(Token = "0x4000109")]
		Ignore = 1,
		[Token(Token = "0x400010A")]
		Serialize = 2
	}
}
