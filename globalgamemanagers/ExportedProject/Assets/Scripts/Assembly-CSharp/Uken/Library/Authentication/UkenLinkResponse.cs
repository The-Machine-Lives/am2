using Il2CppDummyDll;

namespace Uken.Library.Authentication
{
	[Token(Token = "0x200048A")]
	public class UkenLinkResponse
	{
		[Token(Token = "0x40014BB")]
		[FieldOffset(Offset = "0x10")]
		public string result;

		[Token(Token = "0x40014BC")]
		[FieldOffset(Offset = "0x18")]
		public string reason;

		[Token(Token = "0x6002156")]
		[Address(RVA = "0xAFC590", Offset = "0xAFC590", VA = "0xAFC590")]
		public UkenLinkResponse()
		{
		}
	}
}
