using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200006B")]
	[Preserve]
	internal struct StringBuffer
	{
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x0")]
		private char[] _buffer;

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x8")]
		private int _position;

		[Token(Token = "0x1700007E")]
		public int Position
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x8B6688", Offset = "0x8B6688", VA = "0x8B6688")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x8B6690", Offset = "0x8B6690", VA = "0x8B6690")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public bool IsEmpty
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x8B6698", Offset = "0x8B6698", VA = "0x8B6698")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000080")]
		public char[] InternalBuffer
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x8B6778", Offset = "0x8B6778", VA = "0x8B6778")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x8B66A8", Offset = "0x8B66A8", VA = "0x8B66A8")]
		public StringBuffer(IArrayPool<char> bufferPool, int initalSize)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x8B66DC", Offset = "0x8B66DC", VA = "0x8B66DC")]
		private StringBuffer(char[] buffer)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x8B66E8", Offset = "0x8B66E8", VA = "0x8B66E8")]
		public void Append(IArrayPool<char> bufferPool, char value)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x8B66F0", Offset = "0x8B66F0", VA = "0x8B66F0")]
		public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x8B66F8", Offset = "0x8B66F8", VA = "0x8B66F8")]
		public void Clear(IArrayPool<char> bufferPool)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x8B6734", Offset = "0x8B6734", VA = "0x8B6734")]
		private void EnsureSize(IArrayPool<char> bufferPool, int appendLength)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x8B673C", Offset = "0x8B673C", VA = "0x8B673C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x8B6754", Offset = "0x8B6754", VA = "0x8B6754")]
		public string ToString(int start, int length)
		{
			return null;
		}
	}
}
