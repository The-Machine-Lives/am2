using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005EB")]
	internal class FastEncoder
	{
		[Token(Token = "0x4001C80")]
		[FieldOffset(Offset = "0x10")]
		private FastEncoderWindow inputWindow;

		[Token(Token = "0x4001C81")]
		[FieldOffset(Offset = "0x18")]
		private Match currentMatch;

		[Token(Token = "0x4001C82")]
		[FieldOffset(Offset = "0x20")]
		private double lastCompressionRatio;

		[Token(Token = "0x17000790")]
		internal int BytesInHistory
		{
			[Token(Token = "0x6002BC2")]
			[Address(RVA = "0xAACBCC", Offset = "0xAACBCC", VA = "0xAACBCC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000791")]
		internal DeflateInput UnprocessedInput
		{
			[Token(Token = "0x6002BC3")]
			[Address(RVA = "0xAAD0F0", Offset = "0xAAD0F0", VA = "0xAAD0F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000792")]
		internal double LastCompressionRatio
		{
			[Token(Token = "0x6002BC5")]
			[Address(RVA = "0xAAD09C", Offset = "0xAAD09C", VA = "0xAAD09C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6002BC1")]
		[Address(RVA = "0xAACA24", Offset = "0xAACA24", VA = "0xAACA24")]
		public FastEncoder()
		{
		}

		[Token(Token = "0x6002BC4")]
		[Address(RVA = "0xAAD120", Offset = "0xAAD120", VA = "0xAAD120")]
		internal void FlushInput()
		{
		}

		[Token(Token = "0x6002BC6")]
		[Address(RVA = "0xAAD14C", Offset = "0xAAD14C", VA = "0xAAD14C")]
		internal void GetBlock(DeflateInput input, OutputBuffer output, int maxBytesToCopy)
		{
		}

		[Token(Token = "0x6002BC7")]
		[Address(RVA = "0xAAD094", Offset = "0xAAD094", VA = "0xAAD094")]
		internal void GetCompressedData(DeflateInput input, OutputBuffer output)
		{
		}

		[Token(Token = "0x6002BC8")]
		[Address(RVA = "0xAAD08C", Offset = "0xAAD08C", VA = "0xAAD08C")]
		internal void GetBlockHeader(OutputBuffer output)
		{
		}

		[Token(Token = "0x6002BC9")]
		[Address(RVA = "0xAAD11C", Offset = "0xAAD11C", VA = "0xAAD11C")]
		internal void GetBlockFooter(OutputBuffer output)
		{
		}

		[Token(Token = "0x6002BCA")]
		[Address(RVA = "0xAAD454", Offset = "0xAAD454", VA = "0xAAD454")]
		private void GetCompressedOutput(DeflateInput input, OutputBuffer output, int maxBytesToCopy)
		{
		}

		[Token(Token = "0x6002BCB")]
		[Address(RVA = "0xAAD7AC", Offset = "0xAAD7AC", VA = "0xAAD7AC")]
		private void GetCompressedOutput(OutputBuffer output)
		{
		}

		[Token(Token = "0x6002BCC")]
		[Address(RVA = "0xAAD934", Offset = "0xAAD934", VA = "0xAAD934")]
		private bool InputAvailable(DeflateInput input)
		{
			return default(bool);
		}

		[Token(Token = "0x6002BCD")]
		[Address(RVA = "0xAAD8E8", Offset = "0xAAD8E8", VA = "0xAAD8E8")]
		private bool SafeToWriteTo(OutputBuffer output)
		{
			return default(bool);
		}

		[Token(Token = "0x6002BCE")]
		[Address(RVA = "0xAAD694", Offset = "0xAAD694", VA = "0xAAD694")]
		private void WriteEndOfBlock(OutputBuffer output)
		{
		}

		[Token(Token = "0x6002BCF")]
		[Address(RVA = "0xAADD94", Offset = "0xAADD94", VA = "0xAADD94")]
		internal static void WriteMatch(int matchLen, int matchPos, OutputBuffer output)
		{
		}

		[Token(Token = "0x6002BD0")]
		[Address(RVA = "0xAADCC0", Offset = "0xAADCC0", VA = "0xAADCC0")]
		internal static void WriteChar(byte b, OutputBuffer output)
		{
		}

		[Token(Token = "0x6002BD1")]
		[Address(RVA = "0xAAD38C", Offset = "0xAAD38C", VA = "0xAAD38C")]
		internal static void WriteDeflatePreamble(OutputBuffer output)
		{
		}
	}
}
