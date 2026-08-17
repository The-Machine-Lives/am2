using Il2CppDummyDll;

[Token(Token = "0x2000055")]
public class AltUnitySetTimeScale : AltBaseCommand
{
	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x38")]
	private float timeScale;

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xC17F14", Offset = "0xC17F14", VA = "0xC17F14")]
	public AltUnitySetTimeScale(SocketSettings socketSettings, float timescale)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xC17FC0", Offset = "0xC17FC0", VA = "0xC17FC0")]
	public void Execute()
	{
	}
}
