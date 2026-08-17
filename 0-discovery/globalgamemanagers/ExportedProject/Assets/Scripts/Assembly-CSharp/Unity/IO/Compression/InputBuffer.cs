using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005F8")]
	internal class InputBuffer
	{
		[Token(Token = "0x4001CFC")]
		[FieldOffset(Offset = "0x10")]
		private byte[] buffer;

		[Token(Token = "0x4001CFD")]
		[FieldOffset(Offset = "0x18")]
		private int start;

		[Token(Token = "0x4001CFE")]
		[FieldOffset(Offset = "0x1C")]
		private int end;

		[Token(Token = "0x4001CFF")]
		[FieldOffset(Offset = "0x20")]
		private uint bitBuffer;

		[Token(Token = "0x4001D00")]
		[FieldOffset(Offset = "0x24")]
		private int bitsInBuffer;

		[Token(Token = "0x1700079F")]
		public int AvailableBits
		{
			[Token(Token = "0x6002C24")]
			[Address(RVA = "0xAB0E44", Offset = "0xAB0E44", VA = "0xAB0E44")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170007A0")]
		public int AvailableBytes
		{
			[Token(Token = "0x6002C25")]
			[Address(RVA = "0xAB2A54", Offset = "0xAB2A54", VA = "0xAB2A54")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6002C26")]
		[Address(RVA = "0xAB13F4", Offset = "0xAB13F4", VA = "0xAB13F4")]
		public bool EnsureBitsAvailable(int count)
		{
			return default(bool);
		}

		[Token(Token = "0x6002C27")]
		[Address(RVA = "0xAB0CFC", Offset = "0xAB0CFC", VA = "0xAB0CFC")]
		public uint TryLoad16Bits()
		{
			return default(uint);
		}

		[Token(Token = "0x6002C28")]
		[Address(RVA = "0xAB2A74", Offset = "0xAB2A74", VA = "0xAB2A74")]
		private uint GetBitMask(int count)
		{
			return default(uint);
		}

		[Token(Token = "0x6002C29")]
		[Address(RVA = "0xAAF068", Offset = "0xAAF068", VA = "0xAAF068")]
		public int GetBits(int count)
		{
			return default(int);
		}

		[Token(Token = "0x6002C2A")]
		[Address(RVA = "0xAB2A88", Offset = "0xAB2A88", VA = "0xAB2A88")]
		public int CopyTo(byte[] output, int offset, int length)
		{
			return default(int);
		}

		[Token(Token = "0x6002C2B")]
		[Address(RVA = "0xAB0F5C", Offset = "0xAB0F5C", VA = "0xAB0F5C")]
		public bool NeedsInput()
		{
			return default(bool);
		}

		[Token(Token = "0x6002C2C")]
		[Address(RVA = "0xAB0EE4", Offset = "0xAB0EE4", VA = "0xAB0EE4")]
		public void SetInput(byte[] buffer, int offset, int length)
		{
		}

		[Token(Token = "0x6002C2D")]
		[Address(RVA = "0xAB0E4C", Offset = "0xAB0E4C", VA = "0xAB0E4C")]
		public void SkipBits(int n)
		{
		}

		[Token(Token = "0x6002C2E")]
		[Address(RVA = "0xAAF210", Offset = "0xAAF210", VA = "0xAAF210")]
		public void SkipToByteBoundary()
		{
		}

		[Token(Token = "0x6002C2F")]
		[Address(RVA = "0xAB0EC4", Offset = "0xAB0EC4", VA = "0xAB0EC4")]
		public InputBuffer()
		{
		}
	}
}
