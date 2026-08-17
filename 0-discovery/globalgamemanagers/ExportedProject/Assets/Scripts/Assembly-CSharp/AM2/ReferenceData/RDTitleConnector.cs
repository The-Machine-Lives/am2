using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000394")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F608", Offset = "0x81F608")]
	public class RDTitleConnector : BaseEntityDocument
	{
		[Token(Token = "0x400115D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CD6C", Offset = "0x82CD6C")]
		public string readableName;

		[Token(Token = "0x6001C09")]
		[Address(RVA = "0x9BAB34", Offset = "0x9BAB34", VA = "0x9BAB34")]
		public RDTitleConnector(string _ref)
		{
		}
	}
}
