using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000381")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F448", Offset = "0x81F448")]
	public class RDPrestigeLevel : BaseEntityDocument
	{
		[Token(Token = "0x4001112")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82BB90", Offset = "0x82BB90")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82BB90", Offset = "0x82BB90")]
		public string readableName;

		[Token(Token = "0x4001113")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82BBE0", Offset = "0x82BBE0")]
		[Attribute(Name = "EntityReference", RVA = "0x82BBE0", Offset = "0x82BBE0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82BBE0", Offset = "0x82BBE0")]
		public string prestigeTokensReference;

		[Token(Token = "0x4001114")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82BC54", Offset = "0x82BC54")]
		[Attribute(Name = "EntityReference", RVA = "0x82BC54", Offset = "0x82BC54")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82BC54", Offset = "0x82BC54")]
		public string machineLevelUpgradableReference;

		[Token(Token = "0x4001115")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82BCC8", Offset = "0x82BCC8")]
		[Attribute(Name = "EntityReference", RVA = "0x82BCC8", Offset = "0x82BCC8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82BCC8", Offset = "0x82BCC8")]
		public string machineLevelFormula;

		[Token(Token = "0x4001116")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82BD3C", Offset = "0x82BD3C")]
		[Attribute(Name = "EntityReference", RVA = "0x82BD3C", Offset = "0x82BD3C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82BD3C", Offset = "0x82BD3C")]
		public string powerSpeedReference;

		[Token(Token = "0x4001117")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82BDB0", Offset = "0x82BDB0")]
		[Attribute(Name = "EntityReference", RVA = "0x82BDB0", Offset = "0x82BDB0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82BDB0", Offset = "0x82BDB0")]
		public string powerSpeedFormula;

		[Token(Token = "0x4001118")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82BE24", Offset = "0x82BE24")]
		[Attribute(Name = "EntityReference", RVA = "0x82BE24", Offset = "0x82BE24")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82BE24", Offset = "0x82BE24")]
		public string powerBonusSpeedSustainReference;

		[Token(Token = "0x4001119")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82BE98", Offset = "0x82BE98")]
		[Attribute(Name = "EntityReference", RVA = "0x82BE98", Offset = "0x82BE98")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82BE98", Offset = "0x82BE98")]
		public string powerBonusSpeedResearchFormula;

		[Token(Token = "0x400111A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82BF0C", Offset = "0x82BF0C")]
		[Attribute(Name = "EntityReference", RVA = "0x82BF0C", Offset = "0x82BF0C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82BF0C", Offset = "0x82BF0C")]
		public string powerSustainReference;

		[Token(Token = "0x400111B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82BF80", Offset = "0x82BF80")]
		[Attribute(Name = "EntityReference", RVA = "0x82BF80", Offset = "0x82BF80")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82BF80", Offset = "0x82BF80")]
		public string powerSustainFormula;

		[Token(Token = "0x400111C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82BFF4", Offset = "0x82BFF4")]
		[Attribute(Name = "EntityReference", RVA = "0x82BFF4", Offset = "0x82BFF4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82BFF4", Offset = "0x82BFF4")]
		public List<string> boosterItemReferences;

		[Token(Token = "0x400111D")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82C068", Offset = "0x82C068")]
		[Attribute(Name = "EntityReference", RVA = "0x82C068", Offset = "0x82C068")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C068", Offset = "0x82C068")]
		public string boostersFormula;

		[Token(Token = "0x400111E")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82C0DC", Offset = "0x82C0DC")]
		[Attribute(Name = "EntityReference", RVA = "0x82C0DC", Offset = "0x82C0DC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C0DC", Offset = "0x82C0DC")]
		public string shardsItemReference;

		[Token(Token = "0x400111F")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82C150", Offset = "0x82C150")]
		[Attribute(Name = "EntityReference", RVA = "0x82C150", Offset = "0x82C150")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C150", Offset = "0x82C150")]
		public string shardsFormula;

		[Token(Token = "0x4001120")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82C1C4", Offset = "0x82C1C4")]
		[Attribute(Name = "EntityReference", RVA = "0x82C1C4", Offset = "0x82C1C4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C1C4", Offset = "0x82C1C4")]
		public string mTokenItemReference;

		[Token(Token = "0x4001121")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82C238", Offset = "0x82C238")]
		[Attribute(Name = "EntityReference", RVA = "0x82C238", Offset = "0x82C238")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C238", Offset = "0x82C238")]
		public string mTokensFormula;

		[Token(Token = "0x6001BA5")]
		[Address(RVA = "0x9BA6A4", Offset = "0x9BA6A4", VA = "0x9BA6A4")]
		public RDPrestigeLevel(string inReference)
		{
		}
	}
}
