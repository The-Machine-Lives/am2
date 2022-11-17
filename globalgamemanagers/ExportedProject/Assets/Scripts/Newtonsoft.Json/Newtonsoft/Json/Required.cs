using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200001C")]
	[Preserve]
	public enum Required
	{
		[Token(Token = "0x4000036")]
		Default = 0,
		[Token(Token = "0x4000037")]
		AllowNull = 1,
		[Token(Token = "0x4000038")]
		Always = 2,
		[Token(Token = "0x4000039")]
		DisallowNull = 3
	}
}
