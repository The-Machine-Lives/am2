using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000367")]
	public class ResearchSystem : RuntimeData<RDResearchSystem>, IItemModel, IInfoText
	{
		[Token(Token = "0x40010AC")]
		public const string c_researchResourceName = "research";

		[Token(Token = "0x40010AD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82ADB4", Offset = "0x82ADB4")]
		private Upgradable _003CpowerSustainTime_003Ek__BackingField;

		[Token(Token = "0x40010AE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82ADC4", Offset = "0x82ADC4")]
		private Upgradable _003CpowerGrowthRate_003Ek__BackingField;

		[Token(Token = "0x40010AF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82ADD4", Offset = "0x82ADD4")]
		private Upgradable _003CpowerDecayTime_003Ek__BackingField;

		[Token(Token = "0x40010B0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82ADE4", Offset = "0x82ADE4")]
		private Upgradable _003CmaxRateUpgradable_003Ek__BackingField;

		[Token(Token = "0x40010B1")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82ADF4", Offset = "0x82ADF4")]
		private Upgradable _003CloadoutSlots_003Ek__BackingField;

		[Token(Token = "0x40010B2")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82AE04", Offset = "0x82AE04")]
		private Upgradable _003CresearchSlots_003Ek__BackingField;

		[Token(Token = "0x40010B3")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82AE14", Offset = "0x82AE14")]
		private Upgradable _003CequipmentSlots_003Ek__BackingField;

		[Token(Token = "0x40010B4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82AE24", Offset = "0x82AE24")]
		private Upgradable _003CglobalPrestigeSpeedBoost_003Ek__BackingField;

		[Token(Token = "0x17000489")]
		public Upgradable powerSustainTime
		{
			[Token(Token = "0x6001AEE")]
			[Address(RVA = "0x96B000", Offset = "0x96B000", VA = "0x96B000")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8381C0", Offset = "0x8381C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AEF")]
			[Address(RVA = "0x96B008", Offset = "0x96B008", VA = "0x96B008")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8381D0", Offset = "0x8381D0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700048A")]
		public Upgradable powerGrowthRate
		{
			[Token(Token = "0x6001AF0")]
			[Address(RVA = "0x96B010", Offset = "0x96B010", VA = "0x96B010")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8381E0", Offset = "0x8381E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AF1")]
			[Address(RVA = "0x96B018", Offset = "0x96B018", VA = "0x96B018")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8381F0", Offset = "0x8381F0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700048B")]
		public Upgradable powerDecayTime
		{
			[Token(Token = "0x6001AF2")]
			[Address(RVA = "0x96B020", Offset = "0x96B020", VA = "0x96B020")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838200", Offset = "0x838200")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AF3")]
			[Address(RVA = "0x96B028", Offset = "0x96B028", VA = "0x96B028")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838210", Offset = "0x838210")]
			private set
			{
			}
		}

		[Token(Token = "0x1700048C")]
		public Upgradable maxRateUpgradable
		{
			[Token(Token = "0x6001AF4")]
			[Address(RVA = "0x96B030", Offset = "0x96B030", VA = "0x96B030")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838220", Offset = "0x838220")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AF5")]
			[Address(RVA = "0x96B038", Offset = "0x96B038", VA = "0x96B038")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838230", Offset = "0x838230")]
			private set
			{
			}
		}

		[Token(Token = "0x1700048D")]
		public Upgradable loadoutSlots
		{
			[Token(Token = "0x6001AF6")]
			[Address(RVA = "0x96B040", Offset = "0x96B040", VA = "0x96B040")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838240", Offset = "0x838240")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AF7")]
			[Address(RVA = "0x96B048", Offset = "0x96B048", VA = "0x96B048")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838250", Offset = "0x838250")]
			private set
			{
			}
		}

		[Token(Token = "0x1700048E")]
		public Upgradable researchSlots
		{
			[Token(Token = "0x6001AF8")]
			[Address(RVA = "0x96B050", Offset = "0x96B050", VA = "0x96B050")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838260", Offset = "0x838260")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AF9")]
			[Address(RVA = "0x96B058", Offset = "0x96B058", VA = "0x96B058")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838270", Offset = "0x838270")]
			private set
			{
			}
		}

		[Token(Token = "0x1700048F")]
		public Upgradable equipmentSlots
		{
			[Token(Token = "0x6001AFA")]
			[Address(RVA = "0x96B060", Offset = "0x96B060", VA = "0x96B060")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838280", Offset = "0x838280")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AFB")]
			[Address(RVA = "0x96B068", Offset = "0x96B068", VA = "0x96B068")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838290", Offset = "0x838290")]
			private set
			{
			}
		}

		[Token(Token = "0x17000490")]
		public Upgradable globalPrestigeSpeedBoost
		{
			[Token(Token = "0x6001AFC")]
			[Address(RVA = "0x96B070", Offset = "0x96B070", VA = "0x96B070")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8382A0", Offset = "0x8382A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AFD")]
			[Address(RVA = "0x96B078", Offset = "0x96B078", VA = "0x96B078")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8382B0", Offset = "0x8382B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000491")]
		public long maxRate
		{
			[Token(Token = "0x6001AFE")]
			[Address(RVA = "0x96B080", Offset = "0x96B080", VA = "0x96B080")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000492")]
		public string readableItemName
		{
			[Token(Token = "0x6001AFF")]
			[Address(RVA = "0x96B0F0", Offset = "0x96B0F0", VA = "0x96B0F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000493")]
		public string description
		{
			[Token(Token = "0x6001B00")]
			[Address(RVA = "0x96B138", Offset = "0x96B138", VA = "0x96B138", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000494")]
		public string dustOutputItem
		{
			[Token(Token = "0x6001B01")]
			[Address(RVA = "0x96B188", Offset = "0x96B188", VA = "0x96B188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000495")]
		public string researchInfoText
		{
			[Token(Token = "0x6001B02")]
			[Address(RVA = "0x96B1B4", Offset = "0x96B1B4", VA = "0x96B1B4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000496")]
		public string infoImageSource
		{
			[Token(Token = "0x6001B03")]
			[Address(RVA = "0x96B204", Offset = "0x96B204", VA = "0x96B204", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001B04")]
		[Address(RVA = "0x96B254", Offset = "0x96B254", VA = "0x96B254")]
		public ResearchSystem()
		{
		}

		[Token(Token = "0x6001B05")]
		[Address(RVA = "0x96B2A4", Offset = "0x96B2A4", VA = "0x96B2A4", Slot = "4")]
		public override void Initialize(RDResearchSystem researchSystem)
		{
		}

		[Token(Token = "0x6001B06")]
		[Address(RVA = "0x96B6DC", Offset = "0x96B6DC", VA = "0x96B6DC")]
		public double GetPowerSustainTime()
		{
			return default(double);
		}

		[Token(Token = "0x6001B07")]
		[Address(RVA = "0x96B73C", Offset = "0x96B73C", VA = "0x96B73C")]
		public int GetNumResearchSlots()
		{
			return default(int);
		}

		[Token(Token = "0x6001B08")]
		[Address(RVA = "0x96B77C", Offset = "0x96B77C", VA = "0x96B77C")]
		public int GetLoadoutSlotCount()
		{
			return default(int);
		}

		[Token(Token = "0x6001B09")]
		[Address(RVA = "0x96B7BC", Offset = "0x96B7BC", VA = "0x96B7BC")]
		public int GetEquipmentSlotCount()
		{
			return default(int);
		}

		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0x96B7FC", Offset = "0x96B7FC", VA = "0x96B7FC")]
		public double GetPrestigeGlobalSpeedBoost()
		{
			return default(double);
		}
	}
}
