using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000043")]
public class AltUnityFindElementsByComponent : AltUnityCommandReturningAltElement
{
	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x38")]
	private string componentName;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x40")]
	private string assemblyName;

	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x48")]
	private string cameraName;

	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x50")]
	private bool enabled;

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xADE310", Offset = "0xADE310", VA = "0xADE310")]
	public AltUnityFindElementsByComponent(SocketSettings socketSettings, string componentName, string assemblyName, string cameraName, bool enabled)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xADE37C", Offset = "0xADE37C", VA = "0xADE37C")]
	public List<AltUnityObject> Execute()
	{
		return null;
	}
}
