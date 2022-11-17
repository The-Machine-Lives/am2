using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200001B")]
	[Preserve]
	public enum StringEscapeHandling
	{
		[Token(Token = "0x4000032")]
		Default = 0,
		[Token(Token = "0x4000033")]
		EscapeNonAscii = 1,
		[Token(Token = "0x4000034")]
		EscapeHtml = 2
	}
}
