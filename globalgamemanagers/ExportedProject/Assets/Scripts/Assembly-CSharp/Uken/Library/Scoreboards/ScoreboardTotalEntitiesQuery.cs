using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.Scoreboards
{
	[Token(Token = "0x20003F9")]
	public class ScoreboardTotalEntitiesQuery : WebRequest
	{
		[Token(Token = "0x6001E57")]
		[Address(RVA = "0xB3B25C", Offset = "0xB3B25C", VA = "0xB3B25C")]
		public ScoreboardTotalEntitiesQuery(string url, List<string> scoreboardNames, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
