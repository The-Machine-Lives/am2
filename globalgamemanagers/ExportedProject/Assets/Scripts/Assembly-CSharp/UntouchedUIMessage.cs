using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000130")]
public class UntouchedUIMessage
{
	[Token(Token = "0x40007BA")]
	[FieldOffset(Offset = "0x10")]
	public string messageID;

	[Token(Token = "0x40007BB")]
	[FieldOffset(Offset = "0x18")]
	public HashSet<string> untouchedElementsByReference;

	[Token(Token = "0x60008BB")]
	[Address(RVA = "0xAB45E0", Offset = "0xAB45E0", VA = "0xAB45E0")]
	public UntouchedUIMessage()
	{
	}
}
