using Il2CppDummyDll;

[Token(Token = "0x2000054")]
public class AltUnitySetKeyPLayerPref : AltBaseCommand
{
	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x38")]
	private string keyName;

	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x40")]
	private int intValue;

	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x44")]
	private float floatValue;

	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x48")]
	private string stringValue;

	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x50")]
	private int option;

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xC171D0", Offset = "0xC171D0", VA = "0xC171D0")]
	public AltUnitySetKeyPLayerPref(SocketSettings socketSettings, string keyName, int intValue)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xC1728C", Offset = "0xC1728C", VA = "0xC1728C")]
	public AltUnitySetKeyPLayerPref(SocketSettings socketSettings, string keyName, float floatValue)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xC17348", Offset = "0xC17348", VA = "0xC17348")]
	public AltUnitySetKeyPLayerPref(SocketSettings socketSettings, string keyName, string stringValue)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xC17404", Offset = "0xC17404", VA = "0xC17404")]
	public void Execute()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xC179C8", Offset = "0xC179C8", VA = "0xC179C8")]
	private void SetStringKey()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xC17430", Offset = "0xC17430", VA = "0xC17430")]
	private void SetIntKey()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xC176FC", Offset = "0xC176FC", VA = "0xC176FC")]
	private void SetFloatKey()
	{
	}
}
