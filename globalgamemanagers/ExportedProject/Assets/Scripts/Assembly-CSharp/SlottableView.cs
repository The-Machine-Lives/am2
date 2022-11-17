using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x2000113")]
public abstract class SlottableView<TSlottedItem> : MonoBehaviour, IRefreshableSlottableView<TSlottedItem>, ISlottableView<TSlottedItem> where TSlottedItem : ISlottedItem
{
	[Token(Token = "0x40006C4")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected CasualViewController m_viewController;

	[Token(Token = "0x40006C5")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private GameObject m_popupViewTemplate;

	[Token(Token = "0x40006C6")]
	[FieldOffset(Offset = "0x0")]
	protected int m_previousSlotCount;

	[Token(Token = "0x40006C7")]
	[FieldOffset(Offset = "0x0")]
	protected ISlotController<TSlottedItem> m_slotController;

	[Token(Token = "0x40006C8")]
	[FieldOffset(Offset = "0x0")]
	private SlottablePopupView<TSlottedItem> popupView;

	[Token(Token = "0x40006C9")]
	[FieldOffset(Offset = "0x0")]
	private List<SlottedItemView<TSlottedItem>> m_slottedItemViews;

	[Token(Token = "0x600078A")]
	public virtual void Initialize(ISlotController<TSlottedItem> slotController)
	{
	}

	[Token(Token = "0x600078B")]
	public virtual void OnClickedItemView(int sourceIndex, TSlottedItem equipmentItem, int clickCount, SlottedItemView<TSlottedItem> itemView)
	{
	}

	[Token(Token = "0x600078C")]
	public virtual void RefreshSlots()
	{
	}

	[Token(Token = "0x600078D")]
	public void RefreshRedDotNotification(bool showRedDotNotification)
	{
	}

	[Token(Token = "0x600078E")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600078F")]
	protected abstract List<SlottedItemView<TSlottedItem>> GetItemViews();

	[Token(Token = "0x6000790")]
	protected SlottableView()
	{
	}
}
