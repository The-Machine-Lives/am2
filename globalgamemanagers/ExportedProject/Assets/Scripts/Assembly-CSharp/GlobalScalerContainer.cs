using System.Collections.Generic;
using System.Runtime.InteropServices;
using AM2.ReferenceData;
using Il2CppDummyDll;

[Token(Token = "0x2000132")]
public class GlobalScalerContainer
{
	[Token(Token = "0x40007BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private GlobalScaler m_prestigeScaler;

	[Token(Token = "0x40007BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<GlobalScaler> m_miniEventScalers;

	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x9D5928", Offset = "0x9D5928", VA = "0x9D5928")]
	private GlobalScalerContainer([Optional] GlobalScaler prestigeScaler, [Optional] List<GlobalScaler> miniEventScalers)
	{
	}

	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x9D59B4", Offset = "0x9D59B4", VA = "0x9D59B4")]
	public static GlobalScalerContainer GenerateGlobalScalerContainer([Optional] string prestigeScalerRef, [Optional] List<string> miniEventScalerRefs)
	{
		return null;
	}

	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x9D5B44", Offset = "0x9D5B44", VA = "0x9D5B44")]
	public long ApplyScalerValue(long value)
	{
		return default(long);
	}

	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x9D5D08", Offset = "0x9D5D08", VA = "0x9D5D08")]
	private long ApplyPrestigeScaler(long value)
	{
		return default(long);
	}

	[Token(Token = "0x60008C1")]
	[Address(RVA = "0x9D5B84", Offset = "0x9D5B84", VA = "0x9D5B84")]
	private double ApplyMiniEventScalers(long value)
	{
		return default(double);
	}
}
