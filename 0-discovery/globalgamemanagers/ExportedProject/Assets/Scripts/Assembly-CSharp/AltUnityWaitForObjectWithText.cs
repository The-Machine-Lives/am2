using Il2CppDummyDll;

[Token(Token = "0x2000022")]
public class AltUnityWaitForObjectWithText : AltUnityBaseFindObjects
{
	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x38")]
	private By by;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x40")]
	private string value;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x48")]
	private string text;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x50")]
	private By cameraBy;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x58")]
	private string cameraPath;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x60")]
	private bool enabled;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x68")]
	private double timeout;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x70")]
	private double interval;

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xC1C728", Offset = "0xC1C728", VA = "0xC1C728")]
	public AltUnityWaitForObjectWithText(SocketSettings socketSettings, By by, string value, string text, By cameraBy, string cameraPath, bool enabled, double timeout, double interval)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xC1C7C4", Offset = "0xC1C7C4", VA = "0xC1C7C4")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
