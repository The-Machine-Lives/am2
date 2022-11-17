using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000026")]
	[Preserve]
	public enum MemberSerialization
	{
		[Token(Token = "0x4000084")]
		OptOut = 0,
		[Token(Token = "0x4000085")]
		OptIn = 1,
		[Token(Token = "0x4000086")]
		Fields = 2
	}
}
