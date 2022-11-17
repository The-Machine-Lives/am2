using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000375")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F368", Offset = "0x81F368")]
	public class RDCredits : BaseEntityDocument
	{
		[Token(Token = "0x40010FF")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TextAreaAttribute", RVA = "0x82B874", Offset = "0x82B874")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B874", Offset = "0x82B874")]
		public string credits;

		[Token(Token = "0x6001B82")]
		[Address(RVA = "0x9BA364", Offset = "0x9BA364", VA = "0x9BA364")]
		public RDCredits(string inReference)
		{
		}
	}
}
