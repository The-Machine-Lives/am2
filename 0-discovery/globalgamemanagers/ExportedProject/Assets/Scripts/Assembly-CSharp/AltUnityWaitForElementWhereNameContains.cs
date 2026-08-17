using Il2CppDummyDll;

[Token(Token = "0x2000048")]
public class AltUnityWaitForElementWhereNameContains : AltBaseCommand
{
	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x38")]
	private string name;

	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x40")]
	private string cameraName;

	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x48")]
	private bool enabled;

	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x50")]
	private double timeout;

	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x58")]
	private double interval;

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xC1B294", Offset = "0xC1B294", VA = "0xC1B294")]
	public AltUnityWaitForElementWhereNameContains(SocketSettings socketSettings, string name, string cameraName, bool enabled, double timeout, double interval)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xC1B364", Offset = "0xC1B364", VA = "0xC1B364")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
