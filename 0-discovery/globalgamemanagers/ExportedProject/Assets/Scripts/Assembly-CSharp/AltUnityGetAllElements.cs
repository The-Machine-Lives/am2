using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200001E")]
public class AltUnityGetAllElements : AltUnityBaseFindObjects
{
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x38")]
	private By cameraBy;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x40")]
	private string cameraPath;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x48")]
	private bool enabled;

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xADC610", Offset = "0xADC610", VA = "0xADC610")]
	public AltUnityGetAllElements(SocketSettings socketSettings, By cameraBy, string cameraPath, bool enabled)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xADC670", Offset = "0xADC670", VA = "0xADC670")]
	public List<AltUnityObject> Execute()
	{
		return null;
	}
}
