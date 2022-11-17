using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x2000177")]
public class EquipmentItem : Item, IEquipmentItem, ISlottedItem
{
	[Token(Token = "0x40008FE")]
	[FieldOffset(Offset = "0x20")]
	public int c_maxNumTraits;

	[Token(Token = "0x40008FF")]
	public new const string mc_sItemType = "EquipmentItem";

	[Token(Token = "0x4000900")]
	private const string c_traitType = "trait_type_";

	[Token(Token = "0x4000901")]
	private const string c_traitThingRef = "trait_thing_ref_";

	[Token(Token = "0x4000902")]
	private const string c_traitAmount = "trait_amt_";

	[Token(Token = "0x4000903")]
	private const string c_numTraits = "num_traits";

	[Token(Token = "0x1700012B")]
	public string slottedItemRef
	{
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x9C4E70", Offset = "0x9C4E70", VA = "0x9C4E70", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000A39")]
	[Address(RVA = "0x9C4E78", Offset = "0x9C4E78", VA = "0x9C4E78", Slot = "8")]
	public string GetEquipmentModelReference()
	{
		return null;
	}

	[Token(Token = "0x6000A3A")]
	[Address(RVA = "0x9C4ED8", Offset = "0x9C4ED8", VA = "0x9C4ED8", Slot = "9")]
	public void SetEquipmentModelReference(string itemRef)
	{
	}

	[Token(Token = "0x6000A3B")]
	[Address(RVA = "0x9C4F3C", Offset = "0x9C4F3C", VA = "0x9C4F3C")]
	public List<EquipmentTrait> GetEquipmentTraits()
	{
		return null;
	}

	[Token(Token = "0x6000A3C")]
	[Address(RVA = "0x9C5280", Offset = "0x9C5280", VA = "0x9C5280")]
	public void SetEquipmentTraits(List<EquipmentTrait> equipmentTraits)
	{
	}

	[Token(Token = "0x6000A3D")]
	[Address(RVA = "0x9C50FC", Offset = "0x9C50FC", VA = "0x9C50FC")]
	private string GetTraitTypeKey(int slotIndex)
	{
		return null;
	}

	[Token(Token = "0x6000A3E")]
	[Address(RVA = "0x9C5164", Offset = "0x9C5164", VA = "0x9C5164")]
	private string GetThingRefKey(int slotIndex)
	{
		return null;
	}

	[Token(Token = "0x6000A3F")]
	[Address(RVA = "0x9C51CC", Offset = "0x9C51CC", VA = "0x9C51CC")]
	private string GetAmountKey(int slotIndex)
	{
		return null;
	}

	[Token(Token = "0x6000A40")]
	[Address(RVA = "0x9C50A4", Offset = "0x9C50A4", VA = "0x9C50A4")]
	private int GetTraitCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000A41")]
	[Address(RVA = "0x9C53EC", Offset = "0x9C53EC", VA = "0x9C53EC")]
	private void SetTraitCount(int count)
	{
	}

	[Token(Token = "0x6000A42")]
	[Address(RVA = "0x9C5468", Offset = "0x9C5468", VA = "0x9C5468")]
	public EquipmentItem()
	{
	}
}
