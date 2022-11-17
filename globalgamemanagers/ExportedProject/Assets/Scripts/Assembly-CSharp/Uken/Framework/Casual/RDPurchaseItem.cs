using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200053D")]
	[Attribute(Name = "GroupAttribute", RVA = "0x820028", Offset = "0x820028")]
	public class RDPurchaseItem : BaseEntityDocument
	{
		[Token(Token = "0x40018D7")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "EntityReference", RVA = "0x83161C", Offset = "0x83161C")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x83161C", Offset = "0x83161C")]
		public string itemName;

		[Token(Token = "0x40018D8")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x83166C", Offset = "0x83166C")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x83166C", Offset = "0x83166C")]
		public int quantity;

		[Token(Token = "0x40018D9")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8316BC", Offset = "0x8316BC")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x8316BC", Offset = "0x8316BC")]
		public bool isScalable;

		[Token(Token = "0x40018DA")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x83170C", Offset = "0x83170C")]
		public string badgeTextTop;

		[Token(Token = "0x40018DB")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x831744", Offset = "0x831744")]
		public string badgeTextBottom;

		[Token(Token = "0x40018DC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x83177C", Offset = "0x83177C")]
		public string imageURL;

		[Token(Token = "0x600280D")]
		[Address(RVA = "0xA8184C", Offset = "0xA8184C", VA = "0xA8184C")]
		public RDPurchaseItem()
		{
		}
	}
}
