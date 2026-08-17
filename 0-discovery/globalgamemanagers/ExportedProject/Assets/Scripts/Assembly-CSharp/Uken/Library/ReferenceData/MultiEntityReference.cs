using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000472")]
	public class MultiEntityReference : DropdownAttribute
	{
		[Token(Token = "0x400148E")]
		[FieldOffset(Offset = "0x18")]
		public string[] Depots;

		[Token(Token = "0x6002111")]
		[Address(RVA = "0xB37CBC", Offset = "0xB37CBC", VA = "0xB37CBC")]
		public MultiEntityReference(string[] _depots)
		{
		}
	}
}
