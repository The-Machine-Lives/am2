using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x20001E6")]
public class UkenLinkResponse
{
	[Token(Token = "0x4000B29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly string Credential;

	[Token(Token = "0x4000B2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly LinkStatus Status;

	[Token(Token = "0x6000CFF")]
	[Address(RVA = "0xB49BB4", Offset = "0xB49BB4", VA = "0xB49BB4")]
	public UkenLinkResponse(LinkStatus linkStatus, [Optional] string credential)
	{
	}

	[Token(Token = "0x6000D00")]
	[Address(RVA = "0xB49BF0", Offset = "0xB49BF0", VA = "0xB49BF0")]
	public static UkenLinkResponse ParseResponse(bool success, string response, bool getCredential)
	{
		return null;
	}
}
