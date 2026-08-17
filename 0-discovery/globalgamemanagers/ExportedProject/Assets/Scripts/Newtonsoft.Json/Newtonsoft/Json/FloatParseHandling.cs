using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000010")]
	[Preserve]
	public enum FloatParseHandling
	{
		[Token(Token = "0x400001C")]
		Double = 0,
		[Token(Token = "0x400001D")]
		Decimal = 1
	}
}
