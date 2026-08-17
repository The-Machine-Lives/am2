using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.Scoreboards
{
	[Token(Token = "0x20003F2")]
	public class ScoreboardResultRequest : WebRequest
	{
		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0xB39734", Offset = "0xB39734", VA = "0xB39734")]
		public ScoreboardResultRequest(string url, List<string> entityIDs, double lastResultTime, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
