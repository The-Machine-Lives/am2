using Il2CppDummyDll;

namespace Com.Uken.Adlib
{
	[Token(Token = "0x2000005")]
	public enum AdResult
	{
		[Token(Token = "0x4000009")]
		Failed = 0,
		[Token(Token = "0x400000A")]
		Skipped = 1,
		[Token(Token = "0x400000B")]
		Finished = 2,
		[Token(Token = "0x400000C")]
		Timeout = 3
	}
}
