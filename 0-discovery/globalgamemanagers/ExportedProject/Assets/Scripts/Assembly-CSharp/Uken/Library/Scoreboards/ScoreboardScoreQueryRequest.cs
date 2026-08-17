using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.Scoreboards
{
	[Token(Token = "0x20003F7")]
	public class ScoreboardScoreQueryRequest : WebRequest
	{
		[Token(Token = "0x6001E55")]
		[Address(RVA = "0xB3A918", Offset = "0xB3A918", VA = "0xB3A918")]
		public ScoreboardScoreQueryRequest(string url, List<ScoreboardDefinition> scoreboards, List<string> entityIDs, int top, int above, int below, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
