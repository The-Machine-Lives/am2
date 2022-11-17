using System;
using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x200047B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x81FB58", Offset = "0x81FB58")]
	public class RegisterDepotEditorAttribute : Attribute
	{
		[Token(Token = "0x400149C")]
		[FieldOffset(Offset = "0x10")]
		public string m_name;

		[Token(Token = "0x600211B")]
		[Address(RVA = "0xB37D6C", Offset = "0xB37D6C", VA = "0xB37D6C")]
		public RegisterDepotEditorAttribute(string name)
		{
		}
	}
}
