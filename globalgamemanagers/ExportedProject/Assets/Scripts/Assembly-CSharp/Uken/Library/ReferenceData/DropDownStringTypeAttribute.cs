using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000477")]
	public class DropDownStringTypeAttribute : DropdownAttribute
	{
		[Token(Token = "0x4001494")]
		[FieldOffset(Offset = "0x18")]
		public string[] m_options;

		[Token(Token = "0x4001495")]
		[FieldOffset(Offset = "0x20")]
		public string[] m_values;

		[Token(Token = "0x6002117")]
		[Address(RVA = "0xB37A30", Offset = "0xB37A30", VA = "0xB37A30")]
		public DropDownStringTypeAttribute(string[] _options, string[] _values)
		{
		}
	}
}
