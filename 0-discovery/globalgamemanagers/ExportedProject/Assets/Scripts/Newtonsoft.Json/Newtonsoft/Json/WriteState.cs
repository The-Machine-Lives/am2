using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200003D")]
	[Preserve]
	public enum WriteState
	{
		[Token(Token = "0x400013D")]
		Error = 0,
		[Token(Token = "0x400013E")]
		Closed = 1,
		[Token(Token = "0x400013F")]
		Object = 2,
		[Token(Token = "0x4000140")]
		Array = 3,
		[Token(Token = "0x4000141")]
		Constructor = 4,
		[Token(Token = "0x4000142")]
		Property = 5,
		[Token(Token = "0x4000143")]
		Start = 6
	}
}
