using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005FC")]
	internal class OutputWindow
	{
		[Token(Token = "0x4001D09")]
		private const int WindowSize = 32768;

		[Token(Token = "0x4001D0A")]
		private const int WindowMask = 32767;

		[Token(Token = "0x4001D0B")]
		[FieldOffset(Offset = "0x10")]
		private byte[] window;

		[Token(Token = "0x4001D0C")]
		[FieldOffset(Offset = "0x18")]
		private int end;

		[Token(Token = "0x4001D0D")]
		[FieldOffset(Offset = "0x1C")]
		private int bytesUsed;

		[Token(Token = "0x170007A8")]
		public int FreeBytes
		{
			[Token(Token = "0x6002C4D")]
			[Address(RVA = "0xAB267C", Offset = "0xAB267C", VA = "0xAB267C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170007A9")]
		public int AvailableBytes
		{
			[Token(Token = "0x6002C4E")]
			[Address(RVA = "0xAB0F20", Offset = "0xAB0F20", VA = "0xAB0F20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6002C4A")]
		[Address(RVA = "0xAB268C", Offset = "0xAB268C", VA = "0xAB268C")]
		public void Write(byte b)
		{
		}

		[Token(Token = "0x6002C4B")]
		[Address(RVA = "0xAB2704", Offset = "0xAB2704", VA = "0xAB2704")]
		public void WriteLengthDistance(int length, int distance)
		{
		}

		[Token(Token = "0x6002C4C")]
		[Address(RVA = "0xAB2518", Offset = "0xAB2518", VA = "0xAB2518")]
		public int CopyFrom(InputBuffer input, int length)
		{
			return default(int);
		}

		[Token(Token = "0x6002C4F")]
		[Address(RVA = "0xAB0F6C", Offset = "0xAB0F6C", VA = "0xAB0F6C")]
		public int CopyTo(byte[] output, int offset, int length)
		{
			return default(int);
		}

		[Token(Token = "0x6002C50")]
		[Address(RVA = "0xAB0E64", Offset = "0xAB0E64", VA = "0xAB0E64")]
		public OutputWindow()
		{
		}
	}
}
