using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200006A")]
	[Preserve]
	internal static class JavaScriptUtils
	{
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly bool[] SingleQuoteCharEscapeFlags;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly bool[] DoubleQuoteCharEscapeFlags;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly bool[] HtmlCharEscapeFlags;

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x176ABCC", Offset = "0x176ABCC", VA = "0x176ABCC")]
		static JavaScriptUtils()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x176B6C4", Offset = "0x176B6C4", VA = "0x176B6C4")]
		public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar)
		{
			return null;
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x176B7A0", Offset = "0x176B7A0", VA = "0x176B7A0")]
		public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x176B858", Offset = "0x176B858", VA = "0x176B858")]
		public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x176BEAC", Offset = "0x176BEAC", VA = "0x176BEAC")]
		public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling)
		{
			return null;
		}
	}
}
