using System;
using Il2CppDummyDll;

[Token(Token = "0x20001FE")]
public abstract class AuthProvider
{
	[Token(Token = "0x6000D7F")]
	[Address(RVA = "0xA3A8C4", Offset = "0xA3A8C4", VA = "0xA3A8C4")]
	public AuthProvider()
	{
	}

	[Token(Token = "0x6000D80")]
	public abstract void Login(Action<bool, string> callback);

	[Token(Token = "0x6000D81")]
	public abstract void Logout();
}
