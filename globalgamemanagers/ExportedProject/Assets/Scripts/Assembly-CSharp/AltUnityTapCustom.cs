using Il2CppDummyDll;

[Token(Token = "0x200002B")]
public class AltUnityTapCustom : AltBaseCommand
{
	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x38")]
	private float x;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x3C")]
	private float y;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x40")]
	private int count;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x44")]
	private float interval;

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xC18DC8", Offset = "0xC18DC8", VA = "0xC18DC8")]
	public AltUnityTapCustom(SocketSettings socketSettings, float x, float y, int count, float interval)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xC18E90", Offset = "0xC18E90", VA = "0xC18E90")]
	public void Execute()
	{
	}
}
