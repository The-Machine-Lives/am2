using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000034")]
public class AltUnityGetAllComponents : AltBaseCommand
{
	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityObject AltUnityObject;

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xADF4B4", Offset = "0xADF4B4", VA = "0xADF4B4")]
	public AltUnityGetAllComponents(SocketSettings socketSettings, AltUnityObject altUnityObject)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xADF560", Offset = "0xADF560", VA = "0xADF560")]
	public List<AltUnityComponent> Execute()
	{
		return null;
	}
}
