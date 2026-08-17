using Il2CppDummyDll;

[Token(Token = "0x2000056")]
public class AltUnityWaitForCurrentSceneToBe : AltBaseCommand
{
	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x38")]
	private string sceneName;

	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x40")]
	private double timeout;

	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x48")]
	private double interval;

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xC1A6EC", Offset = "0xC1A6EC", VA = "0xC1A6EC")]
	public AltUnityWaitForCurrentSceneToBe(SocketSettings socketSettings, string sceneName, double timeout, double interval)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xC1A7A4", Offset = "0xC1A7A4", VA = "0xC1A7A4")]
	public string Execute()
	{
		return null;
	}
}
