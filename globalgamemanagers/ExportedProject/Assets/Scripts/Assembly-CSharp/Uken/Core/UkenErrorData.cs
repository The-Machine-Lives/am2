using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003D4")]
	public class UkenErrorData
	{
		[Token(Token = "0x40011FF")]
		[FieldOffset(Offset = "0x10")]
		public int status;

		[Token(Token = "0x4001200")]
		[FieldOffset(Offset = "0x18")]
		public string error;

		[Token(Token = "0x4001201")]
		[FieldOffset(Offset = "0x20")]
		public string message;

		[Token(Token = "0x4001202")]
		[FieldOffset(Offset = "0x28")]
		public string path;

		[Token(Token = "0x4001203")]
		[FieldOffset(Offset = "0x30")]
		public int ukenStatus;

		[Token(Token = "0x4001204")]
		[FieldOffset(Offset = "0x38")]
		public string ukenMessage;

		[Token(Token = "0x6001D97")]
		[Address(RVA = "0xA1BAD0", Offset = "0xA1BAD0", VA = "0xA1BAD0")]
		public UkenErrorData()
		{
		}
	}
}
