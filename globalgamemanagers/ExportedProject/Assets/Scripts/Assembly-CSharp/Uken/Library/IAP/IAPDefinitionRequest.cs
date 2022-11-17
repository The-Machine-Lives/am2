using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.IAP
{
	[Token(Token = "0x2000437")]
	public class IAPDefinitionRequest : WebRequest
	{
		[Token(Token = "0x6001F55")]
		[Address(RVA = "0xAFC5A0", Offset = "0xAFC5A0", VA = "0xAFC5A0")]
		public IAPDefinitionRequest(string endpoint, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
