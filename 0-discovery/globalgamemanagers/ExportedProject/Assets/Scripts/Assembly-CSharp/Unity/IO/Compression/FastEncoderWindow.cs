using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005ED")]
	internal class FastEncoderWindow
	{
		[Token(Token = "0x4001C95")]
		[FieldOffset(Offset = "0x10")]
		private byte[] window;

		[Token(Token = "0x4001C96")]
		[FieldOffset(Offset = "0x18")]
		private int bufPos;

		[Token(Token = "0x4001C97")]
		[FieldOffset(Offset = "0x1C")]
		private int bufEnd;

		[Token(Token = "0x4001C98")]
		private const int FastEncoderHashShift = 4;

		[Token(Token = "0x4001C99")]
		private const int FastEncoderHashtableSize = 2048;

		[Token(Token = "0x4001C9A")]
		private const int FastEncoderHashMask = 2047;

		[Token(Token = "0x4001C9B")]
		private const int FastEncoderWindowSize = 8192;

		[Token(Token = "0x4001C9C")]
		private const int FastEncoderWindowMask = 8191;

		[Token(Token = "0x4001C9D")]
		private const int FastEncoderMatch3DistThreshold = 16384;

		[Token(Token = "0x4001C9E")]
		internal const int MaxMatch = 258;

		[Token(Token = "0x4001C9F")]
		internal const int MinMatch = 3;

		[Token(Token = "0x4001CA0")]
		private const int SearchDepth = 32;

		[Token(Token = "0x4001CA1")]
		private const int GoodLength = 4;

		[Token(Token = "0x4001CA2")]
		private const int NiceLength = 32;

		[Token(Token = "0x4001CA3")]
		private const int LazyMatchThreshold = 6;

		[Token(Token = "0x4001CA4")]
		[FieldOffset(Offset = "0x20")]
		private ushort[] prev;

		[Token(Token = "0x4001CA5")]
		[FieldOffset(Offset = "0x28")]
		private ushort[] lookup;

		[Token(Token = "0x17000793")]
		public int BytesAvailable
		{
			[Token(Token = "0x6002BD6")]
			[Address(RVA = "0xAAD2C4", Offset = "0xAAD2C4", VA = "0xAAD2C4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000794")]
		public DeflateInput UnprocessedInput
		{
			[Token(Token = "0x6002BD7")]
			[Address(RVA = "0xAAD2D0", Offset = "0xAAD2D0", VA = "0xAAD2D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000795")]
		public int FreeWindowSpace
		{
			[Token(Token = "0x6002BDA")]
			[Address(RVA = "0xAAD750", Offset = "0xAAD750", VA = "0xAAD750")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6002BD5")]
		[Address(RVA = "0xAAD294", Offset = "0xAAD294", VA = "0xAAD294")]
		public FastEncoderWindow()
		{
		}

		[Token(Token = "0x6002BD8")]
		[Address(RVA = "0xAAD388", Offset = "0xAAD388", VA = "0xAAD388")]
		public void FlushWindow()
		{
		}

		[Token(Token = "0x6002BD9")]
		[Address(RVA = "0xAAE3CC", Offset = "0xAAE3CC", VA = "0xAAE3CC")]
		private void ResetWindow()
		{
		}

		[Token(Token = "0x6002BDB")]
		[Address(RVA = "0xAAD760", Offset = "0xAAD760", VA = "0xAAD760")]
		public void CopyBytes(byte[] inputBuffer, int startIndex, int count)
		{
		}

		[Token(Token = "0x6002BDC")]
		[Address(RVA = "0xAAE454", Offset = "0xAAE454", VA = "0xAAE454")]
		public void MoveWindows()
		{
		}

		[Token(Token = "0x6002BDD")]
		[Address(RVA = "0xAAE5F4", Offset = "0xAAE5F4", VA = "0xAAE5F4")]
		private uint HashValue(uint hash, byte b)
		{
			return default(uint);
		}

		[Token(Token = "0x6002BDE")]
		[Address(RVA = "0xAAE600", Offset = "0xAAE600", VA = "0xAAE600")]
		private uint InsertString(ref uint hash)
		{
			return default(uint);
		}

		[Token(Token = "0x6002BDF")]
		[Address(RVA = "0xAAE734", Offset = "0xAAE734", VA = "0xAAE734")]
		private void InsertStrings(ref uint hash, int matchLen)
		{
		}

		[Token(Token = "0x6002BE0")]
		[Address(RVA = "0xAAD994", Offset = "0xAAD994", VA = "0xAAD994")]
		internal bool GetNextSymbolOrMatch(Match match)
		{
			return default(bool);
		}

		[Token(Token = "0x6002BE1")]
		[Address(RVA = "0xAAE7A8", Offset = "0xAAE7A8", VA = "0xAAE7A8")]
		private int FindMatch(int search, out int matchPos, int searchDepth, int niceLength)
		{
			return default(int);
		}

		[Token(Token = "0x6002BE2")]
		[Address(RVA = "0xAAEA5C", Offset = "0xAAEA5C", VA = "0xAAEA5C")]
		private uint RecalculateHash(int position)
		{
			return default(uint);
		}
	}
}
