using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001EE")]
public class GuestUnlinkRequest
{
	[Token(Token = "0x4000B30")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string credential;

	[Token(Token = "0x4000B31")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string user_id;

	[Token(Token = "0x6000D36")]
	[Address(RVA = "0x9862C4", Offset = "0x9862C4", VA = "0x9862C4")]
	public GuestUnlinkRequest(string inCredential, string inUserID)
	{
	}
}
