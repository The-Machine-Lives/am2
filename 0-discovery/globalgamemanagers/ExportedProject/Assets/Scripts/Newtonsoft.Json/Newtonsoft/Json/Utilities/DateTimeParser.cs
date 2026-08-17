using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200003F")]
	[Preserve]
	internal struct DateTimeParser
	{
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x0")]
		public int Year;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x4")]
		public int Month;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x8")]
		public int Day;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0xC")]
		public int Hour;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x10")]
		public int Minute;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x14")]
		public int Second;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x18")]
		public int Fraction;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x1C")]
		public int ZoneHour;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x20")]
		public int ZoneMinute;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x24")]
		public ParserTimeZone Zone;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x28")]
		private char[] _text;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x30")]
		private int _end;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] Power10;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int Lzyyyy;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int Lzyyyy_;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int Lzyyyy_MM;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int Lzyyyy_MM_;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int Lzyyyy_MM_dd;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int Lzyyyy_MM_ddT;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int LzHH;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int LzHH_;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int LzHH_mm;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly int LzHH_mm_;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int LzHH_mm_ss;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x34")]
		private static readonly int Lz_;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x38")]
		private static readonly int Lz_zz;

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1765580", Offset = "0x1765580", VA = "0x1765580")]
		static DateTimeParser()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x8B64BC", Offset = "0x8B64BC", VA = "0x8B64BC")]
		public bool Parse(char[] text, int startIndex, int length)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x8B64C4", Offset = "0x8B64C4", VA = "0x8B64C4")]
		private bool ParseDate(int start)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x8B64CC", Offset = "0x8B64CC", VA = "0x8B64CC")]
		private bool ParseTimeAndZoneAndWhitespace(int start)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x8B64D4", Offset = "0x8B64D4", VA = "0x8B64D4")]
		private bool ParseTime(ref int start)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x8B64DC", Offset = "0x8B64DC", VA = "0x8B64DC")]
		private bool ParseZone(int start)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x8B64E4", Offset = "0x8B64E4", VA = "0x8B64E4")]
		private bool Parse4Digit(int start, out int num)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x8B64EC", Offset = "0x8B64EC", VA = "0x8B64EC")]
		private bool Parse2Digit(int start, out int num)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x8B64F4", Offset = "0x8B64F4", VA = "0x8B64F4")]
		private bool ParseChar(int start, char ch)
		{
			return default(bool);
		}
	}
}
