using Il2CppDummyDll;

[Token(Token = "0x200000B")]
public struct AltUnityObjectProperty
{
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x0")]
	public string Component;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x8")]
	public string Property;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x10")]
	public string Assembly;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x89DEA8", Offset = "0x89DEA8", VA = "0x89DEA8")]
	public AltUnityObjectProperty(string component = "", string property = "")
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x89DEB4", Offset = "0x89DEB4", VA = "0x89DEB4")]
	public AltUnityObjectProperty(string component, string property, string assembly)
	{
	}
}
