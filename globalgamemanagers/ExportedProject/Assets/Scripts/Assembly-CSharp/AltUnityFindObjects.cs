using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200001B")]
public class AltUnityFindObjects : AltUnityBaseFindObjects
{
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x38")]
	private By by;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x40")]
	private string value;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x48")]
	private By cameraBy;

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x50")]
	private string cameraPath;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x58")]
	private bool enabled;

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xAD89AC", Offset = "0xAD89AC", VA = "0xAD89AC")]
	public AltUnityFindObjects(SocketSettings socketSettings, By by, string value, By cameraBy, string cameraPath, bool enabled)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xAD8A24", Offset = "0xAD8A24", VA = "0xAD8A24")]
	public List<AltUnityObject> Execute()
	{
		return null;
	}
}
