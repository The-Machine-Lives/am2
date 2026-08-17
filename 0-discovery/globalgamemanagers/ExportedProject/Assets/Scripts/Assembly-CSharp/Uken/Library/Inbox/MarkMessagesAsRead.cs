using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.Inbox
{
	[Token(Token = "0x200042D")]
	public class MarkMessagesAsRead : WebRequest
	{
		[Token(Token = "0x6001F47")]
		[Address(RVA = "0xB9A2B0", Offset = "0xB9A2B0", VA = "0xB9A2B0")]
		public MarkMessagesAsRead(string userID, List<string> messageIds, string endpoint, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
