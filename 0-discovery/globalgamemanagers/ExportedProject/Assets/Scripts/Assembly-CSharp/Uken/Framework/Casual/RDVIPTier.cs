using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000556")]
	[Attribute(Name = "GroupAttribute", RVA = "0x820178", Offset = "0x820178")]
	public class RDVIPTier : BaseEntityDocument
	{
		[Token(Token = "0x4001971")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8326F0", Offset = "0x8326F0")]
		public int Tier;

		[Token(Token = "0x4001972")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x832728", Offset = "0x832728")]
		public int RequiredVIPPoints;

		[Token(Token = "0x4001973")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x832760", Offset = "0x832760")]
		public float PurchaseScaleMultiplier;

		[Token(Token = "0x4001974")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x832798", Offset = "0x832798")]
		public float dailySpinnerMultiplier;

		[Token(Token = "0x4001975")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8327D0", Offset = "0x8327D0")]
		public string LargeIconPath;

		[Token(Token = "0x4001976")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x832808", Offset = "0x832808")]
		public string SmallIconPath;

		[Token(Token = "0x4001977")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x832840", Offset = "0x832840")]
		public string TierName;

		[Token(Token = "0x60028E5")]
		[Address(RVA = "0xA81CBC", Offset = "0xA81CBC", VA = "0xA81CBC")]
		public RDVIPTier(string refName)
		{
		}
	}
}
