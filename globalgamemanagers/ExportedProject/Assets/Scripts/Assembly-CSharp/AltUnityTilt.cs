using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;

[Token(Token = "0x200002D")]
public class AltUnityTilt : AltBaseCommand
{
	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityVector3 acceleration;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x44")]
	private float duration;

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xC1A04C", Offset = "0xC1A04C", VA = "0xC1A04C")]
	public AltUnityTilt(SocketSettings socketSettings, AltUnityVector3 acceleration, float duration)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xC1A110", Offset = "0xC1A110", VA = "0xC1A110")]
	public void Execute()
	{
	}
}
