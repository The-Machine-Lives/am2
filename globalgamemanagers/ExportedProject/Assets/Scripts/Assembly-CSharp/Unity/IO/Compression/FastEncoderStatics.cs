using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005EC")]
	internal static class FastEncoderStatics
	{
		[Token(Token = "0x4001C83")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly byte[] FastEncoderTreeStructureData;

		[Token(Token = "0x4001C84")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly byte[] BFinalFastEncoderTreeStructureData;

		[Token(Token = "0x4001C85")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly uint[] FastEncoderLiteralCodeInfo;

		[Token(Token = "0x4001C86")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly uint[] FastEncoderDistanceCodeInfo;

		[Token(Token = "0x4001C87")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly uint[] BitMask;

		[Token(Token = "0x4001C88")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly byte[] ExtraLengthBits;

		[Token(Token = "0x4001C89")]
		[FieldOffset(Offset = "0x30")]
		internal static readonly byte[] ExtraDistanceBits;

		[Token(Token = "0x4001C8A")]
		internal const int NumChars = 256;

		[Token(Token = "0x4001C8B")]
		internal const int NumLengthBaseCodes = 29;

		[Token(Token = "0x4001C8C")]
		internal const int NumDistBaseCodes = 30;

		[Token(Token = "0x4001C8D")]
		internal const uint FastEncoderPostTreeBitBuf = 34u;

		[Token(Token = "0x4001C8E")]
		internal const int FastEncoderPostTreeBitCount = 9;

		[Token(Token = "0x4001C8F")]
		internal const uint NoCompressionHeader = 0u;

		[Token(Token = "0x4001C90")]
		internal const int NoCompressionHeaderBitCount = 3;

		[Token(Token = "0x4001C91")]
		internal const uint BFinalNoCompressionHeader = 1u;

		[Token(Token = "0x4001C92")]
		internal const int BFinalNoCompressionHeaderBitCount = 3;

		[Token(Token = "0x4001C93")]
		internal const int MaxCodeLen = 16;

		[Token(Token = "0x4001C94")]
		[FieldOffset(Offset = "0x38")]
		private static byte[] distLookup;

		[Token(Token = "0x6002BD2")]
		[Address(RVA = "0xAAE05C", Offset = "0xAAE05C", VA = "0xAAE05C")]
		static FastEncoderStatics()
		{
		}

		[Token(Token = "0x6002BD3")]
		[Address(RVA = "0xAADFAC", Offset = "0xAADFAC", VA = "0xAADFAC")]
		internal static int GetSlot(int pos)
		{
			return default(int);
		}

		[Token(Token = "0x6002BD4")]
		[Address(RVA = "0xAAE3A4", Offset = "0xAAE3A4", VA = "0xAAE3A4")]
		public static uint BitReverse(uint code, int length)
		{
			return default(uint);
		}
	}
}
