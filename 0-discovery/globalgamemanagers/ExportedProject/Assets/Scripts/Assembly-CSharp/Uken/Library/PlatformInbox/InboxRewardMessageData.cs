using Il2CppDummyDll;

namespace Uken.Library.PlatformInbox
{
	[Token(Token = "0x20003FF")]
	public class InboxRewardMessageData
	{
		[Token(Token = "0x40012B7")]
		[FieldOffset(Offset = "0x0")]
		public static string dataType;

		[Token(Token = "0x40012B8")]
		[FieldOffset(Offset = "0x10")]
		public long qty;

		[Token(Token = "0x40012B9")]
		[FieldOffset(Offset = "0x18")]
		public string item;

		[Token(Token = "0x40012BA")]
		[FieldOffset(Offset = "0x20")]
		public string src;

		[Token(Token = "0x6001E81")]
		[Address(RVA = "0xB2FD70", Offset = "0xB2FD70", VA = "0xB2FD70")]
		public InboxRewardMessageData()
		{
		}
	}
}
