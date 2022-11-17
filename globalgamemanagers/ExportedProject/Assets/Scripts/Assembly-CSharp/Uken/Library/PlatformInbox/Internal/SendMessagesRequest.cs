using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.PlatformInbox.Internal
{
	[Token(Token = "0x2000402")]
	public class SendMessagesRequest : WebRequest
	{
		[Token(Token = "0x6001E96")]
		[Address(RVA = "0xB3009C", Offset = "0xB3009C", VA = "0xB3009C")]
		public SendMessagesRequest(List<string> userIdsTo, string sender_name, string type, string message, string subject, string itemType, string data, string endpoint, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
