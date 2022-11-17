using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.PlatformInbox.Internal
{
	[Token(Token = "0x2000401")]
	public class GetMessagesRequest : WebRequest
	{
		[Token(Token = "0x6001E95")]
		[Address(RVA = "0xB2FDD4", Offset = "0xB2FDD4", VA = "0xB2FDD4")]
		public GetMessagesRequest(string endpoint, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
