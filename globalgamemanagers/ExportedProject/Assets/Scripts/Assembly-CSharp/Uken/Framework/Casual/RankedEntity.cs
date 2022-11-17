using Il2CppDummyDll;
using Uken.Library.LeagueService;
using Uken.Library.Scoreboards;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000560")]
	public class RankedEntity
	{
		[Token(Token = "0x400198F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832878", Offset = "0x832878")]
		private int _003CRank_003Ek__BackingField;

		[Token(Token = "0x4001990")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832888", Offset = "0x832888")]
		private long _003CScore_003Ek__BackingField;

		[Token(Token = "0x4001991")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832898", Offset = "0x832898")]
		private string _003CId_003Ek__BackingField;

		[Token(Token = "0x4001992")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8328A8", Offset = "0x8328A8")]
		private string _003CData_003Ek__BackingField;

		[Token(Token = "0x4001993")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8328B8", Offset = "0x8328B8")]
		private EntityType _003CType_003Ek__BackingField;

		[Token(Token = "0x17000745")]
		public int Rank
		{
			[Token(Token = "0x600291B")]
			[Address(RVA = "0xA81CE8", Offset = "0xA81CE8", VA = "0xA81CE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A48C", Offset = "0x83A48C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600291C")]
			[Address(RVA = "0xA81CF0", Offset = "0xA81CF0", VA = "0xA81CF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A49C", Offset = "0x83A49C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000746")]
		public long Score
		{
			[Token(Token = "0x600291D")]
			[Address(RVA = "0xA81CF8", Offset = "0xA81CF8", VA = "0xA81CF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A4AC", Offset = "0x83A4AC")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600291E")]
			[Address(RVA = "0xA81D00", Offset = "0xA81D00", VA = "0xA81D00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A4BC", Offset = "0x83A4BC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000747")]
		public string Id
		{
			[Token(Token = "0x600291F")]
			[Address(RVA = "0xA81D08", Offset = "0xA81D08", VA = "0xA81D08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A4CC", Offset = "0x83A4CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002920")]
			[Address(RVA = "0xA81D10", Offset = "0xA81D10", VA = "0xA81D10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A4DC", Offset = "0x83A4DC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000748")]
		public string Data
		{
			[Token(Token = "0x6002921")]
			[Address(RVA = "0xA81D18", Offset = "0xA81D18", VA = "0xA81D18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A4EC", Offset = "0x83A4EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002922")]
			[Address(RVA = "0xA81D20", Offset = "0xA81D20", VA = "0xA81D20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A4FC", Offset = "0x83A4FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000749")]
		public EntityType Type
		{
			[Token(Token = "0x6002923")]
			[Address(RVA = "0xA81D28", Offset = "0xA81D28", VA = "0xA81D28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A50C", Offset = "0x83A50C")]
			get
			{
				return default(EntityType);
			}
			[Token(Token = "0x6002924")]
			[Address(RVA = "0xA81D30", Offset = "0xA81D30", VA = "0xA81D30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A51C", Offset = "0x83A51C")]
			private set
			{
			}
		}

		[Token(Token = "0x6002925")]
		[Address(RVA = "0xA81D38", Offset = "0xA81D38", VA = "0xA81D38")]
		public RankedEntity(int rank, int score, string id, string data, EntityType type)
		{
		}

		[Token(Token = "0x6002926")]
		[Address(RVA = "0xA81D94", Offset = "0xA81D94", VA = "0xA81D94")]
		public RankedEntity(ScoreboardEntity other, EntityType type)
		{
		}

		[Token(Token = "0x6002927")]
		[Address(RVA = "0xA81E38", Offset = "0xA81E38", VA = "0xA81E38")]
		public RankedEntity(LeagueServiceEntity other, EntityType type)
		{
		}
	}
}
