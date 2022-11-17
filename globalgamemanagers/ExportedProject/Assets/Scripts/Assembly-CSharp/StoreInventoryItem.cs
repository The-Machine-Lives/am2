using System;
using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x2000189")]
public class StoreInventoryItem : Item
{
	[Token(Token = "0x400094B")]
	public new const string mc_sItemType = "StoreItem";

	[Token(Token = "0x400094C")]
	private const string c_firstSeenEpoch = "first_seen_epoch";

	[Token(Token = "0x400094D")]
	private const string c_hasBeenSeen = "has_been_seen";

	[Token(Token = "0x400094E")]
	private const string c_timeOfferWasUnlocked = "time_offer_was_unlocked";

	[Token(Token = "0x400094F")]
	private const string c_numberOfTimesSeenByUser = "number_of_times_seen_by_user";

	[Token(Token = "0x4000950")]
	private const string c_cooldownTimeSeconds = "cooldown_time_seconds";

	[Token(Token = "0x4000951")]
	private const string c_dateOfferWasLastPurchased = "date_offer_last_purchased";

	[Token(Token = "0x4000952")]
	private const string c_lastActiveTimeslot = "last_active_timeslot";

	[Token(Token = "0x4000953")]
	private const string c_timeslotIteration = "timeslot_iteration";

	[Token(Token = "0x4000954")]
	private const long c_defaultNumberOfTimesSeen = 0L;

	[Token(Token = "0x4000955")]
	private const bool c_defaultHasBeenSeen = false;

	[Token(Token = "0x4000956")]
	private const string c_defaultLastActiveTimeslot = "";

	[Token(Token = "0x4000957")]
	private const long c_defaultCooldownSeconds = 0L;

	[Token(Token = "0x4000958")]
	[FieldOffset(Offset = "0x20")]
	private readonly DateTime c_defaultDateTime;

	[Token(Token = "0x17000150")]
	public DateTime dateOfferFirstSeenByUser
	{
		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0xA09E8C", Offset = "0xA09E8C", VA = "0xA09E8C")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0xA09F48", Offset = "0xA09F48", VA = "0xA09F48")]
		set
		{
		}
	}

	[Token(Token = "0x17000151")]
	public DateTime dateOfferLastPurchased
	{
		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0xA0A1EC", Offset = "0xA0A1EC", VA = "0xA0A1EC")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0xA0A298", Offset = "0xA0A298", VA = "0xA0A298")]
		set
		{
		}
	}

	[Token(Token = "0x17000152")]
	public long numberOfTimesSeen
	{
		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0xA09FB8", Offset = "0xA09FB8", VA = "0xA09FB8")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0xA0A010", Offset = "0xA0A010", VA = "0xA0A010")]
		set
		{
		}
	}

	[Token(Token = "0x17000153")]
	public DateTime dateOfferWasUnlockedByUser
	{
		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0xA0A074", Offset = "0xA0A074", VA = "0xA0A074")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0xA0A308", Offset = "0xA0A308", VA = "0xA0A308")]
		set
		{
		}
	}

	[Token(Token = "0x17000154")]
	public bool hasBeenSeen
	{
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0xA0A130", Offset = "0xA0A130", VA = "0xA0A130")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0xA0A188", Offset = "0xA0A188", VA = "0xA0A188")]
		set
		{
		}
	}

	[Token(Token = "0x17000155")]
	public long coolDownTimeSeconds
	{
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0xA0A378", Offset = "0xA0A378", VA = "0xA0A378")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0xA0A3D0", Offset = "0xA0A3D0", VA = "0xA0A3D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000156")]
	public string lastActiveTimeSlotReference
	{
		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0xA0A434", Offset = "0xA0A434", VA = "0xA0A434")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0xA0A494", Offset = "0xA0A494", VA = "0xA0A494")]
		set
		{
		}
	}

	[Token(Token = "0x17000157")]
	public int lastActiveTimeSlotIteration
	{
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0xA0A4F8", Offset = "0xA0A4F8", VA = "0xA0A4F8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0xA0A550", Offset = "0xA0A550", VA = "0xA0A550")]
		set
		{
		}
	}

	[Token(Token = "0x6000AB4")]
	[Address(RVA = "0xA09D54", Offset = "0xA09D54", VA = "0xA09D54", Slot = "4")]
	public override void ResetTraits(bool resetLifeTimeQuantity = false)
	{
	}

	[Token(Token = "0x6000AC5")]
	[Address(RVA = "0xA0A5B4", Offset = "0xA0A5B4", VA = "0xA0A5B4")]
	public StoreInventoryItem()
	{
	}
}
