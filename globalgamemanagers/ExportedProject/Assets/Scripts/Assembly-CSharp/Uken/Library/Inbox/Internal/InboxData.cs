using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Inbox.Internal
{
	[Token(Token = "0x2000430")]
	public class InboxData
	{
		[Token(Token = "0x4001352")]
		[FieldOffset(Offset = "0x10")]
		public List<InboxMessageData> messages;

		[Token(Token = "0x6001F4A")]
		[Address(RVA = "0xB9B7A8", Offset = "0xB9B7A8", VA = "0xB9B7A8")]
		public InboxData()
		{
		}
	}
}
