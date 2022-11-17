using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000021")]
	[Preserve]
	[Flags]
	public enum DefaultValueHandling
	{
		[Token(Token = "0x4000046")]
		Include = 0,
		[Token(Token = "0x4000047")]
		Ignore = 1,
		[Token(Token = "0x4000048")]
		Populate = 2,
		[Token(Token = "0x4000049")]
		IgnoreAndPopulate = 3
	}
}
