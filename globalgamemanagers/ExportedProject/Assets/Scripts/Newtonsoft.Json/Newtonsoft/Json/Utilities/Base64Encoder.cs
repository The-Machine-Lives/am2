using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000040")]
	[Preserve]
	internal class Base64Encoder
	{
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x10")]
		private readonly char[] _charsLine;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x18")]
		private readonly TextWriter _writer;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x20")]
		private byte[] _leftOverBytes;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x28")]
		private int _leftOverBytesCount;

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xF09244", Offset = "0xF09244", VA = "0xF09244")]
		public Base64Encoder(TextWriter writer)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xF092D0", Offset = "0xF092D0", VA = "0xF092D0")]
		public void Encode(byte[] buffer, int index, int count)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xF096DC", Offset = "0xF096DC", VA = "0xF096DC")]
		public void Flush()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xF09684", Offset = "0xF09684", VA = "0xF09684")]
		private void WriteChars(char[] chars, int index, int count)
		{
		}
	}
}
