using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001F0")]
public class GooglePlayCredentialRequest
{
	[Token(Token = "0x4000B33")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string auth_code;

	[Token(Token = "0x6000D38")]
	[Address(RVA = "0x9D7E40", Offset = "0x9D7E40", VA = "0x9D7E40")]
	public GooglePlayCredentialRequest(string inAuthCode)
	{
	}
}
