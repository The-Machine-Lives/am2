using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Observe;
using UnityEngine;

[Token(Token = "0x200008D")]
public class BattleLogView : MonoBehaviour, IUkenObserver<BattleReport>
{
	[Token(Token = "0x400022A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<HighlightableItemView> m_battleLogs;

	[Token(Token = "0x400022B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_logShowInterval;

	[Token(Token = "0x400022C")]
	[FieldOffset(Offset = "0x24")]
	private float m_remainingShowWaitTime;

	[Token(Token = "0x400022D")]
	[FieldOffset(Offset = "0x28")]
	private UkenUnsubscriber<BattleReport> m_signalHandle;

	[Token(Token = "0x400022E")]
	[FieldOffset(Offset = "0x30")]
	private Queue<BattleReport> m_pendingBattleReports;

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xA461AC", Offset = "0xA461AC", VA = "0xA461AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xA462C0", Offset = "0xA462C0", VA = "0xA462C0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xA4631C", Offset = "0xA4631C", VA = "0xA4631C", Slot = "4")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CUken_002EFramework_002ECasual_002EBattleReport_003E_002EOnEmit(BattleReport battleLog)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0xA46444", Offset = "0xA46444", VA = "0xA46444")]
	private void Update()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xA462B4", Offset = "0xA462B4", VA = "0xA462B4")]
	private void ResetRemainingShowWaitTime()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xA46394", Offset = "0xA46394", VA = "0xA46394")]
	private void TryToShowBattleLog()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xA464D8", Offset = "0xA464D8", VA = "0xA464D8")]
	private void ShowBattleLog(BattleReport battleReport)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xA466EC", Offset = "0xA466EC", VA = "0xA466EC")]
	private void PlayBattleReportSound(EBattleReportType reportType)
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xA46724", Offset = "0xA46724", VA = "0xA46724")]
	public BattleLogView()
	{
	}
}
