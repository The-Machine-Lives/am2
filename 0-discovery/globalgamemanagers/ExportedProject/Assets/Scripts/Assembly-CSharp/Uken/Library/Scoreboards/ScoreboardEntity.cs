using Il2CppDummyDll;

namespace Uken.Library.Scoreboards
{
	[Token(Token = "0x20003EF")]
	public class ScoreboardEntity
	{
		[Token(Token = "0x4001288")]
		[FieldOffset(Offset = "0x10")]
		public string entityId;

		[Token(Token = "0x4001289")]
		[FieldOffset(Offset = "0x18")]
		public string data;

		[Token(Token = "0x400128A")]
		[FieldOffset(Offset = "0x20")]
		public long score;

		[Token(Token = "0x400128B")]
		[FieldOffset(Offset = "0x28")]
		public int rank;

		[Token(Token = "0x6001E47")]
		[Address(RVA = "0xB3D994", Offset = "0xB3D994", VA = "0xB3D994")]
		public ScoreboardEntity()
		{
		}

		[Token(Token = "0x6001E48")]
		[Address(RVA = "0xB3AD3C", Offset = "0xB3AD3C", VA = "0xB3AD3C")]
		public ScoreboardEntity(string _entityID, string _data)
		{
		}

		[Token(Token = "0x6001E49")]
		[Address(RVA = "0xB3D99C", Offset = "0xB3D99C", VA = "0xB3D99C")]
		public ScoreboardEntity(string _entityId, int _rank, int _score, string _data)
		{
		}

		[Token(Token = "0x6001E4A")]
		[Address(RVA = "0xB3AD74", Offset = "0xB3AD74", VA = "0xB3AD74")]
		public void SetSubmissionScore(long value)
		{
		}
	}
}
