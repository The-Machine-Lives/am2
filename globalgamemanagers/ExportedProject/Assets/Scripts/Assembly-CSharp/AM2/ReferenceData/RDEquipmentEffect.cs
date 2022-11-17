using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000371")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F2F8", Offset = "0x81F2F8")]
	public class RDEquipmentEffect : BaseEntityDocument
	{
		[Token(Token = "0x40010FA")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B75C", Offset = "0x82B75C")]
		public EEquipmentEffect effect;

		[Token(Token = "0x40010FB")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B794", Offset = "0x82B794")]
		public string parameter1;

		[Token(Token = "0x40010FC")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B7CC", Offset = "0x82B7CC")]
		public double minAmount;

		[Token(Token = "0x40010FD")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B804", Offset = "0x82B804")]
		public double maxAmount;

		[Token(Token = "0x6001B79")]
		[Address(RVA = "0x9BA480", Offset = "0x9BA480", VA = "0x9BA480")]
		public RDEquipmentEffect(string inReference)
		{
		}
	}
}
