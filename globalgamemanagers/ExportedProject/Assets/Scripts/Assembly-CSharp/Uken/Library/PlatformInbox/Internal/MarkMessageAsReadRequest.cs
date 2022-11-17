using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.PlatformInbox.Internal
{
	[Token(Token = "0x2000403")]
	public class MarkMessageAsReadRequest : WebRequest
	{
		[Token(Token = "0x6001E97")]
		[Address(RVA = "0xB2FEBC", Offset = "0xB2FEBC", VA = "0xB2FEBC")]
		public MarkMessageAsReadRequest(string messageID, string endpoint, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
