using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x20000F3")]
public class BadgeEditView : MonoBehaviour
{
	[Token(Token = "0x400059A")]
	private const float c_badgeWidth = 100f;

	[Token(Token = "0x400059B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ProfilePageView m_profilePageView;

	[Token(Token = "0x400059C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private BadgeScrollableSelector m_badgeSelector;

	[Token(Token = "0x400059D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private BadgeSwapper m_badgeItemViewTemplate;

	[Token(Token = "0x400059E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AutoScrollableView m_autoScrollableView;

	[Token(Token = "0x400059F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AM2Button m_confirmButton;

	[Token(Token = "0x40005A0")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AM2Button m_cancelButton;

	[Token(Token = "0x40005A1")]
	[FieldOffset(Offset = "0x48")]
	private Badge m_activeBadge;

	[Token(Token = "0x40005A2")]
	[FieldOffset(Offset = "0x50")]
	private CasualViewController m_viewController;

	[Token(Token = "0x40005A3")]
	[FieldOffset(Offset = "0x58")]
	private ProfilePageController m_profilePageController;

	[Token(Token = "0x40005A4")]
	[FieldOffset(Offset = "0x60")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x40005A5")]
	[FieldOffset(Offset = "0x68")]
	private bool m_ownedBadgesPopulated;

	[Token(Token = "0x40005A6")]
	[FieldOffset(Offset = "0x69")]
	private bool m_isOpen;

	[Token(Token = "0x6000674")]
	[Address(RVA = "0xA44A04", Offset = "0xA44A04", VA = "0xA44A04")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6000675")]
	[Address(RVA = "0xA44B74", Offset = "0xA44B74", VA = "0xA44B74")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6000676")]
	[Address(RVA = "0xA44D94", Offset = "0xA44D94", VA = "0xA44D94")]
	public void Initialize(CasualViewController viewController, Badge activeBadge)
	{
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0xA44F00", Offset = "0xA44F00", VA = "0xA44F00")]
	public void UpdateActiveBadgeDye(Dye dye)
	{
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0xA451B8", Offset = "0xA451B8", VA = "0xA451B8")]
	protected bool PopulateOwnedBadges()
	{
		return default(bool);
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0xA45564", Offset = "0xA45564", VA = "0xA45564")]
	public void ToggleViewOpen()
	{
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0xA455F8", Offset = "0xA455F8", VA = "0xA455F8")]
	public void OpenView()
	{
	}

	[Token(Token = "0x600067B")]
	[Address(RVA = "0xA45574", Offset = "0xA45574", VA = "0xA45574")]
	public void CloseView()
	{
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0xA4580C", Offset = "0xA4580C", VA = "0xA4580C")]
	public void OnClickConfirmBadge()
	{
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0xA458D0", Offset = "0xA458D0", VA = "0xA458D0")]
	public void OnClickCancel()
	{
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0xA45728", Offset = "0xA45728", VA = "0xA45728")]
	private void OnBadgeTargetChanged(GameObject gameObject)
	{
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0xA458D4", Offset = "0xA458D4", VA = "0xA458D4")]
	public BadgeEditView()
	{
	}
}
