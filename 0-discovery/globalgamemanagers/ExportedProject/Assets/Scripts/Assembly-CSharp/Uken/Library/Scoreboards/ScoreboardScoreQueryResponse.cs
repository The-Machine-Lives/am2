using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Scoreboards
{
	[Token(Token = "0x20003F8")]
	public class ScoreboardScoreQueryResponse
	{
		[Token(Token = "0x4001299")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, List<ScoreboardScoreData>> entityResults;

		[Token(Token = "0x6001E56")]
		[Address(RVA = "0xB3A714", Offset = "0xB3A714", VA = "0xB3A714")]
		public ScoreboardScoreQueryResponse()
		{
		}
	}
}
