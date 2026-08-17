using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x200017E")]
public class PlayerDataItem : Item
{
	[Token(Token = "0x4000916")]
	public const string c_unsetVersion = "0.0.0";

	[Token(Token = "0x4000917")]
	public new const string mc_sItemType = "PlayerDataItem";

	[Token(Token = "0x4000918")]
	[FieldOffset(Offset = "0x0")]
	public static string mc_sReference;

	[Token(Token = "0x4000919")]
	public const string c_defaultVersionCode = "0.0.0";

	[Token(Token = "0x400091A")]
	public const string mc_sPowerPressedElapsedTrait = "power_pressed";

	[Token(Token = "0x400091B")]
	public const string mc_sLastUpdatedSecondDateTrait = "last_sec";

	[Token(Token = "0x400091C")]
	public const string c_previouslyLoadedVersion = "prev_version";

	[Token(Token = "0x400091D")]
	public const string c_quantity = "quantity";

	[Token(Token = "0x400091E")]
	public const string c_betaUser = "beta_user";

	[Token(Token = "0x400091F")]
	public const string c_userName = "user_name";

	[Token(Token = "0x4000920")]
	public const long c_defaultQuantity = 1L;

	[Token(Token = "0x17000136")]
	public double lastUpdatedSecondDate
	{
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x99FA50", Offset = "0x99FA50", VA = "0x99FA50")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x99FAA8", Offset = "0x99FAA8", VA = "0x99FAA8")]
		set
		{
		}
	}

	[Token(Token = "0x17000137")]
	public double timeInSecondsSincePowerButtonPressed
	{
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x99FB0C", Offset = "0x99FB0C", VA = "0x99FB0C")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x99FB68", Offset = "0x99FB68", VA = "0x99FB68")]
		set
		{
		}
	}

	[Token(Token = "0x17000138")]
	public string previouslyLoadedVersion
	{
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x99FBCC", Offset = "0x99FBCC", VA = "0x99FBCC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x99FC2C", Offset = "0x99FC2C", VA = "0x99FC2C")]
		set
		{
		}
	}

	[Token(Token = "0x17000139")]
	public bool betaUser
	{
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x99FC90", Offset = "0x99FC90", VA = "0x99FC90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x99FCE8", Offset = "0x99FCE8", VA = "0x99FCE8")]
		set
		{
		}
	}

	[Token(Token = "0x1700013A")]
	public string userName
	{
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x99FD4C", Offset = "0x99FD4C", VA = "0x99FD4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x99FDAC", Offset = "0x99FDAC", VA = "0x99FDAC")]
		set
		{
		}
	}

	[Token(Token = "0x6000A68")]
	[Address(RVA = "0x99F9D4", Offset = "0x99F9D4", VA = "0x99F9D4")]
	public PlayerDataItem()
	{
	}

	[Token(Token = "0x6000A69")]
	[Address(RVA = "0x99F9DC", Offset = "0x99F9DC", VA = "0x99F9DC", Slot = "4")]
	public override void ResetTraits(bool resetLifeTimeQuantity = false)
	{
	}

	[Token(Token = "0x6000A74")]
	[Address(RVA = "0x99FE10", Offset = "0x99FE10", VA = "0x99FE10", Slot = "5")]
	public override bool ValidateTrait(string sName, object oValue)
	{
		return default(bool);
	}
}
