using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000331")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81EDF0", Offset = "0x81EDF0")]
	public class RDTag : BaseEntityDocument
	{
		[Token(Token = "0x4000FC3")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82855C", Offset = "0x82855C")]
		public string readableName;

		[Token(Token = "0x4000FC4")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828594", Offset = "0x828594")]
		public string infoText;

		[Token(Token = "0x4000FC5")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8285CC", Offset = "0x8285CC")]
		public string infoImageSource;

		[Token(Token = "0x4000FC6")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828604", Offset = "0x828604")]
		public int dustOutputAmount;

		[Token(Token = "0x60019AE")]
		[Address(RVA = "0x9BAB14", Offset = "0x9BAB14", VA = "0x9BAB14")]
		public RDTag(string _ref)
		{
		}
	}
}
