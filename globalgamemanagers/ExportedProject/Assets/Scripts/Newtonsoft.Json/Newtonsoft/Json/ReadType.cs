using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000028")]
	[Preserve]
	internal enum ReadType
	{
		[Token(Token = "0x400008C")]
		Read = 0,
		[Token(Token = "0x400008D")]
		ReadAsInt32 = 1,
		[Token(Token = "0x400008E")]
		ReadAsBytes = 2,
		[Token(Token = "0x400008F")]
		ReadAsString = 3,
		[Token(Token = "0x4000090")]
		ReadAsDecimal = 4,
		[Token(Token = "0x4000091")]
		ReadAsDateTime = 5,
		[Token(Token = "0x4000092")]
		ReadAsDateTimeOffset = 6,
		[Token(Token = "0x4000093")]
		ReadAsDouble = 7,
		[Token(Token = "0x4000094")]
		ReadAsBoolean = 8
	}
}
