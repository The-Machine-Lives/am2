using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005FA")]
	internal class Match
	{
		[Token(Token = "0x4001D01")]
		[FieldOffset(Offset = "0x10")]
		private MatchState state;

		[Token(Token = "0x4001D02")]
		[FieldOffset(Offset = "0x14")]
		private int pos;

		[Token(Token = "0x4001D03")]
		[FieldOffset(Offset = "0x18")]
		private int len;

		[Token(Token = "0x4001D04")]
		[FieldOffset(Offset = "0x1C")]
		private byte symbol;

		[Token(Token = "0x170007A1")]
		internal MatchState State
		{
			[Token(Token = "0x6002C34")]
			[Address(RVA = "0xAADCB0", Offset = "0xAADCB0", VA = "0xAADCB0")]
			get
			{
				return default(MatchState);
			}
			[Token(Token = "0x6002C35")]
			[Address(RVA = "0xAAEA3C", Offset = "0xAAEA3C", VA = "0xAAEA3C")]
			set
			{
			}
		}

		[Token(Token = "0x170007A2")]
		internal int Position
		{
			[Token(Token = "0x6002C36")]
			[Address(RVA = "0xAADD8C", Offset = "0xAADD8C", VA = "0xAADD8C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6002C37")]
			[Address(RVA = "0xAAEA4C", Offset = "0xAAEA4C", VA = "0xAAEA4C")]
			set
			{
			}
		}

		[Token(Token = "0x170007A3")]
		internal int Length
		{
			[Token(Token = "0x6002C38")]
			[Address(RVA = "0xAADD84", Offset = "0xAADD84", VA = "0xAADD84")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6002C39")]
			[Address(RVA = "0xAAEA54", Offset = "0xAAEA54", VA = "0xAAEA54")]
			set
			{
			}
		}

		[Token(Token = "0x170007A4")]
		internal byte Symbol
		{
			[Token(Token = "0x6002C3A")]
			[Address(RVA = "0xAADCB8", Offset = "0xAADCB8", VA = "0xAADCB8")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6002C3B")]
			[Address(RVA = "0xAAEA44", Offset = "0xAAEA44", VA = "0xAAEA44")]
			set
			{
			}
		}

		[Token(Token = "0x6002C3C")]
		[Address(RVA = "0xAAD2BC", Offset = "0xAAD2BC", VA = "0xAAD2BC")]
		public Match()
		{
		}
	}
}
