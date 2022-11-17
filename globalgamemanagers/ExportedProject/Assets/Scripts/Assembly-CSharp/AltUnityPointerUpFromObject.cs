using Il2CppDummyDll;

[Token(Token = "0x200003C")]
public class AltUnityPointerUpFromObject : AltUnityCommandReturningAltElement
{
	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityObject altUnityObject;

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xC0E39C", Offset = "0xC0E39C", VA = "0xC0E39C")]
	public AltUnityPointerUpFromObject(SocketSettings socketSettings, AltUnityObject altUnityObject)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xC0E3E4", Offset = "0xC0E3E4", VA = "0xC0E3E4")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
