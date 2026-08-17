using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x2000178")]
public class EquipmentSlotItem : Item
{
	[Token(Token = "0x4000904")]
	public new const string mc_sItemType = "EquipmentSlotItem";

	[Token(Token = "0x4000905")]
	private const string c_slot = "slot_";

	[Token(Token = "0x6000A43")]
	[Address(RVA = "0x9C6FDC", Offset = "0x9C6FDC", VA = "0x9C6FDC")]
	public string GetEquipmentAtSlot(int slotIndex)
	{
		return null;
	}

	[Token(Token = "0x6000A44")]
	[Address(RVA = "0x9C70B0", Offset = "0x9C70B0", VA = "0x9C70B0")]
	public void SetEquipmentAtSlot(int slotIndex, string equipmentRef)
	{
	}

	[Token(Token = "0x6000A45")]
	[Address(RVA = "0x9C7048", Offset = "0x9C7048", VA = "0x9C7048")]
	private string GetSlotTraitKey(int slotIndex)
	{
		return null;
	}

	[Token(Token = "0x6000A46")]
	[Address(RVA = "0x9C70E4", Offset = "0x9C70E4", VA = "0x9C70E4")]
	public EquipmentSlotItem()
	{
	}
}
