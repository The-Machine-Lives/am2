using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000392")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F5D0", Offset = "0x81F5D0")]
	public class RDTitle : BaseEntityDocument
	{
		[Token(Token = "0x400115C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CD34", Offset = "0x82CD34")]
		public string readableName;

		[Token(Token = "0x6001C02")]
		[Address(RVA = "0x9BAB2C", Offset = "0x9BAB2C", VA = "0x9BAB2C")]
		public RDTitle(string _ref)
		{
		}
	}
}
