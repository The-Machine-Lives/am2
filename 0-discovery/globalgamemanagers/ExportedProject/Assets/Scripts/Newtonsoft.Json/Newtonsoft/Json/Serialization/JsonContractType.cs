using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000099")]
	[Preserve]
	internal enum JsonContractType
	{
		[Token(Token = "0x400023C")]
		None = 0,
		[Token(Token = "0x400023D")]
		Object = 1,
		[Token(Token = "0x400023E")]
		Array = 2,
		[Token(Token = "0x400023F")]
		Primitive = 3,
		[Token(Token = "0x4000240")]
		String = 4,
		[Token(Token = "0x4000241")]
		Dictionary = 5,
		[Token(Token = "0x4000242")]
		Dynamic = 6,
		[Token(Token = "0x4000243")]
		Serializable = 7,
		[Token(Token = "0x4000244")]
		Linq = 8
	}
}
