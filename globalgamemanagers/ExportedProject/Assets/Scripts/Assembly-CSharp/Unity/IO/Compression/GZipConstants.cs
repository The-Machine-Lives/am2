using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005F2")]
	internal static class GZipConstants
	{
		[Token(Token = "0x4001CB0")]
		internal const int CompressionLevel_3 = 3;

		[Token(Token = "0x4001CB1")]
		internal const int CompressionLevel_10 = 10;

		[Token(Token = "0x4001CB2")]
		internal const long FileLengthModulo = 4294967296L;

		[Token(Token = "0x4001CB3")]
		internal const byte ID1 = 31;

		[Token(Token = "0x4001CB4")]
		internal const byte ID2 = 139;

		[Token(Token = "0x4001CB5")]
		internal const byte Deflate = 8;

		[Token(Token = "0x4001CB6")]
		internal const int Xfl_HeaderPos = 8;

		[Token(Token = "0x4001CB7")]
		internal const byte Xfl_FastestAlgorithm = 4;

		[Token(Token = "0x4001CB8")]
		internal const byte Xfl_MaxCompressionSlowestAlgorithm = 2;
	}
}
