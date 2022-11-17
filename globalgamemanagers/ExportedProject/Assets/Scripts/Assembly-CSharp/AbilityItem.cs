using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x200016F")]
public class AbilityItem : Item
{
	[Token(Token = "0x40008EE")]
	public new const string mc_sItemType = "AbilityItem";

	[Token(Token = "0x40008EF")]
	public const string c_level = "lvl";

	[Token(Token = "0x40008F0")]
	private const long c_defaultLevel = 0L;

	[Token(Token = "0x17000123")]
	public long level
	{
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0xACC434", Offset = "0xACC434", VA = "0xACC434")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xACC48C", Offset = "0xACC48C", VA = "0xACC48C")]
		set
		{
		}
	}

	[Token(Token = "0x6000A1A")]
	[Address(RVA = "0xACC40C", Offset = "0xACC40C", VA = "0xACC40C")]
	public void IncrementLevel()
	{
	}

	[Token(Token = "0x6000A1B")]
	[Address(RVA = "0xACC4F0", Offset = "0xACC4F0", VA = "0xACC4F0", Slot = "4")]
	public override void ResetTraits(bool resetLifeTimeQuantity = false)
	{
	}

	[Token(Token = "0x6000A1E")]
	[Address(RVA = "0xACC538", Offset = "0xACC538", VA = "0xACC538")]
	public AbilityItem()
	{
	}
}
