using Il2CppDummyDll;

namespace Uken.Library.Inventory
{
	[Token(Token = "0x2000459")]
	public class InventoryTokenPayload
	{
		[Token(Token = "0x4001412")]
		[FieldOffset(Offset = "0x10")]
		public string token;

		[Token(Token = "0x6001FFC")]
		[Address(RVA = "0xBA5CD4", Offset = "0xBA5CD4", VA = "0xBA5CD4")]
		public InventoryTokenPayload()
		{
		}
	}
}
