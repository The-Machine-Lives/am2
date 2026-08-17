using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200038E")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F560", Offset = "0x81F560")]
	public class RDBadge : BaseEntityDocument
	{
		[Token(Token = "0x4001151")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CB5C", Offset = "0x82CB5C")]
		public string readableName;

		[Token(Token = "0x4001152")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CB94", Offset = "0x82CB94")]
		public string imageSource;

		[Token(Token = "0x6001BE7")]
		[Address(RVA = "0x9BA1A4", Offset = "0x9BA1A4", VA = "0x9BA1A4")]
		public RDBadge(string _ref)
		{
		}
	}
}
