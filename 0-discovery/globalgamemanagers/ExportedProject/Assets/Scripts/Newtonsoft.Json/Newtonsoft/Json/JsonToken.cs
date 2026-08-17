using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200003A")]
	[Preserve]
	public enum JsonToken
	{
		[Token(Token = "0x4000112")]
		None = 0,
		[Token(Token = "0x4000113")]
		StartObject = 1,
		[Token(Token = "0x4000114")]
		StartArray = 2,
		[Token(Token = "0x4000115")]
		StartConstructor = 3,
		[Token(Token = "0x4000116")]
		PropertyName = 4,
		[Token(Token = "0x4000117")]
		Comment = 5,
		[Token(Token = "0x4000118")]
		Raw = 6,
		[Token(Token = "0x4000119")]
		Integer = 7,
		[Token(Token = "0x400011A")]
		Float = 8,
		[Token(Token = "0x400011B")]
		String = 9,
		[Token(Token = "0x400011C")]
		Boolean = 10,
		[Token(Token = "0x400011D")]
		Null = 11,
		[Token(Token = "0x400011E")]
		Undefined = 12,
		[Token(Token = "0x400011F")]
		EndObject = 13,
		[Token(Token = "0x4000120")]
		EndArray = 14,
		[Token(Token = "0x4000121")]
		EndConstructor = 15,
		[Token(Token = "0x4000122")]
		Date = 16,
		[Token(Token = "0x4000123")]
		Bytes = 17
	}
}
