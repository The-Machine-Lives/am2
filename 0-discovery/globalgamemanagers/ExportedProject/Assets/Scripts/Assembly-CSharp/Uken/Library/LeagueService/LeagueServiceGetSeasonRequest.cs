using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.LeagueService
{
	[Token(Token = "0x200041E")]
	public class LeagueServiceGetSeasonRequest : WebRequest
	{
		[Token(Token = "0x6001F13")]
		[Address(RVA = "0xBAA42C", Offset = "0xBAA42C", VA = "0xBAA42C")]
		public LeagueServiceGetSeasonRequest(string url, string entityId, string leagueId, bool previous, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
