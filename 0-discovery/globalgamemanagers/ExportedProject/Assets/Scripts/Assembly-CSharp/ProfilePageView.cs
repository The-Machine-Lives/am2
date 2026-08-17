using System;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x20001A8")]
public class ProfilePageView : CasualView
{
	[Token(Token = "0x40009EA")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private BadgeSwapper m_bannerImage;

	[Token(Token = "0x40009EB")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private TitleSwapper m_titleText;

	[Token(Token = "0x40009EC")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private AM2Button m_openTitleDyeButton;

	[Token(Token = "0x40009ED")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private AM2Button m_openTitleEditButton;

	[Token(Token = "0x40009EE")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private AM2Button m_openBadgeDyeButton;

	[Token(Token = "0x40009EF")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private AM2Button m_openBadgeEditButton;

	[Token(Token = "0x40009F0")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private AM2Button m_closeAllEditsButton;

	[Token(Token = "0x40009F1")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private AM2Text m_nameText;

	[Token(Token = "0x40009F2")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private TitleEditView m_titleEditView;

	[Token(Token = "0x40009F3")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private DyeEditView m_titleDyeEditView;

	[Token(Token = "0x40009F4")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private DyeEditView m_badgeDyeEditView;

	[Token(Token = "0x40009F5")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private BadgeEditView m_badgeEditView;

	[Token(Token = "0x40009F6")]
	[FieldOffset(Offset = "0x120")]
	private ProfilePageController m_profilePageController;

	[Token(Token = "0x40009F7")]
	[FieldOffset(Offset = "0x128")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x6000B83")]
	[Address(RVA = "0x9E53CC", Offset = "0x9E53CC", VA = "0x9E53CC", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000B84")]
	[Address(RVA = "0x9E5618", Offset = "0x9E5618", VA = "0x9E5618", Slot = "13")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000B85")]
	[Address(RVA = "0x9E306C", Offset = "0x9E306C", VA = "0x9E306C")]
	public void Initialize(CasualViewController viewController)
	{
	}

	[Token(Token = "0x6000B86")]
	[Address(RVA = "0x9E5864", Offset = "0x9E5864", VA = "0x9E5864")]
	private void InitializeTitle()
	{
	}

	[Token(Token = "0x6000B87")]
	[Address(RVA = "0x9E5B18", Offset = "0x9E5B18", VA = "0x9E5B18")]
	private void InitializeBadge()
	{
	}

	[Token(Token = "0x6000B88")]
	[Address(RVA = "0x9E5C90", Offset = "0x9E5C90", VA = "0x9E5C90")]
	public void RefreshTitleText()
	{
	}

	[Token(Token = "0x6000B89")]
	[Address(RVA = "0x9E5CE0", Offset = "0x9E5CE0", VA = "0x9E5CE0")]
	public void PurchaseDye(DyeEditView dyeEditView, Dye dye)
	{
	}

	[Token(Token = "0x6000B8A")]
	[Address(RVA = "0x9E5E48", Offset = "0x9E5E48", VA = "0x9E5E48")]
	public void RefreshDye(DyeEditView dyeEditView, Dye dye)
	{
	}

	[Token(Token = "0x6000B8B")]
	[Address(RVA = "0x9E5F40", Offset = "0x9E5F40", VA = "0x9E5F40")]
	public void RefreshTitleDye(Dye dye)
	{
	}

	[Token(Token = "0x6000B8C")]
	[Address(RVA = "0x9E5F78", Offset = "0x9E5F78", VA = "0x9E5F78")]
	public void RefreshBadgeDye(Dye dye)
	{
	}

	[Token(Token = "0x6000B8D")]
	[Address(RVA = "0x9E5FB0", Offset = "0x9E5FB0", VA = "0x9E5FB0")]
	public void RefreshBadge(Badge badge)
	{
	}

	[Token(Token = "0x6000B8E")]
	[Address(RVA = "0x9E6094", Offset = "0x9E6094", VA = "0x9E6094")]
	private void OpenTitleDyeView()
	{
	}

	[Token(Token = "0x6000B8F")]
	[Address(RVA = "0x9E6260", Offset = "0x9E6260", VA = "0x9E6260")]
	private void OpenTitleEditView()
	{
	}

	[Token(Token = "0x6000B90")]
	[Address(RVA = "0x9E629C", Offset = "0x9E629C", VA = "0x9E629C")]
	private void OpenBadgeDyeView()
	{
	}

	[Token(Token = "0x6000B91")]
	[Address(RVA = "0x9E631C", Offset = "0x9E631C", VA = "0x9E631C")]
	private void OpenBadgeEditView()
	{
	}

	[Token(Token = "0x6000B92")]
	[Address(RVA = "0x9E6358", Offset = "0x9E6358", VA = "0x9E6358")]
	private void CloseAllEditViews()
	{
	}

	[Token(Token = "0x6000B93")]
	[Address(RVA = "0x9E60D0", Offset = "0x9E60D0", VA = "0x9E60D0")]
	private void CloseOtherEditViews(MonoBehaviour currentEditView)
	{
	}

	[Token(Token = "0x6000B94")]
	[Address(RVA = "0x9E6360", Offset = "0x9E6360", VA = "0x9E6360", Slot = "11")]
	protected override void OnHideFinished(Action onHideComplete)
	{
	}

	[Token(Token = "0x6000B95")]
	[Address(RVA = "0x9E63C8", Offset = "0x9E63C8", VA = "0x9E63C8")]
	public ProfilePageView()
	{
	}
}
