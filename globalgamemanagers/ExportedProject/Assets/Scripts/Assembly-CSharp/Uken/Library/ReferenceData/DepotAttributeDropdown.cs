using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x200046E")]
	public class DepotAttributeDropdown : DropdownAttribute
	{
		[Token(Token = "0x4001489")]
		[FieldOffset(Offset = "0x18")]
		public string Depot;

		[Token(Token = "0x400148A")]
		[FieldOffset(Offset = "0x20")]
		private string[] Excludes;

		[Token(Token = "0x600210B")]
		[Address(RVA = "0xB37810", Offset = "0xB37810", VA = "0xB37810")]
		public DepotAttributeDropdown(string _depot)
		{
		}
	}
}
