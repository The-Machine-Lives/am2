using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

[Token(Token = "0x2000195")]
public class LeaderboardTierView : MonoBehaviour
{
	[Token(Token = "0x400097F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Text m_tierText;

	[Token(Token = "0x4000980")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject m_rewardItemTemplate;

	[Token(Token = "0x4000981")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform m_rewardParent;

	[Token(Token = "0x4000982")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool m_showRewards;

	[Token(Token = "0x4000983")]
	[FieldOffset(Offset = "0x31")]
	[SerializeField]
	private bool m_showOnlyFirstRewards;

	[Token(Token = "0x6000AF2")]
	[Address(RVA = "0x993858", Offset = "0x993858", VA = "0x993858")]
	public static string GetLocalizedTierText(Localizations localizationController, int upperBound)
	{
		return null;
	}

	[Token(Token = "0x6000AF3")]
	[Address(RVA = "0x9933C4", Offset = "0x9933C4", VA = "0x9933C4")]
	public void Initialize(ScaleSetEntry scaleSetEntry, RewardGroup scaleSetRewardGroup)
	{
	}

	[Token(Token = "0x6000AF4")]
	[Address(RVA = "0x99390C", Offset = "0x99390C", VA = "0x99390C")]
	public LeaderboardTierView()
	{
	}
}
