using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;

[Token(Token = "0x2000024")]
public class AltUnityMoveMouse : AltBaseCommand
{
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityVector2 location;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x40")]
	private float duration;

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xADB764", Offset = "0xADB764", VA = "0xADB764")]
	public AltUnityMoveMouse(SocketSettings socketSettings, AltUnityVector2 location, float duration)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xADB830", Offset = "0xADB830", VA = "0xADB830")]
	public void Execute()
	{
	}
}
