using Il2CppDummyDll;

[Token(Token = "0x2000041")]
public class AltUnityFindElementByComponent : AltUnityCommandReturningAltElement
{
	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x38")]
	private string componentName;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x40")]
	private string assemblyName;

	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x48")]
	private string cameraName;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x50")]
	private bool enabled;

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xADDF98", Offset = "0xADDF98", VA = "0xADDF98")]
	public AltUnityFindElementByComponent(SocketSettings socketSettings, string componentName, string assemblyName, string cameraName, bool enabled)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xADE004", Offset = "0xADE004", VA = "0xADE004")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
