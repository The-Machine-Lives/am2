using Il2CppDummyDll;

[Token(Token = "0x2000049")]
public class AltUnityWaitForElementWithText : AltBaseCommand
{
	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x38")]
	private string name;

	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x40")]
	private string cameraName;

	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x48")]
	private string text;

	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x50")]
	private bool enabled;

	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x58")]
	private double timeout;

	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x60")]
	private double interval;

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xC1B698", Offset = "0xC1B698", VA = "0xC1B698")]
	public AltUnityWaitForElementWithText(SocketSettings socketSettings, string name, string text, string cameraName, bool enabled, double timeout, double interval)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xC1B778", Offset = "0xC1B778", VA = "0xC1B778")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
