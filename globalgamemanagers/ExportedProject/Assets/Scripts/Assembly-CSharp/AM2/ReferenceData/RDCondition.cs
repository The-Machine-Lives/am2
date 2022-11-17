using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003AF")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F870", Offset = "0x81F870")]
	public class RDCondition : BaseEntityDocument
	{
		[Token(Token = "0x40011A4")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DCAC", Offset = "0x82DCAC")]
		public string itemRef;

		[Token(Token = "0x40011A5")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DCE4", Offset = "0x82DCE4")]
		public long itemQuantity;

		[Token(Token = "0x6001C82")]
		[Address(RVA = "0x9BA304", Offset = "0x9BA304", VA = "0x9BA304")]
		public RDCondition(string _ref)
		{
		}
	}
}
