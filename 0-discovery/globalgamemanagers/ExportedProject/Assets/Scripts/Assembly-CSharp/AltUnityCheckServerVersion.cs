using Il2CppDummyDll;

[Token(Token = "0x2000012")]
public class AltUnityCheckServerVersion : AltBaseCommand
{
	[Token(Token = "0x6000073")]
	[Address(RVA = "0xAD64EC", Offset = "0xAD64EC", VA = "0xAD64EC")]
	public AltUnityCheckServerVersion(SocketSettings socketSettings)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xAD6594", Offset = "0xAD6594", VA = "0xAD6594")]
	public string Execute()
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xAD67B0", Offset = "0xAD67B0", VA = "0xAD67B0")]
	public void WriteWarning(bool isEarlier, string serverVersion = "")
	{
	}
}
