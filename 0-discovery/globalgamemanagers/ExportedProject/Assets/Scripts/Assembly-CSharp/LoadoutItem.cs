using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x200017C")]
public class LoadoutItem : Item
{
	[Token(Token = "0x400090F")]
	public new const string mc_sItemType = "LoadoutItem";

	[Token(Token = "0x4000910")]
	private const string c_slot = "slot_";

	[Token(Token = "0x6000A57")]
	[Address(RVA = "0x996118", Offset = "0x996118", VA = "0x996118", Slot = "4")]
	public override void ResetTraits(bool resetLifeTimeQuantity = false)
	{
	}

	[Token(Token = "0x6000A58")]
	[Address(RVA = "0x996144", Offset = "0x996144", VA = "0x996144")]
	private void ClearSlots()
	{
	}

	[Token(Token = "0x6000A59")]
	[Address(RVA = "0x996218", Offset = "0x996218", VA = "0x996218")]
	public string GetAbilityAtSlot(int slotIndex)
	{
		return null;
	}

	[Token(Token = "0x6000A5A")]
	[Address(RVA = "0x996284", Offset = "0x996284", VA = "0x996284")]
	public void SetAbilityAtSlot(int slotIndex, string abilityRef)
	{
	}

	[Token(Token = "0x6000A5B")]
	[Address(RVA = "0x9962B8", Offset = "0x9962B8", VA = "0x9962B8")]
	private string GetSlotTraitKey(int slotIndex)
	{
		return null;
	}

	[Token(Token = "0x6000A5C")]
	[Address(RVA = "0x996320", Offset = "0x996320", VA = "0x996320")]
	public LoadoutItem()
	{
	}
}
