using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x2000213")]
public class InboxPopup : PopupView
{
	[Token(Token = "0x4000BC9")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private AM2Button m_closeButton;

	[Token(Token = "0x4000BCA")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private bool m_playSoundOnClose;

	[Token(Token = "0x4000BCB")]
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	private BISoundEvents.EventKey m_closeSound;

	[Token(Token = "0x4000BCC")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private GameObject m_inboxMessagePrefab;

	[Token(Token = "0x4000BCD")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private BIScrollPanel m_scrollPanel;

	[Token(Token = "0x4000BCE")]
	[FieldOffset(Offset = "0xB0")]
	private readonly List<InboxMessageView> inboxMessageViews;

	[Token(Token = "0x4000BCF")]
	[FieldOffset(Offset = "0xB8")]
	private Vector3[] m_scrollViewCorners;

	[Token(Token = "0x6000E20")]
	[Address(RVA = "0x989998", Offset = "0x989998", VA = "0x989998")]
	public static InboxPopup Create(PopupView popupPrefab, Transform parent, CasualViewController controller, List<MessageItem> messages)
	{
		return null;
	}

	[Token(Token = "0x6000E21")]
	[Address(RVA = "0x989264", Offset = "0x989264", VA = "0x989264")]
	public void OnOpenTray(InboxMessageView openedInboxMessageView)
	{
	}

	[Token(Token = "0x6000E22")]
	[Address(RVA = "0x989864", Offset = "0x989864", VA = "0x989864")]
	public void OnMessageDelete(InboxMessageView deletedInboxMessageView)
	{
	}

	[Token(Token = "0x6000E23")]
	[Address(RVA = "0x9894B0", Offset = "0x9894B0", VA = "0x9894B0")]
	public float GetScrollViewBottom()
	{
		return default(float);
	}

	[Token(Token = "0x6000E24")]
	[Address(RVA = "0x9894F4", Offset = "0x9894F4", VA = "0x9894F4")]
	public float GetScrollViewTop()
	{
		return default(float);
	}

	[Token(Token = "0x6000E25")]
	[Address(RVA = "0x989A9C", Offset = "0x989A9C", VA = "0x989A9C")]
	public void Setup(List<MessageItem> messages)
	{
	}

	[Token(Token = "0x6000E26")]
	[Address(RVA = "0x989F58", Offset = "0x989F58", VA = "0x989F58", Slot = "9")]
	protected override void OnHideStart(Action onHideComplete)
	{
	}

	[Token(Token = "0x6000E27")]
	[Address(RVA = "0x98A040", Offset = "0x98A040", VA = "0x98A040", Slot = "11")]
	protected override void OnHideFinished(Action onHideComplete)
	{
	}

	[Token(Token = "0x6000E28")]
	[Address(RVA = "0x98A0A4", Offset = "0x98A0A4", VA = "0x98A0A4")]
	public InboxPopup()
	{
	}
}
