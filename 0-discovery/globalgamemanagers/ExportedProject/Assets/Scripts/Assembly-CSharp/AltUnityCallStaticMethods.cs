using Il2CppDummyDll;

[Token(Token = "0x2000030")]
public class AltUnityCallStaticMethods : AltBaseCommand
{
	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x38")]
	private string typeName;

	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x40")]
	private string methodName;

	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x48")]
	private string parameters;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x50")]
	private string typeOfParameters;

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x58")]
	private string assemblyName;

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xAD6198", Offset = "0xAD6198", VA = "0xAD6198")]
	public AltUnityCallStaticMethods(SocketSettings socketSettings, string typeName, string methodName, string parameters, string typeOfParameters, string assemblyName)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xAD626C", Offset = "0xAD626C", VA = "0xAD626C")]
	public string Execute()
	{
		return null;
	}
}
