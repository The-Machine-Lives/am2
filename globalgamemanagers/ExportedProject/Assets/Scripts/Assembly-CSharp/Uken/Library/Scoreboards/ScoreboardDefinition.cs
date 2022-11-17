using System;
using Il2CppDummyDll;

namespace Uken.Library.Scoreboards
{
	[Token(Token = "0x20003EE")]
	public class ScoreboardDefinition
	{
		[Token(Token = "0x20007BE")]
		private enum ScoreboardType
		{
			[Token(Token = "0x400229A")]
			SCORE = 0,
			[Token(Token = "0x400229B")]
			TIME = 1,
			[Token(Token = "0x400229C")]
			PLAYER_NUMBER = 2
		}

		[Token(Token = "0x20007BF")]
		public static class Defaults
		{
			[Token(Token = "0x400229D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int FinalValue;

			[Token(Token = "0x400229E")]
			[FieldOffset(Offset = "0x4")]
			public static readonly int StartTime;

			[Token(Token = "0x400229F")]
			[FieldOffset(Offset = "0x8")]
			public static readonly int EndTime;

			[Token(Token = "0x40022A0")]
			[FieldOffset(Offset = "0xC")]
			public static readonly int Expiry;

			[Token(Token = "0x40022A1")]
			[FieldOffset(Offset = "0x10")]
			public static readonly string TypeId;
		}

		[Token(Token = "0x4001279")]
		private const int NO_FINAL_VALUE = 0;

		[Token(Token = "0x400127A")]
		private const int NO_START_TIME = -1;

		[Token(Token = "0x400127B")]
		private const int NO_END_TIME = -1;

		[Token(Token = "0x400127C")]
		private const int DEFAULT_EXPIRY = -1;

		[Token(Token = "0x400127D")]
		private const string NO_TYPE_ID = "TIME";

		[Token(Token = "0x400127E")]
		private const string NO_NAME = "no_name";

		[Token(Token = "0x400127F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DateTime Epoch;

		[Token(Token = "0x4001280")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4001281")]
		[FieldOffset(Offset = "0x18")]
		public int startTime;

		[Token(Token = "0x4001282")]
		[FieldOffset(Offset = "0x1C")]
		public int endTime;

		[Token(Token = "0x4001283")]
		[FieldOffset(Offset = "0x20")]
		public int? expiresAt;

		[Token(Token = "0x4001284")]
		[FieldOffset(Offset = "0x28")]
		public int finalValue;

		[Token(Token = "0x4001285")]
		[FieldOffset(Offset = "0x2C")]
		public int numberOfEntities;

		[Token(Token = "0x4001286")]
		[FieldOffset(Offset = "0x30")]
		public string typeId;

		[Token(Token = "0x4001287")]
		[FieldOffset(Offset = "0x38")]
		public string source;

		[Token(Token = "0x6001E42")]
		[Address(RVA = "0xB3D398", Offset = "0xB3D398", VA = "0xB3D398")]
		public ScoreboardDefinition()
		{
		}

		[Token(Token = "0x6001E43")]
		[Address(RVA = "0xB3D448", Offset = "0xB3D448", VA = "0xB3D448")]
		public ScoreboardDefinition(ScoreboardDefinition clone)
		{
		}

		[Token(Token = "0x6001E44")]
		[Address(RVA = "0xB3D530", Offset = "0xB3D530", VA = "0xB3D530")]
		public ScoreboardDefinition(string _name, int _startTime, int _endTime, int _expiresAt = -1, string _source = "")
		{
		}

		[Token(Token = "0x6001E45")]
		[Address(RVA = "0xB3D634", Offset = "0xB3D634", VA = "0xB3D634")]
		public ScoreboardDefinition(string _name, DateTime _startTime, DateTime _endTime, DateTime _expiresAt, string _source)
		{
		}
	}
}
