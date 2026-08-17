using Il2CppDummyDll;

[Token(Token = "0x200003F")]
public class AltUnityTap : AltUnityCommandReturningAltElement
{
	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityObject altUnityObject;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x40")]
	private int count;

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xC18B4C", Offset = "0xC18B4C", VA = "0xC18B4C")]
	public AltUnityTap(SocketSettings socketSettings, AltUnityObject altUnityObject, int count)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xC18BA4", Offset = "0xC18BA4", VA = "0xC18BA4")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
