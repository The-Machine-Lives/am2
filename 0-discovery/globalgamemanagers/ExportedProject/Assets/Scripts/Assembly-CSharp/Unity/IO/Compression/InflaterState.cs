using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005F7")]
	internal enum InflaterState
	{
		[Token(Token = "0x4001CE5")]
		ReadingHeader = 0,
		[Token(Token = "0x4001CE6")]
		ReadingBFinal = 2,
		[Token(Token = "0x4001CE7")]
		ReadingBType = 3,
		[Token(Token = "0x4001CE8")]
		ReadingNumLitCodes = 4,
		[Token(Token = "0x4001CE9")]
		ReadingNumDistCodes = 5,
		[Token(Token = "0x4001CEA")]
		ReadingNumCodeLengthCodes = 6,
		[Token(Token = "0x4001CEB")]
		ReadingCodeLengthCodes = 7,
		[Token(Token = "0x4001CEC")]
		ReadingTreeCodesBefore = 8,
		[Token(Token = "0x4001CED")]
		ReadingTreeCodesAfter = 9,
		[Token(Token = "0x4001CEE")]
		DecodeTop = 10,
		[Token(Token = "0x4001CEF")]
		HaveInitialLength = 11,
		[Token(Token = "0x4001CF0")]
		HaveFullLength = 12,
		[Token(Token = "0x4001CF1")]
		HaveDistCode = 13,
		[Token(Token = "0x4001CF2")]
		UncompressedAligning = 15,
		[Token(Token = "0x4001CF3")]
		UncompressedByte1 = 16,
		[Token(Token = "0x4001CF4")]
		UncompressedByte2 = 17,
		[Token(Token = "0x4001CF5")]
		UncompressedByte3 = 18,
		[Token(Token = "0x4001CF6")]
		UncompressedByte4 = 19,
		[Token(Token = "0x4001CF7")]
		DecodingUncompressed = 20,
		[Token(Token = "0x4001CF8")]
		StartReadingFooter = 21,
		[Token(Token = "0x4001CF9")]
		ReadingFooter = 22,
		[Token(Token = "0x4001CFA")]
		VerifyingFooter = 23,
		[Token(Token = "0x4001CFB")]
		Done = 24
	}
}
