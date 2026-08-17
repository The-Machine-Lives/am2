using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200001D")]
	[Flags]
	[Preserve]
	public enum PreserveReferencesHandling
	{
		[Token(Token = "0x400003B")]
		None = 0,
		[Token(Token = "0x400003C")]
		Objects = 1,
		[Token(Token = "0x400003D")]
		Arrays = 2,
		[Token(Token = "0x400003E")]
		All = 3
	}
}
