using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000042")]
public class AltUnityFindElements : AltUnityCommandReturningAltElement
{
	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x38")]
	private string name;

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x40")]
	private string cameraName;

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x48")]
	private bool enabled;

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xADCE40", Offset = "0xADCE40", VA = "0xADCE40")]
	public AltUnityFindElements(SocketSettings socketSettings, string name, string cameraName, bool enabled)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xADCE9C", Offset = "0xADCE9C", VA = "0xADCE9C")]
	public List<AltUnityObject> Execute()
	{
		return null;
	}
}
