using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x200017A")]
public class GlobalSpeedBoosterItem : Item
{
	[Token(Token = "0x400090A")]
	[FieldOffset(Offset = "0x0")]
	public static string s_reference_prefix;

	[Token(Token = "0x400090B")]
	public new const string mc_sItemType = "GlobalSpeedBoosterItem";

	[Token(Token = "0x400090C")]
	private const string c_timeRemainingInSeconds = "remaining";

	[Token(Token = "0x400090D")]
	private const string c_boostPercent = "amt";

	[Token(Token = "0x1700012F")]
	public double timeRemainingInSeconds
	{
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x9D5DA8", Offset = "0x9D5DA8", VA = "0x9D5DA8")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x9D5E00", Offset = "0x9D5E00", VA = "0x9D5E00")]
		set
		{
		}
	}

	[Token(Token = "0x17000130")]
	public double boostPercent
	{
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x9D5E90", Offset = "0x9D5E90", VA = "0x9D5E90")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x9D5EE8", Offset = "0x9D5EE8", VA = "0x9D5EE8")]
		set
		{
		}
	}

	[Token(Token = "0x6000A4F")]
	[Address(RVA = "0x9D5D20", Offset = "0x9D5D20", VA = "0x9D5D20")]
	public static string GetItemReference(int index)
	{
		return null;
	}

	[Token(Token = "0x6000A54")]
	[Address(RVA = "0x9D5F4C", Offset = "0x9D5F4C", VA = "0x9D5F4C")]
	public GlobalSpeedBoosterItem()
	{
	}
}
