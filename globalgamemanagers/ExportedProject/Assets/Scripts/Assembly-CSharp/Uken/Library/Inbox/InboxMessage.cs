using Il2CppDummyDll;
using Uken.Library.Inbox.Internal;

namespace Uken.Library.Inbox
{
	[Token(Token = "0x200042B")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x81FA98", Offset = "0x81FA98")]
	public class InboxMessage
	{
		[Token(Token = "0x4001351")]
		[FieldOffset(Offset = "0x10")]
		protected InboxMessageData msgData;

		[Token(Token = "0x170005A3")]
		public string id
		{
			[Token(Token = "0x6001F36")]
			[Address(RVA = "0xB9B2C0", Offset = "0xB9B2C0", VA = "0xB9B2C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A4")]
		public string from
		{
			[Token(Token = "0x6001F37")]
			[Address(RVA = "0xB9B2EC", Offset = "0xB9B2EC", VA = "0xB9B2EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A5")]
		public string to
		{
			[Token(Token = "0x6001F38")]
			[Address(RVA = "0xB9B318", Offset = "0xB9B318", VA = "0xB9B318")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A6")]
		public string subject
		{
			[Token(Token = "0x6001F39")]
			[Address(RVA = "0xB9B344", Offset = "0xB9B344", VA = "0xB9B344")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A7")]
		public string message
		{
			[Token(Token = "0x6001F3A")]
			[Address(RVA = "0xB9B370", Offset = "0xB9B370", VA = "0xB9B370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A8")]
		public string senderName
		{
			[Token(Token = "0x6001F3B")]
			[Address(RVA = "0xB9B39C", Offset = "0xB9B39C", VA = "0xB9B39C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A9")]
		public string msgType
		{
			[Token(Token = "0x6001F3C")]
			[Address(RVA = "0xB9B3C8", Offset = "0xB9B3C8", VA = "0xB9B3C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005AA")]
		public string data
		{
			[Token(Token = "0x6001F3D")]
			[Address(RVA = "0xB9B3F4", Offset = "0xB9B3F4", VA = "0xB9B3F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005AB")]
		public int expiration
		{
			[Token(Token = "0x6001F3E")]
			[Address(RVA = "0xB9B420", Offset = "0xB9B420", VA = "0xB9B420")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170005AC")]
		public bool isRead
		{
			[Token(Token = "0x6001F3F")]
			[Address(RVA = "0xB9B44C", Offset = "0xB9B44C", VA = "0xB9B44C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170005AD")]
		public bool isSeen
		{
			[Token(Token = "0x6001F40")]
			[Address(RVA = "0xB9B478", Offset = "0xB9B478", VA = "0xB9B478")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001F41")]
		[Address(RVA = "0xB9B4A4", Offset = "0xB9B4A4", VA = "0xB9B4A4")]
		public InboxMessage()
		{
		}

		[Token(Token = "0x6001F42")]
		[Address(RVA = "0xB9B4AC", Offset = "0xB9B4AC", VA = "0xB9B4AC")]
		public void SetMessageData(string from, string to, string subject, string message, string senderName, string type, string data)
		{
		}

		[Token(Token = "0x6001F43")]
		[Address(RVA = "0xB9B5F8", Offset = "0xB9B5F8", VA = "0xB9B5F8")]
		public void SetMessageData(InboxMessageData srcData)
		{
		}

		[Token(Token = "0x6001F44")]
		[Address(RVA = "0xB9B774", Offset = "0xB9B774", VA = "0xB9B774")]
		public InboxMessage(InboxMessageData dataSource)
		{
		}

		[Token(Token = "0x6001F45")]
		[Address(RVA = "0xB9B7A0", Offset = "0xB9B7A0", VA = "0xB9B7A0")]
		public InboxMessageData GetDataSource()
		{
			return null;
		}
	}
}
