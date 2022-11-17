using Il2CppDummyDll;

[Token(Token = "0x2000015")]
public class AltUnityGetPNGScreenshot : AltBaseCommand
{
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x38")]
	private string path;

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xADEFA8", Offset = "0xADEFA8", VA = "0xADEFA8")]
	public AltUnityGetPNGScreenshot(SocketSettings socketSettings, string path)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xADF054", Offset = "0xADF054", VA = "0xADF054")]
	public void Execute()
	{
	}
}
