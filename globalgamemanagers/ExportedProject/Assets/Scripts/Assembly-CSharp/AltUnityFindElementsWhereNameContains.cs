using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000044")]
public class AltUnityFindElementsWhereNameContains : AltUnityCommandReturningAltElement
{
	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x38")]
	private string name;

	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x40")]
	private string cameraName;

	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x48")]
	private bool enabled;

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xADD154", Offset = "0xADD154", VA = "0xADD154")]
	public AltUnityFindElementsWhereNameContains(SocketSettings socketSettings, string name, string cameraName, bool enabled)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xADD1B0", Offset = "0xADD1B0", VA = "0xADD1B0")]
	public List<AltUnityObject> Execute()
	{
		return null;
	}
}
