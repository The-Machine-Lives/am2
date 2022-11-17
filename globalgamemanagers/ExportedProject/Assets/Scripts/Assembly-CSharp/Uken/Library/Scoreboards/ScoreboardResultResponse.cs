using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Scoreboards
{
	[Token(Token = "0x20003F4")]
	public class ScoreboardResultResponse
	{
		[Token(Token = "0x400128F")]
		private const double NO_LAST_RESULT_TIME = -1.0;

		[Token(Token = "0x4001290")]
		[FieldOffset(Offset = "0x10")]
		public List<ScoreboardResult> leaderboards;

		[Token(Token = "0x4001291")]
		[FieldOffset(Offset = "0x18")]
		public double lastResultTime;

		[Token(Token = "0x6001E50")]
		[Address(RVA = "0xB3DBF0", Offset = "0xB3DBF0", VA = "0xB3DBF0")]
		public ScoreboardResultResponse()
		{
		}
	}
}
