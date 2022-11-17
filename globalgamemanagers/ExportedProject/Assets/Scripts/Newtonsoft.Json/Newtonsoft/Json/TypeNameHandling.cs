using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000039")]
	[Flags]
	[Preserve]
	public enum TypeNameHandling
	{
		[Token(Token = "0x400010C")]
		None = 0,
		[Token(Token = "0x400010D")]
		Objects = 1,
		[Token(Token = "0x400010E")]
		Arrays = 2,
		[Token(Token = "0x400010F")]
		All = 3,
		[Token(Token = "0x4000110")]
		Auto = 4
	}
}
