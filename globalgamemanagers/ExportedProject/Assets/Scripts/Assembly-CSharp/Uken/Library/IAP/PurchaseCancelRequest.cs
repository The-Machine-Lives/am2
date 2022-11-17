using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.IAP
{
	[Token(Token = "0x2000439")]
	public class PurchaseCancelRequest : WebRequest
	{
		[Token(Token = "0x6001F57")]
		[Address(RVA = "0xAFC5A8", Offset = "0xAFC5A8", VA = "0xAFC5A8")]
		public PurchaseCancelRequest(string endpoint, Action<WebResponse, WebRequest> onComplete, List<string> transactionIDs)
		{
		}
	}
}
