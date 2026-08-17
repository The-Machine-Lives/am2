using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x2000124")]
	[Preserve]
	internal enum BsonType : sbyte
	{
		[Token(Token = "0x400040B")]
		Number = 1,
		[Token(Token = "0x400040C")]
		String = 2,
		[Token(Token = "0x400040D")]
		Object = 3,
		[Token(Token = "0x400040E")]
		Array = 4,
		[Token(Token = "0x400040F")]
		Binary = 5,
		[Token(Token = "0x4000410")]
		Undefined = 6,
		[Token(Token = "0x4000411")]
		Oid = 7,
		[Token(Token = "0x4000412")]
		Boolean = 8,
		[Token(Token = "0x4000413")]
		Date = 9,
		[Token(Token = "0x4000414")]
		Null = 10,
		[Token(Token = "0x4000415")]
		Regex = 11,
		[Token(Token = "0x4000416")]
		Reference = 12,
		[Token(Token = "0x4000417")]
		Code = 13,
		[Token(Token = "0x4000418")]
		Symbol = 14,
		[Token(Token = "0x4000419")]
		CodeWScope = 15,
		[Token(Token = "0x400041A")]
		Integer = 16,
		[Token(Token = "0x400041B")]
		TimeStamp = 17,
		[Token(Token = "0x400041C")]
		Long = 18,
		[Token(Token = "0x400041D")]
		MinKey = -1,
		[Token(Token = "0x400041E")]
		MaxKey = sbyte.MaxValue
	}
}
