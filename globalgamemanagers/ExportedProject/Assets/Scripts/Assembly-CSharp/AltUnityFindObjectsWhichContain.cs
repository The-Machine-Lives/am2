using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200001C")]
public class AltUnityFindObjectsWhichContain : AltUnityBaseFindObjects
{
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x38")]
	private By by;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x40")]
	private string value;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x48")]
	private By cameraBy;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x50")]
	private string cameraPath;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x58")]
	private bool enabled;

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xAD8E80", Offset = "0xAD8E80", VA = "0xAD8E80")]
	public AltUnityFindObjectsWhichContain(SocketSettings socketSettings, By by, string value, By cameraBy, string cameraPath, bool enabled)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xAD8EF8", Offset = "0xAD8EF8", VA = "0xAD8EF8")]
	public List<AltUnityObject> Execute()
	{
		return null;
	}
}
