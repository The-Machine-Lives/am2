using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000C5")]
public class ConstructionPageSubTabView : ConstructionPageView
{
	[Token(Token = "0x4000338")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform m_childrenContainer;

	[Token(Token = "0x4000339")]
	[FieldOffset(Offset = "0x40")]
	protected List<ISubTabItemView> m_itemViews;

	[Token(Token = "0x400033A")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AM2Text titleText;

	[Token(Token = "0x170000CD")]
	public Transform childContainer
	{
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x9BD8A8", Offset = "0x9BD8A8", VA = "0x9BD8A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x9BD8B0", Offset = "0x9BD8B0", VA = "0x9BD8B0")]
	public void Initialize(TabButton inTabButton, string pageName)
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x9BD8FC", Offset = "0x9BD8FC", VA = "0x9BD8FC", Slot = "6")]
	public override void OnTogglePageOff()
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x9BDB3C", Offset = "0x9BDB3C", VA = "0x9BDB3C")]
	public void AddItemView(ISubTabItemView itemView)
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x9BDC44", Offset = "0x9BDC44", VA = "0x9BDC44")]
	public void ClearItemViews()
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x9BDCA4", Offset = "0x9BDCA4", VA = "0x9BDCA4")]
	public void SetActiveSubTab(bool active)
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x9BDCF4", Offset = "0x9BDCF4", VA = "0x9BDCF4")]
	public bool RefreshRedDotNotification(HashSet<string> untouchedUnlockers, HashSet<string> untouchedItemRefs)
	{
		return default(bool);
	}

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x9BDE8C", Offset = "0x9BDE8C", VA = "0x9BDE8C")]
	public ConstructionPageSubTabView()
	{
	}
}
