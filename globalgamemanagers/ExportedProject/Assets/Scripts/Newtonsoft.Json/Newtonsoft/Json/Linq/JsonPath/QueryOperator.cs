using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Token(Token = "0x20000EE")]
	[Preserve]
	internal enum QueryOperator
	{
		[Token(Token = "0x4000398")]
		None = 0,
		[Token(Token = "0x4000399")]
		Equals = 1,
		[Token(Token = "0x400039A")]
		NotEquals = 2,
		[Token(Token = "0x400039B")]
		Exists = 3,
		[Token(Token = "0x400039C")]
		LessThan = 4,
		[Token(Token = "0x400039D")]
		LessThanOrEquals = 5,
		[Token(Token = "0x400039E")]
		GreaterThan = 6,
		[Token(Token = "0x400039F")]
		GreaterThanOrEquals = 7,
		[Token(Token = "0x40003A0")]
		And = 8,
		[Token(Token = "0x40003A1")]
		Or = 9
	}
}
