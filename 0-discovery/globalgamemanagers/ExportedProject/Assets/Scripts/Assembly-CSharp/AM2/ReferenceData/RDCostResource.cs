using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000351")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F058", Offset = "0x81F058")]
	public class RDCostResource : BaseEntityDocument
	{
		[Token(Token = "0x4001015")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x829350", Offset = "0x829350")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x829350", Offset = "0x829350")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829350", Offset = "0x829350")]
		public string itemRef;

		[Token(Token = "0x4001016")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x829410", Offset = "0x829410")]
		[Attribute(Name = "EntityReference", RVA = "0x829410", Offset = "0x829410")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x829410", Offset = "0x829410")]
		public string formula;

		[Token(Token = "0x6001A38")]
		[Address(RVA = "0x9BA30C", Offset = "0x9BA30C", VA = "0x9BA30C")]
		public RDCostResource()
		{
		}
	}
}
