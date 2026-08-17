using System.Numerics;
using Il2CppDummyDll;

[Token(Token = "0x20001D3")]
public struct AM2Int
{
	[Token(Token = "0x4000AB1")]
	[FieldOffset(Offset = "0x0")]
	public BigInteger value;

	[Token(Token = "0x6000C76")]
	[Address(RVA = "0x89B960", Offset = "0x89B960", VA = "0x89B960")]
	private AM2Int(BigInteger value)
	{
	}

	[Token(Token = "0x6000C77")]
	[Address(RVA = "0x981BE4", Offset = "0x981BE4", VA = "0x981BE4")]
	public static implicit operator AM2Int(BigInteger value)
	{
		return default(AM2Int);
	}

	[Token(Token = "0x6000C78")]
	[Address(RVA = "0x981BE8", Offset = "0x981BE8", VA = "0x981BE8")]
	public static implicit operator BigInteger(AM2Int record)
	{
		return default(BigInteger);
	}

	[Token(Token = "0x6000C79")]
	[Address(RVA = "0x981BEC", Offset = "0x981BEC", VA = "0x981BEC")]
	public static implicit operator AM2Int(int value)
	{
		return default(AM2Int);
	}

	[Token(Token = "0x6000C7A")]
	[Address(RVA = "0x981C54", Offset = "0x981C54", VA = "0x981C54")]
	public static implicit operator int(AM2Int record)
	{
		return default(int);
	}
}
