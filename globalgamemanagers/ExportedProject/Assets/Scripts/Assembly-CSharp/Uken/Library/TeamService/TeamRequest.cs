using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.TeamService
{
	[Token(Token = "0x20003EC")]
	public class TeamRequest : WebRequest
	{
		[Token(Token = "0x6001E40")]
		[Address(RVA = "0xB3DE24", Offset = "0xB3DE24", VA = "0xB3DE24")]
		public TeamRequest(string endpoint, string userId, TeamEventInfo eventInfo, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
