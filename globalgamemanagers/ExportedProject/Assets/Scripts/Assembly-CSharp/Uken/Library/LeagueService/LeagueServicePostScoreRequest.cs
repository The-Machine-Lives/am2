using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.LeagueService
{
	[Token(Token = "0x2000422")]
	public class LeagueServicePostScoreRequest : WebRequest
	{
		[Token(Token = "0x6001F17")]
		[Address(RVA = "0xBAADB4", Offset = "0xBAADB4", VA = "0xBAADB4")]
		public LeagueServicePostScoreRequest(string url, string entityId, string entityData, int score, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
