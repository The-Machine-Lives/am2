using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x2000194")]
public class LeaderboardResultsView : CasualView
{
	[Token(Token = "0x400097D")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	public LeaderboardEntryView m_entryView;

	[Token(Token = "0x400097E")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	public LeaderboardTierView m_tierView;

	[Token(Token = "0x6000AF0")]
	[Address(RVA = "0x992FEC", Offset = "0x992FEC", VA = "0x992FEC")]
	public void Initialize(CasualViewController viewController, LeaderboardResultsMessage message)
	{
	}

	[Token(Token = "0x6000AF1")]
	[Address(RVA = "0x993850", Offset = "0x993850", VA = "0x993850")]
	public LeaderboardResultsView()
	{
	}
}
