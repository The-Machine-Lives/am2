using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005FB")]
	internal class OutputBuffer
	{
		[Token(Token = "0x200087B")]
		internal struct BufferState
		{
			[Token(Token = "0x4002449")]
			[FieldOffset(Offset = "0x0")]
			internal int pos;

			[Token(Token = "0x400244A")]
			[FieldOffset(Offset = "0x4")]
			internal uint bitBuf;

			[Token(Token = "0x400244B")]
			[FieldOffset(Offset = "0x8")]
			internal int bitCount;
		}

		[Token(Token = "0x4001D05")]
		[FieldOffset(Offset = "0x10")]
		private byte[] byteBuffer;

		[Token(Token = "0x4001D06")]
		[FieldOffset(Offset = "0x18")]
		private int pos;

		[Token(Token = "0x4001D07")]
		[FieldOffset(Offset = "0x1C")]
		private uint bitBuf;

		[Token(Token = "0x4001D08")]
		[FieldOffset(Offset = "0x20")]
		private int bitCount;

		[Token(Token = "0x170007A5")]
		internal int BytesWritten
		{
			[Token(Token = "0x6002C3E")]
			[Address(RVA = "0xAAD19C", Offset = "0xAAD19C", VA = "0xAAD19C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170007A6")]
		internal int FreeBytes
		{
			[Token(Token = "0x6002C3F")]
			[Address(RVA = "0xAA8F3C", Offset = "0xAA8F3C", VA = "0xAA8F3C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170007A7")]
		internal int BitsInBuffer
		{
			[Token(Token = "0x6002C46")]
			[Address(RVA = "0xAA8F74", Offset = "0xAA8F74", VA = "0xAA8F74")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6002C3D")]
		[Address(RVA = "0xAAD070", Offset = "0xAAD070", VA = "0xAAD070")]
		internal void UpdateBuffer(byte[] output)
		{
		}

		[Token(Token = "0x6002C40")]
		[Address(RVA = "0xAA922C", Offset = "0xAA922C", VA = "0xAA922C")]
		internal void WriteUInt16(ushort value)
		{
		}

		[Token(Token = "0x6002C41")]
		[Address(RVA = "0xAA8F90", Offset = "0xAA8F90", VA = "0xAA8F90")]
		internal void WriteBits(int n, uint bits)
		{
		}

		[Token(Token = "0x6002C42")]
		[Address(RVA = "0xAA906C", Offset = "0xAA906C", VA = "0xAA906C")]
		internal void FlushBits()
		{
		}

		[Token(Token = "0x6002C43")]
		[Address(RVA = "0xAA91B0", Offset = "0xAA91B0", VA = "0xAA91B0")]
		internal void WriteBytes(byte[] byteArray, int offset, int count)
		{
		}

		[Token(Token = "0x6002C44")]
		[Address(RVA = "0xAB2BB0", Offset = "0xAB2BB0", VA = "0xAB2BB0")]
		private void WriteBytesUnaligned(byte[] byteArray, int offset, int count)
		{
		}

		[Token(Token = "0x6002C45")]
		[Address(RVA = "0xAB2C3C", Offset = "0xAB2C3C", VA = "0xAB2C3C")]
		private void WriteByteUnaligned(byte b)
		{
		}

		[Token(Token = "0x6002C47")]
		[Address(RVA = "0xAAD07C", Offset = "0xAAD07C", VA = "0xAAD07C")]
		internal BufferState DumpState()
		{
			return default(BufferState);
		}

		[Token(Token = "0x6002C48")]
		[Address(RVA = "0xAAD0B4", Offset = "0xAAD0B4", VA = "0xAAD0B4")]
		internal void RestoreState(BufferState state)
		{
		}

		[Token(Token = "0x6002C49")]
		[Address(RVA = "0xAACAB8", Offset = "0xAACAB8", VA = "0xAACAB8")]
		public OutputBuffer()
		{
		}
	}
}
