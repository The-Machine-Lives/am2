using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003A5")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F790", Offset = "0x81F790")]
	public class RDSection : BaseEntityDocument
	{
		[Token(Token = "0x400118F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82D95C", Offset = "0x82D95C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D95C", Offset = "0x82D95C")]
		public string readableName;

		[Token(Token = "0x4001190")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D9AC", Offset = "0x82D9AC")]
		public int priority;

		[Token(Token = "0x6001C60")]
		[Address(RVA = "0x9BAAD4", Offset = "0x9BAAD4", VA = "0x9BAAD4")]
		public RDSection()
		{
		}
	}
}
