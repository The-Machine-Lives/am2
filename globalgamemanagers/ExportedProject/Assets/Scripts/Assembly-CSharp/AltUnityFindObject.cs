using Il2CppDummyDll;

[Token(Token = "0x200001A")]
public class AltUnityFindObject : AltUnityBaseFindObjects
{
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x38")]
	private By by;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x40")]
	private string value;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x48")]
	private By cameraBy;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x50")]
	private string cameraPath;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x58")]
	private bool enabled;

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xAD9354", Offset = "0xAD9354", VA = "0xAD9354")]
	public AltUnityFindObject(SocketSettings socketSettings, By by, string value, By cameraBy, string cameraPath, bool enabled)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xAD93CC", Offset = "0xAD93CC", VA = "0xAD93CC")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
