using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;

[Token(Token = "0x2000023")]
public class AltUnitySwipe : AltBaseCommand
{
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityVector2 start;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x40")]
	private AltUnityVector2 end;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x48")]
	private float duration;

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xC1849C", Offset = "0xC1849C", VA = "0xC1849C")]
	public AltUnitySwipe(SocketSettings socketSettings, AltUnityVector2 start, AltUnityVector2 end, float duration)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xC18570", Offset = "0xC18570", VA = "0xC18570")]
	public void Execute()
	{
	}
}
