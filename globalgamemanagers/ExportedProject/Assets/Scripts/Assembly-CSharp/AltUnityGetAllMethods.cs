using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000035")]
public class AltUnityGetAllMethods : AltBaseCommand
{
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityComponent altUnityComponent;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x48")]
	private AltUnityObject altUnityObject;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x50")]
	private AltUnityMethodSelection methodSelection;

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xADF7A0", Offset = "0xADF7A0", VA = "0xADF7A0")]
	public AltUnityGetAllMethods(SocketSettings socketSettings, AltUnityComponent altUnityComponent, AltUnityObject altUnityObject, AltUnityMethodSelection methodSelection = AltUnityMethodSelection.ALLMETHODS)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xADF870", Offset = "0xADF870", VA = "0xADF870")]
	public List<string> Execute()
	{
		return null;
	}
}
