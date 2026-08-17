using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004BC")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81FBC4", Offset = "0x81FBC4")]
	public class RDAM2Message : BaseEntityDocument
	{
		[Token(Token = "0x400163A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82EB1C", Offset = "0x82EB1C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82EB1C", Offset = "0x82EB1C")]
		public string messageText;

		[Token(Token = "0x60023D2")]
		[Address(RVA = "0xA80BC4", Offset = "0xA80BC4", VA = "0xA80BC4")]
		public RDAM2Message()
		{
		}
	}
}
