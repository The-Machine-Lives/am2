using Il2CppDummyDll;

[Token(Token = "0x200003A")]
public class AltUnityPointerEnterObject : AltUnityCommandReturningAltElement
{
	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityObject altUnityObject;

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xC0DF74", Offset = "0xC0DF74", VA = "0xC0DF74")]
	public AltUnityPointerEnterObject(SocketSettings socketSettings, AltUnityObject altUnityObject)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xC0DFBC", Offset = "0xC0DFBC", VA = "0xC0DFBC")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
