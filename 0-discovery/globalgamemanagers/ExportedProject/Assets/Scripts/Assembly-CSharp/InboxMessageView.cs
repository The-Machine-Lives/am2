using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Animation;
using Uken.Library.Inventory;
using Uken.Library.PlatformInbox;
using UnityEngine;

[Token(Token = "0x2000212")]
public class InboxMessageView : MonoBehaviour
{
	[Token(Token = "0x4000BB2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Text m_subjectText;

	[Token(Token = "0x4000BB3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Button m_trayButton;

	[Token(Token = "0x4000BB4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float m_openTraySize;

	[Token(Token = "0x4000BB5")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float m_closedTraySize;

	[Token(Token = "0x4000BB6")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float m_trayAnimDuration;

	[Token(Token = "0x4000BB7")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform m_trayParent;

	[Token(Token = "0x4000BB8")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject m_notificationIcon;

	[Token(Token = "0x4000BB9")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AM2TextWithHyperlink m_messageText;

	[Token(Token = "0x4000BBA")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AM2Button m_claimButton;

	[Token(Token = "0x4000BBB")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AM2Button m_deleteButton;

	[Token(Token = "0x4000BBC")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AM2Button m_minimizeButton;

	[Token(Token = "0x4000BBD")]
	[FieldOffset(Offset = "0x68")]
	private bool m_trayOpen;

	[Token(Token = "0x4000BBE")]
	[FieldOffset(Offset = "0x70")]
	private UkenAnimFloat m_trayAnim;

	[Token(Token = "0x4000BBF")]
	[FieldOffset(Offset = "0x78")]
	private float m_currentHeight;

	[Token(Token = "0x4000BC0")]
	[FieldOffset(Offset = "0x80")]
	private string m_uiPreferencesKey;

	[Token(Token = "0x4000BC1")]
	[FieldOffset(Offset = "0x88")]
	private InboxPopup m_parent;

	[Token(Token = "0x4000BC2")]
	[FieldOffset(Offset = "0x90")]
	private BIScrollPanel m_scrollPanel;

	[Token(Token = "0x4000BC3")]
	[FieldOffset(Offset = "0x98")]
	private MessageItem m_message;

	[Token(Token = "0x4000BC4")]
	[FieldOffset(Offset = "0xA0")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x4000BC5")]
	[FieldOffset(Offset = "0xA8")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000BC6")]
	[FieldOffset(Offset = "0xB0")]
	private PlatformInbox m_platformInbox;

	[Token(Token = "0x4000BC7")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_hasReward;

	[Token(Token = "0x4000BC8")]
	[FieldOffset(Offset = "0xC0")]
	private RectTransform m_rectTransform;

	[Token(Token = "0x6000E10")]
	[Address(RVA = "0x987E30", Offset = "0x987E30", VA = "0x987E30")]
	public void Initialize(InboxPopup inboxPopup, BIScrollPanel scrollPanel, MessageItem message)
	{
	}

	[Token(Token = "0x6000E11")]
	[Address(RVA = "0x9889D0", Offset = "0x9889D0", VA = "0x9889D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000E12")]
	[Address(RVA = "0x988BB4", Offset = "0x988BB4", VA = "0x988BB4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000E13")]
	[Address(RVA = "0x988D90", Offset = "0x988D90", VA = "0x988D90")]
	public void ResetUIPreferences()
	{
	}

	[Token(Token = "0x6000E14")]
	[Address(RVA = "0x988308", Offset = "0x988308", VA = "0x988308")]
	public void OpenTray(bool open, bool animate = true)
	{
	}

	[Token(Token = "0x6000E15")]
	[Address(RVA = "0x9893D4", Offset = "0x9893D4", VA = "0x9893D4")]
	private void OnTrayOpenComplete()
	{
	}

	[Token(Token = "0x6000E16")]
	[Address(RVA = "0x988D9C", Offset = "0x988D9C", VA = "0x988D9C")]
	private void StopTrayAnimation()
	{
	}

	[Token(Token = "0x6000E17")]
	[Address(RVA = "0x988DCC", Offset = "0x988DCC", VA = "0x988DCC")]
	private void OnTrayOpenStart()
	{
	}

	[Token(Token = "0x6000E18")]
	[Address(RVA = "0x989230", Offset = "0x989230", VA = "0x989230")]
	private void OnTrayCloseComplete()
	{
	}

	[Token(Token = "0x6000E19")]
	[Address(RVA = "0x988E40", Offset = "0x988E40", VA = "0x988E40")]
	private void OnUpdateViewHeight(float height)
	{
	}

	[Token(Token = "0x6000E1A")]
	[Address(RVA = "0x989540", Offset = "0x989540", VA = "0x989540")]
	private void ToggleTrayOpen()
	{
	}

	[Token(Token = "0x6000E1B")]
	[Address(RVA = "0x988614", Offset = "0x988614", VA = "0x988614")]
	private void UpdateUI(bool open)
	{
	}

	[Token(Token = "0x6000E1C")]
	[Address(RVA = "0x989664", Offset = "0x989664", VA = "0x989664")]
	private void ClaimReward()
	{
	}

	[Token(Token = "0x6000E1D")]
	[Address(RVA = "0x989800", Offset = "0x989800", VA = "0x989800")]
	private void DeleteMessage()
	{
	}

	[Token(Token = "0x6000E1E")]
	[Address(RVA = "0x98819C", Offset = "0x98819C", VA = "0x98819C")]
	private bool GetHasReward()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E1F")]
	[Address(RVA = "0x98992C", Offset = "0x98992C", VA = "0x98992C")]
	public InboxMessageView()
	{
	}
}
