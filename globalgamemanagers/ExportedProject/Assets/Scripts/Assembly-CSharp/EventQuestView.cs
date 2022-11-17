using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x20001AB")]
public class EventQuestView : QuestViewBase
{
	[Token(Token = "0x40009FE")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private ProgressBar m_totalTiersProgressBarCurrent;

	[Token(Token = "0x40009FF")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private ProgressBar m_totalTiersProgressBarActual;

	[Token(Token = "0x4000A00")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	private ProgressBar m_currentTierProgressBar;

	[Token(Token = "0x4000A01")]
	[FieldOffset(Offset = "0x140")]
	protected float m_refreshTime;

	[Token(Token = "0x4000A02")]
	[FieldOffset(Offset = "0x144")]
	protected float m_indexIncrement;

	[Token(Token = "0x4000A03")]
	[FieldOffset(Offset = "0x148")]
	protected bool m_eventQuestComplete;

	[Token(Token = "0x6000BA1")]
	[Address(RVA = "0x9C81B4", Offset = "0x9C81B4", VA = "0x9C81B4", Slot = "8")]
	public override void Initialize(CasualViewController viewController, Quest quest, EventQuest eventQuest, QuestPageView parentPageView)
	{
	}

	[Token(Token = "0x6000BA2")]
	[Address(RVA = "0x9C8318", Offset = "0x9C8318", VA = "0x9C8318")]
	private void Update()
	{
	}

	[Token(Token = "0x6000BA3")]
	[Address(RVA = "0x9C8728", Offset = "0x9C8728", VA = "0x9C8728", Slot = "9")]
	public override void RefreshProgress()
	{
	}

	[Token(Token = "0x6000BA4")]
	[Address(RVA = "0x9C88BC", Offset = "0x9C88BC", VA = "0x9C88BC")]
	public EventQuestView()
	{
	}
}
