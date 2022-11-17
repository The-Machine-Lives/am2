using System;
using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.Inventory;
using Uken.Library.Observe;
using UnityEngine;

[Token(Token = "0x20001AE")]
public class QuestViewBase : MonoBehaviour, IUkenObserver<Dictionary<string, Quest>>
{
	[Token(Token = "0x4000A14")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected AM2Text m_questTitleText;

	[Token(Token = "0x4000A15")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected AM2Text m_description;

	[Token(Token = "0x4000A16")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AM2Button m_inProgressButton;

	[Token(Token = "0x4000A17")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected AM2Button m_collectButton;

	[Token(Token = "0x4000A18")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected GameObject m_taskItemViewTemplate;

	[Token(Token = "0x4000A19")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected Transform m_taskItemViewParent;

	[Token(Token = "0x4000A1A")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected AM2Text m_rewardTitleText;

	[Token(Token = "0x4000A1B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected GameObject m_rewardItemViewTemplate;

	[Token(Token = "0x4000A1C")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected Transform rewardItemViewParent;

	[Token(Token = "0x4000A1D")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected GameObject m_questViewTemplate;

	[Token(Token = "0x4000A1E")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected AM2Text m_stagesText;

	[Token(Token = "0x4000A1F")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	protected AM2Text m_timeLeftText;

	[Token(Token = "0x4000A20")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	protected AM2Text m_costText;

	[Token(Token = "0x4000A21")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	protected InfoPopupButton m_infoPopupButton;

	[Token(Token = "0x4000A22")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	protected GameObject eventQuestContainer;

	[Token(Token = "0x4000A23")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	protected GameObject descriptionContainer;

	[Token(Token = "0x4000A24")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	protected MiniLeaderboardView m_miniLeaderboardView;

	[Token(Token = "0x4000A25")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	protected GameObject m_completeText;

	[Token(Token = "0x4000A26")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	protected GameObject m_inProgressText;

	[Token(Token = "0x4000A27")]
	[FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x82586C", Offset = "0x82586C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x82586C", Offset = "0x82586C")]
	[SerializeField]
	protected MiniQuestRewardSummaryView m_miniQuestRewardSummaryView;

	[Token(Token = "0x4000A28")]
	[FieldOffset(Offset = "0xB8")]
	protected DateTime m_endDate;

	[Token(Token = "0x4000A29")]
	[FieldOffset(Offset = "0xC0")]
	protected QuestPageView m_parentPageView;

	[Token(Token = "0x4000A2A")]
	[FieldOffset(Offset = "0xC8")]
	protected QuestItem m_questItem;

	[Token(Token = "0x4000A2B")]
	[FieldOffset(Offset = "0xD0")]
	protected UkenUnsubscriber<Dictionary<string, Quest>> m_signalHandle;

	[Token(Token = "0x4000A2C")]
	[FieldOffset(Offset = "0xD8")]
	protected List<BasicItemView> m_taskList;

	[Token(Token = "0x4000A2D")]
	[FieldOffset(Offset = "0xE0")]
	protected List<RewardItemView> m_allRewardViews;

	[Token(Token = "0x4000A2E")]
	[FieldOffset(Offset = "0xE8")]
	protected Quest m_quest;

	[Token(Token = "0x4000A2F")]
	[FieldOffset(Offset = "0xF0")]
	protected EventQuest m_eventQuest;

	[Token(Token = "0x4000A30")]
	[FieldOffset(Offset = "0xF8")]
	protected CasualViewController m_viewController;

	[Token(Token = "0x4000A31")]
	[FieldOffset(Offset = "0x100")]
	protected QuestController m_questController;

	[Token(Token = "0x4000A32")]
	[FieldOffset(Offset = "0x108")]
	protected InventoryController m_inventoryController;

	[Token(Token = "0x4000A33")]
	[FieldOffset(Offset = "0x110")]
	protected Localizations m_localizationController;

	[Token(Token = "0x4000A34")]
	[FieldOffset(Offset = "0x118")]
	protected AM2TextDisplayController m_textDisplayController;

	[Token(Token = "0x4000A35")]
	[FieldOffset(Offset = "0x120")]
	protected bool m_initialized;

	[Token(Token = "0x6000BB5")]
	[Address(RVA = "0x9E9B08", Offset = "0x9E9B08", VA = "0x9E9B08", Slot = "5")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000BB6")]
	[Address(RVA = "0x9E9D3C", Offset = "0x9E9D3C", VA = "0x9E9D3C", Slot = "6")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000BB7")]
	[Address(RVA = "0x9E9E20", Offset = "0x9E9E20", VA = "0x9E9E20", Slot = "7")]
	public virtual void Cleanup()
	{
	}

	[Token(Token = "0x6000BB8")]
	[Address(RVA = "0x9E9F8C", Offset = "0x9E9F8C", VA = "0x9E9F8C", Slot = "8")]
	public virtual void Initialize(CasualViewController viewController, Quest quest, EventQuest eventQuest, QuestPageView parentPageView)
	{
	}

	[Token(Token = "0x6000BB9")]
	[Address(RVA = "0x9EB0BC", Offset = "0x9EB0BC", VA = "0x9EB0BC")]
	public void InitializeTaskViews()
	{
	}

	[Token(Token = "0x6000BBA")]
	[Address(RVA = "0x9EB1F4", Offset = "0x9EB1F4", VA = "0x9EB1F4")]
	public void InitializeRewardsSection()
	{
	}

	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0x9EB9DC", Offset = "0x9EB9DC", VA = "0x9EB9DC")]
	private void SetQuestLevelText(long currentQuestIteration, long maxRepeats)
	{
	}

	[Token(Token = "0x6000BBC")]
	[Address(RVA = "0x9EBD3C", Offset = "0x9EBD3C", VA = "0x9EBD3C")]
	private void HideEventQuestContainerIfEmpty()
	{
	}

	[Token(Token = "0x6000BBD")]
	[Address(RVA = "0x9EBE58", Offset = "0x9EBE58", VA = "0x9EBE58", Slot = "4")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CSystem_002ECollections_002EGeneric_002EDictionary_003CSystem_002EString_002CAM2_002EReferenceData_002EQuest_003E_003E_002EOnEmit(Dictionary<string, Quest> activeQuests)
	{
	}

	[Token(Token = "0x6000BBE")]
	[Address(RVA = "0x9EBF04", Offset = "0x9EBF04", VA = "0x9EBF04", Slot = "9")]
	public virtual void RefreshProgress()
	{
	}

	[Token(Token = "0x6000BBF")]
	[Address(RVA = "0x9EB034", Offset = "0x9EB034", VA = "0x9EB034")]
	private void OnQuestInProgress()
	{
	}

	[Token(Token = "0x6000BC0")]
	[Address(RVA = "0x9EC378", Offset = "0x9EC378", VA = "0x9EC378")]
	protected void OnTasksComplete()
	{
	}

	[Token(Token = "0x6000BC1")]
	[Address(RVA = "0x9EC400", Offset = "0x9EC400", VA = "0x9EC400")]
	public void OnCollectRewardsButtonPressed()
	{
	}

	[Token(Token = "0x6000BC2")]
	[Address(RVA = "0x9EC58C", Offset = "0x9EC58C", VA = "0x9EC58C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000BC3")]
	[Address(RVA = "0x9EB89C", Offset = "0x9EB89C", VA = "0x9EB89C")]
	private void RebuildRewardLayout()
	{
	}

	[Token(Token = "0x6000BC4")]
	[Address(RVA = "0x9EAF9C", Offset = "0x9EAF9C", VA = "0x9EAF9C")]
	public QuestViewBase()
	{
	}
}
