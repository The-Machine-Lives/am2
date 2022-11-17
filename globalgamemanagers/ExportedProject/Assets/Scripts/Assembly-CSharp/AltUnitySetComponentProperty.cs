using Il2CppDummyDll;

[Token(Token = "0x200003D")]
public class AltUnitySetComponentProperty : AltBaseCommand
{
	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x38")]
	private string componentName;

	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x40")]
	private string propertyName;

	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x48")]
	private string value;

	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x50")]
	private string assemblyName;

	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x58")]
	private AltUnityObject altUnityObject;

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xC16E04", Offset = "0xC16E04", VA = "0xC16E04")]
	public AltUnitySetComponentProperty(SocketSettings socketSettings, string componentName, string propertyName, string value, string assemblyName, AltUnityObject altUnityObject)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xC16ED0", Offset = "0xC16ED0", VA = "0xC16ED0")]
	public string Execute()
	{
		return null;
	}
}
