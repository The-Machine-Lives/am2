using System;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x20000EC")]
public class PrestigeItemPopupInfoView : CasualView
{
	[Token(Token = "0x4000569")]
	private const string c_maxText = "MAX";

	[Token(Token = "0x400056A")]
	private const string c_currentLevel = "Current Level:";

	[Token(Token = "0x400056B")]
	private const string c_currentEffect = "Current Effect:";

	[Token(Token = "0x400056C")]
	private const string c_nextEffect = "Next Effect:";

	[Token(Token = "0x400056D")]
	[FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x82336C", Offset = "0x82336C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x82336C", Offset = "0x82336C")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82336C", Offset = "0x82336C")]
	private AM2Button m_upgradeButton;

	[Token(Token = "0x400056E")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8233EC", Offset = "0x8233EC")]
	private AM2Text m_upgradeButtonText;

	[Token(Token = "0x400056F")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823438", Offset = "0x823438")]
	private AM2Text m_descriptionText;

	[Token(Token = "0x4000570")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823484", Offset = "0x823484")]
	private AM2Text m_titleText;

	[Token(Token = "0x4000571")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8234D0", Offset = "0x8234D0")]
	private AM2Text m_itemStatsText;

	[Token(Token = "0x4000572")]
	[FieldOffset(Offset = "0xE8")]
	private Prestiges m_prestigeItem;

	[Token(Token = "0x4000573")]
	[FieldOffset(Offset = "0xF0")]
	private Upgradable m_pretigeUpgradable;

	[Token(Token = "0x4000574")]
	[FieldOffset(Offset = "0xF8")]
	private Item m_costItemReference;

	[Token(Token = "0x4000575")]
	[FieldOffset(Offset = "0x100")]
	private ItemMinimalDetails m_costItemMinimalDetails;

	[Token(Token = "0x4000576")]
	[FieldOffset(Offset = "0x108")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000577")]
	[FieldOffset(Offset = "0x110")]
	private AM2InventoryController m_inventoryController;

	[Token(Token = "0x4000578")]
	[FieldOffset(Offset = "0x118")]
	private PrestigeController m_prestigeController;

	[Token(Token = "0x4000579")]
	[FieldOffset(Offset = "0x120")]
	private string m_originalButtonText;

	[Token(Token = "0x600064F")]
	[Address(RVA = "0x9DEB98", Offset = "0x9DEB98", VA = "0x9DEB98")]
	public void Initialize(CasualViewController viewController, Prestiges prestigeItem)
	{
	}

	[Token(Token = "0x6000650")]
	[Address(RVA = "0x9DF45C", Offset = "0x9DF45C", VA = "0x9DF45C", Slot = "12")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000651")]
	[Address(RVA = "0x9DF518", Offset = "0x9DF518", VA = "0x9DF518", Slot = "13")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000652")]
	[Address(RVA = "0x9DF5D4", Offset = "0x9DF5D4", VA = "0x9DF5D4", Slot = "6")]
	protected override void OnShowStart(Action onShowComplete)
	{
	}

	[Token(Token = "0x6000653")]
	[Address(RVA = "0x9DF158", Offset = "0x9DF158", VA = "0x9DF158")]
	private void BuildStatsText()
	{
	}

	[Token(Token = "0x6000654")]
	[Address(RVA = "0x9DEF30", Offset = "0x9DEF30", VA = "0x9DEF30")]
	private void UpdateUpgradeButton()
	{
	}

	[Token(Token = "0x6000655")]
	[Address(RVA = "0x9DF604", Offset = "0x9DF604", VA = "0x9DF604")]
	private void OnUpgradeButtonPressed()
	{
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0x9DF688", Offset = "0x9DF688", VA = "0x9DF688")]
	public PrestigeItemPopupInfoView()
	{
	}
}
