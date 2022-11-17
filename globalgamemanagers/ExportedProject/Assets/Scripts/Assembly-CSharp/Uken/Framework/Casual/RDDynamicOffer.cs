using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200053A")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81FF80", Offset = "0x81FF80")]
	public class RDDynamicOffer : BaseEntityDocument
	{
		[Token(Token = "0x200084D")]
		public class SaleSegmentData
		{
			[Token(Token = "0x40023D4")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "EntityReference", RVA = "0x833100", Offset = "0x833100")]
			[Attribute(Name = "DescriptionAttribute", RVA = "0x833100", Offset = "0x833100")]
			public string userSegment;

			[Token(Token = "0x40023D5")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "EntityReference", RVA = "0x833160", Offset = "0x833160")]
			[Attribute(Name = "DescriptionAttribute", RVA = "0x833160", Offset = "0x833160")]
			[Attribute(Name = "RequiredAttribute", RVA = "0x833160", Offset = "0x833160")]
			public string sale;

			[Token(Token = "0x40023D6")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "EntityReference", RVA = "0x8331D4", Offset = "0x8331D4")]
			[Attribute(Name = "DescriptionAttribute", RVA = "0x8331D4", Offset = "0x8331D4")]
			public string bonusItem;

			[Token(Token = "0x6003370")]
			[Address(RVA = "0xA80D5C", Offset = "0xA80D5C", VA = "0xA80D5C")]
			public SaleSegmentData()
			{
			}
		}

		[Token(Token = "0x40018BE")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830E20", Offset = "0x830E20")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x830E20", Offset = "0x830E20")]
		public int viewDurationInMinutes;

		[Token(Token = "0x40018BF")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x830E70", Offset = "0x830E70")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x830E70", Offset = "0x830E70")]
		public List<SaleSegmentData> saleSegments;

		[Token(Token = "0x600280A")]
		[Address(RVA = "0xA80D54", Offset = "0xA80D54", VA = "0xA80D54")]
		public RDDynamicOffer()
		{
		}
	}
}
