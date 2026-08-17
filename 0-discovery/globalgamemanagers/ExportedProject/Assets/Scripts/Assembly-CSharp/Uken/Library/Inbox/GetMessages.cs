using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.Inbox
{
	[Token(Token = "0x200042C")]
	public class GetMessages : WebRequest
	{
		[Token(Token = "0x6001F46")]
		[Address(RVA = "0xB99370", Offset = "0xB99370", VA = "0xB99370")]
		public GetMessages(string userID, string endpoint, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
