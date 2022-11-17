using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20001EC")]
public class UkenMath
{
	[Token(Token = "0x6000D2B")]
	[Address(RVA = "0xB49D9C", Offset = "0xB49D9C", VA = "0xB49D9C")]
	public static bool AlmostEqual(float a, float b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D2C")]
	[Address(RVA = "0xB3C684", Offset = "0xB3C684", VA = "0xB3C684")]
	public static int ToInt(double val)
	{
		return default(int);
	}

	[Token(Token = "0x6000D2D")]
	public static T ChooseByWeight<T>(ICollection<T> weightedItems, int totalWeight) where T : class, IWeighted
	{
		return null;
	}

	[Token(Token = "0x6000D2E")]
	public static int GetTotalWeight<T>(ICollection<T> weightedItems) where T : class, IWeighted
	{
		return default(int);
	}

	[Token(Token = "0x6000D2F")]
	[Address(RVA = "0xB49E20", Offset = "0xB49E20", VA = "0xB49E20")]
	public static double ClampDouble(double value, double min, double max)
	{
		return default(double);
	}

	[Token(Token = "0x6000D30")]
	[Address(RVA = "0xB49E3C", Offset = "0xB49E3C", VA = "0xB49E3C")]
	public static long ClampLong(long value, long min, long max)
	{
		return default(long);
	}

	[Token(Token = "0x6000D31")]
	[Address(RVA = "0xB49E58", Offset = "0xB49E58", VA = "0xB49E58")]
	public static bool Proc(float procChance)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D32")]
	[Address(RVA = "0xB49E90", Offset = "0xB49E90", VA = "0xB49E90")]
	public static double RandomRange(double minimum, double maximum)
	{
		return default(double);
	}

	[Token(Token = "0x6000D33")]
	[Address(RVA = "0xB49F20", Offset = "0xB49F20", VA = "0xB49F20")]
	public static long RandomRange(long minimum, long maximum)
	{
		return default(long);
	}

	[Token(Token = "0x6000D34")]
	[Address(RVA = "0xB49FBC", Offset = "0xB49FBC", VA = "0xB49FBC")]
	public UkenMath()
	{
	}
}
