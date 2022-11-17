using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200034F")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F020", Offset = "0x81F020")]
	public class RDAutoConversion : BaseEntityDocument
	{
		[Token(Token = "0x4001010")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829238", Offset = "0x829238")]
		public string inputItemRef;

		[Token(Token = "0x4001011")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829270", Offset = "0x829270")]
		public string outputItemRef;

		[Token(Token = "0x4001012")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8292A8", Offset = "0x8292A8")]
		public double conversionRate;

		[Token(Token = "0x4001013")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8292E0", Offset = "0x8292E0")]
		public sbyte orderPriority;

		[Token(Token = "0x4001014")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829318", Offset = "0x829318")]
		public long amountToLeave;

		[Token(Token = "0x6001A2F")]
		[Address(RVA = "0x9BA194", Offset = "0x9BA194", VA = "0x9BA194")]
		public RDAutoConversion(string inReference)
		{
		}
	}
}
