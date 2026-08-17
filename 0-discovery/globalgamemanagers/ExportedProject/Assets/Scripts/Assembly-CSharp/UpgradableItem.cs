using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x200018E")]
public class UpgradableItem : Item
{
	[Token(Token = "0x4000962")]
	public new const string mc_sItemType = "UpgradableItem";

	[Token(Token = "0x4000963")]
	private const string c_currentResearchProgress = "progress";

	[Token(Token = "0x4000964")]
	private const string c_remainingTimeToProgressInSeconds = "countdown";

	[Token(Token = "0x4000965")]
	private const long c_defaultResearchProgress = 0L;

	[Token(Token = "0x4000966")]
	private const long c_defaultRemainingTimeToProgressInSeconds = 0L;

	[Token(Token = "0x17000159")]
	public long researchProgress
	{
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0xAB52B8", Offset = "0xAB52B8", VA = "0xAB52B8")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0xAB5310", Offset = "0xAB5310", VA = "0xAB5310")]
		set
		{
		}
	}

	[Token(Token = "0x1700015A")]
	public double remainingTimeToProgressInSeconds
	{
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0xAB5374", Offset = "0xAB5374", VA = "0xAB5374")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0xAB53CC", Offset = "0xAB53CC", VA = "0xAB53CC")]
		set
		{
		}
	}

	[Token(Token = "0x6000AD4")]
	[Address(RVA = "0xAB5254", Offset = "0xAB5254", VA = "0xAB5254", Slot = "4")]
	public override void ResetTraits(bool resetLifeTimeQuantity = false)
	{
	}

	[Token(Token = "0x6000AD9")]
	[Address(RVA = "0xAB5430", Offset = "0xAB5430", VA = "0xAB5430")]
	public UpgradableItem()
	{
	}
}
