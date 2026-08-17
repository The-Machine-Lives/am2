using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001ED")]
public class GuestCredentialRequest
{
	[Token(Token = "0x4000B2F")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string credential;

	[Token(Token = "0x6000D35")]
	[Address(RVA = "0x986298", Offset = "0x986298", VA = "0x986298")]
	public GuestCredentialRequest(string inCredential)
	{
	}
}
