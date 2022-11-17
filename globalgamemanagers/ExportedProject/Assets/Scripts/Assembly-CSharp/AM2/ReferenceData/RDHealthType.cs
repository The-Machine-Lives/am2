using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200032A")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81ED48", Offset = "0x81ED48")]
	public class RDHealthType : BaseEntityDocument
	{
		[Token(Token = "0x4000FAD")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8281F8", Offset = "0x8281F8")]
		public bool isReverse;

		[Token(Token = "0x4000FAE")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828230", Offset = "0x828230")]
		public string deadText;

		[Token(Token = "0x6001994")]
		[Address(RVA = "0x9BA56C", Offset = "0x9BA56C", VA = "0x9BA56C")]
		public RDHealthType(string _ref)
		{
		}
	}
}
