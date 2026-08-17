using System;
using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x200047C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x81FB6C", Offset = "0x81FB6C")]
	public class UseDepotEditorAttribute : Attribute
	{
		[Token(Token = "0x400149D")]
		[FieldOffset(Offset = "0x10")]
		public string m_name;

		[Token(Token = "0x600211C")]
		[Address(RVA = "0xB38604", Offset = "0xB38604", VA = "0xB38604")]
		public UseDepotEditorAttribute(string name)
		{
		}
	}
}
