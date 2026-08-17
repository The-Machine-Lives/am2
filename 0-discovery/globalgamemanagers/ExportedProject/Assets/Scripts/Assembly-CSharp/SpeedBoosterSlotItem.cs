using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x2000188")]
public class SpeedBoosterSlotItem : Item
{
	[Token(Token = "0x4000943")]
	public new const string mc_sItemType = "SpeedBoosterSlotItem";

	[Token(Token = "0x4000944")]
	public const string c_itemReferencePrefix = "booster_slot_";

	[Token(Token = "0x4000945")]
	private const string c_boosterReference = "booster_ref";

	[Token(Token = "0x4000946")]
	private const string c_timeRemainingInSeconds = "remaining";

	[Token(Token = "0x4000947")]
	private const string c_itemRef = "item_ref";

	[Token(Token = "0x4000948")]
	private const string c_refItemType = "ref_type";

	[Token(Token = "0x4000949")]
	private const string c_count = "count";

	[Token(Token = "0x400094A")]
	private const long c_defaultBoosterCount = 1L;

	[Token(Token = "0x1700014B")]
	public string boosterReference
	{
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0xA06C04", Offset = "0xA06C04", VA = "0xA06C04")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0xA06C64", Offset = "0xA06C64", VA = "0xA06C64")]
		set
		{
		}
	}

	[Token(Token = "0x1700014C")]
	public double timeRemainingInSeconds
	{
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0xA06CC8", Offset = "0xA06CC8", VA = "0xA06CC8")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0xA06D20", Offset = "0xA06D20", VA = "0xA06D20")]
		set
		{
		}
	}

	[Token(Token = "0x1700014D")]
	public string itemRef
	{
		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0xA06D84", Offset = "0xA06D84", VA = "0xA06D84")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0xA06DE4", Offset = "0xA06DE4", VA = "0xA06DE4")]
		set
		{
		}
	}

	[Token(Token = "0x1700014E")]
	public string refItemType
	{
		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0xA06E48", Offset = "0xA06E48", VA = "0xA06E48")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0xA06EA8", Offset = "0xA06EA8", VA = "0xA06EA8")]
		set
		{
		}
	}

	[Token(Token = "0x1700014F")]
	public long boosterCount
	{
		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0xA06F0C", Offset = "0xA06F0C", VA = "0xA06F0C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0xA06BA0", Offset = "0xA06BA0", VA = "0xA06BA0")]
		set
		{
		}
	}

	[Token(Token = "0x6000AA7")]
	[Address(RVA = "0xA06B08", Offset = "0xA06B08", VA = "0xA06B08")]
	public static string GetItemReference(int index)
	{
		return null;
	}

	[Token(Token = "0x6000AA8")]
	[Address(RVA = "0xA06B70", Offset = "0xA06B70", VA = "0xA06B70", Slot = "4")]
	public override void ResetTraits(bool resetLifeTimeQuantity = false)
	{
	}

	[Token(Token = "0x6000AB3")]
	[Address(RVA = "0xA06F64", Offset = "0xA06F64", VA = "0xA06F64")]
	public SpeedBoosterSlotItem()
	{
	}
}
