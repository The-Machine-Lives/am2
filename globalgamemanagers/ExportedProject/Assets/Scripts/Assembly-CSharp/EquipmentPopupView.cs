using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x20000CB")]
public class EquipmentPopupView : SlottablePopupView<EquipmentItem>
{
	[Token(Token = "0x4000362")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	private AM2Text m_titleText;

	[Token(Token = "0x4000363")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	private AM2Text m_descriptionText;

	[Token(Token = "0x4000364")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private AM2Button m_dustingButton;

	[Token(Token = "0x4000365")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x82261C", Offset = "0x82261C")]
	private AM2Text m_equipButtonText;

	[Token(Token = "0x4000366")]
	[FieldOffset(Offset = "0x160")]
	private EquipmentTraitViewInstantiator m_traitViewInstantiator;

	[Token(Token = "0x4000367")]
	[FieldOffset(Offset = "0x168")]
	private EquipmentController m_equipmentController;

	[Token(Token = "0x4000368")]
	[FieldOffset(Offset = "0x170")]
	private AM2MessageController m_am2MessageController;

	[Token(Token = "0x4000369")]
	[FieldOffset(Offset = "0x178")]
	private Equipment m_selectedEquipment;

	[Token(Token = "0x400036A")]
	[FieldOffset(Offset = "0x180")]
	private string m_dustingOutputName;

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x9C57F4", Offset = "0x9C57F4", VA = "0x9C57F4", Slot = "12")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x9C58B8", Offset = "0x9C58B8", VA = "0x9C58B8", Slot = "13")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x9C5A1C", Offset = "0x9C5A1C", VA = "0x9C5A1C", Slot = "17")]
	public override void Initialize(CasualViewController parentController, int sourceIndex, IRefreshableSlottableView<EquipmentItem> sourceSlottableView, EquipmentItem equipmentItem)
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x9C6034", Offset = "0x9C6034", VA = "0x9C6034", Slot = "19")]
	protected override void RefreshView()
	{
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x9C6790", Offset = "0x9C6790", VA = "0x9C6790")]
	protected void Update()
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x9C685C", Offset = "0x9C685C", VA = "0x9C685C")]
	private void OnClickDust()
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x9C69EC", Offset = "0x9C69EC", VA = "0x9C69EC")]
	private void OnConfirmDustEquipment()
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x9C6E24", Offset = "0x9C6E24", VA = "0x9C6E24", Slot = "20")]
	public override void OnClickedEquip()
	{
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x9C6D14", Offset = "0x9C6D14", VA = "0x9C6D14")]
	private void UnequipSlotItem()
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x9C6F8C", Offset = "0x9C6F8C", VA = "0x9C6F8C")]
	public EquipmentPopupView()
	{
	}
}
