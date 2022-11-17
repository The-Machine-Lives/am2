using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;

[Token(Token = "0x2000026")]
public class AltUnityPressKey : AltBaseCommand
{
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityKeyCode keyCode;

	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x3C")]
	private float power;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x40")]
	private float duration;

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xC0E5B0", Offset = "0xC0E5B0", VA = "0xC0E5B0")]
	public AltUnityPressKey(SocketSettings socketSettings, AltUnityKeyCode keyCode, float power, float duration)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xC0E668", Offset = "0xC0E668", VA = "0xC0E668")]
	public void Execute()
	{
	}
}
