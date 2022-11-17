using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200032F")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81EDB8", Offset = "0x81EDB8")]
	public class RDSubstance : BaseEntityDocument
	{
		[Token(Token = "0x4000FC2")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828524", Offset = "0x828524")]
		public string readableName;

		[Token(Token = "0x60019AB")]
		[Address(RVA = "0x9BAB04", Offset = "0x9BAB04", VA = "0x9BAB04")]
		public RDSubstance(string _ref)
		{
		}
	}
}
