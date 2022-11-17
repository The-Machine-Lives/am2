using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x20000A1")]
public class AM2TextFormatter
{
	[Token(Token = "0x2000619")]
	public enum ETimeFormat
	{
		[Token(Token = "0x4001DD0")]
		SecondsWithDecimal = 0,
		[Token(Token = "0x4001DD1")]
		Second = 1,
		[Token(Token = "0x4001DD2")]
		MinAndSecond = 2,
		[Token(Token = "0x4001DD3")]
		HourAndMin = 3,
		[Token(Token = "0x4001DD4")]
		DayAndHour = 4,
		[Token(Token = "0x4001DD5")]
		Dynamic = 5
	}

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CultureInfo enUSCulture;

	[Token(Token = "0x40002C9")]
	public const string c_infinitySymbol = "∞";

	[Token(Token = "0x40002CA")]
	public const string c_squaredSymbol = "²";

	[Token(Token = "0x40002CB")]
	public const string c_maxText = "MAX";

	[Token(Token = "0x40002CC")]
	public const string c_secondAbbrv = "s";

	[Token(Token = "0x40002CD")]
	public const string c_minuteAbbrv = "m";

	[Token(Token = "0x40002CE")]
	public const string c_hourAbbrv = "h";

	[Token(Token = "0x40002CF")]
	public const string c_dayAbbrv = "d";

	[Token(Token = "0x40002D0")]
	public const int c_maxDisplayDecimalPlacesUnderOne = 3;

	[Token(Token = "0x40002D1")]
	public const int c_maxDisplayDecimalPlacesUnderTen = 2;

	[Token(Token = "0x40002D2")]
	public const int c_maxDisplayDecimalPlacesUnderHundred = 1;

	[Token(Token = "0x40002D3")]
	public const int c_maxDisplayDecimalPlacesAboveHundred = 0;

	[Token(Token = "0x40002D4")]
	public const double c_quintillion = 1E+18;

	[Token(Token = "0x40002D5")]
	public const double c_quadrillion = 1000000000000000.0;

	[Token(Token = "0x40002D6")]
	public const double c_trillion = 1000000000000.0;

	[Token(Token = "0x40002D7")]
	public const double c_billion = 1000000000.0;

	[Token(Token = "0x40002D8")]
	public const double c_million = 1000000.0;

	[Token(Token = "0x40002D9")]
	public const double c_hundredThousand = 100000.0;

	[Token(Token = "0x40002DA")]
	public const double c_tenThousand = 10000.0;

	[Token(Token = "0x40002DB")]
	public const double c_thousand = 1000.0;

	[Token(Token = "0x40002DC")]
	private const double secondsPerMinuteFloat = 60.0;

	[Token(Token = "0x40002DD")]
	private const double secondsPerHourFloat = 3600.0;

	[Token(Token = "0x40002DE")]
	private const double secondsPerDayFloat = 86400.0;

	[Token(Token = "0x40002DF")]
	private const long secondsPerMinuteLong = 60L;

	[Token(Token = "0x40002E0")]
	private const long secondsPerHourLong = 3600L;

	[Token(Token = "0x40002E1")]
	private const long secondsPerDayILong = 86400L;

	[Token(Token = "0x40002E2")]
	private const double onePerMinute = 1.0 / 60.0;

	[Token(Token = "0x40002E3")]
	private const double onePerHour = 0.0002777777777777778;

	[Token(Token = "0x40002E4")]
	private const double onePerDay = 1.1574074074074073E-05;

	[Token(Token = "0x40002E5")]
	private const string m_speedFormat = "{0}/{1}";

	[Token(Token = "0x40002E6")]
	private const string m_accelerationFormat = "{0}/{1}²";

