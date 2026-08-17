using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000398")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F678", Offset = "0x81F678")]
	public class RDVIPStatus : BaseEntityDocument
	{
		[Token(Token = "0x4001162")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CE84", Offset = "0x82CE84")]
		public string readableName;

		[Token(Token = "0x4001163")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TextAreaAttribute", RVA = "0x82CEBC", Offset = "0x82CEBC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CEBC", Offset = "0x82CEBC")]
		public string description;

		[Token(Token = "0x6001C16")]
		[Address(RVA = "0x9BAC28", Offset = "0x9BAC28", VA = "0x9BAC28")]
		public RDVIPStatus(string inReference)
		{
		}
	}
}
