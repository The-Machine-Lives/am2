using System.Collections.Generic;
using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200035A")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F100", Offset = "0x81F100")]
	public class RDItemConverter : RDResearchable
	{
		[Token(Token = "0x4001053")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829B04", Offset = "0x829B04")]
		public string readableName;

		[Token(Token = "0x4001054")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x829B3C", Offset = "0x829B3C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829B3C", Offset = "0x829B3C")]
		public string inputItemRef;

		[Token(Token = "0x4001055")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829B8C", Offset = "0x829B8C")]
		public string overrideReadableName;

		[Token(Token = "0x4001056")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829BC4", Offset = "0x829BC4")]
		public string overrideButtonName;

		[Token(Token = "0x4001057")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829BFC", Offset = "0x829BFC")]
		public long inputItemQuantity;

		[Token(Token = "0x4001058")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "EntityReference", RVA = "0x829C34", Offset = "0x829C34")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829C34", Offset = "0x829C34")]
		public string overrrideInputFormula;

		[Token(Token = "0x4001059")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x829C94", Offset = "0x829C94")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829C94", Offset = "0x829C94")]
		public string outputItemRef;

		[Token(Token = "0x400105A")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829CE4", Offset = "0x829CE4")]
		public long outputItemQuantity;

		[Token(Token = "0x400105B")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "EntityReference", RVA = "0x829D1C", Offset = "0x829D1C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829D1C", Offset = "0x829D1C")]
		public string globalScaler;

		[Token(Token = "0x400105C")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "EntityReference", RVA = "0x829D7C", Offset = "0x829D7C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829D7C", Offset = "0x829D7C")]
		public List<string> miniEventScalers;

		[Token(Token = "0x400105D")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "EntityReference", RVA = "0x829DDC", Offset = "0x829DDC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829DDC", Offset = "0x829DDC")]
		public string overrrideOutputFormula;

		[Token(Token = "0x400105E")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x829E3C", Offset = "0x829E3C")]
		[Attribute(Name = "EntityReference", RVA = "0x829E3C", Offset = "0x829E3C")]
		public string subTab;

		[Token(Token = "0x400105F")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "EntityReference", RVA = "0x829E8C", Offset = "0x829E8C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829E8C", Offset = "0x829E8C")]
		public string rewardGroup;

		[Token(Token = "0x6001A7D")]
		[Address(RVA = "0x9BA600", Offset = "0x9BA600", VA = "0x9BA600")]
		public RDItemConverter(string _ref)
		{
		}
	}
}
