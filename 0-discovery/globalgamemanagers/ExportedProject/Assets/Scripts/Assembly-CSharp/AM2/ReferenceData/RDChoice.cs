using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000325")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81ECD8", Offset = "0x81ECD8")]
	public class RDChoice : BaseEntityDocument
	{
		[Token(Token = "0x4000F9F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x827F48", Offset = "0x827F48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827F48", Offset = "0x827F48")]
		public string choiceEffect;

		[Token(Token = "0x4000FA0")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x827FF4", Offset = "0x827FF4")]
		public string textChoice;

		[Token(Token = "0x4000FA1")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82802C", Offset = "0x82802C")]
		public string requiredItemRef;

		[Token(Token = "0x4000FA2")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828064", Offset = "0x828064")]
		public long requiredItemQuantity;

		[Token(Token = "0x4000FA3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82809C", Offset = "0x82809C")]
		public bool isRequirementConsumed;

		[Token(Token = "0x6001981")]
		[Address(RVA = "0x9BA21C", Offset = "0x9BA21C", VA = "0x9BA21C")]
		public RDChoice(string _ref)
		{
		}
	}
}
