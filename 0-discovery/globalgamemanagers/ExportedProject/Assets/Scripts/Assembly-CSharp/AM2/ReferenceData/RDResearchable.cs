using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000368")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F250", Offset = "0x81F250")]
	public abstract class RDResearchable : BaseEntityDocument
	{
		[Token(Token = "0x40010B5")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82AE34", Offset = "0x82AE34")]
		public string buyName;

		[Token(Token = "0x40010B6")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "EntityReference", RVA = "0x82AE6C", Offset = "0x82AE6C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82AE6C", Offset = "0x82AE6C")]
		public string costItemRef;

		[Token(Token = "0x40010B7")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82AECC", Offset = "0x82AECC")]
		public long costQuantity;

		[Token(Token = "0x40010B8")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82AF04", Offset = "0x82AF04")]
		public EBuyType buyType;

		[Token(Token = "0x40010B9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "EntityReference", RVA = "0x82AF3C", Offset = "0x82AF3C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82AF3C", Offset = "0x82AF3C")]
		public string onResearchRewardGroup;

		[Token(Token = "0x40010BA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "EntityReference", RVA = "0x82AF9C", Offset = "0x82AF9C")]
		public string researchableSubTab;

		[Token(Token = "0x40010BB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "EntityReference", RVA = "0x82AFD4", Offset = "0x82AFD4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82AFD4", Offset = "0x82AFD4")]
		public string sectionRef;

		[Token(Token = "0x40010BC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "EntityReference", RVA = "0x82B034", Offset = "0x82B034")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B034", Offset = "0x82B034")]
		public string researchableSectionRef;

		[Token(Token = "0x40010BD")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B094", Offset = "0x82B094")]
		public string infoText;

		[Token(Token = "0x40010BE")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B0CC", Offset = "0x82B0CC")]
		public string researchInfoText;

		[Token(Token = "0x40010BF")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B104", Offset = "0x82B104")]
		public string infoImageSource;

		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x9BA610", Offset = "0x9BA610", VA = "0x9BA610")]
		public RDResearchable(string _ref)
		{
		}
	}
}
