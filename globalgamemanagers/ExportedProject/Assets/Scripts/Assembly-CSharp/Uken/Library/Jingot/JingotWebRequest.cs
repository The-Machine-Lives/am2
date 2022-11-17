using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.Jingot
{
	[Token(Token = "0x2000428")]
	public class JingotWebRequest : WebRequest
	{
		[Token(Token = "0x400134A")]
		private const string mc_sFiltersParam = "filter_criteria";

		[Token(Token = "0x6001F24")]
		[Address(RVA = "0xBA82D4", Offset = "0xBA82D4", VA = "0xBA82D4")]
		public JingotWebRequest(string endpoint, Dictionary<string, string> filterCriteria, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
