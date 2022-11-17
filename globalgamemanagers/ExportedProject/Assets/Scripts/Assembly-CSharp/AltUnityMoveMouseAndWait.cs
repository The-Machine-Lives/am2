using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;

[Token(Token = "0x2000025")]
public class AltUnityMoveMouseAndWait : AltBaseCommand
{
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityVector2 location;

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x40")]
	private float duration;

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xADBB08", Offset = "0xADBB08", VA = "0xADBB08")]
	public AltUnityMoveMouseAndWait(SocketSettings socketSettings, AltUnityVector2 location, float duration)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xADBBD4", Offset = "0xADBBD4", VA = "0xADBBD4")]
	public void Execute()
	{
	}
}
