using System;
using System.Globalization;
using System.IO;
using System.Xml;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000060")]
	[Preserve]
	internal static class DateTimeUtils
	{
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly long InitialJavaScriptDateTicks;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] DaysToMonth365;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[] DaysToMonth366;

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1766398", Offset = "0x1766398", VA = "0x1766398")]
		static DateTimeUtils()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1766468", Offset = "0x1766468", VA = "0x1766468")]
		public static TimeSpan GetUtcOffset(this DateTime d)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x17664EC", Offset = "0x17664EC", VA = "0x17664EC")]
		public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind)
		{
			return default(XmlDateTimeSerializationMode);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1766680", Offset = "0x1766680", VA = "0x1766680")]
		internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x17667BC", Offset = "0x17667BC", VA = "0x17667BC")]
		private static DateTime SwitchToLocalTime(DateTime value)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x176683C", Offset = "0x176683C", VA = "0x176683C")]
		private static DateTime SwitchToUtcTime(DateTime value)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x17668BC", Offset = "0x17668BC", VA = "0x17668BC")]
		private static long ToUniversalTicks(DateTime dateTime)
		{
			return default(long);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1766958", Offset = "0x1766958", VA = "0x1766958")]
		private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset)
		{
			return default(long);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1766A84", Offset = "0x1766A84", VA = "0x1766A84")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset)
		{
			return default(long);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1766B88", Offset = "0x1766B88", VA = "0x1766B88")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime)
		{
			return default(long);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1766BF0", Offset = "0x1766BF0", VA = "0x1766BF0")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc)
		{
			return default(long);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1766AFC", Offset = "0x1766AFC", VA = "0x1766AFC")]
		private static long UniversialTicksToJavaScriptTicks(long universialTicks)
		{
			return default(long);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1766CA8", Offset = "0x1766CA8", VA = "0x1766CA8")]
		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks)
		{
			return default(DateTime);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1766D40", Offset = "0x1766D40", VA = "0x1766D40")]
		internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x17671E8", Offset = "0x17671E8", VA = "0x17671E8")]
		internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x176715C", Offset = "0x176715C", VA = "0x176715C")]
		private static DateTime CreateDateTime(DateTimeParser dateTimeParser)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x17673B4", Offset = "0x17673B4", VA = "0x17673B4")]
		internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1767AC4", Offset = "0x1767AC4", VA = "0x1767AC4")]
		internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1767E44", Offset = "0x1767E44", VA = "0x1767E44")]
		internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1768278", Offset = "0x1768278", VA = "0x1768278")]
		internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1768624", Offset = "0x1768624", VA = "0x1768624")]
		private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind)
		{
			return default(bool);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x176783C", Offset = "0x176783C", VA = "0x176783C")]
		private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x17679D0", Offset = "0x17679D0", VA = "0x17679D0")]
		private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1768068", Offset = "0x1768068", VA = "0x1768068")]
		private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt)
		{
			return default(bool);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x17681B8", Offset = "0x17681B8", VA = "0x17681B8")]
		private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			return default(bool);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1768830", Offset = "0x1768830", VA = "0x1768830")]
		private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset)
		{
			return default(bool);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x17689C0", Offset = "0x17689C0", VA = "0x17689C0")]
		internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1768B18", Offset = "0x1768B18", VA = "0x1768B18")]
		internal static int WriteDateTimeString(char[] chars, int start, DateTime value, TimeSpan? offset, DateTimeKind kind, DateFormatHandling format)
		{
			return default(int);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x17690E8", Offset = "0x17690E8", VA = "0x17690E8")]
		internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt)
		{
			return default(int);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x17696B8", Offset = "0x17696B8", VA = "0x17696B8")]
		private static void CopyIntToCharArray(char[] chars, int start, int value, int digits)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1768F20", Offset = "0x1768F20", VA = "0x1768F20")]
		internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format)
		{
			return default(int);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1769774", Offset = "0x1769774", VA = "0x1769774")]
		internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1769424", Offset = "0x1769424", VA = "0x1769424")]
		private static void GetDateValues(DateTime td, out int year, out int month, out int day)
		{
		}
	}
}
