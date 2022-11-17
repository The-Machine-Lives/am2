using System;
using Il2CppDummyDll;

[Token(Token = "0x20001EB")]
public class RandomLong
{
	[Token(Token = "0x4000B2E")]
	[FieldOffset(Offset = "0x10")]
	private Random m_random;

	[Token(Token = "0x6000D27")]
	[Address(RVA = "0x9EC5C0", Offset = "0x9EC5C0", VA = "0x9EC5C0")]
	public RandomLong(Random random)
	{
	}

	[Token(Token = "0x6000D28")]
	[Address(RVA = "0x9EC5EC", Offset = "0x9EC5EC", VA = "0x9EC5EC")]
	public long Next()
	{
		return default(long);
	}

	[Token(Token = "0x6000D29")]
	[Address(RVA = "0x9EC628", Offset = "0x9EC628", VA = "0x9EC628")]
	public long Next(long maxValue)
	{
		return default(long);
	}

	[Token(Token = "0x6000D2A")]
	[Address(RVA = "0x9EC638", Offset = "0x9EC638", VA = "0x9EC638")]
	public long Next(long minValue, long maxValue)
	{
		return default(long);
	}
}
