using Il2CppDummyDll;

[Token(Token = "0x2000200")]
public abstract class NativeAuthProvider : AuthProvider
{
	[Token(Token = "0x170001A8")]
	public abstract bool isLoggedIn
	{
		[Token(Token = "0x6000D8B")]
		get;
	}

	[Token(Token = "0x170001A9")]
	public string credential
	{
		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x99D9A8", Offset = "0x99D9A8", VA = "0x99D9A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0x99DAD4", Offset = "0x99DAD4", VA = "0x99DAD4")]
	public NativeAuthProvider()
	{
	}
}
