using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200036B")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F288", Offset = "0x81F288")]
	public class RDUpgradable : BaseEntityDocument
	{
		[Token(Token = "0x40010CE")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "EntityReference", RVA = "0x82B18C", Offset = "0x82B18C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B18C", Offset = "0x82B18C")]
		public List<string> costResources;

		[Token(Token = "0x40010CF")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "EntityReference", RVA = "0x82B1EC", Offset = "0x82B1EC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B1EC", Offset = "0x82B1EC")]
		public List<string> levelGates;

		[Token(Token = "0x40010D0")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82B24C", Offset = "0x82B24C")]
		[Attribute(Name = "EntityReference", RVA = "0x82B24C", Offset = "0x82B24C")]
		public string amountFormula;

		[Token(Token = "0x40010D1")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82B29C", Offset = "0x82B29C")]
		[Attribute(Name = "EntityReference", RVA = "0x82B29C", Offset = "0x82B29C")]
		public string costFormula;

		[Token(Token = "0x40010D2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "EntityReference", RVA = "0x82B2EC", Offset = "0x82B2EC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B2EC", Offset = "0x82B2EC")]
		public string researchableSubTab;

		[Token(Token = "0x40010D3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "EntityReference", RVA = "0x82B34C", Offset = "0x82B34C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B34C", Offset = "0x82B34C")]
		public string section;

		[Token(Token = "0x40010D4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82B3AC", Offset = "0x82B3AC")]
		[Attribute(Name = "EntityReference", RVA = "0x82B3AC", Offset = "0x82B3AC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B3AC", Offset = "0x82B3AC")]
		public string costItemRef;

		[Token(Token = "0x40010D5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B420", Offset = "0x82B420")]
		public long maxLevel;

		[Token(Token = "0x40010D6")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B458", Offset = "0x82B458")]
		public EBuyType buyType;

		[Token(Token = "0x40010D7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B490", Offset = "0x82B490")]
		public string buyName;

		[Token(Token = "0x40010D8")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B4C8", Offset = "0x82B4C8")]
		public ENumericDisplayType amountDisplayType;

		[Token(Token = "0x40010D9")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B500", Offset = "0x82B500")]
		public string researchInfoText;

		[Token(Token = "0x40010DA")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B538", Offset = "0x82B538")]
		public BISoundEvents.EventKey upgradeClickSoundEventOverride;

		[Token(Token = "0x40010DB")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B570", Offset = "0x82B570")]
		public BISoundEvents.EventKey bonusUpgradeClickSoundEventOverride;

		[Token(Token = "0x6001B30")]
		[Address(RVA = "0x9BAB4C", Offset = "0x9BAB4C", VA = "0x9BAB4C")]
		public RDUpgradable(string _ref)
		{
		}
	}
}
