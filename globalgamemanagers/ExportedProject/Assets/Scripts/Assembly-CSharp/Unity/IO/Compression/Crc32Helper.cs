using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005E6")]
	internal static class Crc32Helper
	{
		[Token(Token = "0x4001C59")]
		[FieldOffset(Offset = "0x0")]
		private static readonly uint[] crcTable;

		[Token(Token = "0x6002B7B")]
		[Address(RVA = "0xAA92E0", Offset = "0xAA92E0", VA = "0xAA92E0")]
		public static uint UpdateCrc32(uint crc32, byte[] buffer, int offset, int length)
		{
			return default(uint);
		}
	}
}
