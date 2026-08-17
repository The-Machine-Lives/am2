using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000205")]
public class ScrubUserRequest
{
	[Token(Token = "0x4000B74")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string game_id;

	[Token(Token = "0x4000B75")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string user_id;

	[Token(Token = "0x6000DA5")]
	[Address(RVA = "0x9FEA84", Offset = "0x9FEA84", VA = "0x9FEA84")]
	public ScrubUserRequest(string inGameID, string inUserID)
	{
	}
}
