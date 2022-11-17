using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.Jingot
{
	[Token(Token = "0x2000427")]
	public class JingotRunningTestsRequest : WebRequest
	{
		[Token(Token = "0x6001F23")]
		[Address(RVA = "0xBA9440", Offset = "0xBA9440", VA = "0xBA9440")]
		public JingotRunningTestsRequest(string endpoint, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
