using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200054C")]
	public class PurchaseFinalizeRequest : WebRequest
	{
		[Token(Token = "0x4001942")]
		[FieldOffset(Offset = "0x38")]
		public string transactionID;

		[Token(Token = "0x600289F")]
		[Address(RVA = "0xA795D4", Offset = "0xA795D4", VA = "0xA795D4")]
		public PurchaseFinalizeRequest(string endpoint, Action<WebResponse, WebRequest> onComplete, string transactionID)
		{
		}
	}
}
