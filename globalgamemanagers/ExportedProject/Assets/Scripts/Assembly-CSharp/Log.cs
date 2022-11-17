using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20001E8")]
public static class Log
{
	[Token(Token = "0x4000B2C")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string[] LogTypes;

	[Token(Token = "0x4000B2D")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x825F5C", Offset = "0x825F5C")]
	private static bool _003CIgnorePlayerPrefs_003Ek__BackingField;

	[Token(Token = "0x170001A0")]
	public static bool IgnorePlayerPrefs
	{
		[Token(Token = "0x6000D0F")]
		[Address(RVA = "0x9992A0", Offset = "0x9992A0", VA = "0x9992A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834D70", Offset = "0x834D70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D10")]
		[Address(RVA = "0x999308", Offset = "0x999308", VA = "0x999308")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834D80", Offset = "0x834D80")]
		set
		{
		}
	}

	[Token(Token = "0x6000D11")]
	[Address(RVA = "0x999378", Offset = "0x999378", VA = "0x999378")]
	public static IEnumerable<string> AllLogTypes()
	{
		return null;
	}

	[Token(Token = "0x6000D12")]
	[Address(RVA = "0x99940C", Offset = "0x99940C", VA = "0x99940C")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x834D90", Offset = "0x834D90")]
	public static void Debug(string text)
	{
	}

	[Token(Token = "0x6000D13")]
	[Address(RVA = "0x999474", Offset = "0x999474", VA = "0x999474")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x834DC8", Offset = "0x834DC8")]
	public static void ColourDebug(string text, string color = "cyan")
	{
	}

	[Token(Token = "0x6000D14")]
	[Address(RVA = "0x999520", Offset = "0x999520", VA = "0x999520")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x834E00", Offset = "0x834E00")]
	public static void Warning(string text)
	{
	}

	[Token(Token = "0x6000D15")]
	[Address(RVA = "0x999588", Offset = "0x999588", VA = "0x999588")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x834E38", Offset = "0x834E38")]
	public static void Error(string text)
	{
	}

	[Token(Token = "0x6000D16")]
	[Address(RVA = "0x9995F0", Offset = "0x9995F0", VA = "0x9995F0")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x834E70", Offset = "0x834E70")]
	public static void Network(string text)
	{
	}

	[Token(Token = "0x6000D17")]
	[Address(RVA = "0x9995F4", Offset = "0x9995F4", VA = "0x9995F4")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x834EA8", Offset = "0x834EA8")]
	public static void View(string text)
	{
	}

	[Token(Token = "0x6000D18")]
	[Address(RVA = "0x9995F8", Offset = "0x9995F8", VA = "0x9995F8")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x834EE0", Offset = "0x834EE0")]
	public static void Controller(string text)
	{
	}

	[Token(Token = "0x6000D19")]
	[Address(RVA = "0x9995FC", Offset = "0x9995FC", VA = "0x9995FC")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x834F18", Offset = "0x834F18")]
	public static void Logic(string text)
	{
	}

	[Token(Token = "0x6000D1A")]
	[Address(RVA = "0x999600", Offset = "0x999600", VA = "0x999600")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x834F50", Offset = "0x834F50")]
	public static void Utility(string text)
	{
	}

	[Token(Token = "0x6000D1B")]
	[Address(RVA = "0x999604", Offset = "0x999604", VA = "0x999604")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x834F88", Offset = "0x834F88")]
	public static void Performance(string text)
	{
	}

	[Token(Token = "0x6000D1C")]
	[Address(RVA = "0x999608", Offset = "0x999608", VA = "0x999608")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x834FC0", Offset = "0x834FC0")]
	public static void Analytics(string text)
	{
	}

	[Token(Token = "0x6000D1D")]
	[Address(RVA = "0x99960C", Offset = "0x99960C", VA = "0x99960C")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x834FF8", Offset = "0x834FF8")]
	public static void Audio(string text)
	{
	}

	[Token(Token = "0x6000D1E")]
	[Address(RVA = "0x999610", Offset = "0x999610", VA = "0x999610")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x835030", Offset = "0x835030")]
	public static void Content(string text)
	{
	}

	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0x999614", Offset = "0x999614", VA = "0x999614")]
	public static bool Enabled(string logName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D20")]
	[Address(RVA = "0x9996C4", Offset = "0x9996C4", VA = "0x9996C4")]
	public static void Exception(string name, string message)
	{
	}

	[Token(Token = "0x6000D21")]
	[Address(RVA = "0x999734", Offset = "0x999734", VA = "0x999734")]
	public static void Exception(string name, string message, string stackTrace)
	{
	}

	[Token(Token = "0x6000D22")]
	[Address(RVA = "0x999738", Offset = "0x999738", VA = "0x999738")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x835068", Offset = "0x835068")]
	private static void WriteIfEnabled(string text, string logName, string colour)
	{
	}
}
