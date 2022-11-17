using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x2000117")]
	[Preserve]
	internal enum BsonBinaryType : byte
	{
		[Token(Token = "0x40003D7")]
		Binary = 0,
		[Token(Token = "0x40003D8")]
		Function = 1,
		[Token(Token = "0x40003D9")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x80FD58", Offset = "0x80FD58")]
		BinaryOld = 2,
		[Token(Token = "0x40003DA")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x80FD90", Offset = "0x80FD90")]
		UuidOld = 3,
		[Token(Token = "0x40003DB")]
		Uuid = 4,
		[Token(Token = "0x40003DC")]
		Md5 = 5,
		[Token(Token = "0x40003DD")]
		UserDefined = 128
	}
}
