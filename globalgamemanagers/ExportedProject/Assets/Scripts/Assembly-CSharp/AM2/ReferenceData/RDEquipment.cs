using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200036E")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F2C0", Offset = "0x81F2C0")]
	public class RDEquipment : BaseEntityDocument
	{
		[Token(Token = "0x40010EF")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82B608", Offset = "0x82B608")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B608", Offset = "0x82B608")]
		public string readableName;

		[Token(Token = "0x40010F0")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B658", Offset = "0x82B658")]
		public string description;

		[Token(Token = "0x40010F1")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82B690", Offset = "0x82B690")]
		[Attribute(Name = "EntityReference", RVA = "0x82B690", Offset = "0x82B690")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B690", Offset = "0x82B690")]
		public List<string> effects;

		[Token(Token = "0x40010F2")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B704", Offset = "0x82B704")]
		public int dustOutputAmount;

		[Token(Token = "0x6001B6A")]
		[Address(RVA = "0x9BA478", Offset = "0x9BA478", VA = "0x9BA478")]
		public RDEquipment(string inReference)
		{
		}
	}
}
