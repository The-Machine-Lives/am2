using Il2CppDummyDll;

[Token(Token = "0x2000185")]
public class ResearchableUnlockableItem : VisiblyUnlockableItem
{
	[Token(Token = "0x4000937")]
	private const string c_currentResearchProgress = "progress";

	[Token(Token = "0x4000938")]
	private const string c_remainingTimeToProgressInSeconds = "countdown";

	[Token(Token = "0x4000939")]
	private const long c_defaultResearchProgress = 0L;

	[Token(Token = "0x400093A")]
	private const double c_defaultRemainingTimeToProgressInSeconds = 0.0;

	[Token(Token = "0x17000146")]
	public long researchProgress
	{
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x9F85DC", Offset = "0x9F85DC", VA = "0x9F85DC")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x9F8634", Offset = "0x9F8634", VA = "0x9F8634")]
		set
		{
		}
	}

	[Token(Token = "0x17000147")]
	public double remainingTimeToProgressInSeconds
	{
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x9F8698", Offset = "0x9F8698", VA = "0x9F8698")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x9F86F0", Offset = "0x9F86F0", VA = "0x9F86F0")]
		set
		{
		}
	}

	[Token(Token = "0x6000A98")]
	[Address(RVA = "0x9EEE64", Offset = "0x9EEE64", VA = "0x9EEE64", Slot = "4")]
	public override void ResetTraits(bool resetLifeTimeQuantity = false)
	{
	}

	[Token(Token = "0x6000A9D")]
	[Address(RVA = "0x9EF238", Offset = "0x9EF238", VA = "0x9EF238")]
	public ResearchableUnlockableItem()
	{
	}
}
