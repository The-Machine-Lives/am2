using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x2000197")]
public class MiniLeaderboardView : MonoBehaviour
{
	[Token(Token = "0x40009A5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Button m_openleaderboardButton;

	[Token(Token = "0x40009A6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject m_leaderboardViewTemplate;

	[Token(Token = "0x40009A7")]
	[FieldOffset(Offset = "0x28")]
	private LeaderboardView m_currentLeaderboardPopupView;

	[Token(Token = "0x40009A8")]
	[FieldOffset(Offset = "0x30")]
	private string m_title;

	[Token(Token = "0x40009A9")]
	[FieldOffset(Offset = "0x38")]
	private GlobalLeaderboard m_leaderboard;

	[Token(Token = "0x40009AA")]
	[FieldOffset(Offset = "0x40")]
	private CasualViewController m_viewController;

	[Token(Token = "0x6000B09")]
	[Address(RVA = "0x99D10C", Offset = "0x99D10C", VA = "0x99D10C")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0x99D1BC", Offset = "0x99D1BC", VA = "0x99D1BC")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6000B0B")]
	[Address(RVA = "0x99D2B4", Offset = "0x99D2B4", VA = "0x99D2B4")]
	public void Initialize(CasualViewController viewController, GlobalLeaderboard leaderboard, string title)
	{
	}

	[Token(Token = "0x6000B0C")]
	[Address(RVA = "0x99D414", Offset = "0x99D414", VA = "0x99D414")]
	private void OnClickedOpenLeaderboard()
	{
	}

	[Token(Token = "0x6000B0D")]
	[Address(RVA = "0x99D5BC", Offset = "0x99D5BC", VA = "0x99D5BC")]
	public MiniLeaderboardView()
	{
	}
}
