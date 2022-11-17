using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000193")]
public class LeaderboardEntryView : MonoBehaviour
{
	[Token(Token = "0x4000975")]
	private const int c_entityDataCount = 5;

	[Token(Token = "0x4000976")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Text m_rankText;

	[Token(Token = "0x4000977")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Text m_playerText;

	[Token(Token = "0x4000978")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AM2Text m_scoreText;

	[Token(Token = "0x4000979")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AM2Image m_borderImage;

	[Token(Token = "0x400097A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private BadgeSwapper m_badgeSwapper;

	[Token(Token = "0x400097B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TitleSwapper m_titleSwapper;

	[Token(Token = "0x400097C")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private BadgeBumperSwapper m_bumperSwapper;

	[Token(Token = "0x6000AED")]
	[Address(RVA = "0x992840", Offset = "0x992840", VA = "0x992840")]
	public void Initialize(int rank, string entityData, long score, bool isSelf)
	{
	}

	[Token(Token = "0x6000AEE")]
	[Address(RVA = "0x992974", Offset = "0x992974", VA = "0x992974")]
	public void ParseEntityData(string entityData, bool isSelf)
	{
	}

	[Token(Token = "0x6000AEF")]
	[Address(RVA = "0x992F9C", Offset = "0x992F9C", VA = "0x992F9C")]
	public LeaderboardEntryView()
	{
	}
}
