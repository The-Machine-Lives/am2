using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.PlatformInbox.Internal
{
	[Token(Token = "0x2000406")]
	public class UserInboxResponse : PlatformInboxResponse
	{
		[Token(Token = "0x20007CE")]
		public class UserMessageResponse
		{
			[Token(Token = "0x200089B")]
			public class UserFrom
			{
				[Token(Token = "0x4002489")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				[Token(Token = "0x400248A")]
				[FieldOffset(Offset = "0x18")]
				public string user_id;

				[Token(Token = "0x60033F8")]
				[Address(RVA = "0xB302DC", Offset = "0xB302DC", VA = "0xB302DC")]
				public UserFrom()
				{
				}
			}

			[Token(Token = "0x200089C")]
			public class ItemAttrs
			{
				[Token(Token = "0x400248B")]
				[FieldOffset(Offset = "0x10")]
				public string type;

				[Token(Token = "0x400248C")]
				[FieldOffset(Offset = "0x18")]
				public string title;

				[Token(Token = "0x400248D")]
				[FieldOffset(Offset = "0x20")]
				public string notes;

				[Token(Token = "0x400248E")]
				[FieldOffset(Offset = "0x28")]
				public string body;

				[Token(Token = "0x400248F")]
				[FieldOffset(Offset = "0x30")]
				public string itemReference;

				[Token(Token = "0x4002490")]
				[FieldOffset(Offset = "0x38")]
				public int amount;

				[Token(Token = "0x4002491")]
				[FieldOffset(Offset = "0x40")]
				public string source;

				[Token(Token = "0x60033F9")]
				[Address(RVA = "0xB302D4", Offset = "0xB302D4", VA = "0xB302D4")]
				public ItemAttrs()
				{
				}
			}

			[Token(Token = "0x40022BE")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			[Token(Token = "0x40022BF")]
			[FieldOffset(Offset = "0x18")]
			public UserFrom user_from;

			[Token(Token = "0x40022C0")]
			[FieldOffset(Offset = "0x20")]
			public string subject;

			[Token(Token = "0x40022C1")]
			[FieldOffset(Offset = "0x28")]
			public string type;

			[Token(Token = "0x40022C2")]
			[FieldOffset(Offset = "0x30")]
			public ItemAttrs item_attrs;

			[Token(Token = "0x40022C3")]
			[FieldOffset(Offset = "0x38")]
			public bool read;

			[Token(Token = "0x40022C4")]
			[FieldOffset(Offset = "0x3C")]
			public int ttl;

			[Token(Token = "0x40022C5")]
			[FieldOffset(Offset = "0x40")]
			public string created_at;

			[Token(Token = "0x40022C6")]
			[FieldOffset(Offset = "0x48")]
			public string expires_at;

			[Token(Token = "0x6003222")]
			[Address(RVA = "0xB302CC", Offset = "0xB302CC", VA = "0xB302CC")]
			public UserMessageResponse()
			{
			}
		}

		[Token(Token = "0x40012CB")]
		[FieldOffset(Offset = "0x20")]
		public List<UserMessageResponse> messages;

		[Token(Token = "0x40012CC")]
		[FieldOffset(Offset = "0x28")]
		public string user_id;

		[Token(Token = "0x6001E9B")]
		[Address(RVA = "0xB302C4", Offset = "0xB302C4", VA = "0xB302C4")]
		public UserInboxResponse()
		{
		}
	}
}
