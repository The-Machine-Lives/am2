using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.IAP
{
	[Token(Token = "0x2000436")]
	public class UnclaimedPurchaseRequest : WebRequest
	{
		[Token(Token = "0x6001F54")]
		[Address(RVA = "0xB96584", Offset = "0xB96584", VA = "0xB96584")]
		public UnclaimedPurchaseRequest(string endpoint, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
