using System.Collections.Generic;
using AM2;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

[Token(Token = "0x20000CD")]
public class EquipmentView : SlottableView<EquipmentItem>
{
	[Token(Token = "0x4000373")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject m_equipmentTraitTemplate;

	[Token(Token = "0x4000374")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform m_equipmentTraitViewsParent;

	[Token(Token = "0x4000375")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected List<EquipmentItemView> m_slottedItemViews;

	[Token(Token = "0x4000376")]
	[FieldOffset(Offset = "0x60")]
	private EquipmentTraitViewInstantiator m_traitViewInstantiator;

	[Token(Token = "0x4000377")]
	[FieldOffset(Offset = "0x68")]
	private EquipmentController m_equipmentController;

	[Token(Token = "0x4000378")]
	[FieldOffset(Offset = "0x70")]
	private UIAlertController m_uiAlertController;

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x9C7AC0", Offset = "0x9C7AC0", VA = "0x9C7AC0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x9C7CD0", Offset = "0x9C7CD0", VA = "0x9C7CD0")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x9C7D34", Offset = "0x9C7D34", VA = "0x9C7D34")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6000508")]
	[Address(RVA = "0x9C7D44", Offset = "0x9C7D44", VA = "0x9C7D44", Slot = "8")]
	public override void RefreshSlots()
	{
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x9C7C60", Offset = "0x9C7C60", VA = "0x9C7C60")]
	private void RefreshTraitViews()
	{
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x9C7D9C", Offset = "0x9C7D9C", VA = "0x9C7D9C", Slot = "9")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x9C7E04", Offset = "0x9C7E04", VA = "0x9C7E04", Slot = "10")]
	protected override List<SlottedItemView<EquipmentItem>> GetItemViews()
	{
		return null;
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x9C7E74", Offset = "0x9C7E74", VA = "0x9C7E74")]
	private void ClearTraitViews()
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x9C7EA0", Offset = "0x9C7EA0", VA = "0x9C7EA0")]
	public EquipmentView()
	{
	}
}
