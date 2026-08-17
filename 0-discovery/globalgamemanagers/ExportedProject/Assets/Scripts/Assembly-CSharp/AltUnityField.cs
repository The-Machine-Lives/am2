using Il2CppDummyDll;

[Token(Token = "0x2000007")]
public struct AltUnityField
{
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x0")]
	public string name;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x8")]
	public string value;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x89C240", Offset = "0x89C240", VA = "0x89C240")]
	public AltUnityField(string name, string value)
	{
	}
}
