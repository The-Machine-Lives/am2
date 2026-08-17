using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000053")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x80E674", Offset = "0x80E674")]
	[Preserve]
	internal struct StringReference
	{
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x0")]
		private readonly char[] _chars;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x8")]
		private readonly int _startIndex;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0xC")]
		private readonly int _length;

		[Token(Token = "0x17000060")]
		public char this[int i]
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x8B691C", Offset = "0x8B691C", VA = "0x8B691C")]
			get
			{
				return default(char);
			}
		}

		[Token(Token = "0x17000061")]
		public char[] Chars
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x8B6924", Offset = "0x8B6924", VA = "0x8B6924")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		public int StartIndex
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x8B692C", Offset = "0x8B692C", VA = "0x8B692C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000063")]
		public int Length
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x8B6934", Offset = "0x8B6934", VA = "0x8B6934")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x8B693C", Offset = "0x8B693C", VA = "0x8B693C")]
		public StringReference(char[] chars, int startIndex, int length)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x8B6948", Offset = "0x8B6948", VA = "0x8B6948", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
