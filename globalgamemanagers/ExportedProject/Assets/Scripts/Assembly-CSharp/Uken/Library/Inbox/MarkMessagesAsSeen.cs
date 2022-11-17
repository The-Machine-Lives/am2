using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.Inbox
{
	[Token(Token = "0x200042E")]
	public class MarkMessagesAsSeen : WebRequest
	{
		[Token(Token = "0x6001F48")]
		[Address(RVA = "0xB9A5B8", Offset = "0xB9A5B8", VA = "0xB9A5B8")]
		public MarkMessagesAsSeen(string userID, List<string> messageIds, string endpoint, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
