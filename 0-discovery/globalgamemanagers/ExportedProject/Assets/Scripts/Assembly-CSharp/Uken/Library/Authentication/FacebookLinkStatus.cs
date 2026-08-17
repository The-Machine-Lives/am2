using Il2CppDummyDll;

namespace Uken.Library.Authentication
{
	[Token(Token = "0x200048B")]
	public enum FacebookLinkStatus
	{
		[Token(Token = "0x40014BE")]
		Linked = 0,
		[Token(Token = "0x40014BF")]
		NotLinked_Error = 1,
		[Token(Token = "0x40014C0")]
		NotLinked_AccountAlreadyLinked = 2
	}
}
