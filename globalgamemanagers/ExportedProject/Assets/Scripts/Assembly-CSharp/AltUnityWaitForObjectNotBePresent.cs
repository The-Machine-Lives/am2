using Il2CppDummyDll;

[Token(Token = "0x2000020")]
public class AltUnityWaitForObjectNotBePresent : AltUnityBaseFindObjects
{
	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x38")]
	private By by;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x40")]
	private string value;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x48")]
	private By cameraBy;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x50")]
	private string cameraPath;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x58")]
	private bool enabled;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x60")]
	private double timeout;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x68")]
	private double interval;

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xC1BF54", Offset = "0xC1BF54", VA = "0xC1BF54")]
	public AltUnityWaitForObjectNotBePresent(SocketSettings socketSettings, By by, string value, By cameraBy, string cameraPath, bool enabled, double timeout, double interval)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xC1BFE4", Offset = "0xC1BFE4", VA = "0xC1BFE4")]
	public void Execute()
	{
	}
}
