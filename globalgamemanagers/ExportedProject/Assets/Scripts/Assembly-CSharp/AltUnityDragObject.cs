using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;

[Token(Token = "0x2000032")]
public class AltUnityDragObject : AltUnityCommandReturningAltElement
{
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityVector2 position;

	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x40")]
	private AltUnityObject altUnityObject;

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xAD790C", Offset = "0xAD790C", VA = "0xAD790C")]
	public AltUnityDragObject(SocketSettings socketSettings, AltUnityVector2 position, AltUnityObject altUnityObject)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xAD7964", Offset = "0xAD7964", VA = "0xAD7964")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
