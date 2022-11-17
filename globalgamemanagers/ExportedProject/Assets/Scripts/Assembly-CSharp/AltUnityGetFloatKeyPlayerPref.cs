using Il2CppDummyDll;

[Token(Token = "0x200004F")]
public class AltUnityGetFloatKeyPlayerPref : AltBaseCommand
{
	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x38")]
	private string keyName;

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xADA880", Offset = "0xADA880", VA = "0xADA880")]
	public AltUnityGetFloatKeyPlayerPref(SocketSettings socketSettings, string keyName)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xADA92C", Offset = "0xADA92C", VA = "0xADA92C")]
	public float Execute()
	{
		return default(float);
	}
}
