using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.ReferenceData.DataProviders
{
	[Token(Token = "0x2000483")]
	public class ChecksumRequest : WebRequest
	{
		[Token(Token = "0x6002135")]
		[Address(RVA = "0xB34E50", Offset = "0xB34E50", VA = "0xB34E50")]
		public ChecksumRequest(string url, List<string> depots, Dictionary<string, string> alt_value_drivers, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
