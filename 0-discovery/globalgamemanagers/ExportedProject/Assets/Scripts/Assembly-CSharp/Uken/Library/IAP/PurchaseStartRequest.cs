using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.IAP
{
	[Token(Token = "0x2000438")]
	public class PurchaseStartRequest : WebRequest
	{
		[Token(Token = "0x6001F56")]
		[Address(RVA = "0xAFC648", Offset = "0xAFC648", VA = "0xAFC648")]
		public PurchaseStartRequest(string endpoint, Action<WebResponse, WebRequest> onComplete, UkenPaymentProduct product)
		{
		}
	}
}
