using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Scoreboards
{
	[Token(Token = "0x20003FA")]
	public class ScoreboardTotalEntitiesQueryResponse
	{
		[Token(Token = "0x400129A")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, int> scoreboardEntityTotals;

		[Token(Token = "0x6001E58")]
		[Address(RVA = "0xB3CFD0", Offset = "0xB3CFD0", VA = "0xB3CFD0")]
		public ScoreboardTotalEntitiesQueryResponse()
		{
		}
	}
}
