using Il2CppDummyDll;

[Token(Token = "0x2000029")]
public class AltUnityScrollMouseAndWait : AltBaseCommand
{
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x38")]
	private float speed;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x3C")]
	private float duration;

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xC16B1C", Offset = "0xC16B1C", VA = "0xC16B1C")]
	public AltUnityScrollMouseAndWait(SocketSettings socketSettings, float speed, float duration)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xC16BCC", Offset = "0xC16BCC", VA = "0xC16BCC")]
	public void Execute()
	{
	}
}
