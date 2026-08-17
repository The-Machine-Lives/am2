using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x20001AF")]
public class MiniQuestRewardSummaryView : MonoBehaviour
{
	[Token(Token = "0x4000A36")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Button m_openQuestRewardSummaryButton;

	[Token(Token = "0x4000A37")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject m_rewardSummaryViewTemplate;

	[Token(Token = "0x4000A38")]
	[FieldOffset(Offset = "0x28")]
	private CasualViewController m_viewController;

	[Token(Token = "0x4000A39")]
	[FieldOffset(Offset = "0x30")]
	private RewardSummaryView m_currentRewardSummaryView;

	[Token(Token = "0x4000A3A")]
	[FieldOffset(Offset = "0x38")]
	private Quest m_quest;

	[Token(Token = "0x4000A3B")]
	[FieldOffset(Offset = "0x40")]
	private QuestItem m_questItem;

	[Token(Token = "0x6000BC5")]
	[Address(RVA = "0x99D5C4", Offset = "0x99D5C4", VA = "0x99D5C4")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000BC6")]
	[Address(RVA = "0x99D674", Offset = "0x99D674", VA = "0x99D674")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6000BC7")]
	[Address(RVA = "0x99D76C", Offset = "0x99D76C", VA = "0x99D76C")]
	public void Initialize(CasualViewController viewController, Quest quest, QuestItem questItem)
	{
	}

	[Token(Token = "0x6000BC8")]
	[Address(RVA = "0x99D7F8", Offset = "0x99D7F8", VA = "0x99D7F8")]
	private void OnClickedOpenRewardSummaryButton()
	{
	}

	[Token(Token = "0x6000BC9")]
	[Address(RVA = "0x99D9A0", Offset = "0x99D9A0", VA = "0x99D9A0")]
	public MiniQuestRewardSummaryView()
	{
	}
}
