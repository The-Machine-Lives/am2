using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004F8")]
	public class RDFeature : BaseEntityDocument
	{
		[Token(Token = "0x4001780")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82FC80", Offset = "0x82FC80")]
		public string comment;

		[Token(Token = "0x6002647")]
		[Address(RVA = "0xA810F0", Offset = "0xA810F0", VA = "0xA810F0")]
		public RDFeature(string _ref)
		{
		}
	}
}
