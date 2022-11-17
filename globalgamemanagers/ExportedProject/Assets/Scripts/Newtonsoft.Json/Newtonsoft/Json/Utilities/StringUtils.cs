using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000074")]
	[Preserve]
	internal static class StringUtils
	{
		[Token(Token = "0x2000075")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E9A4", Offset = "0x80E9A4")]
		private sealed class _003C_003Ec__DisplayClass15_0<TSource>
		{
			[Token(Token = "0x40001E5")]
			[FieldOffset(Offset = "0x0")]
			public Func<TSource, string> valueSelector;

			[Token(Token = "0x40001E6")]
			[FieldOffset(Offset = "0x0")]
			public string testValue;

			[Token(Token = "0x600033B")]
			public _003C_003Ec__DisplayClass15_0()
			{
			}

			[Token(Token = "0x600033C")]
			internal bool _003CForgivingCaseSensitiveFind_003Eb__0(TSource s)
			{
				return default(bool);
			}

			[Token(Token = "0x600033D")]
			internal bool _003CForgivingCaseSensitiveFind_003Eb__1(TSource s)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x176CABC", Offset = "0x176CABC", VA = "0x176CABC")]
		public static string FormatWith(this string format, IFormatProvider provider, object arg0)
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1769CB0", Offset = "0x1769CB0", VA = "0x1769CB0")]
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1)
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1773620", Offset = "0x1773620", VA = "0x1773620")]
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2)
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1773788", Offset = "0x1773788", VA = "0x1773788")]
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
		{
			return null;
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x17735AC", Offset = "0x17735AC", VA = "0x17735AC")]
		private static string FormatWith(this string format, IFormatProvider provider, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x176C130", Offset = "0x176C130", VA = "0x176C130")]
		public static StringWriter CreateStringWriter(int capacity)
		{
			return null;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x176C0AC", Offset = "0x176C0AC", VA = "0x176C0AC")]
		public static int? GetLength(string value)
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x176BD5C", Offset = "0x176BD5C", VA = "0x176BD5C")]
		public static void ToCharAsUnicode(char c, char[] buffer)
		{
		}

		[Token(Token = "0x6000335")]
		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			return (TSource)null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x176A7DC", Offset = "0x176A7DC", VA = "0x176A7DC")]
		public static string ToCamelCase(string s)
		{
			return null;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1773944", Offset = "0x1773944", VA = "0x1773944")]
		public static bool IsHighSurrogate(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x17739AC", Offset = "0x17739AC", VA = "0x17739AC")]
		public static bool IsLowSurrogate(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1773A14", Offset = "0x1773A14", VA = "0x1773A14")]
		public static bool StartsWith(this string source, char value)
		{
			return default(bool);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1773A80", Offset = "0x1773A80", VA = "0x1773A80")]
		public static bool EndsWith(this string source, char value)
		{
			return default(bool);
		}
	}
}
