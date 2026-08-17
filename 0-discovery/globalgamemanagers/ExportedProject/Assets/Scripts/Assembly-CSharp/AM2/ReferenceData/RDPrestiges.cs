using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000389")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F4F0", Offset = "0x81F4F0")]
	public class RDPrestiges : BaseEntityDocument
	{
		[Token(Token = "0x4001149")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82C998", Offset = "0x82C998")]
		[Attribute(Name = "EntityReference", RVA = "0x82C998", Offset = "0x82C998")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82C998", Offset = "0x82C998")]
		public string upgradeable;

		[Token(Token = "0x400114A")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CA0C", Offset = "0x82CA0C")]
		public bool allowAmountDecimal;

		[Token(Token = "0x6001BD4")]
		[Address(RVA = "0x9BA8E0", Offset = "0x9BA8E0", VA = "0x9BA8E0")]
		public RDPrestiges(string inReference)
		{
		}
	}
}
