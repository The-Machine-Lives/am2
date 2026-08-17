using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;

[Token(Token = "0x200002E")]
public class AltUnityTiltAndWait : AltBaseCommand
{
	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityVector3 acceleration;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x44")]
	private float duration;

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xC1A3D8", Offset = "0xC1A3D8", VA = "0xC1A3D8")]
	public AltUnityTiltAndWait(SocketSettings socketSettings, AltUnityVector3 acceleration, float duration)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xC1A49C", Offset = "0xC1A49C", VA = "0xC1A49C")]
	public void Execute()
	{
	}
}
