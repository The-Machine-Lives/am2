using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003A2")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F758", Offset = "0x81F758")]
	public class RDTask : BaseEntityDocument
	{
		[Token(Token = "0x4001189")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D844", Offset = "0x82D844")]
		public string acquireText;

		[Token(Token = "0x400118A")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D87C", Offset = "0x82D87C")]
		public string itemRef;

		[Token(Token = "0x400118B")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D8B4", Offset = "0x82D8B4")]
		public long itemQuantity;

		[Token(Token = "0x400118C")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "EntityReference", RVA = "0x82D8EC", Offset = "0x82D8EC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D8EC", Offset = "0x82D8EC")]
		public string itemQuantityFormula;

		[Token(Token = "0x6001C55")]
		[Address(RVA = "0x9BAB1C", Offset = "0x9BAB1C", VA = "0x9BAB1C")]
		public RDTask(string _ref)
		{
		}
	}
}
