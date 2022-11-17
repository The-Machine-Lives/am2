using Il2CppDummyDll;

[Token(Token = "0x2000031")]
public class AltUnityClickEvent : AltUnityCommandReturningAltElement
{
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityObject altUnityObject;

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xAD68B8", Offset = "0xAD68B8", VA = "0xAD68B8")]
	public AltUnityClickEvent(SocketSettings socketSettings, AltUnityObject altUnityObject)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xAD68FC", Offset = "0xAD68FC", VA = "0xAD68FC")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
