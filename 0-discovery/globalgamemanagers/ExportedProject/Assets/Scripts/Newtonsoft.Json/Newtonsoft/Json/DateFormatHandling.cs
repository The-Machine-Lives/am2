using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200000C")]
	[Preserve]
	public enum DateFormatHandling
	{
		[Token(Token = "0x400000C")]
		IsoDateFormat = 0,
		[Token(Token = "0x400000D")]
		MicrosoftDateFormat = 1
	}
}
