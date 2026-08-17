using Il2CppDummyDll;

[Token(Token = "0x200002C")]
public class AltUnityTapScreen : AltBaseCommand
{
	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x38")]
	private float x;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x3C")]
	private float y;

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xC19130", Offset = "0xC19130", VA = "0xC19130")]
	public AltUnityTapScreen(SocketSettings socketSettings, float x, float y)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xC191E0", Offset = "0xC191E0", VA = "0xC191E0")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
