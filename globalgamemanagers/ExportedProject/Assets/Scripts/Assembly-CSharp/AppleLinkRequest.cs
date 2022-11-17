using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001F3")]
public class AppleLinkRequest : AppleCredentialRequest
{
	[Token(Token = "0x4000B36")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool force;

	[Token(Token = "0x6000D3B")]
	[Address(RVA = "0xC1DC7C", Offset = "0xC1DC7C", VA = "0xC1DC7C")]
	public AppleLinkRequest(string inIdentityToken, bool inForce)
	{
	}
}
