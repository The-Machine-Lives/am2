using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Scoreboards
{
	[Token(Token = "0x20003FB")]
	public class ScoreboardTotalEntitiesData
	{
		[Token(Token = "0x400129B")]
		[FieldOffset(Offset = "0x10")]
		public List<ScoreboardDefinition> leaderboards;

		[Token(Token = "0x6001E59")]
		[Address(RVA = "0xB3DDA8", Offset = "0xB3DDA8", VA = "0xB3DDA8")]
		public ScoreboardTotalEntitiesData()
		{
		}
	}
}
