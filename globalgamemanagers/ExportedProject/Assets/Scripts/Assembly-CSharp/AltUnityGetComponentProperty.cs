using Il2CppDummyDll;

[Token(Token = "0x2000037")]
public class AltUnityGetComponentProperty : AltBaseCommand
{
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x38")]
	private string componentName;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x40")]
	private string propertyName;

	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x48")]
	private string assemblyName;

	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x50")]
	private AltUnityObject altUnityObject;

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xAE00AC", Offset = "0xAE00AC", VA = "0xAE00AC")]
	public AltUnityGetComponentProperty(SocketSettings socketSettings, string componentName, string propertyName, string assemblyName, AltUnityObject altUnityObject)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xAE017C", Offset = "0xAE017C", VA = "0xAE017C")]
	public string Execute()
	{
		return null;
	}
}
