using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000036")]
public class AltUnityGetAllProperties : AltBaseCommand
{
	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityComponent altUnityComponent;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x48")]
	private AltUnityObject altUnityObject;

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xADFB88", Offset = "0xADFB88", VA = "0xADFB88")]
	public AltUnityGetAllProperties(SocketSettings socketSettings, AltUnityComponent altUnityComponent, AltUnityObject altUnityObject)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xADFC48", Offset = "0xADFC48", VA = "0xADFC48")]
	public List<AltUnityProperty> Execute()
	{
		return null;
	}
}
