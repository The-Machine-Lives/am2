using Il2CppDummyDll;

[Token(Token = "0x2000047")]
public class AltUnityWaitForElementToNotBePresent : AltBaseCommand
{
	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x38")]
	private string name;

	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x40")]
	private string cameraName;

	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x48")]
	private bool enabled;

	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x50")]
	private double timeout;

	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x58")]
	private double interval;

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xC1AE98", Offset = "0xC1AE98", VA = "0xC1AE98")]
	public AltUnityWaitForElementToNotBePresent(SocketSettings socketSettings, string name, string cameraName, bool enabled, double timeout, double interval)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xC1AF68", Offset = "0xC1AF68", VA = "0xC1AF68")]
	public void Execute()
	{
	}
}
