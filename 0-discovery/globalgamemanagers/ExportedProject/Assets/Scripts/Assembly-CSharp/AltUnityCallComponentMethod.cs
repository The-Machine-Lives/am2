using Il2CppDummyDll;

[Token(Token = "0x200002F")]
public class AltUnityCallComponentMethod : AltBaseCommand
{
	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x38")]
	private string componentName;

	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x40")]
	private string methodName;

	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x48")]
	private string parameters;

	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x50")]
	private string typeOfParameters;

	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x58")]
	private string assemblyName;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x60")]
	private AltUnityObject altUnityObject;

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xAD5DF4", Offset = "0xAD5DF4", VA = "0xAD5DF4")]
	public AltUnityCallComponentMethod(SocketSettings socketSettings, string componentName, string methodName, string parameters, string typeOfParameters, string assembly, AltUnityObject altUnityObject)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xAD5ED8", Offset = "0xAD5ED8", VA = "0xAD5ED8")]
	public string Execute()
	{
		return null;
	}
}
