using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x2000119")]
public class SubstanceView : MonoBehaviour, ISubTabItemView
{
	[Token(Token = "0x400071F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected AM2Text m_titleText;

	[Token(Token = "0x4000720")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected AM2Text m_quantityText;

	[Token(Token = "0x4000721")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private InfoPopupButton m_infoPopupButton;

	[Token(Token = "0x4000722")]
	[FieldOffset(Offset = "0x30")]
	private long m_previousQuantity;

	[Token(Token = "0x4000723")]
	[FieldOffset(Offset = "0x38")]
	private Item m_item;

	[Token(Token = "0x60007ED")]
	[Address(RVA = "0xA10ABC", Offset = "0xA10ABC", VA = "0xA10ABC", Slot = "8")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x60007EE")]
	[Address(RVA = "0xA10AC0", Offset = "0xA10AC0", VA = "0xA10AC0", Slot = "9")]
	public virtual void Initialize(CasualViewController viewController, IInfoText infoText, string inventoryItemRef, string readableName)
	{
	}

	[Token(Token = "0x60007EF")]
	[Address(RVA = "0xA10E88", Offset = "0xA10E88", VA = "0xA10E88", Slot = "7")]
	public void OnHidePage()
	{
	}

	[Token(Token = "0x60007F0")]
	[Address(RVA = "0xA10E8C", Offset = "0xA10E8C", VA = "0xA10E8C", Slot = "4")]
	public bool RefreshRedDotNotification(HashSet<string> untouchedUnlockers, HashSet<string> untouchedItemRefs)
	{
		return default(bool);
	}

	[Token(Token = "0x60007F1")]
	[Address(RVA = "0xA10D3C", Offset = "0xA10D3C", VA = "0xA10D3C")]
	private void RefreshQuantityText(bool forced = false)
	{
	}

	[Token(Token = "0x60007F2")]
	[Address(RVA = "0xA10E94", Offset = "0xA10E94", VA = "0xA10E94")]
	protected void Update()
	{
	}

	[Token(Token = "0x60007F3")]
	[Address(RVA = "0xA10E9C", Offset = "0xA10E9C", VA = "0xA10E9C")]
	public SubstanceView()
	{
	}

	[SpecialName]
	[Token(Token = "0x60007F4")]
	[Address(RVA = "0xA10EAC", Offset = "0xA10EAC", VA = "0xA10EAC", Slot = "5")]
	private GameObject ISubTabItemView_002Eget_gameObject()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x60007F5")]
	[Address(RVA = "0xA10EB4", Offset = "0xA10EB4", VA = "0xA10EB4", Slot = "6")]
	private Transform ISubTabItemView_002Eget_transform()
	{
		return null;
	}
}
