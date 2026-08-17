using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001F1")]
public class GooglePlayLinkRequest : GooglePlayCredentialRequest
{
	[Token(Token = "0x4000B34")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool force;

	[Token(Token = "0x6000D39")]
	[Address(RVA = "0x984ED4", Offset = "0x984ED4", VA = "0x984ED4")]
	public GooglePlayLinkRequest(string inAuthCode, bool inForce)
	{
	}
}
