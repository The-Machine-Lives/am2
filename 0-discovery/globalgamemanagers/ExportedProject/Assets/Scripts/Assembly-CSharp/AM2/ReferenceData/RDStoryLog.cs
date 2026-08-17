using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003A7")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F7C8", Offset = "0x81F7C8")]
	public class RDStoryLog : BaseEntityDocument
	{
		[Token(Token = "0x4001191")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D9E4", Offset = "0x82D9E4")]
		public string readableText;

		[Token(Token = "0x4001192")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DA1C", Offset = "0x82DA1C")]
		public string unlockItemRef;

		[Token(Token = "0x4001193")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82DA54", Offset = "0x82DA54")]
		public int allTimeGenerationUnlockAmount;

		[Token(Token = "0x6001C65")]
		[Address(RVA = "0x9BAAF4", Offset = "0x9BAAF4", VA = "0x9BAAF4")]
		public RDStoryLog(string _ref)
		{
		}
	}
}
