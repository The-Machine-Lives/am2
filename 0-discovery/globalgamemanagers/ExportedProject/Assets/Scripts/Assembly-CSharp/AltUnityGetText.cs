using Il2CppDummyDll;

[Token(Token = "0x2000038")]
public class AltUnityGetText : AltBaseCommand
{
	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityObject altUnityObject;

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xAE1238", Offset = "0xAE1238", VA = "0xAE1238")]
	public AltUnityGetText(SocketSettings socketSettings, AltUnityObject altUnityObject)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xAE12E4", Offset = "0xAE12E4", VA = "0xAE12E4")]
	public string Execute()
	{
		return null;
	}
}
