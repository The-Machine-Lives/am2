using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.Inbox
{
	[Token(Token = "0x200042F")]
	public class PostMessage : WebRequest
	{
		[Token(Token = "0x6001F49")]
		[Address(RVA = "0xB99D40", Offset = "0xB99D40", VA = "0xB99D40")]
		public PostMessage(string fromEntityID, string senderName, List<string> toEntityIDs, string subject, string message, string msgType, string data, string endpoint, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
