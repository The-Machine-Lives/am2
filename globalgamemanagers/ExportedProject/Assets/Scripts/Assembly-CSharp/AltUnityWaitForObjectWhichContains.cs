using Il2CppDummyDll;

[Token(Token = "0x2000021")]
public class AltUnityWaitForObjectWhichContains : AltUnityBaseFindObjects
{
	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x38")]
	private By by;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x40")]
	private string value;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x48")]
	private By cameraBy;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x50")]
	private string cameraPath;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x58")]
	private bool enabled;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x60")]
	private double timeout;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x68")]
	private double interval;

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xC1C344", Offset = "0xC1C344", VA = "0xC1C344")]
	public AltUnityWaitForObjectWhichContains(SocketSettings socketSettings, By by, string value, By cameraBy, string cameraPath, bool enabled, double timeout, double interval)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xC1C3D4", Offset = "0xC1C3D4", VA = "0xC1C3D4")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
