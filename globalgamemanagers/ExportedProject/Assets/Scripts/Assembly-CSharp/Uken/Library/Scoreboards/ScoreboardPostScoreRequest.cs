using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.Scoreboards
{
	[Token(Token = "0x20003F0")]
	public class ScoreboardPostScoreRequest : WebRequest
	{
		[Token(Token = "0x6001E4B")]
		[Address(RVA = "0xB3AD7C", Offset = "0xB3AD7C", VA = "0xB3AD7C")]
		public ScoreboardPostScoreRequest(string url, List<ScoreboardDefinition> leaderboards, ScoreboardEntity entity, long score, bool absolute, List<string> segments, Action<WebResponse, WebRequest> onComplete)
		{
		}
	}
}
