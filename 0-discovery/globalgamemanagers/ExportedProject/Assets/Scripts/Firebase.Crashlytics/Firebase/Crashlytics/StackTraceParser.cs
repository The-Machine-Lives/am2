using System.Collections.Generic;
using Il2CppDummyDll;

namespace Firebase.Crashlytics
{
	[Token(Token = "0x200000E")]
	internal class StackTraceParser
	{
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string FrameArgsRegex;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string FrameRegexWithoutFileInfo;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string FrameRegexWithFileInfo;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string MonoFilenameUnknownString;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x20")]
		private static readonly string[] StringDelimiters;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x17AB4F0", Offset = "0x17AB4F0", VA = "0x17AB4F0")]
		public StackTraceParser()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x17A9278", Offset = "0x17A9278", VA = "0x17A9278")]
		public static Dictionary<string, string>[] ParseStackTraceString(string stackTrace)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x17AB4F8", Offset = "0x17AB4F8", VA = "0x17AB4F8")]
		private static Dictionary<string, string> ParseFrameString(string regex, string frameString)
		{
			return null;
		}
	}
}
