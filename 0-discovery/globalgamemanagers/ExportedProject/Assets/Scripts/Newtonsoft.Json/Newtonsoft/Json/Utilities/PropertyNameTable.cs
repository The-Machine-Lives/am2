using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000042")]
	[Preserve]
	internal class PropertyNameTable
	{
		[Token(Token = "0x2000043")]
		private class Entry
		{
			[Token(Token = "0x400016B")]
			[FieldOffset(Offset = "0x10")]
			internal readonly string Value;

			[Token(Token = "0x400016C")]
			[FieldOffset(Offset = "0x18")]
			internal readonly int HashCode;

			[Token(Token = "0x400016D")]
			[FieldOffset(Offset = "0x20")]
			internal Entry Next;

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x176D5D0", Offset = "0x176D5D0", VA = "0x176D5D0")]
			internal Entry(string value, int hashCode, Entry next)
			{
			}
		}

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int HashCodeRandomizer;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x10")]
		private int _count;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x18")]
		private Entry[] _entries;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x20")]
		private int _mask;

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x176CEEC", Offset = "0x176CEEC", VA = "0x176CEEC")]
		static PropertyNameTable()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x176CF44", Offset = "0x176CF44", VA = "0x176CF44")]
		public PropertyNameTable()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x176CFB4", Offset = "0x176CFB4", VA = "0x176CFB4")]
		public string Get(char[] key, int start, int length)
		{
			return null;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x176D284", Offset = "0x176D284", VA = "0x176D284")]
		public string Add(string key)
		{
			return null;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x176D474", Offset = "0x176D474", VA = "0x176D474")]
		private string AddEntry(string str, int hashCode)
		{
			return null;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x176D614", Offset = "0x176D614", VA = "0x176D614")]
		private void Grow()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x176D198", Offset = "0x176D198", VA = "0x176D198")]
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length)
		{
			return default(bool);
		}
	}
}
