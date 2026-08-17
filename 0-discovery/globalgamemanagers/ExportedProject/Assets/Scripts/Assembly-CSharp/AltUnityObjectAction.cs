using Il2CppDummyDll;

[Token(Token = "0x200000A")]
public struct AltUnityObjectAction
{
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x0")]
	public string Component;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x8")]
	public string Method;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x10")]
	public string Parameters;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x18")]
	public string TypeOfParameters;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x20")]
	public string Assembly;

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x89C358", Offset = "0x89C358", VA = "0x89C358")]
	public AltUnityObjectAction(string component = "", string method = "", string parameters = "", string typeOfParameters = "", string assembly = "")
	{
	}
}
