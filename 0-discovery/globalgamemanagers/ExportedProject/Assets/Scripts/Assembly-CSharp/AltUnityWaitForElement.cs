using Il2CppDummyDll;

[Token(Token = "0x2000046")]
public class AltUnityWaitForElement : AltBaseCommand
{
	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x38")]
	private string name;

	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x40")]
	private string cameraName;

	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x48")]
	private bool enabled;

	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x50")]
	private double timeout;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x58")]
	private double interval;

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xC1AA94", Offset = "0xC1AA94", VA = "0xC1AA94")]
	public AltUnityWaitForElement(SocketSettings socketSettings, string name, string cameraName, bool enabled, double timeout, double interval)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xC1AB64", Offset = "0xC1AB64", VA = "0xC1AB64")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
