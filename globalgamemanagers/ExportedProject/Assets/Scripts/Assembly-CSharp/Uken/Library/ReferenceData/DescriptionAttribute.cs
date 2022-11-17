using System;
using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000460")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x81FB1C", Offset = "0x81FB1C")]
	public class DescriptionAttribute : Attribute
	{
		[Token(Token = "0x4001454")]
		[FieldOffset(Offset = "0x10")]
		public string description;

		[Token(Token = "0x60020AE")]
		[Address(RVA = "0xB37A04", Offset = "0xB37A04", VA = "0xB37A04")]
		public DescriptionAttribute(string _description)
		{
		}
	}
}
