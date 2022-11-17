using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.LeagueService
{
	[Token(Token = "0x2000420")]
	public class LeagueServiceGetTierRequest : WebRequest
	{
		[Token(Token = "0x6001F15")]
		[Address(RVA = "0xBA9780", Offset = "0xBA9780", VA = "0xBA9780")]
		public LeagueServiceGetTierRequest(string url, string entityId, string leagueId, int tierIndex, int above, int below, int top, bool previous, bool queryOverallRank, bool topQueryForSelfTierOnly, bool withEntityData, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
