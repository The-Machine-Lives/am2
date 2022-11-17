using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005F3")]
	internal class GZipFormatter : IFileFormatWriter
	{
		[Token(Token = "0x4001CB9")]
		[FieldOffset(Offset = "0x10")]
		private byte[] headerBytes;

		[Token(Token = "0x4001CBA")]
		[FieldOffset(Offset = "0x18")]
		private uint _crc32;

		[Token(Token = "0x4001CBB")]
		[FieldOffset(Offset = "0x20")]
		private long _inputStreamSizeModulo;

		[Token(Token = "0x6002C04")]
		[Address(RVA = "0xAAF3B4", Offset = "0xAAF3B4", VA = "0xAAF3B4")]
		internal GZipFormatter()
		{
		}

		[Token(Token = "0x6002C05")]
		[Address(RVA = "0xAAF3BC", Offset = "0xAAF3BC", VA = "0xAAF3BC")]
		internal GZipFormatter(int compressionLevel)
		{
		}

		[Token(Token = "0x6002C06")]
		[Address(RVA = "0xAAF480", Offset = "0xAAF480", VA = "0xAAF480", Slot = "4")]
		public byte[] GetHeader()
		{
			return null;
		}

		[Token(Token = "0x6002C07")]
		[Address(RVA = "0xAAF488", Offset = "0xAAF488", VA = "0xAAF488", Slot = "5")]
		public void UpdateWithBytesRead(byte[] buffer, int offset, int bytesToCopy)
		{
		}

		[Token(Token = "0x6002C08")]
		[Address(RVA = "0xAAF550", Offset = "0xAAF550", VA = "0xAAF550", Slot = "6")]
		public byte[] GetFooter()
		{
			return null;
		}

		[Token(Token = "0x6002C09")]
		[Address(RVA = "0xAAF5CC", Offset = "0xAAF5CC", VA = "0xAAF5CC")]
		internal void WriteUInt32(byte[] b, uint value, int startIndex)
		{
		}
	}
}
