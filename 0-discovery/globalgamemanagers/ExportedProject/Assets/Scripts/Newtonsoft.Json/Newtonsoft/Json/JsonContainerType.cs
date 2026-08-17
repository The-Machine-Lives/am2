using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000017")]
	[Preserve]
	internal enum JsonContainerType
	{
		[Token(Token = "0x4000024")]
		None = 0,
		[Token(Token = "0x4000025")]
		Object = 1,
		[Token(Token = "0x4000026")]
		Array = 2,
		[Token(Token = "0x4000027")]
		Constructor = 3
	}
}
