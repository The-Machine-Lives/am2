using Il2CppDummyDll;

[Token(Token = "0x2000045")]
public class AltUnityFindElementWhereNameContains : AltUnityCommandReturningAltElement
{
	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x38")]
	private string name;

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x40")]
	private string cameraName;

	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x48")]
	private bool enabled;

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xADC300", Offset = "0xADC300", VA = "0xADC300")]
	public AltUnityFindElementWhereNameContains(SocketSettings socketSettings, string name, string cameraName, bool enabled)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xADC35C", Offset = "0xADC35C", VA = "0xADC35C")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
