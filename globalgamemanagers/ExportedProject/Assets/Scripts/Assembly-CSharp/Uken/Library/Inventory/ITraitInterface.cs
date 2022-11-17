using Il2CppDummyDll;
using Uken.Library.Inventory.InventoryInternal;

namespace Uken.Library.Inventory
{
	[Token(Token = "0x200045C")]
	public interface ITraitInterface
	{
		[Token(Token = "0x600207F")]
		bool SetItemTrait(BaseInventoryItem item, string key, string value);

		[Token(Token = "0x6002080")]
		bool SetItemTrait(BaseInventoryItem item, string key, int value);

		[Token(Token = "0x6002081")]
		bool SetItemTrait(BaseInventoryItem item, string key, long value);

		[Token(Token = "0x6002082")]
		bool SetItemTrait(BaseInventoryItem item, string key, bool value);

		[Token(Token = "0x6002083")]
		bool SetItemTrait(BaseInventoryItem item, string key, double value);
	}
}
