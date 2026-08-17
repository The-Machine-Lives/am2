using AM2.ReferenceData;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000515")]
	public class Reward : RuntimeData<RDReward>, IWeighted
	{
		[Token(Token = "0x40017D4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8302F0", Offset = "0x8302F0")]
		private Formula _003CquantityFormula_003Ek__BackingField;

		[Token(Token = "0x40017D5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x830300", Offset = "0x830300")]
		private Reward _003CaltReward_003Ek__BackingField;

		[Token(Token = "0x40017D6")]
		[FieldOffset(Offset = "0x28")]
		private GlobalScalerContainer globalScalers;

		[Token(Token = "0x40017D7")]
		[FieldOffset(Offset = "0x30")]
		private RecipeController m_recipeController;

		[Token(Token = "0x40017D8")]
		[FieldOffset(Offset = "0x38")]
		private ConstructionController m_constructionController;

		[Token(Token = "0x170006A1")]
		public string itemName
		{
			[Token(Token = "0x60026AA")]
			[Address(RVA = "0xA89548", Offset = "0xA89548", VA = "0xA89548")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006A2")]
		public long quantityMin
		{
			[Token(Token = "0x60026AB")]
			[Address(RVA = "0xA89574", Offset = "0xA89574", VA = "0xA89574")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170006A3")]
		public long quantityMax
		{
			[Token(Token = "0x60026AC")]
			[Address(RVA = "0xA895A0", Offset = "0xA895A0", VA = "0xA895A0")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170006A4")]
		public int weight
		{
			[Token(Token = "0x60026AD")]
			[Address(RVA = "0xA895CC", Offset = "0xA895CC", VA = "0xA895CC", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170006A5")]
		public float percentChance
		{
			[Token(Token = "0x60026AE")]
			[Address(RVA = "0xA895F8", Offset = "0xA895F8", VA = "0xA895F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170006A6")]
		public bool useMaxCapPercent
		{
			[Token(Token = "0x60026AF")]
			[Address(RVA = "0xA89624", Offset = "0xA89624", VA = "0xA89624")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170006A7")]
		public Formula quantityFormula
		{
			[Token(Token = "0x60026B0")]
			[Address(RVA = "0xA89684", Offset = "0xA89684", VA = "0xA89684")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A19C", Offset = "0x83A19C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60026B1")]
			[Address(RVA = "0xA8968C", Offset = "0xA8968C", VA = "0xA8968C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A1AC", Offset = "0x83A1AC")]
			private set
			{
			}
		}

		[Token(Token = "0x170006A8")]
		public bool hasAltReward
		{
			[Token(Token = "0x60026B2")]
			[Address(RVA = "0xA89694", Offset = "0xA89694", VA = "0xA89694")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170006A9")]
		public Reward altReward
		{
			[Token(Token = "0x60026B3")]
			[Address(RVA = "0xA896A4", Offset = "0xA896A4", VA = "0xA896A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A1BC", Offset = "0x83A1BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60026B4")]
			[Address(RVA = "0xA896AC", Offset = "0xA896AC", VA = "0xA896AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A1CC", Offset = "0x83A1CC")]
			private set
			{
			}
		}

		[Token(Token = "0x170006AA")]
		public bool dontDisplayToUser
		{
			[Token(Token = "0x60026B5")]
			[Address(RVA = "0xA896B4", Offset = "0xA896B4", VA = "0xA896B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60026B6")]
		[Address(RVA = "0xA896E0", Offset = "0xA896E0", VA = "0xA896E0", Slot = "4")]
		public override void Initialize(RDReward referenceData)
		{
		}

		[Token(Token = "0x60026B7")]
		[Address(RVA = "0xA89958", Offset = "0xA89958", VA = "0xA89958")]
		public void SetupAltReward()
		{
		}

		[Token(Token = "0x60026B8")]
		[Address(RVA = "0xA89AB4", Offset = "0xA89AB4", VA = "0xA89AB4")]
		public long CalculateRewardFormula(long level)
		{
			return default(long);
		}

		[Token(Token = "0x60026B9")]
		[Address(RVA = "0xA89B34", Offset = "0xA89B34", VA = "0xA89B34")]
		public long GetQuantityMin(long level = 0L)
		{
			return default(long);
		}

		[Token(Token = "0x60026BA")]
		[Address(RVA = "0xA89D6C", Offset = "0xA89D6C", VA = "0xA89D6C")]
		public long GetQuantityMax(long level = 0L)
		{
			return default(long);
		}

		[Token(Token = "0x60026BB")]
		[Address(RVA = "0xA89DF4", Offset = "0xA89DF4", VA = "0xA89DF4")]
		public long GetQuantity(long level = 0L)
		{
			return default(long);
		}

		[Token(Token = "0x60026BC")]
		[Address(RVA = "0xA89BBC", Offset = "0xA89BBC", VA = "0xA89BBC")]
		private long GetQuantityAsPercentage()
		{
			return default(long);
		}

		[Token(Token = "0x60026BD")]
		[Address(RVA = "0xA89F98", Offset = "0xA89F98", VA = "0xA89F98")]
		public Reward()
		{
		}
	}
}
