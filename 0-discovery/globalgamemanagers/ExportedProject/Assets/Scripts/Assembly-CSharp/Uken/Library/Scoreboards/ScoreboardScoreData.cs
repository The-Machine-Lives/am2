using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Scoreboards
{
	[Token(Token = "0x20003F5")]
	public class ScoreboardScoreData
	{
		[Token(Token = "0x4001292")]
		[FieldOffset(Offset = "0x10")]
		public ScoreboardDefinition leaderboard;

		[Token(Token = "0x4001293")]
		[FieldOffset(Offset = "0x18")]
		public List<ScoreboardEntity> topEntities;

		[Token(Token = "0x4001294")]
		[FieldOffset(Offset = "0x20")]
		public List<ScoreboardEntity> aboveEntities;

		[Token(Token = "0x4001295")]
		[FieldOffset(Offset = "0x28")]
		public List<ScoreboardEntity> belowEntities;

		[Token(Token = "0x4001296")]
		[FieldOffset(Offset = "0x30")]
		public ScoreboardEntity selfEntity;

		[Token(Token = "0x6001E51")]
		[Address(RVA = "0xB3DC6C", Offset = "0xB3DC6C", VA = "0xB3DC6C")]
		public ScoreboardScoreData()
		{
		}

		[Token(Token = "0x6001E52")]
		[Address(RVA = "0xB3DD54", Offset = "0xB3DD54", VA = "0xB3DD54")]
		public ScoreboardScoreData(ScoreboardDefinition _scoreboard, List<ScoreboardEntity> _topEntities, List<ScoreboardEntity> _aboveEntities, List<ScoreboardEntity> _belowEntities, ScoreboardEntity _selfEntity)
		{
		}
	}
}
