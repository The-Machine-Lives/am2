using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200035B")]
	public class ItemConverter : ResearchableRuntimeData<RDItemConverter, ItemConverterItem>
	{
		[Token(Token = "0x4001060")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x829EEC", Offset = "0x829EEC")]
		private Formula _003CoverrrideInputFormula_003Ek__BackingField;

		[Token(Token = "0x4001061")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x829EFC", Offset = "0x829EFC")]
		private Formula _003CoverrideOutputFormula_003Ek__BackingField;

		[Token(Token = "0x4001062")]
		[FieldOffset(Offset = "0x78")]
		public RewardGroup rewardGroup;

		[Token(Token = "0x4001063")]
		[FieldOffset(Offset = "0x80")]
		private GlobalScalerContainer globalScalers;

		[Token(Token = "0x1700044C")]
		public override string readableItemName
		{
			[Token(Token = "0x6001A7E")]
			[Address(RVA = "0x9B53C4", Offset = "0x9B53C4", VA = "0x9B53C4", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700044D")]
		public string readableName
		{
			[Token(Token = "0x6001A7F")]
			[Address(RVA = "0x9B540C", Offset = "0x9B540C", VA = "0x9B540C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700044E")]
		public string inputItemRef
		{
			[Token(Token = "0x6001A80")]
			[Address(RVA = "0x9B5438", Offset = "0x9B5438", VA = "0x9B5438")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700044F")]
		public string overrideReadableName
		{
			[Token(Token = "0x6001A81")]
			[Address(RVA = "0x9B5464", Offset = "0x9B5464", VA = "0x9B5464")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000450")]
		public string overrideButtonName
		{
			[Token(Token = "0x6001A82")]
			[Address(RVA = "0x9B5490", Offset = "0x9B5490", VA = "0x9B5490")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000451")]
		public long inputItemQuantity
		{
			[Token(Token = "0x6001A83")]
			[Address(RVA = "0x9B54BC", Offset = "0x9B54BC", VA = "0x9B54BC")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000452")]
		public Formula overrrideInputFormula
		{
			[Token(Token = "0x6001A84")]
			[Address(RVA = "0x9B54E8", Offset = "0x9B54E8", VA = "0x9B54E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837F60", Offset = "0x837F60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A85")]
			[Address(RVA = "0x9B54F0", Offset = "0x9B54F0", VA = "0x9B54F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837F70", Offset = "0x837F70")]
			private set
			{
			}
		}

		[Token(Token = "0x17000453")]
		public string outputItemRef
		{
			[Token(Token = "0x6001A86")]
			[Address(RVA = "0x9B54F8", Offset = "0x9B54F8", VA = "0x9B54F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000454")]
		public long outputItemQuantity
		{
			[Token(Token = "0x6001A87")]
			[Address(RVA = "0x9B5524", Offset = "0x9B5524", VA = "0x9B5524")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000455")]
		public Formula overrideOutputFormula
		{
			[Token(Token = "0x6001A88")]
			[Address(RVA = "0x9B557C", Offset = "0x9B557C", VA = "0x9B557C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837F80", Offset = "0x837F80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A89")]
			[Address(RVA = "0x9B5584", Offset = "0x9B5584", VA = "0x9B5584")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837F90", Offset = "0x837F90")]
			private set
			{
			}
		}

		[Token(Token = "0x6001A8A")]
		[Address(RVA = "0x9B558C", Offset = "0x9B558C", VA = "0x9B558C")]
		public ItemConverter()
		{
		}

		[Token(Token = "0x6001A8B")]
		[Address(RVA = "0x9B55E8", Offset = "0x9B55E8", VA = "0x9B55E8")]
		public void Setup(RuntimeDataCache<SubTab, RDSubTab> subTabCache, RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache, RuntimeDataCache<Section, RDSection> sectionCache, RuntimeDataCache<Formula, RDFormula> formulas)
		{
		}
	}
}
