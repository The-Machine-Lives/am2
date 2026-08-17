using Il2CppDummyDll;

[Token(Token = "0x2000039")]
public class AltUnityPointerDownFromObject : AltUnityCommandReturningAltElement
{
	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityObject altUnityObject;

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xC0DD60", Offset = "0xC0DD60", VA = "0xC0DD60")]
	public AltUnityPointerDownFromObject(SocketSettings socketSettings, AltUnityObject altUnityObject)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xC0DDA8", Offset = "0xC0DDA8", VA = "0xC0DDA8")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
