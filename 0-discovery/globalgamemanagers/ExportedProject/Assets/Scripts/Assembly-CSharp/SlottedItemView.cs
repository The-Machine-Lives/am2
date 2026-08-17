using System;
using AM2;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x2000114")]
public abstract class SlottedItemView<TSlottedItem> : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IComparable<SlottedItemView<TSlottedItem>> where TSlottedItem : ISlottedItem
{
	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected GameObject m_parentSlot;

	[Token(Token = "0x40006CB")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected GameObject m_emptyActiveContainer;

	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected GameObject m_inactiveContainer;

	[Token(Token = "0x40006CD")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected AM2Button m_emptyButton;

	[Token(Token = "0x40006CE")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected AM2Button m_button;

	[Token(Token = "0x40006CF")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected GameObject m_newText;

	[Token(Token = "0x40006D0")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected UntouchedAlertView m_untouchedAlertView;

	[Token(Token = "0x40006D1")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x824270", Offset = "0x824270")]
	private bool _003Cselected_003Ek__BackingField;

	[Token(Token = "0x40006D2")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x824280", Offset = "0x824280")]
	private bool _003Cequipped_003Ek__BackingField;

	[Token(Token = "0x40006D3")]
	[FieldOffset(Offset = "0x0")]
	protected bool m_isUnlocked;

	[Token(Token = "0x40006D4")]
	[FieldOffset(Offset = "0x0")]
	protected int m_index;

	[Token(Token = "0x40006D5")]
	[FieldOffset(Offset = "0x0")]
	protected ISlottableView<TSlottedItem> m_parentView;

	[Token(Token = "0x40006D6")]
	[FieldOffset(Offset = "0x0")]
	protected TSlottedItem m_slottedItem;

	[Token(Token = "0x40006D7")]
	[FieldOffset(Offset = "0x0")]
	protected UIAlertController m_uiAlertController;

	[Token(Token = "0x40006D8")]
	[FieldOffset(Offset = "0x0")]
	protected ISlotController<TSlottedItem> m_slotController;

	[Token(Token = "0x170000EA")]
	public bool selected
	{
		[Token(Token = "0x6000791")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834140", Offset = "0x834140")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000792")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834150", Offset = "0x834150")]
		protected set
		{
		}
	}

	[Token(Token = "0x170000EB")]
	public bool equipped
	{
		[Token(Token = "0x6000793")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834160", Offset = "0x834160")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000794")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834170", Offset = "0x834170")]
		protected set
		{
		}
	}

	[Token(Token = "0x170000EC")]
	public TSlottedItem SlottedItem
	{
		[Token(Token = "0x6000795")]
		get
		{
			return (TSlottedItem)null;
		}
	}

	[Token(Token = "0x6000796")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6000797")]
	public virtual void Initialize(ISlottableView<TSlottedItem> parentView, int index)
	{
	}

	[Token(Token = "0x6000798")]
	public virtual void RefreshView()
	{
	}

	[Token(Token = "0x6000799")]
	public virtual void RefreshWithSlottedItem(TSlottedItem slottedItem)
	{
	}

	[Token(Token = "0x600079A")]
	public void RefreshRedDotNotification(bool showRedDotNotification)
	{
	}

	[Token(Token = "0x600079B")]
	public void SetSelected(bool inSelected)
	{
	}

	[Token(Token = "0x600079C")]
	public void SetAsViewed()
	{
	}

	[Token(Token = "0x600079D")]
	public void SetEquipped()
	{
	}

	[Token(Token = "0x600079E")]
	public void SetAsNew()
	{
	}

	[Token(Token = "0x600079F")]
	public virtual void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60007A0")]
	public virtual void OnClickedButton(int clickCount)
	{
	}

	[Token(Token = "0x60007A1")]
	protected void UpdateButtonColorBasedOnState()
	{
	}

	[Token(Token = "0x60007A2")]
	protected abstract ISlotController<TSlottedItem> GetSlotController();

	[Token(Token = "0x60007A3")]
	protected abstract string GetSlotUpgradableItemRef();

	[Token(Token = "0x60007A4")]
	protected abstract string GetUIAlertItemKey(TSlottedItem slottedItem);

	[Token(Token = "0x60007A5")]
	public abstract int CompareTo(SlottedItemView<TSlottedItem> other);

	[Token(Token = "0x60007A6")]
	protected SlottedItemView()
	{
	}
}
