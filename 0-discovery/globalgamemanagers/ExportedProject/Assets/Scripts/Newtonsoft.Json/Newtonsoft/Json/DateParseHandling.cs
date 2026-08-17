using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200000D")]
	[Preserve]
	public enum DateParseHandling
	{
		[Token(Token = "0x400000F")]
		None = 0,
		[Token(Token = "0x4000010")]
		DateTime = 1,
		[Token(Token = "0x4000011")]
		DateTimeOffset = 2
	}
}
