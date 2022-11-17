using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

[Token(Token = "0x20000CA")]
public class EquipmentItemView : SlottedItemView<EquipmentItem>
{
	[Token(Token = "0x4000360")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private AM2Text m_nameText;

	[Token(Token = "0x4000361")]
	[FieldOffset(Offset = "0x80")]
	private EquipmentController m_equipmentController;

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x9C5478", Offset = "0x9C5478", VA = "0x9C5478", Slot = "6")]
	public override void Initialize(ISlottableView<EquipmentItem> parentView, int index)
	{
	}

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x9C5584", Offset = "0x9C5584", VA = "0x9C5584", Slot = "8")]
	public override void RefreshWithSlottedItem(EquipmentItem slottedItem)
	{
	}

	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x9C56BC", Offset = "0x9C56BC", VA = "0x9C56BC", Slot = "11")]
	protected override ISlotController<EquipmentItem> GetSlotController()
	{
		return null;
	}

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x9C56C4", Offset = "0x9C56C4", VA = "0x9C56C4", Slot = "12")]
	protected override string GetSlotUpgradableItemRef()
	{
		return null;
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x9C570C", Offset = "0x9C570C", VA = "0x9C570C", Slot = "13")]
	protected override string GetUIAlertItemKey(EquipmentItem slottedItem)
	{
		return null;
	}

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x9C573C", Offset = "0x9C573C", VA = "0x9C573C", Slot = "14")]
	public override int CompareTo(SlottedItemView<EquipmentItem> other)
	{
		return default(int);
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x9C57A4", Offset = "0x9C57A4", VA = "0x9C57A4")]
	public EquipmentItemView()
	{
	}
}
