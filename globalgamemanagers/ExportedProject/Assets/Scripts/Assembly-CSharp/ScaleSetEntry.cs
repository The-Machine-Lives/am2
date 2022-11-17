using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x2000203")]
public class ScaleSetEntry : RuntimeData<RDScaleSetEntry>
{
	[Token(Token = "0x4000B6D")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826124", Offset = "0x826124")]
	private int _003ClowerBound_003Ek__BackingField;

	[Token(Token = "0x4000B6E")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826134", Offset = "0x826134")]
	private int _003CupperBound_003Ek__BackingField;

	[Token(Token = "0x4000B6F")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826144", Offset = "0x826144")]
	private long _003Cscalar_003Ek__BackingField;

	[Token(Token = "0x4000B70")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826154", Offset = "0x826154")]
	private RewardGroup _003CoverrideRewardGroup_003Ek__BackingField;

	[Token(Token = "0x170001AA")]
	public int lowerBound
	{
		[Token(Token = "0x6000D92")]
		[Address(RVA = "0x9FE748", Offset = "0x9FE748", VA = "0x9FE748")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x835194", Offset = "0x835194")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D93")]
		[Address(RVA = "0x9FE750", Offset = "0x9FE750", VA = "0x9FE750")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8351A4", Offset = "0x8351A4")]
		set
		{
		}
	}

	[Token(Token = "0x170001AB")]
	public int upperBound
	{
		[Token(Token = "0x6000D94")]
		[Address(RVA = "0x9FE758", Offset = "0x9FE758", VA = "0x9FE758")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8351B4", Offset = "0x8351B4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D95")]
		[Address(RVA = "0x9FE760", Offset = "0x9FE760", VA = "0x9FE760")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8351C4", Offset = "0x8351C4")]
		set
		{
		}
	}

	[Token(Token = "0x170001AC")]
	public long scalar
	{
		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x9FE768", Offset = "0x9FE768", VA = "0x9FE768")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8351D4", Offset = "0x8351D4")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x9FE770", Offset = "0x9FE770", VA = "0x9FE770")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8351E4", Offset = "0x8351E4")]
		set
		{
		}
	}

	[Token(Token = "0x170001AD")]
	public RewardGroup overrideRewardGroup
	{
		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x9FE778", Offset = "0x9FE778", VA = "0x9FE778")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8351F4", Offset = "0x8351F4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D99")]
		[Address(RVA = "0x9FE780", Offset = "0x9FE780", VA = "0x9FE780")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x835204", Offset = "0x835204")]
		private set
		{
		}
	}

	[Token(Token = "0x6000D9A")]
	[Address(RVA = "0x9FE788", Offset = "0x9FE788", VA = "0x9FE788")]
	public ScaleSetEntry()
	{
	}

	[Token(Token = "0x6000D9B")]
	[Address(RVA = "0x9FE7D8", Offset = "0x9FE7D8", VA = "0x9FE7D8")]
	public ScaleSetEntry(int inLowerBound, int inUpperBound, long inScalar, RewardGroup inOverrideRewardGroup)
	{
	}

	[Token(Token = "0x6000D9C")]
	[Address(RVA = "0x9FE854", Offset = "0x9FE854", VA = "0x9FE854", Slot = "4")]
	public override void Initialize(RDScaleSetEntry referenceData)
	{
	}

	[Token(Token = "0x6000D9D")]
	[Address(RVA = "0x9FEA18", Offset = "0x9FEA18", VA = "0x9FEA18")]
	public bool HasMatchingBounds(ScaleSetEntry entry)
	{
		return default(bool);
	}
}
