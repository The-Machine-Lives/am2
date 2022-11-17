using Il2CppDummyDll;

[Token(Token = "0x200001F")]
public class AltUnityWaitForObject : AltUnityBaseFindObjects
{
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x38")]
	private By by;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x40")]
	private string value;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x48")]
	private By cameraBy;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x50")]
	private string cameraPath;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x58")]
	private bool enabled;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x60")]
	private double timeout;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x68")]
	private double interval;

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xC1BB70", Offset = "0xC1BB70", VA = "0xC1BB70")]
	public AltUnityWaitForObject(SocketSettings socketSettings, By by, string value, By cameraBy, string cameraPath, bool enabled, double timeout, double interval)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xC1BC00", Offset = "0xC1BC00", VA = "0xC1BC00")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
