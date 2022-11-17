using Il2CppDummyDll;

[Token(Token = "0x2000028")]
public class AltUnityScrollMouse : AltBaseCommand
{
	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x38")]
	private float speed;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x3C")]
	private float duration;

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xC16834", Offset = "0xC16834", VA = "0xC16834")]
	public AltUnityScrollMouse(SocketSettings socketSettings, float speed, float duration)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xC168E4", Offset = "0xC168E4", VA = "0xC168E4")]
	public void Execute()
	{
	}
}
