using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000327")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81ED10", Offset = "0x81ED10")]
	public class RDEncounter : BaseEntityDocument
	{
		[Token(Token = "0x4000FA6")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x8280E4", Offset = "0x8280E4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8280E4", Offset = "0x8280E4")]
		public List<string> scenes;

		[Token(Token = "0x4000FA7")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8281C0", Offset = "0x8281C0")]
		public bool isSelectInSequence;

		[Token(Token = "0x600198A")]
		[Address(RVA = "0x9BA408", Offset = "0x9BA408", VA = "0x9BA408")]
		public RDEncounter(string _ref)
		{
		}
	}
}
