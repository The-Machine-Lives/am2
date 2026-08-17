using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001EF")]
public class RefreshRequest
{
	[Token(Token = "0x4000B32")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string refresh_token;

	[Token(Token = "0x6000D37")]
	[Address(RVA = "0x9F49C4", Offset = "0x9F49C4", VA = "0x9F49C4")]
	public RefreshRequest(string inRefreshToken)
	{
	}
}
