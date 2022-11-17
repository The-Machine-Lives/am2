using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x20000D1")]
public class LoadoutAbilityView : SlottedItemView<Ability>
{
	[Token(Token = "0x40003AB")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private AM2Text m_ammoCountText;

	[Token(Token = "0x40003AC")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private AM2Text m_abilityNameText;

	[Token(Token = "0x40003AD")]
	[FieldOffset(Offset = "0x88")]
	private AmmoTextUpdater m_ammoTextUpdater;

	[Token(Token = "0x40003AE")]
	[FieldOffset(Offset = "0x90")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x40003AF")]
	[FieldOffset(Offset = "0x98")]
	private ConstructionController m_constructionController;

	[Token(Token = "0x40003B0")]
	[FieldOffset(Offset = "0xA0")]
	private LoadoutController m_loadoutController;

	[Token(Token = "0x170000D0")]
	public bool hasAmmo
	{
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x9957EC", Offset = "0x9957EC", VA = "0x9957EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0x99584C", Offset = "0x99584C", VA = "0x99584C", Slot = "6")]
	public override void Initialize(ISlottableView<Ability> parentView, int index)
	{
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0x995ABC", Offset = "0x995ABC", VA = "0x995ABC", Slot = "8")]
	public override void RefreshWithSlottedItem(Ability slottedItem)
	{
	}

	[Token(Token = "0x6000536")]
	[Address(RVA = "0x995D0C", Offset = "0x995D0C", VA = "0x995D0C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000537")]
	[Address(RVA = "0x995CF8", Offset = "0x995CF8", VA = "0x995CF8")]
	protected void UpdateAmmoText()
	{
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0x995D20", Offset = "0x995D20", VA = "0x995D20", Slot = "11")]
	protected override ISlotController<Ability> GetSlotController()
	{
		return null;
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x995D28", Offset = "0x995D28", VA = "0x995D28", Slot = "12")]
	protected override string GetSlotUpgradableItemRef()
	{
		return null;
	}

	[Token(Token = "0x600053A")]
	[Address(RVA = "0x995D70", Offset = "0x995D70", VA = "0x995D70", Slot = "13")]
	protected override string GetUIAlertItemKey(Ability slottedItem)
	{
		return null;
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x995DA4", Offset = "0x995DA4", VA = "0x995DA4", Slot = "14")]
	public override int CompareTo(SlottedItemView<Ability> other)
	{
		return default(int);
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x995F94", Offset = "0x995F94", VA = "0x995F94")]
	private int CompareByAmmoCount(LoadoutAbilityView other)
	{
		return default(int);
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x995E90", Offset = "0x995E90", VA = "0x995E90")]
	private int CompareByAlphabetical(LoadoutAbilityView other)
	{
		return default(int);
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x995F10", Offset = "0x995F10", VA = "0x995F10")]
	private int CompareByReverseAlphabetical(LoadoutAbilityView other)
	{
		return default(int);
	}

	[Token(Token = "0x600053F")]
	[Address(RVA = "0x9960C8", Offset = "0x9960C8", VA = "0x9960C8")]
	public LoadoutAbilityView()
	{
	}
}
