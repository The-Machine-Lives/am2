using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.LeagueService
{
	[Token(Token = "0x200041C")]
	public class LeagueServiceGetLeagueRequest : WebRequest
	{
		[Token(Token = "0x6001F11")]
		[Address(RVA = "0xBAA8F0", Offset = "0xBAA8F0", VA = "0xBAA8F0")]
		public LeagueServiceGetLeagueRequest(string url, string entityId, string leagueId, int above, int below, int top, bool previous, bool queryOverallRank, bool querySelfTierOnly, bool withEntityData, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
