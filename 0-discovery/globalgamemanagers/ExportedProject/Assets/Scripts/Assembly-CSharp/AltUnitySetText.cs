using Il2CppDummyDll;

[Token(Token = "0x200003E")]
public class AltUnitySetText : AltUnityCommandReturningAltElement
{
	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityObject altUnityObject;

	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x40")]
	private string newText;

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xC17CA8", Offset = "0xC17CA8", VA = "0xC17CA8")]
	public AltUnitySetText(SocketSettings socketSettings, AltUnityObject altUnityObject, string text)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xC17CFC", Offset = "0xC17CFC", VA = "0xC17CFC")]
	public AltUnityObject Execute()
	{
		return null;
	}
}
