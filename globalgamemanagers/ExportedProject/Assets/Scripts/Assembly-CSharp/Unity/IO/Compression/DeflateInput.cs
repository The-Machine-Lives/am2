using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005E7")]
	internal class DeflateInput
	{
		[Token(Token = "0x2000875")]
		internal struct InputState
		{
			[Token(Token = "0x4002425")]
			[FieldOffset(Offset = "0x0")]
			internal int count;

			[Token(Token = "0x4002426")]
			[FieldOffset(Offset = "0x4")]
			internal int startIndex;
		}

		[Token(Token = "0x4001C5A")]
		[FieldOffset(Offset = "0x10")]
		private byte[] buffer;

		[Token(Token = "0x4001C5B")]
		[FieldOffset(Offset = "0x18")]
		private int count;

		[Token(Token = "0x4001C5C")]
		[FieldOffset(Offset = "0x1C")]
		private int startIndex;

		[Token(Token = "0x17000782")]
		internal byte[] Buffer
		{
			[Token(Token = "0x6002B7D")]
			[Address(RVA = "0xAA91A0", Offset = "0xAA91A0", VA = "0xAA91A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B7E")]
			[Address(RVA = "0xAA9478", Offset = "0xAA9478", VA = "0xAA9478")]
			set
			{
			}
		}

		[Token(Token = "0x17000783")]
		internal int Count
		{
			[Token(Token = "0x6002B7F")]
			[Address(RVA = "0xAA8F34", Offset = "0xAA8F34", VA = "0xAA8F34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6002B80")]
			[Address(RVA = "0xAA9480", Offset = "0xAA9480", VA = "0xAA9480")]
			set
			{
			}
		}

		[Token(Token = "0x17000784")]
		internal int StartIndex
		{
			[Token(Token = "0x6002B81")]
			[Address(RVA = "0xAA91A8", Offset = "0xAA91A8", VA = "0xAA91A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6002B82")]
			[Address(RVA = "0xAA9488", Offset = "0xAA9488", VA = "0xAA9488")]
			set
			{
			}
		}

		[Token(Token = "0x6002B83")]
		[Address(RVA = "0xAA9218", Offset = "0xAA9218", VA = "0xAA9218")]
		internal void ConsumeBytes(int n)
		{
		}

		[Token(Token = "0x6002B84")]
		[Address(RVA = "0xAA9490", Offset = "0xAA9490", VA = "0xAA9490")]
		internal InputState DumpState()
		{
			return default(InputState);
		}

		[Token(Token = "0x6002B85")]
		[Address(RVA = "0xAA9498", Offset = "0xAA9498", VA = "0xAA9498")]
		internal void RestoreState(InputState state)
		{
		}

		[Token(Token = "0x6002B86")]
		[Address(RVA = "0xAA94A4", Offset = "0xAA94A4", VA = "0xAA94A4")]
		public DeflateInput()
		{
		}
	}
}
