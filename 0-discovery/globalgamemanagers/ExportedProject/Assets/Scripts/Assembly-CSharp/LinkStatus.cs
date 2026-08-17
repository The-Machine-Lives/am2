using Il2CppDummyDll;

[Token(Token = "0x20001E5")]
public enum LinkStatus
{
	[Token(Token = "0x4000B25")]
	Linked = 0,
	[Token(Token = "0x4000B26")]
	NotLinked_Error = 1,
	[Token(Token = "0x4000B27")]
	NotLinked_AccountAlreadyLinked = 2,
	[Token(Token = "0x4000B28")]
	NotLinked_DoesntMatchLinkedAccount = 3
}
