using Il2CppDummyDll;

[Token(Token = "0x200001D")]
public class AltUnityFindObjectWhichContains : AltUnityBaseFindObjects
{
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x38")]
	private By by;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x40")]
	private string value;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x48")]
	private By cameraBy;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x50")]
	private string cameraPath;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x58")]
	private bool enabled;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xAD98E4", Offset = "0xAD98E4", VA = "0xAD98E4")]
	public AltUnityFindObjectWhichContains(SocketSettings socketSettings, By by, string value, By cameraBy, string cameraPath, bool enabled)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xAD995C", Offset = "0xAD995C", VA = "0xAD995C")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
