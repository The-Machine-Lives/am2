using System.Collections.Generic;
using Il2CppDummyDll;

namespace Opencoding.Console
{
	[Token(Token = "0x2000005")]
	public class InputHistory
	{
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<string> _history;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x18")]
		private int _currentIndex;

		[Token(Token = "0x17000012")]
		public bool HasPreviousInput
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0xE892F0", Offset = "0xE892F0", VA = "0xE892F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		public bool HasNextInput
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0xE89300", Offset = "0xE89300", VA = "0xE89300")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xE89220", Offset = "0xE89220", VA = "0xE89220")]
		public void RecordInput(string input)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xE89374", Offset = "0xE89374", VA = "0xE89374")]
		public string GetPreviousInput()
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xE893FC", Offset = "0xE893FC", VA = "0xE893FC")]
		public string GetNextInput()
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xE7A5D0", Offset = "0xE7A5D0", VA = "0xE7A5D0")]
		public InputHistory()
		{
		}
	}
}
