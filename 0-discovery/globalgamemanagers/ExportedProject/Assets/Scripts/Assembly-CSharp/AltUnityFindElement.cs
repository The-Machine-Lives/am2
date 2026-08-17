using Il2CppDummyDll;

[Token(Token = "0x2000040")]
public class AltUnityFindElement : AltUnityCommandReturningAltElement
{
	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x38")]
	private string name;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x40")]
	private string cameraName;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x48")]
	private bool enabled;

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xADCB2C", Offset = "0xADCB2C", VA = "0xADCB2C")]
	public AltUnityFindElement(SocketSettings socketSettings, string name, string cameraName, bool enabled)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xADCB88", Offset = "0xADCB88", VA = "0xADCB88")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
