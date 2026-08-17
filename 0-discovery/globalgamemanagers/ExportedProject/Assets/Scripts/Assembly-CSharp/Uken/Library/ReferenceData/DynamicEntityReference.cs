using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000473")]
	public class DynamicEntityReference : DropdownAttribute
	{
		[Token(Token = "0x400148F")]
		[FieldOffset(Offset = "0x11")]
		public bool ShowEntity;

		[Token(Token = "0x6002112")]
		[Address(RVA = "0xB37AA8", Offset = "0xB37AA8", VA = "0xB37AA8")]
		public DynamicEntityReference(bool _showEntity = true)
		{
		}
	}
}
