using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using Uken.Library.Animation;
using UnityEngine;

[Token(Token = "0x20001AD")]
public class QuestView : QuestViewBase
{
	[Token(Token = "0x4000A09")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	protected DropdownButton m_trayButton;

	[Token(Token = "0x4000A0A")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	protected GameObject m_trayButtonNotification;

	[Token(Token = "0x4000A0B")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	protected RectTransform m_trayParent;

	[Token(Token = "0x4000A0C")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	protected bool m_trayOpen;

	[Token(Token = "0x4000A0D")]
	[FieldOffset(Offset = "0x144")]
	[SerializeField]
	protected float m_openTraySize;

	[Token(Token = "0x4000A0E")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	protected float m_closedTraySize;

	[Token(Token = "0x4000A0F")]
	[FieldOffset(Offset = "0x14C")]
	[SerializeField]
	protected float m_trayAnimDuration;

	[Token(Token = "0x4000A10")]
	[FieldOffset(Offset = "0x150")]
	private UkenAnimFloat m_trayAnim;

	[Token(Token = "0x4000A11")]
	[FieldOffset(Offset = "0x158")]
	protected float m_currentHeight;

	[Token(Token = "0x4000A12")]
	[FieldOffset(Offset = "0x160")]
	protected string m_uiPreferencesKey;

	[Token(Token = "0x4000A13")]
	[FieldOffset(Offset = "0x168")]
	protected float m_heightOfTextField;

	[Token(Token = "0x6000BAA")]
	[Address(RVA = "0x9E9A1C", Offset = "0x9E9A1C", VA = "0x9E9A1C", Slot = "5")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000BAB")]
	[Address(RVA = "0x9E9C84", Offset = "0x9E9C84", VA = "0x9E9C84", Slot = "6")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000BAC")]
	[Address(RVA = "0x9E9DFC", Offset = "0x9E9DFC", VA = "0x9E9DFC", Slot = "7")]
	public override void Cleanup()
	{
	}

	[Token(Token = "0x6000BAD")]
	[Address(RVA = "0x9E9E80", Offset = "0x9E9E80", VA = "0x9E9E80", Slot = "8")]
	public override void Initialize(CasualViewController viewController, Quest quest, EventQuest eventQuest, QuestPageView parentPageView)
	{
	}

	[Token(Token = "0x6000BAE")]
	[Address(RVA = "0x9EA730", Offset = "0x9EA730", VA = "0x9EA730")]
	private void CheckActiveChildrenAndScale()
	{
	}

	[Token(Token = "0x6000BAF")]
	[Address(RVA = "0x9EACEC", Offset = "0x9EACEC", VA = "0x9EACEC")]
	public void ToggleTrayOpen()
	{
	}

	[Token(Token = "0x6000BB0")]
	[Address(RVA = "0x9EACFC", Offset = "0x9EACFC", VA = "0x9EACFC")]
	public void OpenTray(bool open)
	{
	}

	[Token(Token = "0x6000BB1")]
	[Address(RVA = "0x9EA7CC", Offset = "0x9EA7CC", VA = "0x9EA7CC")]
	private void OnUpdateViewHeight(float height)
	{
	}

	[Token(Token = "0x6000BB2")]
	[Address(RVA = "0x9EAC28", Offset = "0x9EAC28", VA = "0x9EAC28")]
	private void OnDoneOpen()
	{
	}

	[Token(Token = "0x6000BB3")]
	[Address(RVA = "0x9EAF00", Offset = "0x9EAF00", VA = "0x9EAF00")]
	private void OnDoneClose()
	{
	}

	[Token(Token = "0x6000BB4")]
	[Address(RVA = "0x9EAF18", Offset = "0x9EAF18", VA = "0x9EAF18")]
	public QuestView()
	{
	}
}
