using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;

[Token(Token = "0x2000027")]
public class AltUnityPressKeyAndWait : AltBaseCommand
{
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityKeyCode keyCode;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x3C")]
	private float power;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x40")]
	private float duration;

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xC0E948", Offset = "0xC0E948", VA = "0xC0E948")]
	public AltUnityPressKeyAndWait(SocketSettings socketSettings, AltUnityKeyCode keyCode, float power, float duration)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xC0EA00", Offset = "0xC0EA00", VA = "0xC0EA00")]
	public void Execute()
	{
	}
}
