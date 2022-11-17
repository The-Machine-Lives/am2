using Il2CppDummyDll;

[Token(Token = "0x2000050")]
public class AltUnityGetIntKeyPLayerPref : AltBaseCommand
{
	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x38")]
	private string keyName;

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xADA4CC", Offset = "0xADA4CC", VA = "0xADA4CC")]
	public AltUnityGetIntKeyPLayerPref(SocketSettings socketSettings, string keyName)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xADA578", Offset = "0xADA578", VA = "0xADA578")]
	public int Execute()
	{
		return default(int);
	}
}
