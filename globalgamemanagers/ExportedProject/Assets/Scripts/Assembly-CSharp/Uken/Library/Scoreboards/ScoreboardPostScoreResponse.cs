using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Scoreboards
{
	[Token(Token = "0x20003F1")]
	public class ScoreboardPostScoreResponse
	{
		[Token(Token = "0x400128C")]
		[FieldOffset(Offset = "0x10")]
		public List<ScoreboardPostScoreData> scoreboards;

		[Token(Token = "0x6001E4C")]
		[Address(RVA = "0xB3CD3C", Offset = "0xB3CD3C", VA = "0xB3CD3C")]
		public ScoreboardPostScoreResponse()
		{
		}
	}
}
