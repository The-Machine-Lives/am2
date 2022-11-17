using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;

[Token(Token = "0x2000033")]
public class AltUnityDropObject : AltUnityCommandReturningAltElement
{
	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityVector2 position;

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x40")]
	private AltUnityObject altUnityObject;

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xADF234", Offset = "0xADF234", VA = "0xADF234")]
	public AltUnityDropObject(SocketSettings socketSettings, AltUnityVector2 position, AltUnityObject altUnityObject)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xADF28C", Offset = "0xADF28C", VA = "0xADF28C")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
