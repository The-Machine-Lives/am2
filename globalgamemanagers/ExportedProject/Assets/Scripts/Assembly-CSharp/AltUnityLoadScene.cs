using Il2CppDummyDll;

[Token(Token = "0x2000053")]
public class AltUnityLoadScene : AltBaseCommand
{
	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x38")]
	private string sceneName;

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xAD8648", Offset = "0xAD8648", VA = "0xAD8648")]
	public AltUnityLoadScene(SocketSettings socketSettings, string sceneName)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xAD86F4", Offset = "0xAD86F4", VA = "0xAD86F4")]
	public void Execute()
	{
	}
}
