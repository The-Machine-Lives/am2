using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000013")]
public class AltUnityCommandReturningAltElement : AltBaseCommand
{
	[Token(Token = "0x6000076")]
	[Address(RVA = "0xAD5B7C", Offset = "0xAD5B7C", VA = "0xAD5B7C")]
	public AltUnityCommandReturningAltElement(SocketSettings socketSettings)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xAD6AC0", Offset = "0xAD6AC0", VA = "0xAD6AC0")]
	protected AltUnityObject ReceiveAltUnityObject()
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xAD72A0", Offset = "0xAD72A0", VA = "0xAD72A0")]
	protected List<AltUnityObject> ReceiveListOfAltUnityObjects()
	{
		return null;
	}
}
