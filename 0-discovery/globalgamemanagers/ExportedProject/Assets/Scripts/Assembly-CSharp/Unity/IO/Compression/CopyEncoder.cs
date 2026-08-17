using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005E5")]
	internal class CopyEncoder
	{
		[Token(Token = "0x4001C57")]
		private const int PaddingSize = 5;

		[Token(Token = "0x4001C58")]
		private const int MaxUncompressedBlockSize = 65536;

		[Token(Token = "0x6002B78")]
		[Address(RVA = "0xAA8D9C", Offset = "0xAA8D9C", VA = "0xAA8D9C")]
		public void GetBlock(DeflateInput input, OutputBuffer output, bool isFinal)
		{
		}

		[Token(Token = "0x6002B79")]
		[Address(RVA = "0xAA9148", Offset = "0xAA9148", VA = "0xAA9148")]
		private void WriteLenNLen(ushort len, OutputBuffer output)
		{
		}

		[Token(Token = "0x6002B7A")]
		[Address(RVA = "0xAA92D8", Offset = "0xAA92D8", VA = "0xAA92D8")]
		public CopyEncoder()
		{
		}
	}
}
