using Il2CppDummyDll;

namespace Uken.Library.Authentication
{
	[Token(Token = "0x200048C")]
	public class UkenUnlinkResponse
	{
		[Token(Token = "0x40014C1")]
		[FieldOffset(Offset = "0x10")]
		public string message;

		[Token(Token = "0x40014C2")]
		[FieldOffset(Offset = "0x18")]
		public long timestamp;

		[Token(Token = "0x40014C3")]
		[FieldOffset(Offset = "0x20")]
		public int status;

		[Token(Token = "0x6002157")]
		[Address(RVA = "0xAFC598", Offset = "0xAFC598", VA = "0xAFC598")]
		public UkenUnlinkResponse()
		{
		}
	}
}
