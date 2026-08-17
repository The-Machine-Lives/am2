using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200053E")]
	[Attribute(Name = "GroupAttribute", RVA = "0x820060", Offset = "0x820060")]
	public class RDSale : BaseEntityDocument
	{
		[Token(Token = "0x40018DD")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "EntityReference", RVA = "0x8317B4", Offset = "0x8317B4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8317B4", Offset = "0x8317B4")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x8317B4", Offset = "0x8317B4")]
		public List<string> purchaseItems;

		[Token(Token = "0x40018DE")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "EntityReference", RVA = "0x831828", Offset = "0x831828")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831828", Offset = "0x831828")]
		public string iapProduct;

		[Token(Token = "0x40018DF")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831888", Offset = "0x831888")]
		public string virtualCurrency;

		[Token(Token = "0x40018E0")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8318C0", Offset = "0x8318C0")]
		public int virtualCost;

		[Token(Token = "0x40018E1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8318F8", Offset = "0x8318F8")]
		public string bannerText;

		[Token(Token = "0x40018E2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831930", Offset = "0x831930")]
		public string badgeTextTop;

		[Token(Token = "0x40018E3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831968", Offset = "0x831968")]
		public string badgeTextBottom;

		[Token(Token = "0x600280E")]
		[Address(RVA = "0xA8193C", Offset = "0xA8193C", VA = "0xA8193C")]
		public RDSale()
		{
		}
	}
}
