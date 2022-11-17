using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001F2")]
public class AppleCredentialRequest
{
	[Token(Token = "0x4000B35")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string identity_token;

	[Token(Token = "0x6000D3A")]
	[Address(RVA = "0xC1DC50", Offset = "0xC1DC50", VA = "0xC1DC50")]
	public AppleCredentialRequest(string inIdentityToken)
	{
	}
}
