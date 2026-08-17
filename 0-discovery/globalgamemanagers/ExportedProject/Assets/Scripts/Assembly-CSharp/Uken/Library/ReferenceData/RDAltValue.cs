using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x200047A")]
	public class RDAltValue
	{
		[Token(Token = "0x4001498")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82E7C8", Offset = "0x82E7C8")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82E7C8", Offset = "0x82E7C8")]
		[Attribute(Name = "FieldPairReference", RVA = "0x82E7C8", Offset = "0x82E7C8")]
		public string args;

		[Token(Token = "0x4001499")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82E8C8", Offset = "0x82E8C8")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82E8C8", Offset = "0x82E8C8")]
		public string trigger;

		[Token(Token = "0x400149A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82E918", Offset = "0x82E918")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82E918", Offset = "0x82E918")]
		[Attribute(Name = "DropdownNameAttribute", RVA = "0x82E918", Offset = "0x82E918")]
		public string attribute;

		[Token(Token = "0x400149B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82E98C", Offset = "0x82E98C")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82E98C", Offset = "0x82E98C")]
		public object value;

		[Token(Token = "0x600211A")]
		[Address(RVA = "0xB37CF0", Offset = "0xB37CF0", VA = "0xB37CF0")]
		public RDAltValue()
		{
		}
	}
}
