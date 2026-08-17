using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000478")]
	public class FieldPairReference : DropdownAttribute
	{
		[Token(Token = "0x4001496")]
		[FieldOffset(Offset = "0x18")]
		private string[] fields;

		[Token(Token = "0x6002118")]
		[Address(RVA = "0xB37C5C", Offset = "0xB37C5C", VA = "0xB37C5C")]
		public FieldPairReference(params string[] _fields)
		{
		}
	}
}
