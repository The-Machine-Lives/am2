using Il2CppDummyDll;

namespace Uken.Library.Inbox.Internal
{
	[Token(Token = "0x2000431")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x81FAD0", Offset = "0x81FAD0")]
	public class InboxMessageData
	{
		[Token(Token = "0x4001353")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4001354")]
		[FieldOffset(Offset = "0x18")]
		public string from;

		[Token(Token = "0x4001355")]
		[FieldOffset(Offset = "0x20")]
		public string to;

		[Token(Token = "0x4001356")]
		[FieldOffset(Offset = "0x28")]
		public string subject;

		[Token(Token = "0x4001357")]
		[FieldOffset(Offset = "0x30")]
		public string message;

		[Token(Token = "0x4001358")]
		[FieldOffset(Offset = "0x38")]
		public string senderName;

		[Token(Token = "0x4001359")]
		[FieldOffset(Offset = "0x40")]
		public string msgType;

		[Token(Token = "0x400135A")]
		[FieldOffset(Offset = "0x48")]
		public string data;

		[Token(Token = "0x400135B")]
		[FieldOffset(Offset = "0x50")]
		public int expiration;

		[Token(Token = "0x400135C")]
		[FieldOffset(Offset = "0x54")]
		public bool isRead;

		[Token(Token = "0x400135D")]
		[FieldOffset(Offset = "0x55")]
		public bool isSeen;

		[Token(Token = "0x6001F4B")]
		[Address(RVA = "0xB99F44", Offset = "0xB99F44", VA = "0xB99F44")]
		public InboxMessageData()
		{
		}
	}
}