	[Token(Token = "0x40002E7")]
	private const string c_commaNumberFormat = "#,###,###,###,###,###,##0.";

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0xAC615C", Offset = "0xAC615C", VA = "0xAC615C")]
	public static string ItemCostAndQuantityInfo(string localizedItemName, long cost, long currentQuantity)
	{
		return null;
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0xAC63E4", Offset = "0xAC63E4", VA = "0xAC63E4")]
	public static string ItemCost(string localizedItemName, long cost)
	{
		return null;
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0xAC6480", Offset = "0xAC6480", VA = "0xAC6480")]
	public static string Fraction(long top, long bottom, [Optional] int? wrapAtSlashLength)
	{
		return null;
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0xAC65B0", Offset = "0xAC65B0", VA = "0xAC65B0")]
	public static string CountdownTimer(double timeRemaining, bool allowDecimals = false)
	{
		return null;
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0xAC68F0", Offset = "0xAC68F0", VA = "0xAC68F0")]
	public static string DisplayRoundedNumberWithType(double number, ENumericDisplayType displayType, ETimeFormat timeFormat = ETimeFormat.Dynamic, int truncateDecimalPlaces = 2)
	{
		return null;
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0xAC6D28", Offset = "0xAC6D28", VA = "0xAC6D28")]
	public static ETimeFormat DetermineFormat(double amountInSeconds, ENumericDisplayType displayType, bool allowDecimals)
	{
		return default(ETimeFormat);
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0xAC6E08", Offset = "0xAC6E08", VA = "0xAC6E08")]
	public static ETimeFormat DetermineSpeedFormat(double speedInSeconds)
	{
		return default(ETimeFormat);
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0xAC6A38", Offset = "0xAC6A38", VA = "0xAC6A38")]
	public static string FormatSecondsIntoSpeed(double speedInSeconds, ETimeFormat timeFormat, int truncateDecimalPlaces = 2)
	{
		return null;
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0xAC6ADC", Offset = "0xAC6ADC", VA = "0xAC6ADC")]
	public static string FormatSecondsIntoAcceleration(double accelerationInSeconds, ETimeFormat timeFormat, int truncateDecimalPlaces = 2)
	{
		return null;
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0xAC7188", Offset = "0xAC7188", VA = "0xAC7188")]
	public static string FormatAsSpeed(string number, string units)
	{
		return null;
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0xAC71EC", Offset = "0xAC71EC", VA = "0xAC71EC")]
	public static string FormatAsAcceleration(string number, string units)
	{
		return null;
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0xAC6EEC", Offset = "0xAC6EEC", VA = "0xAC6EEC")]
	public static ETimeFormat DetermineTimeFormat(double timeInSeconds, bool allowDecimals)
	{
		return default(ETimeFormat);
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0xAC662C", Offset = "0xAC662C", VA = "0xAC662C")]
	public static string FormatSecondsIntoTime(double timeInSeconds, bool allowDecimals, ETimeFormat timeFormat, int truncateDecimalPlaces = 2)
	{
		return null;
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0xAC6B80", Offset = "0xAC6B80", VA = "0xAC6B80")]
	public static string RoundNumberBasedOnSize(double number, int truncateDecimalPlaces = 2)
	{
		return null;
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0xAC7444", Offset = "0xAC7444", VA = "0xAC7444")]
	public static string CurrentUnixTimeToUniversalString(double seconds)
	{
		return null;
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0xAC752C", Offset = "0xAC752C", VA = "0xAC752C")]
	public static string TimeSpanToDaysHoursString(TimeSpan span)
	{
		return null;
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0xAC760C", Offset = "0xAC760C", VA = "0xAC760C")]
	public static string TimeSpanToHoursMinutesSecondsString(TimeSpan span)
	{
		return null;
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0xAC76EC", Offset = "0xAC76EC", VA = "0xAC76EC")]
	public static string TimeSpanToMinutesSecondsString(TimeSpan span)
	{
		return null;
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0xAC77A0", Offset = "0xAC77A0", VA = "0xAC77A0")]
	public static string TimeSpanToHoursMinutesString(TimeSpan span)
	{
		return null;
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0xAC7858", Offset = "0xAC7858", VA = "0xAC7858")]
	public static string FormatAsPercent(double num, int decimalPlaces = 0)
	{
		return null;
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0xAC7914", Offset = "0xAC7914", VA = "0xAC7914")]
	public static string FormatAsPercent(long num)
	{
		return null;
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0xAC6034", Offset = "0xAC6034", VA = "0xAC6034")]
	public static string FormatAsCommaNumber(long num)
	{
		return null;
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0xAC7250", Offset = "0xAC7250", VA = "0xAC7250")]
	public static string FormatAsCommaNumber(double num, int decimalPlaces = 0, int truncateDecimalPlaces = 2)
	{
		return null;
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0xAC797C", Offset = "0xAC797C", VA = "0xAC797C")]
	public static string FormatAsStringColonString(string firstString, string secondString)
	{
		return null;
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0xAC79E0", Offset = "0xAC79E0", VA = "0xAC79E0")]
	public static string FormatAsStringColonSignedQuanity(string inString, long quantity)
	{
		return null;
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0xAC7A68", Offset = "0xAC7A68", VA = "0xAC7A68")]
	public static string FormatAsSignedQuantity(double quantity, int decimalPlaces, ENumericDisplayType displayType = ENumericDisplayType.None, ETimeFormat timeFormat = ETimeFormat.Dynamic)
	{
		return null;
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0xAC7004", Offset = "0xAC7004", VA = "0xAC7004")]
	private static void GetTimeNumberAndUnits(double speedInSeconds, ETimeFormat timeFormat, int truncateDecimalPlaces, out string number, out string units)
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0xAC7B98", Offset = "0xAC7B98", VA = "0xAC7B98")]
	public static string AmountText(long amount)
	{
		return null;
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0xAC7C00", Offset = "0xAC7C00", VA = "0xAC7C00")]
	public static string RangedAmountText(long amountMin, long amountMax)
	{
		return null;
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0xAC7D20", Offset = "0xAC7D20", VA = "0xAC7D20")]
	public static string TimeLeftFromDate(DateTime dateTime)
	{
		return null;
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0xAC7FAC", Offset = "0xAC7FAC", VA = "0xAC7FAC")]
	public static string VIPTimeLeftFromDate(DateTime dateTime)
	{
		return null;
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0xAC80F8", Offset = "0xAC80F8", VA = "0xAC80F8")]
	public AM2TextFormatter()
	{
	}
}
