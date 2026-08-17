using Il2CppDummyDll;

[Token(Token = "0x200004A")]
public class AltUnityDeleteKeyPlayerPref : AltBaseCommand
{
	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x38")]
	private string keyName;

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xAD7484", Offset = "0xAD7484", VA = "0xAD7484")]
	public AltUnityDeleteKeyPlayerPref(SocketSettings socketSettings, string keyname)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xAD7530", Offset = "0xAD7530", VA = "0xAD7530")]
	public void Execute()
	{
	}
}
