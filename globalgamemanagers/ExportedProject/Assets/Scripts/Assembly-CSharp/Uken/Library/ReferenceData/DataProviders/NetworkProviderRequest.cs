using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.ReferenceData.DataProviders
{
	[Token(Token = "0x2000484")]
	public class NetworkProviderRequest : WebRequest
	{
		[Token(Token = "0x6002136")]
		[Address(RVA = "0xB35AB8", Offset = "0xB35AB8", VA = "0xB35AB8")]
		public NetworkProviderRequest(string url, List<string> depots, Dictionary<string, string> alt_value_drivers, Action<WebResponse, WebRequest> onComplete)
		{
		}

		[Token(Token = "0x6002137")]
		[Address(RVA = "0xB35FCC", Offset = "0xB35FCC", VA = "0xB35FCC")]
		public string GetRequestID()
		{
			return null;
		}
	}
}
