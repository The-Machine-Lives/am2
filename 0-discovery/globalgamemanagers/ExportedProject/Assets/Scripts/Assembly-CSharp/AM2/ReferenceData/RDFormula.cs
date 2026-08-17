using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000357")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F0C8", Offset = "0x81F0C8")]
	public class RDFormula : BaseEntityDocument
	{
		[Token(Token = "0x4001042")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82982C", Offset = "0x82982C")]
		public EFormulaType formulaType;

		[Token(Token = "0x4001043")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829864", Offset = "0x829864")]
		public string descriptiveName;

		[Token(Token = "0x4001044")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82989C", Offset = "0x82989C")]
		public double constant1;

		[Token(Token = "0x4001045")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8298D4", Offset = "0x8298D4")]
		public double constant2;

		[Token(Token = "0x4001046")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82990C", Offset = "0x82990C")]
		public double constant3;

		[Token(Token = "0x4001047")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829944", Offset = "0x829944")]
		public double constant4;

		[Token(Token = "0x4001048")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82997C", Offset = "0x82997C")]
		public double bonus1;

		[Token(Token = "0x4001049")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8299B4", Offset = "0x8299B4")]
		public double exponent1;

		[Token(Token = "0x400104A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8299EC", Offset = "0x8299EC")]
		public double exponent2;

		[Token(Token = "0x400104B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "EntityReference", RVA = "0x829A24", Offset = "0x829A24")]
		public string nestedFormula1;

		[Token(Token = "0x400104C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "EntityReference", RVA = "0x829A5C", Offset = "0x829A5C")]
		public string nestedFormula2;

		[Token(Token = "0x400104D")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829A94", Offset = "0x829A94")]
		public List<double> customNumbersIndices;

		[Token(Token = "0x400104E")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829ACC", Offset = "0x829ACC")]
		public List<double> customNumbers;

		[Token(Token = "0x6001A70")]
		[Address(RVA = "0x9BA4A8", Offset = "0x9BA4A8", VA = "0x9BA4A8")]
		public RDFormula(string _ref)
		{
		}

		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x9B36BC", Offset = "0x9B36BC", VA = "0x9B36BC")]
		public bool IsBonusType()
		{
			return default(bool);
		}
	}
}
