using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual.Leaderboards;
using Uken.Library.Inventory;
using Uken.Library.Observe;
using Uken.Library.ReferenceData;
using Uken.Library.UINotification;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004BB")]
	public class QuestController : DepotController, IInventoryProgressTracker
	{
		[Token(Token = "0x2000829")]
		public class QuestProgressLogData : CasualAnalogData
		{
			[Token(Token = "0x6003320")]
			[Address(RVA = "0xA808D8", Offset = "0xA808D8", VA = "0xA808D8")]
			public QuestProgressLogData(Quest quest, Task task, long delta, float taskQuantity)
			{
			}
		}

		[Token(Token = "0x200082A")]
		private class EventQuestItemState
		{
			[Token(Token = "0x400236C")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833050", Offset = "0x833050")]
			private int _003Cquantity_003Ek__BackingField;

			[Token(Token = "0x400236D")]
			[FieldOffset(Offset = "0x14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833060", Offset = "0x833060")]
			private bool _003CbasedOnActiveEvent_003Ek__BackingField;

			[Token(Token = "0x400236E")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833070", Offset = "0x833070")]
			private EventQuest _003CeventQuest_003Ek__BackingField;

			[Token(Token = "0x1700082A")]
			public int quantity
			{
				[Token(Token = "0x6003321")]
				[Address(RVA = "0xA7CC30", Offset = "0xA7CC30", VA = "0xA7CC30")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BC5C", Offset = "0x83BC5C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003322")]
				[Address(RVA = "0xA7CC28", Offset = "0xA7CC28", VA = "0xA7CC28")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BC6C", Offset = "0x83BC6C")]
				set
				{
				}
			}

			[Token(Token = "0x1700082B")]
			public bool basedOnActiveEvent
			{
				[Token(Token = "0x6003323")]
				[Address(RVA = "0xA7CC0C", Offset = "0xA7CC0C", VA = "0xA7CC0C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BC7C", Offset = "0x83BC7C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003324")]
				[Address(RVA = "0xA7CC14", Offset = "0xA7CC14", VA = "0xA7CC14")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BC8C", Offset = "0x83BC8C")]
				set
				{
				}
			}

			[Token(Token = "0x1700082C")]
			public EventQuest eventQuest
			{
				[Token(Token = "0x6003325")]
				[Address(RVA = "0xA7CC38", Offset = "0xA7CC38", VA = "0xA7CC38")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BC9C", Offset = "0x83BC9C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003326")]
				[Address(RVA = "0xA7CC20", Offset = "0xA7CC20", VA = "0xA7CC20")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BCAC", Offset = "0x83BCAC")]
				set
				{
				}
			}

			[Token(Token = "0x6003327")]
			[Address(RVA = "0xA7CC04", Offset = "0xA7CC04", VA = "0xA7CC04")]
			public EventQuestItemState()
			{
			}
		}

		[Token(Token = "0x400161E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int c_maxNumberOfTasks;

		[Token(Token = "0x400161F")]
		private const string c_questUINotificationKey = "quest";

		[Token(Token = "0x4001620")]
		private const string c_questCompleteLogEventName = "quest_complete";

		[Token(Token = "0x4001621")]
		private const string c_questSystemResourceName = "quest";

		[Token(Token = "0x4001622")]
		public const float c_eventRefreshDelay = 1f;

		[Token(Token = "0x4001623")]
		[FieldOffset(Offset = "0x20")]
		private RuntimeQuestsCache m_questsCache;

		[Token(Token = "0x4001624")]
		[FieldOffset(Offset = "0x28")]
		private RuntimeTasksCache m_tasksCache;

		[Token(Token = "0x4001625")]
		[FieldOffset(Offset = "0x30")]
		private QuestSystem m_questSystem;

		[Token(Token = "0x4001626")]
		[FieldOffset(Offset = "0x38")]
		private List<EventQuest> m_allEventQuests;

		[Token(Token = "0x4001627")]
		[FieldOffset(Offset = "0x40")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x4001628")]
		[FieldOffset(Offset = "0x48")]
		private RewardGroupsController m_rewardGroupController;

		[Token(Token = "0x4001629")]
		[FieldOffset(Offset = "0x50")]
		private Localizations m_localizationController;

		[Token(Token = "0x400162A")]
		[FieldOffset(Offset = "0x58")]
		private CasualAnalog m_analogController;

		[Token(Token = "0x400162B")]
		[FieldOffset(Offset = "0x60")]
		private FTUEController m_ftueController;

		[Token(Token = "0x400162C")]
		[FieldOffset(Offset = "0x68")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x400162D")]
		[FieldOffset(Offset = "0x70")]
		private AM2MessageController m_am2MessageController;

		[Token(Token = "0x400162E")]
		[FieldOffset(Offset = "0x78")]
		private UkenTimeController m_timeController;

		[Token(Token = "0x400162F")]
		[FieldOffset(Offset = "0x80")]
		private GlobalLeaderboardController m_globalLeaderboardController;

		[Token(Token = "0x4001630")]
		[FieldOffset(Offset = "0x88")]
		private LeaderboardController m_leaderboardController;

		[Token(Token = "0x4001631")]
		[FieldOffset(Offset = "0x90")]
		private UIAlertController m_uiAlertController;

		[Token(Token = "0x4001632")]
		[FieldOffset(Offset = "0x98")]
		private ConstructionController m_constructionController;

		[Token(Token = "0x4001633")]
		[FieldOffset(Offset = "0xA0")]
		private LoadoutController m_loadoutController;

		[Token(Token = "0x4001634")]
		[FieldOffset(Offset = "0xA8")]
		protected UkenObservable<Dictionary<string, Quest>> m_questProgressSignal;

		[Token(Token = "0x4001635")]
		[FieldOffset(Offset = "0xB0")]
		protected UINotification<QuestUIMessage> m_questUINotification;

		[Token(Token = "0x4001636")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_questsAllowedToTrack;

		[Token(Token = "0x4001637")]
		[FieldOffset(Offset = "0xB9")]
		private bool m_leaderboardEnded;

		[Token(Token = "0x4001638")]
		[FieldOffset(Offset = "0xBC")]
		private float m_eventRefreshTime;

		[Token(Token = "0x4001639")]
		[FieldOffset(Offset = "0xC0")]
		private UnlockItem m_questTabUnlockItem;

		[Token(Token = "0x170005FF")]
		public Dictionary<string, Quest> visiblyUnlockedQuests
		{
			[Token(Token = "0x6002398")]
			[Address(RVA = "0xA7AD44", Offset = "0xA7AD44", VA = "0xA7AD44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002399")]
		[Address(RVA = "0xA7ADA4", Offset = "0xA7ADA4", VA = "0xA7ADA4")]
		public static string GetUIPreferenceKey(Quest quest)
		{
			return null;
		}

		[Token(Token = "0x600239A")]
		[Address(RVA = "0xA7AE18", Offset = "0xA7AE18", VA = "0xA7AE18")]
		public QuestController(CasualDataStoreController dataController, InventoryController inventoryController, RewardGroupsController rewardGroupController, Localizations localizationController, CasualAnalog analogController, FTUEController ftueController, SharedDataCacheController dataCacheController, AM2MessageController am2MessageController, UkenTimeController timeController, GlobalLeaderboardController globalLeaderboardController, LeaderboardController leaderboardController, UIAlertController uiAlertController, ConstructionController constructionController, LoadoutController loadoutController)
		{
		}

		[Token(Token = "0x600239B")]
		[Address(RVA = "0xA7AFA4", Offset = "0xA7AFA4", VA = "0xA7AFA4")]
		public void SetAllowedToTrack()
		{
		}

		[Token(Token = "0x600239C")]
		[Address(RVA = "0xA7AFB0", Offset = "0xA7AFB0", VA = "0xA7AFB0")]
		public UkenUnsubscriber<QuestUIMessage> SubscribeToQuestUINotifications(IUkenObserver<QuestUIMessage> observer)
		{
			return null;
		}

		[Token(Token = "0x600239D")]
		[Address(RVA = "0xA7B024", Offset = "0xA7B024", VA = "0xA7B024")]
		public Dictionary<string, Quest> GetVisibleCompleteQuest()
		{
			return null;
		}

		[Token(Token = "0x600239E")]
		[Address(RVA = "0xA7B25C", Offset = "0xA7B25C", VA = "0xA7B25C")]
		public QuestItem FindOrCreateQuestItem(Quest quest)
		{
			return null;
		}

		[Token(Token = "0x600239F")]
		[Address(RVA = "0xA7B338", Offset = "0xA7B338", VA = "0xA7B338")]
		public EventQuestItem FindOrCreateEventQuestItem(EventQuest eventQuest)
		{
			return null;
		}

		[Token(Token = "0x60023A0")]
		[Address(RVA = "0xA7B3C8", Offset = "0xA7B3C8", VA = "0xA7B3C8")]
		public static long GetTaskQuantity(Task task, QuestItem questItem)
		{
			return default(long);
		}

		[Token(Token = "0x60023A1")]
		[Address(RVA = "0xA7B45C", Offset = "0xA7B45C", VA = "0xA7B45C")]
		public static long GetTaskQuantity(Task task, long repeatIndex)
		{
			return default(long);
		}

		[Token(Token = "0x60023A2")]
		[Address(RVA = "0xA7B4F4", Offset = "0xA7B4F4", VA = "0xA7B4F4")]
		public void SyncQuestUIMessageAndNotify(EQuestMessageSource source)
		{
		}

		[Token(Token = "0x60023A3")]
		[Address(RVA = "0xA7BA60", Offset = "0xA7BA60", VA = "0xA7BA60")]
		public void ConsumeQuestNotification()
		{
		}

		[Token(Token = "0x60023A4")]
		[Address(RVA = "0xA7BAFC", Offset = "0xA7BAFC", VA = "0xA7BAFC")]
		public void MarkViewedQuests()
		{
		}

		[Token(Token = "0x60023A5")]
		[Address(RVA = "0xA7BCF0", Offset = "0xA7BCF0", VA = "0xA7BCF0")]
		public string GetReadableQuestName(string questReference)
		{
			return null;
		}

		[Token(Token = "0x60023A6")]
		[Address(RVA = "0xA7BD78", Offset = "0xA7BD78", VA = "0xA7BD78")]
		public Dictionary<string, Quest> GetVisiblyUnlockedQuests()
		{
			return null;
		}

		[Token(Token = "0x60023A7")]
		[Address(RVA = "0xA7BD7C", Offset = "0xA7BD7C", VA = "0xA7BD7C", Slot = "8")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x60023A8")]
		[Address(RVA = "0xA7BDA4", Offset = "0xA7BDA4", VA = "0xA7BDA4", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x60023A9")]
		[Address(RVA = "0xA7C044", Offset = "0xA7C044", VA = "0xA7C044", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x60023AA")]
		[Address(RVA = "0xA7C074", Offset = "0xA7C074", VA = "0xA7C074")]
		private void MigrateOldEventQuestsSystem()
		{
		}

		[Token(Token = "0x60023AB")]
		[Address(RVA = "0xA7C238", Offset = "0xA7C238", VA = "0xA7C238")]
		private void DoHackyItemStateEnforcementToFixBugCausedByUnreadableCode()
		{
		}

		[Token(Token = "0x60023AC")]
		[Address(RVA = "0xA7CC40", Offset = "0xA7CC40", VA = "0xA7CC40")]
		private bool TryResetEventIterationNumber(EventQuest eventQuest)
		{
			return default(bool);
		}

		[Token(Token = "0x60023AD")]
		[Address(RVA = "0xA7CCDC", Offset = "0xA7CCDC", VA = "0xA7CCDC")]
		private void ResetEventQuestProgress(EventQuest eventQuest)
		{
		}

		[Token(Token = "0x60023AE")]
		[Address(RVA = "0xA7CFD0", Offset = "0xA7CFD0", VA = "0xA7CFD0", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x60023AF")]
		[Address(RVA = "0xA7D490", Offset = "0xA7D490", VA = "0xA7D490")]
		private bool IsQuestTabUnlocked()
		{
			return default(bool);
		}

		[Token(Token = "0x60023B0")]
		[Address(RVA = "0xA7D4F0", Offset = "0xA7D4F0", VA = "0xA7D4F0")]
		private void TrySetLeaderboardEndedFlag(EventQuest eventQuest)
		{
		}

		[Token(Token = "0x60023B1")]
		[Address(RVA = "0xA7D098", Offset = "0xA7D098", VA = "0xA7D098")]
		private void UpdateEventQuests()
		{
		}

		[Token(Token = "0x60023B2")]
		[Address(RVA = "0xA7D630", Offset = "0xA7D630", VA = "0xA7D630")]
		private void TryStartEvent(EventQuest eventQuest)
		{
		}

		[Token(Token = "0x60023B3")]
		[Address(RVA = "0xA7D544", Offset = "0xA7D544", VA = "0xA7D544")]
		private void TryStopEvent(EventQuest eventQuest)
		{
		}

		[Token(Token = "0x60023B4")]
		[Address(RVA = "0xA7DB10", Offset = "0xA7DB10", VA = "0xA7DB10")]
		private void LogProgressSoFarOnEventQuest(EventQuest eventQuest)
		{
		}

		[Token(Token = "0x60023B5")]
		[Address(RVA = "0xA7CB08", Offset = "0xA7CB08", VA = "0xA7CB08")]
		private void SetEventQuestActive(EventQuest eventQuest, bool active, bool forced = false)
		{
		}

		[Token(Token = "0x60023B6")]
		[Address(RVA = "0xA7E0CC", Offset = "0xA7E0CC", VA = "0xA7E0CC")]
		public void ResetTraits(List<string> itemsToReset, string sourceSink)
		{
		}

		[Token(Token = "0x60023B7")]
		[Address(RVA = "0xA7E81C", Offset = "0xA7E81C", VA = "0xA7E81C")]
		private void AddUpgradableItemsToList(Recipe recipe, List<Item> items)
		{
		}

		[Token(Token = "0x60023B8")]
		[Address(RVA = "0xA7EBD8", Offset = "0xA7EBD8", VA = "0xA7EBD8")]
		public void ShowQuestStartMessage(Quest quest, string rewardString)
		{
		}

		[Token(Token = "0x60023B9")]
		[Address(RVA = "0xA7D894", Offset = "0xA7D894", VA = "0xA7D894")]
		public void ShowEventStartMessage(EventQuest eventQuest, string rewardString)
		{
		}

		[Token(Token = "0x60023BA")]
		[Address(RVA = "0xA7DCF0", Offset = "0xA7DCF0", VA = "0xA7DCF0")]
		public void ShowEventEndMessage(EventQuest eventQuest, string rewardString)
		{
		}

		[Token(Token = "0x60023BB")]
		[Address(RVA = "0xA7EE54", Offset = "0xA7EE54", VA = "0xA7EE54")]
		public void ShowEventCompleteMessage(EventQuest eventQuest)
		{
		}

		[Token(Token = "0x60023BC")]
		[Address(RVA = "0xA7CE9C", Offset = "0xA7CE9C", VA = "0xA7CE9C")]
		private void ResetQuestItemTasks(Quest quest, QuestItem questItem)
		{
		}

		[Token(Token = "0x60023BD")]
		[Address(RVA = "0xA7D850", Offset = "0xA7D850", VA = "0xA7D850")]
		private string AwardEventQuestStartRewards(EventQuest eventQuest)
		{
			return null;
		}

		[Token(Token = "0x60023BE")]
		[Address(RVA = "0xA7DCAC", Offset = "0xA7DCAC", VA = "0xA7DCAC")]
		private string AwardEventQuestEndRewards(EventQuest eventQuest)
		{
			return null;
		}

		[Token(Token = "0x60023BF")]
		[Address(RVA = "0xA7EF28", Offset = "0xA7EF28", VA = "0xA7EF28")]
		private string AwardEventQuestRewards(EventQuest eventQuest, RewardGroup eventRewardGroup)
		{
			return null;
		}

		[Token(Token = "0x60023C0")]
		[Address(RVA = "0xA7F020", Offset = "0xA7F020", VA = "0xA7F020")]
		public string RewardsMessage(Dictionary<string, long> transaction)
		{
			return null;
		}

		[Token(Token = "0x60023C1")]
		[Address(RVA = "0xA7F244", Offset = "0xA7F244", VA = "0xA7F244")]
		public string FormatReward(ItemMinimalDetails itemMinimalDetails, long transactionAmount)
		{
			return null;
		}

		[Token(Token = "0x60023C2")]
		[Address(RVA = "0xA7F424", Offset = "0xA7F424", VA = "0xA7F424")]
		public ReadableRewardTypeInfo? GetReadableRewardTypeInfo(ItemMinimalDetails itemDetails, long quantity, bool granting = false)
		{
			return null;
		}

		[Token(Token = "0x60023C3")]
		[Address(RVA = "0xA7D37C", Offset = "0xA7D37C", VA = "0xA7D37C")]
		private void UpdateLeaderboardCompletion()
		{
		}

		[Token(Token = "0x60023C4")]
		[Address(RVA = "0xA7D5BC", Offset = "0xA7D5BC", VA = "0xA7D5BC")]
		public bool IsEventHappeningByTime(EventQuest eventQuest)
		{
			return default(bool);
		}

		[Token(Token = "0x60023C5")]
		[Address(RVA = "0xA7D7A4", Offset = "0xA7D7A4", VA = "0xA7D7A4")]
		public bool IsEventQuestActive(EventQuest eventQuest)
		{
			return default(bool);
		}

		[Token(Token = "0x60023C6")]
		[Address(RVA = "0xA7F770", Offset = "0xA7F770", VA = "0xA7F770")]
		public EventQuest GetEventQuest(string reference)
		{
			return null;
		}

		[Token(Token = "0x60023C7")]
		[Address(RVA = "0xA7F8C0", Offset = "0xA7F8C0", VA = "0xA7F8C0")]
		public UkenUnsubscriber<Dictionary<string, Quest>> SubscribeToQuestProgressUpdates(IUkenObserver<Dictionary<string, Quest>> observer, bool signalOnSubscribe)
		{
			return null;
		}

		[Token(Token = "0x60023C8")]
		[Address(RVA = "0xA7F938", Offset = "0xA7F938", VA = "0xA7F938")]
		private string GrantQuestStartRewards(Quest quest)
		{
			return null;
		}

		[Token(Token = "0x60023C9")]
		[Address(RVA = "0xA7FA84", Offset = "0xA7FA84", VA = "0xA7FA84", Slot = "10")]
		public void TrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
		{
		}

		[Token(Token = "0x60023CA")]
		[Address(RVA = "0xA7FF84", Offset = "0xA7FF84", VA = "0xA7FF84")]
		public Dictionary<string, long> CompleteQuest(Quest quest, QuestItem questItem, bool canShowMessageForEvent = false, bool excludeHiddenRewardsFromReturnedValue = false)
		{
			return null;
		}

		[Token(Token = "0x60023CB")]
		[Address(RVA = "0xA80854", Offset = "0xA80854", VA = "0xA80854")]
		public bool CanQuestBeRepeated(Quest quest, QuestItem questItem)
		{
			return default(bool);
		}

		[Token(Token = "0x60023CC")]
		[Address(RVA = "0xA804DC", Offset = "0xA804DC", VA = "0xA804DC")]
		public bool TryResetQuestForRepeat(Quest quest, QuestItem questItem)
		{
			return default(bool);
		}

		[Token(Token = "0x60023CD")]
		[Address(RVA = "0xA80690", Offset = "0xA80690", VA = "0xA80690")]
		private void ApplyTaskOverflowToNextQuest(QuestItem questItem, Quest quest, Dictionary<string, long> overflowTaskProgressByItem)
		{
		}

		[Token(Token = "0x60023CE")]
		[Address(RVA = "0xA8081C", Offset = "0xA8081C", VA = "0xA8081C")]
		private void SetEventQuestComplete(EventQuest eventQuest, bool complete)
		{
		}

		[Token(Token = "0x60023CF")]
		[Address(RVA = "0xA7E068", Offset = "0xA7E068", VA = "0xA7E068")]
		private void SetEventQuestComplete(EventQuestItem eventQuestItem, bool complete)
		{
		}

		[Token(Token = "0x60023D0")]
		[Address(RVA = "0xA7DF6C", Offset = "0xA7DF6C", VA = "0xA7DF6C")]
		private void LogQuestProgress(Quest quest, Task task, long delta, QuestItem questItem)
		{
		}
	}
}
