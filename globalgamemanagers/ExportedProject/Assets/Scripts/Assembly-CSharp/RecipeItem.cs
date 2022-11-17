using Il2CppDummyDll;

[Token(Token = "0x2000184")]
public class RecipeItem : ResearchableUnlockableItem
{
	[Token(Token = "0x400092E")]
	public new const string mc_sItemType = "RecipeItem";

	[Token(Token = "0x400092F")]
	private const string c_sliderRate = "slider_rate";

	[Token(Token = "0x4000930")]
	private const string c_currentJobProgress = "progress";

	[Token(Token = "0x4000931")]
	private const string c_BuildInProgress = "in_progress";

	[Token(Token = "0x4000932")]
	private const string c_remainingSustainTime = "sustain";

	[Token(Token = "0x4000933")]
	private const float c_defaultSliderRate = 1f;

	[Token(Token = "0x4000934")]
	private const float c_defaultCurrentJobProgress = 0f;

	[Token(Token = "0x4000935")]
	private const bool c_defaultBuildInProgress = false;

	[Token(Token = "0x4000936")]
	private const double c_defaultRemainingSustainTime = 0.0;

	[Token(Token = "0x17000141")]
	public double sliderRate
	{
		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x9DC9B4", Offset = "0x9DC9B4", VA = "0x9DC9B4")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x9EEEC8", Offset = "0x9EEEC8", VA = "0x9EEEC8")]
		set
		{
		}
	}

	[Token(Token = "0x17000142")]
	public double currentJobProgress
	{
		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x9EEF3C", Offset = "0x9EEF3C", VA = "0x9EEF3C")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x9EEF9C", Offset = "0x9EEF9C", VA = "0x9EEF9C")]
		set
		{
		}
	}

	[Token(Token = "0x17000143")]
	public bool buildInProgress
	{
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x9EF070", Offset = "0x9EF070", VA = "0x9EF070")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x9EF0C8", Offset = "0x9EF0C8", VA = "0x9EF0C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000144")]
	public double remainingSustainTime
	{
		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x9EF12C", Offset = "0x9EF12C", VA = "0x9EF12C")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x9EF184", Offset = "0x9EF184", VA = "0x9EF184")]
		set
		{
		}
	}

	[Token(Token = "0x17000145")]
	public bool automatedByGenerationTime
	{
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x9EF214", Offset = "0x9EF214", VA = "0x9EF214")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000A8D")]
	[Address(RVA = "0x9EEDC8", Offset = "0x9EEDC8", VA = "0x9EEDC8", Slot = "4")]
	public override void ResetTraits(bool resetLifeTimeQuantity = false)
	{
	}

	[Token(Token = "0x6000A97")]
	[Address(RVA = "0x9EF230", Offset = "0x9EF230", VA = "0x9EF230")]
	public RecipeItem()
	{
	}
}
