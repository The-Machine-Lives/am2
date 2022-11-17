using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200000E")]
	[Preserve]
	public enum DateTimeZoneHandling
	{
		[Token(Token = "0x4000013")]
		Local = 0,
		[Token(Token = "0x4000014")]
		Utc = 1,
		[Token(Token = "0x4000015")]
		Unspecified = 2,
		[Token(Token = "0x4000016")]
		RoundtripKind = 3
	}
}
