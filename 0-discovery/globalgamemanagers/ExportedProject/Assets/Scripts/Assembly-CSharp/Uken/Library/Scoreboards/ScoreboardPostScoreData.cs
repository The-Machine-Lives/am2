using Il2CppDummyDll;

namespace Uken.Library.Scoreboards
{
	[Token(Token = "0x20003F6")]
	public class ScoreboardPostScoreData
	{
		[Token(Token = "0x4001297")]
		[FieldOffset(Offset = "0x10")]
		public ScoreboardDefinition leaderboard;

		[Token(Token = "0x4001298")]
		[FieldOffset(Offset = "0x18")]
		public ScoreboardEntity entity;

		[Token(Token = "0x6001E53")]
		[Address(RVA = "0xB3D9F0", Offset = "0xB3D9F0", VA = "0xB3D9F0")]
		public ScoreboardPostScoreData()
		{
		}

		[Token(Token = "0x6001E54")]
		[Address(RVA = "0xB3DA78", Offset = "0xB3DA78", VA = "0xB3DA78")]
		public ScoreboardPostScoreData(ScoreboardDefinition _scoreboard, ScoreboardEntity _entity)
		{
		}
	}
}
