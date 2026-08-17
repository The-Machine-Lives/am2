using Il2CppDummyDll;

[Token(Token = "0x2000051")]
public class AltUnityGetStringKeyPlayerPref : AltBaseCommand
{
	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x38")]
	private string keyName;

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xADAC34", Offset = "0xADAC34", VA = "0xADAC34")]
	public AltUnityGetStringKeyPlayerPref(SocketSettings socketSettings, string keyName)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xADACE0", Offset = "0xADACE0", VA = "0xADACE0")]
	public string Execute()
	{
		return null;
	}
}
