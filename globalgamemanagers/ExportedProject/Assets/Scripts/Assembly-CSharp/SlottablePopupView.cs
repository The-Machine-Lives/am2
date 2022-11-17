using System;
using System.Collections.Generic;
using AM2;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x2000112")]
public abstract class SlottablePopupView<TSlottedItem> : CasualView, ISlottableView<TSlottedItem> where TSlottedItem : ISlottedItem
{
	[Token(Token = "0x40006B4")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected GameObject m_traitTemplate;

	[Token(Token = "0x40006B5")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected GameObject m_itemViewTemplate;

	[Token(Token = "0x40006B6")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected Transform m_itemViewParent;

	[Token(Token = "0x40006B7")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected Transform m_traitViewsParent;

	[Token(Token = "0x40006B8")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected GameObject m_equippedText;

	[Token(Token = "0x40006B9")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected AM2Button m_equipButton;

	[Token(Token = "0x40006BA")]
	[FieldOffset(Offset = "0x0")]
	protected List<SlottedItemView<TSlottedItem>> m_itemViews;

	[Token(Token = "0x40006BB")]
	[FieldOffset(Offset = "0x0")]
	protected TSlottedItem m_selectedSlottedItem;

	[Token(Token = "0x40006BC")]
	[FieldOffset(Offset = "0x0")]
	protected string m_slottedItemType;

	[Token(Token = "0x40006BD")]
	[FieldOffset(Offset = "0x0")]
	protected int m_sourceIndex;

	[Token(Token = "0x40006BE")]
	[FieldOffset(Offset = "0x0")]
	protected Localizations m_localizationController;

	[Token(Token = "0x40006BF")]
	[FieldOffset(Offset = "0x0")]
	protected InventoryController m_inventoryController;

	[Token(Token = "0x40006C0")]
	[FieldOffset(Offset = "0x0")]
	protected ConstructionController m_constructionController;

	[Token(Token = "0x40006C1")]
	[FieldOffset(Offset = "0x0")]
	protected UIAlertController m_uiAlertController;

	[Token(Token = "0x40006C2")]
	[FieldOffset(Offset = "0x0")]
	protected IRefreshableSlottableView<TSlottedItem> m_sourceSlottableView;

	[Token(Token = "0x40006C3")]
	[FieldOffset(Offset = "0x0")]
	protected ISlotController<TSlottedItem> m_slotController;

	[Token(Token = "0x600077D")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600077E")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600077F")]
	public abstract void Initialize(CasualViewController parentController, int sourceIndex, IRefreshableSlottableView<TSlottedItem> sourceSlottableView, TSlottedItem ability);

	[Token(Token = "0x6000780")]
	protected void InitializeSlottableView(CasualViewController parentController, string itemType, int sourceIndex, IRefreshableSlottableView<TSlottedItem> sourceSlottableView, ISlotController<TSlottedItem> slotController, TSlottedItem startingSlottedItem)
	{
	}

	[Token(Token = "0x6000781")]
	public virtual void OnClickedItemView(int sourceIndex, TSlottedItem slottedItem, int clickCount, SlottedItemView<TSlottedItem> itemView)
	{
	}

	[Token(Token = "0x6000782")]
	protected virtual void RefreshView()
	{
	}

	[Token(Token = "0x6000783")]
	public virtual void OnClickedEquip()
	{
	}

	[Token(Token = "0x6000784")]
	protected override void OnHideFinished(Action onHideComplete)
	{
	}

	[Token(Token = "0x6000785")]
	protected void SetEquippedTextEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6000786")]
	protected virtual void SetSelectedItem(TSlottedItem selectedItem)
	{
	}

	[Token(Token = "0x6000787")]
	protected bool IsItemEquipped(string itemRef, List<TSlottedItem> equippedItems)
	{
		return default(bool);
	}

	[Token(Token = "0x6000788")]
	protected void SortItemViews()
	{
	}

	[Token(Token = "0x6000789")]
	protected SlottablePopupView()
	{
	}
}
