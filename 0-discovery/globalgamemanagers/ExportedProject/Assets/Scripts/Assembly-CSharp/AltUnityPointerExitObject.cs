using Il2CppDummyDll;

[Token(Token = "0x200003B")]
public class AltUnityPointerExitObject : AltUnityCommandReturningAltElement
{
	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityObject altUnityObject;

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xC0E188", Offset = "0xC0E188", VA = "0xC0E188")]
	public AltUnityPointerExitObject(SocketSettings socketSettings, AltUnityObject altUnityObject)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xC0E1D0", Offset = "0xC0E1D0", VA = "0xC0E1D0")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
