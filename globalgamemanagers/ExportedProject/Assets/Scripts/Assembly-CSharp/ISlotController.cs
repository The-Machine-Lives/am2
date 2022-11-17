using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000110")]
public interface ISlotController<TSlottedItem> where TSlottedItem : ISlottedItem
{
	[Token(Token = "0x6000777")]
	void SetSlotItem(int index, TSlottedItem slottedItem);

	[Token(Token = "0x6000778")]
	List<TSlottedItem> GetAllOwnedSlottedItems();

	[Token(Token = "0x6000779")]
	List<TSlottedItem> GetEquippedSlottedItems();

	[Token(Token = "0x600077A")]
	TSlottedItem GetSlottedItemAtSlot(int index);

	[Token(Token = "0x600077B")]
	int GetSlotCount();
}
